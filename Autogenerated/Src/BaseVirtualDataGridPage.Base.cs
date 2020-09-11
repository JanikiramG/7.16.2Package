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
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: BaseVirtualDataGridPageSchema

	/// <exclude/>
	public class BaseVirtualDataGridPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _searchControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SearchControlLayout {
			get {
				return _searchControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _fieldsList;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FieldsList {
			get {
				return _fieldsList;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _searchEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SearchEdit {
			get {
				return _searchEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _clearSearchButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ClearSearchButton {
			get {
				return _clearSearchButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _searchButton;
		public Terrasoft.UI.WebControls.Controls.Button SearchButton {
			get {
				return _searchButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _treeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGrid {
			get {
				return _treeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonControlLayout {
			get {
				return _buttonControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer {
			get {
				return _spacer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _oKButton;
		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return _oKButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _dataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return _dataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseVirtualDataGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseVirtualDataGridPageSchema(BaseVirtualDataGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			RealUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			Name = "BaseVirtualDataGridPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 450;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseVirtualDataGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateSearchControlLayout());
			SearchControlLayout.InsertItem(0, CreateFieldsList());
			SearchControlLayout.InsertItem(1, CreateSearchEdit());
			SearchEdit.InsertItem(0, CreateClearSearchButton());
			SearchControlLayout.InsertItem(2, CreateSearchButton());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateTreeGrid());
			MainControlLayout.InsertItem(1, CreateButtonControlLayout());
			ButtonControlLayout.InsertItem(0, CreateSpacer());
			ButtonControlLayout.InsertItem(1, CreateOKButton());
			ButtonControlLayout.InsertItem(2, CreateCancelButton());
			Controls.AddAt(2, CreateDataSource());
			UpdateDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseVirtualDataGridPageEventsProcessSchema() {
			var schema = new BaseVirtualDataGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateFieldsList() {
			_fieldsList = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_fieldsList.UId = new Guid("9a0e3a22-6649-42d5-bbf1-88592c13b0c1");
			_fieldsList.Name = "FieldsList";
			_fieldsList.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_fieldsList.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_fieldsList.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fieldsList.Tag = "";
			_fieldsList.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fieldsList.Image = new ControlImage {};
			_fieldsList.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			return _fieldsList;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateClearSearchButton() {
			_clearSearchButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_clearSearchButton.UId = new Guid("43d041db-b1ca-4fc8-b259-118a96829fde");
			_clearSearchButton.Name = "ClearSearchButton";
			_clearSearchButton.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_clearSearchButton.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_clearSearchButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_clearSearchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_clearSearchButton.Tag = "";
			_clearSearchButton.Image = new ControlImage {};
			_clearSearchButton.Hidden = true;
			return _clearSearchButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSearchEdit() {
			_searchEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_searchEdit.UId = new Guid("027f4553-cfde-4b9d-8ce0-f2ca63a4155d");
			_searchEdit.Name = "SearchEdit";
			_searchEdit.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_searchEdit.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_searchEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchEdit.Tag = "";
			_searchEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_searchEdit.Image = new ControlImage {};
			_searchEdit.Width = System.Web.UI.WebControls.Unit.Percentage(60);
			return _searchEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSearchButton() {
			_searchButton = new Terrasoft.UI.WebControls.Controls.Button();
			_searchButton.UId = new Guid("c3414a77-808b-4d65-ac96-492de0d89d1f");
			_searchButton.Name = "SearchButton";
			_searchButton.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_searchButton.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_searchButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_searchButton.Tag = "";
			_searchButton.Image = new ControlImage {};
			return _searchButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSearchControlLayout() {
			_searchControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_searchControlLayout.UId = new Guid("01cd2342-2fdc-4f70-8d55-fc681ea51538");
			_searchControlLayout.Name = "SearchControlLayout";
			_searchControlLayout.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_searchControlLayout.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_searchControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchControlLayout.Tag = "";
			_searchControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(100);
			_searchControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_searchControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_searchControlLayout.StartNewAlignGroup = false;
			_searchControlLayout.Image = new ControlImage {};
			_searchControlLayout.Edges = "";
			return _searchControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateTreeGrid() {
			_treeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_treeGrid.UId = new Guid("5ade76f6-90df-443d-a4c8-2824d3171361");
			_treeGrid.Name = "TreeGrid";
			_treeGrid.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_treeGrid.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_treeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_treeGrid.Tag = "";
			_treeGrid.DataSourceId = "DataSource";
			_treeGrid.Edges = "";
			_treeGrid.IsColumnAutowidth = true;
			_treeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.IsSummaryVisible = false;
			_treeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGrid.HideHeaders = false;
			return _treeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer() {
			_spacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer.UId = new Guid("83acee1b-6d99-4c52-861e-13aa6818bf94");
			_spacer.Name = "Spacer";
			_spacer.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_spacer.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_spacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer.Tag = "";
			_spacer.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("7917d35b-b936-4f2d-a9dc-949fdb066e34");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_oKButton.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("b495a57b-9297-42d9-8222-caac8df733ec");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_cancelButton.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonControlLayout() {
			_buttonControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonControlLayout.UId = new Guid("b824f5af-60b1-461c-aaa9-891cf6beaff1");
			_buttonControlLayout.Name = "ButtonControlLayout";
			_buttonControlLayout.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_buttonControlLayout.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_buttonControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonControlLayout.Tag = "";
			_buttonControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttonControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_buttonControlLayout.StartNewAlignGroup = false;
			_buttonControlLayout.Image = new ControlImage {};
			_buttonControlLayout.Edges = "";
			return _buttonControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("5ea90063-8284-4e32-9d8e-456935d28641");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("a2b36325-61d5-4999-8c9c-468feac1b603");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_dataSource.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = 1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("a38bf8ab-b33e-4e96-89f4-88cc27908a4f");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			return _dataSource;
		}

		protected virtual void UpdateDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseVirtualDataGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseVirtualDataGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseVirtualDataGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseVirtualDataGridPageEventsProcess

	/// <exclude/>
	public class BaseVirtualDataGridPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseVirtualDataGridPageSchemaUserControl
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

		public BaseVirtualDataGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseVirtualDataGridPageEventsProcess";
			SchemaUId = new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd1a6c34-8904-46e4-837c-037318f42e7e");
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

		public virtual string VirtualDataSourceID {
			get;
			set;
		}

		public virtual bool UseFilteredList {
			get;
			set;
		}

		private ProcessFlowElement _oKButtonClickEventSubProcess;
		public ProcessFlowElement OKButtonClickEventSubProcess {
			get {
				return _oKButtonClickEventSubProcess ?? (_oKButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OKButtonClickEventSubProcess",
					SchemaElementUId = new Guid("62fe49d2-52d7-42da-ac6e-226c972a26db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClick;
		public ProcessFlowElement OKButtonClick {
			get {
				return _oKButtonClick ?? (_oKButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClick",
					SchemaElementUId = new Guid("6eedab9b-32cf-4487-ab54-8092268416d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOKButtonClick;
		public ProcessScriptTask ScriptOKButtonClick {
			get {
				return _scriptOKButtonClick ?? (_scriptOKButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOKButtonClick",
					SchemaElementUId = new Guid("548ea5c3-47fe-4a2e-b5d5-6836682cea23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOKButtonClickExecute,
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
					SchemaElementUId = new Guid("cb09a38b-0c5d-4c9f-b8e7-8f7e8bb958e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClick;
		public ProcessFlowElement CancelButtonClick {
			get {
				return _cancelButtonClick ?? (_cancelButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClick",
					SchemaElementUId = new Guid("715170c5-0d63-444a-b764-53df85372702"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptCancelButtonClick;
		public ProcessScriptTask ScriptCancelButtonClick {
			get {
				return _scriptCancelButtonClick ?? (_scriptCancelButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptCancelButtonClick",
					SchemaElementUId = new Guid("1820bd42-f8cd-4991-b4a2-b299670a2703"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCancelButtonClickExecute,
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
					SchemaElementUId = new Guid("da6a0d88-a7ae-446f-b153-05ad5be93707"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _init;
		public ProcessFlowElement Init {
			get {
				return _init ?? (_init = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Init",
					SchemaElementUId = new Guid("0e2c6df8-dbb2-495d-86af-48a1ea0d1237"),
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
					SchemaElementUId = new Guid("2b1df252-74ff-4d95-b487-9d32c5213b75"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
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
					SchemaElementUId = new Guid("436fa17b-bfda-4a2e-95e8-a0fa0381b3fd"),
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
					SchemaElementUId = new Guid("471397d1-961e-4163-b175-b9390f667408"),
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
					SchemaElementUId = new Guid("10cd065c-c4e6-4a9f-a21b-f6c364952cb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
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
					SchemaElementUId = new Guid("f9a4d1bf-1387-4d34-8103-89ed680b9dad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _clearSearchButtonClick;
		public ProcessFlowElement ClearSearchButtonClick {
			get {
				return _clearSearchButtonClick ?? (_clearSearchButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ClearSearchButtonClick",
					SchemaElementUId = new Guid("8216b4fc-dd59-47b8-9f5c-0fce402dbfe7"),
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
					SchemaElementUId = new Guid("a285f61f-fa96-4539-be01-b8446a55d790"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptClearSearchButtonClickExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwSearchButtonClick;
		public ProcessThrowMessageEvent ThrowSearchButtonClick {
			get {
				return _throwSearchButtonClick ?? (_throwSearchButtonClick = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowSearchButtonClick",
					SchemaElementUId = new Guid("ad7312b7-deb7-4f8d-acd6-88413dd7f4bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SearchButtonClick",
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
					SchemaElementUId = new Guid("5a468641-009d-4545-8096-b1ab0db366d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _searchButtonClick;
		public ProcessFlowElement SearchButtonClick {
			get {
				return _searchButtonClick ?? (_searchButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SearchButtonClick",
					SchemaElementUId = new Guid("82f4f347-da96-4d3b-a45f-9d8989ce0664"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSearchButtonClick;
		public ProcessScriptTask ScriptSearchButtonClick {
			get {
				return _scriptSearchButtonClick ?? (_scriptSearchButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSearchButtonClick",
					SchemaElementUId = new Guid("3dd28bd3-fa49-491f-bb37-f1abcfb29a54"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSearchButtonClickExecute,
				});
			}
		}

		private LocalizableString _pageCaptionLS;
		public LocalizableString PageCaptionLS {
			get {
				return _pageCaptionLS ?? (_pageCaptionLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PageCaptionLS.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[OKButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickEventSubProcess };
			FlowElements[OKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick };
			FlowElements[ScriptOKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOKButtonClick };
			FlowElements[CancelButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickEventSubProcess };
			FlowElements[CancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClick };
			FlowElements[ScriptCancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCancelButtonClick };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[ClearSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearSearchButtonClick };
			FlowElements[ScriptClearSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptClearSearchButtonClick };
			FlowElements[ThrowSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowSearchButtonClick };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[SearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SearchButtonClick };
			FlowElements[ScriptSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSearchButtonClick };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "OKButtonClickEventSubProcess":
						break;
					case "OKButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptOKButtonClick");
						break;
					case "ScriptOKButtonClick":
						break;
					case "CancelButtonClickEventSubProcess":
						break;
					case "CancelButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptCancelButtonClick");
						break;
					case "ScriptCancelButtonClick":
						break;
					case "EventSubProcess1":
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						break;
					case "EventSubProcess4":
						break;
					case "ClearSearchButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptClearSearchButtonClick");
						break;
					case "ScriptClearSearchButtonClick":
						e.Context.QueueTasks.Enqueue("ThrowSearchButtonClick");
						break;
					case "ThrowSearchButtonClick":
						break;
					case "EventSubProcess3":
						break;
					case "SearchButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptSearchButtonClick");
						break;
					case "ScriptSearchButtonClick":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OKButtonClick");
			ActivatedEventElements.Add("CancelButtonClick");
			ActivatedEventElements.Add("Init");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("ClearSearchButtonClick");
			ActivatedEventElements.Add("SearchButtonClick");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "OKButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClick";
					result = OKButtonClick.Execute(context);
					break;
				case "ScriptOKButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOKButtonClick";
					result = ScriptOKButtonClick.Execute(context, ScriptOKButtonClickExecute);
					break;
				case "CancelButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClick";
					result = CancelButtonClick.Execute(context);
					break;
				case "ScriptCancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptCancelButtonClick";
					result = ScriptCancelButtonClick.Execute(context, ScriptCancelButtonClickExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
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
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ClearSearchButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearSearchButtonClick";
					result = ClearSearchButtonClick.Execute(context);
					break;
				case "ScriptClearSearchButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptClearSearchButtonClick";
					result = ScriptClearSearchButtonClick.Execute(context, ScriptClearSearchButtonClickExecute);
					break;
				case "ThrowSearchButtonClick":
					context.QueueTasks.Dequeue();
					result = ThrowSearchButtonClick.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "SearchButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "SearchButtonClick";
					result = SearchButtonClick.Execute(context);
					break;
				case "ScriptSearchButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSearchButtonClick";
					result = ScriptSearchButtonClick.Execute(context, ScriptSearchButtonClickExecute);
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
				case "UseFilteredList":
					UseFilteredList = reader.GetValue<System.Boolean>();
				break;
				case "VirtualDataSourceID":
					VirtualDataSourceID = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptOKButtonClickExecute(ProcessExecutingContext context) {
			OnOKButtonClick();
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptCancelButtonClickExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			VirtualDataSourceID = "MainVirtualDataSource";
			var virtualDataSource = new VirtualDataSource() {
				ID = VirtualDataSourceID
			};
			Page.TreeGrid.ImageList = "Terrasoft.WebApp";
			Page.TreeGrid.GetRowConfigHandler =	delegate(Terrasoft.Core.Entities.Entity row) {			
				string primaryColumnName = "Id";		
				string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
				var config = new DataSourceRowConfig(primaryColumnValue);		
				return config;
			};
			
			virtualDataSource.AjaxEvents.Removed.ExtraParameters.Add(new Terrasoft.UI.WebControls.Controls.Parameter("request", 
				"request", Terrasoft.UI.WebControls.Controls.ParameterMode.Raw));
			virtualDataSource.AjaxEvents.Removed.Event += delegate(object sender, AjaxEventArgs e) {
				var virtualDS = GetVirtualDataSource();
				var request = virtualDataSource.GetDataSourceRequest(e);
				DataSource_Removed(request.PrimaryColumnValue);
			};
			virtualDataSource.BeforeLoad += delegate(object sender, DataSourceEventArgs e) {
				Page.ThrowEvent("PrepareFilters");
			};
			virtualDataSource.DataRequest += delegate(object sender, DataSourceEventArgs e) {
				FillVirtualDataSource(GetVirtualDataSource());
				GetVirtualDataSource().LoadRows(e.Request);
			};
			virtualDataSource.LoadingRow += delegate(object sender, DataSourceEventArgs e) {
				OnDataSourceLoadingRow(e.Request);
			};
			Page.PageContainer.Controls.Add(virtualDataSource);
			Page.TreeGrid.DataSourceId = virtualDataSource.ID; 
			virtualDataSource.Loaded += Page.TreeGrid.DataLoaded;
			DataSourceStructure defStructure = virtualDataSource.DefStructure;
			defStructure.Columns.Clear();
			var dataValueTypeManager = (DataValueTypeManager) Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			CreateVirtualDataSourceStructure(dataValueTypeManager, defStructure);
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			FillVirtualDataSource(GetVirtualDataSource());
			GetVirtualDataSource().LoadRows();
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = PageCaptionLS;
			PrepareSearch();
			return true;
		}

		public virtual bool ScriptClearSearchButtonClickExecute(ProcessExecutingContext context) {
			Page.SearchEdit.Text = string.Empty;
			UseFilteredList = false;
			return true;
		}

		public virtual bool ScriptSearchButtonClickExecute(ProcessExecutingContext context) {
			var searchText = Page.SearchEdit.Text;
			if (string.Empty.Equals(searchText)) {
				Page.ClearSearchButton.Hide();	
			} else {
				Page.ClearSearchButton.Show();
			}
			var searchColumnName = Page.FieldsList.SelectedItem.Value;
			
			FormFilteredList(searchColumnName, searchText);
			
			Page.TreeGrid.Clear();
			UseFilteredList = !string.IsNullOrEmpty(searchText);
			FillVirtualDataSource(GetVirtualDataSource());
			GetVirtualDataSource().LoadRows();
			return true;
		}

		public virtual void OnOKButtonClick() {
			return;
		}

		public virtual VirtualDataSource GetVirtualDataSource() {
			return Page.PageContainer.FindPageControl(VirtualDataSourceID) as VirtualDataSource;
		}

		public virtual void FillVirtualDataSource(VirtualDataSource virtualDataSource) {
		}

		public virtual void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
			/*
			!!!EXAMPLE!!!
			defStructure.PrimaryColumnName = "SysUserId";
			defStructure.PrimaryDisplayColumnName = "SysUserName";
			var entitySchemaManager = Page.UserConnection.EntitySchemaManager;
			var column = new DataSourceStructureColumn {
				Name = "SysUser",
				ValueColumnName = "SysUserId",
				DisplayColumnName = "SysUserName",
				DataValueType = dataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = entitySchemaManager.GetInstanceByName("SysAdminUnit").UId,
				ReferenceSchemaName = "SysAdminUnit",
				ReferenceSchemaPrimaryColumnName = "Id",
				Caption = Word_User,
				IsVisible = true,
				IsSortable = true,
				OrderDirection = OrderDirection.Ascending,
				OrderPosition = 1
			};
			defStructure.AddColumn(column);
			column = new DataSourceStructureColumn {
						Name = item.Key,
						ValueColumnName = item.Key,
						DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
						Caption = item.Value["Name"].ToString()+ " (" + usedLic + " " + Word_From + " "+ count + ")",
						IsVisible = true,
						IsSortable = false
					};
					defStructure.AddColumn(column);*/
		}

		public virtual void DataSource_Removed(Guid recordId) {
			/* !!!EXAMPLE!!!
			Delete delete = new Delete(Page.UserConnection).From("SysLicUser").Where("SysUserId").IsEqual(Column.Parameter(recordId)) as Delete;
			delete.Execute();
			*/
		}

		public virtual void OnDataSourceLoadingRow(DataSourceRequest dataSourceRequest) {
			/*
			!!!EXAMPLE!!!
			Guid recordId =  dataSourceRequest == null ? Guid.Empty : dataSourceRequest.PrimaryColumnValue;
			var row = new Entity();
			GetVirtualDataSource().Rows.Add(row);*/
		}

		public virtual void PrepareSearch() {
			Page.ClearSearchButton.Hide();
			Page.ClearSearchButton.Image.Source = Terrasoft.UI.WebControls.ControlImageSource.ResourceManager;
			Page.ClearSearchButton.Image.ResourceManagerName = "Terrasoft.UI.WebControls";
			Page.ClearSearchButton.Image.ResourceItemName = "toolbutton-close.gif";
			var userConnection = Page.UserConnection;
			var columns = GetVirtualDataSource().DefStructure.Columns;
			
			foreach(var column in columns) {
				if (column.IsVisible && column.DataValueType.Name == "Text"){
					var newItem = new Terrasoft.UI.WebControls.Controls.ListItem(column.Caption, column.Name);
					Page.FieldsList.Items.Add(newItem);
				}
			}
			if (Page.FieldsList.Items.Count > 0) {
				Page.FieldsList.SelectItem(Page.FieldsList.Items[0].Value);
			}
			Page.SearchEdit.Focus();
			
			var script = new StringBuilder(@"function onSearchEditSpecialKey(el, e) {
				var key = e.getKey();
				switch (key) {
					case e.ENTER : ");
			script.AppendFormat("{0}.fireEvent(\"click\");\n", Page.SearchButton.ClientID);		
			script.Append("\nbreak;\ndefault :\nbreak;\n}\n}");
			script.Append(string.Format("{0}.on('specialkey', onSearchEditSpecialKey);", Page.SearchEdit.ClientID));
			script.Append(string.Format("{0}.on('specialkey', onSearchEditSpecialKey);", Page.FieldsList.ClientID));
			Page.ScriptManager.AddScript(script.ToString());
			return;
		}

		public virtual void FormFilteredList(string columnName, string searchText) {
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClick")) {
							context.QueueTasks.Enqueue("OKButtonClick");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClick")) {
							context.QueueTasks.Enqueue("CancelButtonClick");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("Init")) {
							context.QueueTasks.Enqueue("Init");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "ClearSearchButtonClick":
							if (ActivatedEventElements.Contains("ClearSearchButtonClick")) {
							context.QueueTasks.Enqueue("ClearSearchButtonClick");
						}
						break;
					case "SearchButtonClick":
							if (ActivatedEventElements.Contains("SearchButtonClick")) {
							context.QueueTasks.Enqueue("SearchButtonClick");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("UseFilteredList") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UseFilteredList", UseFilteredList, false);
			}
			if (!HasMapping("VirtualDataSourceID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("VirtualDataSourceID", VirtualDataSourceID, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseVirtualDataGridPageEventsProcess

	/// <exclude/>
	public class BaseVirtualDataGridPageEventsProcess : BaseVirtualDataGridPageEventsProcess<Terrasoft.WebApp.BaseVirtualDataGridPageSchemaUserControl>
	{

		public BaseVirtualDataGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseVirtualDataGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseVirtualDataGridPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout SearchControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SearchControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FieldsList {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("FieldsList", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SearchEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SearchEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ClearSearchButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ClearSearchButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SearchButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SearchButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("TreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OKButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OKButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("DataSource", true);
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
			ClearSearchButton.AjaxEvents.Click.Event += ClearSearchButtonClick;
			SearchButton.AjaxEvents.Click.Event += SearchButtonClick;
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ClearSearchButton.AjaxEvents.Click.Event -= ClearSearchButtonClick;
			SearchButton.AjaxEvents.Click.Event -= SearchButtonClick;
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseVirtualDataGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseVirtualDataGridPageEventsProcess(UserConnection);
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

		public virtual void ClearSearchButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ClearSearchButtonClick");
		}

		public virtual void SearchButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SearchButtonClick");
		}

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
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
			SchemaName = "BaseVirtualDataGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseVirtualDataGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseVirtualDataGridPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseVirtualDataGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseVirtualDataGridPageEventsProcessSchema(BaseVirtualDataGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseVirtualDataGridPageEventsProcess";
			UId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed");
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

		protected virtual ProcessSchemaParameter CreateVirtualDataSourceIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7362c75e-9ef8-4c25-88ce-12975f077194"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"VirtualDataSourceID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUseFilteredListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("561f2fdc-7d47-4f3a-b923-5e53da33d8a2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"UseFilteredList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateVirtualDataSourceIDParameter());
			Parameters.Add(CreateUseFilteredListParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaEventSubProcess okbuttonclickeventsubprocess = CreateOKButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess cancelbuttonclickeventsubprocess = CreateCancelButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(cancelbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent okbuttonclick = CreateOKButtonClickStartMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclick);
			ProcessSchemaScriptTask scriptokbuttonclick = CreateScriptOKButtonClickScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(scriptokbuttonclick);
			ProcessSchemaStartMessageEvent cancelbuttonclick = CreateCancelButtonClickStartMessageEvent();
			cancelbuttonclickeventsubprocess.FlowElements.Add(cancelbuttonclick);
			ProcessSchemaScriptTask scriptcancelbuttonclick = CreateScriptCancelButtonClickScriptTask();
			cancelbuttonclickeventsubprocess.FlowElements.Add(scriptcancelbuttonclick);
			ProcessSchemaStartMessageEvent init = CreateInitStartMessageEvent();
			eventsubprocess1.FlowElements.Add(init);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			eventsubprocess1.FlowElements.Add(scriptinit);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			eventsubprocess2.FlowElements.Add(scriptpageloadcomplete);
			ProcessSchemaStartMessageEvent clearsearchbuttonclick = CreateClearSearchButtonClickStartMessageEvent();
			eventsubprocess4.FlowElements.Add(clearsearchbuttonclick);
			ProcessSchemaScriptTask scriptclearsearchbuttonclick = CreateScriptClearSearchButtonClickScriptTask();
			eventsubprocess4.FlowElements.Add(scriptclearsearchbuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent throwsearchbuttonclick = CreateThrowSearchButtonClickIntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(throwsearchbuttonclick);
			ProcessSchemaStartMessageEvent searchbuttonclick = CreateSearchButtonClickStartMessageEvent();
			eventsubprocess3.FlowElements.Add(searchbuttonclick);
			ProcessSchemaScriptTask scriptsearchbuttonclick = CreateScriptSearchButtonClickScriptTask();
			eventsubprocess3.FlowElements.Add(scriptsearchbuttonclick);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatePageCaptionLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatePageCaptionLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fc45d587-34d8-485f-b9e2-00acb19a6932"),
				Name = "PageCaptionLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("dfe3dfb5-8f51-4031-b44a-b6c9f03d673a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("715170c5-0d63-444a-b764-53df85372702"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1820bd42-f8cd-4991-b4a2-b299670a2703"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5d060438-878f-4a26-a0ee-3f95568d08df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6eedab9b-32cf-4487-ab54-8092268416d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("548ea5c3-47fe-4a2e-b5d5-6836682cea23"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("9da8e08f-96a4-4b8e-97b5-8694177b88e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(144, 255),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e2c6df8-dbb2-495d-86af-48a1ea0d1237"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b1df252-74ff-4d95-b487-9d32c5213b75"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("c3020c71-e8d0-4c81-8a0b-e9da293f1a16"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(340, 257),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("471397d1-961e-4163-b175-b9390f667408"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("10cd065c-c4e6-4a9f-a21b-f6c364952cb7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b4b45c3a-16cb-402e-870f-f79193c641b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("82f4f347-da96-4d3b-a45f-9d8989ce0664"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3dd28bd3-fa49-491f-bb37-f1abcfb29a54"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("bd86875d-0137-4a06-891b-88cbea1dc871"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8216b4fc-dd59-47b8-9f5c-0fce402dbfe7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a285f61f-fa96-4539-be01-b8446a55d790"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("b9b8f193-944d-484e-9db0-0c005fc70df8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CurveCenterPosition = new Point(244, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a285f61f-fa96-4539-be01-b8446a55d790"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad7312b7-deb7-4f8d-acd6-88413dd7f4bd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6e013781-3eda-4858-a880-1de507b2287f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(608, 503),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("7a5af51a-fc66-454c-88e5-5cbab9c47b41"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("6e013781-3eda-4858-a880-1de507b2287f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"Lane1",
				Position = new Point(29, 328),
				Size = new Size(579, 175),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("b1262df0-12d1-4602-a65a-5a4b963600fc"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("6e013781-3eda-4858-a880-1de507b2287f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"Lane2",
				Position = new Point(29, 164),
				Size = new Size(579, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("7004462f-2341-4552-b968-f8a629de46c9"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6e013781-3eda-4858-a880-1de507b2287f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"Lane4",
				Position = new Point(29, 0),
				Size = new Size(579, 159),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOKButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOKButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("62fe49d2-52d7-42da-ac6e-226c972a26db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1262df0-12d1-4602-a65a-5a4b963600fc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"OKButtonClickEventSubProcess",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOKButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6eedab9b-32cf-4487-ab54-8092268416d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62fe49d2-52d7-42da-ac6e-226c972a26db"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"OKButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOKButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("548ea5c3-47fe-4a2e-b5d5-6836682cea23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62fe49d2-52d7-42da-ac6e-226c972a26db"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ScriptOKButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,243,247,118,42,45,41,201,207,115,206,201,76,206,214,208,180,230,229,210,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,96,157,69,169,37,165,69,121,10,37,69,165,169,214,0,88,137,121,13,90,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cb09a38b-0c5d-4c9f-b8e7-8f7e8bb958e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1262df0-12d1-4602-a65a-5a4b963600fc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"CancelButtonClickEventSubProcess",
				Position = new Point(225, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(183, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("715170c5-0d63-444a-b764-53df85372702"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb09a38b-0c5d-4c9f-b8e7-8f7e8bb958e9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"CancelButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCancelButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1820bd42-f8cd-4991-b4a2-b299670a2703"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb09a38b-0c5d-4c9f-b8e7-8f7e8bb958e9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ScriptCancelButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("da6a0d88-a7ae-446f-b153-05ad5be93707"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a5af51a-fc66-454c-88e5-5cbab9c47b41"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0e2c6df8-dbb2-495d-86af-48a1ea0d1237"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da6a0d88-a7ae-446f-b153-05ad5be93707"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"Init",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2b1df252-74ff-4d95-b487-9d32c5213b75"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da6a0d88-a7ae-446f-b153-05ad5be93707"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ScriptInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,143,155,48,16,61,195,175,176,56,25,53,242,31,64,57,164,33,221,34,109,218,40,201,166,199,149,55,76,82,175,136,157,14,38,217,168,234,127,239,24,16,80,32,85,187,23,132,61,95,111,222,60,207,78,161,45,100,22,75,43,55,166,192,61,36,49,155,178,96,41,149,222,245,77,65,228,95,36,178,75,255,158,2,52,92,217,192,159,135,236,167,239,149,9,7,182,36,246,127,69,254,74,30,65,108,17,224,1,85,42,146,19,29,31,85,110,29,130,45,32,202,220,28,172,248,6,47,179,243,57,232,123,63,128,93,155,235,220,232,131,58,126,150,58,205,0,217,212,75,33,131,163,180,192,219,248,185,65,16,11,109,149,85,144,87,63,55,134,230,74,232,60,207,243,189,220,162,210,71,118,70,117,146,120,155,155,172,56,233,47,242,228,218,10,146,52,136,238,249,236,100,86,144,147,71,169,28,152,206,37,31,228,10,197,214,108,202,28,60,140,124,207,209,184,47,145,215,220,181,196,52,61,241,97,177,176,196,130,96,11,212,117,124,228,104,244,7,35,17,179,87,249,182,184,128,182,185,88,195,201,92,32,21,139,55,139,114,37,145,224,88,192,92,204,210,148,187,218,45,83,79,137,35,155,202,91,52,89,46,154,159,38,136,7,8,63,10,200,109,48,97,190,215,57,252,71,142,165,73,65,172,229,53,36,34,254,13,183,59,178,15,83,214,204,214,188,188,194,222,178,28,116,10,56,97,77,204,12,143,57,131,82,117,93,161,110,136,100,26,208,136,62,235,81,212,125,144,219,16,16,5,118,134,83,57,114,112,145,237,245,115,13,149,215,137,196,106,100,116,110,80,195,244,31,225,64,242,124,52,50,253,91,135,109,64,191,207,234,77,124,39,13,150,22,30,172,16,206,18,225,147,202,220,144,131,123,117,221,111,221,205,251,10,83,129,108,200,232,56,205,142,173,113,139,112,157,147,228,115,78,154,168,224,220,67,236,60,233,253,144,243,251,0,127,213,173,173,205,213,175,91,242,233,62,78,184,180,4,1,91,9,187,7,51,192,21,246,247,82,103,199,165,163,138,74,226,136,221,233,15,74,21,12,243,85,182,200,111,221,105,153,20,123,218,3,64,76,28,218,195,88,189,184,227,16,249,93,119,81,9,148,94,105,6,18,221,115,112,175,33,165,208,82,179,219,219,25,150,82,19,26,218,172,140,199,35,247,97,5,246,41,7,36,154,52,77,66,25,45,104,93,215,246,21,154,139,162,193,184,103,84,95,241,96,44,145,19,234,28,129,38,58,80,73,3,151,143,33,155,252,65,0,101,169,215,35,221,64,244,27,66,228,180,48,222,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("436fa17b-bfda-4a2e-95e8-a0fa0381b3fd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a5af51a-fc66-454c-88e5-5cbab9c47b41"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 6),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("471397d1-961e-4163-b175-b9390f667408"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("436fa17b-bfda-4a2e-95e8-a0fa0381b3fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
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
				UId = new Guid("10cd065c-c4e6-4a9f-a21b-f6c364952cb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("436fa17b-bfda-4a2e-95e8-a0fa0381b3fd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ScriptPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,140,189,10,2,49,16,132,123,193,119,72,153,52,251,2,135,133,156,40,194,21,199,197,159,122,61,87,13,132,108,216,108,240,245,53,98,167,213,240,205,124,204,54,196,120,10,162,21,227,6,21,61,87,153,201,238,72,127,75,231,186,229,226,255,2,3,227,117,226,103,177,205,177,35,222,9,214,37,183,52,88,204,129,68,176,240,77,225,184,135,51,93,122,78,42,28,11,52,193,65,143,89,3,39,179,50,141,191,52,248,247,211,40,148,81,200,19,202,252,248,124,11,105,149,100,84,42,117,47,169,200,176,243,188,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f9a4d1bf-1387-4d34-8103-89ed680b9dad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7004462f-2341-4552-b968-f8a629de46c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"EventSubProcess4",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateClearSearchButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8216b4fc-dd59-47b8-9f5c-0fce402dbfe7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9a4d1bf-1387-4d34-8103-89ed680b9dad"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ClearSearchButtonClick",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ClearSearchButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptClearSearchButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a285f61f-fa96-4539-be01-b8446a55d790"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9a4d1bf-1387-4d34-8103-89ed680b9dad"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ScriptClearSearchButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,78,77,44,74,206,112,77,201,44,209,11,73,173,40,81,176,85,40,46,41,202,204,75,215,115,205,45,40,169,180,230,10,45,78,117,203,204,41,73,45,74,77,241,201,44,6,201,167,37,230,20,167,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,191,135,169,36,74,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowSearchButtonClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ad7312b7-deb7-4f8d-acd6-88413dd7f4bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9a4d1bf-1387-4d34-8103-89ed680b9dad"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SearchButtonClick",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ThrowSearchButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5a468641-009d-4545-8096-b1ab0db366d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7004462f-2341-4552-b968-f8a629de46c9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"EventSubProcess3",
				Position = new Point(309, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(183, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSearchButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("82f4f347-da96-4d3b-a45f-9d8989ce0664"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a468641-009d-4545-8096-b1ab0db366d8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SearchButtonClick",
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"SearchButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSearchButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3dd28bd3-fa49-491f-bb37-f1abcfb29a54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a468641-009d-4545-8096-b1ab0db366d8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Name = @"ScriptSearchButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,205,78,195,48,16,132,207,141,148,119,48,55,71,66,126,129,138,11,37,41,149,170,130,72,233,221,138,151,214,210,58,110,215,235,22,132,120,119,28,151,159,66,17,215,217,153,209,183,179,215,36,2,104,234,54,75,120,102,113,37,238,245,26,84,155,149,218,88,86,131,60,46,11,251,36,100,96,178,253,90,213,110,203,47,170,222,69,141,65,126,103,171,74,188,150,197,40,231,39,152,228,99,201,117,100,246,189,186,181,6,100,53,30,149,197,155,0,12,240,159,183,221,248,67,242,38,107,89,236,191,248,38,30,163,235,23,218,193,39,101,99,1,77,152,219,192,9,24,161,99,48,51,6,167,86,26,35,164,120,89,52,158,92,99,145,129,192,12,62,249,187,234,242,228,249,42,71,114,243,146,0,166,100,205,17,46,179,60,6,56,109,74,12,23,31,123,204,194,34,34,222,81,222,69,254,236,75,17,92,89,226,180,213,141,102,221,250,72,29,200,41,240,185,88,13,254,191,47,106,238,181,121,240,135,144,73,8,56,82,47,152,210,147,239,205,95,218,156,191,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnOKButtonClickMethod());
			Methods.Add(CreateGetVirtualDataSourceMethod());
			Methods.Add(CreateFillVirtualDataSourceMethod());
			Methods.Add(CreateCreateVirtualDataSourceStructureMethod());
			Methods.Add(CreateDataSource_RemovedMethod());
			Methods.Add(CreateOnDataSourceLoadingRowMethod());
			Methods.Add(CreatePrepareSearchMethod());
			Methods.Add(CreateFormFilteredListMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dc56818e-6055-45fc-a193-588e5b25bbbc"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateOnOKButtonClickMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("36c606c1-a99e-4fd4-8452-2c5127ced98d"),
				Name = "OnOKButtonClick",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4fe47fdb-fb3e-4963-a17d-0515f6dac73e"),
				Name = "GetVirtualDataSource",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,48,145,162,252,28,141,176,204,162,146,210,196,28,151,196,146,196,224,252,210,162,228,84,79,23,77,133,196,98,5,12,113,107,0,231,40,17,24,84,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ad557f97-d598-4b7b-8ce9-128f18277ff5"),
				Name = "FillVirtualDataSource",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("40729fcd-c770-4e3d-9e58-ea3fce80d7f3"),
				Name = "virtualDataSource",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("452cee2e-a4e3-42a0-b071-fa82b3861304"),
				Name = "CreateVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b4e494e1-946b-4fa8-8d48-1e9516b6babd"),
				Name = "dataValueTypeManager",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueTypeManager",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7089911c-a2c4-4810-aa26-e5e38fa48930"),
				Name = "defStructure",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceStructure",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,81,79,194,48,16,126,222,126,69,233,19,3,50,227,51,241,1,1,13,17,149,56,64,19,99,76,93,15,108,220,90,210,118,234,98,252,239,94,59,81,144,25,140,79,219,125,247,221,245,187,251,238,160,21,54,26,141,225,77,239,124,50,30,226,95,200,97,145,88,93,164,182,208,16,79,180,200,153,46,251,42,43,114,121,193,114,32,71,132,38,165,153,25,208,35,78,187,181,236,129,48,171,140,213,23,185,16,203,158,153,38,32,173,176,101,146,62,66,206,206,153,100,75,208,72,156,224,55,118,204,190,146,18,82,43,148,140,135,187,204,170,69,234,159,192,42,9,47,100,192,44,75,84,161,83,248,82,84,73,32,111,97,240,67,6,237,132,193,156,101,5,252,54,25,230,247,142,225,56,248,166,239,51,45,87,46,207,55,227,79,169,241,41,216,145,52,150,201,20,142,75,87,217,164,99,165,158,138,21,141,176,197,21,44,64,3,230,170,249,102,35,142,125,106,118,83,215,6,213,244,120,46,228,76,10,75,163,24,107,119,27,110,40,255,230,238,210,106,157,174,22,209,103,43,103,3,2,215,74,243,123,55,63,162,35,51,23,70,60,100,142,136,251,6,15,37,74,91,182,133,93,106,14,122,32,116,101,37,226,219,64,220,51,41,72,46,228,114,205,157,40,35,62,169,135,225,251,143,11,235,113,94,41,108,86,214,71,221,240,239,55,16,172,175,64,88,200,227,51,40,59,14,219,61,131,173,244,127,29,158,194,171,245,254,6,27,251,243,157,125,245,45,245,39,116,23,79,21,42,197,241,155,81,155,80,210,164,164,77,10,3,124,44,82,226,0,23,251,173,159,104,149,87,72,27,207,190,144,214,5,17,245,15,212,88,17,108,155,177,96,153,1,68,113,159,65,176,103,163,173,131,15,36,44,245,11,20,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_RemovedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7572936a-535b-4017-8d48-2e14f04710c9"),
				Name = "DataSource_Removed",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("507db204-f2f0-4178-b682-8ff666560b58"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,141,209,10,194,32,24,133,239,125,10,221,149,238,194,61,192,232,34,150,129,176,64,136,168,91,209,159,26,108,74,191,147,234,237,115,217,213,57,124,7,206,215,181,148,49,166,110,251,147,25,85,105,228,0,51,172,64,125,141,29,13,240,162,149,113,99,239,32,47,9,112,136,33,128,91,167,24,132,60,98,92,120,115,254,164,113,114,219,214,8,121,125,0,194,143,109,64,251,130,116,82,207,108,103,62,196,57,47,65,26,139,118,41,151,200,17,92,68,175,189,16,212,166,191,168,39,213,46,213,27,92,46,98,209,147,182,251,2,131,237,147,178,170,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnDataSourceLoadingRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("43b0034d-b5b6-4a5d-957c-3794620a98df"),
				Name = "OnDataSourceLoadingRow",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("66c7572a-82bd-4f2f-9d06-77a1941988c8"),
				Name = "dataSourceRequest",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceRequest",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,140,177,10,131,48,16,64,247,124,197,185,169,67,220,43,82,164,13,82,104,65,44,72,215,96,110,8,196,164,61,239,42,254,125,237,210,165,219,27,222,123,85,169,178,44,51,143,246,214,95,205,78,170,19,239,128,112,74,228,46,14,26,0,103,217,222,147,208,132,3,190,4,23,134,166,129,40,33,192,17,190,178,54,243,147,55,56,252,139,186,39,63,91,218,78,41,200,28,71,27,4,107,245,182,4,148,214,253,28,113,5,19,217,243,150,23,181,234,144,71,79,44,54,156,127,159,188,208,67,90,23,221,58,151,239,77,81,151,213,7,43,211,20,226,176,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareSearchMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30c84cc3-7e58-4d56-991f-41acd9f3f070"),
				Name = "PrepareSearch",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,203,110,26,49,20,93,15,18,255,96,205,34,241,72,212,98,29,212,170,9,143,22,181,141,162,64,232,162,116,97,60,119,192,194,216,35,63,146,162,136,127,175,31,67,3,148,40,221,84,154,145,172,235,115,207,57,247,49,115,71,151,64,250,2,168,158,248,151,173,110,156,181,74,146,207,188,4,92,244,218,173,187,243,247,227,77,136,79,148,211,12,208,123,52,5,173,169,81,149,37,15,99,242,29,22,125,37,173,86,194,144,230,16,225,9,77,238,193,196,195,55,42,125,80,191,165,113,2,191,165,155,32,152,191,166,152,255,43,223,216,194,102,79,102,149,18,139,8,122,199,132,50,64,150,188,10,68,143,84,35,103,64,123,114,9,204,114,37,61,58,178,63,28,69,27,40,83,194,109,164,241,152,79,96,103,92,91,71,197,128,90,154,10,199,5,25,64,53,177,218,49,235,180,55,152,208,62,183,221,170,148,6,202,86,248,133,5,113,185,231,43,208,115,187,149,241,10,225,20,32,99,51,227,134,47,4,160,139,139,6,68,130,206,140,10,7,211,109,13,36,21,22,219,244,203,230,69,200,207,2,183,132,167,80,183,119,232,79,111,78,205,144,175,220,216,144,176,87,238,211,58,212,219,217,171,6,157,176,37,89,22,187,50,226,32,74,19,146,72,200,50,228,186,44,113,163,25,97,187,118,203,63,161,148,243,248,190,114,210,162,15,168,155,106,62,5,77,64,248,134,71,67,103,243,127,116,127,146,216,132,32,182,107,22,33,237,192,176,228,150,140,20,115,38,174,117,26,152,97,154,215,182,233,134,159,12,151,203,27,199,69,9,26,127,204,43,39,211,200,149,124,161,152,212,192,56,21,95,96,139,65,116,16,36,159,129,107,13,91,79,228,87,7,108,184,141,229,154,39,110,217,10,97,127,151,128,25,163,6,60,104,120,59,29,222,163,43,148,7,88,114,65,174,235,26,100,57,82,122,67,45,206,159,187,59,82,113,13,195,71,144,22,207,115,38,56,91,207,61,126,46,243,14,58,40,172,89,238,190,224,30,56,30,20,189,44,59,161,196,249,92,46,252,126,173,125,110,9,21,117,194,162,171,151,208,206,63,127,251,192,38,182,131,28,250,81,18,95,154,212,0,95,209,101,231,149,206,20,189,99,135,177,245,127,252,253,31,165,131,77,56,82,74,54,162,92,243,3,9,59,153,2,184,177,49,85,105,244,56,102,104,240,95,167,236,253,6,180,194,249,129,24,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFormFilteredListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("97e6d8a0-c2a2-4a31-91a2-209d0b3cc1be"),
				Name = "FormFilteredList",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("34bca3b2-9d23-4b73-a684-407a78e836ab"),
				Name = "columnName",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fdb2cc67-5797-4f23-a9c0-259fec2c0e19"),
				Name = "searchText",
				CreatedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				ModifiedInSchemaUId = new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseVirtualDataGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b3aeb85-95f4-468f-86d3-46aa6833e6ed"));
		}

		#endregion

	}

	#endregion

}

