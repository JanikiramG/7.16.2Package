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
	using System.Security;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: UserEditPageSchema

	/// <exclude/>
	public class UserEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _employeeEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EmployeeEdit {
			get {
				return _employeeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _sysCultureEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SysCultureEdit {
			get {
				return _sysCultureEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _homePageEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit HomePageEdit {
			get {
				return _homePageEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _bPMonlineRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton BPMonlineRadioButton {
			get {
				return _bPMonlineRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bPMonlineControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BPMonlineControlLayout {
			get {
				return _bPMonlineControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _nameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return _nameEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _userPasswordEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit UserPasswordEdit {
			get {
				return _userPasswordEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.DateTimeEdit _passwordExpireDateEdit;
		public Terrasoft.UI.WebControls.Controls.DateTimeEdit PasswordExpireDateEdit {
			get {
				return _passwordExpireDateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _lDAPControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LDAPControlLayout {
			get {
				return _lDAPControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _synchronizeWithLDAPCheckBox;
		public Terrasoft.UI.WebControls.Controls.RadioButton SynchronizeWithLDAPCheckBox {
			get {
				return _synchronizeWithLDAPCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _lDAPEntryEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit LDAPEntryEdit {
			get {
				return _lDAPEntryEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _lDAPEntryButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton LDAPEntryButton {
			get {
				return _lDAPEntryButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _activeCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox ActiveCheckBox {
			get {
				return _activeCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _forceChangePasswordCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox ForceChangePasswordCheckBox {
			get {
				return _forceChangePasswordCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _licenseControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout LicenseControlLayout {
			get {
				return _licenseControlLayout;
			}
		}

		#endregion

		#region Constructors: Public

		public UserEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public UserEditPageSchema(UserEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			RealUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			Name = "UserEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 400;
			HelpContextId = "267";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUserEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(0, CreateEmployeeEdit());
			MainControlLayout.InsertItem(1, CreateSysCultureEdit());
			MainControlLayout.InsertItem(2, CreateHomePageEdit());
			MainControlLayout.InsertItem(3, CreateBPMonlineRadioButton());
			MainControlLayout.InsertItem(4, CreateBPMonlineControlLayout());
			BPMonlineControlLayout.InsertItem(0, CreateNameEdit());
			BPMonlineControlLayout.InsertItem(1, CreateUserPasswordEdit());
			BPMonlineControlLayout.InsertItem(2, CreatePasswordExpireDateEdit());
			MainControlLayout.InsertItem(5, CreateLDAPControlLayout());
			LDAPControlLayout.InsertItem(0, CreateSynchronizeWithLDAPCheckBox());
			LDAPControlLayout.InsertItem(1, CreateLDAPEntryEdit());
			LDAPEntryEdit.InsertItem(0, CreateLDAPEntryButton());
			MainControlLayout.InsertItem(6, CreateActiveCheckBox());
			MainControlLayout.InsertItem(7, CreateForceChangePasswordCheckBox());
			MainControlLayout.InsertItem(8, CreateLicenseControlLayout());
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

		protected virtual EmbeddedProcessSchema CreateUserEditPageEventsProcessSchema() {
			var schema = new UserEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEmployeeEdit() {
			_employeeEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_employeeEdit.UId = new Guid("8e43aedb-4277-4e3d-bbe8-2ed857a868fd");
			_employeeEdit.Name = "EmployeeEdit";
			_employeeEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_employeeEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_employeeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_employeeEdit.Tag = "";
			_employeeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_employeeEdit.Image = new ControlImage {};
			_employeeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_employeeEdit.DataSource = "DataSource";
			_employeeEdit.ColumnUId = new Guid("8575a293-ac88-4de6-8c54-c1d6bcc373d7");
			_employeeEdit.Required = true;
			_employeeEdit.LookupSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			return _employeeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateSysCultureEdit() {
			_sysCultureEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_sysCultureEdit.UId = new Guid("279f206a-73b8-4383-9bbb-8d41b0dc09ad");
			_sysCultureEdit.Name = "SysCultureEdit";
			_sysCultureEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_sysCultureEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_sysCultureEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysCultureEdit.Tag = "";
			_sysCultureEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysCultureEdit.Image = new ControlImage {};
			_sysCultureEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysCultureEdit.DataSource = "DataSource";
			_sysCultureEdit.ColumnUId = new Guid("06616ef1-af0f-4d60-8094-93b4c3d21790");
			_sysCultureEdit.Required = true;
			return _sysCultureEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateHomePageEdit() {
			_homePageEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_homePageEdit.UId = new Guid("ecb4dfa8-bae6-4f8e-864d-787dd1eb93cd");
			_homePageEdit.Name = "HomePageEdit";
			_homePageEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_homePageEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_homePageEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_homePageEdit.Tag = "";
			_homePageEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_homePageEdit.Image = new ControlImage {};
			_homePageEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_homePageEdit.DataSource = "DataSource";
			_homePageEdit.ColumnUId = new Guid("7314a50f-52c9-4237-8049-dbdfa3fb0de9");
			return _homePageEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateBPMonlineRadioButton() {
			_bPMonlineRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_bPMonlineRadioButton.UId = new Guid("d83cdd74-d89c-48fb-a61a-92f5fcdd73c8");
			_bPMonlineRadioButton.Name = "BPMonlineRadioButton";
			_bPMonlineRadioButton.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_bPMonlineRadioButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_bPMonlineRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bPMonlineRadioButton.Tag = "";
			_bPMonlineRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_bPMonlineRadioButton.AlignedByCaption = false;
			_bPMonlineRadioButton.GroupName = "1";
			return _bPMonlineRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateNameEdit() {
			_nameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_nameEdit.UId = new Guid("bdd1f60b-6d55-48ce-a184-ef5301e53c32");
			_nameEdit.Name = "NameEdit";
			_nameEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_nameEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_nameEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_nameEdit.Tag = "";
			_nameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_nameEdit.Image = new ControlImage {};
			_nameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_nameEdit.DataSource = "DataSource";
			_nameEdit.ColumnUId = new Guid("1001c3fc-98b5-44a8-a987-256c3b55740d");
			return _nameEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserPasswordEdit() {
			_userPasswordEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userPasswordEdit.UId = new Guid("b2b536ae-eb43-4b5c-9a6d-0bedddfec207");
			_userPasswordEdit.Name = "UserPasswordEdit";
			_userPasswordEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_userPasswordEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_userPasswordEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userPasswordEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_userPasswordEdit.Tag = "";
			_userPasswordEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userPasswordEdit.Image = new ControlImage {};
			_userPasswordEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_userPasswordEdit.DataSource = "DataSource";
			_userPasswordEdit.ColumnUId = new Guid("7e5caf9b-f3a2-4c04-966c-4f43c507d4e4");
			_userPasswordEdit.Required = true;
			_userPasswordEdit.IsSecureValue = true;
			return _userPasswordEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.DateTimeEdit CreatePasswordExpireDateEdit() {
			_passwordExpireDateEdit = new Terrasoft.UI.WebControls.Controls.DateTimeEdit();
			_passwordExpireDateEdit.UId = new Guid("9fc6449e-e2fd-45af-9dad-f033c8913997");
			_passwordExpireDateEdit.Name = "PasswordExpireDateEdit";
			_passwordExpireDateEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_passwordExpireDateEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_passwordExpireDateEdit.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			_passwordExpireDateEdit.Tag = "";
			_passwordExpireDateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_passwordExpireDateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_passwordExpireDateEdit.DataSource = "DataSource";
			_passwordExpireDateEdit.ColumnUId = new Guid("4540f661-ee94-44e7-85db-aa44563b8a25");
			return _passwordExpireDateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBPMonlineControlLayout() {
			_bPMonlineControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bPMonlineControlLayout.UId = new Guid("20122653-769b-4cd1-8945-25fe368b8827");
			_bPMonlineControlLayout.Name = "BPMonlineControlLayout";
			_bPMonlineControlLayout.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_bPMonlineControlLayout.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_bPMonlineControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bPMonlineControlLayout.Tag = "";
			_bPMonlineControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_bPMonlineControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_bPMonlineControlLayout.FitHeightByContent = true;
			_bPMonlineControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bPMonlineControlLayout.Padding = "0 0 0 17";
			_bPMonlineControlLayout.StartNewAlignGroup = false;
			_bPMonlineControlLayout.Image = new ControlImage {};
			_bPMonlineControlLayout.Edges = "";
			return _bPMonlineControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateSynchronizeWithLDAPCheckBox() {
			_synchronizeWithLDAPCheckBox = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_synchronizeWithLDAPCheckBox.UId = new Guid("e81e26e6-3d24-49a1-b9f4-929b5db2b64c");
			_synchronizeWithLDAPCheckBox.Name = "SynchronizeWithLDAPCheckBox";
			_synchronizeWithLDAPCheckBox.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_synchronizeWithLDAPCheckBox.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_synchronizeWithLDAPCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_synchronizeWithLDAPCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_synchronizeWithLDAPCheckBox.Tag = "";
			_synchronizeWithLDAPCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_synchronizeWithLDAPCheckBox.AlignedByCaption = false;
			_synchronizeWithLDAPCheckBox.DataSource = "DataSource";
			_synchronizeWithLDAPCheckBox.ColumnUId = new Guid("c7daf049-6ada-457d-b018-f32cc918a9f7");
			_synchronizeWithLDAPCheckBox.GroupName = "1";
			return _synchronizeWithLDAPCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateLDAPEntryButton() {
			_lDAPEntryButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_lDAPEntryButton.UId = new Guid("46eab5ec-90fa-4da1-9592-8b4d090ff57f");
			_lDAPEntryButton.Name = "LDAPEntryButton";
			_lDAPEntryButton.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_lDAPEntryButton.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_lDAPEntryButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lDAPEntryButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_lDAPEntryButton.Tag = "";
			_lDAPEntryButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21"),
				ImageHash = @"54ac1a2d1db28aa44e6b7837c54cc5e6"
			};
			_lDAPEntryButton.Enabled = false;
			return _lDAPEntryButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateLDAPEntryEdit() {
			_lDAPEntryEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_lDAPEntryEdit.UId = new Guid("973482ee-7481-47ad-8d82-75694464277d");
			_lDAPEntryEdit.Name = "LDAPEntryEdit";
			_lDAPEntryEdit.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_lDAPEntryEdit.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_lDAPEntryEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lDAPEntryEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_lDAPEntryEdit.Tag = "";
			_lDAPEntryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lDAPEntryEdit.Image = new ControlImage {};
			_lDAPEntryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lDAPEntryEdit.Margins = "0 0 0 17";
			_lDAPEntryEdit.DataSource = "DataSource";
			_lDAPEntryEdit.ColumnUId = new Guid("b9206b32-8dbb-447c-bc12-d677954754e2");
			_lDAPEntryEdit.Enabled = false;
			return _lDAPEntryEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLDAPControlLayout() {
			_lDAPControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_lDAPControlLayout.UId = new Guid("39a7e82d-35e4-4ece-8416-3fac0376b69f");
			_lDAPControlLayout.Name = "LDAPControlLayout";
			_lDAPControlLayout.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_lDAPControlLayout.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_lDAPControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lDAPControlLayout.Tag = "";
			_lDAPControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_lDAPControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_lDAPControlLayout.FitHeightByContent = true;
			_lDAPControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lDAPControlLayout.StartNewAlignGroup = false;
			_lDAPControlLayout.Image = new ControlImage {};
			_lDAPControlLayout.Edges = "";
			return _lDAPControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateActiveCheckBox() {
			_activeCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_activeCheckBox.UId = new Guid("cc9af26e-e021-408a-833b-a1753a992497");
			_activeCheckBox.Name = "ActiveCheckBox";
			_activeCheckBox.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_activeCheckBox.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_activeCheckBox.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_activeCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_activeCheckBox.Tag = "";
			_activeCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_activeCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_activeCheckBox.AlignedByCaption = false;
			_activeCheckBox.DataSource = "DataSource";
			_activeCheckBox.ColumnUId = new Guid("bf163eeb-6842-4af8-b935-d823d1f3d0fe");
			return _activeCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateForceChangePasswordCheckBox() {
			_forceChangePasswordCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_forceChangePasswordCheckBox.UId = new Guid("92ae800c-dcd0-4ce7-ab9d-e14e830a78f8");
			_forceChangePasswordCheckBox.Name = "ForceChangePasswordCheckBox";
			_forceChangePasswordCheckBox.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_forceChangePasswordCheckBox.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_forceChangePasswordCheckBox.CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb");
			_forceChangePasswordCheckBox.Tag = "";
			_forceChangePasswordCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_forceChangePasswordCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_forceChangePasswordCheckBox.AlignedByCaption = false;
			_forceChangePasswordCheckBox.DataSource = "DataSource";
			_forceChangePasswordCheckBox.ColumnUId = new Guid("d9996a71-ca33-4e76-a686-8719660906ef");
			return _forceChangePasswordCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateLicenseControlLayout() {
			_licenseControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_licenseControlLayout.UId = new Guid("25bbbd9c-51e0-42de-a3c5-12293306ca4c");
			_licenseControlLayout.Name = "LicenseControlLayout";
			_licenseControlLayout.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_licenseControlLayout.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			_licenseControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_licenseControlLayout.Tag = "";
			_licenseControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_licenseControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_licenseControlLayout.FitHeightByContent = true;
			_licenseControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_licenseControlLayout.StartNewAlignGroup = false;
			_licenseControlLayout.Image = new ControlImage {};
			_licenseControlLayout.Edges = "";
			return _licenseControlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			DataSource.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("76bd123d-6164-4483-901e-58d79bc55c7e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("785f4da6-b6c1-403a-9dd1-295357eab44e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("5758c278-61eb-4d43-8ebf-97baca77ee88");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c4ce8289-3d70-4d56-a06f-74e80cc10c35");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("fdfcecf1-9e34-49cc-8223-48306ccd90d3");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("1001c3fc-98b5-44a8-a987-256c3b55740d");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("e1af0f00-a8c9-4034-a1d6-1f64d8791adf");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("25815aa6-f450-42dc-8637-1374ea00ccb5");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.UId = new Guid("263168b2-8dcd-4aa4-a9a5-31bd432e2237");
				column.Name = @"ParentRole";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("45d5d808-1ad8-42bf-aaf2-177dcd2079c7");
			if (column != null) {
				column.UId = new Guid("210d3a73-5944-450a-ab9e-58326970fa1a");
				column.Name = @"Account";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("72a7351e-36cf-40f9-b334-0a7563bd60fb");
			if (column != null) {
				column.UId = new Guid("c871934a-bdf7-4fb0-9981-bc17ca9adfea");
				column.Name = @"IsDirectoryEntry";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8280981b-5189-40a1-b700-6a35c572dba2");
			if (column != null) {
				column.UId = new Guid("62520dee-8049-427c-88f2-23374bbbf2bd");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.UId = new Guid("7e5caf9b-f3a2-4c04-966c-4f43c507d4e4");
				column.Name = @"UserPassword";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a986b074-459c-40b1-b4b6-0e286b3ef123");
			if (column != null) {
				column.UId = new Guid("bf163eeb-6842-4af8-b935-d823d1f3d0fe");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("328f73e7-ebde-432f-9052-a0365b3105e8");
			if (column != null) {
				column.UId = new Guid("8575a293-ac88-4de6-8c54-c1d6bcc373d7");
				column.Name = @"Contact";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("a3c751b9-544a-420b-8df0-dc3a0e3bc147");
			if (column != null) {
				column.UId = new Guid("d9996a71-ca33-4e76-a686-8719660906ef");
				column.Name = @"ForceChangePassword";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("184336ef-e07a-4f5a-9850-8d4ccaff520f");
			if (column != null) {
				column.UId = new Guid("c7daf049-6ada-457d-b018-f32cc918a9f7");
				column.Name = @"SynchronizeWithLDAP";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2e25fe29-ea38-4db2-84d5-03a8db9b2491");
			if (column != null) {
				column.UId = new Guid("b9206b32-8dbb-447c-bc12-d677954754e2");
				column.Name = @"LDAPEntry";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c2748d54-0f48-4251-bfc0-ff6e2478348d");
			if (column != null) {
				column.UId = new Guid("bcd1f899-a717-40b5-a531-dfc1f531ee47");
				column.Name = @"LDAPEntryId";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("bee2b6ad-4e6f-4c00-a052-a60e1cdf5686");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9eb0071c-72bd-48e1-b9e7-36c81e6aa232");
			if (column != null) {
				column.UId = new Guid("06616ef1-af0f-4d60-8094-93b4c3d21790");
				column.Name = @"SysCulture";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("088ae956-eb2f-4df7-ad9c-1fb9a6596a9f");
			if (column != null) {
				column.UId = new Guid("4540f661-ee94-44e7-85db-aa44563b8a25");
				column.Name = @"PasswordExpireDate";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5f009f32-31e0-41c2-9506-a9aa73ed64ae");
			if (column != null) {
				column.UId = new Guid("7314a50f-52c9-4237-8049-dbdfa3fb0de9");
				column.Name = @"HomePage";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c6d4b209-8259-4eb2-8a4f-bcc6e448a6e4");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("b763a686-c02a-4948-868f-92f32c775fa4");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("a54f32f8-fb7e-4b83-8df7-b8ce4f7197b5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("9c123d33-4369-408c-9a2e-cc49bc7347ce");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("b81a0893-6613-410b-b7ae-65dada5b806e");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("808125cd-a265-4b16-b89b-789922e43aaf");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("70140cff-4db1-4c0d-b9d6-ffb023f9c0ad");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("3b1b6e4c-aa09-413c-9ded-a6ad81bb93c1");
			if (column != null) {
				column.UId = new Guid("5894cb42-66e9-4cb1-b6a8-af3ad94d9a27");
				column.Name = @"SysAdminUnitType";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("3678b2d1-343e-4e0c-8a93-f082143be510");
			if (column != null) {
				column.UId = new Guid("77c3661e-6285-4de1-8d7e-807f2284fa6a");
				column.Name = @"ParentRole";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("45d5d808-1ad8-42bf-aaf2-177dcd2079c7");
			if (column != null) {
				column.UId = new Guid("5a7926a1-fc6e-4466-98c3-a95680120698");
				column.Name = @"Account";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("72a7351e-36cf-40f9-b334-0a7563bd60fb");
			if (column != null) {
				column.UId = new Guid("65b11afd-8aff-4912-908f-2755638d5d28");
				column.Name = @"IsDirectoryEntry";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("8280981b-5189-40a1-b700-6a35c572dba2");
			if (column != null) {
				column.UId = new Guid("00e8d1ca-d1f9-449b-a7ca-7f73ffbcbf00");
				column.Name = @"TimeZone";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("a07a30ff-b3df-45db-a83c-bf89027250d8");
			if (column != null) {
				column.UId = new Guid("24663b3f-cd37-446e-ae46-fb08b6a2adc8");
				column.Name = @"UserPassword";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddQuickViewColumnByMetaPath("a986b074-459c-40b1-b4b6-0e286b3ef123");
			if (column != null) {
				column.UId = new Guid("7e9152b7-c2ef-47e8-847b-8f380dbe8935");
				column.Name = @"Active";
				column.CreatedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
				column.ModifiedInSchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
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
			return new UserEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new UserEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new UserEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: UserEditPageEventsProcess

	/// <exclude/>
	public class UserEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.UserEditPageSchemaUserControl
	{

		#region Class: ShowMessageAboutErrorPasswordTaskFlowElement

		/// <exclude/>
		public class ShowMessageAboutErrorPasswordTaskFlowElement : QuestionUserTask
		{

			public ShowMessageAboutErrorPasswordTaskFlowElement(UserConnection userConnection, UserEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMessageAboutErrorPasswordTask";
				IsLogging = false;
				SchemaElementUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowMessageAboutErrorUpdateLicenseTaskFlowElement

		/// <exclude/>
		public class ShowMessageAboutErrorUpdateLicenseTaskFlowElement : QuestionUserTask
		{

			public ShowMessageAboutErrorUpdateLicenseTaskFlowElement(UserConnection userConnection, UserEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMessageAboutErrorUpdateLicenseTask";
				IsLogging = false;
				SchemaElementUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: LDAPEntryButtonClickUserTaskFlowElement

		/// <exclude/>
		public class LDAPEntryButtonClickUserTaskFlowElement : OpenPageUserTask
		{

			public LDAPEntryButtonClickUserTaskFlowElement(UserConnection userConnection, UserEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LDAPEntryButtonClickUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ShowErrorMessageTaskFlowElement

		/// <exclude/>
		public class ShowErrorMessageTaskFlowElement : QuestionUserTask
		{

			public ShowErrorMessageTaskFlowElement(UserConnection userConnection, UserEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowErrorMessageTask";
				IsLogging = false;
				SchemaElementUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public UserEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UserEditPageEventsProcess";
			SchemaUId = new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7f781a64-2b32-48c3-98ac-bb3d45eecb21");
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

		public virtual bool areConditionsCorrect {
			get;
			set;
		}

		public virtual bool LdapEntryChanged {
			get;
			set;
		}

		public virtual Object SysPackageIds {
			get;
			set;
		}

		public virtual Object SysPackageNames {
			get;
			set;
		}

		public virtual Object SysPackageAvailables {
			get;
			set;
		}

		public virtual bool CanManageLicUsers {
			get;
			set;
		}

		public virtual int PasswordDuration {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual bool IsPasswordChange {
			get;
			set;
		}

		public virtual string PasswordErrorMessage {
			get;
			set;
		}

		public virtual bool ShowMessageAboutErrorPassword {
			get;
			set;
		}

		public virtual string UpdateLicenseErrorMessage {
			get;
			set;
		}

		public virtual bool IsShowMessageAboutErrorUpdateLicense {
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
					SchemaElementUId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _userPasswordEditChange_StartMessage;
		public ProcessFlowElement UserPasswordEditChange_StartMessage {
			get {
				return _userPasswordEditChange_StartMessage ?? (_userPasswordEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UserPasswordEditChange_StartMessage",
					SchemaElementUId = new Guid("4631c771-d2df-46c6-9606-71a494cd550d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changePasswordExpiryDateScriptTask;
		public ProcessScriptTask ChangePasswordExpiryDateScriptTask {
			get {
				return _changePasswordExpiryDateScriptTask ?? (_changePasswordExpiryDateScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangePasswordExpiryDateScriptTask",
					SchemaElementUId = new Guid("52590e01-3d9c-416a-92d4-90e06aef8649"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangePasswordExpiryDateScriptTaskExecute,
				});
			}
		}

		private ShowMessageAboutErrorPasswordTaskFlowElement _showMessageAboutErrorPasswordTask;
		public ShowMessageAboutErrorPasswordTaskFlowElement ShowMessageAboutErrorPasswordTask {
			get {
				return _showMessageAboutErrorPasswordTask ?? (_showMessageAboutErrorPasswordTask = new ShowMessageAboutErrorPasswordTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("566a54df-5a1d-4a51-8b84-09eb805e9359"),
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
					SchemaElementUId = new Guid("9c2e4ae7-2bd0-403a-b5ee-c123a6807b77"),
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

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("f5d06a03-ac3b-4e5b-ba04-f3c891d9068e"),
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
					SchemaElementUId = new Guid("1640dcd3-4dc5-455c-94e1-addb7a4193d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activeCheckBoxCheckScriptTask;
		public ProcessScriptTask ActiveCheckBoxCheckScriptTask {
			get {
				return _activeCheckBoxCheckScriptTask ?? (_activeCheckBoxCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActiveCheckBoxCheckScriptTask",
					SchemaElementUId = new Guid("5084ebf5-a06b-46b8-94e2-92bb2c2d8bb0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActiveCheckBoxCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
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
					SchemaElementUId = new Guid("d3b6560a-2289-48ca-b52b-6a38da5268c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _childDataSourceSavedScriptTask;
		public ProcessScriptTask ChildDataSourceSavedScriptTask {
			get {
				return _childDataSourceSavedScriptTask ?? (_childDataSourceSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildDataSourceSavedScriptTask",
					SchemaElementUId = new Guid("8e2b6dd5-0744-4225-a88d-d21965892058"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildDataSourceSavedScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _dataSourceSavedIntermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent DataSourceSavedIntermediateThrowMessageEvent2 {
			get {
				return _dataSourceSavedIntermediateThrowMessageEvent2 ?? (_dataSourceSavedIntermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DataSourceSavedIntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("82dc1377-cc25-46aa-8f56-4c708d435d10"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _setCurrentUserPasswordExpiredDate_ScriptTask;
		public ProcessScriptTask SetCurrentUserPasswordExpiredDate_ScriptTask {
			get {
				return _setCurrentUserPasswordExpiredDate_ScriptTask ?? (_setCurrentUserPasswordExpiredDate_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetCurrentUserPasswordExpiredDate_ScriptTask",
					SchemaElementUId = new Guid("0adc952e-ca4f-4349-a4db-65f8e08a74b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetCurrentUserPasswordExpiredDate_ScriptTaskExecute,
				});
			}
		}

		private ShowMessageAboutErrorUpdateLicenseTaskFlowElement _showMessageAboutErrorUpdateLicenseTask;
		public ShowMessageAboutErrorUpdateLicenseTaskFlowElement ShowMessageAboutErrorUpdateLicenseTask {
			get {
				return _showMessageAboutErrorUpdateLicenseTask ?? (_showMessageAboutErrorUpdateLicenseTask = new ShowMessageAboutErrorUpdateLicenseTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4;
		public ProcessExclusiveGateway ExclusiveGateway4 {
			get {
				return _exclusiveGateway4 ?? (_exclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4",
					SchemaElementUId = new Guid("d7dd4707-6146-43d6-b35a-bc5ee5d5a311"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _lDAPEntryButtonClickEventSubProcess;
		public ProcessFlowElement LDAPEntryButtonClickEventSubProcess {
			get {
				return _lDAPEntryButtonClickEventSubProcess ?? (_lDAPEntryButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "LDAPEntryButtonClickEventSubProcess",
					SchemaElementUId = new Guid("c6efe590-c038-4ad0-8b35-bddf630cc2a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lDAPEntryButtonClick;
		public ProcessFlowElement LDAPEntryButtonClick {
			get {
				return _lDAPEntryButtonClick ?? (_lDAPEntryButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LDAPEntryButtonClick",
					SchemaElementUId = new Guid("21714f1e-99db-45ea-adf1-aa5891992677"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLDAPEntryButtonClick;
		public ProcessScriptTask ScriptLDAPEntryButtonClick {
			get {
				return _scriptLDAPEntryButtonClick ?? (_scriptLDAPEntryButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLDAPEntryButtonClick",
					SchemaElementUId = new Guid("56589da2-3258-4a20-bd68-80bcdd81ef00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLDAPEntryButtonClickExecute,
				});
			}
		}

		private LDAPEntryButtonClickUserTaskFlowElement _lDAPEntryButtonClickUserTask;
		public LDAPEntryButtonClickUserTaskFlowElement LDAPEntryButtonClickUserTask {
			get {
				return _lDAPEntryButtonClickUserTask ?? (_lDAPEntryButtonClickUserTask = new LDAPEntryButtonClickUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("3d504a60-b47e-4fd4-b467-276c91c7a665"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lDAPUsersGridPageClose;
		public ProcessFlowElement LDAPUsersGridPageClose {
			get {
				return _lDAPUsersGridPageClose ?? (_lDAPUsersGridPageClose = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LDAPUsersGridPageClose",
					SchemaElementUId = new Guid("db2406d9-7cd3-4c5f-aa6d-79814442a92a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLDAPUsersGridPageClose;
		public ProcessScriptTask ScriptLDAPUsersGridPageClose {
			get {
				return _scriptLDAPUsersGridPageClose ?? (_scriptLDAPUsersGridPageClose = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLDAPUsersGridPageClose",
					SchemaElementUId = new Guid("9fd8b58e-b039-4b77-bdf0-a3a30a85bd27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLDAPUsersGridPageCloseExecute,
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
					SchemaElementUId = new Guid("626a318a-eede-46a3-952c-622b97c75796"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lDAPEntryEditChange;
		public ProcessFlowElement LDAPEntryEditChange {
			get {
				return _lDAPEntryEditChange ?? (_lDAPEntryEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LDAPEntryEditChange",
					SchemaElementUId = new Guid("ec9f0a8f-bdbc-4a1c-968a-af98e9b51788"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLDAPEntryEditChange;
		public ProcessScriptTask ScriptLDAPEntryEditChange {
			get {
				return _scriptLDAPEntryEditChange ?? (_scriptLDAPEntryEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLDAPEntryEditChange",
					SchemaElementUId = new Guid("4b40ff71-82df-47fe-843a-d3bfc86bf9a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLDAPEntryEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessSynchronizeWithLDAPCheckBoxCheck;
		public ProcessFlowElement EventSubProcessSynchronizeWithLDAPCheckBoxCheck {
			get {
				return _eventSubProcessSynchronizeWithLDAPCheckBoxCheck ?? (_eventSubProcessSynchronizeWithLDAPCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessSynchronizeWithLDAPCheckBoxCheck",
					SchemaElementUId = new Guid("ff731d48-92ee-41b2-846d-20bedeff5c62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _synchronizeWithLDAPCheckBoxCheck;
		public ProcessFlowElement SynchronizeWithLDAPCheckBoxCheck {
			get {
				return _synchronizeWithLDAPCheckBoxCheck ?? (_synchronizeWithLDAPCheckBoxCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SynchronizeWithLDAPCheckBoxCheck",
					SchemaElementUId = new Guid("9b0e68c3-ebb7-48ef-a21a-4e9489061e44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSynchronizeWithLDAPCheckBoxCheck;
		public ProcessScriptTask ScriptSynchronizeWithLDAPCheckBoxCheck {
			get {
				return _scriptSynchronizeWithLDAPCheckBoxCheck ?? (_scriptSynchronizeWithLDAPCheckBoxCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSynchronizeWithLDAPCheckBoxCheck",
					SchemaElementUId = new Guid("2e53746c-126d-42a4-a93a-e2455ce11432"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSynchronizeWithLDAPCheckBoxCheckExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChildEventSubProcess;
		public ProcessFlowElement PageLoadCompleteChildEventSubProcess {
			get {
				return _pageLoadCompleteChildEventSubProcess ?? (_pageLoadCompleteChildEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteChildEventSubProcess",
					SchemaElementUId = new Guid("6b3b8dab-cb6c-4010-b63f-6a16a3467516"),
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
					SchemaElementUId = new Guid("60f73c99-5599-453e-9bb3-50dc8ee9f0cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteParent;
		public ProcessThrowMessageEvent PageLoadCompleteParent {
			get {
				return _pageLoadCompleteParent ?? (_pageLoadCompleteParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteParent",
					SchemaElementUId = new Guid("347fb6a8-68d8-4d73-9beb-878ced11f472"),
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
					SchemaElementUId = new Guid("e91a01e8-712b-45a3-9071-77af5cd62bbb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChildExecute,
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
					SchemaElementUId = new Guid("f39535e4-c6b2-4ac3-846d-d8f735862936"),
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
					SchemaElementUId = new Guid("3a57fdf9-0687-46e9-87e4-1d26295ecdf3"),
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
					SchemaElementUId = new Guid("d221b095-1cc6-4ee3-9ff6-56e5e4199960"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _child_InitScriptTask;
		public ProcessScriptTask Child_InitScriptTask {
			get {
				return _child_InitScriptTask ?? (_child_InitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_InitScriptTask",
					SchemaElementUId = new Guid("2458abe9-9601-4c91-bb8f-99637e33dacd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickChild;
		public ProcessFlowElement OKButtonClickChild {
			get {
				return _oKButtonClickChild ?? (_oKButtonClickChild = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickChild",
					SchemaElementUId = new Guid("9b1b560d-7996-4251-8860-f54e1a06897d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _throwScriptOKButtonClickChild;
		public ProcessThrowMessageEvent ThrowScriptOKButtonClickChild {
			get {
				return _throwScriptOKButtonClickChild ?? (_throwScriptOKButtonClickChild = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowScriptOKButtonClickChild",
					SchemaElementUId = new Guid("2f978323-af86-4ec4-bf5c-6e02320c71f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptOKButtonClickChild2;
		public ProcessScriptTask ScriptOKButtonClickChild2 {
			get {
				return _scriptOKButtonClickChild2 ?? (_scriptOKButtonClickChild2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOKButtonClickChild2",
					SchemaElementUId = new Guid("6a27d7dd-56ac-4371-b170-d3032277e5ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOKButtonClickChild2Execute,
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
					SchemaElementUId = new Guid("b3b8bc85-776d-4164-9c44-96744c3d7775"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("d5e1def9-c039-49e7-9bc8-8e750b936254"),
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

		private ShowErrorMessageTaskFlowElement _showErrorMessageTask;
		public ShowErrorMessageTaskFlowElement ShowErrorMessageTask {
			get {
				return _showErrorMessageTask ?? (_showErrorMessageTask = new ShowErrorMessageTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway5;
		public ProcessExclusiveGateway ExclusiveGateway5 {
			get {
				return _exclusiveGateway5 ?? (_exclusiveGateway5 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway5",
					SchemaElementUId = new Guid("f2b91918-ade7-478b-9ab7-db5ec92e5140"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway5.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("b9b2ba5f-d4a3-454c-bbc1-1b8ec5d1a9eb"),
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
					SchemaElementUId = new Guid("87074824-120d-431c-8ef4-c284c9ff6ef8"),
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
					SchemaElementUId = new Guid("7e53b6f4-4132-44d0-b162-0e31d01b7c24"),
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
					SchemaElementUId = new Guid("dc2f3da0-43f3-44c3-a7ab-a4a5e108b284"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _nameNotUniqueMessage;
		public LocalizableString NameNotUniqueMessage {
			get {
				return _nameNotUniqueMessage ?? (_nameNotUniqueMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NameNotUniqueMessage.Value"));
			}
		}

		private LocalizableString _attentionCaption;
		public LocalizableString AttentionCaption {
			get {
				return _attentionCaption ?? (_attentionCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AttentionCaption.Value"));
			}
		}

		private LocalizableString _windowCaption;
		public LocalizableString WindowCaption {
			get {
				return _windowCaption ?? (_windowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WindowCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[UserPasswordEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { UserPasswordEditChange_StartMessage };
			FlowElements[ChangePasswordExpiryDateScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangePasswordExpiryDateScriptTask };
			FlowElements[ShowMessageAboutErrorPasswordTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageAboutErrorPasswordTask };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ActiveCheckBoxCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActiveCheckBoxCheckScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ChildDataSourceSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildDataSourceSavedScriptTask };
			FlowElements[DataSourceSavedIntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSavedIntermediateThrowMessageEvent2 };
			FlowElements[SetCurrentUserPasswordExpiredDate_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetCurrentUserPasswordExpiredDate_ScriptTask };
			FlowElements[ShowMessageAboutErrorUpdateLicenseTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageAboutErrorUpdateLicenseTask };
			FlowElements[ExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4 };
			FlowElements[LDAPEntryButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryButtonClickEventSubProcess };
			FlowElements[LDAPEntryButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryButtonClick };
			FlowElements[ScriptLDAPEntryButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLDAPEntryButtonClick };
			FlowElements[LDAPEntryButtonClickUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryButtonClickUserTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[LDAPUsersGridPageClose.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPUsersGridPageClose };
			FlowElements[ScriptLDAPUsersGridPageClose.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLDAPUsersGridPageClose };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[LDAPEntryEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { LDAPEntryEditChange };
			FlowElements[ScriptLDAPEntryEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLDAPEntryEditChange };
			FlowElements[EventSubProcessSynchronizeWithLDAPCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessSynchronizeWithLDAPCheckBoxCheck };
			FlowElements[SynchronizeWithLDAPCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeWithLDAPCheckBoxCheck };
			FlowElements[ScriptSynchronizeWithLDAPCheckBoxCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSynchronizeWithLDAPCheckBoxCheck };
			FlowElements[PageLoadCompleteChildEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildEventSubProcess };
			FlowElements[PageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChild };
			FlowElements[PageLoadCompleteParent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteParent };
			FlowElements[ScriptPageLoadCompleteChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChild };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[Child_InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_InitScriptTask };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[OKButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickChild };
			FlowElements[ThrowScriptOKButtonClickChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowScriptOKButtonClickChild };
			FlowElements[ScriptOKButtonClickChild2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOKButtonClickChild2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ShowErrorMessageTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowErrorMessageTask };
			FlowElements[ExclusiveGateway5.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway5 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess7":
						break;
					case "UserPasswordEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ChangePasswordExpiryDateScriptTask");
						break;
					case "ChangePasswordExpiryDateScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ShowMessageAboutErrorPasswordTask":
						break;
					case "Terminate1":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowMessageAboutErrorPasswordTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ActiveCheckBoxCheckScriptTask");
						break;
					case "ActiveCheckBoxCheckScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("ChildDataSourceSavedScriptTask");
						break;
					case "ChildDataSourceSavedScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway4");
						break;
					case "DataSourceSavedIntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("SetCurrentUserPasswordExpiredDate_ScriptTask");
						break;
					case "SetCurrentUserPasswordExpiredDate_ScriptTask":
						break;
					case "ShowMessageAboutErrorUpdateLicenseTask":
						break;
					case "ExclusiveGateway4":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowMessageAboutErrorUpdateLicenseTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("DataSourceSavedIntermediateThrowMessageEvent2");
						break;
					case "LDAPEntryButtonClickEventSubProcess":
						break;
					case "LDAPEntryButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptLDAPEntryButtonClick");
						break;
					case "ScriptLDAPEntryButtonClick":
						e.Context.QueueTasks.Enqueue("LDAPEntryButtonClickUserTask");
						break;
					case "LDAPEntryButtonClickUserTask":
						break;
					case "EventSubProcess5":
						break;
					case "LDAPUsersGridPageClose":
						e.Context.QueueTasks.Enqueue("ScriptLDAPUsersGridPageClose");
						break;
					case "ScriptLDAPUsersGridPageClose":
						break;
					case "EventSubProcess4":
						break;
					case "LDAPEntryEditChange":
						e.Context.QueueTasks.Enqueue("ScriptLDAPEntryEditChange");
						break;
					case "ScriptLDAPEntryEditChange":
						break;
					case "EventSubProcessSynchronizeWithLDAPCheckBoxCheck":
						break;
					case "SynchronizeWithLDAPCheckBoxCheck":
						e.Context.QueueTasks.Enqueue("ScriptSynchronizeWithLDAPCheckBoxCheck");
						break;
					case "ScriptSynchronizeWithLDAPCheckBoxCheck":
						break;
					case "PageLoadCompleteChildEventSubProcess":
						break;
					case "PageLoadCompleteChild":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteParent");
						break;
					case "PageLoadCompleteParent":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChild");
						break;
					case "ScriptPageLoadCompleteChild":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("Child_InitScriptTask");
						break;
					case "Child_InitScriptTask":
						break;
					case "SubProcess2":
						break;
					case "OKButtonClickChild":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ThrowScriptOKButtonClickChild":
						break;
					case "ScriptOKButtonClickChild2":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway5");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowErrorMessageTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptOKButtonClickChild2");
						break;
					case "ShowErrorMessageTask":
						break;
					case "ExclusiveGateway5":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowErrorMessageTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ThrowScriptOKButtonClickChild");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(ShowMessageAboutErrorPassword == true);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(ShowMessageAboutErrorPassword == true);
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(IsShowMessageAboutErrorUpdateLicense);
		}

		private bool ConditionalFlow4ExpressionExecute() {
			return Convert.ToBoolean(IsShowMessageAboutErrorUpdateLicense);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("UserPasswordEditChange_StartMessage");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("LDAPEntryButtonClick");
			ActivatedEventElements.Add("LDAPUsersGridPageClose");
			ActivatedEventElements.Add("LDAPEntryEditChange");
			ActivatedEventElements.Add("SynchronizeWithLDAPCheckBoxCheck");
			ActivatedEventElements.Add("PageLoadCompleteChild");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("OKButtonClickChild");
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
				case "UserPasswordEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "UserPasswordEditChange_StartMessage";
					result = UserPasswordEditChange_StartMessage.Execute(context);
					break;
				case "ChangePasswordExpiryDateScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangePasswordExpiryDateScriptTask";
					result = ChangePasswordExpiryDateScriptTask.Execute(context, ChangePasswordExpiryDateScriptTaskExecute);
					break;
				case "ShowMessageAboutErrorPasswordTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageAboutErrorPasswordTask";
					result = ShowMessageAboutErrorPasswordTask.Execute(context);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ActiveCheckBoxCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActiveCheckBoxCheckScriptTask";
					result = ActiveCheckBoxCheckScriptTask.Execute(context, ActiveCheckBoxCheckScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ChildDataSourceSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildDataSourceSavedScriptTask";
					result = ChildDataSourceSavedScriptTask.Execute(context, ChildDataSourceSavedScriptTaskExecute);
					break;
				case "DataSourceSavedIntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceSaved");
					result = DataSourceSavedIntermediateThrowMessageEvent2.Execute(context);
					break;
				case "SetCurrentUserPasswordExpiredDate_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetCurrentUserPasswordExpiredDate_ScriptTask";
					result = SetCurrentUserPasswordExpiredDate_ScriptTask.Execute(context, SetCurrentUserPasswordExpiredDate_ScriptTaskExecute);
					break;
				case "ShowMessageAboutErrorUpdateLicenseTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageAboutErrorUpdateLicenseTask";
					result = ShowMessageAboutErrorUpdateLicenseTask.Execute(context);
					break;
				case "ExclusiveGateway4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway4";
					result = ExclusiveGateway4.Execute(context);
					break;
				case "LDAPEntryButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "LDAPEntryButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPEntryButtonClick";
					result = LDAPEntryButtonClick.Execute(context);
					break;
				case "ScriptLDAPEntryButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLDAPEntryButtonClick";
					result = ScriptLDAPEntryButtonClick.Execute(context, ScriptLDAPEntryButtonClickExecute);
					break;
				case "LDAPEntryButtonClickUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPEntryButtonClickUserTask";
					result = LDAPEntryButtonClickUserTask.Execute(context);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "LDAPUsersGridPageClose":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPUsersGridPageClose";
					result = LDAPUsersGridPageClose.Execute(context);
					break;
				case "ScriptLDAPUsersGridPageClose":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLDAPUsersGridPageClose";
					result = ScriptLDAPUsersGridPageClose.Execute(context, ScriptLDAPUsersGridPageCloseExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "LDAPEntryEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "LDAPEntryEditChange";
					result = LDAPEntryEditChange.Execute(context);
					break;
				case "ScriptLDAPEntryEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLDAPEntryEditChange";
					result = ScriptLDAPEntryEditChange.Execute(context, ScriptLDAPEntryEditChangeExecute);
					break;
				case "EventSubProcessSynchronizeWithLDAPCheckBoxCheck":
					context.QueueTasks.Dequeue();
					break;
				case "SynchronizeWithLDAPCheckBoxCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeWithLDAPCheckBoxCheck";
					result = SynchronizeWithLDAPCheckBoxCheck.Execute(context);
					break;
				case "ScriptSynchronizeWithLDAPCheckBoxCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSynchronizeWithLDAPCheckBoxCheck";
					result = ScriptSynchronizeWithLDAPCheckBoxCheck.Execute(context, ScriptSynchronizeWithLDAPCheckBoxCheckExecute);
					break;
				case "PageLoadCompleteChildEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChild";
					result = PageLoadCompleteChild.Execute(context);
					break;
				case "PageLoadCompleteParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteParent.Execute(context);
					break;
				case "ScriptPageLoadCompleteChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChild";
					result = ScriptPageLoadCompleteChild.Execute(context, ScriptPageLoadCompleteChildExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "Child_InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_InitScriptTask";
					result = Child_InitScriptTask.Execute(context, Child_InitScriptTaskExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickChild";
					result = OKButtonClickChild.Execute(context);
					break;
				case "ThrowScriptOKButtonClickChild":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = ThrowScriptOKButtonClickChild.Execute(context);
					break;
				case "ScriptOKButtonClickChild2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOKButtonClickChild2";
					result = ScriptOKButtonClickChild2.Execute(context, ScriptOKButtonClickChild2Execute);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ShowErrorMessageTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowErrorMessageTask";
					result = ShowErrorMessageTask.Execute(context);
					break;
				case "ExclusiveGateway5":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway5";
					result = ExclusiveGateway5.Execute(context);
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
				case "IsShowMessageAboutErrorUpdateLicense":
					IsShowMessageAboutErrorUpdateLicense = reader.GetValue<System.Boolean>();
				break;
				case "UpdateLicenseErrorMessage":
					UpdateLicenseErrorMessage = reader.GetValue<System.String>();
				break;
				case "ShowMessageAboutErrorPassword":
					ShowMessageAboutErrorPassword = reader.GetValue<System.Boolean>();
				break;
				case "PasswordErrorMessage":
					PasswordErrorMessage = reader.GetValue<System.String>();
				break;
				case "IsPasswordChange":
					IsPasswordChange = reader.GetValue<System.Boolean>();
				break;
				case "RecordId":
					RecordId = reader.GetValue<System.Guid>();
				break;
				case "PasswordDuration":
					PasswordDuration = reader.GetValue<System.Int32>();
				break;
				case "CanManageLicUsers":
					CanManageLicUsers = reader.GetValue<System.Boolean>();
				break;
				case "SysPackageAvailables":
					SysPackageAvailables = reader.GetSerializableObjectValue();
				break;
				case "SysPackageNames":
					SysPackageNames = reader.GetSerializableObjectValue();
				break;
				case "SysPackageIds":
					SysPackageIds = reader.GetSerializableObjectValue();
				break;
				case "LdapEntryChanged":
					LdapEntryChanged = reader.GetValue<System.Boolean>();
				break;
				case "areConditionsCorrect":
					areConditionsCorrect = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ChangePasswordExpiryDateScriptTaskExecute(ProcessExecutingContext context) {
			if (PasswordDuration > 0) {
				Page.PasswordExpireDateEdit.SuspendAjaxEvents();
				Page.PasswordExpireDateEdit.Value = DateTime.UtcNow.AddDays(PasswordDuration).Date;
				Page.PasswordExpireDateEdit.ResumeAjaxEvents();
			}
			IsPasswordChange = true;
			ShowMessageAboutErrorPassword = !GetIsPasswordCorrect(GetPassword(), Page.UserConnection);
			if (ShowMessageAboutErrorPassword) {
				ShowMessageAboutErrorPasswordTask.Page = Page;
				ShowMessageAboutErrorPasswordTask.MessageText = PasswordErrorMessage;
				ShowMessageAboutErrorPasswordTask.Icon = "WARNING";
				ShowMessageAboutErrorPasswordTask.Buttons = "OK";
			}
			return true;
		}

		public virtual bool ActiveCheckBoxCheckScriptTaskExecute(ProcessExecutingContext context) {
			var activeChecked = Page.ActiveCheckBox.Checked;
			for (int i = 0; i < (SysPackageIds as Guid[]).Length; i++) {
				var available = (SysPackageAvailables as bool[])[i];
				if (available) {
					Terrasoft.UI.WebControls.Controls.CheckBox checkBox;
					checkBox = Page.LicenseControlLayout.Items[i] as Terrasoft.UI.WebControls.Controls.CheckBox;		
					if (activeChecked) {
						checkBox.Enabled = CanManageLicUsers;
						checkBox.Checked = true;
					}
					else {
						checkBox.Checked = false;
						checkBox.Enabled = false;
					}
				}	
			}
			return true;
		}

		public virtual bool ChildDataSourceSavedScriptTaskExecute(ProcessExecutingContext context) {
			IsShowMessageAboutErrorUpdateLicense = false;
			if (IsNew) {
				UpdateLicenseErrorMessage = UpdateLicenseInfo();
				if(!string.IsNullOrEmpty(UpdateLicenseErrorMessage)) {
					ShowMessageAboutErrorUpdateLicenseTask.Page = Page;
					ShowMessageAboutErrorUpdateLicenseTask.MessageText = UpdateLicenseErrorMessage;
					ShowMessageAboutErrorUpdateLicenseTask.Icon = "WARNING";
					ShowMessageAboutErrorUpdateLicenseTask.Buttons = "OK";
					IsShowMessageAboutErrorUpdateLicense = true;
				}
			}
			return true;
		}

		public virtual bool SetCurrentUserPasswordExpiredDate_ScriptTaskExecute(ProcessExecutingContext context) {
			if ((string)Page.DataSource.ActiveRow.GetColumnValue("Name") == UserConnection.CurrentUser.Name) {
				UserConnection.RefreshCurrentUserInfo();
			}
			return true;
		}

		public virtual bool ScriptLDAPEntryButtonClickExecute(ProcessExecutingContext context) {
			LDAPEntryButtonClickUserTask.CloseMessage = "LDAPUsersGridPageClose";
			LDAPEntryButtonClickUserTask.OpenerInstanceId = InstanceUId;
			LDAPEntryButtonClickUserTask.UseCurrentActivePage = true;
			LDAPEntryButtonClickUserTask.PageUId = new Guid("{bc593a79-34be-4f02-b5e9-5a0ff54987fc}");
			return true;
		}

		public virtual bool ScriptLDAPUsersGridPageCloseExecute(ProcessExecutingContext context) {
			var sessionData = UserConnection.SessionData;
			var currentUserId = UserConnection.CurrentUser.Id.ToString();
			var activeRow = Page.DataSource.ActiveRow;
			var ldapEntry = sessionData[currentUserId + "LDAPEntry"];
			if (ldapEntry != null) {
				activeRow.SetColumnValue("LDAPEntry", ldapEntry);
				activeRow.SetColumnValue("Name", ldapEntry);
				sessionData.Remove(currentUserId + "LDAPEntry");
			}
			if (sessionData[currentUserId + "LDAPEntryId"] != null) {
				activeRow.SetColumnValue("LDAPEntryId", sessionData[currentUserId + "LDAPEntryId"]);
				sessionData.Remove(currentUserId + "LDAPEntryId");
			}
			return true;
		}

		public virtual bool ScriptLDAPEntryEditChangeExecute(ProcessExecutingContext context) {
			Page.NameEdit.Text = Page.LDAPEntryEdit.Text;
			LdapEntryChanged = true;
			return true;
		}

		public virtual bool ScriptSynchronizeWithLDAPCheckBoxCheckExecute(ProcessExecutingContext context) {
			SetLDAPEntryEnable();
			var activeRow = Page.DataSource.ActiveRow;
			if (activeRow.GetTypedColumnValue<bool>("SynchronizeWithLDAP")) {
				activeRow.SetColumnValue("Active", true);
			} else {
				activeRow.SetColumnValue("Name", string.Empty);
				activeRow.SetColumnValue("UserPassword", string.Empty);
				activeRow.SetColumnValue("LDAPEntry", string.Empty);
				activeRow.SetColumnValue("LDAPEntryId", string.Empty);
			}
			return true;
		}

		public virtual bool ScriptPageLoadCompleteChildExecute(ProcessExecutingContext context) {
			SetLDAPEntryEnable();
			SetLDAPControlsVisibility();
			if (!IsNew && !Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("Active")) {
				foreach (var checkBoxItem in Page.LicenseControlLayout.Items) {
					var checkBox = checkBoxItem as Terrasoft.UI.WebControls.Controls.CheckBox;
					checkBox.Checked = false;
					checkBox.Enabled = false;
				}
			}
			
			var connectionType = UserConnection.SessionData["CurrentFolderConnectionType"];
			if (IsNew) {
				Page.DataSource.ActiveRow.SetColumnValue("ConnectionType", connectionType);
				var employeeIdObj = Page.GetParameterValue("EmployeeId");
				if (employeeIdObj != null) {
					var contactId = new Guid(employeeIdObj.ToString());
					Page.DataSource.ActiveRow.SetColumnValue("ContactId", contactId);
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var contactSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "Contact");
					contactSchemaQuery.AddColumn("Name");
					var contactIdFilter = contactSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", contactId);
					contactSchemaQuery.Filters.Add(contactIdFilter);
					var contacts = contactSchemaQuery.GetEntityCollection(UserConnection);
					if (contacts.Count > 0) {
						var contactName = contacts[0].GetColumnValue("Name").ToString();
						Page.EmployeeEdit.SetValueAndText(contactId, contactName);
					}
				}
			}
			
			bool isGeneralUser = connectionType == null || connectionType.Equals((int)UserType.General);
			Page.EmployeeEdit.Enabled = IsNew || IsCopy || !isGeneralUser;
			Page.PasswordExpireDateEdit.Enabled = (PasswordDuration > 0);
			
			return true;
		}

		public virtual bool Child_InitScriptTaskExecute(ProcessExecutingContext context) {
			if (!Ext.IsAjaxRequest) {
				CanManageLicUsers = UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageLicUsers");
			}
			CreateSolutionCheckBoxes();
			Page.EmployeeEdit.PrepareLookupFilter += PrepareEmployeeEditFilter;
			
			Page.HomePageEdit.PrepareLookupFilter += HomePageEditPrepareLookupFilter;
			
			if (!IsNew && Page.GetParameterValue("RecordId").ToString() == UserConnection.CurrentUser.Id.ToString()) {
				Page.SysCultureEdit.Hidden = true;
			}
			
			PasswordDuration = 0;
			object value;
			if (SysSettings.TryGetValue(UserConnection, "PasswordDuration", out value)) {
				PasswordDuration = (int)value;
			}
			RecordId = new Guid(Page.GetParameterValue("RecordId").ToString());
			
			return true;
		}

		public virtual bool ScriptOKButtonClickChild2Execute(ProcessExecutingContext context) {
			IsShowMessageAboutErrorUpdateLicense = false;
			if (!IsNew) {
				UpdateLicenseErrorMessage = UpdateLicenseInfo();
				if(!string.IsNullOrEmpty(UpdateLicenseErrorMessage)) {
					ShowErrorMessageTask.Page = Page;
					ShowErrorMessageTask.MessageText = UpdateLicenseErrorMessage;
					ShowErrorMessageTask.Icon = "WARNING";
					ShowErrorMessageTask.Buttons = "OK";
					IsShowMessageAboutErrorUpdateLicense = true;
				}
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			ShowMessageAboutErrorPassword = IsPasswordChange ? !GetIsPasswordCorrect(GetPassword(), Page.UserConnection) : false;
			if (ShowMessageAboutErrorPassword) {
				ShowErrorMessageTask.Page = Page;
				ShowErrorMessageTask.MessageText = PasswordErrorMessage;
				ShowErrorMessageTask.Icon = "WARNING";
				ShowErrorMessageTask.Buttons = "OK";
			}
			return true;
		}

		public override bool AreConditionsCorrect(Entity row) {
			var entitySchemaManager = Page.UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit");
			entitySchemaQuery.AddColumn("Id");
			EntitySchemaQueryFilterCollection filters = entitySchemaQuery.Filters;
			var filter = (EntitySchemaQueryFilter)entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Name", row.GetColumnValue("Name"));
			filters.Add(filter);
			filter = (EntitySchemaQueryFilter)entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.NotEqual, "Id", row.GetColumnValue("Id"));
			filters.Add(filter);
			EntitySchemaQueryOptions options = new EntitySchemaQueryOptions() {
				PageableDirection = PageableSelectDirection.Current,
				PageableConditionValues = new Dictionary<string, object>()
			};
			EntityCollection entityCollection = entitySchemaQuery.GetEntityCollection(Page.UserConnection, options);
			areConditionsCorrect = (entityCollection == null || (entityCollection.Count == 0));
			if (!areConditionsCorrect) {
				if (!Page.BaseMessagePanel.HasMessage("CaptionNotUnique")) {
					Page.BaseMessagePanel.AddMessage("CaptionNotUnique", AttentionCaption, NameNotUniqueMessage);
				}
			} else {
				Page.ThrowClientEvent("UserEditPageClosed", Page.DataSource.ActiveRowPrimaryColumnValue, IsNew);
			}
			return areConditionsCorrect;
		}

		public override void MakeCaption() {
			if(IsCaptionExists) {
				return;
			}
			var columnName = Page.DataSource.Schema.FindPrimaryDisplayColumnName();
			var primaryDisplayColumnName = String.Empty;
			var record = Page.GetParameterValue("recordId");
			var recordId = record != null ? new Guid(record.ToString()) : Guid.Empty;
			bool isNew = recordId.IsEmpty() || Convert.ToBoolean(Page.GetParameterValue("Copy"));
			if (isNew) {
				primaryDisplayColumnName = NewRecordCaption;
			} else {
				if(string.IsNullOrEmpty(columnName)) {
					primaryDisplayColumnName = EditingRecordCaption;
				} else {
					primaryDisplayColumnName = Page.DataSource.Rows[0].GetTypedColumnValue<string>(columnName);
				}
			}
			var caption = WindowCaption;
			caption = string.Format("{0} ({1})", caption, primaryDisplayColumnName);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = caption;
		}

		public virtual void SetLDAPEntryEnable() {
			var synchronizeWithLDAP = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("SynchronizeWithLDAP");
			Page.LDAPEntryButton.SetEnabled(synchronizeWithLDAP);
			Page.LDAPEntryEdit.SetEnabled(synchronizeWithLDAP);
			Page.LDAPEntryEdit.SetRequired(synchronizeWithLDAP);
			Page.NameEdit.SetRequired(!synchronizeWithLDAP);
			Page.NameEdit.SetEnabled(!synchronizeWithLDAP);
			Page.UserPasswordEdit.SetRequired(!synchronizeWithLDAP);
			Page.UserPasswordEdit.SetEnabled(!synchronizeWithLDAP);
			Page.NameEdit.Enabled = !synchronizeWithLDAP;
			Page.BPMonlineRadioButton.Checked = !synchronizeWithLDAP;
			return;
		}

		public virtual void SetLDAPControlsVisibility() {
			var enabled = false;
			Page.LDAPControlLayout.Enabled = enabled;
			Page.SynchronizeWithLDAPCheckBox.Enabled = enabled;
			Page.LDAPEntryEdit.Enabled = enabled;
		}

		public override Dictionary<string, object> GetDefValues() {
			var defValues = base.GetDefValues();
			defValues["Description"] = "";
			defValues["IsDirectoryEntry"] = false;
			defValues["SysAdminUnitType"] = new Guid("{472E97C7-6BD7-DF11-9B2A-001D60E938C6}");
			return defValues;
		}

		public virtual void CreateSolutionCheckBoxes() {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			Guid[] sysPackageIds;
			string[] sysPackageNames;
			bool[] sysPackageAvailables = new bool[0];
			if (!Ext.IsAjaxRequest) {
				var sysPackages = UserConnection.LicHelper.GetAvailablePackages();
				var n = sysPackages.Count;
				sysPackageIds = new Guid[n];
				sysPackageNames = new string[n];
				sysPackageAvailables = new bool[n];
				for (int i = 0; i < n; i++) {
					sysPackageIds[i] = sysPackages[i].GetTypedColumnValue<Guid>("SysLicPackageId");
					sysPackageNames[i] = sysPackages[i].GetColumnValue("SysPackageName").ToString();
				}
				SysPackageIds = sysPackageIds;
				SysPackageNames = sysPackageNames;
			}
			else {
				sysPackageIds = SysPackageIds as Guid[];
				sysPackageNames = SysPackageNames as string[];
			}
			var recordId = new Guid(Page.Request.QueryString["recordId"]);
			var isNew = (recordId == Guid.Empty);
			if (sysPackageIds != null) {
				for (int i = 0; i < sysPackageIds.Length; i++) {
					var sysPackageId = sysPackageIds[i];
					var sysPackageName = sysPackageNames[i];	
					var checkBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
					checkBox.Name = "CheckBox" + sysPackageId.ToString().Replace("-", "_").Replace("{", "").Replace("}", "");
					if (!Ext.IsAjaxRequest) {	
						var availableLicensesCount = GetAvailableLicensesCount(sysPackageId);
						var userInitiallyHadLicense = false;
						if (!isNew) {
							userInitiallyHadLicense = GetUserHasLicense(recordId, sysPackageId);  
						}	
							
						sysPackageAvailables[i] = availableLicensesCount > 0;
						checkBox.Enabled = CanManageLicUsers && (userInitiallyHadLicense || availableLicensesCount > 0);
						checkBox.Checked = userInitiallyHadLicense || (isNew && availableLicensesCount > 0);
						checkBox.Width = Unit.Percentage(100);
						checkBox.Caption = sysPackageName;	
						checkBox.CaptionPosition = CheckBoxBaseCaptionPosition.Left;				
					}
					Page.LicenseControlLayout.AddItem(checkBox);
				}
			}
			if (!Ext.IsAjaxRequest) {
				SysPackageAvailables = sysPackageAvailables;
			}
		}

		public virtual int GetAvailableLicensesCount(Guid sysLicPackageId) {
			var purchasedLicensesCount = 0;
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var sysLicSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysLic");
			sysLicSchemaQuery.AddColumn("Count").OrderByDesc();	
			sysLicSchemaQuery.AddColumn("LicType");
			var nowDt = UserConnection.CurrentUser.GetCurrentDateTime();
			var startDateFilter = sysLicSchemaQuery.CreateFilterWithParameters(FilterComparisonType.LessOrEqual, "StartDate", nowDt);
			var dueDateFilter = sysLicSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Greater, "DueDate", nowDt);
			var sysPackageIdFilter = sysLicSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysLicPackage", sysLicPackageId);
			var filter = new EntitySchemaQueryFilterCollection(sysLicSchemaQuery, LogicalOperationStrict.And, startDateFilter, dueDateFilter, sysPackageIdFilter);
			sysLicSchemaQuery.Filters.Add(filter);	
			var sysLics = sysLicSchemaQuery.GetEntityCollection(UserConnection);
			var licType = SysLicType.Personal;
			for (int i = 0; i < sysLics.Count; i++) {
				purchasedLicensesCount += sysLics[i].GetTypedColumnValue<int>("Count");
				licType = sysLics[i].GetTypedColumnValue<SysLicType>("LicType");
			}
			var sysLicUserSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysLicUser");
			sysLicUserSchemaQuery.AddColumn("Id");
			sysPackageIdFilter = sysLicUserSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysLicPackage", sysLicPackageId);
			sysLicUserSchemaQuery.Filters.Add(sysPackageIdFilter);
			var sysLicUsers = sysLicUserSchemaQuery.GetEntityCollection(UserConnection);
			return licType == SysLicType.Competitive ? purchasedLicensesCount : purchasedLicensesCount - sysLicUsers.Count;
		}

		public virtual bool GetUserHasLicense(Guid sysUserId, Guid sysLicPackageId) {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var sysLicUserSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysLicUser");
			sysLicUserSchemaQuery.AddColumn("Id");
			var userIdFilter = sysLicUserSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysUser", sysUserId);
			var sysPackageIdFilter = sysLicUserSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysLicPackage", sysLicPackageId);
			var filter = new EntitySchemaQueryFilterCollection(sysLicUserSchemaQuery, LogicalOperationStrict.And, userIdFilter, sysPackageIdFilter);
			sysLicUserSchemaQuery.Filters.Add(filter);	
			var sysLicUsers = sysLicUserSchemaQuery.GetEntityCollection(UserConnection);
			return sysLicUsers.Count > 0;
		}

		public virtual string UpdateLicenseInfo() {
			var userId = Page.DataSource.ActiveRowPrimaryColumnValue;
			EntityCollection availablePackages = null;
			var sb = new StringBuilder();
			foreach (var checkBoxItem in Page.LicenseControlLayout.Items) {
				var checkBox = checkBoxItem as Terrasoft.UI.WebControls.Controls.CheckBox;
				var sysPackageId = new Guid(checkBox.Name.Substring(8).Replace("_", "-"));
				var userHasLicense = GetUserHasLicense(userId, sysPackageId);
				if (checkBox.Checked && !userHasLicense) {
					if(availablePackages ==null) {
						availablePackages = UserConnection.LicHelper.GetAvailablePackages();
					}
					bool hasErrors = false;
					foreach (Entity item in availablePackages) {
						Guid sysLicPackageId = item.GetTypedColumnValue<Guid>("SysLicPackageId");
						if (sysLicPackageId==sysPackageId) {
							SysLicType LicType = item.GetTypedColumnValue<SysLicType>("LicType");
							if (LicType == SysLicType.Personal && 
								item.GetTypedColumnValue<int>("PersonalLicCount") >= item.GetTypedColumnValue<int>("Count")){
								hasErrors = true;
								sb.AppendIfNotEmpty(", ");
								sb.Append(item.GetTypedColumnValue<string>("SysPackageName"));
							}
						}
					}
					if (!hasErrors){
						var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
						var sysLicUser = entitySchemaManager.GetInstanceByName("SysLicUser").CreateEntity(UserConnection);
						sysLicUser.SetDefColumnValues();
						sysLicUser.SetColumnValue("SysUserId", userId);
						sysLicUser.SetColumnValue("SysLicPackageId", sysPackageId);
						sysLicUser.SetColumnValue("Active", true);
						sysLicUser.Save();
					}
				}
				if (!checkBox.Checked && userHasLicense) {
					var delete = new Delete(UserConnection).From("SysLicUser").Where("SysUserId").IsEqual(new QueryParameter(userId)).And("SysLicPackageId").IsEqual(new QueryParameter(sysPackageId)) as Delete;
					delete.Execute();
				}
			}
			if (sb.Length > 0) {
				return string.Format(new LocalizableString("Terrasoft.WebApp.Loader","LicManager.PaidLicenseCountExceededMessage"), sb);
			}
			return string.Empty;
		}

		public virtual void PrepareEmployeeEditFilter(object sender, LookupEditEventArgs e) {
			var connectionType = UserConnection.SessionData["CurrentFolderConnectionType"];
			var filters = e.Filters;
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.Equal}, 
				{"leftExpressionColumnPath", "[SysAdminUnit:Contact].Id"},
				{"aggregationType", AggregationTypeStrict.Count},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", new object[] {0}}});
			if(connectionType == null || connectionType.Equals((int)UserType.General)) {
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.IsNotNull}, 
					{"leftExpressionColumnPath", "[SysAdminUnit:Account:Account].Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {0}}});
			}
			e.ParametersValue.Add("hideButtons", true);
		}

		public virtual void HomePageEditPrepareLookupFilter(object sender, LookupEditEventArgs e) {
			var filters = e.Filters;
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.Greater}, 
				{"leftExpressionColumnPath", "[SysModuleInSysModuleFolder:SysModule].Id"},
				{"aggregationType", AggregationTypeStrict.Count},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", new object[] {0}}});
			filters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.IsNotNull}, 
				{"leftExpressionColumnPath", "SectionModuleSchemaUId"},
				{"useDisplayValue", false}});
			e.ParametersValue.Add("hideButtons", true);
		}

		public virtual bool GetIsPasswordCorrect(string password, UserConnection userConnection) {
			if (!IsPasswordChange) {
				return true;
			}
			string userName = userConnection.CurrentUser.Name;
			bool result = true;
			try{
				password.ValidatePassword(userConnection, userName);
			} catch (SecurityException ex) {
				PasswordErrorMessage = ex.Message.FormatForHtml();
				result = false;
			}
			return result;
		}

		public virtual string GetPassword() {
			return Page.UserPasswordEdit.Value.ToString();
		}

		public virtual bool ValidateCanChangeRecord() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "UserPasswordEditChange":
							if (ActivatedEventElements.Contains("UserPasswordEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("UserPasswordEditChange_StartMessage");
						}
						break;
					case "ActiveCheckBoxCheck":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "LDAPEntryButtonClick":
							if (ActivatedEventElements.Contains("LDAPEntryButtonClick")) {
							context.QueueTasks.Enqueue("LDAPEntryButtonClick");
						}
						break;
					case "LDAPUsersGridPageClose":
							if (ActivatedEventElements.Contains("LDAPUsersGridPageClose")) {
							context.QueueTasks.Enqueue("LDAPUsersGridPageClose");
						}
						break;
					case "LDAPEntryEditChange":
							if (ActivatedEventElements.Contains("LDAPEntryEditChange")) {
							context.QueueTasks.Enqueue("LDAPEntryEditChange");
						}
						break;
					case "SynchronizeWithLDAPCheckBoxCheck":
							if (ActivatedEventElements.Contains("SynchronizeWithLDAPCheckBoxCheck")) {
							context.QueueTasks.Enqueue("SynchronizeWithLDAPCheckBoxCheck");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChild")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChild");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickChild")) {
							context.QueueTasks.Enqueue("OKButtonClickChild");
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
			if (!HasMapping("IsShowMessageAboutErrorUpdateLicense") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsShowMessageAboutErrorUpdateLicense", IsShowMessageAboutErrorUpdateLicense, false);
			}
			if (!HasMapping("UpdateLicenseErrorMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("UpdateLicenseErrorMessage", UpdateLicenseErrorMessage, null);
			}
			if (!HasMapping("ShowMessageAboutErrorPassword") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ShowMessageAboutErrorPassword", ShowMessageAboutErrorPassword, false);
			}
			if (!HasMapping("PasswordErrorMessage") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PasswordErrorMessage", PasswordErrorMessage, null);
			}
			if (!HasMapping("IsPasswordChange") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsPasswordChange", IsPasswordChange, false);
			}
			if (!HasMapping("RecordId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("PasswordDuration") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("PasswordDuration", PasswordDuration, 0);
			}
			if (!HasMapping("CanManageLicUsers") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CanManageLicUsers", CanManageLicUsers, false);
			}
			if (SysPackageAvailables != null) {
				if (SysPackageAvailables.GetType().IsSerializable ||
					SysPackageAvailables.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SysPackageAvailables", SysPackageAvailables, null);
				}
			}
			if (SysPackageNames != null) {
				if (SysPackageNames.GetType().IsSerializable ||
					SysPackageNames.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SysPackageNames", SysPackageNames, null);
				}
			}
			if (SysPackageIds != null) {
				if (SysPackageIds.GetType().IsSerializable ||
					SysPackageIds.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SysPackageIds", SysPackageIds, null);
				}
			}
			if (!HasMapping("LdapEntryChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LdapEntryChanged", LdapEntryChanged, false);
			}
			if (!HasMapping("areConditionsCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("areConditionsCorrect", areConditionsCorrect, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: UserEditPageEventsProcess

	/// <exclude/>
	public class UserEditPageEventsProcess : UserEditPageEventsProcess<Terrasoft.WebApp.UserEditPageSchemaUserControl>
	{

		public UserEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UserEditPageSchemaUserControl

	/// <exclude/>
	public partial class UserEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit EmployeeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EmployeeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit SysCultureEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("SysCultureEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit HomePageEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("HomePageEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton BPMonlineRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("BPMonlineRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BPMonlineControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BPMonlineControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit NameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("NameEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit UserPasswordEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("UserPasswordEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.DateTimeEdit PasswordExpireDateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.DateTimeEdit)PageContainer.FindPageControl("PasswordExpireDateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout LDAPControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LDAPControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton SynchronizeWithLDAPCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("SynchronizeWithLDAPCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit LDAPEntryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("LDAPEntryEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton LDAPEntryButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("LDAPEntryButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ActiveCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ActiveCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ForceChangePasswordCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ForceChangePasswordCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout LicenseControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("LicenseControlLayout", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			UserPasswordEdit.AjaxEvents.Change.Event += UserPasswordEditChange;
			SynchronizeWithLDAPCheckBox.AjaxEvents.Check.Event += SynchronizeWithLDAPCheckBoxCheck;
			LDAPEntryEdit.AjaxEvents.Change.Event += LDAPEntryEditChange;
			LDAPEntryButton.AjaxEvents.Click.Event += LDAPEntryButtonClick;
			ActiveCheckBox.AjaxEvents.Check.Event += ActiveCheckBoxCheck;
			DataSource.BeforeSaveRow += DataSourceBeforeSave;
			DataSource.SaveRow += DataSourceSaved;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			UserPasswordEdit.AjaxEvents.Change.Event -= UserPasswordEditChange;
			SynchronizeWithLDAPCheckBox.AjaxEvents.Check.Event -= SynchronizeWithLDAPCheckBoxCheck;
			LDAPEntryEdit.AjaxEvents.Change.Event -= LDAPEntryEditChange;
			LDAPEntryButton.AjaxEvents.Click.Event -= LDAPEntryButtonClick;
			ActiveCheckBox.AjaxEvents.Check.Event -= ActiveCheckBoxCheck;
			DataSource.BeforeSaveRow -= DataSourceBeforeSave;
			DataSource.SaveRow -= DataSourceSaved;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (UserEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new UserEditPageEventsProcess(UserConnection);
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

		public virtual void UserPasswordEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("UserPasswordEditChange");
		}

		public virtual void SynchronizeWithLDAPCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("SynchronizeWithLDAPCheckBoxCheck");
		}

		public virtual void LDAPEntryEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("LDAPEntryEditChange");
		}

		public virtual void LDAPEntryButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("LDAPEntryButtonClick");
		}

		public virtual void ActiveCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("ActiveCheckBoxCheck");
		}

		public virtual void DataSourceBeforeSave(object sender, EventArgs e) {
			object result = ThrowEvent("DataSourceBeforeSave");
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
			SchemaName = "UserEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: UserEditPageEventsProcessSchema

	/// <exclude/>
	public class UserEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public UserEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UserEditPageEventsProcessSchema(UserEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UserEditPageEventsProcess";
			UId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593");
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

		protected virtual ProcessSchemaParameter CreateareConditionsCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("69eb4c67-1902-4961-9d81-9d3ba71a8998"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"areConditionsCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLdapEntryChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("740c2b0f-7693-44c6-83e1-c02ed4c90e3f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LdapEntryChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysPackageIdsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("eef07036-ceb7-47cc-bf0e-ca7fb2eaf208"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"SysPackageIds",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysPackageNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3d708d93-a270-4584-8627-8ae46cb55fe1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"SysPackageNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysPackageAvailablesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("74588c15-7b41-4769-891e-ab1fd454cfe0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"SysPackageAvailables",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanManageLicUsersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4db85418-6da7-409b-9a2b-1cd3bef714f9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"CanManageLicUsers",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePasswordDurationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a948f81b-930e-4e54-b38f-b6b89b335862"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"PasswordDuration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("89409887-76eb-4362-bfc4-80e2d4abef61"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsPasswordChangeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a6b216f9-1f41-4cfb-a7bd-24e5a30aa93a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"IsPasswordChange",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePasswordErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bbb0f796-e183-46c6-b4ca-bff06af6ed02"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"PasswordErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateShowMessageAboutErrorPasswordParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d23d98d7-c7fe-45dd-9686-08b800eb2102"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ShowMessageAboutErrorPassword",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUpdateLicenseErrorMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0686ec0e-ab66-4db9-b64f-7701e649f615"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"UpdateLicenseErrorMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsShowMessageAboutErrorUpdateLicenseParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce9c4c98-97e2-4556-9a3c-13cf2fd0d9fb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"IsShowMessageAboutErrorUpdateLicense",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateareConditionsCorrectParameter());
			Parameters.Add(CreateLdapEntryChangedParameter());
			Parameters.Add(CreateSysPackageIdsParameter());
			Parameters.Add(CreateSysPackageNamesParameter());
			Parameters.Add(CreateSysPackageAvailablesParameter());
			Parameters.Add(CreateCanManageLicUsersParameter());
			Parameters.Add(CreatePasswordDurationParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateIsPasswordChangeParameter());
			Parameters.Add(CreatePasswordErrorMessageParameter());
			Parameters.Add(CreateShowMessageAboutErrorPasswordParameter());
			Parameters.Add(CreateUpdateLicenseErrorMessageParameter());
			Parameters.Add(CreateIsShowMessageAboutErrorUpdateLicenseParameter());
		}

		protected virtual void InitializeShowMessageAboutErrorPasswordTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ecce98d5-ce22-47b8-a90e-14618e7e9019"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("a0e35c3f-499e-4437-acd0-1ee2205df8d0"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("d694e027-6f2d-472a-a15d-b5adf95ab7e0"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("5c8b9020-a687-48b4-a52a-205687064045"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("e7f335f6-7775-4a1d-8b7f-666f32731506"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("e9e61fe3-2e37-42f1-a09f-275bf2795a90"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("7681dbe3-06fc-4c28-b12f-d3241e0b8f02"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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
				UId = new Guid("e4e2f2dc-80eb-4c79-8456-7021a7add5aa"),
				ContainerUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
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

		protected virtual void InitializeShowMessageAboutErrorUpdateLicenseTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ac6c6d6a-7c40-4f5b-944e-d91fdeae8d73"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("480cb901-342f-4f47-a84b-091f765f104a"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("fc174b70-4c8c-4f70-8044-22502987cc60"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("d4617232-e5da-4ba7-a85e-3bdc80a57d79"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("7a3b12d8-d512-4602-97a8-4c7f12b4f945"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("c65d85d4-017b-428c-8c48-bd78b20e2319"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("eb7326ad-94d4-4579-a07a-a7ca4c595633"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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
				UId = new Guid("204a1038-89c1-41e5-ba9b-7dc0896a6ce5"),
				ContainerUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
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

		protected virtual void InitializeLDAPEntryButtonClickUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1e04e2d0-91b8-4842-893d-db1cc7dc1a8b"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("5ab93287-86ed-44b8-8143-efdbbfa07ba0"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("8e5d66ba-a48e-4433-9ee5-a82521ae7a2e"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("952968c8-b332-453f-b612-7d0dd39cb81c"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("3f637e00-541d-476e-b434-572d588d72ab"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("a45c92d1-acf6-45e6-9d8e-efe80ab0d706"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("91648756-8db3-434e-9773-23664cf22d25"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("ff7506c2-00b3-4e5a-b446-354a563d2b7c"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("90c38ba3-bcb4-4b2e-87b7-83e83eedf2fe"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("cc67571c-53f7-42e9-a2a4-506c2c593b4b"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("605781e8-747b-4023-afdb-43bb8e698c99"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UId = new Guid("6fe5fd9f-2c43-40f3-98cd-d1b1c9145187"),
				ContainerUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
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

		protected virtual void InitializeShowErrorMessageTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a2bf6cfe-4cb9-4c8c-8e89-16c4fc1d3c0a"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("d4d8f63f-d066-4a86-9f81-e4941d909531"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("81ad12d2-5fdf-4c79-a565-ce098eb1cd80"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("c871de9a-f09c-43ce-81fb-ec6925e62741"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("4a84d4ad-2014-4e28-a163-2a0a00434918"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("642ced3c-35b1-40e5-9843-43e4f2c1e92d"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("62c73d47-fa2b-440a-9a3b-ddb91ed6a0b3"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
				UId = new Guid("2a390dca-1d38-434b-a1da-f178e0b5a9c6"),
				ContainerUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
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
			ProcessSchemaLaneSet schemaLaneSet255 = CreateLaneSet255LaneSet();
			LaneSets.Add(schemaLaneSet255);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet255.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess ldapentrybuttonclickeventsubprocess = CreateLDAPEntryButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(ldapentrybuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocesssynchronizewithldapcheckboxcheck = CreateEventSubProcessSynchronizeWithLDAPCheckBoxCheckEventSubProcess();
			FlowElements.Add(eventsubprocesssynchronizewithldapcheckboxcheck);
			ProcessSchemaEventSubProcess pageloadcompletechildeventsubprocess = CreatePageLoadCompleteChildEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompletechildeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaStartMessageEvent userpasswordeditchange_startmessage = CreateUserPasswordEditChange_StartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(userpasswordeditchange_startmessage);
			ProcessSchemaScriptTask changepasswordexpirydatescripttask = CreateChangePasswordExpiryDateScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(changepasswordexpirydatescripttask);
			ProcessSchemaUserTask showmessageabouterrorpasswordtask = CreateShowMessageAboutErrorPasswordTaskUserTask();
			eventsubprocess7.FlowElements.Add(showmessageabouterrorpasswordtask);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			eventsubprocess7.FlowElements.Add(terminate1);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess7.FlowElements.Add(exclusivegateway2);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask activecheckboxcheckscripttask = CreateActiveCheckBoxCheckScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(activecheckboxcheckscripttask);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask childdatasourcesavedscripttask = CreateChildDataSourceSavedScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(childdatasourcesavedscripttask);
			ProcessSchemaIntermediateThrowMessageEvent datasourcesavedintermediatethrowmessageevent2 = CreateDataSourceSavedIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(datasourcesavedintermediatethrowmessageevent2);
			ProcessSchemaScriptTask setcurrentuserpasswordexpireddate_scripttask = CreateSetCurrentUserPasswordExpiredDate_ScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(setcurrentuserpasswordexpireddate_scripttask);
			ProcessSchemaUserTask showmessageabouterrorupdatelicensetask = CreateShowMessageAboutErrorUpdateLicenseTaskUserTask();
			eventsubprocess3.FlowElements.Add(showmessageabouterrorupdatelicensetask);
			ProcessSchemaExclusiveGateway exclusivegateway4 = CreateExclusiveGateway4ExclusiveGateway();
			eventsubprocess3.FlowElements.Add(exclusivegateway4);
			ProcessSchemaStartMessageEvent ldapentrybuttonclick = CreateLDAPEntryButtonClickStartMessageEvent();
			ldapentrybuttonclickeventsubprocess.FlowElements.Add(ldapentrybuttonclick);
			ProcessSchemaScriptTask scriptldapentrybuttonclick = CreateScriptLDAPEntryButtonClickScriptTask();
			ldapentrybuttonclickeventsubprocess.FlowElements.Add(scriptldapentrybuttonclick);
			ProcessSchemaUserTask ldapentrybuttonclickusertask = CreateLDAPEntryButtonClickUserTaskUserTask();
			ldapentrybuttonclickeventsubprocess.FlowElements.Add(ldapentrybuttonclickusertask);
			ProcessSchemaStartMessageEvent ldapusersgridpageclose = CreateLDAPUsersGridPageCloseStartMessageEvent();
			eventsubprocess5.FlowElements.Add(ldapusersgridpageclose);
			ProcessSchemaScriptTask scriptldapusersgridpageclose = CreateScriptLDAPUsersGridPageCloseScriptTask();
			eventsubprocess5.FlowElements.Add(scriptldapusersgridpageclose);
			ProcessSchemaStartMessageEvent ldapentryeditchange = CreateLDAPEntryEditChangeStartMessageEvent();
			eventsubprocess4.FlowElements.Add(ldapentryeditchange);
			ProcessSchemaScriptTask scriptldapentryeditchange = CreateScriptLDAPEntryEditChangeScriptTask();
			eventsubprocess4.FlowElements.Add(scriptldapentryeditchange);
			ProcessSchemaStartMessageEvent synchronizewithldapcheckboxcheck = CreateSynchronizeWithLDAPCheckBoxCheckStartMessageEvent();
			eventsubprocesssynchronizewithldapcheckboxcheck.FlowElements.Add(synchronizewithldapcheckboxcheck);
			ProcessSchemaScriptTask scriptsynchronizewithldapcheckboxcheck = CreateScriptSynchronizeWithLDAPCheckBoxCheckScriptTask();
			eventsubprocesssynchronizewithldapcheckboxcheck.FlowElements.Add(scriptsynchronizewithldapcheckboxcheck);
			ProcessSchemaStartMessageEvent pageloadcompletechild = CreatePageLoadCompleteChildStartMessageEvent();
			pageloadcompletechildeventsubprocess.FlowElements.Add(pageloadcompletechild);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteparent = CreatePageLoadCompleteParentIntermediateThrowMessageEvent();
			pageloadcompletechildeventsubprocess.FlowElements.Add(pageloadcompleteparent);
			ProcessSchemaScriptTask scriptpageloadcompletechild = CreateScriptPageLoadCompleteChildScriptTask();
			pageloadcompletechildeventsubprocess.FlowElements.Add(scriptpageloadcompletechild);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask child_initscripttask = CreateChild_InitScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(child_initscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickchild = CreateOKButtonClickChildStartMessageEvent();
			subprocess2.FlowElements.Add(okbuttonclickchild);
			ProcessSchemaIntermediateThrowMessageEvent throwscriptokbuttonclickchild = CreateThrowScriptOKButtonClickChildIntermediateThrowMessageEvent();
			subprocess2.FlowElements.Add(throwscriptokbuttonclickchild);
			ProcessSchemaScriptTask scriptokbuttonclickchild2 = CreateScriptOKButtonClickChild2ScriptTask();
			subprocess2.FlowElements.Add(scriptokbuttonclickchild2);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			subprocess2.FlowElements.Add(scripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			subprocess2.FlowElements.Add(exclusivegateway3);
			ProcessSchemaUserTask showerrormessagetask = CreateShowErrorMessageTaskUserTask();
			subprocess2.FlowElements.Add(showerrormessagetask);
			ProcessSchemaExclusiveGateway exclusivegateway5 = CreateExclusiveGateway5ExclusiveGateway();
			subprocess2.FlowElements.Add(exclusivegateway5);
			FlowElements.Add(CreateSequenceFlow4122SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4124SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4125SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4126SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4127SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4128SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4129SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4130SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNameNotUniqueMessageLocalizableString());
			LocalizableStrings.Add(CreateAttentionCaptionLocalizableString());
			LocalizableStrings.Add(CreateWindowCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNameNotUniqueMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cd51c3cb-7292-4cdb-9f1a-45652be8297f"),
				Name = "NameNotUniqueMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAttentionCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6195e9c0-e5d3-471e-b67e-54f6b358b5f8"),
				Name = "AttentionCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c8ea0e78-ea08-4391-8cda-d048baa35cc0"),
				Name = "WindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4122SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4122",
				UId = new Guid("f26789bd-32ca-48d0-b41f-e7ed614a9eba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(148, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b1b560d-7996-4251-8860-f54e1a06897d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3b8bc85-776d-4164-9c44-96744c3d7775"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4124SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4124",
				UId = new Guid("f0cca1cd-74b6-422d-aea5-e329895264af"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b0e68c3-ebb7-48ef-a21a-4e9489061e44"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e53746c-126d-42a4-a93a-e2455ce11432"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4125SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4125",
				UId = new Guid("1337e946-f82c-48c5-b6a9-fa1d280d4d48"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(413, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60f73c99-5599-453e-9bb3-50dc8ee9f0cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("347fb6a8-68d8-4d73-9beb-878ced11f472"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4126SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4126",
				UId = new Guid("8308665f-eaff-4351-b492-4f097bda40fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(500, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("347fb6a8-68d8-4d73-9beb-878ced11f472"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e91a01e8-712b-45a3-9071-77af5cd62bbb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4127SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4127",
				UId = new Guid("1b24de93-087e-4d95-9f1d-8f6604f6e27d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec9f0a8f-bdbc-4a1c-968a-af98e9b51788"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b40ff71-82df-47fe-843a-d3bfc86bf9a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4128SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4128",
				UId = new Guid("5c78e6fa-ddc9-4a72-823e-f89ce5efa6f1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21714f1e-99db-45ea-adf1-aa5891992677"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("56589da2-3258-4a20-bd68-80bcdd81ef00"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4129SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4129",
				UId = new Guid("a9bb1ed0-d054-4486-a257-19392cfaaa98"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(248, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56589da2-3258-4a20-bd68-80bcdd81ef00"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4130SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4130",
				UId = new Guid("eed45a67-b93f-427d-9fb6-2f8b64564060"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(468, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db2406d9-7cd3-4c5f-aa6d-79814442a92a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9fd8b58e-b039-4b77-bdf0-a3a30a85bd27"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("28bbddfc-5b55-4adf-98a9-ea59422d4510"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1640dcd3-4dc5-455c-94e1-addb7a4193d6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5084ebf5-a06b-46b8-94e2-92bb2c2d8bb0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8146282f-bb70-4799-90ce-bd274d1b4562"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(155, 603),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3a57fdf9-0687-46e9-87e4-1d26295ecdf3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d221b095-1cc6-4ee3-9ff6-56e5e4199960"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("eee355d3-283e-4ab3-852d-2e312e416d11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(254, 602),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d221b095-1cc6-4ee3-9ff6-56e5e4199960"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2458abe9-9601-4c91-bb8f-99637e33dacd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("33eb8622-4b91-41ef-8060-4b67e7850223"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(542, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8e2b6dd5-0744-4225-a88d-d21965892058"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d7dd4707-6146-43d6-b35a-bc5ee5d5a311"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("54c65e3e-75df-4cfe-9489-93df285deeeb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(186, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4631c771-d2df-46c6-9606-71a494cd550d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52590e01-3d9c-416a-92d4-90e06aef8649"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c92ae6d4-0c64-4a27-b0f4-2c5aeabbb520"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(440, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3b6560a-2289-48ca-b52b-6a38da5268c2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8e2b6dd5-0744-4225-a88d-d21965892058"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("cf9f2efd-1d44-4fc2-af1c-3aff01f5658e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(700, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("82dc1377-cc25-46aa-8f56-4c708d435d10"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0adc952e-ca4f-4349-a4db-65f8e08a74b7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("b9b2ba5f-d4a3-454c-bbc1-1b8ec5d1a9eb"),
				ConditionExpression = @"ShowMessageAboutErrorPassword == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(388, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9c2e4ae7-2bd0-403a-b5ee-c123a6807b77"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow9",
				UId = new Guid("eaf5746c-5dc5-4fbd-a0ec-2256ea65525b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(400, 136),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9c2e4ae7-2bd0-403a-b5ee-c123a6807b77"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("566a54df-5a1d-4a51-8b84-09eb805e9359"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("9a7c099e-4aef-4b40-b0cf-e64f33db30de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(320, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52590e01-3d9c-416a-92d4-90e06aef8649"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9c2e4ae7-2bd0-403a-b5ee-c123a6807b77"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("184d13da-95dd-4c75-8081-2ba184b76751"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(278, 1080),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3b8bc85-776d-4164-9c44-96744c3d7775"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5e1def9-c039-49e7-9bc8-8e750b936254"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("87074824-120d-431c-8ef4-c284c9ff6ef8"),
				ConditionExpression = @"ShowMessageAboutErrorPassword == true",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(374, 1032),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5e1def9-c039-49e7-9bc8-8e750b936254"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("92f3cace-e2fc-4521-99d4-b3a403d87834"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(438, 1050),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5e1def9-c039-49e7-9bc8-8e750b936254"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a27d7dd-56ac-4371-b170-d3032277e5ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("7e53b6f4-4132-44d0-b162-0e31d01b7c24"),
				ConditionExpression = @"IsShowMessageAboutErrorUpdateLicense",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(616, 1042),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2b91918-ade7-478b-9ab7-db5ec92e5140"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("dc2f3da0-43f3-44c3-a7ab-a4a5e108b284"),
				ConditionExpression = @"IsShowMessageAboutErrorUpdateLicense",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(661, 326),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7dd4707-6146-43d6-b35a-bc5ee5d5a311"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow13",
				UId = new Guid("6cf22cf2-38a5-4222-b4e3-0dfd26a4b4cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(676, 374),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d7dd4707-6146-43d6-b35a-bc5ee5d5a311"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("82dc1377-cc25-46aa-8f56-4c708d435d10"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("1038860b-c686-43eb-89a8-61dead6849f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(526, 1255),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a27d7dd-56ac-4371-b170-d3032277e5ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f2b91918-ade7-478b-9ab7-db5ec92e5140"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow16",
				UId = new Guid("72aaf2ed-399c-44a1-bbd5-f131f3a79ef0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CurveCenterPosition = new Point(696, 1237),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2b91918-ade7-478b-9ab7-db5ec92e5140"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f978323-af86-4ec4-bf5c-6e02320c71f5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet255LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet255 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ecfa2152-d4a4-44a0-84d7-838ddd7d311d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LaneSet255",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1311, 235),
				UseBackgroundMode = false
			};
			return schemaLaneSet255;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ecfa2152-d4a4-44a0-84d7-838ddd7d311d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1282, 235),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(542, 205),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUserPasswordEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4631c771-d2df-46c6-9606-71a494cd550d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UserPasswordEditChange",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"UserPasswordEditChange_StartMessage",
				Position = new Point(42, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangePasswordExpiryDateScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52590e01-3d9c-416a-92d4-90e06aef8649"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ChangePasswordExpiryDateScriptTask",
				Position = new Point(147, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,75,195,48,20,125,118,176,255,16,251,212,130,20,223,199,132,186,150,81,196,58,182,78,159,99,123,221,162,46,25,247,222,216,138,248,223,77,182,22,68,97,235,83,224,124,229,112,18,245,34,194,133,36,106,12,214,169,69,201,202,104,113,35,174,35,241,53,30,93,44,228,6,226,158,206,218,189,66,72,37,67,86,43,142,87,150,246,160,235,228,85,182,217,7,104,166,48,154,156,177,60,202,119,11,98,42,60,80,170,29,196,107,174,10,211,196,73,93,167,242,147,254,21,137,98,175,60,151,186,4,178,59,248,211,227,123,60,202,169,55,204,182,82,111,252,197,140,214,199,173,182,166,185,7,34,23,154,60,27,203,25,162,193,94,236,100,151,115,224,95,110,131,8,21,135,14,236,161,48,186,18,135,74,107,2,156,25,173,29,239,251,186,108,229,6,61,153,127,92,246,164,164,148,244,22,251,124,215,197,31,147,65,134,142,45,161,229,131,175,27,203,235,58,106,88,78,94,185,47,48,21,193,83,178,44,242,98,30,12,115,221,90,102,163,201,27,31,238,130,227,11,32,176,69,125,92,253,7,32,23,62,95,105,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowMessageAboutErrorPasswordTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e29bd445-c587-468a-ad35-a9b754ac0094"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ShowMessageAboutErrorPasswordTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(399, 35),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowMessageAboutErrorPasswordTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("566a54df-5a1d-4a51-8b84-09eb805e9359"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(413, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("9c2e4ae7-2bd0-403a-b5ee-c123a6807b77"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a4a7d04-c15e-4d52-b1f3-8b773802fa65"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f5d06a03-ac3b-4e5b-ba04-f3c891d9068e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 247),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(293, 233),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1640dcd3-4dc5-455c-94e1-addb7a4193d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5d06a03-ac3b-4e5b-ba04-f3c891d9068e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ActiveCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"StartMessage1",
				Position = new Point(15, 91),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActiveCheckBoxCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5084ebf5-a06b-46b8-94e2-92bb2c2d8bb0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5d06a03-ac3b-4e5b-ba04-f3c891d9068e"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ActiveCheckBoxCheckScriptTask",
				Position = new Point(147, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,203,106,195,48,16,60,203,95,177,71,135,128,232,93,237,33,53,165,24,92,8,180,161,135,144,195,218,94,39,34,174,4,146,108,26,138,255,189,107,199,143,180,80,232,65,104,217,153,157,153,149,90,116,128,69,208,45,37,39,42,206,84,194,3,108,241,72,114,179,52,31,237,167,28,81,21,85,214,65,172,77,0,205,204,59,197,215,61,196,175,23,191,197,226,204,115,105,233,1,61,60,55,186,220,31,86,50,35,115,12,39,102,173,215,43,248,138,68,219,219,181,168,107,204,107,98,129,155,201,205,212,30,4,114,107,107,22,216,235,131,138,132,174,32,158,167,6,29,241,70,206,161,183,85,144,187,84,190,83,158,88,19,156,173,189,92,138,49,58,20,99,193,66,98,170,167,45,51,93,144,241,52,14,101,120,177,77,144,105,160,15,207,206,125,142,255,251,40,33,216,96,136,122,251,158,215,184,179,177,124,50,253,18,253,51,39,104,94,208,112,10,14,177,243,228,188,250,65,92,254,35,184,134,122,172,227,67,181,167,95,138,11,177,66,70,213,31,118,51,200,50,157,136,186,200,81,104,156,185,170,127,3,55,60,229,6,7,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcess3",
				Position = new Point(344, 247),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(606, 237),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d3b6560a-2289-48ca-b52b-6a38da5268c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"StartMessage3",
				Position = new Point(28, 89),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildDataSourceSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8e2b6dd5-0744-4225-a88d-d21965892058"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ChildDataSourceSavedScriptTask",
				Position = new Point(119, 77),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,207,10,130,64,16,135,207,10,190,131,121,210,139,47,32,29,12,34,150,202,162,140,206,86,179,38,217,110,236,204,98,17,189,123,235,159,67,5,81,194,194,192,206,124,223,252,96,24,174,143,178,154,3,98,150,67,188,147,154,198,74,73,181,185,28,50,130,89,177,7,129,224,14,93,158,149,8,145,99,23,220,245,25,38,80,5,238,221,177,173,183,177,6,236,76,6,121,235,49,193,165,31,24,129,85,112,127,128,164,10,145,135,70,164,203,114,161,198,231,11,221,252,175,174,160,221,101,253,14,154,102,120,10,151,237,250,186,68,61,176,110,36,133,43,125,134,127,13,211,71,201,246,82,24,151,183,141,87,9,75,38,94,31,118,164,137,164,192,26,95,76,91,146,253,119,42,82,186,73,249,112,108,243,20,144,86,162,253,124,2,120,52,84,53,236,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDataSourceSavedIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("82dc1377-cc25-46aa-8f56-4c708d435d10"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"DataSourceSavedIntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(364, 138),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetCurrentUserPasswordExpiredDate_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0adc952e-ca4f-4349-a4db-65f8e08a74b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"SetCurrentUserPasswordExpiredDate_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(490, 124),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,202,177,10,194,48,20,5,208,217,64,255,33,116,74,150,252,64,233,32,17,196,165,72,69,247,80,110,106,160,125,129,151,23,29,196,127,215,110,226,122,56,41,106,99,138,112,162,217,158,195,12,119,8,18,46,185,242,4,183,159,36,61,48,230,167,59,66,124,94,234,74,183,176,84,152,118,8,43,90,171,251,94,95,11,216,103,34,124,111,38,231,43,51,72,54,117,91,178,250,213,168,221,95,26,17,25,229,254,115,79,20,179,177,93,163,222,141,98,72,101,210,194,21,221,7,198,24,227,83,158,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowMessageAboutErrorUpdateLicenseTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6c112a57-a2bb-45a0-8865-4fcd22ef952a"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ShowMessageAboutErrorUpdateLicenseTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(343, 21),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowMessageAboutErrorUpdateLicenseTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d7dd4707-6146-43d6-b35a-bc5ee5d5a311"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f0c26215-90d5-4cde-947c-472ab1845164"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ExclusiveGateway4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(231, 75),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateLDAPEntryButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaLDAPEntryButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c6efe590-c038-4ad0-8b35-bddf630cc2a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LDAPEntryButtonClickEventSubProcess",
				Position = new Point(35, 517),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(294, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaLDAPEntryButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLDAPEntryButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("21714f1e-99db-45ea-adf1-aa5891992677"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6efe590-c038-4ad0-8b35-bddf630cc2a5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LDAPEntryButtonClick",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LDAPEntryButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLDAPEntryButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("56589da2-3258-4a20-bd68-80bcdd81ef00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6efe590-c038-4ad0-8b35-bddf630cc2a5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptLDAPEntryButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,65,11,130,64,16,133,239,254,10,241,84,135,13,73,197,68,58,152,133,8,70,30,242,7,172,187,99,136,178,198,236,110,17,209,127,111,85,186,230,109,102,222,247,222,155,226,152,148,39,161,240,117,208,74,13,34,237,91,214,85,18,240,74,101,183,73,251,65,194,25,164,164,55,176,247,182,83,24,120,20,101,134,45,47,205,113,2,156,216,42,254,165,92,238,32,0,115,33,21,21,12,114,110,146,126,75,149,243,5,179,25,82,141,8,66,37,76,181,15,40,231,87,20,106,88,112,142,100,53,181,9,120,218,153,110,249,202,121,215,44,136,60,26,70,196,243,107,32,126,227,110,73,29,64,68,2,234,54,77,224,71,187,176,97,31,103,29,91,8,74,163,152,123,190,192,47,24,11,36,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateLDAPEntryButtonClickUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8975654d-caae-4d98-a070-a78e3b1b0f91"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6efe590-c038-4ad0-8b35-bddf630cc2a5"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LDAPEntryButtonClickUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(183, 37),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeLDAPEntryButtonClickUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3d504a60-b47e-4fd4-b467-276c91c7a665"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(337, 512),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLDAPUsersGridPageCloseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("db2406d9-7cd3-4c5f-aa6d-79814442a92a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d504a60-b47e-4fd4-b467-276c91c7a665"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LDAPUsersGridPageClose",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LDAPUsersGridPageClose",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLDAPUsersGridPageCloseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9fd8b58e-b039-4b77-bdf0-a3a30a85bd27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d504a60-b47e-4fd4-b467-276c91c7a665"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptLDAPUsersGridPageClose",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,193,170,194,48,16,69,215,10,254,67,236,170,162,228,7,196,133,84,23,5,17,177,234,230,225,34,180,163,20,210,137,76,147,138,136,255,238,196,215,247,90,17,68,183,51,231,76,238,77,165,72,148,80,150,185,193,153,178,74,76,196,182,4,138,12,34,164,150,135,50,105,150,227,94,183,98,60,117,68,128,214,115,113,246,42,68,205,90,198,153,220,152,196,82,142,199,112,80,235,138,177,10,214,230,204,234,74,29,65,250,211,137,113,148,130,156,254,237,106,86,103,234,52,71,75,23,102,91,41,127,158,35,12,69,176,152,77,87,15,48,216,179,154,31,68,216,168,253,137,64,167,245,64,92,123,221,206,255,235,92,204,70,70,187,2,119,74,59,8,91,39,70,205,187,62,244,27,103,169,10,120,193,91,65,229,26,10,83,65,248,38,175,87,110,191,145,63,107,24,103,193,254,235,78,44,141,62,252,65,127,255,251,30,108,213,77,8,172,35,20,150,28,240,224,14,19,95,109,235,96,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("626a318a-eede-46a3-952c-622b97c75796"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcess4",
				Position = new Point(35, 699),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(244, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLDAPEntryEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec9f0a8f-bdbc-4a1c-968a-af98e9b51788"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("626a318a-eede-46a3-952c-622b97c75796"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LDAPEntryEditChange",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"LDAPEntryEditChange",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLDAPEntryEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4b40ff71-82df-47fe-843a-d3bfc86bf9a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("626a318a-eede-46a3-952c-622b97c75796"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptLDAPEntryEditChange",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,75,204,77,117,77,201,44,209,11,73,173,40,81,176,85,8,0,9,250,184,56,6,184,230,149,20,85,194,101,172,121,185,124,82,18,11,192,130,206,25,137,121,233,169,41,64,197,37,69,165,169,64,153,162,212,146,210,162,60,8,15,0,227,69,97,248,85,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessSynchronizeWithLDAPCheckBoxCheckEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessSynchronizeWithLDAPCheckBoxCheck = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ff731d48-92ee-41b2-846d-20bedeff5c62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcessSynchronizeWithLDAPCheckBoxCheck",
				Position = new Point(309, 705),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessSynchronizeWithLDAPCheckBoxCheck;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSynchronizeWithLDAPCheckBoxCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b0e68c3-ebb7-48ef-a21a-4e9489061e44"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff731d48-92ee-41b2-846d-20bedeff5c62"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SynchronizeWithLDAPCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"SynchronizeWithLDAPCheckBoxCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSynchronizeWithLDAPCheckBoxCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2e53746c-126d-42a4-a93a-e2455ce11432"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff731d48-92ee-41b2-846d-20bedeff5c62"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptSynchronizeWithLDAPCheckBoxCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,208,203,10,194,64,12,5,208,181,253,138,161,171,22,164,63,80,21,68,139,8,34,197,250,88,199,26,235,192,116,70,50,153,150,42,254,187,47,124,44,68,208,117,114,184,55,201,144,39,195,126,154,104,166,38,209,176,86,24,132,177,87,1,9,200,89,86,56,51,181,232,138,20,10,140,134,192,144,25,71,57,70,253,199,44,246,228,86,4,207,213,104,132,60,111,246,184,25,24,229,74,189,4,229,176,179,54,70,245,2,63,107,116,190,35,163,229,1,87,146,119,215,84,63,12,197,209,107,189,120,134,252,38,3,255,158,227,183,5,147,195,75,175,147,64,101,241,187,153,66,121,21,150,73,234,34,74,202,61,55,23,249,5,44,44,82,10,214,214,134,54,63,193,231,227,254,83,227,15,105,39,143,144,29,233,219,193,241,25,117,20,93,25,157,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteChildEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteChildEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6b3b8dab-cb6c-4010-b63f-6a16a3467516"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"PageLoadCompleteChildEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 866),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(285, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteChildEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("60f73c99-5599-453e-9bb3-50dc8ee9f0cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b3b8dab-cb6c-4010-b63f-6a16a3467516"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"PageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("347fb6a8-68d8-4d73-9beb-878ced11f472"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b3b8dab-cb6c-4010-b63f-6a16a3467516"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"PageLoadCompleteParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e91a01e8-712b-45a3-9071-77af5cd62bbb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b3b8dab-cb6c-4010-b63f-6a16a3467516"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptPageLoadCompleteChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(175, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,193,78,227,48,16,61,83,169,255,224,230,128,28,9,69,220,187,32,117,67,65,145,88,182,187,45,112,64,28,220,100,10,222,117,237,174,237,0,17,240,239,107,123,146,54,73,187,135,149,42,53,26,207,188,121,239,205,216,115,176,215,23,147,217,84,90,93,77,37,91,10,160,241,120,56,152,99,56,85,46,174,132,185,227,134,47,185,224,182,10,167,124,69,232,40,51,55,240,74,142,143,201,104,198,158,32,185,96,150,205,85,169,115,72,38,185,229,47,240,83,189,38,87,96,23,213,6,138,84,137,114,45,239,152,40,225,203,82,41,113,78,35,76,138,226,152,188,15,7,71,43,165,129,229,207,132,190,48,77,242,103,200,127,127,85,111,153,133,53,225,146,4,252,107,158,131,52,80,51,186,102,149,42,109,226,51,12,34,28,181,43,201,89,23,132,25,178,0,173,153,81,43,155,220,102,201,61,44,27,105,201,238,163,174,24,123,180,166,28,163,80,56,196,21,19,6,186,135,232,88,231,240,115,56,112,191,225,32,208,81,82,130,211,169,164,119,193,101,221,26,208,233,54,152,204,193,24,247,239,173,123,136,210,82,107,144,246,82,137,162,157,228,43,163,199,218,244,224,57,234,253,183,233,110,118,45,191,105,212,195,58,233,209,242,3,13,230,193,122,35,84,5,144,21,223,151,191,28,217,208,193,77,112,198,52,91,131,5,93,227,77,183,121,81,168,245,196,186,181,163,51,34,75,33,218,131,113,38,179,220,102,222,42,233,214,230,170,228,69,183,40,89,168,185,213,92,62,209,56,160,254,159,64,4,71,109,248,141,32,65,151,180,110,113,231,110,104,107,246,141,73,7,171,247,71,225,116,118,50,156,204,253,178,40,246,155,116,224,96,220,211,137,135,63,74,208,85,45,184,93,20,226,244,0,173,19,210,104,65,103,143,246,225,146,73,81,223,38,26,221,184,177,68,113,191,119,86,92,114,97,131,198,3,229,169,187,103,22,48,227,158,219,231,237,112,13,197,96,170,214,27,166,185,193,229,72,166,127,74,38,28,175,67,230,30,128,71,12,227,89,210,30,159,61,162,230,48,67,55,9,52,203,201,20,56,29,218,29,22,34,249,181,107,144,220,37,46,165,37,231,228,180,222,185,118,31,111,211,174,149,121,56,125,244,61,58,27,132,78,182,86,48,116,192,21,108,214,125,90,112,235,87,47,148,76,100,177,128,55,187,211,120,210,238,134,229,159,173,215,192,63,122,132,155,43,144,160,153,240,114,144,81,231,121,192,91,67,62,62,122,39,56,4,67,41,151,54,246,181,33,88,99,249,94,251,60,119,15,19,62,211,14,51,51,169,218,84,254,107,212,33,210,212,207,152,49,175,74,23,211,183,13,215,224,46,94,31,137,54,25,23,165,102,158,91,240,123,236,229,105,176,165,150,196,234,18,198,127,1,10,230,83,89,82,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f39535e4-c6b2-4ac3-846d-d8f735862936"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 866),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(319, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3a57fdf9-0687-46e9-87e4-1d26295ecdf3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f39535e4-c6b2-4ac3-846d-d8f735862936"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d221b095-1cc6-4ee3-9ff6-56e5e4199960"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f39535e4-c6b2-4ac3-846d-d8f735862936"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_InitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2458abe9-9601-4c91-bb8f-99637e33dacd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f39535e4-c6b2-4ac3-846d-d8f735862936"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"Child_InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(210, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,209,78,194,48,20,125,150,132,127,168,123,32,91,36,139,239,132,7,25,19,150,160,18,135,190,215,237,138,133,209,98,123,43,91,140,255,238,237,10,6,197,152,248,212,230,158,211,115,206,61,21,207,44,60,79,107,140,51,115,181,226,245,61,188,90,48,24,177,247,110,231,44,225,242,134,75,190,132,153,40,30,12,104,195,134,204,157,137,146,18,10,20,74,198,227,81,14,133,213,2,155,84,46,133,132,120,2,72,207,210,154,166,8,119,91,208,220,241,194,224,68,43,136,6,221,206,71,183,147,104,224,8,185,170,172,35,38,47,80,172,71,170,6,19,58,124,78,15,226,116,179,173,84,3,144,150,2,227,185,134,45,215,48,83,106,109,183,215,162,66,208,236,98,200,246,227,99,170,7,73,100,47,51,85,27,112,151,191,100,142,57,191,80,90,49,225,26,203,204,45,236,88,175,199,90,105,90,122,206,53,223,0,113,30,121,101,33,12,238,161,80,186,204,202,32,138,23,42,71,45,228,50,140,216,240,164,192,196,106,13,18,221,52,206,202,35,174,255,130,86,62,111,76,98,43,180,218,103,159,138,178,4,73,127,129,218,130,47,209,173,104,204,142,28,199,214,55,78,240,37,97,234,105,69,70,236,205,133,26,248,236,164,150,3,34,153,152,120,161,27,202,238,35,127,15,214,103,193,79,201,160,207,148,221,107,125,197,59,113,13,133,196,232,224,71,209,14,69,16,36,169,178,137,21,101,248,175,210,162,182,117,13,180,191,244,43,127,2,18,5,219,155,180,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a95d446-ed69-4943-b9e1-76cd50b9f080"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"SubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 1080),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1232, 233),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickChildStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b1b560d-7996-4251-8860-f54e1a06897d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"OKButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowScriptOKButtonClickChildIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2f978323-af86-4ec4-bf5c-6e02320c71f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ThrowScriptOKButtonClickChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(609, 140),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOKButtonClickChild2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6a27d7dd-56ac-4371-b170-d3032277e5ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptOKButtonClickChild2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(385, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,221,10,130,64,16,133,175,21,124,7,243,74,111,122,1,233,162,64,98,169,52,250,161,107,179,217,146,108,87,118,102,177,136,222,189,85,11,52,16,130,133,25,102,190,115,230,176,12,183,23,89,173,0,49,61,195,244,40,53,69,74,73,181,47,79,41,193,50,207,64,32,184,19,151,167,5,66,232,216,57,119,253,17,195,24,170,192,125,58,182,213,227,26,229,199,202,104,122,59,38,184,244,3,227,96,229,220,31,33,169,92,156,199,198,72,23,69,162,162,91,73,15,127,208,43,104,111,89,117,210,238,124,151,226,117,188,110,143,213,37,28,132,190,61,220,233,55,88,151,29,54,96,153,20,70,233,29,166,155,152,197,115,111,152,156,105,34,41,176,134,147,69,203,177,255,254,152,148,110,18,188,28,219,60,5,164,149,104,135,111,3,10,201,242,165,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3b8bc85-776d-4164-9c44-96744c3d7775"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,207,74,195,64,16,135,207,6,242,14,99,78,9,72,30,192,32,210,198,80,130,244,15,214,226,121,77,167,201,82,157,149,153,9,173,136,239,238,110,107,160,30,226,105,103,191,249,230,55,179,17,228,210,17,97,163,214,81,254,48,93,99,211,179,213,207,138,90,75,152,151,29,54,251,210,80,117,244,92,113,249,129,108,130,153,38,30,206,13,153,22,39,219,119,75,86,244,220,72,178,34,142,214,157,59,204,81,36,116,95,93,175,21,179,227,149,17,57,56,222,194,29,212,50,124,202,206,80,139,112,15,215,51,212,11,236,152,253,73,169,135,3,74,179,27,88,249,192,124,243,231,228,12,110,97,103,222,4,253,90,187,131,244,223,213,25,124,197,209,85,80,78,248,215,123,54,178,207,67,180,191,44,60,197,152,51,212,120,212,147,122,14,189,212,70,71,235,198,145,159,73,94,38,79,139,122,49,75,70,197,105,175,234,72,130,187,124,12,218,119,28,49,106,207,4,202,61,22,63,214,120,64,100,177,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d5e1def9-c039-49e7-9bc8-8e750b936254"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(392, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateShowErrorMessageTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d191c783-6a58-473c-92b3-142d369159d0"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ShowErrorMessageTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(504, 21),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowErrorMessageTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway5ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f2b91918-ade7-478b-9ab7-db5ec92e5140"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4183f50f-e659-4fed-8ed8-a56f6fa9c09a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7"),
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Name = @"ExclusiveGateway5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(511, 126),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetLDAPEntryEnableMethod());
			Methods.Add(CreateSetLDAPControlsVisibilityMethod());
			Methods.Add(CreateCreateSolutionCheckBoxesMethod());
			Methods.Add(CreateGetAvailableLicensesCountMethod());
			Methods.Add(CreateGetUserHasLicenseMethod());
			Methods.Add(CreateUpdateLicenseInfoMethod());
			Methods.Add(CreatePrepareEmployeeEditFilterMethod());
			Methods.Add(CreateHomePageEditPrepareLookupFilterMethod());
			Methods.Add(CreateGetIsPasswordCorrectMethod());
			Methods.Add(CreateGetPasswordMethod());
			Methods.Add(CreateValidateCanChangeRecordMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ffc4fdf3-0955-41ea-99c9-f4421edaf240"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Packages",
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
				UId = new Guid("ad377ff8-eda6-4fe3-99ac-ce28ab22510c"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5ede5064-8dee-4d75-80c8-ea26036275d9"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("39607109-10b6-45b0-a96a-22ab56c68c7f"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c60d22e7-10ed-4e15-8ccd-b4ae26fcb672"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("f795d9c2-dc6a-438b-8300-714f6c49b4e7")
			});
		}

		protected override SchemaMethod CreateAreConditionsCorrectMethod() {
			SchemaMethod method = base.CreateAreConditionsCorrectMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,77,111,219,48,12,61,199,191,130,243,73,6,12,99,247,172,3,50,39,219,122,104,150,45,109,119,86,99,182,209,32,75,169,36,39,48,214,252,247,145,254,72,211,218,57,238,226,15,242,145,122,143,124,218,75,7,104,130,10,245,122,179,197,82,222,72,35,159,208,193,21,172,232,157,221,121,116,185,53,6,55,65,89,147,125,195,240,6,38,226,197,176,54,78,64,122,24,73,76,163,243,224,207,10,93,253,230,236,54,114,5,6,15,48,64,138,17,150,41,196,235,218,207,138,82,153,59,163,66,156,76,163,65,191,108,86,20,185,213,85,105,68,124,93,48,100,208,250,171,210,129,101,106,221,202,132,199,38,224,137,202,176,93,11,246,211,104,79,147,107,129,132,19,23,154,38,195,6,185,67,25,176,77,255,86,97,187,146,78,150,200,61,69,52,233,169,148,59,233,148,183,230,182,222,97,182,120,174,164,38,173,75,194,197,41,56,123,224,69,180,162,238,165,174,80,180,169,132,196,117,212,89,181,104,191,79,193,255,77,115,105,67,207,148,6,61,206,147,55,112,137,229,128,219,143,29,111,195,131,237,222,23,156,209,193,68,2,127,163,9,187,86,62,104,156,43,215,45,179,117,50,199,214,200,11,62,101,178,188,114,142,132,167,175,85,100,245,66,113,174,161,219,159,56,87,13,94,186,250,147,15,78,153,167,20,236,195,31,106,242,89,36,209,177,39,126,230,31,124,31,24,51,18,141,230,125,161,24,185,115,105,47,159,38,36,221,43,67,159,91,199,66,120,171,195,243,136,120,165,53,188,188,12,147,89,110,43,19,24,242,145,87,161,30,65,124,24,107,220,140,179,201,54,172,190,72,143,55,232,61,125,175,164,65,157,125,151,190,251,23,113,46,27,142,228,0,186,135,207,21,91,145,171,39,227,149,180,245,203,149,41,204,66,96,206,214,116,185,20,216,221,39,68,87,74,212,39,199,232,8,168,61,246,139,207,110,183,100,186,92,43,170,95,236,233,33,98,30,230,130,132,113,58,215,214,35,59,179,193,206,101,144,107,91,185,13,102,51,26,204,30,127,217,195,202,169,146,214,124,102,217,20,174,253,18,15,116,218,49,114,24,42,103,96,108,88,211,127,248,29,208,75,72,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,65,79,2,49,16,133,207,146,240,31,198,61,181,137,105,240,42,162,209,21,204,94,144,8,234,193,120,168,236,160,77,118,219,205,180,43,110,144,255,110,119,187,2,146,192,169,135,121,239,125,211,153,81,11,150,216,88,22,78,25,61,252,86,214,89,14,171,110,231,132,208,149,164,251,221,206,186,219,249,146,4,115,147,149,185,30,203,28,97,0,19,249,129,226,78,58,57,53,37,205,81,76,231,159,152,75,49,82,58,157,144,202,37,85,119,202,22,153,172,226,141,139,241,126,8,42,14,8,124,236,212,145,210,31,98,152,23,174,106,213,132,115,67,233,31,242,30,221,68,146,23,59,164,103,153,149,200,162,32,72,210,136,255,115,36,181,167,53,159,14,64,151,89,6,215,160,113,9,247,165,74,89,168,136,153,9,72,198,57,92,52,149,13,252,221,152,12,148,29,123,199,96,147,41,18,219,212,25,135,159,31,136,141,254,66,114,62,229,214,139,81,106,118,168,201,216,20,85,196,235,14,213,2,88,147,26,166,124,100,24,94,243,216,96,219,229,212,171,0,204,44,54,70,181,96,54,76,43,177,99,255,185,7,10,141,109,215,196,3,225,24,98,152,42,231,35,246,49,39,59,156,99,246,253,43,120,52,75,251,218,123,171,7,48,171,10,76,131,184,25,193,101,104,246,106,183,191,134,180,189,175,128,247,177,47,254,138,204,114,219,206,182,210,254,120,100,40,151,142,69,171,222,26,216,234,124,205,163,179,63,251,217,193,243,170,113,97,63,55,182,168,95,144,22,102,72,36,173,89,56,241,148,136,23,124,247,27,117,100,50,43,106,1,23,241,134,220,198,247,127,1,206,245,52,101,46,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetDefValuesMethod() {
			SchemaMethod method = base.CreateGetDefValuesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,207,189,14,130,48,20,5,224,221,167,104,58,225,80,3,104,168,132,56,0,69,226,236,207,98,28,42,92,146,38,88,200,109,209,52,198,119,151,144,168,113,61,231,27,206,185,75,36,53,52,39,217,14,96,200,134,92,165,129,69,9,86,124,50,111,158,204,190,224,76,5,152,10,85,111,85,167,233,101,244,148,254,213,59,35,20,66,101,59,116,133,182,232,38,211,200,214,192,31,219,59,147,214,55,165,143,90,217,131,235,97,98,26,30,164,28,84,237,209,231,138,135,69,204,115,206,162,76,112,38,182,65,192,226,44,76,153,239,7,34,242,139,120,185,206,163,23,29,151,33,216,1,245,239,65,242,6,143,95,217,247,208,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetLDAPEntryEnableMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6ec81433-f915-4d99-9dfe-d3e67f790661"),
				Name = "SetLDAPEntryEnable",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,209,203,138,194,80,12,6,224,189,48,239,208,113,165,155,190,128,51,130,151,226,198,25,74,235,101,29,123,130,61,120,154,104,154,163,212,167,247,130,206,166,197,81,151,129,255,75,126,200,30,36,40,43,202,114,97,178,71,92,90,205,167,227,65,28,124,7,49,172,49,28,131,66,202,94,50,12,7,153,218,61,38,124,8,39,168,179,106,139,102,196,206,23,180,0,231,241,107,197,236,250,157,118,90,95,213,238,246,62,90,215,101,151,41,34,149,106,232,85,153,194,20,53,34,88,57,52,157,134,10,117,22,25,171,111,163,4,119,222,202,63,234,23,10,172,129,207,103,197,189,215,67,48,47,81,98,40,203,3,139,121,237,84,147,124,234,228,95,199,91,250,252,220,166,252,61,62,140,127,152,156,37,76,192,88,190,253,106,148,99,182,121,68,5,213,11,245,78,8,37,196,221,80,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetLDAPControlsVisibilityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bce6fd34-965e-401c-911a-6c0a39048311"),
				Name = "SetLDAPControlsVisibility",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,205,75,76,202,73,77,81,176,85,72,75,204,41,78,181,230,10,72,76,79,213,243,113,113,12,112,206,207,43,41,202,207,241,73,172,204,47,45,209,115,133,171,131,234,128,170,12,174,204,75,206,40,202,207,203,172,74,13,207,44,201,0,107,204,72,77,206,118,202,175,192,169,7,164,200,21,104,120,165,107,74,38,54,147,1,26,141,29,77,152,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateSolutionCheckBoxesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("83f9b180-f06b-4c31-bb8b-dd1a522a150c"),
				Name = "CreateSolutionCheckBoxes",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,79,219,64,16,61,27,137,255,176,248,128,28,65,45,122,14,32,65,20,65,36,138,210,6,202,1,69,213,98,79,96,203,102,55,245,174,41,22,228,191,119,246,195,193,107,59,168,135,196,214,206,155,143,183,243,102,252,66,11,2,66,51,93,205,178,39,88,210,111,84,208,71,40,200,9,185,85,80,140,164,16,144,105,38,69,122,1,58,64,36,241,184,235,22,15,8,85,164,199,48,220,221,185,40,89,126,63,39,170,82,83,154,61,227,225,36,87,120,172,116,193,196,99,96,184,166,75,48,166,7,41,121,96,56,123,161,140,211,7,14,10,235,19,240,151,88,196,209,28,177,108,65,146,189,241,171,78,39,234,236,55,125,253,1,127,74,80,122,64,222,118,119,162,23,228,248,17,68,117,185,93,177,236,18,248,10,10,195,114,147,164,198,39,131,161,15,34,208,181,17,40,29,201,82,104,99,12,72,249,218,44,95,49,15,205,150,154,7,120,230,109,72,63,73,135,90,200,130,36,76,104,194,208,118,52,196,199,49,17,248,56,56,112,76,195,66,238,217,60,44,24,15,12,195,155,106,5,249,72,242,114,41,126,82,94,194,177,41,245,52,137,103,149,194,155,216,248,199,150,119,187,248,109,65,27,241,108,164,134,79,60,72,111,228,204,178,117,119,185,198,223,172,117,101,109,93,68,179,206,165,117,21,130,129,128,43,176,220,219,61,8,19,160,44,157,0,251,251,209,78,134,240,90,152,46,141,105,127,1,153,44,242,73,222,104,112,50,69,151,212,171,45,253,94,66,81,57,162,247,113,141,142,231,134,179,241,103,234,26,221,78,72,242,17,232,196,70,73,199,203,149,174,6,94,198,33,145,61,76,86,114,238,250,219,215,255,0,158,94,129,120,212,79,77,73,132,234,183,213,183,85,50,236,226,204,53,116,175,220,96,163,26,140,243,157,61,159,203,87,127,29,55,80,20,84,201,133,78,111,39,233,29,60,224,124,233,66,114,51,37,245,139,119,112,34,136,106,255,212,231,138,107,123,76,14,130,18,27,234,193,171,94,113,154,161,196,190,196,135,36,254,21,55,78,222,204,73,243,96,237,14,108,178,173,251,193,210,177,124,104,61,120,56,4,32,20,40,59,222,88,88,115,41,4,182,160,85,46,143,141,84,226,122,153,8,166,25,229,188,186,164,185,119,194,80,11,138,114,117,64,91,145,149,132,111,84,20,109,247,195,18,204,206,186,164,202,159,109,52,116,72,194,34,8,177,177,214,142,151,251,239,91,46,110,142,183,112,62,69,113,89,207,77,143,198,194,160,140,120,70,84,184,165,142,46,166,38,69,246,247,73,178,173,244,247,247,79,114,12,90,73,172,0,108,146,79,194,37,110,140,48,233,255,7,190,99,185,126,50,123,31,67,166,83,40,16,174,145,65,242,245,168,91,3,93,153,111,66,71,251,78,247,29,220,84,42,230,241,181,124,207,169,130,150,21,199,114,161,135,117,63,204,250,139,236,226,240,133,251,9,185,162,149,44,117,122,150,231,19,13,203,164,78,85,175,204,245,231,95,185,89,255,23,164,175,247,102,165,253,3,100,155,78,46,249,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAvailableLicensesCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("afed9eb9-bdae-45aa-b9d1-e71ca28e4a69"),
				Name = "GetAvailableLicensesCount",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8ac508dd-112e-4cfd-ac0e-04aa7f3fceb7"),
				Name = "sysLicPackageId",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,93,111,211,48,20,125,238,164,253,7,43,79,169,26,34,158,217,24,26,233,152,42,21,181,168,3,30,16,15,86,114,187,90,36,118,185,118,58,69,136,255,206,181,19,183,73,147,104,72,140,167,42,190,31,231,220,227,227,219,3,71,182,47,49,221,113,13,217,82,164,32,53,232,68,149,210,176,183,236,245,213,229,197,129,18,64,26,97,170,77,186,131,130,127,228,146,63,2,82,244,179,6,76,148,148,144,26,161,100,124,15,166,147,17,6,119,253,178,96,202,184,102,3,129,6,73,87,154,72,212,145,79,37,96,69,56,18,158,58,21,238,60,28,224,20,177,96,227,234,131,41,181,235,181,138,111,179,44,81,121,89,200,48,112,19,6,211,120,133,25,224,251,106,14,58,13,167,87,147,103,170,40,242,80,237,193,181,183,108,165,122,154,155,190,18,73,137,72,244,236,169,85,165,249,156,115,3,15,162,128,208,87,107,195,209,157,126,16,185,113,138,246,193,19,132,99,194,87,97,118,107,142,188,0,250,208,97,125,152,168,98,207,81,104,37,45,179,120,9,90,175,240,238,103,201,115,171,134,71,8,162,154,171,135,206,74,120,97,224,123,151,111,175,96,94,247,62,135,36,136,53,79,127,208,61,45,178,23,196,61,142,234,58,53,8,132,173,219,223,139,204,179,216,122,228,65,83,121,132,60,175,111,50,236,241,139,216,82,61,138,148,231,171,61,32,183,57,27,131,34,53,241,173,204,162,243,27,141,186,58,71,3,26,12,27,181,142,105,107,189,112,219,228,77,218,15,68,15,106,71,94,171,71,106,77,208,181,166,151,33,175,141,76,93,106,221,156,148,107,130,84,146,231,148,179,85,200,66,65,59,64,184,45,64,63,215,30,57,118,79,135,142,102,179,41,251,117,121,49,25,217,30,51,207,80,127,19,223,45,53,139,209,188,164,47,60,47,225,154,250,223,28,95,34,129,78,78,172,158,169,60,145,190,233,62,202,223,109,145,236,232,255,186,73,108,143,214,54,57,107,217,222,13,139,204,231,141,217,252,188,248,63,90,125,24,176,109,171,97,43,118,197,211,163,212,255,206,105,8,166,68,121,50,91,199,109,118,56,160,22,226,0,236,221,216,95,208,155,177,192,171,54,205,198,146,127,0,173,49,132,220,203,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetUserHasLicenseMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9615f81f-9646-484c-8937-c09135cf8e24"),
				Name = "GetUserHasLicense",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("918e9313-d9c4-4319-8b82-4117ffe78c1f"),
				Name = "sysUserId",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c919e513-4359-4b95-bbed-8bde8094a50f"),
				Name = "sysLicPackageId",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,82,221,75,195,48,16,127,86,240,127,8,125,74,161,20,223,135,194,40,83,6,19,39,117,248,124,164,183,45,152,38,53,31,147,254,247,38,205,102,87,205,30,247,152,220,239,126,31,119,119,0,77,80,90,110,251,154,237,177,133,23,144,176,67,77,30,200,198,160,174,148,148,200,44,87,178,124,70,59,65,208,108,241,191,45,203,9,24,146,40,204,238,110,15,94,201,244,102,197,89,96,142,213,55,135,186,247,90,18,191,39,93,195,63,77,248,42,72,86,255,114,100,185,167,77,82,150,243,166,169,148,112,173,164,217,178,25,112,65,222,121,212,178,121,226,194,14,9,211,173,149,70,176,24,65,31,220,238,215,160,161,69,255,48,52,126,86,170,237,64,115,163,228,123,223,97,185,248,114,32,162,175,193,84,17,120,55,131,82,62,198,94,3,251,244,1,174,169,238,217,142,42,209,195,248,30,157,108,79,234,201,137,159,20,132,136,75,167,73,143,5,89,169,29,103,32,94,59,212,16,112,181,213,156,217,114,46,155,98,50,227,34,145,252,242,206,98,221,132,221,209,237,17,123,243,247,110,204,197,201,249,3,141,129,206,252,79,111,56,72,107,180,78,203,115,194,178,82,78,90,242,72,238,103,63,139,231,181,159,13,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateLicenseInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("20cc4ec0-f651-4580-9e03-ce6faf2c92a0"),
				Name = "UpdateLicenseInfo",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,219,78,219,64,16,125,54,18,255,176,248,1,217,18,93,245,177,18,13,82,8,1,34,5,148,18,40,143,213,218,158,16,139,245,110,186,187,14,164,21,255,222,217,139,147,56,49,81,165,40,55,207,156,51,123,230,204,236,146,41,82,107,80,163,130,244,200,132,189,0,189,98,134,77,101,173,114,160,253,220,148,75,120,144,111,19,85,86,76,173,6,146,215,149,248,201,120,13,231,199,71,67,97,74,99,255,227,128,113,82,16,182,100,37,103,25,135,9,203,95,17,74,35,164,168,57,199,216,37,210,232,204,254,134,55,50,53,170,20,47,151,117,201,11,80,73,138,143,103,82,1,203,231,36,177,113,249,28,242,215,75,249,62,50,80,145,82,248,170,198,101,14,66,195,64,10,163,36,31,179,149,172,13,181,17,58,37,127,143,143,162,237,68,164,105,97,48,77,30,65,41,166,229,204,208,167,17,125,134,44,224,104,186,249,18,50,206,3,152,94,233,112,12,39,141,173,251,166,46,139,164,65,166,247,172,2,58,173,51,237,78,147,124,75,233,3,44,56,203,33,137,127,197,103,36,254,18,167,105,3,102,21,190,101,58,28,2,225,110,192,60,181,254,75,124,19,206,90,188,46,191,156,145,13,169,171,18,10,114,122,74,78,218,160,94,6,140,78,58,218,208,179,109,8,17,81,87,155,108,49,40,133,240,157,180,106,223,2,95,128,162,88,104,127,55,222,181,44,138,62,236,91,38,37,39,115,166,135,74,73,101,145,102,140,107,112,207,215,77,245,70,33,101,232,231,30,127,83,152,213,215,158,31,217,183,165,183,121,182,142,199,213,2,138,45,11,126,183,241,23,73,60,109,103,196,190,58,167,219,14,88,175,215,82,55,208,70,30,192,194,147,230,243,0,235,38,26,185,195,183,134,211,145,174,49,122,100,19,75,39,160,180,20,140,219,214,249,216,232,83,138,82,24,196,110,50,16,97,32,107,97,226,148,92,28,168,203,39,133,200,52,28,45,218,110,141,81,53,132,58,35,157,209,254,98,1,162,24,205,238,165,25,86,11,179,74,172,107,211,189,128,228,83,70,239,124,223,129,160,170,29,138,224,251,40,56,196,191,127,120,115,146,228,100,93,81,168,209,206,7,56,135,76,209,230,21,187,99,2,129,212,190,41,177,132,86,68,18,15,247,211,80,36,28,247,142,7,231,107,50,111,10,11,142,28,29,204,150,104,36,180,97,34,135,203,149,61,81,227,49,155,19,167,116,128,190,54,224,57,146,118,145,225,228,27,10,58,5,115,5,179,45,217,154,241,217,9,218,138,112,116,79,110,31,96,75,252,98,248,175,156,214,24,116,172,146,131,249,126,217,99,154,181,73,71,56,91,194,214,224,127,132,205,116,210,181,154,58,55,147,149,190,0,14,6,194,58,189,114,63,118,5,164,215,74,86,59,130,63,207,65,181,84,73,233,72,15,127,215,140,39,22,232,71,13,106,53,97,10,59,101,208,22,65,176,148,246,209,188,251,219,225,80,106,75,49,231,36,95,164,59,182,47,158,14,223,33,175,77,208,2,101,192,151,91,53,25,29,131,120,49,115,114,65,190,250,35,43,48,181,18,196,143,9,189,150,170,98,198,177,142,101,206,120,249,199,238,64,127,23,38,241,230,130,194,219,9,7,143,142,37,195,219,49,62,179,43,166,49,230,132,149,197,250,34,196,57,31,190,231,0,5,20,119,160,53,6,196,41,246,60,179,117,97,77,109,114,55,224,231,255,0,81,2,112,58,237,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreatePrepareEmployeeEditFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1dc1fea6-89c8-4c20-9e40-30addc4b5163"),
				Name = "PrepareEmployeeEditFilter",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eaa01e80-1b45-4e19-9d9f-5919dcdfa978"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("714cbf42-4b99-4bf0-81b4-b44ad4322859"),
				Name = "e",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LookupEditEventArgs",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,81,193,78,194,64,20,60,75,194,63,108,122,106,147,166,241,44,106,130,5,12,23,66,130,120,33,28,158,237,107,89,179,221,197,221,183,104,3,253,119,183,45,32,112,81,60,109,51,157,153,204,155,217,128,102,137,146,18,19,226,74,190,148,107,100,15,108,110,80,199,71,48,154,161,49,238,29,0,193,194,139,173,214,40,105,164,68,122,74,170,149,222,178,215,237,108,156,97,198,5,161,54,206,9,163,81,251,237,254,236,209,168,159,166,190,196,79,54,224,141,18,116,121,111,72,115,153,135,76,189,189,59,187,71,182,101,221,206,205,214,75,84,177,6,205,205,222,62,100,173,89,124,6,71,195,15,11,162,10,91,137,192,140,134,95,107,221,70,142,149,176,133,156,2,173,156,216,91,204,74,211,79,11,46,231,146,211,157,203,78,144,208,50,26,167,94,21,54,98,200,115,141,57,28,239,9,89,255,28,153,185,156,9,69,177,178,146,246,26,107,112,192,205,90,64,249,10,194,214,154,12,132,193,67,30,205,243,213,73,160,41,104,40,208,221,208,144,141,99,215,77,180,103,47,150,108,123,91,85,85,224,186,226,153,127,185,202,3,147,86,8,182,219,93,236,213,222,111,124,159,75,10,234,229,26,240,25,37,106,16,65,192,182,46,199,181,213,255,185,251,177,153,40,154,184,92,237,189,87,13,208,79,146,186,199,195,251,51,196,111,173,254,191,214,170,219,193,232,72,54,13,187,41,197,91,241,20,159,44,145,146,181,154,180,197,160,247,13,89,148,43,95,28,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHomePageEditPrepareLookupFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("881cfd06-bb46-403e-829d-d7642dace6e0"),
				Name = "HomePageEditPrepareLookupFilter",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7ace7148-a304-4d9d-9d90-5b2cd242cc4b"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3e3aa8cb-dad1-41c8-afa7-65a431026d30"),
				Name = "e",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "LookupEditEventArgs",
				CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,144,189,78,195,48,20,133,103,42,245,29,172,76,84,138,44,102,10,72,37,165,40,3,85,165,0,75,213,225,18,223,36,70,142,29,249,7,136,162,188,59,142,19,10,29,144,88,216,174,143,125,174,191,115,222,64,147,130,11,139,218,144,107,130,116,51,206,203,249,108,82,233,138,177,115,137,239,100,205,115,203,149,4,221,94,25,171,185,44,99,162,94,94,49,183,55,164,35,243,217,89,23,229,170,110,64,115,163,228,99,219,96,20,147,113,89,114,34,211,123,141,224,213,62,30,77,2,11,123,247,209,104,52,198,111,79,148,112,181,220,129,173,188,61,218,103,173,121,80,204,9,76,229,113,220,40,193,80,95,30,207,7,154,178,168,143,195,50,40,75,141,37,12,156,19,194,234,84,201,60,121,110,105,162,156,180,147,199,25,92,115,211,8,104,159,65,184,193,83,128,48,248,197,167,121,89,253,0,220,129,134,26,61,127,120,108,252,235,161,155,177,136,253,129,116,23,125,223,47,254,177,189,212,108,149,221,58,33,254,210,95,134,225,211,177,167,44,175,176,134,167,239,178,126,11,30,248,145,30,147,154,112,29,146,68,21,103,120,235,172,85,114,136,110,181,195,197,242,19,174,247,147,130,67,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsPasswordCorrectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dc10f33b-f61c-4f9f-9b7e-6eea2f5353d5"),
				Name = "GetIsPasswordCorrect",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e01345c5-f684-4d36-8e41-e716fad29b5f"),
				Name = "password",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("112822a0-973a-4416-8e89-431c844296a9"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				ModifiedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,193,138,2,49,12,134,207,14,204,59,100,111,35,72,95,64,60,13,138,30,92,22,22,189,199,26,199,66,167,149,36,101,71,196,119,119,186,86,193,75,105,147,63,255,255,165,238,4,205,215,70,126,80,228,47,242,177,61,99,232,104,10,183,186,154,48,105,226,0,202,137,230,117,117,175,43,81,118,161,131,36,196,223,216,19,44,254,175,109,12,129,172,186,24,76,155,152,41,232,110,172,154,172,24,199,14,49,122,96,146,228,117,212,23,47,229,107,14,184,148,80,179,71,239,142,168,244,162,104,62,125,103,239,200,105,6,1,139,106,207,208,252,146,77,236,244,186,28,44,93,178,14,104,120,146,191,124,150,204,145,183,36,130,93,166,165,193,148,135,89,69,238,81,199,115,173,189,111,178,237,228,13,121,66,47,101,227,242,5,207,214,252,1,143,21,137,169,44,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPasswordMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e6bdd039-87af-4ce7-8500-527c2466d0c3"),
				Name = "GetPassword",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,72,76,79,213,11,45,78,45,10,72,44,46,46,207,47,74,113,77,201,44,209,11,75,204,41,77,213,11,201,15,46,41,202,204,75,215,208,180,6,0,229,50,182,167,46,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateValidateCanChangeRecordMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("42386345-be58-4931-8b7c-b5360c15619f"),
				Name = "ValidateCanChangeRecord",
				CreatedInSchemaUId = new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,208,129,106,2,98,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new UserEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("161bfb4b-ffe2-42c7-bd2d-cd4fd3c4a593"));
		}

		#endregion

	}

	#endregion

}

