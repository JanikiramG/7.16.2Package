namespace Terrasoft.WebApp
{

	using DocumentFormat.OpenXml;
	using DocumentFormat.OpenXml.Packaging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using OpenXmlSpreadsheet = DocumentFormat.OpenXml.Spreadsheet;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.ImportExcelData;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: ImportSettingsPageSchema

	/// <exclude/>
	public class ImportSettingsPageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.LookupEdit _objectEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return _objectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _fileUploadEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return _fileUploadEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _columnsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ColumnsControlLayout {
			get {
				return _columnsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _columnsLabel;
		public Terrasoft.UI.WebControls.Controls.Label ColumnsLabel {
			get {
				return _columnsLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _columnsEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnsEdit {
			get {
				return _columnsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _columnsEditButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ColumnsEditButton {
			get {
				return _columnsEditButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _checkRequiredFieldsBeforeImportCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox CheckRequiredFieldsBeforeImportCheckBox {
			get {
				return _checkRequiredFieldsBeforeImportCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isOnlyErrorsMode;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsOnlyErrorsMode {
			get {
				return _isOnlyErrorsMode;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _resolveConflictsAutomatically;
		public Terrasoft.UI.WebControls.Controls.CheckBox ResolveConflictsAutomatically {
			get {
				return _resolveConflictsAutomatically;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _importModeControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ImportModeControlLayout {
			get {
				return _importModeControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _mode1On;
		public Terrasoft.UI.WebControls.Controls.RadioButton Mode1On {
			get {
				return _mode1On;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _mode2On;
		public Terrasoft.UI.WebControls.Controls.RadioButton Mode2On {
			get {
				return _mode2On;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _columnMetaPathEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnMetaPathEdit {
			get {
				return _columnMetaPathEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downloadTemplateButton;
		public Terrasoft.UI.WebControls.Controls.Button DownloadTemplateButton {
			get {
				return _downloadTemplateButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _openLogButton;
		public Terrasoft.UI.WebControls.Controls.Button OpenLogButton {
			get {
				return _openLogButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
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

		public ImportSettingsPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ImportSettingsPageSchema(ImportSettingsPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			RealUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			Name = "ImportSettingsPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			Height = 350;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateImportSettingsPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateObjectEdit());
			MainControlLayout.InsertItem(1, CreateFileUploadEdit());
			MainControlLayout.InsertItem(2, CreateColumnsControlLayout());
			ColumnsControlLayout.InsertItem(0, CreateColumnsLabel());
			ColumnsControlLayout.InsertItem(1, CreateColumnsEdit());
			ColumnsEdit.InsertItem(0, CreateColumnsEditButton());
			MainControlLayout.InsertItem(3, CreateCheckRequiredFieldsBeforeImportCheckBox());
			MainControlLayout.InsertItem(4, CreateIsOnlyErrorsMode());
			MainControlLayout.InsertItem(5, CreateResolveConflictsAutomatically());
			MainControlLayout.InsertItem(6, CreateImportModeControlLayout());
			ImportModeControlLayout.InsertItem(0, CreateMode1On());
			ImportModeControlLayout.InsertItem(1, CreateMode2On());
			MainControlLayout.InsertItem(7, CreateColumnMetaPathEdit());
			Controls.AddAt(2, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateDownloadTemplateButton());
			ButtonsControlLayout.InsertItem(1, CreateOpenLogButton());
			ButtonsControlLayout.InsertItem(2, CreateSpacer1());
			ButtonsControlLayout.InsertItem(3, CreateOKButton());
			ButtonsControlLayout.InsertItem(4, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateImportSettingsPageEventsProcessSchema() {
			var schema = new ImportSettingsPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("3cbe0eb9-7a54-4072-892a-39fc9a99ea7f");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_baseMessagePanel.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectEdit() {
			_objectEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectEdit.UId = new Guid("6550d532-32bd-409c-81a9-a17fc67d649b");
			_objectEdit.Name = "ObjectEdit";
			_objectEdit.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_objectEdit.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_objectEdit.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_objectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectEdit.Tag = "";
			_objectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectEdit.Image = new ControlImage {};
			_objectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectEdit.Margins = "0 0 5";
			_objectEdit.Required = true;
			_objectEdit.LookupSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			return _objectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateFileUploadEdit() {
			_fileUploadEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_fileUploadEdit.UId = new Guid("46724899-795b-4364-a035-71f26ce2bc45");
			_fileUploadEdit.Name = "FileUploadEdit";
			_fileUploadEdit.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_fileUploadEdit.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_fileUploadEdit.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_fileUploadEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_fileUploadEdit.Tag = "";
			_fileUploadEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fileUploadEdit.Image = new ControlImage {};
			_fileUploadEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_fileUploadEdit.Margins = "0 0 5";
			_fileUploadEdit.Required = true;
			return _fileUploadEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateColumnsLabel() {
			_columnsLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_columnsLabel.UId = new Guid("6a6a42f9-0757-4177-bb36-fed72d0380c1");
			_columnsLabel.Name = "ColumnsLabel";
			_columnsLabel.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsLabel.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsLabel.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_columnsLabel.Tag = "";
			_columnsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnsLabel.Width = System.Web.UI.WebControls.Unit.Pixel(147);
			_columnsLabel.Margins = "2";
			return _columnsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateColumnsEditButton() {
			_columnsEditButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_columnsEditButton.UId = new Guid("41e9a1ec-b3aa-4801-97c7-8ac21efb02b5");
			_columnsEditButton.Name = "ColumnsEditButton";
			_columnsEditButton.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsEditButton.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsEditButton.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_columnsEditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_columnsEditButton.Tag = "";
			_columnsEditButton.Image = new ControlImage {};
			return _columnsEditButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateColumnsEdit() {
			_columnsEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_columnsEdit.UId = new Guid("86f7b889-1f4f-4cd3-9b3a-20cc4978ad9b");
			_columnsEdit.Name = "ColumnsEdit";
			_columnsEdit.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsEdit.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsEdit.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_columnsEdit.Tag = "";
			_columnsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnsEdit.Image = new ControlImage {};
			_columnsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnsEdit.Enabled = false;
			return _columnsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateColumnsControlLayout() {
			_columnsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_columnsControlLayout.UId = new Guid("25329f46-56d5-4ebb-9c2a-8339189b94e3");
			_columnsControlLayout.Name = "ColumnsControlLayout";
			_columnsControlLayout.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsControlLayout.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnsControlLayout.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_columnsControlLayout.Tag = "";
			_columnsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(22);
			_columnsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_columnsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnsControlLayout.StartNewAlignGroup = false;
			_columnsControlLayout.Image = new ControlImage {};
			_columnsControlLayout.Edges = "";
			return _columnsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateCheckRequiredFieldsBeforeImportCheckBox() {
			_checkRequiredFieldsBeforeImportCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_checkRequiredFieldsBeforeImportCheckBox.UId = new Guid("1e9fb47b-015a-4706-9f50-62a6a7bc4bdd");
			_checkRequiredFieldsBeforeImportCheckBox.Name = "CheckRequiredFieldsBeforeImportCheckBox";
			_checkRequiredFieldsBeforeImportCheckBox.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_checkRequiredFieldsBeforeImportCheckBox.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_checkRequiredFieldsBeforeImportCheckBox.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_checkRequiredFieldsBeforeImportCheckBox.Tag = "";
			_checkRequiredFieldsBeforeImportCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_checkRequiredFieldsBeforeImportCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_checkRequiredFieldsBeforeImportCheckBox.AlignedByCaption = false;
			return _checkRequiredFieldsBeforeImportCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsOnlyErrorsMode() {
			_isOnlyErrorsMode = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isOnlyErrorsMode.UId = new Guid("7d45e319-e054-4ab3-b073-55bdb1da9b75");
			_isOnlyErrorsMode.Name = "IsOnlyErrorsMode";
			_isOnlyErrorsMode.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_isOnlyErrorsMode.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_isOnlyErrorsMode.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_isOnlyErrorsMode.Tag = "";
			_isOnlyErrorsMode.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isOnlyErrorsMode.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isOnlyErrorsMode.AlignedByCaption = false;
			return _isOnlyErrorsMode;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateResolveConflictsAutomatically() {
			_resolveConflictsAutomatically = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_resolveConflictsAutomatically.UId = new Guid("c874f578-cb14-4506-9f63-54a773080395");
			_resolveConflictsAutomatically.Name = "ResolveConflictsAutomatically";
			_resolveConflictsAutomatically.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_resolveConflictsAutomatically.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_resolveConflictsAutomatically.CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a");
			_resolveConflictsAutomatically.Tag = "";
			_resolveConflictsAutomatically.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_resolveConflictsAutomatically.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_resolveConflictsAutomatically.AlignedByCaption = false;
			return _resolveConflictsAutomatically;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMode1On() {
			_mode1On = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_mode1On.UId = new Guid("f6cab161-4334-4eb6-bc14-1d1592cd0a89");
			_mode1On.Name = "Mode1On";
			_mode1On.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_mode1On.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_mode1On.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_mode1On.Tag = "";
			_mode1On.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_mode1On.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mode1On.AlignedByCaption = false;
			_mode1On.GroupName = "ModeGroup";
			return _mode1On;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateMode2On() {
			_mode2On = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_mode2On.UId = new Guid("1b7eabbc-eade-41ea-a3de-99376b5d2df3");
			_mode2On.Name = "Mode2On";
			_mode2On.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_mode2On.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_mode2On.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_mode2On.Tag = "";
			_mode2On.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_mode2On.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mode2On.AlignedByCaption = false;
			_mode2On.GroupName = "ModeGroup";
			return _mode2On;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateImportModeControlLayout() {
			_importModeControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_importModeControlLayout.UId = new Guid("826326c9-4a75-49dd-9e66-b3198d127a63");
			_importModeControlLayout.Name = "ImportModeControlLayout";
			_importModeControlLayout.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_importModeControlLayout.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_importModeControlLayout.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_importModeControlLayout.Tag = "";
			_importModeControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_importModeControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_importModeControlLayout.FitHeightByContent = true;
			_importModeControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_importModeControlLayout.StartNewAlignGroup = false;
			_importModeControlLayout.Image = new ControlImage {};
			_importModeControlLayout.Edges = "";
			return _importModeControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateColumnMetaPathEdit() {
			_columnMetaPathEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_columnMetaPathEdit.UId = new Guid("f5f63807-13e8-477b-bed2-3eee3b5954d6");
			_columnMetaPathEdit.Name = "ColumnMetaPathEdit";
			_columnMetaPathEdit.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnMetaPathEdit.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_columnMetaPathEdit.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_columnMetaPathEdit.Tag = "";
			_columnMetaPathEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnMetaPathEdit.Image = new ControlImage {};
			_columnMetaPathEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnMetaPathEdit.Hidden = true;
			return _columnMetaPathEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("1b568040-760d-4ccc-895b-a16f45c1c013");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_mainControlLayout.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
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

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownloadTemplateButton() {
			_downloadTemplateButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downloadTemplateButton.UId = new Guid("6e48329c-0e51-4efa-808e-09d9a651b487");
			_downloadTemplateButton.Name = "DownloadTemplateButton";
			_downloadTemplateButton.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_downloadTemplateButton.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_downloadTemplateButton.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_downloadTemplateButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downloadTemplateButton.Tag = "";
			_downloadTemplateButton.Image = new ControlImage {};
			return _downloadTemplateButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOpenLogButton() {
			_openLogButton = new Terrasoft.UI.WebControls.Controls.Button();
			_openLogButton.UId = new Guid("f216089c-6d5a-48c7-8886-e029216e88dd");
			_openLogButton.Name = "OpenLogButton";
			_openLogButton.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_openLogButton.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_openLogButton.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_openLogButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_openLogButton.Tag = "";
			_openLogButton.Image = new ControlImage {};
			return _openLogButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("0b4cc377-5ade-432f-ad12-ea46b1d12954");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_spacer1.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_spacer1.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOKButton() {
			_oKButton = new Terrasoft.UI.WebControls.Controls.Button();
			_oKButton.UId = new Guid("3a773839-37a0-49c8-b561-40c7ac0f8a27");
			_oKButton.Name = "OKButton";
			_oKButton.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_oKButton.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_oKButton.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_oKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_oKButton.Tag = "";
			_oKButton.Image = new ControlImage {};
			return _oKButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("1c3aad20-f00a-4991-b2fd-e74c4532b8c8");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_cancelButton.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_cancelButton.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("a4fd5969-69e9-404e-924d-c182270708f8");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			_buttonsControlLayout.CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonsControlLayout.FitHeightByContent = true;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "";
			return _buttonsControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ImportSettingsPageSchemaUserControl();
		}

		public override object Clone() {
			return new ImportSettingsPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ImportSettingsPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ImportSettingsPageEventsProcess

	/// <exclude/>
	public class ImportSettingsPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ImportSettingsPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, ImportSettingsPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserMessageFlowElement

		/// <exclude/>
		public class UserMessageFlowElement : QuestionUserTask
		{

			public UserMessageFlowElement(UserConnection userConnection, ImportSettingsPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenNewLookupDataPageTaskFlowElement

		/// <exclude/>
		public class OpenNewLookupDataPageTaskFlowElement : OpenPageUserTask
		{

			public OpenNewLookupDataPageTaskFlowElement(UserConnection userConnection, ImportSettingsPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenNewLookupDataPageTask";
				IsLogging = false;
				SchemaElementUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: UserMessageUniqueFlowElement

		/// <exclude/>
		public class UserMessageUniqueFlowElement : QuestionUserTask
		{

			public UserMessageUniqueFlowElement(UserConnection userConnection, ImportSettingsPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserMessageUnique";
				IsLogging = false;
				SchemaElementUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ImportStartedMessageBoxFlowElement

		/// <exclude/>
		public class ImportStartedMessageBoxFlowElement : QuestionUserTask
		{

			public ImportStartedMessageBoxFlowElement(UserConnection userConnection, ImportSettingsPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ImportStartedMessageBox";
				IsLogging = false;
				SchemaElementUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440");
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

		public ImportSettingsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ImportSettingsPageEventsProcess";
			SchemaUId = new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c2af7f54-07df-4670-9c2b-af2497d3231f");
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

		public virtual Guid SchemaId {
			get;
			set;
		}

		public virtual string FileContent {
			get;
			set;
		}

		public virtual string FileName {
			get;
			set;
		}

		public virtual Object RequiredColumnsIndexes {
			get;
			set;
		}

		public virtual Object HeaderNames {
			get;
			set;
		}

		public virtual Object LookupColumnsIndexesAndNames {
			get;
			set;
		}

		public virtual Object LookupFieldValuesAndCounts {
			get;
			set;
		}

		public virtual int NameColumnIndex {
			get;
			set;
		}

		public virtual int CurrencyColumnIndex {
			get;
			set;
		}

		public virtual bool IsAllColumnCaptionsPresent {
			get;
			set;
		}

		public virtual bool IsValid {
			get;
			set;
		}

		public virtual Object FileData {
			get;
			set;
		}

		public virtual Guid ExcelImportId {
			get;
			set;
		}

		public virtual Object Captions {
			get;
			set;
		}

		public virtual Object ImportedItems {
			get;
			set;
		}

		public virtual string SheetName {
			get;
			set;
		}

		public virtual string SchemaName {
			get;
			set;
		}

		public virtual bool IsPrimaryDisplayColumnExists {
			get;
			set;
		}

		public virtual string UndiscoveredFields {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual bool ColumnStructureExplorerRegistered {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual string SelectedIdentificationColumns {
			get;
			set;
		}

		public virtual bool IsOnlyErrorsMode {
			get;
			set;
		}

		private Guid _excelImportLogSchemaId = new Guid("b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0");
		public Guid ExcelImportLogSchemaId {
			get {
				return _excelImportLogSchemaId;
			}
			set {
				_excelImportLogSchemaId = value;
			}
		}

		public virtual int ImportMode {
			get;
			set;
		}

		public virtual bool HasUniqueRecords {
			get;
			set;
		}

		public virtual bool ResolveConflictsAutomatically {
			get;
			set;
		}

		private ProcessFlowElement _controlsEventSubProcess;
		public ProcessFlowElement ControlsEventSubProcess {
			get {
				return _controlsEventSubProcess ?? (_controlsEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ControlsEventSubProcess",
					SchemaElementUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
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
					SchemaElementUId = new Guid("a9300777-817f-419e-9f58-00a4a08f4ea3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _oKButtonClickScriptTask;
		public ProcessScriptTask OKButtonClickScriptTask {
			get {
				return _oKButtonClickScriptTask ?? (_oKButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OKButtonClickScriptTask",
					SchemaElementUId = new Guid("6885ac7b-3043-4d03-9368-be80e1c4c482"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("1483b90f-2cd7-4a8f-a0ed-5ec9d4d45bd3"),
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
					SchemaElementUId = new Guid("72a640d1-f2a6-492e-981b-181bc27600e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _columnsEditButtonClick;
		public ProcessFlowElement ColumnsEditButtonClick {
			get {
				return _columnsEditButtonClick ?? (_columnsEditButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnsEditButtonClick",
					SchemaElementUId = new Guid("9e712a18-36a0-475b-962d-c0306448c1f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _columnsEditButtonClickScriptTask;
		public ProcessScriptTask ColumnsEditButtonClickScriptTask {
			get {
				return _columnsEditButtonClickScriptTask ?? (_columnsEditButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ColumnsEditButtonClickScriptTask",
					SchemaElementUId = new Guid("7b661c9a-4585-4ebd-a1cf-bf12efbc9468"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnsEditButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _fileUploadEditChange;
		public ProcessFlowElement FileUploadEditChange {
			get {
				return _fileUploadEditChange ?? (_fileUploadEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FileUploadEditChange",
					SchemaElementUId = new Guid("7fd44619-7e77-4d51-81b2-98f3072dea3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _productsFileUploadEditChangeScriptTask;
		public ProcessScriptTask ProductsFileUploadEditChangeScriptTask {
			get {
				return _productsFileUploadEditChangeScriptTask ?? (_productsFileUploadEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProductsFileUploadEditChangeScriptTask",
					SchemaElementUId = new Guid("2d472483-db62-477c-990b-7c78abe8ad5d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProductsFileUploadEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _openLogButtonClickStartMessage;
		public ProcessFlowElement OpenLogButtonClickStartMessage {
			get {
				return _openLogButtonClickStartMessage ?? (_openLogButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpenLogButtonClickStartMessage",
					SchemaElementUId = new Guid("14e24ad0-8451-48a4-a648-f72d1e5392f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openLogButtonClickScriptTask;
		public ProcessScriptTask OpenLogButtonClickScriptTask {
			get {
				return _openLogButtonClickScriptTask ?? (_openLogButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenLogButtonClickScriptTask",
					SchemaElementUId = new Guid("e3f79d71-f422-4698-8591-2b108c7f30f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenLogButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _downloadTemplateMenuItemClickScriptTask;
		public ProcessScriptTask DownloadTemplateMenuItemClickScriptTask {
			get {
				return _downloadTemplateMenuItemClickScriptTask ?? (_downloadTemplateMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DownloadTemplateMenuItemClickScriptTask",
					SchemaElementUId = new Guid("9a4f3ee2-359c-474a-ab69-5dc47f99449e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DownloadTemplateMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _downloadTemplateButtonClickStartMessage;
		public ProcessFlowElement DownloadTemplateButtonClickStartMessage {
			get {
				return _downloadTemplateButtonClickStartMessage ?? (_downloadTemplateButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DownloadTemplateButtonClickStartMessage",
					SchemaElementUId = new Guid("156ed94d-689e-4983-bac6-49b669a2c51b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _pageEventSubProcess;
		public ProcessFlowElement PageEventSubProcess {
			get {
				return _pageEventSubProcess ?? (_pageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageEventSubProcess",
					SchemaElementUId = new Guid("d24d946a-686c-4849-87b6-e987f8524999"),
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
					SchemaElementUId = new Guid("d38dcc1e-f290-46a9-bd9d-22989d8e6527"),
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
					SchemaElementUId = new Guid("aa6daf4d-b9aa-40d5-b9ed-0664d1f49d8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("a40b744d-4db4-4832-98b5-3cee92f3a711"),
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
					SchemaElementUId = new Guid("d3d469d5-0a1d-4260-9c66-3ac186314ba8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _customEventSubProcess;
		public ProcessFlowElement CustomEventSubProcess {
			get {
				return _customEventSubProcess ?? (_customEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CustomEventSubProcess",
					SchemaElementUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _analizeDataStartMessage;
		public ProcessFlowElement AnalizeDataStartMessage {
			get {
				return _analizeDataStartMessage ?? (_analizeDataStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AnalizeDataStartMessage",
					SchemaElementUId = new Guid("b03d0300-065f-488a-ac49-322163f816b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _analizeDataScriptTask;
		public ProcessScriptTask AnalizeDataScriptTask {
			get {
				return _analizeDataScriptTask ?? (_analizeDataScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AnalizeDataScriptTask",
					SchemaElementUId = new Guid("3ec95639-0ffa-4e7b-ab7d-137a50520f1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AnalizeDataScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _areInputDataCorrectExclusiveGateway;
		public ProcessExclusiveGateway AreInputDataCorrectExclusiveGateway {
			get {
				return _areInputDataCorrectExclusiveGateway ?? (_areInputDataCorrectExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "AreInputDataCorrectExclusiveGateway",
					SchemaElementUId = new Guid("77c05c9d-0734-4cd8-bb4b-4cfc02f34d80"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.AreInputDataCorrectExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("a3fcf61e-9094-44c7-b13e-e46356942dd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private UserMessageFlowElement _userMessage;
		public UserMessageFlowElement UserMessage {
			get {
				return _userMessage ?? (_userMessage = new UserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("85b40358-1362-474c-b207-97be32e2f623"),
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

		private ProcessThrowMessageEvent _throwSaveProductsIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ThrowSaveProductsIntermediateThrowMessageEvent {
			get {
				return _throwSaveProductsIntermediateThrowMessageEvent ?? (_throwSaveProductsIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowSaveProductsIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("c16d35bf-f6cd-46c2-8374-f37d475f6dc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ThrowSaveProducts",
				});
			}
		}

		private ProcessFlowElement _saveNewLookupDataStartMessage;
		public ProcessFlowElement SaveNewLookupDataStartMessage {
			get {
				return _saveNewLookupDataStartMessage ?? (_saveNewLookupDataStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveNewLookupDataStartMessage",
					SchemaElementUId = new Guid("d089505d-965d-4d4c-8553-af0257905b8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _openNewLookupDataPageScript;
		public ProcessScriptTask OpenNewLookupDataPageScript {
			get {
				return _openNewLookupDataPageScript ?? (_openNewLookupDataPageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OpenNewLookupDataPageScript",
					SchemaElementUId = new Guid("4145599b-ccfa-4b9b-84f4-3a0131577228"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OpenNewLookupDataPageScriptExecute,
				});
			}
		}

		private OpenNewLookupDataPageTaskFlowElement _openNewLookupDataPageTask;
		public OpenNewLookupDataPageTaskFlowElement OpenNewLookupDataPageTask {
			get {
				return _openNewLookupDataPageTask ?? (_openNewLookupDataPageTask = new OpenNewLookupDataPageTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _importYesMessageStartMessage;
		public ProcessFlowElement ImportYesMessageStartMessage {
			get {
				return _importYesMessageStartMessage ?? (_importYesMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImportYesMessageStartMessage",
					SchemaElementUId = new Guid("5d84bae3-0eb0-44d5-bc02-18ba9ce202f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _importYesScript;
		public ProcessScriptTask ImportYesScript {
			get {
				return _importYesScript ?? (_importYesScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ImportYesScript",
					SchemaElementUId = new Guid("609cc4fb-51a1-4ff5-94bf-b0a7ba567161"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ImportYesScriptExecute,
				});
			}
		}

		private ProcessFlowElement _importNoMessageStartMessage;
		public ProcessFlowElement ImportNoMessageStartMessage {
			get {
				return _importNoMessageStartMessage ?? (_importNoMessageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ImportNoMessageStartMessage",
					SchemaElementUId = new Guid("19902afc-d7da-457c-bfc9-b4eaf3187d41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessEndEvent _end2;
		public ProcessEndEvent End2 {
			get {
				return _end2 ?? (_end2 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End2",
					SchemaElementUId = new Guid("13ecd1e7-ec17-4727-92bb-fb3b35bf2ef9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _throwSaveProductsStartMessage;
		public ProcessFlowElement ThrowSaveProductsStartMessage {
			get {
				return _throwSaveProductsStartMessage ?? (_throwSaveProductsStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ThrowSaveProductsStartMessage",
					SchemaElementUId = new Guid("7f851def-af74-471e-a67e-e5883b5a09e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _throwSaveProductsScriptTask;
		public ProcessScriptTask ThrowSaveProductsScriptTask {
			get {
				return _throwSaveProductsScriptTask ?? (_throwSaveProductsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ThrowSaveProductsScriptTask",
					SchemaElementUId = new Guid("0d7ab517-1e17-4539-bdbc-052d88773726"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ThrowSaveProductsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _saveProductsStartMessage;
		public ProcessFlowElement SaveProductsStartMessage {
			get {
				return _saveProductsStartMessage ?? (_saveProductsStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveProductsStartMessage",
					SchemaElementUId = new Guid("139094b4-ae29-4107-b744-f7188f034b1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("68223875-5183-4512-b0b0-e0cf7ab94c77"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _clearSettingsScript;
		public ProcessScriptTask ClearSettingsScript {
			get {
				return _clearSettingsScript ?? (_clearSettingsScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearSettingsScript",
					SchemaElementUId = new Guid("50eb6e8a-9e92-4221-b2cc-3a5d22179d3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClearSettingsScriptExecute,
				});
			}
		}

		private ProcessScriptTask _saveProductsScriptTask;
		public ProcessScriptTask SaveProductsScriptTask {
			get {
				return _saveProductsScriptTask ?? (_saveProductsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SaveProductsScriptTask",
					SchemaElementUId = new Guid("51d339e9-cf7e-4f16-9edd-b5b21281c5c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SaveProductsScriptTaskExecute,
				});
			}
		}

		private ProcessEndEvent _end3;
		public ProcessEndEvent End3 {
			get {
				return _end3 ?? (_end3 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End3",
					SchemaElementUId = new Guid("a6f6e626-9173-43bb-892d-1dd70927d8ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkUniqueScriptTask;
		public ProcessScriptTask CheckUniqueScriptTask {
			get {
				return _checkUniqueScriptTask ?? (_checkUniqueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckUniqueScriptTask",
					SchemaElementUId = new Guid("044bba60-6f5b-439c-a9c9-673b7b548fd0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckUniqueScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("18a7d8bd-ec4e-4877-ae7a-cda08558c7fd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _prepareUserQuestionScriptTask;
		public ProcessScriptTask PrepareUserQuestionScriptTask {
			get {
				return _prepareUserQuestionScriptTask ?? (_prepareUserQuestionScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareUserQuestionScriptTask",
					SchemaElementUId = new Guid("036ccbc1-7c40-4779-aafd-195f2a113c7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareUserQuestionScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _uniqueImportYesMessageStart;
		public ProcessFlowElement UniqueImportYesMessageStart {
			get {
				return _uniqueImportYesMessageStart ?? (_uniqueImportYesMessageStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UniqueImportYesMessageStart",
					SchemaElementUId = new Guid("a8ee5847-b324-40e0-ac57-d433e2a7be16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private UserMessageUniqueFlowElement _userMessageUnique;
		public UserMessageUniqueFlowElement UserMessageUnique {
			get {
				return _userMessageUnique ?? (_userMessageUnique = new UserMessageUniqueFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _uniqueImportNoMessageStart;
		public ProcessFlowElement UniqueImportNoMessageStart {
			get {
				return _uniqueImportNoMessageStart ?? (_uniqueImportNoMessageStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UniqueImportNoMessageStart",
					SchemaElementUId = new Guid("8230ea3c-e52a-43b4-b389-8ff1d887eed7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _executeImportExcelLookupProcess;
		public ProcessScriptTask ExecuteImportExcelLookupProcess {
			get {
				return _executeImportExcelLookupProcess ?? (_executeImportExcelLookupProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExecuteImportExcelLookupProcess",
					SchemaElementUId = new Guid("4c5fbd9d-715d-4d27-87f7-feedddc92513"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ExecuteImportExcelLookupProcessExecute,
				});
			}
		}

		private ProcessExclusiveGateway _chooseImportTypeExclusiveGateway;
		public ProcessExclusiveGateway ChooseImportTypeExclusiveGateway {
			get {
				return _chooseImportTypeExclusiveGateway ?? (_chooseImportTypeExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ChooseImportTypeExclusiveGateway",
					SchemaElementUId = new Guid("2fef55d4-a149-4239-bbd2-aaaa8c0bef39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ChooseImportTypeExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ImportStartedMessageBoxFlowElement _importStartedMessageBox;
		public ImportStartedMessageBoxFlowElement ImportStartedMessageBox {
			get {
				return _importStartedMessageBox ?? (_importStartedMessageBox = new ImportStartedMessageBoxFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _closeImportSetingsPage;
		public ProcessScriptTask CloseImportSetingsPage {
			get {
				return _closeImportSetingsPage ?? (_closeImportSetingsPage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CloseImportSetingsPage",
					SchemaElementUId = new Guid("3b12a25f-942f-4786-85de-3c678b3d8159"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CloseImportSetingsPageExecute,
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
					SchemaElementUId = new Guid("7f9cd08a-6084-4095-8853-c149046631ec"),
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
					SchemaElementUId = new Guid("5c180dfd-5def-4646-a3bc-414d9d824203"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectEditChangeScriptTask;
		public ProcessScriptTask ObjectEditChangeScriptTask {
			get {
				return _objectEditChangeScriptTask ?? (_objectEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectEditChangeScriptTask",
					SchemaElementUId = new Guid("c3796db3-3d94-4e73-8633-c3f1cf2880fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _isValidConditionalFlow;
		public ProcessConditionalFlow IsValidConditionalFlow {
			get {
				return _isValidConditionalFlow ?? (_isValidConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsValidConditionalFlow",
					SchemaElementUId = new Guid("01a5a0c0-484a-4d78-b1a7-960e62edbba5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
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
					SchemaElementUId = new Guid("8b1f3ab6-b498-4dc9-8442-7f62eb21c7b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("9e275910-3a07-4856-8e7b-391db0970674"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("2e00a2fc-b7de-4878-8676-800f443950e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("7e393bdc-03aa-4031-b597-5c2212c3a2fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("20e273af-6da3-4cda-aa52-8df6cbd3017e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow6;
		public ProcessConditionalFlow ConditionalFlow6 {
			get {
				return _conditionalFlow6 ?? (_conditionalFlow6 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow6",
					SchemaElementUId = new Guid("c93c5739-2b9a-4a42-a125-3598e8e7e536"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _unableUploadFileMessage;
		public LocalizableString UnableUploadFileMessage {
			get {
				return _unableUploadFileMessage ?? (_unableUploadFileMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UnableUploadFileMessage.Value"));
			}
		}

		private LocalizableString _warrningMessage;
		public LocalizableString WarrningMessage {
			get {
				return _warrningMessage ?? (_warrningMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WarrningMessage.Value"));
			}
		}

		private LocalizableString _requiredFieldsAreNotFilled;
		public LocalizableString RequiredFieldsAreNotFilled {
			get {
				return _requiredFieldsAreNotFilled ?? (_requiredFieldsAreNotFilled = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RequiredFieldsAreNotFilled.Value"));
			}
		}

		private LocalizableString _importNotAllColumnsMessage;
		public LocalizableString ImportNotAllColumnsMessage {
			get {
				return _importNotAllColumnsMessage ?? (_importNotAllColumnsMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportNotAllColumnsMessage.Value"));
			}
		}

		private LocalizableString _loading;
		public LocalizableString Loading {
			get {
				return _loading ?? (_loading = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Loading.Value"));
			}
		}

		private LocalizableString _addItemLocalizableString;
		public LocalizableString AddItemLocalizableString {
			get {
				return _addItemLocalizableString ?? (_addItemLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddItemLocalizableString.Value"));
			}
		}

		private LocalizableString _updateItemLocalizableString;
		public LocalizableString UpdateItemLocalizableString {
			get {
				return _updateItemLocalizableString ?? (_updateItemLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UpdateItemLocalizableString.Value"));
			}
		}

		private LocalizableString _errorAddItemLocalizableString;
		public LocalizableString ErrorAddItemLocalizableString {
			get {
				return _errorAddItemLocalizableString ?? (_errorAddItemLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ErrorAddItemLocalizableString.Value"));
			}
		}

		private LocalizableString _addNewLookupExcelLocalizableString;
		public LocalizableString AddNewLookupExcelLocalizableString {
			get {
				return _addNewLookupExcelLocalizableString ?? (_addNewLookupExcelLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AddNewLookupExcelLocalizableString.Value"));
			}
		}

		private LocalizableString _unableSelectObjectMessage;
		public LocalizableString UnableSelectObjectMessage {
			get {
				return _unableSelectObjectMessage ?? (_unableSelectObjectMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UnableSelectObjectMessage.Value"));
			}
		}

		private LocalizableString _importErrorMessage;
		public LocalizableString ImportErrorMessage {
			get {
				return _importErrorMessage ?? (_importErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportErrorMessage.Value"));
			}
		}

		private LocalizableString _importSuccessMessage;
		public LocalizableString ImportSuccessMessage {
			get {
				return _importSuccessMessage ?? (_importSuccessMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportSuccessMessage.Value"));
			}
		}

		private LocalizableString _errorMessage;
		public LocalizableString ErrorMessage {
			get {
				return _errorMessage ?? (_errorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ErrorMessage.Value"));
			}
		}

		private LocalizableString _noPrimaryDisplayField;
		public LocalizableString NoPrimaryDisplayField {
			get {
				return _noPrimaryDisplayField ?? (_noPrimaryDisplayField = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NoPrimaryDisplayField.Value"));
			}
		}

		private LocalizableString _closeLS;
		public LocalizableString CloseLS {
			get {
				return _closeLS ?? (_closeLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CloseLS.Value"));
			}
		}

		private LocalizableString _retryLS;
		public LocalizableString RetryLS {
			get {
				return _retryLS ?? (_retryLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RetryLS.Value"));
			}
		}

		private LocalizableString _cancelLS;
		public LocalizableString CancelLS {
			get {
				return _cancelLS ?? (_cancelLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CancelLS.Value"));
			}
		}

		private LocalizableString _inGroupLS;
		public LocalizableString InGroupLS {
			get {
				return _inGroupLS ?? (_inGroupLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InGroupLS.Value"));
			}
		}

		private LocalizableString _oK;
		public LocalizableString OK {
			get {
				return _oK ?? (_oK = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OK.Value"));
			}
		}

		private LocalizableString _missingDisplayValueErrorMessage;
		public LocalizableString MissingDisplayValueErrorMessage {
			get {
				return _missingDisplayValueErrorMessage ?? (_missingDisplayValueErrorMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.MissingDisplayValueErrorMessage.Value"));
			}
		}

		private LocalizableString _informationMessage;
		public LocalizableString InformationMessage {
			get {
				return _informationMessage ?? (_informationMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InformationMessage.Value"));
			}
		}

		private LocalizableString _hasUniqueRecordsMessage;
		public LocalizableString HasUniqueRecordsMessage {
			get {
				return _hasUniqueRecordsMessage ?? (_hasUniqueRecordsMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.HasUniqueRecordsMessage.Value"));
			}
		}

		private LocalizableString _importMessageWithUnique;
		public LocalizableString ImportMessageWithUnique {
			get {
				return _importMessageWithUnique ?? (_importMessageWithUnique = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportMessageWithUnique.Value"));
			}
		}

		private LocalizableString _notUniqueRecord;
		public LocalizableString NotUniqueRecord {
			get {
				return _notUniqueRecord ?? (_notUniqueRecord = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NotUniqueRecord.Value"));
			}
		}

		private LocalizableString _importStartedMessage;
		public LocalizableString ImportStartedMessage {
			get {
				return _importStartedMessage ?? (_importStartedMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportStartedMessage.Value"));
			}
		}

		private LocalizableString _importStartedCaption;
		public LocalizableString ImportStartedCaption {
			get {
				return _importStartedCaption ?? (_importStartedCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ImportStartedCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ControlsEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ControlsEventSubProcess };
			FlowElements[OKButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClick };
			FlowElements[OKButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickScriptTask };
			FlowElements[CancelButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClick };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[ColumnsEditButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnsEditButtonClick };
			FlowElements[ColumnsEditButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnsEditButtonClickScriptTask };
			FlowElements[FileUploadEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { FileUploadEditChange };
			FlowElements[ProductsFileUploadEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductsFileUploadEditChangeScriptTask };
			FlowElements[OpenLogButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLogButtonClickStartMessage };
			FlowElements[OpenLogButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLogButtonClickScriptTask };
			FlowElements[DownloadTemplateMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DownloadTemplateMenuItemClickScriptTask };
			FlowElements[DownloadTemplateButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DownloadTemplateButtonClickStartMessage };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[PageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageEventSubProcess };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[CustomEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CustomEventSubProcess };
			FlowElements[AnalizeDataStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AnalizeDataStartMessage };
			FlowElements[AnalizeDataScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AnalizeDataScriptTask };
			FlowElements[AreInputDataCorrectExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { AreInputDataCorrectExclusiveGateway };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[UserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ThrowSaveProductsIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowSaveProductsIntermediateThrowMessageEvent };
			FlowElements[SaveNewLookupDataStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveNewLookupDataStartMessage };
			FlowElements[OpenNewLookupDataPageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenNewLookupDataPageScript };
			FlowElements[OpenNewLookupDataPageTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenNewLookupDataPageTask };
			FlowElements[ImportYesMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportYesMessageStartMessage };
			FlowElements[ImportYesScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportYesScript };
			FlowElements[ImportNoMessageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportNoMessageStartMessage };
			FlowElements[End2.SchemaElementUId] = new Collection<ProcessFlowElement> { End2 };
			FlowElements[ThrowSaveProductsStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowSaveProductsStartMessage };
			FlowElements[ThrowSaveProductsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowSaveProductsScriptTask };
			FlowElements[SaveProductsStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveProductsStartMessage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ClearSettingsScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearSettingsScript };
			FlowElements[SaveProductsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveProductsScriptTask };
			FlowElements[End3.SchemaElementUId] = new Collection<ProcessFlowElement> { End3 };
			FlowElements[CheckUniqueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckUniqueScriptTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[PrepareUserQuestionScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareUserQuestionScriptTask };
			FlowElements[UniqueImportYesMessageStart.SchemaElementUId] = new Collection<ProcessFlowElement> { UniqueImportYesMessageStart };
			FlowElements[UserMessageUnique.SchemaElementUId] = new Collection<ProcessFlowElement> { UserMessageUnique };
			FlowElements[UniqueImportNoMessageStart.SchemaElementUId] = new Collection<ProcessFlowElement> { UniqueImportNoMessageStart };
			FlowElements[ExecuteImportExcelLookupProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ExecuteImportExcelLookupProcess };
			FlowElements[ChooseImportTypeExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { ChooseImportTypeExclusiveGateway };
			FlowElements[ImportStartedMessageBox.SchemaElementUId] = new Collection<ProcessFlowElement> { ImportStartedMessageBox };
			FlowElements[CloseImportSetingsPage.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseImportSetingsPage };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ObjectEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeStartMessage };
			FlowElements[ObjectEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ControlsEventSubProcess":
						break;
					case "OKButtonClick":
						e.Context.QueueTasks.Enqueue("OKButtonClickScriptTask");
						break;
					case "OKButtonClickScriptTask":
						break;
					case "CancelButtonClick":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "ColumnsEditButtonClick":
						e.Context.QueueTasks.Enqueue("ColumnsEditButtonClickScriptTask");
						break;
					case "ColumnsEditButtonClickScriptTask":
						break;
					case "FileUploadEditChange":
						e.Context.QueueTasks.Enqueue("ProductsFileUploadEditChangeScriptTask");
						break;
					case "ProductsFileUploadEditChangeScriptTask":
						break;
					case "OpenLogButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OpenLogButtonClickScriptTask");
						break;
					case "OpenLogButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "DownloadTemplateMenuItemClickScriptTask":
						break;
					case "DownloadTemplateButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DownloadTemplateMenuItemClickScriptTask");
						break;
					case "OpenLookupUserTask":
						break;
					case "PageEventSubProcess":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "CustomEventSubProcess":
						break;
					case "AnalizeDataStartMessage":
						e.Context.QueueTasks.Enqueue("AnalizeDataScriptTask");
						break;
					case "AnalizeDataScriptTask":
						e.Context.QueueTasks.Enqueue("AreInputDataCorrectExclusiveGateway");
						break;
					case "AreInputDataCorrectExclusiveGateway":
						if (IsValidConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("End1");
							break;
						}
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("UserMessage");
							break;
						}
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "End1":
						break;
					case "UserMessage":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ThrowSaveProductsIntermediateThrowMessageEvent");
							break;
						}
						e.Context.QueueTasks.Enqueue("ChooseImportTypeExclusiveGateway");
						break;
					case "ThrowSaveProductsIntermediateThrowMessageEvent":
						break;
					case "SaveNewLookupDataStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "OpenNewLookupDataPageScript":
						e.Context.QueueTasks.Enqueue("OpenNewLookupDataPageTask");
						break;
					case "OpenNewLookupDataPageTask":
						break;
					case "ImportYesMessageStartMessage":
						e.Context.QueueTasks.Enqueue("ImportYesScript");
						break;
					case "ImportYesScript":
						break;
					case "ImportNoMessageStartMessage":
						e.Context.QueueTasks.Enqueue("End2");
						break;
					case "End2":
						break;
					case "ThrowSaveProductsStartMessage":
						e.Context.QueueTasks.Enqueue("ThrowSaveProductsScriptTask");
						break;
					case "ThrowSaveProductsScriptTask":
						break;
					case "SaveProductsStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ClearSettingsScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("CheckUniqueScriptTask");
						break;
					case "ClearSettingsScript":
						e.Context.QueueTasks.Enqueue("End3");
						break;
					case "SaveProductsScriptTask":
						e.Context.QueueTasks.Enqueue("CloseImportSetingsPage");
						break;
					case "End3":
						break;
					case "CheckUniqueScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("SaveProductsScriptTask");
							break;
						}
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareUserQuestionScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End3");
						break;
					case "PrepareUserQuestionScriptTask":
						e.Context.QueueTasks.Enqueue("UserMessageUnique");
						break;
					case "UniqueImportYesMessageStart":
						e.Context.QueueTasks.Enqueue("SaveProductsScriptTask");
						break;
					case "UserMessageUnique":
						break;
					case "UniqueImportNoMessageStart":
						e.Context.QueueTasks.Enqueue("End3");
						break;
					case "ExecuteImportExcelLookupProcess":
						e.Context.QueueTasks.Enqueue("CloseImportSetingsPage");
						break;
					case "ChooseImportTypeExclusiveGateway":
						if (ConditionalFlow6ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ExecuteImportExcelLookupProcess");
							break;
						}
						e.Context.QueueTasks.Enqueue("OpenNewLookupDataPageScript");
						break;
					case "ImportStartedMessageBox":
						break;
					case "CloseImportSetingsPage":
						e.Context.QueueTasks.Enqueue("ImportStartedMessageBox");
						break;
					case "EventSubProcess1":
						break;
					case "ObjectEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ObjectEditChangeScriptTask");
						break;
					case "ObjectEditChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool IsValidConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(!IsValid);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsValid && !IsAllColumnCaptionsPresent);
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(LookupFieldValuesAndCounts == null);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(UserConnection.SessionData["NewLookupDataPageSuccessfullyClosed"] != null && !(bool)UserConnection.SessionData["NewLookupDataPageSuccessfullyClosed"]);
		}

		private bool ConditionalFlow4ExpressionExecute() {
			return Convert.ToBoolean(!HasUniqueRecords);
		}

		private bool ConditionalFlow5ExpressionExecute() {
			return Convert.ToBoolean(HasUniqueRecords);
		}

		private bool ConditionalFlow6ExpressionExecute() {
			return Convert.ToBoolean(ResolveConflictsAutomatically);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("OKButtonClick");
			ActivatedEventElements.Add("CancelButtonClick");
			ActivatedEventElements.Add("ColumnsEditButtonClick");
			ActivatedEventElements.Add("FileUploadEditChange");
			ActivatedEventElements.Add("OpenLogButtonClickStartMessage");
			ActivatedEventElements.Add("DownloadTemplateButtonClickStartMessage");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("AnalizeDataStartMessage");
			ActivatedEventElements.Add("SaveNewLookupDataStartMessage");
			ActivatedEventElements.Add("ImportYesMessageStartMessage");
			ActivatedEventElements.Add("ImportNoMessageStartMessage");
			ActivatedEventElements.Add("ThrowSaveProductsStartMessage");
			ActivatedEventElements.Add("SaveProductsStartMessage");
			ActivatedEventElements.Add("UniqueImportYesMessageStart");
			ActivatedEventElements.Add("UniqueImportNoMessageStart");
			ActivatedEventElements.Add("ObjectEditChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ControlsEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClick";
					result = OKButtonClick.Execute(context);
					break;
				case "OKButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickScriptTask";
					result = OKButtonClickScriptTask.Execute(context, OKButtonClickScriptTaskExecute);
					break;
				case "CancelButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClick";
					result = CancelButtonClick.Execute(context);
					break;
				case "CancelButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScriptTask";
					result = CancelButtonClickScriptTask.Execute(context, CancelButtonClickScriptTaskExecute);
					break;
				case "ColumnsEditButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnsEditButtonClick";
					result = ColumnsEditButtonClick.Execute(context);
					break;
				case "ColumnsEditButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnsEditButtonClickScriptTask";
					result = ColumnsEditButtonClickScriptTask.Execute(context, ColumnsEditButtonClickScriptTaskExecute);
					break;
				case "FileUploadEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "FileUploadEditChange";
					result = FileUploadEditChange.Execute(context);
					break;
				case "ProductsFileUploadEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductsFileUploadEditChangeScriptTask";
					result = ProductsFileUploadEditChangeScriptTask.Execute(context, ProductsFileUploadEditChangeScriptTaskExecute);
					break;
				case "OpenLogButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLogButtonClickStartMessage";
					result = OpenLogButtonClickStartMessage.Execute(context);
					break;
				case "OpenLogButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLogButtonClickScriptTask";
					result = OpenLogButtonClickScriptTask.Execute(context, OpenLogButtonClickScriptTaskExecute);
					break;
				case "DownloadTemplateMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownloadTemplateMenuItemClickScriptTask";
					result = DownloadTemplateMenuItemClickScriptTask.Execute(context, DownloadTemplateMenuItemClickScriptTaskExecute);
					break;
				case "DownloadTemplateButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownloadTemplateButtonClickStartMessage";
					result = DownloadTemplateButtonClickStartMessage.Execute(context);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "PageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
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
				case "CustomEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AnalizeDataStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AnalizeDataStartMessage";
					result = AnalizeDataStartMessage.Execute(context);
					break;
				case "AnalizeDataScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AnalizeDataScriptTask";
					result = AnalizeDataScriptTask.Execute(context, AnalizeDataScriptTaskExecute);
					break;
				case "AreInputDataCorrectExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "AreInputDataCorrectExclusiveGateway";
					result = AreInputDataCorrectExclusiveGateway.Execute(context);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "UserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessage";
					result = UserMessage.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ThrowSaveProductsIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = ThrowSaveProductsIntermediateThrowMessageEvent.Execute(context);
					break;
				case "SaveNewLookupDataStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveNewLookupDataStartMessage";
					result = SaveNewLookupDataStartMessage.Execute(context);
					break;
				case "OpenNewLookupDataPageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenNewLookupDataPageScript";
					result = OpenNewLookupDataPageScript.Execute(context, OpenNewLookupDataPageScriptExecute);
					break;
				case "OpenNewLookupDataPageTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenNewLookupDataPageTask";
					result = OpenNewLookupDataPageTask.Execute(context);
					break;
				case "ImportYesMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImportYesMessageStartMessage";
					result = ImportYesMessageStartMessage.Execute(context);
					break;
				case "ImportYesScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImportYesScript";
					result = ImportYesScript.Execute(context, ImportYesScriptExecute);
					break;
				case "ImportNoMessageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImportNoMessageStartMessage";
					result = ImportNoMessageStartMessage.Execute(context);
					break;
				case "End2":
					context.QueueTasks.Dequeue();
					break;
				case "ThrowSaveProductsStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ThrowSaveProductsStartMessage";
					result = ThrowSaveProductsStartMessage.Execute(context);
					break;
				case "ThrowSaveProductsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ThrowSaveProductsScriptTask";
					result = ThrowSaveProductsScriptTask.Execute(context, ThrowSaveProductsScriptTaskExecute);
					break;
				case "SaveProductsStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveProductsStartMessage";
					result = SaveProductsStartMessage.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ClearSettingsScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearSettingsScript";
					result = ClearSettingsScript.Execute(context, ClearSettingsScriptExecute);
					break;
				case "SaveProductsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveProductsScriptTask";
					result = SaveProductsScriptTask.Execute(context, SaveProductsScriptTaskExecute);
					break;
				case "End3":
					context.QueueTasks.Dequeue();
					break;
				case "CheckUniqueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckUniqueScriptTask";
					result = CheckUniqueScriptTask.Execute(context, CheckUniqueScriptTaskExecute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "PrepareUserQuestionScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareUserQuestionScriptTask";
					result = PrepareUserQuestionScriptTask.Execute(context, PrepareUserQuestionScriptTaskExecute);
					break;
				case "UniqueImportYesMessageStart":
					context.QueueTasks.Dequeue();
					context.SenderName = "UniqueImportYesMessageStart";
					result = UniqueImportYesMessageStart.Execute(context);
					break;
				case "UserMessageUnique":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserMessageUnique";
					result = UserMessageUnique.Execute(context);
					break;
				case "UniqueImportNoMessageStart":
					context.QueueTasks.Dequeue();
					context.SenderName = "UniqueImportNoMessageStart";
					result = UniqueImportNoMessageStart.Execute(context);
					break;
				case "ExecuteImportExcelLookupProcess":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExecuteImportExcelLookupProcess";
					result = ExecuteImportExcelLookupProcess.Execute(context, ExecuteImportExcelLookupProcessExecute);
					break;
				case "ChooseImportTypeExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChooseImportTypeExclusiveGateway";
					result = ChooseImportTypeExclusiveGateway.Execute(context);
					break;
				case "ImportStartedMessageBox":
					context.QueueTasks.Dequeue();
					context.SenderName = "ImportStartedMessageBox";
					result = ImportStartedMessageBox.Execute(context);
					break;
				case "CloseImportSetingsPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CloseImportSetingsPage";
					result = CloseImportSetingsPage.Execute(context, CloseImportSetingsPageExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ObjectEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChangeStartMessage";
					result = ObjectEditChangeStartMessage.Execute(context);
					break;
				case "ObjectEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChangeScriptTask";
					result = ObjectEditChangeScriptTask.Execute(context, ObjectEditChangeScriptTaskExecute);
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
				case "ResolveConflictsAutomatically":
					ResolveConflictsAutomatically = reader.GetValue<System.Boolean>();
				break;
				case "HasUniqueRecords":
					HasUniqueRecords = reader.GetValue<System.Boolean>();
				break;
				case "ImportMode":
					ImportMode = reader.GetValue<System.Int32>();
				break;
				case "ExcelImportLogSchemaId":
					ExcelImportLogSchemaId = reader.GetValue<System.Guid>();
				break;
				case "IsOnlyErrorsMode":
					IsOnlyErrorsMode = reader.GetValue<System.Boolean>();
				break;
				case "SelectedIdentificationColumns":
					SelectedIdentificationColumns = reader.GetValue<System.String>();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "ColumnStructureExplorerRegistered":
					ColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "ColumnStructureExplorerCreated":
					ColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "UndiscoveredFields":
					UndiscoveredFields = reader.GetValue<System.String>();
				break;
				case "IsPrimaryDisplayColumnExists":
					IsPrimaryDisplayColumnExists = reader.GetValue<System.Boolean>();
				break;
				case "SchemaName":
					SchemaName = reader.GetValue<System.String>();
				break;
				case "SheetName":
					SheetName = reader.GetValue<System.String>();
				break;
				case "ImportedItems":
					ImportedItems = reader.GetSerializableObjectValue();
				break;
				case "Captions":
					Captions = reader.GetSerializableObjectValue();
				break;
				case "ExcelImportId":
					ExcelImportId = reader.GetValue<System.Guid>();
				break;
				case "FileData":
					FileData = reader.GetSerializableObjectValue();
				break;
				case "IsValid":
					IsValid = reader.GetValue<System.Boolean>();
				break;
				case "IsAllColumnCaptionsPresent":
					IsAllColumnCaptionsPresent = reader.GetValue<System.Boolean>();
				break;
				case "CurrencyColumnIndex":
					CurrencyColumnIndex = reader.GetValue<System.Int32>();
				break;
				case "NameColumnIndex":
					NameColumnIndex = reader.GetValue<System.Int32>();
				break;
				case "LookupFieldValuesAndCounts":
					LookupFieldValuesAndCounts = reader.GetSerializableObjectValue();
				break;
				case "LookupColumnsIndexesAndNames":
					LookupColumnsIndexesAndNames = reader.GetSerializableObjectValue();
				break;
				case "HeaderNames":
					HeaderNames = reader.GetSerializableObjectValue();
				break;
				case "RequiredColumnsIndexes":
					RequiredColumnsIndexes = reader.GetSerializableObjectValue();
				break;
				case "FileName":
					FileName = reader.GetValue<System.String>();
				break;
				case "FileContent":
					FileContent = reader.GetValue<System.String>();
				break;
				case "SchemaId":
					SchemaId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OKButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.Clear();
			
			if (string.IsNullOrEmpty(SchemaName)) {
				Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableSelectObjectMessage, MessageType.Warning, true);
				return true;
			}
			
			if (string.Compare(Path.GetExtension(FileName), ".xlsx", true) != 0) {
				Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage, MessageType.Warning, true);
				return true;
			}
			LogInfo(string.Format("\t{0}\t{1}\t{2}\tImport, start", FileName, ExcelImportId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));
			Page.AddScript(string.Format("PageContainer.el.mask('{0}', 'x-mask-loading blue', true, false, true);", Loading));
			
			Page.AddScript(string.Format("{0}.callPageMethod(", Page.FileUploadEdit.ClientID)
			 + "'ThrowEvent', { signalName: 'AnalizeData', "
			 + "formProxyArg: 'htmlForm', "
			 + "viewStateMode: 'include', "
			 + "timeout: 12000000});");
			 
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t{0}\t{1}\t\tClose import window", FileName, ExcelImportId));
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool ColumnsEditButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			if ((Guid)Page.ObjectEdit.Value != Guid.Empty) {
				ShowColumnStructureExplorer(SchemaId);
			}
			return true;
		}

		public virtual bool ProductsFileUploadEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.FileUploadEdit.HasFile) {
				Page.FileUploadEdit.FileContent.Position = 0;
				FileContent = Convert.ToBase64String(Page.FileUploadEdit.FileBytes);
				FileName = Page.FileUploadEdit.FileName;
			}
			Page.CancelButton.Caption = CancelLS;
			Page.OKButton.Caption = OK;
			Page.OKButton.Hidden = false;
			LogInfo(string.Format("\t{0}\t{1}\t\tUpload file (Base64String.Length ={2})", FileName, ExcelImportId, (FileContent == null ? 0 : FileContent.Length)));
			return true;
		}

		public virtual bool OpenLogButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
			OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
			OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
			var pageParameters = 
				(Dictionary <string, object>) OpenLookupUserTask.PageParameters;
			pageParameters.Add("schemaUId", ExcelImportLogSchemaId.ToString());
			pageParameters.Add("editMode", true);
			pageParameters.Add("hideButtons", true);
			Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
			pageParameters.Add("LookupFilters", filters);	
			return true;
		}

		public virtual bool DownloadTemplateMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.Clear();
			if (string.IsNullOrEmpty(SchemaName)) {
				Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableSelectObjectMessage, MessageType.Warning, true);
				return true;
			}
			Page.Response.ClearHeaders();
			Page.Response.ClearContent();
			string fileName = SchemaName;
			var instance = UserConnection.EntitySchemaManager.GetInstanceByName(SchemaName);
			if (instance != null) {
				fileName = instance.Caption.ToString();
			}
			Page.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
			if (HttpContext.Current.Request.Browser.Browser == "IE") {
				string fileNameEnc = HttpUtility.UrlPathEncode(fileName);
				Page.Response.AddHeader("Content-Disposition", "attachment; filename=\"" + fileNameEnc + ".xlsx\"");
			} else {
				Page.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName + ".xlsx");
			}
			List<double> columnWidthsList = new List<double>();
			using (MemoryStream stream = new MemoryStream()) {
				using(SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook)) {
					// Add a WorkbookPart to the document.
					var workbookpart = spreadsheetDocument.AddWorkbookPart();
					workbookpart.Workbook = new OpenXmlSpreadsheet.Workbook();
			
					// Add a WorksheetPart to the WorkbookPart.
					var worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
					var workbookStylesPart = workbookpart.AddNewPart<WorkbookStylesPart>(); 
					worksheetPart.Worksheet = new OpenXmlSpreadsheet.Worksheet(new OpenXmlSpreadsheet.SheetData());
			
					// Add Sheets to the Workbook.
					OpenXmlSpreadsheet.Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<OpenXmlSpreadsheet.Sheets>(new OpenXmlSpreadsheet.Sheets());
			
					// Append a new worksheet and associate it with the workbook.
					string relationshipId = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart);
					string sheetName = fileName;
					OpenXmlSpreadsheet.Sheet sheet = new OpenXmlSpreadsheet.Sheet() {
						Id = relationshipId,
						SheetId = 1, 
						Name = sheetName
					};
					sheets.Append(sheet);
			
					OpenXmlSpreadsheet.Worksheet worksheet = new OpenXmlSpreadsheet.Worksheet();
					OpenXmlSpreadsheet.SheetData sheetData = new OpenXmlSpreadsheet.SheetData();
					OpenXmlSpreadsheet.Row row = new OpenXmlSpreadsheet.Row();
			
					OpenXmlSpreadsheet.Cell currentCell;
					int columnCount = 0;
					var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(SchemaName);
					foreach (EntitySchemaColumn column in entitySchema.Columns) {
						if (!column.DefValue.IsSystemValue &&
								(column.UsageType != EntitySchemaColumnUsageType.Advanced) && 
								(column.UsageType != EntitySchemaColumnUsageType.None) &&
								!column.Name.Equals("ProcessListeners") &&
								!(column.DataValueType is ImageDataValueType) &&
								!(column.DataValueType is ImageLookupDataValueType)) {
							currentCell = new OpenXmlSpreadsheet.Cell();
							currentCell.DataType =  OpenXmlSpreadsheet.CellValues.String;
							if (column.RequirementType == EntitySchemaColumnRequirementType.ApplicationLevel || column.RequirementType == EntitySchemaColumnRequirementType.DBLevel) {
								currentCell.StyleIndex = 3;
							} else {
								currentCell.StyleIndex = 4;
							}
							columnWidthsList.Add(CalculateWidth(column.Caption.Value));
							currentCell.CellValue = new OpenXmlSpreadsheet.CellValue(column.Caption.Value);
							row.AppendChild(currentCell);
						}
					}
					sheetData.Append(row);
					row = new OpenXmlSpreadsheet.Row();
					for (int i=0;i<columnWidthsList.Count; i++) {
						currentCell = new OpenXmlSpreadsheet.Cell();
						currentCell.DataType =  OpenXmlSpreadsheet.CellValues.String;
						currentCell.StyleIndex = 5;
						row.AppendChild(currentCell);
					}
					sheetData.Append(row);
					//Adding columns and specifeing width
					OpenXmlSpreadsheet.Columns columns = new OpenXmlSpreadsheet.Columns();
					uint j = 1;
					foreach (var w in columnWidthsList) {
						columns.Append(CreateColumnData(j, w));
						j++;
					}
					worksheet.Append(columns);
					//--
					worksheet.Append(sheetData);
					
					workbookStylesPart.Stylesheet = CreateStyleSheet();
					worksheetPart.Worksheet = worksheet;
					spreadsheetDocument.Close();
					
					stream.Seek(0, SeekOrigin.Begin);
					byte[] dataArray = stream.ToArray();
			
					Page.Response.BinaryWrite(dataArray);
					Page.Response.End();
				}
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanImportFromExcel");
			Page.DownloadTemplateButton.AjaxEvents.Click.IsUpload = true;
			//Page.DefModeOn.Checked = true;
			Page.Mode1On.Checked = true;
			Page.ResolveConflictsAutomatically.Checked = true;
			
			//object schemaId = Page.GetParameterValue("SchemaId");
			//if (schemaId != null) {
			//	SchemaId = new Guid(schemaId.ToString());
			//} else {
				
			//}
			
			//FillSchemaParameters(false);
			
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			Page.ObjectEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				filters.Add(new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"useDisplayValue", false },
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"rightExpressionParameterValues", new object[] { Page.UserConnection.Workspace.Id }}
				});
				filters.Add(new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.NotContain}, 
					{"leftExpressionColumnPath", "Name"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"InFolder"}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.NotContain}, 
					{"leftExpressionColumnPath", "Name"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"InTag"}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ExtendParent"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {false}}});
			};
			if (ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			return true;
		}

		public virtual bool AnalizeDataScriptTaskExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t{0}\t{1}\t\tAnalize data, start ", FileName, ExcelImportId));
			try {
				UserConnection.SessionData.Remove("NewLookupData");
				UserConnection.SessionData.Remove("NewLookupDataPageSuccessfullyClosed");
				UserConnection.SessionData.Remove("ImportedRowsCount");
				NameColumnIndex = -1;
				CurrencyColumnIndex = -1;
				IsAllColumnCaptionsPresent = true;
				ImportedItems = new List<string>();
				IsValid = true;
				IsOnlyErrorsMode = Page.IsOnlyErrorsMode.Checked;
				//ImportMode = Page.DefModeOn.Checked ? 0 : (Page.Mode1On.Checked ? 1 : 2);
				ImportMode = Page.Mode1On.Checked ? 1 : 2;
				ResolveConflictsAutomatically = Page.ResolveConflictsAutomatically.Checked;
				LogExcelImport();
				byte[] bytes = Convert.FromBase64String(FileContent);
				using (Stream stream = new MemoryStream(bytes)) {
					using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(stream, false)) {
						WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
						SharedStringTablePart stringTablePart = workbookPart.SharedStringTablePart;
						WorksheetPart worksheetPart = GetWorksheetPartByName(workbookPart, SheetName);
						OpenXmlSpreadsheet.SheetData sheetData = worksheetPart.Worksheet.Elements<OpenXmlSpreadsheet.SheetData>().First();
						var sheetDataElements = sheetData.Elements<OpenXmlSpreadsheet.Row>();
						if (sheetDataElements.Count() <= 1) {
							Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage, MessageType.Warning, true);
							IsValid = false;
							Page.AddScript("PageContainer.el.unmask();");
							return true;
						}
						OpenXmlSpreadsheet.Row header = sheetDataElements.Where(r => r.RowIndex == 1).First();
						bool isHeaderNull = (header == null);
						IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Cell> headerElements = null;
						if (!isHeaderNull) {
							headerElements = header.Elements<OpenXmlSpreadsheet.Cell>();
							isHeaderNull = (headerElements.Count() == 0);
						}
						if (isHeaderNull) {
							Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage, MessageType.Warning, true);
							IsValid = false;
							Page.AddScript("PageContainer.el.unmask();");
							return true;
						}
						bool isNullData = CheckIsNullData(sheetDataElements, stringTablePart);
						if (isNullData) {
							return true;
						}
						var captions = new List<string>();
						foreach (OpenXmlSpreadsheet.Cell cell in headerElements) {
							var currentCellValue = GetCellValue(cell, stringTablePart);
							if (currentCellValue != null) {
							 	captions.Add(currentCellValue);
							}
						}
						Captions = captions;
						HeaderNames = new List<string>();
						UndiscoveredFields = string.Empty;
						FormatHeaderNames(captions); // side effects
						if (IsPrimaryDisplayColumnExists && NameColumnIndex == -1) {
							Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage + MissingDisplayValueErrorMessage, MessageType.Warning, true);
							IsValid = false;
							Page.AddScript("PageContainer.el.unmask();");
							return true;
						}
						var requiredFieldsNotFilled = GetRequiredFieldsNotFilled(sheetData, stringTablePart, captions); // side effects (FileData)
						bool isRequiredFieldsNotFilled = CheckRequiredFieldsNotFilled(requiredFieldsNotFilled);
						if (isRequiredFieldsNotFilled) {
							return true;
						}
						LookupFieldValuesAndCounts = GetLookupFieldValuesAndCounts(sheetData, stringTablePart, captions);
						if (!IsAllColumnCaptionsPresent) {
							UserMessage.Page = Page;
							UserMessage.MessageText = string.Format(ImportNotAllColumnsMessage, UndiscoveredFields);
							UserMessage.Icon = "QUESTION";
							UserMessage.Buttons = "YESNO";
							UserMessage.ResponseMessages = new Dictionary<string, string> {
								{"yes", "ImportYesMessage"},
								{"no", "ImportNoMessage"},
							};
							Page.AddScript("PageContainer.el.unmask();");
						}
					}
				}
			}
			catch(Exception e) {
				Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage, MessageType.Warning, true);
				Page.AddScript("PageContainer.el.unmask();");
				return false;
			}
			LogInfo(string.Format("\t{0}\t{1}\t\tAnalize data, end \t\t\t", FileName, ExcelImportId));
			return true;
		}

		public virtual bool OpenNewLookupDataPageScriptExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t{0}\t{1}\t\tOpen window NewLookupDataPage", FileName, ExcelImportId));
			UserConnection.SessionData["NewLookupData"] = LookupFieldValuesAndCounts;
			OpenNewLookupDataPageTask.OpenerInstanceId = InstanceUId;
			OpenNewLookupDataPageTask.UseCurrentActivePage = true;
			OpenNewLookupDataPageTask.PageUId = new Guid("aa6ed9ea-b081-4ec4-a1f0-01d01a38b2a8");
			OpenNewLookupDataPageTask.CloseMessage = "ThrowSaveProducts";
			Page.AddScript(string.Format("PageContainer.el.mask('{0}', 'x-mask-loading blue', true, false, true);", Loading));
			return true;
		}

		public virtual bool ImportYesScriptExecute(ProcessExecutingContext context) {
			Page.AddScript(string.Format("PageContainer.el.mask('{0}', 'x-mask-loading blue', true, false, true);", Loading));
			ThrowEvent(context, "SaveNewLookupData");
			return true;
		}

		public virtual bool ThrowSaveProductsScriptTaskExecute(ProcessExecutingContext context) {
			Page.AddScript(string.Format("{0}.callPageMethod(", Page.FileUploadEdit.ClientID)
			 + "'ThrowEvent', { signalName: 'SaveProducts', "
			 + "formProxyArg: 'htmlForm', "
			 + "viewStateMode: 'include', "
			 + "isUpload: true, "
			 + "timeout: 12000000});");
			 
			return true;
		}

		public virtual bool ClearSettingsScriptExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t{0}\t{1}\t\tClear \"NewLookupDataPageSuccessfullyClosed\"", FileName, ExcelImportId));
			if (UserConnection.SessionData["NewLookupDataPageSuccessfullyClosed"] != null) {
				UserConnection.SessionData.Remove("NewLookupDataPageSuccessfullyClosed");
			}
			
			Page.AddScript("PageContainer.el.unmask();");
			return true;
		}

		public virtual bool SaveProductsScriptTaskExecute(ProcessExecutingContext context) {
			var rows = FileData as string[][];
			int totalRowsCount = rows.Length;
			int importedRowsCount = 0;
			var newLookupDataPageSuccessfullyClosedSessionData =
				UserConnection.SessionData.Pop<object>("NewLookupDataPageSuccessfullyClosed");
			var newLookupDataSessionData = UserConnection.SessionData.Pop<object>("NewLookupData");
			try {
				if (newLookupDataPageSuccessfullyClosedSessionData != null &&
						newLookupDataSessionData != null &&
						(bool)newLookupDataPageSuccessfullyClosedSessionData) {
					var newLookupData = (List<Tuple<Guid, string, string, string, string, 
						KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>)newLookupDataSessionData;
					foreach (var entity in newLookupData) {
						var fileValue = entity.Item2;
						var lookupValue = entity.Item3;
						if (!string.IsNullOrEmpty(lookupValue) && fileValue != lookupValue) {
							var lookup = entity.Item5;
							var lookupName = entity.Item6.Value;
							var indexes = entity.Item7; 
							foreach (var index in indexes) {
								foreach(var subIndex in index.Value) {
									rows[index.Key][subIndex] = lookupValue;
								}
							}
							var excelFileDataInLookups = new Terrasoft.Configuration.ExcelFileDataInLookups(UserConnection);
							excelFileDataInLookups.SetDefColumnValues();
							excelFileDataInLookups.Id = Guid.NewGuid();
							excelFileDataInLookups.FileValue = fileValue;
							excelFileDataInLookups.LookupValue = lookupValue;
							excelFileDataInLookups.LookupName = lookupName;
							excelFileDataInLookups.Save();
							if (!IsOnlyErrorsMode) {
								string message = string.Format(AddNewLookupExcelLocalizableString, 
										"\"" + lookup + "\"", 
										"\"" + fileValue + "\"", 
										"\"" + lookupValue + "\"");
								LogExcelImportLog(message);
							}
						}
					}
				}
				ExecuteImportExcelDataProcess(rows);
			}
			catch (Exception e) {
				Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage, MessageType.Warning, true);
			}
			return true;
		}

		public virtual bool CheckUniqueScriptTaskExecute(ProcessExecutingContext context) {
			//CRM-6240
			var rows = FileData as string[][];
			int totalRowsCount = rows.Length;
			LogInfo(string.Format("\t{0}\t{1}\t\tAdd new {2} lookup, start (window \"NewLookupDataPage\")", FileName, ExcelImportId, totalRowsCount));
			var importedItems = new List<string>();
			HasUniqueRecords = false;
			if (IsPrimaryDisplayColumnExists) {
				try {
					foreach (var row in rows) {
						var primaryDisplayValue = IsPrimaryDisplayColumnExists ? row[NameColumnIndex] : string.Empty;
						if (importedItems.Contains(primaryDisplayValue)) {
							HasUniqueRecords = true;
						}
						importedItems.Add(primaryDisplayValue);
					}
				}
				catch(Exception e) {
					LogInfo(string.Format("\t{0}\t{1}\t\tAdd new {2} lookup, ERROR (window \"NewLookupDataPage\")", FileName, ExcelImportId, totalRowsCount));
				}
			}
			LogInfo(string.Format("\t{0}\t{1}\t\tAdd new {2} lookup, end (window \"NewLookupDataPage\")", FileName, ExcelImportId, totalRowsCount));
			return true;
		}

		public virtual bool PrepareUserQuestionScriptTaskExecute(ProcessExecutingContext context) {
			//CRM-6240
			LogInfo(string.Format("\t{0}\t{1}\t\tShow message \"Has Unique Records\"", FileName, ExcelImportId));
			LogInfo("_Start");
			UserMessageUnique.Page = Page;
			UserMessageUnique.MessageText = HasUniqueRecordsMessage;
			UserMessageUnique.Icon = "QUESTION";
			UserMessageUnique.Buttons = "YESNO";
			UserMessageUnique.ResponseMessages = new Dictionary<string, string> {
				{"yes", "UniqueImportYesMessage"},
				{"no", "UniqueImportNoMessage"},
			};
			Page.AddScript("PageContainer.el.unmask();");
			LogInfo("PrepareUserQuestionScriptTaskExecute_End");
			return true;
		}

		public virtual bool ExecuteImportExcelLookupProcessExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t{0}\t{1}\t\tStarte auto import procces", FileName, ExcelImportId));
			string jobName = "ImportExcelLookupData";
			string jobGroup = "ImportExcelDataGroup";
			string processName = "ImportExcelLookupProcess";
			var processParameters = new Dictionary<string, object>() {
				{"ExcelImportId", ExcelImportId},
				{"LookupEntities", LookupFieldValuesAndCounts},
				{"IsSyncLookupConflicts", true},
				{"IsPrimaryDisplayColumnExists", IsPrimaryDisplayColumnExists},
				{"SelectedIdentificationColumns", SelectedIdentificationColumns},
				{"NameColumnIndex", NameColumnIndex},
				{"Captions", Captions},
				{"FileName", FileName},
				{"SchemaName", SchemaName},
				{"ImportMode", ImportMode},
				{"IsOnlyErrorsMode", IsOnlyErrorsMode},
				{"HeaderNames", HeaderNames},
				{"ImportExcelData", FileData}
			};
			AppScheduler.ScheduleImmediateProcessJob(jobName, jobGroup, processName,
				UserConnection.Workspace.Name, UserConnection.CurrentUser.Name, processParameters);
			return true;
		}

		public virtual bool CloseImportSetingsPageExecute(ProcessExecutingContext context) {
			LogInfo(string.Format("\t{0}\t{1}\t\tClose \"ImportSetingsPage\" and show message \"Started import procces.\"", FileName, ExcelImportId));
			ImportStartedMessageBox.Page = Page;
			ImportStartedMessageBox.WindowCaption = ImportStartedCaption;
			ImportStartedMessageBox.MessageText = ImportStartedMessage;
			ImportStartedMessageBox.Icon = "INFORMATION";
			ImportStartedMessageBox.Buttons = "OK";
			ImportStartedMessageBox.ResponseMessages = new Dictionary<string, string> {
				{"ok", "CancelButtonClick"}
			};
			Page.AddScript("PageContainer.el.unmask();");
			return true;
		}

		public virtual bool ObjectEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			SchemaId = (Guid)Page.ObjectEdit.Value;
			Page.ColumnsEdit.Clear();
			Page.FileUploadEdit.Clear();
			FillSchemaParameters(true);
			return true;
		}

		public virtual int FormatHeaderNames(List<string> captions) {
			LogInfo(string.Format("\t{0}\t{1}\t\tMethods: FormatHeaderNames", FileName, ExcelImportId));
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(SchemaName); // captions
			int index = 0;
			var requiredColumnsIndexes = new List<int>();
			var lookupColumnsIndexes = new Dictionary<int, string>();
			IsPrimaryDisplayColumnExists = (entitySchema.PrimaryDisplayColumn != null);
			string primaryDisplayColumnName = IsPrimaryDisplayColumnExists ? entitySchema.PrimaryDisplayColumn.Name : string.Empty;
			foreach (string caption in captions) {
				bool isColumnCaptionsPresent = false;
				foreach (var column in entitySchema.Columns) {
					if ((string.Compare(column.Caption.Value, caption, true) == 0) ||
						((string.Compare(column.Name, caption, true) == 0))){
						AddHeaderAndCaption(column.Name);
						if (column.RequirementType == EntitySchemaColumnRequirementType.ApplicationLevel
							|| column.RequirementType == EntitySchemaColumnRequirementType.DBLevel) {
							requiredColumnsIndexes.Add(index);
						}
			
						if (column.IsLookupType && !lookupColumnsIndexes.ContainsKey(index)) {
							lookupColumnsIndexes.Add(index, column.ReferenceSchema.Name);
						}
			
						if (IsPrimaryDisplayColumnExists && column.Name == primaryDisplayColumnName) {
							NameColumnIndex = index;
						} 
						isColumnCaptionsPresent = true;
						break;
					}
				}
				if (IsAllColumnCaptionsPresent && !isColumnCaptionsPresent) {
					IsAllColumnCaptionsPresent = isColumnCaptionsPresent;
				}
				if (!isColumnCaptionsPresent) {
					AddHeaderAndCaption(string.Empty);
					if (string.IsNullOrEmpty(UndiscoveredFields)) {
						UndiscoveredFields += "<" + caption + ">";
					} else {
						UndiscoveredFields += ", <" + caption + ">";
					}
				}
				index++;
			}
			
			RequiredColumnsIndexes = requiredColumnsIndexes;
			LookupColumnsIndexesAndNames = lookupColumnsIndexes;
			return index;
		}

		public virtual void AddHeaderAndCaption(string name) {
			var headerNames = HeaderNames as List<string>;
			headerNames.Add(name);
		}

		public virtual string GetCellValue(OpenXmlSpreadsheet.Cell cell, SharedStringTablePart stringTablePart) {
			if (cell.ChildElements.Count == 0) {
				return null;
			}
			
			string value = cell.CellValue.InnerText;
			
			if (cell.DataType != null && cell.DataType == OpenXmlSpreadsheet.CellValues.SharedString) {
				value = stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
			}
			
			return value;
		}

		public virtual List<string> GetRequiredFieldsNotFilled(OpenXmlSpreadsheet.SheetData sheetData, SharedStringTablePart stringTablePart, List<string> captions) {
			LogInfo(string.Format("\t{0}\t{1}\t\tMethods: GetRequiredFieldsNotFilled", FileName, ExcelImportId));
			var requiredColumnsIndexes = RequiredColumnsIndexes as List<int>;
			var requiredFieldsNotFilled = new List<string>();
			
			var rows = new List<string[]>();
			var rowIndex = 0;
			
			var rowsData = sheetData.Elements<OpenXmlSpreadsheet.Row>()
				.Where(row => row.RowIndex > 1);
			foreach (var row in rowsData) {
				if (row.Elements<OpenXmlSpreadsheet.Cell>().Count() == 0) {
					continue;
				}
			
				var isNullData = true;
				foreach (var cell in row.Elements<OpenXmlSpreadsheet.Cell>()) {
					if (GetCellValue(cell, stringTablePart) != null) {
						isNullData = false;
						break;
					}
				}
			
				if (isNullData) {
					continue;
				}
			
				var captionsCount = captions.Count;
				rows.Add(new string[captionsCount]);
				int index = 0;
				bool requiredFieldsBeforeImport = Page.CheckRequiredFieldsBeforeImportCheckBox.Checked;
				foreach (var cell in row.Elements<OpenXmlSpreadsheet.Cell>()) {
					if (index >= captionsCount) {
						break;
					}
					int? cellColumnIndex = (int?)GetColumnIndexFromName(GetColumnName(cell.CellReference));
					
					if (cellColumnIndex != null && index < cellColumnIndex) {
						do {
							string caption = captions[index];
							if (requiredColumnsIndexes.Contains(index) && !requiredFieldsBeforeImport) {
								if (!requiredFieldsNotFilled.Contains(caption)) {
									requiredFieldsNotFilled.Add(caption);
								}
							} 
							rows[rowIndex][index] = string.Empty;
							index++;
						} while (index < cellColumnIndex); //captionsCount);
					} 
			
					var value = GetCellValue(cell, stringTablePart);
					if (requiredColumnsIndexes.Contains(index) && string.IsNullOrEmpty(value) && !requiredFieldsBeforeImport) {
						string caption = captions[index];
						if (!requiredFieldsNotFilled.Contains(caption)) {
							requiredFieldsNotFilled.Add(caption);
						}
					}
					rows[rowIndex][index] = value != null ? value : string.Empty;
					index++;
				}
				if (index < captionsCount) {
					string caption = captions[index];
					do {
						if (requiredColumnsIndexes.Contains(index) && !requiredFieldsBeforeImport) {
							if (!requiredFieldsNotFilled.Contains(caption)) {
								requiredFieldsNotFilled.Add(caption);
							}
						} 
						rows[rowIndex][index] = string.Empty;
						index++;
					} while (index < captionsCount);
				}
				rowIndex++;
			}
			
			FileData = rows.ToArray();
			return requiredFieldsNotFilled;
		}

		public virtual string GetColumnName(string cellReference) {
			Regex regex = new Regex("[A-Za-z]+");
			Match match = regex.Match(cellReference);
			return match.Value;
		}

		public virtual int? GetColumnIndexFromName(string columnName) {
			string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if(columnName.Length > 1) {
				int colIndex = 0;
				for(int q = 0; q <= columnName.Length - 1; q++) {
					var s = columnName.Substring(q,1);
					int indexEntry = letters.IndexOf(s);
					if (columnName.Length - 1 != q) {			
						colIndex += (indexEntry + 1)*26;
					} else {
						colIndex += indexEntry;
					}
				}
				return colIndex;
			}
			
			int? columnIndex = null;
			
			string[] colLetters = Regex.Split(columnName, "([A-Z]+)");
			colLetters = colLetters.Where(s => !string.IsNullOrEmpty(s)).ToArray();
			
			if (colLetters.Count() <= 2)
			{
			    int index = 0;
			    foreach (string col in colLetters)
			    {
			        List<char> col1 = colLetters.ElementAt(index).ToCharArray().ToList();
			        int? indexValue = letters.IndexOf(col1.ElementAt(index));
			
			        if (indexValue != -1)
			        {
			            if (index == 0 && colLetters.Count() == 2)
			            {
			                columnIndex = columnIndex == null ? (indexValue + 1) * 26 : columnIndex + ((indexValue + 1) * 26);
			            }
			            else
			            {
			                columnIndex = columnIndex == null ? indexValue : columnIndex + indexValue;
			            }
			        }
			
			        index++;
			    }
			}
			
			return columnIndex;
		}

		public virtual List<Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>> GetLookupFieldValuesAndCounts(OpenXmlSpreadsheet.SheetData sheetData, SharedStringTablePart stringTablePart, List<string> captions) {
			var lookupFieldValuesAndCounts = new List<Tuple<Guid, string, string, string, string,
					KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>();
			var lookupColumnsIndexesAndNames = LookupColumnsIndexesAndNames as Dictionary<int, string>;
			LogInfo(string.Format("\t{0}\t{1}\t\tMethods: GetLookupFieldValuesAndCounts (lookup columns count {2})", FileName, ExcelImportId,
				(lookupColumnsIndexesAndNames == null ? 0: lookupColumnsIndexesAndNames.Count)));
			var rows = FileData as string[][];
			var checkNewLookupDataPageNumber = 0;
			var values = new List<string>();
			if (rows != null) {
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var excelFileDataInLookupsEntitySchema = entitySchemaManager.GetInstanceByName("ExcelFileDataInLookups");
				string excelFileDataInLookupsEntitySchemaName = excelFileDataInLookupsEntitySchema.Name;
				var sysLookupEntitySchema = entitySchemaManager.GetInstanceByName("SysLookup");
				string sysLookupEntitySchemaName = sysLookupEntitySchema.Name;
				string entitySchemaName;
				EntitySchema entitySchema;
				Guid entitySchemaUId;
				string entitySchemaPrimaryDisplayColumnName;
				int i;
				int pageRecordsCount = 1000;
				int rowNumberStart = 0;
				int rowNumberEnd = pageRecordsCount;
				foreach (KeyValuePair<int, string> lookupColumnsIndexesAndNamesPair in lookupColumnsIndexesAndNames) {
					i = lookupColumnsIndexesAndNamesPair.Key;
					while (rowNumberEnd < rows.Length) {
						rowNumberStart = checkNewLookupDataPageNumber * pageRecordsCount;
						rowNumberEnd = rowNumberStart + pageRecordsCount;
						if (rowNumberEnd > rows.Length) {
							rowNumberEnd = rows.Length;
						}
						for (var j = rowNumberStart; j < rowNumberEnd; j++) {
							var rowElement = rows[j][i];
							if (!values.Contains(rowElement) && !string.IsNullOrEmpty(rowElement)) {
								values.Add(rowElement);
							}
						}
						if (values.Count == 0) {
							checkNewLookupDataPageNumber++;
							continue;
						}
						entitySchemaName = lookupColumnsIndexesAndNamesPair.Value;
						entitySchema = entitySchemaManager.GetInstanceByName(entitySchemaName);
						entitySchemaUId = entitySchema.UId;
						var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchemaName);
						entitySchemaPrimaryDisplayColumnName = entitySchema.PrimaryDisplayColumn.Name;
						var idColumn = entitySchemaQuery.AddColumn(entitySchemaPrimaryDisplayColumnName);
						entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
							entitySchemaPrimaryDisplayColumnName, values.ToArray()));
						var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
						foreach (var entity in entityCollection) {
							var primaryDisplayColumnValue = entity.GetTypedColumnValue<string>(entitySchemaPrimaryDisplayColumnName);
							if (values.Contains(primaryDisplayColumnValue)) {
								values.Remove(primaryDisplayColumnValue);
							}
						}
						if (values.Count > 0) {
							var notFoundItems = new object[values.Count];
							var notFoundItemsList = new List<string>();
							for (var k = 0; k < notFoundItems.Length; k++) {
								var currentValue = values[k];
								notFoundItems[k] = currentValue;
								notFoundItemsList.Add(currentValue);
							}
							entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, excelFileDataInLookupsEntitySchemaName);
							var lookupValueColumnName = entitySchemaQuery.AddColumn("LookupValue").Name;
							var fileValueColumnName = entitySchemaQuery.AddColumn("FileValue").Name;
							entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "FileValue", notFoundItems));
							entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "LookupName", entitySchemaName));
							entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
							var notFountItemsConnection = new Dictionary<string, string>();
							if (entityCollection.Count > 0) {
								foreach (var entity in entityCollection) {
									string fileValueColumnValue = entity.GetTypedColumnValue<string>(fileValueColumnName);
									string lookupValueColumnValue = entity.GetTypedColumnValue<string>(lookupValueColumnName);
									if (!notFountItemsConnection.ContainsKey(fileValueColumnValue)) {
										notFountItemsConnection.Add(fileValueColumnValue, lookupValueColumnValue);
									}
								}
								for (int f = rowNumberStart; f < rowNumberEnd; f++) {
									var currentValue = rows[f][i];
									if (notFountItemsConnection.ContainsKey(currentValue)) {
										rows[f][i] = notFountItemsConnection[currentValue];
									}
								}
							}
							var sysLookupEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, sysLookupEntitySchemaName);
							var nameColumn = sysLookupEntitySchemaQuery.AddColumn("Name");
							sysLookupEntitySchemaQuery.Filters.Add(sysLookupEntitySchemaQuery.CreateFilterWithParameters(
								FilterComparisonType.Equal, "SysEntitySchemaUId", entitySchemaUId));
							var sysLookupEntitySchemaQueryEntityCollection = sysLookupEntitySchemaQuery.GetEntityCollection(UserConnection);
							var lookupName = string.Empty;
							if (sysLookupEntitySchemaQueryEntityCollection.Count > 0) {
								var entity = sysLookupEntitySchemaQueryEntityCollection[0];
								lookupName = entity.GetTypedColumnValue<string>(nameColumn.Name);
							}
							if (string.IsNullOrEmpty(lookupName)) {
								lookupName = entitySchema.Caption;
							}
							var caption = captions[i];
							for (var p = rowNumberStart; p < rowNumberEnd; p++) {
								var value = rows[p][i];
								if (!notFoundItemsList.Contains(value)) {
									continue;
								}
								if (lookupFieldValuesAndCounts.Count > 0) {
									var isPresent = false;
									foreach (var item in lookupFieldValuesAndCounts) {
										if (item.Item2 == value && item.Item6.Value == entitySchemaName) {
											var indexes = item.Item7;
											if (indexes.ContainsKey(p)) {
												indexes[p].Add(i);
											} else {
												indexes.Add(p, new Collection<int>(){i});
											}
											lookupFieldValuesAndCounts.Add(
												new Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>(
													Guid.NewGuid(), value, string.Empty, caption, lookupName,
														new KeyValuePair<Guid, string> (entitySchemaUId, entitySchemaName), indexes));
											isPresent = true;
											lookupFieldValuesAndCounts.Remove(item);
											break;
										}
									}
									if (!isPresent) {
										var indexes = new Dictionary<int, Collection<int>> ();
										indexes.Add(p, new Collection<int>(){i});
										lookupFieldValuesAndCounts.Add(
											new Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>(
												Guid.NewGuid(), value, string.Empty, caption, lookupName,
													new KeyValuePair<Guid, string> (entitySchemaUId, entitySchemaName), indexes));
									}
								} else {
									var indexes = new Dictionary<int, Collection<int>> ();
									indexes.Add(p, new Collection<int>(){i});
									lookupFieldValuesAndCounts.Add(
										new Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>(
											Guid.NewGuid(), value, string.Empty, caption, lookupName,
												new KeyValuePair<Guid, string> (entitySchemaUId, entitySchemaName), indexes));
								}
							}
						}
						checkNewLookupDataPageNumber++;
					}
					checkNewLookupDataPageNumber = 0;
					rowNumberStart = 0;
					rowNumberEnd = pageRecordsCount;
					values.Clear();
				}
			}
			return (lookupFieldValuesAndCounts.Count > 0) ? lookupFieldValuesAndCounts : null;
		}

		public virtual bool CreateItem(List<string> row) {
			var name = IsPrimaryDisplayColumnExists ? row[NameColumnIndex] : string.Empty;
			var importedItems = ImportedItems as List<string>;
			var headerNames = HeaderNames as List<string>;
			var nowParameter = new QueryParameter("now", DateTime.UtcNow, "DateTime");
			var currentUserContactIdParameter = new QueryParameter("currentUserId", UserConnection.CurrentUser.ContactId);
			var dateIndexes = new List<int>();
			var isFetched = false;
			var allIdentificationColumsAreInFile = true;
			
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName(SchemaName); 
			var itemEntity = entitySchema.CreateEntity(UserConnection);
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
			var itemEntityIdColumn = entitySchemaQuery.AddColumn(entitySchema.GetPrimaryColumnName());
			//CR [170759] DO
			if (!string.IsNullOrEmpty(SelectedIdentificationColumns)) {
				var identifiedColumns = Json.Deserialize(SelectedIdentificationColumns) as JArray;
				foreach(var column in identifiedColumns) {
					var identifiedColumnName = entitySchema.FindSchemaColumnByMetaPath(column["metaPath"].ToString()).Name;
					
					var rowIndex = headerNames.IndexOf(identifiedColumnName);
					if (rowIndex < 0) { //Все ли выбранные поля для идентификации присутствуют в файле?
						allIdentificationColumsAreInFile = false;
						continue;
					}
					var excelColumnValue = row[rowIndex];
					var identifiedQueryColumn = entitySchemaQuery.AddColumn(identifiedColumnName);
					if (itemEntity.Schema.Columns.FindByName(identifiedColumnName).IsLookupType) {
						if (!string.IsNullOrEmpty(excelColumnValue)) {
							var fieldEntitySchema = entitySchema.Columns.FindByName(identifiedColumnName).ReferenceSchema; 
							var subEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, fieldEntitySchema.Name);
							var idColumn = subEntitySchemaQuery.AddColumn(fieldEntitySchema.GetPrimaryColumnName());
							subEntitySchemaQuery.Filters.Add(subEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, fieldEntitySchema.PrimaryDisplayColumn.Name, excelColumnValue));
							var subEntityCollection = subEntitySchemaQuery.GetEntityCollection(UserConnection);
							if (subEntityCollection.Count > 0) {
								entitySchemaQuery.Filters.Add(
									entitySchemaQuery.CreateFilterWithParameters(
										FilterComparisonType.Equal, 
										identifiedQueryColumn.Name, 
										subEntityCollection[0].GetTypedColumnValue<Guid>(idColumn.Name)
									)
								);
							} else {
								entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateIsNullFilter(identifiedQueryColumn.Name));
							}
						} else {
							entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateIsNullFilter(identifiedQueryColumn.Name));
						}
					} else {
						entitySchemaQuery.Filters.Add(
							entitySchemaQuery.CreateFilterWithParameters(
								FilterComparisonType.Equal, 
								identifiedQueryColumn.Name, 
								excelColumnValue
							)
						);
					}
				}
				var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entityCollection.Count > 0) {
					if (allIdentificationColumsAreInFile) {
						isFetched = itemEntity.FetchFromDB(entityCollection[0].GetTypedColumnValue<Guid>(itemEntityIdColumn.Name));
					}
				}
			} else {
				//--DO
				if (IsPrimaryDisplayColumnExists) {
					var primaryDisplayColumnName = entitySchema.PrimaryDisplayColumn.Name;
					var nameColumn = entitySchemaQuery.AddColumn(primaryDisplayColumnName);
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, nameColumn.Name, name));
					var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);		
					if (entityCollection.Count > 0) {
						isFetched = itemEntity.FetchFromDB(entityCollection[0].GetTypedColumnValue<Guid>(itemEntityIdColumn.Name));
					} 
				}
			}
			
			if (!isFetched) {
				itemEntity.SetDefColumnValues();
				itemEntity.SetColumnValue("Id", Guid.NewGuid());
			}
			
			for (int index = 0; index < row.Count; index++) {
				string columnName = headerNames[index];
				string columnValue = row[index];
				var itemColumn = itemEntity.Schema.Columns.FindByName(columnName);
				if (itemColumn == null || (ImportMode == 2 && string.IsNullOrEmpty(columnValue))) {
					continue;
				}
				if (itemColumn.IsLookupType) {
					if (!string.IsNullOrEmpty(columnValue)) {
						var fieldEntitySchema = entitySchema.Columns.FindByName(columnName).ReferenceSchema; 
						entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, fieldEntitySchema.Name);
						var idColumn = entitySchemaQuery.AddColumn(fieldEntitySchema.GetPrimaryColumnName());
						entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, fieldEntitySchema.PrimaryDisplayColumn.Name, columnValue));
						var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
						if (entityCollection.Count > 0) {
							itemEntity.SetColumnValue(entitySchema.Columns.FindByName(columnName), entityCollection[0].GetTypedColumnValue<Guid>(idColumn.Name));
						}
					} else {
						itemEntity.SetColumnValue(entitySchema.Columns.FindByName(columnName), null);
					}
				} else {
					if (entitySchema.Columns.FindByName(columnName).ValueType == typeof(System.DateTime)) {
						dateIndexes.Add(index);
						if (!string.IsNullOrEmpty(columnValue)) {
							double time;
							DateTime date;
							if (Double.TryParse(columnValue.Replace('.', ','), out time)) {
								itemEntity.SetColumnValue(columnName, DateTime.FromOADate(time));
							} else if (DateTime.TryParse(columnValue, out date)) {
								itemEntity.SetColumnValue(columnName, date);
							}
						}
					} else if (entitySchema.Columns.FindByName(columnName).ValueType == typeof(Decimal)) {
						Decimal decimalValue;
						CultureInfo currentCulture = UserConnection.CurrentUser.Culture;
						string cultureSpecificValue = Regex.Replace(columnValue, "[,.]", currentCulture.NumberFormat.NumberDecimalSeparator);
						if (Decimal.TryParse(cultureSpecificValue, out decimalValue)) {
							itemEntity.SetColumnValue(columnName, decimalValue);
						}
					} else if (entitySchema.Columns.FindByName(columnName).ValueType == typeof(bool) && !string.IsNullOrEmpty(columnValue)) {
						itemEntity.SetColumnValue(columnName, columnValue);
					} else if (entitySchema.Columns.FindByName(columnName).ValueType == typeof(string)) {
						itemEntity.SetColumnValue(columnName, columnValue);
					} else if (string.IsNullOrEmpty(columnValue)) {
						itemEntity.SetColumnValue(columnName, null);
					} else {
						itemEntity.SetColumnValue(columnName, columnValue);
					}
				}
			}
			
			itemEntity.Save();
			
			var messageText = isFetched ? UpdateItemLocalizableString
										: AddItemLocalizableString;
			var captions = Captions as List<string>;
			var values = new StringBuilder(messageText);
			values.Append(" ");
			
			for (int i = 0; i < row.Count; i++) {
				values.Append(captions[i]);
				values.Append(" = \"");
				if (!dateIndexes.Contains(i)) {
					values.Append(row[i]);
				} else {
					if (!string.IsNullOrEmpty(row[i])) {
						double time;
						if (Double.TryParse(row[i].Replace('.',','), out time)) {
							values.Append(DateTime.FromOADate(time).Date.ToString("dd.MM.yyyy"));
						} else {
							values.Append(string.Empty);
						}
					} else {
						values.Append(string.Empty);
					}
				}
				if (i != row.Count -1) {
					values.Append("\"; ");
				} else {
					values.Append("\".");
				}
			}
			
			if (!IsOnlyErrorsMode) {
				//CRM-6240
				var message = values.ToString();
				if (IsPrimaryDisplayColumnExists) {
					if (importedItems.Contains(name)) {
						message += NotUniqueRecord;
					} else {
						importedItems.Add(name);
						ImportedItems = importedItems;
					}
				}
				LogExcelImportLog(message);
			}
			return true;
		}

		public virtual WorksheetPart GetWorksheetPartByName(WorkbookPart workbookPart, string sheetName) {
			LogInfo(string.Format("\t{0}\t{1}\t\tGet worksheet part", FileName, ExcelImportId));
			IEnumerable<OpenXmlSpreadsheet.Sheet> sheets = workbookPart.Workbook.GetFirstChild<OpenXmlSpreadsheet.Sheets>().
				Elements<OpenXmlSpreadsheet.Sheet>().Where(s => s.Name == sheetName);
			
			if (sheets.Count() == 0) {
				if (workbookPart.WorksheetParts.Count() > 0) {
					return workbookPart.WorksheetParts.First();
				} else {
					return null;
				}
			}
			
			string relationshipId = sheets.First().Id.Value;
			WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(relationshipId);
			return worksheetPart;
		}

		public virtual void FillSchemaParameters(bool IsId) {
			SchemaName = string.Empty;
			if (SchemaId != Guid.Empty) {
				//var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwSysSchemaInSolution");
				var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwSysSchemaInWorkspace");
				var id = entitySchemaQuery.AddColumn("Id").Name;
				var caption = entitySchemaQuery.AddColumn("Caption").Name;
				var name = entitySchemaQuery.AddColumn("Name").Name;	
				if (IsId) {
					//entitySchemaQuery.AddColumn("SysSchema");
					entitySchemaQuery.AddColumn("UId");
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SchemaId));
				} else {
					//entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysSchema", SchemaId));
					
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysWorkspace", UserConnection.Workspace.Id));
					entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "UId", SchemaId));
				}
				var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (collection.Count > 0) {
					if (IsId) {
						//SchemaId = collection[0].GetTypedColumnValue<Guid>("SysSchemaId");
						SchemaId = collection[0].GetTypedColumnValue<Guid>("UId");
					}
					Page.ObjectEdit.SetValueAndText(collection[0].GetTypedColumnValue<Guid>(id), collection[0].GetTypedColumnValue<string>(caption));
					SchemaName = collection[0].GetTypedColumnValue<string>(name);
				}
			}
			Page.DownloadTemplateButton.Enabled = (SchemaName != string.Empty);
		}

		public virtual void ShowColumnStructureExplorer(Guid entitySchemaUId) {
			LogInfo("ShowColumnStructureExplorer_Start");
			if (!ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			var sructureExplorer = (StructureExplorer) ColumnStructureExplorer;
			if (sructureExplorer == null) {
				return;
			}
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
			sructureExplorer.ManagerName = entitySchemaManager.Name;
			
			if (!string.IsNullOrEmpty(SelectedIdentificationColumns)) {
				var dataSourceStructureColumnCollection = new DataSourceStructureColumnCollection();
				var macrosList = Json.Deserialize(SelectedIdentificationColumns) as JArray;
				for (int i = 0; i < macrosList.Count; i++) {
					var dataSourceStructureColumn = new DataSourceStructureColumn();
					dataSourceStructureColumn.UId = Guid.NewGuid();
					dataSourceStructureColumn.MetaPath = macrosList[i].Value<string>("metaPath");
					dataSourceStructureColumn.Name =  schema.GetSchemaColumnPathByMetaPath(dataSourceStructureColumn.MetaPath);
					dataSourceStructureColumn.Caption = macrosList[i].Value<string>("caption");
					dataSourceStructureColumn.MetaPathCaption = macrosList[i].Value<string>("metaPathCaption");
					dataSourceStructureColumn.DataValueType = schema.FindSchemaColumnByMetaPath(dataSourceStructureColumn.MetaPath).DataValueType;
				
					if (!string.IsNullOrEmpty(macrosList[i].Value<string>("aggregationType"))
						&& string.Compare(macrosList[i].Value<string>("aggregationType"), "None", true) != 0) {
						
						dataSourceStructureColumn.AggregationType = (AggregationType)Enum.Parse(typeof(AggregationType),
							macrosList[i].Value<string>("aggregationType"));
						if (dataSourceStructureColumn.AggregationType == AggregationType.Count) {
							DataValueTypeManager dataValueTypeManager = dataSourceStructureColumn.DataValueType.DataValueTypeManager;
							dataSourceStructureColumn.DataValueType = dataValueTypeManager.GetInstanceByName("Integer");
						}	
						
						if (!string.IsNullOrEmpty(macrosList[i].Value<string>("subFilters"))) {
							dataSourceStructureColumn.SubFilters =  macrosList[i].Value<string>("subFilters");
						}
					}
					dataSourceStructureColumnCollection.Add(dataSourceStructureColumn);
				}
				sructureExplorer.Columns = dataSourceStructureColumnCollection;
			}
			LogInfo("ShowColumnStructureExplorer_sructureExplorer.ShowEditWindow");
			sructureExplorer.ShowEditWindow(schema, null);
			LogInfo("ShowColumnStructureExplorer_End");
			return;
		}

		public virtual void CreateColumnStructureExplorer() {
			LogInfo(string.Format("\t{0}\t{1}\t\tMethods: CreateColumnStructureExplorer", FileName, ExcelImportId));
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);
			var structureExplorer = new StructureExplorer(Page.ColumnsEdit, "columns", true, false, string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			structureExplorer.IsShowOppositeReference = true;
			
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(SetMetaPathInfo);
			editComplete.ExtraParameters.Add(param);
			structureExplorer.Columns = new DataSourceStructureColumnCollection();
			
			if (!ColumnStructureExplorerRegistered) {
				structureExplorer.Register();
				ColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorerCreated = true;
			
			ColumnStructureExplorer = structureExplorer;
		}

		public virtual void SetMetaPathInfo(object sender, AjaxEventArgs e) {
			var column = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JArray;
			var macroses = e.ExtraParameters["itemsInfo"]!="[]" ? new StringBuilder(e.ExtraParameters["itemsInfo"]) : new StringBuilder();
			
			SelectedIdentificationColumns = macroses.ToString();
			var result = Json.Deserialize(SelectedIdentificationColumns) as JArray;
			string resultStr = "@";
			foreach(var selectedColumn in result) {
				resultStr += ", "+selectedColumn["caption"];
			}
			Page.ColumnsEdit.Text = resultStr.Replace("@, ", "");
			return;
		}

		public virtual double CalculateWidth(string ColumnText) {
			if(ColumnText == null) return 8.43;
			double ColumnWidth = ColumnText.Length * 1.1219642 + 1.5;
			if(ColumnWidth < 8.43) ColumnWidth = 8.43;
			return ColumnWidth;
		}

		public virtual OpenXmlSpreadsheet.Column CreateColumnData(UInt32 ColumnIndex, double ColumnWidth) {
			OpenXmlSpreadsheet.Column column;
			column = new OpenXmlSpreadsheet.Column();
			column.Min = ColumnIndex;
			column.Max = column.Min;
			column.Width = ColumnWidth;
			column.CustomWidth = true;
			return column;
		}

		public virtual OpenXmlSpreadsheet.Stylesheet CreateStyleSheet() {
			using (MemoryStream stream = new MemoryStream()) {
				using(SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook)) {
			
					OpenXmlSpreadsheet.Stylesheet stylesheet = new OpenXmlSpreadsheet.Stylesheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
					stylesheet.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
					stylesheet.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
					
					var fonts = new OpenXmlSpreadsheet.Fonts();
					//Font Index 0
					var font = new OpenXmlSpreadsheet.Font();
					var fontName = new OpenXmlSpreadsheet.FontName {Val = StringValue.FromString("Calibri")};
					var fontSize = new OpenXmlSpreadsheet.FontSize {Val = DoubleValue.FromDouble(11)};
					font.FontName = fontName;
					font.FontSize = fontSize;		
					fonts.Append(font);
					//Font Index 1		
					font = new OpenXmlSpreadsheet.Font();
					fontName = new OpenXmlSpreadsheet.FontName {Val = StringValue.FromString("Calibri")};
					fontSize = new OpenXmlSpreadsheet.FontSize {Val = DoubleValue.FromDouble(11)};				
					font.FontName = fontName;
					font.FontSize = fontSize;
					font.Bold = new OpenXmlSpreadsheet.Bold();
					fonts.Append(font);
					
					//Font Index 1 - red font
					font = new OpenXmlSpreadsheet.Font();
					fontName = new OpenXmlSpreadsheet.FontName {Val = StringValue.FromString("Calibri")};
					fontSize = new OpenXmlSpreadsheet.FontSize {Val = DoubleValue.FromDouble(11)};				
					font.FontName = fontName;
					font.FontSize = fontSize;
					//System.Drawing.Color fontColor = System.Drawing.Color.FromName("Red");
					//var redColor = new DocumentFormat.OpenXml.Spreadsheet.Color() { Rgb = string.Format("{0:x2}{1:x2}{2:x2}{3:x2}", fontColor.A, fontColor.R, fontColor.G, fontColor.B).ToUpper() };
					var orangeColor = new DocumentFormat.OpenXml.Spreadsheet.Color() { Rgb = string.Format("{0:x2}{1:x2}{2:x2}{3:x2}", 255, 239, 124, 16).ToUpper()};
					font.Color = orangeColor;
					font.Bold = new OpenXmlSpreadsheet.Bold();
					fonts.Append(font);
					
					fonts.Count = UInt32Value.FromUInt32((uint)fonts.ChildElements.Count);
					/*fills*/
					var fills = new OpenXmlSpreadsheet.Fills();
					var fill = new OpenXmlSpreadsheet.Fill();
					var patternFill = new OpenXmlSpreadsheet.PatternFill {PatternType = OpenXmlSpreadsheet.PatternValues.None};
					fill.PatternFill = patternFill;
					fills.Append(fill);
					fill = new OpenXmlSpreadsheet.Fill();
					patternFill = new OpenXmlSpreadsheet.PatternFill {PatternType = OpenXmlSpreadsheet.PatternValues.Gray125};
					fill.PatternFill = patternFill;
					fills.Append(fill);
					
					//Fill index  2
					fill = new OpenXmlSpreadsheet.Fill();
					patternFill = new OpenXmlSpreadsheet.PatternFill {
						PatternType = OpenXmlSpreadsheet.PatternValues.Solid, 
						ForegroundColor = new OpenXmlSpreadsheet.ForegroundColor()
					};
					patternFill.ForegroundColor = TranslateForeground(System.Drawing.Color.Coral);
					patternFill.BackgroundColor = new OpenXmlSpreadsheet.BackgroundColor {Rgb = patternFill.ForegroundColor.Rgb};
					fill.PatternFill = patternFill;
					fills.Append(fill);
					
					fills.Count = UInt32Value.FromUInt32((uint)fills.ChildElements.Count);
					/*borders*/
					var borders = new OpenXmlSpreadsheet.Borders();
					var border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder(),
						RightBorder = new OpenXmlSpreadsheet.RightBorder(),
						TopBorder = new OpenXmlSpreadsheet.TopBorder(),
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder(),
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
					//All Boarder Index 1
					border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder {Style = OpenXmlSpreadsheet.BorderStyleValues.Thin}, //.Medium .Thin .Thick
						RightBorder = new OpenXmlSpreadsheet.RightBorder {Style = OpenXmlSpreadsheet.BorderStyleValues.Thin},
						TopBorder = new OpenXmlSpreadsheet.TopBorder {Style = OpenXmlSpreadsheet.BorderStyleValues.Thin},
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder {Style = OpenXmlSpreadsheet.BorderStyleValues.Thin},
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
					//Top and Bottom Boarder Index 2
					border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder(),
						RightBorder = new OpenXmlSpreadsheet.RightBorder (),
						TopBorder = new OpenXmlSpreadsheet.TopBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
					//Left, Right and Top Boarder Index 3
					border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						RightBorder = new OpenXmlSpreadsheet.RightBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						TopBorder = new OpenXmlSpreadsheet.TopBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder(),
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
					//Left, Right and Bottom Boarder Index 4
					border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						RightBorder = new OpenXmlSpreadsheet.RightBorder{ Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						TopBorder = new OpenXmlSpreadsheet.TopBorder (),
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
					//Left and Right Boarder Index 5
					border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						RightBorder = new OpenXmlSpreadsheet.RightBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						TopBorder = new OpenXmlSpreadsheet.TopBorder (), 
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder (),
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
					
					//Top Boarder Index 6
					border = new OpenXmlSpreadsheet.Border {
						LeftBorder = new OpenXmlSpreadsheet.LeftBorder (),
						RightBorder = new OpenXmlSpreadsheet.RightBorder (),
						TopBorder = new OpenXmlSpreadsheet.TopBorder { Style = OpenXmlSpreadsheet.BorderStyleValues.Thin },
						BottomBorder = new OpenXmlSpreadsheet.BottomBorder(),
						DiagonalBorder = new OpenXmlSpreadsheet.DiagonalBorder()
					};
					borders.Append(border);
			
					borders.Count = UInt32Value.FromUInt32((uint)borders.ChildElements.Count);
					//--
					var cellStyleFormats = new OpenXmlSpreadsheet.CellStyleFormats();
					var cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = 0, FontId = 0, FillId = 0, BorderId = 0
					};
					cellStyleFormats.Append(cellFormat);
					cellStyleFormats.Count = UInt32Value.FromUInt32((uint)cellStyleFormats.ChildElements.Count);
					
					uint iExcelIndex = 164;
					var numberingFormats = new OpenXmlSpreadsheet.NumberingFormats();
					var cellFormats = new OpenXmlSpreadsheet.CellFormats();
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = 0, FontId = 0, 
						FillId = 0, BorderId = 0, FormatId = 0
					};
					cellFormats.Append(cellFormat);
					var nformatDateTime = new OpenXmlSpreadsheet.NumberingFormat {
						NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++),
						FormatCode = StringValue.FromString("dd/mm/yyyy hh:mm:ss")
					};
					numberingFormats.Append(nformatDateTime);
					var nformat4Decimal = new OpenXmlSpreadsheet.NumberingFormat {
						NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++),
						FormatCode = StringValue.FromString("#,##0.0000")
					};
					numberingFormats.Append(nformat4Decimal);
					var nformat2Decimal = new OpenXmlSpreadsheet.NumberingFormat {
						NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++),
						FormatCode = StringValue.FromString("#,##0.00")
					};
					numberingFormats.Append(nformat2Decimal);
					var nformatForcedText = new OpenXmlSpreadsheet.NumberingFormat {
						NumberFormatId = UInt32Value.FromUInt32(iExcelIndex),
						FormatCode = StringValue.FromString("@")
					};
					numberingFormats.Append(nformatForcedText);
					
					// index 1
					// Cell Standard Date format 
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = 14,
						FontId = 0,
						FillId = 0,
						BorderId = 0,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 2
					// Cell Standard Number format with 2 decimal placing
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = 4,
						FontId = 0,
						FillId = 0,
						BorderId = 0,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 3
					// Cell header required
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 2,
						FillId = 0,
						BorderId = 1,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 4
					// Cell header
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 1,
						FillId = 0,
						BorderId = 1,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 5
					// Cell last in group
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 0,
						FillId = 0,
						BorderId = 1,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 6
					// Cell middle
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 0,
						FillId = 0,
						BorderId = 5,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 7
					// Cell full
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 0,
						FillId = 0,
						BorderId = 1,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 8
					// Cell text
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 0,
						FillId = 0,
						BorderId = 6,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 9
					// Coloured 2 decimal cell text
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 0,
						FillId = 0,
						BorderId = 2,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 10
					// Coloured cell text
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 0,
						FillId = 0,
						BorderId = 2,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					// Index 11
					// Coloured cell text
					cellFormat = new OpenXmlSpreadsheet.CellFormat {
						NumberFormatId = nformatForcedText.NumberFormatId,
						FontId = 1,
						FillId = 0,
						BorderId = 2,
						FormatId = 0,
						ApplyNumberFormat = BooleanValue.FromBoolean(true)
					};
					cellFormats.Append(cellFormat);
					numberingFormats.Count = UInt32Value.FromUInt32((uint)numberingFormats.ChildElements.Count);
					cellFormats.Count = UInt32Value.FromUInt32((uint)cellFormats.ChildElements.Count);
			
					stylesheet.Append(numberingFormats);
			        stylesheet.Append(fonts);
			        stylesheet.Append(fills);
			        stylesheet.Append(borders);
			        stylesheet.Append(cellStyleFormats);
			        stylesheet.Append(cellFormats);
					
					var css = new OpenXmlSpreadsheet.CellStyles();
					var cs = new OpenXmlSpreadsheet.CellStyle {
						Name = StringValue.FromString("Normal"), 
						FormatId = 0, BuiltinId = 0
					};
					css.Append(cs);
					css.Count = UInt32Value.FromUInt32((uint)css.ChildElements.Count);
					stylesheet.Append(css);
					
					var dfs = new OpenXmlSpreadsheet.DifferentialFormats {Count = 0};
					stylesheet.Append(dfs);
			
					var tss = new OpenXmlSpreadsheet.TableStyles {
						Count = 0,
						DefaultTableStyle = StringValue.FromString("TableStyleMedium9"),
						DefaultPivotStyle = StringValue.FromString("PivotStyleLight16")
					};
					stylesheet.Append(tss);
					return stylesheet;
				}
			}
		}

		public virtual OpenXmlSpreadsheet.ForegroundColor TranslateForeground(System.Drawing.Color fillColor) {
			LogInfo(string.Format("\t{0}\t{1}\t\tMethods: TranslateForeground", FileName, ExcelImportId));
			using (MemoryStream stream = new MemoryStream()) {
				using(SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook)) {
					
					return new OpenXmlSpreadsheet.ForegroundColor() {
						Rgb = new HexBinaryValue() {
							Value = System.Drawing.ColorTranslator.ToHtml(
								System.Drawing.Color.FromArgb(
									fillColor.A,
									fillColor.R,
									fillColor.G,
									fillColor.B
								)
							).Replace("#", "")
						}
					};
					
				}
			}
		}

		public virtual void LogExcelImport() {
			ExcelImportId = Guid.NewGuid();
			LogInfo(string.Format("\t{0}\t{1}\t\tExcelImport write log, start", FileName, ExcelImportId));
			var nowParameter = new QueryParameter("now", DateTime.Now, "DateTime");
			var currentUserContactIdParameter = new QueryParameter("currentUserId",
				UserConnection.CurrentUser.ContactId);
			UserConnection.SessionData["ExcelImportId"] = ExcelImportId;
			new Insert(UserConnection)
				.Into("ExcelImport")
				.Set("Id", Column.Parameter(ExcelImportId))
				.Set("CreatedOn", nowParameter)
				.Set("CreatedById", currentUserContactIdParameter)
				.Set("ModifiedOn", nowParameter)
				.Set("ModifiedById", currentUserContactIdParameter)
				.Execute();
			LogInfo(string.Format("\t{0}\t{1}\t\tExcelImport write log, end", FileName, ExcelImportId));
		}

		public virtual bool CheckRequiredFieldsNotFilled(List<string> requiredFieldsNotFilled) {
			if (requiredFieldsNotFilled.Count == 0) {
				return false;
			}
			var requiredColumns = new StringBuilder(" ");
			for (int i = 0; i < requiredFieldsNotFilled.Count; i++) {
				requiredColumns.Append(requiredFieldsNotFilled[i]);
				if (i != requiredFieldsNotFilled.Count - 1) {
					requiredColumns.Append(", ");
				}
			}
			Page.BaseMessagePanel.AddMessage(WarrningMessage, 
											UnableUploadFileMessage + ". " + string.Format(RequiredFieldsAreNotFilled, requiredColumns.ToString()), 
											MessageType.Warning, true);
			Page.AddScript("PageContainer.el.unmask();");
			IsValid = false;
			return true;
		}

		public virtual bool CheckIsNullData(IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row> sheetDataElements, SharedStringTablePart stringTablePart) {
			var isNullData = true;
			foreach (var row in sheetDataElements.Where(r => r.RowIndex > 1)) {
				var rowElements = row.Elements<OpenXmlSpreadsheet.Cell>();
				//if (rowElements.Count() == 0) {
				//	continue;
				//}
				foreach (var cell in rowElements) {
					if (GetCellValue(cell, stringTablePart) != null) {
						isNullData = false;
						break;
					}
				}
				if (!isNullData) {
					break;
				}
			}			
			if (isNullData) {
				Page.BaseMessagePanel.AddMessage(WarrningMessage, UnableUploadFileMessage, MessageType.Warning, true);
				Page.AddScript("PageContainer.el.unmask();");
				IsValid = false;
				return true;
			}
			return false;
		}

		public virtual void LogInfo(string message) {
			if(ExcelUtilities.Log != null) {
				ExcelUtilities.Log.Info(message);
			}
		}

		public virtual void LogExcelImportLog(string message) {
			var nowParameter = new QueryParameter("now", DateTime.Now, "DateTime");
			var currentUserContactIdParameter = new QueryParameter("currentUserId",
				UserConnection.CurrentUser.ContactId);
			var guid = Guid.NewGuid();
			new Insert(UserConnection)
				.Into("ExcelImportLog")
				.Set("Id", Column.Parameter(guid))
				.Set("CreatedOn", nowParameter)
				.Set("CreatedById", currentUserContactIdParameter)
				.Set("ModifiedOn", nowParameter)
				.Set("ModifiedById", currentUserContactIdParameter)
				.Set("MessageText", Column.Parameter(message))
				.Set("ExcelImportId", Column.Parameter(ExcelImportId))
				.Execute();
		}

		public virtual void ExecuteImportExcelDataProcess(string[][] rows) {
			LogInfo(string.Format("\t{0}\t{1}\t\tStarte import procces", FileName, ExcelImportId));
			string jobName = "ImportExcelData";
			string jobGroup = "ImportExcelDataGroup";
			string processName = "ImportExcelDataProcess";
			var processParameters = new Dictionary<string, object>() {
				{"ExcelImportId", ExcelImportId},
				{"ImportExcelData", rows},
				{"IsPrimaryDisplayColumnExists", IsPrimaryDisplayColumnExists},
				{"SelectedIdentificationColumns", SelectedIdentificationColumns},
				{"NameColumnIndex", NameColumnIndex},
				{"Captions", Captions},
				{"FileName", FileName},
				{"SchemaName", SchemaName},
				{"ImportMode", ImportMode},
				{"IsOnlyErrorsMode", IsOnlyErrorsMode},
				{"HeaderNames", HeaderNames}
			};
			
			AppScheduler.ScheduleImmediateProcessJob(jobName, jobGroup, processName,
				UserConnection.Workspace.Name, UserConnection.CurrentUser.Name, processParameters);
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
					case "ColumnsEditButtonClick":
							if (ActivatedEventElements.Contains("ColumnsEditButtonClick")) {
							context.QueueTasks.Enqueue("ColumnsEditButtonClick");
						}
						break;
					case "FileUploadEditChange":
							if (ActivatedEventElements.Contains("FileUploadEditChange")) {
							context.QueueTasks.Enqueue("FileUploadEditChange");
						}
						break;
					case "OpenLogButtonClick":
							if (ActivatedEventElements.Contains("OpenLogButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OpenLogButtonClickStartMessage");
						}
						break;
					case "DownloadTemplateButtonClick":
							if (ActivatedEventElements.Contains("DownloadTemplateButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DownloadTemplateButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "AnalizeData":
							if (ActivatedEventElements.Contains("AnalizeDataStartMessage")) {
							context.QueueTasks.Enqueue("AnalizeDataStartMessage");
						}
						break;
					case "SaveNewLookupData":
							if (ActivatedEventElements.Contains("SaveNewLookupDataStartMessage")) {
							context.QueueTasks.Enqueue("SaveNewLookupDataStartMessage");
						}
						break;
					case "ImportYesMessage":
							if (ActivatedEventElements.Contains("ImportYesMessageStartMessage")) {
							context.QueueTasks.Enqueue("ImportYesMessageStartMessage");
						}
						break;
					case "ImportNoMessage":
							if (ActivatedEventElements.Contains("ImportNoMessageStartMessage")) {
							context.QueueTasks.Enqueue("ImportNoMessageStartMessage");
						}
						break;
					case "ThrowSaveProducts":
							if (ActivatedEventElements.Contains("ThrowSaveProductsStartMessage")) {
							context.QueueTasks.Enqueue("ThrowSaveProductsStartMessage");
						}
						break;
					case "SaveProducts":
							if (ActivatedEventElements.Contains("SaveProductsStartMessage")) {
							context.QueueTasks.Enqueue("SaveProductsStartMessage");
						}
						break;
					case "UniqueImportYesMessage":
							if (ActivatedEventElements.Contains("UniqueImportYesMessageStart")) {
							context.QueueTasks.Enqueue("UniqueImportYesMessageStart");
						}
						break;
					case "UniqueImportNoMessage":
							if (ActivatedEventElements.Contains("UniqueImportNoMessageStart")) {
							context.QueueTasks.Enqueue("UniqueImportNoMessageStart");
						}
						break;
					case "ObjectEditChange":
							if (ActivatedEventElements.Contains("ObjectEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ObjectEditChangeStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ResolveConflictsAutomatically") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ResolveConflictsAutomatically", ResolveConflictsAutomatically, false);
			}
			if (!HasMapping("HasUniqueRecords") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("HasUniqueRecords", HasUniqueRecords, false);
			}
			if (!HasMapping("ImportMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ImportMode", ImportMode, 0);
			}
			if (!HasMapping("ExcelImportLogSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ExcelImportLogSchemaId", ExcelImportLogSchemaId, Guid.Empty);
			}
			if (!HasMapping("IsOnlyErrorsMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsOnlyErrorsMode", IsOnlyErrorsMode, false);
			}
			if (!HasMapping("SelectedIdentificationColumns") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SelectedIdentificationColumns", SelectedIdentificationColumns, null);
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("ColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerRegistered", ColumnStructureExplorerRegistered, false);
			}
			if (!HasMapping("ColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnStructureExplorerCreated", ColumnStructureExplorerCreated, false);
			}
			if (!HasMapping("UndiscoveredFields") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UndiscoveredFields", UndiscoveredFields, null);
			}
			if (!HasMapping("IsPrimaryDisplayColumnExists") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsPrimaryDisplayColumnExists", IsPrimaryDisplayColumnExists, false);
			}
			if (!HasMapping("SchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaName", SchemaName, null);
			}
			if (!HasMapping("SheetName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SheetName", SheetName, null);
			}
			if (ImportedItems != null) {
				if (ImportedItems.GetType().IsSerializable ||
					ImportedItems.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ImportedItems", ImportedItems, null);
				}
			}
			if (Captions != null) {
				if (Captions.GetType().IsSerializable ||
					Captions.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Captions", Captions, null);
				}
			}
			if (!HasMapping("ExcelImportId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ExcelImportId", ExcelImportId, Guid.Empty);
			}
			if (FileData != null) {
				if (FileData.GetType().IsSerializable ||
					FileData.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FileData", FileData, null);
				}
			}
			if (!HasMapping("IsValid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsValid", IsValid, false);
			}
			if (!HasMapping("IsAllColumnCaptionsPresent") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsAllColumnCaptionsPresent", IsAllColumnCaptionsPresent, false);
			}
			if (!HasMapping("CurrencyColumnIndex") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrencyColumnIndex", CurrencyColumnIndex, 0);
			}
			if (!HasMapping("NameColumnIndex") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NameColumnIndex", NameColumnIndex, 0);
			}
			if (LookupFieldValuesAndCounts != null) {
				if (LookupFieldValuesAndCounts.GetType().IsSerializable ||
					LookupFieldValuesAndCounts.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LookupFieldValuesAndCounts", LookupFieldValuesAndCounts, null);
				}
			}
			if (LookupColumnsIndexesAndNames != null) {
				if (LookupColumnsIndexesAndNames.GetType().IsSerializable ||
					LookupColumnsIndexesAndNames.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LookupColumnsIndexesAndNames", LookupColumnsIndexesAndNames, null);
				}
			}
			if (HeaderNames != null) {
				if (HeaderNames.GetType().IsSerializable ||
					HeaderNames.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("HeaderNames", HeaderNames, null);
				}
			}
			if (RequiredColumnsIndexes != null) {
				if (RequiredColumnsIndexes.GetType().IsSerializable ||
					RequiredColumnsIndexes.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("RequiredColumnsIndexes", RequiredColumnsIndexes, null);
				}
			}
			if (!HasMapping("FileName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileName", FileName, null);
			}
			if (!HasMapping("FileContent") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileContent", FileContent, null);
			}
			if (!HasMapping("SchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SchemaId", SchemaId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ImportSettingsPageEventsProcess

	/// <exclude/>
	public class ImportSettingsPageEventsProcess : ImportSettingsPageEventsProcess<Terrasoft.WebApp.ImportSettingsPageSchemaUserControl>
	{

		public ImportSettingsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ImportSettingsPageSchemaUserControl

	/// <exclude/>
	public partial class ImportSettingsPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ObjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("FileUploadEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ColumnsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ColumnsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label ColumnsLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("ColumnsLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ColumnsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ColumnsEditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ColumnsEditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox CheckRequiredFieldsBeforeImportCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("CheckRequiredFieldsBeforeImportCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsOnlyErrorsMode {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsOnlyErrorsMode", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ResolveConflictsAutomatically {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ResolveConflictsAutomatically", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ImportModeControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ImportModeControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton Mode1On {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("Mode1On", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton Mode2On {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("Mode2On", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnMetaPathEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ColumnMetaPathEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownloadTemplateButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownloadTemplateButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OpenLogButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OpenLogButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
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
			ObjectEdit.AjaxEvents.Change.Event += ObjectEditChange;
			FileUploadEdit.AjaxEvents.Change.Event += FileUploadEditChange;
			ColumnsEditButton.AjaxEvents.Click.Event += ColumnsEditButtonClick;
			DownloadTemplateButton.AjaxEvents.Click.Event += DownloadTemplateButtonClick;
			OpenLogButton.AjaxEvents.Click.Event += OpenLogButtonClick;
			OKButton.AjaxEvents.Click.Event += OKButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event -= ObjectEditChange;
			FileUploadEdit.AjaxEvents.Change.Event -= FileUploadEditChange;
			ColumnsEditButton.AjaxEvents.Click.Event -= ColumnsEditButtonClick;
			DownloadTemplateButton.AjaxEvents.Click.Event -= DownloadTemplateButtonClick;
			OpenLogButton.AjaxEvents.Click.Event -= OpenLogButtonClick;
			OKButton.AjaxEvents.Click.Event -= OKButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ImportSettingsPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ImportSettingsPageEventsProcess(UserConnection);
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

		public virtual void FileUploadEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FileUploadEditChange");
		}

		public virtual void ColumnsEditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ColumnsEditButtonClick");
		}

		public virtual void DownloadTemplateButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownloadTemplateButtonClick");
		}

		public virtual void OpenLogButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OpenLogButtonClick");
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
			SchemaName = "ImportSettingsPage";
		}

		#endregion

	}

	#endregion

	#region Class: ImportSettingsPageEventsProcessSchema

	/// <exclude/>
	public class ImportSettingsPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ImportSettingsPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ImportSettingsPageEventsProcessSchema(ImportSettingsPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ImportSettingsPageEventsProcess";
			UId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2");
			CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce");
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

		protected virtual ProcessSchemaParameter CreateSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2479d905-b7f0-4915-a0b4-6fcc9ef3e88c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileContentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e4869200-0946-4b74-92e7-9e15ca6c8fec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"FileContent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7d206464-158a-421b-b7a7-580b5482905c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"FileName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRequiredColumnsIndexesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e87698-7d25-4551-a99d-9572d3221c28"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"RequiredColumnsIndexes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHeaderNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ddae6036-6e56-4220-beb2-494ec3255837"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"HeaderNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupColumnsIndexesAndNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("29201aeb-0c4c-40f3-a61d-075e3d49169c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"LookupColumnsIndexesAndNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupFieldValuesAndCountsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5381546b-7f9a-46c4-af19-bf8638a2ff60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"LookupFieldValuesAndCounts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNameColumnIndexParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("14b306dc-2981-4540-95be-de5fce2ca5cb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"NameColumnIndex",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrencyColumnIndexParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("43bc0b50-052a-4bf5-96be-68d965996d20"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"CurrencyColumnIndex",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsAllColumnCaptionsPresentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("791c5579-6998-46ec-b9e2-3acbcccc31e9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"IsAllColumnCaptionsPresent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsValidParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0eef0f78-5996-40da-89d1-2174d6fea1b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"IsValid",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileDataParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("761da1dc-99b0-4ffe-8ec8-397c7d3390bf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"FileData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateExcelImportIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3402a52e-7548-444a-a508-6b605dab065b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ExcelImportId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaptionsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("63c51e34-f757-43ed-bd61-7f6c55535c34"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"Captions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateImportedItemsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c9c24dad-b69b-4bc1-881a-4df6b05e0db2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ImportedItems",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSheetNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a3fa19d5-9645-4027-a227-85699f884ba8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SheetName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("37b8597d-b71a-4786-a423-72ffdca137c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsPrimaryDisplayColumnExistsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b075c3ce-4fdd-4fd7-afbe-8ee43e2c95b2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"IsPrimaryDisplayColumnExists",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUndiscoveredFieldsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("69bbb4ff-8a3d-417e-a580-eba6696aad14"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"UndiscoveredFields",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7b50a095-a42e-4159-86ba-1103799021d7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ab53ce84-0c77-43ef-83fc-11c604174ab4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d00892f0-08df-4bd7-aac1-b970fda52f01"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedIdentificationColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d58e1c8e-022b-4198-8ce0-c775d32798b8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SelectedIdentificationColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsOnlyErrorsModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("237928cf-9d5a-4994-9cd6-ad80fbb93635"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"IsOnlyErrorsMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateExcelImportLogSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("81cf5f67-ccda-4460-bff9-4e6cab7c2bbe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ExcelImportLogSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"b974e2ae-655d-4f5c-9a3c-cb58ae3ad3d0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateImportModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d0623c2c-9852-4cf8-82e2-1c3bc0492394"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ImportMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateHasUniqueRecordsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77f3401d-1cf3-480e-a99c-70bcf4a8e8a6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"HasUniqueRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateResolveConflictsAutomaticallyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("74cade20-cd2b-4e67-a5bf-2a87ba380a11"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ResolveConflictsAutomatically",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSchemaIdParameter());
			Parameters.Add(CreateFileContentParameter());
			Parameters.Add(CreateFileNameParameter());
			Parameters.Add(CreateRequiredColumnsIndexesParameter());
			Parameters.Add(CreateHeaderNamesParameter());
			Parameters.Add(CreateLookupColumnsIndexesAndNamesParameter());
			Parameters.Add(CreateLookupFieldValuesAndCountsParameter());
			Parameters.Add(CreateNameColumnIndexParameter());
			Parameters.Add(CreateCurrencyColumnIndexParameter());
			Parameters.Add(CreateIsAllColumnCaptionsPresentParameter());
			Parameters.Add(CreateIsValidParameter());
			Parameters.Add(CreateFileDataParameter());
			Parameters.Add(CreateExcelImportIdParameter());
			Parameters.Add(CreateCaptionsParameter());
			Parameters.Add(CreateImportedItemsParameter());
			Parameters.Add(CreateSheetNameParameter());
			Parameters.Add(CreateSchemaNameParameter());
			Parameters.Add(CreateIsPrimaryDisplayColumnExistsParameter());
			Parameters.Add(CreateUndiscoveredFieldsParameter());
			Parameters.Add(CreateColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateSelectedIdentificationColumnsParameter());
			Parameters.Add(CreateIsOnlyErrorsModeParameter());
			Parameters.Add(CreateExcelImportLogSchemaIdParameter());
			Parameters.Add(CreateImportModeParameter());
			Parameters.Add(CreateHasUniqueRecordsParameter());
			Parameters.Add(CreateResolveConflictsAutomaticallyParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9787de1e-4e06-4005-aa0d-03f67bb241a5"),
				ContainerUId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
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
				UId = new Guid("0e96c7e5-d3b9-4d06-abb0-7003dab51836"),
				ContainerUId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
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
				UId = new Guid("4171f5b4-9382-4e83-bf58-a98eb2625fde"),
				ContainerUId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
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
				UId = new Guid("6445874b-50a5-435d-a7f5-2447bb0510cd"),
				ContainerUId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
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

		protected virtual void InitializeUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("50632919-0008-4eb6-ab60-1200bea93a14"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("688b9b01-61c7-4674-a523-02510678d5b3"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("3fb53887-860f-4034-8525-44a027edd195"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("921f8a88-1ea8-49a7-9c87-e3b29c3eacdc"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("b075f6b0-7e31-4f97-a409-1268d98e1971"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("bc30f857-3dbe-496d-b892-22b7c72f8878"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("320b4831-e642-4083-b63f-f4be3142579f"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
				UId = new Guid("11b6d310-4b84-47bc-84d3-36c0705965fc"),
				ContainerUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected virtual void InitializeOpenNewLookupDataPageTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5460bd96-e56a-4473-b3da-fb2b92c7625e"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("0e7ba84b-18a0-492f-b0cc-f8a23d84abdd"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("d76dec78-ad2c-49d6-871c-a2165cf8148a"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("aa2073bc-de7b-4c63-9cc2-474c64ce1166"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("145ed879-ae19-4174-90ce-de78f45394bd"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("6ca7f2e8-7558-43e7-8c50-318a59c9d543"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("55186ab5-6a74-488f-856c-01d4f331dfad"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("64df6a72-7746-4bac-beab-e1cb6d77b0a9"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("687f558a-d77b-4a3d-bf5e-43cbf4d2b7f5"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("4f91f318-404d-492a-9d53-0355623fd2d0"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("891ec0c0-9d6a-4305-bdf2-06ff56d6101a"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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
				UId = new Guid("955eeaa1-a6a8-4592-bfae-aeec0eeada97"),
				ContainerUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
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

		protected virtual void InitializeUserMessageUniqueParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4ce5a672-b5c9-4998-9951-68ba0b4898fc"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("2ffafda2-1642-4dbd-bf6c-0a42480ad10c"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("2a06dc5b-075c-48c6-984a-942ca0567947"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("a671dd1e-3568-413d-9fd3-58a87d494919"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("12848bb0-20de-4939-8073-be4fe6ea49b0"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("869cd331-93ab-493f-a935-37b464c5ba62"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("60a58670-35d9-48c4-be1e-863c864aaecb"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
				UId = new Guid("22177734-931a-46b1-8754-439269fdc89d"),
				ContainerUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected virtual void InitializeImportStartedMessageBoxParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("77a919ae-c19c-4de8-8796-8b7f125209a6"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("dd01c379-2698-4335-b9c0-d37a713facdf"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("1523e7b0-cb5d-49a5-a7d3-db8ddb7bb2dc"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("38998176-f87a-4aca-aae0-621e49528374"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("3d9ff759-2782-4215-a3be-0dac403fcf1b"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("e251c0a5-a278-4786-8f8d-6b8a14847971"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("91047144-0346-4031-88ee-69839c065649"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
				UId = new Guid("d67b882b-bfac-4b7c-9e73-50da76a6bebe"),
				ContainerUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
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
					Value = @"",
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
			ProcessSchemaEventSubProcess controlseventsubprocess = CreateControlsEventSubProcessEventSubProcess();
			FlowElements.Add(controlseventsubprocess);
			ProcessSchemaEventSubProcess pageeventsubprocess = CreatePageEventSubProcessEventSubProcess();
			FlowElements.Add(pageeventsubprocess);
			ProcessSchemaEventSubProcess customeventsubprocess = CreateCustomEventSubProcessEventSubProcess();
			FlowElements.Add(customeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent okbuttonclick = CreateOKButtonClickStartMessageEvent();
			controlseventsubprocess.FlowElements.Add(okbuttonclick);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOKButtonClickScriptTaskScriptTask();
			controlseventsubprocess.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclick = CreateCancelButtonClickStartMessageEvent();
			controlseventsubprocess.FlowElements.Add(cancelbuttonclick);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			controlseventsubprocess.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent columnseditbuttonclick = CreateColumnsEditButtonClickStartMessageEvent();
			controlseventsubprocess.FlowElements.Add(columnseditbuttonclick);
			ProcessSchemaScriptTask columnseditbuttonclickscripttask = CreateColumnsEditButtonClickScriptTaskScriptTask();
			controlseventsubprocess.FlowElements.Add(columnseditbuttonclickscripttask);
			ProcessSchemaStartMessageEvent fileuploadeditchange = CreateFileUploadEditChangeStartMessageEvent();
			controlseventsubprocess.FlowElements.Add(fileuploadeditchange);
			ProcessSchemaScriptTask productsfileuploadeditchangescripttask = CreateProductsFileUploadEditChangeScriptTaskScriptTask();
			controlseventsubprocess.FlowElements.Add(productsfileuploadeditchangescripttask);
			ProcessSchemaStartMessageEvent openlogbuttonclickstartmessage = CreateOpenLogButtonClickStartMessageStartMessageEvent();
			controlseventsubprocess.FlowElements.Add(openlogbuttonclickstartmessage);
			ProcessSchemaScriptTask openlogbuttonclickscripttask = CreateOpenLogButtonClickScriptTaskScriptTask();
			controlseventsubprocess.FlowElements.Add(openlogbuttonclickscripttask);
			ProcessSchemaScriptTask downloadtemplatemenuitemclickscripttask = CreateDownloadTemplateMenuItemClickScriptTaskScriptTask();
			controlseventsubprocess.FlowElements.Add(downloadtemplatemenuitemclickscripttask);
			ProcessSchemaStartMessageEvent downloadtemplatebuttonclickstartmessage = CreateDownloadTemplateButtonClickStartMessageStartMessageEvent();
			controlseventsubprocess.FlowElements.Add(downloadtemplatebuttonclickstartmessage);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			controlseventsubprocess.FlowElements.Add(openlookupusertask);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			pageeventsubprocess.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			pageeventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			pageeventsubprocess.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent analizedatastartmessage = CreateAnalizeDataStartMessageStartMessageEvent();
			customeventsubprocess.FlowElements.Add(analizedatastartmessage);
			ProcessSchemaScriptTask analizedatascripttask = CreateAnalizeDataScriptTaskScriptTask();
			customeventsubprocess.FlowElements.Add(analizedatascripttask);
			ProcessSchemaExclusiveGateway areinputdatacorrectexclusivegateway = CreateAreInputDataCorrectExclusiveGatewayExclusiveGateway();
			customeventsubprocess.FlowElements.Add(areinputdatacorrectexclusivegateway);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			customeventsubprocess.FlowElements.Add(end1);
			ProcessSchemaUserTask usermessage = CreateUserMessageUserTask();
			customeventsubprocess.FlowElements.Add(usermessage);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			customeventsubprocess.FlowElements.Add(exclusivegateway2);
			ProcessSchemaIntermediateThrowMessageEvent throwsaveproductsintermediatethrowmessageevent = CreateThrowSaveProductsIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			customeventsubprocess.FlowElements.Add(throwsaveproductsintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent savenewlookupdatastartmessage = CreateSaveNewLookupDataStartMessageStartMessageEvent();
			customeventsubprocess.FlowElements.Add(savenewlookupdatastartmessage);
			ProcessSchemaScriptTask opennewlookupdatapagescript = CreateOpenNewLookupDataPageScriptScriptTask();
			customeventsubprocess.FlowElements.Add(opennewlookupdatapagescript);
			ProcessSchemaUserTask opennewlookupdatapagetask = CreateOpenNewLookupDataPageTaskUserTask();
			customeventsubprocess.FlowElements.Add(opennewlookupdatapagetask);
			ProcessSchemaStartMessageEvent importyesmessagestartmessage = CreateImportYesMessageStartMessageStartMessageEvent();
			customeventsubprocess.FlowElements.Add(importyesmessagestartmessage);
			ProcessSchemaScriptTask importyesscript = CreateImportYesScriptScriptTask();
			customeventsubprocess.FlowElements.Add(importyesscript);
			ProcessSchemaStartMessageEvent importnomessagestartmessage = CreateImportNoMessageStartMessageStartMessageEvent();
			customeventsubprocess.FlowElements.Add(importnomessagestartmessage);
			ProcessSchemaEndEvent end2 = CreateEnd2EndEvent();
			customeventsubprocess.FlowElements.Add(end2);
			ProcessSchemaStartMessageEvent throwsaveproductsstartmessage = CreateThrowSaveProductsStartMessageStartMessageEvent();
			customeventsubprocess.FlowElements.Add(throwsaveproductsstartmessage);
			ProcessSchemaScriptTask throwsaveproductsscripttask = CreateThrowSaveProductsScriptTaskScriptTask();
			customeventsubprocess.FlowElements.Add(throwsaveproductsscripttask);
			ProcessSchemaStartMessageEvent saveproductsstartmessage = CreateSaveProductsStartMessageStartMessageEvent();
			customeventsubprocess.FlowElements.Add(saveproductsstartmessage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			customeventsubprocess.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask clearsettingsscript = CreateClearSettingsScriptScriptTask();
			customeventsubprocess.FlowElements.Add(clearsettingsscript);
			ProcessSchemaScriptTask saveproductsscripttask = CreateSaveProductsScriptTaskScriptTask();
			customeventsubprocess.FlowElements.Add(saveproductsscripttask);
			ProcessSchemaEndEvent end3 = CreateEnd3EndEvent();
			customeventsubprocess.FlowElements.Add(end3);
			ProcessSchemaScriptTask checkuniquescripttask = CreateCheckUniqueScriptTaskScriptTask();
			customeventsubprocess.FlowElements.Add(checkuniquescripttask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			customeventsubprocess.FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask prepareuserquestionscripttask = CreatePrepareUserQuestionScriptTaskScriptTask();
			customeventsubprocess.FlowElements.Add(prepareuserquestionscripttask);
			ProcessSchemaStartMessageEvent uniqueimportyesmessagestart = CreateUniqueImportYesMessageStartStartMessageEvent();
			customeventsubprocess.FlowElements.Add(uniqueimportyesmessagestart);
			ProcessSchemaUserTask usermessageunique = CreateUserMessageUniqueUserTask();
			customeventsubprocess.FlowElements.Add(usermessageunique);
			ProcessSchemaStartMessageEvent uniqueimportnomessagestart = CreateUniqueImportNoMessageStartStartMessageEvent();
			customeventsubprocess.FlowElements.Add(uniqueimportnomessagestart);
			ProcessSchemaScriptTask executeimportexcellookupprocess = CreateExecuteImportExcelLookupProcessScriptTask();
			customeventsubprocess.FlowElements.Add(executeimportexcellookupprocess);
			ProcessSchemaExclusiveGateway chooseimporttypeexclusivegateway = CreateChooseImportTypeExclusiveGatewayExclusiveGateway();
			customeventsubprocess.FlowElements.Add(chooseimporttypeexclusivegateway);
			ProcessSchemaUserTask importstartedmessagebox = CreateImportStartedMessageBoxUserTask();
			customeventsubprocess.FlowElements.Add(importstartedmessagebox);
			ProcessSchemaScriptTask closeimportsetingspage = CreateCloseImportSetingsPageScriptTask();
			customeventsubprocess.FlowElements.Add(closeimportsetingspage);
			ProcessSchemaStartMessageEvent objecteditchangestartmessage = CreateObjectEditChangeStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(objecteditchangestartmessage);
			ProcessSchemaScriptTask objecteditchangescripttask = CreateObjectEditChangeScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(objecteditchangescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateIsValidConditionalFlowConditionalFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateConditionalFlow6ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUnableUploadFileMessageLocalizableString());
			LocalizableStrings.Add(CreateWarrningMessageLocalizableString());
			LocalizableStrings.Add(CreateRequiredFieldsAreNotFilledLocalizableString());
			LocalizableStrings.Add(CreateImportNotAllColumnsMessageLocalizableString());
			LocalizableStrings.Add(CreateLoadingLocalizableString());
			LocalizableStrings.Add(CreateAddItemLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateUpdateItemLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateErrorAddItemLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateAddNewLookupExcelLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateUnableSelectObjectMessageLocalizableString());
			LocalizableStrings.Add(CreateImportErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateImportSuccessMessageLocalizableString());
			LocalizableStrings.Add(CreateErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateNoPrimaryDisplayFieldLocalizableString());
			LocalizableStrings.Add(CreateCloseLSLocalizableString());
			LocalizableStrings.Add(CreateRetryLSLocalizableString());
			LocalizableStrings.Add(CreateCancelLSLocalizableString());
			LocalizableStrings.Add(CreateInGroupLSLocalizableString());
			LocalizableStrings.Add(CreateOKLocalizableString());
			LocalizableStrings.Add(CreateMissingDisplayValueErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateInformationMessageLocalizableString());
			LocalizableStrings.Add(CreateHasUniqueRecordsMessageLocalizableString());
			LocalizableStrings.Add(CreateImportMessageWithUniqueLocalizableString());
			LocalizableStrings.Add(CreateNotUniqueRecordLocalizableString());
			LocalizableStrings.Add(CreateImportStartedMessageLocalizableString());
			LocalizableStrings.Add(CreateImportStartedCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUnableUploadFileMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dacba885-571c-4154-bfca-84181af3d580"),
				Name = "UnableUploadFileMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWarrningMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("43d5bdd5-bda2-4c8a-abf1-041c9a147004"),
				Name = "WarrningMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRequiredFieldsAreNotFilledLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5c1678d5-b569-41ea-adf5-4acfa1f6ab5d"),
				Name = "RequiredFieldsAreNotFilled",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportNotAllColumnsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b09c3060-6faf-4c60-ada7-294238599896"),
				Name = "ImportNotAllColumnsMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLoadingLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1b6597bf-a758-45d4-99b3-a1a430b2635d"),
				Name = "Loading",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddItemLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8ad2dc7e-0daa-41da-9448-1c07d9e63011"),
				Name = "AddItemLocalizableString",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUpdateItemLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("39da6cf7-b669-4d42-a6bf-d1695968fbd3"),
				Name = "UpdateItemLocalizableString",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorAddItemLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7684c806-efbe-456e-945d-e49df53f8691"),
				Name = "ErrorAddItemLocalizableString",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddNewLookupExcelLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("411c82e2-9fed-47c4-ada9-8ef21214acd8"),
				Name = "AddNewLookupExcelLocalizableString",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnableSelectObjectMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("65f7858f-1450-4a45-bc70-fab4af24f917"),
				Name = "UnableSelectObjectMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("26292fdf-18c2-4c43-9556-cc3e06979d5b"),
				Name = "ImportErrorMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("556bc9b2-77dc-4368-a8e0-be2b7d8783ec"),
				Name = "ImportSuccessMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7437d1d6-e9b3-4a13-84dd-e348696f4044"),
				Name = "ErrorMessage",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoPrimaryDisplayFieldLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c21badb3-672a-4847-a724-37c2c3edabb6"),
				Name = "NoPrimaryDisplayField",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCloseLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3d035381-458e-41bf-a48b-c4ec0c20717d"),
				Name = "CloseLS",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRetryLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c6f9b002-c887-419e-8db7-3e260cf52fda"),
				Name = "RetryLS",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCancelLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fe2735b-2bf6-4a8b-ac73-731e39a8c97f"),
				Name = "CancelLS",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInGroupLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e62e56c1-dd44-4456-90bd-f746fc5d2b81"),
				Name = "InGroupLS",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOKLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6d32524e-7370-4b6f-8c0a-53a550498bc3"),
				Name = "OK",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMissingDisplayValueErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0a592caf-1c04-41be-9f0c-22c2261a6636"),
				Name = "MissingDisplayValueErrorMessage",
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInformationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("61d3e3cf-ee3a-4089-9dda-1501cfb51dd9"),
				Name = "InformationMessage",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateHasUniqueRecordsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a6b0f2a7-a89c-4c39-877d-ecc25b2a3ae9"),
				Name = "HasUniqueRecordsMessage",
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportMessageWithUniqueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cfbec0bb-0bbe-4727-9ba0-8b85a4235b1e"),
				Name = "ImportMessageWithUnique",
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotUniqueRecordLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("68459032-754b-40da-8c77-bcdb146c0d61"),
				Name = "NotUniqueRecord",
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportStartedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("88e681a3-49dc-47c8-80a4-e45f9018095e"),
				Name = "ImportStartedMessage",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateImportStartedCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b4b33769-ead5-435f-b8ae-32dbc5f17806"),
				Name = "ImportStartedCaption",
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e8f8fd85-d6b0-4ebf-bba0-175f44c19021"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e712a18-36a0-475b-962d-c0306448c1f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b661c9a-4585-4ebd-a1cf-bf12efbc9468"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("ccc3ce3e-51fb-4a48-947d-3f526508bedf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9300777-817f-419e-9f58-00a4a08f4ea3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6885ac7b-3043-4d03-9368-be80e1c4c482"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("6e376965-304b-4f84-abbf-0b19eaca104e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1483b90f-2cd7-4a8f-a0ed-5ec9d4d45bd3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("72a640d1-f2a6-492e-981b-181bc27600e6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("7d34eb94-8108-41cd-99a2-603e4339c360"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(170, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d38dcc1e-f290-46a9-bd9d-22989d8e6527"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa6daf4d-b9aa-40d5-b9ed-0664d1f49d8d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("85c1ab85-c04b-46ff-be63-8a80658d772f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(381, 417),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a40b744d-4db4-4832-98b5-3cee92f3a711"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3d469d5-0a1d-4260-9c66-3ac186314ba8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("49433849-3da9-473b-ac98-7bdf2c33b542"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7fd44619-7e77-4d51-81b2-98f3072dea3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d472483-db62-477c-990b-7c78abe8ad5d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("76a190b5-3066-403c-b73f-0d3f0a8476a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(174, 652),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b03d0300-065f-488a-ac49-322163f816b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ec95639-0ffa-4e7b-ab7d-137a50520f1a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("eca7898c-fdad-4335-bdb6-7dfe15cf955e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(308, 651),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ec95639-0ffa-4e7b-ab7d-137a50520f1a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77c05c9d-0734-4cd8-bb4b-4cfc02f34d80"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsValidConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsValidConditionalFlow",
				UId = new Guid("01a5a0c0-484a-4d78-b1a7-960e62edbba5"),
				ConditionExpression = @"!IsValid",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(428, 601),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c05c9d-0734-4cd8-bb4b-4cfc02f34d80"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3fcf61e-9094-44c7-b13e-e46356942dd8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("8b1f3ab6-b498-4dc9-8442-7f62eb21c7b3"),
				ConditionExpression = @"IsValid && !IsAllColumnCaptionsPresent",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(428, 656),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c05c9d-0734-4cd8-bb4b-4cfc02f34d80"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("e6769c9c-e487-43f8-95b7-315dfa8544d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(358, 724),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c05c9d-0734-4cd8-bb4b-4cfc02f34d80"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("85b40358-1362-474c-b207-97be32e2f623"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("496c3b51-914f-43fe-85a1-518f36645a80"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(428, 901),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4145599b-ccfa-4b9b-84f4-3a0131577228"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("9e275910-3a07-4856-8e7b-391db0970674"),
				ConditionExpression = @"LookupFieldValuesAndCounts == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(432, 780),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("85b40358-1362-474c-b207-97be32e2f623"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c16d35bf-f6cd-46c2-8374-f37d475f6dc4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("91ef5485-e3e5-488b-a007-2e20939bc61e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(304, 788),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d089505d-965d-4d4c-8553-af0257905b8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("85b40358-1362-474c-b207-97be32e2f623"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("1e12c1e9-c6a4-4e6c-9521-a934df309cba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c180dfd-5def-4646-a3bc-414d9d824203"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3796db3-3d94-4e73-8633-c3f1cf2880fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("718f4e75-8c15-419d-aa0b-19a93b5d0455"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(714, 752),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d84bae3-0eb0-44d5-bc02-18ba9ce202f4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("609cc4fb-51a1-4ff5-94bf-b0a7ba567161"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("9205701f-45b3-42fc-97af-e145b5ce020e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(716, 892),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19902afc-d7da-457c-bfc9-b4eaf3187d41"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("13ecd1e7-ec17-4727-92bb-fb3b35bf2ef9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("121f9a60-35f9-4bfb-b41d-0589603430e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(706, 1006),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f851def-af74-471e-a67e-e5883b5a09e1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0d7ab517-1e17-4539-bdbc-052d88773726"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("a6971542-839d-4bbb-af05-1984a85ba4a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(184, 1182),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("139094b4-ae29-4107-b744-f7188f034b1a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68223875-5183-4512-b0b0-e0cf7ab94c77"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("2e00a2fc-b7de-4878-8676-800f443950e2"),
				ConditionExpression = @"UserConnection.SessionData[""NewLookupDataPageSuccessfullyClosed""] != null && !(bool)UserConnection.SessionData[""NewLookupDataPageSuccessfullyClosed""]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(263, 1260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68223875-5183-4512-b0b0-e0cf7ab94c77"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("50eb6e8a-9e92-4221-b2cc-3a5d22179d3b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow20",
				UId = new Guid("f44eac72-7ca9-497a-b10c-11ae17a2288c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(348, 1188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68223875-5183-4512-b0b0-e0cf7ab94c77"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("044bba60-6f5b-439c-a9c9-673b7b548fd0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("cc4e7bc4-d902-4206-bb09-4671a3b053a0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(356, 1324),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("50eb6e8a-9e92-4221-b2cc-3a5d22179d3b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6f6e626-9173-43bb-892d-1dd70927d8ad"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("d3af795c-13b3-48d8-93ed-cf81f1dd5b35"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14e24ad0-8451-48a4-a648-f72d1e5392f3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3f79d71-f422-4698-8591-2b108c7f30f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("f14a74c7-7a92-4b95-9015-0a8c699cef95"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("156ed94d-689e-4983-bac6-49b669a2c51b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9a4f3ee2-359c-474a-ab69-5dc47f99449e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("332fd275-b820-4376-a133-f1a4113766e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(304, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3f79d71-f422-4698-8591-2b108c7f30f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("7e393bdc-03aa-4031-b597-5c2212c3a2fc"),
				ConditionExpression = @"!HasUniqueRecords",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(631, 1014),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18a7d8bd-ec4e-4877-ae7a-cda08558c7fd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51d339e9-cf7e-4f16-9edd-b5b21281c5c4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("8f403262-6b27-405c-bb5c-8092f062cf92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(464, 1028),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("044bba60-6f5b-439c-a9c9-673b7b548fd0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18a7d8bd-ec4e-4877-ae7a-cda08558c7fd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow24",
				UId = new Guid("c1868336-b09f-4927-b414-1860e519e451"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(441, 1094),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18a7d8bd-ec4e-4877-ae7a-cda08558c7fd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6f6e626-9173-43bb-892d-1dd70927d8ad"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("20e273af-6da3-4cda-aa52-8df6cbd3017e"),
				ConditionExpression = @"HasUniqueRecords",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(568, 1100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18a7d8bd-ec4e-4877-ae7a-cda08558c7fd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("036ccbc1-7c40-4779-aafd-195f2a113c7f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("b3ad1599-6952-4e7b-87ae-259fb57a076c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(782, 999),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a8ee5847-b324-40e0-ac57-d433e2a7be16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("51d339e9-cf7e-4f16-9edd-b5b21281c5c4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("77ddf402-4984-4244-861e-d2d9a0519bbc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(713, 1135),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("036ccbc1-7c40-4779-aafd-195f2a113c7f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("e14c9b7a-f1ae-42f4-b862-ba96855be66f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(458, 1194),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8230ea3c-e52a-43b4-b389-8ff1d887eed7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6f6e626-9173-43bb-892d-1dd70927d8ad"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow6ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow6",
				UId = new Guid("c93c5739-2b9a-4a42-a125-3598e8e7e536"),
				ConditionExpression = @"ResolveConflictsAutomatically",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(265, 990),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2fef55d4-a149-4239-bbd2-aaaa8c0bef39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c5fbd9d-715d-4d27-87f7-feedddc92513"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("c6c11aab-9db7-46ea-85b2-f853d72318d9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(409, 956),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2fef55d4-a149-4239-bbd2-aaaa8c0bef39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4145599b-ccfa-4b9b-84f4-3a0131577228"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow29",
				UId = new Guid("6084a1c9-31d8-461d-93d2-7b0d29a26c25"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(349, 847),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("85b40358-1362-474c-b207-97be32e2f623"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2fef55d4-a149-4239-bbd2-aaaa8c0bef39"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow28",
				UId = new Guid("c010ea46-006a-4933-8d05-05c6bdeefcf9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(190, 998),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3b12a25f-942f-4786-85de-3c678b3d8159"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("7622f218-40e2-4404-85c6-ccf0ef219cb6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(580, 1064),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("51d339e9-cf7e-4f16-9edd-b5b21281c5c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b12a25f-942f-4786-85de-3c678b3d8159"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("1a16250e-7ae7-42b2-8f3e-6bbcd3b214e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CurveCenterPosition = new Point(618, 956),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c5fbd9d-715d-4d27-87f7-feedddc92513"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3b12a25f-942f-4786-85de-3c678b3d8159"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("17d5d69b-ec6d-4f3e-a89c-19c123ee4e10"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1476, 1411),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("405ea0a5-6366-49e3-8340-681c8b67b291"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("17d5d69b-ec6d-4f3e-a89c-19c123ee4e10"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"Lane5",
				Position = new Point(29, 0),
				Size = new Size(1447, 1411),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateControlsEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaControlsEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("405ea0a5-6366-49e3-8340-681c8b67b291"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ControlsEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(774, 375),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaControlsEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a9300777-817f-419e-9f58-00a4a08f4ea3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OKButtonClick",
				Position = new Point(29, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6885ac7b-3043-4d03-9368-be80e1c4c482"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OKButtonClickScriptTask",
				Position = new Point(120, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,82,77,111,218,64,16,61,7,137,255,176,245,197,182,106,86,36,71,170,30,40,33,13,82,32,72,16,245,210,203,98,143,97,219,253,176,118,199,193,20,241,223,59,107,67,83,69,85,14,233,30,70,59,158,153,55,239,61,239,82,108,129,127,17,30,230,224,61,221,151,194,128,226,19,5,194,37,233,167,126,175,223,147,37,75,60,58,105,182,124,230,23,181,82,143,110,170,43,60,36,171,124,7,90,44,132,134,52,101,199,126,239,106,249,79,172,113,81,156,243,228,155,112,206,16,208,57,207,216,147,17,27,5,43,80,144,227,227,230,7,197,63,165,243,101,125,168,128,211,92,24,203,24,186,26,2,171,43,7,88,59,211,230,148,158,94,241,156,88,93,9,7,201,82,224,142,127,5,156,54,8,198,75,107,146,59,169,160,101,156,177,136,55,202,55,209,25,148,125,248,204,134,255,39,227,169,82,86,20,97,195,123,69,60,216,237,204,148,246,34,227,206,58,45,48,137,190,227,113,120,162,112,29,194,13,133,153,174,172,195,140,121,20,14,73,193,69,85,198,166,77,14,170,43,207,138,140,221,10,132,181,212,192,23,118,207,215,118,213,226,38,209,129,206,96,62,31,20,5,187,191,31,105,61,242,158,151,101,25,165,105,224,213,234,39,185,171,220,201,10,95,147,9,213,137,53,40,164,1,199,201,24,45,252,207,36,38,134,113,198,226,102,16,210,65,48,130,134,216,70,213,16,119,138,51,86,10,229,225,34,159,88,63,116,77,105,247,204,222,222,74,240,60,23,74,133,174,57,224,206,22,9,33,180,51,65,124,103,253,180,144,72,79,87,130,193,217,109,218,239,177,143,44,138,215,59,103,247,211,103,250,70,68,142,204,203,173,17,42,152,53,98,241,152,174,242,23,144,75,130,138,81,55,81,210,202,165,179,205,97,236,182,212,179,67,173,2,139,151,134,103,9,251,21,146,179,115,91,4,20,105,114,85,23,240,210,128,228,184,173,113,196,174,111,134,237,57,145,222,160,146,245,123,127,255,243,223,16,177,229,192,124,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1483b90f-2cd7-4a8f-a0ed-5ec9d4d45bd3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"CancelButtonClick",
				Position = new Point(253, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("72a640d1-f2a6-492e-981b-181bc27600e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(372, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,141,49,11,194,48,16,133,119,193,255,112,116,74,160,4,157,59,73,177,16,16,113,80,92,186,68,123,13,129,52,87,46,87,42,136,255,221,182,203,247,134,247,61,222,133,188,77,61,169,44,28,146,55,13,241,224,68,21,173,124,15,191,5,199,5,173,212,145,50,66,24,70,98,129,57,164,142,230,162,132,38,68,188,186,1,75,56,127,222,24,237,86,219,78,235,106,191,83,55,231,209,156,242,184,38,184,12,119,100,118,153,122,49,15,107,158,248,170,41,9,83,204,102,21,180,217,30,212,186,100,148,137,19,8,79,88,253,1,20,179,188,154,157,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnsEditButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9e712a18-36a0-475b-962d-c0306448c1f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ColumnsEditButtonClick",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ColumnsEditButtonClick",
				Position = new Point(491, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnsEditButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b661c9a-4585-4ebd-a1cf-bf12efbc9468"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ColumnsEditButtonClickScriptTask",
				Position = new Point(603, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,208,112,47,205,76,209,12,72,76,79,213,243,79,202,74,77,46,113,77,201,44,209,11,75,204,41,77,85,80,180,85,0,201,234,185,230,22,148,84,106,42,84,243,114,113,6,103,228,151,59,231,231,148,230,230,5,151,20,149,38,151,148,22,165,186,86,20,228,228,23,165,22,105,4,39,103,164,230,38,122,166,104,90,243,114,213,242,114,21,165,2,101,243,20,128,202,82,173,1,89,110,178,93,106,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFileUploadEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7fd44619-7e77-4d51-81b2-98f3072dea3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FileUploadEditChange",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"FileUploadEditChange",
				Position = new Point(491, 181),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProductsFileUploadEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2d472483-db62-477c-990b-7c78abe8ad5d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ProductsFileUploadEditChangeScriptTask",
				Position = new Point(596, 167),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,106,195,48,12,134,207,43,244,29,68,79,9,4,147,141,177,195,66,24,164,180,52,52,172,133,110,183,94,204,162,100,6,199,14,182,50,54,66,222,125,118,211,66,70,187,139,144,244,127,72,191,36,42,8,246,188,70,182,22,18,223,91,169,121,185,42,5,177,13,183,190,19,66,63,159,221,221,2,124,185,212,138,80,17,219,107,43,72,104,5,41,196,137,227,39,154,107,185,236,11,13,177,55,157,113,139,79,143,7,50,66,213,55,183,250,50,251,33,180,225,101,204,43,111,208,205,248,15,246,178,67,135,249,236,68,44,185,250,64,153,117,68,90,185,162,61,155,26,219,197,33,57,99,187,237,21,178,219,94,137,27,81,150,232,181,138,75,235,183,20,186,206,85,165,3,123,58,128,173,181,105,56,5,139,35,245,241,224,194,189,11,71,26,13,66,229,204,65,48,61,152,21,168,106,250,132,180,127,24,194,69,4,23,251,17,172,190,157,187,188,105,181,161,188,140,32,248,243,190,20,84,39,37,188,64,12,207,48,125,250,56,46,12,253,171,12,82,103,20,144,233,48,249,5,125,125,195,27,210,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOpenLogButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("14e24ad0-8451-48a4-a648-f72d1e5392f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OpenLogButtonClick",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OpenLogButtonClickStartMessage",
				Position = new Point(29, 289),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenLogButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e3f79d71-f422-4698-8591-2b108c7f30f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OpenLogButtonClickScriptTask",
				Position = new Point(120, 275),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,221,106,194,64,16,133,175,21,242,14,139,87,9,149,125,1,173,224,79,11,161,150,10,26,122,189,102,71,221,26,119,210,153,73,91,223,190,113,45,109,20,210,246,102,96,217,115,190,115,102,88,200,249,173,114,158,197,248,28,82,171,110,85,28,175,128,200,48,110,68,103,169,126,134,245,20,189,16,22,172,23,102,11,201,105,232,49,151,225,161,211,111,171,94,225,50,224,226,100,16,117,159,74,240,115,196,125,85,102,12,180,50,188,215,11,194,28,152,31,224,88,167,52,34,111,84,64,158,198,41,201,56,15,164,51,239,94,43,72,103,45,168,90,187,48,100,14,32,64,92,227,60,188,171,153,203,197,161,55,116,84,67,14,77,250,10,215,47,144,203,40,84,122,51,164,202,107,99,212,237,196,191,24,19,245,103,122,77,190,164,234,177,181,113,143,243,29,28,76,150,218,94,95,221,125,228,80,164,135,18,73,230,184,93,134,159,139,131,37,45,16,176,78,30,209,66,205,16,170,160,77,182,115,22,38,149,8,122,110,40,167,88,20,16,54,27,254,108,120,189,224,72,109,92,209,56,226,255,76,113,91,147,243,165,238,207,200,186,203,23,60,25,116,162,46,129,84,228,67,189,193,39,195,111,156,91,121,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateDownloadTemplateMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9a4f3ee2-359c-474a-ab69-5dc47f99449e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"DownloadTemplateMenuItemClickScriptTask",
				Position = new Point(351, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,221,79,227,70,16,127,14,18,255,195,94,30,78,142,8,230,78,109,159,32,72,16,80,15,137,143,136,64,169,212,246,97,177,39,100,97,189,246,237,174,9,81,143,255,189,179,179,107,199,134,36,208,210,151,216,222,249,254,205,120,102,156,17,191,131,248,144,27,56,3,99,240,126,196,21,200,120,40,129,235,168,183,187,185,33,38,44,50,86,11,117,23,159,152,243,82,202,11,125,156,21,118,30,141,147,41,100,252,156,103,208,235,177,191,55,55,58,163,165,154,14,210,52,60,71,55,92,107,133,138,194,115,159,93,43,126,43,97,12,18,18,123,113,123,143,191,53,41,220,92,205,11,136,81,206,137,245,153,213,37,56,159,58,26,108,169,21,61,227,227,243,230,6,217,190,4,83,228,202,128,247,254,27,240,20,180,161,32,150,144,135,185,178,160,44,145,125,124,108,34,36,184,120,216,128,45,130,67,242,35,215,76,40,99,185,74,28,237,218,128,147,86,232,174,200,85,124,172,172,176,115,47,112,198,21,90,210,241,175,96,79,130,192,225,220,105,105,162,21,64,173,53,126,26,48,133,184,122,16,27,62,84,12,241,144,23,100,233,42,31,147,163,228,243,235,160,125,64,14,49,20,238,242,162,144,34,225,78,112,231,81,165,113,94,128,122,202,228,36,215,25,183,102,59,159,76,68,2,105,158,148,25,10,197,166,208,8,151,153,2,216,76,198,116,237,6,63,191,89,91,144,238,39,27,15,75,173,29,251,37,124,47,193,216,248,80,231,51,68,163,186,178,1,26,62,57,238,250,80,94,160,122,172,18,244,203,105,187,182,66,34,100,241,181,150,35,110,167,72,200,83,136,42,62,74,112,59,52,172,33,159,205,168,27,162,220,62,18,72,51,194,133,215,237,99,180,214,242,100,234,66,217,37,131,10,21,13,254,236,118,217,86,203,254,22,235,198,79,210,60,33,133,48,100,32,13,44,138,247,163,6,155,230,106,91,221,144,173,83,97,236,94,154,151,88,241,251,44,201,101,153,169,27,145,218,169,113,4,68,70,193,140,53,121,40,203,165,113,16,70,103,144,229,122,142,217,7,158,49,227,47,94,162,73,137,194,139,72,66,209,120,145,210,163,144,102,102,150,156,97,177,191,62,141,135,120,100,33,242,182,250,203,88,252,171,153,235,135,219,60,127,8,150,59,59,59,12,177,99,156,85,132,17,215,150,217,156,217,41,176,186,218,28,167,123,169,102,129,169,112,76,131,101,222,185,76,52,85,17,40,157,78,83,176,246,33,32,114,129,133,254,123,38,27,30,215,28,36,253,202,77,226,105,250,217,52,216,242,117,193,57,104,249,238,188,60,135,153,163,236,181,52,238,7,127,155,193,142,237,92,130,121,135,150,54,179,83,197,170,216,107,3,113,109,110,125,244,116,23,173,96,24,19,226,220,114,44,160,54,64,68,49,47,113,33,76,86,233,49,204,248,203,242,124,182,176,173,21,30,20,168,45,29,78,133,76,247,86,42,222,95,235,191,105,59,79,10,49,193,78,164,70,140,113,119,102,76,158,8,44,110,38,44,155,9,59,165,216,102,205,216,66,231,210,32,169,127,154,169,40,78,210,247,4,228,250,126,122,49,161,74,109,229,201,151,65,208,75,167,161,201,87,237,98,119,29,166,236,141,12,19,83,20,94,193,14,185,218,246,189,79,4,98,35,234,215,62,149,82,39,56,81,59,228,14,159,189,171,132,105,72,76,68,79,21,188,235,74,172,129,245,59,234,177,183,54,106,87,145,222,53,186,91,31,189,47,223,85,250,46,243,25,195,17,181,90,7,50,68,107,226,27,130,148,44,241,195,207,221,147,29,129,205,211,247,241,97,94,82,35,253,82,191,236,208,88,10,254,159,149,161,211,193,209,13,56,115,88,212,20,31,146,3,193,15,92,25,90,150,99,79,53,85,101,184,113,254,201,179,198,71,48,249,141,203,18,112,171,27,207,141,133,140,158,216,231,207,196,217,233,68,129,239,186,90,195,220,158,242,218,114,77,198,238,245,232,156,79,123,168,131,253,87,37,231,185,130,222,194,137,202,89,7,66,124,252,189,228,210,68,221,145,206,19,220,14,221,172,4,133,27,94,183,41,80,89,116,245,64,17,145,85,97,216,73,134,54,90,167,239,23,59,197,247,187,44,218,194,21,166,157,70,89,172,174,47,71,13,229,217,146,32,131,97,101,91,37,71,54,77,236,119,191,160,194,101,50,184,236,118,49,161,33,171,119,191,101,8,191,96,114,239,117,181,29,158,194,35,72,246,227,7,251,136,190,163,67,82,83,131,210,138,145,134,216,137,74,225,9,163,252,41,68,208,216,189,214,242,255,92,241,7,236,94,44,78,110,104,70,67,46,147,18,251,29,208,121,5,76,181,54,19,126,189,101,224,215,232,174,79,28,177,44,215,26,148,98,111,105,206,176,168,97,36,176,144,251,207,117,103,117,105,175,154,43,10,123,166,119,117,40,234,3,238,235,193,50,49,248,178,43,246,94,33,66,221,104,151,137,173,173,42,29,255,186,68,63,94,161,43,243,249,139,167,191,137,216,27,88,237,236,96,226,221,48,245,225,27,26,237,166,128,68,76,192,29,207,28,30,171,186,121,16,169,68,87,67,226,25,2,42,165,195,252,222,77,207,118,59,166,229,206,181,222,151,153,168,225,247,106,170,24,252,106,237,117,211,216,186,239,179,89,85,159,247,91,91,139,240,235,97,90,137,6,77,21,4,219,219,75,185,106,212,60,95,115,97,94,236,147,62,43,213,168,246,62,209,209,184,49,154,87,239,154,53,197,111,11,203,190,32,100,110,32,90,184,224,63,37,226,49,192,67,244,5,191,40,240,122,161,197,157,80,241,33,224,175,103,188,157,91,248,227,47,150,162,243,7,90,243,185,91,78,188,220,85,78,7,245,148,110,127,176,29,10,197,245,252,70,11,252,102,169,133,189,202,54,227,49,226,67,231,207,244,81,214,252,35,225,31,239,213,26,98,10,17,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDownloadTemplateButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("156ed94d-689e-4983-bac6-49b669a2c51b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownloadTemplateButtonClick",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"DownloadTemplateButtonClickStartMessage",
				Position = new Point(246, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d133b40d-e88c-465b-b2f8-29a7d9b0b70b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("309de864-8dc1-434c-bba1-9b65ffa57ff9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 275),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d24d946a-686c-4849-87b6-e987f8524999"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("405ea0a5-6366-49e3-8340-681c8b67b291"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"PageEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 387),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(497, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d38dcc1e-f290-46a9-bd9d-22989d8e6527"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d24d946a-686c-4849-87b6-e987f8524999"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"PageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aa6daf4d-b9aa-40d5-b9ed-0664d1f49d8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d24d946a-686c-4849-87b6-e987f8524999"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,205,110,194,48,16,132,207,84,234,59,184,156,146,75,162,158,43,14,16,2,226,80,129,26,232,221,53,19,48,56,118,100,175,249,81,213,119,175,157,84,20,169,234,209,59,223,204,206,122,227,96,11,163,53,4,73,163,179,233,164,130,240,86,210,181,212,59,169,145,21,123,136,99,193,117,121,9,115,194,178,133,229,145,76,134,97,184,104,90,99,105,102,77,83,94,4,212,48,125,121,124,88,241,29,178,169,57,107,101,248,118,141,166,85,156,48,241,68,33,125,124,224,151,242,4,77,46,43,148,20,199,108,225,54,109,228,216,136,145,245,8,246,60,239,3,80,191,154,45,150,186,47,128,59,162,211,163,248,252,175,250,6,103,212,9,225,174,58,172,33,55,246,100,154,80,91,112,165,174,127,61,113,171,249,56,132,47,96,78,236,209,240,69,20,187,164,57,104,197,45,111,64,176,239,92,121,36,195,234,7,233,174,205,115,89,179,228,230,122,26,49,237,149,74,217,103,148,6,213,111,154,198,153,205,189,220,222,216,108,109,42,178,82,239,146,180,15,250,98,80,14,209,57,232,158,125,175,153,84,170,143,185,245,112,73,205,3,153,118,205,45,200,91,221,95,242,13,186,127,164,89,204,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a40b744d-4db4-4832-98b5-3cee92f3a711"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d24d946a-686c-4849-87b6-e987f8524999"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d3d469d5-0a1d-4260-9c66-3ac186314ba8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d24d946a-686c-4849-87b6-e987f8524999"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(357, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,75,195,64,16,61,43,244,63,12,57,181,24,242,7,212,66,105,35,8,126,4,234,199,65,60,172,201,52,93,221,238,198,217,141,26,74,254,187,147,108,43,122,168,253,128,122,241,16,150,204,206,123,243,222,99,153,68,228,24,93,63,61,99,234,226,76,186,40,33,44,4,225,133,49,47,101,113,38,149,67,130,163,83,200,80,97,46,28,66,215,180,189,96,81,103,72,33,248,198,6,26,191,161,118,3,202,45,96,15,230,157,195,131,161,81,138,91,165,209,39,35,217,158,130,170,19,235,72,234,60,4,207,211,239,195,164,29,98,225,20,48,242,3,237,49,163,23,229,104,144,101,93,141,239,176,154,162,29,118,48,15,82,51,99,233,210,26,125,83,21,24,132,224,217,134,63,202,81,252,90,10,85,135,30,82,90,28,73,91,40,81,221,9,85,54,152,137,80,22,97,121,175,112,226,226,143,130,208,90,158,205,134,202,153,78,132,155,114,99,48,174,236,189,161,23,91,136,20,131,37,128,100,62,253,134,72,4,137,25,178,136,150,222,50,172,177,226,117,63,60,194,28,146,38,254,91,219,168,212,218,135,21,125,177,70,231,25,212,53,19,215,189,63,75,228,55,199,151,66,179,92,186,98,75,193,154,4,119,204,35,136,181,147,174,26,167,83,156,137,197,184,160,174,183,247,15,219,4,112,101,28,199,239,132,212,117,8,235,99,216,204,63,236,22,192,185,62,51,42,251,127,174,111,68,190,127,203,139,151,190,129,219,248,195,241,130,99,221,188,211,246,229,218,131,189,231,154,63,57,129,174,87,49,118,84,166,174,36,100,50,101,136,125,16,242,242,205,22,123,181,253,89,209,217,109,217,58,135,132,92,213,192,215,120,252,9,54,1,238,36,228,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCustomEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCustomEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("405ea0a5-6366-49e3-8340-681c8b67b291"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"CustomEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 527),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(813, 870),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCustomEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAnalizeDataStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b03d0300-065f-488a-ac49-322163f816b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AnalizeData",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"AnalizeDataStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAnalizeDataScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3ec95639-0ffa-4e7b-ab7d-137a50520f1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"AnalizeDataScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 112),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,87,221,79,227,70,16,127,246,73,247,63,236,229,225,228,168,169,33,85,213,135,134,80,65,8,109,36,8,148,64,233,169,244,193,216,19,98,177,222,77,119,215,64,138,248,223,59,179,235,117,156,15,115,71,85,85,85,37,176,179,59,51,191,249,30,239,158,200,187,145,152,202,80,27,149,137,187,232,88,170,60,54,97,235,198,60,239,190,224,163,139,143,27,115,32,98,158,253,9,44,141,77,220,97,218,196,202,176,86,135,29,103,28,198,113,14,29,54,124,74,128,143,242,185,84,102,148,182,219,189,247,239,140,90,176,231,247,239,130,43,13,106,32,133,128,196,100,82,68,19,208,26,223,71,8,20,93,64,46,31,32,108,141,225,241,68,202,251,98,78,187,45,18,126,179,212,121,124,7,147,34,73,144,111,90,112,190,24,112,169,33,253,98,44,103,57,164,23,242,81,15,100,33,140,147,36,223,6,146,23,185,24,137,20,158,88,159,125,221,165,253,65,161,20,136,100,177,141,54,210,7,156,59,194,32,158,147,70,125,174,64,131,48,200,98,84,1,150,169,212,55,50,144,107,220,23,240,200,78,50,109,246,92,22,246,195,182,131,250,5,195,158,214,229,244,153,224,139,161,82,82,233,83,153,2,146,200,243,104,125,63,26,204,32,185,135,148,100,118,118,156,182,58,255,17,76,105,121,38,60,35,251,129,237,178,239,89,104,169,68,234,174,208,186,72,251,166,189,180,188,142,213,192,77,204,23,160,37,127,192,16,138,41,207,18,163,15,10,35,177,186,178,36,198,20,121,249,87,153,234,142,156,200,187,90,153,185,16,221,46,12,252,246,59,163,23,197,17,65,30,64,153,232,88,201,252,48,214,240,221,183,19,27,208,144,42,21,137,6,211,96,229,10,141,187,44,68,42,196,57,22,180,125,185,60,156,98,77,168,133,163,132,22,184,221,182,149,92,9,205,145,148,234,25,128,57,146,73,145,83,106,245,150,189,62,219,194,25,157,205,65,132,78,97,135,77,99,174,193,195,7,215,82,221,223,98,73,159,83,123,61,214,23,253,109,10,162,58,127,207,34,76,102,177,130,212,249,124,25,223,114,176,210,122,109,221,95,1,143,182,10,245,42,139,172,206,202,164,229,170,207,126,4,179,194,112,184,160,134,9,235,224,29,54,33,42,237,183,29,36,249,255,107,206,107,161,137,44,11,245,35,211,213,175,254,170,182,168,82,20,13,57,144,247,122,239,53,36,236,160,232,56,83,186,44,147,32,120,136,213,18,221,67,80,92,253,222,171,184,56,23,246,61,82,54,101,225,6,82,100,167,70,216,102,123,125,214,245,249,12,108,125,83,29,158,226,204,193,223,231,177,0,30,29,164,105,185,14,175,99,165,4,134,189,92,119,216,149,160,4,92,205,185,140,83,170,217,138,80,254,184,92,204,33,66,41,18,234,216,177,80,90,85,27,22,182,168,122,53,11,80,225,36,81,217,28,199,58,173,169,15,226,76,128,138,208,152,66,228,177,190,71,223,90,30,72,129,41,148,168,70,78,16,188,52,229,13,163,194,102,184,2,85,15,100,21,146,235,25,40,8,145,182,207,20,241,150,115,146,2,180,154,27,44,22,206,50,253,147,133,26,227,248,70,184,208,3,99,83,226,78,201,57,26,10,44,125,69,49,218,243,109,224,190,88,81,105,95,84,55,112,0,156,239,151,38,214,114,78,128,203,92,126,168,107,174,82,183,33,228,54,94,173,18,171,206,59,21,108,119,104,163,96,208,193,221,118,61,208,100,211,86,147,254,79,213,84,166,156,252,43,219,221,14,250,81,181,179,217,98,157,245,57,86,235,199,37,82,21,173,6,197,52,7,146,242,187,220,248,225,13,130,169,196,180,38,51,22,54,164,153,37,244,200,196,90,113,85,218,173,26,123,74,48,196,142,193,44,192,77,204,106,25,18,68,147,83,214,171,13,128,15,101,51,120,45,44,240,174,80,86,54,248,61,214,75,205,255,193,210,119,47,235,184,202,130,195,65,253,90,92,174,68,154,233,4,207,76,248,197,56,206,128,167,118,134,186,163,227,48,159,155,133,99,115,61,89,131,12,189,178,118,143,237,236,48,157,225,249,1,166,83,60,146,233,42,137,35,60,40,101,121,172,22,71,153,158,243,184,60,93,13,159,208,12,205,62,126,100,27,167,49,58,114,253,243,221,193,190,98,167,153,166,79,125,105,135,141,165,61,91,253,119,250,135,234,75,193,31,69,86,229,97,44,13,58,193,33,117,101,118,177,157,184,108,171,141,202,235,176,230,28,49,123,128,178,253,85,111,223,6,37,190,155,155,108,104,48,124,165,159,27,100,63,215,222,238,70,96,133,108,218,244,129,72,237,164,213,46,44,205,244,47,140,204,242,179,209,124,208,175,140,164,155,71,89,42,17,229,186,60,242,246,54,169,190,160,224,201,44,27,170,188,139,185,243,46,134,160,210,167,107,53,188,222,143,237,45,232,163,68,10,132,109,253,124,53,156,92,142,206,198,173,45,60,135,133,49,110,46,180,62,13,39,227,179,109,60,120,84,159,35,143,239,20,63,40,142,50,123,179,194,206,45,199,133,143,224,190,15,68,240,220,90,128,198,27,99,121,211,250,4,222,133,214,75,167,98,17,114,201,49,150,235,12,47,127,187,137,108,105,208,3,255,241,47,137,77,50,11,233,42,97,179,198,192,229,235,95,251,188,190,213,129,178,212,253,32,65,15,78,222,126,103,7,145,50,218,189,49,159,185,183,215,27,235,47,31,107,82,163,28,16,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateAreInputDataCorrectExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("77c05c9d-0734-4cd8-bb4b-4cfc02f34d80"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"AreInputDataCorrectExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 112),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("a3fcf61e-9094-44c7-b13e-e46356942dd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"End1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3fcd3e83-34e6-419e-af56-a615adf4a994"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"UserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(434, 112),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("85b40358-1362-474c-b207-97be32e2f623"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 238),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowSaveProductsIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c16d35bf-f6cd-46c2-8374-f37d475f6dc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ThrowSaveProducts",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ThrowSaveProductsIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(455, 252),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveNewLookupDataStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d089505d-965d-4d4c-8553-af0257905b8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SaveNewLookupData",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SaveNewLookupDataStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 252),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOpenNewLookupDataPageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4145599b-ccfa-4b9b-84f4-3a0131577228"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OpenNewLookupDataPageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 350),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,77,75,195,64,16,189,11,254,135,101,47,77,160,9,137,138,84,138,135,18,173,4,106,21,218,122,177,30,166,217,105,93,154,236,134,253,48,5,241,191,59,219,224,65,133,94,102,119,118,230,189,121,251,102,166,119,165,218,234,200,58,35,213,46,157,106,211,128,139,248,218,125,102,95,20,114,10,107,247,212,162,98,157,84,66,119,108,142,221,76,235,189,111,239,192,193,51,236,144,15,217,84,214,56,135,6,135,236,254,80,97,93,54,173,54,174,20,113,60,62,63,91,89,52,133,86,10,43,39,181,74,23,104,45,157,1,252,202,127,113,241,55,118,203,250,116,42,177,22,47,80,123,180,19,37,10,237,149,179,68,21,100,252,27,191,4,187,79,67,5,77,169,172,3,85,97,41,136,233,39,89,149,226,36,148,244,21,222,24,84,110,66,10,63,48,20,8,238,140,199,147,184,112,89,29,39,41,236,216,131,151,34,226,0,215,40,110,16,146,77,54,202,147,43,172,174,18,200,183,89,146,229,34,203,225,114,180,185,128,17,143,79,210,22,181,182,248,72,38,245,50,248,242,221,232,110,1,164,203,104,225,43,103,57,193,67,119,58,17,98,81,25,217,186,191,187,11,85,114,220,129,36,79,82,172,211,134,136,163,1,45,116,48,100,131,67,18,210,164,214,32,8,196,54,100,50,61,135,239,14,217,22,106,139,125,18,143,105,175,179,190,233,184,71,131,206,27,213,251,242,13,55,86,26,24,53,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenNewLookupDataPageTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4a2732a8-4466-4a9d-b3a5-92c4232d5631"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"OpenNewLookupDataPageTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 469),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenNewLookupDataPageTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImportYesMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5d84bae3-0eb0-44d5-bc02-18ba9ce202f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ImportYesMessage",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ImportYesMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(574, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateImportYesScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("609cc4fb-51a1-4ff5-94bf-b0a7ba567161"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ImportYesScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(644, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,140,205,10,131,48,16,132,239,133,190,67,200,197,8,49,244,238,169,244,231,36,69,176,47,176,173,91,43,198,68,214,141,10,165,239,222,88,143,51,243,205,87,66,131,230,88,215,213,147,218,129,213,200,212,186,198,92,61,245,192,74,150,113,61,121,199,208,58,36,131,214,244,48,118,42,249,28,190,137,22,201,146,173,49,179,30,234,120,18,15,27,48,214,76,1,181,120,129,29,113,11,105,46,181,40,54,40,77,243,253,238,254,38,63,95,38,116,172,158,81,142,11,107,33,43,152,240,134,115,225,125,23,134,51,48,200,21,37,228,64,238,175,201,127,251,139,104,3,171,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateImportNoMessageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("19902afc-d7da-457c-bfc9-b4eaf3187d41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ImportNoMessage",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ImportNoMessageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(574, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd2EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("13ecd1e7-ec17-4727-92bb-fb3b35bf2ef9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"End2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(665, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateThrowSaveProductsStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7f851def-af74-471e-a67e-e5883b5a09e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ThrowSaveProducts",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ThrowSaveProductsStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(574, 252),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateThrowSaveProductsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0d7ab517-1e17-4539-bdbc-052d88773726"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ThrowSaveProductsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(644, 238),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,142,193,170,194,48,16,69,247,130,255,16,178,105,203,147,160,46,219,85,241,41,188,133,82,168,126,64,104,198,118,32,77,100,58,169,79,196,127,55,85,208,217,205,189,103,230,222,74,183,160,74,99,234,134,240,194,233,192,132,174,85,59,79,189,230,84,222,151,15,213,104,107,171,72,237,129,59,111,82,185,16,211,166,118,104,225,116,177,94,155,173,65,86,27,139,224,248,239,55,155,207,196,143,144,201,177,35,127,221,142,81,75,22,226,46,6,108,157,182,7,221,67,46,146,90,143,80,145,55,161,225,33,186,242,125,114,142,153,81,253,191,149,212,70,168,227,222,78,53,190,192,136,112,173,89,51,236,189,153,222,160,107,108,48,240,5,112,120,23,202,5,83,128,143,204,216,131,15,156,139,213,122,249,154,71,86,200,172,136,230,124,70,192,129,220,139,47,158,123,223,44,81,11,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveProductsStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("139094b4-ae29-4107-b744-f7188f034b1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SaveProducts",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SaveProductsStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 672),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("68223875-5183-4512-b0b0-e0cf7ab94c77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 658),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateClearSettingsScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("50eb6e8a-9e92-4221-b2cc-3a5d22179d3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ClearSettingsScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 777),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,63,107,196,48,12,197,231,6,242,29,92,79,14,28,166,157,67,135,146,246,32,112,28,165,161,83,211,193,56,74,48,103,91,65,150,251,135,227,190,123,157,238,133,91,222,67,18,250,61,161,3,46,125,156,81,37,38,23,23,189,71,10,134,149,28,249,124,119,41,114,95,100,228,206,131,33,49,202,35,124,29,16,79,121,125,50,108,94,204,2,67,182,22,82,154,179,247,63,157,199,4,211,40,229,78,236,157,135,163,9,176,19,207,223,22,124,31,86,36,238,167,166,105,235,202,205,66,189,37,160,14,99,4,203,14,163,30,10,162,248,6,125,191,38,67,126,136,219,7,17,75,163,17,231,186,186,249,31,167,95,33,224,39,168,171,168,219,117,151,186,170,171,109,174,31,167,105,176,228,214,242,140,173,46,124,54,46,2,105,240,58,199,96,210,73,53,237,223,14,1,103,138,130,41,67,251,11,145,83,128,97,79,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSaveProductsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("51d339e9-cf7e-4f16-9edd-b5b21281c5c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"SaveProductsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(518, 567),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,81,79,219,48,16,126,14,18,255,193,244,1,165,162,138,166,77,219,30,218,34,109,165,76,209,10,84,3,182,135,174,15,110,114,41,222,28,59,178,29,32,155,248,239,59,59,110,73,160,165,98,145,154,212,185,239,124,223,221,125,231,220,82,69,148,188,211,100,72,78,25,135,19,106,40,161,154,104,163,152,88,206,230,179,121,127,127,143,9,67,140,52,148,127,67,224,72,150,184,28,58,167,104,2,98,105,110,60,132,229,133,84,6,210,38,234,13,218,110,49,132,128,187,137,148,191,203,194,6,152,210,37,92,150,73,2,90,103,37,231,213,136,75,13,233,37,46,153,20,142,193,112,127,47,184,214,160,70,82,8,72,12,190,142,26,230,104,42,139,129,92,252,66,203,113,216,57,223,189,117,167,187,137,70,43,32,249,175,112,110,99,163,42,242,23,9,179,140,132,175,204,243,96,72,4,90,200,225,33,250,7,193,86,122,79,112,225,66,74,222,125,93,172,174,227,24,60,171,2,166,30,78,152,54,131,171,178,224,48,248,82,178,180,231,219,191,253,233,88,124,133,234,59,229,37,76,41,83,45,191,227,30,57,97,174,140,84,85,3,148,70,143,140,36,231,117,101,237,250,24,175,238,182,100,251,118,243,76,42,160,201,13,9,45,95,16,134,153,138,48,209,102,238,51,114,41,101,168,93,71,6,211,169,225,81,108,32,127,219,95,35,184,243,219,128,121,87,99,108,247,14,106,254,81,172,207,177,134,23,106,156,23,166,10,27,158,93,236,64,35,22,182,165,101,172,249,52,194,181,35,189,239,63,181,159,211,252,9,155,15,145,219,171,129,100,34,133,123,208,109,216,199,126,221,131,118,161,28,212,214,201,251,172,25,173,96,14,165,203,69,220,2,70,109,250,65,96,103,123,86,155,176,201,243,217,202,99,78,90,9,123,146,193,67,253,124,120,228,12,247,9,240,213,121,18,139,186,103,54,5,108,32,185,2,165,168,150,153,137,112,222,50,182,44,21,117,35,55,222,232,20,182,7,179,235,131,110,142,128,99,107,78,32,67,181,149,185,112,28,117,184,195,35,78,145,150,85,111,132,147,109,159,187,28,78,27,82,91,75,225,101,151,73,75,123,207,43,248,162,155,215,200,163,96,118,84,128,222,194,58,5,39,234,88,95,8,94,141,149,146,74,159,201,180,209,232,90,238,36,199,225,195,227,3,131,120,253,159,74,149,83,19,126,74,211,245,105,231,154,51,145,9,229,236,15,93,112,184,108,158,4,246,234,252,236,116,200,209,74,247,71,196,174,159,155,31,103,103,27,162,57,167,53,102,149,76,48,145,75,71,35,118,31,26,92,133,158,249,10,81,43,208,221,237,205,254,198,247,144,148,6,106,23,231,237,78,75,37,237,73,25,90,161,91,103,68,38,212,216,49,178,144,194,10,141,248,58,217,131,53,250,76,53,156,213,177,166,84,0,143,176,52,126,29,254,160,74,9,172,133,95,247,200,181,176,5,186,46,184,164,169,237,207,218,224,255,92,85,5,68,232,37,92,1,141,42,193,83,80,96,74,37,220,155,254,63,156,113,217,252,152,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd3EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("a6f6e626-9173-43bb-892d-1dd70927d8ad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"End3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(399, 791),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckUniqueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("044bba60-6f5b-439c-a9c9-673b7b548fd0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"CheckUniqueScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(266, 658),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,75,107,194,64,16,62,71,240,63,12,158,18,176,246,65,233,161,214,150,226,131,6,236,131,64,123,81,15,67,50,234,210,100,55,221,157,52,138,248,223,187,155,216,131,69,122,104,61,100,67,54,223,124,143,153,57,61,237,71,143,39,87,23,151,103,205,198,39,106,208,170,52,208,131,145,72,105,128,140,128,6,12,107,33,23,147,217,100,214,109,54,132,100,96,197,152,70,22,216,87,133,253,236,85,69,157,49,201,5,47,45,100,172,22,161,156,43,191,174,235,140,148,206,144,253,214,148,55,103,91,123,156,219,99,202,247,73,2,146,74,216,92,108,33,85,234,189,200,219,86,8,53,131,95,10,153,168,18,166,173,39,42,199,213,47,231,228,5,23,52,109,5,173,118,229,237,9,51,106,195,112,21,83,26,102,185,210,28,38,237,31,190,130,160,91,71,18,21,128,146,144,41,115,217,156,236,88,24,190,169,13,222,250,14,248,128,230,85,138,143,130,34,138,149,78,28,110,142,169,33,23,121,14,126,104,94,180,200,80,175,7,194,228,41,174,251,42,45,50,57,92,89,26,19,192,166,217,240,88,175,171,183,55,87,154,48,94,130,191,107,39,8,89,53,168,134,121,158,187,206,247,200,222,48,45,200,10,254,38,2,119,142,100,226,114,215,215,161,76,104,53,131,235,221,120,58,195,44,231,117,183,82,112,134,247,66,119,250,74,50,10,105,252,3,194,193,183,49,239,64,15,88,23,84,147,110,107,234,61,90,59,196,131,140,85,133,43,112,79,140,28,47,125,55,170,156,133,146,64,59,189,63,175,201,48,138,158,163,227,174,137,51,186,253,199,230,146,76,142,107,72,19,23,90,214,237,255,2,64,11,6,85,163,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("18a7d8bd-ec4e-4877-ae7a-cda08558c7fd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(385, 658),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareUserQuestionScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("036ccbc1-7c40-4779-aafd-195f2a113c7f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"PrepareUserQuestionScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(553, 658),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,93,107,194,48,20,134,175,39,248,31,66,174,20,186,234,198,216,141,219,96,115,149,21,102,253,168,94,8,5,9,237,153,11,179,73,151,156,160,34,254,247,37,166,99,31,244,38,33,231,60,231,205,155,55,189,222,112,62,190,188,189,190,233,183,91,175,114,19,139,55,217,209,168,184,216,132,35,169,74,134,29,154,225,177,127,178,203,149,93,50,76,223,229,142,148,160,53,219,0,201,232,11,211,100,41,248,167,1,50,135,92,170,66,103,148,6,100,196,183,144,176,18,2,18,237,115,216,198,101,37,21,198,69,183,59,248,185,134,174,83,100,10,169,171,45,53,168,177,23,245,106,225,212,233,223,19,183,53,246,235,211,2,246,104,49,107,195,215,107,19,117,183,113,50,206,165,176,35,116,182,140,210,69,60,73,104,35,245,100,16,165,208,14,92,69,105,50,105,166,230,160,43,75,65,93,117,184,128,29,121,230,57,114,41,152,58,220,249,48,3,226,247,7,114,108,183,46,142,244,0,218,166,68,189,138,79,103,5,223,174,233,41,56,67,66,254,103,18,249,27,57,89,75,46,159,240,177,40,210,92,241,202,126,150,59,15,165,64,198,5,168,16,182,161,17,37,211,31,157,238,128,254,201,126,170,160,98,10,220,139,102,6,180,115,235,37,22,150,142,246,144,27,132,117,36,138,243,148,2,52,74,16,84,6,6,95,45,18,227,72,49,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUniqueImportYesMessageStartStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a8ee5847-b324-40e0-ac57-d433e2a7be16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UniqueImportYesMessage",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"UniqueImportYesMessageStart",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(728, 581),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaUserTask CreateUserMessageUniqueUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a7257ece-2ec3-44b6-a438-86d49657a5d4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"UserMessageUnique",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(707, 658),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeUserMessageUniqueParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUniqueImportNoMessageStartStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8230ea3c-e52a-43b4-b389-8ff1d887eed7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0eaeb1f0-d1dc-43b0-85dd-8eb0b02beb3f"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"UniqueImportNoMessage",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"UniqueImportNoMessageStart",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(728, 791),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateExecuteImportExcelLookupProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c5fbd9d-715d-4d27-87f7-feedddc92513"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ExecuteImportExcelLookupProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(434, 350),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,193,106,27,49,16,61,215,224,127,16,123,178,97,49,205,57,109,33,172,237,102,67,210,26,76,211,75,46,178,52,78,149,104,53,203,72,106,109,140,255,189,210,74,235,216,91,154,203,34,205,123,243,244,70,122,123,143,207,181,217,226,196,58,82,230,121,182,68,106,184,155,20,79,238,240,241,24,62,87,225,243,228,214,142,147,3,198,189,67,166,154,22,201,177,150,80,8,176,69,201,150,74,195,55,222,64,201,22,59,1,186,238,240,90,78,167,215,227,81,82,101,47,184,137,12,246,153,21,9,238,152,247,136,175,190,157,115,199,139,11,234,87,66,223,14,184,145,213,213,207,168,209,2,88,251,95,229,85,194,99,199,111,78,61,125,197,41,52,56,32,27,154,12,252,97,115,37,156,66,195,105,255,41,9,151,12,55,47,32,220,151,201,148,29,198,163,15,135,226,98,176,98,48,232,177,236,56,233,204,133,113,202,169,238,94,82,97,169,64,203,71,174,61,216,27,35,43,244,198,217,220,81,219,245,222,136,68,171,208,108,117,48,18,27,29,121,56,81,86,164,154,96,109,174,108,171,249,190,66,237,27,179,216,41,219,49,223,131,179,194,26,116,24,5,100,45,33,88,219,42,193,227,176,137,24,37,222,197,179,70,188,225,84,169,141,132,93,232,26,84,50,175,226,109,108,142,178,253,50,35,125,70,206,226,210,251,19,191,160,225,25,123,219,244,243,119,119,252,128,50,162,111,155,211,237,124,55,122,191,32,66,178,61,103,80,202,204,91,224,18,40,10,71,115,103,187,139,115,78,73,203,54,227,242,56,30,29,67,128,110,218,54,154,147,94,3,205,250,85,221,52,32,21,119,144,147,118,135,155,73,142,122,121,10,114,121,158,211,120,218,15,11,20,158,219,64,23,187,217,79,164,87,219,114,1,179,212,55,128,43,79,20,94,38,86,51,225,159,28,199,31,141,192,121,50,93,116,174,255,2,103,220,188,123,211,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateChooseImportTypeExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("2fef55d4-a149-4239-bbd2-aaaa8c0bef39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ChooseImportTypeExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 350),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateImportStartedMessageBoxUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ac184610-4dd6-4751-9b6f-a9ebc14c3440"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ImportStartedMessageBox",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(693, 350),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeImportStartedMessageBoxParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCloseImportSetingsPageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3b12a25f-942f-4786-85de-3c678b3d8159"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9350d830-38e6-48a6-aed0-bd8d88bf4282"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"CloseImportSetingsPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(574, 350),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,106,195,48,12,134,207,43,244,29,132,79,9,148,176,157,187,13,218,108,133,176,53,29,109,97,151,92,140,163,101,166,137,21,108,133,116,148,190,251,236,38,151,237,144,139,100,203,223,175,31,75,239,84,101,230,139,34,199,86,155,42,217,144,109,36,71,162,224,203,253,213,135,7,31,10,78,107,114,8,133,200,154,150,44,31,144,61,234,62,100,133,133,0,105,74,112,223,212,67,131,206,249,146,199,14,44,45,99,9,250,134,67,107,73,41,116,73,33,196,2,54,186,198,92,54,184,128,215,179,194,122,232,152,149,113,188,156,207,198,246,131,122,59,180,91,211,57,9,78,240,4,33,77,80,159,218,148,212,167,178,101,77,198,227,127,184,177,60,33,31,143,71,60,243,127,241,248,52,33,206,212,205,82,100,249,102,183,223,174,142,217,46,23,19,248,186,99,38,227,130,98,247,54,5,238,209,181,30,196,177,20,20,6,123,120,209,42,252,70,218,159,199,97,111,11,24,242,51,92,230,179,187,139,160,147,31,181,72,165,241,35,30,204,210,90,171,147,184,206,103,87,111,23,38,153,172,202,242,160,172,110,253,182,195,61,37,195,82,27,180,9,214,73,103,26,233,78,81,188,20,97,47,22,185,179,6,216,118,184,252,5,97,150,20,165,48,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7f9cd08a-6084-4095-8853-c149046631ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("405ea0a5-6366-49e3-8340-681c8b67b291"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"EventSubProcess1",
				Position = new Point(540, 387),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5c180dfd-5def-4646-a3bc-414d9d824203"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f9cd08a-6084-4095-8853-c149046631ec"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectEditChange",
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ObjectEditChangeStartMessage",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c3796db3-3d94-4e73-8633-c3f1cf2880fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f9cd08a-6084-4095-8853-c149046631ec"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Name = @"ObjectEditChangeScriptTask",
				Position = new Point(161, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,206,72,205,77,244,76,81,176,85,208,112,47,205,76,209,12,72,76,79,213,243,79,202,74,77,46,113,77,201,44,209,11,75,204,41,77,181,230,229,2,139,59,231,231,148,230,230,21,131,37,156,115,82,19,139,52,52,97,82,110,153,57,169,161,5,57,249,137,41,104,178,64,137,156,96,176,45,1,137,69,137,185,169,37,169,69,197,26,37,69,165,169,32,201,162,212,146,210,162,60,5,16,215,26,0,93,190,13,210,139,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFormatHeaderNamesMethod());
			Methods.Add(CreateAddHeaderAndCaptionMethod());
			Methods.Add(CreateGetCellValueMethod());
			Methods.Add(CreateGetRequiredFieldsNotFilledMethod());
			Methods.Add(CreateGetColumnNameMethod());
			Methods.Add(CreateGetColumnIndexFromNameMethod());
			Methods.Add(CreateGetLookupFieldValuesAndCountsMethod());
			Methods.Add(CreateCreateItemMethod());
			Methods.Add(CreateGetWorksheetPartByNameMethod());
			Methods.Add(CreateFillSchemaParametersMethod());
			Methods.Add(CreateShowColumnStructureExplorerMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateSetMetaPathInfoMethod());
			Methods.Add(CreateCalculateWidthMethod());
			Methods.Add(CreateCreateColumnDataMethod());
			Methods.Add(CreateCreateStyleSheetMethod());
			Methods.Add(CreateTranslateForegroundMethod());
			Methods.Add(CreateLogExcelImportMethod());
			Methods.Add(CreateCheckRequiredFieldsNotFilledMethod());
			Methods.Add(CreateCheckIsNullDataMethod());
			Methods.Add(CreateLogInfoMethod());
			Methods.Add(CreateLogExcelImportLogMethod());
			Methods.Add(CreateExecuteImportExcelDataProcessMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cdea4c3a-f0aa-4666-af2c-f060eac639ed"),
				Name = "DocumentFormat.OpenXml.Packaging",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d6b790d5-5565-48b7-b734-6b4ab63d49b5"),
				Name = "DocumentFormat.OpenXml",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8d747696-60f8-45bf-9029-a22498a45b7a"),
				Name = "DocumentFormat.OpenXml.Spreadsheet",
				Alias = "OpenXmlSpreadsheet",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09ac125d-462e-44be-b391-bfb79eda661a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("155c7b62-6af3-4fdd-b5a6-b6d56b46c2ae"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3fe7bab0-b8a8-4f1a-9504-d6d5248e37f1"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c5b92ba2-fd91-4f30-9406-d2cba6914d08"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("58b837be-fe71-4722-a0f7-2b9342e240f6"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dee4e615-c2d4-4100-bb52-26e4aaedc021"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3398073d-e31d-49a5-9d33-5441108d0986"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("18f1059f-2038-4d85-a32e-61f4e5a96daa"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("c6dca304-a1bb-4543-b6b7-745cf618e36d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5179748-0081-464f-9655-a948893a91a0"),
				Name = "System.Diagnostics",
				Alias = "",
				CreatedInPackageId = new Guid("e7cfe45f-b5b2-4226-968e-5b1797c1b4ca")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bc137692-d916-4fbc-8b6f-454799976a52"),
				Name = "Terrasoft.Core.Scheduler",
				Alias = "",
				CreatedInPackageId = new Guid("ff6db8c2-aaeb-43c3-ad7c-1d48a4333145")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("824478e3-b25b-45c5-9009-fe25beb15fa4"),
				Name = "Terrasoft.Configuration.ImportExcelData",
				Alias = "",
				CreatedInPackageId = new Guid("380e5823-e58a-46ec-aacb-19be835fa110")
			});
		}

		protected virtual SchemaMethod CreateFormatHeaderNamesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7d8ac492-8a1a-4e4f-bdd4-7896f7cb02fa"),
				Name = "FormatHeaderNames",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("88917718-afc9-478c-b932-2aedb6683c3c"),
				Name = "captions",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,193,82,219,48,16,61,59,51,249,135,37,7,198,158,100,12,189,2,161,19,66,104,61,13,148,161,165,39,46,194,222,128,6,89,114,37,133,38,67,248,247,174,44,37,117,169,19,14,61,196,227,104,245,222,219,93,189,149,167,234,33,147,51,21,27,171,185,124,72,47,148,46,153,141,123,119,246,229,240,149,30,31,232,113,103,47,209,62,170,194,28,129,15,127,70,86,160,190,98,37,154,222,0,46,184,64,247,62,128,201,34,71,145,149,149,210,54,43,146,228,184,219,121,102,26,80,90,110,151,223,242,71,44,25,12,225,214,160,30,43,41,49,183,92,201,116,210,136,94,50,201,30,80,167,159,208,102,210,88,38,115,60,91,58,234,216,199,221,107,114,12,7,7,144,179,202,161,77,183,195,165,5,46,11,92,16,245,97,80,212,248,115,206,53,22,99,37,230,165,52,153,11,163,161,13,18,127,193,148,27,123,66,168,211,120,157,160,80,234,105,94,181,110,62,231,117,150,76,47,29,100,0,190,75,30,154,153,107,205,75,10,157,115,83,9,182,244,4,147,5,241,59,120,220,172,59,109,219,10,123,36,50,23,194,145,121,98,168,90,182,185,170,137,111,167,220,71,120,87,45,173,121,142,66,9,233,164,172,236,146,132,103,74,35,203,31,33,24,96,221,89,234,233,166,201,9,188,116,59,209,189,82,2,184,241,100,227,16,186,214,104,72,153,210,155,49,97,144,248,162,13,161,107,109,238,11,37,178,191,242,11,189,246,196,17,159,65,188,246,223,88,149,21,211,24,123,96,26,116,210,31,76,204,201,96,33,163,1,88,61,199,4,134,116,228,9,172,86,142,36,218,70,225,173,217,134,76,146,90,62,26,21,133,119,244,72,22,65,176,9,118,199,19,249,44,195,234,141,247,87,73,53,125,95,86,232,216,154,54,246,213,189,217,148,142,170,74,240,156,57,246,41,62,163,168,73,163,213,10,254,135,244,252,172,230,10,141,140,162,118,231,167,84,97,92,15,73,168,229,181,219,121,91,83,102,166,245,24,212,218,251,251,176,215,54,21,212,91,105,25,151,230,11,46,3,225,70,186,117,255,70,120,240,167,204,25,106,164,201,14,86,104,116,184,153,213,78,183,83,122,141,243,113,157,218,54,55,155,236,220,31,191,156,133,203,162,78,43,8,131,215,221,106,110,103,26,191,245,158,204,253,84,191,82,182,245,207,103,59,18,162,29,236,90,185,133,56,36,183,3,60,220,54,112,199,13,241,119,232,219,220,221,188,3,124,243,29,81,88,205,204,21,93,74,95,117,29,141,111,101,193,77,174,158,233,208,138,11,142,162,48,155,35,255,55,4,253,33,244,78,122,208,223,92,35,125,232,157,246,124,191,0,233,134,216,13,29,192,54,240,186,94,119,104,253,62,173,213,102,185,217,118,209,183,207,1,193,166,45,46,165,198,212,223,50,194,181,153,152,80,26,237,92,203,96,153,223,195,211,238,71,50,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddHeaderAndCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7307f76b-895d-41af-b87a-d7ebf4252680"),
				Name = "AddHeaderAndCaption",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4b4a5608-cd16-4bc0-bb5a-bface9a65c8a"),
				Name = "name",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,72,77,76,73,45,242,75,204,77,45,86,176,85,240,64,226,37,22,43,248,100,22,151,216,20,151,20,101,230,165,219,89,115,33,41,213,115,76,73,209,200,3,178,52,173,1,143,192,214,158,69,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCellValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("82225085-4cd8-47ae-bef1-5b2f83e14585"),
				Name = "GetCellValue",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a443f587-22b9-4967-bafb-c08f236fb5a5"),
				Name = "cell",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "OpenXmlSpreadsheet.Cell",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24d83445-9f41-47ca-8670-1d987759d88b"),
				Name = "stringTablePart",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SharedStringTablePart",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,143,65,11,130,64,16,133,207,9,254,135,233,34,118,89,162,142,226,201,58,120,42,80,34,136,14,91,78,41,76,147,236,142,81,68,255,61,93,147,240,50,135,55,143,239,189,87,93,32,60,35,145,74,202,138,138,53,225,13,89,172,74,238,13,11,196,49,204,103,240,246,189,137,65,105,12,3,55,68,145,239,125,124,207,247,172,152,138,175,240,208,212,32,196,208,67,218,179,235,4,149,50,163,201,241,41,81,231,173,134,148,149,22,157,191,106,132,105,236,96,16,4,48,126,180,153,155,26,121,127,163,172,54,168,11,91,34,202,31,108,85,86,106,131,69,230,210,251,114,67,133,190,81,174,79,132,91,109,100,228,116,234,120,228,33,101,89,46,84,107,181,24,58,198,236,56,234,237,102,254,150,187,127,244,5,100,187,99,0,46,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRequiredFieldsNotFilledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4ee3930e-703f-4863-b3ee-a990c19d7885"),
				Name = "GetRequiredFieldsNotFilled",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("087a0163-52ca-4673-964a-2ac25383458e"),
				Name = "sheetData",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "OpenXmlSpreadsheet.SheetData",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8389520d-c0f6-489c-bebc-57890bd1623b"),
				Name = "stringTablePart",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SharedStringTablePart",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("da2ff9e6-e56d-4dfd-9843-fcc7f38b4071"),
				Name = "captions",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,219,78,227,48,16,125,14,18,255,96,120,64,137,64,1,94,41,45,130,46,93,85,98,1,117,209,238,74,208,7,211,76,105,132,99,119,109,135,130,80,254,125,61,190,180,164,165,40,139,120,201,197,158,153,51,151,115,156,92,136,135,62,31,139,88,105,153,243,135,180,39,100,65,117,188,125,167,95,15,42,115,57,52,151,59,253,3,244,68,100,234,136,124,7,61,128,191,101,46,33,235,229,192,50,117,41,116,47,103,12,178,237,61,98,30,224,146,22,176,71,206,159,71,192,250,197,84,72,221,207,146,164,181,185,241,68,37,145,222,179,43,88,89,112,213,231,25,60,131,34,109,50,120,127,131,42,114,145,43,125,156,115,221,89,10,177,4,110,98,112,152,57,107,87,72,39,70,84,239,36,102,106,213,226,118,232,108,188,133,5,53,86,7,53,183,111,84,83,179,168,38,0,26,159,211,115,6,5,112,173,142,175,166,192,255,20,236,231,84,2,205,236,126,58,16,51,19,114,115,35,74,127,79,64,66,108,2,144,118,7,227,224,150,3,232,144,67,4,29,11,227,54,154,144,216,3,145,156,207,241,18,242,106,98,228,99,130,1,62,4,236,2,99,6,49,237,138,146,235,56,33,109,147,190,243,142,70,130,235,156,151,96,176,162,10,43,138,16,41,87,151,37,99,190,40,45,221,118,45,23,51,55,230,147,105,2,237,209,48,89,67,13,92,252,69,89,9,49,134,217,35,174,209,55,244,158,193,53,149,58,33,91,102,10,38,1,239,21,213,210,25,83,166,108,62,81,116,111,112,30,237,99,53,79,31,33,22,246,31,86,57,162,83,157,11,174,108,91,76,228,240,238,250,132,182,216,234,244,52,203,98,228,132,167,67,205,107,136,67,138,12,241,76,47,22,188,136,238,133,96,75,28,60,3,236,159,227,186,49,187,166,15,144,118,39,48,122,28,172,53,179,219,103,226,217,217,65,246,133,67,112,217,118,218,245,30,132,126,215,251,138,229,157,88,44,167,187,160,128,24,215,19,28,231,98,185,39,69,129,210,142,231,203,246,13,157,109,22,3,24,27,198,243,17,88,177,71,81,200,103,57,186,39,0,217,217,241,141,61,94,78,32,228,154,9,255,16,185,249,132,138,222,204,243,214,134,24,58,206,56,193,188,123,144,152,185,115,77,115,174,92,123,18,68,223,90,63,197,144,129,11,185,181,230,200,89,4,245,233,36,11,191,104,157,15,82,46,152,251,180,221,40,204,141,184,59,82,243,54,156,71,67,95,34,30,65,238,124,62,47,166,250,37,84,140,123,187,187,238,173,34,179,137,57,127,3,5,86,251,218,34,251,251,117,86,56,38,16,171,27,43,156,39,212,174,193,106,32,229,86,152,112,243,150,251,10,250,86,196,87,210,86,18,91,200,166,19,105,198,132,79,78,173,249,204,170,185,130,214,13,203,53,50,144,253,196,191,31,173,14,241,205,8,171,112,200,133,249,189,163,224,70,13,152,43,231,235,21,241,89,65,252,135,30,42,207,102,123,107,46,134,183,90,88,149,194,10,237,43,247,17,232,207,189,236,215,3,127,96,252,215,200,126,33,110,196,169,148,244,197,254,38,72,208,165,228,235,126,64,90,255,0,211,208,12,3,71,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("47ce9e1c-da49-4156-9607-9d364c820160"),
				Name = "GetColumnName",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3ee3f2c5-8bee-4555-bfe8-47fe5d813d9e"),
				Name = "cellReference",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,77,79,173,80,40,2,147,182,10,121,169,229,10,65,32,182,134,82,180,163,110,84,162,110,85,172,182,146,166,53,151,111,98,73,114,134,66,46,152,180,133,168,214,3,139,105,36,167,230,228,4,165,166,165,22,165,230,37,167,2,85,22,165,150,148,22,229,65,148,234,133,37,230,148,166,90,3,0,228,132,78,250,99,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnIndexFromNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0be0365d-331a-41e9-b6dd-c03ae76f5d4a"),
				Name = "GetColumnIndexFromName",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "int?"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("66f517bb-ff45-4338-bd56-c22a9f03b0c0"),
				Name = "columnName",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,77,111,218,64,16,61,123,127,197,132,67,180,142,131,85,115,200,33,142,137,40,165,45,45,133,54,164,73,155,40,7,151,174,193,146,89,194,122,93,5,69,254,239,153,89,27,127,52,244,214,21,18,154,221,55,111,222,188,25,167,90,197,114,9,137,208,90,168,20,2,232,12,222,14,223,141,222,127,248,56,254,244,121,242,101,58,251,250,237,106,126,253,253,230,246,199,207,187,142,207,226,136,47,54,73,182,150,211,112,45,220,137,144,75,189,130,62,120,54,60,51,43,150,26,240,117,44,127,139,39,100,122,227,51,43,218,40,78,215,91,19,227,223,69,0,175,9,186,224,225,155,227,24,22,235,79,168,128,148,52,112,243,236,87,106,132,242,237,169,103,35,175,169,21,83,161,145,212,106,135,232,178,3,215,84,159,69,60,45,96,17,28,16,140,245,224,40,128,45,214,179,44,11,97,86,37,219,9,128,55,120,29,108,237,164,119,70,84,57,136,36,21,70,97,11,94,163,13,138,209,79,9,157,41,89,153,225,179,156,49,84,124,89,246,180,119,72,102,73,226,51,86,180,118,255,64,175,147,106,16,87,98,41,158,220,249,99,18,235,70,11,167,208,225,247,131,238,221,131,99,119,176,195,86,70,29,184,183,43,161,4,199,203,62,28,21,244,238,56,157,98,185,153,26,173,31,245,14,237,177,221,235,205,64,169,112,199,145,135,149,70,237,243,135,155,76,106,110,211,184,122,54,123,102,128,167,178,188,152,45,93,225,120,69,184,88,1,47,106,144,2,132,52,132,216,6,86,228,211,153,196,169,190,88,172,66,213,39,144,215,22,61,74,196,90,72,61,208,197,4,72,224,16,161,165,72,140,40,155,212,238,217,140,165,6,123,19,38,153,56,176,5,84,228,21,47,245,91,81,68,229,188,11,6,220,138,174,103,87,175,181,240,22,22,2,116,0,142,143,225,128,99,129,113,172,153,214,38,161,211,222,130,86,84,44,5,92,182,84,209,22,194,9,244,206,224,188,133,118,128,31,132,53,44,162,147,183,34,218,226,255,160,175,81,247,111,81,245,211,191,116,228,141,1,16,216,113,10,100,78,31,74,253,241,236,57,253,23,30,251,157,37,166,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLookupFieldValuesAndCountsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ce3f2fe-147b-465d-898a-c1aca35e0d25"),
				Name = "GetLookupFieldValuesAndCounts",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "List<Tuple<Guid, string, string, string, string, KeyValuePair<Guid, string>, Dictionary<int, Collection<int>>>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e8698fcc-a4b3-4626-9a66-44c6505a9495"),
				Name = "sheetData",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "OpenXmlSpreadsheet.SheetData",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("288bccda-ab70-495c-9654-93f9bbed4c65"),
				Name = "stringTablePart",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SharedStringTablePart",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6913fd96-69ca-49b6-88f3-21a7f1c04801"),
				Name = "captions",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,89,219,110,219,56,16,125,118,129,254,3,235,135,66,218,8,130,219,135,93,160,78,83,116,93,167,48,54,205,102,155,116,247,193,205,131,106,209,137,26,89,82,41,42,169,17,248,223,119,120,17,69,82,148,42,247,26,4,190,80,195,51,135,195,153,163,161,124,27,17,148,230,249,77,85,28,39,56,141,255,141,210,10,151,47,179,120,150,87,25,45,209,115,148,225,59,116,146,148,244,240,162,42,82,124,248,186,74,226,0,149,148,36,217,85,231,251,195,7,163,209,95,120,203,193,206,162,132,24,179,142,2,244,42,89,209,36,207,34,178,61,76,50,26,160,89,158,166,152,15,177,239,71,240,231,249,211,135,15,110,21,55,48,168,54,89,185,200,98,252,153,211,59,141,54,152,177,59,233,187,28,149,45,79,146,2,128,159,228,87,139,108,157,123,98,36,60,206,201,38,162,222,248,61,189,159,236,224,229,9,188,188,167,111,48,189,206,227,242,25,122,141,233,73,119,148,60,193,18,173,4,15,120,135,97,116,255,116,231,143,3,116,156,164,152,241,9,208,252,243,10,167,139,77,145,19,186,136,89,144,188,254,213,65,240,171,52,69,47,208,228,89,111,28,66,78,195,247,235,152,145,252,142,197,134,57,126,21,209,136,197,65,172,114,121,185,188,148,54,171,107,188,186,57,197,119,98,85,204,236,44,186,194,167,213,230,3,38,48,119,34,205,110,249,74,245,52,144,17,228,27,148,172,145,199,157,61,18,84,125,116,15,171,98,243,112,70,19,186,61,7,47,155,232,77,148,1,52,67,125,87,98,50,203,179,76,236,117,56,111,27,77,235,249,44,84,245,2,22,153,96,89,234,19,0,206,225,36,132,141,90,100,37,141,178,21,254,115,203,162,227,141,231,78,172,49,91,192,72,172,102,128,59,6,197,92,126,209,48,100,150,245,50,202,109,41,76,190,142,249,121,61,221,32,235,4,149,252,156,215,20,165,122,181,214,60,118,201,32,168,27,176,139,172,124,141,193,119,139,184,3,239,140,36,27,168,182,87,73,89,164,209,86,228,107,237,3,42,16,37,245,135,2,22,253,22,175,114,18,151,60,125,129,252,147,201,100,82,95,134,180,18,201,120,78,35,66,101,70,154,87,230,89,12,227,54,14,51,91,231,4,71,171,107,228,25,34,164,11,64,111,61,49,107,148,100,189,54,34,213,71,9,48,248,18,84,8,44,24,171,209,221,53,36,14,175,152,102,1,135,188,90,195,19,156,93,209,107,9,58,106,45,190,183,90,127,115,198,64,67,17,129,178,64,15,58,102,201,154,110,102,30,185,24,58,192,107,19,1,179,227,175,176,17,200,99,133,240,177,69,96,10,99,135,198,102,194,200,193,129,114,32,133,108,158,226,13,230,217,193,92,44,63,94,46,147,75,225,129,51,125,36,4,10,20,48,163,81,146,149,94,51,197,71,143,31,163,71,82,222,23,229,41,232,211,223,100,190,41,232,86,55,82,254,70,18,233,101,28,235,215,165,175,157,182,40,230,87,185,229,153,11,217,169,112,250,182,234,224,64,194,173,128,110,146,85,88,143,149,93,149,67,50,139,39,247,180,53,125,176,194,216,62,253,54,22,148,186,5,23,202,234,31,181,148,254,159,10,147,173,188,89,204,237,113,207,65,41,104,105,145,131,65,151,164,216,180,92,118,74,250,4,217,36,22,195,214,84,206,143,237,188,184,234,13,241,238,32,42,96,224,238,64,49,17,137,212,190,58,3,101,162,88,216,252,151,208,235,179,136,0,24,155,224,137,193,89,190,41,34,146,148,121,118,177,45,112,56,255,84,69,105,128,68,218,12,225,21,200,123,118,120,145,191,36,36,218,122,162,47,48,118,171,233,183,156,129,128,60,153,91,118,158,121,235,150,136,74,103,27,104,166,155,182,19,163,166,11,7,111,158,198,138,10,243,207,214,30,107,23,85,219,177,199,214,152,133,42,245,161,211,125,91,9,222,226,77,126,139,123,102,12,209,134,35,77,26,216,242,179,156,30,195,133,120,65,241,166,238,171,242,15,31,33,80,75,125,94,173,113,173,41,172,7,235,106,199,70,186,226,222,240,123,38,188,29,154,0,181,74,163,27,77,108,185,159,85,69,8,132,183,222,12,65,103,121,83,83,25,25,48,48,206,238,75,218,20,167,25,227,200,43,65,183,52,3,215,46,161,61,21,100,80,239,230,107,1,21,178,202,169,116,170,137,45,9,227,147,102,210,216,215,100,133,35,174,193,253,158,120,199,245,20,19,237,39,233,137,230,62,48,243,163,86,139,159,198,68,4,150,133,96,236,184,29,152,108,190,151,112,233,117,69,249,178,27,19,153,125,218,201,209,60,221,54,181,198,138,221,230,229,40,251,189,101,114,84,55,214,86,90,237,33,147,142,132,172,89,43,244,86,25,236,129,239,44,161,198,3,111,205,58,226,171,180,24,218,98,155,167,173,196,74,77,90,32,44,7,93,147,131,142,101,53,220,164,234,168,119,174,152,236,96,177,118,244,168,235,86,143,186,214,101,211,165,155,188,79,93,107,125,170,8,199,144,104,24,34,169,71,161,193,100,217,233,70,90,234,179,47,187,150,187,107,242,223,121,86,252,10,1,238,60,143,26,197,6,223,85,239,213,237,89,87,72,46,9,53,70,207,20,93,150,122,204,122,244,73,134,168,87,166,224,44,174,99,66,15,108,201,21,140,248,250,138,187,169,216,26,213,31,145,253,68,45,85,106,202,80,197,225,135,31,122,52,205,26,206,204,165,102,154,136,245,241,182,161,150,19,149,147,6,199,1,98,211,228,78,168,167,213,78,91,145,235,148,215,184,209,106,201,225,91,30,31,102,81,193,120,78,91,117,178,18,23,88,187,35,62,149,77,109,171,118,171,112,136,71,209,18,143,194,238,185,110,117,209,40,116,209,208,37,84,235,165,84,35,123,107,139,132,121,166,108,10,159,1,117,63,225,117,237,176,56,42,149,103,4,151,226,232,189,142,210,82,225,154,183,179,4,152,53,207,74,92,30,116,29,99,92,216,140,144,45,232,41,59,56,139,0,192,73,93,13,255,30,74,37,125,222,238,6,52,40,65,82,156,137,129,162,154,254,199,180,49,225,238,132,137,161,179,133,33,174,96,39,108,96,3,184,136,36,190,134,177,67,24,22,239,50,231,182,69,192,165,210,122,130,237,249,247,201,206,64,105,62,246,236,5,3,212,252,48,224,61,158,186,163,111,122,228,174,59,230,15,252,194,83,124,199,222,61,95,30,41,3,67,79,130,186,26,2,77,115,2,29,132,243,239,230,132,60,75,61,29,221,95,80,239,176,175,7,83,79,77,74,154,140,239,15,174,60,206,177,68,209,193,62,64,50,223,52,223,213,70,169,15,188,16,149,75,61,113,204,12,180,154,70,103,148,145,167,185,222,63,141,6,167,206,47,203,156,239,146,56,63,38,111,84,35,100,21,244,183,237,226,222,155,56,116,15,127,213,22,126,143,29,252,33,27,104,52,176,226,117,192,179,86,110,56,224,199,46,199,67,119,107,184,251,231,134,250,129,209,44,197,17,17,185,1,110,225,159,96,90,145,108,232,237,247,69,223,15,177,207,248,15,108,211,255,1,109,168,88,63,175,29,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1e9c356a-213e-4cc6-8fda-9bfed6083463"),
				Name = "CreateItem",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4e5c5422-559c-4b56-b1cd-f39031b0f0a5"),
				Name = "row",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,89,201,110,219,70,24,62,43,64,222,97,194,67,76,34,50,237,4,109,131,70,142,3,91,146,83,5,94,82,47,237,193,241,129,38,71,54,81,138,84,200,161,109,181,49,208,56,69,47,5,90,160,79,146,22,13,224,54,72,243,10,212,27,245,159,141,28,46,146,233,84,176,15,22,57,252,231,223,151,143,195,19,43,68,190,53,192,232,49,234,69,207,67,119,96,133,163,142,27,13,61,107,212,14,188,120,224,119,207,220,136,68,232,9,10,131,211,253,77,160,228,203,61,223,193,103,7,232,17,138,72,232,250,71,102,119,48,36,163,214,237,91,39,192,207,29,12,131,144,96,167,71,240,32,162,140,115,247,86,132,214,129,229,18,223,184,44,246,28,99,203,193,33,229,79,119,124,165,220,85,211,251,193,233,115,43,4,2,130,67,216,224,227,83,244,117,140,195,81,186,168,107,64,162,53,81,199,34,120,215,29,96,115,143,216,155,193,105,19,105,114,69,51,4,47,59,14,67,236,147,189,8,135,237,192,39,150,77,122,206,85,204,149,61,61,7,196,136,205,62,182,137,27,248,102,59,123,108,166,60,165,60,7,20,96,254,99,182,82,238,204,64,215,39,203,186,164,113,163,53,76,236,99,236,0,69,223,242,34,44,214,45,207,235,57,192,217,237,187,182,69,69,177,112,68,43,33,112,92,115,61,26,71,18,198,148,154,211,83,82,50,218,1,78,3,107,195,242,173,35,102,81,65,219,110,153,168,85,222,14,251,42,184,153,79,49,233,249,17,177,124,27,175,142,104,200,116,254,156,94,26,45,36,204,129,208,115,41,5,46,102,59,196,224,14,254,76,207,235,101,84,40,193,226,32,188,214,45,174,235,21,250,53,243,226,184,86,69,165,122,14,207,234,130,114,140,169,185,226,136,167,57,246,212,110,81,47,252,41,51,221,160,188,23,22,218,219,104,255,254,195,197,135,159,127,121,128,58,91,183,111,185,125,164,223,17,149,210,139,54,99,207,219,10,89,197,232,59,216,3,99,161,54,202,65,245,35,195,64,63,220,190,213,96,186,138,231,88,232,66,51,231,89,4,177,235,96,240,153,107,121,238,247,248,10,102,180,146,158,173,132,161,69,235,180,209,15,192,241,246,177,206,10,128,27,239,250,101,49,92,131,74,21,54,121,219,200,57,101,205,245,29,126,201,105,86,71,27,152,88,207,45,114,172,115,33,251,218,64,44,104,7,230,110,176,195,124,2,110,99,129,161,122,53,164,56,232,55,172,72,64,132,210,28,76,182,182,213,215,171,180,49,24,3,234,236,116,243,18,90,4,19,208,194,66,242,251,248,117,242,14,37,239,147,75,148,252,57,254,37,249,99,252,99,242,54,249,144,124,128,107,88,255,152,252,155,188,31,255,134,146,191,248,207,37,92,188,131,135,23,201,229,248,39,184,251,39,121,59,254,25,126,97,247,71,216,121,57,126,61,126,51,190,128,255,23,192,237,205,248,215,241,5,176,69,64,250,54,249,27,132,188,123,66,85,105,212,40,87,89,221,64,109,67,167,112,253,152,223,157,75,71,224,51,27,123,220,200,111,44,47,166,123,104,47,150,38,30,180,202,1,98,137,91,43,165,167,187,49,171,16,83,150,43,79,11,22,104,81,238,149,44,32,205,215,131,224,187,120,184,59,26,98,145,68,141,201,101,80,180,209,144,91,152,97,192,219,115,186,147,91,81,125,173,182,113,31,67,99,182,49,223,72,219,147,20,18,197,135,165,134,114,189,70,83,82,211,204,188,41,35,148,6,165,74,156,18,151,50,175,201,253,134,114,175,100,7,25,6,195,42,162,108,245,74,2,222,124,57,217,183,46,57,78,7,92,164,243,197,118,48,24,90,161,11,141,134,198,209,236,190,140,45,175,202,208,42,228,192,172,111,150,210,215,80,29,146,106,5,4,30,239,250,147,124,3,246,23,73,43,230,69,67,164,89,5,99,200,146,216,39,104,153,117,4,78,217,40,151,134,234,51,65,84,65,53,197,113,114,83,99,154,7,83,162,202,154,21,158,75,137,42,140,217,95,60,160,30,161,60,29,197,185,75,79,99,215,89,214,101,158,241,4,148,124,228,133,244,211,57,194,208,122,106,250,98,146,15,120,29,115,74,125,178,53,105,212,89,91,43,136,190,17,201,76,112,78,110,157,224,127,74,232,107,4,190,70,216,139,117,195,151,121,12,141,116,66,156,11,124,128,203,85,84,86,189,102,9,209,250,41,242,43,21,15,37,186,106,186,165,125,95,1,179,202,72,97,139,107,97,48,232,172,150,228,93,145,223,37,228,166,134,90,248,69,137,245,194,194,252,60,197,97,76,235,105,239,57,10,220,25,86,16,85,65,158,137,173,47,157,203,126,250,214,116,197,48,158,36,146,155,245,105,85,114,237,230,158,105,43,242,209,207,60,59,211,76,227,80,175,86,178,221,120,6,33,145,66,244,53,138,161,150,84,1,174,145,10,140,48,233,224,190,34,33,210,121,21,229,72,148,231,186,198,222,24,169,30,230,38,62,165,191,124,142,51,105,128,203,1,119,129,245,174,0,191,139,45,113,185,68,97,31,119,141,88,186,119,143,107,195,33,149,128,241,34,71,21,204,188,239,166,56,49,71,169,162,201,140,68,190,25,165,25,91,11,4,218,249,100,149,224,81,50,1,28,5,189,26,189,122,5,229,199,78,3,54,2,7,211,229,7,232,238,93,84,9,9,109,21,50,136,60,80,1,242,121,73,76,21,230,156,12,57,115,252,69,154,125,42,216,84,172,159,0,49,255,231,59,236,84,104,89,64,150,211,58,204,53,97,229,13,181,156,107,225,201,92,220,50,7,204,114,0,214,237,74,83,106,252,26,25,211,44,233,126,29,112,55,17,221,204,72,55,90,183,202,88,85,36,100,62,170,87,24,76,56,181,137,214,61,129,223,160,175,239,140,34,80,211,148,71,114,105,33,42,71,100,44,213,88,123,82,98,83,191,164,27,78,16,31,194,139,54,113,197,68,110,52,164,52,118,16,167,188,51,116,24,165,185,203,14,250,34,172,178,131,170,134,68,180,177,62,103,206,53,209,92,115,14,60,19,196,132,113,205,68,77,241,121,230,8,229,72,146,78,174,173,21,122,171,115,70,121,96,206,116,146,180,85,90,113,29,168,21,215,214,129,109,202,67,114,37,131,102,17,218,14,182,161,134,189,84,51,113,143,28,254,203,182,112,5,218,177,71,98,138,25,251,129,60,139,21,75,229,163,202,220,193,42,39,226,76,228,100,227,107,59,67,144,2,168,84,142,184,109,124,132,207,210,32,230,92,168,237,55,205,3,152,199,121,201,230,102,60,56,196,225,90,16,14,44,34,110,132,5,59,24,90,152,69,130,80,201,71,241,72,137,82,133,30,34,92,138,253,70,141,78,146,139,154,186,183,92,248,179,8,219,97,16,120,6,29,202,245,75,172,158,238,234,206,214,140,149,230,170,206,80,161,25,219,174,52,209,122,45,122,186,158,42,56,85,88,88,39,152,65,79,126,186,13,192,47,2,240,176,139,207,8,5,113,41,128,126,130,246,134,172,189,194,206,245,192,166,39,199,22,180,61,126,18,155,30,57,60,66,208,118,43,73,228,71,19,107,72,11,146,158,67,183,229,101,245,167,154,19,6,138,5,222,225,60,86,99,215,3,116,170,43,58,242,67,121,74,105,174,12,135,216,119,116,13,105,220,154,12,18,11,56,92,128,194,18,6,231,183,75,5,247,221,3,163,85,122,170,1,171,23,154,150,130,213,59,234,196,97,95,108,92,63,210,93,35,125,33,84,55,51,192,204,185,22,7,98,117,213,136,13,233,116,43,142,164,170,233,195,247,228,6,207,164,185,147,215,110,226,120,97,99,54,59,116,215,28,199,220,216,48,71,240,167,165,48,34,119,46,147,231,171,126,233,155,136,58,174,218,34,207,44,24,114,71,119,30,103,129,68,243,247,43,157,173,189,208,90,60,19,114,146,74,68,166,160,81,223,218,122,209,150,239,141,186,97,24,132,17,125,227,48,196,105,64,123,123,99,254,139,7,159,45,138,215,29,145,134,144,18,130,107,246,97,66,230,71,141,67,3,102,146,250,169,51,203,35,254,10,45,92,36,165,221,123,140,54,3,178,231,187,47,99,188,141,237,32,116,42,58,68,142,31,69,66,126,134,251,123,133,239,172,57,226,156,183,215,131,163,46,61,78,226,59,224,78,86,158,120,237,12,49,12,43,159,127,57,252,15,107,28,215,250,18,30,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetWorksheetPartByNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e6fc3c5e-f509-4255-87f2-0ff19e48cd9b"),
				Name = "GetWorksheetPartByName",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "WorksheetPart"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("167f82e4-b2c6-4e4b-8422-dec5c28750c3"),
				Name = "workbookPart",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "WorkbookPart",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e895fcbd-b273-4985-8aae-09449722a9f1"),
				Name = "sheetName",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,207,107,194,48,20,62,183,208,255,33,120,74,65,130,59,187,246,48,105,37,48,182,129,48,119,240,18,237,211,6,211,164,36,41,219,144,254,239,75,82,167,22,241,242,200,151,247,190,31,143,247,170,14,84,238,21,54,86,115,121,32,165,210,13,179,120,178,177,167,89,239,202,147,43,27,187,4,139,190,149,62,154,26,220,171,101,218,78,166,168,228,2,222,88,3,83,84,252,236,64,208,166,85,218,210,42,77,231,73,76,11,217,53,160,217,86,192,243,123,11,242,171,17,171,86,3,171,130,2,89,249,154,163,0,12,202,130,246,86,169,227,135,83,38,235,51,32,206,181,228,218,216,69,205,69,245,80,198,228,56,37,73,28,21,2,26,144,214,60,246,115,115,235,26,52,96,103,233,204,137,15,143,178,108,136,225,129,79,158,196,124,143,240,144,140,44,84,39,45,78,253,208,44,69,39,231,226,155,119,105,195,180,71,87,70,254,79,136,52,216,78,203,251,21,111,72,97,75,236,221,163,30,129,48,48,98,202,78,136,208,74,226,222,231,27,46,133,52,8,102,185,146,166,230,45,173,208,121,141,139,24,161,21,249,100,162,3,71,29,217,93,15,25,80,134,240,168,157,142,130,46,135,207,151,95,90,225,177,161,79,123,179,218,133,63,255,3,143,133,97,99,81,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillSchemaParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0feebd7b-2bbe-4fa5-93be-8060b2bc7d95"),
				Name = "FillSchemaParameters",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a6d0fc6c-6a1b-4749-9084-64ec5d7e073d"),
				Name = "IsId",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,203,78,195,48,16,60,7,137,127,48,61,37,82,229,114,135,86,130,80,170,30,120,41,20,14,136,131,169,151,98,112,236,224,56,148,8,241,239,216,113,94,4,40,21,18,149,122,138,103,118,103,119,103,183,209,252,1,98,114,74,98,64,67,148,106,197,196,2,143,227,68,231,123,219,91,236,30,249,81,241,62,165,104,103,136,38,25,163,238,49,64,111,219,91,222,96,240,66,20,2,161,153,206,29,238,34,3,149,155,64,2,150,104,220,253,238,207,82,80,161,20,2,230,154,73,129,219,128,19,34,200,2,84,31,245,174,150,81,158,150,89,69,36,121,102,177,189,192,200,241,254,59,219,181,84,79,105,66,230,208,164,99,212,196,255,146,19,31,80,26,26,105,177,240,123,83,218,11,176,237,95,69,153,147,196,38,252,141,23,58,88,135,44,220,32,86,50,45,190,162,121,134,103,199,52,77,167,212,13,197,76,101,37,187,174,215,21,233,173,4,207,108,117,63,192,142,25,215,160,82,11,247,191,190,134,10,136,6,135,185,102,250,225,156,40,163,215,18,124,247,49,148,113,66,20,75,165,184,204,19,192,227,231,140,112,51,16,147,176,143,42,211,5,69,238,119,4,60,133,159,139,251,31,33,77,159,186,122,188,77,246,195,200,104,108,217,71,29,83,215,79,184,22,183,41,97,179,239,38,85,173,128,228,220,41,252,214,203,19,208,110,27,195,26,215,217,214,34,154,245,117,19,9,135,50,19,26,141,208,110,233,243,142,237,141,53,234,91,53,108,41,184,217,189,181,9,173,246,210,214,87,132,103,176,111,143,217,168,181,14,181,211,189,191,132,105,22,197,246,192,59,55,231,5,159,221,61,26,238,152,50,141,35,208,5,252,64,208,75,120,213,254,186,113,25,13,250,107,136,112,119,123,228,151,167,167,116,66,212,62,237,235,7,177,39,168,154,166,249,21,165,28,201,165,224,146,24,241,113,194,141,93,14,51,173,139,155,74,238,56,216,70,249,173,100,59,159,255,72,130,189,15,95,191,181,3,100,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a56af1a9-3fde-4bff-94de-bc4f170704cd"),
				Name = "ShowColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("48e2668b-e607-482e-b68f-867732fb9435"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,93,111,218,48,20,125,166,18,255,193,205,67,229,168,200,218,59,101,82,75,105,69,69,25,82,186,237,97,154,38,47,185,80,75,137,141,108,167,140,77,252,247,250,11,104,128,16,216,75,172,216,247,158,123,238,61,215,31,35,49,27,242,169,192,81,242,42,22,125,145,151,5,79,180,44,83,93,74,24,252,153,231,66,130,252,149,104,42,117,20,119,219,23,108,138,240,101,141,89,95,2,213,144,197,232,95,251,162,229,127,106,44,177,133,90,181,47,222,168,68,106,103,13,245,16,222,115,136,81,13,82,160,180,15,210,67,188,204,115,207,69,130,89,227,219,144,192,53,211,203,36,125,133,130,62,83,78,103,46,234,196,140,196,79,146,202,218,68,138,55,150,129,36,143,160,195,20,142,6,251,24,81,140,168,66,47,32,37,85,98,170,73,223,48,33,206,142,129,34,7,28,186,161,2,110,206,48,56,192,203,198,28,114,165,41,79,225,110,249,117,152,225,143,70,230,223,86,114,55,123,18,156,199,180,128,26,88,187,100,60,131,160,74,75,198,103,100,168,198,166,102,95,228,160,152,235,37,78,32,135,212,232,57,204,44,192,148,165,84,51,193,189,14,42,246,149,181,244,51,170,105,34,74,153,194,70,29,111,100,190,22,193,56,25,18,28,22,232,190,217,210,117,134,131,45,104,42,133,26,49,165,141,247,147,18,156,220,131,2,201,104,206,254,66,3,57,171,195,211,173,209,97,105,209,166,66,34,204,184,70,204,32,125,234,154,225,230,3,186,145,169,228,218,204,94,95,251,156,142,39,213,148,138,79,160,85,235,79,140,102,6,227,177,100,25,25,195,194,142,141,46,207,160,233,132,234,87,227,183,229,253,131,253,36,223,104,94,194,141,87,239,51,142,138,96,23,53,1,134,198,8,157,103,123,204,119,135,95,182,16,119,203,117,80,220,204,171,41,92,159,206,67,23,28,165,159,122,179,70,246,235,176,39,194,22,85,243,70,120,43,173,131,120,89,206,109,149,66,145,30,24,207,62,86,233,188,10,85,81,45,3,75,162,126,243,29,205,136,206,102,18,102,174,227,45,90,20,199,22,172,117,117,133,2,86,95,20,115,42,225,76,148,14,138,198,130,67,212,65,38,11,136,209,165,217,45,97,75,56,182,71,106,118,91,197,178,103,248,206,84,60,224,101,65,38,84,42,192,218,252,139,233,158,69,199,5,105,157,153,186,83,211,85,242,12,122,61,180,51,229,79,129,117,182,173,138,90,235,43,34,59,52,217,171,63,42,170,154,147,67,152,158,252,25,205,120,136,67,245,142,176,123,27,71,67,174,193,93,73,62,194,170,181,85,241,63,155,78,149,191,31,88,174,65,42,83,244,77,161,234,153,39,27,123,123,210,156,12,29,248,218,239,234,232,62,221,222,25,228,54,203,234,197,119,136,22,106,239,150,12,183,197,49,9,183,65,252,235,97,116,202,107,105,47,144,53,30,100,76,127,55,71,136,88,68,7,175,236,170,13,246,135,78,199,63,98,186,39,6,30,240,204,129,135,247,206,59,63,227,226,253,219,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("26d44b30-fecd-425d-9a77-3066e8ce8dac"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,111,211,64,16,61,55,82,254,195,226,147,45,170,21,92,169,56,148,224,10,75,20,162,184,192,129,246,176,245,142,19,163,245,174,53,59,110,18,69,249,239,204,198,169,211,98,151,94,246,195,122,243,222,155,55,235,175,110,153,217,210,197,158,176,178,75,121,229,176,86,20,71,183,180,123,183,231,229,61,47,183,116,13,180,114,218,127,16,51,4,69,48,115,166,173,109,78,216,22,212,34,164,155,198,56,4,140,206,197,85,101,224,155,170,225,92,164,155,2,76,86,55,14,41,211,73,114,49,157,60,40,20,141,66,85,139,143,194,194,90,220,0,162,242,174,36,249,35,147,191,224,126,230,44,161,51,94,246,135,121,64,3,1,198,81,69,80,251,96,148,69,158,93,122,204,181,211,32,23,106,253,40,229,255,181,119,148,29,216,142,231,106,9,178,235,201,167,186,34,86,40,186,27,243,51,154,187,41,149,241,188,29,67,74,235,134,182,65,103,160,33,185,109,211,106,248,172,72,253,84,166,133,155,109,3,254,168,220,85,255,190,19,59,17,125,170,172,194,109,104,38,68,22,246,172,102,27,225,192,78,28,70,98,63,202,159,249,124,229,214,249,214,115,4,71,203,204,30,76,254,7,254,189,105,156,231,208,22,80,2,130,45,224,84,50,157,204,28,15,201,130,165,203,63,106,147,62,240,65,0,135,16,62,27,206,149,161,67,218,30,234,101,250,4,203,124,79,75,101,199,246,182,235,190,175,249,162,172,54,28,123,14,225,93,169,185,162,85,152,101,50,168,222,16,170,126,188,94,94,106,29,31,222,207,120,242,167,52,130,90,24,64,238,90,44,160,159,119,7,224,213,64,65,149,179,113,114,232,191,42,69,252,230,133,23,189,128,101,197,73,35,232,68,236,166,147,179,161,234,35,226,64,118,246,42,205,41,248,125,72,126,20,221,253,99,250,249,140,70,145,99,179,185,248,11,205,154,119,246,209,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetMetaPathInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27a0e8a0-f0ed-4d51-8ca8-82698298f0a1"),
				Name = "SetMetaPathInfo",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7b2524ef-b7bb-4b82-9e41-57d70f1eefaf"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c3b3eeb5-059b-49b4-a018-454f8ca0b113"),
				Name = "e",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,203,110,194,48,20,68,215,245,87,184,94,37,2,249,3,106,161,210,7,11,88,161,194,46,202,226,202,185,161,150,28,27,93,59,148,182,234,191,215,14,105,43,36,68,247,115,206,204,28,128,184,246,182,239,28,159,241,85,240,78,62,99,64,50,96,205,7,22,40,23,199,72,176,6,130,14,35,82,168,132,137,216,133,165,107,189,168,75,14,129,175,30,136,224,93,177,67,18,117,160,201,7,12,73,117,157,188,157,137,170,22,252,158,59,124,227,155,72,198,237,30,123,99,27,164,127,43,239,46,48,165,98,108,131,22,117,196,102,217,160,139,166,53,26,162,241,238,105,184,150,7,253,108,147,91,127,130,51,149,71,19,134,222,198,75,239,175,42,207,206,135,193,56,170,146,62,217,196,92,40,214,122,66,208,175,69,238,9,163,237,196,115,227,198,120,201,63,217,205,31,57,73,232,148,139,201,121,188,18,26,246,185,93,212,138,125,177,53,236,80,142,67,22,141,137,114,139,199,124,225,87,35,95,112,111,65,99,33,230,211,193,39,210,91,194,216,147,83,223,54,74,136,204,243,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCalculateWidthMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("db433d06-a205-4814-988a-4c2919c76876"),
				Name = "CalculateWidth",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "double"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fce594e9-49df-4cb4-b0b5-256f3c38e98d"),
				Name = "ColumnText",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,112,206,207,41,205,205,11,73,173,40,81,176,181,85,200,43,205,201,209,84,40,74,45,41,45,202,83,176,208,51,49,182,230,74,201,47,77,202,73,85,128,168,11,207,76,41,201,80,176,85,64,232,210,243,73,205,75,7,138,105,41,24,234,25,26,25,90,154,153,24,41,104,3,217,166,214,92,153,48,211,33,186,108,192,6,106,162,153,4,177,4,106,35,146,148,53,0,248,78,165,34,156,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("03d70c01-91e2-483f-a41a-1ab6380ad99f"),
				Name = "CreateColumnData",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "OpenXmlSpreadsheet.Column"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3bb7115c-35f8-4af6-86bd-a875ae1bedd7"),
				Name = "ColumnIndex",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UInt32",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("67f7b73d-1f1d-4454-b10f-6f52f9682201"),
				Name = "ColumnWidth",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "double",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,205,139,200,205,9,46,40,74,77,76,41,206,72,77,45,209,115,206,207,41,205,205,83,72,6,83,214,92,16,90,193,86,33,47,181,92,193,31,151,114,13,77,152,74,61,223,76,144,106,136,176,103,94,74,106,5,66,38,177,2,40,131,80,6,151,8,207,76,41,201,128,107,2,243,224,114,206,165,197,37,249,185,48,21,37,69,165,169,214,92,69,169,37,165,69,112,39,2,0,132,39,3,205,196,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateStyleSheetMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46b43558-3ec2-4444-b2b4-c2afde4140db"),
				Name = "CreateStyleSheet",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "OpenXmlSpreadsheet.Stylesheet"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,91,109,115,218,56,16,254,156,206,244,63,104,232,23,211,82,27,147,151,187,164,147,153,11,208,116,50,211,230,58,9,189,187,175,198,22,160,137,108,113,182,220,134,99,248,239,183,146,108,44,108,176,129,134,64,59,205,76,28,75,126,86,187,251,236,106,45,203,78,28,145,96,136,140,79,216,103,225,228,158,135,216,241,81,164,254,92,162,0,127,67,250,21,163,94,71,211,151,47,142,98,33,100,220,143,161,207,139,70,24,243,46,115,99,31,7,28,69,75,250,46,209,18,164,217,129,46,142,13,165,171,177,12,210,155,140,177,249,55,11,31,250,140,61,40,205,160,251,232,207,49,14,254,241,169,38,96,222,243,9,197,242,20,108,159,159,42,251,75,225,6,140,138,62,117,174,56,15,73,63,230,56,74,157,118,194,135,120,220,97,254,216,225,164,79,40,225,147,12,35,133,110,134,1,11,157,62,197,32,81,123,180,79,28,183,134,102,104,246,78,88,152,217,96,94,121,222,173,227,227,104,236,184,184,139,93,234,132,48,32,11,140,154,239,214,26,168,54,226,124,124,97,89,145,59,194,190,19,153,12,108,125,244,233,128,133,190,195,161,25,14,45,95,90,242,214,213,77,177,90,205,230,89,173,190,182,46,101,94,81,157,79,220,144,69,108,192,77,24,222,98,131,1,113,177,165,69,208,167,66,211,185,117,110,129,184,82,39,126,191,58,33,26,176,128,71,171,25,190,22,151,13,37,98,89,162,133,110,2,15,63,162,166,62,64,185,124,34,158,130,133,107,229,2,18,49,253,203,161,34,227,32,88,193,16,206,99,108,94,135,204,87,109,163,214,113,40,233,135,164,86,159,45,12,126,79,254,171,24,92,34,146,193,187,44,134,192,103,131,171,182,97,219,201,168,98,196,204,162,203,185,249,139,23,19,157,169,250,119,138,92,73,172,121,53,6,43,60,67,52,150,144,104,103,208,181,40,220,25,125,79,75,221,209,81,230,215,230,244,205,47,182,25,245,86,27,36,174,106,180,44,161,186,72,55,122,139,66,236,73,85,191,120,95,198,187,101,221,79,34,142,125,179,27,58,223,192,96,179,195,40,83,51,75,157,129,103,75,0,210,18,161,193,168,221,97,175,150,102,186,152,148,192,119,42,41,60,76,111,9,215,178,50,154,137,195,166,238,177,132,203,210,124,55,236,131,88,36,169,51,149,132,81,155,54,47,30,91,179,169,45,143,45,121,60,22,71,40,139,115,51,205,43,189,113,167,55,62,232,141,118,221,236,177,47,144,55,66,95,86,72,224,126,16,12,241,179,153,221,58,61,133,195,241,121,3,217,173,19,56,156,105,86,105,117,40,181,71,179,238,105,231,138,186,212,97,177,156,21,95,110,2,126,220,202,18,77,181,13,35,38,32,147,64,71,132,122,239,41,22,204,36,130,73,232,95,15,8,165,209,107,107,94,154,69,179,36,201,197,101,253,54,1,237,114,180,6,134,219,41,199,97,112,93,42,243,89,3,77,147,134,88,150,128,196,106,180,116,62,50,111,89,128,147,56,128,248,194,80,151,186,246,57,36,227,23,26,245,121,247,90,30,237,220,155,15,161,51,177,91,167,223,235,80,82,92,133,12,145,197,21,181,118,236,167,144,58,218,208,217,123,70,137,215,64,82,20,102,34,30,134,144,164,11,5,105,105,201,93,0,26,117,33,62,203,91,157,135,193,120,61,152,153,17,133,197,112,118,201,88,90,46,59,48,135,105,129,7,179,237,184,15,107,89,152,7,78,85,201,41,177,206,4,196,83,132,92,93,90,175,70,40,232,234,26,209,103,161,135,67,173,74,36,29,101,117,76,2,180,201,175,68,170,36,146,228,249,136,7,188,93,33,144,97,140,122,67,74,221,145,225,168,82,76,3,165,114,61,54,174,146,154,67,82,153,54,227,156,249,85,98,58,42,149,236,18,103,200,2,135,86,201,46,226,244,220,78,216,79,227,174,154,233,173,252,10,18,165,205,28,57,118,178,152,202,100,118,66,63,154,202,167,187,229,179,92,65,36,32,153,233,189,17,9,102,13,100,89,230,39,236,145,216,71,178,71,30,221,135,173,226,184,149,1,27,71,126,123,45,155,231,202,246,186,118,156,93,192,6,114,2,15,41,99,115,137,214,218,113,162,109,59,207,209,54,19,29,150,135,27,199,0,125,71,192,183,215,182,227,144,11,254,27,72,210,41,67,47,82,96,49,238,199,59,47,48,219,147,179,121,45,217,94,215,225,166,215,51,221,123,242,169,178,180,74,156,252,68,217,242,92,201,178,253,170,227,192,11,139,76,19,149,48,139,89,114,250,19,101,201,179,213,20,72,19,180,109,158,60,75,137,200,22,17,139,209,62,219,117,180,127,226,165,195,51,4,78,191,184,214,19,229,28,188,242,153,210,122,251,54,125,50,116,49,165,146,14,181,3,87,242,84,217,201,33,181,199,75,49,136,234,45,23,79,48,42,137,110,99,191,143,67,213,117,35,118,229,154,13,36,54,92,231,231,240,96,156,158,43,186,84,43,163,44,111,123,202,93,102,78,125,57,110,45,26,139,82,171,248,20,191,66,4,145,247,143,32,165,102,213,37,178,207,78,230,12,5,210,89,18,12,43,105,190,205,33,151,210,92,17,166,69,209,157,68,71,237,21,173,8,145,128,102,130,139,1,171,136,149,36,75,189,16,236,58,28,247,72,217,235,132,28,87,171,76,95,17,102,45,90,111,222,36,243,88,73,117,152,135,75,222,78,120,158,229,251,214,4,126,208,104,116,225,251,23,81,84,211,102,114,62,214,169,171,57,183,10,254,158,116,177,75,124,167,100,163,111,79,254,190,106,188,122,213,52,155,240,179,129,155,169,55,5,55,91,135,238,230,6,78,182,86,57,9,112,23,123,61,252,88,50,231,158,204,205,77,156,252,99,3,239,50,39,244,5,68,178,145,109,39,45,81,57,64,27,44,37,97,77,129,68,114,35,37,141,158,174,246,216,39,169,135,243,2,148,175,63,201,253,91,171,65,26,39,122,15,184,72,39,186,6,184,212,102,140,98,39,200,216,74,58,12,30,198,184,190,81,253,2,70,180,253,152,2,63,74,113,202,208,55,194,71,168,133,188,100,66,140,169,227,66,48,158,142,183,31,144,182,99,157,182,17,248,138,197,203,209,127,99,18,98,239,233,136,41,36,184,185,8,201,241,214,170,228,205,222,55,111,39,69,222,246,70,151,125,248,116,157,234,116,81,39,130,181,91,128,196,139,160,241,222,88,171,158,156,123,103,237,76,103,205,39,158,71,241,1,211,117,186,111,186,126,211,233,26,196,148,30,48,89,123,207,173,223,117,178,56,120,116,192,100,157,237,155,172,243,148,44,70,89,44,190,213,202,22,17,238,15,192,95,107,223,252,217,205,60,129,191,104,91,135,54,251,240,104,171,94,108,236,139,182,194,211,213,90,219,78,69,169,85,219,78,186,9,107,239,104,85,140,42,198,213,63,177,78,158,7,115,54,9,36,74,126,138,104,249,213,91,5,68,124,244,82,14,73,118,49,203,65,249,61,186,106,180,6,204,190,238,118,163,117,246,61,23,182,226,214,17,72,51,92,125,94,186,234,137,252,86,88,68,107,245,236,251,171,44,77,81,59,38,148,147,160,176,145,22,101,89,151,248,34,186,214,203,130,168,36,167,150,144,22,229,200,242,6,37,190,119,201,96,128,67,24,149,56,243,173,202,105,106,86,179,248,239,2,74,7,12,153,38,159,208,192,203,194,209,19,255,132,160,226,145,240,59,31,62,217,138,199,3,39,166,60,195,149,112,159,129,212,231,48,231,181,250,194,32,159,201,87,198,171,6,201,64,31,197,187,11,251,76,223,98,41,58,203,83,66,67,204,227,48,208,242,84,244,206,94,190,152,253,15,2,111,198,21,164,50,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateTranslateForegroundMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("13584ca6-b00a-4c82-9844-c7e81bfeb16c"),
				Name = "TranslateForeground",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce"),
				ResultValueTypeName = "OpenXmlSpreadsheet.ForegroundColor"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7ba93148-77bc-49e3-be2f-5e6ab168076c"),
				Name = "fillColor",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "System.Drawing.Color",
				CreatedInPackageId = new Guid("d45dc8b6-924a-4c74-b50c-49a315ef60ce")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,75,107,194,64,16,62,71,240,63,44,233,101,3,97,105,175,21,15,62,106,21,106,11,42,109,15,94,86,51,198,224,238,78,152,221,160,65,242,223,155,151,173,208,28,118,134,249,230,251,230,181,111,24,47,204,1,185,117,148,152,88,204,144,180,116,220,223,186,235,99,81,154,167,210,108,221,18,220,17,35,251,204,54,36,141,85,210,65,201,131,152,48,51,145,31,178,89,162,224,93,106,8,217,203,101,15,106,161,83,36,183,136,130,96,208,239,101,182,44,203,248,18,52,82,190,118,4,82,51,219,184,33,51,112,102,247,25,30,4,236,218,239,121,181,136,175,211,18,139,236,17,192,77,113,159,105,48,142,217,14,108,200,58,152,98,82,66,14,120,211,43,236,162,108,242,20,196,23,210,105,135,120,106,59,123,213,35,112,25,153,122,186,143,20,204,183,86,119,106,241,183,250,4,21,18,111,133,222,42,222,181,43,205,225,50,78,140,164,252,83,170,12,126,9,94,29,86,227,230,214,129,22,83,146,231,234,230,117,153,219,101,145,196,6,231,78,43,222,104,188,46,178,152,17,234,17,197,187,27,201,59,36,74,53,169,81,248,31,91,117,96,175,29,216,184,133,130,198,7,98,5,169,146,123,224,254,67,249,205,190,223,224,69,101,139,65,123,173,50,42,126,0,134,143,104,240,69,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogExcelImportMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("434fe856-717b-48a9-99f5-819fd0b13157"),
				Name = "LogExcelImport",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,65,75,195,64,16,133,207,22,250,31,150,61,165,16,22,61,139,23,99,42,1,141,74,245,100,61,44,201,52,44,36,179,50,153,152,22,241,191,59,41,166,73,43,180,130,151,93,118,120,243,205,155,199,198,235,12,202,164,122,247,196,73,174,174,212,109,227,114,147,66,219,221,193,236,114,58,185,243,69,130,43,31,212,76,14,11,51,247,84,89,14,244,146,63,207,191,228,184,144,99,201,241,64,81,45,57,6,85,250,34,84,53,91,98,29,170,185,43,33,181,21,132,42,30,143,155,117,252,15,75,10,125,251,104,73,4,12,36,30,16,90,245,212,0,109,118,197,64,139,68,64,55,150,225,217,85,96,82,223,134,74,247,79,221,131,178,134,8,144,95,106,160,200,35,219,76,166,156,34,143,122,146,92,135,211,201,217,79,59,66,198,206,163,137,6,129,217,81,187,137,7,186,5,212,181,220,98,202,190,234,189,69,245,155,204,222,171,72,119,231,37,65,65,112,176,15,154,137,5,147,32,251,96,76,209,219,242,2,36,251,206,166,138,124,217,84,104,134,69,14,162,221,169,35,2,137,41,127,64,105,26,7,253,75,113,189,217,130,143,102,56,52,221,251,220,173,220,81,110,47,249,51,56,94,67,214,48,252,251,223,1,230,39,126,221,55,238,112,165,34,247,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckRequiredFieldsNotFilledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("129ca747-6bd5-4fd4-85f6-8c7555c39699"),
				Name = "CheckRequiredFieldsNotFilled",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("561dcfa7-37ab-4e39-8e2d-2699aaf0861f"),
				Name = "requiredFieldsNotFilled",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,79,75,3,49,16,197,207,45,244,59,140,123,202,210,53,212,243,186,135,182,80,240,160,20,219,234,65,60,68,51,45,193,52,89,39,89,69,164,223,221,217,127,98,133,54,151,100,96,50,191,247,94,98,182,32,8,223,43,67,168,23,6,173,14,119,62,46,140,181,168,229,220,87,46,66,81,192,36,133,239,209,112,64,24,43,114,176,85,54,96,62,26,30,70,195,15,69,208,223,158,123,91,237,93,128,2,28,126,194,42,146,113,187,89,101,172,70,18,9,36,41,223,216,122,2,97,120,166,225,174,73,206,219,53,156,133,115,203,120,220,195,143,48,114,90,150,232,244,41,237,79,230,185,6,14,12,219,51,112,81,156,199,192,37,92,181,148,83,152,36,107,29,12,14,141,239,165,218,161,156,169,128,183,24,2,159,151,202,161,149,83,173,187,90,60,42,34,199,1,116,117,6,245,236,118,109,156,122,177,184,41,173,87,172,198,246,35,96,12,137,132,132,183,208,68,39,23,158,246,42,138,251,35,225,83,194,95,237,217,255,232,229,218,183,177,139,52,253,75,236,8,235,175,18,37,11,171,117,101,16,169,194,218,81,99,133,149,175,94,201,148,81,36,117,61,247,46,42,227,144,36,187,170,220,94,133,55,145,230,77,0,55,225,65,89,163,249,253,250,111,208,253,138,122,94,254,3,249,254,52,195,78,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCheckIsNullDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e75520fa-b5fb-4dec-992c-d18a0b2b18e0"),
				Name = "CheckIsNullData",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4ec54b02-188b-4519-9038-46ecdee8ad6f"),
				Name = "sheetDataElements",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row>",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("352d830e-d47d-4001-9ed4-1b165107d85e"),
				Name = "stringTablePart",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SharedStringTablePart",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,82,91,79,194,48,20,126,46,9,255,225,192,83,151,144,78,159,117,36,138,151,240,160,18,1,241,181,108,7,104,40,221,210,118,160,49,252,119,79,203,64,240,97,75,191,238,187,245,116,91,105,65,185,215,90,235,7,233,37,100,224,109,141,55,237,214,162,180,40,243,21,240,45,17,108,185,3,101,192,173,16,125,160,61,106,220,160,241,78,204,86,104,145,91,200,250,96,197,123,185,27,154,2,191,160,15,215,73,2,63,237,22,107,196,71,62,217,19,18,71,120,251,86,161,249,220,232,113,69,89,69,116,23,3,212,186,207,19,106,192,210,84,45,128,159,201,197,160,172,141,231,9,100,25,92,29,2,210,148,229,165,241,202,196,210,4,247,244,190,232,158,147,97,40,127,230,115,144,178,224,254,140,62,36,126,72,93,35,15,212,30,56,111,149,89,78,228,92,227,72,90,159,64,39,3,67,243,105,84,236,98,90,11,169,93,76,102,108,78,161,235,184,12,29,194,19,2,58,127,244,198,224,196,35,202,158,116,237,86,224,253,167,141,228,18,197,189,116,248,130,206,209,122,36,13,106,113,87,20,13,230,51,105,173,161,162,13,238,193,212,132,202,211,74,151,178,120,82,26,79,31,154,197,228,187,66,65,170,32,234,197,107,142,83,142,65,228,59,206,173,170,60,239,6,60,160,145,74,101,208,10,202,172,205,70,186,53,93,73,55,242,135,142,134,165,138,243,179,91,244,181,53,199,63,135,142,213,108,28,8,191,47,226,90,172,98,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("de796769-1794-4f07-88fe-f0bd3f97f5bf"),
				Name = "LogInfo",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("ff6db8c2-aaeb-43c3-ad7c-1d48a4333145"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("33efd87b-037f-4307-9c95-f1d7e380a382"),
				Name = "message",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("ff6db8c2-aaeb-43c3-ad7c-1d48a4333145")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,112,173,72,78,205,9,45,201,204,201,44,201,76,45,214,243,201,79,87,80,180,85,200,43,205,201,209,84,168,230,229,226,196,148,215,243,204,75,203,215,200,77,45,46,78,76,79,213,180,230,229,170,5,0,224,225,217,64,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogExcelImportLogMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f5338465-07d8-4002-be3c-886adf295dc5"),
				Name = "LogExcelImportLog",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("12648e04-c8c4-4d4c-afbe-cd42c913505e"),
				Name = "message",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,209,74,3,49,16,69,159,45,244,31,66,158,178,176,228,7,196,23,215,34,1,173,138,245,3,66,50,46,129,102,34,217,73,119,251,247,38,173,219,221,98,169,248,20,146,185,247,220,153,201,78,71,134,161,127,213,81,123,32,136,236,142,33,244,236,45,65,220,159,30,5,207,18,94,179,7,77,176,113,30,228,58,244,53,227,227,149,87,183,203,197,46,131,76,138,17,144,62,58,136,77,64,210,134,148,253,139,60,243,40,203,235,229,226,230,199,142,96,200,5,148,205,36,144,39,234,152,216,38,103,51,248,49,31,114,13,125,57,69,169,149,36,133,217,66,226,28,87,229,0,169,144,130,224,171,193,192,86,249,175,16,233,41,180,252,80,121,7,18,188,244,193,154,176,77,30,229,212,105,137,170,38,81,19,33,143,111,95,48,107,231,11,252,165,184,223,31,120,87,119,51,153,158,131,117,159,238,42,119,148,252,19,12,93,167,91,216,192,64,151,166,243,199,242,108,192,217,122,46,47,228,76,112,52,174,6,48,137,32,127,193,55,32,2,201,149,88,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateExecuteImportExcelDataProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ba7f687-1321-4e56-a8f4-b3fe7458972f"),
				Name = "ExecuteImportExcelDataProcess",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9d450bbc-bf23-4454-b29a-d2cc9ba7cf90"),
				Name = "rows",
				CreatedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				ModifiedInSchemaUId = new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string[][]",
				CreatedInPackageId = new Guid("4cbc9f01-9447-4c47-b88a-f54633e6598a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,223,79,131,48,16,199,159,37,225,127,104,120,130,132,16,125,158,154,24,182,41,198,31,75,140,241,101,47,29,220,102,39,180,228,90,220,150,133,255,221,22,202,198,80,247,210,180,247,253,244,123,215,235,61,137,85,194,151,194,151,10,25,95,69,83,129,5,85,190,55,87,251,203,90,47,87,122,153,171,55,69,81,1,97,69,41,80,145,18,69,154,130,244,66,50,101,57,188,208,2,66,50,217,166,144,39,141,158,100,65,48,114,157,214,144,172,197,194,16,228,134,120,173,220,144,99,170,168,119,2,221,163,168,202,63,168,38,222,67,77,114,144,242,31,207,89,171,26,254,155,98,7,207,40,106,92,1,74,125,133,195,134,140,89,170,152,224,20,119,215,173,109,72,196,98,13,169,186,245,3,178,119,157,139,189,119,242,32,111,240,192,58,108,152,225,131,66,130,98,35,59,81,206,144,21,58,197,152,201,50,167,187,88,228,85,193,39,91,38,149,105,221,57,217,58,188,65,174,75,130,44,201,128,43,182,100,41,53,69,183,160,177,56,171,91,15,211,167,54,146,240,12,182,250,214,32,98,185,152,150,230,178,177,237,182,86,233,254,184,247,221,93,125,233,39,20,212,106,199,195,73,115,158,69,102,212,227,225,208,157,87,158,239,38,136,2,101,199,12,66,150,124,0,154,1,26,99,83,92,239,84,187,78,173,255,217,117,238,202,210,100,207,170,28,48,234,118,73,81,64,198,168,2,59,18,143,98,225,219,89,12,15,243,22,246,199,201,164,123,151,128,177,224,28,154,249,136,62,4,126,201,146,166,16,181,247,6,114,92,33,234,214,155,168,5,126,13,92,48,250,1,226,210,63,45,97,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ImportSettingsPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cff20af-14a7-4b54-83fe-15c5815e63f2"));
		}

		#endregion

	}

	#endregion

}

