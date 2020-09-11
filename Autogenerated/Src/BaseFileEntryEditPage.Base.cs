namespace Terrasoft.WebApp
{

	using Entities = Terrasoft.Core.Entities;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.IO.Compression;
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

	#region Class: BaseFileEntryEditPageSchema

	/// <exclude/>
	public class BaseFileEntryEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _nameControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NameControlLayout {
			get {
				return _nameControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameTextEdit {
			get {
				return _nameTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _fileUploadEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return _fileUploadEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _notesControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NotesControlLayout {
			get {
				return _notesControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MemoEdit _notesMemoEdit;
		public Terrasoft.UI.WebControls.Controls.MemoEdit NotesMemoEdit {
			get {
				return _notesMemoEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _historyControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout HistoryControlLayout {
			get {
				return _historyControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _leftHistoryControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LeftHistoryControlLayout {
			get {
				return _leftHistoryControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _lockedByLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit LockedByLookupEdit {
			get {
				return _lockedByLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _modifiedByLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ModifiedByLookupEdit {
			get {
				return _modifiedByLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _createdByLookupEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit CreatedByLookupEdit {
			get {
				return _createdByLookupEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _versionIntegerEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit VersionIntegerEdit {
			get {
				return _versionIntegerEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _rightHistoryControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout RightHistoryControlLayout {
			get {
				return _rightHistoryControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _lockedOnDateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit LockedOnDateTimeEdit {
			get {
				return _lockedOnDateTimeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _modifiedOnDateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit ModifiedOnDateTimeEdit {
			get {
				return _modifiedOnDateTimeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _createdOnDateTimeEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CreatedOnDateTimeEdit {
			get {
				return _createdOnDateTimeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _sizeControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SizeControlLayout {
			get {
				return _sizeControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _sizeIntegerEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit SizeIntegerEdit {
			get {
				return _sizeIntegerEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseFileEntryEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseFileEntryEditPageSchema(BaseFileEntryEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			RealUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			Name = "BaseFileEntryEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 360;
			HelpContextId = "207";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseFileEntryEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateNameControlLayout());
			NameControlLayout.InsertItem(0, CreateNameTextEdit());
			NameControlLayout.InsertItem(1, CreateFileUploadEdit());
			MainControlLayout.InsertItem(1, CreateNotesControlLayout());
			NotesControlLayout.InsertItem(0, CreateNotesMemoEdit());
			MainControlLayout.InsertItem(2, CreateHistoryControlLayout());
			HistoryControlLayout.InsertItem(0, CreateLeftHistoryControlLayout());
			LeftHistoryControlLayout.InsertItem(0, CreateLockedByLookupEdit());
			LeftHistoryControlLayout.InsertItem(1, CreateModifiedByLookupEdit());
			LeftHistoryControlLayout.InsertItem(2, CreateCreatedByLookupEdit());
			LeftHistoryControlLayout.InsertItem(3, CreateVersionIntegerEdit());
			HistoryControlLayout.InsertItem(1, CreateRightHistoryControlLayout());
			RightHistoryControlLayout.InsertItem(0, CreateLockedOnDateTimeEdit());
			RightHistoryControlLayout.InsertItem(1, CreateModifiedOnDateTimeEdit());
			RightHistoryControlLayout.InsertItem(2, CreateCreatedOnDateTimeEdit());
			RightHistoryControlLayout.InsertItem(3, CreateSizeControlLayout());
			SizeControlLayout.InsertItem(0, CreateSizeIntegerEdit());
			MainControlLayout.MoveItem(3, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseFileEntryEditPageEventsProcessSchema() {
			var schema = new BaseFileEntryEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameTextEdit() {
			_nameTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameTextEdit.UId = new Guid("b45fb83f-d674-4dd8-80aa-85bb3f909b1e");
			_nameTextEdit.Name = "NameTextEdit";
			_nameTextEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_nameTextEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_nameTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameTextEdit.Tag = "";
			_nameTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameTextEdit.Image = new ControlImage {};
			_nameTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameTextEdit.Margins = "0 0";
			_nameTextEdit.DataSource = "DataSource";
			_nameTextEdit.ColumnUId = new Guid("dce7142d-49b5-48ba-9bd2-60fb6c17ba06");
			return _nameTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateFileUploadEdit() {
			_fileUploadEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_fileUploadEdit.UId = new Guid("ad383513-2d8f-447c-bbae-a1721a5e33e7");
			_fileUploadEdit.Name = "FileUploadEdit";
			_fileUploadEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_fileUploadEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_fileUploadEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_fileUploadEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_fileUploadEdit.AjaxEvents.Change.ShowLoadMask = true;
			_fileUploadEdit.Tag = "";
			_fileUploadEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_fileUploadEdit.Image = new ControlImage {};
			_fileUploadEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_fileUploadEdit.Margins = "0 0";
			return _fileUploadEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNameControlLayout() {
			_nameControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_nameControlLayout.UId = new Guid("c8d98361-99e5-4cf6-8cd4-119eeb21ddc1");
			_nameControlLayout.Name = "NameControlLayout";
			_nameControlLayout.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_nameControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_nameControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameControlLayout.Tag = "";
			_nameControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(150);
			_nameControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_nameControlLayout.FitHeightByContent = true;
			_nameControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameControlLayout.StartNewAlignGroup = false;
			_nameControlLayout.Image = new ControlImage {};
			_nameControlLayout.Edges = "";
			return _nameControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MemoEdit CreateNotesMemoEdit() {
			_notesMemoEdit = new Terrasoft.UI.WebControls.Controls.MemoEdit();
			_notesMemoEdit.UId = new Guid("6128cb8b-c901-40b1-bcc9-1d641d1be709");
			_notesMemoEdit.Name = "NotesMemoEdit";
			_notesMemoEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_notesMemoEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_notesMemoEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_notesMemoEdit.Tag = "";
			_notesMemoEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_notesMemoEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_notesMemoEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_notesMemoEdit.Margins = "0 0";
			_notesMemoEdit.DataSource = "DataSource";
			_notesMemoEdit.ColumnUId = new Guid("43105570-b68a-497c-b7be-eb21745bea9f");
			return _notesMemoEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNotesControlLayout() {
			_notesControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_notesControlLayout.UId = new Guid("29fa20e3-3833-46b2-8d63-a0dc44b8ed1a");
			_notesControlLayout.Name = "NotesControlLayout";
			_notesControlLayout.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_notesControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_notesControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_notesControlLayout.Tag = "";
			_notesControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_notesControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_notesControlLayout.FitHeightByContent = true;
			_notesControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_notesControlLayout.StartNewAlignGroup = false;
			_notesControlLayout.Image = new ControlImage {};
			_notesControlLayout.Edges = "";
			return _notesControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateLockedByLookupEdit() {
			_lockedByLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_lockedByLookupEdit.UId = new Guid("f7f19997-6019-41a5-a3e1-1f98a8914faa");
			_lockedByLookupEdit.Name = "LockedByLookupEdit";
			_lockedByLookupEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_lockedByLookupEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_lockedByLookupEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lockedByLookupEdit.Tag = "";
			_lockedByLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lockedByLookupEdit.Image = new ControlImage {};
			_lockedByLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lockedByLookupEdit.DataSource = "DataSource";
			_lockedByLookupEdit.ColumnUId = new Guid("01c55d24-a7b9-472a-8416-d8ada2df2964");
			_lockedByLookupEdit.Enabled = false;
			return _lockedByLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateModifiedByLookupEdit() {
			_modifiedByLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_modifiedByLookupEdit.UId = new Guid("7f93ce2a-4a5a-493c-b3c2-75acc6f77cae");
			_modifiedByLookupEdit.Name = "ModifiedByLookupEdit";
			_modifiedByLookupEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_modifiedByLookupEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_modifiedByLookupEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_modifiedByLookupEdit.Tag = "";
			_modifiedByLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_modifiedByLookupEdit.Image = new ControlImage {};
			_modifiedByLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_modifiedByLookupEdit.DataSource = "DataSource";
			_modifiedByLookupEdit.ColumnUId = new Guid("72f14472-f279-4d3c-b346-6a1d1dab14ed");
			_modifiedByLookupEdit.Enabled = false;
			return _modifiedByLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateCreatedByLookupEdit() {
			_createdByLookupEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_createdByLookupEdit.UId = new Guid("8cb7103b-f169-468c-b6aa-c3717ea232b3");
			_createdByLookupEdit.Name = "CreatedByLookupEdit";
			_createdByLookupEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_createdByLookupEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_createdByLookupEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_createdByLookupEdit.Tag = "";
			_createdByLookupEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_createdByLookupEdit.Image = new ControlImage {};
			_createdByLookupEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_createdByLookupEdit.DataSource = "DataSource";
			_createdByLookupEdit.ColumnUId = new Guid("80ff42f1-6c42-4587-9bad-a7e5cca40cf5");
			_createdByLookupEdit.Enabled = false;
			return _createdByLookupEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateVersionIntegerEdit() {
			_versionIntegerEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_versionIntegerEdit.UId = new Guid("1114edf9-aab7-40ad-ae18-005ab6c0207d");
			_versionIntegerEdit.Name = "VersionIntegerEdit";
			_versionIntegerEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_versionIntegerEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_versionIntegerEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_versionIntegerEdit.Tag = "";
			_versionIntegerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_versionIntegerEdit.Image = new ControlImage {};
			_versionIntegerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_versionIntegerEdit.DataSource = "DataSource";
			_versionIntegerEdit.ColumnUId = new Guid("f9765bf9-ad9c-425a-b0bc-ea6af4c6f8ab");
			_versionIntegerEdit.Enabled = false;
			return _versionIntegerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLeftHistoryControlLayout() {
			_leftHistoryControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_leftHistoryControlLayout.UId = new Guid("5f7f906d-9420-412f-a0f3-e98cba53b795");
			_leftHistoryControlLayout.Name = "LeftHistoryControlLayout";
			_leftHistoryControlLayout.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_leftHistoryControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_leftHistoryControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_leftHistoryControlLayout.Tag = "";
			_leftHistoryControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(45);
			_leftHistoryControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_leftHistoryControlLayout.FitHeightByContent = true;
			_leftHistoryControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(65);
			_leftHistoryControlLayout.StartNewAlignGroup = false;
			_leftHistoryControlLayout.Image = new ControlImage {};
			_leftHistoryControlLayout.Edges = "";
			_leftHistoryControlLayout.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.Left;
			return _leftHistoryControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateLockedOnDateTimeEdit() {
			_lockedOnDateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_lockedOnDateTimeEdit.UId = new Guid("6d351d8a-d889-40dc-97f5-75bac728ed08");
			_lockedOnDateTimeEdit.Name = "LockedOnDateTimeEdit";
			_lockedOnDateTimeEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_lockedOnDateTimeEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_lockedOnDateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lockedOnDateTimeEdit.Tag = "";
			_lockedOnDateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lockedOnDateTimeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lockedOnDateTimeEdit.AlignedByCaption = false;
			_lockedOnDateTimeEdit.DataSource = "DataSource";
			_lockedOnDateTimeEdit.ColumnUId = new Guid("5299d6a2-0b89-4442-a1eb-97ffba3b306d");
			_lockedOnDateTimeEdit.Enabled = false;
			return _lockedOnDateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateModifiedOnDateTimeEdit() {
			_modifiedOnDateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_modifiedOnDateTimeEdit.UId = new Guid("177200cb-9c87-40d0-a3d8-65b285b54d4e");
			_modifiedOnDateTimeEdit.Name = "ModifiedOnDateTimeEdit";
			_modifiedOnDateTimeEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_modifiedOnDateTimeEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_modifiedOnDateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_modifiedOnDateTimeEdit.Tag = "";
			_modifiedOnDateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_modifiedOnDateTimeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_modifiedOnDateTimeEdit.AlignedByCaption = false;
			_modifiedOnDateTimeEdit.DataSource = "DataSource";
			_modifiedOnDateTimeEdit.ColumnUId = new Guid("586625fe-62d1-469d-9463-e5a36fa99aef");
			_modifiedOnDateTimeEdit.Enabled = false;
			return _modifiedOnDateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreateCreatedOnDateTimeEdit() {
			_createdOnDateTimeEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_createdOnDateTimeEdit.UId = new Guid("5b141dc8-e2c5-4f30-9508-79a06ac3f709");
			_createdOnDateTimeEdit.Name = "CreatedOnDateTimeEdit";
			_createdOnDateTimeEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_createdOnDateTimeEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_createdOnDateTimeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_createdOnDateTimeEdit.Tag = "";
			_createdOnDateTimeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_createdOnDateTimeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_createdOnDateTimeEdit.AlignedByCaption = false;
			_createdOnDateTimeEdit.DataSource = "DataSource";
			_createdOnDateTimeEdit.ColumnUId = new Guid("dcd9afac-f593-4c49-8973-e5fb2f4aec00");
			_createdOnDateTimeEdit.Enabled = false;
			return _createdOnDateTimeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateSizeIntegerEdit() {
			_sizeIntegerEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_sizeIntegerEdit.UId = new Guid("fe89e6e6-dc26-41f6-bd5d-a53cc4856a28");
			_sizeIntegerEdit.Name = "SizeIntegerEdit";
			_sizeIntegerEdit.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_sizeIntegerEdit.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_sizeIntegerEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sizeIntegerEdit.Tag = "";
			_sizeIntegerEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sizeIntegerEdit.Image = new ControlImage {};
			_sizeIntegerEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sizeIntegerEdit.DataSource = "DataSource";
			_sizeIntegerEdit.ColumnUId = new Guid("bad62a04-62d7-4b88-81d6-d7841b36bf8a");
			_sizeIntegerEdit.Enabled = false;
			return _sizeIntegerEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSizeControlLayout() {
			_sizeControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_sizeControlLayout.UId = new Guid("61cc0dd6-6ce1-4467-9fc7-6381c7793c89");
			_sizeControlLayout.Name = "SizeControlLayout";
			_sizeControlLayout.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_sizeControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_sizeControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sizeControlLayout.Tag = "";
			_sizeControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_sizeControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_sizeControlLayout.FitHeightByContent = true;
			_sizeControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sizeControlLayout.StartNewAlignGroup = false;
			_sizeControlLayout.Image = new ControlImage {};
			_sizeControlLayout.Edges = "";
			return _sizeControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateRightHistoryControlLayout() {
			_rightHistoryControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_rightHistoryControlLayout.UId = new Guid("36a4c7db-80e8-4db1-bf82-54146660e876");
			_rightHistoryControlLayout.Name = "RightHistoryControlLayout";
			_rightHistoryControlLayout.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_rightHistoryControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_rightHistoryControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_rightHistoryControlLayout.Tag = "";
			_rightHistoryControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(45);
			_rightHistoryControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_rightHistoryControlLayout.FitHeightByContent = true;
			_rightHistoryControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(35);
			_rightHistoryControlLayout.StartNewAlignGroup = false;
			_rightHistoryControlLayout.Image = new ControlImage {};
			_rightHistoryControlLayout.Edges = "";
			_rightHistoryControlLayout.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.Left;
			return _rightHistoryControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateHistoryControlLayout() {
			_historyControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_historyControlLayout.UId = new Guid("eaacd2a8-09c1-4e3e-9a9c-dff0d2dcaacb");
			_historyControlLayout.Name = "HistoryControlLayout";
			_historyControlLayout.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_historyControlLayout.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			_historyControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_historyControlLayout.AjaxEvents.Collapse.IsProcessEventHandler = true;
			_historyControlLayout.AjaxEvents.Expand.IsProcessEventHandler = true;
			_historyControlLayout.Tag = "";
			_historyControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(45);
			_historyControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_historyControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_historyControlLayout.FitHeightByContent = true;
			_historyControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_historyControlLayout.IsCollapsible = true;
			_historyControlLayout.StartNewAlignGroup = false;
			_historyControlLayout.Image = new ControlImage {};
			_historyControlLayout.Edges = "";
			_historyControlLayout.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.Left;
			return _historyControlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			DataSource.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("176287a4-506a-4353-a5b3-9978665020eb");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4a35bb09-6c8c-4de8-8773-4e9e3b3cf3b0");
			if (column != null) {
				column.UId = new Guid("dce7142d-49b5-48ba-9bd2-60fb6c17ba06");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("dcd9afac-f593-4c49-8973-e5fb2f4aec00");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("80ff42f1-6c42-4587-9bad-a7e5cca40cf5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("586625fe-62d1-469d-9463-e5a36fa99aef");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("72f14472-f279-4d3c-b346-6a1d1dab14ed");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8f7c60c3-7d35-4de4-a234-6e18470eb34c");
			if (column != null) {
				column.UId = new Guid("43105570-b68a-497c-b7be-eb21745bea9f");
				column.Name = @"Notes";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6b37344b-b460-44c5-9fd7-a623689bba4c");
			if (column != null) {
				column.UId = new Guid("01c55d24-a7b9-472a-8416-d8ada2df2964");
				column.Name = @"LockedBy";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f906243b-8d5c-48f0-8220-89d5c9175806");
			if (column != null) {
				column.UId = new Guid("5299d6a2-0b89-4442-a1eb-97ffba3b306d");
				column.Name = @"LockedOn";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("73c5b07b-3c1a-44fc-953e-f2ce6cbb7420");
			if (column != null) {
				column.UId = new Guid("7cefd20b-4165-41b8-b2fc-0cb6adc6cb08");
				column.Name = @"Data";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6255f70e-45c9-4346-8ee0-8d604459e7d8");
			if (column != null) {
				column.UId = new Guid("624b80f4-1c5b-4d0e-b028-e27c3c683d4b");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8d8676ce-6974-4157-9a96-841d4499fccb");
			if (column != null) {
				column.UId = new Guid("f9765bf9-ad9c-425a-b0bc-ea6af4c6f8ab");
				column.Name = @"Version";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5d9d91dd-892d-4652-8da1-e7a53b96ba4a");
			if (column != null) {
				column.UId = new Guid("bad62a04-62d7-4b88-81d6-d7841b36bf8a");
				column.Name = @"Size";
				column.CreatedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
				column.ModifiedInSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
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
			return new BaseFileEntryEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseFileEntryEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseFileEntryEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseFileEntryEditPageEventsProcess

	/// <exclude/>
	public class BaseFileEntryEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseFileEntryEditPageSchemaUserControl
	{

		public BaseFileEntryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseFileEntryEditPageEventsProcess";
			SchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d");
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

		public virtual string FileContent {
			get;
			set;
		}

		public virtual int FileSize {
			get;
			set;
		}

		private ProcessFlowElement _subProcessDataSourceLoaded;
		public ProcessFlowElement SubProcessDataSourceLoaded {
			get {
				return _subProcessDataSourceLoaded ?? (_subProcessDataSourceLoaded = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessDataSourceLoaded",
					SchemaElementUId = new Guid("b959ce88-69ad-4b8c-9c8a-6a1a8e1b82e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceLoaded;
		public ProcessFlowElement DataSourceLoaded {
			get {
				return _dataSourceLoaded ?? (_dataSourceLoaded = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceLoaded",
					SchemaElementUId = new Guid("7ad8eeb8-4eaa-48a9-8da6-be203a6f7c98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwDataSourceBeforeInsert;
		public ProcessThrowMessageEvent ThrowDataSourceBeforeInsert {
			get {
				return _throwDataSourceBeforeInsert ?? (_throwDataSourceBeforeInsert = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowDataSourceBeforeInsert",
					SchemaElementUId = new Guid("8df16dab-11d5-491d-9706-ab71007c872e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceBeforeInsert",
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceLoaded;
		public ProcessScriptTask ScriptDataSourceLoaded {
			get {
				return _scriptDataSourceLoaded ?? (_scriptDataSourceLoaded = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceLoaded",
					SchemaElementUId = new Guid("e4e42a0d-2dd8-4559-a239-732476c29491"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceLoadedExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessFileUploadEditChange;
		public ProcessFlowElement SubProcessFileUploadEditChange {
			get {
				return _subProcessFileUploadEditChange ?? (_subProcessFileUploadEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessFileUploadEditChange",
					SchemaElementUId = new Guid("72dc0794-0f02-4e1a-9908-428c74d79f68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("6fe9fa9e-7300-4936-98fa-bf3444172c7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFileUploadEditChange;
		public ProcessScriptTask ScriptFileUploadEditChange {
			get {
				return _scriptFileUploadEditChange ?? (_scriptFileUploadEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFileUploadEditChange",
					SchemaElementUId = new Guid("b77af1fd-0a4e-46a0-bd3e-0e4817ac9d69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFileUploadEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessDataSourceBeforeSave;
		public ProcessFlowElement SubProcessDataSourceBeforeSave {
			get {
				return _subProcessDataSourceBeforeSave ?? (_subProcessDataSourceBeforeSave = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessDataSourceBeforeSave",
					SchemaElementUId = new Guid("b9d30dc9-3231-48f0-baf3-0d02b562f920"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeSave;
		public ProcessFlowElement DataSourceBeforeSave {
			get {
				return _dataSourceBeforeSave ?? (_dataSourceBeforeSave = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeSave",
					SchemaElementUId = new Guid("de3798a7-884c-43dc-817a-ee7cb5df6d1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceBeforeSave;
		public ProcessScriptTask ScriptDataSourceBeforeSave {
			get {
				return _scriptDataSourceBeforeSave ?? (_scriptDataSourceBeforeSave = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceBeforeSave",
					SchemaElementUId = new Guid("fc0317f3-3439-4239-93e5-6926206f9c41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceBeforeSaveExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessDataSourceBeforeSaveServer;
		public ProcessFlowElement SubProcessDataSourceBeforeSaveServer {
			get {
				return _subProcessDataSourceBeforeSaveServer ?? (_subProcessDataSourceBeforeSaveServer = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessDataSourceBeforeSaveServer",
					SchemaElementUId = new Guid("7526c743-9a94-429e-a27f-def7dca77b58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeSaveServer;
		public ProcessFlowElement DataSourceBeforeSaveServer {
			get {
				return _dataSourceBeforeSaveServer ?? (_dataSourceBeforeSaveServer = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeSaveServer",
					SchemaElementUId = new Guid("56372303-1d98-43ae-a25a-b2767f6c1a2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDataSourceBeforeSaveServer;
		public ProcessScriptTask ScriptDataSourceBeforeSaveServer {
			get {
				return _scriptDataSourceBeforeSaveServer ?? (_scriptDataSourceBeforeSaveServer = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDataSourceBeforeSaveServer",
					SchemaElementUId = new Guid("91fee47d-ac09-4ec2-af9a-0e35762934a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDataSourceBeforeSaveServerExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoadChild;
		public ProcessFlowElement SubProcessPageLoadChild {
			get {
				return _subProcessPageLoadChild ?? (_subProcessPageLoadChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoadChild",
					SchemaElementUId = new Guid("112ca0ab-8860-4fb7-b878-7d576dde651a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadChild;
		public ProcessFlowElement PageLoadChild {
			get {
				return _pageLoadChild ?? (_pageLoadChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadChild",
					SchemaElementUId = new Guid("48e27269-7a32-4235-9523-452f83100983"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadChild;
		public ProcessScriptTask ScriptPageLoadChild {
			get {
				return _scriptPageLoadChild ?? (_scriptPageLoadChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadChild",
					SchemaElementUId = new Guid("ff21908e-7888-476d-baa7-711a72868bc1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadChildExecute,
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
					SchemaElementUId = new Guid("36324431-15e7-4607-b4e6-bf24f2b69f33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoadCompleteChild;
		public ProcessFlowElement SubProcessPageLoadCompleteChild {
			get {
				return _subProcessPageLoadCompleteChild ?? (_subProcessPageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoadCompleteChild",
					SchemaElementUId = new Guid("7f5733b7-1010-4037-ace1-971d143823bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChild;
		public ProcessFlowElement PageLoadCompleteChild {
			get {
				return _pageLoadCompleteChild ?? (_pageLoadCompleteChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChild",
					SchemaElementUId = new Guid("a09e5bed-37b1-40ad-9c87-970c4d65475d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("64b182c1-1772-4814-9f3c-bad842f4a835"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChild;
		public ProcessScriptTask ScriptPageLoadCompleteChild {
			get {
				return _scriptPageLoadCompleteChild ?? (_scriptPageLoadCompleteChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChild",
					SchemaElementUId = new Guid("bc32e98f-7f5d-4e19-b567-589ec98cf9f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
				});
			}
		}

		private LocalizableString _fileWindowCaption;
		public LocalizableString FileWindowCaption {
			get {
				return _fileWindowCaption ?? (_fileWindowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FileWindowCaption.Value"));
			}
		}

		private LocalizableString _linkWindowCaption;
		public LocalizableString LinkWindowCaption {
			get {
				return _linkWindowCaption ?? (_linkWindowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.LinkWindowCaption.Value"));
			}
		}

		private LocalizableString _attentionCaption;
		public LocalizableString AttentionCaption {
			get {
				return _attentionCaption ?? (_attentionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AttentionCaption.Value"));
			}
		}

		private LocalizableString _fileMaxSizeMoreThan;
		public LocalizableString FileMaxSizeMoreThan {
			get {
				return _fileMaxSizeMoreThan ?? (_fileMaxSizeMoreThan = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FileMaxSizeMoreThan.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessDataSourceLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessDataSourceLoaded };
			FlowElements[DataSourceLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceLoaded };
			FlowElements[ThrowDataSourceBeforeInsert.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowDataSourceBeforeInsert };
			FlowElements[ScriptDataSourceLoaded.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceLoaded };
			FlowElements[SubProcessFileUploadEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessFileUploadEditChange };
			FlowElements[FileUploadEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { FileUploadEditChange };
			FlowElements[ScriptFileUploadEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFileUploadEditChange };
			FlowElements[SubProcessDataSourceBeforeSave.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessDataSourceBeforeSave };
			FlowElements[DataSourceBeforeSave.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeSave };
			FlowElements[ScriptDataSourceBeforeSave.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceBeforeSave };
			FlowElements[SubProcessDataSourceBeforeSaveServer.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessDataSourceBeforeSaveServer };
			FlowElements[DataSourceBeforeSaveServer.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeSaveServer };
			FlowElements[ScriptDataSourceBeforeSaveServer.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDataSourceBeforeSaveServer };
			FlowElements[SubProcessPageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoadChild };
			FlowElements[PageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadChild };
			FlowElements[ScriptPageLoadChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadChild };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[SubProcessPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoadCompleteChild };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessDataSourceLoaded":
						break;
					case "DataSourceLoaded":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceLoaded");
						break;
					case "ThrowDataSourceBeforeInsert":
						break;
					case "ScriptDataSourceLoaded":
						e.Context.QueueTasks.Enqueue("ThrowDataSourceBeforeInsert");
						break;
					case "SubProcessFileUploadEditChange":
						break;
					case "FileUploadEditChange":
						e.Context.QueueTasks.Enqueue("ScriptFileUploadEditChange");
						break;
					case "ScriptFileUploadEditChange":
						break;
					case "SubProcessDataSourceBeforeSave":
						break;
					case "DataSourceBeforeSave":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceBeforeSave");
						break;
					case "ScriptDataSourceBeforeSave":
						break;
					case "SubProcessDataSourceBeforeSaveServer":
						break;
					case "DataSourceBeforeSaveServer":
						e.Context.QueueTasks.Enqueue("ScriptDataSourceBeforeSaveServer");
						break;
					case "ScriptDataSourceBeforeSaveServer":
						break;
					case "SubProcessPageLoadChild":
						break;
					case "PageLoadChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "ScriptPageLoadChild":
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadChild");
						break;
					case "SubProcessPageLoadCompleteChild":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "ScriptPageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DataSourceLoaded");
			ActivatedEventElements.Add("FileUploadEditChange");
			ActivatedEventElements.Add("DataSourceBeforeSave");
			ActivatedEventElements.Add("DataSourceBeforeSaveServer");
			ActivatedEventElements.Add("PageLoadChild");
			ActivatedEventElements.Add("PageLoadCompleteChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessDataSourceLoaded":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceLoaded":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceLoaded";
					result = DataSourceLoaded.Execute(context);
					break;
				case "ThrowDataSourceBeforeInsert":
					context.QueueTasks.Dequeue();
					result = ThrowDataSourceBeforeInsert.Execute(context);
					break;
				case "ScriptDataSourceLoaded":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceLoaded";
					result = ScriptDataSourceLoaded.Execute(context, ScriptDataSourceLoadedExecute);
					break;
				case "SubProcessFileUploadEditChange":
					context.QueueTasks.Dequeue();
					break;
				case "FileUploadEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "FileUploadEditChange";
					result = FileUploadEditChange.Execute(context);
					break;
				case "ScriptFileUploadEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFileUploadEditChange";
					result = ScriptFileUploadEditChange.Execute(context, ScriptFileUploadEditChangeExecute);
					break;
				case "SubProcessDataSourceBeforeSave":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeSave":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeSave";
					result = DataSourceBeforeSave.Execute(context);
					break;
				case "ScriptDataSourceBeforeSave":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceBeforeSave";
					result = ScriptDataSourceBeforeSave.Execute(context, ScriptDataSourceBeforeSaveExecute);
					break;
				case "SubProcessDataSourceBeforeSaveServer":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeSaveServer":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeSaveServer";
					result = DataSourceBeforeSaveServer.Execute(context);
					break;
				case "ScriptDataSourceBeforeSaveServer":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDataSourceBeforeSaveServer";
					result = ScriptDataSourceBeforeSaveServer.Execute(context, ScriptDataSourceBeforeSaveServerExecute);
					break;
				case "SubProcessPageLoadChild":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadChild";
					result = PageLoadChild.Execute(context);
					break;
				case "ScriptPageLoadChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadChild";
					result = ScriptPageLoadChild.Execute(context, ScriptPageLoadChildExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "SubProcessPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
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
				case "FileSize":
					FileSize = reader.GetValue<System.Int32>();
				break;
				case "FileContent":
					FileContent = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptDataSourceLoadedExecute(ProcessExecutingContext context) {
			var isFileType = GetIsFileType(Page.DataSource.ActiveRow);
			SetControlsVisibilityByFileType(isFileType);
			Page.FileUploadEdit.Value = Page.DataSource.ActiveRow.GetColumnValue("Name");
			return true;
		}

		public virtual bool ScriptFileUploadEditChangeExecute(ProcessExecutingContext context) {
			if (Page.FileUploadEdit.HasFile) {
				Page.NameTextEdit.Value = Page.FileUploadEdit.FileName;
				Page.FileUploadEdit.FileContent.Position = 0;
				//FileContent = Page.FileUploadEdit.FileContent;
				//FileSize = Page.FileUploadEdit.FileBytes.Length;
				FileSize = (int)Page.FileUploadEdit.FileContent.Length;
				string encodedData = Convert.ToBase64String(Page.FileUploadEdit.FileBytes);
				FileContent = encodedData;
			}
			var notes= Page.NotesMemoEdit.Value;
			Page.NotesMemoEdit.Value = "";
			if (notes.Equals(String.Empty)) {
				notes = " ";
			}
			Page.NotesMemoEdit.Value = notes;
			
			return true;
		}

		public virtual bool ScriptDataSourceBeforeSaveExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptDataSourceBeforeSaveServerExecute(ProcessExecutingContext context) {
			if (FileContent != null) {
				byte[] fileData = Convert.FromBase64String((string)FileContent);
				Page.DataSource.ActiveRow.SetBytesValue("Data", fileData);
				Page.DataSource.ActiveRow.SetColumnValue("Size", FileSize);
				if (Page.NameTextEdit.Value != null) {
					string fileName = System.IO.Path.GetFileName(Page.NameTextEdit.Value.ToString());
					Page.DataSource.ActiveRow.SetColumnValue("Name", fileName);
				}	
				FileContent = null;
			}
			return true;
		}

		public virtual bool ScriptPageLoadChildExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeSaveRow +=
			 delegate(object sender, DataSourceEventArgs e) {
				Page.ThrowEvent("DataSourceBeforeSaveServer");
			};
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			Page.FileUploadEdit.AjaxEvents.Change.ShowOpaqueMask = true;
			SynchronizeDataSourceStructure = true;
			Guid schemaUId = new Guid(Page.Request.QueryString["entitySchemaUId"].ToString());
			Page.DataSource.SchemaUId = schemaUId;
			Page.DataSource.BeforeInsert +=
			 delegate(object sender, DataSourceEventArgs e) {
			 	HandleDataSourceBeforeInsertRow(e.Row);
			};
			Page.DataSource.Loaded +=
			 delegate(object sender, DataSourceEventArgs e) {
			 	
				Page.DataSource.SetActiveRow(EntityPrimaryColumnValue);
				Page.ThrowEvent("DataSourceLoaded");
			};
			IsCaptionExists = true;
			return true;
		}

		public override bool AreConditionsCorrect(Entity row) {
			var maxFileSize = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "MaxFileSize");
			maxFileSize = (maxFileSize == 0) ? 1 : maxFileSize * 1048576;
			if ((FileSize/maxFileSize >= 1) && (!Page.BaseMessagePanel.HasMessage("FileOvercameMaxSize"))) {
				Page.BaseMessagePanel.AddMessage("FileOvercameMaxSize", AttentionCaption, FileMaxSizeMoreThan);
				return false;
			} else {
				return true;
			}
		}

		public virtual void HandleDataSourceBeforeInsertRow(Entity row) {
			Guid lockedById = (row.GetColumnValue("LockedById") == null) ? Guid.Empty : new Guid(row.GetColumnValue("LockedById").ToString());
			Guid currentUserContactId = UserConnection.CurrentUser.ContactId;
			bool canEdit = (lockedById.Equals(Guid.Empty)) || (lockedById.Equals(currentUserContactId)) 
				|| UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanForceUnlockFile");
			Page.OKButton.Enabled = canEdit;
			bool isFileType = GetIsFileType(row);
			SetControlsVisibilityByFileType(isFileType);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = isFileType
				? (IsNew || IsCopy ? string.Format("{0} ({1})", FileWindowCaption, NewRecordCaption) : string.Format("{0} ({1})", FileWindowCaption, EditingRecordCaption)) 
				: (IsNew || IsCopy ? string.Format("{0} ({1})", LinkWindowCaption, NewRecordCaption) : string.Format("{0} ({1})", LinkWindowCaption, EditingRecordCaption));
		}

		public virtual void SetControlsVisibilityByFileType(bool isFileType) {
			Page.NameTextEdit.Visible = !isFileType;
			Page.FileUploadEdit.Visible = isFileType;
			Page.FileUploadEdit.Required = isFileType;
		}

		public virtual bool GetIsFileType(Entity row) {
			Guid fileTypeId = new Guid("529BC2F8-0EE0-DF11-971B-001D60E938C6");
			Guid typeId = row.GetTypedColumnValue<Guid>("TypeId");
			return typeId.Equals(fileTypeId);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DataSourceLoaded":
							if (ActivatedEventElements.Contains("DataSourceLoaded")) {
							context.QueueTasks.Enqueue("DataSourceLoaded");
						}
						break;
					case "FileUploadEditChange":
							if (ActivatedEventElements.Contains("FileUploadEditChange")) {
							context.QueueTasks.Enqueue("FileUploadEditChange");
						}
						break;
					case "DataSourceBeforeSave":
							if (ActivatedEventElements.Contains("DataSourceBeforeSave")) {
							context.QueueTasks.Enqueue("DataSourceBeforeSave");
						}
						break;
					case "DataSourceBeforeSaveServer":
							if (ActivatedEventElements.Contains("DataSourceBeforeSaveServer")) {
							context.QueueTasks.Enqueue("DataSourceBeforeSaveServer");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadChild")) {
							context.QueueTasks.Enqueue("PageLoadChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
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
			if (!HasMapping("FileSize") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileSize", FileSize, 0);
			}
			if (!HasMapping("FileContent") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileContent", FileContent, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseFileEntryEditPageEventsProcess

	/// <exclude/>
	public class BaseFileEntryEditPageEventsProcess : BaseFileEntryEditPageEventsProcess<Terrasoft.WebApp.BaseFileEntryEditPageSchemaUserControl>
	{

		public BaseFileEntryEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseFileEntryEditPageSchemaUserControl

	/// <exclude/>
	public partial class BaseFileEntryEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout NameControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NameControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit FileUploadEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("FileUploadEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NotesControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NotesControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MemoEdit NotesMemoEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.MemoEdit)PageContainer.FindPageControl("NotesMemoEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout HistoryControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("HistoryControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout LeftHistoryControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LeftHistoryControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit LockedByLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("LockedByLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit ModifiedByLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ModifiedByLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit CreatedByLookupEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("CreatedByLookupEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit VersionIntegerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("VersionIntegerEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout RightHistoryControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("RightHistoryControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit LockedOnDateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("LockedOnDateTimeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit ModifiedOnDateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("ModifiedOnDateTimeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit CreatedOnDateTimeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("CreatedOnDateTimeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SizeControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SizeControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit SizeIntegerEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("SizeIntegerEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			FileUploadEdit.AjaxEvents.Change.Event += FileUploadEditChange;
			HistoryControlLayout.AjaxEvents.Collapse.Event += HistoryControlLayoutCollapse;
			HistoryControlLayout.AjaxEvents.Expand.Event += HistoryControlLayoutExpand;
			DataSource.BeforeSaveRow += DataSourceBeforeSave;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			FileUploadEdit.AjaxEvents.Change.Event -= FileUploadEditChange;
			HistoryControlLayout.AjaxEvents.Collapse.Event -= HistoryControlLayoutCollapse;
			HistoryControlLayout.AjaxEvents.Expand.Event -= HistoryControlLayoutExpand;
			DataSource.BeforeSaveRow -= DataSourceBeforeSave;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseFileEntryEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseFileEntryEditPageEventsProcess(UserConnection);
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

		public virtual void FileUploadEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FileUploadEditChange");
		}

		public virtual void HistoryControlLayoutCollapse(object sender, EventArgs e) {
			object result = ThrowEvent("HistoryControlLayoutCollapse");
		}

		public virtual void HistoryControlLayoutExpand(object sender, EventArgs e) {
			object result = ThrowEvent("HistoryControlLayoutExpand");
		}

		public virtual void DataSourceBeforeSave(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeSave");
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
			SchemaName = "BaseFileEntryEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseFileEntryEditPageEventsProcessSchema

	/// <exclude/>
	public class BaseFileEntryEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseFileEntryEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseFileEntryEditPageEventsProcessSchema(BaseFileEntryEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseFileEntryEditPageEventsProcess";
			UId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e");
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

		protected virtual ProcessSchemaParameter CreateFileContentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("78e5a656-9947-46d5-a3f7-aca8acfe5c01"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"FileContent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7391fcfb-4465-4971-b041-6231fd00e9b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"FileSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFileContentParameter());
			Parameters.Add(CreateFileSizeParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet142 = CreateLaneSet142LaneSet();
			LaneSets.Add(schemaLaneSet142);
			ProcessSchemaLane schemaLane365 = CreateLane365Lane();
			schemaLaneSet142.Lanes.Add(schemaLane365);
			ProcessSchemaLane schemaLane366 = CreateLane366Lane();
			schemaLaneSet142.Lanes.Add(schemaLane366);
			ProcessSchemaLane schemaLane367 = CreateLane367Lane();
			schemaLaneSet142.Lanes.Add(schemaLane367);
			ProcessSchemaLane schemaLane368 = CreateLane368Lane();
			schemaLaneSet142.Lanes.Add(schemaLane368);
			ProcessSchemaEventSubProcess subprocessdatasourceloaded = CreateSubProcessDataSourceLoadedEventSubProcess();
			FlowElements.Add(subprocessdatasourceloaded);
			ProcessSchemaEventSubProcess subprocessfileuploadeditchange = CreateSubProcessFileUploadEditChangeEventSubProcess();
			FlowElements.Add(subprocessfileuploadeditchange);
			ProcessSchemaEventSubProcess subprocessdatasourcebeforesave = CreateSubProcessDataSourceBeforeSaveEventSubProcess();
			FlowElements.Add(subprocessdatasourcebeforesave);
			ProcessSchemaEventSubProcess subprocessdatasourcebeforesaveserver = CreateSubProcessDataSourceBeforeSaveServerEventSubProcess();
			FlowElements.Add(subprocessdatasourcebeforesaveserver);
			ProcessSchemaEventSubProcess subprocesspageloadchild = CreateSubProcessPageLoadChildEventSubProcess();
			FlowElements.Add(subprocesspageloadchild);
			ProcessSchemaEventSubProcess subprocesspageloadcompletechild = CreateSubProcessPageLoadCompleteChildEventSubProcess();
			FlowElements.Add(subprocesspageloadcompletechild);
			ProcessSchemaStartMessageEvent datasourceloaded = CreateDataSourceLoadedStartMessageEvent();
			subprocessdatasourceloaded.FlowElements.Add(datasourceloaded);
			ProcessSchemaIntermediateThrowMessageEvent throwdatasourcebeforeinsert = CreateThrowDataSourceBeforeInsertIntermediateThrowMessageEvent();
			subprocessdatasourceloaded.FlowElements.Add(throwdatasourcebeforeinsert);
			ProcessSchemaScriptTask scriptdatasourceloaded = CreateScriptDataSourceLoadedScriptTask();
			subprocessdatasourceloaded.FlowElements.Add(scriptdatasourceloaded);
			ProcessSchemaStartMessageEvent fileuploadeditchange = CreateFileUploadEditChangeStartMessageEvent();
			subprocessfileuploadeditchange.FlowElements.Add(fileuploadeditchange);
			ProcessSchemaScriptTask scriptfileuploadeditchange = CreateScriptFileUploadEditChangeScriptTask();
			subprocessfileuploadeditchange.FlowElements.Add(scriptfileuploadeditchange);
			ProcessSchemaStartMessageEvent datasourcebeforesave = CreateDataSourceBeforeSaveStartMessageEvent();
			subprocessdatasourcebeforesave.FlowElements.Add(datasourcebeforesave);
			ProcessSchemaScriptTask scriptdatasourcebeforesave = CreateScriptDataSourceBeforeSaveScriptTask();
			subprocessdatasourcebeforesave.FlowElements.Add(scriptdatasourcebeforesave);
			ProcessSchemaStartMessageEvent datasourcebeforesaveserver = CreateDataSourceBeforeSaveServerStartMessageEvent();
			subprocessdatasourcebeforesaveserver.FlowElements.Add(datasourcebeforesaveserver);
			ProcessSchemaScriptTask scriptdatasourcebeforesaveserver = CreateScriptDataSourceBeforeSaveServerScriptTask();
			subprocessdatasourcebeforesaveserver.FlowElements.Add(scriptdatasourcebeforesaveserver);
			ProcessSchemaStartMessageEvent pageloadchild = CreatePageLoadChildStartMessageEvent();
			subprocesspageloadchild.FlowElements.Add(pageloadchild);
			ProcessSchemaScriptTask scriptpageloadchild = CreateScriptPageLoadChildScriptTask();
			subprocesspageloadchild.FlowElements.Add(scriptpageloadchild);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			subprocesspageloadchild.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			subprocesspageloadcompletechild.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			subprocesspageloadcompletechild.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			subprocesspageloadcompletechild.FlowElements.Add(scriptpageloadcompletechild);
			FlowElements.Add(CreateSequenceFlow2660SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2661SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2662SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2663SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2664SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2671SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2672SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2673SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2674SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFileWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateLinkWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateAttentionCaptionLocalizableString());
			LocalizableStrings.Add(CreateFileMaxSizeMoreThanLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFileWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("06a7d094-8fc5-4063-b528-754d3265d47d"),
				Name = "FileWindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLinkWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5e0fb504-d037-4e13-b411-6449fe681c12"),
				Name = "LinkWindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAttentionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bf994f2d-0ab7-4ee9-9123-7c2357a8879e"),
				Name = "AttentionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFileMaxSizeMoreThanLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b9009976-45ff-48d8-99bc-351f6594b510"),
				Name = "FileMaxSizeMoreThan",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2660SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2660",
				UId = new Guid("e88e74cb-e99b-4ff8-b976-5d43d185ec45"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6fe9fa9e-7300-4936-98fa-bf3444172c7e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b77af1fd-0a4e-46a0-bd3e-0e4817ac9d69"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2661SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2661",
				UId = new Guid("6aff6c3a-fbdd-4859-9e8f-b48c429013c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56372303-1d98-43ae-a25a-b2767f6c1a2f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("91fee47d-ac09-4ec2-af9a-0e35762934a9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2662SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2662",
				UId = new Guid("a7d8aa1e-f452-4e94-b600-792c00c834b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de3798a7-884c-43dc-817a-ee7cb5df6d1c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc0317f3-3439-4239-93e5-6926206f9c41"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2663SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2663",
				UId = new Guid("d94c0ee6-a974-4760-9715-4f60e2949a9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(445, 910),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4e42a0d-2dd8-4559-a239-732476c29491"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8df16dab-11d5-491d-9706-ab71007c872e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2664SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2664",
				UId = new Guid("70a9765a-ca44-497d-aca4-23f8ff4a2866"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(445, 910),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ad8eeb8-4eaa-48a9-8da6-be203a6f7c98"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e4e42a0d-2dd8-4559-a239-732476c29491"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2671SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2671",
				UId = new Guid("38f22aaf-153f-4209-91f3-26623828a120"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(132, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("48e27269-7a32-4235-9523-452f83100983"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36324431-15e7-4607-b4e6-bf24f2b69f33"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2672SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2672",
				UId = new Guid("ec65dc9a-faeb-4c7e-9749-7df2a59ec8e4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(220, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("36324431-15e7-4607-b4e6-bf24f2b69f33"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff21908e-7888-476d-baa7-711a72868bc1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2673SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2673",
				UId = new Guid("3e6f00d2-d29f-4222-94f5-0a1835ba8427"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(382, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a09e5bed-37b1-40ad-9c87-970c4d65475d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bc32e98f-7f5d-4e19-b567-589ec98cf9f4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2674SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2674",
				UId = new Guid("76f6b275-ab1f-4caa-be4f-7abfd2aca392"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CurveCenterPosition = new Point(502, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc32e98f-7f5d-4e19-b567-589ec98cf9f4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("64b182c1-1772-4814-9f3c-bad842f4a835"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet142LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet142 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fa03c9b5-3421-407e-a05d-d24a25868c83"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"LaneSet142",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(862, 680),
				UseBackgroundMode = false
			};
			return schemaLaneSet142;
		}

		protected virtual ProcessSchemaLane CreateLane365Lane() {
			ProcessSchemaLane schemaLane365 = new ProcessSchemaLane(this) {
				UId = new Guid("ce67d5d3-4e4e-4867-be86-5131926ad065"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fa03c9b5-3421-407e-a05d-d24a25868c83"),
				CreatedInOwnerSchemaUId = new Guid("0cdb5a1a-1587-4c1b-8ce8-83f61167ac6d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"Lane365",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(833, 177),
				UseBackgroundMode = false
			};
			return schemaLane365;
		}

		protected virtual ProcessSchemaLane CreateLane366Lane() {
			ProcessSchemaLane schemaLane366 = new ProcessSchemaLane(this) {
				UId = new Guid("d25dc6a8-9650-418d-9b29-cc1267526562"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("fa03c9b5-3421-407e-a05d-d24a25868c83"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"Lane366",
				Position = new Point(29, 182),
				Size = new Size(833, 159),
				UseBackgroundMode = false
			};
			return schemaLane366;
		}

		protected virtual ProcessSchemaLane CreateLane367Lane() {
			ProcessSchemaLane schemaLane367 = new ProcessSchemaLane(this) {
				UId = new Guid("cefb2f58-c28f-4735-b1a9-31e80a80c5bb"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("fa03c9b5-3421-407e-a05d-d24a25868c83"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"Lane367",
				Position = new Point(29, 346),
				Size = new Size(833, 159),
				UseBackgroundMode = false
			};
			return schemaLane367;
		}

		protected virtual ProcessSchemaLane CreateLane368Lane() {
			ProcessSchemaLane schemaLane368 = new ProcessSchemaLane(this) {
				UId = new Guid("026af648-6f91-4306-9ffa-5dae7e507386"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("fa03c9b5-3421-407e-a05d-d24a25868c83"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"Lane368",
				Position = new Point(29, 510),
				Size = new Size(833, 170),
				UseBackgroundMode = false
			};
			return schemaLane368;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessDataSourceLoadedEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessDataSourceLoaded = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b959ce88-69ad-4b8c-9c8a-6a1a8e1b82e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("026af648-6f91-4306-9ffa-5dae7e507386"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"SubProcessDataSourceLoaded",
				Position = new Point(29, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(363, 133),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessDataSourceLoaded;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceLoadedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7ad8eeb8-4eaa-48a9-8da6-be203a6f7c98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b959ce88-69ad-4b8c-9c8a-6a1a8e1b82e1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceLoaded",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"DataSourceLoaded",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowDataSourceBeforeInsertIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8df16dab-11d5-491d-9706-ab71007c872e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b959ce88-69ad-4b8c-9c8a-6a1a8e1b82e1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceBeforeInsert",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ThrowDataSourceBeforeInsert",
				Position = new Point(253, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceLoadedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e4e42a0d-2dd8-4559-a239-732476c29491"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b959ce88-69ad-4b8c-9c8a-6a1a8e1b82e1"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ScriptDataSourceLoaded",
				Position = new Point(134, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,141,189,10,194,64,16,132,123,193,119,56,82,197,230,94,32,88,248,27,108,68,140,166,95,147,69,22,54,119,97,111,47,114,111,47,151,34,86,150,51,204,124,223,4,98,40,156,137,241,145,70,52,91,83,163,94,150,92,222,224,141,246,8,10,141,143,210,161,221,117,74,19,222,253,103,83,173,87,13,234,193,59,21,207,161,165,64,47,98,210,180,79,203,249,199,205,235,25,149,139,231,200,30,250,83,79,106,91,224,152,165,127,53,182,206,14,142,131,155,167,101,113,133,1,139,140,19,212,40,206,168,68,172,190,105,115,218,93,197,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessFileUploadEditChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessFileUploadEditChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("72dc0794-0f02-4e1a-9908-428c74d79f68"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cefb2f58-c28f-4735-b1a9-31e80a80c5bb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"SubProcessFileUploadEditChange",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(193, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessFileUploadEditChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFileUploadEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6fe9fa9e-7300-4936-98fa-bf3444172c7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("72dc0794-0f02-4e1a-9908-428c74d79f68"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FileUploadEditChange",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"FileUploadEditChange",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFileUploadEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b77af1fd-0a4e-46a0-bd3e-0e4817ac9d69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("72dc0794-0f02-4e1a-9908-428c74d79f68"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ScriptFileUploadEditChange",
				Position = new Point(84, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,49,79,195,48,16,133,103,252,43,172,76,201,226,118,64,44,22,75,33,136,1,170,74,45,236,39,114,13,150,18,187,181,47,21,5,241,223,57,155,40,205,16,194,102,251,125,239,249,157,109,246,50,223,64,141,234,193,52,248,114,104,28,84,101,101,72,61,66,136,39,133,252,18,87,73,95,67,139,59,252,160,164,190,66,211,161,188,149,83,206,184,141,176,238,141,19,242,157,179,132,150,212,198,5,67,198,89,78,90,50,190,88,140,196,153,244,158,24,28,91,243,57,87,102,117,38,12,234,9,109,77,239,236,25,57,114,99,169,248,175,228,96,12,228,141,173,37,218,55,87,97,117,15,4,28,193,212,9,61,169,157,91,65,192,155,235,109,130,38,159,116,232,82,244,45,46,147,142,50,181,248,22,39,240,210,58,38,251,161,214,113,253,140,173,187,60,190,22,127,41,28,151,101,90,24,254,216,148,161,202,99,7,77,200,127,155,169,178,61,208,185,72,255,154,228,136,203,44,222,58,19,152,72,45,132,71,234,188,149,228,185,192,15,106,72,160,37,58,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessDataSourceBeforeSaveEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessDataSourceBeforeSave = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b9d30dc9-3231-48f0-baf3-0d02b562f920"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d25dc6a8-9650-418d-9b29-cc1267526562"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"SubProcessDataSourceBeforeSave",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessDataSourceBeforeSave;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeSaveStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("de3798a7-884c-43dc-817a-ee7cb5df6d1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9d30dc9-3231-48f0-baf3-0d02b562f920"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeSave",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"DataSourceBeforeSave",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceBeforeSaveScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fc0317f3-3439-4239-93e5-6926206f9c41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9d30dc9-3231-48f0-baf3-0d02b562f920"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ScriptDataSourceBeforeSave",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessDataSourceBeforeSaveServerEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessDataSourceBeforeSaveServer = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7526c743-9a94-429e-a27f-def7dca77b58"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d25dc6a8-9650-418d-9b29-cc1267526562"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"SubProcessDataSourceBeforeSaveServer",
				Position = new Point(428, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessDataSourceBeforeSaveServer;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeSaveServerStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("56372303-1d98-43ae-a25a-b2767f6c1a2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7526c743-9a94-429e-a27f-def7dca77b58"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeSaveServer",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"DataSourceBeforeSaveServer",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDataSourceBeforeSaveServerScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("91fee47d-ac09-4ec2-af9a-0e35762934a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7526c743-9a94-429e-a27f-def7dca77b58"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ScriptDataSourceBeforeSaveServer",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,65,107,2,49,16,133,207,43,248,31,162,167,93,40,115,18,47,226,65,109,183,244,162,210,72,47,197,67,106,71,27,200,38,144,157,216,106,241,191,59,137,139,232,65,196,75,50,48,243,189,55,47,209,107,145,151,218,224,196,89,66,75,162,51,20,54,24,83,136,255,118,43,251,218,17,126,46,197,154,251,207,138,148,24,10,30,219,162,39,40,189,171,198,170,198,126,79,146,215,118,147,231,117,186,139,11,173,98,192,18,115,181,65,136,176,116,193,175,16,70,43,210,91,124,119,191,32,145,198,172,95,127,40,19,48,239,198,153,238,211,217,235,62,60,113,38,84,182,161,165,222,35,211,209,61,150,137,214,28,45,41,76,85,133,11,252,163,151,111,77,144,128,235,152,217,105,247,228,29,103,57,167,220,213,132,21,188,205,96,174,232,7,94,145,202,166,121,75,18,22,174,121,138,34,185,63,176,124,20,107,162,199,50,225,135,140,143,203,143,57,45,204,173,67,187,229,145,130,183,130,124,192,193,17,23,17,59,160,193,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoadChild = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("112ca0ab-8860-4fb7-b878-7d576dde651a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce67d5d3-4e4e-4867-be86-5131926ad065"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"SubProcessPageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(246, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoadChild;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("48e27269-7a32-4235-9523-452f83100983"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("112ca0ab-8860-4fb7-b878-7d576dde651a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"PageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ff21908e-7888-476d-baa7-711a72868bc1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("112ca0ab-8860-4fb7-b878-7d576dde651a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ScriptPageLoadChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,140,75,10,194,48,16,134,215,230,20,67,87,45,74,47,16,92,40,186,47,166,23,24,219,223,136,72,6,166,147,116,33,222,93,234,38,235,239,49,112,68,127,97,227,32,89,39,244,103,60,68,17,184,224,38,43,237,143,142,102,188,17,217,208,202,253,133,201,104,65,154,161,7,170,209,181,32,217,73,227,66,232,232,227,118,195,246,28,159,42,235,159,180,77,85,235,62,64,11,180,233,188,251,122,167,176,172,137,76,51,252,15,175,80,2,12,146,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("36324431-15e7-4607-b4e6-bf24f2b69f33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("112ca0ab-8860-4fb7-b878-7d576dde651a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadCompleteChildEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoadCompleteChild = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7f5733b7-1010-4037-ace1-971d143823bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce67d5d3-4e4e-4867-be86-5131926ad065"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"SubProcessPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(280, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(267, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoadCompleteChild;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a09e5bed-37b1-40ad-9c87-970c4d65475d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f5733b7-1010-4037-ace1-971d143823bb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("64b182c1-1772-4814-9f3c-bad842f4a835"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f5733b7-1010-4037-ace1-971d143823bb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bc32e98f-7f5d-4e19-b567-589ec98cf9f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f5733b7-1010-4037-ace1-971d143823bb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,65,79,194,64,16,133,207,244,87,108,122,42,209,244,15,16,14,136,85,73,52,34,5,47,198,195,216,125,182,139,101,23,119,103,41,104,252,239,46,109,4,18,110,30,119,118,222,251,222,204,76,169,68,122,163,106,44,214,181,33,153,73,197,233,104,73,219,108,3,205,46,29,87,164,67,67,94,153,230,113,77,159,30,15,228,62,196,80,176,245,24,68,249,78,23,149,53,90,125,225,154,152,114,227,109,129,60,252,21,236,45,14,109,183,94,73,225,138,10,43,90,76,100,40,107,52,98,95,76,166,123,250,12,193,215,113,250,228,97,119,65,173,116,249,18,7,186,226,93,254,39,138,95,211,185,233,254,146,126,127,16,181,194,35,51,205,79,220,15,164,243,182,43,188,27,139,137,118,176,44,46,134,145,144,168,81,18,35,49,111,75,20,44,28,180,132,189,20,71,77,187,136,145,45,157,64,95,124,71,162,119,71,90,214,39,243,158,122,206,76,147,132,129,76,19,34,254,156,227,239,195,134,33,255,11,142,122,103,83,131,71,5,171,13,246,220,172,221,216,212,170,21,217,221,216,212,126,165,159,169,246,8,81,58,225,60,156,170,105,93,147,248,104,210,101,138,187,192,19,55,166,53,43,163,179,173,114,236,14,23,180,8,7,213,221,227,23,23,146,48,154,50,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateHandleDataSourceBeforeInsertRowMethod());
			Methods.Add(CreateSetControlsVisibilityByFileTypeMethod());
			Methods.Add(CreateGetIsFileTypeMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("28b4571d-bcda-413b-aa8f-7658287e2760"),
				Name = "Terrasoft.Core.Entities",
				Alias = "Entities",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84867314-f298-4077-a557-264612b24c86"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("282664e2-c6fc-4b24-ab05-8659e97554fe"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cd3a68b1-beb8-477b-b045-c031a024918e"),
				Name = "System.IO.Compression",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("524939f9-1a25-44b1-a300-b4605b112dfb"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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

		protected override SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = base.CreateAreConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,77,75,195,64,16,61,55,191,98,204,161,236,74,89,27,240,11,67,148,90,80,47,193,66,170,247,161,157,196,133,116,35,179,147,226,7,254,119,119,105,68,43,226,101,103,103,230,189,153,247,102,139,12,27,124,185,177,45,85,246,141,160,0,101,157,232,37,49,163,239,106,49,243,142,41,60,174,182,77,207,40,182,115,166,122,245,21,137,88,215,120,115,75,242,136,109,79,234,193,19,7,152,163,85,196,76,32,45,191,167,166,58,79,126,45,217,75,11,152,106,184,130,12,46,246,180,28,66,54,61,62,63,57,59,205,19,91,131,82,95,141,163,159,160,203,2,50,13,227,49,168,131,5,54,100,174,209,83,73,222,135,255,2,29,181,230,14,253,144,171,52,178,238,183,196,43,220,80,208,183,211,166,53,188,39,163,191,201,179,245,250,95,242,4,102,34,228,162,229,57,62,239,156,71,220,208,47,195,241,150,79,232,130,255,17,147,244,236,160,198,214,83,158,124,0,133,24,23,15,117,225,62,150,63,1,176,122,22,20,144,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHandleDataSourceBeforeInsertRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e2344789-070d-4e94-b914-c94178c35c3a"),
				Name = "HandleDataSourceBeforeInsertRow",
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eab6c5c7-ea56-472f-ae1c-536022c34968"),
				Name = "row",
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,95,75,195,48,20,197,159,29,248,29,46,125,74,64,130,190,42,99,184,90,71,81,156,184,63,62,103,237,117,132,101,73,77,82,102,153,251,238,222,148,109,69,25,136,248,84,146,254,238,185,231,220,155,81,173,74,208,182,88,97,57,108,242,18,250,192,156,221,136,17,134,212,234,122,109,230,82,215,200,146,199,35,145,112,232,247,193,212,90,115,24,192,136,202,69,182,174,66,3,215,96,112,211,94,252,170,32,166,118,18,156,50,75,198,249,205,121,47,214,64,81,59,135,38,204,60,186,212,154,32,139,208,186,217,159,13,22,65,89,35,210,142,18,71,140,36,22,214,106,40,164,201,74,21,98,134,46,145,200,222,107,169,61,235,156,114,14,159,159,167,144,83,22,8,62,239,157,17,255,195,200,221,112,130,196,171,208,100,102,169,12,182,121,169,255,7,221,6,28,87,232,100,228,88,66,151,247,214,21,56,51,177,225,189,210,152,196,204,207,114,137,98,252,48,172,67,32,181,204,200,133,198,152,119,159,225,16,73,249,88,49,109,42,164,127,212,34,63,158,227,144,163,208,36,206,217,4,103,181,159,43,175,22,74,147,167,97,115,196,58,133,72,179,182,239,173,175,226,23,164,135,41,58,39,189,125,11,98,150,139,87,92,28,180,68,4,184,72,101,21,99,80,243,78,135,230,49,0,150,251,39,90,55,13,38,247,169,173,26,122,11,190,93,169,160,180,107,25,88,178,189,220,1,219,94,237,120,114,1,177,244,85,153,210,110,246,130,23,64,213,47,88,88,87,238,111,56,61,160,191,41,196,57,17,254,93,165,93,215,245,31,237,61,42,179,250,159,189,19,10,167,237,209,14,190,0,252,207,162,143,115,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlsVisibilityByFileTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a57ff966-e2e0-474b-84b1-b917523540dd"),
				Name = "SetControlsVisibilityByFileType",
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5fe68963-b444-435e-b11f-058e0af3cb9a"),
				Name = "isFileType",
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,75,204,77,13,73,173,40,113,77,201,44,209,11,203,44,206,76,202,73,85,176,85,80,204,44,118,203,204,73,13,169,44,72,181,230,10,0,41,4,113,67,11,114,242,19,83,208,148,18,82,25,148,90,88,154,89,148,154,130,166,20,0,178,69,116,23,126,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsFileTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e389aa9f-c27e-438d-b984-33fe717baf1a"),
				Name = "GetIsFileType",
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("313b956f-acc5-4861-b1e1-cf0e6170e93f"),
				Name = "row",
				CreatedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				ModifiedInSchemaUId = new Guid("fa418773-7788-46ca-af05-0f503a7d143e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,72,203,204,73,13,169,44,72,245,76,81,176,85,200,75,45,87,112,7,138,106,40,153,26,89,58,57,27,185,89,232,26,184,186,26,232,186,184,25,26,234,90,154,27,58,233,26,24,24,186,152,25,184,90,26,91,56,155,41,105,90,243,114,129,148,43,148,192,12,40,202,47,215,115,79,45,1,25,152,226,156,159,83,154,155,23,150,152,83,154,106,3,82,101,167,161,4,177,8,172,175,40,181,164,180,40,15,170,83,207,181,176,52,49,167,88,3,225,24,77,107,0,128,215,248,11,158,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseFileEntryEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa418773-7788-46ca-af05-0f503a7d143e"));
		}

		#endregion

	}

	#endregion

}

