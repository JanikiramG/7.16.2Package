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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: ExchangeMailServerEditPageSchema

	/// <exclude/>
	public class ExchangeMailServerEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _autodiscoverCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox AutodiscoverCheckBox {
			get {
				return _autodiscoverCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _exchangeAddressTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ExchangeAddressTextEdit {
			get {
				return _exchangeAddressTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _downloadingSending;
		public Terrasoft.UI.WebControls.Controls.Label DownloadingSending {
			get {
				return _downloadingSending;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _allowEmailDownloadingCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailDownloadingCheckBox {
			get {
				return _allowEmailDownloadingCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _allowEmailSendingCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailSendingCheckBox {
			get {
				return _allowEmailSendingCheckBox;
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

		public ExchangeMailServerEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ExchangeMailServerEditPageSchema(ExchangeMailServerEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			RealUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			Name = "ExchangeMailServerEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			Width = 490;
			Height = 400;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateExchangeMailServerEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateAutodiscoverCheckBox());
			MainControlLayout.InsertItem(2, CreateExchangeAddressTextEdit());
			MainControlLayout.InsertItem(3, CreateDownloadingSending());
			MainControlLayout.InsertItem(4, CreateAllowEmailDownloadingCheckBox());
			MainControlLayout.InsertItem(5, CreateAllowEmailSendingCheckBox());
			MainControlLayout.InsertItem(6, CreateLoginParametersControlLayout());
			LoginParametersControlLayout.InsertItem(0, CreateUseLoginRadioButton());
			LoginParametersControlLayout.InsertItem(1, CreateUseUserNameAsLoginRadioButton());
			LoginParametersControlLayout.InsertItem(2, CreateUseEmailAddressAsLoginRadioButton());
			MainControlLayout.InsertItem(7, CreateImageAndSettingsLabel());
			MainControlLayout.InsertItem(8, CreateLogoEdit());
			MainControlLayout.MoveItem(9, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateExchangeMailServerEditPageEventsProcessSchema() {
			var schema = new ExchangeMailServerEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("cc420bbf-5a7f-401d-95ce-c72770f24db6");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_nameEdit.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_nameEdit.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.AlignedByCaption = false;
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("300db023-841f-476c-85b8-282dea072cd7");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateAutodiscoverCheckBox() {
			_autodiscoverCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_autodiscoverCheckBox.UId = new Guid("8ab4b97e-7045-44da-b75d-d5855c3fdc4c");
			_autodiscoverCheckBox.Name = "AutodiscoverCheckBox";
			_autodiscoverCheckBox.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_autodiscoverCheckBox.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_autodiscoverCheckBox.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			_autodiscoverCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_autodiscoverCheckBox.Tag = "";
			_autodiscoverCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_autodiscoverCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_autodiscoverCheckBox.AlignedByCaption = false;
			_autodiscoverCheckBox.DataSource = "DataSource";
			_autodiscoverCheckBox.ColumnUId = new Guid("0eb25696-08ab-4fd2-a671-ac46c77d3339");
			return _autodiscoverCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateExchangeAddressTextEdit() {
			_exchangeAddressTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_exchangeAddressTextEdit.UId = new Guid("5e741b45-74f0-45d9-8cb2-f561d34067d1");
			_exchangeAddressTextEdit.Name = "ExchangeAddressTextEdit";
			_exchangeAddressTextEdit.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_exchangeAddressTextEdit.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_exchangeAddressTextEdit.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			_exchangeAddressTextEdit.Tag = "";
			_exchangeAddressTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_exchangeAddressTextEdit.Image = new ControlImage {};
			_exchangeAddressTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_exchangeAddressTextEdit.Margins = "0 0 5 20";
			_exchangeAddressTextEdit.DataSource = "DataSource";
			_exchangeAddressTextEdit.ColumnUId = new Guid("86a68f6f-4b49-4ea1-b2c2-b547cfffbe8e");
			return _exchangeAddressTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateDownloadingSending() {
			_downloadingSending = new Terrasoft.UI.WebControls.Controls.Label();
			_downloadingSending.UId = new Guid("44a0237c-a899-4083-abf5-525bf6ad0826");
			_downloadingSending.Name = "DownloadingSending";
			_downloadingSending.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_downloadingSending.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_downloadingSending.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			_downloadingSending.Tag = "";
			_downloadingSending.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_downloadingSending.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_downloadingSending.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _downloadingSending;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateAllowEmailDownloadingCheckBox() {
			_allowEmailDownloadingCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_allowEmailDownloadingCheckBox.UId = new Guid("be0b48a1-384f-41e4-abac-946ddd92278d");
			_allowEmailDownloadingCheckBox.Name = "AllowEmailDownloadingCheckBox";
			_allowEmailDownloadingCheckBox.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_allowEmailDownloadingCheckBox.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_allowEmailDownloadingCheckBox.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			_allowEmailDownloadingCheckBox.Tag = "";
			_allowEmailDownloadingCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allowEmailDownloadingCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allowEmailDownloadingCheckBox.AlignedByCaption = false;
			_allowEmailDownloadingCheckBox.Margins = "0 0 0 20";
			_allowEmailDownloadingCheckBox.DataSource = "DataSource";
			_allowEmailDownloadingCheckBox.ColumnUId = new Guid("90a7d885-f781-48ba-b9ae-38fe652910bb");
			return _allowEmailDownloadingCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateAllowEmailSendingCheckBox() {
			_allowEmailSendingCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_allowEmailSendingCheckBox.UId = new Guid("9d0e2de8-4227-4b3b-b7f3-19eaa013c1d2");
			_allowEmailSendingCheckBox.Name = "AllowEmailSendingCheckBox";
			_allowEmailSendingCheckBox.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_allowEmailSendingCheckBox.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_allowEmailSendingCheckBox.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			_allowEmailSendingCheckBox.Tag = "";
			_allowEmailSendingCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allowEmailSendingCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allowEmailSendingCheckBox.AlignedByCaption = false;
			_allowEmailSendingCheckBox.Margins = "0 0 0 20";
			_allowEmailSendingCheckBox.DataSource = "DataSource";
			_allowEmailSendingCheckBox.ColumnUId = new Guid("4ba547e7-d762-40e7-a569-3d5b241eb2f1");
			return _allowEmailSendingCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateUseLoginRadioButton() {
			_useLoginRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_useLoginRadioButton.UId = new Guid("ca5e7c81-fef8-4b86-a803-39f928c6a0eb");
			_useLoginRadioButton.Name = "UseLoginRadioButton";
			_useLoginRadioButton.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_useLoginRadioButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_useLoginRadioButton.CreatedInPackageId = new Guid("1de63699-0e23-4471-ab45-29b30174f8a3");
			_useLoginRadioButton.Tag = "";
			_useLoginRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useLoginRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useLoginRadioButton.Margins = "0 0 0 -55";
			_useLoginRadioButton.DataSource = "DataSource";
			_useLoginRadioButton.ColumnUId = new Guid("fdc08ae7-dad5-4d40-8f17-dd6cbd6ba93b");
			_useLoginRadioButton.GroupName = "LoginParametersControlLayout";
			return _useLoginRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateUseUserNameAsLoginRadioButton() {
			_useUserNameAsLoginRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_useUserNameAsLoginRadioButton.UId = new Guid("3f1f47b2-6728-44ba-bc82-22f799e6d4d2");
			_useUserNameAsLoginRadioButton.Name = "UseUserNameAsLoginRadioButton";
			_useUserNameAsLoginRadioButton.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_useUserNameAsLoginRadioButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_useUserNameAsLoginRadioButton.CreatedInPackageId = new Guid("1de63699-0e23-4471-ab45-29b30174f8a3");
			_useUserNameAsLoginRadioButton.Tag = "";
			_useUserNameAsLoginRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useUserNameAsLoginRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useUserNameAsLoginRadioButton.Margins = "0 0 0 -55";
			_useUserNameAsLoginRadioButton.DataSource = "DataSource";
			_useUserNameAsLoginRadioButton.ColumnUId = new Guid("73c15ed2-ddf3-4b5b-9010-8e996a513c6e");
			_useUserNameAsLoginRadioButton.GroupName = "LoginParametersControlLayout";
			return _useUserNameAsLoginRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateUseEmailAddressAsLoginRadioButton() {
			_useEmailAddressAsLoginRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_useEmailAddressAsLoginRadioButton.UId = new Guid("100a7ad7-53f6-4be8-80e8-50594dc9b979");
			_useEmailAddressAsLoginRadioButton.Name = "UseEmailAddressAsLoginRadioButton";
			_useEmailAddressAsLoginRadioButton.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_useEmailAddressAsLoginRadioButton.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_useEmailAddressAsLoginRadioButton.CreatedInPackageId = new Guid("1de63699-0e23-4471-ab45-29b30174f8a3");
			_useEmailAddressAsLoginRadioButton.Tag = "";
			_useEmailAddressAsLoginRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_useEmailAddressAsLoginRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_useEmailAddressAsLoginRadioButton.Margins = "0 0 0 -55";
			_useEmailAddressAsLoginRadioButton.DataSource = "DataSource";
			_useEmailAddressAsLoginRadioButton.ColumnUId = new Guid("bc82b601-2d8d-41fc-874d-96986410d4e6");
			_useEmailAddressAsLoginRadioButton.GroupName = "LoginParametersControlLayout";
			return _useEmailAddressAsLoginRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLoginParametersControlLayout() {
			_loginParametersControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_loginParametersControlLayout.UId = new Guid("17621adf-84ad-4f9c-873b-801e7f1167f7");
			_loginParametersControlLayout.Name = "LoginParametersControlLayout";
			_loginParametersControlLayout.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_loginParametersControlLayout.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_loginParametersControlLayout.CreatedInPackageId = new Guid("1de63699-0e23-4471-ab45-29b30174f8a3");
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
			_imageAndSettingsLabel.UId = new Guid("b7d9ce25-b1d7-4aa9-95cd-3f0d6048cc5e");
			_imageAndSettingsLabel.Name = "ImageAndSettingsLabel";
			_imageAndSettingsLabel.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_imageAndSettingsLabel.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_imageAndSettingsLabel.CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac");
			_imageAndSettingsLabel.Tag = "";
			_imageAndSettingsLabel.DisplayStyle = Terrasoft.UI.WebControls.Controls.LabelDisplayStyle.GroupHeader;
			_imageAndSettingsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_imageAndSettingsLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _imageAndSettingsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FileUploadEdit CreateLogoEdit() {
			_logoEdit = new Terrasoft.UI.WebControls.Controls.FileUploadEdit();
			_logoEdit.UId = new Guid("95197e3a-0209-4440-b042-34f1eda2ef56");
			_logoEdit.Name = "LogoEdit";
			_logoEdit.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_logoEdit.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			_logoEdit.CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac");
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
			DataSource.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("890aafb6-812e-4546-a3f2-a16de56d5a42");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("9ddd02ae-79e1-46b3-8cad-f74b08b5442b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("9ca8bc41-2c89-4de5-bd77-6ddc447fdf04");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("f7ecea63-8142-43f6-8564-1ac240a90f11");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("0173c7be-996f-4c8a-b407-1c68fa3bd5b3");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f0fec10e-c639-4ebb-b0d4-75ba7beb2b30");
			if (column != null) {
				column.UId = new Guid("300db023-841f-476c-85b8-282dea072cd7");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("be4a6212-190c-4430-8b31-6972ac32503f");
			if (column != null) {
				column.UId = new Guid("09e8d308-5ba4-48f5-ba21-fac9d239e4d1");
				column.Name = @"Address";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b9e6dfc3-cd79-4707-9f3d-9b6bedda3c5f");
			if (column != null) {
				column.UId = new Guid("b18818cd-d684-4613-b530-bc527f2a10b4");
				column.Name = @"Port";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("773d7c26-389e-421c-a67e-9ca6a8b8a3e9");
			if (column != null) {
				column.UId = new Guid("4dbeec6f-afe4-4540-aa46-7b91bb7a09bd");
				column.Name = @"UseSSL";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("adbc103b-6492-44ca-87de-b542cf08499b");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9a6b34c9-96b3-45f5-b005-dfcd12e79d6d");
			if (column != null) {
				column.UId = new Guid("894c6860-14c7-4de6-9e35-669ff8e49d5a");
				column.Name = @"EmailProtocol";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("89e2b329-bf63-4d5c-a079-6cf6c5fa9430");
			if (column != null) {
				column.UId = new Guid("90a7d885-f781-48ba-b9ae-38fe652910bb");
				column.Name = @"AllowEmailDownloading";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411aaeae-43da-4e1c-8b1c-1655c25aac96");
			if (column != null) {
				column.UId = new Guid("4ba547e7-d762-40e7-a569-3d5b241eb2f1");
				column.Name = @"AllowEmailSending";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("394009b0-7664-46b4-b052-5754522f03c3");
			if (column != null) {
				column.UId = new Guid("1890b0da-2012-4746-af39-d11fb5d944e9");
				column.Name = @"SMTPServerAddress";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c6d3e3b2-5552-4b06-9d5c-fe34b58ae7aa");
			if (column != null) {
				column.UId = new Guid("a0f430ff-4a0e-4208-9e37-5392cc947f53");
				column.Name = @"SMTPPort";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6094ebec-dee7-492e-8977-4e2748a9b4bb");
			if (column != null) {
				column.UId = new Guid("ba79b3ea-363e-4f7d-b739-700ff598f5ab");
				column.Name = @"SMTPServerTimeout";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("33affd30-ab8b-4975-8917-9baa63d2d025");
			if (column != null) {
				column.UId = new Guid("c450c2f5-e0b9-40cf-8ae6-5581a8f8270b");
				column.Name = @"UseSSLforSending";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ff05d2f5-bc16-4d80-b361-13120a07867e");
			if (column != null) {
				column.UId = new Guid("86a68f6f-4b49-4ea1-b2c2-b547cfffbe8e");
				column.Name = @"ExchangeEmailAddress";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1b376a5e-a709-468a-92c3-fb99001fd041");
			if (column != null) {
				column.UId = new Guid("4e80b5ea-ec20-4a4c-8181-36f2dfe44bb1");
				column.Name = @"IsExchangeServer";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5a1ceded-281a-4994-bf5f-5fe57b752e0b");
			if (column != null) {
				column.UId = new Guid("0eb25696-08ab-4fd2-a671-ac46c77d3339");
				column.Name = @"IsExchengeAutodiscover";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a017673a-f233-4df8-8ba8-fd299bae4e20");
			if (column != null) {
				column.UId = new Guid("8fd6f053-a9f6-43ca-8d84-19a3bf9f82e6");
				column.Name = @"IsStartTls";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("411a2310-81f3-4a83-896e-87eccdbae77f");
			if (column != null) {
				column.UId = new Guid("4b64d36f-d3b1-460d-9629-7b8fac857a99");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("29f424ac-945a-4548-a60e-5e738cf01711");
			if (column != null) {
				column.UId = new Guid("fdc08ae7-dad5-4d40-8f17-dd6cbd6ba93b");
				column.Name = @"UseLogin";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("38790f02-593c-4eb3-80be-2204877697a0");
			if (column != null) {
				column.UId = new Guid("bc82b601-2d8d-41fc-874d-96986410d4e6");
				column.Name = @"UseEmailAddressAsLogin";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("30e37f76-b60e-4975-89a0-befc3e75eeb7");
			if (column != null) {
				column.UId = new Guid("73c15ed2-ddf3-4b5b-9010-8e996a513c6e");
				column.Name = @"UseUserNameAsLogin";
				column.CreatedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
				column.ModifiedInSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
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
			return new ExchangeMailServerEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ExchangeMailServerEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ExchangeMailServerEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ExchangeMailServerEditPageEventsProcess

	/// <exclude/>
	public class ExchangeMailServerEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ExchangeMailServerEditPageSchemaUserControl
	{

		public ExchangeMailServerEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExchangeMailServerEditPageEventsProcess";
			SchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_defaultLogo = () => {{ return "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAIAAAD8GO2jAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAABWlJREFUeNq0VmtsFFUUPndeO7tbtt1229IWCqG2Ka+mAga1RJRXjMhDNAT4QYIJJhoTRBKJUYkRYnwElIoaSWoiP4AQg4/ADyAVooYQKvZFC3T73m5L99Xu7O685453tktB6GNL0ptJdnbmzPnOPec737lITmgUjWB6lqZihnhnbfQ0AegqptK3Dgj62YbAzuMt//ji6X/FjPciFFN6gqJ3SG4PKde7E3eCmi+mSoE4DMpbVxQ+BgBuC0oNvUJnWOmKaC0BtdEXi8cUkE3QDCBFImnkKMjkgaUcLDU1gN5QYs23Ld6gDoIEevIxh8DBgZ0FJ4IHGYBNMKdWBgsgKhre9jg4Wch1QBqE0rE5NQCOoSCLAwqN7Z14+/9znqGwaQYFmaKoR78wTRMbKN9tG6fIJN2iAVEVMAYTEfMkMII83nqVjL0sz9E6kFj83lV7gRMhKyzdMFUVQyp9yKaaVYuzzu1eMBaApOe6+apKj8uGHBxy2ViPi0XY/OSSL0aAGStiK2wCHMUSViCXBxlDQgMXA4i2MDBWdPxHXbh7izQ3g38EIKxuWJFXs7XsoceHr/hjkgozWHJ/cyCxqjSz58TK1d+0tvfGIG4cer30g3XFVq8kNF8kvuyrVohjCjFj7QAhgyQnuf7qiIYFxcYxcVUXdRPuNTxHU4JkFLrZ+gOLZ7xcu23rHOK9LyIqslpSmJXndFMshQ0DoTFrgMBI+YdtJzr6GwbBY7eK7CKsZUbeleXZWwYSzx6u31iWWbo899TOBdVX+vZ830qa5vKnS59f6HmQF8wEDBNkHRI62DVw81b4Gh7lSZaDgX7194GgfvaFU/8G9lQ3w2wX+BKkKVNMMdMAqH61uG9FHsszJxvDzR0COFPGNIVE4imqHPyo4uKtoR3VLVaH98uVT3nWVniudUXxXREctskB1pRl4pJMnqNvh8XmhtAoQE9ELc+379r1xPELd31hKdtBH9o2j9Hh51vDWz6v/6UzbiWTRZMDVB296bs5BDOdlnWBY3TX+S62sU+0M9QzC12+c8Pr1s9668e29ZWeC+9U/NoU/u1YCybEtaUAJpAtMxzHEFEgIEFIAXS/zzkaZTno737qOnOq+4e9899eWcDx7Pk/B5d/2bC5IufGx08iygQFT7oD9PXm4jtL3GET+QXlklewGjtFNFCIJsblD/cveuPp2ejNv60gihzXL/prXypavTAX5fJmQBsHQDfd9hTfd1cVALmIhmKN3ncNNGQpNvFumENx7ZXtcw9uKHnxWPOOJW5PXmFNrR/mZNjZpEN9Apq62Gvd4ukbg24H68mg853MrGwnoStF0RhSu24dENeWZ60qz/qitufCma4jh5bufa7o6KZ5o7qIKIB7ivsIgJuta49tb4wAkVieZmyoONsxM4Mh1MQcPSJnLjtj6Hr1Zf/+072wKPvdmva+iPJaZQ7pgbhkBKIiJsLH0iMNO0aKgKSIpyxXhqkrZmd3rJPYZnNW+yT7aH6+vb5P2Pd+HZRlA0VQ8ZGatiPIHInc+tDGQgZto/H4RR7hDJFNIm48fX8wJFdE1Dwz7Ms2zmVcySlieYWkgFkpIlRgYuqqSvccD68mMPMYh5GOkEx6sO7AsskMCV4SQCFp6RctrXfZrPyQ7E841dM+pqFUiopybPt3lnQE5Ua/4g1JIKggGxYNyLSwUeQYYWE/oF8ITXHo5zi5zzaVjGzKezfRMyx5g2pTv1jfl+iOqoNDEgyb1tiiyUhgCAyaCsJDNUClMzPItaY89V9W9d4h9XZAutoltAXEer/Y3RQWJH0KW1Bl3Ux7Sap2vmmwJyKmaS8KKiI/MJ2LEULy9J2uxZj2nwADAC4LvQzDtoQcAAAAAElFTkSuQmCC"; }};
			_defaultFileSize = () => {{ return 1479; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13");
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

		private Func<string> _defaultLogo;
		public virtual string DefaultLogo {
			get {
				return (_defaultLogo ?? (_defaultLogo = () => null)).Invoke();
			}
			set {
				_defaultLogo = () => { return value; };
			}
		}

		private Func<int> _defaultFileSize;
		public virtual int DefaultFileSize {
			get {
				return (_defaultFileSize ?? (_defaultFileSize = () => 0)).Invoke();
			}
			set {
				_defaultFileSize = () => { return value; };
			}
		}

		private ProcessFlowElement _exchangeMailServerEditPageOKButtonClickEventSubProcess;
		public ProcessFlowElement ExchangeMailServerEditPageOKButtonClickEventSubProcess {
			get {
				return _exchangeMailServerEditPageOKButtonClickEventSubProcess ?? (_exchangeMailServerEditPageOKButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ExchangeMailServerEditPageOKButtonClickEventSubProcess",
					SchemaElementUId = new Guid("59f16600-d7ba-4655-99fb-a343a3f8a3b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _exchangeMailServerEditPageOKButtonClickStartMessage;
		public ProcessFlowElement ExchangeMailServerEditPageOKButtonClickStartMessage {
			get {
				return _exchangeMailServerEditPageOKButtonClickStartMessage ?? (_exchangeMailServerEditPageOKButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ExchangeMailServerEditPageOKButtonClickStartMessage",
					SchemaElementUId = new Guid("8c186a85-9dc6-488d-98bd-56902ffef1ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _exchangeMailServerEditPageOKButtonClickScriptTask;
		public ProcessScriptTask ExchangeMailServerEditPageOKButtonClickScriptTask {
			get {
				return _exchangeMailServerEditPageOKButtonClickScriptTask ?? (_exchangeMailServerEditPageOKButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ExchangeMailServerEditPageOKButtonClickScriptTask",
					SchemaElementUId = new Guid("e08f9539-c10d-40db-950a-4939b517d562"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ExchangeMailServerEditPageOKButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _exchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent {
			get {
				return _exchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent ?? (_exchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("6f162699-1605-40c7-869e-afa5b1e8b418"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _exchangeMailServerEditPageIsAutodiscoverClickEventSubProcess;
		public ProcessFlowElement ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess {
			get {
				return _exchangeMailServerEditPageIsAutodiscoverClickEventSubProcess ?? (_exchangeMailServerEditPageIsAutodiscoverClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess",
					SchemaElementUId = new Guid("88b6ee87-2617-4659-8e43-022357e690f6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _autodiscoverCheckBoxCheckStartMessage;
		public ProcessFlowElement AutodiscoverCheckBoxCheckStartMessage {
			get {
				return _autodiscoverCheckBoxCheckStartMessage ?? (_autodiscoverCheckBoxCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AutodiscoverCheckBoxCheckStartMessage",
					SchemaElementUId = new Guid("d1118f89-8ad0-4192-abd2-ecfa4c584367"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isAutodiscoverCheckBoxChekcScriptTask;
		public ProcessScriptTask IsAutodiscoverCheckBoxChekcScriptTask {
			get {
				return _isAutodiscoverCheckBoxChekcScriptTask ?? (_isAutodiscoverCheckBoxChekcScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsAutodiscoverCheckBoxChekcScriptTask",
					SchemaElementUId = new Guid("053a5bc4-5b46-4102-bef0-a68b7648807f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsAutodiscoverCheckBoxChekcScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _logoEditChangeEventSubProcess1;
		public ProcessFlowElement LogoEditChangeEventSubProcess1 {
			get {
				return _logoEditChangeEventSubProcess1 ?? (_logoEditChangeEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LogoEditChangeEventSubProcess1",
					SchemaElementUId = new Guid("780fbdc9-2046-44f6-99df-94e4e53aa9c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _logoEditChangeStartMessage;
		public ProcessFlowElement LogoEditChangeStartMessage {
			get {
				return _logoEditChangeStartMessage ?? (_logoEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LogoEditChangeStartMessage",
					SchemaElementUId = new Guid("dce6f969-b3c9-49bf-83c4-b37ab16d2128"),
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
					SchemaElementUId = new Guid("ad232927-371b-4f01-ab31-c528e3da8fb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogoEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("f1c79245-233a-49cb-ab27-41830d649650"),
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
					SchemaElementUId = new Guid("22efded1-80a0-4c09-8794-735fe304824d"),
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
					SchemaElementUId = new Guid("0e1415cd-eb11-4a2f-be0b-184ae6371de6"),
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
					SchemaElementUId = new Guid("dc9c1ece-2152-4b08-9c88-9c34789e3a83"),
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
					SchemaElementUId = new Guid("35c4616f-16aa-4163-9809-0f6ac4e0eb69"),
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
					SchemaElementUId = new Guid("00a82906-03a6-4525-897c-a64bb1a7ec09"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("2bd2769e-86f3-4ae0-8381-f5b01adcdb75"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitMailboxScriptTaskExecute,
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
					SchemaElementUId = new Guid("cb9abb6d-7d6d-49b6-9a08-aba774c03ae5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteMailServerEventSubProcess;
		public ProcessFlowElement PageLoadCompleteMailServerEventSubProcess {
			get {
				return _pageLoadCompleteMailServerEventSubProcess ?? (_pageLoadCompleteMailServerEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteMailServerEventSubProcess",
					SchemaElementUId = new Guid("c6b595fb-d1ab-41da-b4c1-9786cb6e2fdd"),
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
					SchemaElementUId = new Guid("32d2ca36-a833-40fb-bc08-f927460a68cf"),
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
					SchemaElementUId = new Guid("d5195e8f-5c12-4b4d-a72e-c0f85a2f8b22"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _parentPageLoadComplete;
		public ProcessThrowMessageEvent ParentPageLoadComplete {
			get {
				return _parentPageLoadComplete ?? (_parentPageLoadComplete = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ParentPageLoadComplete",
					SchemaElementUId = new Guid("31faf4f5-11fb-4cd1-a46b-780a0940dafe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
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
			FlowElements[ExchangeMailServerEditPageOKButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ExchangeMailServerEditPageOKButtonClickEventSubProcess };
			FlowElements[ExchangeMailServerEditPageOKButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ExchangeMailServerEditPageOKButtonClickStartMessage };
			FlowElements[ExchangeMailServerEditPageOKButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ExchangeMailServerEditPageOKButtonClickScriptTask };
			FlowElements[ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent };
			FlowElements[ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess };
			FlowElements[AutodiscoverCheckBoxCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AutodiscoverCheckBoxCheckStartMessage };
			FlowElements[IsAutodiscoverCheckBoxChekcScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IsAutodiscoverCheckBoxChekcScriptTask };
			FlowElements[LogoEditChangeEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { LogoEditChangeEventSubProcess1 };
			FlowElements[LogoEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { LogoEditChangeStartMessage };
			FlowElements[LogoEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogoEditChangeScriptTask };
			FlowElements[PageLoadEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadEventSubProcess };
			FlowElements[PageLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadStartMessage };
			FlowElements[PageLoadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadScriptTask };
			FlowElements[PageLoadIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadIntermediateThrowMessageEvent };
			FlowElements[InitMailServerEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailServerEventSubProcess };
			FlowElements[InitMailServerStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailServerStartMessage };
			FlowElements[InitMailboxScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailboxScriptTask };
			FlowElements[InitMailboxIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMailboxIntermediateThrowMessageEvent1 };
			FlowElements[PageLoadCompleteMailServerEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteMailServerEventSubProcess };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[PageLoadCompleteChildScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScriptTask };
			FlowElements[ParentPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ExchangeMailServerEditPageOKButtonClickEventSubProcess":
						break;
					case "ExchangeMailServerEditPageOKButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("ExchangeMailServerEditPageOKButtonClickScriptTask");
						break;
					case "ExchangeMailServerEditPageOKButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent");
						break;
					case "ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent":
						break;
					case "ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess":
						break;
					case "AutodiscoverCheckBoxCheckStartMessage":
						e.Context.QueueTasks.Enqueue("IsAutodiscoverCheckBoxChekcScriptTask");
						break;
					case "IsAutodiscoverCheckBoxChekcScriptTask":
						break;
					case "LogoEditChangeEventSubProcess1":
						break;
					case "LogoEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("LogoEditChangeScriptTask");
						break;
					case "LogoEditChangeScriptTask":
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
					case "InitMailboxScriptTask":
						e.Context.QueueTasks.Enqueue("InitMailboxIntermediateThrowMessageEvent1");
						break;
					case "InitMailboxIntermediateThrowMessageEvent1":
						break;
					case "PageLoadCompleteMailServerEventSubProcess":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("ParentPageLoadComplete");
						break;
					case "PageLoadCompleteChildScriptTask":
						break;
					case "ParentPageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ExchangeMailServerEditPageOKButtonClickStartMessage");
			ActivatedEventElements.Add("AutodiscoverCheckBoxCheckStartMessage");
			ActivatedEventElements.Add("LogoEditChangeStartMessage");
			ActivatedEventElements.Add("PageLoadStartMessage");
			ActivatedEventElements.Add("InitMailServerStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteChild");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ExchangeMailServerEditPageOKButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ExchangeMailServerEditPageOKButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExchangeMailServerEditPageOKButtonClickStartMessage";
					result = ExchangeMailServerEditPageOKButtonClickStartMessage.Execute(context);
					break;
				case "ExchangeMailServerEditPageOKButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExchangeMailServerEditPageOKButtonClickScriptTask";
					result = ExchangeMailServerEditPageOKButtonClickScriptTask.Execute(context, ExchangeMailServerEditPageOKButtonClickScriptTaskExecute);
					break;
				case "ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AutodiscoverCheckBoxCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AutodiscoverCheckBoxCheckStartMessage";
					result = AutodiscoverCheckBoxCheckStartMessage.Execute(context);
					break;
				case "IsAutodiscoverCheckBoxChekcScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsAutodiscoverCheckBoxChekcScriptTask";
					result = IsAutodiscoverCheckBoxChekcScriptTask.Execute(context, IsAutodiscoverCheckBoxChekcScriptTaskExecute);
					break;
				case "LogoEditChangeEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "LogoEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogoEditChangeStartMessage";
					result = LogoEditChangeStartMessage.Execute(context);
					break;
				case "LogoEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogoEditChangeScriptTask";
					result = LogoEditChangeScriptTask.Execute(context, LogoEditChangeScriptTaskExecute);
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
				case "InitMailboxScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMailboxScriptTask";
					result = InitMailboxScriptTask.Execute(context, InitMailboxScriptTaskExecute);
					break;
				case "InitMailboxIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitMailboxIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageLoadCompleteMailServerEventSubProcess":
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
				case "ParentPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = ParentPageLoadComplete.Execute(context);
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

		public virtual bool ExchangeMailServerEditPageOKButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			bool validationResult = IsValidParameters();
			if (validationResult) {
				SetLogo();
			}
			return validationResult;
		}

		public virtual bool IsAutodiscoverCheckBoxChekcScriptTaskExecute(ProcessExecutingContext context) {
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

		public virtual bool PageLoadScriptTaskExecute(ProcessExecutingContext context) {
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			Page.OKButton.AjaxEvents.Click.ShowLoadMask = true;
			Page.OKButton.AjaxEvents.Click.ShowOpaqueMask = true;
			return true;
		}

		public virtual bool InitMailboxScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeSaveRow +=
			 delegate(object sender, DataSourceEventArgs e) {
				e.Row.SetColumnValue("TypeId", new Guid("3490BD45-4F4D-4613-AA06-454546F3342A"));
			};
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageMailServers");
			SetControlsEnableRequire();
			return true;
		}

		public virtual bool IsValidParameters() {
			Page.BaseMessagePanel.Clear();
			if (!Page.AllowEmailDownloadingCheckBox.Checked && !Page.AllowEmailSendingCheckBox.Checked) {
				Page.BaseMessagePanel.AddMessage(Warning, SendOrReceiveSettingAreRequiredLS, MessageType.Warning);
				return false;
			}
			return true;
		}

		public virtual void SetControlsEnableRequire() {
			bool isAutodiscover = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("IsExchengeAutodiscover");
			bool isExchangeAddressRequired = !isAutodiscover;
			Page.ExchangeAddressTextEdit.SetEnabled(isExchangeAddressRequired);
			Page.ExchangeAddressTextEdit.SetRequired(isExchangeAddressRequired);
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

		public virtual void SetLogo() {
			Guid logoId = Guid.Empty;
			string logoName = FileName;
			string fileContent = (string)FileContent;
			int fileSize = FileSize;
			if (fileContent.IsNullOrEmpty() && Page.DataSource.ActiveRow.StoringState == StoringObjectState.New) {
				logoName = Guid.NewGuid().ToString();
				fileContent = DefaultLogo;
				fileSize = DefaultFileSize;
			}
			byte[] fileData = Convert.FromBase64String(fileContent ?? string.Empty) as byte[];
			var memoryStream = new MemoryStream();
			memoryStream.Write(fileData, 0, fileSize);
			string mimeType = GetMimeType(memoryStream);
			if (!string.IsNullOrEmpty(mimeType) && mimeType.Contains("image")) {
				Terrasoft.Core.ImageAPI.ImageAPI imageApi = new Core.ImageAPI.ImageAPI(UserConnection);
				logoId = imageApi.Save(memoryStream, mimeType, logoName);
			}
			if (logoId.IsNotEmpty()) {
				Page.DataSource.ActiveRow.SetColumnBothValues("LogoId", logoId, "LogoName", logoName);
				string script = string.Format("{0}.setColumnValue('LogoId', '{1}');", Page.DataSource.ClientID, logoId);
				Page.ScriptManager.AddScript(script);
			}
			memoryStream.Close();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("ExchangeMailServerEditPageOKButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("ExchangeMailServerEditPageOKButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "AutodiscoverCheckBoxCheck":
							if (ActivatedEventElements.Contains("AutodiscoverCheckBoxCheckStartMessage")) {
							context.QueueTasks.Enqueue("AutodiscoverCheckBoxCheckStartMessage");
						}
						break;
					case "LogoEditChange":
							if (ActivatedEventElements.Contains("LogoEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("LogoEditChangeStartMessage");
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

	#region Class: ExchangeMailServerEditPageEventsProcess

	/// <exclude/>
	public class ExchangeMailServerEditPageEventsProcess : ExchangeMailServerEditPageEventsProcess<Terrasoft.WebApp.ExchangeMailServerEditPageSchemaUserControl>
	{

		public ExchangeMailServerEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExchangeMailServerEditPageSchemaUserControl

	/// <exclude/>
	public partial class ExchangeMailServerEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox AutodiscoverCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("AutodiscoverCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ExchangeAddressTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ExchangeAddressTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label DownloadingSending {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("DownloadingSending", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailDownloadingCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("AllowEmailDownloadingCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox AllowEmailSendingCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("AllowEmailSendingCheckBox", true);
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
			AutodiscoverCheckBox.AjaxEvents.Check.Event += AutodiscoverCheckBoxCheck;
			LogoEdit.AjaxEvents.Change.Event += LogoEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AutodiscoverCheckBox.AjaxEvents.Check.Event -= AutodiscoverCheckBoxCheck;
			LogoEdit.AjaxEvents.Change.Event -= LogoEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ExchangeMailServerEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ExchangeMailServerEditPageEventsProcess(UserConnection);
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

		public virtual void AutodiscoverCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("AutodiscoverCheckBoxCheck");
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
			SchemaName = "ExchangeMailServerEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ExchangeMailServerEditPageEventsProcessSchema

	/// <exclude/>
	public class ExchangeMailServerEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ExchangeMailServerEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ExchangeMailServerEditPageEventsProcessSchema(ExchangeMailServerEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ExchangeMailServerEditPageEventsProcess";
			UId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
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
			UId = new Guid("7395da3a-8a88-4b42-8114-640f28b53900"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"FileContent",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7fca6420-d4f0-4aee-8261-3e1060c7302b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"FileSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("14676eff-75d4-472f-99a9-2c50f4fcdf6f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"FileName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultLogoParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5b55ba0d-b205-42b8-9716-c0ea30af30dc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"DefaultLogo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultFileSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("250af2ce-8da2-48d1-8723-1fc382ca2157"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"DefaultFileSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"1479",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFileContentParameter());
			Parameters.Add(CreateFileSizeParameter());
			Parameters.Add(CreateFileNameParameter());
			Parameters.Add(CreateDefaultLogoParameter());
			Parameters.Add(CreateDefaultFileSizeParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaExchangeMailServerEditPageLaneSet = CreateExchangeMailServerEditPageLaneSetLaneSet();
			LaneSets.Add(schemaExchangeMailServerEditPageLaneSet);
			ProcessSchemaLane schemaExchangeMailServerEditPageButtonEventsLane = CreateExchangeMailServerEditPageButtonEventsLaneLane();
			schemaExchangeMailServerEditPageLaneSet.Lanes.Add(schemaExchangeMailServerEditPageButtonEventsLane);
			ProcessSchemaEventSubProcess exchangemailservereditpageokbuttonclickeventsubprocess = CreateExchangeMailServerEditPageOKButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(exchangemailservereditpageokbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess exchangemailservereditpageisautodiscoverclickeventsubprocess = CreateExchangeMailServerEditPageIsAutodiscoverClickEventSubProcessEventSubProcess();
			FlowElements.Add(exchangemailservereditpageisautodiscoverclickeventsubprocess);
			ProcessSchemaEventSubProcess logoeditchangeeventsubprocess1 = CreateLogoEditChangeEventSubProcess1EventSubProcess();
			FlowElements.Add(logoeditchangeeventsubprocess1);
			ProcessSchemaEventSubProcess pageloadeventsubprocess = CreatePageLoadEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadeventsubprocess);
			ProcessSchemaEventSubProcess initmailservereventsubprocess = CreateInitMailServerEventSubProcessEventSubProcess();
			FlowElements.Add(initmailservereventsubprocess);
			ProcessSchemaEventSubProcess pageloadcompletemailservereventsubprocess = CreatePageLoadCompleteMailServerEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletemailservereventsubprocess);
			ProcessSchemaStartMessageEvent exchangemailservereditpageokbuttonclickstartmessage = CreateExchangeMailServerEditPageOKButtonClickStartMessageStartMessageEvent();
			exchangemailservereditpageokbuttonclickeventsubprocess.FlowElements.Add(exchangemailservereditpageokbuttonclickstartmessage);
			ProcessSchemaScriptTask exchangemailservereditpageokbuttonclickscripttask = CreateExchangeMailServerEditPageOKButtonClickScriptTaskScriptTask();
			exchangemailservereditpageokbuttonclickeventsubprocess.FlowElements.Add(exchangemailservereditpageokbuttonclickscripttask);
			ProcessSchemaIntermediateThrowMessageEvent exchangemailservereditpageokbuttonclickintermediatethrowmessageevent = CreateExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			exchangemailservereditpageokbuttonclickeventsubprocess.FlowElements.Add(exchangemailservereditpageokbuttonclickintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent autodiscovercheckboxcheckstartmessage = CreateAutodiscoverCheckBoxCheckStartMessageStartMessageEvent();
			exchangemailservereditpageisautodiscoverclickeventsubprocess.FlowElements.Add(autodiscovercheckboxcheckstartmessage);
			ProcessSchemaScriptTask isautodiscovercheckboxchekcscripttask = CreateIsAutodiscoverCheckBoxChekcScriptTaskScriptTask();
			exchangemailservereditpageisautodiscoverclickeventsubprocess.FlowElements.Add(isautodiscovercheckboxchekcscripttask);
			ProcessSchemaStartMessageEvent logoeditchangestartmessage = CreateLogoEditChangeStartMessageStartMessageEvent();
			logoeditchangeeventsubprocess1.FlowElements.Add(logoeditchangestartmessage);
			ProcessSchemaScriptTask logoeditchangescripttask = CreateLogoEditChangeScriptTaskScriptTask();
			logoeditchangeeventsubprocess1.FlowElements.Add(logoeditchangescripttask);
			ProcessSchemaStartMessageEvent pageloadstartmessage = CreatePageLoadStartMessageStartMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(pageloadstartmessage);
			ProcessSchemaScriptTask pageloadscripttask = CreatePageLoadScriptTaskScriptTask();
			pageloadeventsubprocess.FlowElements.Add(pageloadscripttask);
			ProcessSchemaIntermediateThrowMessageEvent pageloadintermediatethrowmessageevent = CreatePageLoadIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			pageloadeventsubprocess.FlowElements.Add(pageloadintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent initmailserverstartmessage = CreateInitMailServerStartMessageStartMessageEvent();
			initmailservereventsubprocess.FlowElements.Add(initmailserverstartmessage);
			ProcessSchemaScriptTask initmailboxscripttask = CreateInitMailboxScriptTaskScriptTask();
			initmailservereventsubprocess.FlowElements.Add(initmailboxscripttask);
			ProcessSchemaIntermediateThrowMessageEvent initmailboxintermediatethrowmessageevent1 = CreateInitMailboxIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			initmailservereventsubprocess.FlowElements.Add(initmailboxintermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			pageloadcompletemailservereventsubprocess.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaScriptTask pageloadcompletechildscripttask = CreatePageLoadCompleteChildScriptTaskScriptTask();
			pageloadcompletemailservereventsubprocess.FlowElements.Add(pageloadcompletechildscripttask);
			ProcessSchemaIntermediateThrowMessageEvent parentpageloadcomplete = CreateParentPageLoadCompleteIntermediateThrowMessageEvent();
			pageloadcompletemailservereventsubprocess.FlowElements.Add(parentpageloadcomplete);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateLogoEditChangeSequenceFlow10SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSendOrReceiveSettingAreRequiredLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSendOrReceiveSettingAreRequiredLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8132e751-abb1-4af4-ab8f-dc2e3ec54bed"),
				Name = "SendOrReceiveSettingAreRequiredLS",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9a52e17a-395e-4c70-b117-43c3a9b512d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(182, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8c186a85-9dc6-488d-98bd-56902ffef1ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e08f9539-c10d-40db-950a-4939b517d562"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4482e2a0-dc2b-4d0b-a5b7-8e972cee7d77"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(294, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e08f9539-c10d-40db-950a-4939b517d562"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6f162699-1605-40c7-869e-afa5b1e8b418"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("a8f0524d-6e8f-410a-995f-54b9be7c6175"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(172, 276),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22efded1-80a0-4c09-8794-735fe304824d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e1415cd-eb11-4a2f-be0b-184ae6371de6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("4e67a41e-1591-4c79-b3f3-3341c715fc88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(277, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e1415cd-eb11-4a2f-be0b-184ae6371de6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc9c1ece-2152-4b08-9c88-9c34789e3a83"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("9b119c28-ccb5-4aad-b990-d0f1fb361b16"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(472, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00a82906-03a6-4525-897c-a64bb1a7ec09"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2bd2769e-86f3-4ae0-8381-f5b01adcdb75"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("a7ab2ad9-fe8e-4ca4-aa51-492a8fa3c987"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(585, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2bd2769e-86f3-4ae0-8381-f5b01adcdb75"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb9abb6d-7d6d-49b6-9a08-aba774c03ae5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("eb9f8e75-8ecd-410f-bbda-053abd86cf5b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(790, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32d2ca36-a833-40fb-bc08-f927460a68cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("31faf4f5-11fb-4cd1-a46b-780a0940dafe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("584874ed-e007-433a-94f4-3ccf1a3562a7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(875, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("31faf4f5-11fb-4cd1-a46b-780a0940dafe"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5195e8f-5c12-4b4d-a72e-c0f85a2f8b22"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("b7d5a1ce-72d5-44d3-8685-2020d9f4f677"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d1118f89-8ad0-4192-abd2-ecfa4c584367"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("053a5bc4-5b46-4102-bef0-a68b7648807f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateLogoEditChangeSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "LogoEditChangeSequenceFlow10",
				UId = new Guid("92945452-bb4e-4b5a-9b77-f4bc8cb7bbe8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dce6f969-b3c9-49bf-83c4-b37ab16d2128"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ad232927-371b-4f01-ab31-c528e3da8fb1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateExchangeMailServerEditPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaExchangeMailServerEditPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fbc466a6-a59d-4e67-be28-e9bef2c5760d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1015, 177),
				UseBackgroundMode = false
			};
			return schemaExchangeMailServerEditPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateExchangeMailServerEditPageButtonEventsLaneLane() {
			ProcessSchemaLane schemaExchangeMailServerEditPageButtonEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fbc466a6-a59d-4e67-be28-e9bef2c5760d"),
				CreatedInOwnerSchemaUId = new Guid("9f99adec-b1f7-4ed5-98e5-2373b7cd6b13"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageButtonEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(986, 177),
				UseBackgroundMode = false
			};
			return schemaExchangeMailServerEditPageButtonEventsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateExchangeMailServerEditPageOKButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaExchangeMailServerEditPageOKButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("59f16600-d7ba-4655-99fb-a343a3f8a3b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageOKButtonClickEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(312, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaExchangeMailServerEditPageOKButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateExchangeMailServerEditPageOKButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8c186a85-9dc6-488d-98bd-56902ffef1ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59f16600-d7ba-4655-99fb-a343a3f8a3b2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageOKButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateExchangeMailServerEditPageOKButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e08f9539-c10d-40db-950a-4939b517d562"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59f16600-d7ba-4655-99fb-a343a3f8a3b2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageOKButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,202,207,207,81,40,75,204,201,76,73,44,201,204,207,11,74,45,46,205,41,81,176,85,240,44,14,3,9,6,36,22,37,230,166,150,164,22,21,107,104,90,115,101,166,41,104,160,171,213,84,168,230,226,12,78,45,241,201,79,207,7,169,169,229,42,74,45,41,45,202,195,48,212,154,11,0,81,230,12,51,108,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("6f162699-1605-40c7-869e-afa5b1e8b418"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("59f16600-d7ba-4655-99fb-a343a3f8a3b2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageOKButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateExchangeMailServerEditPageIsAutodiscoverClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("88b6ee87-2617-4659-8e43-022357e690f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess",
				Position = new Point(343, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(283, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaExchangeMailServerEditPageIsAutodiscoverClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAutodiscoverCheckBoxCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d1118f89-8ad0-4192-abd2-ecfa4c584367"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88b6ee87-2617-4659-8e43-022357e690f6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AutodiscoverCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"AutodiscoverCheckBoxCheckStartMessage",
				Position = new Point(43, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsAutodiscoverCheckBoxChekcScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("053a5bc4-5b46-4102-bef0-a68b7648807f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88b6ee87-2617-4659-8e43-022357e690f6"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"IsAutodiscoverCheckBoxChekcScriptTask",
				Position = new Point(148, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,113,206,207,43,41,202,207,41,118,205,75,76,202,73,13,74,45,44,205,44,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,182,238,243,68,41,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLogoEditChangeEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaLogoEditChangeEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("780fbdc9-2046-44f6-99df-94e4e53aa9c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"LogoEditChangeEventSubProcess1",
				Position = new Point(28, 412),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(284, 187),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLogoEditChangeEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLogoEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dce6f969-b3c9-49bf-83c4-b37ab16d2128"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("780fbdc9-2046-44f6-99df-94e4e53aa9c7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LogoEditChange",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"LogoEditChangeStartMessage",
				Position = new Point(42, 90),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogoEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ad232927-371b-4f01-ab31-c528e3da8fb1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("780fbdc9-2046-44f6-99df-94e4e53aa9c7"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"LogoEditChangeScriptTask",
				Position = new Point(162, 76),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,140,177,10,194,64,16,68,123,193,127,184,50,105,14,11,73,19,108,34,166,10,18,136,63,112,224,114,46,232,46,236,77,2,250,245,185,192,117,193,110,152,121,243,122,126,211,61,124,200,93,220,24,34,249,65,163,222,158,12,223,151,161,61,30,182,56,241,111,99,42,22,212,123,240,170,2,18,248,129,36,226,149,47,255,145,81,19,131,85,178,236,84,220,101,202,77,78,11,25,252,67,187,144,168,57,79,48,150,88,237,109,221,23,148,234,252,55,194,108,226,96,51,181,43,60,100,173,20,204,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f1c79245-233a-49cb-ab27-41830d649650"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 194),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(295, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("22efded1-80a0-4c09-8794-735fe304824d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1c79245-233a-49cb-ab27-41830d649650"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0e1415cd-eb11-4a2f-be0b-184ae6371de6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1c79245-233a-49cb-ab27-41830d649650"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,247,118,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,115,78,44,45,78,45,14,75,204,201,76,73,44,201,204,207,83,176,85,40,41,42,77,181,230,229,10,192,175,49,56,35,191,220,39,63,49,197,55,177,56,155,36,77,254,5,137,133,165,169,168,218,138,82,75,74,139,242,32,60,0,211,2,78,25,177,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("dc9c1ece-2152-4b08-9c88-9c34789e3a83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1c79245-233a-49cb-ab27-41830d649650"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitMailServerEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitMailServerEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("35c4616f-16aa-4163-9809-0f6ac4e0eb69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"InitMailServerEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(343, 194),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(295, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitMailServerEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitMailServerStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("00a82906-03a6-4525-897c-a64bb1a7ec09"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35c4616f-16aa-4163-9809-0f6ac4e0eb69"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"InitMailServerStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitMailboxScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2bd2769e-86f3-4ae0-8381-f5b01adcdb75"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35c4616f-16aa-4163-9809-0f6ac4e0eb69"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"InitMailboxScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,203,193,10,130,64,24,69,225,117,130,239,240,227,74,73,197,114,20,66,90,104,86,180,139,140,246,147,222,164,176,153,24,103,148,136,222,61,119,113,56,203,239,200,91,132,37,215,188,146,70,213,8,11,220,164,66,197,7,156,228,72,243,181,109,81,131,14,45,215,112,229,245,129,90,83,15,209,64,249,244,87,219,1,66,231,170,237,9,30,125,108,107,134,112,210,97,5,189,145,157,121,138,11,239,12,92,231,252,126,225,208,56,62,9,140,180,55,247,198,117,98,182,138,138,146,37,1,219,177,50,96,233,34,14,242,60,74,3,150,76,165,187,56,102,203,220,241,188,204,182,190,211,10,218,40,65,90,25,100,63,128,0,76,148,185,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitMailboxIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("cb9abb6d-7d6d-49b6-9a08-aba774c03ae5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("35c4616f-16aa-4163-9809-0f6ac4e0eb69"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"InitMailboxIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteMailServerEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteMailServerEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c6b595fb-d1ab-41da-b4c1-9786cb6e2fdd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02b68efd-2b44-4c8f-8a4f-450529f46dd8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadCompleteMailServerEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(658, 194),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 163),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteMailServerEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("32d2ca36-a833-40fb-bc08-f927460a68cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6b595fb-d1ab-41da-b4c1-9786cb6e2fdd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d5195e8f-5c12-4b4d-a72e-c0f85a2f8b22"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6b595fb-d1ab-41da-b4c1-9786cb6e2fdd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"PageLoadCompleteChildScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,140,65,10,194,48,20,5,247,130,119,144,174,234,166,23,232,206,152,101,17,12,30,224,27,30,53,24,126,244,229,71,244,246,166,219,153,97,110,21,116,69,21,209,82,209,233,124,10,136,141,201,126,94,215,164,152,220,3,241,233,68,253,183,115,195,229,5,202,86,142,67,135,139,168,172,88,36,229,0,126,192,58,28,231,253,46,192,250,209,88,114,245,42,247,140,43,222,45,17,227,38,9,107,212,131,177,97,254,3,162,102,201,51,124,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateParentPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("31faf4f5-11fb-4cd1-a46b-780a0940dafe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6b595fb-d1ab-41da-b4c1-9786cb6e2fdd"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Name = @"ParentPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 65),
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
			Methods.Add(CreateIsValidParametersMethod());
			Methods.Add(CreateSetControlsEnableRequireMethod());
			Methods.Add(CreateGetMimeTypeMethod());
			Methods.Add(CreateSetLogoMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("63bd986f-ef11-4bb1-b595-4283e1ed6d8e"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("77b64d66-bd01-4de3-9199-f76ae82a9dd0"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d1a15483-23da-421d-ab8d-05b8d75930fa"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac")
			});
		}

		protected virtual SchemaMethod CreateIsValidParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f1431b5b-0402-463e-8af9-b90916d85da2"),
				Name = "IsValidParameters",
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,193,10,130,64,24,132,207,9,190,195,118,17,5,241,5,60,169,117,43,90,52,232,252,227,142,182,180,237,214,174,102,17,189,123,26,158,194,219,204,48,223,255,51,156,90,36,57,57,236,225,220,168,57,105,168,164,80,32,27,70,169,239,201,134,133,107,62,149,50,165,204,176,189,146,84,27,51,104,101,72,72,221,22,103,212,151,220,60,147,159,128,96,65,192,254,235,21,244,82,53,98,111,223,91,241,197,255,153,16,179,15,79,100,245,72,199,108,58,115,176,37,106,200,7,42,116,221,152,102,22,37,238,189,180,16,187,42,102,51,115,124,221,144,204,220,180,97,101,209,245,86,179,134,148,195,232,63,190,55,39,157,237,145,126,1,202,2,61,145,3,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlsEnableRequireMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c6a6b9bc-0fc0-45c6-96b3-88704d74d3ad"),
				Name = "SetControlsEnableRequire",
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,203,10,194,48,20,68,247,130,255,80,187,106,55,249,1,31,80,180,136,59,105,139,251,60,134,26,72,27,77,110,106,253,123,91,69,80,65,113,125,102,206,140,176,214,68,218,103,129,172,210,94,218,14,46,90,70,123,94,131,109,56,241,210,6,39,193,50,73,186,67,97,47,108,11,170,174,39,168,181,53,161,105,15,220,4,44,196,224,88,37,241,206,231,189,60,162,173,241,106,139,211,249,116,34,30,43,35,231,35,87,202,193,251,2,231,160,29,212,48,56,123,191,48,84,238,23,62,10,21,122,202,149,38,86,130,242,150,11,3,149,124,181,166,127,72,158,217,95,150,27,101,177,108,186,34,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetMimeTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c04f201a-8850-4c5b-bb91-48f228fd41b5"),
				Name = "GetMimeType",
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2c7b77cf-0b1b-42d2-9b1c-5029db074fc2"),
				Name = "stream",
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				ModifiedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Stream",
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,65,142,131,48,12,60,195,43,220,91,114,241,3,22,177,61,20,129,56,172,42,109,247,3,81,234,182,145,8,84,142,179,21,90,241,247,5,210,86,61,244,98,203,99,123,60,227,32,236,250,51,120,231,233,103,188,18,148,208,199,174,43,114,225,17,254,242,44,134,165,171,14,99,16,242,88,177,185,205,53,182,222,156,9,220,26,75,120,215,196,154,7,127,16,38,227,85,88,147,214,11,95,246,107,24,236,112,36,251,126,241,73,176,91,102,218,254,52,96,67,178,34,21,45,123,28,148,198,218,113,144,61,87,116,50,177,19,53,115,125,130,197,122,96,111,164,173,160,44,147,54,252,54,183,4,98,19,221,81,23,243,253,23,163,42,233,216,36,203,26,182,73,24,126,61,70,62,238,191,200,166,124,2,107,196,94,102,11,83,206,36,145,251,231,203,138,127,96,136,229,253,67,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetLogoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9ef61b84-bc15-49e1-91bf-64626a54b02d"),
				Name = "SetLogo",
				CreatedInSchemaUId = new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"),
				CreatedInPackageId = new Guid("e69d5962-a3fb-4b7c-a8c5-fab4027514ac"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,77,139,219,48,16,61,199,191,66,245,97,35,129,17,91,40,189,152,101,201,38,205,18,216,100,151,58,109,15,165,7,109,50,73,85,44,43,72,114,66,26,242,223,59,146,101,175,93,74,79,214,204,155,121,111,190,252,88,203,45,41,245,94,47,182,228,142,60,162,197,63,169,131,59,231,137,117,70,86,251,128,173,132,2,68,231,178,4,255,236,176,29,58,166,186,114,80,57,132,105,227,101,243,55,111,158,72,132,124,88,33,127,183,20,254,137,192,142,208,94,62,95,216,85,93,150,207,38,168,83,70,110,110,200,139,216,3,159,9,39,10,93,155,13,240,201,198,201,35,124,214,39,94,56,237,165,10,39,28,178,222,145,104,63,191,254,130,141,11,94,190,130,19,35,151,100,212,171,63,116,135,126,255,165,140,175,117,17,10,166,44,79,70,195,86,102,176,19,117,233,158,48,55,98,177,254,8,188,181,113,77,94,207,14,190,255,8,77,250,90,49,8,121,142,96,28,159,27,173,30,132,133,143,31,162,80,95,228,254,158,52,243,106,230,205,136,176,164,161,202,147,163,48,68,129,210,230,140,137,32,20,114,86,112,34,203,158,203,23,221,15,225,223,140,116,64,219,42,50,114,155,117,115,103,221,194,148,84,176,62,31,194,48,192,45,163,69,251,68,172,89,205,187,88,220,112,45,109,126,88,79,107,112,223,146,144,149,165,169,84,184,178,148,133,193,175,193,24,97,245,206,33,110,128,47,60,52,121,89,116,15,18,130,39,7,25,187,251,119,20,253,98,193,160,64,133,139,149,186,242,171,234,174,181,37,224,133,56,14,155,200,186,226,178,238,128,153,95,150,111,173,201,247,157,105,23,175,45,20,252,159,115,3,55,213,101,173,170,7,237,126,126,21,101,13,216,235,83,160,73,179,248,247,100,36,120,188,82,58,16,29,197,217,219,141,145,7,127,92,113,178,115,109,148,112,52,189,220,94,185,109,5,2,57,29,55,220,227,140,140,47,239,175,99,150,35,227,223,213,77,75,137,103,180,152,181,250,94,41,196,20,65,103,41,42,52,12,159,108,183,141,131,54,250,97,10,131,195,153,150,218,2,158,211,31,179,252,4,118,10,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExchangeMailServerEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f7def0a-973a-4ce7-8e11-dad6ba26dd16"));
		}

		#endregion

	}

	#endregion

}

