namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
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
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: LookupGridPageSchema

	/// <exclude/>
	public class LookupGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _searchControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SearchControlLayout {
			get {
				return _searchControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _schemaListEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SchemaListEdit {
			get {
				return _schemaListEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _searchComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SearchComboBoxEdit {
			get {
				return _searchComboBoxEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _searchEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SearchEdit {
			get {
				return _searchEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _toolButtonClearSearch;
		public Terrasoft.UI.WebControls.Controls.ToolButton ToolButtonClearSearch {
			get {
				return _toolButtonClearSearch;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _searchButton;
		public Terrasoft.UI.WebControls.Controls.Button SearchButton {
			get {
				return _searchButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacerDeleteButton;
		public Terrasoft.UI.WebControls.Controls.Spacer SpacerDeleteButton {
			get {
				return _spacerDeleteButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _commonControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout CommonControlLayout {
			get {
				return _commonControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _selectedRowsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SelectedRowsControlLayout {
			get {
				return _selectedRowsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _selectedRecordButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SelectedRecordButtonsControlLayout {
			get {
				return _selectedRecordButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addSelectedRecordButton;
		public Terrasoft.UI.WebControls.Controls.Button AddSelectedRecordButton {
			get {
				return _addSelectedRecordButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _removeSelectedRecordButton;
		public Terrasoft.UI.WebControls.Controls.Button RemoveSelectedRecordButton {
			get {
				return _removeSelectedRecordButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer2;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return _spacer2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _selectedRecordsGridContolLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SelectedRecordsGridContolLayout {
			get {
				return _selectedRecordsGridContolLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _selectedRecordsGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid SelectedRecordsGrid {
			get {
				return _selectedRecordsGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _actionButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ActionButtonsControlLayout {
			get {
				return _actionButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacerOKButton;
		public Terrasoft.UI.WebControls.Controls.Spacer SpacerOKButton {
			get {
				return _spacerOKButton;
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

		#endregion

		#region Constructors: Public

		public LookupGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LookupGridPageSchema(LookupGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.Enabled = true;
			SendEmailMenuItem.Hidden = false;
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.DblClick.ShowLoadMask = true;
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
			TreeGrid.AjaxEvents.SelectionChange.ShowLoadMask = true;
			TreeGrid.Edges = "0 0 1 0";
			TreeGrid.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			RealUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			Name = "LookupGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 650;
			Height = 375;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLookupGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateSearchControlLayout());
			SearchControlLayout.InsertItem(0, CreateSchemaListEdit());
			SearchControlLayout.InsertItem(1, CreateSearchComboBoxEdit());
			SearchControlLayout.InsertItem(2, CreateSearchEdit());
			SearchEdit.InsertItem(0, CreateToolButtonClearSearch());
			SearchControlLayout.InsertItem(3, CreateSearchButton());
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.InsertItem(4, CreateSpacerDeleteButton());
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			ButtonsControlLayout.MoveItem(8, ActionButton);
			Controls.AddAt(3, CreateCommonControlLayout());
			CommonControlLayout.MoveItem(0, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, CallMenuItem);
			TreeGrid.MoveItem(2, ShowChangelogMenuItem);
			CommonControlLayout.InsertItem(1, CreateSelectedRowsControlLayout());
			SelectedRowsControlLayout.InsertItem(0, CreateSelectedRecordButtonsControlLayout());
			SelectedRecordButtonsControlLayout.InsertItem(0, CreateSpacer1());
			SelectedRecordButtonsControlLayout.InsertItem(1, CreateAddSelectedRecordButton());
			SelectedRecordButtonsControlLayout.InsertItem(2, CreateRemoveSelectedRecordButton());
			SelectedRecordButtonsControlLayout.InsertItem(3, CreateSpacer2());
			SelectedRowsControlLayout.InsertItem(1, CreateSelectedRecordsGridContolLayout());
			SelectedRecordsGridContolLayout.InsertItem(0, CreateSelectedRecordsGrid());
			Controls.AddAt(4, CreateActionButtonsControlLayout());
			ActionButtonsControlLayout.InsertItem(0, CreateSpacerOKButton());
			ActionButtonsControlLayout.InsertItem(1, CreateOKButton());
			ActionButtonsControlLayout.InsertItem(2, CreateCancelButton());
			TopLevelControl.MoveItem(5, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateLookupGridPageEventsProcessSchema() {
			var schema = new LookupGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("62a18e7e-d9ab-4779-bd78-7efed0d36771");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateSchemaListEdit() {
			_schemaListEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_schemaListEdit.UId = new Guid("2495e530-4584-45f3-bf6d-9c5631a778b2");
			_schemaListEdit.Name = "SchemaListEdit";
			_schemaListEdit.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_schemaListEdit.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_schemaListEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_schemaListEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_schemaListEdit.Tag = "";
			_schemaListEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_schemaListEdit.Image = new ControlImage {};
			_schemaListEdit.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			_schemaListEdit.Margins = "0 5 0 0";
			_schemaListEdit.Hidden = true;
			return _schemaListEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateSearchComboBoxEdit() {
			_searchComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_searchComboBoxEdit.UId = new Guid("8230dc58-fed5-44dd-b089-27050a42e10b");
			_searchComboBoxEdit.Name = "SearchComboBoxEdit";
			_searchComboBoxEdit.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchComboBoxEdit.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_searchComboBoxEdit.Tag = "";
			_searchComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_searchComboBoxEdit.Image = new ControlImage {};
			_searchComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			_searchComboBoxEdit.AlignedByCaption = false;
			_searchComboBoxEdit.Margins = "0 5 0 0";
			return _searchComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateToolButtonClearSearch() {
			_toolButtonClearSearch = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_toolButtonClearSearch.UId = new Guid("8c231974-7f1f-462e-a678-49fb690d76eb");
			_toolButtonClearSearch.Name = "ToolButtonClearSearch";
			_toolButtonClearSearch.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_toolButtonClearSearch.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_toolButtonClearSearch.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_toolButtonClearSearch.AjaxEvents.Click.IsProcessEventHandler = true;
			_toolButtonClearSearch.Tag = "";
			_toolButtonClearSearch.Image = new ControlImage {
				Source = ControlImageSource.ResourceManager,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ResourceManagerName = @"Terrasoft.UI.WebControls",
				ResourceItemName = @"toolbutton-close.gif",
				ImageHash = @"6936621ac4b4c164b51744b8634fe7a0"
			};
			return _toolButtonClearSearch;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSearchEdit() {
			_searchEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_searchEdit.UId = new Guid("8d0235f0-d6ca-4afb-98a4-e7a76978ed03");
			_searchEdit.Name = "SearchEdit";
			_searchEdit.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchEdit.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchEdit.Tag = "";
			_searchEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_searchEdit.Image = new ControlImage {};
			_searchEdit.Width = System.Web.UI.WebControls.Unit.Percentage(60);
			_searchEdit.AlignedByCaption = false;
			_searchEdit.Margins = "0 0 0 0";
			return _searchEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSearchButton() {
			_searchButton = new Terrasoft.UI.WebControls.Controls.Button();
			_searchButton.UId = new Guid("e5bf2556-85ae-43de-a253-a9d1f3b81f3a");
			_searchButton.Name = "SearchButton";
			_searchButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_searchButton.Tag = "";
			_searchButton.Image = new ControlImage {};
			_searchButton.Margins = "0 0 0 5";
			return _searchButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSearchControlLayout() {
			_searchControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_searchControlLayout.UId = new Guid("06bd4e5f-fd10-4c8d-99bc-3aa90f8dfa66");
			_searchControlLayout.Name = "SearchControlLayout";
			_searchControlLayout.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchControlLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_searchControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchControlLayout.Tag = "";
			_searchControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(100);
			_searchControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_searchControlLayout.FitHeightByContent = true;
			_searchControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_searchControlLayout.StartNewAlignGroup = false;
			_searchControlLayout.Image = new ControlImage {};
			_searchControlLayout.Edges = "0 0 1 0";
			return _searchControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacerDeleteButton() {
			_spacerDeleteButton = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacerDeleteButton.UId = new Guid("85fa6062-4b59-4237-b10c-ad90a46b9cf9");
			_spacerDeleteButton.Name = "SpacerDeleteButton";
			_spacerDeleteButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacerDeleteButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacerDeleteButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacerDeleteButton.Tag = "";
			_spacerDeleteButton.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacerDeleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("e9e9dd62-88c3-487b-a7e6-9c67a2c59ada");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacer1.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddSelectedRecordButton() {
			_addSelectedRecordButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addSelectedRecordButton.UId = new Guid("99181a94-f93d-43a3-b5c6-1f045a06abad");
			_addSelectedRecordButton.Name = "AddSelectedRecordButton";
			_addSelectedRecordButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_addSelectedRecordButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_addSelectedRecordButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addSelectedRecordButton.Tag = "";
			_addSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"f5fb6c4a8d5abab00bede0e49a38a6ff"
			};
			_addSelectedRecordButton.Width = System.Web.UI.WebControls.Unit.Pixel(25);
			_addSelectedRecordButton.AutoWidth = false;
			_addSelectedRecordButton.Margins = "5 5 5 5";
			return _addSelectedRecordButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateRemoveSelectedRecordButton() {
			_removeSelectedRecordButton = new Terrasoft.UI.WebControls.Controls.Button();
			_removeSelectedRecordButton.UId = new Guid("5b52638e-c005-480d-b162-1af2f17b742c");
			_removeSelectedRecordButton.Name = "RemoveSelectedRecordButton";
			_removeSelectedRecordButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_removeSelectedRecordButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_removeSelectedRecordButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_removeSelectedRecordButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_removeSelectedRecordButton.Tag = "";
			_removeSelectedRecordButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			_removeSelectedRecordButton.Width = System.Web.UI.WebControls.Unit.Pixel(25);
			_removeSelectedRecordButton.AutoWidth = false;
			_removeSelectedRecordButton.Margins = "5 5 5 5";
			return _removeSelectedRecordButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer2() {
			_spacer2 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer2.UId = new Guid("ac19f73a-b7cb-4cf3-b360-fda1d033a50b");
			_spacer2.Name = "Spacer2";
			_spacer2.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacer2.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacer2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer2.Tag = "";
			_spacer2.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSelectedRecordButtonsControlLayout() {
			_selectedRecordButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_selectedRecordButtonsControlLayout.UId = new Guid("4d100e38-6891-4925-b0fa-18ea919a354b");
			_selectedRecordButtonsControlLayout.Name = "SelectedRecordButtonsControlLayout";
			_selectedRecordButtonsControlLayout.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRecordButtonsControlLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRecordButtonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_selectedRecordButtonsControlLayout.Tag = "";
			_selectedRecordButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_selectedRecordButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_selectedRecordButtonsControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_selectedRecordButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Pixel(36);
			_selectedRecordButtonsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Center;
			_selectedRecordButtonsControlLayout.StartNewAlignGroup = false;
			_selectedRecordButtonsControlLayout.DefaultMargins = "5 5 5 5";
			_selectedRecordButtonsControlLayout.Image = new ControlImage {};
			_selectedRecordButtonsControlLayout.Edges = "0 0 0 1";
			return _selectedRecordButtonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateSelectedRecordsGrid() {
			_selectedRecordsGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_selectedRecordsGrid.UId = new Guid("d71a48b1-b24c-4e08-b282-29c0e8c90cef");
			_selectedRecordsGrid.Name = "SelectedRecordsGrid";
			_selectedRecordsGrid.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRecordsGrid.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRecordsGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_selectedRecordsGrid.Tag = "";
			_selectedRecordsGrid.Edges = "0 1 0 0";
			_selectedRecordsGrid.IsColumnAutowidth = true;
			_selectedRecordsGrid.FooterVisible = false;
			_selectedRecordsGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_selectedRecordsGrid.IsSummaryVisible = false;
			_selectedRecordsGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_selectedRecordsGrid.HideHeaders = false;
			return _selectedRecordsGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSelectedRecordsGridContolLayout() {
			_selectedRecordsGridContolLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_selectedRecordsGridContolLayout.UId = new Guid("8b44b275-984b-4177-aaca-a5b3a00295f0");
			_selectedRecordsGridContolLayout.Name = "SelectedRecordsGridContolLayout";
			_selectedRecordsGridContolLayout.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRecordsGridContolLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRecordsGridContolLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_selectedRecordsGridContolLayout.Tag = "";
			_selectedRecordsGridContolLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_selectedRecordsGridContolLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_selectedRecordsGridContolLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_selectedRecordsGridContolLayout.StartNewAlignGroup = false;
			_selectedRecordsGridContolLayout.Image = new ControlImage {};
			_selectedRecordsGridContolLayout.Edges = "0 0 1 1";
			return _selectedRecordsGridContolLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSelectedRowsControlLayout() {
			_selectedRowsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_selectedRowsControlLayout.UId = new Guid("114dd4e2-2934-48ee-8925-60af293ab6e1");
			_selectedRowsControlLayout.Name = "SelectedRowsControlLayout";
			_selectedRowsControlLayout.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRowsControlLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_selectedRowsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_selectedRowsControlLayout.Tag = "";
			_selectedRowsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_selectedRowsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_selectedRowsControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_selectedRowsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(90);
			_selectedRowsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Center;
			_selectedRowsControlLayout.StartNewAlignGroup = false;
			_selectedRowsControlLayout.Image = new ControlImage {};
			_selectedRowsControlLayout.Edges = "";
			_selectedRowsControlLayout.Hidden = true;
			return _selectedRowsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateCommonControlLayout() {
			_commonControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_commonControlLayout.UId = new Guid("8c89b2c9-5e23-4223-a510-f93133ae4dd7");
			_commonControlLayout.Name = "CommonControlLayout";
			_commonControlLayout.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_commonControlLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_commonControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_commonControlLayout.Tag = "";
			_commonControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(90);
			_commonControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_commonControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_commonControlLayout.StartNewAlignGroup = false;
			_commonControlLayout.Image = new ControlImage {};
			_commonControlLayout.Edges = "";
			return _commonControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacerOKButton() {
			_spacerOKButton = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacerOKButton.UId = new Guid("225425ba-2aef-45b8-b856-8992650de35b");
			_spacerOKButton.Name = "SpacerOKButton";
			_spacerOKButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacerOKButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_spacerOKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacerOKButton.Tag = "";
			_spacerOKButton.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacerOKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("76d57a6c-2cf3-487e-a33a-0bcc64a5e73b");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_oKButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_oKButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("e461149f-3770-45b8-8baf-088600fe3044");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_cancelButton.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateActionButtonsControlLayout() {
			_actionButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_actionButtonsControlLayout.UId = new Guid("6ccf19dd-689d-4a41-b184-b6550bd568bb");
			_actionButtonsControlLayout.Name = "ActionButtonsControlLayout";
			_actionButtonsControlLayout.CreatedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_actionButtonsControlLayout.ModifiedInSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			_actionButtonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_actionButtonsControlLayout.Tag = "";
			_actionButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_actionButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_actionButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_actionButtonsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_actionButtonsControlLayout.StartNewAlignGroup = false;
			_actionButtonsControlLayout.Image = new ControlImage {};
			_actionButtonsControlLayout.Edges = "";
			return _actionButtonsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new LookupGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new LookupGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LookupGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LookupGridPageEventsProcess

	/// <exclude/>
	public class LookupGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LookupGridPageSchemaUserControl
	{

		public LookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LookupGridPageEventsProcess";
			SchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
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

		public virtual bool EditMode {
			get;
			set;
		}

		public virtual Object SelectedValues {
			get;
			set;
		}

		public virtual string SearchValue {
			get;
			set;
		}

		public virtual string OpenLookupProcessUserContextUId {
			get;
			set;
		}

		public virtual Object DataSourceFilters {
			get;
			set;
		}

		public virtual string EntitySchemaName {
			get;
			set;
		}

		public virtual bool MultiSelectMode {
			get;
			set;
		}

		public virtual Object LogicalOperation {
			get;
			set;
		}

		public virtual bool IsVirtualMode {
			get;
			set;
		}

		public virtual string VirtualModeContextKey {
			get;
			set;
		}

		public virtual Object VirtualModeStructure {
			get;
			set;
		}

		public virtual Guid SysLookupId {
			get;
			set;
		}

		public virtual bool HasOwnEditPage {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess12;
		public ProcessFlowElement EventSubProcess12 {
			get {
				return _eventSubProcess12 ?? (_eventSubProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12",
					SchemaElementUId = new Guid("b31a2c95-2365-4d7c-98a2-852104912600"),
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
					SchemaElementUId = new Guid("a621f4e0-ccf8-40a5-8de3-e9e2117f50a5"),
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
					SchemaElementUId = new Guid("c0818c40-f065-4172-abe2-3a4ae2a4eece"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOKButtonClickExecute,
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
					SchemaElementUId = new Guid("0ac42b76-76a7-4ded-8fbc-43bb31298e3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptEditButtonClickNoEditMode;
		public ProcessScriptTask ScriptEditButtonClickNoEditMode {
			get {
				return _scriptEditButtonClickNoEditMode ?? (_scriptEditButtonClickNoEditMode = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEditButtonClickNoEditMode",
					SchemaElementUId = new Guid("2b7d95be-1933-4d28-9f3f-47115ae95a38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEditButtonClickNoEditModeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("39ea6cdf-5726-4875-a221-50276968ae07"),
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
					SchemaElementUId = new Guid("fb1765a3-a5ae-4fe6-93ed-6873947ad3ca"),
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
					SchemaElementUId = new Guid("0c5d8843-fcd7-4195-b0ad-e7c5ab30a1af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptCancelButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess17;
		public ProcessFlowElement EventSubProcess17 {
			get {
				return _eventSubProcess17 ?? (_eventSubProcess17 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess17",
					SchemaElementUId = new Guid("a0dcaf42-0b17-49cf-b103-a658e8ef063d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoad;
		public ProcessFlowElement PageLoad {
			get {
				return _pageLoad ?? (_pageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoad",
					SchemaElementUId = new Guid("9705237a-fb11-477d-9069-80703d408b6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoad;
		public ProcessScriptTask ScriptPageLoad {
			get {
				return _scriptPageLoad ?? (_scriptPageLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoad",
					SchemaElementUId = new Guid("b4d26cbd-ca1d-4c16-94d2-2502342413b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBasePageLoad;
		public ProcessThrowMessageEvent IntermediateThrowBasePageLoad {
			get {
				return _intermediateThrowBasePageLoad ?? (_intermediateThrowBasePageLoad = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBasePageLoad",
					SchemaElementUId = new Guid("7deb43fb-9364-4c93-8cf7-07804c1e3695"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess14;
		public ProcessFlowElement EventSubProcess14 {
			get {
				return _eventSubProcess14 ?? (_eventSubProcess14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess14",
					SchemaElementUId = new Guid("7c8715fa-3c12-4e26-be61-68ba5020f45f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _toolButtonClearSearchClick;
		public ProcessFlowElement ToolButtonClearSearchClick {
			get {
				return _toolButtonClearSearchClick ?? (_toolButtonClearSearchClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ToolButtonClearSearchClick",
					SchemaElementUId = new Guid("05ae8e81-ed7e-4f3a-a299-0865177629f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("eb5dae00-17a0-4152-ae47-44171b48e958"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SearchButtonClick",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess16;
		public ProcessFlowElement EventSubProcess16 {
			get {
				return _eventSubProcess16 ?? (_eventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess16",
					SchemaElementUId = new Guid("682c25d6-e9d6-43b3-bb28-364b12d097ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _removeSelectedRecordButtonClick;
		public ProcessFlowElement RemoveSelectedRecordButtonClick {
			get {
				return _removeSelectedRecordButtonClick ?? (_removeSelectedRecordButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemoveSelectedRecordButtonClick",
					SchemaElementUId = new Guid("48e8c583-75fe-4d04-a61a-940ad5399c32"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptRemoveSelectedRecordButtonClick;
		public ProcessScriptTask ScriptRemoveSelectedRecordButtonClick {
			get {
				return _scriptRemoveSelectedRecordButtonClick ?? (_scriptRemoveSelectedRecordButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptRemoveSelectedRecordButtonClick",
					SchemaElementUId = new Guid("9263ad5d-6700-4646-95d6-21022c58dd44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptRemoveSelectedRecordButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess18;
		public ProcessFlowElement EventSubProcess18 {
			get {
				return _eventSubProcess18 ?? (_eventSubProcess18 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess18",
					SchemaElementUId = new Guid("89638d77-6af1-48e7-9424-9269f349d9f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _searchComboBoxEditChange;
		public ProcessFlowElement SearchComboBoxEditChange {
			get {
				return _searchComboBoxEditChange ?? (_searchComboBoxEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SearchComboBoxEditChange",
					SchemaElementUId = new Guid("a85fc2b0-f525-4c38-a3c3-8f57cee8b88e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSearchComboBoxEditChange;
		public ProcessScriptTask ScriptSearchComboBoxEditChange {
			get {
				return _scriptSearchComboBoxEditChange ?? (_scriptSearchComboBoxEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSearchComboBoxEditChange",
					SchemaElementUId = new Guid("95f6c153-90da-43eb-a0cf-5ebbc79fed83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSearchComboBoxEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess15;
		public ProcessFlowElement EventSubProcess15 {
			get {
				return _eventSubProcess15 ?? (_eventSubProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess15",
					SchemaElementUId = new Guid("75cd0029-9251-4979-a1ad-5c8d41341d62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addSelectedRecordButtonClick;
		public ProcessFlowElement AddSelectedRecordButtonClick {
			get {
				return _addSelectedRecordButtonClick ?? (_addSelectedRecordButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddSelectedRecordButtonClick",
					SchemaElementUId = new Guid("39fdd587-da9a-443f-81a7-06583e2526dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAddSelectedRecordButtonClick;
		public ProcessScriptTask ScriptAddSelectedRecordButtonClick {
			get {
				return _scriptAddSelectedRecordButtonClick ?? (_scriptAddSelectedRecordButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddSelectedRecordButtonClick",
					SchemaElementUId = new Guid("d951a50a-60fe-4506-8ee7-740aff3716e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddSelectedRecordButtonClickExecute,
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
					SchemaElementUId = new Guid("6fdb38e6-8acb-48f8-bcf5-ef744d998ec1"),
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
					SchemaElementUId = new Guid("1c6789a5-e6ad-4ee8-9983-83ee68cc69f2"),
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
					SchemaElementUId = new Guid("ed1d1b12-be19-4497-bae9-3dd1e76d8cae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSearchButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("4fe56de6-6000-4798-8e48-f393f20576bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _schemaListEditChange;
		public ProcessFlowElement SchemaListEditChange {
			get {
				return _schemaListEditChange ?? (_schemaListEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SchemaListEditChange",
					SchemaElementUId = new Guid("6506e319-c0ba-43bb-b829-08c1820ea3ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSchemaListEditChange;
		public ProcessScriptTask ScriptSchemaListEditChange {
			get {
				return _scriptSchemaListEditChange ?? (_scriptSchemaListEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSchemaListEditChange",
					SchemaElementUId = new Guid("71bd9f29-a978-46db-9200-2c5d74070efd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSchemaListEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _processLookupGridPageLoadComplete;
		public ProcessFlowElement ProcessLookupGridPageLoadComplete {
			get {
				return _processLookupGridPageLoadComplete ?? (_processLookupGridPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProcessLookupGridPageLoadComplete",
					SchemaElementUId = new Guid("632bfb6a-6c76-4cb1-9517-6043da74711e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startLookupGridPagePageLoadComplete;
		public ProcessFlowElement StartLookupGridPagePageLoadComplete {
			get {
				return _startLookupGridPagePageLoadComplete ?? (_startLookupGridPagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartLookupGridPagePageLoadComplete",
					SchemaElementUId = new Guid("23c2c673-ec8a-46b0-bda9-40bcebdd8aa8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLookupGridPageLoadComplete;
		public ProcessScriptTask ScriptLookupGridPageLoadComplete {
			get {
				return _scriptLookupGridPageLoadComplete ?? (_scriptLookupGridPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLookupGridPageLoadComplete",
					SchemaElementUId = new Guid("1401fc1b-a4ba-45b6-a142-52e0845e9db3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLookupGridPageLoadCompleteExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventPageLoadComplete;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventPageLoadComplete {
			get {
				return _intermediateThrowMessageEventPageLoadComplete ?? (_intermediateThrowMessageEventPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventPageLoadComplete",
					SchemaElementUId = new Guid("fc2cfcc5-b369-4bfa-aba6-a12d9b2727b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask145646456;
		public ProcessScriptTask ScriptTask145646456 {
			get {
				return _scriptTask145646456 ?? (_scriptTask145646456 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask145646456",
					SchemaElementUId = new Guid("0ddff2e5-06c5-44d4-b50f-d4f5a8624e4d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask145646456Execute,
				});
			}
		}

		private ProcessFlowElement _lookupGridPageDataSourceBeforeLoadEventSubProcess;
		public ProcessFlowElement LookupGridPageDataSourceBeforeLoadEventSubProcess {
			get {
				return _lookupGridPageDataSourceBeforeLoadEventSubProcess ?? (_lookupGridPageDataSourceBeforeLoadEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LookupGridPageDataSourceBeforeLoadEventSubProcess",
					SchemaElementUId = new Guid("67feede2-a697-4221-bba0-e8fd7dc0f8c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lookupGridPageDataSourceBeforeLoadStartMessage;
		public ProcessFlowElement LookupGridPageDataSourceBeforeLoadStartMessage {
			get {
				return _lookupGridPageDataSourceBeforeLoadStartMessage ?? (_lookupGridPageDataSourceBeforeLoadStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LookupGridPageDataSourceBeforeLoadStartMessage",
					SchemaElementUId = new Guid("4f093043-7d71-4fda-8120-9d51a1971ce5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _lookupGridPageDataSourceBeforeLoadScriptTask;
		public ProcessScriptTask LookupGridPageDataSourceBeforeLoadScriptTask {
			get {
				return _lookupGridPageDataSourceBeforeLoadScriptTask ?? (_lookupGridPageDataSourceBeforeLoadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LookupGridPageDataSourceBeforeLoadScriptTask",
					SchemaElementUId = new Guid("bce6af46-ae32-41d3-9a48-5ccf1af6f8e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LookupGridPageDataSourceBeforeLoadScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess20;
		public ProcessFlowElement EventSubProcess20 {
			get {
				return _eventSubProcess20 ?? (_eventSubProcess20 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess20",
					SchemaElementUId = new Guid("74aa1db8-cbd7-4f0b-a91c-cc13744076a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _stopPageMessage;
		public ProcessFlowElement StopPageMessage {
			get {
				return _stopPageMessage ?? (_stopPageMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StopPageMessage",
					SchemaElementUId = new Guid("5fcddaa7-68e6-45b3-9594-65e3e3aebc56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptStopPageMessage;
		public ProcessScriptTask ScriptStopPageMessage {
			get {
				return _scriptStopPageMessage ?? (_scriptStopPageMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptStopPageMessage",
					SchemaElementUId = new Guid("9cc9ef8a-6a29-4a0f-ae6e-c5a2c209f991"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptStopPageMessageExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessBaseInit;
		public ProcessFlowElement EventSubProcessBaseInit {
			get {
				return _eventSubProcessBaseInit ?? (_eventSubProcessBaseInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessBaseInit",
					SchemaElementUId = new Guid("4fb5150e-af4b-4947-85ac-d059b5156bfa"),
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
					SchemaElementUId = new Guid("3e4c2f98-d287-434c-b26f-8d5881230bee"),
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
					SchemaElementUId = new Guid("28d7619a-3e4e-4d99-809c-ce4b51d3fc43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
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
					SchemaElementUId = new Guid("fcf1307d-5e29-4691-b137-87ecfb8cc21a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessScriptTask _scriptGetDataSourceSchemaUId;
		public ProcessScriptTask ScriptGetDataSourceSchemaUId {
			get {
				return _scriptGetDataSourceSchemaUId ?? (_scriptGetDataSourceSchemaUId = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptGetDataSourceSchemaUId",
					SchemaElementUId = new Guid("311f8c47-7661-496f-b579-f7e81b863e8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptGetDataSourceSchemaUIdExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildBasePrepareFilters;
		public ProcessFlowElement EventSubProcessChildBasePrepareFilters {
			get {
				return _eventSubProcessChildBasePrepareFilters ?? (_eventSubProcessChildBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildBasePrepareFilters",
					SchemaElementUId = new Guid("1df995fe-1789-4bdd-adda-2bc487a0d914"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildBasePrepareFilters;
		public ProcessFlowElement StartMessageChildBasePrepareFilters {
			get {
				return _startMessageChildBasePrepareFilters ?? (_startMessageChildBasePrepareFilters = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildBasePrepareFilters",
					SchemaElementUId = new Guid("1ca6adaa-58dd-4745-8b46-0604e881b901"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildBasePrepareFilters;
		public ProcessScriptTask ScriptChildBasePrepareFilters {
			get {
				return _scriptChildBasePrepareFilters ?? (_scriptChildBasePrepareFilters = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildBasePrepareFilters",
					SchemaElementUId = new Guid("2fa4914a-39fd-4a7b-8d0d-107080ad121e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildBasePrepareFiltersExecute,
				});
			}
		}

		private LocalizableString _cancelCaption;
		public LocalizableString CancelCaption {
			get {
				return _cancelCaption ?? (_cancelCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CancelCaption.Value"));
			}
		}

		private LocalizableString _closeCaption;
		public LocalizableString CloseCaption {
			get {
				return _closeCaption ?? (_closeCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CloseCaption.Value"));
			}
		}

		private LocalizableString _notItemDisplayMessage;
		public LocalizableString NotItemDisplayMessage {
			get {
				return _notItemDisplayMessage ?? (_notItemDisplayMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NotItemDisplayMessage.Value"));
			}
		}

		private LocalizableString _primaryDisplayColumnIsEmptyMessage;
		public LocalizableString PrimaryDisplayColumnIsEmptyMessage {
			get {
				return _primaryDisplayColumnIsEmptyMessage ?? (_primaryDisplayColumnIsEmptyMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PrimaryDisplayColumnIsEmptyMessage.Value"));
			}
		}

		private LocalizableString _selectedRecordsDataSourceCaption;
		public LocalizableString SelectedRecordsDataSourceCaption {
			get {
				return _selectedRecordsDataSourceCaption ?? (_selectedRecordsDataSourceCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SelectedRecordsDataSourceCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[OKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick };
			FlowElements[ScriptOKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOKButtonClick };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[ScriptEditButtonClickNoEditMode.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEditButtonClickNoEditMode };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[CancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClick };
			FlowElements[ScriptCancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptCancelButtonClick };
			FlowElements[EventSubProcess17.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess17 };
			FlowElements[PageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoad };
			FlowElements[ScriptPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoad };
			FlowElements[IntermediateThrowBasePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBasePageLoad };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[ToolButtonClearSearchClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ToolButtonClearSearchClick };
			FlowElements[ThrowSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowSearchButtonClick };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[RemoveSelectedRecordButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveSelectedRecordButtonClick };
			FlowElements[ScriptRemoveSelectedRecordButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptRemoveSelectedRecordButtonClick };
			FlowElements[EventSubProcess18.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess18 };
			FlowElements[SearchComboBoxEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SearchComboBoxEditChange };
			FlowElements[ScriptSearchComboBoxEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSearchComboBoxEditChange };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[AddSelectedRecordButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSelectedRecordButtonClick };
			FlowElements[ScriptAddSelectedRecordButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddSelectedRecordButtonClick };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[SearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SearchButtonClick };
			FlowElements[ScriptSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSearchButtonClick };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[SchemaListEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SchemaListEditChange };
			FlowElements[ScriptSchemaListEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSchemaListEditChange };
			FlowElements[ProcessLookupGridPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessLookupGridPageLoadComplete };
			FlowElements[StartLookupGridPagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartLookupGridPagePageLoadComplete };
			FlowElements[ScriptLookupGridPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLookupGridPageLoadComplete };
			FlowElements[IntermediateThrowMessageEventPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventPageLoadComplete };
			FlowElements[ScriptTask145646456.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask145646456 };
			FlowElements[LookupGridPageDataSourceBeforeLoadEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageDataSourceBeforeLoadEventSubProcess };
			FlowElements[LookupGridPageDataSourceBeforeLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageDataSourceBeforeLoadStartMessage };
			FlowElements[LookupGridPageDataSourceBeforeLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageDataSourceBeforeLoadScriptTask };
			FlowElements[EventSubProcess20.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess20 };
			FlowElements[StopPageMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StopPageMessage };
			FlowElements[ScriptStopPageMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptStopPageMessage };
			FlowElements[EventSubProcessBaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessBaseInit };
			FlowElements[Init.SchemaElementUId] = new Collection<ProcessFlowElement> { Init };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ScriptGetDataSourceSchemaUId.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptGetDataSourceSchemaUId };
			FlowElements[EventSubProcessChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildBasePrepareFilters };
			FlowElements[StartMessageChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildBasePrepareFilters };
			FlowElements[ScriptChildBasePrepareFilters.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildBasePrepareFilters };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess12":
						break;
					case "OKButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptOKButtonClick");
						break;
					case "ScriptOKButtonClick":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("ScriptOKButtonClick");
						break;
					case "ScriptEditButtonClickNoEditMode":
						break;
					case "EventSubProcess13":
						break;
					case "CancelButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptCancelButtonClick");
						break;
					case "ScriptCancelButtonClick":
						break;
					case "EventSubProcess17":
						break;
					case "PageLoad":
						e.Context.QueueTasks.Enqueue("ScriptPageLoad");
						break;
					case "ScriptPageLoad":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBasePageLoad");
						break;
					case "IntermediateThrowBasePageLoad":
						break;
					case "EventSubProcess14":
						break;
					case "ToolButtonClearSearchClick":
						e.Context.QueueTasks.Enqueue("ThrowSearchButtonClick");
						break;
					case "ThrowSearchButtonClick":
						break;
					case "EventSubProcess16":
						break;
					case "RemoveSelectedRecordButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptRemoveSelectedRecordButtonClick");
						break;
					case "ScriptRemoveSelectedRecordButtonClick":
						break;
					case "EventSubProcess18":
						break;
					case "SearchComboBoxEditChange":
						e.Context.QueueTasks.Enqueue("ScriptSearchComboBoxEditChange");
						break;
					case "ScriptSearchComboBoxEditChange":
						break;
					case "EventSubProcess15":
						break;
					case "AddSelectedRecordButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptAddSelectedRecordButtonClick");
						break;
					case "ScriptAddSelectedRecordButtonClick":
						break;
					case "EventSubProcess10":
						break;
					case "SearchButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptSearchButtonClick");
						break;
					case "ScriptSearchButtonClick":
						break;
					case "EventSubProcess11":
						break;
					case "SchemaListEditChange":
						e.Context.QueueTasks.Enqueue("ScriptSchemaListEditChange");
						break;
					case "ScriptSchemaListEditChange":
						break;
					case "ProcessLookupGridPageLoadComplete":
						break;
					case "StartLookupGridPagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptLookupGridPageLoadComplete");
						break;
					case "ScriptLookupGridPageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventPageLoadComplete");
						break;
					case "IntermediateThrowMessageEventPageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptTask145646456");
						break;
					case "ScriptTask145646456":
						break;
					case "LookupGridPageDataSourceBeforeLoadEventSubProcess":
						break;
					case "LookupGridPageDataSourceBeforeLoadStartMessage":
						e.Context.QueueTasks.Enqueue("LookupGridPageDataSourceBeforeLoadScriptTask");
						break;
					case "LookupGridPageDataSourceBeforeLoadScriptTask":
						break;
					case "EventSubProcess20":
						break;
					case "StopPageMessage":
						e.Context.QueueTasks.Enqueue("ScriptStopPageMessage");
						break;
					case "ScriptStopPageMessage":
						break;
					case "EventSubProcessBaseInit":
						break;
					case "Init":
						e.Context.QueueTasks.Enqueue("ScriptGetDataSourceSchemaUId");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
					case "ScriptGetDataSourceSchemaUId":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "EventSubProcessChildBasePrepareFilters":
						break;
					case "StartMessageChildBasePrepareFilters":
						e.Context.QueueTasks.Enqueue("ScriptChildBasePrepareFilters");
						break;
					case "ScriptChildBasePrepareFilters":
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
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("CancelButtonClick");
			ActivatedEventElements.Add("PageLoad");
			ActivatedEventElements.Add("ToolButtonClearSearchClick");
			ActivatedEventElements.Add("RemoveSelectedRecordButtonClick");
			ActivatedEventElements.Add("SearchComboBoxEditChange");
			ActivatedEventElements.Add("AddSelectedRecordButtonClick");
			ActivatedEventElements.Add("SearchButtonClick");
			ActivatedEventElements.Add("SchemaListEditChange");
			ActivatedEventElements.Add("StartLookupGridPagePageLoadComplete");
			ActivatedEventElements.Add("LookupGridPageDataSourceBeforeLoadStartMessage");
			ActivatedEventElements.Add("StopPageMessage");
			ActivatedEventElements.Add("Init");
			ActivatedEventElements.Add("StartMessageChildBasePrepareFilters");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess12":
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
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "ScriptEditButtonClickNoEditMode":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEditButtonClickNoEditMode";
					result = ScriptEditButtonClickNoEditMode.Execute(context, ScriptEditButtonClickNoEditModeExecute);
					break;
				case "EventSubProcess13":
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
				case "EventSubProcess17":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoad";
					result = PageLoad.Execute(context);
					break;
				case "ScriptPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoad";
					result = ScriptPageLoad.Execute(context, ScriptPageLoadExecute);
					break;
				case "IntermediateThrowBasePageLoad":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = IntermediateThrowBasePageLoad.Execute(context);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "ToolButtonClearSearchClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ToolButtonClearSearchClick";
					result = ToolButtonClearSearchClick.Execute(context);
					break;
				case "ThrowSearchButtonClick":
					context.QueueTasks.Dequeue();
					result = ThrowSearchButtonClick.Execute(context);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "RemoveSelectedRecordButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveSelectedRecordButtonClick";
					result = RemoveSelectedRecordButtonClick.Execute(context);
					break;
				case "ScriptRemoveSelectedRecordButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptRemoveSelectedRecordButtonClick";
					result = ScriptRemoveSelectedRecordButtonClick.Execute(context, ScriptRemoveSelectedRecordButtonClickExecute);
					break;
				case "EventSubProcess18":
					context.QueueTasks.Dequeue();
					break;
				case "SearchComboBoxEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "SearchComboBoxEditChange";
					result = SearchComboBoxEditChange.Execute(context);
					break;
				case "ScriptSearchComboBoxEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSearchComboBoxEditChange";
					result = ScriptSearchComboBoxEditChange.Execute(context, ScriptSearchComboBoxEditChangeExecute);
					break;
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "AddSelectedRecordButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSelectedRecordButtonClick";
					result = AddSelectedRecordButtonClick.Execute(context);
					break;
				case "ScriptAddSelectedRecordButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddSelectedRecordButtonClick";
					result = ScriptAddSelectedRecordButtonClick.Execute(context, ScriptAddSelectedRecordButtonClickExecute);
					break;
				case "EventSubProcess10":
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
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "SchemaListEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "SchemaListEditChange";
					result = SchemaListEditChange.Execute(context);
					break;
				case "ScriptSchemaListEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSchemaListEditChange";
					result = ScriptSchemaListEditChange.Execute(context, ScriptSchemaListEditChangeExecute);
					break;
				case "ProcessLookupGridPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartLookupGridPagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartLookupGridPagePageLoadComplete";
					result = StartLookupGridPagePageLoadComplete.Execute(context);
					break;
				case "ScriptLookupGridPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLookupGridPageLoadComplete";
					result = ScriptLookupGridPageLoadComplete.Execute(context, ScriptLookupGridPageLoadCompleteExecute);
					break;
				case "IntermediateThrowMessageEventPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEventPageLoadComplete.Execute(context);
					break;
				case "ScriptTask145646456":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask145646456";
					result = ScriptTask145646456.Execute(context, ScriptTask145646456Execute);
					break;
				case "LookupGridPageDataSourceBeforeLoadEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "LookupGridPageDataSourceBeforeLoadStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageDataSourceBeforeLoadStartMessage";
					result = LookupGridPageDataSourceBeforeLoadStartMessage.Execute(context);
					break;
				case "LookupGridPageDataSourceBeforeLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageDataSourceBeforeLoadScriptTask";
					result = LookupGridPageDataSourceBeforeLoadScriptTask.Execute(context, LookupGridPageDataSourceBeforeLoadScriptTaskExecute);
					break;
				case "EventSubProcess20":
					context.QueueTasks.Dequeue();
					break;
				case "StopPageMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StopPageMessage";
					result = StopPageMessage.Execute(context);
					break;
				case "ScriptStopPageMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptStopPageMessage";
					result = ScriptStopPageMessage.Execute(context, ScriptStopPageMessageExecute);
					break;
				case "EventSubProcessBaseInit":
					context.QueueTasks.Dequeue();
					break;
				case "Init":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init";
					result = Init.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "ScriptGetDataSourceSchemaUId":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptGetDataSourceSchemaUId";
					result = ScriptGetDataSourceSchemaUId.Execute(context, ScriptGetDataSourceSchemaUIdExecute);
					break;
				case "EventSubProcessChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildBasePrepareFilters";
					result = StartMessageChildBasePrepareFilters.Execute(context);
					break;
				case "ScriptChildBasePrepareFilters":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildBasePrepareFilters";
					result = ScriptChildBasePrepareFilters.Execute(context, ScriptChildBasePrepareFiltersExecute);
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
				case "HasOwnEditPage":
					HasOwnEditPage = reader.GetValue<System.Boolean>();
				break;
				case "SysLookupId":
					SysLookupId = reader.GetValue<System.Guid>();
				break;
				case "VirtualModeStructure":
					VirtualModeStructure = reader.GetSerializableObjectValue();
				break;
				case "VirtualModeContextKey":
					VirtualModeContextKey = reader.GetValue<System.String>();
				break;
				case "IsVirtualMode":
					IsVirtualMode = reader.GetValue<System.Boolean>();
				break;
				case "LogicalOperation":
					LogicalOperation = reader.GetSerializableObjectValue();
				break;
				case "MultiSelectMode":
					MultiSelectMode = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaName":
					EntitySchemaName = reader.GetValue<System.String>();
				break;
				case "OpenLookupProcessUserContextUId":
					OpenLookupProcessUserContextUId = reader.GetValue<System.String>();
				break;
				case "SearchValue":
					SearchValue = reader.GetValue<System.String>();
				break;
				case "SelectedValues":
					SelectedValues = reader.GetSerializableObjectValue();
				break;
				case "EditMode":
					EditMode = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptOKButtonClickExecute(ProcessExecutingContext context) {
			string primaryColumnName = string.Empty;
			string primaryDisplayColumnName = string.Empty;
			if (IsVirtualMode) {
				var virtualDataSource = GetVirtualDataSource();
				primaryColumnName = virtualDataSource.DefStructure.PrimaryColumnName;
				primaryDisplayColumnName = virtualDataSource.DefStructure.PrimaryDisplayColumnName;
			} else {
				primaryColumnName = Page.DataSource.Schema.PrimaryColumn.Name;
				primaryDisplayColumnName = Page.DataSource.Schema.PrimaryDisplayColumn.Name;
			}
			string schemaUId = (Page.SchemaListEdit.Visible && Page.SchemaListEdit.Items.Count > 0) ?
				Page.SchemaListEdit.SelectedItem.Value : Page.DataSource.SchemaUId.ToString();
			if (Page.TreeGrid.SelectedNodes.Count > 0) {
				string selectedValuesString = string.Empty;
				Dictionary <string, object> openLookupSelectedValues = (Dictionary <string, object>)Page.GetParameterValue("openLookupSelectedValues");
				bool isOpenLookupSelectedValues = openLookupSelectedValues != null ? true : false;
				Dictionary<string, object> values;
				string serializedData;
				if (!MultiSelectMode) {
					foreach(var node in Page.TreeGrid.SelectedNodes) {
						values = new Dictionary<string, object>();
						if (node.Values.ContainsKey(primaryDisplayColumnName)) {
							values.Add(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
						} else {
							Page.BaseMessagePanel.Clear();
							Page.BaseMessagePanel.AddMessage(
								Warning, 
								PrimaryDisplayColumnIsEmptyMessage, 
								MessageType.Warning
							);
							return false;
						}
						values.Add("schemaUId", schemaUId);
						serializedData = Json.Serialize(values, new DictionaryJsonConverter());
						selectedValuesString += string.Concat("selectedValues.push({keyValue :", Json.Serialize(node.Values[primaryColumnName]), 
							", primaryDisplayColumnName:", Json.Serialize(primaryDisplayColumnName), ", dataValue:", serializedData, "});");
						if (isOpenLookupSelectedValues) {
							if (openLookupSelectedValues.ContainsKey(node.Values[primaryColumnName].ToString())) {
								openLookupSelectedValues[node.Values[primaryColumnName].ToString()] = values;
							} else {
								openLookupSelectedValues.Add(node.Values[primaryColumnName].ToString(), values);
							}
						}
					}
					//--
					if (openLookupSelectedValues != null) {
						var selectedValues = (Dictionary<string, object>)SelectedValues;
						foreach (KeyValuePair<string, object> item in selectedValues) {
							if (openLookupSelectedValues.ContainsKey(item.Key)) {
								openLookupSelectedValues[item.Key] = item.Value;
							} else {
						    	openLookupSelectedValues.Add(item.Key, item.Value);
							}
						}
						string userContextKey = Page.GetParameterValue("tempUserContextUId") == null ? string.Empty : Page.GetParameterValue("tempUserContextUId").ToString();
						if (!string.IsNullOrEmpty(userContextKey)) {
							var sessionData = UserConnection.SessionData[userContextKey] as Dictionary<string, object>;
							sessionData["openLookupSelectedValues"] = openLookupSelectedValues;
							UserConnection.SessionData[userContextKey] = sessionData;
						}
					}
					//
					
				} else {
					foreach(KeyValuePair<string,object> p in (Dictionary<string,object>)SelectedValues) {
						string id = p.Key;
						values = (Dictionary<string,object>)p.Value;
						serializedData = Json.Serialize(values, new DictionaryJsonConverter());
						selectedValuesString += string.Concat("selectedValues.push({keyValue :", Json.Serialize(id), ", primaryDisplayColumnName:", Json.Serialize(primaryDisplayColumnName), ", dataValue:", serializedData, "});");
						if (openLookupSelectedValues != null) {
							if (openLookupSelectedValues.ContainsKey(id)) {
								openLookupSelectedValues[id] = values;
							} else {
								openLookupSelectedValues.Add(id, values);
							}
						}
					}
					string userContextKey = Page.GetParameterValue("tempUserContextUId") == null ? string.Empty : Page.GetParameterValue("tempUserContextUId").ToString();
					if (!string.IsNullOrEmpty(userContextKey)) {
						var sessionData = UserConnection.SessionData[userContextKey] as Dictionary<string, object>;
						sessionData["openLookupSelectedValues"] = openLookupSelectedValues;
						UserConnection.SessionData[userContextKey] = sessionData;
					}
				}
				string script = "";
				if (!IsVirtualMode) {
					script = @"
					var selectedRecordsDataSource = window['" + ((Terrasoft.UI.WebControls.Controls.VirtualDataSource)Page.PageContainer.FindPageControl("SelectedRecordsDataSource", true)).ClientID + @"'];
					var selectedValues = []; " + selectedValuesString + @"
					var dataSourceItems = selectedRecordsDataSource.rows.items;
					for(var i = 0, itemsLen = dataSourceItems.length; i < itemsLen; i++) {
						selectedValues.push({keyValue : dataSourceItems[i].getPrimaryColumnValue(), primaryDisplayColumnName:" + Json.Serialize(primaryDisplayColumnName) 
								+ @", dataValue:{" + primaryDisplayColumnName + @": dataSourceItems[i].getColumnValue('" + primaryDisplayColumnName + @"'), schemaUId:" + Json.Serialize(schemaUId) + @"}});
					}
					var key = window.name;
					if (window.opener) {
					var lookupGridPageParams = window.opener.window.lookupGridPageParams[key];
					var sender = lookupGridPageParams.sender;
					var schemaUId = '" + schemaUId + @"';
					var lookupGridPageCallback = lookupGridPageParams.lookupGridPageCallback;
					if (sender && lookupGridPageCallback) { lookupGridPageCallback.call(lookupGridPageParams.sender, selectedValues, schemaUId);}}";
				} else {
					script = @"
					var key = window.name;
					if (window.opener) {
					var lookupGridPageParams = window.opener.window.lookupGridPageParams[key];
					var sender = lookupGridPageParams.sender;
					var referenceSchemaUId = '" + schemaUId + @"';
					var selectedValues = []; " + selectedValuesString + @"
					var lookupGridPageCallback = lookupGridPageParams.lookupGridPageCallback;
					if (sender && lookupGridPageCallback) { lookupGridPageCallback.call(lookupGridPageParams.sender, selectedValues, referenceSchemaUId);}}";
				}
				Page.AddScript(script);
			} else if (Page.SelectedRecordsGrid.SelectedNodes.Count > 0) {
				var selectedRecordsDataSource = (Terrasoft.UI.WebControls.Controls.VirtualDataSource)Page.PageContainer.FindPageControl("SelectedRecordsDataSource", true);
				var selectedValues = (Dictionary<string, object>)SelectedValues;
				Entity row;
				object value;
				Dictionary<string, object> values;
				foreach(var node in Page.TreeGrid.SelectedNodes) {
					row = selectedRecordsDataSource.CreateRow();
					row.SetColumnValue(primaryColumnName, node.Values[primaryColumnName]);
					row.SetColumnValue(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
					selectedRecordsDataSource.Add(row);
					if (!selectedValues.TryGetValue(node.Values[primaryColumnName].ToString(), out value)) {
						values = new Dictionary<string, object>();
						values.Add(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
						values.Add("schemaUId", schemaUId);
						selectedValues.Add(node.Values[primaryColumnName].ToString(), values);
					}
				}
				selectedRecordsDataSource.LoadRows();
			}
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();//
			return true;
		}

		public virtual bool ScriptEditButtonClickNoEditModeExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0 && Page.SelectedRecordsGrid.SelectedNodes.Count == 0) {
				return true;
			}
			string primaryColumnName = string.Empty;
			string primaryDisplayColumnName = string.Empty;
			if (IsVirtualMode) {
				var virtualDataSource = GetVirtualDataSource();
				primaryColumnName = virtualDataSource.DefStructure.PrimaryColumnName;
				primaryDisplayColumnName = virtualDataSource.DefStructure.PrimaryDisplayColumnName;
			} else {
				primaryColumnName = Page.DataSource.Schema.PrimaryColumn.Name;
				primaryDisplayColumnName = Page.DataSource.Schema.PrimaryDisplayColumn.Name;
			}
			string schemaUId = (Page.SchemaListEdit.Visible && Page.SchemaListEdit.Items.Count > 0) ?
				Page.SchemaListEdit.SelectedItem.Value : Page.DataSource.SchemaUId.ToString();
			if (Page.TreeGrid.SelectedNodes.Count > 0 /*&& Page.SelectedRecordsGrid.SelectedNodes.Count == 0*/) {
				string selectedValuesString = string.Empty;
				Dictionary <string, object> openLookupSelectedValues = (Dictionary <string, object>)Page.GetParameterValue("openLookupSelectedValues");
				bool isOpenLookupSelectedValues = openLookupSelectedValues != null ? true : false;
				Dictionary<string, object> values;
				string serializedData;
				foreach(var node in Page.TreeGrid.SelectedNodes) {
					values = new Dictionary<string, object>();
					values.Add(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
					values.Add("schemaUId", schemaUId);
					serializedData = Json.Serialize(values, new DictionaryJsonConverter());
					selectedValuesString += string.Concat("selectedValues.push({keyValue :", Json.Serialize(node.Values[primaryColumnName]), 
						", primaryDisplayColumnName:", Json.Serialize(primaryDisplayColumnName), ", dataValue:", serializedData, "});");
					if (isOpenLookupSelectedValues) {
						if (openLookupSelectedValues.ContainsKey(node.Values[primaryColumnName].ToString())) {
							openLookupSelectedValues[node.Values[primaryColumnName].ToString()] = values;
						} else {
							openLookupSelectedValues.Add(node.Values[primaryColumnName].ToString(), values);
						}
					}
				}
				string script = @"
				var key = window.name;
				if (window.opener) {
				var lookupGridPageParams = window.opener.window.lookupGridPageParams[key];
				var sender = lookupGridPageParams.sender;
				var referenceSchemaUId = '" + schemaUId + @"';
				var selectedValues = []; " + selectedValuesString + @"
				var lookupGridPageCallback = lookupGridPageParams.lookupGridPageCallback;
				if (sender && lookupGridPageCallback) { lookupGridPageCallback.call(lookupGridPageParams.sender, selectedValues, referenceSchemaUId);}} window.close();";
				Page.AddScript(script);
			} else if (Page.SelectedRecordsGrid.SelectedNodes.Count > 0) {
				var selectedRecordsDataSource = (Terrasoft.UI.WebControls.Controls.VirtualDataSource)Page.PageContainer.FindPageControl("SelectedRecordsDataSource", true);
				var selectedValues = (Dictionary<string, object>)SelectedValues;
				Entity row;
				object value;
				Dictionary<string, object> values;
				foreach(var node in Page.TreeGrid.SelectedNodes) {
					row = selectedRecordsDataSource.CreateRow();
					row.SetColumnValue(primaryColumnName, node.Values[primaryColumnName]);
					row.SetColumnValue(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
					selectedRecordsDataSource.Add(row);
					if (!selectedValues.TryGetValue(node.Values[primaryColumnName].ToString(), out value)) {
						values = new Dictionary<string, object>();
						values.Add(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
						values.Add("schemaUId", schemaUId);
						selectedValues.Add(node.Values[primaryColumnName].ToString(), values);
					}
				}
				selectedRecordsDataSource.LoadRows();
			}
			return true;
		}

		public virtual bool ScriptCancelButtonClickExecute(ProcessExecutingContext context) {
			//Page.ScriptManager.AddScript("window.close();");
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ScriptPageLoadExecute(ProcessExecutingContext context) {
			NotRecivePrintReportMenu = true;
			var tempUserContextUIdObj = Page.GetParameterValue("tempUserContextUId");
			if (tempUserContextUIdObj != null) {
				var tempUserContextUId = tempUserContextUIdObj.ToString();
				var tempValues = UserConnection.SessionData[tempUserContextUId] as Dictionary<string, object>;
				if (tempValues != null && tempValues.ContainsKey("useHierarchy")) {
					if (!(bool)tempValues["useHierarchy"]) {
						Page.DataSource.CurrentStructure.IsHierarchical = false;
					}
				}
			}
			var searchValue = ControlUtilities.HtmlDecode((string)Page.GetParameterValue("searchValue"));
			var schemaName = (string)Page.GetParameterValue("schemaName");
			object parameterValue = Page.GetParameterValue("schemaUId");
			Guid schemaUId = parameterValue == null ? Guid.Empty : new Guid(parameterValue.ToString());
			if (Page.DataSource.Schema != null) {
				schemaName = schemaName ?? Page.DataSource.Schema.Name;
				if (schemaUId == Guid.Empty) {
					schemaUId = Page.DataSource.SchemaUId;
				}
			}
			var multiSelectMode = Convert.ToString(Page.GetParameterValue("multiSelectMode"));
			bool isMultiSelectMode;
			MultiSelectMode = bool.TryParse(multiSelectMode, out isMultiSelectMode) ? isMultiSelectMode : false;
			EntityDataSource dataSource = Page.DataSource;
			//LocalizableString lookupGridPageCaption = Page.GetParameterValue("lookupGridPageCaption") as LocalizableString;
			//string windowCaption = LocalizableString.IsNullOrEmpty(lookupGridPageCaption) ? string.Empty : lookupGridPageCaption.ToString();
			var lookupGridPageCaption = (string)Page.GetParameterValue("lookupGridPageCaption");
			string windowCaption = string.IsNullOrEmpty(lookupGridPageCaption) ? string.Empty : lookupGridPageCaption.ToString();
			if (!IsVirtualMode) {
				if (!string.IsNullOrEmpty(schemaName)){
						schemaUId = UserConnection.EntitySchemaManager.GetInstanceByName(schemaName).UId;
						EntitySchemaName = schemaName;
				}
				if (schemaUId == Guid.Empty) {
					return true;
				}
				if (string.IsNullOrEmpty(schemaName)){
						EntitySchemaName = UserConnection.EntitySchemaManager.GetInstanceByUId(schemaUId).Name;
				}
				if (!Ext.IsAjaxRequest) {
					DataSourceFilters = new Collection<IDataSourceFilterItem>();
					string editMode = (string)Page.GetParameterValue("editMode");
					EditMode = string.IsNullOrEmpty(editMode) ? false : Convert.ToBoolean(editMode);
					dataSource.SchemaUId = schemaUId;
				}
				dataSource.PrepareFilters += DataSource_PrepareFilters;
				var schema = dataSource.SchemaManager.GetInstanceByUId(schemaUId);
				if (string.IsNullOrEmpty(windowCaption)) {
					windowCaption = schema.Caption.ToString();
				}
				if (!Ext.IsAjaxRequest) {
					var logicalOperation = Page.GetParameterValue("logicalOperation");
					if (logicalOperation != null) {
						LogicalOperation = logicalOperation;
					}
					if (!string.IsNullOrEmpty(searchValue)) {
						Page.SearchEdit.SetSafeValue(MultiSelectMode ? searchValue.Replace("\"", string.Empty) : searchValue);
					}
					SetControlsVisible();
					InitializeDataSourceCurrentStructure();
				}
				InitializeSelectedRecordsDataSourceCurrentStructure(schemaUId);
			} 
			if (!Ext.IsAjaxRequest) {
				SelectedValues = new Dictionary<string, object>();
				var senderId = (string)Page.GetParameterValue("senderid");	
				string dataSourceClientID = Page.DataSource.ClientID;
				if (IsVirtualMode) {
					var virtualDataSource = GetVirtualDataSource();
					dataSourceClientID = virtualDataSource.ClientID;
				}
				string script =  @"document.title = " + Json.Serialize(windowCaption) + @";
				var parentWindow = window.opener.window;
				var key = window.name; 
				var lookupGridPageParams = parentWindow.lookupGridPageParams ? parentWindow.lookupGridPageParams[key] : null;
				var referenceSchemaList = lookupGridPageParams ? lookupGridPageParams.referenceSchemaList : null;
				var dataSource = window['" + dataSourceClientID + @"'];
				var schemaListEdit = Ext.getCmp('" + Page.SchemaListEdit.ClientID + @"');
				if (referenceSchemaList && referenceSchemaList.length > 0) {
					var length = referenceSchemaList.length;
					if (referenceSchemaList.length > 1) {
						schemaListEdit.setVisible(true);
						for (var i = 0; i < length; i++) {
							schemaListEdit.addItem(referenceSchemaList[i].referenceSchemaUId, referenceSchemaList[i].referenceSchemaCaption);
						}
						schemaListEdit.setValue('" + schemaUId.ToString() + @"');
					}
				}
				var searchEdit = Ext.getCmp('" + Page.SearchEdit.ClientID + @"');
				var searchButton = Ext.getCmp('" + Page.SearchButton.ClientID + @"');
				var toolButtonClearSearch = Ext.getCmp('" + Page.ToolButtonClearSearch.ClientID + @"');
				var okButton = Ext.getCmp('" + Page.OKButton.ClientID + @"');
				var treeGrid = Ext.getCmp('" + Page.TreeGrid.ClientID + @"');
				var selectedRecordsLayout = Ext.getCmp('" + Page.SelectedRowsControlLayout.ClientID + @"');
				var multiSelect = "+Terrasoft.Common.Json.Json.Serialize(MultiSelectMode)+@";
				if (multiSelect === true){
					selectedRecordsLayout.show();
				}
				else{
					selectedRecordsLayout.hide();
				}
				
				function onSearchButtonClick(e) {
					toolButtonClearSearch.show();
				}
			
				function onClearSearchValue(e) {
					searchEdit.setValue('');
					toolButtonClearSearch.hide();
					searchEdit.getEl().removeClass('x-qf-text');
				}
			
				function onSearchEditSpecialKey(el, e) {
					var key = e.getKey();
					startText = searchEdit.startValue;
					text = searchEdit.getValue();
					var showToolButton = true;
					var refreshData = true;
					var keyHandled = false;
					switch (key) {
						case e.ENTER :
							keyHandled = true;
							showToolButton = Ext.isEmpty(text) ? false : true;
							break;
						case e.ESC :
							keyHandled = true;
							showToolButton = false;
							refreshData = !Ext.isEmpty(startText);
							searchEdit.setValue('');
							break;
					}
					if (keyHandled === true) {
						if (showToolButton === true) {
							toolButtonClearSearch.show();
							searchEdit.getEl().addClass('x-qf-text');
						} else {
							toolButtonClearSearch.hide();
							searchEdit.getEl().removeClass('x-qf-text');
						}
						if (refreshData === true) {
							treeGrid.refreshData();
						}
						treeGrid.focus();
					}
				}
				
				function onTreeGridKeyDown(e) {
					var key = e.getKey();
					var refreshData = true;
					var keyHandled = false;
					switch (key) {
						case e.ENTER :
							okButton.fireEvent('click', okButton);
							break;
						case e.ESC :
							break;
					}
				}
				
				function onDataSourceLoaded(rows, cfg) {
					treeGrid.focus();
					treeGrid.on(Ext.isIE || Ext.isSafari3 ? 'keydown' : 'keypress', onTreeGridKeyDown, treeGrid);
				}
				
				searchEdit.on('specialkey', onSearchEditSpecialKey);
				searchButton.on('click', onSearchButtonClick);
				toolButtonClearSearch.on('click', onClearSearchValue);
				dataSource.on('loaded', onDataSourceLoaded);";
				Page.ScriptManager.AddScript(script);
				if (string.IsNullOrEmpty(searchValue)) {
					Page.ScriptManager.AddScript("Ext.onReady(function (){toolButtonClearSearch.hide();});");
				}
				if ((Page.AspPage as Terrasoft.UI.WebControls.Page).UseProfile && !IsVirtualMode) {
					dataSource.InitializeProfile();
				}
				if (IsVirtualMode) {
					var virtualDataSource = GetVirtualDataSource();
					virtualDataSource.LoadRows();
					Page.TreeGrid.RefreshData();
				} else {
					dataSource.LoadRows();
				}
			}
			return true;
		}

		public virtual bool ScriptRemoveSelectedRecordButtonClickExecute(ProcessExecutingContext context) {
			if (Page.SelectedRecordsGrid.SelectedNodes.Count == 0) {
				return true;
			}
			string primaryColumnName = Page.DataSource.Schema.PrimaryColumn.Name;
			string primaryDisplayColumnName = Page.DataSource.Schema.PrimaryDisplayColumn.Name;
			var selectedRecordsDataSource = (Terrasoft.UI.WebControls.Controls.VirtualDataSource)Page.PageContainer.FindPageControl("SelectedRecordsDataSource", true);
			foreach(var node in Page.SelectedRecordsGrid.SelectedNodes) {
				selectedRecordsDataSource.Remove(new Guid(node.Values[primaryColumnName].ToString()));
				((Dictionary<string, object>)SelectedValues).Remove(node.Values[primaryColumnName].ToString());
			}
			return true; 
		}

		public virtual bool ScriptSearchComboBoxEditChangeExecute(ProcessExecutingContext context) {
			SearchValue = Page.SearchComboBoxEdit.SelectedItem.Value;
			return true;
		}

		public virtual bool ScriptAddSelectedRecordButtonClickExecute(ProcessExecutingContext context) {
			if (Page.TreeGrid.SelectedNodes.Count == 0) {
				return true;
			}
			var selectedRecordsDataSource = (Terrasoft.UI.WebControls.Controls.VirtualDataSource)Page.PageContainer.FindPageControl("SelectedRecordsDataSource", true);
			
			string schemaUId = (Page.SchemaListEdit.Visible && Page.SchemaListEdit.Items.Count > 0) ?
			Page.SchemaListEdit.SelectedItem.Value : Page.DataSource.SchemaUId.ToString();
			string primaryColumnName = Page.DataSource.Schema.PrimaryColumn.Name;
			string primaryDisplayColumnName = Page.DataSource.Schema.PrimaryDisplayColumn.Name;
			var selectedValues = (Dictionary<string, object>)SelectedValues;
			object value;
			Entity row;
			Dictionary<string, object> values;
			foreach(var node in Page.TreeGrid.SelectedNodes) {
				row = selectedRecordsDataSource.CreateRow();
				row.SetColumnValue(primaryColumnName, node.Values[primaryColumnName]);
				row.SetColumnValue(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
				selectedRecordsDataSource.Add(row);
				if (!selectedValues.TryGetValue(node.Values[primaryColumnName].ToString(), out value)) {
					values = new Dictionary<string, object>();
					values.Add(primaryDisplayColumnName, node.Values[primaryDisplayColumnName]);
					values.Add("schemaUId", schemaUId);
					selectedValues.Add(node.Values[primaryColumnName].ToString(), values);
				}
			}
			selectedRecordsDataSource.LoadRows();
			return true;
		}

		public virtual bool ScriptSearchButtonClickExecute(ProcessExecutingContext context) {
			Page.TreeGrid.Clear();
			if (IsVirtualMode) {
				var virtualDataSource = GetVirtualDataSource();
				virtualDataSource.LoadRows();
			} else {
				Page.DataSource.LoadRows();
			}
			return true;
		}

		public virtual bool ScriptSchemaListEditChangeExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.Clear();
			var dataSource = Page.DataSource;
			string schemaUId = Page.SchemaListEdit.SelectedItem.Value;
			Page.SearchEdit.Caption = string.Empty;
			Page.SearchComboBoxEdit.ClearItems();
			SysLookupId = Guid.Empty;
			Page.TreeGrid.Clear();
			dataSource.CurrentStructure.Clear();
			((Dictionary<string, object>)SelectedValues).Clear();
			if (schemaUId.Equals(string.Empty)) {
				return true;
			}
			dataSource.SchemaUId = new Guid(schemaUId);
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			InitializeDataSourceCurrentStructure();
			if (page.UseProfile) {
				var args = new ProfileKeyEventArgs();
				args.Key = schemaUId;
				page.InitializeProfile(args, true);
				dataSource.IsProfileReaded = false;
				dataSource.InitializeProfile();
			} else {
			}
			string script = "document.title = '" + dataSource.Schema.Caption + "'";
			Page.ScriptManager.AddScript(script);
			dataSource.LoadRows();
			return true;
		}

		public virtual bool ScriptLookupGridPageLoadCompleteExecute(ProcessExecutingContext context) {
			//SetVirtualDataSourceFilters();
			Page.SearchEdit.MaxLength = 250;
			Page.CancelButton.Caption = EditMode ? CloseCaption : CancelCaption;
			Page.OKButton.Hidden = EditMode;
			var hideBtns = Page.GetParameterValue("hideButtons");
			bool hideButtons = hideBtns != null ? Convert.ToBoolean(hideBtns.ToString()) : false;
			hideButtons |= CanBeEditByNUI();
			var typeEditPageUIds = TypeEditPageUIds as Dictionary<Guid, Dictionary<string, Guid>>;
			
			List<Guid> detailSysSchemaIds = GetNotModuleDetailSchemaIds();
			    bool canManageLookup = UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageLookups", UserConnection.CurrentUser.Id);
			
			if (EditPageUId == Guid.Empty && (typeEditPageUIds == null || typeEditPageUIds.Count == 0) 
			    || hideButtons
			    || detailSysSchemaIds.Contains(Page.DataSource.SchemaUId) 
			    || SysLookupId != Guid.Empty && !canManageLookup)
			    Page.ButtonsControlLayout.Hide();
			
			string openLookupProcessKey = (string)Page.GetParameterValue("openLookupProcessKey");
			string customClosedEvent = (string)Page.GetParameterValue("customClosedEvent");
			string lookupGridPageClosedEvent = string.IsNullOrEmpty(customClosedEvent) ? "LookupGridPageClosed" : customClosedEvent;
			if (!string.IsNullOrEmpty(openLookupProcessKey)) {
				string key = Guid.NewGuid().ToString();
				List<object> userParameters = new List<object>();
				userParameters.Add(openLookupProcessKey);
				UserConnection.SessionData[key] = userParameters;
				string script = "Ext.EventManager.on(window, 'beforeunload', function() { \r\n" +
					"if (window.opener) {\r\n" +
					"window.opener.Terrasoft.AjaxMethods.ThrowClientEvent('" + openLookupProcessKey + "', '" + 
					lookupGridPageClosedEvent + "', '" + key + "');}\r\n" + 
					"});";
				Page.ScriptManager.AddScript(script);
			}
			// redundant, because base grid page already added this script
			/*if (!EditMode) {
				string script = GetRegisterTreeGridDblClickScript(string.Empty);
				string formatString = "{0}.on('click', function(el) {{ {1} }}, this)";
				Page.AddScript(string.Format(formatString, Page.OKButton.ClientID, script));
			}*/
			//GetVirtualDataSource().LoadRows();
			//Page.SelectedRecordsGrid.Clear();
			var dsVirtual = Page.PageContainer.FindControl("SelectedRecordsDataSource") as VirtualDataSource;
			if (dsVirtual != null) {
				dsVirtual.LoadRows();
			}
			return true;
		}

		public virtual bool ScriptTask145646456Execute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool LookupGridPageDataSourceBeforeLoadScriptTaskExecute(ProcessExecutingContext context) {
			// Set order direction for primary display column
			DataSourceStructure currentStructure = Page.DataSource.CurrentStructure;
			string displayColumnName = currentStructure.PrimaryDisplayColumnName;
			if (!String.IsNullOrEmpty(displayColumnName)) {
				DataSourceStructureColumn displayColumn = currentStructure.Columns.FindByName(displayColumnName);
				if (displayColumn != null && displayColumn.OrderDirection == OrderDirection.None) {
					foreach (var column in currentStructure.Columns) {
						if (column.OrderDirection != OrderDirection.None) {
							return true;
						}
					}
					displayColumn.OrderDirection = OrderDirection.Ascending;
					displayColumn.OrderPosition = 1;
				}
			}
			return true;
		}

		public virtual bool ScriptStopPageMessageExecute(ProcessExecutingContext context) {
			//Page.ScriptManager.AddScript("{0}.setDisabled({1}, {2});", Page.SearchControlLayout.ClientID, Json.Serialize(true), Json.Serialize(true));
			Page.ScriptManager.AddScript("{0}.setDisabled({1}, {2});", Page.ButtonsControlLayout.ClientID, Json.Serialize(true), Json.Serialize(true));
			//Page.ScriptManager.AddScript("{0}.setDisabled({1}, {2});", Page.CommonControlLayout.ClientID, Json.Serialize(true), Json.Serialize(true));
			Page.BaseMessagePanel.AddMessage(Warning, NotItemDisplayMessage, MessageType.Warning);
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var page = Page.AspPage as Terrasoft.UI.WebControls.Page;
			if (!page.IsPostBack && page.UseProfile) {	
				var args = new ProfileKeyEventArgs();
				args.Key = Page.AspPage.Request.QueryString["schemaUId"];
				if(args.Key != null)
					page.InitializeProfile(args);	
			}
			if (!page.IsPostBack) {
				var isVirtualModeParameter = Page.GetParameterValue("IsVirtualMode");
				if (isVirtualModeParameter != null) {
					IsVirtualMode = bool.Parse(isVirtualModeParameter.ToString());
					if (IsVirtualMode) {
						var virtualModeContextKey = Page.GetParameterValue("VirtualModeContextKey");
						if (virtualModeContextKey != null) {
							VirtualModeContextKey = virtualModeContextKey.ToString();
						}
						if (!string.IsNullOrEmpty(VirtualModeContextKey)) {
							string structureKey = string.Format("VirtualLookupGridPage_{0}_structure", VirtualModeContextKey);
							VirtualModeStructure = UserConnection.SessionData[structureKey];
						}
					}
				}
			} 
			if (IsVirtualMode) {
				Page.SearchControlLayout.Hidden = true;
				var virtualDataSource = new VirtualDataSource() {
					ID = "VirtualDataSource"
				};
				Page.TreeGrid.GetRowConfigHandler =
					delegate(Terrasoft.Core.Entities.Entity row) {			
						string primaryColumnName = row.Schema.PrimaryColumn.Name;		
						string primaryColumnValue =	row.GetColumnValue(primaryColumnName).ToString();
						var config = new DataSourceRowConfig(primaryColumnValue);		
						return config;
					};
				virtualDataSource.LoadingRow += DataSource_LoadingRows;
				virtualDataSource.DataRequest += DataSource_DataRequest;
				Page.PageContainer.Controls.Add(virtualDataSource);
				DataSourceStructure defStructure = virtualDataSource.DefStructure;
				if (defStructure.Columns.Count == 0) {
					defStructure.Columns.Clear();
					var virtualModeStructure = VirtualModeStructure as List<Dictionary<string, string>>;
					GetVirtualDataSourceStructure(virtualModeStructure, defStructure);
				}	
				Page.TreeGrid.DataSourceId = virtualDataSource.ID;
				virtualDataSource.Loaded += Page.TreeGrid.DataLoaded;
			}
			return true;
		}

		public virtual bool ScriptGetDataSourceSchemaUIdExecute(ProcessExecutingContext context) {
			var schemaUIdParam = (string)Page.GetParameterValue("schemaUId");
			Guid schemaUId = string.IsNullOrEmpty(schemaUIdParam) ? Guid.Empty : new Guid(schemaUIdParam);
			if (schemaUId != Guid.Empty && Page.DataSource.SchemaUId == Guid.Empty &&
				UserConnection.EntitySchemaManager.FindInstanceByUId(schemaUId) != null) {
				Page.DataSource.SchemaUId = schemaUId;
			}
			return true;
		}

		public virtual bool ScriptChildBasePrepareFiltersExecute(ProcessExecutingContext context) {
			/*
			var userId = UserConnection.CurrentUser.Id;
			var contactId = UserConnection.CurrentUser.ContactId;
			var demoUsers = new Guid[] {
				new Guid("1B4B9325-66CC-DF11-9B2A-001D60E938C6"),
				new Guid("E19B3E68-F36B-1410-9693-20CF308CCEC3"),
				new Guid("64508C35-BC4B-E011-8617-00155D043204")
			};
			if (!demoUsers.Contains(userId)) {
				return true;
			}
			var dataSource = Page.DataSource;
			var structure = dataSource.CurrentStructure;
			var demoFiltersName = "DemoFilters";
			var demoFilters = dataSource.FindFiltersGroupByName(demoFiltersName);
			if (demoFilters != null) {
				structure.Filters.Remove(demoFilters);
			}
			demoFilters = structure.CreateFiltersGroup(demoFiltersName, LogicalOperationStrict.Or);
			demoFilters.Add(structure.CreateFilterWithParameters(dataSource.Schema, FilterComparisonType.Equal, "CreatedBy", contactId));
			demoFilters.Add(structure.CreateFilterWithParameters(dataSource.Schema, FilterComparisonType.Equal, "CreatedBy", new Guid("22C5540C-D9B1-49EF-8EB7-72419B78E57C")));
			demoFilters.Add(structure.CreateIsNullFilter(dataSource.Schema, "CreatedBy"));
			structure.Filters.Add(demoFilters);*/
			return true;
		}

		public virtual void SetControlsVisible() {
			/*if (EditMode) {
				if (Page.ButtonsControlLayout.Hidden) {
					Page.ButtonsControlLayout.SetVisible(true);
				}
				if (!Page.OKButton.Hidden) {
					Page.OKButton.SetVisible(false);
				}
			} else {
				if (!Page.ButtonsControlLayout.Hidden) {
					Page.ButtonsControlLayout.SetVisible(false);
				}
				if (Page.OKButton.Hidden) {
					Page.OKButton.SetVisible(true);
				}
			}*/
			Page.OKButton.SetVisible(!EditMode);
			
		}

		public virtual Entity CreateLookupEntity(EntitySchema lookupSchema, string schemaUId) {
			Entity lookupEntity = lookupSchema.CreateEntity(UserConnection);
			var lookupSelect = new Select(UserConnection)
				.Column(Column.Asterisk())
				.From("SysLookup")
				.Where("SysEntitySchemaUId")
					.IsEqual(new QueryParameter(Guid.Parse(schemaUId))) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (System.Data.IDataReader dataReader = lookupSelect.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						lookupEntity.Load(dataReader);
						SysLookupId = lookupEntity.PrimaryColumnValue;
					}
				}
			}
			return lookupEntity;
		}

		public virtual void InitializeDataSourceCurrentStructure() {
			List<string> showColumns = GetShowColumns();
			var dataSource = Page.DataSource;
			var schema = dataSource.Schema;
			if (schema.PrimaryColumn == null) {
				throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
					"EntitySchema.Exception.Unspecified.PrimaryColumn"), schema.Name);
			}
			DataSourceStructure currentStructure = dataSource.CurrentStructure;
			var lookupSchema = dataSource.SchemaManager.GetInstanceByName("SysLookup");
			var lookupColumnSchema = dataSource.SchemaManager.GetInstanceByName("SysLookupColumn");
			var lookupSearchColumnSchema = dataSource.SchemaManager.GetInstanceByName("SysLookupSearchColumn");
			Entity lookupEntity = CreateLookupEntity(lookupSchema, dataSource.SchemaUId.ToString());
			var  editPageSchemaId = !lookupEntity.IsColumnValueLoaded("SysEditPageSchemaUId") ? EditPageUId : lookupEntity.GetTypedColumnValue<Guid>("SysEditPageSchemaUId");
			EditPageUId = editPageSchemaId == Guid.Empty ? GetDeafaultLookupEditSchemaId() : editPageSchemaId;
			string selectedValue = string.Empty;
			string schemaColumnMetaPath = string.Empty;
			Guid schemaPrimaryColumnUId = (schema.PrimaryColumn != null) ? schema.PrimaryColumn.UId : Guid.Empty;
			Guid schemaHierarchyColumnUId = (schema.HierarchyColumn != null) ? schema.HierarchyColumn.UId : Guid.Empty;
			Guid schemaPrimaryDisplayColumnUId = (schema.PrimaryDisplayColumn != null) ? schema.PrimaryDisplayColumn.UId : Guid.Empty;
			if (!lookupEntity.IsColumnValueLoaded(schema.PrimaryColumn.Name)) {
				currentStructure.AddColumnByMetaPath(schemaPrimaryColumnUId.ToString()).IsVisible = false;
				if (schemaPrimaryDisplayColumnUId != Guid.Empty) {
					if(showColumns.Count > 0) {
						foreach(var item in showColumns) {
							currentStructure.AddColumnByMetaPath(schema.FindSchemaColumnByPath(item).UId.ToString()).IsVisible = true;
						}
					} else {
						var column = currentStructure.AddColumnByMetaPath(schemaPrimaryDisplayColumnUId.ToString());
					}
					var displayColumn = currentStructure.Columns.FindByMetaPath(schema.PrimaryDisplayColumn.UId.ToString());
					if (displayColumn != null) {
						displayColumn.IsAlwaysSelect = true;
					}
					selectedValue = schema.PrimaryDisplayColumn.UId.ToString();
					Page.SearchComboBoxEdit.AddItem(selectedValue, schema.Columns.GetByName(schema.PrimaryDisplayColumn.Name).Caption);
				}
			
				if (schemaHierarchyColumnUId != Guid.Empty) {
					var hierarchyColumn = currentStructure.AddColumnByMetaPath(schemaHierarchyColumnUId.ToString());
					hierarchyColumn.IsVisible = false;
					hierarchyColumn.IsAlwaysSelect = true;
				}
			} else {
				EntityCollection lookupColumnEntities = new EntityCollection(UserConnection, "SysLookupColumn");
				EntitySchemaColumnMap columnMap;
				Select lookupColumnSelect = lookupColumnSchema.CreateSelect(UserConnection, true, out columnMap);
				lookupColumnSelect.Where("SysLookupId").IsEqual(new QueryParameter(lookupEntity.GetColumnValue(schema.PrimaryColumn.Name)))
					.OrderBy(OrderDirectionStrict.Ascending, "Position");
				lookupColumnSelect.Join(JoinType.Inner, "SysOrderDirection").As("SysOrderDirectionTable")
					.On("SysLookupColumn", "SysOrderDirectionId").IsEqual("SysOrderDirectionTable", "Id");
				lookupColumnSelect.Column("SysOrderDirection", "Code").As("SysOrderDirectionCode");
				columnMap.Add("SysOrderDirectionCode", "SysOrderDirectionCode");
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = lookupColumnSelect.ExecuteReader(dbExecutor)) {
						lookupColumnEntities.Load(reader, columnMap);
					}
				}
				if (lookupColumnEntities.Count == 0) {
					currentStructure.AddColumnByMetaPath(schemaPrimaryColumnUId.ToString()).IsVisible = false;
					if (schemaHierarchyColumnUId != Guid.Empty) {
						currentStructure.AddColumnByMetaPath(schemaHierarchyColumnUId.ToString()).IsVisible = false;
					}
					if (schemaPrimaryDisplayColumnUId != Guid.Empty) {
						currentStructure.AddColumnByMetaPath(schemaPrimaryDisplayColumnUId.ToString());
					}
				} else {
					var primaryColumnPresented = false;
					foreach (Terrasoft.Configuration.SysLookupColumn lookupColumnEntity in lookupColumnEntities) {
						var dataSourceStructureColumn = currentStructure.AddColumnByMetaPath(lookupColumnEntity.MetaPath);
						if (!primaryColumnPresented && dataSourceStructureColumn.SchemaColumnUId == schemaPrimaryColumnUId) {
							primaryColumnPresented = true;
						} 
						if (dataSourceStructureColumn.SchemaColumnUId == schemaHierarchyColumnUId) {
							dataSourceStructureColumn.IsVisible = false;
						}
						if (!string.IsNullOrEmpty(lookupColumnEntity.Caption)) {
							dataSourceStructureColumn.Caption = lookupColumnEntity.Caption;
						}
						dataSourceStructureColumn.Width = lookupColumnEntity.Width;
						string orderDirection = (string)lookupColumnEntity.GetColumnValue("SysOrderDirectionCode");
						if (!string.IsNullOrEmpty(orderDirection)) {
							dataSourceStructureColumn.OrderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection), orderDirection);
						}
					}
					if (!primaryColumnPresented) {
						currentStructure.AddColumnByMetaPath(schemaPrimaryColumnUId.ToString()).IsVisible = false;
					}
				}
				EntityCollection lookupSearchColumnEntities = new EntityCollection(UserConnection, "SysLookupSearchColumn");
				Select lookupSearchColumnSelect = lookupSearchColumnSchema.CreateSelect(UserConnection, true, out columnMap);
				lookupSearchColumnSelect.Where("SysLookupId").IsEqual(new QueryParameter(lookupEntity.GetColumnValue(schema.PrimaryColumn.Name)))
					.OrderBy(OrderDirectionStrict.Ascending, "Position");
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = lookupSearchColumnSelect.ExecuteReader(dbExecutor)) {
						lookupSearchColumnEntities.Load(reader, columnMap);
					}
				}
				EntitySchemaColumn schemaColumn = null;
				if (lookupSearchColumnEntities.Count == 0) {
					if (!schemaPrimaryDisplayColumnUId.Equals(Guid.Empty)) {
						selectedValue = schemaPrimaryDisplayColumnUId.ToString();;
						Page.SearchComboBoxEdit.AddItem(selectedValue, schema.Columns.GetByName(schema.PrimaryDisplayColumn.Name).Caption);
					}
				} else {
					int i = 0;
					foreach (Terrasoft.Configuration.SysLookupSearchColumn lookupSearchColumnEntity in lookupSearchColumnEntities) {
						schemaColumnMetaPath = lookupSearchColumnEntity.MetaPath;
						schemaColumn = schema.GetSchemaColumnByMetaPath(schemaColumnMetaPath);
						Page.SearchComboBoxEdit.AddItem(schemaColumnMetaPath, schemaColumn.Caption);
						if (i++ == 0) {
							selectedValue = schemaColumnMetaPath;
						}
					}
				}	
			}
			SearchValue = selectedValue;
			Page.SearchComboBoxEdit.SelectItem(selectedValue);
		}

		public virtual void InitializeSelectedRecordsDataSourceCurrentStructure(Guid schemaUID) {
			VirtualDataSource selectedRecordsDataSource = new VirtualDataSource {
				ID = "SelectedRecordsDataSource"
			};
			//---
			
			selectedRecordsDataSource.Loaded += Page.SelectedRecordsGrid.DataLoaded;
			//selectedRecordsDataSource.PrepareFilters += VirtualDataSource_PrepareFilters;
			Page.SelectedRecordsGrid.GetRowConfigHandler =	TreeGridConfigHandler;
			selectedRecordsDataSource.DataRequest += delegate(object sender, DataSourceEventArgs e) {
				var downDataSource = sender as Terrasoft.UI.WebControls.Controls.VirtualDataSource;
				string schemaUId = (Page.SchemaListEdit.Visible && Page.SchemaListEdit.Items.Count > 0) ?
				Page.SchemaListEdit.SelectedItem.Value : Page.DataSource.SchemaUId.ToString();
				string primaryColumnName = Page.DataSource.Schema.PrimaryColumn.Name;
				string primaryDisplayColumnName = Page.DataSource.Schema.PrimaryDisplayColumn.Name;
				var selectedValues = (Dictionary<string, object>)SelectedValues;
				object value;
				Entity row;
				Dictionary<string, object> values;
				foreach(KeyValuePair<string,object> selectedValue in selectedValues) {
					row = downDataSource.CreateRow();
					row.SetColumnValue(primaryColumnName, new Guid(selectedValue.Key.ToString()));
					row.SetColumnValue(primaryDisplayColumnName, (selectedValue.Value as Dictionary<string,object>)[primaryDisplayColumnName].ToString());
					downDataSource.Add(row);
				}
				downDataSource.LoadRows(e.Request);
			};
			//---
			Page.PageContainer.Controls.Add(selectedRecordsDataSource);
			if (!Ext.IsAjaxRequest) {
				var dataSource = Page.DataSource;
				var schema = dataSource.SchemaManager.GetInstanceByUId(schemaUID);
				Page.SelectedRecordsGrid.DataSourceId = selectedRecordsDataSource.ID; 
				DataSourceStructure dataSourceStructure = selectedRecordsDataSource.DefStructure;
				dataSourceStructure.PrimaryColumnName = schema.PrimaryColumn.Name;
				try {
					dataSourceStructure.PrimaryDisplayColumnName = schema.GetPrimaryDisplayColumnName();
				} catch {
					Page.ThrowEvent("StopPageMessage");
					return;
				}
				var dataValueTypeManager = (DataValueTypeManager)
					UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
				var idColumn = new DataSourceStructureColumn {
					Name = schema.PrimaryColumn.Name,
					DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
					IsVisible = false
				};
				dataSourceStructure.AddColumn(idColumn);
				var nameColumn = new DataSourceStructureColumn {
					Name = schema.PrimaryDisplayColumn.Name,
					DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
					//Caption = schema.PrimaryDisplayColumn.Caption
					Caption = SelectedRecordsDataSourceCaption
				};
				dataSourceStructure.AddColumn(nameColumn);
			}
			//var ds = Page.SelectedRecordsGrid.DataSource as VirtualDataSource;
			//ds.CurrentStructure.Filters.Add(SetVirtualDataSourceFilters());
		}

		public virtual void DataSource_PrepareFilters(object sender, DataSourceEventArgs e) {
			if (string.IsNullOrEmpty(SearchValue)) {
				return;
			}
			var currentStructure = Page.DataSource.CurrentStructure;
			var currentFiltersGroup = currentStructure.Filters.FindByName("LookupFiltersGroup");
			if (currentFiltersGroup != null){
				currentStructure.Filters.Remove(currentFiltersGroup);
			}
			var logicalOperation = LogicalOperationStrict.And;
			if ( LogicalOperation != null) {
				logicalOperation = (LogicalOperationStrict)LogicalOperation;
			}
			var lookupFiltersGroup = currentStructure.CreateFiltersGroup("LookupFiltersGroup", logicalOperation);
			string comparisonType = "StartWith";
			if (UserConnection != null) {
				object searchComparisonType;
				if (Terrasoft.Core.Configuration.SysSettings.TryGetValue(UserConnection,
						"StringColumnSearchComparisonType", out searchComparisonType) && searchComparisonType != null) {
						comparisonType = Enum.GetName(typeof(StringValueComparisonType), (int)searchComparisonType);
				}
			}
			
			var currentSearchTextFilter = currentStructure.Filters.FindByName("SearchTextFilter");
				if (currentSearchTextFilter != null) {
					currentStructure.Filters.Remove(currentSearchTextFilter);
			}
			if (!string.IsNullOrEmpty(Page.SearchEdit.Text)) {	
				var comparisonTypeValue = (FilterComparisonType)Enum.Parse(typeof(FilterComparisonType), comparisonType);
				var filters = currentStructure.CreateFilterWithParametersByMetaPath(Page.DataSource.Schema,	comparisonTypeValue, SearchValue, true, Page.SearchEdit.GetSafeValue());		
				var searchTextFilter = currentStructure.CreateFiltersGroup("SearchTextFilter", LogicalOperationStrict.And);
				searchTextFilter.Add(filters);
				currentStructure.Filters.Add(searchTextFilter);
			}
			
			var lookupFilters = (Collection<Dictionary<string, object>>)Page.GetParameterValue("LookupFilters");
			if (lookupFilters != null && lookupFilters.Count > 0) {
				foreach (Dictionary<string, object> filter in lookupFilters) {
					if (filter != null && filter.Count > 0) {
						FilterComparisonType filterComparisonType = (FilterComparisonType)filter["comparisonType"];
						string leftExpressionColumnPath = (string)filter["leftExpressionColumnPath"];
						bool useDisplayValue = (bool)filter["useDisplayValue"];
						DataSourceFilter lookupFilter;
						if (filter.ContainsKey("aggregationType")) {
							var aggregationType = (AggregationTypeStrict)filter["aggregationType"];
							object[] values = (object[])filter["rightExpressionParameterValues"];
							lookupFilter = currentStructure.CreateAggrigationFilter(Page.DataSource.Schema, filterComparisonType, leftExpressionColumnPath, aggregationType, false, useDisplayValue, values);
						} else {
							switch (filterComparisonType) {
								case FilterComparisonType.IsNull:
									lookupFilter = currentStructure.CreateIsNullFilter(Page.DataSource.Schema, leftExpressionColumnPath);
									break;
								case FilterComparisonType.IsNotNull:
									lookupFilter = currentStructure.CreateIsNotNullFilter(Page.DataSource.Schema, leftExpressionColumnPath);
									break;
								default:
									object[] rightExpressionParameterValues = (object[])filter["rightExpressionParameterValues"];
									lookupFilter = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema, filterComparisonType, leftExpressionColumnPath, useDisplayValue, rightExpressionParameterValues);
									break;
							}
						}
						lookupFiltersGroup.Add(lookupFilter);			
					}
				}
			}
			Guid schemaUId = Page.DataSource.Schema.UId;
			/*
			SysSchemaId								Name
			4FE60977-C711-48B2-8499-1CEBBECF7868	VwSysSchemaInWorkspace
			8D21EABA-8F38-4015-AEA0-37204380C093	VwSysPageSchemaInWorkspace
			2E155463-3FF1-4CCF-8584-4EC8D7233111	VwSysEntitySchemaInWorkspace
			90FA6D02-3E93-45D6-A72B-58DCFFA411AE	VwSysSchemaInfo
			36541FE9-C378-4338-915C-ED29D994BE05    VwSysEntitySchemaInPackage
			*/
			if (schemaUId.Equals(new Guid("4FE60977-C711-48B2-8499-1CEBBECF7868")) ||
					schemaUId.Equals(new Guid("8D21EABA-8F38-4015-AEA0-37204380C093")) ||
					schemaUId.Equals(new Guid("2E155463-3FF1-4CCF-8584-4EC8D7233111")) ||
					schemaUId.Equals(new Guid("90FA6D02-3E93-45D6-A72B-58DCFFA411AE")) ||
					schemaUId.Equals(new Guid("36541FE9-C378-4338-915C-ED29D994BE05"))) {
				DataSourceFilter lookupFilter = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema,
				FilterComparisonType.Equal, "SysWorkspace", UserConnection.Workspace.Id);
				lookupFilter.Name = "SysWorkspaceIdFilter";
				lookupFiltersGroup.Add(lookupFilter);			
			}
			
			if(!object.ReferenceEquals(lookupFiltersGroup, null)) {
				currentStructure.Filters.Add(lookupFiltersGroup);
			}
		}

		public virtual Guid GetDeafaultLookupEditSchemaId() {
			/*var schemaUId = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection ,"DefLookupEditPageSchemaUId");
			if (schemaUId == null){
				return Guid.Empty;
			} else {
				return new Guid(schemaUId.ToString());
			}*/
			var schema = Page.DataSource.Schema;
			if (schema == null) {
				return Guid.Empty;
			}
			if (schema.PrimaryColumn == null) {
				throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
					"EntitySchema.Exception.Unspecified.PrimaryColumn"), schema.Name);
			}
			var lookupSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysLookup");
			Entity lookupEntity = CreateLookupEntity(lookupSchema, schema.UId.ToString());
			Guid lookupEditPageUId = Guid.Empty;
			if (lookupEntity.IsColumnValueLoaded("SysEditPageSchemaUId") && 
				lookupEntity.GetTypedColumnValue<Guid>("SysEditPageSchemaUId") != Guid.Empty) {
				lookupEditPageUId = lookupEntity.GetTypedColumnValue<Guid>("SysEditPageSchemaUId");
			}
			var schemaUId = Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection ,"DefLookupEditPageSchemaUId");
			if (lookupEditPageUId == Guid.Empty && SysLookupId != Guid.Empty && schemaUId != null) {
				lookupEditPageUId = new Guid(schemaUId.ToString());
			}
			return lookupEditPageUId;
		}

		public override Dictionary<string, string> GetEditPages() {
			var result = base.GetEditPages();
			if (result.Count == 0 && EditPageUId == Guid.Empty) {
				EditPageUId = GetDeafaultLookupEditSchemaId();
				HasOwnEditPage = true;
			}
			return result;
		}

		public virtual void GetVirtualDataSourceStructure(List<Dictionary<string, string>> serializedStructure, DataSourceStructure structure) {
			bool useVirtualDataSource = false;
			var dataValueTypeManager = UserConnection.DataValueTypeManager;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			DataSourceStructureColumn column;
			foreach (var item in serializedStructure) {
				column = new DataSourceStructureColumn {
						Name = item["Name"],
						ValueColumnName = item["ValueColumnName"],
						DisplayColumnName = item["DisplayColumnName"],
						DataValueType = dataValueTypeManager.GetInstanceByName(item["DataValueTypeName"]),
						Caption = item["Caption"],
						IsVisible = bool.Parse(item["IsVisible"]),
						IsSortable = bool.Parse(item["IsSortable"])
					};
				if (item.ContainsKey("ReferenceSchemaName")) {
					var referenceSchema = entitySchemaManager.GetInstanceByName(item["ReferenceSchemaName"]);
					column.ReferenceSchemaName = item["ReferenceSchemaName"];
					column.ReferenceSchemaUId = referenceSchema.UId;
					column.ReferenceSchemaPrimaryColumnName = referenceSchema.GetPrimaryColumnName();
					column.ReferenceSchemaPrimaryDisplayColumnName = referenceSchema.GetPrimaryDisplayColumnName();
				}
				if (item.ContainsKey("IsPrimaryColumn")) {
					if (bool.Parse(item["IsPrimaryColumn"])) {
						structure.PrimaryColumnName = column.Name;
					}
				}
				if (item.ContainsKey("IsPrimaryDisplayColumn")) {
					if (bool.Parse(item["IsPrimaryDisplayColumn"])) {
						structure.PrimaryDisplayColumnName = column.Name;
					}
				}
				structure.AddColumn(column);
			}
		}

		public virtual void GetVirtualDataSourceData(VirtualDataSource virtualDataSource, DataSourceRequest request) {
			if (!IsVirtualMode) {
				return;
			}
			string dataKey = string.Format("VirtualLookupGridPage_{0}_data", VirtualModeContextKey);
			var data = UserConnection.SessionData[dataKey] as List<Dictionary<string, object>>;
			foreach (var item in data) {
				var row = virtualDataSource.CreateRow();
				foreach (var column in row.Schema.Columns) {
					row.SetColumnValue(column.ColumnValueName, item[column.ColumnValueName]);
				}
				virtualDataSource.Add(row);
			}
			if (request != null) {
				virtualDataSource.LoadRows(request);
			} else {
				virtualDataSource.LoadRows();
			}
		}

		public virtual VirtualDataSource GetVirtualDataSource() {
			return Page.PageContainer.FindControl("VirtualDataSource") as VirtualDataSource;
		}

		public virtual void DataSource_LoadingRows(object sender, DataSourceEventArgs e) {
			GetVirtualDataSourceData(sender as VirtualDataSource, null);
		}

		public virtual void DataSource_DataRequest(object sender, DataSourceEventArgs e) {
			GetVirtualDataSourceData(sender as VirtualDataSource, e.Request);
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			/*if (!EditMode) {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEvent('", InstanceUId, "', 'LookupRecordSelected');");
				return string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
			} else {*/
				var openPageParameters = new Dictionary<string, object>() {
						{"OpenerInstanceId", Page.Process.InstanceUId},		
					};
			
				var queryStringParameters = new Dictionary<string, string>() {
					{"recordId", Page.DataSource.ClientID + ".activeRow.getPrimaryColumnValue()"},
					{"entitySchemaUId",string.Format("'{0}'", Page.DataSource.SchemaUId)},
					{"treeGridId", string.Format("'{0}'", Page.TreeGrid.ClientID)},
					{"SysModuleEditId", string.Format("'{0}'", sysModuleEditId)}
				};
				ModifyEditPageParameters(openPageParameters, queryStringParameters);
			
				var sb = new StringBuilder();
				var typeEditPageUIdScript = string.Format("{0}.getCustomData('typeId_' + {1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName')).replace(/-/g, ''))", Page.AddButton.ClientID, Page.DataSource.ClientID);
				var typeIdScript = string.Format("{1}.activeRow.getColumnValue({0}.getCustomData('typeColumnName'))", Page.AddButton.ClientID, Page.DataSource.ClientID);
				sb.Append("Terrasoft.openWindow(");
				var sbCallback = new StringBuilder();
				var nullString = "null";
				var callbackString = "function(wnd) {{ {0} }}";
				var window = "wnd";
				sb.Append("'");
				sb.Append("ViewPage.aspx");	
				sb.Append("'");
				sb.Append(", ");
				if (TypeColumnUId == Guid.Empty) {
					sb.Append("'");
					sb.Append(editPageUId.ToString());
					sb.Append("'");	
				} else {
					sb.Append(typeEditPageUIdScript);
				}
				sb.Append(", ");
				sb.Append("[");
				bool isFirst = true;
				foreach (var parameter in queryStringParameters) {
					if (isFirst) {
						isFirst = false;
					} else {
						sb.Append(", ");
					}
					sb.Append("\n\t{name: ");
					sb.Append("'");
					sb.Append(parameter.Key);
					sb.Append("'");
					sb.Append(",");
					sb.Append(" value: ");
					if (!parameter.Value.StartsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
						sb.Append("'");
					}
					sb.Append(parameter.Value);
					if (!parameter.Value.EndsWith("'") && parameter.Key != "recordId" && parameter.Key != "ParentEntityId") {
						sb.Append("'");
					}
					sb.Append("}");
				}
				sb.Append("\t]");	
				sb.Append(", ");
				var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as PageSchemaManager;
				if (EditPageUId != Guid.Empty) {
					var pageSchema = pageSchemaManager.GetInstanceByUId(EditPageUId);	
					sb.Append(pageSchema.Width.ToString(CultureInfo.InvariantCulture));
					sb.Append(", ");		
					sb.Append(pageSchema.Height.ToString(CultureInfo.InvariantCulture));
					sb.Append(", ");
				}
				sb.Append("true");
				sb.Append(", ");
				sb.Append(nullString);
				sb.Append(", ");
				sb.Append(nullString);
				sbCallback.Append("\nvar windowKey = ");
				sbCallback.Append("'");
				sbCallback.Append(openPageParameters["OpenerInstanceId"].ToString());
				sbCallback.Append("'");
				sbCallback.Append(";");	
				sbCallback.Append("\nwnd.key = windowKey;");
				if (openPageParameters.ContainsKey("CloseMessage")) {
					var closeMessageObj = openPageParameters["CloseMessage"];
					if (closeMessageObj != null) {
						var closeMessage = closeMessageObj.ToString();
						if (closeMessage.Length > 0) {
							sbCallback.Append("\nExt.EventManager.on(");	
							sbCallback.Append(window);
							sbCallback.Append(", 'beforeunload', function() {\n\t");
							sbCallback.Append("if (Terrasoft.AjaxMethods.ThrowClientEvent)");
							sbCallback.Append("\n\t\t{\n\tTerrasoft.AjaxMethods.ThrowClientEvent(");	
							sbCallback.Append("windowKey");
							sbCallback.Append(",");
							sbCallback.Append("'");
							sbCallback.Append(closeMessage);
							sbCallback.Append("'");
							sbCallback.Append(");}");
							sbCallback.Append("\n});");				
						}
					}
				}
				sb.Append(", ");
				sb.Append(string.Format(callbackString, sbCallback.ToString()));
				sb.Append(");");
				return string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, sb.ToString());
			//}
		}

		public override void ModifyCopyPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			queryStringParameters.Remove("SysModuleEditId");
		}

		public override void CreateContextMenu() {
			return;
		}

		public override string GetRegisterTreeGridDblClickScript(string defaultScript) {
			if (EditMode) {
				return base.GetRegisterTreeGridDblClickScript(defaultScript);
			} if  (MultiSelectMode) {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEventWithMask('", InstanceUId, "', 'AddSelectedRecordButtonClick');");
				script = string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
				return script;
			} else {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEventWithMask('", InstanceUId, "', 'LookupRecordSelected');");
				if (!IsVirtualMode) {
					script = string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
				}
				return script;
			}
			// 14.08.2012
			/*if (EditMode) {
				return base.GetRegisterTreeGridDblClickScript(defaultScript);
			} 
			else {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEvent('", InstanceUId, "', 'LookupRecordSelected');");
				if (!IsVirtualMode) {
					script = string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
				}
			return script;
			}*/
			
			/*if (!EditMode) {
				var script = string.Concat("window.Terrasoft.AjaxMethods.ThrowClientEvent('", InstanceUId, "', 'LookupRecordSelected');");
				return string.Format("if ({0}.activeRow) {{ {1} }}", Page.DataSource.ClientID, script);
			} else {*/
				
			//}
			/*if (!Page.ButtonsControlLayout.Hidden) {
				return defaultScript;
			}
			else {
				return string.Empty;
			}*/
		}

		public virtual List<Guid> GetNotModuleDetailSchemaIds() {
			Select detailSchemaSelect = new Select(UserConnection)
				.Column("SysModuleEntity", "SysEntitySchemaUId")
			    .From("SysModuleDetail").As("SysModuleDetail")
			    .InnerJoin("SysModuleGrid").As("SysModuleGrid").On("SysModuleGrid", "Id").IsEqual("SysModuleDetail", "SysModuleGridId")
			    .InnerJoin("SysModuleEntity").As("SysModuleEntity").On("SysModuleEntity", "Id").IsEqual("SysModuleGrid", "SysModuleEntityId")
			    .Where("SysModuleEntity", "SysEntitySchemaUId")
			    .Not().In(
			    	new Select(UserConnection)
			        	.Column("SysModuleEntity", "SysEntitySchemaUId")
			            .From("SysModule").As("SysModule")
			            .InnerJoin("SysModuleEntity").As("SysModuleEntity").On("SysModuleEntity", "Id").IsEqual("SysModule", "SysModuleEntityId")
				) as Select;
			List<Guid> detailSchemaIds = new List<Guid>();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = detailSchemaSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						detailSchemaIds.Add(UserConnection.DBTypeConverter.DBValueToGuid(dr[0]));
			        }
			    }
			}
			return detailSchemaIds;
		}

		public virtual DataSourceRowConfig TreeGridConfigHandler(Entity row) {
				var config = new DataSourceRowConfig(row.PrimaryColumnValue);		
				return config;
		}

		public virtual DataSourceFilterCollection SetVirtualDataSourceFilters() {
			var lookupFilters = (Collection<Dictionary<string, object>>)Page.GetParameterValue("multiSelectLookupFilters");
			if(lookupFilters == null) {
			return null;
			}
			var selectedRecordsDataSource = (Terrasoft.UI.WebControls.Controls.VirtualDataSource)Page.PageContainer.FindPageControl("SelectedRecordsDataSource", true);
			Guid schemaUId = selectedRecordsDataSource.Schema.UId;
			var selectedValues = (Dictionary<string, object>)SelectedValues;
			var dic = (string[])lookupFilters[0].Values.Last();
			if(selectedValues.Count == 0 && dic.Length == 0) {
				return null;	
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var dsES = entitySchemaManager.GetInstanceByName("VwRecepientEmail"); 
			//var dsES = Page.DataSource.Schema;
			var dsESQ = new EntitySchemaQuery(entitySchemaManager, dsES.Name);
			var subFilterSet = new EntitySchemaQueryFilterCollection(dsESQ, LogicalOperationStrict.Or);
			var c = new EntitySchemaQueryFilterCollection(dsESQ, LogicalOperationStrict.Or);
			var IdColumn = dsESQ.AddColumn(dsES.GetPrimaryColumnName());
			var emailColumnName = dsESQ.AddColumn("Email").Name;
			
			//((string[])lookupFilters.Items[0].Values.Last()).Length
			
			dsESQ.Filters.Clear();
			for(int i=0; i < dic.Length; i++) {
				//dsESQ.Filters.Add(
				subFilterSet.Add(
				dsESQ.CreateFilterWithParameters(
					FilterComparisonType.Equal,
					"Email",
					dic[i]));
			}
			dsESQ.Filters.Add(subFilterSet);
			
			var emailCollection = dsESQ.GetEntityCollection(UserConnection);
			if(emailCollection.Count > 0) {
				object value;
				Dictionary<string, object> values;
				for(int i=0; i<emailCollection.Count; i++) {
					var row= selectedRecordsDataSource.CreateRow();
					var emailEntity  = emailCollection[i];
					var id = emailEntity.Schema.Columns.GetByName(IdColumn.Name);
					var name = emailEntity.Schema.Columns.GetByName(emailColumnName);
					//selectedValues.Add(emailEntity.GetTypedColumnValue<string>(id), emailEntity.GetTypedColumnValue<string>(name));	
					row.SetColumnValue("Id", emailEntity.GetTypedColumnValue<string>(id));
					row.SetColumnValue("Email", emailEntity.GetTypedColumnValue<string>(name));
					if (!selectedValues.TryGetValue(emailEntity.GetTypedColumnValue<string>(id), out value)) {
						values = new Dictionary<string, object>();
						values.Add("Email", emailEntity.GetTypedColumnValue<string>(name));
						values.Add("schemaUId", schemaUId);
						selectedValues.Add( emailEntity.GetTypedColumnValue<string>(id), values);
					}
					selectedRecordsDataSource.Rows.Add(row);
				}
			}
			Page.SelectedRecordsGrid.Clear();
			selectedRecordsDataSource.LoadRows();
			
			
			/*
			var cityCollection = cityEntitySchemaQuery.GetEntityCollection(UserConnection);
			if(cityCollection.Count > 0) {
				var cityEntity  = cityCollection[0];
				var regionColumnName = cityEntity.Schema.Columns.GetByName(regionPrimaryColumnName);
				var countryColumnName = cityEntity.Schema.Columns.GetByName(countryPrimaryColumnName);
										
				contact.SetColumnValue("RegionId", cityEntity.GetTypedColumnValue<Guid>(regionColumnName));
			}
			
			
			
			
			
			DataSourceFilterCollection lookupFiltersGroup = new DataSourceFilterCollection();
			var currentStructure = Page.SelectedRecordsGrid.DataSource.CurrentStructure;
			
			var lookupFilters = (Collection<Dictionary<string, object>>)Page.GetParameterValue("multiSelectLookupFilters");
			if (lookupFilters != null && lookupFilters.Count > 0) {
				foreach (Dictionary<string, object> filter in lookupFilters) {
					if (filter != null && filter.Count > 0) {
						FilterComparisonType filterComparisonType = (FilterComparisonType)filter["comparisonType"];
						string leftExpressionColumnPath = (string)filter["leftExpressionColumnPath"];
						bool useDisplayValue = (bool)filter["useDisplayValue"];
						DataSourceFilter lookupFilter;
						if (filter.ContainsKey("aggregationType")) {
							var aggregationType = (AggregationTypeStrict)filter["aggregationType"];
							object[] values = (object[])filter["rightExpressionParameterValues"];
							lookupFilter = currentStructure.CreateAggrigationFilter(Page.DataSource.Schema, filterComparisonType, leftExpressionColumnPath, aggregationType, false, useDisplayValue, values);
						} else {
							switch (filterComparisonType) {
								case FilterComparisonType.IsNull:
									lookupFilter = currentStructure.CreateIsNullFilter(Page.DataSource.Schema, leftExpressionColumnPath);
									break;
								case FilterComparisonType.IsNotNull:
									lookupFilter = currentStructure.CreateIsNotNullFilter(Page.DataSource.Schema, leftExpressionColumnPath);
									break;
								default:
									object[] rightExpressionParameterValues = (object[])filter["rightExpressionParameterValues"];
									lookupFilter = currentStructure.CreateFilterWithParameters(Page.DataSource.Schema, filterComparisonType, leftExpressionColumnPath, useDisplayValue, rightExpressionParameterValues);
									break;
							}
						}
						lookupFiltersGroup.Add(lookupFilter);			
					}
				}
			}
			return lookupFiltersGroup;
			*/
			return null;
		}

		public virtual List<string> GetShowColumns() {
			var tempUserContextUIdObj = Page.GetParameterValue("tempUserContextUId");
			List<string> listColumn = new List<string>();
			if (tempUserContextUIdObj != null) {
				var tempUserContextUId = tempUserContextUIdObj.ToString();
				var tempValues = UserConnection.SessionData[tempUserContextUId] as Dictionary<string, object>;
				if (tempValues != null && tempValues.ContainsKey("showColumns")&&tempValues["showColumns"] != null) {
					listColumn = (List<string>)tempValues["showColumns"];
				}
			}
			return listColumn;
		}

		public override void FillPrintMenu() {
		}

		public virtual bool CanBeEditByNUI() {
			if (HasOwnEditPage) {
				return false;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName());
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysModuleEntity.SysEntitySchemaUId", Page.DataSource.SchemaUId));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateIsNotNullFilter("CardSchemaUId"));
			var editPages = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (editPages.Count > 0) {
				return true;
			}
			entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleEdit");
			entitySchemaQuery.AddColumn(entitySchemaQuery.RootSchema.GetPrimaryColumnName());
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysModuleEntity.SysEntitySchemaUId", Page.DataSource.SchemaUId));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateIsNotNullFilter("CardSchemaUId"));
			editPages = entitySchemaQuery.GetEntityCollection(UserConnection);
			return editPages.Count > 0;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClick")) {
							context.QueueTasks.Enqueue("OKButtonClick");
						}
						break;
					case "LookupRecordSelected":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClick")) {
							context.QueueTasks.Enqueue("CancelButtonClick");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoad")) {
							context.QueueTasks.Enqueue("PageLoad");
						}
						break;
					case "ToolButtonClearSearchClick":
							if (ActivatedEventElements.Contains("ToolButtonClearSearchClick")) {
							context.QueueTasks.Enqueue("ToolButtonClearSearchClick");
						}
						break;
					case "RemoveSelectedRecordButtonClick":
							if (ActivatedEventElements.Contains("RemoveSelectedRecordButtonClick")) {
							context.QueueTasks.Enqueue("RemoveSelectedRecordButtonClick");
						}
						break;
					case "SearchComboBoxEditChange":
							if (ActivatedEventElements.Contains("SearchComboBoxEditChange")) {
							context.QueueTasks.Enqueue("SearchComboBoxEditChange");
						}
						break;
					case "AddSelectedRecordButtonClick":
							if (ActivatedEventElements.Contains("AddSelectedRecordButtonClick")) {
							context.QueueTasks.Enqueue("AddSelectedRecordButtonClick");
						}
						break;
					case "SearchButtonClick":
							if (ActivatedEventElements.Contains("SearchButtonClick")) {
							context.QueueTasks.Enqueue("SearchButtonClick");
						}
						break;
					case "SchemaListEditChange":
							if (ActivatedEventElements.Contains("SchemaListEditChange")) {
							context.QueueTasks.Enqueue("SchemaListEditChange");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartLookupGridPagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartLookupGridPagePageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceBeforeLoad":
							if (ActivatedEventElements.Contains("LookupGridPageDataSourceBeforeLoadStartMessage")) {
							context.QueueTasks.Enqueue("LookupGridPageDataSourceBeforeLoadStartMessage");
						}
						break;
					case "StopPageMessage":
							if (ActivatedEventElements.Contains("StopPageMessage")) {
							context.QueueTasks.Enqueue("StopPageMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("Init")) {
							context.QueueTasks.Enqueue("Init");
							ProcessQueue(context);
							return;
						}
						break;
					case "BasePrepareFilters":
							if (ActivatedEventElements.Contains("StartMessageChildBasePrepareFilters")) {
							context.QueueTasks.Enqueue("StartMessageChildBasePrepareFilters");
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
			if (!HasMapping("HasOwnEditPage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasOwnEditPage", HasOwnEditPage, false);
			}
			if (!HasMapping("SysLookupId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysLookupId", SysLookupId, Guid.Empty);
			}
			if (VirtualModeStructure != null) {
				if (VirtualModeStructure.GetType().IsSerializable ||
					VirtualModeStructure.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("VirtualModeStructure", VirtualModeStructure, null);
				}
			}
			if (!HasMapping("VirtualModeContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("VirtualModeContextKey", VirtualModeContextKey, null);
			}
			if (!HasMapping("IsVirtualMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsVirtualMode", IsVirtualMode, false);
			}
			if (LogicalOperation != null) {
				if (LogicalOperation.GetType().IsSerializable ||
					LogicalOperation.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LogicalOperation", LogicalOperation, null);
				}
			}
			if (!HasMapping("MultiSelectMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MultiSelectMode", MultiSelectMode, false);
			}
			if (!HasMapping("EntitySchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaName", EntitySchemaName, null);
			}
			if (!HasMapping("OpenLookupProcessUserContextUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OpenLookupProcessUserContextUId", OpenLookupProcessUserContextUId, null);
			}
			if (!HasMapping("SearchValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SearchValue", SearchValue, null);
			}
			if (SelectedValues != null) {
				if (SelectedValues.GetType().IsSerializable ||
					SelectedValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SelectedValues", SelectedValues, null);
				}
			}
			if (!HasMapping("EditMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditMode", EditMode, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: LookupGridPageEventsProcess

	/// <exclude/>
	public class LookupGridPageEventsProcess : LookupGridPageEventsProcess<Terrasoft.WebApp.LookupGridPageSchemaUserControl>
	{

		public LookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LookupGridPageSchemaUserControl

	/// <exclude/>
	public partial class LookupGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SearchControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SearchControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SchemaListEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("SchemaListEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SearchComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("SearchComboBoxEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SearchEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SearchEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ToolButtonClearSearch {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ToolButtonClearSearch", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SearchButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SearchButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer SpacerDeleteButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("SpacerDeleteButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout CommonControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("CommonControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SelectedRowsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SelectedRowsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SelectedRecordButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SelectedRecordButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddSelectedRecordButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddSelectedRecordButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button RemoveSelectedRecordButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("RemoveSelectedRecordButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SelectedRecordsGridContolLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SelectedRecordsGridContolLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid SelectedRecordsGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("SelectedRecordsGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ActionButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ActionButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer SpacerOKButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("SpacerOKButton", true);
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

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SchemaListEdit.AjaxEvents.Change.Event += SchemaListEditChange;
			SearchComboBoxEdit.AjaxEvents.Change.Event += SearchComboBoxEditChange;
			ToolButtonClearSearch.AjaxEvents.Click.Event += ToolButtonClearSearchClick;
			SearchButton.AjaxEvents.Click.Event += SearchButtonClick;
			SendEmailMenuItem.AjaxEvents.PrepareMenu.Event += SendEmailMenuItemPrepareMenu;
			AddSelectedRecordButton.AjaxEvents.Click.Event += AddSelectedRecordButtonClick;
			RemoveSelectedRecordButton.AjaxEvents.Click.Event += RemoveSelectedRecordButtonClick;
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
			DataSource.BeforeLoad += DataSourceBeforeLoad;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SchemaListEdit.AjaxEvents.Change.Event -= SchemaListEditChange;
			SearchComboBoxEdit.AjaxEvents.Change.Event -= SearchComboBoxEditChange;
			ToolButtonClearSearch.AjaxEvents.Click.Event -= ToolButtonClearSearchClick;
			SearchButton.AjaxEvents.Click.Event -= SearchButtonClick;
			SendEmailMenuItem.AjaxEvents.PrepareMenu.Event -= SendEmailMenuItemPrepareMenu;
			AddSelectedRecordButton.AjaxEvents.Click.Event -= AddSelectedRecordButtonClick;
			RemoveSelectedRecordButton.AjaxEvents.Click.Event -= RemoveSelectedRecordButtonClick;
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
			DataSource.BeforeLoad -= DataSourceBeforeLoad;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (LookupGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LookupGridPageEventsProcess(UserConnection);
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

		public virtual void SchemaListEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SchemaListEditChange");
		}

		public virtual void SearchComboBoxEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SearchComboBoxEditChange");
		}

		public virtual void ToolButtonClearSearchClick(object sender, EventArgs e) {
			object result = ThrowEvent("ToolButtonClearSearchClick");
		}

		public virtual void SearchButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SearchButtonClick");
		}

		public virtual void SendEmailMenuItemPrepareMenu(object sender, EventArgs e) {
			object result = ThrowEvent("SendEmailMenuItemPrepareMenu");
		}

		public virtual void AddSelectedRecordButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddSelectedRecordButtonClick");
		}

		public virtual void RemoveSelectedRecordButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("RemoveSelectedRecordButtonClick");
		}

		public virtual void OKButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OKButtonClick");
		}

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
		}

		public virtual void DataSourceBeforeLoad(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeLoad");
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
			SchemaName = "LookupGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: LookupGridPageEventsProcessSchema

	/// <exclude/>
	public class LookupGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public LookupGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LookupGridPageEventsProcessSchema(LookupGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LookupGridPageEventsProcess";
			UId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateEditModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("991c5da5-d009-4df8-ade6-fe72e6290eee"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("062ca4bd-7a5d-4779-8271-ddcaa2d5706a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"SelectedValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSearchValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("32d8beec-53a2-4c08-9c3d-da73b1d69ffb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"SearchValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenLookupProcessUserContextUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2db4b865-35a8-4c8f-afa4-865b2c832c2b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"OpenLookupProcessUserContextUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fd41649a-f855-4cf4-8b23-56091d377eb7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f3c22382-40d1-4f9f-bb69-ce23945680b6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EntitySchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMultiSelectModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eb491622-6516-4729-99c8-cc181a743a61"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"MultiSelectMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLogicalOperationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ac5aecbb-3500-4112-9d34-9ddbe29e73c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"LogicalOperation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsVirtualModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d22092a7-eef7-4d10-8916-672a4c7aae7b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"IsVirtualMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVirtualModeContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("01e82406-51e3-4e37-84b1-3fea48abf205"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"VirtualModeContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVirtualModeStructureParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("560c2568-8e62-4184-a3b1-2a04d1369e66"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"VirtualModeStructure",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysLookupIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56fe2f5e-c69a-4c18-b1bc-45ebf5a9aee2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"SysLookupId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasOwnEditPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("de58bbe6-be43-4779-9cda-15a4d0e291b8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"HasOwnEditPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEditModeParameter());
			Parameters.Add(CreateSelectedValuesParameter());
			Parameters.Add(CreateSearchValueParameter());
			Parameters.Add(CreateOpenLookupProcessUserContextUIdParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateEntitySchemaNameParameter());
			Parameters.Add(CreateMultiSelectModeParameter());
			Parameters.Add(CreateLogicalOperationParameter());
			Parameters.Add(CreateIsVirtualModeParameter());
			Parameters.Add(CreateVirtualModeContextKeyParameter());
			Parameters.Add(CreateVirtualModeStructureParameter());
			Parameters.Add(CreateSysLookupIdParameter());
			Parameters.Add(CreateHasOwnEditPageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet521 = CreateLaneSet521LaneSet();
			LaneSets.Add(schemaLaneSet521);
			ProcessSchemaLane schemaLane1756 = CreateLane1756Lane();
			schemaLaneSet521.Lanes.Add(schemaLane1756);
			ProcessSchemaLane schemaLane1757 = CreateLane1757Lane();
			schemaLaneSet521.Lanes.Add(schemaLane1757);
			ProcessSchemaLane schemaLane1758 = CreateLane1758Lane();
			schemaLaneSet521.Lanes.Add(schemaLane1758);
			ProcessSchemaLane schemaLane1759 = CreateLane1759Lane();
			schemaLaneSet521.Lanes.Add(schemaLane1759);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess17 = CreateEventSubProcess17EventSubProcess();
			FlowElements.Add(eventsubprocess17);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess18 = CreateEventSubProcess18EventSubProcess();
			FlowElements.Add(eventsubprocess18);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess processlookupgridpageloadcomplete = CreateProcessLookupGridPageLoadCompleteEventSubProcess();
			FlowElements.Add(processlookupgridpageloadcomplete);
			ProcessSchemaEventSubProcess lookupgridpagedatasourcebeforeloadeventsubprocess = CreateLookupGridPageDataSourceBeforeLoadEventSubProcessEventSubProcess();
			FlowElements.Add(lookupgridpagedatasourcebeforeloadeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess20 = CreateEventSubProcess20EventSubProcess();
			FlowElements.Add(eventsubprocess20);
			ProcessSchemaEventSubProcess eventsubprocessbaseinit = CreateEventSubProcessBaseInitEventSubProcess();
			FlowElements.Add(eventsubprocessbaseinit);
			ProcessSchemaEventSubProcess eventsubprocesschildbasepreparefilters = CreateEventSubProcessChildBasePrepareFiltersEventSubProcess();
			FlowElements.Add(eventsubprocesschildbasepreparefilters);
			ProcessSchemaStartMessageEvent okbuttonclick = CreateOKButtonClickStartMessageEvent();
			eventsubprocess12.FlowElements.Add(okbuttonclick);
			ProcessSchemaScriptTask scriptokbuttonclick = CreateScriptOKButtonClickScriptTask();
			eventsubprocess12.FlowElements.Add(scriptokbuttonclick);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess12.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask scripteditbuttonclicknoeditmode = CreateScriptEditButtonClickNoEditModeScriptTask();
			eventsubprocess12.FlowElements.Add(scripteditbuttonclicknoeditmode);
			ProcessSchemaStartMessageEvent cancelbuttonclick = CreateCancelButtonClickStartMessageEvent();
			eventsubprocess13.FlowElements.Add(cancelbuttonclick);
			ProcessSchemaScriptTask scriptcancelbuttonclick = CreateScriptCancelButtonClickScriptTask();
			eventsubprocess13.FlowElements.Add(scriptcancelbuttonclick);
			ProcessSchemaStartMessageEvent pageload = CreatePageLoadStartMessageEvent();
			eventsubprocess17.FlowElements.Add(pageload);
			ProcessSchemaScriptTask scriptpageload = CreateScriptPageLoadScriptTask();
			eventsubprocess17.FlowElements.Add(scriptpageload);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasepageload = CreateIntermediateThrowBasePageLoadIntermediateThrowMessageEvent();
			eventsubprocess17.FlowElements.Add(intermediatethrowbasepageload);
			ProcessSchemaStartMessageEvent toolbuttonclearsearchclick = CreateToolButtonClearSearchClickStartMessageEvent();
			eventsubprocess14.FlowElements.Add(toolbuttonclearsearchclick);
			ProcessSchemaIntermediateThrowMessageEvent throwsearchbuttonclick = CreateThrowSearchButtonClickIntermediateThrowMessageEvent();
			eventsubprocess14.FlowElements.Add(throwsearchbuttonclick);
			ProcessSchemaStartMessageEvent removeselectedrecordbuttonclick = CreateRemoveSelectedRecordButtonClickStartMessageEvent();
			eventsubprocess16.FlowElements.Add(removeselectedrecordbuttonclick);
			ProcessSchemaScriptTask scriptremoveselectedrecordbuttonclick = CreateScriptRemoveSelectedRecordButtonClickScriptTask();
			eventsubprocess16.FlowElements.Add(scriptremoveselectedrecordbuttonclick);
			ProcessSchemaStartMessageEvent searchcomboboxeditchange = CreateSearchComboBoxEditChangeStartMessageEvent();
			eventsubprocess18.FlowElements.Add(searchcomboboxeditchange);
			ProcessSchemaScriptTask scriptsearchcomboboxeditchange = CreateScriptSearchComboBoxEditChangeScriptTask();
			eventsubprocess18.FlowElements.Add(scriptsearchcomboboxeditchange);
			ProcessSchemaStartMessageEvent addselectedrecordbuttonclick = CreateAddSelectedRecordButtonClickStartMessageEvent();
			eventsubprocess15.FlowElements.Add(addselectedrecordbuttonclick);
			ProcessSchemaScriptTask scriptaddselectedrecordbuttonclick = CreateScriptAddSelectedRecordButtonClickScriptTask();
			eventsubprocess15.FlowElements.Add(scriptaddselectedrecordbuttonclick);
			ProcessSchemaStartMessageEvent searchbuttonclick = CreateSearchButtonClickStartMessageEvent();
			eventsubprocess10.FlowElements.Add(searchbuttonclick);
			ProcessSchemaScriptTask scriptsearchbuttonclick = CreateScriptSearchButtonClickScriptTask();
			eventsubprocess10.FlowElements.Add(scriptsearchbuttonclick);
			ProcessSchemaStartMessageEvent schemalisteditchange = CreateSchemaListEditChangeStartMessageEvent();
			eventsubprocess11.FlowElements.Add(schemalisteditchange);
			ProcessSchemaScriptTask scriptschemalisteditchange = CreateScriptSchemaListEditChangeScriptTask();
			eventsubprocess11.FlowElements.Add(scriptschemalisteditchange);
			ProcessSchemaStartMessageEvent startlookupgridpagepageloadcomplete = CreateStartLookupGridPagePageLoadCompleteStartMessageEvent();
			processlookupgridpageloadcomplete.FlowElements.Add(startlookupgridpagepageloadcomplete);
			ProcessSchemaScriptTask scriptlookupgridpageloadcomplete = CreateScriptLookupGridPageLoadCompleteScriptTask();
			processlookupgridpageloadcomplete.FlowElements.Add(scriptlookupgridpageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventpageloadcomplete = CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent();
			processlookupgridpageloadcomplete.FlowElements.Add(intermediatethrowmessageeventpageloadcomplete);
			ProcessSchemaScriptTask scripttask145646456 = CreateScriptTask145646456ScriptTask();
			processlookupgridpageloadcomplete.FlowElements.Add(scripttask145646456);
			ProcessSchemaStartMessageEvent lookupgridpagedatasourcebeforeloadstartmessage = CreateLookupGridPageDataSourceBeforeLoadStartMessageStartMessageEvent();
			lookupgridpagedatasourcebeforeloadeventsubprocess.FlowElements.Add(lookupgridpagedatasourcebeforeloadstartmessage);
			ProcessSchemaScriptTask lookupgridpagedatasourcebeforeloadscripttask = CreateLookupGridPageDataSourceBeforeLoadScriptTaskScriptTask();
			lookupgridpagedatasourcebeforeloadeventsubprocess.FlowElements.Add(lookupgridpagedatasourcebeforeloadscripttask);
			ProcessSchemaStartMessageEvent stoppagemessage = CreateStopPageMessageStartMessageEvent();
			eventsubprocess20.FlowElements.Add(stoppagemessage);
			ProcessSchemaScriptTask scriptstoppagemessage = CreateScriptStopPageMessageScriptTask();
			eventsubprocess20.FlowElements.Add(scriptstoppagemessage);
			ProcessSchemaStartMessageEvent init = CreateInitStartMessageEvent();
			eventsubprocessbaseinit.FlowElements.Add(init);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocessbaseinit.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocessbaseinit.FlowElements.Add(scripttask2);
			ProcessSchemaScriptTask scriptgetdatasourceschemauid = CreateScriptGetDataSourceSchemaUIdScriptTask();
			eventsubprocessbaseinit.FlowElements.Add(scriptgetdatasourceschemauid);
			ProcessSchemaStartMessageEvent startmessagechildbasepreparefilters = CreateStartMessageChildBasePrepareFiltersStartMessageEvent();
			eventsubprocesschildbasepreparefilters.FlowElements.Add(startmessagechildbasepreparefilters);
			ProcessSchemaScriptTask scriptchildbasepreparefilters = CreateScriptChildBasePrepareFiltersScriptTask();
			eventsubprocesschildbasepreparefilters.FlowElements.Add(scriptchildbasepreparefilters);
			FlowElements.Add(CreateSequenceFlow10584SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10585SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10586SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10587SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10588SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10589SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10590SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10591SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10592SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10623SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10624SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10630SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10631SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10634SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10635SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10636SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow366SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3654654SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCancelCaptionLocalizableString());
			LocalizableStrings.Add(CreateCloseCaptionLocalizableString());
			LocalizableStrings.Add(CreateNotItemDisplayMessageLocalizableString());
			LocalizableStrings.Add(CreatePrimaryDisplayColumnIsEmptyMessageLocalizableString());
			LocalizableStrings.Add(CreateSelectedRecordsDataSourceCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCancelCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("534008d6-a747-4f11-ba27-da838e8dc33b"),
				Name = "CancelCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCloseCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("28a5c86a-4b0f-4739-8a22-3d949200ae0d"),
				Name = "CloseCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotItemDisplayMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2a97a297-4da6-42eb-8d00-50069aae958a"),
				Name = "NotItemDisplayMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePrimaryDisplayColumnIsEmptyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04f7403a-e466-4a9a-b690-09bb0c8433fb"),
				Name = "PrimaryDisplayColumnIsEmptyMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSelectedRecordsDataSourceCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8e5aff1f-437f-4297-abca-11ce44f57851"),
				Name = "SelectedRecordsDataSourceCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10584SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10584",
				UId = new Guid("c5c549f3-b9b2-4ecb-8de6-92c6fdb7bd33"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(557, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c6789a5-e6ad-4ee8-9983-83ee68cc69f2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed1d1b12-be19-4497-bae9-3dd1e76d8cae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10585SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10585",
				UId = new Guid("29c8d0b7-8b98-4e2d-8980-b8232fee92d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(130, 446),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a621f4e0-ccf8-40a5-8de3-e9e2117f50a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c0818c40-f065-4172-abe2-3a4ae2a4eece"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10586SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10586",
				UId = new Guid("59347dde-a8cd-4bba-b30b-d2415180effe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(127, 604),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb1765a3-a5ae-4fe6-93ed-6873947ad3ca"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c5d8843-fcd7-4195-b0ad-e7c5ab30a1af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10587SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10587",
				UId = new Guid("a8bf41f8-0782-43fc-9db8-216627f6c40f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(554, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6506e319-c0ba-43bb-b829-08c1820ea3ed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71bd9f29-a978-46db-9200-2c5d74070efd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10588SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10588",
				UId = new Guid("bf17042a-6591-431c-8610-ca491cc8f406"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(354, 606),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05ae8e81-ed7e-4f3a-a299-0865177629f5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eb5dae00-17a0-4152-ae47-44171b48e958"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10589SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10589",
				UId = new Guid("82cfaa71-856a-42f0-a45f-e5fbdf2a6384"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(566, 616),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39fdd587-da9a-443f-81a7-06583e2526dd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d951a50a-60fe-4506-8ee7-740aff3716e8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10590SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10590",
				UId = new Guid("66519145-24d1-41ff-99b3-5bc2d332617d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(336, 696),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48e8c583-75fe-4d04-a61a-940ad5399c32"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9263ad5d-6700-4646-95d6-21022c58dd44"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10591SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10591",
				UId = new Guid("446049b3-4172-444e-aa41-6ff9df118317"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(132, 724),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9705237a-fb11-477d-9069-80703d408b6e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b4d26cbd-ca1d-4c16-94d2-2502342413b2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10592SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10592",
				UId = new Guid("ef9c357c-b50f-484d-b34b-061665af5f09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(562, 770),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a85fc2b0-f525-4c38-a3c3-8f57cee8b88e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("95f6c153-90da-43eb-a0cf-5ebbc79fed83"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10623SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10623",
				UId = new Guid("4b06266f-a935-4601-831c-c80cad9e81a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(475, 2020),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4d26cbd-ca1d-4c16-94d2-2502342413b2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7deb43fb-9364-4c93-8cf7-07804c1e3695"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10624SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10624",
				UId = new Guid("8fe78516-8e0c-4538-be16-afe74f3fa650"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(175, 1700),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23c2c673-ec8a-46b0-bda9-40bcebdd8aa8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1401fc1b-a4ba-45b6-a142-52e0845e9db3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10630SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10630",
				UId = new Guid("29221830-314c-4939-8f2e-6d48c90f8677"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f093043-7d71-4fda-8120-9d51a1971ce5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bce6af46-ae32-41d3-9a48-5ccf1af6f8e1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10631SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10631",
				UId = new Guid("f8c21e97-3790-41ab-b60b-45467c04ae39"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(554, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5fcddaa7-68e6-45b3-9594-65e3e3aebc56"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9cc9ef8a-6a29-4a0f-ae6e-c5a2c209f991"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10634SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10634",
				UId = new Guid("59829857-ae9b-436a-9c9b-22e656660a11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(887, 791),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e4c2f98-d287-434c-b26f-8d5881230bee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("311f8c47-7661-496f-b579-f7e81b863e8d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10635SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10635",
				UId = new Guid("989fc0e9-3971-4fd9-96c4-bb3d5a0f2e8c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(968, 790),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("28d7619a-3e4e-4d99-809c-ce4b51d3fc43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fcf1307d-5e29-4691-b137-87ecfb8cc21a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10636SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10636",
				UId = new Guid("1088a76b-a8e3-4aef-b610-43ffca7dfd5a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(513, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ca6adaa-58dd-4745-8b46-0604e881b901"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2fa4914a-39fd-4a7b-8d0d-107080ad121e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a5f5f939-132f-452d-aca7-765ce32be451"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(424, 463),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0ac42b76-76a7-4ded-8fbc-43bb31298e3f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c0818c40-f065-4172-abe2-3a4ae2a4eece"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("caaa70d8-020f-4063-8e50-1ac474662def"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(302, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1401fc1b-a4ba-45b6-a142-52e0845e9db3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc2cfcc5-b369-4bfa-aba6-a12d9b2727b8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow366SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow366",
				UId = new Guid("255fb557-b2fe-4411-81c2-6a166aeed610"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(887, 791),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("311f8c47-7661-496f-b579-f7e81b863e8d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("28d7619a-3e4e-4d99-809c-ce4b51d3fc43"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3654654SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3654654",
				UId = new Guid("8ec44eda-f441-434d-a46e-ff355b6efc77"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CurveCenterPosition = new Point(382, 231),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc2cfcc5-b369-4bfa-aba6-a12d9b2727b8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ddff2e5-06c5-44d4-b50f-d4f5a8624e4d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet521LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet521 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cdf77802-c797-46e0-8fb0-44c187b9bbfb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"LaneSet521",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(787, 1080),
				UseBackgroundMode = false
			};
			return schemaLaneSet521;
		}

		protected virtual ProcessSchemaLane CreateLane1756Lane() {
			ProcessSchemaLane schemaLane1756 = new ProcessSchemaLane(this) {
				UId = new Guid("ac62368d-b0c1-4382-b88d-af329d6e349a"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("cdf77802-c797-46e0-8fb0-44c187b9bbfb"),
				CreatedInOwnerSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"Lane1756",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 790),
				Size = new Size(758, 290),
				UseBackgroundMode = false
			};
			return schemaLane1756;
		}

		protected virtual ProcessSchemaLane CreateLane1757Lane() {
			ProcessSchemaLane schemaLane1757 = new ProcessSchemaLane(this) {
				UId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("cdf77802-c797-46e0-8fb0-44c187b9bbfb"),
				CreatedInOwnerSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"Lane1757",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 317),
				Size = new Size(758, 468),
				UseBackgroundMode = false
			};
			return schemaLane1757;
		}

		protected virtual ProcessSchemaLane CreateLane1758Lane() {
			ProcessSchemaLane schemaLane1758 = new ProcessSchemaLane(this) {
				UId = new Guid("df8919a1-c30f-42d3-a8d1-c0298b6c8156"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("cdf77802-c797-46e0-8fb0-44c187b9bbfb"),
				CreatedInOwnerSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"Lane1758",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 163),
				Size = new Size(758, 149),
				UseBackgroundMode = false
			};
			return schemaLane1758;
		}

		protected virtual ProcessSchemaLane CreateLane1759Lane() {
			ProcessSchemaLane schemaLane1759 = new ProcessSchemaLane(this) {
				UId = new Guid("9f31acac-08de-4425-acda-1578d43b6d52"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cdf77802-c797-46e0-8fb0-44c187b9bbfb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"Lane1759",
				Position = new Point(29, 0),
				Size = new Size(758, 158),
				UseBackgroundMode = false
			};
			return schemaLane1759;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b31a2c95-2365-4d7c-98a2-852104912600"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess12",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a621f4e0-ccf8-40a5-8de3-e9e2117f50a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b31a2c95-2365-4d7c-98a2-852104912600"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"OKButtonClick",
				Position = new Point(36, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOKButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c0818c40-f065-4172-abe2-3a4ae2a4eece"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b31a2c95-2365-4d7c-98a2-852104912600"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptOKButtonClick",
				Position = new Point(134, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,89,221,83,219,56,16,127,78,103,250,63,136,60,128,61,164,110,159,47,165,31,7,189,78,174,64,51,13,208,135,76,30,132,173,128,14,99,123,36,27,46,199,228,127,191,93,89,182,229,216,50,230,227,166,7,51,132,216,218,253,105,181,223,90,100,42,120,116,65,18,193,175,169,88,237,199,97,118,29,29,211,107,70,246,136,84,75,222,151,235,36,93,141,95,191,146,53,202,3,46,147,144,118,50,240,37,113,38,242,140,139,52,163,225,81,28,48,151,220,189,126,53,184,161,130,220,228,47,15,104,74,103,113,38,124,228,254,202,210,179,205,215,142,11,56,131,54,225,26,8,222,1,91,206,82,145,249,105,38,152,55,221,100,49,112,218,68,239,7,215,224,4,212,53,97,161,100,234,100,109,114,78,233,5,96,85,176,51,255,146,93,211,186,124,94,15,1,187,113,106,28,5,220,186,180,153,84,196,167,147,0,128,28,133,148,179,31,114,153,126,9,120,234,157,113,201,207,67,70,182,183,73,219,242,36,101,215,210,219,143,179,40,37,31,200,59,151,124,4,97,219,8,103,44,100,126,202,2,100,240,206,104,152,49,242,155,69,116,144,198,59,137,103,74,64,101,102,116,23,69,122,34,24,251,42,120,80,162,29,131,239,212,182,71,101,23,71,211,52,106,51,153,195,53,93,113,112,192,253,148,199,17,168,138,188,207,215,70,36,62,255,11,88,63,144,56,97,209,97,28,95,101,201,172,6,134,202,234,224,115,149,176,224,181,83,42,64,225,41,19,138,205,25,218,240,134,202,153,207,227,56,36,92,126,183,111,106,149,103,107,143,68,89,24,146,143,4,28,19,53,187,164,224,122,245,227,53,78,119,163,120,199,166,198,4,167,33,255,135,5,104,19,92,64,205,111,29,101,97,202,243,13,171,88,29,44,99,193,168,127,233,96,208,70,240,154,240,136,116,24,73,115,13,110,138,179,68,236,150,216,133,203,195,123,160,4,64,244,220,101,208,212,81,74,121,36,191,177,149,99,139,9,183,216,75,111,230,125,14,2,43,241,136,24,240,115,27,213,66,139,99,132,52,252,168,227,254,78,37,59,98,82,194,247,41,141,88,232,237,135,140,138,66,126,11,13,72,164,159,157,156,108,240,147,138,72,41,64,63,183,133,239,68,42,175,213,156,37,169,126,62,89,37,204,211,48,249,74,33,131,96,144,170,162,202,39,224,28,134,45,148,122,134,101,34,24,142,170,164,160,1,234,126,1,182,251,83,198,17,152,87,191,117,114,156,209,134,73,145,8,204,117,195,4,4,128,227,150,88,45,81,185,91,134,37,48,248,52,5,113,106,100,94,146,201,75,231,238,138,173,116,230,0,33,55,100,104,177,162,105,190,66,89,192,104,179,113,11,168,213,195,70,4,136,3,80,134,218,17,57,235,58,130,245,181,59,30,26,78,108,143,235,210,91,145,204,22,225,53,199,239,62,171,145,59,171,72,24,216,128,231,189,193,22,88,12,203,148,209,8,6,235,14,202,191,122,239,50,210,123,20,190,187,174,252,85,125,188,125,251,230,13,254,237,82,86,145,14,171,156,35,54,170,65,61,129,55,242,119,29,46,151,68,231,59,226,124,211,94,56,165,92,52,114,42,135,242,134,153,80,62,209,196,136,227,193,151,62,22,44,104,209,64,188,44,175,109,70,34,240,211,109,167,2,107,100,32,181,152,162,168,24,25,184,61,138,205,254,78,129,169,104,70,90,42,31,128,37,167,21,49,230,25,151,236,149,85,203,44,202,69,95,208,19,165,222,42,104,29,111,105,192,137,60,134,13,190,11,5,236,212,165,53,203,4,250,135,148,224,13,58,193,233,77,34,166,92,4,50,66,185,56,175,131,44,8,149,29,101,76,107,206,0,159,219,155,128,69,71,133,215,64,15,144,107,207,60,210,184,17,69,248,9,191,166,123,20,21,189,205,193,11,255,78,208,185,91,66,167,61,114,10,13,107,111,225,216,101,38,232,94,227,122,47,208,1,152,152,222,252,18,10,17,15,242,234,240,107,202,76,223,148,248,128,76,20,244,202,65,193,147,202,3,15,238,203,251,255,223,132,243,224,124,243,95,167,155,231,202,54,79,74,54,104,180,181,113,181,240,5,79,82,160,27,14,203,123,69,203,4,96,80,210,125,26,226,163,89,185,127,48,63,22,129,172,77,6,110,121,20,196,183,243,157,33,217,37,142,115,194,132,160,50,94,166,222,233,196,251,201,206,81,66,17,135,185,63,171,47,141,49,66,126,85,195,15,237,243,76,120,127,0,104,241,6,184,156,225,204,38,1,4,36,222,183,92,23,154,126,206,162,116,114,0,114,124,26,238,44,198,155,194,151,109,199,124,49,38,40,109,123,250,49,142,29,148,187,168,59,182,82,177,69,12,79,196,183,210,195,130,157,91,14,18,185,186,150,113,96,122,151,87,114,121,200,34,120,218,0,245,66,22,93,164,151,99,160,124,95,146,193,211,238,110,153,185,187,211,223,38,224,156,47,188,11,8,35,179,195,203,67,201,237,202,136,112,240,190,41,177,184,244,160,170,204,220,120,135,32,214,41,9,82,219,132,53,165,220,185,23,101,199,53,238,71,109,146,87,151,39,69,191,94,187,101,60,40,187,94,169,180,149,59,174,23,233,241,142,10,8,253,14,131,146,9,109,0,228,8,85,132,226,149,122,170,46,144,144,162,100,5,145,147,123,250,169,141,118,14,91,154,30,25,5,76,0,127,27,169,151,175,86,196,198,120,72,233,166,122,161,148,49,110,151,113,159,134,225,57,245,175,108,187,180,83,151,138,208,34,110,111,91,96,65,55,150,21,207,135,47,78,199,201,70,27,129,87,187,236,174,215,42,57,153,133,171,37,31,189,40,3,10,182,100,130,69,62,155,245,181,228,227,51,214,203,245,129,166,150,42,103,40,230,153,208,166,204,148,51,56,185,79,184,213,132,183,156,79,110,20,138,251,71,149,247,213,183,95,87,210,198,27,210,61,242,222,252,37,74,57,116,88,80,160,240,41,167,203,59,189,222,195,201,199,13,26,97,199,206,146,185,15,160,41,251,17,223,234,46,14,232,1,167,86,12,26,115,138,214,89,97,99,72,104,71,122,218,240,209,126,22,236,160,97,87,179,29,173,151,237,19,177,194,255,161,40,89,30,48,137,137,51,109,43,247,145,211,219,103,159,191,246,159,88,62,215,4,170,236,99,173,218,63,140,105,0,126,36,213,161,129,52,79,5,159,101,130,127,177,95,183,198,48,18,96,235,24,75,252,119,22,222,201,245,164,22,35,112,252,47,35,30,208,183,128,27,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0ac42b76-76a7-4ded-8fbc-43bb31298e3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b31a2c95-2365-4d7c-98a2-852104912600"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LookupRecordSelected",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 91),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEditButtonClickNoEditModeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2b7d95be-1933-4d28-9f3f-47115ae95a38"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b31a2c95-2365-4d7c-98a2-852104912600"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptEditButtonClickNoEditMode",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,77,115,219,54,16,61,211,51,254,15,136,14,9,25,107,144,158,163,218,105,71,118,51,110,221,212,19,58,238,193,227,3,68,174,98,212,20,160,1,64,105,212,140,254,123,22,0,41,126,136,80,149,164,23,141,68,190,125,120,187,120,139,133,248,156,196,183,236,51,208,59,5,240,94,241,156,166,80,64,102,32,255,32,115,208,116,42,75,97,200,249,57,249,137,188,124,73,28,178,6,124,132,76,170,92,31,12,74,200,151,211,147,72,129,41,149,32,70,149,48,57,61,217,158,158,104,163,184,248,76,150,138,47,152,218,76,101,81,46,196,7,182,0,114,78,252,43,122,181,88,154,205,164,143,188,228,122,89,176,131,1,28,19,186,214,247,92,153,146,21,127,162,28,47,97,197,20,89,249,135,151,204,176,84,150,42,179,209,239,193,220,247,31,199,9,242,68,67,226,246,24,232,37,204,83,204,43,195,4,129,222,246,67,90,60,67,210,143,163,219,139,180,53,36,80,104,112,153,13,233,116,251,212,162,77,179,39,88,176,174,62,122,132,192,195,60,157,136,154,174,217,93,237,192,159,174,115,36,242,30,243,225,55,92,155,171,156,27,122,207,53,159,21,208,24,171,251,250,218,192,162,246,210,133,181,210,59,20,59,4,172,205,103,3,232,61,43,74,32,111,3,210,81,13,189,147,169,19,232,182,153,31,229,127,92,158,188,121,253,61,13,240,250,141,247,95,93,147,10,230,84,106,175,99,223,195,209,37,207,12,151,2,107,76,126,246,239,198,68,206,254,193,208,11,34,151,32,110,164,124,46,151,105,135,204,86,249,64,92,226,164,163,221,111,153,194,157,50,160,92,88,60,10,241,141,92,23,204,164,44,8,215,127,133,23,13,234,121,113,78,68,89,20,228,157,107,124,220,146,57,67,207,118,211,219,203,110,229,98,39,237,138,41,206,10,254,47,228,118,51,237,139,185,84,192,178,167,216,182,180,192,114,19,46,200,129,45,244,245,143,86,181,94,1,107,18,22,224,123,191,66,211,95,243,60,14,181,199,216,45,238,253,166,31,66,168,199,61,190,209,174,47,70,227,166,71,60,172,155,44,138,253,93,75,129,233,84,79,99,79,51,238,229,96,65,83,41,86,160,112,87,227,164,166,26,112,218,217,206,106,136,207,152,65,49,29,24,93,150,250,41,254,242,12,155,170,141,80,98,79,194,64,210,237,108,199,196,46,30,97,92,168,34,3,156,33,40,178,33,56,199,82,184,5,109,100,183,66,248,126,155,76,188,83,35,219,202,97,167,86,54,112,168,144,101,109,85,12,227,66,255,1,155,255,72,180,117,138,36,53,117,20,226,125,56,154,235,209,78,133,93,11,68,81,235,156,63,192,239,124,117,244,26,227,106,133,164,90,194,126,218,143,109,171,233,50,197,151,120,128,145,95,70,213,236,68,75,224,207,53,23,185,92,83,81,77,14,91,203,234,145,149,6,170,153,181,133,147,105,187,209,182,166,59,115,116,67,224,209,180,250,53,132,125,192,5,31,39,21,153,6,145,131,194,240,33,36,245,111,107,172,130,57,40,16,25,164,173,241,243,106,68,206,90,243,232,12,243,122,213,144,247,14,180,135,199,9,113,248,193,14,106,74,210,21,51,101,69,49,99,217,115,72,229,48,186,174,98,149,33,78,152,97,28,22,54,240,134,102,248,37,62,80,152,113,47,145,241,64,137,146,201,118,91,239,77,86,72,109,175,64,163,73,61,110,209,93,169,51,68,236,125,145,52,23,144,221,248,60,118,38,94,212,119,194,118,233,171,160,206,197,44,190,3,165,152,150,115,67,63,93,211,191,97,102,123,83,201,194,55,169,251,178,119,113,243,51,206,85,199,55,50,122,236,55,204,170,126,130,81,241,40,13,45,138,167,139,29,84,73,208,24,113,120,108,36,221,134,180,20,87,194,112,179,33,74,174,237,47,143,243,157,119,244,8,252,190,73,135,43,218,43,69,40,77,58,69,82,3,31,229,186,154,117,136,71,30,227,15,11,127,41,216,59,63,6,135,221,222,148,11,51,253,216,244,12,231,98,15,62,92,181,25,0,47,122,3,237,78,109,236,21,223,105,249,134,19,82,150,213,94,237,14,247,111,187,63,252,239,23,136,99,111,16,189,185,255,35,147,97,55,19,130,213,191,145,44,71,31,105,151,52,66,219,255,243,190,2,172,38,50,10,89,14,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("39ea6cdf-5726-4875-a221-50276968ae07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess13",
				Position = new Point(36, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(239, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fb1765a3-a5ae-4fe6-93ed-6873947ad3ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39ea6cdf-5726-4875-a221-50276968ae07"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"CancelButtonClick",
				Position = new Point(43, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptCancelButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c5d8843-fcd7-4195-b0ad-e7c5ab30a1af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("39ea6cdf-5726-4875-a221-50276968ae07"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptCancelButtonClick",
				Position = new Point(134, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,15,72,76,79,213,11,78,46,202,44,40,241,77,204,3,114,138,244,28,83,82,32,2,26,74,229,153,121,41,249,229,122,201,57,249,197,169,26,154,214,74,154,214,92,26,96,29,142,197,5,32,90,33,177,88,33,36,181,168,40,177,56,63,173,68,47,212,83,47,60,53,201,57,63,175,164,40,63,167,88,15,164,64,83,207,25,170,151,171,40,181,164,180,40,79,161,164,168,52,213,26,0,10,64,174,213,120,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess17EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess17 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a0dcaf42-0b17-49cf-b103-a658e8ef063d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac62368d-b0c1-4382-b88d-af329d6e349a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess17",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 117),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess17;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9705237a-fb11-477d-9069-80703d408b6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0dcaf42-0b17-49cf-b103-a658e8ef063d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"PageLoad",
				Position = new Point(21, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b4d26cbd-ca1d-4c16-94d2-2502342413b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0dcaf42-0b17-49cf-b103-a658e8ef063d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptPageLoad",
				Position = new Point(92, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,89,91,83,27,55,20,126,118,103,250,31,132,31,234,221,129,110,219,233,91,9,161,9,184,137,91,72,24,12,201,3,101,58,98,87,6,133,245,174,43,201,16,55,225,191,247,28,105,181,146,118,101,59,153,105,103,8,54,187,231,124,231,126,145,242,166,86,231,44,231,15,236,76,240,10,190,46,106,161,78,89,181,36,7,68,137,37,219,255,246,155,7,42,136,98,243,197,165,100,226,168,174,20,251,168,46,39,197,219,155,15,64,114,70,111,89,246,138,169,51,42,232,156,41,38,222,209,114,201,146,97,159,126,152,2,20,159,145,36,14,181,115,64,170,101,89,166,228,211,183,223,12,226,18,81,163,24,111,118,81,79,21,40,127,155,160,136,150,89,107,34,129,169,97,168,88,174,120,93,101,83,38,37,124,30,83,69,175,250,120,215,132,74,114,204,53,41,21,171,103,82,35,239,145,250,230,3,240,63,71,1,214,136,70,64,163,57,249,238,59,79,108,134,136,148,87,242,15,182,74,134,75,201,94,115,38,168,200,239,86,195,212,216,168,97,118,146,155,186,46,83,199,119,21,210,94,55,180,3,237,103,84,121,90,47,69,206,178,163,165,16,172,82,96,247,50,87,75,193,178,137,180,92,60,167,37,88,61,163,165,196,232,13,6,79,240,11,254,61,153,72,74,134,68,90,26,80,161,154,162,46,47,21,47,185,226,160,247,107,53,47,143,89,94,23,44,73,140,237,233,186,24,123,72,96,84,147,40,50,191,99,115,250,6,8,1,125,43,66,75,172,179,195,248,152,44,2,170,13,73,102,216,109,110,189,90,242,130,180,143,128,173,139,211,196,233,144,32,101,54,158,47,212,138,252,66,42,246,168,31,36,33,185,151,84,54,113,187,49,152,106,89,97,230,6,230,123,127,28,30,146,56,123,134,175,109,86,121,218,31,120,90,54,73,224,219,22,7,131,119,251,65,176,231,203,82,241,41,43,193,173,167,16,82,19,240,7,38,148,51,111,157,115,59,172,38,194,152,173,132,203,211,240,29,188,56,237,9,66,210,236,66,172,0,87,178,164,131,6,245,180,84,125,160,20,130,211,123,8,49,178,185,60,174,20,87,43,103,54,41,220,215,158,79,128,254,135,31,78,106,168,6,254,15,189,41,153,177,151,148,117,125,191,92,188,18,188,64,250,35,186,192,74,223,144,100,81,250,97,138,109,162,7,174,69,154,156,39,143,188,42,234,71,135,223,35,134,146,125,3,121,243,86,232,24,39,81,57,232,16,131,215,230,107,148,46,108,129,24,249,117,102,110,43,201,53,230,2,234,26,187,228,255,108,140,110,147,19,249,142,11,181,164,165,201,146,79,77,189,236,68,133,187,178,75,83,211,61,253,202,233,76,3,147,82,166,124,78,105,5,90,8,116,203,164,146,138,86,57,123,185,66,28,31,50,107,138,108,48,240,89,123,21,223,212,225,23,148,181,96,208,192,43,59,108,29,211,151,153,22,81,226,107,45,4,197,156,138,105,214,213,126,103,252,81,129,26,47,62,208,143,231,236,111,152,81,170,81,220,149,218,111,188,132,12,194,89,139,221,244,168,46,75,35,251,217,164,75,51,129,81,247,220,204,233,65,147,80,172,224,182,103,108,75,78,75,58,52,0,99,199,25,245,150,37,199,196,211,45,4,50,206,245,191,151,208,160,24,173,28,149,198,44,34,61,181,13,172,235,175,62,221,153,96,48,59,90,39,236,30,16,103,245,95,225,75,187,159,24,56,192,237,137,251,130,8,237,111,202,144,160,60,237,170,209,171,89,51,122,162,245,182,61,238,166,189,220,226,158,241,118,1,59,199,214,6,26,146,54,193,67,17,61,148,96,150,14,6,39,125,41,93,150,118,195,217,212,16,220,162,146,6,11,213,84,191,192,52,130,175,106,74,103,204,232,220,157,64,135,254,214,148,193,142,92,210,28,44,251,115,56,220,11,58,90,10,9,230,11,115,202,1,124,179,106,65,39,147,28,134,64,83,4,147,10,246,46,28,12,204,37,77,119,185,115,113,113,212,70,59,86,192,238,94,139,66,110,96,14,18,231,137,52,29,117,77,112,45,108,187,60,99,65,175,95,135,221,198,45,89,85,64,121,23,95,178,245,105,82,142,91,219,0,87,38,211,6,92,37,28,149,28,12,152,28,71,214,28,251,202,150,64,100,46,104,109,30,204,211,99,127,61,0,77,222,117,31,39,221,162,247,100,247,48,2,233,79,78,115,153,11,190,80,192,65,126,29,22,117,190,156,3,81,6,61,183,68,169,67,178,75,126,151,250,216,33,76,228,58,37,10,239,127,29,90,47,98,171,168,212,123,77,0,204,134,50,171,23,172,130,150,96,254,178,164,247,108,229,40,42,236,217,164,121,19,14,85,237,125,105,214,225,22,59,139,210,28,110,167,185,2,177,215,184,53,67,121,89,77,4,155,49,96,203,153,233,96,39,92,42,93,168,81,9,177,199,89,12,33,148,17,44,122,198,232,171,17,250,54,18,58,116,232,232,58,108,181,8,137,117,14,220,152,249,183,80,142,243,69,162,17,76,39,8,168,178,16,171,237,184,49,61,225,216,23,121,156,149,172,186,85,119,228,57,249,209,239,154,230,225,193,6,142,182,55,110,4,253,201,182,177,208,186,76,98,142,155,246,130,251,132,201,238,193,172,22,36,65,249,28,68,255,184,15,31,207,26,85,224,251,238,174,197,234,130,209,162,192,113,29,211,228,138,95,119,131,6,13,102,47,102,87,132,212,166,190,209,238,105,157,33,186,91,232,16,181,45,204,27,85,94,104,236,9,119,224,206,183,27,99,237,186,126,36,206,14,227,229,82,41,61,115,54,160,24,154,117,56,10,86,12,67,113,4,171,134,48,44,235,0,47,98,196,235,144,235,251,205,218,189,253,99,139,102,130,49,44,194,181,202,52,239,215,123,40,24,63,39,116,133,7,186,181,174,106,136,235,71,217,76,65,195,176,14,221,59,45,98,11,221,189,96,66,80,89,207,128,161,158,207,193,42,221,81,59,109,181,123,150,220,53,109,21,107,41,192,59,48,23,91,102,127,142,218,145,201,187,250,209,13,93,6,155,227,6,226,59,94,120,19,26,126,102,203,74,207,75,82,87,126,146,128,173,249,125,98,167,84,52,53,66,193,33,148,71,102,42,195,34,185,132,247,170,166,41,140,184,20,167,177,207,12,97,27,151,73,10,197,58,175,31,160,155,82,41,147,209,199,239,255,158,125,143,87,99,163,184,86,174,150,166,11,150,67,36,240,190,139,149,123,196,159,198,102,84,49,148,128,175,237,246,79,133,186,0,100,220,71,61,19,240,177,54,194,24,208,35,184,181,54,26,24,157,140,224,53,87,61,238,226,114,96,199,147,96,242,14,231,120,247,21,40,246,154,86,69,201,138,224,194,76,62,114,5,117,154,192,107,219,27,115,10,167,7,150,141,223,92,140,207,201,47,166,93,6,220,45,46,176,119,213,193,162,224,210,236,162,104,144,127,30,241,248,110,4,163,247,251,129,184,233,209,87,11,115,102,224,209,210,55,125,199,215,163,117,127,106,129,54,164,145,175,91,187,107,251,26,217,154,106,188,165,79,39,29,197,58,36,91,11,96,16,77,78,152,73,241,204,4,197,8,22,234,102,120,47,243,191,58,247,237,164,106,134,179,115,108,207,50,219,59,61,170,36,128,104,41,102,176,46,202,36,28,98,97,129,217,70,12,133,115,92,63,86,201,214,186,250,95,83,222,142,157,108,198,5,27,63,64,239,78,70,57,246,181,209,94,59,146,250,41,19,73,231,48,159,250,102,187,173,251,164,166,5,43,18,1,179,99,143,228,179,91,219,63,99,46,108,31,214,85,98,146,125,50,38,159,63,55,5,8,231,59,42,248,207,80,124,35,48,19,54,200,106,4,5,136,223,23,224,45,137,38,116,221,189,215,14,74,191,193,123,137,3,130,70,210,116,62,192,209,16,177,150,168,185,253,173,66,51,182,158,235,207,9,205,16,207,225,144,179,59,22,52,163,119,171,128,212,165,118,161,38,239,250,53,221,215,67,178,217,129,241,28,99,47,32,94,20,133,121,144,152,243,205,230,107,135,200,17,123,35,230,16,67,82,87,231,140,22,171,164,141,123,146,126,218,88,183,79,160,110,112,71,97,110,175,95,200,5,126,226,149,172,219,20,46,39,217,123,118,99,15,221,25,18,164,217,165,100,103,162,158,113,56,154,193,222,30,187,86,244,125,231,78,219,13,83,120,65,242,31,29,62,251,231,76,12,13,238,74,13,65,184,144,157,119,155,138,223,247,138,117,32,230,191,4,252,171,198,127,1,112,190,202,203,248,27,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBasePageLoadIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7deb43fb-9364-4c93-8cf7-07804c1e3695"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0dcaf42-0b17-49cf-b103-a658e8ef063d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"IntermediateThrowBasePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(217, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7c8715fa-3c12-4e26-be61-68ba5020f45f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess14",
				Position = new Point(519, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(225, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateToolButtonClearSearchClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("05ae8e81-ed7e-4f3a-a299-0865177629f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c8715fa-3c12-4e26-be61-68ba5020f45f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ToolButtonClearSearchClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ToolButtonClearSearchClick",
				Position = new Point(36, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowSearchButtonClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("eb5dae00-17a0-4152-ae47-44171b48e958"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7c8715fa-3c12-4e26-be61-68ba5020f45f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SearchButtonClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ThrowSearchButtonClick",
				Position = new Point(155, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("682c25d6-e9d6-43b3-bb28-364b12d097ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess16",
				Position = new Point(35, 315),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(246, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemoveSelectedRecordButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("48e8c583-75fe-4d04-a61a-940ad5399c32"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("682c25d6-e9d6-43b3-bb28-364b12d097ed"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RemoveSelectedRecordButtonClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"RemoveSelectedRecordButtonClick",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptRemoveSelectedRecordButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9263ad5d-6700-4646-95d6-21022c58dd44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("682c25d6-e9d6-43b3-bb28-364b12d097ed"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptRemoveSelectedRecordButtonClick",
				Position = new Point(134, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,75,107,2,49,16,62,187,191,98,240,148,128,132,222,183,246,162,84,122,17,113,173,61,148,30,198,221,81,83,118,19,153,36,150,82,250,223,155,172,239,22,193,94,66,24,230,123,204,124,163,151,32,38,184,34,85,80,77,165,167,106,74,165,229,202,141,88,87,199,218,216,86,228,212,192,6,227,161,223,135,59,9,95,89,135,201,7,54,224,57,80,158,125,103,206,179,54,43,216,176,110,144,63,7,182,14,141,25,99,67,208,135,150,127,136,30,11,27,184,140,82,229,154,26,84,147,243,86,149,122,243,95,44,67,237,54,53,254,135,236,2,177,231,220,34,131,187,156,238,132,143,140,98,70,204,232,236,210,171,231,39,245,66,139,129,53,158,109,157,38,222,127,230,154,125,192,250,4,147,173,141,244,164,30,212,134,88,61,106,83,29,42,17,37,186,197,53,209,110,175,93,155,204,179,165,101,194,114,45,146,71,19,183,12,218,192,109,113,180,25,92,29,75,77,169,177,91,18,134,62,96,20,116,37,18,185,154,99,29,200,189,254,201,232,77,205,108,209,110,94,72,25,93,117,132,24,234,210,107,107,98,219,253,46,147,30,216,197,123,20,123,144,7,27,59,54,121,148,186,89,33,157,203,249,245,64,246,3,56,118,138,59,134,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess18EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess18 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("89638d77-6af1-48e7-9424-9269f349d9f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac62368d-b0c1-4382-b88d-af329d6e349a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess18",
				Position = new Point(322, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 131),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess18;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSearchComboBoxEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a85fc2b0-f525-4c38-a3c3-8f57cee8b88e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89638d77-6af1-48e7-9424-9269f349d9f4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SearchComboBoxEditChange",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"SearchComboBoxEditChange",
				Position = new Point(36, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSearchComboBoxEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("95f6c153-90da-43eb-a0cf-5ebbc79fed83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89638d77-6af1-48e7-9424-9269f349d9f4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptSearchComboBoxEditChange",
				Position = new Point(134, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,77,44,74,206,8,75,204,41,77,85,176,85,8,72,76,79,213,11,6,11,57,231,231,38,229,59,229,87,184,166,100,150,0,133,114,82,147,75,82,83,60,75,82,115,245,192,138,173,185,138,82,75,74,139,242,20,74,138,128,28,0,179,131,18,14,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("75cd0029-9251-4979-a1ad-5c8d41341d62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess15",
				Position = new Point(379, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(264, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddSelectedRecordButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("39fdd587-da9a-443f-81a7-06583e2526dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75cd0029-9251-4979-a1ad-5c8d41341d62"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddSelectedRecordButtonClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"AddSelectedRecordButtonClick",
				Position = new Point(43, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddSelectedRecordButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d951a50a-60fe-4506-8ee7-740aff3716e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("75cd0029-9251-4979-a1ad-5c8d41341d62"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptAddSelectedRecordButtonClick",
				Position = new Point(155, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,81,107,219,48,16,126,174,193,255,65,203,67,177,33,136,61,111,75,199,72,186,18,40,165,212,105,251,48,246,160,88,151,86,195,150,202,73,78,8,163,255,125,39,201,110,157,57,238,40,236,197,88,210,119,223,125,119,223,73,106,195,178,107,241,0,124,133,0,23,168,36,47,160,130,210,129,188,50,18,44,159,155,70,59,54,155,177,143,57,251,157,38,39,8,174,65,205,28,54,240,57,77,158,211,100,43,144,217,54,228,6,74,131,210,46,132,19,133,105,176,4,54,99,217,10,16,133,53,27,199,111,151,252,30,214,115,163,29,154,202,83,183,63,119,10,93,35,170,215,176,60,40,242,31,143,17,74,3,242,239,74,203,110,135,162,178,73,49,150,116,50,13,242,114,210,151,38,214,161,210,15,204,150,143,80,139,219,165,244,138,2,123,17,118,46,149,117,231,82,57,210,96,213,186,2,118,122,202,142,29,47,29,212,93,51,206,124,47,190,166,201,49,92,39,202,227,249,157,168,26,96,159,34,225,171,190,54,134,196,240,149,41,130,190,204,139,109,165,62,161,170,5,238,231,166,106,106,125,37,106,223,196,227,12,252,186,15,229,30,59,160,89,40,251,84,137,247,176,29,68,116,164,125,151,67,89,214,55,114,161,74,167,140,166,160,47,49,235,148,153,245,47,2,157,229,197,1,152,24,226,1,219,250,53,45,207,181,83,110,207,208,236,104,49,206,19,241,62,126,99,16,68,249,152,121,37,154,70,147,41,205,222,24,220,118,90,205,142,116,142,142,39,159,19,167,131,27,179,11,6,120,56,177,184,88,122,80,158,13,220,152,134,236,209,91,251,99,112,252,243,31,68,3,63,142,242,13,80,145,118,188,144,111,82,102,148,52,160,20,93,233,15,135,102,81,147,246,23,224,162,146,183,245,247,102,146,92,104,90,199,242,216,207,147,109,231,189,134,29,27,183,45,182,179,69,7,113,255,163,252,62,223,228,229,70,211,117,127,249,143,176,191,106,247,240,119,212,28,147,4,166,231,240,194,141,119,253,210,8,73,195,99,67,185,253,151,241,15,79,206,47,128,86,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6fdb38e6-8acb-48f8-bcf5-ef744d998ec1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess10",
				Position = new Point(287, 315),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSearchButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1c6789a5-e6ad-4ee8-9983-83ee68cc69f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fdb38e6-8acb-48f8-bcf5-ef744d998ec1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SearchButtonClick",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"SearchButtonClick",
				Position = new Point(29, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSearchButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ed1d1b12-be19-4497-bae9-3dd1e76d8cae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fdb38e6-8acb-48f8-bcf5-ef744d998ec1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptSearchButtonClick",
				Position = new Point(127, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,41,74,77,117,47,202,76,209,115,206,73,77,44,210,208,180,230,202,76,83,208,240,44,14,203,44,42,41,77,204,241,205,79,73,213,84,168,230,226,44,75,44,82,40,131,136,185,36,150,36,6,231,151,22,37,167,42,216,42,184,167,150,132,161,11,131,76,225,196,80,172,231,147,159,152,18,148,95,94,12,146,174,85,72,205,41,78,5,25,28,0,114,5,46,85,92,69,169,37,165,69,121,10,37,69,165,169,214,0,77,29,7,225,176,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4fe56de6-6000-4798-8e48-f393f20576bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a0b1ecde-d8fb-4019-a3b9-3c34930a314d"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess11",
				Position = new Point(287, 182),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(223, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSchemaListEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6506e319-c0ba-43bb-b829-08c1820ea3ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4fe56de6-6000-4798-8e48-f393f20576bc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SchemaListEditChange",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"SchemaListEditChange",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSchemaListEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("71bd9f29-a978-46db-9200-2c5d74070efd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4fe56de6-6000-4798-8e48-f393f20576bc"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptSchemaListEditChange",
				Position = new Point(119, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,82,203,110,219,48,16,60,39,64,254,129,240,37,18,18,240,7,250,0,28,197,8,132,56,128,17,197,237,121,45,174,29,54,20,169,46,201,164,110,225,127,47,73,89,15,59,39,73,171,217,217,153,217,93,193,14,249,29,88,124,66,107,195,251,10,52,42,94,40,4,202,242,47,87,151,239,64,76,128,131,202,120,170,145,125,99,171,216,112,63,84,2,196,58,146,122,199,108,253,138,13,172,75,209,131,170,84,88,74,235,22,66,58,94,161,194,218,161,40,29,54,252,7,40,31,123,59,96,24,86,191,38,80,1,173,147,70,7,138,142,149,47,154,214,237,79,129,133,105,54,230,206,252,233,26,162,210,72,105,147,220,106,111,151,198,188,249,54,201,120,240,82,156,50,188,16,226,3,133,234,232,112,116,199,11,79,132,218,85,142,124,237,60,225,4,149,101,247,178,142,210,128,246,95,59,109,183,204,108,126,5,75,223,243,222,90,114,101,243,73,155,220,178,108,8,134,47,126,123,80,54,155,90,203,115,246,239,234,242,130,48,204,211,44,12,142,169,28,78,84,85,147,96,53,126,36,87,35,105,191,164,54,216,235,147,159,219,54,62,25,88,246,130,68,96,205,214,241,117,201,127,226,166,48,218,145,81,150,71,64,104,45,181,116,18,148,252,139,227,78,207,99,24,156,196,25,124,109,113,69,102,43,21,118,210,227,112,160,157,61,170,59,254,123,196,253,226,61,144,204,195,159,212,127,17,49,60,148,227,110,123,241,177,158,72,71,25,199,254,44,194,111,83,32,169,123,146,71,105,143,152,103,4,129,49,149,109,72,21,207,81,159,24,35,207,129,97,128,70,221,135,201,225,146,108,93,160,153,9,83,251,38,136,230,78,58,21,211,188,158,177,27,246,105,21,195,149,222,176,217,245,108,56,206,68,243,4,58,124,16,159,11,209,21,178,142,254,236,210,150,6,196,179,249,232,162,153,46,255,63,44,191,7,197,144,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProcessLookupGridPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProcessLookupGridPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("632bfb6a-6c76-4cb1-9517-6043da74711e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df8919a1-c30f-42d3-a8d1-c0298b6c8156"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ProcessLookupGridPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(445, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProcessLookupGridPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartLookupGridPagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("23c2c673-ec8a-46b0-bda9-40bcebdd8aa8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("632bfb6a-6c76-4cb1-9517-6043da74711e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"StartLookupGridPagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLookupGridPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1401fc1b-a4ba-45b6-a142-52e0845e9db3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("632bfb6a-6c76-4cb1-9517-6043da74711e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptLookupGridPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,86,75,115,26,57,16,62,219,85,254,15,242,28,226,153,132,26,188,91,149,203,178,120,43,60,236,80,193,143,50,56,151,205,30,196,168,1,197,66,162,244,48,166,108,254,123,90,210,0,195,35,181,28,160,104,117,127,253,245,215,221,163,169,215,7,96,191,115,109,29,21,29,106,233,64,57,93,192,53,23,22,180,73,179,198,217,233,3,157,64,62,0,170,139,105,151,113,155,223,210,215,62,200,137,157,146,38,249,243,243,229,218,163,77,101,1,162,229,172,85,18,255,204,45,87,18,61,124,200,173,98,64,254,33,109,161,12,172,79,254,34,49,160,252,191,70,185,255,86,34,124,229,140,65,21,0,61,94,168,38,83,206,160,101,165,193,147,16,112,3,246,129,106,58,3,228,251,157,10,7,105,18,92,2,138,73,124,1,35,165,4,169,24,49,116,131,114,222,36,210,9,225,217,41,249,2,218,230,67,213,66,127,160,50,93,59,161,105,96,53,151,147,52,203,144,247,152,10,227,217,84,17,223,155,190,156,22,120,178,173,229,221,83,47,40,231,249,218,229,60,88,61,217,167,30,243,201,135,251,38,106,72,135,23,94,6,170,151,127,223,56,206,106,85,131,9,201,107,196,31,92,93,33,238,217,105,159,27,27,28,175,8,3,75,185,24,44,205,160,152,194,140,198,20,168,202,157,242,178,57,1,157,232,176,62,13,204,8,126,130,44,5,149,183,84,34,145,190,82,207,110,142,161,79,6,52,106,33,33,228,207,59,173,1,20,78,115,187,236,202,9,151,65,112,44,181,251,138,86,11,247,115,208,212,251,165,73,123,23,201,36,181,125,168,182,211,26,164,245,214,188,199,178,80,8,31,147,180,162,5,105,54,67,153,121,119,54,183,75,242,225,3,73,15,5,44,91,246,254,126,32,110,222,86,78,90,239,113,153,145,88,37,122,85,26,181,177,29,170,134,177,18,109,210,164,97,174,182,187,144,71,23,196,175,96,98,100,172,19,57,159,239,115,62,223,83,53,139,97,1,183,36,226,147,105,37,250,116,169,156,245,195,14,105,20,36,54,155,168,57,200,24,252,160,85,1,198,124,131,37,54,39,141,199,217,239,70,255,88,88,216,129,18,182,112,198,170,89,88,68,214,125,1,175,213,255,98,30,196,84,1,69,72,118,163,57,243,225,187,192,209,37,239,153,59,108,215,189,14,242,164,7,104,25,238,94,210,63,2,147,224,174,29,120,55,226,200,156,31,197,62,86,61,174,236,219,217,233,73,73,247,57,168,24,186,117,7,11,255,155,102,149,245,70,244,147,176,90,106,244,19,135,246,138,56,156,213,141,30,126,177,36,44,72,213,35,198,236,186,229,95,24,59,206,197,251,238,45,197,0,143,240,215,143,219,191,200,238,63,204,177,139,214,216,178,55,133,230,115,175,108,210,125,181,121,208,35,142,153,206,113,3,23,92,50,181,168,145,139,17,140,149,6,39,133,162,236,162,70,198,78,134,84,41,42,65,126,232,31,50,33,159,16,243,36,241,66,198,160,220,179,5,141,14,213,243,157,179,124,8,90,83,163,198,54,255,242,147,190,222,130,157,42,92,154,225,84,171,69,91,112,164,18,248,164,23,24,125,124,122,63,145,4,217,132,115,15,255,251,201,169,56,62,151,113,89,99,85,50,11,177,201,42,107,36,94,152,120,55,5,89,214,74,160,248,209,144,70,185,188,232,171,179,211,122,157,104,96,78,50,42,109,141,140,160,160,40,51,25,81,252,154,32,7,50,199,96,66,133,6,202,150,132,226,221,195,136,157,114,83,106,142,241,31,195,220,173,111,163,157,169,218,244,5,183,231,17,38,56,30,160,135,26,192,23,215,25,9,148,167,120,94,115,138,115,27,230,53,171,180,22,59,54,163,54,206,161,111,240,219,229,202,247,244,162,240,177,213,38,130,192,212,111,228,237,143,21,89,173,106,129,99,182,149,162,82,124,76,116,29,112,211,42,124,141,236,222,180,177,123,189,78,173,172,35,11,138,125,172,123,205,110,142,188,27,224,198,244,113,178,30,213,34,222,37,245,122,249,134,32,112,164,129,61,66,161,52,51,190,118,132,198,215,134,205,85,200,76,137,181,190,187,67,227,227,83,23,27,119,141,227,86,62,22,211,100,15,109,155,61,201,252,117,121,64,170,124,46,108,83,148,23,123,236,211,198,188,203,28,199,66,131,117,90,18,171,29,52,126,1,24,208,255,4,11,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fc2cfcc5-b369-4bfa-aba6-a12d9b2727b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("632bfb6a-6c76-4cb1-9517-6043da74711e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"IntermediateThrowMessageEventPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask145646456ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0ddff2e5-06c5-44d4-b50f-d4f5a8624e4d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("632bfb6a-6c76-4cb1-9517-6043da74711e"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptTask145646456",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLookupGridPageDataSourceBeforeLoadEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaLookupGridPageDataSourceBeforeLoadEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("67feede2-a697-4221-bba0-e8fd7dc0f8c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f31acac-08de-4425-acda-1578d43b6d52"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"LookupGridPageDataSourceBeforeLoadEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLookupGridPageDataSourceBeforeLoadEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLookupGridPageDataSourceBeforeLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f093043-7d71-4fda-8120-9d51a1971ce5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67feede2-a697-4221-bba0-e8fd7dc0f8c1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeLoad",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"LookupGridPageDataSourceBeforeLoadStartMessage",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLookupGridPageDataSourceBeforeLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bce6af46-ae32-41d3-9a48-5ccf1af6f8e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("67feede2-a697-4221-bba0-e8fd7dc0f8c1"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"LookupGridPageDataSourceBeforeLoadScriptTask",
				Position = new Point(204, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,110,131,48,12,134,207,228,41,204,165,162,151,84,59,35,14,91,233,164,93,40,18,79,16,5,183,139,4,9,114,146,73,104,226,221,23,160,91,7,99,61,112,192,177,191,255,147,125,56,64,133,14,12,213,72,80,43,66,233,148,209,112,49,4,29,169,86,80,31,170,182,107,68,15,210,52,190,213,44,23,78,84,198,147,196,202,145,151,206,19,130,244,68,168,221,189,144,65,41,174,200,239,189,252,184,106,73,153,117,164,244,245,27,127,156,232,133,104,199,225,53,143,151,179,75,190,238,77,153,186,64,18,87,19,138,191,217,194,55,205,153,78,109,231,250,228,15,120,191,135,79,22,109,248,207,45,75,147,45,139,249,197,242,87,165,235,151,126,68,110,132,164,44,26,157,150,176,56,3,29,212,96,183,91,166,240,243,184,248,252,103,239,89,6,203,10,47,140,198,201,59,10,55,65,33,223,33,249,16,116,59,6,40,253,175,229,60,52,185,200,205,172,248,65,86,20,17,6,152,134,64,13,75,14,255,3,155,191,199,250,107,226,179,149,168,235,112,155,116,123,180,52,86,221,38,159,66,203,192,6,246,59,248,11,116,70,148,228,158,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess20EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess20 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("74aa1db8-cbd7-4f0b-a91c-cc13744076a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df8919a1-c30f-42d3-a8d1-c0298b6c8156"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcess20",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(498, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(213, 114),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess20;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStopPageMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5fcddaa7-68e6-45b3-9594-65e3e3aebc56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74aa1db8-cbd7-4f0b-a91c-cc13744076a4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"StopPageMessage",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"StopPageMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptStopPageMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9cc9ef8a-6a29-4a0f-ae6e-c5a2c209f991"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74aa1db8-cbd7-4f0b-a91c-cc13744076a4"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptStopPageMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,80,177,10,194,64,12,221,5,255,225,232,212,194,113,85,215,78,90,151,138,138,160,224,28,109,208,131,107,174,228,210,161,150,254,187,45,118,116,211,237,189,151,151,228,241,210,244,4,15,52,231,59,219,90,14,64,3,97,179,46,203,143,16,71,221,162,55,1,101,107,3,220,28,150,113,183,236,181,234,86,125,146,69,90,125,86,17,248,254,204,61,9,123,183,135,214,55,98,114,103,145,164,216,106,181,11,158,6,11,91,112,246,133,177,112,131,201,119,53,201,230,179,95,179,108,26,17,79,225,63,97,210,159,171,201,125,85,121,250,99,53,27,8,120,192,16,6,124,2,66,55,198,153,120,124,5,38,75,15,173,142,94,10,193,106,200,85,59,104,167,177,86,19,184,180,53,154,201,59,222,101,148,134,73,141,127,178,55,30,167,175,227,13,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessBaseInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessBaseInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4fb5150e-af4b-4947-85ac-d059b5156bfa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ac62368d-b0c1-4382-b88d-af329d6e349a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcessBaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 143),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(360, 131),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessBaseInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3e4c2f98-d287-434c-b26f-8d5881230bee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4fb5150e-af4b-4947-85ac-d059b5156bfa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"Init",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("28d7619a-3e4e-4d99-809c-ce4b51d3fc43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4fb5150e-af4b-4947-85ac-d059b5156bfa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fcf1307d-5e29-4691-b137-87ecfb8cc21a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4fb5150e-af4b-4947-85ac-d059b5156bfa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = Guid.Empty,
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,85,77,79,27,49,16,61,47,18,255,193,228,80,237,170,200,226,30,130,68,9,133,168,41,77,9,164,7,132,144,217,157,4,139,141,157,218,222,208,20,229,191,119,236,245,126,36,107,122,32,14,158,153,247,222,124,57,107,166,200,138,45,128,12,200,4,15,122,174,87,246,36,76,147,59,80,138,105,57,55,244,126,68,127,193,243,133,20,70,201,92,83,235,208,63,60,224,115,18,31,217,88,58,210,19,169,205,23,150,190,146,79,159,28,28,189,215,48,81,114,206,115,72,200,123,116,120,16,173,145,136,169,133,70,34,1,111,196,27,191,193,230,114,13,194,156,163,37,78,16,52,178,62,20,175,247,4,209,91,248,93,128,54,244,103,1,106,51,53,138,139,197,67,79,167,47,176,100,247,163,172,247,104,99,249,60,174,195,143,144,167,200,243,4,175,163,82,164,224,134,179,156,255,173,132,57,223,164,143,226,182,225,100,80,185,23,206,245,140,43,83,176,252,187,204,96,194,20,91,130,1,85,73,188,2,83,223,205,88,94,64,220,27,181,3,122,73,41,142,196,31,224,84,90,29,95,180,19,139,28,207,82,230,88,115,165,225,131,120,122,39,203,130,196,137,99,114,84,59,40,30,217,229,178,110,174,109,71,225,143,105,85,59,144,202,44,228,95,166,84,50,133,1,119,115,138,162,32,12,210,6,163,91,25,149,60,219,154,237,72,59,3,182,233,6,225,127,168,203,229,202,108,226,32,122,82,147,151,49,4,143,34,53,133,130,146,218,35,125,149,106,201,76,157,232,88,202,215,98,117,165,120,102,43,242,244,126,178,125,170,227,122,199,36,204,212,239,36,57,173,98,144,8,151,65,161,179,128,212,112,41,232,20,180,198,115,200,12,123,104,75,122,108,229,106,63,240,111,75,202,209,12,116,211,245,107,10,76,165,47,126,51,199,108,35,11,67,175,121,150,129,64,90,132,182,123,218,238,186,229,156,202,66,165,224,247,112,182,127,31,87,83,56,68,143,94,199,220,179,186,250,21,253,157,2,176,149,178,115,115,43,223,80,199,156,47,174,153,200,114,187,29,22,38,131,28,22,204,64,220,188,38,23,82,1,189,20,6,215,17,116,249,101,67,148,124,179,15,69,20,185,18,248,126,173,20,95,50,181,185,144,121,177,20,55,56,149,40,9,29,233,212,173,61,157,180,205,212,218,251,255,137,119,227,76,6,145,5,64,185,173,203,184,195,147,116,6,208,214,48,117,233,249,194,53,37,169,19,143,187,124,73,165,72,1,54,89,120,8,7,233,170,216,105,11,29,75,150,33,47,130,146,207,131,22,203,83,99,208,225,72,251,213,191,146,123,161,45,75,221,58,251,97,231,134,113,129,47,72,253,182,159,103,89,220,129,118,53,104,254,109,70,59,131,121,123,206,3,154,90,14,213,35,216,14,162,101,173,52,158,133,48,100,48,32,39,126,254,194,94,57,206,187,111,201,222,91,214,214,17,92,67,252,69,27,115,109,78,135,220,109,33,246,233,180,28,147,99,255,16,156,157,57,92,156,141,206,212,215,40,113,136,241,120,167,14,78,221,54,234,172,72,131,54,202,130,181,26,13,63,158,8,200,108,75,187,128,165,173,239,126,194,252,136,185,173,255,7,150,40,90,161,215,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptGetDataSourceSchemaUIdScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("311f8c47-7661-496f-b579-f7e81b863e8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4fb5150e-af4b-4947-85ac-d059b5156bfa"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptGetDataSourceSchemaUId",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(71, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,77,107,194,64,16,134,207,13,228,63,76,61,72,246,178,63,160,34,133,214,15,114,176,10,98,239,67,50,213,133,100,34,179,179,150,32,254,119,215,8,221,214,67,175,239,206,243,188,51,123,66,1,95,29,168,197,93,89,111,80,176,133,41,20,94,197,241,222,108,112,79,118,73,58,228,164,36,159,216,4,42,70,63,192,200,76,242,108,25,92,157,28,17,191,211,182,244,31,161,105,214,50,111,143,218,23,127,75,12,188,194,141,179,195,35,188,0,211,247,16,60,206,69,191,251,130,148,194,243,244,55,56,30,195,176,228,12,21,183,93,144,138,236,54,109,242,48,154,103,79,59,79,242,222,49,83,165,174,99,59,103,117,218,223,137,21,114,52,137,93,56,174,75,246,138,92,209,91,31,61,169,220,220,218,57,30,101,224,28,101,255,52,167,255,136,7,92,242,76,72,131,48,168,4,154,92,1,123,100,245,71,115,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildBasePrepareFiltersEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildBasePrepareFilters = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1df995fe-1789-4bdd-adda-2bc487a0d914"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f31acac-08de-4425-acda-1578d43b6d52"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"EventSubProcessChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(357, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(233, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildBasePrepareFilters;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildBasePrepareFiltersStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1ca6adaa-58dd-4745-8b46-0604e881b901"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1df995fe-1789-4bdd-adda-2bc487a0d914"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BasePrepareFilters",
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"StartMessageChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildBasePrepareFiltersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2fa4914a-39fd-4a7b-8d0d-107080ad121e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1df995fe-1789-4bdd-adda-2bc487a0d914"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Name = @"ScriptChildBasePrepareFilters",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,83,203,110,156,48,20,93,151,175,112,88,65,132,137,121,14,104,212,69,108,32,26,169,74,162,78,163,46,170,46,44,112,19,75,140,153,26,147,106,20,229,223,107,135,204,192,76,34,53,187,238,240,189,231,156,123,238,131,139,115,235,145,74,48,244,76,174,26,240,25,220,233,15,210,9,193,106,197,59,225,147,65,74,38,148,137,250,171,102,249,130,173,59,161,104,173,254,5,39,123,216,200,106,216,166,51,241,94,179,4,251,3,174,6,222,252,248,9,158,172,79,251,151,99,7,56,198,121,20,38,48,77,9,129,69,21,4,48,199,225,37,68,40,40,82,84,230,81,70,82,219,245,230,148,50,200,113,84,166,25,172,162,20,195,32,14,16,204,211,60,130,33,34,85,132,50,66,74,18,157,80,210,56,209,137,40,129,152,196,24,150,72,87,201,210,96,97,170,36,73,129,226,40,68,177,237,90,207,75,139,255,2,206,217,193,248,216,17,23,189,51,78,203,117,141,123,201,212,32,5,80,114,96,75,235,121,108,149,42,186,238,6,89,51,221,235,45,189,103,126,113,136,140,195,232,53,188,214,60,3,152,208,251,241,173,247,217,105,114,21,111,149,182,112,77,55,134,98,23,83,200,126,3,58,214,172,184,104,94,19,87,178,27,182,120,103,68,156,19,81,119,108,118,174,114,166,247,52,180,237,75,147,7,191,254,107,214,255,170,145,143,71,50,174,105,255,216,198,68,35,146,81,197,230,62,78,29,120,224,75,119,207,107,218,222,108,153,164,230,154,244,24,120,173,252,27,169,149,103,96,255,178,105,156,247,149,191,115,245,112,75,165,86,51,64,103,54,133,117,253,192,54,212,3,35,142,116,155,45,149,188,239,196,183,221,150,249,229,239,129,182,30,176,71,169,6,239,108,111,58,114,247,127,84,159,142,53,12,73,146,196,72,255,13,57,14,96,156,151,21,204,74,188,128,139,48,214,151,191,200,202,100,65,108,247,35,38,87,253,181,94,231,136,120,207,220,204,128,145,123,187,114,35,122,180,239,243,11,107,126,253,127,1,14,166,148,64,75,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetControlsVisibleMethod());
			Methods.Add(CreateCreateLookupEntityMethod());
			Methods.Add(CreateInitializeDataSourceCurrentStructureMethod());
			Methods.Add(CreateInitializeSelectedRecordsDataSourceCurrentStructureMethod());
			Methods.Add(CreateDataSource_PrepareFiltersMethod());
			Methods.Add(CreateGetDeafaultLookupEditSchemaIdMethod());
			Methods.Add(CreateGetVirtualDataSourceStructureMethod());
			Methods.Add(CreateGetVirtualDataSourceDataMethod());
			Methods.Add(CreateGetVirtualDataSourceMethod());
			Methods.Add(CreateDataSource_LoadingRowsMethod());
			Methods.Add(CreateDataSource_DataRequestMethod());
			Methods.Add(CreateGetNotModuleDetailSchemaIdsMethod());
			Methods.Add(CreateTreeGridConfigHandlerMethod());
			Methods.Add(CreateSetVirtualDataSourceFiltersMethod());
			Methods.Add(CreateGetShowColumnsMethod());
			Methods.Add(CreateCanBeEditByNUIMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("041f8571-1e0d-4d76-9587-98645fd79cea"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dc00bb50-26d4-4608-809c-73585d9eebd9"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = base.CreateGetEditPagesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,72,74,44,78,213,115,79,45,113,77,201,44,9,72,76,79,45,214,208,180,230,229,202,76,83,208,128,40,209,115,206,47,205,3,42,180,85,48,80,80,83,83,128,41,11,245,76,1,137,185,151,102,166,232,185,230,22,148,84,106,42,84,243,114,113,162,72,43,0,141,117,73,77,76,75,4,26,227,147,159,159,93,90,0,146,14,78,206,72,205,77,244,76,1,219,195,233,145,88,236,95,158,7,211,6,212,83,82,84,154,10,148,168,229,229,42,74,45,41,45,202,131,186,212,26,0,83,195,192,240,181,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,91,111,219,54,20,126,246,128,253,7,150,15,149,212,121,114,246,186,44,5,18,39,205,140,53,107,80,39,205,67,19,12,180,116,28,43,145,73,143,164,226,24,134,254,251,14,41,235,46,171,89,138,97,47,185,144,231,124,231,59,119,106,244,46,154,19,247,205,89,24,233,11,17,130,71,182,63,254,48,120,98,146,168,64,70,43,77,142,136,210,50,226,247,254,88,240,128,105,151,174,35,30,138,181,127,5,82,50,37,230,218,63,126,96,207,23,160,23,34,84,254,213,66,138,245,56,142,128,235,179,39,252,225,58,116,72,38,92,105,198,3,184,158,132,67,66,157,33,113,62,10,241,152,172,62,67,32,100,56,133,24,2,13,161,227,29,82,239,16,141,75,208,137,228,185,217,15,66,46,141,89,195,114,123,144,250,44,208,209,19,124,22,107,100,186,37,219,95,82,146,166,104,227,146,221,131,127,202,52,155,138,68,6,224,103,28,38,167,195,157,31,6,57,37,16,43,32,219,119,163,157,139,98,5,220,40,94,50,201,150,160,65,42,116,151,195,154,156,70,104,69,112,38,55,191,101,52,134,68,204,30,144,230,123,55,11,208,96,176,165,159,80,27,100,238,220,36,204,89,92,74,17,128,82,126,197,237,116,56,24,24,173,20,89,236,108,255,157,128,220,76,45,248,75,204,103,191,11,243,91,42,109,240,74,171,29,190,147,159,8,45,227,229,223,131,190,148,209,18,81,199,34,78,150,252,11,139,19,112,61,154,14,51,68,212,137,244,102,26,44,96,201,174,13,112,35,3,14,134,223,233,48,87,104,120,57,146,150,0,231,50,202,216,245,161,92,237,4,11,202,5,196,116,163,176,28,147,24,76,97,246,225,168,186,160,151,162,190,9,243,0,79,163,249,198,156,214,83,236,182,179,62,236,206,134,87,102,75,205,118,169,201,100,78,146,40,14,65,186,182,94,205,189,222,172,32,55,133,145,152,54,122,39,39,109,10,24,211,48,78,148,22,75,19,66,215,49,154,147,240,47,7,147,133,197,92,79,87,53,79,123,84,51,145,63,145,177,227,121,190,132,85,204,2,112,71,63,143,176,102,28,60,202,35,125,28,134,39,137,214,130,87,58,99,95,221,212,188,234,113,230,123,233,190,154,155,154,249,199,43,204,98,232,210,114,12,153,180,222,216,217,228,210,194,3,53,27,179,56,158,177,224,177,63,127,60,137,227,236,10,229,168,249,143,230,87,193,14,160,188,158,39,220,246,167,187,230,97,54,133,14,236,20,202,53,178,9,105,36,81,128,54,8,59,180,233,194,151,8,214,214,93,166,86,207,120,59,248,150,2,14,81,123,100,70,226,85,17,84,44,59,114,116,68,206,19,108,167,179,229,74,111,118,163,162,13,85,57,130,178,102,253,43,145,185,232,122,77,41,171,104,104,229,19,180,126,221,89,252,22,35,237,38,94,57,250,154,157,204,132,136,73,164,62,68,82,153,74,211,50,1,115,60,23,18,88,176,32,174,9,235,42,111,76,18,241,61,13,155,49,51,113,217,97,229,211,186,132,158,51,244,192,250,87,117,166,139,165,101,95,189,184,229,183,122,203,209,214,175,164,21,200,142,216,22,124,253,63,96,243,2,121,58,108,31,145,39,211,77,133,61,187,170,75,92,219,106,254,84,51,169,213,77,164,23,22,149,188,125,75,106,166,201,27,172,196,98,93,116,95,99,12,205,202,182,27,0,133,188,118,84,156,238,160,52,200,244,208,60,227,225,255,69,146,166,180,171,28,111,245,93,187,221,242,236,103,21,119,15,217,118,187,96,28,255,150,88,63,215,10,36,62,133,56,216,17,224,159,131,174,73,184,244,178,169,132,68,153,34,173,227,188,131,43,157,99,188,108,245,111,157,8,50,104,177,50,36,242,199,198,201,6,113,170,152,153,131,181,140,229,234,254,77,20,234,69,217,247,227,36,198,151,23,76,248,92,224,227,5,237,70,140,235,221,97,123,38,216,64,13,246,131,255,14,209,253,66,127,23,122,59,101,102,48,236,157,135,229,81,57,206,95,33,155,111,140,74,223,151,83,221,212,226,81,129,209,18,117,246,221,180,31,29,95,219,15,200,187,230,12,254,55,22,232,97,81,204,29,30,224,38,242,31,45,247,194,143,195,114,139,180,217,153,231,190,102,17,87,40,232,210,113,44,20,92,224,163,22,101,168,87,41,204,160,114,241,105,246,128,240,93,142,214,212,239,138,17,209,84,198,234,55,201,200,251,186,137,143,224,13,141,74,184,14,179,49,223,64,245,63,2,191,215,11,242,158,28,228,168,221,225,57,123,214,190,253,96,201,91,10,183,251,46,156,157,42,89,16,119,86,187,32,241,245,53,3,179,190,18,30,11,22,226,71,79,241,106,64,38,102,147,208,30,109,187,217,95,244,129,229,245,193,24,51,184,178,204,175,23,126,174,245,249,76,139,202,233,179,57,236,187,116,122,46,171,121,123,37,4,94,165,253,241,72,237,71,166,185,182,66,105,190,44,190,249,80,169,191,125,235,111,194,97,229,153,89,237,224,230,236,249,175,62,112,103,141,177,49,26,165,255,0,59,126,237,116,214,15,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyCopyPageParametersMethod() {
			SchemaMethod method = base.CreateModifyCopyPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,44,77,45,170,12,46,41,202,204,75,15,72,44,74,204,77,45,73,45,42,214,11,74,205,205,47,75,213,80,10,174,44,246,205,79,41,205,73,117,77,201,44,241,76,81,210,180,6,0,51,222,222,182,48,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateCreateContextMenuMethod() {
			SchemaMethod method = base.CreateCreateContextMenuMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,179,6,0,7,133,17,243,7,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterTreeGridDblClickScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,148,79,79,194,48,24,135,207,44,217,119,40,92,24,132,148,63,241,96,66,60,32,32,146,176,196,0,234,185,172,239,160,50,90,210,190,3,9,217,119,183,219,0,69,61,162,198,203,146,54,91,223,231,247,236,183,137,144,120,125,46,208,87,28,42,100,239,58,5,13,24,107,73,102,204,0,29,0,142,97,46,12,130,158,106,128,129,22,188,55,139,186,145,8,150,147,64,139,53,122,28,66,22,71,152,175,42,109,215,73,136,8,9,241,124,187,41,38,16,65,240,225,232,13,211,196,100,119,146,27,98,80,11,57,167,93,37,3,134,94,105,43,36,87,91,58,5,173,153,81,33,210,206,11,123,245,1,23,138,27,58,93,104,181,181,99,65,98,127,99,47,207,2,23,62,51,75,175,92,170,145,161,52,200,100,0,143,67,94,35,165,114,141,148,59,156,231,163,129,143,33,80,154,223,198,136,74,102,220,229,74,187,148,114,22,62,131,220,41,189,74,65,44,190,183,111,36,148,5,40,54,48,86,91,203,190,39,251,102,66,146,196,78,123,96,115,160,61,134,108,162,98,29,0,205,169,134,189,218,33,89,118,246,193,97,190,147,73,129,200,192,175,58,24,41,181,140,215,121,252,163,140,83,246,52,99,113,104,158,132,198,152,69,239,47,232,71,165,36,223,137,113,157,122,157,52,175,104,227,154,182,26,205,150,93,86,197,229,43,233,58,151,247,255,159,188,127,209,94,173,187,206,209,117,241,92,246,159,10,58,130,94,220,194,241,11,76,131,23,210,210,37,167,248,217,227,249,31,194,216,160,168,85,52,98,59,21,35,189,23,156,131,60,235,224,89,185,242,2,159,170,117,14,223,95,173,113,151,187,126,3,132,208,73,210,101,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateFillPrintMenuMethod() {
			SchemaMethod method = base.CreateFillPrintMenuMethod();
			method.IsOverride = true;
			return method;
		}

		protected virtual SchemaMethod CreateSetControlsVisibleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("15b0c2e6-b455-486c-bc49-7671d8014840"),
				Name = "SetControlsVisible",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,202,76,83,208,112,77,201,44,241,205,79,73,213,84,168,230,229,226,4,137,4,36,166,167,234,57,149,150,148,228,231,21,59,231,231,149,20,229,231,248,36,86,230,151,150,232,121,100,166,164,164,230,65,84,114,226,86,22,156,90,18,150,89,156,153,148,147,170,81,82,84,154,170,105,13,84,94,11,53,92,17,172,205,223,27,162,17,139,137,112,41,36,83,210,18,115,138,225,198,212,42,164,2,121,112,215,42,82,211,185,40,22,33,2,131,68,231,34,123,186,86,75,159,151,11,167,74,69,120,232,3,149,243,114,1,0,48,188,74,40,146,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateLookupEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a26aaa4a-cf82-4b82-8a0b-7971ad04ff23"),
				Name = "CreateLookupEntity",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Entity"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("45e5ed84-6018-4a8c-a717-11eea3ffa56c"),
				Name = "lookupSchema",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff9f28f0-fcdf-4ff6-a81b-4afe505cbb92"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,81,203,78,195,48,16,60,167,82,255,193,234,201,185,248,7,170,30,32,13,40,82,15,133,170,112,54,201,150,90,141,109,88,219,64,132,248,119,54,118,210,16,36,191,246,49,179,179,222,210,120,229,59,214,90,123,9,111,101,50,54,131,121,168,207,160,165,40,16,164,135,20,227,71,7,88,88,99,160,246,202,154,124,189,92,124,72,28,243,161,37,55,193,13,124,178,100,252,207,95,46,50,81,216,54,104,195,211,37,110,156,7,84,238,194,243,24,188,67,171,249,234,208,185,93,164,92,69,231,243,25,16,162,55,169,72,194,142,85,19,195,153,168,92,249,30,100,203,251,186,15,1,176,219,75,148,26,136,152,223,7,213,8,50,29,112,55,162,242,60,103,210,13,10,169,131,224,148,121,101,188,111,164,121,41,191,160,14,222,34,181,49,215,46,74,227,2,194,246,118,114,145,102,246,77,10,6,2,210,231,65,139,173,244,82,84,253,249,8,178,1,34,157,158,155,217,87,137,84,12,82,144,79,197,7,222,76,157,24,159,208,162,191,198,154,89,246,119,102,98,103,41,52,165,246,131,161,148,235,63,86,205,181,244,0,216,163,210,18,187,52,133,39,217,6,136,144,31,58,104,211,66,240,1,205,12,180,254,5,248,255,47,196,46,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeDataSourceCurrentStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1828e1d4-93f1-445b-9f64-5864498536e1"),
				Name = "InitializeDataSourceCurrentStructure",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,89,223,111,219,54,16,126,118,128,252,15,140,31,10,9,53,136,62,47,77,138,216,241,58,15,105,227,205,73,251,204,72,116,76,76,150,60,146,90,226,14,254,223,119,252,33,155,20,41,199,78,87,12,123,113,98,242,120,247,221,241,120,247,145,190,97,66,190,23,146,179,242,241,18,137,69,245,52,170,138,122,89,10,116,129,62,82,57,219,13,36,233,249,233,201,95,132,163,156,72,50,171,106,158,81,144,153,146,71,138,175,183,35,86,68,100,11,186,36,48,189,147,197,51,61,6,2,108,142,18,35,128,167,156,45,9,95,27,11,232,226,2,149,117,81,164,232,239,211,147,158,92,240,234,9,149,244,9,125,134,177,91,62,94,174,228,122,252,156,209,149,100,85,153,168,137,155,42,35,5,251,70,30,10,58,211,14,36,253,59,202,57,17,213,92,226,81,197,105,127,0,138,122,253,113,41,153,92,27,251,120,171,2,223,151,98,69,51,54,103,52,247,129,244,211,129,245,0,127,38,75,170,252,222,156,158,236,156,4,99,117,38,107,78,81,86,115,78,75,185,27,240,60,30,181,102,109,112,138,170,250,163,94,205,58,67,244,137,148,16,84,142,33,252,147,82,72,82,102,116,184,86,64,146,254,108,45,110,244,234,126,234,41,51,184,191,79,101,227,187,143,146,18,158,45,254,13,245,174,38,109,196,236,138,181,99,191,92,160,17,167,68,210,27,103,48,113,227,53,8,141,223,79,114,124,87,217,4,72,27,248,136,230,76,170,228,52,66,147,28,116,159,185,182,240,68,24,48,95,72,81,131,65,146,211,92,195,29,123,11,65,123,63,69,31,80,51,10,223,209,79,30,104,229,245,221,122,69,115,71,221,251,143,53,203,47,187,212,41,231,29,117,23,17,172,112,248,64,3,214,73,15,214,193,196,53,37,115,82,23,210,134,6,86,52,210,73,10,136,218,42,192,134,57,212,72,208,130,102,146,230,26,24,24,51,195,70,181,35,165,215,25,23,62,81,73,166,68,46,66,97,5,202,138,122,39,198,184,17,63,213,103,205,169,254,128,98,243,216,68,116,231,174,111,230,23,70,185,74,156,168,161,214,100,196,84,75,226,5,99,22,216,53,19,171,130,236,115,205,147,232,246,208,19,139,217,86,165,240,229,172,140,134,77,87,38,83,42,219,85,8,95,229,54,25,135,235,102,47,147,248,174,185,39,7,108,127,97,130,65,53,5,135,231,164,16,170,96,245,118,213,186,43,58,103,110,178,26,68,176,42,113,122,9,20,227,186,148,232,18,189,179,211,189,57,84,103,146,45,18,117,84,153,164,75,196,74,183,249,52,98,199,184,134,127,102,101,62,115,210,120,184,214,179,74,125,138,247,249,10,202,181,171,189,222,70,125,110,16,5,223,45,2,5,48,179,237,41,40,247,47,7,186,29,172,86,165,178,22,117,87,245,82,42,98,171,137,165,114,51,116,190,43,227,2,131,106,63,243,120,250,26,143,189,73,136,211,85,241,68,214,98,166,171,136,27,44,141,60,40,46,7,163,209,58,52,123,104,58,195,242,161,26,86,207,170,178,169,184,78,96,219,18,79,253,182,41,55,145,128,170,104,219,204,62,179,250,160,224,17,209,77,95,155,5,228,94,98,71,106,76,44,167,213,46,45,90,21,231,168,156,8,237,4,187,211,210,31,63,146,17,169,142,77,2,79,157,108,54,37,6,214,40,41,8,134,71,30,244,36,163,138,247,41,110,213,150,77,238,5,229,163,170,44,205,215,1,138,18,135,158,75,181,108,51,33,43,123,128,224,63,37,98,65,122,196,165,193,29,178,25,108,8,129,145,8,64,40,63,7,168,170,229,206,132,134,17,42,199,95,23,148,187,124,68,53,98,8,220,248,207,154,20,154,77,254,86,83,14,21,131,67,186,72,202,147,118,139,119,202,242,190,130,156,170,253,193,183,60,167,124,184,78,244,223,107,198,13,94,181,213,128,228,74,100,180,204,97,211,33,136,211,74,48,53,213,239,130,253,107,197,202,68,125,40,138,129,39,224,58,55,177,247,85,131,47,87,34,9,199,239,20,57,238,91,80,101,200,246,98,186,188,200,116,169,132,133,150,202,196,80,155,47,145,197,106,221,168,202,105,23,94,51,167,180,110,55,84,29,168,46,201,24,252,157,138,90,40,102,163,123,76,254,48,126,166,89,45,43,14,89,230,103,17,30,151,2,206,237,245,112,55,148,216,198,234,106,128,52,4,43,237,28,53,238,26,221,244,119,45,146,236,108,53,106,122,177,131,134,85,119,79,140,218,65,43,127,117,113,221,216,34,21,93,108,58,42,240,196,166,165,254,80,18,112,124,177,60,6,207,254,186,216,129,104,227,195,58,134,156,188,34,86,7,245,113,151,56,168,148,89,185,113,158,114,42,192,38,205,61,47,44,15,66,137,123,113,45,231,236,177,230,68,39,103,235,192,134,37,123,173,168,83,44,69,82,135,193,228,225,221,245,184,6,22,154,197,205,156,241,95,111,197,89,135,199,111,222,116,35,192,110,179,184,55,119,159,120,154,110,73,97,103,92,29,34,135,182,160,94,97,57,76,200,173,237,110,109,241,52,53,121,106,162,99,47,83,19,225,188,104,196,34,219,112,149,3,140,90,209,86,89,242,245,184,56,186,53,125,101,185,190,241,69,244,232,41,163,197,222,22,43,175,226,234,251,145,158,72,35,171,91,189,115,95,193,222,23,39,223,228,33,177,185,13,64,250,35,233,184,172,151,24,58,190,160,137,132,238,90,205,219,2,131,150,163,169,123,75,104,234,79,71,210,191,190,214,28,91,5,55,221,212,206,125,116,121,61,193,11,158,110,124,14,231,189,17,249,76,46,124,62,250,30,62,23,26,250,95,176,186,31,73,67,34,33,57,144,140,196,82,227,32,74,18,82,124,239,241,8,153,219,100,243,116,176,199,88,64,97,204,225,223,219,118,245,198,138,196,105,233,141,87,241,155,232,203,237,251,220,156,233,255,230,38,26,208,6,6,17,97,128,254,221,145,236,192,13,112,215,217,119,152,66,108,63,182,129,140,191,4,118,41,221,242,128,243,96,245,238,61,64,253,146,224,189,204,180,42,159,111,45,61,112,75,34,75,7,94,46,250,177,214,249,197,222,190,117,83,174,43,111,124,173,173,178,191,233,233,31,4,12,180,237,58,87,15,44,232,66,111,78,105,152,83,10,227,63,188,225,118,249,140,25,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeSelectedRecordsDataSourceCurrentStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b77a64ab-cbe3-4ae6-8e07-91f511b38c84"),
				Name = "InitializeSelectedRecordsDataSourceCurrentStructure",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2d37aa8e-61e4-44c8-8969-a354d701cb15"),
				Name = "schemaUID",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,77,111,218,64,16,61,7,137,255,176,229,16,25,149,152,158,155,38,21,5,154,162,38,85,20,72,122,168,170,106,99,15,176,145,89,211,221,53,9,170,242,223,59,179,107,131,63,73,171,28,66,96,119,230,205,215,155,103,223,9,101,18,30,141,184,225,211,56,81,1,48,13,17,4,6,194,27,8,98,21,234,220,205,25,147,240,200,238,42,30,127,218,173,163,201,8,175,59,211,38,223,78,187,245,124,218,110,245,251,39,39,39,237,86,187,213,24,196,191,140,121,8,33,123,123,198,174,249,2,252,18,226,133,18,161,79,214,206,204,66,54,99,93,43,88,115,5,159,69,100,64,105,194,172,36,255,171,104,131,128,141,97,47,192,220,196,143,195,88,206,197,226,11,151,97,4,138,157,29,205,20,0,93,23,206,79,15,85,72,95,111,224,119,2,218,80,74,33,26,46,184,1,47,190,127,64,15,236,191,12,65,245,216,222,99,188,1,105,6,106,161,25,116,109,179,55,92,177,48,126,148,133,217,56,63,198,53,155,129,82,92,199,115,227,223,78,252,239,112,143,169,25,21,71,218,223,125,169,180,1,19,62,210,70,9,185,96,58,88,194,138,223,78,66,196,244,92,51,236,201,165,208,102,28,10,131,206,90,220,71,192,142,143,89,221,245,196,192,138,66,37,210,176,115,246,174,203,62,34,118,157,97,214,99,114,240,239,120,148,0,123,239,16,115,205,154,102,217,248,179,120,106,19,244,186,185,100,215,74,172,184,218,14,227,40,89,201,111,124,69,141,168,135,64,50,228,76,125,178,173,226,140,132,94,71,252,127,224,10,30,59,84,26,80,70,0,91,153,166,102,142,68,96,68,44,209,235,131,11,219,99,110,230,231,221,105,193,152,32,82,54,108,232,128,126,143,165,17,102,203,84,252,72,191,154,161,156,135,133,152,199,10,120,176,244,190,194,214,226,94,115,161,50,243,204,186,144,37,19,178,148,182,227,219,17,70,197,2,138,148,243,135,136,110,0,87,194,77,132,140,112,166,198,181,194,186,123,149,241,244,172,132,92,36,34,244,10,129,124,204,49,55,225,238,75,136,149,65,245,88,9,208,21,132,219,80,109,85,214,244,31,77,96,63,243,169,216,76,74,165,15,194,208,195,228,236,221,51,254,149,174,73,156,176,47,218,3,63,93,116,178,204,9,160,229,20,125,208,70,114,33,65,237,119,147,176,27,197,131,112,196,156,121,111,198,79,184,105,122,240,192,159,178,8,123,101,200,171,66,137,189,59,114,90,18,211,76,203,196,190,226,18,93,20,169,221,68,106,195,101,0,159,182,184,127,94,166,11,35,91,245,65,113,118,128,86,65,154,101,112,50,58,101,196,228,221,9,118,60,9,76,162,32,151,212,254,236,16,212,8,230,59,67,74,174,198,191,184,254,233,106,235,67,202,96,212,214,145,255,0,90,157,94,164,160,216,191,38,35,183,47,207,44,224,38,88,186,24,182,157,179,37,114,202,138,189,215,153,154,120,77,135,87,160,53,254,235,164,11,1,24,93,102,172,203,134,109,169,62,219,174,33,157,157,213,154,154,243,46,65,220,106,80,200,53,9,118,43,252,193,122,157,222,94,171,120,35,66,55,249,244,200,235,212,193,184,92,40,56,61,245,168,168,244,205,160,102,148,233,189,173,241,165,166,247,200,168,16,48,229,103,57,129,34,55,109,71,59,36,41,157,174,133,152,232,236,9,117,198,230,60,210,64,237,106,162,5,110,155,75,193,203,138,217,85,39,17,248,213,245,85,159,15,175,42,115,6,79,38,45,179,223,31,242,53,205,240,133,152,169,21,185,236,29,26,95,212,246,214,255,208,178,125,135,172,190,145,188,89,78,106,246,194,219,91,42,79,168,206,117,111,34,253,126,136,47,16,137,82,184,9,251,176,233,27,154,213,71,124,40,84,28,211,123,82,236,191,231,7,87,89,213,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_PrepareFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("64309219-6e8e-4d8c-b0cd-fe169fc26422"),
				Name = "DataSource_PrepareFilters",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a3d8215f-7fe0-476d-b744-a2a4ccecb185"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a42eea8b-a04c-4bf2-b602-2b792dd4b7df"),
				Name = "e",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,223,111,155,72,16,126,198,146,255,7,226,135,10,42,160,198,224,95,151,54,146,141,113,20,93,175,141,206,105,251,80,245,97,139,23,155,11,6,223,178,36,181,174,249,223,111,118,23,19,131,215,46,186,75,30,98,105,119,230,155,153,111,191,153,93,162,80,213,50,74,162,100,101,221,100,31,242,56,254,72,252,205,150,238,180,5,70,36,88,127,70,113,142,117,93,253,167,221,82,8,166,57,73,46,219,173,167,118,235,1,17,53,200,9,193,9,93,80,146,7,176,131,213,119,234,45,90,97,107,134,40,90,164,57,9,176,229,213,76,46,43,158,243,40,166,152,100,215,36,205,183,224,92,199,179,138,125,248,77,150,211,221,7,180,193,90,231,125,154,222,231,219,67,207,142,14,168,17,148,33,67,189,120,167,38,80,148,206,242,63,137,255,39,222,164,15,88,230,175,63,87,27,167,171,40,64,241,199,45,38,136,70,105,2,9,191,175,45,1,114,20,80,107,146,44,139,140,142,44,202,124,56,161,18,72,77,142,169,215,151,15,243,170,19,34,163,210,35,24,81,124,104,37,165,210,56,42,147,49,32,244,161,6,233,102,139,72,148,165,201,221,110,203,78,187,179,160,136,208,47,17,93,119,138,130,63,101,152,120,105,146,224,224,184,218,244,251,95,176,172,102,92,87,94,5,11,188,21,230,126,135,9,65,89,26,82,203,75,89,210,105,18,70,171,92,36,98,45,118,217,2,83,10,153,100,214,29,217,93,99,202,197,89,139,105,0,148,162,116,22,60,101,47,141,243,77,178,144,68,132,74,211,92,158,140,174,190,122,37,221,168,150,163,40,71,124,248,73,190,177,32,47,174,84,10,107,105,168,137,68,120,166,181,48,134,170,69,9,213,165,41,48,66,158,248,17,87,91,141,219,222,225,31,133,72,155,54,77,221,143,183,140,114,208,51,71,192,213,82,27,118,78,29,165,232,30,22,231,66,58,99,248,184,16,94,254,50,162,22,115,101,195,70,129,160,188,236,10,43,156,68,214,35,2,189,70,25,39,255,22,145,172,164,94,106,102,212,64,57,19,44,86,40,74,250,85,243,48,181,67,20,160,149,89,79,119,127,96,138,110,17,93,107,245,209,183,8,214,120,131,12,69,82,131,161,30,12,87,67,133,56,240,191,206,5,232,104,129,66,225,160,233,250,165,178,39,37,107,32,2,89,187,31,137,192,56,51,192,56,45,245,72,214,100,185,212,10,158,184,193,73,93,48,195,186,119,161,6,201,212,98,103,10,173,26,139,14,126,59,139,248,47,34,187,183,66,53,208,171,124,118,92,93,233,156,37,160,166,60,2,193,79,117,150,149,55,66,53,74,161,105,214,222,149,13,152,51,121,66,213,43,181,43,228,30,194,236,65,193,90,213,78,39,82,168,69,141,146,42,84,209,47,44,118,88,105,36,22,84,172,212,163,41,138,76,167,133,177,87,31,49,114,81,11,227,175,157,170,214,58,223,46,57,126,49,190,99,28,82,255,199,150,224,44,131,162,196,104,100,202,101,168,194,164,196,57,101,186,71,252,158,166,177,154,103,120,22,101,219,24,237,202,198,100,235,37,72,109,127,239,251,220,34,133,124,15,9,20,38,207,244,177,43,128,162,40,201,126,199,59,173,131,86,43,130,87,92,169,188,62,125,207,32,239,139,218,46,203,103,82,93,42,238,210,125,130,117,184,34,193,226,162,250,250,77,125,96,121,115,117,238,151,74,95,18,173,214,7,20,85,229,152,149,80,135,181,157,238,83,150,102,36,18,17,166,167,134,137,84,21,198,201,147,53,234,156,0,0,138,51,248,169,157,141,81,148,170,139,180,159,84,12,86,123,110,179,199,136,178,110,144,197,46,15,64,9,16,120,200,196,89,140,252,223,10,187,134,148,8,167,95,176,113,170,238,162,12,38,84,0,187,191,108,146,98,74,255,91,150,194,239,101,19,93,226,16,229,49,45,147,41,5,121,94,117,255,71,168,77,43,150,93,130,47,166,214,35,85,158,79,94,206,222,147,144,48,255,127,252,54,230,55,211,225,50,187,88,217,205,202,61,196,147,235,58,143,150,106,198,107,248,116,179,148,124,213,136,250,44,216,132,152,111,94,183,91,236,105,202,215,110,150,74,241,199,30,94,237,150,59,247,7,221,241,112,104,122,67,219,54,221,209,180,103,142,220,241,216,180,61,127,58,245,189,249,112,52,24,41,159,31,159,253,147,47,41,185,207,182,40,0,231,209,172,103,251,147,233,196,28,205,157,145,233,118,237,190,57,241,39,93,211,25,246,186,174,51,234,122,221,177,35,156,89,130,18,128,158,111,247,251,238,192,49,157,249,28,162,123,222,220,28,245,71,174,233,250,222,104,54,236,57,142,109,219,2,192,79,104,68,119,18,136,113,119,62,25,204,186,61,211,241,199,142,233,246,103,3,115,50,236,77,205,254,104,230,205,231,19,215,182,39,126,181,128,48,109,183,156,65,223,181,231,254,216,244,156,33,100,238,64,250,99,187,239,153,254,172,55,158,141,199,238,212,239,246,85,248,147,196,190,69,193,61,84,211,110,189,126,35,238,240,242,32,44,255,239,28,166,151,150,224,71,149,29,145,214,105,194,46,187,36,126,254,100,7,124,6,168,9,211,141,128,154,48,222,8,168,9,239,141,128,154,28,5,0,137,65,126,246,110,126,153,161,0,81,164,35,152,39,110,192,39,229,46,43,229,7,47,212,234,199,157,85,110,89,55,226,137,122,152,160,197,122,142,127,150,30,96,220,44,139,215,110,221,250,252,60,224,15,213,40,212,46,196,64,133,15,157,16,67,233,1,46,8,62,70,50,196,7,147,32,242,236,195,248,216,151,63,141,255,5,135,11,204,239,138,17,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDeafaultLookupEditSchemaIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("80527ec6-9c37-46b1-9464-42ca8768d3c2"),
				Name = "GetDeafaultLookupEditSchemaId",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,193,110,194,48,12,61,83,137,127,8,61,160,22,161,240,1,27,59,12,42,132,196,24,82,97,247,172,117,33,90,155,84,73,58,214,77,252,251,146,182,64,58,64,59,76,218,165,82,99,251,249,249,61,123,52,120,39,2,201,104,7,25,217,204,99,52,70,107,16,130,72,158,40,60,225,2,244,135,37,116,91,8,162,40,103,56,44,101,8,74,81,182,149,120,6,234,133,164,5,120,27,9,66,167,49,136,76,14,26,186,83,72,22,156,191,21,121,16,83,181,34,91,8,143,248,174,127,215,117,104,130,60,171,227,24,177,34,77,253,175,174,211,17,160,10,193,208,172,160,49,14,178,92,149,58,251,128,32,149,128,172,48,131,125,149,114,6,193,107,30,42,161,89,121,190,105,112,24,140,186,206,121,46,61,148,33,129,167,68,145,144,23,34,2,92,19,106,113,57,17,65,55,153,216,233,120,37,104,70,68,57,225,105,145,177,118,177,218,9,190,175,104,46,245,219,179,168,0,130,143,8,114,35,144,103,2,11,30,145,148,126,146,215,20,26,230,110,91,120,119,168,129,58,110,192,20,85,101,77,23,159,32,240,134,201,28,34,154,80,136,219,68,92,127,216,76,141,151,36,3,191,166,109,180,72,43,71,194,163,34,109,211,176,221,231,137,48,45,151,48,6,207,153,84,132,69,240,88,26,52,207,213,254,215,206,86,70,214,69,13,114,243,51,70,19,1,68,193,194,122,244,236,222,39,126,151,190,25,181,143,104,205,230,212,59,217,178,193,120,96,183,196,115,89,207,94,109,227,130,147,24,226,138,233,149,237,67,253,62,210,186,182,202,245,152,235,50,135,216,2,185,55,13,31,110,130,244,108,70,181,229,215,88,255,173,203,217,185,255,191,206,43,211,216,35,27,21,79,155,160,131,189,159,193,51,227,158,125,23,215,68,250,253,152,187,78,115,140,23,229,58,250,13,254,67,154,22,192,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2c879e6b-9c97-48a4-b590-887359458b07"),
				Name = "GetVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bd95e8e5-d0bf-4bc0-81a0-78639e58a034"),
				Name = "serializedStructure",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Dictionary<string, string>>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("25eba59c-64b2-4800-93aa-7fdd8a9f70c8"),
				Name = "structure",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceStructure",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,223,78,131,48,20,198,175,225,41,154,93,65,98,120,129,197,11,221,140,33,70,179,56,183,27,179,139,51,56,115,77,160,44,109,209,160,217,187,123,10,133,201,214,154,93,145,182,191,239,59,127,217,86,85,193,106,133,107,46,117,13,197,28,52,44,171,90,102,200,110,217,14,10,133,211,240,19,36,203,233,126,13,69,141,111,205,1,159,65,192,7,74,34,86,10,229,172,18,2,51,205,43,145,204,29,84,167,71,161,185,110,150,217,30,75,240,202,31,46,161,105,120,202,104,169,101,157,233,90,226,172,42,234,82,176,172,253,76,195,93,37,17,178,61,139,76,32,174,177,100,92,48,114,230,80,240,111,204,7,89,204,126,194,160,19,81,108,129,95,204,239,77,100,16,188,64,105,218,96,44,223,39,230,48,217,220,152,251,182,196,14,28,33,103,247,150,158,115,117,40,160,113,240,23,47,189,226,111,27,137,118,53,63,121,68,157,10,165,65,100,120,223,24,113,100,77,255,194,157,105,220,186,206,224,96,186,60,68,183,103,27,51,85,107,174,248,182,48,241,182,180,19,201,2,164,234,61,135,199,222,43,85,203,74,106,240,226,253,43,241,132,31,167,97,192,119,172,125,77,104,222,26,184,80,79,216,68,147,87,220,161,68,42,161,27,122,155,110,220,206,41,48,195,148,227,103,138,229,216,35,111,39,92,230,155,152,114,177,75,144,56,128,161,59,78,177,95,187,74,115,146,158,229,155,208,173,95,178,144,188,4,57,222,139,115,3,42,237,2,139,254,41,193,194,174,149,243,91,95,208,109,132,163,111,102,169,26,165,212,207,203,192,142,77,24,179,27,11,7,170,255,223,18,87,27,108,113,230,100,106,61,94,147,205,168,138,235,146,26,75,252,185,185,218,233,76,241,164,188,203,243,14,143,58,144,58,122,252,5,173,71,42,178,107,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8cb06580-6f04-4ea7-8470-cb1a50f2f531"),
				Name = "GetVirtualDataSourceData",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2a0116b0-6cb6-445a-afca-c815b3ebf240"),
				Name = "virtualDataSource",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("44080a6d-d9c8-4d09-92fc-be103ebc891e"),
				Name = "request",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceRequest",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,79,107,2,49,16,197,207,238,167,24,61,173,32,75,239,254,129,162,180,148,110,75,169,212,139,136,164,187,163,166,221,205,180,147,68,43,226,119,239,36,107,193,98,161,167,192,155,249,189,247,134,232,21,164,237,59,59,211,236,188,170,30,168,196,46,28,146,22,163,243,108,250,201,49,177,142,181,89,67,169,156,186,199,61,12,161,17,178,27,226,90,185,180,115,34,115,162,119,255,113,203,186,124,82,107,92,30,174,142,203,128,116,122,112,102,61,38,227,240,203,137,79,183,159,108,21,71,87,177,124,177,200,50,51,88,56,77,38,155,162,181,242,78,100,56,63,229,46,64,89,200,181,117,131,137,142,75,138,247,131,166,73,15,232,245,77,200,209,168,159,172,136,81,21,27,72,131,185,118,88,131,54,49,36,30,21,68,166,157,4,110,155,78,33,97,74,158,11,204,198,2,58,124,166,93,42,213,90,191,124,10,170,124,109,130,147,192,217,180,216,96,173,178,113,20,109,244,109,69,29,93,163,205,84,229,49,109,160,236,76,122,84,53,246,98,169,249,223,195,69,72,62,74,205,139,114,215,101,153,74,70,55,252,135,150,15,99,252,244,104,29,180,135,96,124,85,53,199,93,80,57,169,82,14,178,63,235,1,7,172,44,254,179,30,246,190,1,192,94,92,69,23,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("52db079a-e8b5-4ce6-b5d0-87338cc73faa"),
				Name = "GetVirtualDataSource",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,32,94,81,126,142,134,82,88,102,81,73,105,98,142,75,98,73,98,112,126,105,81,114,170,146,166,66,98,177,2,134,176,53,0,123,3,251,107,80,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_LoadingRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("18aa30e7-6637-4b33-bfb0-8f12fd8e3e45"),
				Name = "DataSource_LoadingRows",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e2a73a8a-25dc-46e6-b614-e47066fb09d8"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("72061bc8-806c-4a0a-b48c-577b5da832df"),
				Name = "e",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,45,9,203,44,42,41,77,204,113,73,44,73,12,206,47,45,74,78,5,177,52,138,83,243,82,82,139,20,18,139,21,48,228,117,20,242,74,115,114,52,173,1,126,98,10,116,60,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDataSource_DataRequestMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("969752cb-6f87-49f8-8713-4ef5c07c7b66"),
				Name = "DataSource_DataRequest",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6e566032-7181-47c6-abbd-7868324e76f2"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8d3b535b-3a36-46d1-a0ac-cf4d717403f3"),
				Name = "e",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,45,9,203,44,42,41,77,204,113,73,44,73,12,206,47,45,74,78,5,177,52,138,83,243,82,82,139,20,18,139,21,48,228,117,20,82,245,130,82,11,75,83,139,75,52,173,1,79,216,199,103,65,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotModuleDetailSchemaIdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("afec8fef-1553-4c3b-82a8-c14ffe9a35c0"),
				Name = "GetNotModuleDetailSchemaIds",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,93,75,195,48,20,125,238,192,255,16,250,148,130,4,223,167,194,182,214,81,81,7,118,211,7,241,33,46,23,23,232,18,205,199,230,16,255,187,169,73,109,215,109,130,130,161,208,220,195,189,247,156,123,46,41,160,132,185,65,12,12,229,101,49,95,192,146,22,30,58,67,2,214,200,7,120,166,65,141,164,16,238,206,165,72,142,122,17,25,201,210,46,5,142,139,141,190,150,204,150,144,9,195,205,38,62,70,21,228,3,223,112,150,179,216,149,32,119,200,133,146,203,86,77,250,197,27,39,100,160,247,160,161,38,119,188,234,82,242,54,217,88,113,214,45,11,216,100,39,207,73,170,36,144,92,103,175,150,150,187,76,94,115,83,209,18,188,143,60,76,218,161,255,70,39,251,93,57,32,161,86,216,169,104,73,184,95,128,130,223,26,125,35,13,118,116,2,251,56,250,105,153,40,156,63,46,181,62,221,229,118,13,218,201,255,119,111,15,250,26,37,136,234,224,71,255,168,119,197,181,57,29,91,206,206,183,94,66,206,116,120,6,77,2,78,92,190,213,92,60,35,188,162,10,177,167,236,13,230,214,72,229,82,183,157,37,153,208,86,65,58,108,32,156,36,232,221,209,135,6,121,74,13,189,5,202,192,53,170,26,236,190,67,226,219,131,207,194,13,93,232,20,173,23,188,4,132,153,34,85,74,77,16,69,157,65,200,128,177,206,230,73,58,156,110,94,192,1,43,80,6,148,139,239,104,105,97,42,171,73,93,199,135,147,199,164,26,183,94,216,135,191,186,159,251,20,24,171,68,215,175,254,39,191,180,233,46,81,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTreeGridConfigHandlerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c61487e0-7aa8-4bb6-abf7-a76542b0138c"),
				Name = "TreeGridConfigHandler",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceRowConfig"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ab56d7a9-9982-4942-a0ba-dbcac21bc44d"),
				Name = "row",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				ModifiedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,44,75,44,82,72,206,207,75,203,76,87,176,85,200,75,45,87,112,73,44,73,12,206,47,45,74,78,13,202,47,119,6,203,104,20,229,151,235,5,20,101,230,38,22,85,58,231,231,148,230,230,133,37,230,148,166,106,90,115,114,114,113,22,165,150,148,22,229,65,205,176,6,0,238,251,169,232,80,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetVirtualDataSourceFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e1a391e0-75fd-4af6-8fca-4936000d2757"),
				Name = "SetVirtualDataSourceFilters",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DataSourceFilterCollection"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,81,83,219,56,16,126,182,127,133,234,135,142,221,102,28,158,47,192,76,15,40,147,57,174,165,4,232,3,195,131,176,149,160,171,99,231,36,25,46,115,147,255,126,43,173,236,88,138,205,133,43,115,60,64,34,239,126,90,125,251,237,106,205,19,21,164,168,170,31,245,234,51,47,20,19,146,28,145,248,164,42,10,150,41,94,149,135,167,220,252,165,98,125,40,149,224,229,98,68,170,135,63,224,225,241,113,114,73,23,44,61,103,234,146,10,186,100,224,124,75,139,154,197,209,178,46,20,159,49,13,113,209,133,142,146,73,200,231,177,183,221,17,41,235,162,72,200,223,161,96,170,22,165,249,58,9,55,225,19,132,38,13,10,203,175,88,86,137,92,158,82,69,103,85,45,50,166,195,188,102,66,80,89,205,85,122,51,77,191,179,135,147,170,84,162,42,100,218,126,184,229,66,213,180,216,186,97,204,250,151,182,161,188,100,34,253,204,203,188,89,1,175,56,154,13,109,26,141,136,18,53,131,99,156,215,60,39,50,123,100,75,122,51,205,33,152,193,64,211,153,177,130,16,243,137,115,36,67,150,161,123,152,227,100,230,24,35,64,206,51,237,133,166,119,247,137,195,231,221,193,125,138,198,233,5,149,42,70,202,221,61,129,159,186,84,154,249,3,242,254,189,198,75,47,88,185,80,143,102,73,103,34,232,166,34,176,185,96,165,226,106,141,199,249,157,150,192,152,128,56,110,36,19,192,92,137,122,73,207,118,141,108,212,242,108,6,230,61,32,90,66,211,82,42,90,102,236,215,245,23,144,82,28,221,62,3,145,108,197,193,252,108,73,121,1,210,33,225,120,220,1,50,137,220,161,121,187,215,55,176,41,217,51,233,6,244,173,102,98,29,247,132,48,50,46,169,222,59,177,89,170,31,144,209,25,83,67,72,104,176,45,150,216,236,59,34,23,213,130,103,180,248,186,98,130,234,245,25,100,42,83,233,87,97,177,179,183,6,156,230,224,83,47,75,192,53,30,233,167,220,174,24,4,83,163,130,47,65,96,184,106,56,78,172,51,211,252,110,215,123,48,34,155,2,195,207,36,132,60,196,3,234,75,167,138,45,119,53,152,88,125,133,33,66,55,214,39,5,163,66,75,116,94,137,152,131,36,249,209,193,132,112,114,216,209,36,124,255,248,209,104,114,60,118,189,33,192,56,12,186,137,178,75,104,118,34,24,85,12,159,125,231,234,177,237,82,18,76,130,134,234,229,138,10,46,171,242,122,189,98,233,217,159,208,44,70,240,212,158,88,127,132,72,238,248,189,38,107,19,238,238,223,221,29,76,28,66,109,18,91,66,33,11,152,241,78,130,221,234,193,98,245,252,109,181,30,219,202,196,206,64,158,52,191,147,48,24,238,29,104,2,61,35,112,217,61,236,197,223,210,28,232,51,136,234,249,165,158,134,220,94,85,207,58,121,232,97,80,241,124,68,215,185,187,9,80,216,24,242,188,121,140,214,77,131,68,177,73,77,147,237,2,141,172,155,186,68,255,18,69,186,23,130,167,109,131,49,30,123,221,80,231,177,139,6,238,90,13,118,115,99,100,185,61,142,121,158,140,200,190,198,58,82,16,78,0,155,2,159,41,72,164,99,21,71,211,60,218,31,11,54,54,209,247,1,89,177,190,54,46,64,227,115,18,191,243,232,184,22,107,112,70,232,87,209,82,213,86,150,9,234,40,120,106,110,56,221,236,134,133,138,26,178,214,38,27,63,113,34,7,166,189,160,1,170,253,140,102,61,26,120,77,46,70,182,186,12,216,38,220,226,237,214,10,84,9,226,67,234,180,249,6,26,137,185,188,188,49,227,92,240,124,219,17,135,241,46,42,154,107,76,109,5,189,248,3,94,41,78,91,1,202,245,194,206,253,178,119,11,114,225,188,14,212,236,183,45,118,215,28,218,255,4,173,4,91,192,119,231,110,217,58,14,87,45,186,237,220,88,137,69,205,116,52,221,7,123,194,90,191,94,92,252,9,131,76,79,133,112,181,250,37,118,101,66,50,66,234,108,213,39,18,61,25,30,199,254,201,241,254,48,63,219,84,250,215,189,59,136,159,139,170,94,53,197,51,232,19,55,51,69,45,4,12,54,48,25,212,25,140,110,172,153,144,250,68,214,109,228,158,155,189,194,254,223,55,2,226,189,18,188,195,87,2,61,155,186,211,133,171,67,184,214,24,205,30,95,154,159,201,220,120,18,238,113,139,13,74,239,108,13,58,91,226,138,183,87,255,192,96,109,189,69,160,171,207,56,65,227,187,40,115,150,163,123,236,71,38,112,82,176,185,58,251,107,37,152,148,173,126,46,169,158,204,155,129,191,133,25,50,181,128,15,85,85,144,90,178,83,46,87,5,93,155,68,104,20,189,222,98,120,207,173,171,175,54,135,59,99,177,101,46,181,239,81,242,55,182,142,35,186,88,128,242,205,140,106,206,214,220,4,166,110,189,135,58,152,79,238,18,206,181,109,116,62,26,70,103,39,160,187,123,210,222,47,113,179,212,186,10,190,120,236,176,227,234,81,54,72,221,115,233,38,226,21,131,29,115,116,144,28,195,64,211,184,255,221,99,212,43,135,209,96,78,71,62,35,0,64,11,9,127,188,180,56,151,77,176,33,12,140,44,175,242,153,43,93,2,125,59,55,220,7,25,5,251,222,129,119,42,191,128,234,127,177,253,111,63,58,208,231,95,152,24,58,115,219,107,31,0,235,199,100,143,248,42,245,159,66,68,183,183,140,50,103,115,10,109,172,137,164,85,225,203,82,251,9,117,238,123,218,222,87,156,183,146,232,142,20,95,142,189,143,185,77,216,252,218,189,223,204,96,212,93,134,113,89,223,195,218,94,15,74,246,255,16,187,142,147,240,195,216,249,135,209,63,194,121,115,246,201,18,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetShowColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cc522705-8fbe-4c46-9291-239b8487afd7"),
				Name = "GetShowColumns",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,65,79,194,64,16,133,207,244,87,140,61,52,219,196,244,15,160,92,32,49,68,19,73,16,47,132,195,160,35,44,217,238,154,157,41,72,12,255,221,161,86,109,67,61,109,54,243,222,55,111,223,238,49,130,80,249,190,96,138,227,224,133,62,100,49,125,125,92,239,224,22,102,184,161,226,142,100,134,17,75,18,138,207,232,42,50,233,165,62,205,135,201,131,101,185,97,137,214,111,70,224,244,50,14,174,42,189,114,60,29,160,61,53,170,182,111,96,250,247,94,169,161,114,46,135,207,100,176,239,77,167,200,94,107,241,20,230,245,134,243,130,95,111,29,154,213,211,232,61,189,136,13,190,152,19,179,158,19,20,92,94,226,86,128,12,19,91,75,49,30,155,232,215,16,214,59,245,143,148,255,243,130,134,223,196,134,44,107,109,45,206,64,180,158,239,233,104,82,222,134,195,119,41,156,230,89,246,39,91,118,70,171,78,5,131,78,149,166,221,99,254,47,65,227,157,146,83,18,73,170,232,91,159,49,252,2,156,161,196,127,239,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCanBeEditByNUIMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ae6bd367-be51-4231-963a-05a08b28c815"),
				Name = "CanBeEditByNUI",
				CreatedInSchemaUId = new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,146,193,78,2,49,16,134,207,146,240,14,205,158,74,66,26,239,68,19,179,174,202,1,68,145,120,158,176,131,52,233,182,56,157,74,54,198,119,183,75,9,138,187,55,241,230,177,237,63,95,219,153,79,175,132,188,3,127,191,181,69,169,121,6,47,56,16,239,253,222,25,33,7,178,98,5,198,227,168,223,251,232,247,222,128,4,90,214,92,207,151,107,172,96,2,54,166,73,92,136,133,71,202,157,181,184,100,237,172,42,218,161,81,187,252,33,32,213,177,216,226,86,20,63,247,101,199,69,67,145,205,107,63,113,101,48,152,13,34,177,69,83,87,101,153,59,19,42,43,219,103,143,206,113,90,171,91,228,25,233,10,168,78,233,41,84,40,7,221,200,27,109,24,201,55,232,14,104,78,8,140,41,243,172,121,61,3,138,172,166,64,166,205,220,85,27,32,237,157,125,170,55,168,138,215,0,102,40,98,127,191,254,146,62,175,226,250,123,27,22,227,50,27,138,102,30,234,26,24,230,46,208,18,213,225,236,23,175,29,251,169,227,105,48,38,133,101,150,3,149,95,151,238,200,187,97,237,125,240,113,72,109,86,236,97,122,110,108,161,73,131,151,199,30,52,28,29,237,58,112,84,238,130,101,113,41,206,143,20,99,10,123,195,78,166,71,163,242,191,34,127,171,200,41,244,216,27,208,97,200,232,19,201,200,251,176,152,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LookupGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d35634d2-4c6d-4eac-88d3-4206b491cc5f"));
		}

		#endregion

	}

	#endregion

}

