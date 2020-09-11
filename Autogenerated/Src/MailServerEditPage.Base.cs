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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: MailServerEditPage_Base_TerrasoftSchema

	/// <exclude/>
	public class MailServerEditPage_Base_TerrasoftSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _downloading;
		public Terrasoft.UI.WebControls.Controls.Label Downloading {
			get {
				return _downloading;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _allowEmailDownloadingCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailDownloadingCheckBox {
			get {
				return _allowEmailDownloadingCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _emailProtocolComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit EmailProtocolComboBoxEdit {
			get {
				return _emailProtocolComboBoxEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _addressEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit AddressEdit {
			get {
				return _addressEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _portEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PortEdit {
			get {
				return _portEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _useSSLEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox UseSSLEdit {
			get {
				return _useSSLEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isStartTlsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsStartTlsEdit {
			get {
				return _isStartTlsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _sending;
		public Terrasoft.UI.WebControls.Controls.Label Sending {
			get {
				return _sending;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _allowEmailSendingCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailSendingCheckBox {
			get {
				return _allowEmailSendingCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _sMTPServerAddressTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SMTPServerAddressTextEdit {
			get {
				return _sMTPServerAddressTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _sMTPPortEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit SMTPPortEdit {
			get {
				return _sMTPPortEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _sMTPServerTimeoutEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit SMTPServerTimeoutEdit {
			get {
				return _sMTPServerTimeoutEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _useSSLforSendingCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox UseSSLforSendingCheckBox {
			get {
				return _useSSLforSendingCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _loginParametersControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LoginParametersControlLayout {
			get {
				return _loginParametersControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _useLoginRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton UseLoginRadioButton {
			get {
				return _useLoginRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _useUserNameAsLoginRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton UseUserNameAsLoginRadioButton {
			get {
				return _useUserNameAsLoginRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _useEmailAddressAsLoginRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton UseEmailAddressAsLoginRadioButton {
			get {
				return _useEmailAddressAsLoginRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _imageAndSettingsLabel;
		public Terrasoft.UI.WebControls.Controls.Label ImageAndSettingsLabel {
			get {
				return _imageAndSettingsLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FileUploadEdit _logoEdit;
		public Terrasoft.UI.WebControls.Controls.FileUploadEdit LogoEdit {
			get {
				return _logoEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public MailServerEditPage_Base_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public MailServerEditPage_Base_TerrasoftSchema(MailServerEditPage_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			RealUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			Name = "MailServerEditPage_Base_Terrasoft";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 490;
			Height = 510;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailServerEditPage_Base_TerrasoftEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateNameEdit());
			MainControlLayout.InsertItem(1, CreateDownloading());
			MainControlLayout.InsertItem(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateAllowEmailDownloadingCheckBox());
			ControlLayout2.InsertItem(1, CreateEmailProtocolComboBoxEdit());
			MainControlLayout.InsertItem(3, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateAddressEdit());
			ControlLayout1.InsertItem(1, CreatePortEdit());
			MainControlLayout.InsertItem(4, CreateUseSSLEdit());
			MainControlLayout.InsertItem(5, CreateIsStartTlsEdit());
			MainControlLayout.InsertItem(6, CreateSending());
			MainControlLayout.InsertItem(7, CreateAllowEmailSendingCheckBox());
			MainControlLayout.InsertItem(8, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateSMTPServerAddressTextEdit());
			ControlLayout3.InsertItem(1, CreateSMTPPortEdit());
			MainControlLayout.InsertItem(9, CreateSMTPServerTimeoutEdit());
			MainControlLayout.InsertItem(10, CreateUseSSLforSendingCheckBox());
			MainControlLayout.InsertItem(11, CreateLoginParametersControlLayout());
			LoginParametersControlLayout.InsertItem(0, CreateUseLoginRadioButton());
			LoginParametersControlLayout.InsertItem(1, CreateUseUserNameAsLoginRadioButton());
			LoginParametersControlLayout.InsertItem(2, CreateUseEmailAddressAsLoginRadioButton());
			MainControlLayout.InsertItem(12, CreateImageAndSettingsLabel());
			MainControlLayout.InsertItem(13, CreateLogoEdit());
			MainControlLayout.MoveItem(14, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateMailServerEditPage_Base_TerrasoftEventsProcessSchema() {
			var schema = new MailServerEditPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("f0bd1c16-fa78-4113-bc72-1769b9084e50");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_nameEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.AlignedByCaption = false;
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("18f30cbf-f3df-4c62-bc00-19eb53a6b11c");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateDownloading() {
			_downloading = new Terrasoft.UI.WebControls.Controls.Label();
			_downloading.UId = new Guid("48fad0f4-fc5a-4c6e-9647-426e91e98cca");
			_downloading.Name = "Downloading";
			_downloading.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_downloading.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_downloading.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_downloading.Tag = "";
			_downloading.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_downloading.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_downloading.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _downloading;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateAllowEmailDownloadingCheckBox() {
			_allowEmailDownloadingCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_allowEmailDownloadingCheckBox.UId = new Guid("0bf6fdd4-920b-46ec-a8c1-55f9666a5504");
			_allowEmailDownloadingCheckBox.Name = "AllowEmailDownloadingCheckBox";
			_allowEmailDownloadingCheckBox.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_allowEmailDownloadingCheckBox.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_allowEmailDownloadingCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_allowEmailDownloadingCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_allowEmailDownloadingCheckBox.Tag = "";
			_allowEmailDownloadingCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allowEmailDownloadingCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(90);
			_allowEmailDownloadingCheckBox.AlignedByCaption = false;
			_allowEmailDownloadingCheckBox.DataSource = "DataSource";
			_allowEmailDownloadingCheckBox.ColumnUId = new Guid("bc02dafc-5b71-4592-9655-b0b3411f0b22");
			return _allowEmailDownloadingCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateEmailProtocolComboBoxEdit() {
			_emailProtocolComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_emailProtocolComboBoxEdit.UId = new Guid("1e61e092-f91b-4f20-870b-4ed0f379ee03");
			_emailProtocolComboBoxEdit.Name = "EmailProtocolComboBoxEdit";
			_emailProtocolComboBoxEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_emailProtocolComboBoxEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_emailProtocolComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_emailProtocolComboBoxEdit.Tag = "";
			_emailProtocolComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_emailProtocolComboBoxEdit.Image = new ControlImage {};
			_emailProtocolComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(20);
			_emailProtocolComboBoxEdit.AlignedByCaption = false;
			_emailProtocolComboBoxEdit.DataSource = "DataSource";
			_emailProtocolComboBoxEdit.ColumnUId = new Guid("88630829-7cbf-45eb-b42b-c52604b87fcd");
			return _emailProtocolComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("8d8735ca-a51b-4c0a-89bf-5fc2d37cde89");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_controlLayout2.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(74);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateAddressEdit() {
			_addressEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_addressEdit.UId = new Guid("5c609af3-fe72-4087-8e9b-e6738472df1d");
			_addressEdit.Name = "AddressEdit";
			_addressEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_addressEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_addressEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addressEdit.Tag = "";
			_addressEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addressEdit.Image = new ControlImage {};
			_addressEdit.Width = System.Web.UI.WebControls.Unit.Percentage(75);
			_addressEdit.Margins = "0 0 0 0";
			_addressEdit.DataSource = "DataSource";
			_addressEdit.ColumnUId = new Guid("fb50fe98-c183-43a9-aaba-f6cbac6438a6");
			return _addressEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePortEdit() {
			_portEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_portEdit.UId = new Guid("874e1704-ef80-4bca-95d5-c228fd4dfaa4");
			_portEdit.Name = "PortEdit";
			_portEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_portEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_portEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_portEdit.Tag = "";
			_portEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_portEdit.Image = new ControlImage {};
			_portEdit.Width = System.Web.UI.WebControls.Unit.Percentage(25);
			_portEdit.DataSource = "DataSource";
			_portEdit.ColumnUId = new Guid("4b2324ef-e3ce-4eab-81bd-59b65a61a51f");
			return _portEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("2e155c6e-051a-456a-8d44-d2f15e51bb6c");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_controlLayout1.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.Padding = "0 0 0 20";
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateUseSSLEdit() {
			_useSSLEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_useSSLEdit.UId = new Guid("3eaf7bf2-e1b7-4381-a2c4-451520856604");
			_useSSLEdit.Name = "UseSSLEdit";
			_useSSLEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useSSLEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useSSLEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_useSSLEdit.Tag = "";
			_useSSLEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useSSLEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useSSLEdit.AlignedByCaption = false;
			_useSSLEdit.Margins = "0 0 5 20";
			_useSSLEdit.DataSource = "DataSource";
			_useSSLEdit.ColumnUId = new Guid("27984b71-9d4b-4e4a-b283-3b464e2b4ce7");
			return _useSSLEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsStartTlsEdit() {
			_isStartTlsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isStartTlsEdit.UId = new Guid("7a61a4b8-30df-411e-8ee2-f9c885963f91");
			_isStartTlsEdit.Name = "IsStartTlsEdit";
			_isStartTlsEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_isStartTlsEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_isStartTlsEdit.CreatedInPackageId = new Guid("d96ae870-4bfc-40ec-921c-ada84236f3fa");
			_isStartTlsEdit.Tag = "";
			_isStartTlsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isStartTlsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isStartTlsEdit.AlignedByCaption = false;
			_isStartTlsEdit.Margins = "0 0 5 20";
			_isStartTlsEdit.DataSource = "DataSource";
			_isStartTlsEdit.ColumnUId = new Guid("04eb56a7-1ebb-4097-9482-5606aad37dbd");
			return _isStartTlsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateSending() {
			_sending = new Terrasoft.UI.WebControls.Controls.Label();
			_sending.UId = new Guid("87de03ad-cbc4-482d-ba32-324b9c6e292e");
			_sending.Name = "Sending";
			_sending.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sending.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sending.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sending.Tag = "";
			_sending.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_sending.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sending.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sending.Margins = "0 0";
			return _sending;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateAllowEmailSendingCheckBox() {
			_allowEmailSendingCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_allowEmailSendingCheckBox.UId = new Guid("269c64ad-3e02-4ba0-aed8-298d9efa8c5a");
			_allowEmailSendingCheckBox.Name = "AllowEmailSendingCheckBox";
			_allowEmailSendingCheckBox.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_allowEmailSendingCheckBox.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_allowEmailSendingCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_allowEmailSendingCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_allowEmailSendingCheckBox.Tag = "";
			_allowEmailSendingCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allowEmailSendingCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allowEmailSendingCheckBox.AlignedByCaption = false;
			_allowEmailSendingCheckBox.DataSource = "DataSource";
			_allowEmailSendingCheckBox.ColumnUId = new Guid("bed6388d-8091-4131-a968-55f663580fc1");
			return _allowEmailSendingCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSMTPServerAddressTextEdit() {
			_sMTPServerAddressTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_sMTPServerAddressTextEdit.UId = new Guid("a830da30-e000-4dc1-a6b1-ae2f2abdbdc9");
			_sMTPServerAddressTextEdit.Name = "SMTPServerAddressTextEdit";
			_sMTPServerAddressTextEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sMTPServerAddressTextEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sMTPServerAddressTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sMTPServerAddressTextEdit.Tag = "";
			_sMTPServerAddressTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sMTPServerAddressTextEdit.Image = new ControlImage {};
			_sMTPServerAddressTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(75);
			_sMTPServerAddressTextEdit.Margins = "0 0 0 20";
			_sMTPServerAddressTextEdit.DataSource = "DataSource";
			_sMTPServerAddressTextEdit.ColumnUId = new Guid("93372eb5-7fb0-40cf-a368-8504035a8be2");
			return _sMTPServerAddressTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateSMTPPortEdit() {
			_sMTPPortEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_sMTPPortEdit.UId = new Guid("cdfb20ac-f051-4e99-adc0-1bcf4d9ce24f");
			_sMTPPortEdit.Name = "SMTPPortEdit";
			_sMTPPortEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sMTPPortEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sMTPPortEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sMTPPortEdit.Tag = "";
			_sMTPPortEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sMTPPortEdit.Image = new ControlImage {};
			_sMTPPortEdit.Width = System.Web.UI.WebControls.Unit.Percentage(25);
			_sMTPPortEdit.DataSource = "DataSource";
			_sMTPPortEdit.ColumnUId = new Guid("3c503717-dd92-49df-9b4e-2f2d4786adf8");
			return _sMTPPortEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("1ab1b5bd-8ba7-43df-b932-62231efcdf30");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_controlLayout3.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.Padding = "0 0 0 20";
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateSMTPServerTimeoutEdit() {
			_sMTPServerTimeoutEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_sMTPServerTimeoutEdit.UId = new Guid("c45f3217-4d7c-4b20-884b-a5e6929574ca");
			_sMTPServerTimeoutEdit.Name = "SMTPServerTimeoutEdit";
			_sMTPServerTimeoutEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sMTPServerTimeoutEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_sMTPServerTimeoutEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sMTPServerTimeoutEdit.Tag = "";
			_sMTPServerTimeoutEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sMTPServerTimeoutEdit.Image = new ControlImage {};
			_sMTPServerTimeoutEdit.Width = System.Web.UI.WebControls.Unit.Percentage(73);
			_sMTPServerTimeoutEdit.Margins = "0 0 0 20";
			_sMTPServerTimeoutEdit.DataSource = "DataSource";
			_sMTPServerTimeoutEdit.ColumnUId = new Guid("0f2e02ad-4200-4180-bdbf-eaa4f04fd337");
			return _sMTPServerTimeoutEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateUseSSLforSendingCheckBox() {
			_useSSLforSendingCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_useSSLforSendingCheckBox.UId = new Guid("158a2d64-9fd0-40c7-b79b-e25db77a3951");
			_useSSLforSendingCheckBox.Name = "UseSSLforSendingCheckBox";
			_useSSLforSendingCheckBox.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useSSLforSendingCheckBox.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useSSLforSendingCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_useSSLforSendingCheckBox.Tag = "";
			_useSSLforSendingCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useSSLforSendingCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useSSLforSendingCheckBox.AlignedByCaption = false;
			_useSSLforSendingCheckBox.Margins = "0 0 0 20";
			_useSSLforSendingCheckBox.DataSource = "DataSource";
			_useSSLforSendingCheckBox.ColumnUId = new Guid("3977f94a-c23a-4779-bd81-69c3e4ff594d");
			return _useSSLforSendingCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateUseLoginRadioButton() {
			_useLoginRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_useLoginRadioButton.UId = new Guid("74c3026a-9c78-4db6-a7ef-745397109a6d");
			_useLoginRadioButton.Name = "UseLoginRadioButton";
			_useLoginRadioButton.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useLoginRadioButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useLoginRadioButton.CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			_useLoginRadioButton.Tag = "";
			_useLoginRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useLoginRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useLoginRadioButton.Margins = "0 0 0 -215";
			_useLoginRadioButton.DataSource = "DataSource";
			_useLoginRadioButton.ColumnUId = new Guid("856cba5a-2243-4231-b769-cb2398b46711");
			_useLoginRadioButton.GroupName = "LoginParametersControlLayout";
			return _useLoginRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateUseUserNameAsLoginRadioButton() {
			_useUserNameAsLoginRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_useUserNameAsLoginRadioButton.UId = new Guid("603934ee-cf44-4cc3-b640-f035a3bf1f90");
			_useUserNameAsLoginRadioButton.Name = "UseUserNameAsLoginRadioButton";
			_useUserNameAsLoginRadioButton.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useUserNameAsLoginRadioButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useUserNameAsLoginRadioButton.CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			_useUserNameAsLoginRadioButton.Tag = "";
			_useUserNameAsLoginRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useUserNameAsLoginRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useUserNameAsLoginRadioButton.Margins = "0 0 0 -215";
			_useUserNameAsLoginRadioButton.DataSource = "DataSource";
			_useUserNameAsLoginRadioButton.ColumnUId = new Guid("db98ba0e-5771-4d5b-aa99-c68f89c23685");
			_useUserNameAsLoginRadioButton.GroupName = "LoginParametersControlLayout";
			return _useUserNameAsLoginRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateUseEmailAddressAsLoginRadioButton() {
			_useEmailAddressAsLoginRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_useEmailAddressAsLoginRadioButton.UId = new Guid("bee161b0-ec79-4de4-84ba-0031eef6c2ca");
			_useEmailAddressAsLoginRadioButton.Name = "UseEmailAddressAsLoginRadioButton";
			_useEmailAddressAsLoginRadioButton.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useEmailAddressAsLoginRadioButton.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_useEmailAddressAsLoginRadioButton.CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			_useEmailAddressAsLoginRadioButton.Tag = "";
			_useEmailAddressAsLoginRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useEmailAddressAsLoginRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useEmailAddressAsLoginRadioButton.Margins = "0 0 0 -215";
			_useEmailAddressAsLoginRadioButton.DataSource = "DataSource";
			_useEmailAddressAsLoginRadioButton.ColumnUId = new Guid("41e3cd9b-bc9d-49d5-b353-2ab339c68c9c");
			_useEmailAddressAsLoginRadioButton.GroupName = "LoginParametersControlLayout";
			return _useEmailAddressAsLoginRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLoginParametersControlLayout() {
			_loginParametersControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_loginParametersControlLayout.UId = new Guid("62ef72dc-0cf7-495b-9ce5-1fc9dd70cc4f");
			_loginParametersControlLayout.Name = "LoginParametersControlLayout";
			_loginParametersControlLayout.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_loginParametersControlLayout.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_loginParametersControlLayout.CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			_loginParametersControlLayout.Tag = "";
			_loginParametersControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_loginParametersControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_loginParametersControlLayout.FitHeightByContent = true;
			_loginParametersControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_loginParametersControlLayout.StartNewAlignGroup = false;
			_loginParametersControlLayout.Image = new ControlImage {};
			_loginParametersControlLayout.Edges = "";
			return _loginParametersControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateImageAndSettingsLabel() {
			_imageAndSettingsLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_imageAndSettingsLabel.UId = new Guid("ebb15491-3aa4-4176-a437-fccc077e82be");
			_imageAndSettingsLabel.Name = "ImageAndSettingsLabel";
			_imageAndSettingsLabel.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_imageAndSettingsLabel.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_imageAndSettingsLabel.CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28");
			_imageAndSettingsLabel.Tag = "";
			_imageAndSettingsLabel.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_imageAndSettingsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_imageAndSettingsLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _imageAndSettingsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateLogoEdit() {
			_logoEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_logoEdit.UId = new Guid("f99f398c-82b9-42f2-b40b-38b7660b8325");
			_logoEdit.Name = "LogoEdit";
			_logoEdit.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_logoEdit.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			_logoEdit.CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28");
			_logoEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_logoEdit.AjaxEvents.Change.ShowLoadMask = true;
			_logoEdit.Tag = "";
			_logoEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_logoEdit.Image = new ControlImage {};
			_logoEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _logoEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			DataSource.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("2ce83824-e529-4477-b3e3-10b1317223a6");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f0fec10e-c639-4ebb-b0d4-75ba7beb2b30");
			if (column != null) {
				column.UId = new Guid("18f30cbf-f3df-4c62-bc00-19eb53a6b11c");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("16902985-8fb6-4297-8031-de7706c21004");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("7fe3389f-c302-4434-82be-2c6cc51163ac");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("f1d530ec-c6a1-4b29-98b3-67a62af9d998");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("d071b206-3171-47d3-9ff8-708aab4528bd");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b9e6dfc3-cd79-4707-9f3d-9b6bedda3c5f");
			if (column != null) {
				column.UId = new Guid("4b2324ef-e3ce-4eab-81bd-59b65a61a51f");
				column.Name = @"Port";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("773d7c26-389e-421c-a67e-9ca6a8b8a3e9");
			if (column != null) {
				column.UId = new Guid("27984b71-9d4b-4e4a-b283-3b464e2b4ce7");
				column.Name = @"UseSSL";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6094ebec-dee7-492e-8977-4e2748a9b4bb");
			if (column != null) {
				column.UId = new Guid("0f2e02ad-4200-4180-bdbf-eaa4f04fd337");
				column.Name = @"SMTPServerTimeout";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("394009b0-7664-46b4-b052-5754522f03c3");
			if (column != null) {
				column.UId = new Guid("93372eb5-7fb0-40cf-a368-8504035a8be2");
				column.Name = @"SMTPServerAddress";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("33affd30-ab8b-4975-8917-9baa63d2d025");
			if (column != null) {
				column.UId = new Guid("3977f94a-c23a-4779-bd81-69c3e4ff594d");
				column.Name = @"UseSSLforSending";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c6d3e3b2-5552-4b06-9d5c-fe34b58ae7aa");
			if (column != null) {
				column.UId = new Guid("3c503717-dd92-49df-9b4e-2f2d4786adf8");
				column.Name = @"SMTPPort";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411aaeae-43da-4e1c-8b1c-1655c25aac96");
			if (column != null) {
				column.UId = new Guid("bed6388d-8091-4131-a968-55f663580fc1");
				column.Name = @"AllowEmailSending";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("89e2b329-bf63-4d5c-a079-6cf6c5fa9430");
			if (column != null) {
				column.UId = new Guid("bc02dafc-5b71-4592-9655-b0b3411f0b22");
				column.Name = @"AllowEmailDownloading";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9a6b34c9-96b3-45f5-b005-dfcd12e79d6d");
			if (column != null) {
				column.UId = new Guid("88630829-7cbf-45eb-b42b-c52604b87fcd");
				column.Name = @"EmailProtocol";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("be4a6212-190c-4430-8b31-6972ac32503f");
			if (column != null) {
				column.UId = new Guid("fb50fe98-c183-43a9-aaba-f6cbac6438a6");
				column.Name = @"Address";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a017673a-f233-4df8-8ba8-fd299bae4e20");
			if (column != null) {
				column.UId = new Guid("04eb56a7-1ebb-4097-9482-5606aad37dbd");
				column.Name = @"IsStartTls";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("29f424ac-945a-4548-a60e-5e738cf01711");
			if (column != null) {
				column.UId = new Guid("856cba5a-2243-4231-b769-cb2398b46711");
				column.Name = @"UseLogin";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("29d0de8b-d4db-45d1-b453-8241941d7b62");
			if (column != null) {
				column.UId = new Guid("9e5416d0-79cf-4753-bd2b-67e7bc3988c3");
				column.Name = @"Logo";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("38790f02-593c-4eb3-80be-2204877697a0");
			if (column != null) {
				column.UId = new Guid("41e3cd9b-bc9d-49d5-b353-2ab339c68c9c");
				column.Name = @"UseEmailAddressAsLogin";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("30e37f76-b60e-4975-89a0-befc3e75eeb7");
			if (column != null) {
				column.UId = new Guid("db98ba0e-5771-4d5b-aa99-c68f89c23685");
				column.Name = @"UseUserNameAsLogin";
				column.CreatedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
				column.ModifiedInSchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
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
			return new MailServerEditPage_Base_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new MailServerEditPage_Base_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MailServerEditPage_Base_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: MailServerEditPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class MailServerEditPage_Base_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.MailServerEditPage_Base_TerrasoftSchemaUserControl
	{

		public MailServerEditPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailServerEditPage_Base_TerrasoftEventsProcess";
			SchemaUId = new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("727ec41d-9d34-4095-b1c1-d811ddcf18f3");
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

		public virtual string FileName {
			get;
			set;
		}

		private ProcessFlowElement _mailServerEditPageOKButtonClickEventSubProcess;
		public ProcessFlowElement MailServerEditPageOKButtonClickEventSubProcess {
			get {
				return _mailServerEditPageOKButtonClickEventSubProcess ?? (_mailServerEditPageOKButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "MailServerEditPageOKButtonClickEventSubProcess",
					SchemaElementUId = new Guid("613a9ef2-9404-4932-9428-d2caf1f623e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerEditPageOKButtonClickStartMessage;
		public ProcessFlowElement MailServerEditPageOKButtonClickStartMessage {
			get {
				return _mailServerEditPageOKButtonClickStartMessage ?? (_mailServerEditPageOKButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerEditPageOKButtonClickStartMessage",
					SchemaElementUId = new Guid("a7958eb7-1dda-4c88-9cb7-dbb0c04d7302"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailServerEditPageOKButtonClickScriptTask;
		public ProcessScriptTask MailServerEditPageOKButtonClickScriptTask {
			get {
				return _mailServerEditPageOKButtonClickScriptTask ?? (_mailServerEditPageOKButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailServerEditPageOKButtonClickScriptTask",
					SchemaElementUId = new Guid("3f70d629-12b8-4449-8ee9-8e2804673e27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailServerEditPageOKButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _mailServerEditPageOKButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent MailServerEditPageOKButtonClickIntermediateThrowMessageEvent {
			get {
				return _mailServerEditPageOKButtonClickIntermediateThrowMessageEvent ?? (_mailServerEditPageOKButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "MailServerEditPageOKButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("4af1e16b-2c87-4352-bdf4-53b3316cfede"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("60be0c66-9641-42de-a37a-77f8edb4e754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _allowEmailDownloadingCheckBoxCheck;
		public ProcessFlowElement AllowEmailDownloadingCheckBoxCheck {
			get {
				return _allowEmailDownloadingCheckBoxCheck ?? (_allowEmailDownloadingCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AllowEmailDownloadingCheckBoxCheck",
					SchemaElementUId = new Guid("368ca0cf-ffea-48d1-b45e-ac0266e0d1ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _allowEmailDownloadingCheckBoxCheckScriptTask;
		public ProcessScriptTask AllowEmailDownloadingCheckBoxCheckScriptTask {
			get {
				return _allowEmailDownloadingCheckBoxCheckScriptTask ?? (_allowEmailDownloadingCheckBoxCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AllowEmailDownloadingCheckBoxCheckScriptTask",
					SchemaElementUId = new Guid("ecf524b4-b5c5-4f9a-95e7-6227338704c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AllowEmailDownloadingCheckBoxCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("aaa00fd0-747d-4cf0-b7b6-33dc6d384431"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _allowEmailSendingCheckBoxCheck;
		public ProcessFlowElement AllowEmailSendingCheckBoxCheck {
			get {
				return _allowEmailSendingCheckBoxCheck ?? (_allowEmailSendingCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AllowEmailSendingCheckBoxCheck",
					SchemaElementUId = new Guid("d89b3b3a-9bb8-4904-a223-8cfff3d836e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _allowEmailSendingCheckBoxCheckScript;
		public ProcessScriptTask AllowEmailSendingCheckBoxCheckScript {
			get {
				return _allowEmailSendingCheckBoxCheckScript ?? (_allowEmailSendingCheckBoxCheckScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AllowEmailSendingCheckBoxCheckScript",
					SchemaElementUId = new Guid("3dd93fa2-a46a-4324-9a7d-fbfa5aab6424"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AllowEmailSendingCheckBoxCheckScriptExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadEventSubProcess;
		public ProcessFlowElement PageLoadEventSubProcess {
			get {
				return _pageLoadEventSubProcess ?? (_pageLoadEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadEventSubProcess",
					SchemaElementUId = new Guid("97089eb1-c993-439e-8fe2-67b9c85d613a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadStartMessage;
		public ProcessFlowElement PageLoadStartMessage {
			get {
				return _pageLoadStartMessage ?? (_pageLoadStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadStartMessage",
					SchemaElementUId = new Guid("4f2b3ca1-5cc7-4318-b2ef-58ed5d4e1f35"),
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
					SchemaElementUId = new Guid("0403c21a-cdac-4a30-a939-3ff21eaa4bdf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadIntermediateThrowMessageEvent {
			get {
				return _pageLoadIntermediateThrowMessageEvent ?? (_pageLoadIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("da6a0755-32db-4db3-95f8-b62769e3a7de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoad",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _initMailServerEventSubProcess;
		public ProcessFlowElement InitMailServerEventSubProcess {
			get {
				return _initMailServerEventSubProcess ?? (_initMailServerEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitMailServerEventSubProcess",
					SchemaElementUId = new Guid("2e944d6a-e6e4-4b0a-8982-3b9199f58478"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initMailServerStartMessage;
		public ProcessFlowElement InitMailServerStartMessage {
			get {
				return _initMailServerStartMessage ?? (_initMailServerStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitMailServerStartMessage",
					SchemaElementUId = new Guid("8f9fe3be-ad57-49e3-9a6b-06153168a1a6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initMailboxIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent InitMailboxIntermediateThrowMessageEvent1 {
			get {
				return _initMailboxIntermediateThrowMessageEvent1 ?? (_initMailboxIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitMailboxIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("b9a0e7b4-cf46-4808-a1f0-5237a01d242c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initMailboxScriptTask;
		public ProcessScriptTask InitMailboxScriptTask {
			get {
				return _initMailboxScriptTask ?? (_initMailboxScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitMailboxScriptTask",
					SchemaElementUId = new Guid("33c055d4-690e-407e-9420-73e743a5b232"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitMailboxScriptTaskExecute,
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
					SchemaElementUId = new Guid("dd8d051b-a788-4322-a87d-5526b5f85beb"),
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
					SchemaElementUId = new Guid("6afecf5b-4ae1-4d96-a831-7c653e73f8f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteChildScriptTask;
		public ProcessScriptTask PageLoadCompleteChildScriptTask {
			get {
				return _pageLoadCompleteChildScriptTask ?? (_pageLoadCompleteChildScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteChildScriptTask",
					SchemaElementUId = new Guid("60cb5f24-ea27-4d0b-a1f3-30fb4c508bc4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteChildScript;
		public ProcessThrowMessageEvent PageLoadCompleteChildScript {
			get {
				return _pageLoadCompleteChildScript ?? (_pageLoadCompleteChildScript = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteChildScript",
					SchemaElementUId = new Guid("fd8e3a47-f4d2-498a-b479-9c8d63ca2c0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _logoEditChangeEventSubProcess4;
		public ProcessFlowElement LogoEditChangeEventSubProcess4 {
			get {
				return _logoEditChangeEventSubProcess4 ?? (_logoEditChangeEventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LogoEditChangeEventSubProcess4",
					SchemaElementUId = new Guid("ca2e6161-842f-4f67-bb34-6e447761b316"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _logoEditChangeScriptTask;
		public ProcessScriptTask LogoEditChangeScriptTask {
			get {
				return _logoEditChangeScriptTask ?? (_logoEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogoEditChangeScriptTask",
					SchemaElementUId = new Guid("69b7ea62-9918-4a19-9add-42687cfef59d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogoEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _logoEditChangeMessage;
		public ProcessFlowElement LogoEditChangeMessage {
			get {
				return _logoEditChangeMessage ?? (_logoEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LogoEditChangeMessage",
					SchemaElementUId = new Guid("ec8cc639-d0cd-4658-afd4-6c0aadee8b77"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private LocalizableString _pageCaption;
		public LocalizableString PageCaption {
			get {
				return _pageCaption ?? (_pageCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PageCaption.Value"));
			}
		}

		private LocalizableString _sendOrReceiveSettingAreRequiredLS;
		public LocalizableString SendOrReceiveSettingAreRequiredLS {
			get {
				return _sendOrReceiveSettingAreRequiredLS ?? (_sendOrReceiveSettingAreRequiredLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SendOrReceiveSettingAreRequiredLS.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[MailServerEditPageOKButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerEditPageOKButtonClickEventSubProcess };
			FlowElements[MailServerEditPageOKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerEditPageOKButtonClickStartMessage };
			FlowElements[MailServerEditPageOKButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerEditPageOKButtonClickScriptTask };
			FlowElements[MailServerEditPageOKButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerEditPageOKButtonClickIntermediateThrowMessageEvent };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[AllowEmailDownloadingCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { AllowEmailDownloadingCheckBoxCheck };
			FlowElements[AllowEmailDownloadingCheckBoxCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AllowEmailDownloadingCheckBoxCheckScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[AllowEmailSendingCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { AllowEmailSendingCheckBoxCheck };
			FlowElements[AllowEmailSendingCheckBoxCheckScript.SchemaElementUId] = new Collection<ProcessFlowElement> { AllowEmailSendingCheckBoxCheckScript };
			FlowElements[PageLoadEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadEventSubProcess };
			FlowElements[PageLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadStartMessage };
			FlowElements[PageLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadScriptTask };
			FlowElements[PageLoadIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadIntermediateThrowMessageEvent };
			FlowElements[InitMailServerEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailServerEventSubProcess };
			FlowElements[InitMailServerStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailServerStartMessage };
			FlowElements[InitMailboxIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailboxIntermediateThrowMessageEvent1 };
			FlowElements[InitMailboxScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailboxScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[PageLoadCompleteChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScriptTask };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[LogoEditChangeEventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { LogoEditChangeEventSubProcess4 };
			FlowElements[LogoEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogoEditChangeScriptTask };
			FlowElements[LogoEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { LogoEditChangeMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "MailServerEditPageOKButtonClickEventSubProcess":
						break;
					case "MailServerEditPageOKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("MailServerEditPageOKButtonClickScriptTask");
						break;
					case "MailServerEditPageOKButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("MailServerEditPageOKButtonClickIntermediateThrowMessageEvent");
						break;
					case "MailServerEditPageOKButtonClickIntermediateThrowMessageEvent":
						break;
					case "EventSubProcess2":
						break;
					case "AllowEmailDownloadingCheckBoxCheck":
						e.Context.QueueTasks.Enqueue("AllowEmailDownloadingCheckBoxCheckScriptTask");
						break;
					case "AllowEmailDownloadingCheckBoxCheckScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "AllowEmailSendingCheckBoxCheck":
						e.Context.QueueTasks.Enqueue("AllowEmailSendingCheckBoxCheckScript");
						break;
					case "AllowEmailSendingCheckBoxCheckScript":
						break;
					case "PageLoadEventSubProcess":
						break;
					case "PageLoadStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadScriptTask");
						break;
					case "PageLoadScriptTask":
						e.Context.QueueTasks.Enqueue("PageLoadIntermediateThrowMessageEvent");
						break;
					case "PageLoadIntermediateThrowMessageEvent":
						break;
					case "InitMailServerEventSubProcess":
						break;
					case "InitMailServerStartMessage":
						e.Context.QueueTasks.Enqueue("InitMailboxScriptTask");
						break;
					case "InitMailboxIntermediateThrowMessageEvent1":
						break;
					case "InitMailboxScriptTask":
						e.Context.QueueTasks.Enqueue("InitMailboxIntermediateThrowMessageEvent1");
						break;
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScriptTask":
						break;
					case "PageLoadCompleteChildScript":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScriptTask");
						break;
					case "LogoEditChangeEventSubProcess4":
						break;
					case "LogoEditChangeScriptTask":
						break;
					case "LogoEditChangeMessage":
						e.Context.QueueTasks.Enqueue("LogoEditChangeScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MailServerEditPageOKButtonClickStartMessage");
			ActivatedEventElements.Add("AllowEmailDownloadingCheckBoxCheck");
			ActivatedEventElements.Add("AllowEmailSendingCheckBoxCheck");
			ActivatedEventElements.Add("PageLoadStartMessage");
			ActivatedEventElements.Add("InitMailServerStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("LogoEditChangeMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "MailServerEditPageOKButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "MailServerEditPageOKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerEditPageOKButtonClickStartMessage";
					result = MailServerEditPageOKButtonClickStartMessage.Execute(context);
					break;
				case "MailServerEditPageOKButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerEditPageOKButtonClickScriptTask";
					result = MailServerEditPageOKButtonClickScriptTask.Execute(context, MailServerEditPageOKButtonClickScriptTaskExecute);
					break;
				case "MailServerEditPageOKButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = MailServerEditPageOKButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "AllowEmailDownloadingCheckBoxCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllowEmailDownloadingCheckBoxCheck";
					result = AllowEmailDownloadingCheckBoxCheck.Execute(context);
					break;
				case "AllowEmailDownloadingCheckBoxCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllowEmailDownloadingCheckBoxCheckScriptTask";
					result = AllowEmailDownloadingCheckBoxCheckScriptTask.Execute(context, AllowEmailDownloadingCheckBoxCheckScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "AllowEmailSendingCheckBoxCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllowEmailSendingCheckBoxCheck";
					result = AllowEmailSendingCheckBoxCheck.Execute(context);
					break;
				case "AllowEmailSendingCheckBoxCheckScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllowEmailSendingCheckBoxCheckScript";
					result = AllowEmailSendingCheckBoxCheckScript.Execute(context, AllowEmailSendingCheckBoxCheckScriptExecute);
					break;
				case "PageLoadEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadStartMessage";
					result = PageLoadStartMessage.Execute(context);
					break;
				case "PageLoadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadScriptTask";
					result = PageLoadScriptTask.Execute(context, PageLoadScriptTaskExecute);
					break;
				case "PageLoadIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoad");
					result = PageLoadIntermediateThrowMessageEvent.Execute(context);
					break;
				case "InitMailServerEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitMailServerStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMailServerStartMessage";
					result = InitMailServerStartMessage.Execute(context);
					break;
				case "InitMailboxIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitMailboxIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "InitMailboxScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMailboxScriptTask";
					result = InitMailboxScriptTask.Execute(context, InitMailboxScriptTaskExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "PageLoadCompleteChildScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScriptTask";
					result = PageLoadCompleteChildScriptTask.Execute(context, PageLoadCompleteChildScriptTaskExecute);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteChildScript.Execute(context);
					break;
				case "LogoEditChangeEventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "LogoEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogoEditChangeScriptTask";
					result = LogoEditChangeScriptTask.Execute(context, LogoEditChangeScriptTaskExecute);
					break;
				case "LogoEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogoEditChangeMessage";
					result = LogoEditChangeMessage.Execute(context);
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
				case "FileName":
					FileName = reader.GetValue<System.String>();
				break;
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

		public virtual bool MailServerEditPageOKButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			bool validationResult = IsValidParameters();
			if (validationResult) {
				byte[] fileData = Convert.FromBase64String((string)FileContent ?? string.Empty) as byte[];
				var memoryStream = new System.IO.MemoryStream();
				memoryStream.Write(fileData, 0, FileSize);
				string mimeType = GetMimeType(memoryStream);
				if (!string.IsNullOrEmpty(mimeType) && mimeType.Contains("image")) {
					Terrasoft.Core.ImageAPI.ImageAPI imageApi = new Core.ImageAPI.ImageAPI(UserConnection);
					Guid imageId = imageApi.Save(memoryStream, mimeType, FileName);
					Page.DataSource.ActiveRow.SetColumnBothValues("LogoId", imageId, "LogoName", FileName);
					string script = string.Format("{0}.setColumnValue('LogoId', '{1}');", Page.DataSource.ClientID, imageId);
					Page.ScriptManager.AddScript(script);
				}
				memoryStream.Close();
			}
			return validationResult;
		}

		public virtual bool AllowEmailDownloadingCheckBoxCheckScriptTaskExecute(ProcessExecutingContext context) {
			SetDownloadingControlsEnableRequire();
			return true;
		}

		public virtual bool AllowEmailSendingCheckBoxCheckScriptExecute(ProcessExecutingContext context) {
			SetSendingControlsEnableRequire();
			return true;
		}

		public virtual bool PageLoadScriptTaskExecute(ProcessExecutingContext context) {
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			Page.OKButton.AjaxEvents.Click.ShowLoadMask = true;
			Page.OKButton.AjaxEvents.Click.ShowOpaqueMask = true;
			return true;
		}

		public virtual bool InitMailboxScriptTaskExecute(ProcessExecutingContext context) {
			Page.PortEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			Page.SMTPPortEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			Page.SMTPServerTimeoutEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageMailServers");
			SetControlsEnableRequire();
			return true;
		}

		public virtual bool LogoEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			FileName = Page.LogoEdit.FileName;
			FileSize = (int)Page.LogoEdit.FileContent.Length;
			Page.LogoEdit.FileContent.Position = 0;
			FileContent = Convert.ToBase64String(Page.LogoEdit.FileBytes);
			return true;
		}

		public virtual void SetControlsEnableRequire() {
			SetSendingControlsEnableRequire();
			SetDownloadingControlsEnableRequire();
		}

		public virtual void SetSendingControlsEnableRequire() {
			var enableSendingcontrols = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("AllowEmailSending");
			Page.SMTPServerAddressTextEdit.SetEnabled(enableSendingcontrols);
			Page.SMTPServerAddressTextEdit.SetRequired(enableSendingcontrols);
			Page.SMTPPortEdit.SetEnabled(enableSendingcontrols);
			Page.SMTPServerTimeoutEdit.SetEnabled(enableSendingcontrols);
			Page.SMTPServerTimeoutEdit.SetRequired(enableSendingcontrols);
			Page.UseSSLforSendingCheckBox.SetEnabled(enableSendingcontrols);
		}

		public virtual void SetDownloadingControlsEnableRequire() {
			var enabledownloadingcontrols = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("AllowEmailDownloading");
			Page.EmailProtocolComboBoxEdit.SetEnabled(enabledownloadingcontrols);
			Page.EmailProtocolComboBoxEdit.SetRequired(enabledownloadingcontrols);
			Page.AddressEdit.SetEnabled(enabledownloadingcontrols);
			Page.AddressEdit.SetRequired(enabledownloadingcontrols);
			Page.PortEdit.SetEnabled(enabledownloadingcontrols);
			Page.UseSSLEdit.SetEnabled(enabledownloadingcontrols);
			Page.IsStartTlsEdit.SetEnabled(enabledownloadingcontrols);
		}

		public virtual bool IsValidParameters() {
			Page.BaseMessagePanel.Clear();
			if (!Page.AllowEmailDownloadingCheckBox.Checked && !Page.AllowEmailSendingCheckBox.Checked) {
				Page.BaseMessagePanel.AddMessage(Warning, SendOrReceiveSettingAreRequiredLS, MessageType.Warning);
				return false;
			}
			return true;
		}

		public virtual string GetMimeType(Stream stream) {
			string mimeType = null;
			try {
				using (System.Drawing.Image image = System.Drawing.Image.FromStream(stream)) {
					var codec = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == image.RawFormat.Guid);
					mimeType = (codec != null) ? codec.MimeType : null;
				}
			} catch {
			}
			return mimeType;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("MailServerEditPageOKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("MailServerEditPageOKButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "AllowEmailDownloadingCheckBoxCheck":
							if (ActivatedEventElements.Contains("AllowEmailDownloadingCheckBoxCheck")) {
							context.QueueTasks.Enqueue("AllowEmailDownloadingCheckBoxCheck");
						}
						break;
					case "AllowEmailSendingCheckBoxCheck":
							if (ActivatedEventElements.Contains("AllowEmailSendingCheckBoxCheck")) {
							context.QueueTasks.Enqueue("AllowEmailSendingCheckBoxCheck");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitMailServerStartMessage")) {
							context.QueueTasks.Enqueue("InitMailServerStartMessage");
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
					case "LogoEditChange":
							if (ActivatedEventElements.Contains("LogoEditChangeMessage")) {
							context.QueueTasks.Enqueue("LogoEditChangeMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("FileName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileName", FileName, null);
			}
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

	#region Class: MailServerEditPage_Base_TerrasoftEventsProcess

	/// <exclude/>
	public class MailServerEditPage_Base_TerrasoftEventsProcess : MailServerEditPage_Base_TerrasoftEventsProcess<Terrasoft.WebApp.MailServerEditPage_Base_TerrasoftSchemaUserControl>
	{

		public MailServerEditPage_Base_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailServerEditPage_Base_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class MailServerEditPage_Base_TerrasoftSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Downloading {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Downloading", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailDownloadingCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("AllowEmailDownloadingCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit EmailProtocolComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("EmailProtocolComboBoxEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit AddressEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("AddressEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PortEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PortEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox UseSSLEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("UseSSLEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsStartTlsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsStartTlsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label Sending {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("Sending", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailSendingCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("AllowEmailSendingCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SMTPServerAddressTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SMTPServerAddressTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit SMTPPortEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("SMTPPortEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit SMTPServerTimeoutEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("SMTPServerTimeoutEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox UseSSLforSendingCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("UseSSLforSendingCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout LoginParametersControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LoginParametersControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton UseLoginRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("UseLoginRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton UseUserNameAsLoginRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("UseUserNameAsLoginRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton UseEmailAddressAsLoginRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("UseEmailAddressAsLoginRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label ImageAndSettingsLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("ImageAndSettingsLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FileUploadEdit LogoEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FileUploadEdit)PageContainer.FindPageControl("LogoEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AllowEmailDownloadingCheckBox.AjaxEvents.Check.Event += AllowEmailDownloadingCheckBoxCheck;
			AllowEmailSendingCheckBox.AjaxEvents.Check.Event += AllowEmailSendingCheckBoxCheck;
			LogoEdit.AjaxEvents.Change.Event += LogoEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AllowEmailDownloadingCheckBox.AjaxEvents.Check.Event -= AllowEmailDownloadingCheckBoxCheck;
			AllowEmailSendingCheckBox.AjaxEvents.Check.Event -= AllowEmailSendingCheckBoxCheck;
			LogoEdit.AjaxEvents.Change.Event -= LogoEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (MailServerEditPage_Base_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new MailServerEditPage_Base_TerrasoftEventsProcess(UserConnection);
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

		public virtual void AllowEmailDownloadingCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("AllowEmailDownloadingCheckBoxCheck");
		}

		public virtual void AllowEmailSendingCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("AllowEmailSendingCheckBoxCheck");
		}

		public virtual void LogoEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("LogoEditChange");
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
			SchemaName = "MailServerEditPage_Base_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: MailServerEditPage_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MailServerEditPage_Base_TerrasoftEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public MailServerEditPage_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailServerEditPage_Base_TerrasoftEventsProcessSchema(MailServerEditPage_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailServerEditPage_Base_TerrasoftEventsProcess";
			UId = new Guid("140a6206-152d-475f-b489-a588a549c421");
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

		protected virtual ProcessSchemaParameter CreateFileContentParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4ecf28b1-eb65-40ad-ad6c-31adcfe88a54"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"FileContent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c41aaa71-f31f-4ea0-a594-4f2608cdf6fc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"FileSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc034324-51fa-4038-9f49-00a05dfe86c7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"FileName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFileContentParameter());
			Parameters.Add(CreateFileSizeParameter());
			Parameters.Add(CreateFileNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMailServerEditPageLaneSet = CreateMailServerEditPageLaneSetLaneSet();
			LaneSets.Add(schemaMailServerEditPageLaneSet);
			ProcessSchemaLane schemaMailServerEditPageButtonEventsLane = CreateMailServerEditPageButtonEventsLaneLane();
			schemaMailServerEditPageLaneSet.Lanes.Add(schemaMailServerEditPageButtonEventsLane);
			ProcessSchemaEventSubProcess mailservereditpageokbuttonclickeventsubprocess = CreateMailServerEditPageOKButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(mailservereditpageokbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess pageloadeventsubprocess = CreatePageLoadEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadeventsubprocess);
			ProcessSchemaEventSubProcess initmailservereventsubprocess = CreateInitMailServerEventSubProcessEventSubProcess();
			FlowElements.Add(initmailservereventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess logoeditchangeeventsubprocess4 = CreateLogoEditChangeEventSubProcess4EventSubProcess();
			FlowElements.Add(logoeditchangeeventsubprocess4);
			ProcessSchemaStartMessageEvent mailservereditpageokbuttonclickstartmessage = CreateMailServerEditPageOKButtonClickStartMessageStartMessageEvent();
			mailservereditpageokbuttonclickeventsubprocess.FlowElements.Add(mailservereditpageokbuttonclickstartmessage);
			ProcessSchemaScriptTask mailservereditpageokbuttonclickscripttask = CreateMailServerEditPageOKButtonClickScriptTaskScriptTask();
			mailservereditpageokbuttonclickeventsubprocess.FlowElements.Add(mailservereditpageokbuttonclickscripttask);
			ProcessSchemaIntermediateThrowMessageEvent mailservereditpageokbuttonclickintermediatethrowmessageevent = CreateMailServerEditPageOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			mailservereditpageokbuttonclickeventsubprocess.FlowElements.Add(mailservereditpageokbuttonclickintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent allowemaildownloadingcheckboxcheck = CreateAllowEmailDownloadingCheckBoxCheckStartMessageEvent();
			eventsubprocess2.FlowElements.Add(allowemaildownloadingcheckboxcheck);
			ProcessSchemaScriptTask allowemaildownloadingcheckboxcheckscripttask = CreateAllowEmailDownloadingCheckBoxCheckScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(allowemaildownloadingcheckboxcheckscripttask);
			ProcessSchemaStartMessageEvent allowemailsendingcheckboxcheck = CreateAllowEmailSendingCheckBoxCheckStartMessageEvent();
			eventsubprocess3.FlowElements.Add(allowemailsendingcheckboxcheck);
			ProcessSchemaScriptTask allowemailsendingcheckboxcheckscript = CreateAllowEmailSendingCheckBoxCheckScriptScriptTask();
			eventsubprocess3.FlowElements.Add(allowemailsendingcheckboxcheckscript);
			ProcessSchemaStartMessageEvent pageloadstartmessage = CreatePageLoadStartMessageStartMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(pageloadstartmessage);
			ProcessSchemaScriptTask pageloadscripttask = CreatePageLoadScriptTaskScriptTask();
			pageloadeventsubprocess.FlowElements.Add(pageloadscripttask);
			ProcessSchemaIntermediateThrowMessageEvent pageloadintermediatethrowmessageevent = CreatePageLoadIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(pageloadintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent initmailserverstartmessage = CreateInitMailServerStartMessageStartMessageEvent();
			initmailservereventsubprocess.FlowElements.Add(initmailserverstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent initmailboxintermediatethrowmessageevent1 = CreateInitMailboxIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			initmailservereventsubprocess.FlowElements.Add(initmailboxintermediatethrowmessageevent1);
			ProcessSchemaScriptTask initmailboxscripttask = CreateInitMailboxScriptTaskScriptTask();
			initmailservereventsubprocess.FlowElements.Add(initmailboxscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask pageloadcompletechildscripttask = CreatePageLoadCompleteChildScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletechildscripttask);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletechildscript = CreatePageLoadCompleteChildScriptIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaScriptTask logoeditchangescripttask = CreateLogoEditChangeScriptTaskScriptTask();
			logoeditchangeeventsubprocess4.FlowElements.Add(logoeditchangescripttask);
			ProcessSchemaStartMessageEvent logoeditchangemessage = CreateLogoEditChangeMessageStartMessageEvent();
			logoeditchangeeventsubprocess4.FlowElements.Add(logoeditchangemessage);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateLogoEditChangeSequenceFlow11SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatePageCaptionLocalizableString());
			LocalizableStrings.Add(CreateSendOrReceiveSettingAreRequiredLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreatePageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a600bdbf-2a61-49e0-b70a-53a48bd1c8d9"),
				Name = "PageCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSendOrReceiveSettingAreRequiredLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6e57c5da-0b2e-4cdc-8cb3-5d40343a21de"),
				Name = "SendOrReceiveSettingAreRequiredLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("639af82c-91cf-44ba-a2dc-3d2f99c9f2ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a7958eb7-1dda-4c88-9cb7-dbb0c04d7302"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3f70d629-12b8-4449-8ee9-8e2804673e27"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("42743fae-c539-404f-8dc4-4c51d1ce88c6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(264, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3f70d629-12b8-4449-8ee9-8e2804673e27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4af1e16b-2c87-4352-bdf4-53b3316cfede"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("9fa6bf37-c6d1-4fb7-943f-a3f214090989"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(158, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f2b3ca1-5cc7-4318-b2ef-58ed5d4e1f35"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0403c21a-cdac-4a30-a939-3ff21eaa4bdf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("67d56702-db30-45c6-b2be-c29164c023ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(278, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0403c21a-cdac-4a30-a939-3ff21eaa4bdf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da6a0755-32db-4db3-95f8-b62769e3a7de"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5c3fa3d8-4fda-4439-b5f1-599f4bd363d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(450, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f9fe3be-ad57-49e3-9a6b-06153168a1a6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33c055d4-690e-407e-9420-73e743a5b232"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b8a46a61-a9cd-4b4e-9c6c-6d91d82c4349"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(563, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("33c055d4-690e-407e-9420-73e743a5b232"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9a0e7b4-cf46-4808-a1f0-5237a01d242c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("dfe1fa04-7147-434e-9c0e-5ae8abf26a68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("368ca0cf-ffea-48d1-b45e-ac0266e0d1ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ecf524b4-b5c5-4f9a-95e7-6227338704c5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("335b191a-da5f-4070-99ba-b3c98c902cf5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d89b3b3a-9bb8-4904-a223-8cfff3d836e8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3dd93fa2-a46a-4324-9a7d-fbfa5aab6424"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("aeb31ccc-7e3b-4d4d-bb41-348d0d391914"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(746, 281),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6afecf5b-4ae1-4d96-a831-7c653e73f8f3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd8e3a47-f4d2-498a-b479-9c8d63ca2c0d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("ace91a42-321b-4355-992a-7af5ba98f462"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(830, 282),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fd8e3a47-f4d2-498a-b479-9c8d63ca2c0d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60cb5f24-ea27-4d0b-a1f3-30fb4c508bc4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateLogoEditChangeSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "LogoEditChangeSequenceFlow11",
				UId = new Guid("f10b8984-c817-4dbe-85b9-d3c4a9a94707"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec8cc639-d0cd-4658-afd4-6c0aadee8b77"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69b7ea62-9918-4a19-9add-42687cfef59d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMailServerEditPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMailServerEditPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c6f45695-bef4-4b22-ac86-38ecf30bba86"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"MailServerEditPageLaneSet",
				Position = new Point(5, 5),
				Size = new Size(994, 171),
				UseBackgroundMode = false
			};
			return schemaMailServerEditPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateMailServerEditPageButtonEventsLaneLane() {
			ProcessSchemaLane schemaMailServerEditPageButtonEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c6f45695-bef4-4b22-ac86-38ecf30bba86"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"MailServerEditPageButtonEventsLane",
				Position = new Point(29, 0),
				Size = new Size(965, 171),
				UseBackgroundMode = false
			};
			return schemaMailServerEditPageButtonEventsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateMailServerEditPageOKButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaMailServerEditPageOKButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("613a9ef2-9404-4932-9428-d2caf1f623e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"MailServerEditPageOKButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(305, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaMailServerEditPageOKButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerEditPageOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a7958eb7-1dda-4c88-9cb7-dbb0c04d7302"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("613a9ef2-9404-4932-9428-d2caf1f623e3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"MailServerEditPageOKButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailServerEditPageOKButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f70d629-12b8-4449-8ee9-8e2804673e27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("613a9ef2-9404-4932-9428-d2caf1f623e3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"MailServerEditPageOKButtonClickScriptTask",
				Position = new Point(105, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,147,77,111,219,48,12,134,207,246,175,224,124,104,100,192,16,58,96,216,37,40,138,52,109,10,3,75,27,212,237,118,24,118,80,99,38,21,96,73,1,37,187,240,130,252,247,74,254,200,178,108,39,219,212,203,135,47,41,250,213,152,10,26,81,201,82,56,105,244,19,218,186,114,112,5,185,253,30,130,43,65,66,161,67,178,44,157,198,114,3,236,92,155,194,62,142,94,91,135,63,127,193,70,86,120,43,156,240,249,115,163,27,36,199,23,100,212,141,176,248,245,75,225,72,234,45,99,182,123,166,11,175,245,34,135,218,193,245,53,244,81,126,167,118,174,77,65,88,232,145,211,56,106,4,129,66,101,168,245,4,20,202,195,53,190,67,209,90,135,138,231,143,124,121,114,24,92,70,167,106,254,131,164,67,54,58,203,224,50,131,80,186,144,191,49,104,251,186,160,164,194,231,118,135,30,126,143,110,57,124,177,83,82,80,135,1,124,26,172,230,246,161,174,170,71,234,44,179,17,144,194,197,197,145,198,67,131,66,106,203,18,169,196,22,147,180,155,86,244,140,68,194,154,141,243,2,66,158,135,179,217,42,63,190,64,167,158,237,228,208,235,255,85,236,197,34,249,10,26,215,225,58,130,191,232,190,150,101,159,157,151,62,121,228,240,66,52,127,119,147,29,77,246,243,120,240,215,220,17,86,62,131,135,81,21,166,166,53,242,153,135,55,248,100,222,121,129,110,110,170,90,233,27,227,222,252,118,212,232,251,250,102,182,38,47,147,108,44,154,65,23,10,184,228,140,60,140,218,174,73,238,194,138,13,115,92,24,82,194,177,100,127,121,224,118,44,209,225,217,164,167,79,50,152,236,63,31,38,233,212,35,207,253,205,43,233,87,40,191,61,58,248,211,69,209,85,90,10,237,63,136,207,202,178,15,176,222,65,208,29,206,150,101,94,25,139,97,135,14,49,161,171,73,255,243,107,76,227,15,97,159,128,39,50,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateMailServerEditPageOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("4af1e16b-2c87-4352-bdf4-53b3316cfede"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("613a9ef2-9404-4932-9428-d2caf1f623e3"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"MailServerEditPageOKButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("60be0c66-9641-42de-a37a-77f8edb4e754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"EventSubProcess2",
				Position = new Point(330, 17),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAllowEmailDownloadingCheckBoxCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("368ca0cf-ffea-48d1-b45e-ac0266e0d1ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60be0c66-9641-42de-a37a-77f8edb4e754"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AllowEmailDownloadingCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"AllowEmailDownloadingCheckBoxCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAllowEmailDownloadingCheckBoxCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ecf524b4-b5c5-4f9a-95e7-6227338704c5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60be0c66-9641-42de-a37a-77f8edb4e754"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"AllowEmailDownloadingCheckBoxCheckScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,201,47,207,203,201,79,76,201,204,75,119,206,207,43,41,202,207,41,118,205,75,76,202,73,13,74,45,44,205,44,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,26,135,157,65,52,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("aaa00fd0-747d-4cf0-b7b6-33dc6d384431"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"EventSubProcess3",
				Position = new Point(512, 17),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAllowEmailSendingCheckBoxCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d89b3b3a-9bb8-4904-a223-8cfff3d836e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aaa00fd0-747d-4cf0-b7b6-33dc6d384431"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AllowEmailSendingCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"AllowEmailSendingCheckBoxCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAllowEmailSendingCheckBoxCheckScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3dd93fa2-a46a-4324-9a7d-fbfa5aab6424"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aaa00fd0-747d-4cf0-b7b6-33dc6d384431"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"AllowEmailSendingCheckBoxCheckScript",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,78,205,75,201,204,75,119,206,207,43,41,202,207,41,118,205,75,76,202,73,13,74,45,44,205,44,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,127,211,180,42,48,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("97089eb1-c993-439e-8fe2-67b9c85d613a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(31, 190),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(288, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f2b3ca1-5cc7-4318-b2ef-58ed5d4e1f35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97089eb1-c993-439e-8fe2-67b9c85d613a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0403c21a-cdac-4a30-a939-3ff21eaa4bdf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97089eb1-c993-439e-8fe2-67b9c85d613a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,247,118,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,115,78,44,45,78,45,14,75,204,201,76,73,44,201,204,207,83,176,85,40,41,42,77,181,230,10,192,175,47,56,35,191,220,39,63,49,197,55,177,56,155,20,61,254,5,137,133,165,169,40,186,138,82,75,74,139,242,32,28,0,198,4,37,8,174,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("da6a0755-32db-4db3-95f8-b62769e3a7de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97089eb1-c993-439e-8fe2-67b9c85d613a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitMailServerEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitMailServerEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e944d6a-e6e4-4b0a-8982-3b9199f58478"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"InitMailServerEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 190),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitMailServerEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitMailServerStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8f9fe3be-ad57-49e3-9a6b-06153168a1a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e944d6a-e6e4-4b0a-8982-3b9199f58478"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"InitMailServerStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitMailboxIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b9a0e7b4-cf46-4808-a1f0-5237a01d242c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e944d6a-e6e4-4b0a-8982-3b9199f58478"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"InitMailboxIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitMailboxScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("33c055d4-690e-407e-9420-73e743a5b232"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e944d6a-e6e4-4b0a-8982-3b9199f58478"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"InitMailboxScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,200,47,42,113,77,201,44,209,115,46,45,46,201,207,117,206,207,75,203,76,215,115,76,73,209,200,75,45,87,128,112,61,75,82,115,53,148,50,50,83,82,3,138,50,115,19,139,42,67,242,243,115,156,74,75,74,242,243,148,116,20,148,74,138,74,83,149,52,53,173,121,185,2,64,38,6,251,134,4,208,198,212,224,212,162,178,212,162,144,204,220,212,252,82,234,25,95,148,90,82,90,148,167,0,18,176,6,0,254,254,140,192,19,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dd8d051b-a788-4322-a87d-5526b5f85beb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(645, 191),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(306, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6afecf5b-4ae1-4d96-a831-7c653e73f8f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd8d051b-a788-4322-a87d-5526b5f85beb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(7, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60cb5f24-ea27-4d0b-a1f3-30fb4c508bc4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd8d051b-a788-4322-a87d-5526b5f85beb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadCompleteChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,140,65,10,194,48,20,5,247,130,119,144,174,234,166,23,232,206,152,101,17,12,30,224,27,30,53,24,126,244,229,71,244,246,166,219,153,97,110,21,116,69,21,209,82,209,233,124,10,136,141,201,126,94,215,164,152,220,3,241,233,68,253,183,115,195,229,5,202,86,142,67,135,139,168,172,88,36,229,0,126,192,58,28,231,253,46,192,250,209,88,114,245,42,247,140,43,222,45,17,227,38,9,107,212,131,177,97,254,3,162,102,201,51,124,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteChildScriptIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fd8e3a47-f4d2-498a-b479-9c8d63ca2c0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd8d051b-a788-4322-a87d-5526b5f85beb"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLogoEditChangeEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaLogoEditChangeEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ca2e6161-842f-4f67-bb34-6e447761b316"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35f6881b-4e9c-4e0f-b0fe-99f3c0775644"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"LogoEditChangeEventSubProcess4",
				Position = new Point(44, 409),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 171),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLogoEditChangeEventSubProcess4;
		}

		protected virtual ProcessSchemaScriptTask CreateLogoEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("69b7ea62-9918-4a19-9add-42687cfef59d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca2e6161-842f-4f67-bb34-6e447761b316"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"LogoEditChangeScriptTask",
				Position = new Point(166, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,140,177,10,194,64,16,68,123,193,127,184,50,105,14,11,73,19,108,34,166,10,18,136,63,112,224,114,46,232,46,236,77,2,250,245,185,192,117,193,110,152,121,243,122,126,211,61,124,200,93,220,24,34,249,65,163,222,158,12,223,151,161,61,30,182,56,241,111,99,42,22,212,123,240,170,2,18,248,129,36,226,149,47,255,145,81,19,131,85,178,236,84,220,101,202,77,78,11,25,252,67,187,144,168,57,79,48,150,88,237,109,221,23,148,234,252,55,194,108,226,96,51,181,43,60,100,173,20,204,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLogoEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec8cc639-d0cd-4658-afd4-6c0aadee8b77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca2e6161-842f-4f67-bb34-6e447761b316"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28"),
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LogoEditChange",
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Name = @"LogoEditChangeMessage",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetControlsEnableRequireMethod());
			Methods.Add(CreateSetSendingControlsEnableRequireMethod());
			Methods.Add(CreateSetDownloadingControlsEnableRequireMethod());
			Methods.Add(CreateIsValidParametersMethod());
			Methods.Add(CreateGetMimeTypeMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9f48e174-05f2-41d4-b29d-f1e0149ba290"),
				Name = "Terrasoft.Mail",
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
				UId = new Guid("fcbf9a12-418d-4916-83ba-c99935976293"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cfaac687-6f5f-4ae3-87aa-b12b61d54e6b"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84a4ee49-5ba8-4d0e-b440-a84f85976746"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
		}

		protected virtual SchemaMethod CreateSetControlsEnableRequireMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1da16023-08e4-4099-8f2c-e255068bf591"),
				Name = "SetControlsEnableRequire",
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,78,205,75,201,204,75,119,206,207,43,41,202,207,41,118,205,75,76,202,73,13,74,45,44,205,44,74,213,208,180,230,10,78,45,113,201,47,207,203,201,79,196,167,12,0,123,57,166,249,73,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetSendingControlsEnableRequireMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cf9adb4e-c48a-4d09-8266-deceaac719a0"),
				Name = "SetSendingControlsEnableRequire",
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,206,189,10,194,48,20,134,225,93,240,30,138,83,93,122,3,254,64,213,226,162,80,154,234,30,155,79,13,166,57,122,146,180,245,238,5,113,116,8,226,126,206,251,61,157,228,4,86,158,12,4,172,210,246,210,144,245,76,198,37,139,164,148,23,100,27,233,165,160,192,13,178,188,241,186,67,69,125,182,133,175,159,119,168,53,153,208,218,163,52,1,243,19,145,89,166,147,220,24,234,139,86,106,243,9,78,166,179,241,232,157,18,251,186,20,224,14,156,43,197,112,174,198,224,11,165,125,38,224,139,55,66,165,95,49,113,137,10,143,160,57,170,81,18,255,188,92,235,22,20,254,245,30,137,62,56,8,177,59,19,127,14,214,87,52,183,21,13,17,130,23,96,68,146,15,227,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetDownloadingControlsEnableRequireMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5c9e15c1-4fc8-403d-82c9-135d2b30c1ba"),
				Name = "SetDownloadingControlsEnableRequire",
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,189,10,194,64,16,132,123,193,119,8,86,218,228,5,252,129,168,65,4,139,224,169,253,38,183,200,193,230,70,239,54,70,223,94,208,66,16,4,175,30,230,155,111,110,20,50,246,84,11,91,244,94,64,214,249,115,3,175,1,18,179,121,86,209,153,243,53,41,25,116,161,225,188,104,212,221,120,143,62,223,176,30,30,23,182,43,72,215,250,19,73,199,179,26,144,197,120,84,136,160,47,91,114,178,254,64,71,147,233,112,240,194,189,146,42,64,209,64,86,104,107,44,113,47,173,211,220,176,150,111,153,241,79,169,255,48,123,190,118,46,252,197,41,172,13,28,99,186,192,87,49,97,178,66,208,244,189,99,100,99,118,233,189,109,52,74,65,15,146,242,241,9,77,202,47,247,25,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsValidParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ac997fe-dbb1-4d17-8f70-20eaa8c7eb06"),
				Name = "IsValidParameters",
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("aa28647a-0905-4f4e-afd7-e7ddcf531aa9"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,65,14,130,48,16,69,215,112,138,186,33,144,144,94,128,21,160,59,141,13,152,184,110,232,7,27,107,209,41,136,198,120,119,193,116,101,220,253,63,121,111,38,35,100,7,94,72,135,29,156,155,179,144,22,134,151,6,146,226,36,11,117,203,226,149,88,152,220,152,126,218,92,164,54,235,126,178,166,151,74,219,174,60,161,57,23,253,131,127,3,20,139,34,246,139,215,176,255,208,132,189,194,64,252,189,158,43,229,123,124,148,100,103,57,101,203,150,61,85,104,160,239,168,49,12,243,52,39,84,184,141,154,160,182,117,202,188,115,120,94,193,189,55,127,16,16,134,145,44,107,165,113,200,194,119,232,251,64,35,178,15,197,71,139,4,254,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMimeTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("96170fda-8daf-4ed2-9cf1-7243dcd5f1b2"),
				Name = "GetMimeType",
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a0fb3405-6296-4fc6-b8da-a9034927cf7f"),
				Name = "stream",
				CreatedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				ModifiedInSchemaUId = new Guid("140a6206-152d-475f-b489-a588a549c421"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Stream",
				CreatedInPackageId = new Guid("fa2eb5ad-958f-4492-adde-c5914e708d28")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,65,142,131,48,12,60,195,43,220,91,114,241,3,22,177,61,20,129,56,172,42,109,247,3,81,234,182,145,8,84,142,179,21,90,241,247,5,210,86,61,244,98,203,99,123,60,227,32,236,250,51,120,231,233,103,188,18,148,208,199,174,43,114,225,17,254,242,44,134,165,171,14,99,16,242,88,177,185,205,53,182,222,156,9,220,26,75,120,215,196,154,7,127,16,38,227,85,88,147,214,11,95,246,107,24,236,112,36,251,126,241,73,176,91,102,218,254,52,96,67,178,34,21,45,123,28,148,198,218,113,144,61,87,116,50,177,19,53,115,125,130,197,122,96,111,164,173,160,44,147,54,252,54,183,4,98,19,221,81,23,243,253,23,163,42,233,216,36,203,26,182,73,24,126,61,70,62,238,191,200,166,124,2,107,196,94,102,11,83,206,36,145,251,231,203,138,127,96,136,229,253,67,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServerEditPage_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("140a6206-152d-475f-b489-a588a549c421"));
		}

		#endregion

	}

	#endregion

}

