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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SysModuleEntityEditPageSchema

	/// <exclude/>
	public class SysModuleEntityEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LocalizableTextEdit _captionLocalizableTextEdit;
		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionLocalizableTextEdit {
			get {
				return _captionLocalizableTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LocalizableTextEdit _editMenuCaptionLocalizableTextEdit;
		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit EditMenuCaptionLocalizableTextEdit {
			get {
				return _editMenuCaptionLocalizableTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _pageSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit PageSchemaEdit {
			get {
				return _pageSchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _typeColumnValueLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TypeColumnValueLayout {
			get {
				return _typeColumnValueLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _typeValueComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeValueComboBoxEdit {
			get {
				return _typeValueComboBoxEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _useModuleDetailsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox UseModuleDetailsEdit {
			get {
				return _useModuleDetailsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _detailsLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout DetailsLayout {
			get {
				return _detailsLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TabPanel _detailsTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel DetailsTabPanel {
			get {
				return _detailsTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _detailsEditPageTab;
		public Terrasoft.UI.WebControls.Controls.Tab DetailsEditPageTab {
			get {
				return _detailsEditPageTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _detailContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer DetailContainer {
			get {
				return _detailContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleEntityEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleEntityEditPageSchema(SysModuleEntityEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateBaseMessagePanel() {
			BaseMessagePanel.Edges = "0 0 0 0";
			BaseMessagePanel.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			RealUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			Name = "SysModuleEntityEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEntityEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateButtonsControlLayout();
			UpdateDesignerModeButton();
			UpdateApplyChangesButton();
			UpdateContextHelpButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateBaseMessagePanel();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, OKButton);
			ButtonsControlLayout.MoveItem(1, CancelButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, ContextHelpButton);
			ButtonsControlLayout.MoveItem(4, ApplyChangesButton);
			ButtonsControlLayout.MoveItem(5, DesignerModeButton);
			TopLevelControl.MoveItem(2, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateCaptionLocalizableTextEdit());
			ControlLayout1.InsertItem(1, CreateEditMenuCaptionLocalizableTextEdit());
			ControlLayout1.InsertItem(2, CreatePageSchemaEdit());
			MainControlLayout.InsertItem(1, CreateTypeColumnValueLayout());
			TypeColumnValueLayout.InsertItem(0, CreateTypeValueComboBoxEdit());
			MainControlLayout.InsertItem(2, CreateUseModuleDetailsEdit());
			MainControlLayout.MoveItem(3, CustomControls);
			Controls.AddAt(3, CreateDetailsLayout());
			DetailsLayout.InsertItem(0, CreateDetailsTabPanel());
			DetailsTabPanel.InsertItem(0, CreateDetailsEditPageTab());
			DetailsEditPageTab.InsertItem(0, CreateDetailContainer());
			TopLevelControl.MoveItem(4, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleEntityEditPageEventsProcessSchema() {
			var schema = new SysModuleEntityEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CreateCaptionLocalizableTextEdit() {
			_captionLocalizableTextEdit = new Terrasoft.UI.WebControls.Controls.LocalizableTextEdit();
			_captionLocalizableTextEdit.UId = new Guid("e6335dda-8e2f-4891-a06a-5b33dce14336");
			_captionLocalizableTextEdit.Name = "CaptionLocalizableTextEdit";
			_captionLocalizableTextEdit.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_captionLocalizableTextEdit.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_captionLocalizableTextEdit.CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			_captionLocalizableTextEdit.Tag = "";
			_captionLocalizableTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionLocalizableTextEdit.Image = new ControlImage {};
			_captionLocalizableTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _captionLocalizableTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CreateEditMenuCaptionLocalizableTextEdit() {
			_editMenuCaptionLocalizableTextEdit = new Terrasoft.UI.WebControls.Controls.LocalizableTextEdit();
			_editMenuCaptionLocalizableTextEdit.UId = new Guid("794f880a-f3f5-4528-b18b-dcaf3aa65b3d");
			_editMenuCaptionLocalizableTextEdit.Name = "EditMenuCaptionLocalizableTextEdit";
			_editMenuCaptionLocalizableTextEdit.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_editMenuCaptionLocalizableTextEdit.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_editMenuCaptionLocalizableTextEdit.CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
			_editMenuCaptionLocalizableTextEdit.Tag = "";
			_editMenuCaptionLocalizableTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_editMenuCaptionLocalizableTextEdit.Image = new ControlImage {};
			_editMenuCaptionLocalizableTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _editMenuCaptionLocalizableTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreatePageSchemaEdit() {
			_pageSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_pageSchemaEdit.UId = new Guid("d843fc5f-7004-468e-8daf-ad9aefd0b67e");
			_pageSchemaEdit.Name = "PageSchemaEdit";
			_pageSchemaEdit.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_pageSchemaEdit.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_pageSchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_pageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_pageSchemaEdit.Tag = "";
			_pageSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_pageSchemaEdit.Image = new ControlImage {};
			_pageSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageSchemaEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _pageSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("9c7f5cfa-e2ff-4110-9e82-e87136622190");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_controlLayout1.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = true;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateTypeValueComboBoxEdit() {
			_typeValueComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_typeValueComboBoxEdit.UId = new Guid("8b298006-ae07-40a6-a4fe-4b80e6c38b67");
			_typeValueComboBoxEdit.Name = "TypeValueComboBoxEdit";
			_typeValueComboBoxEdit.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_typeValueComboBoxEdit.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_typeValueComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_typeValueComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_typeValueComboBoxEdit.Tag = "";
			_typeValueComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_typeValueComboBoxEdit.Image = new ControlImage {};
			_typeValueComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_typeValueComboBoxEdit.Hidden = true;
			_typeValueComboBoxEdit.Required = true;
			return _typeValueComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTypeColumnValueLayout() {
			_typeColumnValueLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_typeColumnValueLayout.UId = new Guid("ccf40964-4ca0-4dce-b761-2d5edc4675ea");
			_typeColumnValueLayout.Name = "TypeColumnValueLayout";
			_typeColumnValueLayout.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_typeColumnValueLayout.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_typeColumnValueLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_typeColumnValueLayout.Tag = "";
			_typeColumnValueLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_typeColumnValueLayout.FitHeightByContent = true;
			_typeColumnValueLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_typeColumnValueLayout.StartNewAlignGroup = false;
			_typeColumnValueLayout.Image = new ControlImage {};
			_typeColumnValueLayout.Edges = "";
			_typeColumnValueLayout.Hidden = true;
			return _typeColumnValueLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateUseModuleDetailsEdit() {
			_useModuleDetailsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_useModuleDetailsEdit.UId = new Guid("889306f3-d94b-40a3-a084-16491eddd653");
			_useModuleDetailsEdit.Name = "UseModuleDetailsEdit";
			_useModuleDetailsEdit.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_useModuleDetailsEdit.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_useModuleDetailsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_useModuleDetailsEdit.Tag = "";
			_useModuleDetailsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useModuleDetailsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useModuleDetailsEdit.AlignedByCaption = false;
			_useModuleDetailsEdit.Margins = "0 105";
			_useModuleDetailsEdit.DataSource = "DataSource";
			_useModuleDetailsEdit.ColumnUId = new Guid("d0d94860-d13b-4cbe-a8ce-f4b5b47d54bc");
			_useModuleDetailsEdit.Enabled = false;
			_useModuleDetailsEdit.Hidden = true;
			return _useModuleDetailsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateDetailContainer() {
			_detailContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_detailContainer.UId = new Guid("1d4bed5f-164f-4079-a4c6-c3d98de2cf2d");
			_detailContainer.Name = "DetailContainer";
			_detailContainer.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailContainer.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailContainer.Tag = "";
			_detailContainer.PageSchemaUId = new Guid("6aa0eb1f-50e4-4480-a69a-5a6f67710168");
			_detailContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailContainer.StartNewAlignGroup = false;
			_detailContainer.Edges = "";
			return _detailContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateDetailsEditPageTab() {
			_detailsEditPageTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_detailsEditPageTab.UId = new Guid("3d27a9f3-9a49-46e1-8346-a48083f7e186");
			_detailsEditPageTab.Name = "DetailsEditPageTab";
			_detailsEditPageTab.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailsEditPageTab.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailsEditPageTab.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailsEditPageTab.Tag = "";
			_detailsEditPageTab.Image = new ControlImage {};
			return _detailsEditPageTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateDetailsTabPanel() {
			_detailsTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_detailsTabPanel.UId = new Guid("2f6ef1e8-faeb-41c2-a2bf-4d7fc63b36b0");
			_detailsTabPanel.Name = "DetailsTabPanel";
			_detailsTabPanel.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailsTabPanel.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailsTabPanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailsTabPanel.Tag = "";
			_detailsTabPanel.ActiveTabIndex = 0;
			_detailsTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailsTabPanel.StartNewAlignGroup = false;
			_detailsTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _detailsTabPanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateDetailsLayout() {
			_detailsLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_detailsLayout.UId = new Guid("25d5b07d-ac5a-43ce-af37-9dbb3775d22f");
			_detailsLayout.Name = "DetailsLayout";
			_detailsLayout.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailsLayout.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			_detailsLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_detailsLayout.Tag = "";
			_detailsLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailsLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_detailsLayout.StartNewAlignGroup = false;
			_detailsLayout.Image = new ControlImage {};
			_detailsLayout.Edges = "";
			_detailsLayout.HasSplitter = true;
			_detailsLayout.Enabled = false;
			_detailsLayout.Hidden = true;
			return _detailsLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
			DataSource.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("53545356-f464-4400-b225-4b5205a269df");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2ebe0ad2-1534-4da6-a69c-76e7cfcba375");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("c9432c39-3a18-4aa0-97c6-661ea48ccedc");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("1fe11345-5b9a-4ed1-8021-fc7f056dd2ca");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("19c41dd8-b974-4a6b-bcae-17e73ab00f1a");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f7b189f1-06c6-4b54-bb04-eaf91625177f");
			if (column != null) {
				column.UId = new Guid("35051def-042b-42f0-a3d5-87f9cbc7f1ad");
				column.Name = @"SysModuleEntity";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("56c33b79-2d9a-4b49-adb4-79df03d178e9");
			if (column != null) {
				column.UId = new Guid("f40eb8d2-52fc-4411-989b-7e2e8fb213f9");
				column.Name = @"TypeColumnValue";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c53035ba-426a-4b98-a5fa-2d2966b2c908");
			if (column != null) {
				column.UId = new Guid("d0d94860-d13b-4cbe-a8ce-f4b5b47d54bc");
				column.Name = @"UseModuleDetails";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ca35057b-1338-4316-9d6f-8c35f98f5db5");
			if (column != null) {
				column.UId = new Guid("a42d2512-5feb-4c4a-aceb-bde81eba3109");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae683a77-0faf-4743-a1c2-abadf29f6e98");
			if (column != null) {
				column.UId = new Guid("ee9351f1-aa1e-4a2b-87d8-5b94914e1824");
				column.Name = @"SysPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.ModifiedInSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleEntityEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleEntityEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9805f700-6b84-47c4-92b4-900cf68e882c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleEntityEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityEditPageEventsProcess

	/// <exclude/>
	public class SysModuleEntityEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleEntityEditPageSchemaUserControl
	{

		public SysModuleEntityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEntityEditPageEventsProcess";
			SchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9805f700-6b84-47c4-92b4-900cf68e882c");
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

		public virtual Guid SelectedSysModuleEntityId {
			get;
			set;
		}

		public virtual Guid TypeReferenceSchemaUid {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess5;
		public ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("5c76b2d6-0b30-4fe4-b8d5-587044ae944a"),
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
					SchemaElementUId = new Guid("442af212-5f64-4843-8f6e-a4cf3253ed04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("51a5363b-52fe-4589-9697-72cd24cb1176"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("c786c2fb-416f-4374-8beb-ac1427f25a67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
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
					SchemaElementUId = new Guid("36c15783-3e62-40de-926f-3feca50a8599"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
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
					SchemaElementUId = new Guid("7a9c9a26-6f9b-4f43-9c87-deb8cd210653"),
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
					SchemaElementUId = new Guid("de114c10-11a2-4d7e-aff8-0cc3795bfcc4"),
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
					SchemaElementUId = new Guid("b8317170-f8de-4815-a40b-a0d66919d22d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildInit;
		public ProcessFlowElement EventSubProcessChildInit {
			get {
				return _eventSubProcessChildInit ?? (_eventSubProcessChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildInit",
					SchemaElementUId = new Guid("5fa4aa91-c8d4-46ef-9e60-976f5048f4d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInit;
		public ProcessFlowElement ChildInit {
			get {
				return _childInit ?? (_childInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInit",
					SchemaElementUId = new Guid("8e0c48da-19ff-4c20-ae0d-904dfebe3b6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseInit;
		public ProcessThrowMessageEvent BaseInit {
			get {
				return _baseInit ?? (_baseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseInit",
					SchemaElementUId = new Guid("3a9636e9-c63e-4ebb-865b-7a38f90ff3c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskChildInit;
		public ProcessScriptTask ScriptTaskChildInit {
			get {
				return _scriptTaskChildInit ?? (_scriptTaskChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskChildInit",
					SchemaElementUId = new Guid("eef31672-b08f-47de-93b6-6d83b7193a77"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskChildInitExecute,
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
					SchemaElementUId = new Guid("9eaf821f-7192-421c-bee4-33a6f6b95d92"),
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
					SchemaElementUId = new Guid("d2755ef5-369d-4ebb-9b1e-2479698e5f09"),
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
					SchemaElementUId = new Guid("dc04c4d7-6bd0-4ea5-8e6b-a5e989fad334"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("a155fced-10a7-4de8-b801-29c09a935356"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("13b9e375-347d-4d12-81ce-e0d19743b7a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("06c3328f-aa38-41bc-9106-c081085b6b08"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5Execute,
				});
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
					SchemaElementUId = new Guid("c9f4c558-3fb7-404e-9eac-feaaab1e6539"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceSaved",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4 };
			FlowElements[EventSubProcessChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildInit };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[BaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInit };
			FlowElements[ScriptTaskChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskChildInit };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[ScriptTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess5":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "ScriptTask3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ScriptTask4");
						break;
					case "ScriptTask4":
						break;
					case "EventSubProcessChildInit":
						break;
					case "ChildInit":
						e.Context.QueueTasks.Enqueue("BaseInit");
						break;
					case "BaseInit":
						e.Context.QueueTasks.Enqueue("ScriptTaskChildInit");
						break;
					case "ScriptTaskChildInit":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ScriptTask5");
						break;
					case "ScriptTask5":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("ChildInit");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage4");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
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
				case "EventSubProcessChildInit":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInit";
					result = ChildInit.Execute(context);
					break;
				case "BaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = BaseInit.Execute(context);
					break;
				case "ScriptTaskChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskChildInit";
					result = ScriptTaskChildInit.Execute(context, ScriptTaskChildInitExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "ScriptTask5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5";
					result = ScriptTask5.Execute(context, ScriptTask5Execute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceSaved");
					result = IntermediateThrowMessageEvent2.Execute(context);
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
				case "TypeReferenceSchemaUid":
					TypeReferenceSchemaUid = reader.GetValue<System.Guid>();
				break;
				case "SelectedSysModuleEntityId":
					SelectedSysModuleEntityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			if (Page.DataSource.Rows.Count > 0) {
				var entity = Page.DataSource.Rows[0];
				var pageSchemaColumn = entity.Schema.Columns.GetByName("CardSchemaUId");
				var pageSchemaId = entity.GetTypedColumnValue<Guid>(pageSchemaColumn.ColumnValueName);
				SelectedSysModuleEntityId = entity.GetTypedColumnValue<Guid>("SysModuleEntityId");
				InitializeTypeColumnValueEdit();
				
				InitializePageCaptions();
				//Код, который компилируется только в Workspace CR173850 VwSysSchemaInWorkspace "4FE60977-C711-48B2-8499-1CEBBECF7868"
					var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwSysSchemaInWorkspace");
					esq.AddAllSchemaColumns();
					var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "UId", pageSchemaId);
					esq.Filters.Add(filter);
					filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace.Id", UserConnection.Workspace.Id);
					esq.Filters.Add(filter);
					var entities = esq.GetEntityCollection(UserConnection);
			
					if (entities != null && entities.Count > 0) {
							Page.PageSchemaEdit.SetValueAndText(entities[0].GetTypedColumnValue<Guid>("UId"), entities[0].GetTypedColumnValue<string>("Caption"));
					}
			
				//Page.PageSchemaEdit.SetValueAndText(pageSchemaId, GetSchemaDisplayValue(pageSchemaId));
				var typeValueColumn = entity.Schema.Columns.GetByName("TypeColumnValue");
				var typeValue = entity.GetTypedColumnValue<Guid>(typeValueColumn.ColumnValueName);
				if (TypeReferenceSchemaUid != Guid.Empty) {
					var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager");
					var schema = entitySchemaManager.GetInstanceByUId(TypeReferenceSchemaUid) as EntitySchema;
					var entitySchemaQuery = new EntitySchemaQuery(schema);
					string idColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name;
					string displayColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryDisplayColumnName()).OrderByAsc().Name;
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						schema.GetPrimaryColumnName(), typeValue));
					var typeEntities = entitySchemaQuery.GetEntityCollection(UserConnection);
					foreach(var item in typeEntities) {
						Page.TypeValueComboBoxEdit.SetValueAndText(typeValue, item.GetTypedColumnValue<string>(displayColumnName));
					}
				}
			} else {
				var result = new LocalizableString();
				result.SetCultureValue(CultureInfo.GetCultureInfo("ru-RU"), "");
				result.SetCultureValue(CultureInfo.GetCultureInfo("en-GB"), "");
				var emptyLocalizableValue = Terrasoft.Common.Json.Json.Serialize(result, new Terrasoft.Common.Json.LocalizableStringJsonConverter());
				Page.AddScript(string.Format("{0}.setValue({1});", Page.CaptionLocalizableTextEdit.ClientID, emptyLocalizableValue));
				Page.AddScript(string.Format("{0}.setValue({1});", Page.EditMenuCaptionLocalizableTextEdit.ClientID, emptyLocalizableValue));
			}
			if (Page.DetailContainer.PageInstance != null) {
				Page.DetailContainer.PageInstance.Process.SetPropertyValue("SelectedSysModuleEntityId", SelectedSysModuleEntityId);
				Page.DetailContainer.PageInstance.Process.SetPropertyValue("SelectedSysModuleEditId", EntityPrimaryColumnValue);
				if (!IsNew && !IsCopy) {
					Page.DetailContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", EntityPrimaryColumnValue);
				}
				Page.DetailContainer.PageInstance.ThrowEvent("GridPageRefreshRow");
			}
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			Page.DataSource.EnableServerActiveRow = true;
			var parentEntityIdParameter = Page.GetParameterValue("ParentEntityId") as string;
			if (parentEntityIdParameter != null) {
				//var sysModuleInWorkspaceId = Guid.Parse(parentEntityIdParameter);	
				SelectedSysModuleEntityId = Guid.Parse(parentEntityIdParameter);	//GetSysModuleEntityId(sysModuleInWorkspaceId);	
				InitializeTypeColumnValueEdit();
				Page.DataSource.BeforeInsert += delegate (object sender, DataSourceEventArgs e) {
					e.Row.SetColumnValue("SysModuleEntityId", SelectedSysModuleEntityId);
				};
			}
			var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
			aspPage.CustomData["SysModule_activeDataSource"] = Page.DataSource.ClientID;
			return true;
		}

		public virtual bool ScriptTask4Execute(ProcessExecutingContext context) {
			var entity = Page.DataSource.ActiveRow;
			if (Page.TypeValueComboBoxEdit.SelectedItem != null && Page.TypeValueComboBoxEdit.SelectedItem.Value != null) {
				var typeColumnValue = string.IsNullOrEmpty(Page.TypeValueComboBoxEdit.SelectedItem.Value.ToString()) ? Guid.Empty :
					new Guid(Page.TypeValueComboBoxEdit.SelectedItem.Value.ToString());
				entity.SetColumnValue("TypeColumnValue", typeColumnValue);
			} else {
				entity.SetColumnValue("TypeColumnValue", Guid.Empty);
			}
			return true;
		}

		public virtual bool ScriptTaskChildInitExecute(ProcessExecutingContext context) {
			Page.PageSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
			
				//Код, который компилируется только в Workspace CR173596
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"ClientUnitSchemaManager"}}});
			
			};
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			/*var schema = Page.PageSchemaEdit.Value.ToString();
			if(!string.IsNullOrEmpty(schema) && new Guid(schema) != Guid.Empty){
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysPageSchemaUId', '{1}'); ",
					Page.DataSource.ClientID,new Guid(schema)));
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysPageSchemaId', '{1}'); ",
					Page.DataSource.ClientID,new Guid(schema)));
			}*/
				return true; 
		}

		public virtual bool ScriptTask5Execute(ProcessExecutingContext context) {
			var tableESQ = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleEdit");
			var entity = tableESQ.CreateEntity(UserConnection);
			if (entity.FetchFromDB(Page.DataSource.ActiveRowPrimaryColumnValue)) {
				TSConfiguration.CommonUtilities.SaveLocalizableValue(entity, Page.CaptionLocalizableTextEdit.LocalizableText, "ActionKindCaption");
				TSConfiguration.CommonUtilities.SaveLocalizableValue(entity, Page.EditMenuCaptionLocalizableTextEdit.LocalizableText, "PageCaption");
			}
			return true;
		}

		public override void OkClickMethod() {
			var schema = Page.PageSchemaEdit.Value.ToString();
			if(!string.IsNullOrEmpty(schema) && new Guid(schema) != Guid.Empty){
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('CardSchemaUId', '{1}'); ",
					Page.DataSource.ClientID,new Guid(schema)));
				Page.ScriptManager.AddScript(string.Format("{0}.setColumnValue('SysPageSchemaUId', '{1}'); ",
					Page.DataSource.ClientID,new Guid(schema)));
			}
			
			NeedRefreshGrid = true;
			if(IsCopy){
				Page.ScriptManager.AddScript(Page.DataSource.ClientID + ".save();");
			}
			else{
				Page.ScriptManager.AddScript(
					"if (" + Page.DataSource.ClientID + ".activeRow.modifiedValues) {" 
						+ Page.DataSource.ClientID + ".save(); " + 
					"} else { window.close(); }"
				);
			}
		}

		public virtual string GetSchemaDisplayValue(Guid recordId) {
			// TODO #170704
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "VwSysSchemaInfo");
			var captionColumnName = entitySchemaQuery.AddColumn("Caption").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				entitySchemaQuery.RootSchema.GetPrimaryColumnName(), recordId));
			//Код, который компилируется только в Workspace CR173596
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"SysWorkspace", UserConnection.Workspace.Id));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<string>(captionColumnName);
			} else {
				return string.Empty;
			}
		}

		public virtual void InitializeTypeColumnValueEdit() {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleEntity");
			var entitySchemaIdColumnName = entitySchemaQuery.AddColumn("SysEntitySchemaUId").Name;
			var typeColumnValueColumnName = entitySchemaQuery.AddColumn("TypeColumnUId").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, entitySchemaQuery.RootSchema.GetPrimaryColumnName(),
				SelectedSysModuleEntityId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				var entitySchemaId = entities[0].GetTypedColumnValue<Guid>(entitySchemaIdColumnName);
				var typeColumnUId = entities[0].GetTypedColumnValue<Guid>(typeColumnValueColumnName);
				var entitySchema = entitySchemaManager.GetInstanceByUId(entitySchemaId);
				var typeColumn = entitySchema.Columns.FindByUId(typeColumnUId);
				if (typeColumn != null) {
					TypeReferenceSchemaUid = typeColumn.ReferenceSchemaUId;
					FillTypeValueEdit(typeColumn.ReferenceSchemaUId);
					Page.TypeColumnValueLayout.Hidden = false;
					Page.TypeValueComboBoxEdit.Hidden = false;
					Page.PageSchemaEdit.AlignedByCaption = true;		
					Page.UseModuleDetailsEdit.AlignedByCaption = true;
					Page.UseModuleDetailsEdit.Margins = "";
				}
			}
		}

		public virtual void FillTypeValueEdit(Guid entitySchemaId) {
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager");
			var  schema = entitySchemaManager.GetInstanceByUId(entitySchemaId) as EntitySchema;
			var entitySchemaQuery = new EntitySchemaQuery(schema);
			string idColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName()).Name;
			string displayColumnName = entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryDisplayColumnName()).OrderByAsc().Name;
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			foreach(var item in entities) {
				Page.TypeValueComboBoxEdit.AddItem(item.GetTypedColumnValue<Guid>(idColumnName), 
					item.GetTypedColumnValue<string>(displayColumnName));
			}
		}

		public override Dictionary<string, object> GetDefValues() {
			Dictionary<string, object> defValues = base.GetDefValues();
			//Код, который компилируется только в Workspace CR173596, CR173408
			//defValues["SysWorkspace"] = UserConnection.Workspace.Id;
			defValues["SysModuleEntity"] = SelectedSysModuleEntityId;
			return defValues;
		}

		public virtual Guid GetSysModuleEntityId(Guid sysModuleInWorkspaceId) {
			var query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleInSysModuleFolder");
			var column = query.AddColumn("SysModule.SysModuleEntity");
			var entity = query.GetEntity(UserConnection, sysModuleInWorkspaceId);
			if (entity != null) {
				return query.GetTypedColumnValue<Guid>(entity, column.Name);
			}
			
			query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleDetail");
			column = query.AddColumn("SysModuleGrid.SysModuleEntity");
			entity = query.GetEntity(UserConnection, sysModuleInWorkspaceId);
			if (entity != null) {
				return query.GetTypedColumnValue<Guid>(entity, column.Name);
			}
			
			return Guid.Empty;
		}

		public virtual void InitializePageCaptions() {
			var pageEntity = Page.DataSource.Rows[0];
			var primaryValue = pageEntity.GetTypedColumnValue<Guid>("Id");
			Page.CaptionLocalizableTextEdit.LocalizableText = TSConfiguration.CommonUtilities.GetLocalizableValue(UserConnection, "SysModuleEdit", "ActionKindCaption", primaryValue);
			Page.EditMenuCaptionLocalizableTextEdit.LocalizableText = TSConfiguration.CommonUtilities.GetLocalizableValue(UserConnection, "SysModuleEdit", "PageCaption", primaryValue);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "TypeValueComboBoxEditChange":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageSchemaEditChange":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
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
			if (!HasMapping("TypeReferenceSchemaUid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TypeReferenceSchemaUid", TypeReferenceSchemaUid, Guid.Empty);
			}
			if (!HasMapping("SelectedSysModuleEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedSysModuleEntityId", SelectedSysModuleEntityId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityEditPageEventsProcess

	/// <exclude/>
	public class SysModuleEntityEditPageEventsProcess : SysModuleEntityEditPageEventsProcess<Terrasoft.WebApp.SysModuleEntityEditPageSchemaUserControl>
	{

		public SysModuleEntityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEntityEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleEntityEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionLocalizableTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LocalizableTextEdit)PageContainer.FindPageControl("CaptionLocalizableTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit EditMenuCaptionLocalizableTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LocalizableTextEdit)PageContainer.FindPageControl("EditMenuCaptionLocalizableTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit PageSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("PageSchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TypeColumnValueLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TypeColumnValueLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit TypeValueComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("TypeValueComboBoxEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox UseModuleDetailsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("UseModuleDetailsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout DetailsLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("DetailsLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TabPanel DetailsTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("DetailsTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab DetailsEditPageTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("DetailsEditPageTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer DetailContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("DetailContainer", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			PageSchemaEdit.AjaxEvents.Change.Event += PageSchemaEditChange;
			TypeValueComboBoxEdit.AjaxEvents.Change.Event += TypeValueComboBoxEditChange;
			DataSource.SaveRow += DataSourceSaved;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			PageSchemaEdit.AjaxEvents.Change.Event -= PageSchemaEditChange;
			TypeValueComboBoxEdit.AjaxEvents.Change.Event -= TypeValueComboBoxEditChange;
			DataSource.SaveRow -= DataSourceSaved;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleEntityEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleEntityEditPageEventsProcess(UserConnection);
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

		public virtual void PageSchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("PageSchemaEditChange");
		}

		public virtual void TypeValueComboBoxEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("TypeValueComboBoxEditChange");
		}

		public virtual void DataSourceSaved(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceSaved");
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
			SchemaName = "SysModuleEntityEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleEntityEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEntityEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEntityEditPageEventsProcessSchema(SysModuleEntityEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEntityEditPageEventsProcess";
			UId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateSuccesfullCloseMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ddc06cd3-dd17-4f30-a93a-a0778ed58bc8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				Name = @"SuccesfullCloseMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedSysModuleEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("71285e16-9d3e-4e92-98c4-c88faade83ea"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"SelectedSysModuleEntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeReferenceSchemaUidParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("885c0ed9-e817-4b05-a2d1-38ff09eae60e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"TypeReferenceSchemaUid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSelectedSysModuleEntityIdParameter());
			Parameters.Add(CreateTypeReferenceSchemaUidParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet232 = CreateLaneSet232LaneSet();
			LaneSets.Add(schemaLaneSet232);
			ProcessSchemaLane schemaLane630 = CreateLane630Lane();
			schemaLaneSet232.Lanes.Add(schemaLane630);
			ProcessSchemaLane schemaLane631 = CreateLane631Lane();
			schemaLaneSet232.Lanes.Add(schemaLane631);
			ProcessSchemaLane schemaLane632 = CreateLane632Lane();
			schemaLaneSet232.Lanes.Add(schemaLane632);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet232.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet232.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocesschildinit = CreateEventSubProcessChildInitEventSubProcess();
			FlowElements.Add(eventsubprocesschildinit);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask2);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess5.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask4 = CreateScriptTask4ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask4);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(childinit);
			ProcessSchemaIntermediateThrowMessageEvent baseinit = CreateBaseInitIntermediateThrowMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(baseinit);
			ProcessSchemaScriptTask scripttaskchildinit = CreateScriptTaskChildInitScriptTask();
			eventsubprocesschildinit.FlowElements.Add(scripttaskchildinit);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask scripttask5 = CreateScriptTask5ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask5);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent2);
			FlowElements.Add(CreateSequenceFlow3809SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3810SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3811SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3812SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3815SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3816SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3809SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3809",
				UId = new Guid("344baac9-b862-43a5-8f49-e221611e8755"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(167, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("36c15783-3e62-40de-926f-3feca50a8599"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51a5363b-52fe-4589-9697-72cd24cb1176"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3810SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3810",
				UId = new Guid("946ffaca-195a-47c9-b183-42e224630325"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(254, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51a5363b-52fe-4589-9697-72cd24cb1176"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c786c2fb-416f-4374-8beb-ac1427f25a67"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3811SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3811",
				UId = new Guid("55134f1d-781d-4005-82c1-49df5a6dbd49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(167, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("442af212-5f64-4843-8f6e-a4cf3253ed04"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36c15783-3e62-40de-926f-3feca50a8599"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3812SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3812",
				UId = new Guid("c017388b-d697-470d-80a4-354815b762ee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de114c10-11a2-4d7e-aff8-0cc3795bfcc4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8317170-f8de-4815-a40b-a0d66919d22d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3815SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3815",
				UId = new Guid("01456e41-46c6-44e2-a63b-8a92754bdf9e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(146, 608),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8e0c48da-19ff-4c20-ae0d-904dfebe3b6c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3a9636e9-c63e-4ebb-865b-7a38f90ff3c0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3816SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3816",
				UId = new Guid("2fb5764c-c4d7-4c33-abf6-6bf7fb26cf68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(240, 610),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3a9636e9-c63e-4ebb-865b-7a38f90ff3c0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eef31672-b08f-47de-93b6-6d83b7193a77"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a34cc0bf-909f-4f32-833a-75eb1b52b159"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2755ef5-369d-4ebb-9b1e-2479698e5f09"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc04c4d7-6bd0-4ea5-8e6b-a5e989fad334"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6de7deda-5134-4b6b-9a3a-57315191ebd0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13b9e375-347d-4d12-81ce-e0d19743b7a0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06c3328f-aa38-41bc-9106-c081085b6b08"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("e7d05269-d6fc-4564-9f24-41be4a3e68f5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CurveCenterPosition = new Point(238, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("06c3328f-aa38-41bc-9106-c081085b6b08"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c9f4c558-3fb7-404e-9eac-feaaab1e6539"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet232LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet232 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1b54f0bb-fd57-4c8c-9ac9-dc75ff0175a8"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"LaneSet232",
				Position = new Point(5, 5),
				Size = new Size(956, 836),
				UseBackgroundMode = false
			};
			return schemaLaneSet232;
		}

		protected virtual ProcessSchemaLane CreateLane630Lane() {
			ProcessSchemaLane schemaLane630 = new ProcessSchemaLane(this) {
				UId = new Guid("d6d9e159-db96-4f3f-9132-a409ae17795d"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("1b54f0bb-fd57-4c8c-9ac9-dc75ff0175a8"),
				CreatedInOwnerSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"Lane630",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 478),
				Size = new Size(927, 182),
				UseBackgroundMode = false
			};
			return schemaLane630;
		}

		protected virtual ProcessSchemaLane CreateLane631Lane() {
			ProcessSchemaLane schemaLane631 = new ProcessSchemaLane(this) {
				UId = new Guid("c8dbf2a4-8d1c-4ba1-adbf-90c8cc67db61"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("1b54f0bb-fd57-4c8c-9ac9-dc75ff0175a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"Lane631",
				Position = new Point(29, 328),
				Size = new Size(927, 145),
				UseBackgroundMode = false
			};
			return schemaLane631;
		}

		protected virtual ProcessSchemaLane CreateLane632Lane() {
			ProcessSchemaLane schemaLane632 = new ProcessSchemaLane(this) {
				UId = new Guid("be548eac-169c-4681-ad71-eaffe0363ac9"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("1b54f0bb-fd57-4c8c-9ac9-dc75ff0175a8"),
				CreatedInOwnerSchemaUId = new Guid("9805f700-6b84-47c4-92b4-900cf68e882c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"Lane632",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 665),
				Size = new Size(927, 171),
				UseBackgroundMode = false
			};
			return schemaLane632;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("1e75af18-42ae-4966-b751-085491ee2ab5"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("1b54f0bb-fd57-4c8c-9ac9-dc75ff0175a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"Lane1",
				Position = new Point(29, 164),
				Size = new Size(927, 159),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("e6c921c1-1511-49fe-884d-c7941747326b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1b54f0bb-fd57-4c8c-9ac9-dc75ff0175a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(927, 159),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5c76b2d6-0b30-4fe4-b8d5-587044ae944a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6d9e159-db96-4f3f-9132-a409ae17795d"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(381, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("442af212-5f64-4843-8f6e-a4cf3253ed04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c76b2d6-0b30-4fe4-b8d5-587044ae944a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("51a5363b-52fe-4589-9697-72cd24cb1176"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c76b2d6-0b30-4fe4-b8d5-587044ae944a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c786c2fb-416f-4374-8beb-ac1427f25a67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c76b2d6-0b30-4fe4-b8d5-587044ae944a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,221,110,219,54,20,190,238,128,189,3,171,139,66,6,108,37,217,178,38,65,182,0,177,226,4,222,150,52,139,157,246,98,216,5,43,157,52,92,37,210,37,169,36,94,96,96,235,46,55,96,247,123,140,97,3,186,117,232,94,65,126,163,29,146,178,36,255,36,49,218,4,112,100,145,231,231,59,127,31,105,118,70,252,99,250,2,130,61,170,105,79,100,50,130,224,68,92,170,32,20,25,215,100,135,172,54,200,245,199,31,61,184,160,146,0,215,76,15,201,23,100,145,194,183,171,223,109,23,114,3,220,238,69,231,144,210,80,36,89,202,81,195,169,6,110,53,112,203,42,56,0,221,30,30,209,20,124,47,164,50,118,187,167,221,216,107,204,155,234,198,149,25,212,235,15,7,16,59,59,79,105,146,193,231,7,25,139,119,252,89,215,65,77,196,56,178,134,123,144,64,164,33,238,13,213,161,136,179,4,58,214,236,114,30,188,57,45,135,182,203,153,102,52,97,63,128,81,172,233,117,98,166,125,43,50,37,101,114,24,210,129,102,130,43,183,189,178,146,255,158,191,203,255,108,146,252,159,252,221,248,53,126,126,28,255,146,255,109,95,243,127,243,255,242,55,249,219,252,13,46,254,156,255,53,126,61,254,105,252,27,49,82,249,219,241,175,70,132,228,127,144,103,66,190,84,3,26,1,9,79,214,54,62,221,252,108,149,60,189,68,196,69,14,121,181,239,173,239,119,30,175,110,109,108,180,194,141,181,181,214,250,102,251,147,214,230,250,214,86,107,45,236,180,219,157,112,127,99,243,241,166,135,176,92,233,213,43,76,14,135,75,226,162,118,246,190,201,64,14,253,83,5,50,20,156,99,78,49,152,160,46,112,72,57,134,41,155,196,91,140,194,165,238,1,90,15,118,227,120,55,73,234,181,43,210,98,253,159,177,68,131,52,245,65,209,80,2,213,176,111,151,158,49,125,126,76,37,150,22,95,148,239,22,67,145,14,168,100,74,112,83,139,160,243,42,163,9,98,48,157,213,156,106,169,202,189,83,84,6,134,239,156,185,189,123,113,140,161,151,33,7,22,196,76,206,234,187,119,99,42,103,145,129,42,144,97,191,186,188,99,234,18,103,116,166,46,70,213,40,51,28,248,82,249,33,214,52,75,18,242,232,81,105,112,118,240,241,207,142,251,113,153,54,211,208,65,15,180,237,238,93,30,247,225,74,151,38,145,6,110,27,30,59,220,77,114,151,180,210,146,241,23,59,134,22,236,132,120,13,23,249,200,198,176,178,178,12,162,122,157,155,4,189,184,151,61,166,6,9,29,90,209,41,153,70,73,58,26,225,216,253,229,233,107,102,230,189,121,91,203,112,203,140,227,133,228,101,234,103,212,79,224,12,36,240,168,192,127,202,98,83,77,99,39,232,164,3,61,44,170,87,241,246,212,68,78,72,188,136,104,106,239,88,138,11,22,131,52,64,139,37,223,91,48,213,94,213,141,202,174,151,33,78,137,25,51,93,174,52,69,172,237,33,54,192,13,240,27,132,170,41,118,217,94,132,223,82,206,141,84,228,112,56,92,174,135,8,43,242,108,18,56,3,208,234,152,233,114,18,254,252,222,137,16,69,219,152,40,142,37,75,169,28,86,246,252,70,35,48,207,186,191,216,245,215,125,59,221,155,53,107,124,63,145,88,166,246,112,87,69,126,13,200,188,197,58,145,204,239,190,39,171,89,110,80,183,37,167,89,117,127,163,234,21,179,214,169,177,215,28,158,229,184,12,169,89,32,240,232,220,55,70,153,134,148,48,62,101,124,194,95,182,209,251,213,104,165,207,69,91,92,45,228,140,18,111,211,90,188,149,155,230,10,93,113,148,249,140,8,36,10,202,187,147,4,149,37,186,104,220,175,69,100,238,0,244,121,2,61,107,205,157,116,78,198,128,10,241,153,73,7,197,47,94,186,252,76,24,64,181,87,223,147,89,235,228,212,48,170,231,189,175,9,224,173,131,118,205,132,157,56,195,32,53,148,19,6,235,131,148,84,137,51,141,212,148,166,120,112,125,169,38,255,122,32,221,197,198,119,24,154,54,210,197,10,115,241,155,85,44,239,5,72,108,55,223,37,210,150,13,59,182,23,73,54,208,190,75,123,176,47,100,74,181,239,93,175,142,2,85,84,207,191,94,27,53,182,241,84,181,42,197,145,81,243,97,74,107,203,29,38,12,219,173,187,215,92,28,224,135,249,53,30,14,129,103,31,232,31,91,135,149,119,114,208,148,37,152,24,124,112,100,82,179,56,161,210,201,217,237,186,252,78,241,0,89,61,2,165,76,107,224,215,1,102,186,56,3,189,27,175,195,24,217,141,123,85,170,238,205,43,102,200,250,116,46,166,248,196,165,103,114,252,61,236,170,35,236,45,188,180,224,183,80,12,38,103,221,125,192,57,18,49,204,187,190,11,213,104,169,100,244,207,165,184,236,92,96,11,248,222,129,100,177,217,196,115,16,231,229,28,127,65,121,69,245,173,157,39,95,181,51,173,113,84,118,191,167,87,86,69,153,238,137,94,98,123,103,10,20,186,102,49,53,125,134,83,169,101,102,152,95,2,14,53,119,111,255,3,129,130,149,66,215,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("36c15783-3e62-40de-926f-3feca50a8599"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c76b2d6-0b30-4fe4-b8d5-587044ae944a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,79,2,49,16,61,67,226,127,168,123,218,141,164,252,0,194,1,97,67,246,96,178,113,81,14,198,152,194,14,155,106,105,201,116,138,65,195,127,119,22,88,65,145,196,75,147,54,243,62,230,189,230,170,2,57,82,164,10,23,112,14,50,181,106,102,160,0,92,3,14,230,164,215,112,239,222,69,95,16,6,232,93,181,215,10,197,74,33,88,74,45,105,218,100,101,174,80,45,129,0,121,40,175,201,198,64,223,111,143,202,4,136,163,252,7,34,74,132,242,194,19,106,91,49,165,94,136,248,18,229,117,95,216,96,76,34,62,175,218,173,110,183,86,247,27,127,231,202,96,32,179,83,135,111,126,165,230,144,149,44,62,14,186,148,12,245,112,137,46,233,181,152,166,0,3,115,130,178,104,136,154,185,255,114,116,187,188,226,25,58,254,219,216,94,51,179,154,180,50,250,3,38,155,21,12,157,9,75,187,203,38,45,53,197,9,167,208,202,127,21,113,11,11,135,204,229,1,73,220,244,69,201,182,43,69,32,98,55,123,229,5,132,7,91,2,118,196,17,147,174,217,241,0,43,47,96,159,88,11,36,183,39,11,160,19,201,56,58,243,30,117,196,197,84,118,230,182,124,108,247,237,43,191,170,173,54,109,15,14,87,110,116,2,136,202,187,5,201,135,76,78,97,54,116,150,208,25,47,235,1,38,56,32,229,48,120,114,203,218,246,211,209,202,139,218,125,182,227,50,209,115,35,113,18,202,208,104,94,49,27,49,27,2,5,180,251,127,249,5,2,117,17,233,197,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7a9c9a26-6f9b-4f43-9c87-deb8cd210653"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c8dbf2a4-8d1c-4ba1-adbf-90c8cc67db61"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"EventSubProcess6",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(177, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("de114c10-11a2-4d7e-aff8-0cc3795bfcc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a9c9a26-6f9b-4f43-9c87-deb8cd210653"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"TypeValueComboBoxEditChange",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"StartMessage3",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b8317170-f8de-4815-a40b-a0d66919d22d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7a9c9a26-6f9b-4f43-9c87-deb8cd210653"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ScriptTask4",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,80,77,107,131,64,16,61,43,248,31,166,57,136,66,217,31,16,145,210,90,41,185,52,33,74,239,91,157,202,194,186,27,214,89,83,9,249,239,217,172,132,180,61,73,175,243,62,230,189,55,114,3,168,72,208,4,57,236,120,135,236,149,19,175,180,53,13,178,231,134,196,136,123,125,204,162,80,124,65,226,241,122,58,224,7,151,22,11,221,127,234,23,253,93,182,130,88,133,18,27,194,118,67,216,195,67,14,202,74,9,113,12,11,37,204,195,55,97,10,167,40,12,70,23,141,156,178,208,210,246,106,38,228,48,144,17,170,99,155,225,221,17,183,166,236,15,52,45,13,54,127,97,181,174,188,73,146,166,240,4,111,86,180,204,219,192,218,125,13,20,30,253,237,255,166,110,173,96,222,212,17,233,71,252,100,85,255,238,179,122,252,219,240,42,62,3,202,1,253,6,139,109,238,45,188,67,20,26,36,107,20,144,177,152,93,0,222,131,100,123,229,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5fa4aa91-c8d4-46ef-9e60-976f5048f4d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be548eac-169c-4681-ad71-eaffe0363ac9"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"EventSubProcessChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(399, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8e0c48da-19ff-4c20-ae0d-904dfebe3b6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fa4aa91-c8d4-46ef-9e60-976f5048f4d3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3a9636e9-c63e-4ebb-865b-7a38f90ff3c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fa4aa91-c8d4-46ef-9e60-976f5048f4d3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"BaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eef31672-b08f-47de-93b6-6d83b7193a77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5fa4aa91-c8d4-46ef-9e60-976f5048f4d3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ScriptTaskChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,82,203,74,3,49,20,93,91,232,63,92,102,85,113,24,17,81,145,106,65,106,5,65,101,176,62,22,226,34,118,110,167,177,105,102,76,50,106,41,3,62,150,10,238,253,12,81,240,69,253,133,204,31,121,167,83,68,23,46,5,23,73,72,56,175,156,196,103,33,122,62,77,205,86,7,123,172,17,112,227,249,10,99,166,112,35,138,186,73,188,198,133,65,5,83,203,16,160,192,144,25,132,74,116,116,140,45,3,26,101,128,202,133,2,152,83,27,167,40,205,138,10,53,224,36,12,202,165,137,122,36,4,65,121,36,151,86,249,104,101,170,191,164,141,226,50,116,161,208,169,213,160,61,50,209,176,12,232,21,134,186,90,46,17,127,122,218,222,219,161,125,116,193,190,218,97,118,69,227,34,187,177,47,163,173,125,183,31,246,217,190,217,103,58,188,182,79,217,85,118,153,221,65,142,178,111,217,109,14,1,251,0,251,145,234,234,152,181,16,234,219,51,11,179,115,139,243,36,60,118,244,86,130,160,34,241,12,126,79,7,3,32,252,196,192,105,69,61,170,133,235,72,238,244,99,116,92,40,146,214,127,28,123,141,147,132,137,212,29,115,4,182,77,227,60,86,168,53,169,83,27,73,79,250,204,116,136,237,52,251,250,43,154,183,30,56,169,91,112,18,141,171,92,199,130,245,247,152,72,114,163,54,19,26,191,52,21,15,59,223,68,125,166,88,15,41,200,8,173,9,158,223,167,8,127,112,8,131,252,113,189,93,157,7,149,178,120,11,239,187,111,154,166,147,213,255,209,200,38,147,20,86,109,209,125,254,170,13,167,46,56,253,209,93,201,77,241,227,199,158,206,184,134,114,41,165,89,161,73,148,4,163,18,172,126,2,72,62,4,80,34,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9eaf821f-7192-421c-bee4-33a6f6b95d92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1e75af18-42ae-4966-b751-085491ee2ab5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d2755ef5-369d-4ebb-9b1e-2479698e5f09"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9eaf821f-7192-421c-bee4-33a6f6b95d92"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageSchemaEditChange",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"StartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dc04c4d7-6bd0-4ea5-8e6b-a5e989fad334"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9eaf821f-7192-421c-bee4-33a6f6b95d92"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,143,75,107,195,48,16,132,207,13,228,63,108,114,136,165,96,148,246,108,114,40,121,225,67,31,160,182,119,97,169,137,64,150,195,106,149,18,140,255,123,29,57,164,208,107,123,89,152,97,119,230,219,197,252,164,16,66,117,48,181,130,37,188,170,189,17,151,33,147,179,209,150,196,135,114,209,136,183,70,18,90,191,103,188,24,143,236,39,155,132,36,69,25,158,163,115,47,184,169,143,116,102,67,16,135,217,12,188,249,130,93,180,250,230,77,150,73,139,180,201,219,241,232,46,181,201,10,237,145,158,148,239,5,138,71,173,7,131,93,243,183,13,214,138,216,180,189,239,68,48,180,106,92,172,125,66,98,153,60,135,31,214,247,82,103,57,100,237,67,151,241,2,166,121,159,63,20,172,21,41,217,68,172,140,88,57,107,60,149,235,252,55,28,191,124,245,191,60,127,198,233,230,139,254,8,13,69,244,64,24,77,1,223,1,141,67,156,174,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a155fced-10a7-4de8-b801-29c09a935356"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6c921c1-1511-49fe-884d-c7941747326b"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(514, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("13b9e375-347d-4d12-81ce-e0d19743b7a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a155fced-10a7-4de8-b801-29c09a935356"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"StartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask5ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("06c3328f-aa38-41bc-9106-c081085b6b08"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a155fced-10a7-4de8-b801-29c09a935356"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"ScriptTask5",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,144,209,74,195,48,20,134,175,45,244,29,66,175,90,24,121,129,225,197,214,109,34,90,153,102,243,254,44,61,219,2,77,34,233,73,181,138,239,110,146,77,152,222,9,222,134,124,223,255,255,103,0,199,8,118,29,46,197,35,187,102,219,30,93,109,141,65,73,202,26,190,52,164,104,20,242,136,26,26,48,112,64,199,111,144,110,77,79,96,36,206,199,7,208,88,22,98,236,27,219,250,32,105,21,21,213,52,207,134,160,197,4,7,233,183,159,215,14,129,240,36,45,127,70,69,72,237,89,121,130,248,10,73,30,87,206,234,197,188,92,135,88,190,0,2,97,189,147,200,103,1,24,240,201,190,174,157,210,224,198,218,118,94,155,103,232,60,86,21,251,200,179,171,141,8,226,189,58,120,7,105,70,109,181,182,102,75,170,83,164,176,231,2,6,188,183,18,58,245,30,171,37,244,156,60,97,41,174,134,151,72,94,124,218,224,27,197,121,252,215,219,132,21,179,180,224,78,153,246,140,165,19,252,67,139,152,215,160,241,127,106,19,201,203,30,159,121,230,144,188,51,140,156,199,233,23,187,172,138,188,241,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c9f4c558-3fb7-404e-9eac-feaaab1e6539"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a155fced-10a7-4de8-b801-29c09a935356"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 51),
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
			Methods.Add(CreateGetSchemaDisplayValueMethod());
			Methods.Add(CreateInitializeTypeColumnValueEditMethod());
			Methods.Add(CreateFillTypeValueEditMethod());
			Methods.Add(CreateGetSysModuleEntityIdMethod());
			Methods.Add(CreateInitializePageCaptionsMethod());
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
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,49,107,195,48,16,133,231,24,252,31,46,26,98,153,6,209,206,33,67,113,210,224,161,105,137,219,238,194,58,39,2,219,50,146,156,16,140,255,123,101,57,180,80,104,83,200,34,120,167,227,123,239,238,142,92,131,201,15,88,113,88,194,43,223,35,27,158,204,87,214,66,90,246,193,203,22,217,155,202,172,150,245,158,198,139,48,144,5,157,26,47,89,106,182,109,89,190,232,117,213,216,51,29,65,49,204,102,80,227,9,54,173,20,95,181,233,210,107,230,59,227,46,12,38,222,45,203,181,108,236,51,175,157,208,236,81,136,177,64,47,252,39,165,43,110,41,233,238,123,102,208,38,170,108,171,218,71,162,81,194,181,24,131,190,167,34,154,67,212,61,244,81,188,0,50,119,240,145,190,226,150,103,170,213,57,178,164,148,88,219,116,53,255,153,44,30,70,186,57,76,118,54,223,139,187,61,79,31,6,97,176,69,20,59,44,52,154,195,70,75,225,14,100,117,139,227,1,82,147,168,230,31,123,252,205,22,238,128,48,195,143,232,46,74,46,142,88,26,188,10,28,102,33,178,0,74,28,226,79,58,207,173,60,226,78,157,88,165,132,44,36,10,191,43,19,67,71,96,192,76,174,0,46,241,96,112,242,182,61,12,17,161,131,147,172,133,227,230,165,50,190,163,39,238,223,79,241,9,0,211,89,143,208,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,200,79,202,74,77,46,177,83,72,73,77,11,75,204,41,77,45,86,176,85,72,74,44,78,213,115,79,45,113,129,137,105,104,90,243,114,233,235,95,152,117,97,223,133,45,58,10,23,118,93,216,119,177,9,136,27,46,118,95,216,9,230,94,216,115,97,255,133,29,23,118,95,216,1,20,108,190,176,245,98,211,197,198,139,253,10,32,85,23,118,95,236,1,41,81,184,176,73,33,60,191,40,187,184,32,49,57,85,193,57,200,208,220,216,212,210,76,7,194,50,49,176,0,217,0,119,69,180,82,112,101,49,92,181,82,44,208,85,161,197,169,69,206,249,121,121,169,96,63,232,193,37,245,60,83,128,174,67,213,233,155,159,82,154,147,234,154,87,146,89,82,9,214,28,156,154,3,212,151,154,130,38,7,214,90,148,90,82,90,148,135,8,1,107,0,72,231,55,182,39,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0383c94c-9e5e-4345-867c-a14c0f0e56a4"),
				Name = "GetSchemaDisplayValue",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("123889bb-a761-433a-9935-205a2b63f193"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,205,106,213,64,20,199,215,22,250,14,135,184,153,64,152,123,139,31,23,81,11,18,175,210,133,246,218,94,219,133,184,24,146,115,219,193,100,38,158,153,180,4,17,180,46,21,220,251,24,162,80,173,212,87,152,188,145,51,77,188,90,115,215,46,194,144,255,252,207,111,206,215,104,4,243,237,251,219,112,117,99,50,158,140,175,175,175,29,9,2,84,86,218,102,55,59,196,82,60,18,74,28,32,193,93,152,249,147,119,34,191,116,55,35,125,36,115,36,254,16,109,47,177,104,58,100,68,49,8,3,115,36,18,70,47,44,79,53,33,191,240,73,52,124,69,192,237,97,58,79,106,164,198,39,163,240,24,166,255,234,108,69,226,9,68,123,199,187,141,233,196,45,181,208,81,220,115,51,81,89,169,85,170,139,186,84,143,69,137,158,59,120,139,223,203,243,206,193,162,180,11,136,98,30,220,158,50,116,63,144,133,69,50,33,138,13,111,83,66,97,177,243,236,75,123,56,19,228,65,33,128,117,98,170,203,74,144,52,90,205,155,202,55,231,101,45,138,100,125,237,202,16,181,163,181,237,135,225,219,62,35,89,10,106,254,148,194,226,4,8,51,77,249,86,30,135,130,71,35,247,201,157,187,47,9,184,239,238,188,61,241,223,155,246,189,251,118,241,235,126,184,159,238,212,157,185,83,47,190,115,95,219,147,246,109,251,17,130,203,157,181,31,130,5,220,103,216,215,244,194,84,34,67,72,119,54,38,215,110,220,186,249,31,91,16,249,33,46,19,136,18,120,106,130,87,41,204,194,76,248,242,138,247,5,47,55,199,47,215,202,193,250,182,117,27,228,187,86,116,20,118,25,26,48,114,1,236,55,198,111,108,173,44,108,194,56,134,87,62,37,66,91,147,90,190,242,108,252,60,64,67,218,253,202,236,137,162,198,59,198,146,84,7,155,108,176,111,129,255,26,176,48,248,55,174,179,243,105,89,217,38,24,126,1,180,231,40,169,163,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeTypeColumnValueEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1dab9f36-b68a-4d07-9012-f50437ee82fe"),
				Name = "InitializeTypeColumnValueEdit",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,77,143,218,48,16,134,207,65,226,63,184,57,57,18,178,246,190,237,74,187,41,221,34,149,138,46,176,61,84,61,184,120,96,45,57,54,181,29,218,168,218,255,94,79,156,101,201,7,168,189,4,197,158,247,153,153,119,38,28,184,37,160,189,244,213,114,243,4,5,159,115,205,119,96,201,59,178,8,191,44,30,178,214,221,194,154,131,20,96,217,61,248,230,136,166,211,62,35,205,8,119,100,5,214,114,103,182,158,229,198,2,171,227,36,56,54,32,184,30,143,14,157,114,190,148,96,171,80,140,134,95,100,218,61,167,3,133,79,72,186,172,220,220,136,82,65,20,164,217,0,119,38,114,163,202,66,127,230,5,4,124,47,37,187,21,77,4,69,222,105,234,245,76,164,25,67,97,195,245,213,30,98,236,35,87,37,252,59,120,117,20,182,152,125,205,7,169,60,88,135,90,218,191,205,45,112,15,49,230,171,244,79,11,110,3,8,5,52,30,230,166,216,115,43,157,209,152,145,77,127,150,92,77,6,74,123,48,198,55,3,15,163,93,88,89,112,91,189,182,67,179,201,120,148,44,65,193,198,131,232,184,60,19,89,203,231,48,226,193,246,3,56,10,2,23,65,210,104,186,118,88,163,214,241,21,49,114,75,232,11,38,236,77,169,61,185,33,87,25,249,19,10,232,143,242,37,81,8,254,118,245,29,83,96,159,226,100,38,111,239,75,41,110,232,185,13,192,148,73,123,148,235,255,192,158,93,128,35,247,52,113,199,150,102,111,17,63,211,206,115,189,129,187,42,100,239,20,59,80,98,7,196,226,169,11,219,162,69,68,180,218,169,9,104,236,9,225,77,248,178,74,165,162,177,9,182,247,0,91,176,16,138,104,150,93,162,13,175,10,214,189,159,9,196,38,97,209,20,202,107,3,166,66,122,122,81,83,215,146,212,255,48,171,182,121,159,120,101,74,207,62,74,33,0,59,220,114,229,160,29,221,152,92,252,48,119,230,55,230,58,27,141,143,152,179,14,187,85,114,167,33,120,147,243,61,110,26,118,102,75,184,78,146,163,34,172,98,220,234,247,224,185,84,238,162,238,178,106,206,237,78,106,252,10,210,20,67,159,199,163,231,191,242,232,204,1,110,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillTypeValueEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f5b7f629-d7f5-40e9-9b37-53fffde9a2a3"),
				Name = "FillTypeValueEdit",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9168a92-debc-435f-85c1-a4c208257272"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,223,78,195,32,20,198,175,219,167,32,187,130,196,244,5,212,37,107,93,150,94,168,245,207,188,199,114,220,72,10,44,64,171,196,248,238,66,169,181,91,231,157,87,132,195,119,126,223,225,131,142,106,4,210,114,235,158,234,61,8,122,75,37,221,129,70,215,168,242,107,22,139,217,209,89,165,85,199,25,232,108,3,118,40,225,197,122,206,88,144,203,180,243,120,100,250,170,71,158,49,10,144,82,26,75,101,13,185,219,150,12,79,69,37,35,136,26,52,133,71,230,84,244,208,130,118,158,46,225,253,72,217,215,113,52,247,163,24,171,185,220,33,206,10,213,180,66,222,81,1,39,35,245,13,217,138,13,10,60,63,123,84,202,14,145,248,185,43,205,5,213,238,151,135,9,201,194,58,154,49,110,14,13,117,255,237,120,115,138,13,198,247,218,191,73,238,86,166,198,63,83,140,73,113,48,103,157,61,50,38,230,81,13,212,150,43,137,183,6,116,161,164,140,91,31,220,155,210,64,235,61,14,52,110,65,32,46,71,42,65,159,105,210,255,148,103,119,128,23,218,180,80,40,241,170,114,245,177,102,220,134,171,149,190,5,135,190,224,22,84,195,101,123,241,213,166,229,108,137,167,143,66,46,80,154,36,127,54,196,100,151,120,22,45,241,163,126,125,3,56,88,162,122,207,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysModuleEntityIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e8673bf6-c3cc-404b-ad86-301e811d5d1c"),
				Name = "GetSysModuleEntityId",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("68da3972-7b42-4040-8769-b9ecaff225b3"),
				Name = "sysModuleInWorkspaceId",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				ModifiedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,80,205,106,194,64,16,62,27,200,59,108,61,69,8,251,2,254,128,168,13,30,20,138,181,158,151,236,180,46,221,204,198,201,174,178,148,190,123,147,184,36,34,61,120,232,161,183,153,97,190,223,179,32,118,114,64,158,77,25,194,133,173,208,42,235,119,249,17,10,241,210,220,147,125,5,180,48,136,144,91,101,144,223,62,108,4,138,15,160,148,13,119,190,218,24,233,52,172,177,27,159,141,150,64,195,209,56,142,206,181,74,110,180,43,176,150,105,229,248,92,202,69,123,73,122,48,239,166,171,74,135,133,118,237,176,25,216,235,195,157,185,148,85,189,143,131,161,207,170,20,57,172,101,67,163,222,89,18,104,158,234,168,78,235,17,251,138,163,1,129,117,132,61,241,171,47,33,56,123,19,218,193,36,115,74,206,2,52,13,41,248,86,20,208,176,126,199,81,28,253,101,127,75,176,66,233,54,248,3,133,101,164,228,175,165,253,239,194,2,69,243,200,87,69,105,253,248,7,234,177,113,196,135,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializePageCaptionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0287b2ee-23a5-48a3-8b61-6f5e3f1a1fd5"),
				Name = "InitializePageCaptions",
				CreatedInSchemaUId = new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,143,79,107,194,64,16,197,239,5,191,67,200,73,161,44,189,251,7,36,138,148,86,16,19,189,136,135,49,59,202,192,102,39,108,102,213,248,233,221,13,210,138,208,123,143,243,230,253,230,189,57,131,75,106,56,225,220,10,73,155,140,147,85,24,212,12,4,114,246,174,68,181,230,75,179,251,216,15,123,111,231,104,117,84,129,107,183,96,60,6,243,47,169,22,40,69,91,163,206,216,248,202,118,134,209,194,147,158,244,211,79,157,14,2,223,93,206,160,22,98,251,205,37,24,186,193,193,96,129,87,153,107,18,245,162,133,243,69,158,177,61,210,201,59,136,144,202,184,170,216,110,132,12,9,97,19,51,159,160,46,179,191,105,208,5,202,98,25,145,247,36,205,219,102,201,218,27,140,33,105,16,166,221,230,139,172,126,148,9,226,243,95,63,93,35,176,68,235,255,65,231,216,231,239,182,119,185,151,237,1,197,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEntityEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4d38cea-ad13-42ce-a010-35050d3caf38"));
		}

		#endregion

	}

	#endregion

}

