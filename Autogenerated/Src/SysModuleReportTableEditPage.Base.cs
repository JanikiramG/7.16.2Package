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
	using System.IO;
	using System.Linq;
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
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysModuleReportTableEditPageSchema

	/// <exclude/>
	public class SysModuleReportTableEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _objectEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return _objectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _objectColumnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ObjectColumnEdit {
			get {
				return _objectColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _objectPathButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ObjectPathButton {
			get {
				return _objectPathButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _referenceColumnEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ReferenceColumnEdit {
			get {
				return _referenceColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _referencePathButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ReferencePathButton {
			get {
				return _referencePathButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isEmptyTableHideEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsEmptyTableHideEdit {
			get {
				return _isEmptyTableHideEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _dataTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel DataTabPanel {
			get {
				return _dataTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _tableFieldsTab;
		public Terrasoft.UI.WebControls.Controls.Tab TableFieldsTab {
			get {
				return _tableFieldsTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _sysModuleReportTableFieldsGridPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer SysModuleReportTableFieldsGridPageContainer {
			get {
				return _sysModuleReportTableFieldsGridPageContainer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _tableFilterTab;
		public Terrasoft.UI.WebControls.Controls.Tab TableFilterTab {
			get {
				return _tableFilterTab;
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

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _filterDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource FilterDataSource {
			get {
				return _filterDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleReportTableEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportTableEditPageSchema(SysModuleReportTableEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Height = System.Web.UI.WebControls.Unit.Percentage(0);
			CustomControls.Image = new ControlImage {};
			CustomControls.Hidden = true;
			CustomControls.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.AutoScroll = false;
			MainControlLayout.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			RealUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			Name = "SysModuleReportTableEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 450;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportTableEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateObjectEdit());
			MainControlLayout.InsertItem(1, CreateCaptionEdit());
			MainControlLayout.InsertItem(2, CreateObjectColumnEdit());
			ObjectColumnEdit.InsertItem(0, CreateObjectPathButton());
			MainControlLayout.InsertItem(3, CreateReferenceColumnEdit());
			ReferenceColumnEdit.InsertItem(0, CreateReferencePathButton());
			MainControlLayout.InsertItem(4, CreateIsEmptyTableHideEdit());
			MainControlLayout.MoveItem(5, CustomControls);
			MainControlLayout.InsertItem(6, CreateDataTabPanel());
			DataTabPanel.InsertItem(0, CreateTableFieldsTab());
			TableFieldsTab.InsertItem(0, CreateSysModuleReportTableFieldsGridPageContainer());
			DataTabPanel.InsertItem(1, CreateTableFilterTab());
			TableFilterTab.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateLabel1());
			ControlLayout1.InsertItem(1, CreateFilterEdit());
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			Controls.AddAt(4, CreateFilterDataSource());
			UpdateFilterDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportTableEditPageEventsProcessSchema() {
			var schema = new SysModuleReportTableEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectEdit() {
			_objectEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectEdit.UId = new Guid("84fdc88b-6a6c-4b89-90cf-643decdb0d5d");
			_objectEdit.Name = "ObjectEdit";
			_objectEdit.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_objectEdit.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_objectEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectEdit.Tag = "";
			_objectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectEdit.Image = new ControlImage {};
			_objectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectEdit.Margins = "0 0 5 0";
			_objectEdit.ColumnUId = new Guid("5b44a839-d269-4f55-b9fc-3bc8aa7f4805");
			_objectEdit.Required = true;
			_objectEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _objectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionEdit.UId = new Guid("3767e2af-f98a-4894-846d-c1c6406852fa");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_captionEdit.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Margins = "0";
			_captionEdit.DataSource = "DataSource";
			_captionEdit.ColumnUId = new Guid("e46461f9-48b3-437e-b636-81dc629367e7");
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateObjectPathButton() {
			_objectPathButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_objectPathButton.UId = new Guid("6a6db629-c203-4d5c-bd59-5c178fb245ae");
			_objectPathButton.Name = "ObjectPathButton";
			_objectPathButton.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_objectPathButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_objectPathButton.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			_objectPathButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_objectPathButton.Tag = "";
			_objectPathButton.Image = new ControlImage {};
			return _objectPathButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateObjectColumnEdit() {
			_objectColumnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_objectColumnEdit.UId = new Guid("5289cd45-fd41-4da8-86b0-af9f149cee4b");
			_objectColumnEdit.Name = "ObjectColumnEdit";
			_objectColumnEdit.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_objectColumnEdit.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_objectColumnEdit.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			_objectColumnEdit.Tag = "";
			_objectColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectColumnEdit.Image = new ControlImage {};
			_objectColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectColumnEdit.DataSource = "DataSource";
			_objectColumnEdit.ColumnUId = new Guid("dae82cd3-8303-4b3e-8149-affd9bf0d914");
			_objectColumnEdit.Required = true;
			return _objectColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateReferencePathButton() {
			_referencePathButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_referencePathButton.UId = new Guid("2f4af382-dbbd-4b19-9254-76da190b1bd0");
			_referencePathButton.Name = "ReferencePathButton";
			_referencePathButton.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_referencePathButton.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_referencePathButton.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			_referencePathButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_referencePathButton.Tag = "";
			_referencePathButton.Image = new ControlImage {};
			return _referencePathButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateReferenceColumnEdit() {
			_referenceColumnEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_referenceColumnEdit.UId = new Guid("620ebb32-c721-4d97-9b1b-cf96348b7489");
			_referenceColumnEdit.Name = "ReferenceColumnEdit";
			_referenceColumnEdit.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_referenceColumnEdit.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_referenceColumnEdit.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			_referenceColumnEdit.Tag = "";
			_referenceColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_referenceColumnEdit.Image = new ControlImage {};
			_referenceColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_referenceColumnEdit.DataSource = "DataSource";
			_referenceColumnEdit.ColumnUId = new Guid("48a5bd14-0d37-4789-b828-c3d38ea3eb9e");
			_referenceColumnEdit.Required = true;
			return _referenceColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsEmptyTableHideEdit() {
			_isEmptyTableHideEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isEmptyTableHideEdit.UId = new Guid("96d4da6f-8efb-4f4f-9012-742f8d00965e");
			_isEmptyTableHideEdit.Name = "IsEmptyTableHideEdit";
			_isEmptyTableHideEdit.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_isEmptyTableHideEdit.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_isEmptyTableHideEdit.CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			_isEmptyTableHideEdit.Tag = "";
			_isEmptyTableHideEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isEmptyTableHideEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isEmptyTableHideEdit.DataSource = "DataSource";
			_isEmptyTableHideEdit.ColumnUId = new Guid("a0715233-de5a-42f8-af8b-ad904d82e003");
			return _isEmptyTableHideEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateSysModuleReportTableFieldsGridPageContainer() {
			_sysModuleReportTableFieldsGridPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_sysModuleReportTableFieldsGridPageContainer.UId = new Guid("40f4e5cc-a96e-4ea2-9733-cab8bbc93148");
			_sysModuleReportTableFieldsGridPageContainer.Name = "SysModuleReportTableFieldsGridPageContainer";
			_sysModuleReportTableFieldsGridPageContainer.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_sysModuleReportTableFieldsGridPageContainer.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_sysModuleReportTableFieldsGridPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysModuleReportTableFieldsGridPageContainer.Tag = "";
			_sysModuleReportTableFieldsGridPageContainer.PageSchemaUId = new Guid("f293afc3-6364-44e9-b083-cf349186572a");
			_sysModuleReportTableFieldsGridPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleReportTableFieldsGridPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleReportTableFieldsGridPageContainer.StartNewAlignGroup = false;
			_sysModuleReportTableFieldsGridPageContainer.Edges = "";
			return _sysModuleReportTableFieldsGridPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateTableFieldsTab() {
			_tableFieldsTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_tableFieldsTab.UId = new Guid("fd8f31c0-6427-4fa2-b000-61bc4170c2f3");
			_tableFieldsTab.Name = "TableFieldsTab";
			_tableFieldsTab.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_tableFieldsTab.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_tableFieldsTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_tableFieldsTab.Tag = "";
			_tableFieldsTab.Image = new ControlImage {};
			return _tableFieldsTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("737e8349-1326-4791-9be9-b6da9824657f");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_label1.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("ebf15181-50c5-4a4d-949e-dbef5932653d");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_filterEdit.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "FilterDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.HasSplitter = true;
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("a0da1ba1-f94c-45a3-b4d8-807d327cba79");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_controlLayout1.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Padding = "5 5 5 5";
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateTableFilterTab() {
			_tableFilterTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_tableFilterTab.UId = new Guid("484ec7b2-3058-4936-ac97-388af75a5190");
			_tableFilterTab.Name = "TableFilterTab";
			_tableFilterTab.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_tableFilterTab.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_tableFilterTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_tableFilterTab.Tag = "";
			_tableFilterTab.Image = new ControlImage {};
			return _tableFilterTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateDataTabPanel() {
			_dataTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_dataTabPanel.UId = new Guid("528f971f-6d05-4750-8e68-f2492d820c04");
			_dataTabPanel.Name = "DataTabPanel";
			_dataTabPanel.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_dataTabPanel.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_dataTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataTabPanel.Tag = "";
			_dataTabPanel.ActiveTabIndex = 0;
			_dataTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_dataTabPanel.StartNewAlignGroup = false;
			_dataTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _dataTabPanel;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("fa05df4e-0361-4496-8198-5aa5b2dbe677");
			DataSource.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("cd9b2561-78ed-4dd9-afd4-bab3b356565e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c2c0fd56-8261-4b68-96c6-d33fe72ec0cd");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("22383b4f-9b2f-4375-982d-87b4341b5bb6");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("062c6c93-ed44-4ab2-bbf1-e938fb822a5d");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("71b34a7a-db4f-40a9-aacc-dbf97b6f3530");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("a0f51f5a-b96b-4608-a9e3-021f6b5450a3");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("154371d2-7624-4a1b-8019-e5c202c2260d");
			if (column != null) {
				column.UId = new Guid("92eeab11-1f99-48b6-a986-1b46b3621a2e");
				column.Name = @"MacrosList";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8501dbf4-1603-4e8b-b875-e1d9c8de5e8c");
			if (column != null) {
				column.UId = new Guid("3ce4d260-4648-4dbe-bd48-85eeae5e1728");
				column.Name = @"SysModuleReport";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("79a3fa68-aef2-4ed5-86d2-5fb4dc4a7ae3");
			if (column != null) {
				column.UId = new Guid("36cd902a-4afc-4ad5-b5b7-1e53f0599464");
				column.Name = @"ReferenceColumn";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("dcbcf570-397b-4c65-bc5c-ffc91e6cc60a");
			if (column != null) {
				column.UId = new Guid("85c330f6-efaf-49bb-a8f0-68d2e551d3f5");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2f560358-9c67-4ddb-8ae8-e9507c0faab9");
			if (column != null) {
				column.UId = new Guid("e46461f9-48b3-437e-b636-81dc629367e7");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("7ac8fc3b-9f5f-40d3-8918-3c18bc54cc23");
			if (column != null) {
				column.UId = new Guid("dae82cd3-8303-4b3e-8149-affd9bf0d914");
				column.Name = @"ObjectColumnCaption";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6e37e4a0-1c37-4475-83aa-dd218ff47173");
			if (column != null) {
				column.UId = new Guid("4cbbf72c-a870-4be3-8cd0-0f9b059e5cab");
				column.Name = @"ObjectColumnPath";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1a6de7b4-2b63-4983-989c-e5f5ad91c559");
			if (column != null) {
				column.UId = new Guid("48a5bd14-0d37-4789-b828-c3d38ea3eb9e");
				column.Name = @"ReferenceColumnCaption";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b368f76c-1279-4700-8914-e821390edfdd");
			if (column != null) {
				column.UId = new Guid("a0715233-de5a-42f8-af8b-ad904d82e003");
				column.Name = @"IsEmptyTableHide";
				column.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
			}
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateFilterDataSource() {
			_filterDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_filterDataSource.UId = new Guid("322b6c02-c61c-4bfc-a00f-c1c19ebf4c1b");
			_filterDataSource.Name = "FilterDataSource";
			_filterDataSource.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_filterDataSource.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_filterDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterDataSource.Tag = "";
			_filterDataSource.EnableServerActiveRow = false;
			_filterDataSource.SchemaUId = Guid.Empty;
			_filterDataSource.HierarchicalDepth = 1;
			_filterDataSource.DefStructure.ID = "c" + _filterDataSource.DefStructure.UId.ToString("N");
			_filterDataSource.DefStructure.UId = new Guid("83082011-933b-405a-af15-1ed404ee6d4c");
			_filterDataSource.DefStructure.Name = "DefStructure";
			_filterDataSource.DefStructure.CreatedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			_filterDataSource.DefStructure.ModifiedInSchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			return _filterDataSource;
		}

		protected virtual void UpdateFilterDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleReportTableEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportTableEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportTableEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableEditPageEventsProcess

	/// <exclude/>
	public class SysModuleReportTableEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportTableEditPageSchemaUserControl
	{

		#region Class: UserMessageUserTaskFlowElement

		/// <exclude/>
		public class UserMessageUserTaskFlowElement : QuestionUserTask
		{

			public UserMessageUserTaskFlowElement(UserConnection userConnection, SysModuleReportTableEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public SysModuleReportTableEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportTableEditPageEventsProcess";
			SchemaUId = new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dad5b1ac-f646-4eff-a51b-56f64272e1e9");
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

		public virtual bool ColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerRegistered {
			get;
			set;
		}

		public virtual Guid ParentEntityId {
			get;
			set;
		}

		public virtual Guid ParentEntitySchemaId {
			get;
			set;
		}

		public virtual string TableCaption {
			get;
			set;
		}

		public virtual Guid ParentEntitySchemaUId {
			get;
			set;
		}

		public virtual bool IsObjectColumn {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("04ed66b9-2c3b-4cce-8636-aed8a2d628b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectEditChangeStartMessage;
		public ProcessFlowElement ObjectEditChangeStartMessage {
			get {
				return _objectEditChangeStartMessage ?? (_objectEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectEditChangeStartMessage",
					SchemaElementUId = new Guid("1740d25f-24a2-4635-92f8-5dfca23f0a27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask6;
		public ProcessScriptTask ScriptTask6 {
			get {
				return _scriptTask6 ?? (_scriptTask6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6",
					SchemaElementUId = new Guid("6c484685-1d18-4beb-854b-4c06f226ce92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6Execute,
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
					SchemaElementUId = new Guid("69cd6b02-50db-4d0f-8579-15936db99315"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectPathButtonClick;
		public ProcessFlowElement ObjectPathButtonClick {
			get {
				return _objectPathButtonClick ?? (_objectPathButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectPathButtonClick",
					SchemaElementUId = new Guid("75a751d1-2189-48c8-b30a-227b3ea4eb2b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskObjectPathButtonClick;
		public ProcessScriptTask ScriptTaskObjectPathButtonClick {
			get {
				return _scriptTaskObjectPathButtonClick ?? (_scriptTaskObjectPathButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskObjectPathButtonClick",
					SchemaElementUId = new Guid("974f3f70-ec22-4f2b-892f-137f56bfd947"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskObjectPathButtonClickExecute,
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
					SchemaElementUId = new Guid("06c48d54-93ef-488e-9a46-7a4cb396caf7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _referencePathButtonClick;
		public ProcessFlowElement ReferencePathButtonClick {
			get {
				return _referencePathButtonClick ?? (_referencePathButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReferencePathButtonClick",
					SchemaElementUId = new Guid("16ef6d16-a0c3-4ca9-8ff4-c7ac772257b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _referencePathButtonClickScript;
		public ProcessScriptTask ReferencePathButtonClickScript {
			get {
				return _referencePathButtonClickScript ?? (_referencePathButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ReferencePathButtonClickScript",
					SchemaElementUId = new Guid("564529b0-9742-4ba7-87cc-b952e02f1589"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ReferencePathButtonClickScriptExecute,
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
					SchemaElementUId = new Guid("8b59fd8c-ffae-46f4-8f3c-d804f8e0fbb4"),
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
					SchemaElementUId = new Guid("713db9ea-4033-4fd2-9159-006efe418628"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("cd13ec4d-4fe4-4097-b954-377c40c4d64b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("2ff8ceec-228c-4845-bab8-6a1d285b3e93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("f2caf79b-61a5-4b10-ad02-810ac51c5a47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("dc21ef2f-832a-4a18-a30c-a90aac844cb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4;
		public ProcessScriptTask ScriptTask4 {
			get {
				return _scriptTask4 ?? (_scriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4",
					SchemaElementUId = new Guid("e43847b5-325c-40ef-a527-93cf88edfbab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("56d45b33-1102-4ca4-b56f-351acf7afc9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask5;
		public ProcessScriptTask ScriptTask5 {
			get {
				return _scriptTask5 ?? (_scriptTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5",
					SchemaElementUId = new Guid("9d55fec5-5905-40de-bd9e-113773e83ade"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
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
					SchemaElementUId = new Guid("64b49252-eeda-4676-b22e-49562d4efa8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _thisPageLoad;
		public ProcessFlowElement ThisPageLoad {
			get {
				return _thisPageLoad ?? (_thisPageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ThisPageLoad",
					SchemaElementUId = new Guid("79552a2b-4026-4562-a0c3-ba024b928063"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadScriptTask;
		public ProcessScriptTask PageLoadScriptTask {
			get {
				return _pageLoadScriptTask ?? (_pageLoadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadScriptTask",
					SchemaElementUId = new Guid("9fe94b9a-fa7f-4685-bcf8-a334cf20fac0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _basePageLoad;
		public ProcessThrowMessageEvent BasePageLoad {
			get {
				return _basePageLoad ?? (_basePageLoad = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BasePageLoad",
					SchemaElementUId = new Guid("d0c41a94-e291-4675-a5fd-e13f717df706"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickStartMessage;
		public ProcessFlowElement OKButtonClickStartMessage {
			get {
				return _oKButtonClickStartMessage ?? (_oKButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickStartMessage",
					SchemaElementUId = new Guid("4ddd6c82-d7df-4524-91eb-eeb127368e89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("2517778e-2e3f-4b12-8943-eb35591a5750"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("46bdae8b-6fdd-4491-a515-7627eb387dd1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private UserMessageUserTaskFlowElement _userMessageUserTask;
		public UserMessageUserTaskFlowElement UserMessageUserTask {
			get {
				return _userMessageUserTask ?? (_userMessageUserTask = new UserMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("16e4a632-7e22-42d8-9cd4-5c40c25b5f2e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask7;
		public ProcessScriptTask ScriptTask7 {
			get {
				return _scriptTask7 ?? (_scriptTask7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7",
					SchemaElementUId = new Guid("68e4562d-8ad2-47b7-a7a4-b9834987646c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7Execute,
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
					SchemaElementUId = new Guid("e5a0f858-4567-4ba6-82b2-3711bbc3a6de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userQuestionYesMessageStartMessage;
		public ProcessFlowElement UserQuestionYesMessageStartMessage {
			get {
				return _userQuestionYesMessageStartMessage ?? (_userQuestionYesMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserQuestionYesMessageStartMessage",
					SchemaElementUId = new Guid("8eb8cd90-9c23-46c8-bf70-af825c86b6fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _userQuestionYesMessageScriptTask;
		public ProcessScriptTask UserQuestionYesMessageScriptTask {
			get {
				return _userQuestionYesMessageScriptTask ?? (_userQuestionYesMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UserQuestionYesMessageScriptTask",
					SchemaElementUId = new Guid("b12009cc-88d4-4820-b57e-bd7c7b2867b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UserQuestionYesMessageScriptTaskExecute,
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
					SchemaElementUId = new Guid("ea102deb-4be9-498c-bc44-eff1527b5798"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userQuestionNoMessageStartMessage;
		public ProcessFlowElement UserQuestionNoMessageStartMessage {
			get {
				return _userQuestionNoMessageStartMessage ?? (_userQuestionNoMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserQuestionNoMessageStartMessage",
					SchemaElementUId = new Guid("e75b99d4-167b-441a-b845-2b487ca7950c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent4;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent4 {
			get {
				return _intermediateThrowMessageEvent4 ?? (_intermediateThrowMessageEvent4 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent4",
					SchemaElementUId = new Guid("3a82f190-1938-4e61-b7ec-f02bca1b5118"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("f8ccabf9-7554-44df-935b-3da1b895b53c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _userQuestionTitle;
		public LocalizableString UserQuestionTitle {
			get {
				return _userQuestionTitle ?? (_userQuestionTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UserQuestionTitle.Value"));
			}
		}

		private LocalizableString _objectColumnCaptionMask;
		public LocalizableString ObjectColumnCaptionMask {
			get {
				return _objectColumnCaptionMask ?? (_objectColumnCaptionMask = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ObjectColumnCaptionMask.Value"));
			}
		}

		private LocalizableString _referenceColumnCaptionMask;
		public LocalizableString ReferenceColumnCaptionMask {
			get {
				return _referenceColumnCaptionMask ?? (_referenceColumnCaptionMask = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ReferenceColumnCaptionMask.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ObjectEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeStartMessage };
			FlowElements[ScriptTask6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ObjectPathButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectPathButtonClick };
			FlowElements[ScriptTaskObjectPathButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskObjectPathButtonClick };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[ReferencePathButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ReferencePathButtonClick };
			FlowElements[ReferencePathButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ReferencePathButtonClickScript };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[ThisPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ThisPageLoad };
			FlowElements[PageLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadScriptTask };
			FlowElements[BasePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { BasePageLoad };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[OKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickStartMessage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[UserMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessageUserTask };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptTask7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[UserQuestionYesMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionYesMessageStartMessage };
			FlowElements[UserQuestionYesMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionYesMessageScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[UserQuestionNoMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionNoMessageStartMessage };
			FlowElements[IntermediateThrowMessageEvent4.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess7":
						break;
					case "ObjectEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask6");
						break;
					case "ScriptTask6":
						break;
					case "EventSubProcess1":
						break;
					case "ObjectPathButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskObjectPathButtonClick");
						break;
					case "ScriptTaskObjectPathButtonClick":
						break;
					case "EventSubProcess8":
						break;
					case "ReferencePathButtonClick":
						e.Context.QueueTasks.Enqueue("ReferencePathButtonClickScript");
						break;
					case "ReferencePathButtonClickScript":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						break;
					case "EventSubProcess9":
						break;
					case "ThisPageLoad":
						e.Context.QueueTasks.Enqueue("PageLoadScriptTask");
						break;
					case "PageLoadScriptTask":
						e.Context.QueueTasks.Enqueue("BasePageLoad");
						break;
					case "BasePageLoad":
						break;
					case "EventSubProcess3":
						break;
					case "OKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask7");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask3");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "ScriptTask3":
						e.Context.QueueTasks.Enqueue("UserMessageUserTask");
						break;
					case "UserMessageUserTask":
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "ScriptTask7":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "EventSubProcess4":
						break;
					case "UserQuestionYesMessageStartMessage":
						e.Context.QueueTasks.Enqueue("UserQuestionYesMessageScriptTask");
						break;
					case "UserQuestionYesMessageScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "UserQuestionNoMessageStartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent4");
						break;
					case "IntermediateThrowMessageEvent4":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList")));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ObjectEditChangeStartMessage");
			ActivatedEventElements.Add("ObjectPathButtonClick");
			ActivatedEventElements.Add("ReferencePathButtonClick");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("ThisPageLoad");
			ActivatedEventElements.Add("OKButtonClickStartMessage");
			ActivatedEventElements.Add("UserQuestionYesMessageStartMessage");
			ActivatedEventElements.Add("UserQuestionNoMessageStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "ObjectEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChangeStartMessage";
					result = ObjectEditChangeStartMessage.Execute(context);
					break;
				case "ScriptTask6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6";
					result = ScriptTask6.Execute(context, ScriptTask6Execute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ObjectPathButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectPathButtonClick";
					result = ObjectPathButtonClick.Execute(context);
					break;
				case "ScriptTaskObjectPathButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskObjectPathButtonClick";
					result = ScriptTaskObjectPathButtonClick.Execute(context, ScriptTaskObjectPathButtonClickExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "ReferencePathButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReferencePathButtonClick";
					result = ReferencePathButtonClick.Execute(context);
					break;
				case "ReferencePathButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReferencePathButtonClickScript";
					result = ReferencePathButtonClickScript.Execute(context, ReferencePathButtonClickScriptExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4";
					result = ScriptTask4.Execute(context, ScriptTask4Execute);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "ThisPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ThisPageLoad";
					result = ThisPageLoad.Execute(context);
					break;
				case "PageLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadScriptTask";
					result = PageLoadScriptTask.Execute(context, PageLoadScriptTaskExecute);
					break;
				case "BasePageLoad":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = BasePageLoad.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickStartMessage";
					result = OKButtonClickStartMessage.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "UserMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessageUserTask";
					result = UserMessageUserTask.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTask7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7";
					result = ScriptTask7.Execute(context, ScriptTask7Execute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "UserQuestionYesMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserQuestionYesMessageStartMessage";
					result = UserQuestionYesMessageStartMessage.Execute(context);
					break;
				case "UserQuestionYesMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserQuestionYesMessageScriptTask";
					result = UserQuestionYesMessageScriptTask.Execute(context, UserQuestionYesMessageScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "UserQuestionNoMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserQuestionNoMessageStartMessage";
					result = UserQuestionNoMessageStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent4":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent4.Execute(context);
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
				case "IsObjectColumn":
					IsObjectColumn = reader.GetValue<System.Boolean>();
				break;
				case "ParentEntitySchemaUId":
					ParentEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "TableCaption":
					TableCaption = reader.GetValue<System.String>();
				break;
				case "ParentEntitySchemaId":
					ParentEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "ParentEntityId":
					ParentEntityId = reader.GetValue<System.Guid>();
				break;
				case "ColumnStructureExplorerRegistered":
					ColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ColumnStructureExplorerCreated":
					ColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask6Execute(ProcessExecutingContext context) {
			Page.DataSource.ActiveRow.SetColumnValue("MacrosList", string.Empty);
			Page.DataSource.ActiveRow.SetColumnValue("ReferenceColumn", string.Empty);
			SetReferenceColumnList();
			Page.ReferenceColumnEdit.Caption = string.Format(ReferenceColumnCaptionMask, Page.ObjectEdit.Text);
			ResetControlValues();
			if (Page.ObjectEdit.Value != null 
				&& !string.IsNullOrEmpty(Page.ObjectEdit.Value.ToString())
				&& new Guid(Page.ObjectEdit.Value.ToString()) != Guid.Empty) {
				if (Page.FilterDataSource.Schema != null) {
					Page.FilterDataSource.Schema = null;
				}
				Page.FilterDataSource.SchemaUId = new Guid(Page.ObjectEdit.Value.ToString());
			} else {
				Page.FilterDataSource.SchemaUId = Guid.Empty;
			}
			
			if (!Page.FilterDataSource.SchemaUId.Equals(Guid.Empty)) {
				EntitySchema schema = Page.FilterDataSource.Schema;
				int refCounts = 0;
				string uniqueColumnCaption = string.Empty;
				Guid uniqueColumnUId = Guid.Empty;
				
				foreach (var column in schema.Columns) {
					if (column.IsLookupType && column.ReferenceSchemaUId == ParentEntitySchemaUId) {
						refCounts++;
						uniqueColumnCaption = column.Caption;
						uniqueColumnUId= column.UId;
					}
				}
				var activeRow = Page.DataSource.ActiveRow;
				if (refCounts == 1) {
					var entitySchemaManager = UserConnection.EntitySchemaManager;
					var baseSchema = entitySchemaManager.GetInstanceByUId(ParentEntitySchemaUId);
					Page.ObjectColumnEdit.Text = baseSchema.GetPrimaryColumnName();
					Page.ReferenceColumnEdit.Text = uniqueColumnCaption;
					activeRow.SetColumnValue("ObjectColumnPath", baseSchema.PrimaryColumn.UId);
					activeRow.SetColumnValue("ReferenceColumn", uniqueColumnUId);
				} else {
					Page.ObjectColumnEdit.Text = string.Empty;
					Page.ReferenceColumnEdit.Text = string.Empty;
					activeRow.SetColumnValue("ObjectColumnPath", string.Empty);
					activeRow.SetColumnValue("ReferenceColumn", string.Empty);
				}
				var structure = Page.FilterDataSource.CurrentStructure;
				structure.Columns.Clear();
				var primaryColumn = structure.CreateColumn(schema, schema.PrimaryColumn.UId.ToString());
				primaryColumn.IsVisible = false;
				structure.AddColumn(primaryColumn);
				var displayColumn = schema.PrimaryDisplayColumn;
				if (displayColumn == null) {
					foreach (var column in schema.Columns) {
						if (column.UsageType == EntitySchemaColumnUsageType.General) {
							displayColumn = column;
							break;
						}
					}
				}
				if (displayColumn != null) {
					var column = structure.CreateColumn(schema, displayColumn.UId.ToString());
					column.OrderDirection = OrderDirection.Ascending;
					column.OrderPosition = 1;
					structure.AddColumn(column);
				}
				Page.FilterEdit.SetDataSource(Page.FilterDataSource);
				Page.FilterDataSource.LoadRows();
			
				if (string.IsNullOrEmpty(Page.CaptionEdit.Text) || Page.CaptionEdit.Text == TableCaption) {
					Page.CaptionEdit.Text = Page.ObjectEdit.Text != null ? Page.ObjectEdit.Text.ToString()
						      											  : string.Empty;
				}
				TableCaption = Page.ObjectEdit.Text;
				
				
			}
			
			var pageInstance = Page.SysModuleReportTableFieldsGridPageContainer.PageInstance 
				as Terrasoft.WebApp.SysModuleReportTableFieldsGridPageSchemaUserControl;
			pageInstance.Process.SetPropertyValue("MacrosList", string.Empty);
			if (Page.ObjectEdit.Value != null 
				&& !string.IsNullOrEmpty(Page.ObjectEdit.Value.ToString())
				&& new Guid(Page.ObjectEdit.Value.ToString()) != Guid.Empty) {
				pageInstance.Process.SetPropertyValue("ObjectId", new Guid(Page.ObjectEdit.Value.ToString()));
			} else {
				pageInstance.Process.SetPropertyValue("ObjectId", Guid.Empty);
			}
			pageInstance.ThrowEvent("FillData");
			
			return true;
		}

		public virtual bool ScriptTaskObjectPathButtonClickExecute(ProcessExecutingContext context) {
			IsObjectColumn = true;
			ShowColumnStructureExplorer(ParentEntitySchemaUId);
			return true;
		}

		public virtual bool ReferencePathButtonClickScriptExecute(ProcessExecutingContext context) {
			IsObjectColumn = false;
			var referenceSchemaUId = new Guid(Page.ObjectEdit.Value.ToString());
			if (Guid.Empty != referenceSchemaUId) {
				ShowColumnStructureExplorer(referenceSchemaUId);
			}
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			Page.ObjectEdit.PrepareLookupFilter += PrepareObjectEditFilter;
			Page.DataSource.BeforeSaveRow += delegate(object sender, DataSourceEventArgs e) {
				 var pageInstance = Page.SysModuleReportTableFieldsGridPageContainer.PageInstance 
					as Terrasoft.WebApp.SysModuleReportTableFieldsGridPageSchemaUserControl;
				 e.Row.SetColumnValue("MacrosList", 
				 	pageInstance.Process.GetPropertyValue("MacrosList").ToString());
				 
			};
			Page.DataTabPanel.IgnoreProfileProperties.Add("activetabindex");
			if (ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			} 
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			if (Page.GetParameterValue("ParentEntityId") != null) {
				ParentEntityId = new Guid(Page.GetParameterValue("ParentEntityId").ToString());
			}
			if (Page.GetParameterValue("ParentEntitySchemaId") != null) {
				ParentEntitySchemaId = new Guid(Page.GetParameterValue("ParentEntitySchemaId").ToString());
			}
			
			return true;
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			if (Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("SysModuleReportId") != Guid.Empty
				&& ParentEntityId == Guid.Empty) {
				ParentEntityId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("SysModuleReportId");
			}
			if (ParentEntitySchemaId == Guid.Empty &&
				ParentEntityId != Guid.Empty) {
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleReport");
				var schmeUIdColumnName = entitySchemaQuery.AddColumn("SysModule.SysModuleEntity.SysEntitySchemaUId").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					entitySchemaQuery.RootSchema.GetPrimaryColumnName(), ParentEntityId));
				var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (collection.Count > 0) {
					ParentEntitySchemaUId = collection[0].GetTypedColumnValue<Guid>(schmeUIdColumnName);
					var baseEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ParentEntitySchemaUId);
					if (baseEntitySchema != null) {
						Page.ObjectColumnEdit.Caption = string.Format(ObjectColumnCaptionMask, baseEntitySchema.Caption);
					}
					entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysSchema");
					var schmeIdColumnName = entitySchemaQuery.AddColumn("Id").Name;
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"UId", ParentEntitySchemaUId));
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"SysPackage.SysWorkspace", Page.UserConnection.Workspace.Id));
					collection = entitySchemaQuery.GetEntityCollection(UserConnection);
					if (collection.Count > 0) {
						ParentEntitySchemaId = collection[0].GetTypedColumnValue<Guid>(schmeIdColumnName);
					}
				}
			}
			
			ConfigureFilterEdit();
			if (!IsNew) {
				// TODO #170715
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") 
						as EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysSchema");
				var captionColumnName = entitySchemaQuery.AddColumn("Caption").Name;
				var uIdColumnName = entitySchemaQuery.AddColumn("UId").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
					FilterComparisonType.Equal, "UId", 
					Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ObjectId")));
				var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
				foreach (var item in collection) {
					Page.ObjectEdit.SetValueAndText(item.GetTypedColumnValue<Guid>(uIdColumnName),
						item.GetTypedColumnValue<string>(captionColumnName));
					Page.FilterDataSource.SchemaUId = item.GetTypedColumnValue<Guid>(uIdColumnName);
					break;
				}
					
				var data = Page.DataSource.ActiveRow.GetBytesValue("Filter");
				if (data != null) {
					string filters = UTF8Encoding.UTF8.GetString(data, 0, data.Length);
					if (!String.IsNullOrEmpty(filters)) {
						var jsonConverter = new DataSourceFiltersJsonConverter(
							UserConnection, Page.FilterEdit.DataSource);
						
						var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
							new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
							
						if (filterCollection != null) {
							var filterEditGroup = Page.FilterDataSource.FindFiltersGroupByName(filterCollection.Name);
							if (filterEditGroup != null) {
								Page.FilterDataSource.CurrentStructure.Filters.Remove(filterEditGroup);
							}
							Page.FilterDataSource.CurrentStructure.Filters.Add(filterCollection);
						}
					}
				}
				
				Page.FilterDataSource.LoadStructure();
				Page.FilterEdit.SetDataSource(Page.FilterDataSource);
				
				EntitySchema schema = Page.FilterDataSource.Schema;
				var structure = Page.FilterDataSource.CurrentStructure;
				structure.Columns.Clear();
				var primaryColumn = structure.CreateColumn(schema, schema.PrimaryColumn.UId.ToString());
				primaryColumn.IsVisible = false;
				structure.AddColumn(primaryColumn);
				var displayColumn = schema.PrimaryDisplayColumn;
				if (displayColumn == null) {
					foreach (var column in schema.Columns) {
						if (column.UsageType == EntitySchemaColumnUsageType.General) {
							displayColumn = column;
							break;
						}
					}
				}
				if (displayColumn != null) {
					var column = structure.CreateColumn(schema, displayColumn.UId.ToString());
					column.OrderDirection = OrderDirection.Ascending;
					column.OrderPosition = 1;
					structure.AddColumn(column);
				}
				
				Page.FilterEdit.SetDataSource(Page.FilterDataSource);
				Page.FilterDataSource.LoadStructure(force: true);
				
				SetReferenceColumnList();
				
				TableCaption = Page.ObjectEdit.Text;
			}
			
			var pageInstance = Page.SysModuleReportTableFieldsGridPageContainer.PageInstance 
				as Terrasoft.WebApp.SysModuleReportTableFieldsGridPageSchemaUserControl;
			pageInstance.Process.SetPropertyValue("MacrosList", Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList"));
			pageInstance.Process.SetPropertyValue("ObjectId", Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ObjectId"));
			pageInstance.ThrowEvent("FillData");
			
			return true;
		}

		public virtual bool PageLoadScriptTaskExecute(ProcessExecutingContext context) {
			
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			UserMessageUserTask.Page = Page;
			UserMessageUserTask.MessageText = UserQuestionTitle;
			UserMessageUserTask.Icon = "QUESTION";
			UserMessageUserTask.Buttons = "YESNO";
			UserMessageUserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "UserQuestionYesMessage"},
				{"no", "UserQuestionNoMessage"}
			};
			return true;
		}

		public virtual bool ScriptTask7Execute(ProcessExecutingContext context) {
			if (ParentEntityId != Guid.Empty) {
				Page.DataSource.ActiveRow.SetColumnValue("SysModuleReportId", ParentEntityId);
			}
			Page.DataSource.ActiveRow.SetColumnValue("Name", Page.ObjectEdit.Text);
			Page.DataSource.ActiveRow.SetColumnValue("ObjectId", new Guid(Page.ObjectEdit.Value.ToString()));
			/*Page.DataSource.ActiveRow.SetColumnValue("ReferenceColumn", 
			 	Page.ReferenceColumnsEdit.Text);*/
			var macrosList = Page.SysModuleReportTableFieldsGridPageContainer
				.PageInstance.Process.GetPropertyValue("MacrosList").ToString();
			if (macrosList != Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList")) {
				Page.DataSource.ActiveRow.SetColumnValue("MacrosList", macrosList);
			}
			return true;
		}

		public virtual bool UserQuestionYesMessageScriptTaskExecute(ProcessExecutingContext context) {
			var pageInstance = Page.SysModuleReportTableFieldsGridPageContainer.PageInstance 
				as Terrasoft.WebApp.SysModuleReportTableFieldsGridPageSchemaUserControl;
			pageInstance.ThrowEvent("SetupMacrosesButtonClick");
			
			return true;
		}

		public override void OkClickMethod() {
			NeedRefreshGrid = true;
			
			var isFiltersGhanged = IsNew || IsCopy;
			
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			string serializedString = Json.Serialize(filterCollection, jsonConverter);                     
			if (!isFiltersGhanged) {
				using (Stream stream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(serializedString))) {
					if (Page.DataSource.ActiveRow.GetStreamValue("Filter") != null && stream != null) {
						if (stream.Length != Page.DataSource.ActiveRow.GetStreamValue("Filter").Length) {
							isFiltersGhanged = true;
						}
					} else {
						if ((Page.DataSource.ActiveRow.GetStreamValue("Filter") != null && stream == null)
							|| (Page.DataSource.ActiveRow.GetStreamValue("Filter") == null && stream != null)) {
								isFiltersGhanged = true;
							}
					}
				}
			}
			Page.DataSource.ActiveRow.SetColumnValue("IsEmptyTableHide", Page.IsEmptyTableHideEdit.Value);
			
			if (Page.DataSource.ActiveRow.GetTypedOldColumnValue<string>("Name") != Page.DataSource.ActiveRow.GetTypedColumnValue<string>("Name")
				|| Page.DataSource.ActiveRow.GetTypedOldColumnValue<string>("ReferenceColumn") != Page.DataSource.ActiveRow.GetTypedColumnValue<string>("ReferenceColumn")
				|| Page.DataSource.ActiveRow.GetTypedOldColumnValue<Guid>("ObjectId") != Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ObjectId")
				|| Page.DataSource.ActiveRow.GetTypedOldColumnValue<string>("MacrosList") != Page.DataSource.ActiveRow.GetTypedColumnValue<string>("MacrosList")
				|| Page.DataSource.ActiveRow.GetTypedOldColumnValue<string>("Caption") != Page.DataSource.ActiveRow.GetTypedColumnValue<string>("Caption")
				|| Page.DataSource.ActiveRow.GetTypedOldColumnValue<bool>("IsEmptyTableHide") != Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("IsEmptyTableHide")
				|| isFiltersGhanged) {
				using (Stream newStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(serializedString))) {
					newStream.Position = 0;
					Page.DataSource.ActiveRow.SetStreamValue("Filter", newStream);
				}
				Page.DataSource.ActiveRow.Save();	
			}
			
				Page.ThrowEvent("DataSourceSaved");
			
		}

		public virtual void PrepareObjectEditFilter(object sender, LookupEditEventArgs e) {
			/*var extendedEntities = new List<object>();
			extendedEntities.Add(ParentEntitySchemaUId);
			var entitySchemaExt = UserConnection.SystemEntitySchemaManager.GetInstanceByName("SysSchema");
			var entitySchemaQueryExt = new Terrasoft.Core.Entities.EntitySchemaQuery(entitySchemaExt);
			var sysSchemaColumnNameExt = entitySchemaQueryExt.AddColumn("UId").Name;
			entitySchemaQueryExt.Filters.Add(entitySchemaQueryExt.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"Parent", ParentEntitySchemaId));
			entitySchemaQueryExt.Filters.Add(entitySchemaQueryExt.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"ExtendParent", true));
			var entitiesExt = entitySchemaQueryExt.GetEntityCollection(UserConnection);
			for (int i = 0; i < entitiesExt.Count; i++) {
				extendedEntities.Add(entitiesExt[i].GetTypedColumnValue<Guid>(sysSchemaColumnNameExt));
			}*/
			/*var extendedEntities = new List<object>();
			extendedEntities.Add(ParentEntitySchemaId);
			var entitySchemaExt = UserConnection.SystemEntitySchemaManager.GetInstanceByName("SysSchema");
			var entitySchemaQueryExt = new Terrasoft.Core.Entities.EntitySchemaQuery(entitySchemaExt);
			var sysSchemaColumnNameExt = entitySchemaQueryExt.AddColumn("Id").Name;
			entitySchemaQueryExt.Filters.Add(entitySchemaQueryExt.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"Parent", ParentEntitySchemaId));
			entitySchemaQueryExt.Filters.Add(entitySchemaQueryExt.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"ExtendParent", true));
			var entitiesExt = entitySchemaQueryExt.GetEntityCollection(UserConnection);
			for (int i = 0; i < entitiesExt.Count; i++) {
				extendedEntities.Add(entitiesExt[i].GetTypedColumnValue<Guid>(sysSchemaColumnNameExt));
			}
			var entitySchema = UserConnection.SystemEntitySchemaManager.GetInstanceByName("SysEntitySchemaReference");
			var entitySchemaQuery = new Terrasoft.Core.Entities.EntitySchemaQuery(entitySchema);
			entitySchemaQuery.IsDistinct = true;
			var sysSchemaColumnName = entitySchemaQuery.AddColumn("SysSchema.UId").Name;
			var sysSchemaParentUId = entitySchemaQuery.AddColumn("SysSchema.Parent.UId").Name;
			var sysSchemaExtendParent = entitySchemaQuery.AddColumn("SysSchema.ExtendParent").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,"ReferenceSchema",
					extendedEntities.ToArray()));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			object[] ids;
			if (entities.Count > 0) {
				ids = new object[entities.Count];
			} else {
				ids = new object[] {Guid.Empty};
			}
			for (int i = 0; i < entities.Count; i++) {
				if (entities[i].GetTypedColumnValue<Guid>(sysSchemaParentUId) != Guid.Empty &&
					entities[i].GetTypedColumnValue<bool>(sysSchemaExtendParent) == true) {
					ids[i] = entities[i].GetTypedColumnValue<Guid>(sysSchemaParentUId);
				} else {
					ids[i] = entities[i].GetTypedColumnValue<Guid>(sysSchemaColumnName);
				}
			}*/
			var filters = e.Filters;
			/*filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.NotEqual}, 
				{"leftExpressionColumnPath", "Id"}, 
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", ids}});
				*/
			/*filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.NotEqual}, 
				{"leftExpressionColumnPath", "UId"}, 
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", extendedEntities.ToArray()}});*/
			
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.Equal}, 
				{"leftExpressionColumnPath", "SysWorkspace.Id"},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.Equal}, 
				{"leftExpressionColumnPath", "ManagerName"},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
		}

		public virtual DataSourceStructureColumn CreateColumn(EntitySchema schema, string metaPath) {
			EntitySchemaColumn entitySchemaColumn = schema.FindSchemaColumnByMetaPath(metaPath);
			if (entitySchemaColumn == null) {
				return null;
			}
			
			string path = schema.GetSchemaColumnPathByMetaPath(metaPath);
			string metaPathCaption = schema.GetSchemaColumnFullCaptionByPath(path);
			var column = new DataSourceStructureColumn {
				UId = Guid.NewGuid(),
				MetaPath = metaPath,
				MetaPathCaption = metaPathCaption,
				DataValueType = entitySchemaColumn.DataValueType,
				Name = entitySchemaColumn.Name,
				Caption = entitySchemaColumn.Caption
			};
			
			return column;
		}

		public virtual void SetReferenceColumnList() {
			/*
			Page.ScriptManager.AddScript(string.Format("{0}.clear();", Page.ReferenceColumnsEdit.ClientID));
			Page.ReferenceColumnsEdit.Clear();
			
			if (Page.ObjectEdit.Value != null && new Guid(Page.ObjectEdit.Value.ToString()) != Guid.Empty) {
				var selectedValue = Guid.Empty;
				var selectedText = string.Empty;
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var schema  = entitySchemaManager.GetInstanceByUId(
					new Guid(Page.ObjectEdit.Value.ToString()));
				var columns = new Dictionary<Guid, string>();
				foreach (var column in schema.Columns) {
					if (column.ReferenceSchemaUId == ParentEntitySchemaUId) {
						columns.Add(column.UId, column.Caption);
						if (Page.DataSource.ActiveRow.GetTypedColumnValue<string>("ReferenceColumn")
							== column.Caption.Value) {
							selectedValue = column.UId;
							selectedText = column.Caption;
						}
					}
				}
				
				var sortedColumns = (from entry in columns orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
				foreach (var column in sortedColumns)	{
					Page.ReferenceColumnsEdit.AddItem(column.Key, column.Value);
				}
				if (selectedValue != Guid.Empty) {
					Page.ReferenceColumnsEdit.SetValueAndText(selectedValue, selectedText);
				} else if (sortedColumns.Count == 1){
					KeyValuePair<Guid, string> value = sortedColumns.First();
					Page.ReferenceColumnsEdit.SetValueAndText(value.Key, value.Value);	
				}
			}
			*/
		}

		public virtual void SetFilter(string serializedFilters) {
			var dataSource = Page.FilterDataSource;
			if (dataSource.CurrentStructure != null)
			                dataSource.CurrentStructure.Columns.Clear();
			
			string filterGroupName = "FilterEdit";
			var oldFilters = dataSource.CurrentStructure.Filters.FindByName(filterGroupName) as DataSourceFilterCollection;
			if (oldFilters != null)
			                oldFilters.Clear();
			                
			//Page.AdditionalMacrosFilterEdit.Reinitialize(dataSource);
			
			if (!string.IsNullOrEmpty(serializedFilters)) {
			    var filtersConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource);
			    var deserializedFilters = JsonConvert.DeserializeObject<DataSourceFilterCollection>(serializedFilters, filtersConverter);
			    var existingFilterCollection = dataSource.CurrentStructure.Filters.FindByName(deserializedFilters.Name) as DataSourceFilterCollection;
			    if (existingFilterCollection != null) {
			                    existingFilterCollection.Clear();
			                    var filtersCollection = deserializedFilters as DataSourceFilterCollection;
			                    foreach (var filterItem in filtersCollection)
			                                    existingFilterCollection.Add(filterItem);
			    } else {
					dataSource.CurrentStructure.Filters.Add(deserializedFilters);
				}
			}
			Terrasoft.UI.WebControls.Utilities.EntityDataSourceUtilities.InitializeAutoDefStructure(dataSource);     
			if (!dataSource.SchemaUId.Equals(Guid.Empty)) {
			    dataSource.LoadStructure();
			}
		}

		public virtual void ResetControlValues() {
			var filterEditGroup = Page.FilterDataSource.FindFiltersGroupByName(Page.FilterEdit.FilterEditGroupName);
			filterEditGroup.Clear();
		}

		public virtual void ConfigureFilterEdit() {
			var editSchemaUId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ObjectId");
			ISchemaManager sm = UserConnection.GetSchemaManager("EntitySchemaManager");
			ProcessSchema processSchema = null;
			if (sm is ProcessSchemaManager){
				processSchema = ((ProcessSchemaManager)sm).GetDesignInstance(UserConnection, editSchemaUId) as ProcessSchema;
			} else if (sm is PageSchemaManager) {
				var ps = ((PageSchemaManager)sm).GetDesignInstance(UserConnection, editSchemaUId) as PageSchema;
				processSchema = ps.EventsProcessSchema;
			}
			if (processSchema == null) {
				var di = UserConnection.ProcessSchemaManager.FindDesignItem(UserConnection, editSchemaUId);
				processSchema = di == null ? null : di.Instance as ProcessSchema;
			}
			Page.FilterEdit.SetProcessSchema(processSchema);
			Page.FilterEdit.AutoInitializeFilterEditGroup = true;
		}

		public virtual Guid GetSchemaIdByUId(Guid uId) {
			if (uId != Guid.Empty) {
				var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as EntitySchemaManager;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysSchema");
				var schmeIdColumnName = entitySchemaQuery.AddColumn("Id").Name;
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"UId", uId));
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"SysPackage.SysWorkspace", Page.UserConnection.Workspace.Id));
				var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (collection.Count > 0) {
					return collection[0].GetTypedColumnValue<Guid>(schmeIdColumnName);
				}
			}
			return Guid.Empty;
		}

		public virtual void CreateColumnStructureExplorer() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);	
			var structureExplorer = new StructureExplorer(Page.ObjectColumnEdit , "columns", false, false, string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(SetMetaPathInfo);
			editComplete.ExtraParameters.Add(param);
			ColumnStructureExplorerCreated = true;
			if (!ColumnStructureExplorerRegistered) {
				structureExplorer.Register();
				ColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = structureExplorer;
		}

		public virtual void ShowColumnStructureExplorer(Guid entitySchemaUId) {
			if (!ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			var sructureExplorer = (StructureExplorer) ColumnStructureExplorer;
			if (sructureExplorer == null) {
				return;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
			sructureExplorer.ManagerName = entitySchemaManager.Name;
			sructureExplorer.ShowEditWindow(schema, null);
		}

		public virtual void SetMetaPathInfo(object sender, AjaxEventArgs e) {
			var column = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JObject;
			string metaPath = column.Value<string>("metaPath");
			string caption = column.Value<string>("caption");
			var activeRow = Page.DataSource.ActiveRow;
			if (IsObjectColumn) {
				if (string.IsNullOrEmpty(caption)) {
					Page.ObjectColumnEdit.Text = metaPath;
				} else {
					Page.ObjectColumnEdit.Text = caption;
				}
				activeRow.SetColumnValue("ObjectColumnPath", metaPath);
			} else {
				if (string.IsNullOrEmpty(caption)) {
					Page.ReferenceColumnEdit.Text = metaPath;
				} else {
					Page.ReferenceColumnEdit.Text = caption;
				}
				activeRow.SetColumnValue("ReferenceColumn", metaPath);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ObjectEditChange":
							if (ActivatedEventElements.Contains("ObjectEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ObjectEditChangeStartMessage");
						}
						break;
					case "ObjectPathButtonClick":
							if (ActivatedEventElements.Contains("ObjectPathButtonClick")) {
							context.QueueTasks.Enqueue("ObjectPathButtonClick");
						}
						break;
					case "ReferencePathButtonClick":
							if (ActivatedEventElements.Contains("ReferencePathButtonClick")) {
							context.QueueTasks.Enqueue("ReferencePathButtonClick");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("ThisPageLoad")) {
							context.QueueTasks.Enqueue("ThisPageLoad");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "UserQuestionYesMessage":
							if (ActivatedEventElements.Contains("UserQuestionYesMessageStartMessage")) {
							context.QueueTasks.Enqueue("UserQuestionYesMessageStartMessage");
						}
						break;
					case "UserQuestionNoMessage":
							if (ActivatedEventElements.Contains("UserQuestionNoMessageStartMessage")) {
							context.QueueTasks.Enqueue("UserQuestionNoMessageStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsObjectColumn") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsObjectColumn", IsObjectColumn, false);
			}
			if (!HasMapping("ParentEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntitySchemaUId", ParentEntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("TableCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TableCaption", TableCaption, null);
			}
			if (!HasMapping("ParentEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntitySchemaId", ParentEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("ParentEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ParentEntityId", ParentEntityId, Guid.Empty);
			}
			if (!HasMapping("ColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerRegistered", ColumnStructureExplorerRegistered, false);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("ColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerCreated", ColumnStructureExplorerCreated, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableEditPageEventsProcess

	/// <exclude/>
	public class SysModuleReportTableEditPageEventsProcess : SysModuleReportTableEditPageEventsProcess<Terrasoft.WebApp.SysModuleReportTableEditPageSchemaUserControl>
	{

		public SysModuleReportTableEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportTableEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportTableEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ObjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ObjectColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ObjectColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ObjectPathButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ObjectPathButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ReferenceColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ReferenceColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ReferencePathButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ReferencePathButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsEmptyTableHideEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsEmptyTableHideEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel DataTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("DataTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab TableFieldsTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("TableFieldsTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer SysModuleReportTableFieldsGridPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("SysModuleReportTableFieldsGridPageContainer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab TableFilterTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("TableFilterTab", true);
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

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource FilterDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("FilterDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event += ObjectEditChange;
			ObjectPathButton.AjaxEvents.Click.Event += ObjectPathButtonClick;
			ReferencePathButton.AjaxEvents.Click.Event += ReferencePathButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event -= ObjectEditChange;
			ObjectPathButton.AjaxEvents.Click.Event -= ObjectPathButtonClick;
			ReferencePathButton.AjaxEvents.Click.Event -= ReferencePathButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportTableEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportTableEditPageEventsProcess(UserConnection);
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

		public virtual void ObjectEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectEditChange");
		}

		public virtual void ObjectPathButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectPathButtonClick");
		}

		public virtual void ReferencePathButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ReferencePathButtonClick");
		}

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
			SchemaName = "SysModuleReportTableEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportTableEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportTableEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportTableEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportTableEditPageEventsProcessSchema(SysModuleReportTableEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportTableEditPageEventsProcess";
			UId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("58404567-adec-44f6-95f2-a649ff0cd64c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("910c5c74-6194-4a54-a481-f35891444b0c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2878227e-a8e6-4a49-b2cd-f57b49ecddaa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b60099a9-d227-451d-a400-a886f45a4be5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ParentEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b3db3214-3b3e-48a0-9ae3-637fb4db2fa3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ParentEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTableCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ba26075a-8a6b-4263-9123-9b887ad09fc7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"TableCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40749d5f-4289-4653-8689-a45946a68e7d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ParentEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsObjectColumnParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2640551c-859d-4f20-af3e-01b9153048a4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"IsObjectColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateParentEntityIdParameter());
			Parameters.Add(CreateParentEntitySchemaIdParameter());
			Parameters.Add(CreateTableCaptionParameter());
			Parameters.Add(CreateParentEntitySchemaUIdParameter());
			Parameters.Add(CreateIsObjectColumnParameter());
		}

		protected virtual void InitializeUserMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("30c98e7c-7a17-4834-bd7d-9a247eff12b3"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ccc167d9-f738-4946-afab-ee1defd779a0"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
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
				UId = new Guid("5c4f507a-7a80-4d76-a69d-704932cb51a4"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
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
				UId = new Guid("9968b261-26f9-4f86-9e97-1db046b33901"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
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
				UId = new Guid("953ed664-ea7b-485e-a56b-9124a941f81a"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("3297345c-5758-489a-858e-4226023ae72b"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
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
				UId = new Guid("cbe119fa-37bf-4e03-9edb-f27cf8d6a723"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
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
				UId = new Guid("3d3a5b03-436c-4c27-bf60-ec236840f72e"),
				ContainerUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaStartMessageEvent objecteditchangestartmessage = CreateObjectEditChangeStartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(objecteditchangestartmessage);
			ProcessSchemaScriptTask scripttask6 = CreateScriptTask6ScriptTask();
			eventsubprocess7.FlowElements.Add(scripttask6);
			ProcessSchemaStartMessageEvent objectpathbuttonclick = CreateObjectPathButtonClickStartMessageEvent();
			eventsubprocess1.FlowElements.Add(objectpathbuttonclick);
			ProcessSchemaScriptTask scripttaskobjectpathbuttonclick = CreateScriptTaskObjectPathButtonClickScriptTask();
			eventsubprocess1.FlowElements.Add(scripttaskobjectpathbuttonclick);
			ProcessSchemaStartMessageEvent referencepathbuttonclick = CreateReferencePathButtonClickStartMessageEvent();
			eventsubprocess8.FlowElements.Add(referencepathbuttonclick);
			ProcessSchemaScriptTask referencepathbuttonclickscript = CreateReferencePathButtonClickScriptScriptTask();
			eventsubprocess8.FlowElements.Add(referencepathbuttonclickscript);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask4);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask5);
			ProcessSchemaStartMessageEvent thispageload = CreateThisPageLoadStartMessageEvent();
			eventsubprocess9.FlowElements.Add(thispageload);
			ProcessSchemaScriptTask pageloadscripttask = CreatePageLoadScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(pageloadscripttask);
			ProcessSchemaIntermediateThrowMessageEvent basepageload = CreateBasePageLoadIntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(basepageload);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOKButtonClickStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess3.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask3);
			ProcessSchemaUserTask usermessageusertask = CreateUserMessageUserTaskUserTask();
			eventsubprocess3.FlowElements.Add(usermessageusertask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttask7 = CreateScriptTask7ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask7);
			ProcessSchemaStartMessageEvent userquestionyesmessagestartmessage = CreateUserQuestionYesMessageStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(userquestionyesmessagestartmessage);
			ProcessSchemaScriptTask userquestionyesmessagescripttask = CreateUserQuestionYesMessageScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(userquestionyesmessagescripttask);
			ProcessSchemaStartMessageEvent userquestionnomessagestartmessage = CreateUserQuestionNoMessageStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(userquestionnomessagestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent4 = CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(intermediatethrowmessageevent4);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUserQuestionTitleLocalizableString());
			LocalizableStrings.Add(CreateObjectColumnCaptionMaskLocalizableString());
			LocalizableStrings.Add(CreateReferenceColumnCaptionMaskLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUserQuestionTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("478e7afc-fe98-403e-a963-8b9c1c1ca3d0"),
				Name = "UserQuestionTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateObjectColumnCaptionMaskLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e9698a58-e628-4b73-b3a8-481069ac2cd5"),
				Name = "ObjectColumnCaptionMask",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateReferenceColumnCaptionMaskLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("909a8f09-d5ea-4102-b2e2-87d069b0b9ed"),
				Name = "ReferenceColumnCaptionMask",
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("86953ddd-5bd1-476a-9da4-5197c157f05b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(188, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("713db9ea-4033-4fd2-9159-006efe418628"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd13ec4d-4fe4-4097-b954-377c40c4d64b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("eafde2d9-bb10-44de-85cf-a802809ea3fc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(338, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd13ec4d-4fe4-4097-b954-377c40c4d64b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ff8ceec-228c-4845-bab8-6a1d285b3e93"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("07b4df93-213b-4d6a-94a9-3c3a07790bdc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(219, 458),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ddd6c82-d7df-4524-91eb-eeb127368e89"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68e4562d-8ad2-47b7-a7a4-b9834987646c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("f8ccabf9-7554-44df-935b-3da1b895b53c"),
				ConditionExpression = @"string.IsNullOrEmpty(Page.DataSource.ActiveRow.GetTypedColumnValue<string>(""MacrosList""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(368, 454),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2517778e-2e3f-4b12-8943-eb35591a5750"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46bdae8b-6fdd-4491-a515-7627eb387dd1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("39b18c95-b5a0-4f0d-8c5d-c0fb1be55427"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(356, 528),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2517778e-2e3f-4b12-8943-eb35591a5750"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("16e4a632-7e22-42d8-9cd4-5c40c25b5f2e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("d8e429db-4ebf-4ca0-96be-e3ffb619b6ab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(519, 454),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46bdae8b-6fdd-4491-a515-7627eb387dd1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("a13a0ac5-0753-487c-97de-98566f64fa35"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(248, 860),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e75b99d4-167b-441a-b845-2b487ca7950c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a82f190-1938-4e61-b7ec-f02bca1b5118"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("db4f0ab4-7dc4-4319-a9cd-502b5a5904fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(180, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc21ef2f-832a-4a18-a30c-a90aac844cb5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e43847b5-325c-40ef-a527-93cf88edfbab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("2e3e3e87-d6a2-489e-86f9-6984b9e03a05"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(324, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e43847b5-325c-40ef-a527-93cf88edfbab"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56d45b33-1102-4ca4-b56f-351acf7afc9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("7d373aac-d37d-4bf5-b994-042a525d5240"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(446, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56d45b33-1102-4ca4-b56f-351acf7afc9e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9d55fec5-5905-40de-bd9e-113773e83ade"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("55030278-10aa-41cd-91f4-64d417206991"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1740d25f-24a2-4635-92f8-5dfca23f0a27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c484685-1d18-4beb-854b-4c06f226ce92"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("b805d0a2-96ef-491b-a164-699889469f13"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(219, 458),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68e4562d-8ad2-47b7-a7a4-b9834987646c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2517778e-2e3f-4b12-8943-eb35591a5750"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("abaa9dbc-0d30-4523-9103-6e2d99ab2473"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(236, 918),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8eb8cd90-9c23-46c8-bf70-af825c86b6fb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b12009cc-88d4-4820-b57e-bd7c7b2867b9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("2a09247b-868f-46ab-8927-2f43a41fedf1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75a751d1-2189-48c8-b30a-227b3ea4eb2b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("974f3f70-ec22-4f2b-892f-137f56bfd947"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("14052afd-cafe-4d25-9897-50d610b6b887"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("16ef6d16-a0c3-4ca9-8ff4-c7ac772257b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("564529b0-9742-4ba7-87cc-b952e02f1589"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("11e68f10-ecd2-488c-befd-75bb09c902fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(552, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79552a2b-4026-4562-a0c3-ba024b928063"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9fe94b9a-fa7f-4685-bcf8-a334cf20fac0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("00f2f70a-9b0d-4046-8453-be9628a8881b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CurveCenterPosition = new Point(666, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9fe94b9a-fa7f-4685-bcf8-a334cf20fac0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d0c41a94-e291-4675-a5fd-e13f717df706"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e5aaa95c-958a-4733-979f-ef1e5dce5e9b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1189, 1171),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e5aaa95c-958a-4733-979f-ef1e5dce5e9b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"Lane5",
				Position = new Point(29, 0),
				Size = new Size(1160, 159),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("04ed66b9-2c3b-4cce-8636-aed8a2d628b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1740d25f-24a2-4635-92f8-5dfca23f0a27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04ed66b9-2c3b-4cce-8636-aed8a2d628b9"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectEditChange",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ObjectEditChangeStartMessage",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask6ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6c484685-1d18-4beb-854b-4c06f226ce92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04ed66b9-2c3b-4cce-8636-aed8a2d628b9"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTask6",
				Position = new Point(77, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,75,79,35,57,16,62,55,18,255,193,112,24,53,26,212,218,185,110,132,70,76,8,8,9,134,136,132,217,179,211,93,1,15,29,187,199,118,195,70,59,252,247,45,191,58,238,71,72,56,78,4,82,176,171,190,250,234,233,98,74,31,33,187,160,154,206,68,45,115,200,206,115,205,94,224,94,188,102,51,208,99,81,214,43,254,131,150,53,164,199,183,52,151,66,221,48,165,143,79,137,210,146,241,199,108,178,170,244,250,100,116,120,48,221,27,230,30,150,32,129,231,224,78,7,176,80,163,35,100,140,166,141,153,206,229,164,96,58,27,211,74,51,193,201,89,64,187,20,114,69,117,218,145,245,98,183,84,61,159,18,11,118,183,248,9,185,182,24,115,248,87,27,35,247,160,12,103,174,165,40,45,105,101,109,179,37,73,187,42,246,154,28,157,17,94,151,37,57,60,72,62,125,34,71,158,193,181,250,142,135,119,210,250,53,172,153,205,197,204,10,167,39,39,78,153,195,43,185,170,89,177,91,222,88,53,146,62,110,228,63,4,104,40,94,178,82,131,140,242,49,203,159,96,69,3,83,39,157,188,43,234,36,209,239,228,13,127,223,19,125,184,46,140,244,222,204,17,243,141,64,169,192,178,216,141,188,241,210,104,30,30,184,84,28,237,80,204,38,191,106,90,170,52,138,145,115,123,194,53,211,107,239,165,10,206,190,135,102,130,192,184,38,18,150,99,81,115,173,80,254,47,115,232,50,77,106,206,126,213,237,10,219,20,98,32,158,24,34,45,209,1,239,18,252,89,10,9,52,127,34,233,11,149,36,183,146,132,113,207,52,115,170,202,103,208,4,194,137,96,185,221,8,241,92,87,243,117,5,4,43,201,31,55,13,16,69,212,120,139,103,58,142,4,94,120,204,164,113,243,243,231,145,61,24,246,207,27,240,7,125,73,68,108,132,240,187,21,120,243,229,100,92,163,97,68,132,232,15,141,143,145,175,234,40,244,103,228,139,103,106,80,32,242,225,150,114,196,145,136,247,160,64,98,7,115,172,65,228,150,77,250,66,163,0,176,160,10,154,146,31,64,203,174,64,95,115,165,41,198,240,219,26,29,73,135,131,55,106,58,202,213,126,52,156,204,96,65,240,141,37,131,57,149,108,69,229,218,137,125,167,43,72,35,136,161,17,231,81,6,146,97,245,232,214,137,27,243,153,82,253,132,35,55,162,210,226,145,53,158,108,135,235,15,240,78,214,45,64,212,225,239,71,165,219,38,59,3,208,83,248,144,231,221,199,230,99,158,246,180,67,49,227,69,157,235,90,194,214,81,50,174,165,41,155,89,16,244,243,195,253,17,218,58,27,151,64,165,171,4,3,91,197,201,113,190,7,5,28,18,218,19,75,221,108,56,13,51,162,151,210,206,244,77,90,176,56,57,126,48,197,22,165,225,190,196,145,217,161,118,94,20,222,76,75,173,225,88,48,85,149,52,226,216,34,113,17,223,134,110,238,168,180,30,165,143,140,191,120,254,61,40,12,187,29,126,136,23,55,167,175,203,112,141,189,199,65,210,96,46,73,186,252,243,134,42,126,22,72,230,217,125,127,139,7,88,223,139,246,211,26,145,223,153,181,22,206,80,186,18,239,226,157,44,176,164,152,116,83,13,129,219,7,217,185,202,129,23,168,215,83,154,10,197,188,206,23,123,57,148,222,124,147,215,206,147,111,219,15,187,99,83,206,195,107,134,213,29,46,255,27,65,11,236,49,183,74,249,0,110,95,148,252,96,219,172,101,228,247,111,50,120,99,178,61,167,88,188,254,34,94,109,250,178,131,59,95,179,191,125,29,188,142,178,97,235,128,216,79,178,249,16,242,119,111,40,153,0,198,180,182,152,246,79,190,95,107,108,199,163,84,120,110,130,210,108,173,110,69,81,151,112,15,149,144,218,226,94,50,40,11,117,37,89,97,68,204,182,74,25,214,117,54,141,245,17,154,42,50,7,41,169,18,75,157,253,3,139,243,170,218,3,207,63,107,238,21,53,123,48,18,141,153,97,119,139,28,148,50,69,129,95,43,144,122,189,207,191,9,127,192,14,189,167,155,14,246,186,64,39,247,183,215,89,125,63,110,42,34,235,118,225,22,196,252,73,138,215,201,11,190,50,233,49,54,96,105,218,239,216,245,155,4,108,118,78,176,235,97,244,63,24,197,30,148,243,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("69cd6b02-50db-4d0f-8579-15936db99315"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess1",
				Position = new Point(225, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectPathButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("75a751d1-2189-48c8-b30a-227b3ea4eb2b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69cd6b02-50db-4d0f-8579-15936db99315"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectPathButtonClick",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ObjectPathButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskObjectPathButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("974f3f70-ec22-4f2b-892f-137f56bfd947"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("69cd6b02-50db-4d0f-8579-15936db99315"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTaskObjectPathButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,246,79,202,74,77,46,113,206,207,41,205,205,83,176,85,40,41,42,77,181,230,229,10,206,200,47,135,136,5,3,69,146,75,74,139,82,93,43,10,114,242,139,82,139,52,2,18,139,82,243,74,92,243,74,50,75,42,131,147,51,82,115,19,67,61,83,52,129,154,138,82,129,234,242,32,70,0,0,251,255,39,69,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("06c48d54-93ef-488e-9a46-7a4cb396caf7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess8",
				Position = new Point(428, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(209, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReferencePathButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("16ef6d16-a0c3-4ca9-8ff4-c7ac772257b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("06c48d54-93ef-488e-9a46-7a4cb396caf7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ReferencePathButtonClick",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ReferencePathButtonClick",
				Position = new Point(21, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateReferencePathButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("564529b0-9742-4ba7-87cc-b952e02f1589"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("06c48d54-93ef-488e-9a46-7a4cb396caf7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ReferencePathButtonClickScript",
				Position = new Point(98, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,14,130,48,24,6,103,73,120,135,223,173,44,125,1,194,100,136,97,210,4,117,175,229,3,106,160,37,63,173,104,140,239,110,13,43,251,221,229,170,249,116,127,64,251,131,27,194,104,169,160,86,13,51,242,52,121,42,38,70,11,134,213,168,117,143,81,93,171,38,2,22,11,29,131,105,196,89,117,144,171,93,54,198,203,155,26,2,228,197,213,158,141,237,68,150,197,138,105,73,252,97,89,142,147,127,211,190,216,104,102,244,73,147,93,221,187,101,157,136,126,208,62,48,202,215,52,56,6,139,13,39,182,191,105,194,136,156,165,40,32,255,1,255,1,178,103,202,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8b59fd8c-ffae-46f4-8f3c-d804f8e0fbb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(70, 192),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(364, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("713db9ea-4033-4fd2-9159-006efe418628"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b59fd8c-ffae-46f4-8f3c-d804f8e0fbb4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cd13ec4d-4fe4-4097-b954-377c40c4d64b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b59fd8c-ffae-46f4-8f3c-d804f8e0fbb4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,79,2,49,16,133,207,144,240,31,26,78,75,36,253,3,196,3,34,16,19,136,27,23,245,60,108,31,107,181,182,155,233,44,106,140,255,221,22,72,36,49,38,222,218,206,188,111,222,188,150,212,64,223,110,159,81,203,220,88,209,37,163,37,198,42,132,151,174,93,88,39,96,117,113,169,78,207,63,141,199,210,100,208,47,51,224,154,132,170,208,113,13,125,133,93,96,84,180,199,93,120,203,82,3,135,134,4,69,56,136,85,132,55,224,177,250,209,204,247,240,50,229,38,42,140,212,231,160,223,83,123,98,213,38,240,141,143,66,190,134,74,14,242,156,234,35,174,131,233,28,238,208,6,150,13,109,29,22,22,206,196,37,91,147,91,102,193,11,89,15,214,229,185,62,65,123,20,213,6,204,20,195,78,244,35,182,211,182,253,7,176,170,159,240,74,247,17,156,209,28,220,36,27,132,78,219,233,10,50,11,174,123,245,15,228,58,20,195,53,213,28,226,202,70,25,142,243,72,213,59,95,34,101,27,106,196,168,151,144,116,108,193,242,241,91,56,210,155,80,9,91,223,20,163,209,97,214,160,255,117,158,115,242,88,146,135,211,55,141,79,73,39,210,206,58,156,128,22,81,79,141,41,134,84,139,221,67,104,107,83,218,239,195,76,178,59,85,28,237,38,126,87,75,199,152,191,183,46,49,120,198,72,63,100,142,233,31,47,127,116,22,153,244,149,60,49,210,179,87,169,142,201,55,87,86,9,186,69,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2ff8ceec-228c-4845-bab8-6a1d285b3e93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b59fd8c-ffae-46f4-8f3c-d804f8e0fbb4"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f2caf79b-61a5-4b10-ad02-810ac51c5a47"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(71, 373),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(499, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dc21ef2f-832a-4a18-a30c-a90aac844cb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2caf79b-61a5-4b10-ad02-810ac51c5a47"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e43847b5-325c-40ef-a527-93cf88edfbab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2caf79b-61a5-4b10-ad02-810ac51c5a47"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTask4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,8,72,76,79,213,115,79,45,9,72,44,74,204,77,45,73,45,10,75,204,41,77,213,80,2,242,83,243,74,92,243,74,50,75,42,61,83,148,52,21,20,109,21,242,74,115,114,52,21,170,121,185,56,81,101,21,128,82,169,229,10,238,165,153,41,68,155,167,23,146,31,92,82,148,153,151,174,161,169,105,205,203,85,203,203,149,73,164,107,130,147,51,82,115,19,241,187,9,166,134,84,151,33,204,198,116,31,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,25,250,4,196,60,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("56d45b33-1102-4ca4-b56f-351acf7afc9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2caf79b-61a5-4b10-ad02-810ac51c5a47"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9d55fec5-5905-40de-bd9e-113773e83ade"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f2caf79b-61a5-4b10-ad02-810ac51c5a47"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTask5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(385, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,109,79,227,56,16,254,28,36,254,131,233,73,40,149,42,47,124,56,237,233,186,139,4,165,32,86,176,244,160,44,31,78,247,193,36,46,245,146,198,57,219,41,215,91,245,191,223,248,37,137,243,194,75,79,176,18,18,36,246,60,243,120,60,207,204,4,54,67,225,132,220,83,124,76,20,185,230,185,136,40,62,140,20,91,210,43,254,136,79,169,154,174,50,26,143,120,146,47,210,111,36,201,233,167,211,156,197,7,97,239,122,37,47,120,156,39,244,138,102,92,168,179,184,215,71,59,159,145,94,197,227,69,166,86,219,91,193,238,46,154,16,65,83,53,78,21,83,171,179,24,125,246,119,244,209,15,216,212,220,129,222,138,206,112,123,107,189,189,197,204,1,43,23,215,209,156,46,72,147,10,218,221,109,83,217,105,147,93,18,129,168,135,115,65,82,96,43,10,214,246,37,174,173,77,4,95,178,152,10,205,222,189,10,123,227,54,6,196,143,72,212,177,48,236,240,251,71,78,197,10,188,166,244,177,102,98,222,135,29,12,7,168,25,34,19,32,3,44,163,249,130,222,156,185,176,126,37,11,10,200,45,111,248,48,118,59,188,104,227,242,47,203,66,63,251,124,110,244,69,96,13,169,157,181,49,79,88,162,168,144,26,59,108,175,142,4,37,138,218,61,183,76,205,225,126,0,73,27,132,246,229,136,47,50,34,152,228,169,206,11,60,254,59,39,201,0,129,167,14,87,87,156,43,119,63,112,19,19,193,22,68,172,170,35,135,253,65,35,89,251,101,128,34,158,36,20,178,144,167,157,129,1,56,107,51,42,247,133,55,82,179,75,83,251,104,144,116,38,86,72,120,196,243,84,161,3,180,103,51,43,104,39,233,141,145,67,101,242,231,222,95,207,72,160,125,139,198,171,57,192,29,145,212,71,6,216,58,65,220,145,119,218,215,89,42,21,73,35,122,180,2,228,14,29,193,91,235,69,31,174,229,5,4,148,230,73,226,14,24,24,137,92,222,125,7,151,150,228,56,102,10,143,72,230,34,43,149,96,233,61,62,225,98,65,84,232,111,116,123,46,136,124,24,180,14,83,32,88,34,235,206,219,223,92,42,246,85,175,138,161,137,239,38,34,169,165,254,207,204,253,160,167,101,87,79,231,234,186,250,63,159,14,132,115,66,162,7,83,33,87,242,150,139,7,153,145,136,26,138,240,174,145,138,229,58,46,217,190,141,0,95,82,96,135,4,55,87,96,91,128,58,35,215,166,23,109,111,1,163,25,187,207,133,139,164,22,64,168,119,105,102,59,103,242,43,125,180,92,62,124,64,211,203,227,75,244,203,254,199,189,143,251,191,190,123,231,49,199,127,247,246,227,107,202,212,85,43,220,215,75,202,41,221,211,149,134,201,55,81,229,187,117,36,29,194,231,164,224,68,105,75,253,255,152,112,108,61,212,236,223,186,49,205,56,156,42,154,163,80,67,50,69,23,136,165,30,116,217,159,202,234,109,234,246,53,85,134,223,97,26,79,233,63,42,212,134,207,240,175,93,82,127,96,18,238,73,19,219,9,14,194,86,130,184,122,96,184,216,96,123,97,244,187,230,70,108,12,230,29,4,225,97,104,181,26,4,46,192,49,160,191,52,146,30,173,20,149,6,60,236,89,78,189,178,223,27,251,122,27,180,103,67,51,155,103,186,19,79,79,126,27,167,17,143,117,243,211,15,26,244,218,236,50,246,3,180,55,48,68,240,57,77,239,213,188,170,101,59,118,23,134,194,1,248,151,194,12,170,161,67,238,23,85,77,159,227,187,212,81,76,151,84,40,83,51,180,112,171,243,184,156,255,226,111,50,249,28,4,245,116,113,5,187,42,94,94,80,44,173,160,116,57,115,90,240,50,84,59,192,199,20,32,25,73,216,191,180,160,58,64,10,174,137,207,194,38,165,202,186,239,122,73,160,153,159,51,169,62,213,216,30,160,31,141,51,174,205,56,253,52,160,101,107,233,234,88,182,232,54,134,23,239,76,250,224,167,130,231,89,145,25,173,76,60,97,105,236,130,106,54,30,173,204,136,217,244,129,171,236,243,73,84,248,77,14,79,36,254,40,23,186,113,65,54,228,145,130,230,82,22,177,43,186,224,75,218,132,45,60,174,237,175,13,49,117,97,108,30,196,33,174,189,118,23,152,239,169,46,228,115,78,226,18,214,116,191,160,153,85,80,91,42,131,176,19,198,216,193,79,109,224,148,197,116,251,92,129,40,63,123,10,14,79,238,111,198,64,91,150,86,216,22,16,137,71,9,37,34,44,107,114,230,127,89,216,169,182,48,48,205,195,53,34,75,117,224,40,227,218,247,8,134,26,134,167,220,213,0,91,243,106,176,160,248,111,76,178,187,68,115,159,145,68,54,168,85,253,174,102,86,114,140,153,204,18,226,113,172,145,56,246,87,203,74,86,55,169,37,102,173,129,68,118,7,180,16,135,234,226,84,36,177,27,194,204,49,37,132,93,87,104,141,231,95,164,53,41,151,161,32,166,84,144,74,7,77,254,81,73,53,240,10,121,35,33,219,167,168,203,203,35,255,226,173,213,112,186,174,43,112,71,188,20,48,128,29,51,81,214,192,250,11,124,40,35,154,234,202,223,50,154,112,201,156,205,254,208,53,142,214,245,70,213,189,182,53,183,145,148,94,163,85,184,231,136,254,142,224,185,148,31,192,95,209,25,5,153,68,46,70,186,56,135,197,242,148,64,142,86,95,120,205,25,66,15,14,67,55,26,27,237,192,122,241,201,89,78,182,245,127,91,24,196,19,70,147,24,74,43,139,245,22,40,250,138,48,200,16,60,241,237,193,61,116,128,41,21,130,72,62,83,248,150,222,29,102,217,43,240,220,28,97,59,159,18,60,1,138,62,51,208,9,143,168,148,58,182,240,103,6,13,103,229,250,255,5,137,4,151,58,4,197,199,205,171,199,188,98,230,241,49,76,46,189,210,117,57,31,110,234,184,61,95,54,157,78,231,130,63,142,151,80,10,205,132,147,104,104,51,227,108,111,9,10,153,145,154,148,24,254,7,71,172,14,52,76,20,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("64b49252-eeda-4676-b22e-49562d4efa8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(448, 199),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateThisPageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("79552a2b-4026-4562-a0c3-ba024b928063"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64b49252-eeda-4676-b22e-49562d4efa8d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ThisPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9fe94b9a-fa7f-4685-bcf8-a334cf20fac0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64b49252-eeda-4676-b22e-49562d4efa8d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"PageLoadScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,213,191,245,244,14,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBasePageLoadIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d0c41a94-e291-4675-a5fd-e13f717df706"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64b49252-eeda-4676-b22e-49562d4efa8d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"BasePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 589),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(592, 234),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4ddd6c82-d7df-4524-91eb-eeb127368e89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"OKButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("2517778e-2e3f-4b12-8943-eb35591a5750"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46bdae8b-6fdd-4491-a515-7627eb387dd1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(358, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,206,189,10,194,48,16,7,240,217,66,223,33,100,46,190,64,213,65,236,208,193,214,218,100,232,88,202,81,130,146,72,238,130,150,210,119,55,209,34,34,118,186,15,126,119,252,37,130,61,2,98,219,131,244,173,104,241,178,62,249,129,109,89,40,105,28,201,63,98,158,5,60,200,195,176,174,28,32,41,163,133,162,235,210,85,222,25,237,57,175,100,86,139,188,44,248,130,219,59,34,163,49,208,38,171,139,114,201,157,1,111,222,193,188,15,7,26,238,236,160,186,144,164,181,195,6,201,42,221,39,236,93,119,108,140,163,213,200,7,64,158,48,254,29,187,1,156,191,240,41,121,33,109,126,77,97,62,36,142,38,159,201,2,57,171,25,89,7,233,19,210,87,127,140,72,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("79582715-c885-4215-a9c1-a8e1b201b591"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"UserMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(498, 36),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("16e4a632-7e22-42d8-9cd4-5c40c25b5f2e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 166),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask7ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("68e4562d-8ad2-47b7-a7a4-b9834987646c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75878f69-baf7-428f-b89b-c1d006bc1ecd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"ScriptTask7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,209,106,194,48,20,134,175,87,232,59,68,175,90,145,248,0,206,193,112,78,10,115,19,91,118,31,155,163,100,180,73,57,57,209,149,177,119,95,218,202,168,101,23,238,46,36,231,124,255,255,159,28,117,96,209,86,32,104,90,105,82,84,39,146,141,22,108,237,148,228,171,178,162,58,102,95,97,112,183,21,71,224,79,130,68,106,28,230,192,31,115,82,39,216,153,51,79,129,150,166,112,165,126,23,133,131,104,156,214,118,99,164,43,96,7,149,65,74,228,120,202,174,249,241,60,12,190,195,224,118,228,171,40,161,165,248,134,183,253,7,228,180,146,138,120,6,159,212,176,110,7,117,205,173,37,13,231,54,100,52,164,182,165,60,51,41,161,210,199,40,142,27,137,217,228,118,145,29,28,192,199,205,161,187,245,90,97,192,186,1,14,158,108,47,198,100,22,6,39,129,172,20,57,26,251,162,44,177,69,151,120,48,208,76,236,11,120,86,80,72,187,70,37,155,146,165,209,36,148,6,244,31,197,155,139,68,91,18,94,134,111,209,228,96,45,95,3,249,99,5,72,245,197,229,230,87,103,28,247,210,250,172,202,47,68,207,197,232,98,227,207,236,158,155,213,21,200,222,0,238,109,139,122,184,150,248,239,22,245,122,167,189,153,92,86,7,129,28,106,70,232,96,254,3,114,65,140,95,192,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e5a0f858-4567-4ba6-82b2-3711bbc3a6de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 835),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserQuestionYesMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8eb8cd90-9c23-46c8-bf70-af825c86b6fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e5a0f858-4567-4ba6-82b2-3711bbc3a6de"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UserQuestionYesMessage",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"UserQuestionYesMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUserQuestionYesMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b12009cc-88d4-4820-b57e-bd7c7b2867b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e5a0f858-4567-4ba6-82b2-3711bbc3a6de"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"UserQuestionYesMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(168, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,10,194,64,16,68,107,3,249,135,195,74,155,251,129,96,161,65,197,34,16,76,196,122,115,89,205,225,121,123,236,237,69,252,123,147,46,165,229,48,243,30,51,2,171,0,79,188,248,40,224,13,170,157,170,167,168,155,111,172,168,79,14,175,24,136,165,133,206,225,201,162,235,227,153,109,63,79,74,242,2,214,35,235,122,201,231,217,10,162,106,145,25,34,61,68,223,177,219,135,240,135,175,49,3,190,225,22,145,103,51,147,43,242,108,249,76,183,3,211,231,56,162,151,205,186,65,73,161,2,195,20,49,30,146,8,249,210,89,243,90,111,39,42,207,120,170,217,43,225,132,197,15,194,1,123,252,226,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ea102deb-4be9-498c-bc44-eff1527b5798"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4d5e2cf3-1a13-4078-b513-e61aaba8f95e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 1003),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserQuestionNoMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e75b99d4-167b-441a-b845-2b487ca7950c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea102deb-4be9-498c-bc44-eff1527b5798"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UserQuestionNoMessage",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"UserQuestionNoMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3a82f190-1938-4e61-b7ec-f02bca1b5118"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea102deb-4be9-498c-bc44-eff1527b5798"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Name = @"IntermediateThrowMessageEvent4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreatePrepareObjectEditFilterMethod());
			Methods.Add(CreateCreateColumnMethod());
			Methods.Add(CreateSetReferenceColumnListMethod());
			Methods.Add(CreateSetFilterMethod());
			Methods.Add(CreateResetControlValuesMethod());
			Methods.Add(CreateConfigureFilterEditMethod());
			Methods.Add(CreateGetSchemaIdByUIdMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateShowColumnStructureExplorerMethod());
			Methods.Add(CreateSetMetaPathInfoMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("018a18da-a4f9-442c-94e6-3f08080b0739"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9009f60c-34e0-4dac-b2c0-66fcb6accaf5"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b56a70bf-e35b-4277-ae03-b699aab29f7d"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d585d704-557b-40d5-bd14-ec2e3b93353d"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("834df0cd-0e35-4763-828d-626d0377341f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,219,110,226,48,16,125,38,95,225,230,161,74,36,20,237,227,74,44,149,182,44,101,89,181,180,42,180,239,6,15,224,202,216,200,118,64,217,45,255,190,227,56,92,150,66,218,77,138,16,23,207,204,57,103,70,227,147,1,0,123,132,169,6,51,239,105,206,72,155,88,157,66,43,8,86,84,19,110,110,184,176,160,77,111,78,229,12,92,180,111,6,176,38,175,175,248,163,163,150,89,145,56,205,211,58,74,8,152,88,174,36,38,62,208,25,36,190,188,203,184,77,126,80,75,135,42,213,19,119,42,217,22,88,171,116,121,157,13,232,2,162,112,159,29,198,173,28,247,197,40,217,81,114,5,26,3,8,42,145,123,15,84,96,252,58,76,138,158,140,19,34,165,23,210,44,209,129,28,198,106,46,103,4,75,56,21,252,55,176,161,63,104,19,7,154,12,183,231,209,113,131,205,127,165,197,45,114,234,21,240,41,137,46,142,167,24,147,63,65,35,53,142,39,66,62,160,11,98,252,151,111,240,14,22,74,103,62,18,61,141,110,190,118,229,68,49,76,79,220,159,164,7,246,58,179,96,162,99,213,113,156,35,55,28,105,222,245,193,200,191,163,234,21,60,170,181,43,247,208,207,84,164,187,161,135,49,185,64,246,84,8,114,121,185,149,83,156,120,212,28,214,7,146,91,144,51,59,119,241,255,231,41,138,11,208,198,137,21,243,11,136,177,13,126,108,8,8,3,123,5,159,211,89,187,232,44,151,128,203,92,5,181,125,118,94,219,222,74,155,243,221,5,248,222,4,231,217,135,96,113,233,210,133,44,216,251,166,187,88,218,108,68,199,2,126,114,6,97,177,224,199,231,249,170,231,53,184,229,193,187,27,49,202,150,192,238,5,59,224,250,230,239,198,85,20,186,203,233,167,248,62,70,9,64,224,6,93,93,5,154,20,104,144,19,240,209,90,130,222,96,85,211,214,75,57,67,180,251,241,11,154,66,159,85,145,244,6,162,230,148,238,232,68,43,115,203,141,173,53,160,67,152,154,138,58,116,233,12,179,150,156,29,70,53,45,99,165,196,213,137,187,83,65,210,89,168,92,217,7,156,30,13,126,248,153,102,191,195,75,30,148,225,197,179,247,139,115,152,82,83,57,101,105,205,189,56,52,13,231,77,37,16,116,5,81,220,106,160,121,21,105,163,185,86,235,238,10,164,141,194,125,137,203,99,238,105,30,252,5,73,32,233,216,105,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareObjectEditFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1375a8c2-d628-4fe0-933d-fb2596738a60"),
				Name = "PrepareObjectEditFilter",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ee6e879f-b0d3-4fb5-bf7f-88ee2874baa9"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("edce9bd8-7524-493e-8661-206f5708abf7"),
				Name = "e",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LookupEditEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,93,79,219,48,20,125,6,169,255,193,203,3,74,160,10,188,83,42,177,210,33,164,13,149,1,227,1,245,193,36,55,212,91,106,119,182,179,17,85,253,239,187,142,211,224,180,105,87,241,33,38,177,167,170,206,245,241,61,247,158,115,237,253,221,95,84,18,120,208,192,99,136,251,92,51,205,64,145,35,194,225,55,249,204,148,238,136,187,239,16,233,174,31,28,182,182,23,227,194,227,56,246,7,84,2,215,197,82,126,25,141,96,76,175,207,98,19,93,32,59,203,253,7,141,192,215,10,100,79,112,142,160,76,240,240,50,87,26,198,238,238,47,148,211,123,144,225,41,232,51,174,52,229,17,124,204,207,233,24,124,15,131,109,140,215,132,127,145,129,204,237,33,38,251,43,144,146,42,145,232,176,39,36,132,85,206,253,197,45,254,66,146,115,108,53,63,173,39,210,108,204,77,10,22,189,233,80,83,10,27,231,123,200,223,11,66,19,111,106,214,20,252,137,165,26,164,173,95,99,64,79,2,213,96,195,110,152,30,97,145,17,206,236,241,237,98,79,140,39,84,50,37,248,85,62,65,118,63,51,154,182,73,107,123,107,203,179,13,241,218,100,185,51,216,152,224,77,114,234,23,202,169,50,211,50,131,160,214,67,236,204,154,226,162,22,44,13,44,113,106,149,227,215,133,100,192,18,33,137,207,184,38,12,113,14,14,241,167,227,130,163,14,50,174,113,121,111,47,32,83,76,171,81,206,206,134,91,54,52,39,27,50,101,111,191,209,52,131,206,105,198,226,174,223,44,143,130,213,108,119,191,181,189,255,26,214,122,231,206,250,111,172,119,110,172,101,109,62,95,248,110,228,87,72,0,75,25,193,106,31,60,203,4,141,34,9,207,212,9,206,3,198,35,211,39,211,194,213,62,105,106,164,235,144,202,200,97,237,22,170,161,89,181,224,247,205,193,236,150,53,152,174,14,55,135,173,169,119,181,179,215,91,232,137,254,241,170,94,151,147,175,109,12,181,36,221,43,113,140,141,206,253,96,201,86,141,52,55,51,148,157,252,183,67,194,98,133,127,89,66,42,123,88,51,145,46,57,176,94,194,136,82,113,229,166,122,224,208,184,130,64,170,160,57,122,72,166,198,85,97,127,60,209,249,204,90,104,157,157,151,188,236,230,182,161,111,43,125,5,228,195,17,121,60,158,236,236,20,37,254,11,218,157,16,169,131,230,106,36,32,71,214,32,54,55,67,23,81,230,141,120,74,134,88,145,45,167,126,79,70,124,116,168,133,44,31,1,70,47,137,21,175,193,156,11,249,208,60,15,18,71,212,166,99,39,172,208,7,149,121,71,105,201,248,125,187,108,98,151,76,205,176,159,122,81,77,199,56,238,27,229,125,46,116,161,240,89,219,238,74,33,209,253,135,137,4,165,16,222,38,58,160,122,132,251,205,133,58,15,203,20,224,20,154,164,52,47,8,226,215,132,98,89,230,159,37,187,31,57,48,149,199,138,96,133,209,88,185,217,172,32,111,95,63,255,2,189,235,23,228,183,122,50,24,218,134,51,58,235,149,56,111,76,24,71,235,141,144,63,212,132,70,16,22,228,95,132,123,125,160,12,240,50,13,23,46,93,247,212,153,213,193,155,23,163,188,246,141,41,95,167,16,94,195,35,195,43,216,255,1,101,124,93,121,88,15,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3991a012-6023-408d-ab03-7fee08050c09"),
				Name = "CreateColumn",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceStructureColumn"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b674b7ef-0c3f-459e-98a1-0849e03b824a"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6331039f-cfc6-49ee-9ac4-ee940a681b62"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,193,174,130,48,16,60,187,95,209,35,36,134,31,32,94,212,167,121,135,103,76,80,239,27,88,181,9,20,82,183,26,98,252,119,23,44,129,167,120,106,119,103,118,102,182,253,49,172,185,78,210,51,21,184,40,115,87,24,69,159,173,153,186,180,101,180,210,38,27,34,243,250,143,24,183,200,231,160,240,151,48,6,125,84,193,152,202,76,25,151,231,161,186,195,196,18,59,107,218,58,134,7,192,133,173,54,39,85,137,64,239,182,38,30,10,52,234,227,134,126,186,235,44,176,98,93,154,175,66,43,113,245,156,121,221,106,85,47,157,43,90,149,118,43,27,186,169,37,50,38,165,179,41,37,108,93,42,153,201,47,35,59,236,127,51,161,173,157,206,162,13,221,154,51,8,167,48,233,2,10,214,5,26,116,251,108,111,105,133,211,184,29,48,119,180,171,43,18,198,231,27,70,255,40,50,178,193,226,11,179,65,132,208,251,141,112,60,8,143,24,192,255,200,107,253,248,9,50,3,147,184,24,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetReferenceColumnListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ef809793-d641-4f25-8bc9-32f7f5b8b0cb"),
				Name = "SetReferenceColumnList",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,239,111,218,48,16,253,28,36,254,7,143,15,85,92,69,238,246,153,82,137,1,173,208,52,173,106,232,190,187,201,209,122,74,236,200,113,232,162,170,255,251,206,63,82,48,163,213,38,65,8,190,119,119,239,222,59,95,156,143,71,183,252,17,88,94,104,209,152,239,92,226,31,205,230,101,233,15,210,214,104,33,31,217,181,210,53,55,233,228,229,243,43,43,42,224,58,165,211,73,70,92,234,29,108,65,131,44,96,161,170,174,150,237,170,20,134,45,42,1,210,172,151,148,78,67,135,119,96,190,214,120,52,30,137,45,73,29,242,199,195,47,40,140,139,255,228,85,7,228,211,140,200,174,170,200,217,25,145,240,76,110,58,81,158,70,178,141,202,29,225,148,82,155,101,145,108,85,55,166,167,228,101,60,74,118,92,147,22,42,204,129,210,151,62,196,76,143,16,27,248,109,16,16,36,136,32,56,155,48,125,94,60,65,205,131,104,136,188,111,65,47,148,148,152,45,148,100,171,191,65,111,45,220,33,193,156,19,149,216,13,152,181,108,13,71,177,190,246,247,235,50,197,172,228,223,39,167,67,151,194,43,141,93,108,242,82,56,90,92,247,151,182,78,22,6,187,114,242,39,91,165,129,23,79,36,221,39,18,33,3,81,22,60,243,42,38,214,41,15,217,187,234,39,64,178,100,54,195,189,192,51,115,56,63,6,66,114,18,88,217,37,27,170,96,52,11,77,217,130,55,150,166,35,229,91,185,129,151,220,240,92,117,186,0,54,199,57,118,112,167,158,173,80,155,190,129,210,211,115,66,92,14,83,77,142,22,110,66,93,193,4,233,197,157,188,128,3,187,228,120,63,246,20,167,49,32,172,71,92,204,99,94,237,211,62,236,119,176,92,105,51,48,181,150,164,91,173,106,107,191,238,173,208,131,87,74,151,160,31,122,31,8,251,207,219,2,100,137,83,133,213,244,65,138,158,239,61,77,27,46,112,7,175,136,253,101,223,160,207,72,116,226,135,252,200,233,67,126,52,113,106,188,127,113,209,188,181,129,122,48,208,245,11,239,251,78,118,122,107,96,44,233,137,123,249,65,163,28,140,75,155,75,39,120,92,43,139,238,170,239,73,160,106,129,184,182,135,19,225,10,119,210,216,229,252,66,93,75,164,236,106,220,162,58,241,133,32,187,96,125,92,224,90,232,214,248,203,242,31,124,93,45,175,143,127,13,242,36,94,31,252,156,95,252,1,63,243,110,74,134,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d1bda269-4f0b-41be-a8af-fa20fba8e072"),
				Name = "SetFilter",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("469c8bb7-349e-47b7-9136-8fadaa718502"),
				Name = "serializedFilters",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,95,107,219,48,16,127,142,193,223,65,237,147,13,69,253,0,91,7,93,146,21,143,173,29,75,195,158,85,251,220,106,200,82,119,146,178,101,163,223,125,167,56,142,92,59,9,169,48,88,72,167,251,253,185,187,149,64,86,9,39,22,198,99,9,236,138,125,19,143,192,63,73,229,0,103,187,243,119,105,34,107,150,197,64,62,245,136,160,221,194,161,47,157,71,96,103,87,76,123,165,242,52,97,131,117,228,21,159,26,229,27,109,249,84,129,192,44,39,156,52,177,14,165,126,100,245,134,195,13,26,255,124,43,154,64,237,188,165,53,175,164,59,167,200,21,81,55,170,106,15,45,221,31,3,218,70,209,95,87,31,215,33,97,54,0,200,153,176,44,74,110,31,16,63,5,165,147,70,111,45,232,1,30,86,28,131,122,194,134,65,105,114,121,185,49,251,186,34,65,132,32,212,87,81,162,177,81,37,255,14,82,211,157,80,242,47,244,220,111,125,10,116,206,90,179,120,97,111,137,202,29,206,155,103,183,206,44,96,251,166,163,145,231,236,95,203,32,152,214,10,183,83,163,87,128,180,35,235,52,252,30,105,183,159,173,209,187,160,108,105,131,29,90,183,118,92,176,215,116,186,220,21,140,192,41,125,47,19,159,197,136,187,135,159,148,237,253,97,211,63,140,165,92,140,232,247,225,225,143,180,142,12,25,38,122,123,119,236,17,194,79,107,147,192,37,212,230,32,151,174,113,186,154,12,215,161,135,71,154,105,84,218,190,240,61,37,57,69,195,112,213,6,65,148,79,44,139,64,133,131,134,73,61,134,221,51,20,111,82,74,51,145,69,136,78,241,11,3,101,33,216,54,153,156,82,206,144,101,143,250,144,110,242,146,38,244,221,3,162,176,166,118,124,89,240,31,240,64,77,229,208,40,203,151,78,42,154,60,176,124,174,157,116,235,232,86,188,41,118,179,121,237,157,153,65,189,99,240,106,86,183,211,190,25,215,30,235,69,249,4,141,88,22,21,159,255,242,66,217,236,198,75,218,135,1,142,227,218,139,255,98,68,21,1,130,6,226,255,31,194,100,138,240,191,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bb1f073a-2aff-4d41-8e67-86be2979345d"),
				Name = "ResetControlValues",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,203,204,41,73,45,114,77,201,44,113,47,202,47,45,80,176,85,8,72,76,79,213,115,3,11,187,36,150,36,6,231,151,22,37,131,4,242,82,32,130,197,96,133,78,149,126,137,185,169,26,72,138,65,102,32,49,193,170,64,106,52,173,185,208,44,209,115,206,73,77,44,210,208,180,6,0,135,192,169,26,129,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConfigureFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e561d849-760c-4494-b379-56d6edce3bdf"),
				Name = "ConfigureFilterEdit",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,205,78,195,48,16,132,207,228,41,172,158,18,9,249,1,8,5,85,253,83,14,136,138,82,238,38,94,202,34,199,142,236,117,80,65,188,59,78,83,74,157,70,66,226,100,101,51,158,249,60,118,35,44,3,137,180,46,95,161,18,155,66,178,49,91,137,45,240,153,32,177,54,222,150,192,39,37,97,3,15,230,157,47,129,30,119,53,200,169,81,190,210,79,66,121,184,94,122,148,55,233,232,254,249,13,74,42,228,40,203,147,162,115,187,19,58,56,89,230,170,96,186,113,96,167,70,235,32,66,163,91,167,72,148,142,230,154,144,118,209,176,245,90,89,83,130,115,221,156,213,209,215,152,105,175,84,158,224,11,75,67,8,58,22,169,15,46,217,103,114,209,223,151,166,131,74,87,101,45,217,12,28,110,117,161,29,9,93,66,26,163,95,198,125,101,76,244,98,243,228,139,129,114,192,78,176,130,123,156,196,2,84,19,186,175,93,71,115,38,248,55,202,209,41,63,63,118,237,248,188,1,77,174,15,188,175,176,167,238,218,61,146,74,60,191,197,161,18,249,2,181,60,96,19,84,127,32,15,64,182,65,93,54,187,237,150,171,48,227,63,29,12,245,157,236,159,236,2,21,129,157,7,127,190,6,138,52,241,217,218,103,213,219,48,241,100,10,141,132,66,225,7,252,254,88,90,227,235,0,69,214,67,158,124,3,183,181,0,250,46,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaIdByUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20dba574-8956-495a-b269-10146dc522e4"),
				Name = "GetSchemaIdByUId",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("26de231a-536e-4fd2-b3e3-67e19655d159"),
				Name = "uId",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,77,107,194,64,16,61,43,248,31,166,57,109,64,22,239,86,161,132,84,60,180,164,88,235,161,244,176,36,211,186,152,236,166,251,97,9,165,255,189,187,217,168,149,228,92,8,4,102,222,188,55,59,239,241,119,32,118,93,192,205,2,86,150,23,52,173,106,211,196,240,61,25,143,142,76,1,10,195,77,179,201,247,88,177,7,38,216,7,42,88,64,230,254,52,20,233,85,47,83,242,200,11,84,116,133,166,43,145,40,237,115,68,49,48,13,3,141,249,128,238,147,69,213,56,85,129,95,87,35,109,157,12,108,56,133,104,211,232,80,138,226,19,165,206,247,21,174,139,68,150,182,18,143,172,66,71,217,147,161,119,69,135,32,209,186,136,98,234,129,158,161,143,188,231,165,65,165,253,4,233,119,19,133,204,96,192,236,184,217,103,76,57,38,63,64,66,49,145,85,205,20,215,82,60,55,53,210,244,211,178,114,10,78,105,20,109,157,242,20,156,43,113,252,223,210,238,110,25,203,15,173,191,141,222,73,117,208,53,203,209,173,211,122,190,213,126,90,8,204,13,151,130,158,251,244,180,171,63,116,46,203,50,0,6,47,236,162,17,92,76,206,56,114,205,219,50,113,23,204,11,19,77,164,21,6,150,48,11,217,28,41,52,86,137,63,90,175,179,55,79,237,95,212,57,248,194,74,139,183,62,213,75,210,51,191,213,248,153,140,221,215,81,93,226,63,255,5,182,135,241,237,21,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("210faa4e-ed9d-4518-977d-c94071f55775"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,79,79,194,48,20,63,67,194,119,168,59,109,209,244,11,16,15,56,103,220,129,72,24,234,193,120,120,172,111,48,210,181,75,219,193,22,194,119,183,101,58,208,65,60,245,181,249,189,223,159,247,186,5,69,74,80,80,144,123,34,112,71,22,168,20,104,153,25,250,26,211,119,92,134,82,24,37,185,166,93,49,115,104,52,168,124,47,55,88,232,88,100,210,187,35,191,46,29,102,42,25,210,57,236,130,241,96,52,220,90,45,109,84,149,154,74,97,84,151,92,42,84,223,186,201,223,119,127,6,43,164,47,203,13,166,38,148,188,42,68,196,114,67,172,80,122,188,105,43,147,1,215,216,29,150,58,23,43,26,21,165,105,130,241,104,216,147,162,81,157,242,138,225,35,24,120,3,94,225,162,41,81,127,27,104,187,63,62,201,158,120,15,185,0,213,184,80,79,57,71,119,198,133,117,227,10,107,69,42,143,28,46,242,199,58,89,203,93,210,104,59,138,214,179,99,183,48,180,240,80,22,165,20,40,204,100,3,117,180,181,5,65,155,200,61,115,59,42,11,236,19,118,80,77,163,51,172,101,59,111,165,45,219,109,27,164,235,121,6,193,184,29,100,130,102,138,6,102,96,214,110,61,65,175,187,54,10,186,141,105,58,97,204,63,126,137,224,232,218,197,232,109,39,84,8,6,217,41,93,158,17,255,230,10,120,142,171,220,142,68,33,11,200,126,52,28,244,115,254,32,124,39,57,248,151,230,36,123,184,234,240,210,60,199,95,119,226,228,42,238,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("05ac0e6c-a733-4e93-8014-9b3b0d8a15f0"),
				Name = "ShowColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("57f07477-a5ea-4b82-a68c-23e3d57735ff"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,79,203,10,130,64,20,93,39,248,15,211,110,132,240,7,196,77,34,225,162,54,34,173,7,189,229,128,222,137,241,154,73,244,239,141,142,80,248,88,158,123,30,247,28,121,99,124,31,169,170,173,49,37,221,230,212,106,136,95,143,74,105,208,145,6,65,80,120,236,237,58,59,11,54,148,220,11,92,231,227,58,79,161,89,51,227,88,200,248,194,224,177,141,36,147,35,77,165,101,72,200,176,173,42,219,69,131,225,240,247,18,144,36,245,105,94,66,45,206,2,197,125,252,154,53,102,130,66,132,156,164,66,63,94,138,130,169,241,120,51,142,149,28,255,4,148,96,67,2,115,56,246,89,82,240,127,145,193,195,242,121,91,127,50,95,68,13,27,177,3,181,230,76,75,213,197,133,164,171,196,66,117,220,86,59,216,237,193,23,121,10,216,2,173,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetMetaPathInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("55ad0941-283a-49d1-9e34-d7bd7f5eb1af"),
				Name = "SetMetaPathInfo",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("84afa958-9117-4f60-963c-06b26aa86580"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7540e6da-7281-48a3-a592-a3e23b1d615f"),
				Name = "e",
				CreatedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				ModifiedInSchemaUId = new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,205,106,195,48,16,132,207,14,228,29,132,78,54,20,189,64,127,160,52,62,56,135,36,36,165,151,210,195,86,89,167,10,178,20,164,181,155,182,244,221,171,200,118,106,2,45,201,65,23,237,124,51,59,219,128,99,210,234,186,50,236,150,77,189,53,98,130,30,157,2,173,62,49,69,145,239,201,193,2,28,84,72,232,252,51,87,132,149,47,76,105,249,75,198,192,179,233,252,117,139,146,174,199,35,79,78,153,13,11,194,0,208,91,240,107,141,197,19,232,26,111,218,241,93,202,123,1,207,126,33,9,59,82,214,252,201,116,243,136,52,97,101,144,164,26,92,218,247,64,44,96,131,98,2,4,43,91,59,137,226,190,159,5,173,42,89,90,248,118,197,135,232,156,177,175,241,40,57,252,183,230,162,240,179,90,235,185,203,171,29,125,164,93,80,214,202,146,232,61,196,243,181,34,241,136,123,10,193,125,145,144,147,124,51,212,30,207,128,186,128,200,132,119,44,34,86,216,169,99,245,148,15,13,226,185,174,142,129,135,43,12,2,47,42,179,196,18,29,26,137,23,246,249,135,59,187,210,137,199,105,163,31,209,183,108,123,140,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportTableEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f36aac6-aa44-4be7-8c8a-3447da27d5d5"));
		}

		#endregion

	}

	#endregion

}

