namespace Terrasoft.WebApp
{

	using Controls = Terrasoft.UI.WebControls.Controls;
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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: ColumnValueEditPageSchema

	/// <exclude/>
	public class ColumnValueEditPageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _label1;
		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return _label1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _columnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnEdit {
			get {
				return _columnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _exploreButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ExploreButton {
			get {
				return _exploreButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _columnValueEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ColumnValueEdit {
			get {
				return _columnValueEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _filterColumnValueEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit FilterColumnValueEdit {
			get {
				return _filterColumnValueEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _filterExploreButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton FilterExploreButton {
			get {
				return _filterExploreButton;
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

		public ColumnValueEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ColumnValueEditPageSchema(ColumnValueEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			RealUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			Name = "ColumnValueEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 460;
			Height = 400;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateColumnValueEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateLabel1());
			ControlLayout1.InsertItem(1, CreateColumnEdit());
			ColumnEdit.InsertItem(0, CreateExploreButton());
			MainControlLayout.InsertItem(1, CreateColumnValueEdit());
			MainControlLayout.InsertItem(2, CreateFilterColumnValueEdit());
			FilterColumnValueEdit.InsertItem(0, CreateFilterExploreButton());
			Controls.AddAt(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateSpacer1());
			ControlLayout2.InsertItem(1, CreateOkButton());
			ControlLayout2.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateColumnValueEditPageEventsProcessSchema() {
			var schema = new ColumnValueEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("9f28914b-f020-456a-a561-0181344c075f");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("1a531002-12b8-4fdd-8883-c4417f1a18e7");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_label1.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,253,132,16);
			_label1.Width = System.Web.UI.WebControls.Unit.Pixel(53);
			_label1.Margins = "3 0 0";
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateExploreButton() {
			_exploreButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_exploreButton.UId = new Guid("ba06007e-64a0-4346-abbb-a7111c65519c");
			_exploreButton.Name = "ExploreButton";
			_exploreButton.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_exploreButton.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_exploreButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_exploreButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_exploreButton.Tag = "";
			_exploreButton.Image = new ControlImage {};
			return _exploreButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateColumnEdit() {
			_columnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_columnEdit.UId = new Guid("92ffa715-3953-48f4-ab68-8948a311d51a");
			_columnEdit.Name = "ColumnEdit";
			_columnEdit.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_columnEdit.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_columnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_columnEdit.Tag = "";
			_columnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnEdit.Image = new ControlImage {};
			_columnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.Top;
			_columnEdit.AlignedByCaption = false;
			_columnEdit.Enabled = false;
			_columnEdit.Required = true;
			return _columnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("58cec14d-e94d-47a5-8c0e-8c6ff5cd4de9");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_controlLayout1.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateColumnValueEdit() {
			_columnValueEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_columnValueEdit.UId = new Guid("eeee1d85-830f-4ffb-80d6-84f25aca7084");
			_columnValueEdit.Name = "ColumnValueEdit";
			_columnValueEdit.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_columnValueEdit.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_columnValueEdit.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_columnValueEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_columnValueEdit.Tag = "";
			_columnValueEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnValueEdit.DataValueTypeUId = new Guid("84ed6865-9692-4c98-aaed-4d15b96a95c2");
			_columnValueEdit.Image = new ControlImage {};
			_columnValueEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _columnValueEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateFilterExploreButton() {
			_filterExploreButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_filterExploreButton.UId = new Guid("7fe4cdf3-e64b-47fe-998c-15b7cc488ff4");
			_filterExploreButton.Name = "FilterExploreButton";
			_filterExploreButton.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_filterExploreButton.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_filterExploreButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterExploreButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_filterExploreButton.Tag = "";
			_filterExploreButton.Image = new ControlImage {};
			return _filterExploreButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateFilterColumnValueEdit() {
			_filterColumnValueEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_filterColumnValueEdit.UId = new Guid("63f2ee2c-c7fe-418b-a13c-fdcd9900460e");
			_filterColumnValueEdit.Name = "FilterColumnValueEdit";
			_filterColumnValueEdit.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_filterColumnValueEdit.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_filterColumnValueEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterColumnValueEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_filterColumnValueEdit.Tag = "";
			_filterColumnValueEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_filterColumnValueEdit.Image = new ControlImage {};
			_filterColumnValueEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterColumnValueEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("f8233628-6747-414f-a427-563f59fb9c06");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			_spacer1.UId = new Guid("9e5191d2-8385-4c3f-8d79-a31cb5f6dc6b");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_spacer1.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("6f3fb390-b4d1-45fc-ac8b-651277f90056");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_okButton.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("8c0b6fb7-0f80-4a75-bdd9-f8798c6a8633");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_cancelButton.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("0b628e5d-c477-4b1c-8003-322d5ecb4d55");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_controlLayout2.ModifiedInSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new ColumnValueEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ColumnValueEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ColumnValueEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ColumnValueEditPageEventsProcess

	/// <exclude/>
	public class ColumnValueEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ColumnValueEditPageSchemaUserControl
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

		public ColumnValueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ColumnValueEditPageEventsProcess";
			SchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
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

		public virtual Guid RowId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual Object ColumnExplorer {
			get;
			set;
		}

		public virtual bool IsColumnExplorerCreated {
			get;
			set;
		}

		public virtual Guid SchemaId {
			get;
			set;
		}

		public virtual string MetaPath {
			get;
			set;
		}

		public virtual Guid DataValueTypeId {
			get;
			set;
		}

		public virtual bool IsParameterExplorerCreated {
			get;
			set;
		}

		public virtual Object ParameterExplorer {
			get;
			set;
		}

		public virtual Guid ProcessSchemaId {
			get;
			set;
		}

		public virtual string ManagerName {
			get;
			set;
		}

		public virtual Guid FilterSchemaId {
			get;
			set;
		}

		public virtual string FilterMetaPath {
			get;
			set;
		}

		public virtual bool IsFilterColumnExplorerCreated {
			get;
			set;
		}

		public virtual Object FilterColumnExplorer {
			get;
			set;
		}

		public virtual Guid EditElementUId {
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
					SchemaElementUId = new Guid("8542a1ef-d7b7-4675-9cb7-ff708b279e64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _exploreButtonClickStartMessage;
		public ProcessFlowElement ExploreButtonClickStartMessage {
			get {
				return _exploreButtonClickStartMessage ?? (_exploreButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ExploreButtonClickStartMessage",
					SchemaElementUId = new Guid("8943e47f-9e3d-43ab-b2e7-993d57cdb95f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _exploreButtonClickScriptTask;
		public ProcessScriptTask ExploreButtonClickScriptTask {
			get {
				return _exploreButtonClickScriptTask ?? (_exploreButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExploreButtonClickScriptTask",
					SchemaElementUId = new Guid("862d00f7-c3e7-4194-a181-7288462edd1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ExploreButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("888907e5-75f0-4b96-a446-1d1f1d4d83ce"),
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
					SchemaElementUId = new Guid("9e31b15c-eabf-43b1-9552-c46819db00ed"),
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
					SchemaElementUId = new Guid("7c307280-a378-4706-906e-b5a87f72b4a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("4a372fd9-c7f3-4534-acbc-04aa4456e9ef"),
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
					SchemaElementUId = new Guid("a5316e1f-e4c5-4498-baab-dc1b77e8596f"),
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
					SchemaElementUId = new Guid("203013d4-842a-4e10-b181-3ad549498c50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
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
					SchemaElementUId = new Guid("46afb3ed-1885-4b3d-b670-49fb41e9bc31"),
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
					SchemaElementUId = new Guid("41e6d34d-949e-4e23-9486-19de072d436e"),
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
					SchemaElementUId = new Guid("01559df3-70fb-4415-8ddb-44c0a1c7f9e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("85f7af6c-5530-4aa2-9396-978ccd5dd9b6"),
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
					SchemaElementUId = new Guid("e0425c2a-2fe5-42d8-bc1d-35ce16fa9960"),
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
					SchemaElementUId = new Guid("d5674c69-2eff-4f0e-9ac7-87772cd3ef44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("0ed4a868-4516-4db4-8fb8-63eeddf6c673"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _filterExploreButtonClick_StartMessage;
		public ProcessFlowElement FilterExploreButtonClick_StartMessage {
			get {
				return _filterExploreButtonClick_StartMessage ?? (_filterExploreButtonClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FilterExploreButtonClick_StartMessage",
					SchemaElementUId = new Guid("c7455555-f1ce-4349-8132-071883a454d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _filterExploreButtonClick_ScriptTask;
		public ProcessScriptTask FilterExploreButtonClick_ScriptTask {
			get {
				return _filterExploreButtonClick_ScriptTask ?? (_filterExploreButtonClick_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FilterExploreButtonClick_ScriptTask",
					SchemaElementUId = new Guid("8e255378-6924-4c66-a15b-dfadda00c4ac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FilterExploreButtonClick_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("7dec0d5b-3318-4587-ad8f-f292329cdbd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _filterColumnValueEditChange_StartMessage;
		public ProcessFlowElement FilterColumnValueEditChange_StartMessage {
			get {
				return _filterColumnValueEditChange_StartMessage ?? (_filterColumnValueEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FilterColumnValueEditChange_StartMessage",
					SchemaElementUId = new Guid("7cd4a2d3-3cc0-4468-b2eb-7a3a463cd887"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _filterColumnValueEditChange_ScriptTask;
		public ProcessScriptTask FilterColumnValueEditChange_ScriptTask {
			get {
				return _filterColumnValueEditChange_ScriptTask ?? (_filterColumnValueEditChange_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FilterColumnValueEditChange_ScriptTask",
					SchemaElementUId = new Guid("d90f92d0-ceef-4c23-89ca-ab99f3487d78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FilterColumnValueEditChange_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("29c8b00f-024a-41aa-ad6c-54b70d7900df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnEditChangeStartMessage;
		public ProcessFlowElement ColumnEditChangeStartMessage {
			get {
				return _columnEditChangeStartMessage ?? (_columnEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnEditChangeStartMessage",
					SchemaElementUId = new Guid("8d70fcd2-73a2-4adb-b428-87c790aaa381"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _columnEditChangeScriptTask;
		public ProcessScriptTask ColumnEditChangeScriptTask {
			get {
				return _columnEditChangeScriptTask ?? (_columnEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ColumnEditChangeScriptTask",
					SchemaElementUId = new Guid("cf2aa621-447b-49d3-b874-ec6b046d2ad9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("ad2df983-ab79-41bf-9ae0-5e5cef7fec55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValueEditChangeStartMessage;
		public ProcessFlowElement ColumnValueEditChangeStartMessage {
			get {
				return _columnValueEditChangeStartMessage ?? (_columnValueEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValueEditChangeStartMessage",
					SchemaElementUId = new Guid("4ff7390e-5287-4499-9fca-f3912a6ed3a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _columnValueEditChangeScriptTask;
		public ProcessScriptTask ColumnValueEditChangeScriptTask {
			get {
				return _columnValueEditChangeScriptTask ?? (_columnValueEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ColumnValueEditChangeScriptTask",
					SchemaElementUId = new Guid("454bea31-0df1-403b-986a-4b067d70ea18"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnValueEditChangeScriptTaskExecute,
				});
			}
		}

		private LocalizableString _warningMessage;
		public LocalizableString WarningMessage {
			get {
				return _warningMessage ?? (_warningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarningMessage.Value"));
			}
		}

		private LocalizableString _entityMappingDisplayValuePrefix;
		public LocalizableString EntityMappingDisplayValuePrefix {
			get {
				return _entityMappingDisplayValuePrefix ?? (_entityMappingDisplayValuePrefix = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EntityMappingDisplayValuePrefix.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ExploreButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ExploreButtonClickStartMessage };
			FlowElements[ExploreButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ExploreButtonClickScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[FilterExploreButtonClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterExploreButtonClick_StartMessage };
			FlowElements[FilterExploreButtonClick_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterExploreButtonClick_ScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[FilterColumnValueEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterColumnValueEditChange_StartMessage };
			FlowElements[FilterColumnValueEditChange_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterColumnValueEditChange_ScriptTask };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[ColumnEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnEditChangeStartMessage };
			FlowElements[ColumnEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnEditChangeScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ColumnValueEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditChangeStartMessage };
			FlowElements[ColumnValueEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ExploreButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ExploreButtonClickScriptTask");
						break;
					case "ExploreButtonClickScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "OkButtonClickScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "EventSubProcess7":
						break;
					case "FilterExploreButtonClick_StartMessage":
						e.Context.QueueTasks.Enqueue("FilterExploreButtonClick_ScriptTask");
						break;
					case "FilterExploreButtonClick_ScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "FilterColumnValueEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("FilterColumnValueEditChange_ScriptTask");
						break;
					case "FilterColumnValueEditChange_ScriptTask":
						break;
					case "EventSubProcess9":
						break;
					case "ColumnEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ColumnEditChangeScriptTask");
						break;
					case "ColumnEditChangeScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "ColumnValueEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ColumnValueEditChangeScriptTask");
						break;
					case "ColumnValueEditChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ExploreButtonClickStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("FilterExploreButtonClick_StartMessage");
			ActivatedEventElements.Add("FilterColumnValueEditChange_StartMessage");
			ActivatedEventElements.Add("ColumnEditChangeStartMessage");
			ActivatedEventElements.Add("ColumnValueEditChangeStartMessage");
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
				case "ExploreButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExploreButtonClickStartMessage";
					result = ExploreButtonClickStartMessage.Execute(context);
					break;
				case "ExploreButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExploreButtonClickScriptTask";
					result = ExploreButtonClickScriptTask.Execute(context, ExploreButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess2":
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
				case "EventSubProcess3":
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
				case "EventSubProcess5":
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
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "FilterExploreButtonClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterExploreButtonClick_StartMessage";
					result = FilterExploreButtonClick_StartMessage.Execute(context);
					break;
				case "FilterExploreButtonClick_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterExploreButtonClick_ScriptTask";
					result = FilterExploreButtonClick_ScriptTask.Execute(context, FilterExploreButtonClick_ScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "FilterColumnValueEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterColumnValueEditChange_StartMessage";
					result = FilterColumnValueEditChange_StartMessage.Execute(context);
					break;
				case "FilterColumnValueEditChange_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterColumnValueEditChange_ScriptTask";
					result = FilterColumnValueEditChange_ScriptTask.Execute(context, FilterColumnValueEditChange_ScriptTaskExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnEditChangeStartMessage";
					result = ColumnEditChangeStartMessage.Execute(context);
					break;
				case "ColumnEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnEditChangeScriptTask";
					result = ColumnEditChangeScriptTask.Execute(context, ColumnEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValueEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditChangeStartMessage";
					result = ColumnValueEditChangeStartMessage.Execute(context);
					break;
				case "ColumnValueEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditChangeScriptTask";
					result = ColumnValueEditChangeScriptTask.Execute(context, ColumnValueEditChangeScriptTaskExecute);
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
				case "FilterColumnExplorer":
					FilterColumnExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsFilterColumnExplorerCreated":
					IsFilterColumnExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "FilterMetaPath":
					FilterMetaPath = reader.GetValue<System.String>();
				break;
				case "FilterSchemaId":
					FilterSchemaId = reader.GetValue<System.Guid>();
				break;
				case "ManagerName":
					ManagerName = reader.GetValue<System.String>();
				break;
				case "ProcessSchemaId":
					ProcessSchemaId = reader.GetValue<System.Guid>();
				break;
				case "ParameterExplorer":
					ParameterExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsParameterExplorerCreated":
					IsParameterExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "DataValueTypeId":
					DataValueTypeId = reader.GetValue<System.Guid>();
				break;
				case "MetaPath":
					MetaPath = reader.GetValue<System.String>();
				break;
				case "SchemaId":
					SchemaId = reader.GetValue<System.Guid>();
				break;
				case "IsColumnExplorerCreated":
					IsColumnExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "ColumnExplorer":
					ColumnExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "RowId":
					RowId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ExploreButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenColumnExplorer(SchemaId);
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			FillControlValues();
			SetControlsEnabled();
			Page.ColumnValueEdit.CustomConfig.Add(new ConfigItem("hideMappingTool", "true"));
			Page.OkButton.AjaxEvents.Click.CausesValidation = true;
			/*
			if (string.IsNullOrEmpty(MetaPath)) {
				return true;
			}
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
			var schemaColumn = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
			DataValueTypeId = schemaColumn.DataValueType.UId;
			SetFilterDataValueTypeId();
			*/
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			if (IsColumnExplorerCreated) {
				CreateColumnExplorer();
			}
			if (IsParameterExplorerCreated) {
				CreateParameterExplorer();
			}
			if (IsFilterColumnExplorerCreated) {
				FilterCreateColumnExplorer();
			}
			//Page.ColumnValueEdit.AjaxEvents.ShowMappingWindow.Event += ColumnValueEdit_ShowMappingWindow;
			if (FilterSchemaId != Guid.Empty){
				Page.ScriptManager.AddScript(string.Format("{0}.samplingSchemaUId='{1}'", Page.ColumnValueEdit.ClientID, FilterSchemaId));
			}
			/*
			if (DataValueTypeId != Guid.Empty) {
				var parameterEditControls = new Dictionary<string, string>(1);
				parameterEditControls.Add(Page.ColumnValueEdit.ClientID, DataValueTypeId.ToString());
				SetFilterDataValueTypeIdParameterEdit(parameterEditControls);
			}
			*/
			/*
			if (FilterSchemaId != Guid.Empty){
				Page.ScriptManager.AddScript(string.Format("{0}.samplingSchemaUId='{1}'", Page.ColumnValueEdit.ClientID, FilterSchemaId));
			}
			*/
			//Page.ColumnValueEdit.DataProvider.DataValueTypeUId = DataValueTypeId;
			return true;
		}

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var columnValue = CreateColumnValue();
			if (columnValue == null) {
				return true;
			}
			
			string serializedRow = Json.Serialize(columnValue);
			var sb = new StringBuilder(@"(function() {
				var treeGrid = window.Ext.getCmp('");
			sb.Append(Page.GetParameterValue("treeGridId"));
			sb.Append(@"');
				if (!treeGrid) {
					return;
				}
			
				var dataSource = treeGrid.dataSource;
				if (dataSource) {");
			
			if (IsNew) {
				sb.Append(@"
					var row = dataSource.createRow(");
				sb.Append(serializedRow);	
				sb.Append(@");
					dataSource.rows.insert(0, row.getPrimaryColumnValue(), row);
					dataSource.setActiveRow(row);
					dataSource.fireEvent('inserted', dataSource, row, { });");
			} else {
				sb.Append(@"
					var columns = ");
				sb.Append(serializedRow);	
				sb.Append(@";
					var row = dataSource.getRow(columns[dataSource.getPrimaryColumnName()]);
					for (var columnName in columns) {
						row.setColumnValue(columnName, columns[columnName]);
					}
					dataSource.fireEvent('rowloaded', dataSource, [row.columns], { });");
			}
			
			sb.Append(@"
				}
			})();");
			var insertedRowKey = (string)Page.GetParameterValue("insertedRowKey");
			UserConnection.SessionData[insertedRowKey] = sb.ToString();
			Page.AddScript("window.close();");
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool FilterExploreButtonClick_ScriptTaskExecute(ProcessExecutingContext context) {
			FilterOpenColumnExplorer(FilterSchemaId);
			return true;
		}

		public virtual bool FilterColumnValueEditChange_ScriptTaskExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(FilterMetaPath) && !string.IsNullOrEmpty(Page.FilterColumnValueEdit.Text)) {
				Page.ColumnValueEdit.Text = string.Empty;
			}
			return true;
		}

		public virtual bool ColumnEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			SetControlsEnabled();
			return true;
		}

		public virtual bool ColumnValueEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.ColumnValueEdit.ParameterValue != null && !string.IsNullOrEmpty(Page.ColumnValueEdit.ParameterValue.Value)) {
				Page.FilterColumnValueEdit.Text = string.Empty;
				FilterMetaPath = string.Empty;
			}
			return true;
		}

		public virtual Dictionary<string, ProcessSchemaParameterValue> GetColumnValues() {
			object contextKey = Page.GetParameterValue("contextKey");
			if (contextKey == null) {
				return null;
			}
			return UserConnection.SessionData[contextKey.ToString()] as Dictionary<string, ProcessSchemaParameterValue>;
		}

		public virtual StructureExplorer GetColumnExplorer() {
			if (!IsColumnExplorerCreated) {
				CreateColumnExplorer();
			}
			
			return (StructureExplorer)ColumnExplorer;
		}

		public virtual void ColumnExplorer_EditComplete(object sender, AjaxEventArgs e) {
			var column = (JObject)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			Page.ColumnEdit.Text = column.Value<string>("caption");
			MetaPath = column.Value<string>("metaPath");
			Page.ColumnValueEdit.Clear();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
			var schemaColumn = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
			Page.ColumnValueEdit.ParameterValue = new ProcessSchemaParameterValue() {
				DataValueType = schemaColumn.DataValueType,
				ReferenceSchemaUId = schemaColumn.ReferenceSchemaUId,
				SchemaUId = ProcessSchemaId,
				SchemaManagerName = ManagerName
			};
			DataValueTypeId = schemaColumn.DataValueType.UId;
			/*
			Page.ColumnValueEdit.DataValueTypeUId = DataValueTypeId;
			Page.ColumnValueEdit.SetDataValueTypeUId(schemaColumn.ReferenceSchemaUId);
			string dataValueTypeUId = schemaColumn.DataValueType.UId.ToString();
			var parameterEditControls = new Dictionary<string, string>(1);
			parameterEditControls.Add(Page.ColumnValueEdit.ClientID, dataValueTypeUId);
			SetFilterDataValueTypeIdParameterEdit(parameterEditControls);
			*/
		}

		public virtual void OpenColumnExplorer(Guid schemaUId) {
			if (schemaUId == Guid.Empty) {
				return;
			}
			var columnExplorer = GetColumnExplorer();
			if (columnExplorer == null) {
				return;
			}
			columnExplorer.ShowEditWindow(schemaUId, MetaPath);
		}

		public virtual void CreateColumnExplorer() {
			var columnExplorer = new StructureExplorer(Page.MainControlLayout, "ColumnExplorer", false, true, null);
			columnExplorer.AjaxEvents.EditComplete.Event += ColumnExplorer_EditComplete;
			if (!IsColumnExplorerCreated) {
				columnExplorer.Register();
			}
			ColumnExplorer = columnExplorer;
			IsColumnExplorerCreated = true;
		}

		public virtual object CreateColumnValue() {
			var columnValues = GetColumnValues();
			if (columnValues == null) {
				return null;
			}
			if (IsNew && columnValues.ContainsKey(MetaPath)) {
				ShowWarning();
				return null;
			}
			ProcessSchemaParameterValue paramValue;
			string displayValue;
			if (string.IsNullOrEmpty(Page.FilterColumnValueEdit.Text)) {
				paramValue = Page.ColumnValueEdit.ParameterValue;
				if (!string.IsNullOrEmpty(paramValue.Value) && paramValue.Value.Contains("SamplingColumnValue.")) {
					paramValue.Source = ProcessSchemaParameterValueSource.SamplingEntityMapping;
					paramValue.ReferenceSchemaUId = FilterSchemaId;
				} else if ((paramValue.Source == ProcessSchemaParameterValueSource.ConstValue
						|| paramValue.Source == ProcessSchemaParameterValueSource.Script)
						&& SchemaId != Guid.Empty && !string.IsNullOrEmpty(MetaPath)) {
					EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
					EntitySchemaColumn schemaColumn = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
					if (schemaColumn.DataValueType.IsLookup) {
						paramValue.ReferenceSchemaUId = schemaColumn.ReferenceSchemaUId;
					} else if (paramValue.Source != ProcessSchemaParameterValueSource.Script) {
						DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
						IEnumerable<DataValueTypeManagerItem> dataValueTypeItems = dataValueTypeManager.GetItems();
						Guid dataValueTypeUId = schemaColumn.DataValueTypeUId;
						DataValueTypeManagerItem dataValueTypeItem = null;
						foreach (DataValueTypeManagerItem item in dataValueTypeItems) {
							if (item.UId == dataValueTypeUId) {
								dataValueTypeItem = item;
								break;
							}
						}
						if (dataValueTypeItem.GroupName == "Dates") {
							string dateTimeFormat;
							if (dataValueTypeItem.Name == "Date") {
								dateTimeFormat = "yyyy-MM-dd";
							} else if (dataValueTypeItem.Name == "Time") {
								dateTimeFormat = "HH:MM:ss";
							} else {
								dateTimeFormat = "yyyy-MM-dd HH:mm:ss";
							}
							paramValue.DisplayValue = DateTime.Parse(paramValue.Value).ToString(dateTimeFormat);
						} else if (dataValueTypeItem.GroupName == "Numbers"
								|| dataValueTypeItem.GroupName == "Strings"
								|| dataValueTypeItem.Name == "Boolean"
								|| dataValueTypeItem.Name == "Color") {
							paramValue.DisplayValue = paramValue.Value;
						}
					}
				}
				if (string.IsNullOrEmpty(paramValue.DisplayValue)) {
					paramValue.DisplayValue = Page.ColumnValueEdit.Text;
				}
				displayValue = paramValue.DisplayValue;
			} else {
				paramValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.EntityMapping,
					DisplayValue = Page.FilterColumnValueEdit.Text,
					Value = FilterMetaPath
				};
				displayValue = EntityMappingDisplayValuePrefix + paramValue.DisplayValue;  
			}
			if (paramValue.Source == ProcessSchemaParameterValueSource.Mapping ||
					paramValue.Source == ProcessSchemaParameterValueSource.EntityMapping) {
				paramValue.MetaPath = paramValue.Value;
			}
			columnValues[MetaPath] = paramValue;
			UserConnection.SessionData[Page.GetParameterValue("contextKey").ToString()] = columnValues;
			var columnValue = new { 
				Id = RowId,
				MetaPath = MetaPath,
				Name = Page.ColumnEdit.Text,
				Value = displayValue
			};
			return columnValue;
		}

		public virtual void CreateParameterExplorer() {
			var parameterExplorer = new SchemaStructureExplorer(Page.MainControlLayout, "ParameterExplorer", false, false);
			parameterExplorer.ManagerName = ManagerName;
			parameterExplorer.IncludedDataValueTypes.Clear();
			if (!(SchemaId == Guid.Empty || string.IsNullOrEmpty(MetaPath))) {
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
				var schemaColumn = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
				parameterExplorer.IncludedDataValueTypes.Add(schemaColumn.DataValueType.UId, schemaColumn.ReferenceSchemaUId);
				if (schemaColumn.DataValueType.IsLookup) {
					parameterExplorer.IncludedDataValueTypes.Add(UserConnection.DataValueTypeManager.GetItemByName("Guid").UId, Guid.Empty);
				}
			}
			if (!IsParameterExplorerCreated) {
				parameterExplorer.Register();
			}
			ParameterExplorer = parameterExplorer;
			IsParameterExplorerCreated = true;
		}

		public virtual SchemaStructureExplorer GetParameterExplorer() {
			if (!IsParameterExplorerCreated) {
				CreateParameterExplorer();
			}
			return (SchemaStructureExplorer)ParameterExplorer;
		}

		public virtual void OpenParameterExplorer(string metapath) {
			if (ProcessSchemaId == Guid.Empty) {
				return;
			}
			var parameterExplorer = GetParameterExplorer();
			if (parameterExplorer == null) {
				return;
			}
			parameterExplorer.ShowEditWindow(ProcessSchemaId, metapath,	EditElementUId);
		}

		public virtual void ColumnValueEdit_ShowMappingWindow(object sender, AjaxEventArgs e) {
			var paremeterExplorer = GetParameterExplorer();
			Page.ScriptManager.AddScript(String.Format("{0}.un('editcomplete', {1}.onStructureExplorerWindowEditComplete, {1});",
				paremeterExplorer.ClientID, Page.ColumnValueEdit.ClientID));
			Page.ScriptManager.AddScript(String.Format("{0}.on('editcomplete', {1}.onStructureExplorerWindowEditComplete, {1});",
				paremeterExplorer.ClientID, Page.ColumnValueEdit.ClientID));
			/*
			var parameter = (ProcessSchemaParameterValueEdit)sender;
			OpenParameterExplorer((parameter.Value as ProcessSchemaParameterValue).Value);
			*/
		}

		public virtual void ShowWarning() {
			Page.BaseMessagePanel.AddMessage(new LocalizableString(
				"Terrasoft.WebApp.Common", "Message.Warning").ToString(),
				WarningMessage.ToString(), MessageType.Warning);
		}

		public virtual void FilterOpenColumnExplorer(Guid schemaUId) {
			if (schemaUId == Guid.Empty) {
				return;
			}
			
			var columnExplorer = FilterGetColumnExplorer();
			if (columnExplorer == null) {
				return;
			}
			
			columnExplorer.ShowEditWindow(schemaUId, FilterGetMetaPath());
		}

		public virtual string FilterGetMetaPath() {
			string result = null;
			
			if (!string.IsNullOrEmpty(FilterMetaPath)) {
				result = FilterMetaPath;
			}
			else {
				if (!string.IsNullOrEmpty(MetaPath)) {	
					var columnMap = GetColumnValues();
					if (columnMap.ContainsKey(MetaPath)) {
						result = columnMap[MetaPath].Value;
					}
				}
			}
			return result;
		}

		public virtual StructureExplorer FilterGetColumnExplorer() {
			if (!IsFilterColumnExplorerCreated) {
				FilterCreateColumnExplorer();
			}
			
			return (StructureExplorer)FilterColumnExplorer;
		}

		public virtual void FilterCreateColumnExplorer() {
			var columnExplorer = new StructureExplorer(
				Page.MainControlLayout, "ColumnValueExplorer", false, false, null);
			columnExplorer.AjaxEvents.EditComplete.Event += FilterColumnExplorer_EditComplete;
			columnExplorer.IncludedDataValueTypes.Clear();
			columnExplorer.IsShowSystemColumns = false;
			if (!(SchemaId == Guid.Empty || String.IsNullOrEmpty(MetaPath))) {
				columnExplorer.IsShowSystemColumns = true;
				columnExplorer.ExcludeDataValueTypes = new string[1] {"Color"};
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
				var schemaColumn = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
				Collection<DataValueType> compatibleDataValueTypes =
					GetCompatibleDataValueTypes(schemaColumn.DataValueType);
				foreach (DataValueType compatibleDataValueType in compatibleDataValueTypes) {
					columnExplorer.IncludedDataValueTypes.Add(compatibleDataValueType.UId, schemaColumn.ReferenceSchemaUId);	
				}
			}
			if (!IsFilterColumnExplorerCreated) {
				columnExplorer.Register();
			}
			FilterColumnExplorer = columnExplorer;
			IsFilterColumnExplorerCreated = true;
		}

		public virtual void FilterColumnExplorer_EditComplete(object sender, AjaxEventArgs e) {
			var column = (JObject)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			Page.FilterColumnValueEdit.Text = column.Value<string>("caption");
			FilterMetaPath = column.Value<string>("metaPath");
			Page.ColumnValueEdit.Clear();
			if (!string.IsNullOrEmpty(MetaPath)) {
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
				var schemaColumn = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
				Page.ColumnValueEdit.ParameterValue = new ProcessSchemaParameterValue() {
					DataValueType = schemaColumn.DataValueType,
					ReferenceSchemaUId = schemaColumn.ReferenceSchemaUId,
					SchemaManagerName = ManagerName,
					SchemaUId = ProcessSchemaId
				};
			}
		}

		public virtual void SetControlsEnabled() {
			bool isEnabled = !string.IsNullOrEmpty(Page.ColumnEdit.Text);
			Page.ColumnValueEdit.Enabled = isEnabled;
			Page.FilterColumnValueEdit.Enabled = isEnabled;
			if (!isEnabled) {
				Page.ColumnValueEdit.Clear();
				Page.FilterColumnValueEdit.Clear();
			}
			bool canChangeColumn;
			object canChangeColumnParameter = Page.GetParameterValue("canChangeColumn");
			if (canChangeColumnParameter != null) {
				Boolean.TryParse(canChangeColumnParameter.ToString(), out canChangeColumn);
			} else {
				canChangeColumn = false;
			}
			Page.ColumnEdit.Enabled = canChangeColumn;
			Page.ExploreButton.Enabled = canChangeColumn;
		}

		public virtual void FillControlValues() {
			var columnValues = GetColumnValues();
			if (columnValues == null) {
				return;
			}
			object schemaIdParam = Page.GetParameterValue("schemaId");
			if (schemaIdParam != null) {
				SchemaId = new Guid(schemaIdParam.ToString());
			}
			object processSchemaIdParam = Page.GetParameterValue("processSchemaId");
			if (processSchemaIdParam != null) {
				ProcessSchemaId = new Guid(processSchemaIdParam.ToString());
			}
			object filterSchemaIdParam = Page.GetParameterValue("filterSchemaId");
			if (filterSchemaIdParam != null) {
				FilterSchemaId = new Guid(filterSchemaIdParam.ToString());
				Page.FilterColumnValueEdit.Hidden = false;
			} else {
				Page.FilterColumnValueEdit.Hidden = true;
			}
			object managerNameParam = Page.GetParameterValue("managerName");
			if (managerNameParam != null) {
				ManagerName = managerNameParam.ToString();
			}
			object metaPathParam = Page.GetParameterValue("metaPath");
			if (metaPathParam != null) {
				MetaPath = metaPathParam.ToString();
			}
			object editElementUId = Page.GetParameterValue("editElementId");
			if (editElementUId != null) {
				EditElementUId = new Guid(editElementUId.ToString());
			}
			object rowIdParam = Page.GetParameterValue("rowId");
			IsNew = rowIdParam == null;
			if (rowIdParam != null) {
				RowId = new Guid(rowIdParam.ToString());
			} else {
				RowId = Guid.NewGuid();
			}
			if (!IsNew && !string.IsNullOrEmpty(MetaPath)) {
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SchemaId);
				EntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(MetaPath);
				Page.ColumnEdit.Text = column.Caption.ToString();
				ProcessSchemaParameterValue parameterValue = columnValues[MetaPath];
				ProcessSchemaParameterValue columnValueEditValue = Page.ColumnValueEdit.ParameterValue;
				if (parameterValue.Source == ProcessSchemaParameterValueSource.EntityMapping) {
					Page.FilterColumnValueEdit.Text = parameterValue.DisplayValue;
				} else {
					columnValueEditValue = parameterValue;
				}
				columnValueEditValue.DataValueType = column.DataValueType;
				columnValueEditValue.ReferenceSchemaUId = column.ReferenceSchemaUId;
				columnValueEditValue.SchemaManagerName = ManagerName;
				columnValueEditValue.SchemaUId = ProcessSchemaId;
				Page.ColumnValueEdit.Value = columnValueEditValue;
			}
		}

		public virtual int GetIndexInDataValueTypeNameArray(string dataValueTypeName, string [] dataValueTypeNames) {
			for (int i = 0; i < dataValueTypeNames.Length; i++) {
				if (dataValueTypeNames[i] == dataValueTypeName) {
					return i;
				}
			}
			return -1;
		}

		public virtual Collection<DataValueType> GetCompatibleDataValueTypes(DataValueType dataValueType) {
			Guid dataValueTypeUId = dataValueType.UId;
			string dataValueTypeName = dataValueType.Name;
			bool shouldAddDataValueType = true;
			DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
			var compatibleDataValueTypes = new Collection<DataValueType>();
			if (dataValueTypeName == "Guid") {
				compatibleDataValueTypes.Add(dataValueTypeManager.GetInstanceByName("Lookup"));
			} else if (dataValueTypeName == "Lookup") {
				compatibleDataValueTypes.Add(dataValueTypeManager.GetInstanceByName("Guid"));
			} else {
				DataValueTypeManagerItem dataValueTypeManagerItem = dataValueTypeManager.GetItemByUId(dataValueTypeUId);
				string dataValueTypeGroupName = dataValueTypeManagerItem.GroupName;
				if (dataValueTypeGroupName == "Strings") {
					var stringDataValueTypes = new string[] {
						"ShortText",
						"MediumText",
						"LongText",
						"HugeText",
						"MaxSizeText",
						"Text"
					};
					int topIndex = GetIndexInDataValueTypeNameArray(dataValueTypeName, stringDataValueTypes);
					if (topIndex != -1) {
						Collection<DataValueType> dataValueTypesInGroup =
							dataValueTypeManager.GetDataValueTypesByGroupName(dataValueTypeGroupName);
						foreach (DataValueType dataValueTypeInGroup in dataValueTypesInGroup) {
							int index = GetIndexInDataValueTypeNameArray(dataValueTypeInGroup.Name,
								stringDataValueTypes);
							if (index > -1 && index <= topIndex) {
								compatibleDataValueTypes.Add(dataValueTypeInGroup);								
							}
						}
						shouldAddDataValueType = false;
					}
				}
			}
			if (shouldAddDataValueType) {
				compatibleDataValueTypes.Add(dataValueType);
			}
			return compatibleDataValueTypes;
		}

		public virtual void SetFilterDataValueTypeIdParameterEdit(Dictionary<string, string> parameterEditControls) {
			if (parameterEditControls == null || parameterEditControls.Count == 0) {
				return;
			}
			var sb = new StringBuilder(128 * parameterEditControls.Count);
			foreach (KeyValuePair<string, string> parameterEditControl in parameterEditControls) {
				sb.Append("(function(){");
				sb.Append(parameterEditControl.Key);
				sb.Append(".setFilterDataValueTypeId = function(dataValueTypeUId){");
				sb.Append("var dataProvider=this.dataProvider;var filters=dataProvider.filters;");
				sb.Append("for(var i=0;i<filters.length;i++){var filter=filters[i];");
				sb.Append("if(filter[0]=='dataValueTypeId'){");
				sb.Append("filter[1]=dataValueTypeUId;break;}}};");
				sb.Append(parameterEditControl.Key);
				sb.Append(".setFilterDataValueTypeId(\"");
				sb.Append(parameterEditControl.Value.ToLower());
				sb.Append("\");");
			}
			sb.Append("})();");
			Page.AddScript(sb.ToString());
		}

		public virtual void SetFilterDataValueTypeId() {
			if (DataValueTypeId == Guid.Empty) {
				return;
			}
			var parameterEditControls = new Dictionary<string, string>(1);
			parameterEditControls.Add(Page.ColumnValueEdit.ClientID, DataValueTypeId.ToString());
			SetFilterDataValueTypeIdParameterEdit(parameterEditControls);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ExploreButtonClick":
							if (ActivatedEventElements.Contains("ExploreButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ExploreButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
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
					case "FilterExploreButtonClick":
							if (ActivatedEventElements.Contains("FilterExploreButtonClick_StartMessage")) {
							context.QueueTasks.Enqueue("FilterExploreButtonClick_StartMessage");
						}
						break;
					case "FilterColumnValueEditChange":
							if (ActivatedEventElements.Contains("FilterColumnValueEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("FilterColumnValueEditChange_StartMessage");
						}
						break;
					case "ColumnEditChange":
							if (ActivatedEventElements.Contains("ColumnEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ColumnEditChangeStartMessage");
						}
						break;
					case "ColumnValueEditChange":
							if (ActivatedEventElements.Contains("ColumnValueEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ColumnValueEditChangeStartMessage");
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
			if (FilterColumnExplorer != null) {
				if (FilterColumnExplorer.GetType().IsSerializable ||
					FilterColumnExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FilterColumnExplorer", FilterColumnExplorer, null);
				}
			}
			if (!HasMapping("IsFilterColumnExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFilterColumnExplorerCreated", IsFilterColumnExplorerCreated, false);
			}
			if (!HasMapping("FilterMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterMetaPath", FilterMetaPath, null);
			}
			if (!HasMapping("FilterSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterSchemaId", FilterSchemaId, Guid.Empty);
			}
			if (!HasMapping("ManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ManagerName", ManagerName, null);
			}
			if (!HasMapping("ProcessSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ProcessSchemaId", ProcessSchemaId, Guid.Empty);
			}
			if (ParameterExplorer != null) {
				if (ParameterExplorer.GetType().IsSerializable ||
					ParameterExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ParameterExplorer", ParameterExplorer, null);
				}
			}
			if (!HasMapping("IsParameterExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsParameterExplorerCreated", IsParameterExplorerCreated, false);
			}
			if (!HasMapping("DataValueTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DataValueTypeId", DataValueTypeId, Guid.Empty);
			}
			if (!HasMapping("MetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MetaPath", MetaPath, null);
			}
			if (!HasMapping("SchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaId", SchemaId, Guid.Empty);
			}
			if (!HasMapping("IsColumnExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnExplorerCreated", IsColumnExplorerCreated, false);
			}
			if (ColumnExplorer != null) {
				if (ColumnExplorer.GetType().IsSerializable ||
					ColumnExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnExplorer", ColumnExplorer, null);
				}
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("RowId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RowId", RowId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ColumnValueEditPageEventsProcess

	/// <exclude/>
	public class ColumnValueEditPageEventsProcess : ColumnValueEditPageEventsProcess<Terrasoft.WebApp.ColumnValueEditPageSchemaUserControl>
	{

		public ColumnValueEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ColumnValueEditPageSchemaUserControl

	/// <exclude/>
	public partial class ColumnValueEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Label1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Label1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ExploreButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ExploreButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit ColumnValueEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("ColumnValueEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit FilterColumnValueEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("FilterColumnValueEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton FilterExploreButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("FilterExploreButton", true);
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
			ColumnEdit.AjaxEvents.Change.Event += ColumnEditChange;
			ExploreButton.AjaxEvents.Click.Event += ExploreButtonClick;
			ColumnValueEdit.AjaxEvents.Change.Event += ColumnValueEditChange;
			FilterColumnValueEdit.AjaxEvents.Change.Event += FilterColumnValueEditChange;
			FilterExploreButton.AjaxEvents.Click.Event += FilterExploreButtonClick;
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ColumnEdit.AjaxEvents.Change.Event -= ColumnEditChange;
			ExploreButton.AjaxEvents.Click.Event -= ExploreButtonClick;
			ColumnValueEdit.AjaxEvents.Change.Event -= ColumnValueEditChange;
			FilterColumnValueEdit.AjaxEvents.Change.Event -= FilterColumnValueEditChange;
			FilterExploreButton.AjaxEvents.Click.Event -= FilterExploreButtonClick;
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ColumnValueEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ColumnValueEditPageEventsProcess(UserConnection);
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

		public virtual void ColumnEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ColumnEditChange");
		}

		public virtual void ExploreButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ExploreButtonClick");
		}

		public virtual void ColumnValueEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ColumnValueEditChange");
		}

		public virtual void FilterColumnValueEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FilterColumnValueEditChange");
		}

		public virtual void FilterExploreButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("FilterExploreButtonClick");
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
			SchemaName = "ColumnValueEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ColumnValueEditPageEventsProcessSchema

	/// <exclude/>
	public class ColumnValueEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ColumnValueEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ColumnValueEditPageEventsProcessSchema(ColumnValueEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ColumnValueEditPageEventsProcess";
			UId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6");
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

		protected virtual ProcessSchemaParameter CreateRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9125b94d-ed12-41f2-b5d4-e2d8625e100d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"RowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1df5372d-6b26-4377-aed9-a68dcd07c66c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("15f8ae54-40a7-4ed9-8cd5-c81b5a50422b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ColumnExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("66a62e9b-c5f3-4fcf-b80c-9c2faaefb3f9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"IsColumnExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("067399c7-80fc-4e56-8dfb-e2c30e8b055a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"SchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e810e71c-5813-47ac-8f79-eb72003fd431"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"MetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataValueTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("20332513-6279-434b-9ee5-2a08858897b1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"DataValueTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsParameterExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6b190105-eba3-4a22-bedb-ff431a72077b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"IsParameterExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParameterExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("41b5de8f-2fd4-42f0-a2fd-6a7ba32a64e6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ParameterExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bde86c8b-8061-4605-b431-79aa264dc7fb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ProcessSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("311ee0f3-0f12-4fca-88aa-6f69f2587dd2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("507af982-9820-4ddd-85df-92435fc52866"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4b53a27a-44b7-4fc3-9fda-4cd4b816114f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterColumnExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7dc056a6-9434-4501-9fa4-15173b55850d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"IsFilterColumnExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterColumnExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("603605cd-221a-423d-b3b0-63ea2371c16d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterColumnExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditElementUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fd3994e5-df18-48d9-8e50-f04765c6846a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EditElementUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateRowIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateColumnExplorerParameter());
			Parameters.Add(CreateIsColumnExplorerCreatedParameter());
			Parameters.Add(CreateSchemaIdParameter());
			Parameters.Add(CreateMetaPathParameter());
			Parameters.Add(CreateDataValueTypeIdParameter());
			Parameters.Add(CreateIsParameterExplorerCreatedParameter());
			Parameters.Add(CreateParameterExplorerParameter());
			Parameters.Add(CreateProcessSchemaIdParameter());
			Parameters.Add(CreateManagerNameParameter());
			Parameters.Add(CreateFilterSchemaIdParameter());
			Parameters.Add(CreateFilterMetaPathParameter());
			Parameters.Add(CreateIsFilterColumnExplorerCreatedParameter());
			Parameters.Add(CreateFilterColumnExplorerParameter());
			Parameters.Add(CreateEditElementUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaLane schemaLane6 = CreateLane6Lane();
			schemaLaneSet1.Lanes.Add(schemaLane6);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaStartMessageEvent explorebuttonclickstartmessage = CreateExploreButtonClickStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(explorebuttonclickstartmessage);
			ProcessSchemaScriptTask explorebuttonclickscripttask = CreateExploreButtonClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(explorebuttonclickscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent filterexplorebuttonclick_startmessage = CreateFilterExploreButtonClick_StartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(filterexplorebuttonclick_startmessage);
			ProcessSchemaScriptTask filterexplorebuttonclick_scripttask = CreateFilterExploreButtonClick_ScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(filterexplorebuttonclick_scripttask);
			ProcessSchemaStartMessageEvent filtercolumnvalueeditchange_startmessage = CreateFilterColumnValueEditChange_StartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(filtercolumnvalueeditchange_startmessage);
			ProcessSchemaScriptTask filtercolumnvalueeditchange_scripttask = CreateFilterColumnValueEditChange_ScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(filtercolumnvalueeditchange_scripttask);
			ProcessSchemaStartMessageEvent columneditchangestartmessage = CreateColumnEditChangeStartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(columneditchangestartmessage);
			ProcessSchemaScriptTask columneditchangescripttask = CreateColumnEditChangeScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(columneditchangescripttask);
			ProcessSchemaStartMessageEvent columnvalueeditchangestartmessage = CreateColumnValueEditChangeStartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(columnvalueeditchangestartmessage);
			ProcessSchemaScriptTask columnvalueeditchangescripttask = CreateColumnValueEditChangeScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(columnvalueeditchangescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWarningMessageLocalizableString());
			LocalizableStrings.Add(CreateEntityMappingDisplayValuePrefixLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWarningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fbec3d4-3158-4d86-9447-c440484bce35"),
				Name = "WarningMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEntityMappingDisplayValuePrefixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7550d148-8f14-48b1-9996-9c65a1cbc4ac"),
				Name = "EntityMappingDisplayValuePrefix",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c50ad9d5-0598-4fc5-94b4-e775472da6fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8943e47f-9e3d-43ab-b2e7-993d57cdb95f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("862d00f7-c3e7-4194-a181-7288462edd1d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4af185d8-a3e9-489d-9a08-e823a899b8ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(174, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e31b15c-eabf-43b1-9552-c46819db00ed"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c307280-a378-4706-906e-b5a87f72b4a4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("2de51f4f-7def-480b-afcb-aabf9ef2d05a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(180, 268),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5316e1f-e4c5-4498-baab-dc1b77e8596f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("203013d4-842a-4e10-b181-3ad549498c50"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("769d3468-8f00-476d-85ed-44e1e24f6a20"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("41e6d34d-949e-4e23-9486-19de072d436e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01559df3-70fb-4415-8ddb-44c0a1c7f9e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("fb361b3b-d6ef-4c48-ba0a-a47ac080c706"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e0425c2a-2fe5-42d8-bc1d-35ce16fa9960"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5674c69-2eff-4f0e-9ac7-87772cd3ef44"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("88c72c13-bc68-41c9-8254-9a55ec5ed5fc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7455555-f1ce-4349-8132-071883a454d2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8e255378-6924-4c66-a15b-dfadda00c4ac"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("b7a56141-14db-4489-b5ea-9f2e35a2715e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7cd4a2d3-3cc0-4468-b2eb-7a3a463cd887"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d90f92d0-ceef-4c23-89ca-ab99f3487d78"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("02436744-07a5-499e-91b1-916b8e1cd1f1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8d70fcd2-73a2-4adb-b428-87c790aaa381"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf2aa621-447b-49d3-b874-ec6b046d2ad9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("6288d713-81fe-4d7d-ad6e-6ed715d94dd9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ff7390e-5287-4499-9fca-f3912a6ed3a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("454bea31-0df1-403b-986a-4b067d70ea18"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1126, 1180),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cfc7d647-5e3c-4e96-b563-b9e6d1e9b9e3"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"Lane1",
				Position = new Point(29, 662),
				Size = new Size(1097, 329),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("d09704cf-de56-4c9e-a9be-4d64ae792b1f"),
				ContainerItemIndex = 6,
				ContainerUId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				CreatedInOwnerSchemaUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 996),
				Size = new Size(1097, 184),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("0e541292-492a-4131-865b-1141cd84f48e"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"Lane3",
				Position = new Point(29, 499),
				Size = new Size(1097, 158),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("a6c68cc0-8863-4c04-b7e5-a091f79bf47d"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"Lane4",
				Position = new Point(29, 328),
				Size = new Size(1097, 166),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("c67a8530-4eb9-4230-91f6-8816c517a0b6"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"Lane5",
				Position = new Point(29, 164),
				Size = new Size(1097, 159),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaLane CreateLane6Lane() {
			ProcessSchemaLane schemaLane6 = new ProcessSchemaLane(this) {
				UId = new Guid("59e8d317-9255-4746-b295-401f54921b01"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a6440982-79e3-42d4-b031-49a4422fcca6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"Lane6",
				Position = new Point(29, 0),
				Size = new Size(1097, 159),
				UseBackgroundMode = false
			};
			return schemaLane6;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8542a1ef-d7b7-4675-9cb7-ff708b279e64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cfc7d647-5e3c-4e96-b563-b9e6d1e9b9e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 141),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateExploreButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8943e47f-9e3d-43ab-b2e7-993d57cdb95f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8542a1ef-d7b7-4675-9cb7-ff708b279e64"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ExploreButtonClick",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ExploreButtonClickStartMessage",
				Position = new Point(28, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateExploreButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("862d00f7-c3e7-4194-a181-7288462edd1d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8542a1ef-d7b7-4675-9cb7-ff708b279e64"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ExploreButtonClickScriptTask",
				Position = new Point(147, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,205,115,206,207,41,205,205,115,173,40,200,201,47,74,45,210,8,78,206,72,205,77,244,76,209,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,26,81,148,240,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("888907e5-75f0-4b96-a446-1d1f1d4d83ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d09704cf-de56-4c9e-a9be-4d64ae792b1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 12),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9e31b15c-eabf-43b1-9552-c46819db00ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("888907e5-75f0-4b96-a446-1d1f1d4d83ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7c307280-a378-4706-906e-b5a87f72b4a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("888907e5-75f0-4b96-a446-1d1f1d4d83ce"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,81,205,78,195,48,12,62,83,169,239,16,245,212,78,40,123,0,196,97,43,29,234,97,108,210,54,238,166,241,186,176,52,169,18,103,80,33,222,157,180,101,80,56,218,159,191,31,219,43,169,84,110,52,89,163,158,65,121,116,105,118,23,71,59,164,239,166,43,52,188,40,20,67,123,11,53,242,220,40,223,232,97,184,16,146,120,238,29,153,38,140,31,101,205,23,66,164,26,223,216,88,150,132,77,154,156,164,192,53,180,173,212,245,222,24,149,220,178,132,172,199,36,251,145,220,156,151,158,200,104,190,120,133,247,226,130,154,28,207,149,172,206,60,7,239,208,5,51,41,128,164,209,236,158,245,220,64,156,207,226,72,30,89,234,200,6,97,94,186,39,175,212,198,22,77,75,93,186,70,130,45,208,41,203,216,71,28,221,88,36,111,245,149,249,25,71,23,176,44,184,72,234,118,213,9,27,8,178,7,135,54,164,214,88,245,62,188,152,160,107,208,33,165,229,143,72,165,118,4,186,194,101,119,40,69,58,194,165,232,23,233,37,221,80,143,7,10,146,83,135,158,188,155,192,203,238,154,241,55,108,80,121,0,130,225,180,251,174,197,82,4,145,169,38,255,3,243,16,97,252,213,74,42,66,251,143,59,124,108,54,143,163,233,246,95,109,61,248,155,239,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4a372fd9-c7f3-4534-acbc-04aa4456e9ef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d09704cf-de56-4c9e-a9be-4d64ae792b1f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a5316e1f-e4c5-4498-baab-dc1b77e8596f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a372fd9-c7f3-4534-acbc-04aa4456e9ef"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("203013d4-842a-4e10-b181-3ad549498c50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a372fd9-c7f3-4534-acbc-04aa4456e9ef"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,146,203,110,194,48,16,69,215,32,241,15,46,27,28,138,76,89,211,84,66,33,84,89,32,69,74,31,203,202,194,46,184,74,236,104,226,240,16,226,223,235,216,244,145,16,209,109,87,150,61,51,119,206,220,177,120,71,56,42,2,149,150,153,12,247,121,170,128,67,0,156,106,206,60,116,236,117,59,238,82,79,192,222,180,215,61,245,186,194,22,199,20,104,198,53,135,43,245,23,57,117,137,133,72,77,236,10,197,57,225,10,203,120,28,211,53,39,46,248,66,211,146,135,76,104,50,251,160,251,112,203,165,46,72,178,81,187,37,205,115,33,215,175,66,50,181,35,54,128,110,125,212,168,122,187,72,157,58,82,135,145,172,54,60,163,17,67,55,62,122,44,5,35,97,150,235,131,87,113,90,134,100,5,34,215,75,42,205,5,200,140,49,247,128,11,13,70,144,44,20,100,84,227,254,241,238,68,10,154,229,169,121,116,146,207,17,243,7,199,201,105,208,31,161,214,105,130,84,24,226,104,62,66,117,18,239,203,132,161,227,156,83,77,109,213,211,33,231,23,160,214,209,45,5,148,127,111,197,136,7,74,106,80,105,129,124,36,249,14,205,197,74,11,37,41,28,238,29,247,8,185,243,1,79,170,110,157,214,226,106,90,252,7,122,3,142,60,169,196,10,99,59,69,39,225,218,13,215,200,139,127,247,195,173,221,207,46,12,199,63,78,252,247,141,89,214,246,175,91,205,31,131,218,10,102,152,106,102,152,174,102,75,13,127,140,30,112,93,130,68,26,74,62,253,4,110,82,176,217,217,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("46afb3ed-1885-4b3d-b670-49fb41e9bc31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e541292-492a-4131-865b-1141cd84f48e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess4",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("41e6d34d-949e-4e23-9486-19de072d436e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("46afb3ed-1885-4b3d-b670-49fb41e9bc31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("01559df3-70fb-4415-8ddb-44c0a1c7f9e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("46afb3ed-1885-4b3d-b670-49fb41e9bc31"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,193,138,219,48,16,61,59,144,127,80,125,137,12,193,244,30,22,54,77,151,101,91,88,66,211,246,18,114,208,90,147,32,112,164,48,146,227,110,23,255,123,71,146,141,173,110,115,232,201,48,122,243,230,189,39,141,175,2,89,101,234,230,172,127,138,186,1,118,199,54,8,194,193,102,172,241,98,53,159,169,35,227,9,238,142,233,166,174,11,246,54,159,101,8,174,65,205,28,54,64,208,110,62,155,207,172,67,165,79,204,2,42,81,171,223,32,191,153,150,200,191,88,163,203,221,80,156,50,250,33,87,18,99,95,8,166,161,101,187,192,240,169,81,181,4,228,247,57,63,54,186,114,202,104,30,135,122,176,67,128,71,84,146,90,90,165,165,105,203,135,95,174,60,129,219,156,47,124,145,123,78,251,82,174,47,23,208,146,111,197,9,202,71,112,91,129,226,12,14,48,186,203,7,146,39,153,23,105,199,125,190,240,133,204,155,255,48,192,226,244,222,179,63,13,126,131,28,41,156,216,153,6,43,159,227,128,47,199,234,192,53,86,136,44,168,140,1,63,217,103,104,35,255,84,132,31,231,233,49,68,56,54,151,85,184,42,74,150,7,146,73,83,146,123,177,202,254,98,12,232,108,194,68,212,182,84,154,218,28,255,184,244,147,124,138,91,84,103,129,175,201,91,8,135,239,250,45,184,53,93,206,53,136,249,23,224,168,16,30,174,160,29,95,196,49,32,23,203,137,151,64,187,100,111,172,43,86,65,94,199,160,182,112,51,139,248,114,44,229,241,159,214,87,55,211,36,195,94,125,207,188,79,79,146,40,158,233,253,240,226,16,77,30,13,50,62,74,242,103,76,233,65,96,255,90,50,159,40,133,52,141,114,196,47,7,244,126,172,245,236,221,237,28,137,178,54,66,190,11,114,239,103,245,132,135,36,210,176,152,105,152,84,235,10,222,3,188,139,225,118,40,138,175,240,74,9,241,184,202,197,173,245,73,27,2,207,15,170,108,140,214,16,246,149,246,221,90,250,126,38,141,251,20,125,32,126,18,244,221,196,101,15,127,154,48,103,45,229,174,66,117,113,60,239,23,187,170,141,133,65,232,244,135,243,7,178,92,89,39,194,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("85f7af6c-5530-4aa2-9396-978ccd5dd9b6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e541292-492a-4131-865b-1141cd84f48e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess5",
				Position = new Point(295, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(221, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e0425c2a-2fe5-42d8-bc1d-35ce16fa9960"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("85f7af6c-5530-4aa2-9396-978ccd5dd9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(35, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d5674c69-2eff-4f0e-9ac7-87772cd3ef44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("85f7af6c-5530-4aa2-9396-978ccd5dd9b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(126, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,87,81,106,73,105,81,158,66,73,81,105,170,53,0,50,61,165,196,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0ed4a868-4516-4db4-8fb8-63eeddf6c673"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cfc7d647-5e3c-4e96-b563-b9e6d1e9b9e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess7",
				Position = new Point(35, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFilterExploreButtonClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c7455555-f1ce-4349-8132-071883a454d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ed4a868-4516-4db4-8fb8-63eeddf6c673"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FilterExploreButtonClick",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterExploreButtonClick_StartMessage",
				Position = new Point(29, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFilterExploreButtonClick_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8e255378-6924-4c66-a15b-dfadda00c4ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ed4a868-4516-4db4-8fb8-63eeddf6c673"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterExploreButtonClick_ScriptTask",
				Position = new Point(148, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,41,73,45,242,47,72,205,115,206,207,41,205,205,115,173,40,200,201,47,74,45,210,112,3,75,4,39,103,164,230,38,122,166,104,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,224,43,204,251,54,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7dec0d5b-3318-4587-ad8f-f292329cdbd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c67a8530-4eb9-4230-91f6-8816c517a0b6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(242, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFilterColumnValueEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7cd4a2d3-3cc0-4468-b2eb-7a3a463cd887"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dec0d5b-3318-4587-ad8f-f292329cdbd8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FilterColumnValueEditChange",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterColumnValueEditChange_StartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFilterColumnValueEditChange_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d90f92d0-ceef-4c23-89ca-ab99f3487d78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dec0d5b-3318-4587-ad8f-f292329cdbd8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"FilterColumnValueEditChange_ScriptTask",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,44,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,112,203,204,41,73,45,242,77,45,73,12,72,44,201,208,84,80,83,83,192,174,48,32,49,61,85,15,162,218,57,63,167,52,55,47,44,49,167,52,213,53,37,179,68,47,36,181,162,68,83,83,161,154,151,139,19,172,10,155,188,130,173,2,212,88,176,113,214,188,92,181,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,193,193,154,100,163,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("29c8b00f-024a-41aa-ad6c-54b70d7900df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59e8d317-9255-4746-b295-401f54921b01"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess9",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(234, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8d70fcd2-73a2-4adb-b428-87c790aaa381"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29c8b00f-024a-41aa-ad6c-54b70d7900df"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ColumnEditChange",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ColumnEditChangeStartMessage",
				Position = new Point(21, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cf2aa621-447b-49d3-b874-ec6b046d2ad9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29c8b00f-024a-41aa-ad6c-54b70d7900df"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ColumnEditChangeScriptTask",
				Position = new Point(126, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,206,207,43,41,202,207,41,118,205,75,76,202,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,42,122,74,178,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ad2df983-ab79-41bf-9ae0-5e5cef7fec55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6c68cc0-8863-4c04-b7e5-a091f79bf47d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValueEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4ff7390e-5287-4499-9fca-f3912a6ed3a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ad2df983-ab79-41bf-9ae0-5e5cef7fec55"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ColumnValueEditChange",
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ColumnValueEditChangeStartMessage",
				Position = new Point(29, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnValueEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("454bea31-0df1-403b-986a-4b067d70ea18"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ad2df983-ab79-41bf-9ae0-5e5cef7fec55"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Name = @"ColumnValueEditChangeScriptTask",
				Position = new Point(141, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,115,206,207,41,205,205,11,75,204,41,77,117,77,201,44,209,11,72,44,74,204,77,45,73,45,2,11,41,40,218,42,228,149,230,228,40,168,169,41,40,22,151,20,101,230,165,235,121,22,251,1,69,252,139,92,115,11,74,42,137,49,68,15,76,106,106,42,84,243,114,113,130,213,187,101,230,0,37,209,117,133,164,86,148,40,216,42,64,173,1,27,111,13,212,1,81,236,155,90,146,24,144,88,146,129,169,160,150,151,171,40,181,164,180,40,79,161,164,168,52,213,26,0,34,72,151,253,218,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetColumnValuesMethod());
			Methods.Add(CreateGetColumnExplorerMethod());
			Methods.Add(CreateColumnExplorer_EditCompleteMethod());
			Methods.Add(CreateOpenColumnExplorerMethod());
			Methods.Add(CreateCreateColumnExplorerMethod());
			Methods.Add(CreateCreateColumnValueMethod());
			Methods.Add(CreateCreateParameterExplorerMethod());
			Methods.Add(CreateGetParameterExplorerMethod());
			Methods.Add(CreateOpenParameterExplorerMethod());
			Methods.Add(CreateColumnValueEdit_ShowMappingWindowMethod());
			Methods.Add(CreateShowWarningMethod());
			Methods.Add(CreateFilterOpenColumnExplorerMethod());
			Methods.Add(CreateFilterGetMetaPathMethod());
			Methods.Add(CreateFilterGetColumnExplorerMethod());
			Methods.Add(CreateFilterCreateColumnExplorerMethod());
			Methods.Add(CreateFilterColumnExplorer_EditCompleteMethod());
			Methods.Add(CreateSetControlsEnabledMethod());
			Methods.Add(CreateFillControlValuesMethod());
			Methods.Add(CreateGetIndexInDataValueTypeNameArrayMethod());
			Methods.Add(CreateGetCompatibleDataValueTypesMethod());
			Methods.Add(CreateSetFilterDataValueTypeIdParameterEditMethod());
			Methods.Add(CreateSetFilterDataValueTypeIdMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("eeef7ec1-a5be-4efb-a810-5e7e64d8fb29"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f06be2ee-d65c-4c78-bfd4-fcc73750f595"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "Controls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b8fa5934-3a13-486d-bcf5-d858c142836a"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4a487cd7-54b3-466e-b1c3-ad6b61888df6"),
				Name = "GetColumnValues",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,193,10,130,80,16,69,215,9,254,195,224,74,33,252,1,179,77,66,139,54,130,213,38,90,76,143,201,158,232,60,152,55,66,18,253,123,15,9,172,213,192,225,220,123,199,221,58,50,10,198,177,210,83,15,52,65,9,53,182,148,239,73,107,20,28,72,73,206,216,143,148,38,139,148,100,69,28,217,59,164,191,185,18,120,236,251,12,94,113,180,18,210,81,120,6,193,124,199,209,23,156,60,201,206,49,135,77,235,56,111,200,251,112,43,84,188,44,85,249,209,53,42,150,219,52,187,2,122,168,236,108,163,76,27,63,243,53,212,226,76,200,54,230,65,3,254,255,185,45,62,241,146,13,163,212,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("64600d0b-2df2-4b02-beba-5c7b9316e294"),
				Name = "GetColumnExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,206,207,41,205,205,115,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,84,168,230,226,132,176,81,229,53,52,173,185,106,185,184,138,82,75,74,139,242,20,52,130,75,138,74,147,129,204,84,152,188,38,170,114,107,0,68,56,129,79,101,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e3c908d6-4577-4ffb-8016-167629aacf2b"),
				Name = "ColumnExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("56f8b7b3-e01e-4662-9018-a3c8e8ba18c2"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6567a17f-16a4-41fe-ad75-c1895601f393"),
				Name = "e",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,75,79,194,64,16,62,75,194,127,104,122,90,8,89,226,217,71,34,15,77,73,80,34,224,197,120,88,219,1,214,180,91,178,59,32,213,248,223,157,237,131,180,133,234,173,219,249,94,51,59,187,23,218,241,227,112,23,41,231,198,97,147,167,247,15,240,177,51,49,177,226,35,48,160,165,8,229,23,48,224,227,3,106,49,19,90,68,128,160,205,171,43,17,34,227,169,85,236,190,117,174,218,173,153,88,3,31,166,74,227,64,34,95,192,1,73,50,211,230,47,34,220,193,181,65,45,213,250,150,185,190,216,162,140,149,107,137,83,64,210,197,77,35,56,202,1,110,205,38,133,165,94,195,16,132,102,182,188,167,118,64,161,196,100,238,111,32,18,36,186,164,46,134,177,82,212,23,89,242,113,169,58,21,138,228,52,127,0,244,148,65,161,124,24,36,75,47,96,89,217,11,10,73,147,158,135,197,156,202,14,150,60,47,149,7,73,209,16,43,62,26,115,31,199,153,254,34,97,5,159,206,76,199,62,24,147,105,86,17,172,227,124,183,91,23,35,129,34,61,47,146,173,101,149,211,241,74,177,71,232,103,88,129,6,106,45,83,164,246,234,148,83,132,229,149,225,149,76,229,114,62,193,71,10,73,176,210,169,221,250,161,174,43,97,78,141,43,101,78,86,68,233,119,27,134,85,1,103,177,106,242,77,99,158,3,214,201,236,159,1,216,43,203,22,208,9,78,125,255,110,130,47,226,121,74,61,110,228,182,184,69,27,135,118,17,117,28,154,252,186,71,50,221,75,161,147,124,227,123,78,177,249,151,150,127,150,203,239,130,128,53,60,5,73,219,233,141,122,39,185,173,24,77,226,94,134,36,86,155,220,172,108,194,206,90,90,122,183,255,11,128,127,235,119,47,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1ccb4cd2-f18c-439a-bc97-fb116e4690e2"),
				Name = "OpenColumnExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1d599dda-dee1-4e03-ac49-1a4906327ab4"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,78,206,72,205,77,12,245,76,81,176,181,85,112,47,205,76,209,115,205,45,40,169,212,84,168,230,226,44,74,45,41,45,202,179,230,170,229,42,75,44,82,72,206,207,41,205,205,115,173,40,200,201,47,74,45,82,0,170,78,45,113,70,17,211,208,180,230,202,4,154,137,174,210,86,33,175,52,39,7,205,72,84,69,122,193,25,249,229,174,41,153,37,225,153,121,41,249,229,8,103,233,40,248,166,150,36,6,36,150,100,104,90,3,0,20,154,98,245,176,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0bd22b11-3a12-442a-ad11-3f2692a0e6fb"),
				Name = "CreateColumnExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,193,10,194,48,16,68,207,230,43,214,158,90,44,249,129,210,131,132,30,4,5,209,15,144,208,110,75,36,77,74,186,169,21,241,223,141,130,96,10,94,246,48,188,153,217,153,164,131,218,106,223,155,106,30,180,117,232,160,4,131,55,56,147,243,53,121,135,95,61,61,202,14,249,65,42,35,172,33,103,245,94,222,173,167,28,18,17,249,147,28,90,169,71,204,33,36,132,107,188,214,89,193,226,18,190,189,202,185,154,208,208,200,171,70,145,176,253,160,145,144,127,52,216,148,16,135,94,126,161,130,169,22,210,245,110,140,25,225,80,18,54,25,60,216,106,209,118,194,78,141,20,54,132,71,158,76,44,247,198,116,193,254,36,7,242,61,169,120,1,57,128,75,23,52,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0daedcd3-6a98-4e13-9aff-83b61810d297"),
				Name = "CreateColumnValue",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "object"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,203,82,219,48,20,93,135,25,254,65,120,209,113,166,69,31,128,155,46,32,1,50,109,104,134,132,118,193,116,33,108,5,60,216,146,71,150,1,15,201,191,247,74,150,19,201,143,240,200,194,142,229,123,207,57,247,97,233,62,17,129,66,158,20,41,251,67,146,130,230,104,132,46,168,60,179,86,252,97,112,120,16,175,144,239,154,141,16,43,146,100,136,94,15,15,6,130,202,66,48,189,0,182,155,202,124,154,95,209,103,244,229,139,3,143,207,56,147,36,102,249,79,90,250,51,42,201,156,200,135,97,133,178,120,224,207,127,137,96,49,187,215,156,109,216,185,224,33,205,243,69,248,64,83,240,20,36,165,146,10,141,140,50,245,168,255,130,109,46,5,160,160,40,206,179,132,148,245,170,82,85,189,193,32,14,80,127,139,73,154,201,210,159,147,123,138,207,227,4,192,172,200,39,81,44,241,146,190,72,163,111,199,0,73,210,46,77,99,87,146,10,65,81,30,117,114,238,208,176,190,14,85,170,154,139,219,116,249,222,130,164,89,2,48,22,39,246,140,50,75,26,94,240,66,132,90,97,127,178,42,27,92,67,78,152,140,101,57,35,89,6,15,65,3,239,154,174,168,160,44,164,21,208,205,52,2,236,42,87,213,202,52,82,46,27,68,147,156,34,21,175,223,161,230,61,114,32,214,92,234,5,37,97,176,94,163,79,2,45,66,17,103,114,168,81,32,169,181,76,116,4,189,93,196,17,214,5,80,233,238,174,76,163,45,7,85,122,42,20,68,237,135,17,186,201,85,203,48,70,67,25,115,134,109,211,25,97,208,35,2,195,231,52,133,192,8,164,240,180,132,244,249,181,30,221,227,14,122,85,91,148,219,15,35,135,82,161,217,182,167,101,173,118,39,91,195,234,94,183,12,241,152,72,162,147,180,44,51,10,17,255,226,252,177,200,76,136,111,22,220,129,106,91,104,74,171,5,218,133,59,250,64,225,140,38,71,177,201,38,138,186,22,91,117,232,114,213,26,7,211,9,43,82,42,200,93,66,191,119,89,77,37,77,127,184,44,106,73,237,139,93,212,186,186,234,125,181,99,13,6,170,193,92,203,142,4,142,27,239,131,222,120,21,118,91,13,26,213,155,34,184,173,184,160,36,124,64,126,175,127,172,47,172,35,170,58,213,186,93,148,25,214,106,71,173,8,182,134,131,46,49,202,51,48,239,239,64,205,163,121,216,232,91,117,85,12,45,95,124,33,120,145,93,65,39,40,82,15,34,160,185,183,229,170,119,113,88,93,198,41,61,231,34,37,50,216,9,110,195,57,72,158,35,218,130,0,197,94,9,191,227,217,236,56,138,188,90,236,174,125,247,0,43,148,189,192,151,151,39,179,217,73,158,55,96,223,163,4,129,111,154,218,190,213,205,250,154,198,214,137,6,206,99,131,166,78,158,156,182,207,20,188,228,11,157,68,223,229,53,205,186,55,100,183,52,87,69,122,71,69,238,153,48,96,115,126,203,163,34,222,239,177,53,62,229,60,161,132,189,207,24,190,34,46,118,69,232,79,79,51,31,193,174,31,213,101,99,14,232,183,206,103,27,181,227,196,109,144,118,78,6,106,140,8,12,101,212,43,114,236,206,43,86,235,56,179,7,131,185,106,207,102,234,27,137,31,152,4,156,9,224,155,114,238,10,170,127,66,210,46,181,109,101,86,31,71,42,232,160,29,181,195,104,147,205,5,93,197,47,232,107,111,94,16,218,142,152,159,156,15,12,43,90,175,123,102,167,15,167,172,57,32,226,58,250,238,38,4,249,246,80,124,91,91,255,115,204,193,176,113,172,45,64,18,220,213,70,127,171,43,2,167,79,163,246,94,8,19,35,84,4,230,107,207,250,252,135,10,218,230,4,240,39,119,244,55,141,245,10,233,29,232,35,235,154,63,79,35,85,89,43,152,250,175,90,174,190,71,187,223,157,126,168,65,237,194,67,232,64,108,230,122,139,59,248,15,164,110,226,163,135,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateParameterExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1c795cec-e849-4e50-8b76-7cb208fbac6e"),
				Name = "CreateParameterExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,219,78,194,64,16,134,175,37,225,29,214,94,181,9,217,23,32,92,72,37,164,9,32,1,241,126,211,29,160,113,187,109,118,103,209,70,120,119,167,7,164,80,53,122,213,116,14,255,255,117,102,122,16,134,229,194,136,20,16,204,228,61,87,153,1,195,70,76,195,27,91,199,123,72,197,26,141,139,209,25,56,103,253,165,216,1,159,139,68,135,153,70,147,169,153,40,50,135,3,230,45,111,133,188,1,219,10,101,161,121,4,195,126,175,99,70,74,154,4,205,130,194,100,220,122,251,182,58,210,177,114,18,228,163,64,241,34,148,131,231,34,7,203,67,5,194,248,165,65,178,101,254,189,95,179,71,146,141,70,108,234,18,201,39,105,142,5,59,30,153,69,147,232,29,143,236,194,41,245,100,170,184,63,7,20,75,129,251,32,8,216,71,191,119,119,160,177,128,198,4,139,90,136,192,54,22,12,125,176,134,24,147,76,243,73,43,219,48,243,41,96,164,45,10,29,195,184,216,68,242,139,162,228,170,52,109,21,8,51,229,82,77,154,109,139,178,123,221,74,143,139,51,212,133,174,148,249,243,72,30,164,244,219,126,252,42,207,137,111,112,197,195,87,176,5,3,4,95,99,108,26,238,114,160,191,232,68,118,150,101,175,46,175,7,247,63,188,155,153,94,85,180,135,138,144,142,139,242,36,124,175,92,166,23,212,244,151,197,86,160,167,126,239,212,236,63,178,157,91,12,13,8,4,89,99,118,41,87,176,75,44,5,170,27,34,153,78,63,173,171,211,69,165,63,59,81,3,253,58,48,252,4,46,80,153,76,99,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParameterExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0a9bbbc4-be79-4b38-8c1a-cf3a88a8feb3"),
				Name = "GetParameterExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "SchemaStructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,14,72,44,74,204,77,45,73,45,114,173,40,200,201,47,74,45,114,46,74,77,44,73,77,209,84,168,230,229,226,132,112,48,212,104,104,90,243,114,213,242,114,21,165,150,148,22,229,41,104,4,39,103,164,230,38,6,151,20,149,38,3,5,82,97,202,52,49,52,90,3,0,213,31,41,160,118,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenParameterExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("876eb86c-3022-451b-b2e8-0384bdf36626"),
				Name = "OpenParameterExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9e0f7e09-ba5d-4005-94e1-c67dcbf83c8f"),
				Name = "metapath",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,205,10,131,48,16,132,207,10,190,195,30,13,136,47,32,30,67,241,38,72,233,57,152,45,9,228,143,117,83,91,74,223,189,233,85,123,29,190,111,102,236,29,218,153,226,138,219,182,172,6,189,154,52,140,35,92,178,213,189,244,137,95,2,222,77,93,17,114,166,48,52,245,167,169,31,138,32,41,82,30,25,73,62,147,139,132,4,197,65,158,143,113,43,138,99,203,198,31,97,132,144,157,59,247,159,208,126,49,113,151,218,242,205,6,29,247,227,223,14,10,173,146,98,211,85,63,74,58,244,24,248,58,105,49,124,1,74,20,93,177,223,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnValueEdit_ShowMappingWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5f205382-fcce-4ba4-8af3-1cabf9fb8055"),
				Name = "ColumnValueEdit_ShowMappingWindow",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2b7ddee5-bb03-49ce-8ebc-b2e267fe0866"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("81760548-1396-4098-a072-f557a6d90ee1"),
				Name = "e",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,145,77,75,3,49,16,134,207,46,236,127,8,189,52,41,75,170,231,210,131,172,85,60,136,11,11,122,30,146,161,6,242,197,108,82,133,210,255,110,186,171,11,82,240,224,201,227,204,60,243,240,194,123,0,98,17,8,29,38,164,221,71,180,129,144,216,150,61,96,234,128,224,199,154,139,77,93,117,176,71,217,43,50,49,61,129,47,3,201,91,173,167,5,239,19,25,191,151,247,129,28,36,190,56,94,159,100,246,124,137,218,36,21,92,180,197,182,108,216,241,230,36,131,47,108,86,41,19,126,235,95,141,215,225,125,87,216,246,139,29,81,177,89,52,117,117,117,17,82,182,214,160,79,143,119,13,27,51,181,193,102,231,95,192,102,60,59,230,179,248,75,234,240,47,82,175,87,117,117,152,10,154,154,40,197,240,142,130,194,97,232,213,27,58,152,59,154,13,98,64,175,145,202,247,115,68,127,217,33,159,101,114,252,97,48,176,95,148,98,162,206,105,86,235,79,52,147,199,95,45,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowWarningMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6566702a-8af1-41d9-b817-913f8e1defdf"),
				Name = "ShowWarning",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,74,44,78,245,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,188,212,114,5,159,252,228,196,156,204,170,196,164,156,212,224,146,162,204,188,116,13,46,78,165,144,212,162,162,196,226,252,180,18,189,240,212,36,199,130,2,61,231,252,220,220,252,60,37,29,5,37,168,94,189,240,196,162,60,160,106,37,77,189,144,124,168,70,77,29,46,78,168,48,76,21,146,156,2,84,44,164,178,0,174,91,211,26,0,110,193,208,43,164,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterOpenColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d8a5702b-0ea1-4f33-8d64-9cbde293ebdd"),
				Name = "FilterOpenColumnExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ee669218-e98f-4f15-8489-2778d5af07a2"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,203,10,194,48,16,69,215,230,43,102,153,128,244,7,66,86,18,139,11,65,16,113,29,154,145,4,242,40,211,137,85,196,127,215,93,105,215,247,112,206,141,15,144,211,16,48,187,219,201,131,49,208,183,232,59,155,71,126,43,248,136,29,33,55,42,90,124,133,120,58,130,161,166,150,139,125,141,169,18,18,24,56,198,196,72,61,242,97,181,72,165,69,252,171,183,188,129,210,82,218,154,215,84,119,13,117,182,62,242,61,22,95,231,229,222,126,169,157,145,221,197,113,144,74,233,31,46,88,209,58,195,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterGetMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b30d6264-889f-4cc7-8b0f-58bd1c562177"),
				Name = "FilterGetMetaPath",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,177,10,194,64,12,134,231,203,83,156,91,187,244,5,14,167,162,34,82,117,114,17,135,67,162,30,164,215,114,201,9,34,125,119,175,69,171,29,132,44,201,255,229,35,132,37,56,127,213,1,57,146,232,185,246,145,200,0,184,139,206,102,60,100,197,154,183,105,184,11,139,186,149,71,182,116,36,24,42,20,187,183,114,203,115,253,4,53,110,79,67,3,29,32,49,246,200,127,225,175,74,129,82,119,27,244,185,161,88,251,202,182,201,185,66,41,135,246,96,41,34,103,185,73,80,175,27,161,162,108,188,88,231,121,131,83,93,2,191,183,141,248,241,131,156,138,65,217,251,58,72,213,65,64,137,193,191,191,97,94,178,145,140,132,28,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterGetColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("21082689-cf74-4210-a8cf-6e53249c3c2e"),
				Name = "FilterGetColumnExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,244,44,118,203,204,41,73,45,114,206,207,41,205,205,115,173,40,200,201,47,2,242,138,82,19,75,82,83,52,21,170,185,56,161,242,96,17,84,85,26,154,214,92,181,92,92,69,169,37,165,69,121,10,26,193,37,69,165,201,64,102,42,76,94,19,155,209,214,0,107,50,1,9,119,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterCreateColumnExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bad0561c-f5d4-41db-b9e7-322c0d342d18"),
				Name = "FilterCreateColumnExplorer",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,95,107,219,48,16,127,78,32,223,65,203,147,77,131,96,207,91,6,173,231,21,195,178,149,122,217,203,40,67,181,46,137,134,44,25,233,156,198,180,249,238,61,219,77,106,47,78,233,147,65,119,247,251,119,231,173,112,44,179,186,204,77,188,43,180,117,224,216,156,25,120,96,41,186,50,195,210,193,225,61,152,140,71,55,98,13,124,33,148,137,172,65,103,245,119,81,217,18,103,108,26,53,16,191,133,46,143,253,211,25,91,9,237,225,248,49,165,214,225,167,201,184,79,199,47,255,137,93,188,5,131,158,199,82,97,100,243,66,3,2,111,222,216,197,156,125,83,26,193,69,189,169,191,221,214,83,204,196,100,186,148,32,191,10,20,141,168,95,85,1,158,71,26,132,11,6,52,36,62,221,216,135,180,242,8,121,75,228,41,134,70,55,53,171,21,11,62,4,105,182,129,92,36,146,205,231,236,186,84,146,199,121,129,21,123,122,170,163,82,102,77,32,63,200,225,79,215,188,7,11,64,113,35,112,19,134,33,123,164,232,222,197,72,153,215,132,255,55,199,187,198,78,223,205,203,158,124,67,254,231,227,29,123,172,183,96,221,116,95,35,108,105,175,148,159,194,170,213,77,221,75,95,167,104,12,100,168,172,225,113,167,186,16,134,54,235,248,53,96,98,60,10,147,193,85,181,76,228,209,116,120,192,244,205,67,171,152,48,187,20,245,116,218,41,95,85,135,12,94,195,168,97,168,170,91,13,159,123,142,190,208,33,230,133,64,117,175,79,172,210,216,136,224,163,51,13,65,87,22,239,213,26,202,21,197,40,178,13,11,122,165,115,124,76,153,179,82,218,101,158,108,115,248,222,46,165,12,206,0,113,74,119,214,75,147,223,194,10,28,80,244,109,136,203,58,245,17,145,237,39,227,253,203,17,38,126,232,103,136,200,28,130,28,188,179,91,88,43,186,177,246,234,9,102,104,158,246,216,159,162,214,55,153,14,151,250,12,180,126,209,227,61,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFilterColumnExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("af58d268-d00e-4183-8c07-5db1da47f012"),
				Name = "FilterColumnExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("49c61b69-0cfa-441f-9033-0d6f6fd60061"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d3761930-f97e-4a57-b0cd-a4dd3462a0b8"),
				Name = "e",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,75,79,2,49,16,62,67,226,127,88,247,212,77,76,255,128,143,3,176,154,37,225,17,1,47,198,67,221,29,160,166,219,37,237,128,172,134,255,238,180,21,220,69,61,118,190,249,94,211,157,48,81,94,169,109,169,163,219,136,13,39,175,111,144,99,50,180,149,230,3,176,96,164,80,242,3,24,240,116,143,70,76,133,17,37,32,24,251,28,75,132,210,102,122,89,197,47,201,245,69,119,42,86,192,239,165,34,176,239,245,158,132,218,66,90,72,228,115,216,35,169,7,27,238,231,55,22,141,212,171,59,22,231,98,131,178,210,177,211,8,244,17,32,25,225,250,95,74,249,189,16,159,124,207,29,251,10,132,97,14,150,203,136,93,6,38,207,236,120,171,212,196,164,229,6,107,118,180,73,146,232,243,162,219,217,209,33,64,163,196,122,150,175,161,20,228,190,176,174,139,214,116,17,74,200,211,6,58,18,154,124,13,127,0,204,180,69,161,115,232,213,139,172,96,1,206,10,231,237,53,173,31,244,143,39,110,90,56,246,172,1,247,234,99,166,159,112,78,230,207,138,167,175,240,35,82,214,240,30,77,77,149,131,181,65,180,189,193,66,205,206,64,160,240,131,121,189,113,180,102,62,222,2,175,220,250,35,44,193,0,213,11,154,84,241,156,243,123,195,19,91,119,26,83,16,226,53,94,141,157,160,217,138,158,21,4,31,168,251,225,11,1,235,75,248,160,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlsEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("36c48596-ee04-4cc4-9f0e-4a0d813805ad"),
				Name = "SetControlsEnabled",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,77,107,194,64,16,61,27,200,127,216,120,218,128,236,31,16,47,134,180,244,98,133,134,222,39,58,198,45,147,93,217,15,80,196,255,238,186,105,147,18,171,244,58,239,205,251,152,169,181,38,38,109,169,160,38,220,178,5,203,172,51,82,53,226,205,174,60,209,187,41,219,131,59,241,53,52,40,10,77,190,85,229,86,58,81,225,209,229,243,52,249,53,255,4,242,24,193,65,172,23,254,161,190,72,114,104,254,183,32,119,140,103,253,32,103,231,52,153,252,233,87,16,130,225,183,56,147,39,38,3,235,146,38,245,173,246,6,84,177,7,213,96,71,13,136,174,191,112,227,198,192,26,12,180,24,36,67,192,104,240,138,174,159,69,3,62,29,173,76,243,239,2,15,165,178,5,83,225,192,93,173,101,136,131,160,68,101,78,129,97,241,225,154,168,244,71,252,15,207,103,76,251,187,168,177,30,67,178,24,117,71,104,200,191,131,128,117,55,24,255,116,248,194,253,97,34,183,60,30,72,27,92,122,231,180,122,66,191,2,106,127,57,123,84,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5955ef40-24c4-4b23-b38f-6903f97011f3"),
				Name = "FillControlValues",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,149,207,114,155,48,16,198,207,246,140,223,65,206,33,3,23,94,32,227,75,18,154,250,144,212,19,59,189,116,122,80,97,157,208,1,193,8,145,148,233,244,221,187,250,3,104,49,196,190,25,233,219,111,127,90,173,214,239,92,178,164,204,155,66,124,231,121,3,53,219,176,7,80,119,222,74,16,222,172,150,217,145,5,84,182,97,162,201,243,144,253,93,45,23,18,84,35,5,202,254,173,150,229,175,223,144,40,86,39,111,80,240,109,186,227,146,23,104,186,227,175,16,161,179,249,6,5,210,248,4,87,157,238,170,203,66,3,215,126,154,189,219,66,59,1,31,236,161,201,82,42,143,14,229,94,201,76,188,6,97,72,104,42,89,38,80,215,251,11,161,70,242,158,109,210,134,32,238,168,194,39,157,10,158,5,62,102,57,226,92,202,75,213,61,238,148,9,161,253,66,4,62,236,68,232,136,117,97,96,172,131,215,46,113,154,169,232,107,150,166,32,208,239,200,243,26,244,193,24,224,15,91,161,11,194,148,108,128,148,163,224,2,195,228,19,158,250,92,45,60,105,95,136,147,112,82,133,199,97,23,125,199,90,239,216,20,9,20,223,113,245,118,150,199,233,6,24,18,72,73,220,150,198,240,85,115,12,128,85,139,115,40,64,168,23,115,127,115,16,158,208,235,143,81,56,65,137,199,214,125,107,208,168,217,14,150,229,199,249,198,53,34,195,179,173,159,48,193,134,132,89,30,7,235,109,16,208,103,189,238,243,13,194,49,219,208,132,93,144,14,136,48,177,9,116,252,58,217,218,226,92,95,179,117,109,28,34,92,192,148,223,100,92,84,170,13,186,139,10,45,195,59,14,81,44,71,166,90,251,98,208,249,165,214,253,45,4,150,34,43,69,20,123,187,174,223,116,61,182,162,86,92,36,112,219,98,41,131,238,185,153,231,229,71,216,135,226,230,52,154,251,185,180,141,175,186,109,59,184,129,178,127,174,86,98,30,219,1,254,40,180,178,158,209,29,175,12,39,105,52,58,205,232,221,177,138,126,110,200,191,200,143,46,245,207,115,54,9,157,1,157,153,71,59,204,7,26,170,157,205,80,38,171,209,190,108,100,2,186,121,62,73,107,69,238,86,30,121,85,225,145,237,85,126,54,159,92,201,70,9,239,179,186,202,121,219,51,121,109,182,152,57,93,117,114,16,236,187,73,113,116,207,21,55,191,14,109,53,84,153,46,223,204,5,63,195,17,36,96,127,217,26,216,135,236,28,78,247,102,109,72,219,186,49,233,125,157,137,115,147,137,254,251,141,58,114,168,241,68,55,245,134,250,125,254,7,249,14,254,252,176,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIndexInDataValueTypeNameArrayMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bd4560c4-a39c-4f0a-a487-3e63c9c9f61d"),
				Name = "GetIndexInDataValueTypeNameArray",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9d9fad9e-b8f6-4306-966c-6f1e5edd376b"),
				Name = "dataValueTypeName",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dc2ff46e-1dca-4089-a369-5c7240b77dd9"),
				Name = "dataValueTypeNames",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string []",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,203,47,82,208,200,204,43,81,200,84,176,85,48,176,6,82,54,10,41,137,37,137,97,137,57,165,169,33,149,5,169,126,137,185,169,197,122,62,169,121,233,37,25,64,105,109,109,77,133,106,46,206,204,52,5,13,76,101,209,153,177,10,182,182,152,250,193,90,56,139,82,75,74,139,242,20,50,173,185,56,107,185,106,185,160,92,93,67,107,0,192,140,148,111,132,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCompatibleDataValueTypesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e75efb51-620f-4ca2-94fb-499ccd97c467"),
				Name = "GetCompatibleDataValueTypes",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Collection<DataValueType>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5566e513-6074-4190-812d-3e6e954b14c7"),
				Name = "dataValueType",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueType",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,65,79,235,48,12,62,167,191,34,244,128,58,9,42,113,46,157,196,64,26,149,128,203,128,11,226,16,86,111,139,232,146,42,77,222,91,121,234,127,127,110,186,142,134,165,7,16,61,84,169,237,124,159,253,217,245,220,240,156,230,76,179,103,86,24,120,172,75,120,202,114,154,186,166,24,109,73,80,105,197,197,218,245,60,176,45,28,69,183,198,36,120,147,178,160,213,70,154,34,191,202,243,155,97,4,222,208,202,96,140,99,189,103,130,173,65,185,96,189,49,165,79,21,168,107,41,4,44,53,151,34,246,93,77,130,63,76,209,165,220,150,76,243,183,2,156,152,10,49,4,252,165,215,178,40,58,140,75,199,63,141,38,73,192,87,52,242,20,152,210,112,142,66,133,19,250,47,32,99,248,49,150,25,249,146,143,231,160,51,81,105,38,150,48,171,91,196,40,188,147,242,221,148,225,4,57,27,10,69,5,116,156,186,143,253,53,242,174,150,79,106,196,245,201,153,105,216,122,187,97,29,169,215,101,233,208,61,171,113,102,162,175,131,133,148,196,55,70,115,37,77,233,155,165,1,97,124,8,66,144,35,177,6,8,168,216,194,114,84,157,100,164,29,138,142,213,59,16,157,235,229,213,198,146,112,177,145,74,63,194,78,135,103,246,251,30,114,110,182,3,195,157,20,235,193,231,173,89,195,48,156,237,22,252,99,104,177,71,60,53,152,55,225,66,83,45,203,76,228,176,67,126,219,28,60,102,226,230,107,235,175,148,98,245,241,68,156,121,75,153,88,108,20,229,128,125,146,210,243,139,174,126,50,58,242,174,216,85,38,172,140,52,109,47,145,177,246,186,204,179,250,32,253,72,71,108,110,100,37,21,176,229,134,70,238,38,112,174,244,252,92,248,19,219,151,99,69,228,63,82,112,15,100,87,148,237,14,33,163,114,118,130,118,60,83,20,147,158,158,238,89,47,211,67,15,251,148,190,241,99,246,197,36,100,255,88,128,38,232,95,163,59,115,197,240,103,109,51,195,176,38,104,236,178,242,7,127,115,85,180,155,32,80,160,141,18,163,219,51,249,15,197,135,216,235,42,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFilterDataValueTypeIdParameterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8b781e38-c16c-45ff-acb7-25e6ffeb7726"),
				Name = "SetFilterDataValueTypeIdParameterEdit",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6e44bd09-b108-4b55-a5d7-f24a1abc7d6a"),
				Name = "parameterEditControls",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				ModifiedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,77,107,2,49,16,134,207,21,252,15,97,47,102,107,9,218,83,33,166,96,109,11,210,30,4,181,23,245,16,77,86,135,110,147,37,155,85,68,247,191,55,251,65,187,117,151,82,232,41,48,239,59,207,124,100,32,64,56,226,134,127,72,43,205,147,0,59,210,202,26,29,198,136,49,164,146,48,68,231,51,106,52,144,145,78,148,205,108,61,31,157,218,173,43,35,109,98,20,109,183,210,118,107,207,13,138,215,200,33,228,1,77,173,1,181,125,72,32,20,210,224,254,237,29,186,254,13,233,59,68,160,141,228,155,29,194,47,242,248,198,195,68,78,56,152,65,156,131,110,80,241,222,55,66,16,168,102,120,209,100,188,38,195,40,146,74,96,15,7,137,218,88,208,10,251,39,47,43,90,17,155,8,196,245,114,97,243,72,44,237,51,132,206,248,200,45,207,59,157,29,35,57,22,110,244,47,188,168,74,243,177,168,151,243,178,125,101,182,137,209,123,112,91,98,118,7,49,169,70,104,102,9,242,82,49,171,10,164,12,210,26,212,45,17,103,89,192,122,20,6,165,141,132,82,109,237,142,66,183,235,159,190,153,172,148,23,176,170,131,32,192,133,188,232,173,24,235,136,159,163,118,26,230,41,237,253,21,187,28,158,174,221,207,190,211,52,77,107,117,254,189,116,188,244,254,196,204,83,200,76,191,234,131,59,72,255,146,191,116,144,156,227,14,185,18,78,125,92,198,39,124,43,201,80,136,233,198,64,100,177,243,204,116,113,228,25,236,19,88,181,212,29,83,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFilterDataValueTypeIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c60773f-6b84-45f5-8104-1655dab366d8"),
				Name = "SetFilterDataValueTypeId",
				CreatedInSchemaUId = new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,10,131,48,20,69,231,230,43,222,152,128,4,58,91,11,69,109,113,19,148,238,161,121,149,64,76,36,190,180,72,233,191,215,218,165,136,211,93,206,61,247,154,59,240,66,145,186,42,27,177,157,6,172,52,100,25,92,162,209,178,236,7,154,4,188,216,46,32,197,224,82,246,102,15,21,96,80,65,245,72,24,74,109,40,247,142,130,183,35,100,224,240,9,133,185,145,241,78,133,233,48,82,48,174,75,224,151,71,190,23,41,219,172,202,147,214,188,86,29,202,220,219,216,187,229,203,23,144,185,53,232,168,42,18,88,125,148,173,111,22,45,23,179,181,65,58,27,59,91,87,84,253,191,198,55,183,69,250,1,227,69,255,208,2,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ColumnValueEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3bd8cf47-00ad-4cbc-9286-261329417af6"));
		}

		#endregion

	}

	#endregion

}

