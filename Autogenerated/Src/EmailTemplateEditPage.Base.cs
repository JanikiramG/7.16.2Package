namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
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
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;
	using TSWebControls = Terrasoft.UI.WebControls;

	#region Class: EmailTemplateEditPageSchema

	/// <exclude/>
	public class EmailTemplateEditPageSchema : Terrasoft.WebApp.BaseModuleEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _nameControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NameControlLayout {
			get {
				return _nameControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _objectEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return _objectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _emailControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout EmailControlLayout {
			get {
				return _emailControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _recipientEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit RecipientEdit {
			get {
				return _recipientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _addRecipientToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton AddRecipientToolButton {
			get {
				return _addRecipientToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _copyRecipientEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CopyRecipientEdit {
			get {
				return _copyRecipientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _copyRecipientToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton CopyRecipientToolButton {
			get {
				return _copyRecipientToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _blindCopyRecipientEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit BlindCopyRecipientEdit {
			get {
				return _blindCopyRecipientEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _blindCopyRecipientToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton BlindCopyRecipientToolButton {
			get {
				return _blindCopyRecipientToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _subjectControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout SubjectControlLayout {
			get {
				return _subjectControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _subjectEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SubjectEdit {
			get {
				return _subjectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _addMacrosToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton AddMacrosToolButton {
			get {
				return _addMacrosToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _priorityButton;
		public Terrasoft.UI.WebControls.Controls.Button PriorityButton {
			get {
				return _priorityButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bodyControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BodyControlLayout {
			get {
				return _bodyControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.HtmlEdit _bodyEdit;
		public Terrasoft.UI.WebControls.Controls.HtmlEdit BodyEdit {
			get {
				return _bodyEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _putTemplateToBodyButton;
		public Terrasoft.UI.WebControls.Controls.Button PutTemplateToBodyButton {
			get {
				return _putTemplateToBodyButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _macrosControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MacrosControlLayout {
			get {
				return _macrosControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _setFieldsButton;
		public Terrasoft.UI.WebControls.Controls.Button SetFieldsButton {
			get {
				return _setFieldsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _recipientMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem RecipientMenuItem {
			get {
				return _recipientMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _currentUserMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem CurrentUserMenuItem {
			get {
				return _currentUserMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _objectMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ObjectMenuItem {
			get {
				return _objectMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _macrosTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid MacrosTreeGrid {
			get {
				return _macrosTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _sendIndividualEmailEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SendIndividualEmailEdit {
			get {
				return _sendIndividualEmailEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _saveAsActivityEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox SaveAsActivityEdit {
			get {
				return _saveAsActivityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _objectFieldInActivityEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ObjectFieldInActivityEdit {
			get {
				return _objectFieldInActivityEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showBeforeSendingEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowBeforeSendingEdit {
			get {
				return _showBeforeSendingEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public EmailTemplateEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public EmailTemplateEditPageSchema(EmailTemplateEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateProcessButton() {
			ProcessButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ProcessButton.Image = new ControlImage {};
			ProcessButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdatePrintReportButton() {
			PrintReportButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintReportButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateCustomControlsLeft() {
			CustomControlsLeft.Image = new ControlImage {};
			CustomControlsLeft.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateCustomControlsRight() {
			CustomControlsRight.Image = new ControlImage {};
			CustomControlsRight.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateDataControlLayout() {
			DataControlLayout.Image = new ControlImage {};
			DataControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateDataTab() {
			DataTab.Image = new ControlImage {};
			DataTab.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateDataTabPanel() {
			DataTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			DataTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateCancelButton() {
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateButtomButtonLayout() {
			ButtomButtonLayout.Image = new ControlImage {};
			ButtomButtonLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateRightControlLayout() {
			RightControlLayout.Image = new ControlImage {};
			RightControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			RealUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			Name = "EmailTemplateEditPage";
			ParentSchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 970;
			Height = 750;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailTemplateEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateButtomButtonLayout();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDataTabPanel();
			UpdateDataTab();
			UpdateDataControlLayout();
			UpdateCustomControls();
			UpdateCustomControlsRight();
			UpdateCustomControlsLeft();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdateDesignerModeButton();
			UpdatePrintReportButton();
			UpdateActionButton();
			UpdateProcessButton();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, RightControlLayout);
			RightControlLayout.MoveItem(0, DataTabPanel);
			DataTabPanel.MoveItem(0, DataTab);
			DataTab.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ProcessButton);
			ButtonsControlLayout.MoveItem(1, PrintReportSpacer);
			ButtonsControlLayout.MoveItem(2, ActionButton);
			ButtonsControlLayout.MoveItem(3, PrintReportButton);
			ButtonsControlLayout.MoveItem(4, DesignerModeButton);
			ButtonsControlLayout.MoveItem(5, ContextHelpButton);
			DataTab.MoveItem(1, DataControlLayout);
			DataControlLayout.InsertItem(0, CreateNameControlLayout());
			NameControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateNameEdit());
			NameControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateObjectEdit());
			DataControlLayout.InsertItem(1, CreateEmailControlLayout());
			EmailControlLayout.InsertItem(0, CreateRecipientEdit());
			RecipientEdit.InsertItem(0, CreateAddRecipientToolButton());
			EmailControlLayout.InsertItem(1, CreateCopyRecipientEdit());
			CopyRecipientEdit.InsertItem(0, CreateCopyRecipientToolButton());
			EmailControlLayout.InsertItem(2, CreateBlindCopyRecipientEdit());
			BlindCopyRecipientEdit.InsertItem(0, CreateBlindCopyRecipientToolButton());
			EmailControlLayout.InsertItem(3, CreateSubjectControlLayout());
			SubjectControlLayout.InsertItem(0, CreateSubjectEdit());
			SubjectEdit.InsertItem(0, CreateAddMacrosToolButton());
			SubjectControlLayout.InsertItem(1, CreatePriorityButton());
			DataControlLayout.InsertItem(2, CreateBodyControlLayout());
			BodyControlLayout.InsertItem(0, CreateBodyEdit());
			BodyControlLayout.InsertItem(1, CreatePutTemplateToBodyButton());
			BodyControlLayout.InsertItem(2, CreateMacrosControlLayout());
			MacrosControlLayout.InsertItem(0, CreateSetFieldsButton());
			SetFieldsButton.InsertItem(0, CreateRecipientMenuItem());
			SetFieldsButton.InsertItem(1, CreateCurrentUserMenuItem());
			SetFieldsButton.InsertItem(2, CreateObjectMenuItem());
			MacrosControlLayout.InsertItem(1, CreateMacrosTreeGrid());
			DataControlLayout.InsertItem(3, CreateSendIndividualEmailEdit());
			DataControlLayout.InsertItem(4, CreateSaveAsActivityEdit());
			DataControlLayout.InsertItem(5, CreateObjectFieldInActivityEdit());
			DataControlLayout.InsertItem(6, CreateShowBeforeSendingEdit());
			DataControlLayout.MoveItem(7, CustomControls);
			CustomControls.MoveItem(0, CustomControlsLeft);
			CustomControls.MoveItem(1, CustomControlsRight);
			RightControlLayout.MoveItem(1, ButtomButtonLayout);
			ButtomButtonLayout.MoveItem(0, ButtomSpacer);
			ButtomButtonLayout.MoveItem(1, OKButton);
			ButtomButtonLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateEmailTemplateEditPageEventsProcessSchema() {
			var schema = new EmailTemplateEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("370664c5-bc70-426a-8696-525090478094");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_nameEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("c9c44f05-966f-4c9c-956d-e889128dd6e1");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("5999e72e-336b-4a26-b50a-4ca52cfcf1bb");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_controlLayout1.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(70);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectEdit() {
			_objectEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectEdit.UId = new Guid("f1b37e80-df5a-4445-966c-7adcd456feca");
			_objectEdit.Name = "ObjectEdit";
			_objectEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_objectEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_objectEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectEdit.Tag = "";
			_objectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectEdit.Image = new ControlImage {};
			_objectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectEdit.DataSource = "DataSource";
			_objectEdit.ColumnUId = new Guid("013c1577-1a0b-4e42-ba09-2e0ae2027212");
			_objectEdit.Hidden = true;
			return _objectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("1eda446c-b2b1-4b4b-87f4-9ea904359935");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_controlLayout2.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(30);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			_controlLayout2.Hidden = true;
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNameControlLayout() {
			_nameControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_nameControlLayout.UId = new Guid("45bd56f7-ed75-4da1-9e1e-1f60735a8550");
			_nameControlLayout.Name = "NameControlLayout";
			_nameControlLayout.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_nameControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_nameControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameControlLayout.Tag = "";
			_nameControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_nameControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_nameControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_nameControlLayout.FitHeightByContent = true;
			_nameControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameControlLayout.StartNewAlignGroup = false;
			_nameControlLayout.Image = new ControlImage {};
			_nameControlLayout.Edges = "";
			return _nameControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateAddRecipientToolButton() {
			_addRecipientToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_addRecipientToolButton.UId = new Guid("2454d9d5-4e78-40c3-9c8a-1c7637080399");
			_addRecipientToolButton.Name = "AddRecipientToolButton";
			_addRecipientToolButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_addRecipientToolButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_addRecipientToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addRecipientToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addRecipientToolButton.Tag = "";
			_addRecipientToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"2967f46dffb3953a687d347e4791ebf9"
			};
			return _addRecipientToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateRecipientEdit() {
			_recipientEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_recipientEdit.UId = new Guid("626aaa9e-3050-4c3f-9c46-d2a7d822b0cb");
			_recipientEdit.Name = "RecipientEdit";
			_recipientEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_recipientEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_recipientEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_recipientEdit.Tag = "";
			_recipientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recipientEdit.Image = new ControlImage {};
			_recipientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_recipientEdit.Hidden = true;
			return _recipientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateCopyRecipientToolButton() {
			_copyRecipientToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_copyRecipientToolButton.UId = new Guid("1662aca4-24b8-4b17-9d90-a225c24b6e49");
			_copyRecipientToolButton.Name = "CopyRecipientToolButton";
			_copyRecipientToolButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_copyRecipientToolButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_copyRecipientToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_copyRecipientToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_copyRecipientToolButton.Tag = "";
			_copyRecipientToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"2967f46dffb3953a687d347e4791ebf9"
			};
			return _copyRecipientToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCopyRecipientEdit() {
			_copyRecipientEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_copyRecipientEdit.UId = new Guid("40dadbec-1a62-4099-9e7e-f2267b1df662");
			_copyRecipientEdit.Name = "CopyRecipientEdit";
			_copyRecipientEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_copyRecipientEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_copyRecipientEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_copyRecipientEdit.Tag = "";
			_copyRecipientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_copyRecipientEdit.Image = new ControlImage {};
			_copyRecipientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_copyRecipientEdit.Hidden = true;
			return _copyRecipientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateBlindCopyRecipientToolButton() {
			_blindCopyRecipientToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_blindCopyRecipientToolButton.UId = new Guid("95a0c4ce-12a9-4034-b993-747272d275e3");
			_blindCopyRecipientToolButton.Name = "BlindCopyRecipientToolButton";
			_blindCopyRecipientToolButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_blindCopyRecipientToolButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_blindCopyRecipientToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_blindCopyRecipientToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_blindCopyRecipientToolButton.Tag = "";
			_blindCopyRecipientToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"2967f46dffb3953a687d347e4791ebf9"
			};
			return _blindCopyRecipientToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateBlindCopyRecipientEdit() {
			_blindCopyRecipientEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_blindCopyRecipientEdit.UId = new Guid("37573531-1d5d-40bf-86a1-036752d87a38");
			_blindCopyRecipientEdit.Name = "BlindCopyRecipientEdit";
			_blindCopyRecipientEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_blindCopyRecipientEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_blindCopyRecipientEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_blindCopyRecipientEdit.Tag = "";
			_blindCopyRecipientEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_blindCopyRecipientEdit.Image = new ControlImage {};
			_blindCopyRecipientEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_blindCopyRecipientEdit.Hidden = true;
			return _blindCopyRecipientEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateAddMacrosToolButton() {
			_addMacrosToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_addMacrosToolButton.UId = new Guid("49c4c1f5-2ad4-4abc-a5ce-a6ae9a3faac9");
			_addMacrosToolButton.Name = "AddMacrosToolButton";
			_addMacrosToolButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_addMacrosToolButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_addMacrosToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addMacrosToolButton.Tag = "";
			_addMacrosToolButton.Image = new ControlImage {};
			_addMacrosToolButton.Hidden = true;
			return _addMacrosToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSubjectEdit() {
			_subjectEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_subjectEdit.UId = new Guid("b5d0bc1d-e995-42c0-9493-a304e0659ebb");
			_subjectEdit.Name = "SubjectEdit";
			_subjectEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_subjectEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_subjectEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_subjectEdit.Tag = "";
			_subjectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_subjectEdit.Image = new ControlImage {};
			_subjectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_subjectEdit.DataSource = "DataSource";
			_subjectEdit.ColumnUId = new Guid("519e43d8-cd93-4768-a7f0-c52a9d8e380b");
			return _subjectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreatePriorityButton() {
			_priorityButton = new Terrasoft.UI.WebControls.Controls.Button();
			_priorityButton.UId = new Guid("62dc0054-0186-4a25-9aea-8cb58ba73aef");
			_priorityButton.Name = "PriorityButton";
			_priorityButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_priorityButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_priorityButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_priorityButton.Tag = "";
			_priorityButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"ee7456bf8f8cb3fc24aa1f3d6dd7615f"
			};
			_priorityButton.Width = System.Web.UI.WebControls.Unit.Pixel(24);
			_priorityButton.AutoWidth = false;
			_priorityButton.ImageAsSprite = false;
			_priorityButton.Hidden = true;
			return _priorityButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateSubjectControlLayout() {
			_subjectControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_subjectControlLayout.UId = new Guid("e0709967-6bbf-4358-b76a-4b3ee974635e");
			_subjectControlLayout.Name = "SubjectControlLayout";
			_subjectControlLayout.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_subjectControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_subjectControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_subjectControlLayout.Tag = "";
			_subjectControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_subjectControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_subjectControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_subjectControlLayout.FitHeightByContent = true;
			_subjectControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_subjectControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_subjectControlLayout.StartNewAlignGroup = false;
			_subjectControlLayout.Image = new ControlImage {};
			_subjectControlLayout.Edges = "";
			return _subjectControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateEmailControlLayout() {
			_emailControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_emailControlLayout.UId = new Guid("764e1fc1-b89b-44d2-ace5-d0fc076ce1af");
			_emailControlLayout.Name = "EmailControlLayout";
			_emailControlLayout.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_emailControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_emailControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_emailControlLayout.Tag = "";
			_emailControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_emailControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_emailControlLayout.FitHeightByContent = true;
			_emailControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_emailControlLayout.StartNewAlignGroup = false;
			_emailControlLayout.Image = new ControlImage {};
			_emailControlLayout.Edges = "";
			return _emailControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.HtmlEdit CreateBodyEdit() {
			_bodyEdit = new Terrasoft.UI.WebControls.Controls.HtmlEdit();
			_bodyEdit.UId = new Guid("8a34a678-b85c-4de0-b353-d0e233afb84a");
			_bodyEdit.Name = "BodyEdit";
			_bodyEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_bodyEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_bodyEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bodyEdit.Tag = "";
			_bodyEdit.Edges = "1 1 1 1";
			_bodyEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_bodyEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bodyEdit.DataSource = "DataSource";
			_bodyEdit.ColumnUId = new Guid("939972bc-1e47-4169-b661-11be59da9d9d");
			return _bodyEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreatePutTemplateToBodyButton() {
			_putTemplateToBodyButton = new Terrasoft.UI.WebControls.Controls.Button();
			_putTemplateToBodyButton.UId = new Guid("597c5815-2085-4db8-9848-c355d39aaa03");
			_putTemplateToBodyButton.Name = "PutTemplateToBodyButton";
			_putTemplateToBodyButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_putTemplateToBodyButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_putTemplateToBodyButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_putTemplateToBodyButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_putTemplateToBodyButton.Tag = "";
			_putTemplateToBodyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			_putTemplateToBodyButton.Width = System.Web.UI.WebControls.Unit.Pixel(25);
			_putTemplateToBodyButton.AutoWidth = false;
			_putTemplateToBodyButton.Margins = "0 4 0 4";
			return _putTemplateToBodyButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateRecipientMenuItem() {
			_recipientMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_recipientMenuItem.UId = new Guid("2167f5d3-f0fe-4362-a09f-e38a1752fa77");
			_recipientMenuItem.Name = "RecipientMenuItem";
			_recipientMenuItem.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_recipientMenuItem.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_recipientMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_recipientMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_recipientMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_recipientMenuItem.Image = new ControlImage {};
			_recipientMenuItem.Tag = "";
			return _recipientMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateCurrentUserMenuItem() {
			_currentUserMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_currentUserMenuItem.UId = new Guid("5f6baa65-cb07-4cf5-941a-8edbd16330cd");
			_currentUserMenuItem.Name = "CurrentUserMenuItem";
			_currentUserMenuItem.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_currentUserMenuItem.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_currentUserMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_currentUserMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_currentUserMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_currentUserMenuItem.Image = new ControlImage {};
			_currentUserMenuItem.Tag = "";
			return _currentUserMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateObjectMenuItem() {
			_objectMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_objectMenuItem.UId = new Guid("aa2317a3-5b83-4a21-b8ee-4260f582bb2d");
			_objectMenuItem.Name = "ObjectMenuItem";
			_objectMenuItem.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_objectMenuItem.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_objectMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_objectMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectMenuItem.Image = new ControlImage {};
			_objectMenuItem.Tag = "";
			_objectMenuItem.Hidden = true;
			return _objectMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSetFieldsButton() {
			_setFieldsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_setFieldsButton.UId = new Guid("97e69857-ad9b-4c26-b458-fa09ff4aa10d");
			_setFieldsButton.Name = "SetFieldsButton";
			_setFieldsButton.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_setFieldsButton.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_setFieldsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setFieldsButton.Tag = "";
			_setFieldsButton.Image = new ControlImage {};
			_setFieldsButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_setFieldsButton.AutoWidth = false;
			_setFieldsButton.Hidden = true;
			return _setFieldsButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateMacrosTreeGrid() {
			_macrosTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_macrosTreeGrid.UId = new Guid("8cf8b5e5-c164-40b2-8ea7-11c02b14b3fc");
			_macrosTreeGrid.Name = "MacrosTreeGrid";
			_macrosTreeGrid.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_macrosTreeGrid.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_macrosTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_macrosTreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			_macrosTreeGrid.Tag = "";
			_macrosTreeGrid.Edges = "1 1 1 1";
			_macrosTreeGrid.IsColumnAutowidth = true;
			_macrosTreeGrid.FooterVisible = false;
			_macrosTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_macrosTreeGrid.IsSummaryVisible = false;
			_macrosTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_macrosTreeGrid.ToolbarVisible = false;
			_macrosTreeGrid.QuickFilterVisible = false;
			_macrosTreeGrid.HideHeaders = true;
			_macrosTreeGrid.SplitterSize = 0;
			return _macrosTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMacrosControlLayout() {
			_macrosControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_macrosControlLayout.UId = new Guid("5fa010a5-a4b7-431d-901a-c27354b2a81c");
			_macrosControlLayout.Name = "MacrosControlLayout";
			_macrosControlLayout.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_macrosControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_macrosControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_macrosControlLayout.Tag = "";
			_macrosControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_macrosControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_macrosControlLayout.Width = System.Web.UI.WebControls.Unit.Pixel(300);
			_macrosControlLayout.StartNewAlignGroup = false;
			_macrosControlLayout.Image = new ControlImage {};
			_macrosControlLayout.Edges = "";
			return _macrosControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBodyControlLayout() {
			_bodyControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bodyControlLayout.UId = new Guid("aa58ee83-99bf-4ea0-93ca-790c2d86024a");
			_bodyControlLayout.Name = "BodyControlLayout";
			_bodyControlLayout.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_bodyControlLayout.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_bodyControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bodyControlLayout.Tag = "";
			_bodyControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(300);
			_bodyControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_bodyControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_bodyControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bodyControlLayout.StartNewAlignGroup = false;
			_bodyControlLayout.Image = new ControlImage {};
			_bodyControlLayout.Edges = "";
			_bodyControlLayout.SplitterSize = 0;
			return _bodyControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateSendIndividualEmailEdit() {
			_sendIndividualEmailEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_sendIndividualEmailEdit.UId = new Guid("19eabad9-017b-4160-bf91-c0e7e33967c7");
			_sendIndividualEmailEdit.Name = "SendIndividualEmailEdit";
			_sendIndividualEmailEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_sendIndividualEmailEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_sendIndividualEmailEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sendIndividualEmailEdit.Tag = "";
			_sendIndividualEmailEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sendIndividualEmailEdit.Image = new ControlImage {};
			_sendIndividualEmailEdit.Width = System.Web.UI.WebControls.Unit.Percentage(55);
			_sendIndividualEmailEdit.AlignedByCaption = false;
			_sendIndividualEmailEdit.DataSource = "DataSource";
			_sendIndividualEmailEdit.ColumnUId = new Guid("1b4d128e-94b5-40bb-aaae-abbd96fc9fda");
			_sendIndividualEmailEdit.Hidden = true;
			return _sendIndividualEmailEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateSaveAsActivityEdit() {
			_saveAsActivityEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_saveAsActivityEdit.UId = new Guid("4a5d218d-cb62-4438-b02a-dd9d4ce007c0");
			_saveAsActivityEdit.Name = "SaveAsActivityEdit";
			_saveAsActivityEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_saveAsActivityEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_saveAsActivityEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveAsActivityEdit.Tag = "";
			_saveAsActivityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_saveAsActivityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_saveAsActivityEdit.AlignedByCaption = false;
			_saveAsActivityEdit.DataSource = "DataSource";
			_saveAsActivityEdit.ColumnUId = new Guid("701560e3-c666-4981-9adf-12a0af5a27f7");
			_saveAsActivityEdit.Hidden = true;
			return _saveAsActivityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateObjectFieldInActivityEdit() {
			_objectFieldInActivityEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_objectFieldInActivityEdit.UId = new Guid("92ed71b8-74a8-42f4-892e-069be2fffa17");
			_objectFieldInActivityEdit.Name = "ObjectFieldInActivityEdit";
			_objectFieldInActivityEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_objectFieldInActivityEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_objectFieldInActivityEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectFieldInActivityEdit.Tag = "";
			_objectFieldInActivityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectFieldInActivityEdit.Image = new ControlImage {};
			_objectFieldInActivityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(35);
			_objectFieldInActivityEdit.AlignedByCaption = false;
			_objectFieldInActivityEdit.Margins = "0 0 0 20";
			_objectFieldInActivityEdit.Enabled = false;
			_objectFieldInActivityEdit.Hidden = true;
			return _objectFieldInActivityEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowBeforeSendingEdit() {
			_showBeforeSendingEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showBeforeSendingEdit.UId = new Guid("15d450d4-ede4-433f-8d7c-e73978f4140a");
			_showBeforeSendingEdit.Name = "ShowBeforeSendingEdit";
			_showBeforeSendingEdit.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_showBeforeSendingEdit.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			_showBeforeSendingEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showBeforeSendingEdit.Tag = "";
			_showBeforeSendingEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showBeforeSendingEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showBeforeSendingEdit.AlignedByCaption = false;
			_showBeforeSendingEdit.DataSource = "DataSource";
			_showBeforeSendingEdit.ColumnUId = new Guid("5f0ea661-d9ad-4a2e-b199-581344dd1078");
			_showBeforeSendingEdit.Enabled = false;
			_showBeforeSendingEdit.Hidden = true;
			return _showBeforeSendingEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63");
			DataSource.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("8e1630b1-55e5-4de3-bc5b-b0d8d61de6fc");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ca53e2c8-0767-4f2c-8a18-2ee5821f134e");
			if (column != null) {
				column.UId = new Guid("c9c44f05-966f-4c9c-956d-e889128dd6e1");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("70e39436-6cdc-457f-9233-c4637b914f0e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("ba56d50e-1bf9-4fa7-99ee-bee55226691c");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("27762d1a-b410-4bd8-9381-ca58cecf3592");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("ad0e06d1-e441-4d55-acc5-9521da40d359");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("0b584cfb-776b-48e5-9a09-d7245dc74351");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("26bd9f25-0d50-4c47-829f-8b286576317c");
			if (column != null) {
				column.UId = new Guid("013c1577-1a0b-4e42-ba09-2e0ae2027212");
				column.Name = @"Object";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("382c1794-3e8d-4895-91ce-02c9f5e3553e");
			if (column != null) {
				column.UId = new Guid("83bb1c14-b21f-4d98-8654-9f08b94fda5f");
				column.Name = @"Recipient";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("085d7c7c-fdbc-443a-ad06-1f04ace34173");
			if (column != null) {
				column.UId = new Guid("13e1ace8-35ae-435a-be77-0b4cf1b65c37");
				column.Name = @"CopyRecipient";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("47e72ecd-b21c-4b09-933e-6c1263381425");
			if (column != null) {
				column.UId = new Guid("e6ec0e05-ec3e-412e-aa18-fd7cd7c22e2c");
				column.Name = @"BlindCopyRecipient";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2e7c35e3-0774-4a4a-bea5-6ce4c8de1465");
			if (column != null) {
				column.UId = new Guid("519e43d8-cd93-4768-a7f0-c52a9d8e380b");
				column.Name = @"Subject";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("feab52f3-9df5-4499-8425-855973838905");
			if (column != null) {
				column.UId = new Guid("5164a0a2-919e-4d66-8429-cfda729b917b");
				column.Name = @"Priority";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("54425b16-8b5b-40a1-baf1-3997560a6b0e");
			if (column != null) {
				column.UId = new Guid("939972bc-1e47-4169-b661-11be59da9d9d");
				column.Name = @"Body";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("698c2960-3832-4ba4-ad56-8a6489b32ad4");
			if (column != null) {
				column.UId = new Guid("a4ca7abe-17fa-4d1d-92e5-a5804762c3a3");
				column.Name = @"IsHtmlBody";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e6618002-83f7-419a-a866-63ea7599b123");
			if (column != null) {
				column.UId = new Guid("d53d0615-9a90-45da-b631-d4fb1505532f");
				column.Name = @"Macros";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("613d189f-c6a0-4ec4-b2b0-a43199cacef4");
			if (column != null) {
				column.UId = new Guid("701560e3-c666-4981-9adf-12a0af5a27f7");
				column.Name = @"SaveAsActivity";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b1b8aa8c-787f-42e0-8af1-603d1761f75a");
			if (column != null) {
				column.UId = new Guid("3873a1f8-cafe-46d2-8cd4-e8acfaf295a1");
				column.Name = @"ObjectFieldInActivity";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("aa4c5784-7f68-47d8-b7bb-ee3f89221ac8");
			if (column != null) {
				column.UId = new Guid("5f0ea661-d9ad-4a2e-b199-581344dd1078");
				column.Name = @"ShowBeforeSending";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cf75d513-0d42-439c-b19f-8c7fe4234460");
			if (column != null) {
				column.UId = new Guid("1b4d128e-94b5-40bb-aaae-abbd96fc9fda");
				column.Name = @"SendIndividualEmail";
				column.CreatedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
				column.ModifiedInSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
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
			return new EmailTemplateEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new EmailTemplateEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("709151d1-328a-4279-898a-b90fe94f0567"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new EmailTemplateEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateEditPageEventsProcess

	/// <exclude/>
	public class EmailTemplateEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseModuleEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.EmailTemplateEditPageSchemaUserControl
	{

		#region Class: RecipientGridPageUserTaskFlowElement

		/// <exclude/>
		public class RecipientGridPageUserTaskFlowElement : OpenPageUserTask
		{

			public RecipientGridPageUserTaskFlowElement(UserConnection userConnection, EmailTemplateEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "RecipientGridPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public EmailTemplateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplateEditPageEventsProcess";
			SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("709151d1-328a-4279-898a-b90fe94f0567");
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

		public virtual Object MacrosCollection {
			get;
			set;
		}

		public virtual string VirtualDataSourceID {
			get;
			set;
		}

		public virtual string CurrentObjectSchemaName {
			get;
			set;
		}

		public virtual Object ParentIdNameDictionary {
			get;
			set;
		}

		public virtual int CurrentMacrosIndex {
			get;
			set;
		}

		public virtual Guid CurrentObjectSchemaId {
			get;
			set;
		}

		public virtual string Recipient {
			get;
			set;
		}

		public virtual string CopyRecipient {
			get;
			set;
		}

		public virtual string BlindCopyRecipient {
			get;
			set;
		}

		public virtual bool IsMacrosCollectionChanged {
			get;
			set;
		}

		public virtual Guid ObjectFieldInActivityId {
			get;
			set;
		}

		public virtual string RecipientField {
			get;
			set;
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("53fdfd42-758c-41d1-9df9-750a68eea538"),
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
					SchemaElementUId = new Guid("159d3b7e-d185-4ab4-a0b5-e5f629a20127"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent ?? (_pageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("1394f79b-1c60-4251-9239-49dc74003edd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("7b3b06ba-3d5d-488f-b482-4759ae1397ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("a6ab53e9-9d16-4bdf-a754-a303a956735c"),
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
					SchemaElementUId = new Guid("2702f254-c422-4dca-890a-7194fdc644f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent {
			get {
				return _initIntermediateThrowMessageEvent ?? (_initIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("ad762440-ef8a-4fc2-be2b-8b0958b8e00e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("093a29b5-82c4-4b7a-bd83-f19d6919f499"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _setFieldsContactMenuItemClickEventSubProcess;
		public ProcessFlowElement SetFieldsContactMenuItemClickEventSubProcess {
			get {
				return _setFieldsContactMenuItemClickEventSubProcess ?? (_setFieldsContactMenuItemClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SetFieldsContactMenuItemClickEventSubProcess",
					SchemaElementUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _recipientMenuItemClickStartMessage;
		public ProcessFlowElement RecipientMenuItemClickStartMessage {
			get {
				return _recipientMenuItemClickStartMessage ?? (_recipientMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RecipientMenuItemClickStartMessage",
					SchemaElementUId = new Guid("6fe57dfa-429c-411a-8306-b47abdd8d520"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _recipientMenuItemClickScriptTask;
		public ProcessScriptTask RecipientMenuItemClickScriptTask {
			get {
				return _recipientMenuItemClickScriptTask ?? (_recipientMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RecipientMenuItemClickScriptTask",
					SchemaElementUId = new Guid("64ea04ae-380c-48f6-8b5c-afcbc280d591"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RecipientMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _currentUserMenuItemClickStartMessage;
		public ProcessFlowElement CurrentUserMenuItemClickStartMessage {
			get {
				return _currentUserMenuItemClickStartMessage ?? (_currentUserMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrentUserMenuItemClickStartMessage",
					SchemaElementUId = new Guid("295e5223-5f89-46c7-a11e-841c2b3e9517"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectMenuItemClickStartMessage;
		public ProcessFlowElement ObjectMenuItemClickStartMessage {
			get {
				return _objectMenuItemClickStartMessage ?? (_objectMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectMenuItemClickStartMessage",
					SchemaElementUId = new Guid("3f2ba4f1-9885-451e-bbdf-3181daad0368"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectMenuItemClickScriptTask;
		public ProcessScriptTask ObjectMenuItemClickScriptTask {
			get {
				return _objectMenuItemClickScriptTask ?? (_objectMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectMenuItemClickScriptTask",
					SchemaElementUId = new Guid("2fd0a662-c3b0-4795-9826-da10e07fd390"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _currentUserMenuItemClickScriptTask;
		public ProcessScriptTask CurrentUserMenuItemClickScriptTask {
			get {
				return _currentUserMenuItemClickScriptTask ?? (_currentUserMenuItemClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrentUserMenuItemClickScriptTask",
					SchemaElementUId = new Guid("224d0934-f990-495d-9ec4-aba6eb8fffb2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrentUserMenuItemClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _objectEditChangeEventSubProcess;
		public ProcessFlowElement ObjectEditChangeEventSubProcess {
			get {
				return _objectEditChangeEventSubProcess ?? (_objectEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ObjectEditChangeEventSubProcess",
					SchemaElementUId = new Guid("d15616b7-4fcd-4542-90e4-ff2480289361"),
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
					SchemaElementUId = new Guid("0abc0d55-6e57-47e8-b6d1-a9a77c55a929"),
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
					SchemaElementUId = new Guid("97c93d5b-2663-4986-a240-b1440b66b042"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _putTemplateToBodyButtonClickEventSubProcess;
		public ProcessFlowElement PutTemplateToBodyButtonClickEventSubProcess {
			get {
				return _putTemplateToBodyButtonClickEventSubProcess ?? (_putTemplateToBodyButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PutTemplateToBodyButtonClickEventSubProcess",
					SchemaElementUId = new Guid("bb856868-e36b-4020-a9ee-b307994e84e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _putTemplateToBodyButtonClickStartMessage;
		public ProcessFlowElement PutTemplateToBodyButtonClickStartMessage {
			get {
				return _putTemplateToBodyButtonClickStartMessage ?? (_putTemplateToBodyButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PutTemplateToBodyButtonClickStartMessage",
					SchemaElementUId = new Guid("255a7909-1f8d-40aa-8ab8-6ce80e5b7d7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _putTemplateToBodyButtonClickScriptTask;
		public ProcessScriptTask PutTemplateToBodyButtonClickScriptTask {
			get {
				return _putTemplateToBodyButtonClickScriptTask ?? (_putTemplateToBodyButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PutTemplateToBodyButtonClickScriptTask",
					SchemaElementUId = new Guid("6efb22f4-8824-4860-aa56-b8699155b574"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PutTemplateToBodyButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _macrosTreeGridDblClickStartMessage;
		public ProcessFlowElement MacrosTreeGridDblClickStartMessage {
			get {
				return _macrosTreeGridDblClickStartMessage ?? (_macrosTreeGridDblClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MacrosTreeGridDblClickStartMessage",
					SchemaElementUId = new Guid("b7fbffee-5f0a-413d-83d6-9cabf496b4d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickEventSubProcess;
		public ProcessFlowElement OKButtonClickEventSubProcess {
			get {
				return _oKButtonClickEventSubProcess ?? (_oKButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OKButtonClickEventSubProcess",
					SchemaElementUId = new Guid("b52a05f2-406a-478c-af14-90f5108c864f"),
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
					SchemaElementUId = new Guid("5ea94ec9-72c0-4dbf-a1cf-ac5d45e8b7bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _oKButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OKButtonClickIntermediateThrowMessageEvent {
			get {
				return _oKButtonClickIntermediateThrowMessageEvent ?? (_oKButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OKButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("1fce5211-23c0-49b5-9c0d-6ba346a3f2ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("b26ec7ad-b9a8-45f0-ae47-b0559c55ec3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OKButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRecipientToolButtonClickStartMessage;
		public ProcessFlowElement AddRecipientToolButtonClickStartMessage {
			get {
				return _addRecipientToolButtonClickStartMessage ?? (_addRecipientToolButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRecipientToolButtonClickStartMessage",
					SchemaElementUId = new Guid("d1962ed5-bb29-46e3-9a91-4215a23ada3f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addRecipientToolButtonClickScriptTask;
		public ProcessScriptTask AddRecipientToolButtonClickScriptTask {
			get {
				return _addRecipientToolButtonClickScriptTask ?? (_addRecipientToolButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddRecipientToolButtonClickScriptTask",
					SchemaElementUId = new Guid("d95e190d-8981-4624-a190-3ced39db60d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddRecipientToolButtonClickScriptTaskExecute,
				});
			}
		}

		private RecipientGridPageUserTaskFlowElement _recipientGridPageUserTask;
		public RecipientGridPageUserTaskFlowElement RecipientGridPageUserTask {
			get {
				return _recipientGridPageUserTask ?? (_recipientGridPageUserTask = new RecipientGridPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _changeEditValueScriptTask;
		public ProcessScriptTask ChangeEditValueScriptTask {
			get {
				return _changeEditValueScriptTask ?? (_changeEditValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEditValueScriptTask",
					SchemaElementUId = new Guid("e9d9cc5d-41d5-439c-bc37-240f893bde42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEditValueScriptTaskExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _recipientGridPageClosedCatchMessage;
		public ProcessIntermediateCatchMessageEvent RecipientGridPageClosedCatchMessage {
			get {
				return _recipientGridPageClosedCatchMessage ?? (_recipientGridPageClosedCatchMessage = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "RecipientGridPageClosedCatchMessage",
					SchemaElementUId = new Guid("679a8579-a3a3-4f6c-bc37-33bbd0c5d3e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "RecipientGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _beforeAddRecipientScriptTask;
		public ProcessScriptTask BeforeAddRecipientScriptTask {
			get {
				return _beforeAddRecipientScriptTask ?? (_beforeAddRecipientScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeAddRecipientScriptTask",
					SchemaElementUId = new Guid("2a92ea5e-f44d-4ee4-80b3-dbc3b971a57d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BeforeAddRecipientScriptTaskExecute,
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
					SchemaElementUId = new Guid("08818e31-eb6e-47e5-a4ec-e792d5718f47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _copyRecipientToolButtonClickStartMessage;
		public ProcessFlowElement CopyRecipientToolButtonClickStartMessage {
			get {
				return _copyRecipientToolButtonClickStartMessage ?? (_copyRecipientToolButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CopyRecipientToolButtonClickStartMessage",
					SchemaElementUId = new Guid("8612c260-356d-4108-9c11-54a8758cb28c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _copyRecipientToolButtonClickScriptTask;
		public ProcessScriptTask CopyRecipientToolButtonClickScriptTask {
			get {
				return _copyRecipientToolButtonClickScriptTask ?? (_copyRecipientToolButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CopyRecipientToolButtonClickScriptTask",
					SchemaElementUId = new Guid("d206f9da-8538-4791-b6a1-7d3856335096"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CopyRecipientToolButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("23a8a88a-f669-4920-942a-ed1102662084"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _blindCopyRecipientToolButtonClickStartMessage;
		public ProcessFlowElement BlindCopyRecipientToolButtonClickStartMessage {
			get {
				return _blindCopyRecipientToolButtonClickStartMessage ?? (_blindCopyRecipientToolButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BlindCopyRecipientToolButtonClickStartMessage",
					SchemaElementUId = new Guid("2ba49edb-9492-4527-8939-e95d5b79d7db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _blindCopyRecipientToolButtonClickScriptTask;
		public ProcessScriptTask BlindCopyRecipientToolButtonClickScriptTask {
			get {
				return _blindCopyRecipientToolButtonClickScriptTask ?? (_blindCopyRecipientToolButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BlindCopyRecipientToolButtonClickScriptTask",
					SchemaElementUId = new Guid("eb9ffe01-7645-439a-ab02-b7eb1f14d4fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BlindCopyRecipientToolButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("1c52e533-845b-4e92-87e0-2ee818e4bf4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _dataSourceBeforeSaveChildStartMessage;
		public ProcessFlowElement DataSourceBeforeSaveChildStartMessage {
			get {
				return _dataSourceBeforeSaveChildStartMessage ?? (_dataSourceBeforeSaveChildStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DataSourceBeforeSaveChildStartMessage",
					SchemaElementUId = new Guid("6446376c-e104-400b-bb94-fd35959bfc56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _dataSourceBeforeSaveChildScriptTask;
		public ProcessScriptTask DataSourceBeforeSaveChildScriptTask {
			get {
				return _dataSourceBeforeSaveChildScriptTask ?? (_dataSourceBeforeSaveChildScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceBeforeSaveChildScriptTask",
					SchemaElementUId = new Guid("e2f27939-e52f-48e6-9d79-ada565579a9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceBeforeSaveChildScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[SetFieldsContactMenuItemClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SetFieldsContactMenuItemClickEventSubProcess };
			FlowElements[RecipientMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RecipientMenuItemClickStartMessage };
			FlowElements[RecipientMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RecipientMenuItemClickScriptTask };
			FlowElements[CurrentUserMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrentUserMenuItemClickStartMessage };
			FlowElements[ObjectMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectMenuItemClickStartMessage };
			FlowElements[ObjectMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectMenuItemClickScriptTask };
			FlowElements[CurrentUserMenuItemClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrentUserMenuItemClickScriptTask };
			FlowElements[ObjectEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeEventSubProcess };
			FlowElements[ObjectEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeStartMessage };
			FlowElements[ObjectEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeScriptTask };
			FlowElements[PutTemplateToBodyButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PutTemplateToBodyButtonClickEventSubProcess };
			FlowElements[PutTemplateToBodyButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PutTemplateToBodyButtonClickStartMessage };
			FlowElements[PutTemplateToBodyButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PutTemplateToBodyButtonClickScriptTask };
			FlowElements[MacrosTreeGridDblClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MacrosTreeGridDblClickStartMessage };
			FlowElements[OKButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickEventSubProcess };
			FlowElements[OKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickStartMessage };
			FlowElements[OKButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickIntermediateThrowMessageEvent };
			FlowElements[OKButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[AddRecipientToolButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRecipientToolButtonClickStartMessage };
			FlowElements[AddRecipientToolButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRecipientToolButtonClickScriptTask };
			FlowElements[RecipientGridPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RecipientGridPageUserTask };
			FlowElements[ChangeEditValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEditValueScriptTask };
			FlowElements[RecipientGridPageClosedCatchMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RecipientGridPageClosedCatchMessage };
			FlowElements[BeforeAddRecipientScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeAddRecipientScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[CopyRecipientToolButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyRecipientToolButtonClickStartMessage };
			FlowElements[CopyRecipientToolButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyRecipientToolButtonClickScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[BlindCopyRecipientToolButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BlindCopyRecipientToolButtonClickStartMessage };
			FlowElements[BlindCopyRecipientToolButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BlindCopyRecipientToolButtonClickScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[DataSourceBeforeSaveChildStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeSaveChildStartMessage };
			FlowElements[DataSourceBeforeSaveChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceBeforeSaveChildScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "InitEventSubProcess":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "SetFieldsContactMenuItemClickEventSubProcess":
						break;
					case "RecipientMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("RecipientMenuItemClickScriptTask");
						break;
					case "RecipientMenuItemClickScriptTask":
						break;
					case "CurrentUserMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("CurrentUserMenuItemClickScriptTask");
						break;
					case "ObjectMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("ObjectMenuItemClickScriptTask");
						break;
					case "ObjectMenuItemClickScriptTask":
						break;
					case "CurrentUserMenuItemClickScriptTask":
						break;
					case "ObjectEditChangeEventSubProcess":
						break;
					case "ObjectEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ObjectEditChangeScriptTask");
						break;
					case "ObjectEditChangeScriptTask":
						break;
					case "PutTemplateToBodyButtonClickEventSubProcess":
						break;
					case "PutTemplateToBodyButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("PutTemplateToBodyButtonClickScriptTask");
						break;
					case "PutTemplateToBodyButtonClickScriptTask":
						break;
					case "MacrosTreeGridDblClickStartMessage":
						e.Context.QueueTasks.Enqueue("PutTemplateToBodyButtonClickScriptTask");
						break;
					case "OKButtonClickEventSubProcess":
						break;
					case "OKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OKButtonClickIntermediateThrowMessageEvent");
						break;
					case "OKButtonClickIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("OKButtonClickScriptTask");
						break;
					case "OKButtonClickScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "AddRecipientToolButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("BeforeAddRecipientScriptTask");
						break;
					case "AddRecipientToolButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("RecipientGridPageUserTask");
						break;
					case "RecipientGridPageUserTask":
						ActivatedEventElements.Add("RecipientGridPageClosedCatchMessage");
						break;
					case "ChangeEditValueScriptTask":
						break;
					case "RecipientGridPageClosedCatchMessage":
						e.Context.QueueTasks.Enqueue("ChangeEditValueScriptTask");
						break;
					case "BeforeAddRecipientScriptTask":
						e.Context.QueueTasks.Enqueue("AddRecipientToolButtonClickScriptTask");
						break;
					case "EventSubProcess5":
						break;
					case "CopyRecipientToolButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CopyRecipientToolButtonClickScriptTask");
						break;
					case "CopyRecipientToolButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("AddRecipientToolButtonClickScriptTask");
						break;
					case "EventSubProcess6":
						break;
					case "BlindCopyRecipientToolButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("BlindCopyRecipientToolButtonClickScriptTask");
						break;
					case "BlindCopyRecipientToolButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("AddRecipientToolButtonClickScriptTask");
						break;
					case "EventSubProcess8":
						break;
					case "DataSourceBeforeSaveChildStartMessage":
						e.Context.QueueTasks.Enqueue("DataSourceBeforeSaveChildScriptTask");
						break;
					case "DataSourceBeforeSaveChildScriptTask":
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
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("RecipientMenuItemClickStartMessage");
			ActivatedEventElements.Add("CurrentUserMenuItemClickStartMessage");
			ActivatedEventElements.Add("ObjectMenuItemClickStartMessage");
			ActivatedEventElements.Add("ObjectEditChangeStartMessage");
			ActivatedEventElements.Add("PutTemplateToBodyButtonClickStartMessage");
			ActivatedEventElements.Add("MacrosTreeGridDblClickStartMessage");
			ActivatedEventElements.Add("OKButtonClickStartMessage");
			ActivatedEventElements.Add("AddRecipientToolButtonClickStartMessage");
			ActivatedEventElements.Add("CopyRecipientToolButtonClickStartMessage");
			ActivatedEventElements.Add("BlindCopyRecipientToolButtonClickStartMessage");
			ActivatedEventElements.Add("DataSourceBeforeSaveChildStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "SetFieldsContactMenuItemClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "RecipientMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecipientMenuItemClickStartMessage";
					result = RecipientMenuItemClickStartMessage.Execute(context);
					break;
				case "RecipientMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecipientMenuItemClickScriptTask";
					result = RecipientMenuItemClickScriptTask.Execute(context, RecipientMenuItemClickScriptTaskExecute);
					break;
				case "CurrentUserMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrentUserMenuItemClickStartMessage";
					result = CurrentUserMenuItemClickStartMessage.Execute(context);
					break;
				case "ObjectMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectMenuItemClickStartMessage";
					result = ObjectMenuItemClickStartMessage.Execute(context);
					break;
				case "ObjectMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectMenuItemClickScriptTask";
					result = ObjectMenuItemClickScriptTask.Execute(context, ObjectMenuItemClickScriptTaskExecute);
					break;
				case "CurrentUserMenuItemClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrentUserMenuItemClickScriptTask";
					result = CurrentUserMenuItemClickScriptTask.Execute(context, CurrentUserMenuItemClickScriptTaskExecute);
					break;
				case "ObjectEditChangeEventSubProcess":
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
				case "PutTemplateToBodyButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PutTemplateToBodyButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PutTemplateToBodyButtonClickStartMessage";
					result = PutTemplateToBodyButtonClickStartMessage.Execute(context);
					break;
				case "PutTemplateToBodyButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PutTemplateToBodyButtonClickScriptTask";
					result = PutTemplateToBodyButtonClickScriptTask.Execute(context, PutTemplateToBodyButtonClickScriptTaskExecute);
					break;
				case "MacrosTreeGridDblClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MacrosTreeGridDblClickStartMessage";
					result = MacrosTreeGridDblClickStartMessage.Execute(context);
					break;
				case "OKButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickStartMessage";
					result = OKButtonClickStartMessage.Execute(context);
					break;
				case "OKButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = OKButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "OKButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickScriptTask";
					result = OKButtonClickScriptTask.Execute(context, OKButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "AddRecipientToolButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRecipientToolButtonClickStartMessage";
					result = AddRecipientToolButtonClickStartMessage.Execute(context);
					break;
				case "AddRecipientToolButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRecipientToolButtonClickScriptTask";
					result = AddRecipientToolButtonClickScriptTask.Execute(context, AddRecipientToolButtonClickScriptTaskExecute);
					break;
				case "RecipientGridPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecipientGridPageUserTask";
					result = RecipientGridPageUserTask.Execute(context);
					break;
				case "ChangeEditValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEditValueScriptTask";
					result = ChangeEditValueScriptTask.Execute(context, ChangeEditValueScriptTaskExecute);
					break;
				case "RecipientGridPageClosedCatchMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RecipientGridPageClosedCatchMessage";
					result = RecipientGridPageClosedCatchMessage.Execute(context);
					break;
				case "BeforeAddRecipientScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeAddRecipientScriptTask";
					result = BeforeAddRecipientScriptTask.Execute(context, BeforeAddRecipientScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "CopyRecipientToolButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CopyRecipientToolButtonClickStartMessage";
					result = CopyRecipientToolButtonClickStartMessage.Execute(context);
					break;
				case "CopyRecipientToolButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CopyRecipientToolButtonClickScriptTask";
					result = CopyRecipientToolButtonClickScriptTask.Execute(context, CopyRecipientToolButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "BlindCopyRecipientToolButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BlindCopyRecipientToolButtonClickStartMessage";
					result = BlindCopyRecipientToolButtonClickStartMessage.Execute(context);
					break;
				case "BlindCopyRecipientToolButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BlindCopyRecipientToolButtonClickScriptTask";
					result = BlindCopyRecipientToolButtonClickScriptTask.Execute(context, BlindCopyRecipientToolButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "DataSourceBeforeSaveChildStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeSaveChildStartMessage";
					result = DataSourceBeforeSaveChildStartMessage.Execute(context);
					break;
				case "DataSourceBeforeSaveChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceBeforeSaveChildScriptTask";
					result = DataSourceBeforeSaveChildScriptTask.Execute(context, DataSourceBeforeSaveChildScriptTaskExecute);
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
				case "RecipientField":
					RecipientField = reader.GetValue<System.String>();
				break;
				case "ObjectFieldInActivityId":
					ObjectFieldInActivityId = reader.GetValue<System.Guid>();
				break;
				case "IsMacrosCollectionChanged":
					IsMacrosCollectionChanged = reader.GetValue<System.Boolean>();
				break;
				case "BlindCopyRecipient":
					BlindCopyRecipient = reader.GetValue<System.String>();
				break;
				case "CopyRecipient":
					CopyRecipient = reader.GetValue<System.String>();
				break;
				case "Recipient":
					Recipient = reader.GetValue<System.String>();
				break;
				case "CurrentObjectSchemaId":
					CurrentObjectSchemaId = reader.GetValue<System.Guid>();
				break;
				case "CurrentMacrosIndex":
					CurrentMacrosIndex = reader.GetValue<System.Int32>();
				break;
				case "ParentIdNameDictionary":
					ParentIdNameDictionary = reader.GetSerializableObjectValue();
				break;
				case "CurrentObjectSchemaName":
					CurrentObjectSchemaName = reader.GetValue<System.String>();
				break;
				case "VirtualDataSourceID":
					VirtualDataSourceID = reader.GetValue<System.String>();
				break;
				case "MacrosCollection":
					MacrosCollection = reader.GetSerializableObjectValue();
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

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			RegisterObjectMenuItemStateScript();
			RegisterNameSubjectRelationScript();
			RegisterSaveAsActivityLogicScript();
			FillMenuPriority();
			OrderedDictionary macrosCollection = new OrderedDictionary();
			if (IsNew) {
				var parentIdNameDictionary = new Dictionary<Guid, string>();
				var contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");	
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmailTemplateMacros");
				esq.PrimaryQueryColumn.IsAlwaysSelect = true;
				esq.AddColumn("Name");
				esq.AddColumn("Parent").OrderByAsc(1);
				esq.AddColumn("ColumnPath");
				esq.AddColumn("Position").OrderByAsc(2);
				esq.Filters.Add(
					esq.CreateIsNullFilter("AccountCommunicationType")
				);
				var entityCollection = esq.GetEntityCollection(UserConnection);
				if (entityCollection.Count > 0) {
					var parentColumnValueName = esq.RootSchema.Columns.FindByName("Parent").ColumnValueName;
					foreach(var entity in entityCollection) {
						var path = entity.GetTypedColumnValue<string>("ColumnPath");
						var parentId = entity.GetTypedColumnValue<Guid>(parentColumnValueName);
						if (string.IsNullOrEmpty(path) && parentId != Guid.Empty) {
							continue;
						}
						if (parentId == Guid.Empty) {
							parentIdNameDictionary.Add(entity.PrimaryColumnValue, entity.PrimaryDisplayColumnValue);
							macrosCollection.Add(entity.PrimaryDisplayColumnValue, new JArray());
						} else {
							var name = entity.GetTypedColumnValue<string>("Name");
							var macros = new JObject();
							macros.Add(
								new JProperty(
									"caption", 
									name
								)
							);
							macros.Add(
								new JProperty(
									"metaPath", 
									contactSchema.GetSchemaColumnMetaPathByPath(path)
								)
							);
							(macrosCollection[parentIdNameDictionary[parentId]] as JArray).Add(macros);
						}
					}
				}
				MacrosCollection = macrosCollection;
				IsMacrosCollectionChanged = true;
				ParentIdNameDictionary = parentIdNameDictionary;
				LoadVirtualDataSourceRows(macrosCollection);
				SetPriorityValue("AB96FA02-7FE6-DF11-971B-001D60E938C6");//Normal
			} else {
				var activeRow = IsCopy ? Page.DataSource.Rows[0] : Page.DataSource.ActiveRow;	
				var macrosBytes = activeRow.GetBytesValue("Macros");
				var deserializedList = Json.Deserialize<List<DictionaryEntry>>(
					System.Text.Encoding.UTF8.GetString(macrosBytes)
				);
				foreach(var item in deserializedList) {
					macrosCollection.Add(item.Key, item.Value);
				}
				LoadVirtualDataSourceRows(macrosCollection);
				if (macrosCollection.Count == 3) {
					var objectSchemaColumn = activeRow.Schema.Columns.FindByName("Object");
					var objectId = activeRow.GetTypedColumnValue<Guid>(objectSchemaColumn.ColumnValueName);
					var objectCaption = activeRow.GetTypedColumnValue<string>(objectSchemaColumn.DisplayColumnValueName);
					Page.ObjectMenuItem.Caption = objectCaption;
					Page.ObjectMenuItem.Hidden = false;
					CurrentObjectSchemaId = objectId;
					CurrentObjectSchemaName = objectCaption;
				}
				MacrosCollection = macrosCollection;
				if (IsCopy) {
					IsMacrosCollectionChanged = true;
				}
				var recipientBytes = activeRow.GetBytesValue("Recipient");
				var recipient = Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(recipientBytes));
				Page.RecipientEdit.SuspendAjaxEvents();
				Page.RecipientEdit.SetValue(GetDisplayValues(recipient));
				Page.RecipientEdit.ResumeAjaxEvents();
				var copyRecipientBytes = activeRow.GetBytesValue("CopyRecipient");
				var copyRecipient = Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(copyRecipientBytes));
				Page.CopyRecipientEdit.SuspendAjaxEvents();
				Page.CopyRecipientEdit.SetValue(GetDisplayValues(copyRecipient));
				Page.CopyRecipientEdit.ResumeAjaxEvents();
				var blindCopyRecipientBytes = activeRow.GetBytesValue("BlindCopyRecipient");
				var blindCopyRecipient = Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(blindCopyRecipientBytes));
				Page.BlindCopyRecipientEdit.SuspendAjaxEvents();
				Page.BlindCopyRecipientEdit.SetValue(GetDisplayValues(blindCopyRecipient));
				Page.BlindCopyRecipientEdit.ResumeAjaxEvents();
				if (!IsCopy) {
					Recipient = recipient;
					CopyRecipient = copyRecipient;
					BlindCopyRecipient = blindCopyRecipient;
				}
				var saveAsActivity = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("SaveAsActivity");
				if (saveAsActivity) {
					Page.ObjectFieldInActivityEdit.Enable();
					//Page.ShowBeforeSendingEdit.Enable();
				}
				AddtObjectFieldInActivityValues(CurrentObjectSchemaId);
				var selectedColumnId = activeRow.GetTypedColumnValue<Guid>("ObjectFieldInActivity");
				if (selectedColumnId != Guid.Empty) {
					var activitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("Activity");		
					var activityColumn = activitySchema.Columns.FindByUId(selectedColumnId);
					Page.ObjectFieldInActivityEdit.SetValueAndText(activityColumn.UId, activityColumn.Caption);
					Page.ObjectFieldInActivityEdit.ListPrepared = true;	
					ObjectFieldInActivityId = selectedColumnId;
				}
				SetPriorityValue(activeRow.GetTypedColumnValue<Guid>("PriorityId").ToString());
			}
			var menuItemClickHandlerScript = string.Format(
				@"{0}.customMenuItemClickHandler = function(){{
					{1}.setValue({1}.getValue() + '[#' + this.parentMenu.owner.caption + '.' + this.caption + '#]');
				}}",
				Page.AddMacrosToolButton.ClientID,
				Page.SubjectEdit.ClientID
			);
			Page.ScriptManager.AddScript(menuItemClickHandlerScript);
			string setReadOnlyScript = string.Format(
				@"{0}.setReadOnly('true'); {1}.setReadOnly('true'); {2}.setReadOnly('true');",
				Page.RecipientEdit.ClientID,
				Page.CopyRecipientEdit.ClientID,
				Page.BlindCopyRecipientEdit.ClientID
			);
			Page.ScriptManager.AddScript(setReadOnlyScript);
			
			Terrasoft.Configuration.HtmlEditHelper.RegisterDetailAddImageScript(UserConnection, Page.BodyEdit);
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			if (ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			Page.ObjectEdit.PrepareLookupFilter += PrepareObjectEditFilter;
			if (Ext.IsAjaxRequest) {
				FillMenuPriority();
			}
			VirtualDataSourceID = "MacrosVirtualDataSource";
			var virtualDataSource = new VirtualDataSource() {
				ID = VirtualDataSourceID
			};
			Page.PageContainer.Controls.Add(virtualDataSource);
			Page.MacrosTreeGrid.DataSourceId = virtualDataSource.ID;
			DataSourceStructure defStructure = virtualDataSource.DefStructure;
			defStructure.PrimaryColumnName = "Id";
			defStructure.PrimaryDisplayColumnName = "Name";
			var dataValueTypeManager = (DataValueTypeManager)
				Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			var column = new DataSourceStructureColumn {
				Name = "Id",
				ValueColumnName = "Id",
				DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
				Caption = "Id",
				IsVisible = false,
				IsSortable = false
			};
			defStructure.AddColumn(column);
			column = new DataSourceStructureColumn {
				Name = "Name",
				ValueColumnName = "Name",
				DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
				Caption = "Name",
				IsVisible = true,
				IsSortable = false
			};
			defStructure.AddColumn(column);
			column = new DataSourceStructureColumn {
				Name = "ParentId",
				ValueColumnName = "ParentId",
				DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
				Caption = "ParentId",
				IsVisible = false,
				IsSortable = false
			};
			defStructure.AddColumn(column);
			defStructure.IsHierarchical = true;
			defStructure.HierarchicalColumnName = "ParentId";	
			virtualDataSource.Loaded += Page.MacrosTreeGrid.DataLoaded;
			Page.MacrosTreeGrid.GetRowConfigHandler +=
			delegate(Terrasoft.Core.Entities.Entity row) {
				string primaryColumnName = row.Schema.PrimaryColumn.Name;
				string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
				var config = new DataSourceRowConfig(primaryColumnValue);
				if (row.GetTypedColumnValue<Guid>("ParentId") != null) {
					config.AddConfig(new DataSourceRowIsExpandableConfigValue(false));
				}
				return config;
			};
			Page.DataSource.BeforeSaveRow += delegate(object sender, DataSourceEventArgs e) {
				SetEntityBinaryColumnValues(e.Row);
				ResetCache();
			};
			
			Page.AddMacrosToolButton.AjaxEvents.Click.Event += delegate(object sender, AjaxEventArgs e) {
				var macrosCollection = MacrosCollection as OrderedDictionary;
				if (macrosCollection != null) {
					foreach(var macrosGroup in macrosCollection) {
						var rootMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
						rootMenuItem.CreatedByAjax = true;
						rootMenuItem.Caption = ((DictionaryEntry)macrosGroup).Key.ToString();
						rootMenuItem.ID = string.Format("{0}_{1}", Page.AddMacrosToolButton.ClientID, Guid.NewGuid().ToString("N"));
						rootMenuItem.Page = (Page.AspPage as System.Web.UI.Page);
						Page.AddMacrosToolButton.Menu.AddCaptionItem(rootMenuItem);		
						foreach(var macros in ((DictionaryEntry)macrosGroup).Value as JArray) {
							var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
							menuItem.CreatedByAjax = true;
							menuItem.Caption = macros["caption"].ToString();
							menuItem.ID = string.Format("{0}_{1}", rootMenuItem.ID, Guid.NewGuid().ToString("N"));
							rootMenuItem.Menu.AddCaptionItem(menuItem);
							var menuItemClickScript = string.Format(
								@"{0}.on('click', {1}.customMenuItemClickHandler);",
								menuItem.ClientID,
								Page.AddMacrosToolButton.ClientID
							);
							Page.ScriptManager.AddScript(menuItemClickScript);
						}
					}
				}
				var showMenuScript = string.Format("{0}.menu.show({0}.el, {0}.menuAlign);", Page.AddMacrosToolButton.ClientID);
				Page.ScriptManager.AddScript(showMenuScript);
			};
			var removeMenuScript = string.Format("if ({0}.menu){{{0}.menu.destroy();{0}.menu = null;}}", Page.AddMacrosToolButton.ClientID);
			Page.ScriptManager.AddScript(removeMenuScript);
			Page.BodyEdit.AjaxEvents.ImageLoaded.Event += (sender, e) => {
				EntitySchemaManager esm = UserConnection.EntitySchemaManager;
				var entitySchema = esm.FindInstanceByUId(Page.DataSource.SchemaUId);
				if (entitySchema == null) {
					return;
				}
				Terrasoft.Configuration.HtmlEditHelper.SaveAndInsertImage(UserConnection, Page.BodyEdit, entitySchema, Page.DataSource.ActiveRowPrimaryColumnValue);
			};
			return true;
		}

		public virtual bool RecipientMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			var schemaId = UserConnection.EntitySchemaManager.GetInstanceByName("Contact").UId;
			CurrentMacrosIndex = 0;
			ShowColumnStructureExplorer(schemaId, CurrentMacrosIndex);
			return true;
		}

		public virtual bool ObjectMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			CurrentMacrosIndex = 2;
			ShowColumnStructureExplorer(CurrentObjectSchemaId, CurrentMacrosIndex);
			return true;
		}

		public virtual bool CurrentUserMenuItemClickScriptTaskExecute(ProcessExecutingContext context) {
			var schemaId = UserConnection.EntitySchemaManager.GetInstanceByName("Contact").UId;
			CurrentMacrosIndex = 1;
			ShowColumnStructureExplorer(schemaId, CurrentMacrosIndex);
			return true;
		}

		public virtual bool ObjectEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var entity = Page.DataSource.ActiveRow;
			var objectSchemaColumn = entity.Schema.Columns.FindByName("Object");
			var objectId = entity.GetTypedColumnValue<Guid>(objectSchemaColumn.ColumnValueName);
			var macrosCollection = MacrosCollection as OrderedDictionary;
			var parentIdNameDictionary = ParentIdNameDictionary as Dictionary<Guid, string>;
			if (!string.IsNullOrEmpty(CurrentObjectSchemaName)) {
				macrosCollection.Remove(CurrentObjectSchemaName);
				if (parentIdNameDictionary.ContainsValue(CurrentObjectSchemaName)) {
					parentIdNameDictionary.Remove(
						parentIdNameDictionary.First(item => item.Value == CurrentObjectSchemaName).Key);
				}
			}
			if (objectId != Guid.Empty) {
				var objectName = entity.GetTypedColumnValue<string>(objectSchemaColumn.DisplayColumnValueName);
				var schemaId = objectId;
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(schemaId);
				macrosCollection.Add(entitySchema.Caption, new JArray());
				if (entitySchema.PrimaryDisplayColumn != null) {
					var macros = new JObject();
					macros.Add(
						new JProperty(
							"caption", 
							GetColumnCaptionByName(entitySchema, entitySchema.PrimaryDisplayColumn.Name)	
						)
					);
					macros.Add(
						new JProperty(
							"name", 
							entitySchema.PrimaryDisplayColumn.Name	
						)
					);
					macros.Add(
						new JProperty(
							"metaPath", 
							entitySchema.GetSchemaColumnMetaPathByPath(entitySchema.PrimaryDisplayColumn.Name)
						)
					);
					(macrosCollection[entitySchema.Caption] as JArray).Add(macros);
				}
				CurrentObjectSchemaName = objectName;
				CurrentObjectSchemaId = schemaId;
				AddtObjectFieldInActivityValues(schemaId);
			} else {
				Page.ObjectFieldInActivityEdit.ClearItems();
				Page.ObjectFieldInActivityEdit.SuspendAjaxEvents();
				Page.ObjectFieldInActivityEdit.Clear();
				Page.ObjectFieldInActivityEdit.ResumeAjaxEvents();
				Page.ObjectFieldInActivityEdit.Disable();
				Page.SaveAsActivityEdit.Checked = false;
				CurrentObjectSchemaName = string.Empty;
				CurrentObjectSchemaId = Guid.Empty;
			}
			LoadVirtualDataSourceRows(macrosCollection);
			return true;
		}

		public virtual bool PutTemplateToBodyButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.MacrosTreeGrid.SelectedNodes;
			if (selectedNodes.Count > 0) {
				if (!selectedNodes[0].Values.ContainsKey("ParentId")) {
					return true;
				}
				var parentIdNameDictionary = ParentIdNameDictionary as Dictionary<Guid, string>;
				var parentId = new Guid(selectedNodes[0].Values["ParentId"].ToString());
				Page.BodyEdit.InsertText(
					string.Format("[#{0}.{1}#]", parentIdNameDictionary[parentId], selectedNodes[0].Values["Name"])
				);
			}
			return true;
		}

		public virtual bool OKButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var activeRow = Page.DataSource.ActiveRow;
			if (!Page.DataSource.ActiveRowModified && 
					(IsMacrosCollectionChanged ||
					(Page.RecipientEdit.Text != GetDisplayValues(Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(activeRow.GetBytesValue("Recipient"))))) ||
					(Page.CopyRecipientEdit.Text != GetDisplayValues(Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(activeRow.GetBytesValue("CopyRecipient"))))) ||
					(Page.BlindCopyRecipientEdit.Text != GetDisplayValues(Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(activeRow.GetBytesValue("BlindCopyRecipient"))))) ||
					((Guid)Page.ObjectFieldInActivityEdit.Value != ObjectFieldInActivityId))) {
				SetEntityBinaryColumnValues(activeRow);
				activeRow.Save();
				IsMacrosCollectionChanged = false;
				ResetCache();
			}
			return true;
		}

		public virtual bool AddRecipientToolButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var openProcessKey =((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + Page.PageContainer.UniqueID;
			if (RecipientField == "Recipient") {
				Page.UserConnection.SessionData["Recipient"] = Recipient;
			}
			else if(RecipientField == "CopyRecipient") {
				Page.UserConnection.SessionData["Recipient"] = CopyRecipient;
			}
			else if(RecipientField == "BlindCopyRecipient") {
				Page.UserConnection.SessionData["Recipient"] = BlindCopyRecipient;
			}
			RecipientGridPageUserTask.OpenerInstanceId = Page.Process.InstanceUId;
			RecipientGridPageUserTask.UseCurrentActivePage = true;
			RecipientGridPageUserTask.PageUId = new Guid("0BE0F461-BB76-4B56-85E4-D3BE9170DBBE");
			Dictionary <string, string> parameters = new Dictionary <string, string>() {
				{"openProcessKey", openProcessKey},
				{"customClosedEvent", "RecipientGridPageClosed"},
				{"objectUId", Page.ObjectEdit.Value.ToString()}
			};
			RecipientGridPageUserTask.PageParameters = parameters;
			RecipientGridPageUserTask.Centered = true;
			RecipientGridPageUserTask.CloseOpenerOnLoad = false;
			return true;
		}

		public virtual bool ChangeEditValueScriptTaskExecute(ProcessExecutingContext context) {
			if (RecipientField == "Recipient") {
				Recipient = Page.UserConnection.SessionData["Recipient"] as string;
				string setValueScript = string.Format(@"{0}.setValue('{1}');",Page.RecipientEdit.ClientID, GetDisplayValues(Recipient));
				Page.ScriptManager.AddScript(setValueScript);
			}
			else if(RecipientField == "CopyRecipient") {
				CopyRecipient = Page.UserConnection.SessionData["Recipient"] as string;
				string setValueScript = string.Format(@"{0}.setValue('{1}');",Page.CopyRecipientEdit.ClientID, GetDisplayValues(CopyRecipient));
				Page.ScriptManager.AddScript(setValueScript);
			}
			else if(RecipientField == "BlindCopyRecipient") {
				BlindCopyRecipient = Page.UserConnection.SessionData["Recipient"] as string;
				string setValueScript = string.Format(@"{0}.setValue('{1}');",Page.BlindCopyRecipientEdit.ClientID, GetDisplayValues(BlindCopyRecipient));
				Page.ScriptManager.AddScript(setValueScript);
			}
			return true;
		}

		public virtual bool BeforeAddRecipientScriptTaskExecute(ProcessExecutingContext context) {
			RecipientField = "Recipient";
			return true;
		}

		public virtual bool CopyRecipientToolButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			RecipientField = "CopyRecipient";
			return true;
		}

		public virtual bool BlindCopyRecipientToolButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			RecipientField = "BlindCopyRecipient";
			return true;
		}

		public virtual bool DataSourceBeforeSaveChildScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.BodyEdit.Mode ==  TSWebControls.Controls.HtmlEditMode.FormatedTextEditMode)
				Page.DataSource.ActiveRow.SetColumnValue("IsHtmlBody", true);
			else
				Page.DataSource.ActiveRow.SetColumnValue("IsHtmlBody", false);
			return true;
		}

		public override void DataSourceSavedMethod(object context) {
			base.DataSourceSavedMethod(context);
			IsMacrosCollectionChanged = false;
		}

		public virtual void ShowColumnStructureExplorer(Guid entitySchemaUId, int macrosIndex) {
			if (!ColumnStructureExplorerCreated) {
				CreateColumnStructureExplorer();
			}
			var sructureExplorer = (StructureExplorer) ColumnStructureExplorer;
			if (sructureExplorer == null) {
				return;
			}
			//CurrentMacrosGroup = macrosGroupName;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
			sructureExplorer.ManagerName = entitySchemaManager.Name;
			var macrosCollection = MacrosCollection as OrderedDictionary;
			var macros = macrosCollection[macrosIndex] as JArray;
			var dataSourceStructureColumnCollection = new DataSourceStructureColumnCollection();		
			for (int i = 0; i < macros.Count; i++) {
				var dataSourceStructureColumn = new DataSourceStructureColumn();
				dataSourceStructureColumn.UId = string.IsNullOrEmpty(macros[i].Value<string>("columnUId")) ? Guid.NewGuid() : new Guid(macros[i].Value<string>("columnUId"));
				dataSourceStructureColumn.MetaPath = macros[i].Value<string>("metaPath");
				dataSourceStructureColumn.Name = schema.GetSchemaColumnPathByMetaPath(dataSourceStructureColumn.MetaPath);
				dataSourceStructureColumn.Caption = macros[i].Value<string>("caption");
				dataSourceStructureColumn.MetaPathCaption = macros[i].Value<string>("metaPathCaption");
				dataSourceStructureColumn.DataValueType = schema.FindSchemaColumnByMetaPath(dataSourceStructureColumn.MetaPath).DataValueType;
				if (!string.IsNullOrEmpty(macros[i].Value<string>("aggregationType"))
						&& string.Compare(macros[i].Value<string>("aggregationType"), "None", true) != 0) {
					dataSourceStructureColumn.AggregationType = (AggregationType)Enum.Parse(typeof(AggregationType),
						macros[i].Value<string>("aggregationType"));
					if (dataSourceStructureColumn.AggregationType == AggregationType.Count) {
						DataValueTypeManager dataValueTypeManager = dataSourceStructureColumn.DataValueType.DataValueTypeManager;
						dataSourceStructureColumn.DataValueType = dataValueTypeManager.GetInstanceByName("Integer");
					}	
					if (!string.IsNullOrEmpty(macros[i].Value<string>("subFilters"))) {
						dataSourceStructureColumn.SubFilters =  macros[i].Value<string>("subFilters");
					}
				}
				dataSourceStructureColumnCollection.Add(dataSourceStructureColumn);
			}
			sructureExplorer.Columns = dataSourceStructureColumnCollection;		
			sructureExplorer.ShowEditWindow(schema, null);
		}

		public virtual void CreateColumnStructureExplorer() {
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);	
			var structureExplorer = new StructureExplorer(Page.ObjectEdit, "columns", true, false, string.Empty);
			structureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			structureExplorer.IsShowSystemColumns = true;
			structureExplorer.IsShowOppositeReference = true;
			
			ComponentAjaxEvent editComplete = structureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += new AjaxEventHandler(SetMetaPathInfo);
			editComplete.ExtraParameters.Add(param);
			
			structureExplorer.Columns = new DataSourceStructureColumnCollection();
			
			ColumnStructureExplorerCreated = true;
			if (!ColumnStructureExplorerRegistered) {
				structureExplorer.Register();
				ColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = structureExplorer;
		}

		public virtual void SetMetaPathInfo(object sender, AjaxEventArgs e) {
			var macros = Json.Deserialize(e.ExtraParameters["itemsInfo"]) as JArray;
			var macrosCollection = MacrosCollection as OrderedDictionary;
			if (macrosCollection[CurrentMacrosIndex].ToString() != macros.ToString()) {
				macrosCollection[CurrentMacrosIndex] = macros;
				IsMacrosCollectionChanged = true;
				LoadVirtualDataSourceRows(macrosCollection);
			}
		}

		public virtual VirtualDataSource GetVirtualDataSource() {
			return Page.PageContainer.FindPageControl(VirtualDataSourceID) as VirtualDataSource;
		}

		public virtual void RegisterObjectMenuItemStateScript() {
			var script = string.Format(
				@"{0}.on(
					'change', 
					function(){{
						if ({0}.getValue() != '') {{
							{1}.setCaption({0}.text);
							if ({1}.hidden) {{
								{1}.show();
							}}
						}} else {{
							{1}.hide();
						}}
					}}
				);",
				Page.ObjectEdit.ClientID,
				Page.ObjectMenuItem.ClientID
			);
			Page.ScriptManager.AddScript(script);
		}

		public virtual void LoadVirtualDataSourceRows(OrderedDictionary macrosCollection) {
			Page.MacrosTreeGrid.Clear();
			var virtualDataSource = Page.PageContainer.FindPageControl(VirtualDataSourceID) as VirtualDataSource;
			virtualDataSource.Clear();
			var parentIdNameDictionary = new Dictionary<Guid, string>();
			foreach(var macrosGroup in macrosCollection) {
				var row = virtualDataSource.CreateRow();
				var parentId = Guid.NewGuid();
				row.SetColumnValue("Id", parentId);
				row.SetColumnValue("Name", ((DictionaryEntry)macrosGroup).Key);
				row.SetColumnValue("ParentId", null);
				virtualDataSource.Add(row);
				parentIdNameDictionary[parentId] = ((DictionaryEntry)macrosGroup).Key.ToString();
				foreach(var macros in ((DictionaryEntry)macrosGroup).Value as JArray) {
					row = virtualDataSource.CreateRow();
					row.SetColumnValue("Id", Guid.NewGuid());
					row.SetColumnValue("Name", macros["caption"]);
					row.SetColumnValue("ParentId", parentId);
					virtualDataSource.Add(row);
				}
			}
			virtualDataSource.LoadRows();
			ParentIdNameDictionary = parentIdNameDictionary;
		}

		public virtual Guid GetCurrentObjectSchemaId(Guid objectId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "VwSysSchemaInWorkspace");
			esq.AddColumn("UId");
			var schemaEntity = esq.GetEntity(UserConnection, objectId);
			var sysSchemaColumn = schemaEntity.Schema.Columns.FindByName("UId");
			var schemaId =  schemaEntity.GetTypedColumnValue<Guid>(sysSchemaColumn.ColumnValueName);
			return schemaId;
		}

		public virtual void SetEntityBinaryColumnValues(Entity entity) {
			entity.SetBytesValue("Recipient", System.Text.Encoding.UTF8.GetBytes(Json.Serialize(Recipient)));
			entity.SetBytesValue("CopyRecipient", System.Text.Encoding.UTF8.GetBytes(Json.Serialize(CopyRecipient)));
			entity.SetBytesValue("BlindCopyRecipient", System.Text.Encoding.UTF8.GetBytes(Json.Serialize(BlindCopyRecipient)));
			if (IsMacrosCollectionChanged) {
				var macrosCollection = MacrosCollection as OrderedDictionary;
				var serializationList = new List<DictionaryEntry>();
				foreach(var item in macrosCollection) {
					serializationList.Add((DictionaryEntry)item);
				}
				entity.SetBytesValue(
					"Macros", 
					System.Text.Encoding.UTF8.GetBytes(Json.Serialize(serializationList))
				);
			}
			var objectFieldInActivityId = Page.DataSource.ActiveRow.GetTypedColumnValue<Guid>("ObjectFieldInActivity");
			if (objectFieldInActivityId != (Guid)Page.ObjectFieldInActivityEdit.Value) {
				Page.DataSource.ActiveRow.SetColumnValue("ObjectFieldInActivity", (Guid)Page.ObjectFieldInActivityEdit.Value);
			}
		}

		public virtual void RegisterNameSubjectRelationScript() {
			var script = string.Format(
				@"{0}.on(
					'change', 
					function() {{
						if ({0}.getValue() != '' && 
								{1}.getValue() == '') {{
							{1}.setValue({0}.getValue());
						}}
					}}
				);",
				Page.NameEdit.ClientID,
				Page.SubjectEdit.ClientID
			);
			Page.ScriptManager.AddScript(script);
		}

		public virtual void RegisterSaveAsActivityLogicScript() {
			var script = string.Format(
				@"{0}.on(
					'check', 
					function(){{
						if ({0}.checked == true) {{
							if ({1}.store.getCount() > 0) {{
								{1}.enable();
								if ({1}.store.getCount() == 1) {{
									{1}.setValueAndText({1}.store.getAt(0).data.value, {1}.store.getAt(0).data.text);
								}}
							}}
							{2}.enable();
						}} else {{
							{1}.disable();
							{1}.setValueAndText('', '');
							{2}.disable();
							{2}.setChecked(false);
						}}
					}}
				);",
				Page.SaveAsActivityEdit.ClientID,
				Page.ObjectFieldInActivityEdit.ClientID,
				Page.ShowBeforeSendingEdit.ClientID
			);
			Page.ScriptManager.AddScript(script);
		}

		public virtual void AddtObjectFieldInActivityValues(Guid schemaId) {
			Page.ObjectFieldInActivityEdit.ClearItems();
			var activitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("Activity");
			int columnsNumber = 0;
			var firstColumnId = Guid.Empty;
			var firstCaption = string.Empty;
			foreach(var column in activitySchema.Columns) {
				if (column.ReferenceSchemaUId == schemaId) {
					Page.ObjectFieldInActivityEdit.AddItem(column.UId, column.Caption);
					columnsNumber++;
				}
			}
			var saveAsActivity = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("SaveAsActivity");
			if (saveAsActivity) {
				if (columnsNumber == 1) {
					Page.ObjectFieldInActivityEdit.SuspendAjaxEvents();
					Page.ObjectFieldInActivityEdit.SetValueAndText(firstColumnId, firstCaption);
					Page.ObjectFieldInActivityEdit.ResumeAjaxEvents();
				}
				if (columnsNumber > 0 && !Page.ObjectFieldInActivityEdit.Enabled) {
					Page.ObjectFieldInActivityEdit.Enable();
				}
			}
			if (columnsNumber > 0) {
				Page.ObjectFieldInActivityEdit.ListPrepared = true;	
			}
		}

		public virtual void ResetCache() {
			UserConnection.SessionCache.ExpireGroup(TSConfiguration.CacheUtilities.EmailTemplateCacheGroup);
		}

		public virtual string GetColumnCaptionByName(EntitySchema schema, string name) {
			var columns = schema.Columns;
			foreach (var column in columns) {
				if (column.Name == name) {
					return column.Caption;
				}
			}
			
			return string.Empty;
		}

		public virtual string GetDisplayValues(string encoded) {
			var list = Terrasoft.Configuration.EmailTemplateUtility.DecodeRecipientString(encoded);
			StringBuilder sb = new StringBuilder();
			foreach (var tuple in list) {
				sb.Append(tuple.Item3);
				sb.Append("; ");
			}
			return sb.ToString();
		}

		public virtual void FillMenuPriority() {
			var activityPriorityESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityPriority");
			var idColumn = activityPriorityESQ.AddColumn("Id");
			var nameColumn = activityPriorityESQ.AddColumn("Name"); 
			var priorityCollection = activityPriorityESQ.GetEntityCollection(UserConnection);
			
			var button = Page.PriorityButton;
			var menu = button.Menu;
			menu.RemoveAll();
			string menuScript = string.Empty;
			var imageColumnUId = activityPriorityESQ.RootSchema.Columns.GetByName("Img").UId;
			var schemaUId = activityPriorityESQ.RootSchema.UId;
			foreach(var priority in priorityCollection) {
				var priorityId = priority.GetTypedColumnValue<Guid>(idColumn.Name);
				var priorityCaption = priority.GetTypedColumnValue<string>(nameColumn.Name);;
				var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
				menuItem.Image = new ControlImage() {
					Source = ControlImageSource.EntityColumn,
					SchemaUId = schemaUId,
					EntityPrimaryColumnValue = priorityId,
					UsePrimaryImageColumn = false,
					EntitySchemaColumnUId = imageColumnUId							
				};
				menuItem.CreatedByAjax = Ext.IsAjaxRequest;
				menuItem.UId = Guid.NewGuid();
				menuItem.Name = string.Format("{0}_priority_{1}",button.ClientID, priorityId.ToString("N"));
				menuItem.Tag = priorityId.ToString();
				menuItem.Caption = priorityCaption;
				menuItem.AjaxEvents.Click.Event += delegate(object sender, Terrasoft.UI.WebControls.Controls.AjaxEventArgs e){
					var currentMenuItem = sender as Terrasoft.UI.WebControls.Controls.MenuItem;
					var parentItem = currentMenuItem.Parent as Terrasoft.UI.WebControls.Controls.Button; 
					if (parentItem.Menu.Count == 0) {
						return;
					}
					parentItem.Image = currentMenuItem.Image; 
					var dataSource = Page.DataSource as DataSource;
					if (dataSource == null)
						return;
					dataSource.ActiveRow.SetColumnValue("PriorityId", new Guid (currentMenuItem.Tag));
				};
				menu.Add(menuItem);
				menuScript = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
				menuScript += string.Format("{0}.getMenu().addItem(window.{1});\n", button.ClientID, menuItem.ClientID);
				Page.AddScript(menuScript);
			}
		}

		public virtual void SetPriorityValue(string guidStr) {
			if (guidStr == Guid.Empty.ToString())
				return;
			var button = Page.PriorityButton;
			var menu = button.Menu;
			foreach (var menuItem in menu) {
				if (string.Equals(menuItem.Tag, guidStr, StringComparison.CurrentCultureIgnoreCase)) {
					var dataSource = Page.DataSource as DataSource;
					if (dataSource == null)
						return;
					dataSource.ActiveRow.SetColumnValue("PriorityId", new Guid (menuItem.Tag));
					button.Image = menuItem.Image;
				}
			}
		}

		public virtual void PrepareObjectEditFilter(object sender, LookupEditEventArgs e) {
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleEntity");
			var sysSchemaIdColumn = entitySchemaQuery.AddColumn("SysEntitySchemaUId");
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			object[] ids;
			if (entities.Count > 0) {
				ids = new object[entities.Count];
			} else {
				ids = new object[] {Guid.Empty};
			}
			for (int i = 0; i < entities.Count; i++) {
				ids[i] = entities[i].GetTypedColumnValue<Guid>(sysSchemaIdColumn.Name);
			}
			
			var filters = e.Filters;
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.Equal}, 
				{"leftExpressionColumnPath", "Id"}, 
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", ids}});
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "RecipientMenuItemClick":
							if (ActivatedEventElements.Contains("RecipientMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("RecipientMenuItemClickStartMessage");
						}
						break;
					case "CurrentUserMenuItemClick":
							if (ActivatedEventElements.Contains("CurrentUserMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("CurrentUserMenuItemClickStartMessage");
						}
						break;
					case "ObjectMenuItemClick":
							if (ActivatedEventElements.Contains("ObjectMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("ObjectMenuItemClickStartMessage");
						}
						break;
					case "ObjectEditChange":
							if (ActivatedEventElements.Contains("ObjectEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ObjectEditChangeStartMessage");
						}
						break;
					case "PutTemplateToBodyButtonClick":
							if (ActivatedEventElements.Contains("PutTemplateToBodyButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("PutTemplateToBodyButtonClickStartMessage");
						}
						break;
					case "MacrosTreeGridDblClick":
							if (ActivatedEventElements.Contains("MacrosTreeGridDblClickStartMessage")) {
							context.QueueTasks.Enqueue("MacrosTreeGridDblClickStartMessage");
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "AddRecipientToolButtonClick":
							if (ActivatedEventElements.Contains("AddRecipientToolButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("AddRecipientToolButtonClickStartMessage");
						}
						break;
					case "RecipientGridPageClosed":
					if (ActivatedEventElements.Remove("RecipientGridPageClosedCatchMessage")) {
						context.QueueTasks.Enqueue("RecipientGridPageClosedCatchMessage");
					}
					break;
					case "CopyRecipientToolButtonClick":
							if (ActivatedEventElements.Contains("CopyRecipientToolButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CopyRecipientToolButtonClickStartMessage");
						}
						break;
					case "BlindCopyRecipientToolButtonClick":
							if (ActivatedEventElements.Contains("BlindCopyRecipientToolButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("BlindCopyRecipientToolButtonClickStartMessage");
						}
						break;
					case "DataSourceBeforeSave":
							if (ActivatedEventElements.Contains("DataSourceBeforeSaveChildStartMessage")) {
							context.QueueTasks.Enqueue("DataSourceBeforeSaveChildStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("RecipientField") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RecipientField", RecipientField, null);
			}
			if (!HasMapping("ObjectFieldInActivityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ObjectFieldInActivityId", ObjectFieldInActivityId, Guid.Empty);
			}
			if (!HasMapping("IsMacrosCollectionChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsMacrosCollectionChanged", IsMacrosCollectionChanged, false);
			}
			if (!HasMapping("BlindCopyRecipient") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("BlindCopyRecipient", BlindCopyRecipient, null);
			}
			if (!HasMapping("CopyRecipient") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CopyRecipient", CopyRecipient, null);
			}
			if (!HasMapping("Recipient") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("Recipient", Recipient, null);
			}
			if (!HasMapping("CurrentObjectSchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentObjectSchemaId", CurrentObjectSchemaId, Guid.Empty);
			}
			if (!HasMapping("CurrentMacrosIndex") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentMacrosIndex", CurrentMacrosIndex, 0);
			}
			if (ParentIdNameDictionary != null) {
				if (ParentIdNameDictionary.GetType().IsSerializable ||
					ParentIdNameDictionary.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ParentIdNameDictionary", ParentIdNameDictionary, null);
				}
			}
			if (!HasMapping("CurrentObjectSchemaName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CurrentObjectSchemaName", CurrentObjectSchemaName, null);
			}
			if (!HasMapping("VirtualDataSourceID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("VirtualDataSourceID", VirtualDataSourceID, null);
			}
			if (MacrosCollection != null) {
				if (MacrosCollection.GetType().IsSerializable ||
					MacrosCollection.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("MacrosCollection", MacrosCollection, null);
				}
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

	#region Class: EmailTemplateEditPageEventsProcess

	/// <exclude/>
	public class EmailTemplateEditPageEventsProcess : EmailTemplateEditPageEventsProcess<Terrasoft.WebApp.EmailTemplateEditPageSchemaUserControl>
	{

		public EmailTemplateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplateEditPageSchemaUserControl

	/// <exclude/>
	public partial class EmailTemplateEditPageSchemaUserControl : Terrasoft.WebApp.BaseModuleEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout NameControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NameControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ObjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout EmailControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("EmailControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit RecipientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("RecipientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton AddRecipientToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("AddRecipientToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CopyRecipientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CopyRecipientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton CopyRecipientToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("CopyRecipientToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit BlindCopyRecipientEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("BlindCopyRecipientEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton BlindCopyRecipientToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("BlindCopyRecipientToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout SubjectControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("SubjectControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SubjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SubjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton AddMacrosToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("AddMacrosToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button PriorityButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("PriorityButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BodyControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BodyControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.HtmlEdit BodyEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.HtmlEdit)PageContainer.FindPageControl("BodyEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button PutTemplateToBodyButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("PutTemplateToBodyButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout MacrosControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MacrosControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SetFieldsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SetFieldsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem RecipientMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("RecipientMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem CurrentUserMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("CurrentUserMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ObjectMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ObjectMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid MacrosTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("MacrosTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SendIndividualEmailEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("SendIndividualEmailEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox SaveAsActivityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("SaveAsActivityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ObjectFieldInActivityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ObjectFieldInActivityEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowBeforeSendingEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowBeforeSendingEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event += ObjectEditChange;
			AddRecipientToolButton.AjaxEvents.Click.Event += AddRecipientToolButtonClick;
			CopyRecipientToolButton.AjaxEvents.Click.Event += CopyRecipientToolButtonClick;
			BlindCopyRecipientToolButton.AjaxEvents.Click.Event += BlindCopyRecipientToolButtonClick;
			PutTemplateToBodyButton.AjaxEvents.Click.Event += PutTemplateToBodyButtonClick;
			RecipientMenuItem.AjaxEvents.Click.Event += RecipientMenuItemClick;
			CurrentUserMenuItem.AjaxEvents.Click.Event += CurrentUserMenuItemClick;
			ObjectMenuItem.AjaxEvents.Click.Event += ObjectMenuItemClick;
			MacrosTreeGrid.AjaxEvents.DblClick.Event += MacrosTreeGridDblClick;
			DataSource.AjaxEvents.BeforeInsert.Event += DataSourceBeforeInsert;
			DataSource.BeforeSaveRow += DataSourceBeforeSave;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event -= ObjectEditChange;
			AddRecipientToolButton.AjaxEvents.Click.Event -= AddRecipientToolButtonClick;
			CopyRecipientToolButton.AjaxEvents.Click.Event -= CopyRecipientToolButtonClick;
			BlindCopyRecipientToolButton.AjaxEvents.Click.Event -= BlindCopyRecipientToolButtonClick;
			PutTemplateToBodyButton.AjaxEvents.Click.Event -= PutTemplateToBodyButtonClick;
			RecipientMenuItem.AjaxEvents.Click.Event -= RecipientMenuItemClick;
			CurrentUserMenuItem.AjaxEvents.Click.Event -= CurrentUserMenuItemClick;
			ObjectMenuItem.AjaxEvents.Click.Event -= ObjectMenuItemClick;
			MacrosTreeGrid.AjaxEvents.DblClick.Event -= MacrosTreeGridDblClick;
			DataSource.AjaxEvents.BeforeInsert.Event -= DataSourceBeforeInsert;
			DataSource.BeforeSaveRow -= DataSourceBeforeSave;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (EmailTemplateEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new EmailTemplateEditPageEventsProcess(UserConnection);
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

		public virtual void AddRecipientToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddRecipientToolButtonClick");
		}

		public virtual void CopyRecipientToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CopyRecipientToolButtonClick");
		}

		public virtual void BlindCopyRecipientToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("BlindCopyRecipientToolButtonClick");
		}

		public virtual void PutTemplateToBodyButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("PutTemplateToBodyButtonClick");
		}

		public virtual void RecipientMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("RecipientMenuItemClick");
		}

		public virtual void CurrentUserMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("CurrentUserMenuItemClick");
		}

		public virtual void ObjectMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectMenuItemClick");
		}

		public virtual void MacrosTreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("MacrosTreeGridDblClick");
		}

		public virtual void DataSourceBeforeInsert(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeInsert");
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
			SchemaName = "EmailTemplateEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateEditPageEventsProcessSchema

	/// <exclude/>
	public class EmailTemplateEditPageEventsProcessSchema : Terrasoft.WebApp.BaseModuleEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public EmailTemplateEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailTemplateEditPageEventsProcessSchema(EmailTemplateEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailTemplateEditPageEventsProcess";
			UId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateIsSchemaBlockedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6322e39c-e443-400d-a070-e33ab9f7e541"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				Name = @"IsSchemaBlocked",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9896ac1f-5307-4bf7-8f6f-eb69c92c94a1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b27880ba-f892-4a54-9dd3-b969972279d9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("511d67b1-7a6e-43fa-85af-2d5f312c539f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMacrosCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e26a25c3-7c1e-4bbd-8280-fa0ca7a3bf53"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"MacrosCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVirtualDataSourceIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5217e610-2212-467a-b779-622328f680b4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"VirtualDataSourceID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentObjectSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0730727f-43f3-4a76-aea6-a0b4f9c20bb9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CurrentObjectSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateParentIdNameDictionaryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e53a518f-aac1-4a1a-96f7-997b5a986edf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ParentIdNameDictionary",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentMacrosIndexParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("212a07e3-351a-45a3-a2d2-f82a487cdcd8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CurrentMacrosIndex",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentObjectSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2fb70d88-b8df-4476-a41f-861793da929c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CurrentObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecipientParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e1ad561d-22fb-4b1b-952e-8db171b51ea1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"Recipient",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCopyRecipientParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("69530665-51f5-48bd-88e0-b3a53631469e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CopyRecipient",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBlindCopyRecipientParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7a047051-5bfb-4732-9c76-083e0bff0c55"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"BlindCopyRecipient",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMacrosCollectionChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6ad4c98a-9c5b-48d8-8839-570d27ecf11a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"IsMacrosCollectionChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateObjectFieldInActivityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("00434d13-ace5-4b5e-b3c4-e238c961d9a3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ObjectFieldInActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecipientFieldParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("91295fb9-77b5-4dcc-b574-6cf23d8e9a8c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"RecipientField",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateColumnStructureExplorerRegisteredParameter());
			Parameters.Add(CreateMacrosCollectionParameter());
			Parameters.Add(CreateVirtualDataSourceIDParameter());
			Parameters.Add(CreateCurrentObjectSchemaNameParameter());
			Parameters.Add(CreateParentIdNameDictionaryParameter());
			Parameters.Add(CreateCurrentMacrosIndexParameter());
			Parameters.Add(CreateCurrentObjectSchemaIdParameter());
			Parameters.Add(CreateRecipientParameter());
			Parameters.Add(CreateCopyRecipientParameter());
			Parameters.Add(CreateBlindCopyRecipientParameter());
			Parameters.Add(CreateIsMacrosCollectionChangedParameter());
			Parameters.Add(CreateObjectFieldInActivityIdParameter());
			Parameters.Add(CreateRecipientFieldParameter());
		}

		protected virtual void InitializeRecipientGridPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("25a17828-6a53-41e6-be22-1ea52b63cb2c"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("8d73b2a8-b533-4ef2-9707-3566307f5392"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("302e222d-f3b9-4783-9bd8-4941e4773b3b"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("8510ea68-b3b3-4bc5-8d66-3eb91d224869"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("a15af573-b0cc-4b06-88cb-f756192368be"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("691b4a7d-a0ba-4b48-9c0a-432eb7d22ecd"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("1af510a7-1c64-419b-a307-9bbd3b979dd4"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("e6fd0bd1-48a7-4739-a997-745014410514"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("af5994c0-b495-485a-afa5-c32b97173e6c"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("00620fef-d5dc-4b2f-b746-e80d205379e6"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("b24bd1b8-e923-438f-9f22-3b13c75394d2"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
				UId = new Guid("43f7de44-8e07-4325-81b1-78f33fbc6e67"),
				ContainerUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
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
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaEventsHandlingLaneSet = CreateEventsHandlingLaneSetLaneSet();
			LaneSets.Add(schemaEventsHandlingLaneSet);
			ProcessSchemaLane schemaControlsEventsLane = CreateControlsEventsLaneLane();
			schemaEventsHandlingLaneSet.Lanes.Add(schemaControlsEventsLane);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaEventsHandlingLaneSet.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaEventsHandlingLaneSet.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaEventsHandlingLaneSet.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaEventSubProcess setfieldscontactmenuitemclickeventsubprocess = CreateSetFieldsContactMenuItemClickEventSubProcessEventSubProcess();
			FlowElements.Add(setfieldscontactmenuitemclickeventsubprocess);
			ProcessSchemaEventSubProcess objecteditchangeeventsubprocess = CreateObjectEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(objecteditchangeeventsubprocess);
			ProcessSchemaEventSubProcess puttemplatetobodybuttonclickeventsubprocess = CreatePutTemplateToBodyButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(puttemplatetobodybuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess okbuttonclickeventsubprocess = CreateOKButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent = CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			initeventsubprocess.FlowElements.Add(initintermediatethrowmessageevent);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent recipientmenuitemclickstartmessage = CreateRecipientMenuItemClickStartMessageStartMessageEvent();
			setfieldscontactmenuitemclickeventsubprocess.FlowElements.Add(recipientmenuitemclickstartmessage);
			ProcessSchemaScriptTask recipientmenuitemclickscripttask = CreateRecipientMenuItemClickScriptTaskScriptTask();
			setfieldscontactmenuitemclickeventsubprocess.FlowElements.Add(recipientmenuitemclickscripttask);
			ProcessSchemaStartMessageEvent currentusermenuitemclickstartmessage = CreateCurrentUserMenuItemClickStartMessageStartMessageEvent();
			setfieldscontactmenuitemclickeventsubprocess.FlowElements.Add(currentusermenuitemclickstartmessage);
			ProcessSchemaStartMessageEvent objectmenuitemclickstartmessage = CreateObjectMenuItemClickStartMessageStartMessageEvent();
			setfieldscontactmenuitemclickeventsubprocess.FlowElements.Add(objectmenuitemclickstartmessage);
			ProcessSchemaScriptTask objectmenuitemclickscripttask = CreateObjectMenuItemClickScriptTaskScriptTask();
			setfieldscontactmenuitemclickeventsubprocess.FlowElements.Add(objectmenuitemclickscripttask);
			ProcessSchemaScriptTask currentusermenuitemclickscripttask = CreateCurrentUserMenuItemClickScriptTaskScriptTask();
			setfieldscontactmenuitemclickeventsubprocess.FlowElements.Add(currentusermenuitemclickscripttask);
			ProcessSchemaStartMessageEvent objecteditchangestartmessage = CreateObjectEditChangeStartMessageStartMessageEvent();
			objecteditchangeeventsubprocess.FlowElements.Add(objecteditchangestartmessage);
			ProcessSchemaScriptTask objecteditchangescripttask = CreateObjectEditChangeScriptTaskScriptTask();
			objecteditchangeeventsubprocess.FlowElements.Add(objecteditchangescripttask);
			ProcessSchemaStartMessageEvent puttemplatetobodybuttonclickstartmessage = CreatePutTemplateToBodyButtonClickStartMessageStartMessageEvent();
			puttemplatetobodybuttonclickeventsubprocess.FlowElements.Add(puttemplatetobodybuttonclickstartmessage);
			ProcessSchemaScriptTask puttemplatetobodybuttonclickscripttask = CreatePutTemplateToBodyButtonClickScriptTaskScriptTask();
			puttemplatetobodybuttonclickeventsubprocess.FlowElements.Add(puttemplatetobodybuttonclickscripttask);
			ProcessSchemaStartMessageEvent macrostreegriddblclickstartmessage = CreateMacrosTreeGridDblClickStartMessageStartMessageEvent();
			puttemplatetobodybuttonclickeventsubprocess.FlowElements.Add(macrostreegriddblclickstartmessage);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOKButtonClickStartMessageStartMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclickintermediatethrowmessageevent = CreateOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickintermediatethrowmessageevent);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOKButtonClickScriptTaskScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent addrecipienttoolbuttonclickstartmessage = CreateAddRecipientToolButtonClickStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(addrecipienttoolbuttonclickstartmessage);
			ProcessSchemaScriptTask addrecipienttoolbuttonclickscripttask = CreateAddRecipientToolButtonClickScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(addrecipienttoolbuttonclickscripttask);
			ProcessSchemaUserTask recipientgridpageusertask = CreateRecipientGridPageUserTaskUserTask();
			eventsubprocess4.FlowElements.Add(recipientgridpageusertask);
			ProcessSchemaScriptTask changeeditvaluescripttask = CreateChangeEditValueScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(changeeditvaluescripttask);
			ProcessSchemaIntermediateCatchMessageEvent recipientgridpageclosedcatchmessage = CreateRecipientGridPageClosedCatchMessageIntermediateCatchMessageEvent();
			eventsubprocess4.FlowElements.Add(recipientgridpageclosedcatchmessage);
			ProcessSchemaScriptTask beforeaddrecipientscripttask = CreateBeforeAddRecipientScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(beforeaddrecipientscripttask);
			ProcessSchemaStartMessageEvent copyrecipienttoolbuttonclickstartmessage = CreateCopyRecipientToolButtonClickStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(copyrecipienttoolbuttonclickstartmessage);
			ProcessSchemaScriptTask copyrecipienttoolbuttonclickscripttask = CreateCopyRecipientToolButtonClickScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(copyrecipienttoolbuttonclickscripttask);
			ProcessSchemaStartMessageEvent blindcopyrecipienttoolbuttonclickstartmessage = CreateBlindCopyRecipientToolButtonClickStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(blindcopyrecipienttoolbuttonclickstartmessage);
			ProcessSchemaScriptTask blindcopyrecipienttoolbuttonclickscripttask = CreateBlindCopyRecipientToolButtonClickScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(blindcopyrecipienttoolbuttonclickscripttask);
			ProcessSchemaStartMessageEvent datasourcebeforesavechildstartmessage = CreateDataSourceBeforeSaveChildStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(datasourcebeforesavechildstartmessage);
			ProcessSchemaScriptTask datasourcebeforesavechildscripttask = CreateDataSourceBeforeSaveChildScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(datasourcebeforesavechildscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e4e92ffb-3b5b-4dc4-9474-44f31153cd03"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(192, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("159d3b7e-d185-4ab4-a0b5-e5f629a20127"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1394f79b-1c60-4251-9239-49dc74003edd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("78d597ce-129e-4e99-bf5e-cb2ceea7fbaa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(291, 230),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1394f79b-1c60-4251-9239-49dc74003edd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b3b06ba-3d5d-488f-b482-4759ae1397ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("1d67c746-8001-4670-85bd-138a311fa38b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3f2ba4f1-9885-451e-bbdf-3181daad0368"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2fd0a662-c3b0-4795-9826-da10e07fd390"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e8da5928-82db-4f09-be91-0187defde1fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(186, 386),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2702f254-c422-4dca-890a-7194fdc644f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad762440-ef8a-4fc2-be2b-8b0958b8e00e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("15e78cf3-1391-4c75-8891-015bfc0f81cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(284, 384),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ad762440-ef8a-4fc2-be2b-8b0958b8e00e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("093a29b5-82c4-4b7a-bd83-f19d6919f499"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("1bb0ce15-f95f-4bb3-b273-364b595a2226"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6fe57dfa-429c-411a-8306-b47abdd8d520"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("64ea04ae-380c-48f6-8b5c-afcbc280d591"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("27194abc-76e2-4b67-a8fb-7b90fa2b79d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(187, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("295e5223-5f89-46c7-a11e-841c2b3e9517"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("224d0934-f990-495d-9ec4-aba6eb8fffb2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("fd701c02-1bed-480c-94b7-fb23079db19a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(187, 312),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0abc0d55-6e57-47e8-b6d1-a9a77c55a929"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("97c93d5b-2663-4986-a240-b1440b66b042"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("a697b5d8-8ce0-49e7-b716-25f78456350c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("255a7909-1f8d-40aa-8ab8-6ce80e5b7d7e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6efb22f4-8824-4860-aa56-b8699155b574"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("db8680c6-adcd-493a-9b6a-895538021d63"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(634, 118),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b7fbffee-5f0a-413d-83d6-9cabf496b4d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6efb22f4-8824-4860-aa56-b8699155b574"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("4eb9d200-e677-47e7-b48a-ba1fcd1bc915"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(638, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ea94ec9-72c0-4dbf-a1cf-ac5d45e8b7bf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1fce5211-23c0-49b5-9c0d-6ba346a3f2ee"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("29f966c0-e2b0-4b15-8e97-94b647acf72a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(722, 308),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fce5211-23c0-49b5-9c0d-6ba346a3f2ee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b26ec7ad-b9a8-45f0-ae47-b0559c55ec3a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("bc6194fe-201e-4253-a9c5-249edbbfdb9f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d1962ed5-bb29-46e3-9a91-4215a23ada3f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a92ea5e-f44d-4ee4-80b3-dbc3b971a57d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("805f0522-752f-43b9-b095-b03f26d20490"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8612c260-356d-4108-9c11-54a8758cb28c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d206f9da-8538-4791-b6a1-7d3856335096"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("f4024efd-e455-488a-b4ff-80715559f8ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2ba49edb-9492-4527-8939-e95d5b79d7db"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eb9ffe01-7645-439a-ab02-b7eb1f14d4fb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("f23a8c07-20e3-469c-aa59-501259ea712f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(330, 404),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d95e190d-8981-4624-a190-3ced39db60d8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("7212ac1c-7c5f-46c3-bf18-9f53bda62b2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(453, 406),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("679a8579-a3a3-4f6c-bc37-33bbd0c5d3e8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("c287501d-29c4-4b08-b383-6742c53169a7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(554, 407),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("679a8579-a3a3-4f6c-bc37-33bbd0c5d3e8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9d9cc5d-41d5-439c-bc37-240f893bde42"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("6bd4bf49-9add-4600-affb-ec8a00d805e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2a92ea5e-f44d-4ee4-80b3-dbc3b971a57d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d95e190d-8981-4624-a190-3ced39db60d8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("9efb7a1e-5863-4d7f-8c53-bc4a577933df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(289, 156),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d206f9da-8538-4791-b6a1-7d3856335096"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d95e190d-8981-4624-a190-3ced39db60d8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("05ab3082-236d-4f68-b3b2-4eec4df9ce92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(468, 156),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb9ffe01-7645-439a-ab02-b7eb1f14d4fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d95e190d-8981-4624-a190-3ced39db60d8"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("be4abe8f-6aba-4213-8002-012f86d8badd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6446376c-e104-400b-bb94-fd35959bfc56"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e2f27939-e52f-48e6-9d79-ada565579a9a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateEventsHandlingLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaEventsHandlingLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("6d0e2723-7cef-42a1-b4cb-d46a87b154fb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"EventsHandlingLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1076, 1111),
				UseBackgroundMode = false
			};
			return schemaEventsHandlingLaneSet;
		}

		protected virtual ProcessSchemaLane CreateControlsEventsLaneLane() {
			ProcessSchemaLane schemaControlsEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("6db60bf3-6a13-45b0-83e6-1191e71ef26b"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("6d0e2723-7cef-42a1-b4cb-d46a87b154fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ControlsEventsLane",
				Position = new Point(29, 520),
				Size = new Size(1047, 408),
				UseBackgroundMode = false
			};
			return schemaControlsEventsLane;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("3572d79a-d40a-4f0a-aeaf-1fb7e510c352"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("6d0e2723-7cef-42a1-b4cb-d46a87b154fb"),
				CreatedInOwnerSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 933),
				Size = new Size(1047, 178),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("16aa198c-9585-45bb-a507-8959fe5259f0"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("6d0e2723-7cef-42a1-b4cb-d46a87b154fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"Lane1",
				Position = new Point(29, 189),
				Size = new Size(1047, 326),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("50b66d81-3f87-49ee-a3a6-c221d7c8fb4f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("6d0e2723-7cef-42a1-b4cb-d46a87b154fb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1047, 184),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("53fdfd42-758c-41d1-9df9-750a68eea538"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3572d79a-d40a-4f0a-aeaf-1fb7e510c352"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("159d3b7e-d185-4ab4-a0b5-e5f629a20127"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53fdfd42-758c-41d1-9df9-750a68eea538"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1394f79b-1c60-4251-9239-49dc74003edd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53fdfd42-758c-41d1-9df9-750a68eea538"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7b3b06ba-3d5d-488f-b482-4759ae1397ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("53fdfd42-758c-41d1-9df9-750a68eea538"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,88,91,83,219,56,20,126,14,51,252,7,215,157,41,206,108,48,208,206,208,118,75,217,205,141,146,110,41,108,66,251,210,225,65,216,2,212,218,114,86,146,161,89,38,255,125,207,145,228,187,67,96,203,12,132,72,231,124,231,126,177,167,244,154,73,69,197,233,229,119,26,168,19,202,211,137,162,241,76,17,69,103,129,96,115,229,117,223,109,110,76,45,213,103,18,211,89,170,73,167,52,34,138,37,188,133,106,70,110,105,95,246,3,197,110,153,90,124,74,174,89,80,162,58,98,81,132,114,206,4,75,4,220,235,195,83,17,82,65,195,17,11,16,147,136,133,19,147,64,36,114,152,68,17,213,103,206,123,135,211,59,167,65,168,217,217,149,227,77,228,103,122,215,117,238,55,55,58,183,68,56,115,34,40,87,147,16,85,46,193,26,148,226,224,224,67,202,194,158,35,149,96,252,250,80,131,105,246,32,225,138,4,106,22,220,208,152,0,215,23,73,197,48,225,220,40,227,143,185,2,213,205,237,9,225,228,154,10,255,3,85,19,46,21,225,1,29,44,80,172,231,14,13,138,219,125,215,177,184,84,254,99,117,40,67,252,157,82,176,100,189,140,158,227,142,99,194,162,115,26,207,193,253,244,68,59,201,213,90,3,178,15,62,141,193,40,13,7,174,75,99,238,79,100,63,186,35,11,57,163,232,72,144,173,68,74,51,250,126,24,26,50,207,69,133,11,160,210,197,153,118,164,219,245,181,235,7,139,190,12,188,189,54,66,243,121,70,212,77,59,78,34,25,218,85,69,122,153,147,66,94,64,238,72,100,241,224,72,159,13,5,5,43,33,178,105,20,153,123,207,237,7,65,146,114,53,76,226,56,229,44,208,73,120,190,152,131,242,192,149,199,143,106,231,85,210,7,1,33,70,227,218,77,205,237,26,1,243,169,142,224,15,81,172,115,232,236,154,36,43,101,153,49,241,43,137,82,138,110,180,178,166,73,98,243,199,55,4,18,108,228,97,150,27,185,95,107,220,40,191,115,149,128,229,193,141,87,152,226,48,222,48,202,42,98,53,81,55,40,88,147,160,157,232,147,176,132,125,144,229,120,35,80,157,74,193,60,12,130,229,114,232,181,154,109,177,208,119,70,148,111,2,119,42,198,241,28,234,28,53,236,58,47,94,20,146,158,189,119,16,207,215,247,153,49,29,44,61,198,77,146,118,58,203,28,180,80,176,149,173,189,224,117,58,89,123,108,117,148,212,238,57,213,171,17,147,80,87,101,10,107,84,167,222,142,90,112,155,204,61,93,232,31,251,66,16,232,83,22,106,233,208,72,210,76,107,244,60,183,57,243,136,208,21,85,106,121,141,94,182,165,124,52,93,220,171,42,157,87,20,252,104,170,51,145,204,169,128,136,216,195,142,27,144,185,46,205,158,147,29,161,78,246,255,174,249,124,50,104,76,21,209,73,86,160,86,186,42,90,106,254,51,166,158,88,250,193,2,255,154,116,105,87,193,171,71,227,91,123,240,243,227,139,11,135,72,27,136,174,86,221,32,116,75,57,134,127,240,247,164,57,120,234,226,144,107,34,235,132,195,27,194,175,105,88,106,177,103,171,102,80,187,186,200,242,41,33,225,87,38,84,74,162,17,81,100,150,164,34,160,211,228,78,54,108,214,186,207,168,202,230,168,206,20,104,143,131,183,251,71,253,221,151,219,175,143,198,251,219,163,163,189,189,237,183,175,247,6,219,187,187,123,163,253,221,241,219,87,111,134,251,144,65,59,59,159,19,17,147,104,115,163,148,143,152,80,4,199,54,74,4,53,39,32,110,190,112,254,112,206,96,248,248,133,62,62,42,244,109,247,194,249,189,113,211,207,216,243,137,103,244,30,44,20,197,52,205,225,49,250,250,208,234,93,30,101,200,22,82,104,203,140,68,236,95,26,126,130,181,2,120,63,74,168,187,81,113,126,128,231,7,133,255,160,179,139,197,225,161,206,192,217,2,54,145,216,63,167,63,21,12,210,32,9,177,31,125,57,63,122,163,179,78,151,147,87,210,44,159,29,229,198,203,0,1,219,110,93,21,219,114,90,91,2,242,248,127,209,69,79,115,251,69,15,89,62,61,184,216,244,26,66,204,20,130,22,248,170,52,134,18,93,247,229,98,170,184,250,129,41,100,58,134,109,41,5,148,30,3,149,88,173,152,4,77,201,245,121,86,135,30,154,94,179,22,63,235,121,45,18,154,157,182,16,164,19,178,186,205,250,133,200,138,10,43,233,143,89,24,82,36,191,34,80,26,154,108,152,10,44,217,211,146,50,218,71,153,187,86,17,217,125,160,33,247,9,157,198,44,183,88,137,54,226,143,105,61,75,91,70,130,6,108,206,64,169,181,5,56,205,40,139,26,204,153,219,138,47,139,207,99,42,173,170,133,153,132,218,241,185,208,113,200,148,63,75,229,156,242,176,255,157,252,28,223,194,161,244,86,82,82,101,212,6,25,54,27,244,119,89,136,90,41,101,74,101,26,211,186,16,179,244,207,23,211,71,59,108,88,166,118,219,65,126,213,113,77,141,74,102,85,20,88,235,192,22,234,149,78,172,136,125,80,226,106,103,94,70,208,102,134,79,242,232,160,193,226,62,0,247,171,190,93,161,96,201,220,166,62,107,189,188,138,101,165,171,155,90,172,87,160,221,233,216,39,158,85,26,69,217,85,121,93,152,78,85,115,100,37,224,154,162,41,26,200,154,202,150,123,141,172,60,247,3,249,202,229,160,181,225,95,38,73,4,43,110,245,237,129,155,155,86,69,183,22,150,186,247,17,163,81,56,225,25,129,118,212,152,147,203,136,218,125,120,103,71,83,207,110,146,187,1,197,57,63,131,32,66,34,52,40,209,30,152,229,170,21,215,134,173,117,30,228,201,42,245,195,118,102,222,163,135,169,219,42,177,228,130,58,108,219,3,84,190,196,229,47,15,254,247,235,139,146,6,157,78,29,187,186,103,228,112,181,45,227,203,36,108,168,221,24,212,109,161,203,42,166,207,67,172,98,175,42,214,7,220,94,77,149,108,204,63,10,30,247,184,51,65,113,17,207,199,166,54,177,149,69,71,176,110,70,150,42,141,29,252,81,161,206,88,38,161,219,245,207,19,219,147,116,237,3,168,94,156,237,58,50,140,88,240,227,152,240,48,162,194,188,71,67,101,204,19,246,17,46,241,10,55,222,63,221,251,221,165,31,164,82,37,241,73,11,39,110,51,41,55,111,60,186,247,58,83,238,247,150,190,204,26,19,126,185,206,190,116,157,223,156,173,111,207,183,224,67,221,48,233,155,231,21,132,245,147,59,14,201,98,31,24,145,204,207,169,74,135,207,47,182,76,41,45,221,94,214,204,160,164,204,222,114,14,133,62,72,149,194,109,54,194,38,50,25,229,68,246,237,162,142,81,118,185,185,129,88,230,90,219,159,165,44,32,218,23,139,171,125,133,172,198,89,16,64,53,165,36,60,229,209,98,157,31,75,164,222,22,38,7,152,227,88,127,181,92,188,108,191,40,108,175,246,239,134,213,205,22,223,32,89,49,10,158,224,163,134,249,200,177,185,113,78,225,169,88,38,87,128,149,240,43,118,157,10,253,74,205,63,86,113,132,34,142,105,4,15,246,126,246,114,119,4,79,233,44,2,212,73,12,248,22,186,218,94,122,166,241,15,146,80,215,26,138,17,84,165,130,155,50,251,15,36,138,247,180,115,22,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a6ab53e9-9d16-4bdf-a754-a303a956735c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3572d79a-d40a-4f0a-aeaf-1fb7e510c352"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2702f254-c422-4dca-890a-7194fdc644f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6ab53e9-9d16-4bdf-a754-a303a956735c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ad762440-ef8a-4fc2-be2b-8b0958b8e00e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6ab53e9-9d16-4bdf-a754-a303a956735c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("093a29b5-82c4-4b7a-bd83-f19d6919f499"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6ab53e9-9d16-4bdf-a754-a303a956735c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,87,75,111,227,54,16,62,59,64,254,131,170,203,74,168,33,180,103,55,139,218,113,30,110,55,89,35,78,182,135,162,40,24,105,236,112,87,18,85,146,114,98,4,249,239,157,33,41,89,178,164,100,177,93,244,224,135,200,121,124,51,223,112,134,226,107,47,56,21,105,153,229,43,45,203,88,151,18,206,158,138,84,72,144,167,18,152,134,36,244,158,143,143,70,246,97,64,50,8,39,199,71,47,199,71,75,182,129,232,227,253,103,136,245,89,194,117,180,148,80,48,9,31,132,248,82,22,231,60,213,32,189,31,79,60,183,188,23,180,91,104,131,35,154,179,39,29,45,212,244,51,123,186,129,127,74,80,218,2,64,153,244,10,242,114,41,185,144,92,239,42,159,159,184,212,37,75,231,76,179,149,40,101,12,139,185,119,226,249,87,44,150,66,117,54,125,84,218,50,233,109,15,55,80,39,135,71,175,163,16,88,239,198,104,143,43,132,48,113,113,211,215,169,200,53,227,57,200,136,254,73,145,170,104,154,36,65,199,91,88,41,89,152,183,18,224,66,242,36,106,152,78,208,97,71,47,90,204,81,115,255,92,51,225,37,176,222,63,244,105,206,27,2,104,163,41,143,60,241,140,201,157,101,247,154,101,100,193,95,36,254,128,220,156,171,34,101,7,226,244,91,101,55,65,183,159,88,90,194,237,174,128,43,150,99,164,18,101,130,121,207,122,136,217,53,169,184,83,88,114,34,207,177,38,184,200,163,105,81,56,137,165,20,91,158,96,78,47,64,187,165,192,239,51,229,135,206,127,108,144,57,74,123,178,101,145,27,98,27,209,142,241,209,152,236,228,129,118,90,14,113,189,47,70,66,184,200,149,102,121,12,179,29,25,8,252,139,146,39,126,72,22,78,89,65,145,53,108,46,176,64,21,191,79,201,222,154,165,10,236,226,74,72,205,26,171,182,200,90,76,96,85,89,148,129,141,149,34,255,134,168,13,105,3,113,215,123,223,26,249,45,60,233,78,228,181,213,102,236,136,240,127,15,125,137,29,40,215,195,180,183,246,191,43,249,45,203,223,183,4,90,2,11,117,201,65,50,25,63,240,152,165,46,205,135,66,77,145,129,4,76,70,120,170,58,253,228,131,96,9,36,166,157,15,52,50,43,49,208,233,48,89,55,226,17,207,251,154,111,46,89,158,164,102,52,16,184,20,54,56,105,130,91,144,146,41,177,214,216,74,17,231,89,174,185,230,160,236,159,157,39,197,163,237,204,74,75,158,111,188,162,167,133,161,76,180,138,31,32,99,237,14,23,209,254,100,64,215,208,234,148,17,100,99,49,232,248,8,163,91,177,50,54,204,52,26,217,222,67,33,117,74,177,14,54,232,122,51,186,52,250,156,79,42,170,164,177,255,11,149,209,251,96,207,72,232,253,128,246,203,52,181,41,24,89,159,182,34,140,143,142,239,133,194,89,141,105,166,154,178,50,54,36,83,92,161,1,128,179,116,36,1,139,34,119,49,76,26,195,173,65,252,12,214,72,200,138,109,201,46,241,95,83,38,204,64,247,20,228,216,173,199,13,0,103,91,196,61,149,27,229,129,69,188,2,109,121,156,241,188,157,11,21,64,132,118,13,162,27,80,72,0,67,6,237,176,199,143,131,131,145,186,122,18,34,157,149,90,211,192,192,27,131,113,164,162,211,148,199,95,34,243,240,26,192,90,163,9,141,56,204,140,109,68,149,218,97,132,108,94,29,46,49,229,125,148,104,6,146,57,55,43,24,71,197,99,71,191,77,23,229,15,163,10,246,174,46,164,40,11,143,231,29,207,78,195,160,146,66,104,186,1,45,52,100,174,190,246,135,228,110,17,253,1,247,245,173,163,254,83,41,216,2,29,141,154,70,34,119,195,155,237,40,19,251,6,209,17,171,123,87,16,236,131,69,2,229,46,108,224,15,163,223,97,119,112,34,14,44,153,107,148,61,117,209,185,144,25,211,129,255,252,211,203,223,207,63,191,248,99,111,144,90,228,147,10,127,62,246,232,36,68,215,240,72,191,65,227,248,249,215,126,216,231,144,76,18,110,107,90,21,230,25,169,91,237,20,109,99,202,40,115,180,234,180,7,49,144,73,115,194,108,50,76,78,155,174,194,201,104,100,44,116,217,37,98,223,200,156,237,58,8,236,183,41,50,186,171,104,183,213,248,95,57,31,101,111,19,222,144,169,217,182,8,255,244,99,187,226,255,213,33,119,175,245,58,179,7,69,240,85,60,182,137,236,75,127,86,167,190,155,44,211,2,86,177,228,133,238,0,179,210,163,95,9,96,36,242,224,93,76,194,239,198,30,130,141,226,82,105,145,93,53,205,184,249,20,78,204,196,110,39,171,170,76,183,241,102,9,91,185,10,177,17,183,40,171,91,4,42,219,133,160,39,20,167,71,173,218,124,189,184,134,165,30,196,35,65,30,8,216,4,74,230,34,18,12,232,9,82,12,215,173,78,83,190,201,41,186,183,79,160,1,240,42,234,54,148,170,111,155,254,5,153,216,194,107,48,169,119,86,160,194,231,231,26,117,130,111,129,82,208,43,95,181,228,217,134,58,121,249,170,190,81,191,110,13,129,62,132,86,43,204,68,178,51,175,178,141,233,178,200,112,199,94,110,246,51,38,168,134,10,142,145,147,247,230,248,218,9,103,47,32,213,75,16,40,58,198,7,175,58,61,130,213,109,2,26,91,168,136,234,209,57,207,147,253,61,243,110,145,4,135,19,218,138,227,78,125,177,104,155,105,13,35,59,242,171,11,64,243,214,69,119,128,82,50,3,241,82,103,41,229,225,18,210,2,51,71,211,127,106,96,128,212,38,31,65,59,38,71,74,149,190,113,43,16,183,217,64,60,69,37,115,159,88,246,94,142,168,130,220,213,196,116,172,127,1,3,169,226,249,181,16,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSetFieldsContactMenuItemClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSetFieldsContactMenuItemClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6db60bf3-6a13-45b0-83e6-1191e71ef26b"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"SetFieldsContactMenuItemClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(453, 235),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSetFieldsContactMenuItemClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRecipientMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6fe57dfa-429c-411a-8306-b47abdd8d520"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RecipientMenuItemClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"RecipientMenuItemClickStartMessage",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRecipientMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("64ea04ae-380c-48f6-8b5c-afcbc280d591"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"RecipientMenuItemClickScriptTask",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,206,177,10,194,64,16,4,208,94,240,31,142,84,9,200,97,31,108,12,65,174,136,77,200,7,44,151,193,4,146,61,217,219,211,228,239,61,4,43,235,153,55,204,139,196,68,63,97,37,55,154,139,25,34,164,9,204,240,58,7,182,45,235,172,123,255,205,59,98,122,64,236,13,234,56,42,177,199,117,191,211,138,178,200,66,201,107,81,217,193,141,245,241,208,36,17,176,118,228,37,68,199,35,182,60,125,206,65,63,133,119,19,150,180,114,175,146,188,38,65,187,61,151,32,144,242,247,226,100,254,121,149,173,32,215,217,100,135,250,3,33,217,178,40,182,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCurrentUserMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("295e5223-5f89-46c7-a11e-841c2b3e9517"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CurrentUserMenuItemClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CurrentUserMenuItemClickStartMessage",
				Position = new Point(50, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3f2ba4f1-9885-451e-bbdf-3181daad0368"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectMenuItemClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ObjectMenuItemClickStartMessage",
				Position = new Point(253, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2fd0a662-c3b0-4795-9826-da10e07fd390"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ObjectMenuItemClickScriptTask",
				Position = new Point(358, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,45,42,74,205,43,241,77,76,46,202,47,246,204,75,73,173,80,176,85,48,178,230,229,10,206,200,47,119,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,210,112,134,104,242,79,202,74,77,46,9,78,206,72,205,77,244,76,209,81,112,198,48,75,19,104,80,81,42,80,111,158,2,208,144,84,107,0,34,21,76,96,110,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCurrentUserMenuItemClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("224d0934-f990-495d-9ec4-aba6eb8fffb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1437f627-d39b-4e1b-865b-d716dd10888c"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CurrentUserMenuItemClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,206,177,10,194,64,16,4,208,94,240,31,142,84,9,200,129,117,176,49,4,185,34,54,33,31,176,92,6,19,72,246,100,111,79,147,191,247,16,172,172,103,222,48,47,18,19,253,132,149,220,104,46,102,136,144,38,48,195,235,28,216,182,172,179,238,253,55,239,136,233,1,177,55,168,227,168,196,30,215,253,78,43,202,34,11,37,175,69,101,7,55,214,199,67,147,68,192,218,145,151,16,29,143,216,242,244,57,7,253,20,222,77,88,210,202,189,74,242,154,4,237,246,92,130,64,202,223,139,147,249,231,85,182,130,92,103,147,29,234,15,31,104,240,166,182,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateObjectEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaObjectEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d15616b7-4fcd-4542-90e4-ff2480289361"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6db60bf3-6a13-45b0-83e6-1191e71ef26b"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ObjectEditChangeEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 240),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(455, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaObjectEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0abc0d55-6e57-47e8-b6d1-a9a77c55a929"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d15616b7-4fcd-4542-90e4-ff2480289361"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ObjectEditChange",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ObjectEditChangeStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("97c93d5b-2663-4986-a240-b1440b66b042"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d15616b7-4fcd-4542-90e4-ff2480289361"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ObjectEditChangeScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,193,78,227,48,16,61,23,137,127,48,61,165,82,229,31,232,22,169,148,130,178,187,208,138,46,92,86,123,24,226,1,204,38,78,100,59,101,163,21,255,190,246,56,109,210,146,82,216,75,171,120,102,222,123,158,121,182,87,160,25,42,43,109,197,198,108,1,143,200,207,193,194,50,47,117,130,124,146,88,185,194,155,252,101,116,124,180,114,137,249,253,51,38,118,153,60,97,6,211,60,45,51,229,138,66,53,15,171,60,44,27,126,33,149,56,171,174,33,195,168,63,167,178,254,96,11,37,22,77,237,37,218,31,85,129,34,20,223,65,90,226,151,203,82,138,211,232,45,35,111,37,121,248,53,106,6,137,206,141,11,166,174,64,230,94,217,213,238,18,24,54,215,2,53,138,115,73,43,160,171,186,188,0,237,196,196,194,67,54,65,234,73,103,192,65,53,95,36,118,200,140,213,82,61,158,58,68,249,192,162,147,240,201,99,115,93,166,233,92,207,178,194,86,209,180,212,30,111,222,218,23,237,98,192,254,30,31,245,118,55,193,111,48,203,87,184,183,202,81,245,60,87,183,122,215,42,101,65,42,67,205,58,64,221,219,131,81,43,240,25,251,82,46,164,54,54,146,22,51,54,62,101,254,159,19,35,27,143,217,62,82,254,13,43,146,255,122,124,244,26,26,182,241,197,201,152,249,134,114,234,88,80,215,248,198,87,191,239,156,122,12,93,222,57,151,166,72,161,234,176,16,49,24,202,37,103,174,197,172,67,129,47,128,185,240,173,65,237,186,171,234,49,205,90,209,43,80,238,24,105,47,45,86,198,130,74,240,172,186,141,69,180,70,39,186,55,147,158,8,17,181,73,248,20,10,31,24,50,133,47,236,235,68,107,168,162,193,102,226,91,169,11,45,51,55,136,173,221,249,46,42,103,188,122,186,205,17,113,234,9,49,140,36,34,196,90,14,137,160,73,83,198,66,231,5,106,103,90,90,234,245,147,160,168,63,100,97,193,237,48,112,213,82,235,243,222,150,54,100,7,133,114,26,65,143,32,7,254,247,19,138,148,43,221,200,249,24,211,255,17,101,104,97,1,246,169,155,204,53,162,109,179,171,58,249,172,242,191,135,71,21,58,176,171,43,218,181,200,207,46,123,252,242,55,81,112,199,128,246,16,170,214,71,171,183,231,252,109,28,238,63,70,221,121,116,14,214,166,245,57,14,190,78,184,144,152,138,88,209,251,224,36,209,73,50,91,6,127,101,152,26,36,239,209,171,210,89,55,19,210,242,105,138,160,99,119,105,152,224,197,3,233,203,210,20,168,196,228,25,254,204,86,78,241,199,170,136,228,67,153,55,104,202,12,63,9,239,198,9,247,41,182,114,151,176,194,137,217,214,240,132,201,111,244,77,125,0,215,155,61,93,175,167,83,63,30,116,5,190,55,159,230,162,28,209,69,250,61,7,113,39,181,45,33,109,30,114,247,130,155,55,118,242,90,53,218,82,43,102,117,137,163,127,3,148,200,84,10,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePutTemplateToBodyButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPutTemplateToBodyButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bb856868-e36b-4020-a9ee-b307994e84e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6db60bf3-6a13-45b0-83e6-1191e71ef26b"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PutTemplateToBodyButtonClickEventSubProcess",
				Position = new Point(497, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(311, 221),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPutTemplateToBodyButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePutTemplateToBodyButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("255a7909-1f8d-40aa-8ab8-6ce80e5b7d7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb856868-e36b-4020-a9ee-b307994e84e3"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"PutTemplateToBodyButtonClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PutTemplateToBodyButtonClickStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePutTemplateToBodyButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6efb22f4-8824-4860-aa56-b8699155b574"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb856868-e36b-4020-a9ee-b307994e84e3"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"PutTemplateToBodyButtonClickScriptTask",
				Position = new Point(148, 85),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,59,107,195,48,16,199,103,7,242,29,174,206,34,131,17,238,156,54,67,95,33,148,134,64,76,23,227,65,88,215,32,72,164,114,58,167,53,38,223,189,178,211,146,7,245,160,65,210,239,255,184,219,43,2,143,91,172,24,245,210,105,244,112,15,43,181,65,249,166,42,114,62,39,196,57,25,45,215,231,204,116,60,50,31,32,46,116,242,209,213,150,97,6,89,2,237,120,20,117,192,205,5,81,100,165,124,87,219,186,103,45,43,99,253,43,54,34,94,41,66,203,11,29,39,71,101,68,200,53,89,96,170,49,36,69,135,112,246,161,230,231,47,183,84,59,124,50,21,27,103,21,53,125,223,127,63,148,135,211,237,110,94,27,157,130,103,50,118,51,155,94,89,6,19,139,95,208,49,98,160,115,113,234,89,202,220,173,123,35,145,36,157,85,191,176,7,167,155,103,109,88,46,172,71,226,28,191,89,116,211,28,35,229,139,163,157,98,17,23,147,54,59,200,246,246,48,41,227,116,96,166,226,239,185,76,97,176,78,39,137,203,36,68,116,29,194,146,206,215,246,3,29,223,80,30,215,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMacrosTreeGridDblClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b7fbffee-5f0a-413d-83d6-9cabf496b4d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bb856868-e36b-4020-a9ee-b307994e84e3"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"MacrosTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"MacrosTreeGridDblClickStartMessage",
				Position = new Point(43, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOKButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOKButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b52a05f2-406a-478c-af14-90f5108c864f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6db60bf3-6a13-45b0-83e6-1191e71ef26b"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"OKButtonClickEventSubProcess",
				Position = new Point(497, 238),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(313, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOKButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5ea94ec9-72c0-4dbf-a1cf-ac5d45e8b7bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b52a05f2-406a-478c-af14-90f5108c864f"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"OKButtonClickStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1fce5211-23c0-49b5-9c0d-6ba346a3f2ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b52a05f2-406a-478c-af14-90f5108c864f"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"OKButtonClickIntermediateThrowMessageEvent",
				Position = new Point(134, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOKButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b26ec7ad-b9a8-45f0-ae47-b0559c55ec3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b52a05f2-406a-478c-af14-90f5108c864f"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"OKButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(218, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,146,79,79,2,49,16,197,207,144,240,29,10,7,82,46,61,155,32,38,178,252,9,38,68,195,162,247,113,119,88,198,148,150,180,179,232,42,126,119,187,85,49,68,56,211,227,235,155,215,223,52,111,7,78,64,198,180,195,133,125,21,3,241,0,5,170,17,48,164,182,116,25,170,219,223,187,126,171,73,43,33,219,103,13,115,155,211,138,48,23,221,174,104,53,27,13,57,243,115,200,156,245,137,213,26,131,203,154,100,13,166,8,142,253,62,26,98,212,2,51,218,18,26,30,231,196,106,137,111,44,218,3,49,69,30,145,223,106,168,158,64,151,232,229,157,183,70,141,208,163,35,208,244,142,215,158,29,153,226,70,166,149,103,220,196,65,53,54,89,128,48,133,122,92,78,174,84,200,72,163,73,30,22,172,181,97,197,232,99,170,236,28,30,239,244,234,115,4,150,216,109,117,81,184,35,128,19,128,67,77,38,191,56,229,127,138,99,84,57,45,41,239,69,224,251,231,151,208,131,9,161,206,103,38,246,134,184,138,204,49,171,134,62,105,153,229,117,222,71,136,75,145,199,134,131,52,36,3,174,10,205,42,55,230,103,189,3,97,47,84,181,241,199,155,194,14,101,212,206,23,114,32,86,160,61,214,166,69,248,32,78,32,91,127,15,125,182,154,14,185,116,70,176,43,177,255,5,121,109,45,6,47,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16aa198c-9585-45bb-a507-8959fe5259f0"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"EventSubProcess4",
				Position = new Point(36, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(694, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRecipientToolButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d1962ed5-bb29-46e3-9a91-4215a23ada3f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddRecipientToolButtonClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"AddRecipientToolButtonClickStartMessage",
				Position = new Point(36, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddRecipientToolButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d95e190d-8981-4624-a190-3ced39db60d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"AddRecipientToolButtonClickScriptTask",
				Position = new Point(274, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,77,79,27,49,16,61,55,82,254,131,181,167,141,72,172,160,134,0,162,65,98,63,64,171,34,37,130,4,14,85,15,102,61,65,166,139,189,29,123,83,69,40,255,157,89,47,132,240,161,80,169,189,216,59,246,188,247,60,243,102,23,2,153,41,65,79,208,228,96,237,119,88,178,81,24,78,1,81,88,51,119,124,150,241,107,184,137,141,118,104,10,203,39,226,22,58,245,194,79,108,233,3,158,105,235,132,206,33,147,124,106,46,29,42,125,27,118,216,14,243,89,245,82,131,133,210,128,124,166,213,239,10,178,228,168,221,82,115,22,94,64,174,74,5,218,157,42,40,36,27,141,88,176,62,10,58,236,161,221,250,226,73,102,22,144,72,52,228,78,25,205,47,233,157,180,39,194,137,31,27,128,159,108,196,214,17,41,172,218,45,40,44,48,53,255,72,40,54,229,242,31,197,94,81,124,42,24,21,74,203,255,160,250,158,167,145,94,135,103,168,100,205,89,83,78,133,253,197,199,100,47,224,139,77,68,210,120,211,88,190,54,112,150,201,163,109,60,244,17,87,136,116,117,66,175,92,64,125,73,92,14,43,216,138,243,129,151,213,240,135,157,85,74,134,65,63,74,251,167,131,225,110,47,138,246,135,189,65,180,55,236,29,236,165,131,94,242,53,74,15,119,247,251,73,20,165,65,135,104,19,229,59,34,112,201,190,89,63,92,93,214,236,199,172,20,40,238,193,1,218,39,238,45,201,97,211,236,135,224,245,176,7,221,55,211,191,234,250,172,188,178,206,220,199,133,177,32,211,69,221,251,238,198,112,62,151,216,220,7,79,24,115,115,71,246,81,165,148,235,27,60,246,7,169,84,142,95,137,162,130,141,255,131,12,91,125,218,180,201,102,125,47,197,110,197,197,116,8,8,242,111,140,241,207,111,166,99,172,207,141,168,65,115,65,35,76,40,4,87,161,110,56,30,1,125,16,105,252,36,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateRecipientGridPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("eb0de878-cf7d-4668-b0b4-9b9dfa51b4c9"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"RecipientGridPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 38),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeRecipientGridPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEditValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e9d9cc5d-41d5-439c-bc37-240f893bde42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"ChangeEditValueScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(596, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,144,77,75,195,64,16,134,207,22,250,31,134,92,154,64,89,244,28,2,106,98,197,131,32,22,189,136,135,37,59,45,3,235,38,236,76,14,37,228,191,155,15,140,198,20,10,130,244,180,51,239,206,59,31,15,237,32,124,198,156,74,66,39,27,66,107,32,73,32,24,165,32,130,122,185,184,24,115,72,224,73,239,81,189,48,250,180,112,14,115,161,194,169,45,50,183,111,166,69,191,253,48,191,131,102,96,241,228,246,113,219,101,136,128,81,94,181,173,112,155,123,42,187,142,131,174,54,133,255,208,18,94,7,245,101,163,190,138,194,85,125,213,172,162,56,88,247,115,199,222,119,134,68,165,182,11,31,178,53,220,163,100,196,165,213,135,222,197,223,71,69,81,55,186,55,15,3,31,181,107,19,175,110,140,25,132,112,186,80,87,223,44,23,104,25,129,118,199,232,164,69,121,248,77,104,162,157,155,210,100,153,83,164,38,197,255,64,235,214,146,51,199,144,205,63,206,205,109,190,209,41,120,115,199,95,9,122,148,202,59,16,95,97,252,9,181,48,152,225,150,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateRecipientGridPageClosedCatchMessageIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("679a8579-a3a3-4f6c-bc37-33bbd0c5d3e8"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"RecipientGridPageClosed",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"RecipientGridPageClosedCatchMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(533, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeAddRecipientScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2a92ea5e-f44d-4ee4-80b3-dbc3b971a57d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdea5279-4554-48f6-9b77-0329be1411b4"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"BeforeAddRecipientScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,77,206,44,200,76,205,43,113,203,76,205,73,81,176,85,80,10,130,137,40,89,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,14,0,0,98,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("08818e31-eb6e-47e5-a4ec-e792d5718f47"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16aa198c-9585-45bb-a507-8959fe5259f0"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"EventSubProcess5",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(208, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCopyRecipientToolButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8612c260-356d-4108-9c11-54a8758cb28c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08818e31-eb6e-47e5-a4ec-e792d5718f47"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CopyRecipientToolButtonClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CopyRecipientToolButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCopyRecipientToolButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d206f9da-8538-4791-b6a1-7d3856335096"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("08818e31-eb6e-47e5-a4ec-e792d5718f47"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"CopyRecipientToolButtonClickScriptTask",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,77,206,44,200,76,205,43,113,203,76,205,73,81,176,85,80,114,206,47,168,12,130,137,42,89,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,17,36,158,6,47,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("23a8a88a-f669-4920-942a-ed1102662084"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16aa198c-9585-45bb-a507-8959fe5259f0"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"EventSubProcess6",
				Position = new Point(344, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(213, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBlindCopyRecipientToolButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2ba49edb-9492-4527-8939-e95d5b79d7db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23a8a88a-f669-4920-942a-ed1102662084"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"BlindCopyRecipientToolButtonClick",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"BlindCopyRecipientToolButtonClickStartMessage",
				Position = new Point(28, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBlindCopyRecipientToolButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eb9ffe01-7645-439a-ab02-b7eb1f14d4fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23a8a88a-f669-4920-942a-ed1102662084"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"BlindCopyRecipientToolButtonClickScriptTask",
				Position = new Point(112, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,77,206,44,200,76,205,43,113,203,76,205,73,81,176,85,80,114,202,201,204,75,113,206,47,168,12,130,73,41,89,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,88,154,69,2,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1c52e533-845b-4e92-87e0-2ee818e4bf4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("50b66d81-3f87-49ee-a3a6-c221d7c8fb4f"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(213, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDataSourceBeforeSaveChildStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6446376c-e104-400b-bb94-fd35959bfc56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c52e533-845b-4e92-87e0-2ee818e4bf4f"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceBeforeSave",
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"DataSourceBeforeSaveChildStartMessage",
				Position = new Point(28, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceBeforeSaveChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e2f27939-e52f-48e6-9d79-ada565579a9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c52e533-845b-4e92-87e0-2ee818e4bf4f"),
				CreatedInOwnerSchemaUId = new Guid("55af33e3-0cf0-4da7-8d6e-25e40c61e768"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Name = @"DataSourceBeforeSaveChildScriptTask",
				Position = new Point(112, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,205,77,10,194,48,16,5,224,181,133,222,33,116,213,130,228,2,165,11,173,138,46,4,49,69,215,177,121,45,133,164,3,233,196,159,219,107,10,122,0,119,143,225,205,247,134,78,228,39,221,67,174,201,188,182,102,96,121,36,3,81,85,66,52,234,138,91,77,35,123,178,147,252,133,61,59,27,139,177,39,119,228,157,102,152,6,79,254,30,139,52,89,204,228,70,179,86,20,124,11,185,106,121,184,227,76,15,169,192,53,217,224,198,139,182,1,121,118,152,34,24,215,179,165,96,31,80,148,105,2,59,225,127,165,211,159,247,200,120,112,240,227,172,150,111,141,121,100,118,233,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShowColumnStructureExplorerMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateSetMetaPathInfoMethod());
			Methods.Add(CreateGetVirtualDataSourceMethod());
			Methods.Add(CreateRegisterObjectMenuItemStateScriptMethod());
			Methods.Add(CreateLoadVirtualDataSourceRowsMethod());
			Methods.Add(CreateGetCurrentObjectSchemaIdMethod());
			Methods.Add(CreateSetEntityBinaryColumnValuesMethod());
			Methods.Add(CreateRegisterNameSubjectRelationScriptMethod());
			Methods.Add(CreateRegisterSaveAsActivityLogicScriptMethod());
			Methods.Add(CreateAddtObjectFieldInActivityValuesMethod());
			Methods.Add(CreateResetCacheMethod());
			Methods.Add(CreateGetColumnCaptionByNameMethod());
			Methods.Add(CreateGetDisplayValuesMethod());
			Methods.Add(CreateFillMenuPriorityMethod());
			Methods.Add(CreateSetPriorityValueMethod());
			Methods.Add(CreatePrepareObjectEditFilterMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f83ce94-cebc-400c-954c-bcb0fa73c690"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec535512-952e-4f67-b052-d83dd8cbca7f"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5375dee1-bc17-46f5-9908-be2eaf10ece0"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6859a846-19bc-45e6-8ad5-b6c619db02aa"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8dee24f2-ec02-4125-a8b6-88b3d5ae47c2"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4d5c769a-260c-4913-9dfd-5f7a68a5f440"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f8edb689-e2d8-463d-a704-b7e060156d18"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9b5b0d1b-9b97-4589-af55-1c6fb98fe533"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2c218d10-9fee-44b9-9d01-ffd4b263a355"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5be5b08a-f619-4ffb-8cee-461181ee9377"),
				Name = "System.Collections.Specialized",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("145d22c5-8ae3-4f84-872d-ade4f79c7308"),
				Name = "System.Collections",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateDataSourceSavedMethodMethod() {
			SchemaMethod method = base.CreateDataSourceSavedMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,73,44,73,12,206,47,45,74,78,13,78,44,75,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,230,242,44,246,77,76,46,202,47,118,206,207,201,73,77,46,201,204,207,115,206,72,204,75,79,77,81,176,85,72,75,204,41,78,181,6,0,178,159,116,235,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d4d22b7-88ab-4c44-817c-a9e60eea270c"),
				Name = "ShowColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f2502fbc-4093-4bd0-9c63-9e5d92db143c"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("76a59b27-6f27-41ee-9b0f-259366a6540c"),
				Name = "macrosIndex",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,81,111,218,48,16,126,14,18,255,193,228,161,74,84,148,238,121,148,77,52,165,136,73,208,74,172,219,67,213,7,47,57,192,82,98,71,142,51,138,38,254,251,206,113,2,4,8,105,94,64,62,223,125,247,249,238,59,59,108,73,156,158,47,162,44,230,11,37,179,64,101,18,198,31,73,36,36,72,95,2,85,16,186,228,95,183,99,153,69,141,167,227,14,186,157,93,183,243,151,74,146,158,236,145,33,113,206,2,92,82,131,132,56,12,41,157,131,12,9,207,162,200,112,145,128,123,220,164,188,187,243,51,41,129,171,25,13,164,72,39,82,100,9,166,140,15,171,57,141,97,96,184,161,27,83,219,69,176,134,152,206,40,167,171,156,222,107,138,103,21,156,67,160,152,224,222,248,220,169,8,79,115,27,70,92,192,241,38,160,166,60,85,148,7,240,176,125,157,134,206,177,19,174,117,137,78,143,229,21,193,154,98,13,236,17,123,115,38,44,92,100,152,98,196,236,212,68,83,242,44,67,144,16,62,178,220,66,229,182,18,190,175,205,33,232,205,24,166,60,132,143,119,141,240,99,36,37,45,195,66,170,232,66,100,50,128,125,179,76,239,42,68,56,108,200,99,179,39,10,197,178,186,157,165,144,196,97,92,17,134,161,95,6,248,119,95,176,242,124,145,113,133,150,219,91,211,235,171,20,154,18,231,186,180,106,195,61,108,11,66,164,74,50,190,242,166,233,28,21,246,44,199,113,162,182,142,161,243,198,222,189,95,52,202,224,222,56,125,115,236,32,15,197,72,219,117,201,119,50,201,88,232,205,97,163,255,29,151,124,205,9,229,139,79,33,92,231,55,3,69,95,168,90,239,155,118,1,45,46,124,236,6,172,66,99,70,195,90,173,70,103,102,87,3,60,108,203,116,78,51,163,134,100,62,77,10,97,212,87,193,184,52,209,46,19,126,2,49,174,186,54,33,107,213,228,8,63,183,201,81,101,158,24,15,143,75,211,174,44,85,84,77,64,95,103,189,118,18,163,171,149,132,21,213,135,208,40,40,19,196,177,172,155,155,82,170,190,136,19,42,161,5,66,159,216,115,193,193,238,19,100,14,46,233,225,220,153,1,187,82,161,81,21,69,223,228,39,38,119,204,179,216,123,161,50,5,71,225,90,44,207,60,250,57,247,22,103,213,69,203,171,214,130,216,144,156,152,204,61,82,156,208,170,52,165,188,248,195,75,198,97,253,101,83,109,173,119,9,51,167,222,66,114,151,40,84,31,18,61,181,142,61,229,10,112,203,40,218,218,89,101,133,90,234,42,205,254,60,177,72,129,76,177,204,101,109,234,217,46,246,238,72,181,126,236,142,81,13,63,252,217,93,27,189,195,123,224,141,194,176,190,207,197,87,197,217,171,105,118,211,107,205,58,164,200,31,156,51,136,197,90,108,198,33,83,191,113,218,197,198,49,179,223,55,223,24,131,255,159,98,181,22,21,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a1ee718-aa4e-4bf2-9c0e-424a1c68deb0"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,203,110,194,48,16,60,131,196,63,184,156,18,21,249,7,80,15,52,77,85,14,8,68,104,123,168,122,88,146,13,4,57,118,100,59,60,132,248,247,174,9,13,180,129,246,18,59,214,236,204,120,198,107,208,172,0,13,57,123,96,18,55,108,134,90,131,81,169,229,175,67,254,142,243,64,73,171,149,48,188,222,76,28,26,45,106,175,155,89,204,205,80,166,170,219,99,63,126,106,204,72,37,200,167,176,241,251,173,78,123,77,90,198,234,50,182,165,198,112,91,8,165,81,159,116,163,223,231,222,4,22,200,199,243,21,198,54,76,50,75,10,177,18,101,46,13,241,19,24,123,44,5,97,104,33,202,76,46,120,152,23,118,231,247,59,237,134,4,15,183,177,40,19,124,2,11,111,32,74,156,237,10,52,39,225,106,250,227,147,237,89,247,49,147,160,119,238,50,207,153,64,183,14,115,114,225,54,129,34,170,46,59,92,229,31,154,104,169,54,209,206,80,4,65,101,146,216,157,201,63,224,227,162,80,134,66,155,98,138,26,101,140,231,145,78,59,80,121,161,36,74,59,88,193,54,92,211,134,33,133,224,142,5,229,74,208,38,109,13,53,60,188,192,18,223,229,40,175,216,238,171,219,215,51,47,32,19,65,169,71,104,71,104,97,2,118,233,186,244,27,211,91,171,161,174,215,240,65,146,120,199,247,227,31,125,55,93,157,243,112,122,174,130,72,149,58,198,186,240,10,64,95,65,77,103,74,122,254,41,1,119,220,120,22,129,70,176,152,156,179,202,82,230,221,221,0,79,113,145,81,39,26,19,159,237,59,237,86,211,221,55,226,40,218,250,151,230,44,123,184,233,240,90,55,253,47,146,193,222,233,103,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetMetaPathInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b8415de0-7e33-41d5-8784-22ad4206143a"),
				Name = "SetMetaPathInfo",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("88dd9ecb-dc74-4492-9115-5c9969415295"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a4452b55-50e7-454e-83ad-d349f8620b8e"),
				Name = "e",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,189,106,195,64,16,132,107,27,252,14,107,87,82,163,23,8,46,130,148,66,38,198,33,14,105,140,139,69,183,118,14,164,91,152,91,57,254,33,239,158,115,254,8,74,147,118,152,239,155,57,48,168,227,6,26,105,78,139,168,161,168,36,10,60,183,254,44,153,20,119,71,3,63,48,184,19,19,196,205,204,155,116,177,14,59,157,109,115,226,72,139,91,128,79,55,147,241,225,199,84,106,219,74,99,94,67,114,46,135,81,98,86,112,2,113,149,255,72,24,87,220,239,40,27,226,155,178,7,36,216,167,163,14,78,142,219,226,73,215,6,31,246,89,78,211,249,215,226,175,48,167,203,100,60,250,143,137,190,233,180,62,170,227,240,104,249,194,97,47,46,181,12,189,92,59,247,202,238,217,195,122,110,43,54,94,107,143,70,30,245,53,254,57,158,167,250,219,59,210,92,86,42,91,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("afeea135-9ac3-40ac-b1a4-e1ad5d30a627"),
				Name = "GetVirtualDataSource",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,3,17,206,249,121,37,137,153,121,169,69,122,110,153,121,41,48,145,162,252,28,141,176,204,162,146,210,196,28,151,196,146,196,224,252,210,162,228,84,79,23,77,133,196,98,5,12,113,107,0,231,40,17,24,84,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRegisterObjectMenuItemStateScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1a16919-fd05-40f1-a0c5-dad519b67d91"),
				Name = "RegisterObjectMenuItemStateScript",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,79,139,194,48,16,197,207,21,252,14,163,151,38,32,97,61,23,65,113,119,193,131,236,130,224,61,54,99,27,169,169,164,211,117,161,228,187,155,63,235,138,94,50,121,243,126,239,29,230,71,90,232,74,171,47,4,11,232,200,106,83,137,207,214,158,37,177,241,40,91,78,135,55,39,90,19,254,89,94,214,210,84,152,207,32,168,99,111,74,210,222,226,195,16,116,166,143,192,2,93,33,237,101,211,35,227,48,89,64,158,115,248,3,178,97,238,68,135,180,150,151,24,12,48,225,47,241,34,217,177,192,35,181,86,10,205,35,150,114,117,123,101,119,210,185,56,157,3,108,58,124,234,247,97,188,115,9,139,47,47,166,51,63,190,101,133,226,235,112,194,146,62,148,38,177,110,52,26,218,188,191,120,91,52,253,134,240,252,239,143,71,161,50,18,187,120,172,173,52,94,88,177,82,42,45,88,58,34,47,110,44,161,106,6,81,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLoadVirtualDataSourceRowsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8f1c28ac-556c-406b-8b7e-a446b1a8b4ae"),
				Name = "LoadVirtualDataSourceRows",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("965fc91c-9b73-4d4d-82be-bcbae6e9f16f"),
				Name = "macrosCollection",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "OrderedDictionary",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,219,106,194,64,16,125,86,240,31,150,60,37,32,249,1,219,130,104,43,246,34,161,138,47,226,195,144,157,218,133,117,87,38,27,67,40,254,123,119,55,90,47,73,176,47,9,153,156,57,115,206,153,73,96,131,241,7,164,164,179,5,33,78,72,240,120,36,17,40,140,6,189,238,30,136,237,5,153,28,228,24,12,204,117,78,41,178,71,150,184,46,247,24,105,101,64,40,164,248,69,40,126,170,144,150,225,242,182,109,58,142,24,100,172,86,119,99,110,107,55,18,118,64,168,204,148,207,96,139,99,145,26,161,21,80,105,117,40,44,216,185,240,48,201,5,239,179,204,144,80,155,39,223,253,165,9,33,253,14,29,203,214,187,156,144,206,119,76,168,227,231,72,75,137,158,32,98,63,189,110,199,1,73,23,150,187,65,148,229,50,248,169,11,79,221,185,84,102,241,110,120,60,195,194,189,43,128,229,137,231,104,236,136,124,171,150,32,115,12,131,41,15,250,127,93,173,40,103,212,226,194,240,108,238,217,198,90,70,23,30,162,248,13,203,86,134,228,56,194,178,168,92,202,74,112,205,209,144,243,208,118,251,191,205,33,175,78,229,181,181,120,95,79,188,208,115,31,127,149,64,61,126,151,252,29,26,239,192,157,202,235,144,8,202,106,47,157,127,46,165,61,244,235,253,180,131,143,217,87,146,86,65,10,59,39,53,88,183,119,92,100,125,181,217,59,129,31,122,221,67,211,237,191,107,224,214,79,230,13,37,109,167,223,188,174,193,47,243,171,204,217,208,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCurrentObjectSchemaIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("714470b1-774d-4b7c-8119-3e11ec153a20"),
				Name = "GetCurrentObjectSchemaId",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bb745c7d-a366-4e1e-872f-66faeb5708da"),
				Name = "objectId",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,201,10,194,48,20,69,247,130,255,16,186,170,32,249,1,7,80,81,233,66,65,234,176,142,205,67,171,237,75,205,208,146,191,55,109,180,212,226,238,13,247,158,123,75,38,9,168,23,153,17,132,138,172,81,167,218,198,201,29,114,118,48,32,109,120,82,32,87,2,17,18,157,10,164,93,193,142,33,187,129,28,147,224,92,197,86,249,99,132,23,33,159,170,96,9,4,163,201,112,224,216,116,193,249,74,100,38,199,48,56,69,188,57,151,46,86,53,6,79,116,249,181,114,11,218,239,189,220,49,17,215,135,27,35,222,154,191,129,158,236,252,93,28,245,63,234,159,138,110,82,228,75,187,103,57,252,171,16,113,103,255,245,187,34,71,91,192,167,247,153,101,6,166,91,147,242,121,216,11,166,29,69,205,175,201,18,180,145,216,194,39,111,16,65,124,226,100,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntityBinaryColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("12d6682c-c56b-4cac-982f-547fd14c2f75"),
				Name = "SetEntityBinaryColumnValues",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4418d170-29f1-40fb-a344-6d568041e986"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,91,107,194,48,24,134,175,21,252,15,89,175,18,144,92,15,60,128,103,28,27,14,117,187,207,154,79,253,70,77,36,73,117,221,216,127,95,210,186,147,173,131,225,69,161,77,243,61,207,155,55,160,28,186,140,47,192,245,51,7,246,81,36,41,208,104,14,49,238,16,148,139,154,100,145,89,7,91,190,132,23,199,71,42,214,18,213,154,63,44,199,215,124,114,28,162,55,86,43,143,48,40,18,124,5,250,53,205,24,107,53,234,80,169,24,232,93,118,153,230,23,225,47,85,63,65,37,47,247,149,49,133,20,87,132,78,237,157,136,141,182,3,157,36,16,59,212,106,176,17,106,13,146,145,183,70,189,182,23,134,108,79,54,144,14,57,157,33,194,146,153,145,96,64,14,49,95,17,38,107,29,231,237,49,136,8,235,183,104,157,7,40,56,144,240,218,254,222,62,82,206,100,93,26,130,213,86,218,128,136,55,52,140,163,63,45,65,85,138,81,4,172,149,232,188,39,37,165,39,92,22,40,57,250,221,63,149,109,7,88,84,28,204,183,28,190,254,223,116,41,12,99,30,20,188,94,27,14,163,159,158,125,250,49,66,34,167,170,231,35,238,125,144,169,244,141,220,139,53,240,161,112,98,161,83,19,3,207,127,194,92,31,130,108,153,237,192,223,96,146,110,85,30,182,61,73,81,118,105,52,171,194,69,159,119,123,78,118,213,33,52,0,88,238,172,100,140,36,58,158,171,138,154,207,167,243,37,254,8,118,46,82,243,63,198,80,215,7,234,19,141,76,223,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRegisterNameSubjectRelationScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("de310b01-260b-4c25-b6b9-10771450bfd0"),
				Name = "RegisterNameSubjectRelationScript",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,61,11,131,48,16,134,103,5,255,195,213,193,24,144,208,206,34,180,244,3,58,180,20,10,221,83,141,105,138,198,18,99,151,224,127,111,18,169,224,13,247,245,188,119,112,247,165,10,250,82,137,143,134,2,122,173,132,228,228,212,169,150,234,52,10,131,109,108,214,35,233,164,203,3,84,190,168,228,12,101,224,170,122,144,165,22,22,97,48,198,53,2,81,67,234,228,156,233,7,109,6,102,201,170,0,132,32,73,252,132,53,179,89,224,194,225,121,222,211,254,79,151,155,112,238,37,227,232,130,247,56,143,51,27,110,148,51,114,165,45,59,86,66,147,125,35,152,212,231,195,76,238,195,243,205,74,189,128,81,232,182,77,216,95,126,161,210,22,138,236,170,106,106,164,211,71,112,254,3,181,42,224,201,30,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRegisterSaveAsActivityLogicScriptMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("129e9783-00e3-437d-bc51-a642a972edf2"),
				Name = "RegisterSaveAsActivityLogicScript",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,81,79,131,48,16,199,159,89,178,239,208,236,133,54,89,26,198,235,130,17,167,75,246,96,52,153,241,189,163,7,171,98,49,237,129,26,194,119,183,133,201,156,217,124,225,122,189,223,159,251,115,92,35,12,177,153,81,239,72,18,98,209,40,93,240,117,101,222,4,210,233,36,184,158,181,81,199,43,237,207,65,152,237,33,123,13,231,196,39,121,173,51,84,174,194,218,214,231,129,202,9,245,112,15,129,36,73,66,208,212,192,200,161,62,0,139,142,91,172,12,240,2,112,85,213,26,41,35,87,36,58,82,129,71,64,139,93,9,148,45,15,119,23,165,174,201,226,151,182,23,91,192,103,81,214,144,106,249,4,159,120,42,76,145,70,140,75,129,130,55,30,154,147,75,101,116,218,209,64,215,13,135,159,216,198,127,77,118,29,129,210,194,232,197,191,86,42,123,242,29,231,220,133,110,158,97,56,18,241,25,85,220,171,86,195,92,105,46,92,155,177,169,15,253,147,45,103,115,23,30,69,1,124,43,26,72,109,234,254,79,163,240,235,78,42,228,171,82,129,198,205,237,200,60,236,94,32,195,181,130,82,110,244,255,232,118,95,125,220,64,238,70,180,5,45,221,130,156,96,211,137,55,51,128,253,30,221,11,237,18,195,83,41,135,11,58,236,23,91,126,3,251,197,70,254,108,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddtObjectFieldInActivityValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1a3c934-c6c8-4138-b3eb-b18841088492"),
				Name = "AddtObjectFieldInActivityValues",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("53c7b5d0-0e03-4967-a1fd-bbe00620048c"),
				Name = "schemaId",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,81,79,194,48,20,133,159,71,194,127,168,60,144,17,73,131,207,168,201,196,105,150,40,18,80,223,47,235,69,106,182,110,105,239,16,98,248,239,182,43,144,12,141,240,184,222,179,239,220,115,186,77,224,3,249,203,252,19,83,122,144,152,137,68,69,41,201,149,164,77,44,36,241,81,134,160,19,194,220,132,189,97,187,181,2,205,96,55,159,165,75,204,129,221,176,55,131,122,84,40,101,17,178,80,60,86,116,152,62,131,178,124,205,31,145,18,101,8,84,138,119,155,49,228,24,118,246,54,29,199,149,138,88,90,100,85,174,204,184,202,231,168,45,118,176,243,91,72,109,104,84,15,19,97,207,31,43,41,120,156,151,180,105,8,160,116,238,118,110,72,75,245,113,80,44,10,141,144,46,67,167,244,22,76,170,163,16,220,227,77,143,125,183,91,129,92,176,208,43,249,20,23,168,209,110,237,117,111,110,1,235,80,63,36,194,203,131,201,255,21,70,66,184,2,247,72,203,232,239,22,225,187,165,93,3,65,208,200,127,121,233,206,182,237,214,214,103,52,176,194,200,236,185,54,101,109,122,15,4,179,162,210,41,242,122,132,211,226,203,117,253,186,41,81,248,76,239,144,85,120,61,47,138,236,54,236,204,26,20,223,188,13,219,132,31,151,112,184,145,27,118,117,94,226,89,101,74,84,34,250,132,117,188,66,69,254,219,57,253,26,82,189,109,164,196,43,174,41,108,92,124,191,113,205,103,241,166,104,170,28,143,183,216,254,25,238,150,13,88,183,203,46,78,32,99,5,243,12,207,188,120,47,62,184,110,125,217,191,124,61,236,4,235,73,26,154,104,44,65,163,251,7,72,87,56,12,44,243,7,245,159,221,203,191,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetCacheMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4a9475b1-b15b-4294-9fb2-e7e25ed6d220"),
				Name = "ResetCache",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,78,45,46,6,210,206,137,201,25,169,122,174,21,5,153,69,169,238,69,249,165,5,26,33,193,64,85,105,153,233,165,69,137,96,133,96,21,161,37,153,57,153,37,153,169,197,122,174,185,137,153,57,33,169,185,5,57,137,37,169,96,57,176,54,77,107,0,105,141,106,27,96,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnCaptionByNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1f91b033-bb9a-4b28-85f2-bf62233abda4"),
				Name = "GetColumnCaptionByName",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a7d06c73-e5d8-406f-9fdb-d72d0c9137f6"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd3cfd96-e9f1-4c6b-a544-c06f826f0623"),
				Name = "name",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,206,207,41,205,205,43,86,176,85,40,78,206,72,205,77,212,115,134,8,88,243,114,165,229,23,165,38,38,103,40,104,148,193,213,41,100,230,193,116,104,42,84,243,114,113,102,166,41,104,64,4,244,252,18,115,83,21,108,109,21,242,128,52,68,146,179,40,181,164,180,8,166,67,207,57,177,160,36,51,63,15,104,50,103,45,47,23,16,241,114,65,21,20,151,20,101,230,165,235,185,230,22,148,84,90,3,0,80,2,41,248,150,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDisplayValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("39bb3ebc-9684-4b78-88d7-d5db23974ce8"),
				Name = "GetDisplayValues",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d0ef1529-a587-44c5-8d1c-fba9ef12f16c"),
				Name = "encoded",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,189,14,130,64,16,132,107,73,120,135,13,21,52,215,88,18,11,255,10,91,197,7,56,96,193,77,142,189,203,178,96,140,241,221,5,180,208,246,155,153,204,55,90,1,71,189,194,6,10,20,177,189,111,212,236,61,55,212,14,98,149,60,155,99,103,201,21,216,5,103,21,175,74,142,244,97,14,88,249,26,207,88,81,32,100,189,168,16,183,41,242,76,235,44,143,163,15,217,13,228,106,20,232,203,233,128,241,14,127,56,157,139,141,23,180,213,13,210,113,82,209,33,56,4,226,197,41,131,103,28,173,250,210,108,67,64,174,211,37,52,39,197,110,61,15,127,146,36,135,100,70,175,56,18,212,65,120,58,52,133,255,90,101,249,27,169,212,38,176,230,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillMenuPriorityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8a576299-fe85-4786-9ed2-aefab8776518"),
				Name = "FillMenuPriority",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,75,79,34,65,16,62,99,226,127,232,204,169,39,146,142,158,89,76,16,89,195,1,131,128,187,151,77,76,59,83,224,184,51,221,108,79,15,72,12,255,221,234,199,60,213,93,215,131,208,213,95,125,245,250,170,217,113,69,120,164,147,93,162,15,115,149,72,133,159,147,229,29,25,18,1,123,50,17,26,207,203,232,9,50,126,87,128,58,208,251,28,212,88,10,1,232,35,5,107,2,102,92,240,13,168,62,9,70,29,194,32,28,156,158,236,48,82,18,143,101,90,100,2,233,63,8,202,70,177,191,167,193,52,174,156,4,207,224,171,110,183,136,69,71,226,60,183,30,132,183,169,75,248,19,134,27,208,174,146,26,217,169,212,36,227,72,31,11,173,45,209,28,171,101,37,203,149,181,250,140,51,16,5,2,28,146,205,240,132,23,198,200,22,144,201,29,140,210,148,26,194,92,171,68,108,44,124,25,169,100,171,209,201,217,216,36,219,234,67,217,181,12,35,185,10,239,167,241,39,37,44,164,212,110,14,204,65,115,83,213,213,193,116,4,219,153,109,130,144,161,183,167,204,45,242,75,108,206,105,45,21,240,232,137,54,219,74,18,241,65,139,67,242,122,122,210,107,226,108,148,242,96,178,90,29,182,224,71,246,131,167,5,124,187,41,146,248,146,150,234,96,38,103,211,159,22,203,152,111,253,4,255,74,229,250,119,73,107,213,120,186,146,207,116,123,170,33,243,18,95,129,82,60,151,107,141,133,178,159,240,136,35,215,74,166,57,171,190,204,188,131,29,89,175,116,103,83,51,21,79,226,177,214,68,93,3,122,75,89,168,200,0,154,151,206,200,42,177,97,122,125,11,110,204,163,154,141,189,113,80,156,77,198,213,161,81,104,163,15,30,137,130,245,176,105,45,24,132,173,121,154,67,131,203,197,106,234,169,45,176,158,251,67,135,99,171,224,49,42,64,67,124,117,24,61,243,23,244,154,188,104,54,205,205,97,1,127,10,200,117,11,237,152,205,96,217,45,236,205,103,167,127,102,42,181,222,191,75,149,113,77,131,215,243,227,67,89,215,195,235,197,49,232,251,45,26,167,9,8,61,189,238,55,202,102,43,185,180,238,184,248,65,216,166,95,241,77,171,69,53,182,141,123,47,43,111,105,161,76,149,147,29,38,144,155,68,162,223,204,30,200,217,144,196,144,194,6,251,66,229,227,51,46,0,201,65,196,230,17,252,183,174,42,206,145,218,228,4,66,171,26,163,208,168,80,10,205,179,90,168,142,148,240,252,63,228,58,40,233,182,220,176,121,166,14,55,155,219,203,175,49,251,55,142,24,226,100,77,104,77,108,131,34,176,64,170,225,144,156,251,21,232,41,208,133,178,157,236,29,205,191,134,71,185,62,221,132,172,221,197,48,201,199,92,243,106,147,236,139,123,93,91,48,235,250,52,40,211,106,186,224,122,22,105,26,118,147,169,33,204,254,86,193,66,238,217,18,116,99,191,104,48,175,180,19,244,237,150,27,17,19,218,77,24,133,230,164,87,109,139,249,65,162,165,116,42,181,117,95,248,82,241,251,68,196,24,29,133,143,119,168,248,193,47,129,241,106,125,86,186,175,76,55,32,64,161,228,252,96,28,49,213,170,128,190,43,183,27,243,236,163,53,99,27,176,69,208,144,241,56,182,15,92,153,202,197,49,116,89,188,219,189,119,105,217,80,118,46,88,180,207,164,142,108,110,143,111,39,42,131,141,99,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetPriorityValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("66c1f126-1487-4430-a8d6-f287dd1b303b"),
				Name = "SetPriorityValue",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36bc177c-5fd2-425f-81c5-75f2bbe53c62"),
				Name = "guidStr",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,77,106,195,48,16,133,215,54,248,14,67,86,22,24,93,32,120,209,186,161,120,17,8,113,232,94,181,39,142,64,63,169,44,37,132,146,187,119,44,219,117,187,155,25,125,51,239,233,201,51,228,125,144,93,227,29,148,37,188,83,201,119,250,234,31,252,100,105,38,77,159,51,150,165,137,67,31,156,217,102,233,77,56,248,12,222,91,3,37,28,68,143,252,224,164,117,210,63,94,227,116,70,52,154,64,192,68,242,61,117,244,112,182,14,69,123,129,124,33,106,143,26,164,137,53,131,111,210,145,228,103,136,186,124,247,21,132,26,242,133,227,39,209,23,48,123,45,96,50,87,89,125,21,78,14,164,81,5,231,208,248,42,40,114,138,117,111,72,172,18,3,178,233,112,50,106,118,194,139,198,6,215,226,98,254,109,157,136,1,214,110,59,174,140,102,254,174,148,96,130,82,99,28,201,26,72,146,172,8,127,105,189,188,225,209,222,121,131,190,178,42,104,243,33,84,192,124,179,164,84,119,155,2,12,222,99,212,240,239,119,140,197,115,115,102,181,38,127,100,243,151,136,131,145,120,102,233,243,7,196,59,187,146,184,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareObjectEditFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b1eb8261-fceb-41aa-90e8-e11404ed0a4a"),
				Name = "PrepareObjectEditFilter",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fcdb308e-84bf-4261-b025-4831293e3bb8"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0e2d6a26-73a3-44ea-966d-ce9b7b3774c6"),
				Name = "e",
				CreatedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				ModifiedInSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LookupEditEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,203,110,194,48,16,60,23,137,127,88,229,20,4,138,184,67,145,170,64,17,7,42,42,74,47,40,7,151,108,192,149,99,167,182,67,27,161,252,123,55,113,130,120,157,146,221,157,157,153,29,31,153,6,148,150,219,98,189,59,96,202,222,115,212,5,60,131,196,95,152,221,246,253,141,65,29,42,41,113,103,185,146,193,37,96,201,36,219,163,30,128,183,46,204,82,197,185,64,55,246,122,163,110,231,72,50,166,48,14,186,136,67,37,242,84,146,204,157,116,240,18,55,83,191,34,186,84,216,44,226,51,87,189,199,209,60,164,152,163,117,123,68,36,156,213,27,231,21,141,250,250,166,98,27,1,143,13,149,60,1,191,101,13,66,149,75,11,19,24,246,224,212,237,60,17,162,137,164,89,186,6,70,180,94,2,10,131,143,209,17,156,230,57,143,131,89,154,217,162,172,192,221,78,162,52,248,156,68,56,97,135,35,250,140,225,154,149,122,253,254,89,127,203,163,246,86,66,80,85,93,249,81,100,216,164,245,201,68,142,227,74,102,226,223,5,29,188,177,20,123,78,216,229,151,112,97,81,215,241,5,175,238,159,198,77,183,122,3,191,242,63,229,117,90,76,23,99,99,53,151,251,65,115,210,4,78,64,190,78,222,78,165,25,211,220,40,89,121,241,6,224,200,194,171,118,48,251,201,153,40,7,110,69,96,98,103,127,153,70,99,136,219,25,92,49,123,160,101,143,94,184,133,229,6,167,220,100,130,21,245,105,52,77,24,37,220,142,53,223,31,46,104,86,76,211,137,164,92,131,13,161,41,179,178,236,141,254,1,173,159,14,190,224,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplateEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"));
		}

		#endregion

	}

	#endregion

}

