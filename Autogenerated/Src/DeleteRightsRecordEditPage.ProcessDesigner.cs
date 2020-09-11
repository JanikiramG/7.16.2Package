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
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: DeleteRightsRecordEditPageSchema

	/// <exclude/>
	public class DeleteRightsRecordEditPageSchema : Terrasoft.UI.WebControls.PageSchema
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _operationsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout OperationsControlLayout {
			get {
				return _operationsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _rightToReadCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox RightToReadCheckBox {
			get {
				return _rightToReadCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _rightToChangeCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox RightToChangeCheckBox {
			get {
				return _rightToChangeCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _rightToRemoveCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox RightToRemoveCheckBox {
			get {
				return _rightToRemoveCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _removeRightsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout RemoveRightsControlLayout {
			get {
				return _removeRightsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _allRolesAndUsersRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton AllRolesAndUsersRadioButton {
			get {
				return _allRolesAndUsersRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _rolesRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton RolesRadioButton {
			get {
				return _rolesRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _rolesParameterValueEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RolesParameterValueEdit {
			get {
				return _rolesParameterValueEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _employeeRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton EmployeeRadioButton {
			get {
				return _employeeRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout7;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return _controlLayout7;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit _employeeParameterValueEdit;
		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EmployeeParameterValueEdit {
			get {
				return _employeeParameterValueEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _employeesRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton EmployeesRadioButton {
			get {
				return _employeesRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout9;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return _controlLayout9;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _contactFilterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit ContactFilterEdit {
			get {
				return _contactFilterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _okButton;
		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return _okButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public DeleteRightsRecordEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public DeleteRightsRecordEditPageSchema(DeleteRightsRecordEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			RealUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			Name = "DeleteRightsRecordEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			Width = 350;
			Height = 450;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDeleteRightsRecordEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateOperationsControlLayout());
			OperationsControlLayout.InsertItem(0, CreateRightToReadCheckBox());
			OperationsControlLayout.InsertItem(1, CreateRightToChangeCheckBox());
			OperationsControlLayout.InsertItem(2, CreateRightToRemoveCheckBox());
			MainControlLayout.InsertItem(1, CreateRemoveRightsControlLayout());
			RemoveRightsControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateAllRolesAndUsersRadioButton());
			RemoveRightsControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateRolesRadioButton());
			ControlLayout2.InsertItem(1, CreateControlLayout5());
			ControlLayout5.InsertItem(0, CreateRolesParameterValueEdit());
			RemoveRightsControlLayout.InsertItem(2, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateEmployeeRadioButton());
			ControlLayout3.InsertItem(1, CreateControlLayout7());
			ControlLayout7.InsertItem(0, CreateEmployeeParameterValueEdit());
			RemoveRightsControlLayout.InsertItem(3, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateEmployeesRadioButton());
			ControlLayout4.InsertItem(1, CreateControlLayout9());
			ControlLayout9.InsertItem(0, CreateContactFilterEdit());
			Controls.AddAt(2, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateSpacer1());
			ButtonsControlLayout.InsertItem(1, CreateOkButton());
			ButtonsControlLayout.InsertItem(2, CreateCancelButton());
			Controls.AddAt(3, CreateEntityDataSource());
			UpdateEntityDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateDeleteRightsRecordEditPageEventsProcessSchema() {
			var schema = new DeleteRightsRecordEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("1e81f73b-0440-4d62-84fe-897874c0ec8a");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_baseMessagePanel.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateRightToReadCheckBox() {
			_rightToReadCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_rightToReadCheckBox.UId = new Guid("900ad61f-59a8-4a76-8e6a-aa747f1ba049");
			_rightToReadCheckBox.Name = "RightToReadCheckBox";
			_rightToReadCheckBox.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rightToReadCheckBox.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rightToReadCheckBox.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_rightToReadCheckBox.Tag = "";
			_rightToReadCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_rightToReadCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _rightToReadCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateRightToChangeCheckBox() {
			_rightToChangeCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_rightToChangeCheckBox.UId = new Guid("dfe4b8c8-fff0-49b7-8928-6bfb555ca359");
			_rightToChangeCheckBox.Name = "RightToChangeCheckBox";
			_rightToChangeCheckBox.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rightToChangeCheckBox.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rightToChangeCheckBox.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_rightToChangeCheckBox.Tag = "";
			_rightToChangeCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_rightToChangeCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _rightToChangeCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateRightToRemoveCheckBox() {
			_rightToRemoveCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_rightToRemoveCheckBox.UId = new Guid("ec3c43e3-6b91-4a87-a158-cce4119134c9");
			_rightToRemoveCheckBox.Name = "RightToRemoveCheckBox";
			_rightToRemoveCheckBox.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rightToRemoveCheckBox.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rightToRemoveCheckBox.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_rightToRemoveCheckBox.Tag = "";
			_rightToRemoveCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_rightToRemoveCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _rightToRemoveCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateOperationsControlLayout() {
			_operationsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_operationsControlLayout.UId = new Guid("b2539d78-d78f-467d-bbe8-73a4d4f24b52");
			_operationsControlLayout.Name = "OperationsControlLayout";
			_operationsControlLayout.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_operationsControlLayout.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_operationsControlLayout.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_operationsControlLayout.Tag = "";
			_operationsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_operationsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_operationsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_operationsControlLayout.FitHeightByContent = true;
			_operationsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_operationsControlLayout.StartNewAlignGroup = false;
			_operationsControlLayout.Image = new ControlImage {};
			_operationsControlLayout.Edges = "";
			return _operationsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAllRolesAndUsersRadioButton() {
			_allRolesAndUsersRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_allRolesAndUsersRadioButton.UId = new Guid("9114b274-ae19-493c-8b99-cdd654d8f86d");
			_allRolesAndUsersRadioButton.Name = "AllRolesAndUsersRadioButton";
			_allRolesAndUsersRadioButton.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_allRolesAndUsersRadioButton.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_allRolesAndUsersRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_allRolesAndUsersRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_allRolesAndUsersRadioButton.Tag = "";
			_allRolesAndUsersRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allRolesAndUsersRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allRolesAndUsersRadioButton.GroupName = "EditValuesGroupName";
			return _allRolesAndUsersRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("7ba8c4fd-5c5d-4538-8126-bacde42e2bb9");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout1.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout1.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateRolesRadioButton() {
			_rolesRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_rolesRadioButton.UId = new Guid("769f8e5f-c45c-474b-8d6e-3e65edce1803");
			_rolesRadioButton.Name = "RolesRadioButton";
			_rolesRadioButton.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rolesRadioButton.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rolesRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_rolesRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_rolesRadioButton.Tag = "";
			_rolesRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_rolesRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_rolesRadioButton.GroupName = "EditValuesGroupName";
			return _rolesRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateRolesParameterValueEdit() {
			_rolesParameterValueEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_rolesParameterValueEdit.UId = new Guid("1f14b31a-1f48-43a5-9fb0-c47e98e519e6");
			_rolesParameterValueEdit.Name = "RolesParameterValueEdit";
			_rolesParameterValueEdit.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rolesParameterValueEdit.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_rolesParameterValueEdit.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_rolesParameterValueEdit.Tag = "";
			_rolesParameterValueEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_rolesParameterValueEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_rolesParameterValueEdit.Image = new ControlImage {};
			_rolesParameterValueEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_rolesParameterValueEdit.Margins = "0 0";
			_rolesParameterValueEdit.Enabled = false;
			return _rolesParameterValueEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("3d1aa511-3ead-4c96-9f24-bd6b0c73d3d9");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout5.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout5.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout5.FitHeightByContent = true;
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.Padding = "0 0 0 15";
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("5d526bb2-50e4-44f2-8051-1bf3aa581260");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout2.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout2.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateEmployeeRadioButton() {
			_employeeRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_employeeRadioButton.UId = new Guid("523ff05b-6943-4e11-82cb-80cf0d14b1c3");
			_employeeRadioButton.Name = "EmployeeRadioButton";
			_employeeRadioButton.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_employeeRadioButton.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_employeeRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_employeeRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_employeeRadioButton.Tag = "";
			_employeeRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_employeeRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_employeeRadioButton.GroupName = "EditValuesGroupName";
			return _employeeRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit CreateEmployeeParameterValueEdit() {
			_employeeParameterValueEdit = new Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit();
			_employeeParameterValueEdit.UId = new Guid("a61283a7-f46b-47f7-9d3d-8b333b842148");
			_employeeParameterValueEdit.Name = "EmployeeParameterValueEdit";
			_employeeParameterValueEdit.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_employeeParameterValueEdit.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_employeeParameterValueEdit.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_employeeParameterValueEdit.Tag = "";
			_employeeParameterValueEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_employeeParameterValueEdit.DataValueTypeUId = new Guid("b295071f-7ea9-4e62-8d1a-919bf3732ff2");
			_employeeParameterValueEdit.Image = new ControlImage {};
			_employeeParameterValueEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_employeeParameterValueEdit.AlignedByCaption = false;
			_employeeParameterValueEdit.Enabled = false;
			return _employeeParameterValueEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout7() {
			_controlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout7.UId = new Guid("99d7daac-6d41-48fb-adb3-0bc60476ee4c");
			_controlLayout7.Name = "ControlLayout7";
			_controlLayout7.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout7.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout7.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout7.Tag = "";
			_controlLayout7.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout7.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout7.FitHeightByContent = true;
			_controlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.Padding = "0 0 0 15";
			_controlLayout7.StartNewAlignGroup = false;
			_controlLayout7.Image = new ControlImage {};
			_controlLayout7.Edges = "";
			return _controlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("6433da0c-9e59-4197-bf05-43f07cd1e9d2");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout3.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout3.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateEmployeesRadioButton() {
			_employeesRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_employeesRadioButton.UId = new Guid("f3ba9bf8-9bca-47f1-a080-66c16daafaca");
			_employeesRadioButton.Name = "EmployeesRadioButton";
			_employeesRadioButton.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_employeesRadioButton.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_employeesRadioButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_employeesRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_employeesRadioButton.Tag = "";
			_employeesRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_employeesRadioButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_employeesRadioButton.GroupName = "EditValuesGroupName";
			return _employeesRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateContactFilterEdit() {
			_contactFilterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_contactFilterEdit.UId = new Guid("d53ab2cc-6c5c-4d07-a119-516d03f2460d");
			_contactFilterEdit.Name = "ContactFilterEdit";
			_contactFilterEdit.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_contactFilterEdit.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_contactFilterEdit.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_contactFilterEdit.Tag = "";
			_contactFilterEdit.DataSourceId = "EntityDataSource";
			_contactFilterEdit.Edges = "1 1 1 1";
			_contactFilterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_contactFilterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _contactFilterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout9() {
			_controlLayout9 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout9.UId = new Guid("630d2679-c8ff-44c4-bd50-3634e3f9d3b9");
			_controlLayout9.Name = "ControlLayout9";
			_controlLayout9.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout9.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout9.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout9.Tag = "";
			_controlLayout9.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout9.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout9.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout9.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout9.Padding = "0 0 0 15";
			_controlLayout9.StartNewAlignGroup = false;
			_controlLayout9.Image = new ControlImage {};
			_controlLayout9.Edges = "";
			return _controlLayout9;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("ee6251f1-3aff-44c0-b58b-3e424f7b53ae");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout4.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_controlLayout4.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateRemoveRightsControlLayout() {
			_removeRightsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_removeRightsControlLayout.UId = new Guid("675cc594-5d79-4d58-b07e-f2cc16e81303");
			_removeRightsControlLayout.Name = "RemoveRightsControlLayout";
			_removeRightsControlLayout.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_removeRightsControlLayout.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_removeRightsControlLayout.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_removeRightsControlLayout.Tag = "";
			_removeRightsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_removeRightsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_removeRightsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_removeRightsControlLayout.StartNewAlignGroup = false;
			_removeRightsControlLayout.Image = new ControlImage {};
			_removeRightsControlLayout.Edges = "0 0 0 0";
			return _removeRightsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("00018856-3809-4696-8825-6ab2e3fca618");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_mainControlLayout.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
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

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("1f9b6f02-9bde-4a6d-8c95-105a50330ff7");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_spacer1.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_spacer1.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("1b70a265-e855-47b4-a3b1-89ae6d04703d");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_okButton.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_okButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("07016c74-d730-4027-9165-77c1d4d8187f");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_cancelButton.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_cancelButton.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("5a1cbcc9-4170-4271-b85b-c765c72907b4");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_buttonsControlLayout.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "1 0 0 0";
			return _buttonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("c31480c5-7dbd-40ae-a3c3-149b5c57ec2b");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_entityDataSource.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_entityDataSource.CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("10f3e22a-2452-4a45-927c-cc08c377207f");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			DataSourceStructureColumn column = null;
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("ece98908-75ef-4160-b6b0-2b2c526a068d");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("a5cca792-47dd-428a-83fb-5c92bdd97ff8");
			if (column != null) {
				column.UId = new Guid("090a15dd-1891-43c1-96b5-8af8f6bab987");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("64fa90dd-0cf5-45d7-88e4-6fa691d3c425");
			if (column != null) {
				column.UId = new Guid("63f6b22c-4c12-4706-bc8e-9255e7ee6b41");
				column.Name = @"Owner";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("2e01ce71-98fe-459a-8a46-e021847e4cb7");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("48d6525f-e70c-42d9-ab33-37b8bdba5cdf");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("6ac9c9da-3a9f-4400-aa35-64d8385e3483");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("0bfed9b4-10a7-49f4-9fb7-969742e25365");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("96ead701-0de9-4865-ada6-91086c0dbc35");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("c5d7c4d3-f308-40d3-8469-6ab6882bd70a");
			if (column != null) {
				column.UId = new Guid("df4820ae-2830-4034-82f3-08a4d064aee7");
				column.Name = @"Dear";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("f16cbd03-a8a8-4bdd-9970-a0c7985a1996");
			if (column != null) {
				column.UId = new Guid("bd326ecb-6bbf-4ec9-86fb-1bd4f43ae815");
				column.Name = @"SalutationType";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("3a3317c0-09f6-4a26-998b-018d1caa2c36");
			if (column != null) {
				column.UId = new Guid("63e492ea-3fd2-4b13-81f1-a2e6afcacb34");
				column.Name = @"Gender";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4");
			if (column != null) {
				column.UId = new Guid("7c793e60-68b8-49ba-a3d5-37249edc8bb5");
				column.Name = @"Account";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("f70c762a-1038-49a7-a3e8-f24fb8cfdeef");
			if (column != null) {
				column.UId = new Guid("051e9ce1-9c10-40f4-8f4f-a440b7c0c936");
				column.Name = @"DecisionRole";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("a49571cc-a9a9-4c3e-a346-46c466e9a0d3");
			if (column != null) {
				column.UId = new Guid("e441ba85-cc78-4b41-9d4b-a2acde9208ed");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("344436e4-9d6b-4a30-936f-f8ea45f2adb4");
			if (column != null) {
				column.UId = new Guid("dd096083-aaa5-4fa9-8d43-b3c3a1e72d43");
				column.Name = @"Job";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("8b680ac7-e46c-466c-b630-e5cb4da13a55");
			if (column != null) {
				column.UId = new Guid("e19f0066-aad3-467e-a70e-e9b81908a61e");
				column.Name = @"JobTitle";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("94cb8750-ad6f-4e80-b553-7d9e194a856e");
			if (column != null) {
				column.UId = new Guid("d0e4c91e-0501-4a70-b8cd-448a032fb757");
				column.Name = @"Department";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("3f08db69-6d2f-4b1c-87a4-acddc6c3b9d6");
			if (column != null) {
				column.UId = new Guid("43a59ed8-6b28-4259-9f14-11411715fb14");
				column.Name = @"BirthDate";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("84c5808a-7859-4198-ba6a-243c95a3300b");
			if (column != null) {
				column.UId = new Guid("688fcbdc-a62d-4fd2-b9a6-784033dc81ea");
				column.Name = @"Phone";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("98e085c7-ad4d-4ac6-8c1c-09be09876d44");
			if (column != null) {
				column.UId = new Guid("c9bbad32-abf1-443a-8201-71f328a3a497");
				column.Name = @"MobilePhone";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("0a455b85-133c-4944-aff1-2ce7f7e50fee");
			if (column != null) {
				column.UId = new Guid("94120fd8-ec46-4725-a4fd-c3d0f2d1ad1d");
				column.Name = @"HomePhone";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("5ff9516e-251c-41de-a085-67fa199cdfe7");
			if (column != null) {
				column.UId = new Guid("31ec9659-ed8e-46c0-8f3e-0291addc41c7");
				column.Name = @"Skype";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("dbf202ec-c444-479b-bcf4-d8e5b1863201");
			if (column != null) {
				column.UId = new Guid("703585b1-0f20-4270-b1af-b9f20c61ee83");
				column.Name = @"Email";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("5ad029c6-0fa7-4db6-8fef-c72a0f535682");
			if (column != null) {
				column.UId = new Guid("6c97d3cb-e52a-420e-845e-082113c24b24");
				column.Name = @"AddressType";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("0fb61bc8-a195-4d90-aecc-18b411b51814");
			if (column != null) {
				column.UId = new Guid("67723f26-23a2-43ed-a0eb-dda03b76a9d1");
				column.Name = @"Address";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("cf58ca72-531b-4dd2-b4d5-f0d5b7c556f6");
			if (column != null) {
				column.UId = new Guid("d15fe6ae-5aae-4f54-9b04-dd8029604432");
				column.Name = @"City";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("0e50f221-470e-482b-8580-f61c74b8b1c1");
			if (column != null) {
				column.UId = new Guid("5eb66212-7d49-451c-9386-6f38f6f499f6");
				column.Name = @"Region";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("0737d99d-eebc-4b8e-9859-634414f7cc04");
			if (column != null) {
				column.UId = new Guid("24f29a9e-fe48-4aa6-b452-4b7ebe3f831a");
				column.Name = @"Zip";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("9463dea9-2576-4d37-812f-342ee57ddf32");
			if (column != null) {
				column.UId = new Guid("c9dd5f1d-ac88-452c-9cdf-41ddd694b9b6");
				column.Name = @"Country";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("1b1d8f33-4d26-4353-a1ed-07e11fc82112");
			if (column != null) {
				column.UId = new Guid("0bca1557-ca2c-4a09-8cf3-eec93187fba4");
				column.Name = @"DoNotUseEmail";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("a6bcf6fe-a06d-42ed-a263-f829ece05fd9");
			if (column != null) {
				column.UId = new Guid("1c2a84b1-b08f-4abc-8529-fec82defca26");
				column.Name = @"DoNotUseCall";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("d9deaed5-8e42-40c0-9bb1-a6bfe6716ca4");
			if (column != null) {
				column.UId = new Guid("f8a12400-475a-42a6-840d-78d6146c8652");
				column.Name = @"DoNotUseFax";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("7e295464-4dee-4448-832c-97434b1f2943");
			if (column != null) {
				column.UId = new Guid("97ec83a1-306b-4f33-8fb4-0ae9b5c5923b");
				column.Name = @"DoNotUseSms";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("238d9e74-ff12-4e40-8467-350bd9d4b58d");
			if (column != null) {
				column.UId = new Guid("1fb5daae-8f5d-4beb-a5ef-2822fa42ad9a");
				column.Name = @"DoNotUseMail";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("fd73da4b-2b3d-483e-89d2-383a6db099ac");
			if (column != null) {
				column.UId = new Guid("5cf52445-a2b6-4c61-a21f-d54c40d65420");
				column.Name = @"Notes";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("5282096d-e4af-470a-bfbc-3e3542f04515");
			if (column != null) {
				column.UId = new Guid("bb130508-00e1-4c40-b7b3-8f967ba3c965");
				column.Name = @"Facebook";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("644a4505-9c9c-477e-8037-b73c14d109df");
			if (column != null) {
				column.UId = new Guid("7603c0cf-ab63-4978-9769-cb6c1d86a970");
				column.Name = @"LinkedIn";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("83239d8b-efb5-4a28-80b7-219bdbd2a752");
			if (column != null) {
				column.UId = new Guid("5d381b9c-6e43-49c5-9aeb-f5ec92fb0abb");
				column.Name = @"Twitter";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("21a16860-9d95-4f60-9c23-66b3392ea5f4");
			if (column != null) {
				column.UId = new Guid("b35e419b-f0cc-4fe2-a23e-96bd48ad5331");
				column.Name = @"FacebookId";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("10ebe04c-3e1e-4606-93a5-dbdfdb230e71");
			if (column != null) {
				column.UId = new Guid("c37e843d-6ac8-4736-a367-c144e4a7a16d");
				column.Name = @"LinkedInId";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("2e96804c-cf03-4ab0-a532-79b032dc4529");
			if (column != null) {
				column.UId = new Guid("74f3cbde-3978-4b1e-8c17-833f2be731e7");
				column.Name = @"TwitterId";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("327e44bd-0b97-48c0-b11a-4686d6605b4f");
			if (column != null) {
				column.UId = new Guid("434518fe-7367-4216-817c-3b0e87eff398");
				column.Name = @"ContactPhoto";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("d1732e56-de5f-4bf6-ac22-228d7f768aa3");
			if (column != null) {
				column.UId = new Guid("f38ccb26-c9c7-4095-aac8-15507e7f2f25");
				column.Name = @"TwitterAFDA";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("3ed551e5-7963-4056-95fb-6b6c871145af");
			if (column != null) {
				column.UId = new Guid("98507ada-0852-46b5-81f5-597a8d825b3d");
				column.Name = @"FacebookAFDA";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("b3cf002a-466c-4ea7-a457-b3630ec24e9d");
			if (column != null) {
				column.UId = new Guid("1fd1f7fa-100b-4591-9955-f8e7d632bc7c");
				column.Name = @"LinkedInAFDA";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("4b5bed64-6c71-46b1-8e84-4e0635a7e26e");
			if (column != null) {
				column.UId = new Guid("a05b0fdb-c3ae-465c-9e60-a6c326e3c392");
				column.Name = @"Photo16";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("ab66370b-e604-4d80-8189-366355a51075");
			if (column != null) {
				column.UId = new Guid("19cc79fe-cf81-4fa9-9183-e5b7a326a229");
				column.Name = @"Photo22";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("94d22bd9-66ca-43bf-a991-87c72d555b26");
			if (column != null) {
				column.UId = new Guid("76dd8209-aed6-485f-982a-35242edcffcc");
				column.Name = @"Photo32";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = _entityDataSource.DefStructure.TryAddColumnByMetaPath("0495373c-5053-4ae3-b553-dc92779c4702");
			if (column != null) {
				column.UId = new Guid("db918291-9d6f-46b2-a0cc-4bd26dab4192");
				column.Name = @"Photo";
				column.CreatedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.ModifiedInSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
				column.CreatedInPackageId = Guid.Empty;
			}
			return _entityDataSource;
		}

		protected virtual void UpdateEntityDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new DeleteRightsRecordEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new DeleteRightsRecordEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DeleteRightsRecordEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: DeleteRightsRecordEditPageEventsProcess

	/// <exclude/>
	public class DeleteRightsRecordEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.DeleteRightsRecordEditPageSchemaUserControl
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

		public DeleteRightsRecordEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeleteRightsRecordEditPageEventsProcess";
			SchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
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

		public virtual string ContextKey {
			get;
			set;
		}

		public virtual string ItemId {
			get;
			set;
		}

		public virtual Guid EditSchemaUId {
			get;
			set;
		}

		public virtual bool IsProcessSchemaExplorerCreated {
			get;
			set;
		}

		public virtual bool IsProcessSchemaExplorerRegistered {
			get;
			set;
		}

		public virtual Object ProcessSchemaExplorer {
			get;
			set;
		}

		public virtual Guid EditElementUId {
			get;
			set;
		}

		public virtual Guid LookupTypeUId {
			get;
			set;
		}

		public virtual Guid GuidTypeUId {
			get;
			set;
		}

		public virtual bool IsValidData {
			get;
			set;
		}

		public virtual Guid SysAdminUnitSchemaUId {
			get;
			set;
		}

		public virtual Guid ContactSchemaUId {
			get;
			set;
		}

		public virtual bool IsInitializedParameterValueEdit {
			get;
			set;
		}

		public virtual Object Messages {
			get;
			set;
		}

		public virtual Object IncludedDataValueTypesMap {
			get;
			set;
		}

		public virtual string EditSchemaManagerName {
			get;
			set;
		}

		private ProcessFlowElement _cancelButtonClickEventSubProcess;
		public ProcessFlowElement CancelButtonClickEventSubProcess {
			get {
				return _cancelButtonClickEventSubProcess ?? (_cancelButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CancelButtonClickEventSubProcess",
					SchemaElementUId = new Guid("92e38030-7540-44bb-8310-873060a2b92a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickStartMessage;
		public ProcessFlowElement CancelButtonClickStartMessage {
			get {
				return _cancelButtonClickStartMessage ?? (_cancelButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClickStartMessage",
					SchemaElementUId = new Guid("5a24ef5f-54d6-4495-acf1-2fbbdd608e9b"),
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
					SchemaElementUId = new Guid("033531b8-ea88-4c09-9168-2a46cf9f4bf3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonClickEventSubProcess;
		public ProcessFlowElement OkButtonClickEventSubProcess {
			get {
				return _okButtonClickEventSubProcess ?? (_okButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OkButtonClickEventSubProcess",
					SchemaElementUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessage;
		public ProcessFlowElement OkButtonClickStartMessage {
			get {
				return _okButtonClickStartMessage ?? (_okButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessage",
					SchemaElementUId = new Guid("1cf94e34-2bef-435e-a2d8-ccbf166f8b86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickScriptTask;
		public ProcessScriptTask OkButtonClickScriptTask {
			get {
				return _okButtonClickScriptTask ?? (_okButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickScriptTask",
					SchemaElementUId = new Guid("dd4067a8-f715-45e1-a80f-337c807fa288"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _getIsValidInputDataScriptTask;
		public ProcessScriptTask GetIsValidInputDataScriptTask {
			get {
				return _getIsValidInputDataScriptTask ?? (_getIsValidInputDataScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetIsValidInputDataScriptTask",
					SchemaElementUId = new Guid("1c9ebf89-7041-4580-8275-9a2614fd9aa8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetIsValidInputDataScriptTaskExecute,
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
					SchemaElementUId = new Guid("e36cd70b-83ab-4a3b-8b8a-4204692cf933"),
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

		private ProcessScriptTask _showMassageScriptTask;
		public ProcessScriptTask ShowMassageScriptTask {
			get {
				return _showMassageScriptTask ?? (_showMassageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ShowMassageScriptTask",
					SchemaElementUId = new Guid("33b62ae0-13a6-427e-b463-e28897a12915"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ShowMassageScriptTaskExecute,
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
					SchemaElementUId = new Guid("d8e88eed-bfb2-412d-806c-f2e77bde2f99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CancelButtonClick",
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
					SchemaElementUId = new Guid("3c9cfbfc-8431-45c7-bae6-e512afc62d03"),
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
					SchemaElementUId = new Guid("54119caa-e8c2-44e0-bd71-c8d088774367"),
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
					SchemaElementUId = new Guid("8883bdaf-2867-46a5-9f79-3fa58a6de071"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("7e2c0638-cdd0-418b-bdf8-3bebe6b713a3"),
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
					SchemaElementUId = new Guid("df5349ef-7600-4922-99bd-b033eb4d6f63"),
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
					SchemaElementUId = new Guid("02643dba-1045-4e7f-b283-8cd3af8c4c2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("15ec5ef5-d493-496c-bd21-da8dd89162a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _allRolesAndUsersRadioButtonCheckStartMessage;
		public ProcessFlowElement AllRolesAndUsersRadioButtonCheckStartMessage {
			get {
				return _allRolesAndUsersRadioButtonCheckStartMessage ?? (_allRolesAndUsersRadioButtonCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AllRolesAndUsersRadioButtonCheckStartMessage",
					SchemaElementUId = new Guid("ebc4924a-fc65-4861-9eb7-a6e8caa676cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _allRolesAndUsersRadioButtonCheckScriptTask;
		public ProcessScriptTask AllRolesAndUsersRadioButtonCheckScriptTask {
			get {
				return _allRolesAndUsersRadioButtonCheckScriptTask ?? (_allRolesAndUsersRadioButtonCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AllRolesAndUsersRadioButtonCheckScriptTask",
					SchemaElementUId = new Guid("0745fd0f-df72-499b-b91d-7b18a9bb081e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AllRolesAndUsersRadioButtonCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("78c83aad-44ef-46ec-9498-8843997d3388"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _employeeRadioButtonCheckStartMessage;
		public ProcessFlowElement EmployeeRadioButtonCheckStartMessage {
			get {
				return _employeeRadioButtonCheckStartMessage ?? (_employeeRadioButtonCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmployeeRadioButtonCheckStartMessage",
					SchemaElementUId = new Guid("5da92d9c-e6ee-4c5d-a529-4ae51dbee0ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeeRadioButtonCheckScriptTask;
		public ProcessScriptTask EmployeeRadioButtonCheckScriptTask {
			get {
				return _employeeRadioButtonCheckScriptTask ?? (_employeeRadioButtonCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeeRadioButtonCheckScriptTask",
					SchemaElementUId = new Guid("6e87fc7d-82a7-448b-ae7f-7a86d42f176a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeeRadioButtonCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("8938bc27-2909-4fde-aa25-28db37553dcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _employeesRadioButtonCheckStartMessage;
		public ProcessFlowElement EmployeesRadioButtonCheckStartMessage {
			get {
				return _employeesRadioButtonCheckStartMessage ?? (_employeesRadioButtonCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EmployeesRadioButtonCheckStartMessage",
					SchemaElementUId = new Guid("4f73ae22-759e-462a-8c09-e84bcb75ceb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _employeesRadioButtonCheckScriptTask;
		public ProcessScriptTask EmployeesRadioButtonCheckScriptTask {
			get {
				return _employeesRadioButtonCheckScriptTask ?? (_employeesRadioButtonCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmployeesRadioButtonCheckScriptTask",
					SchemaElementUId = new Guid("c7a82ffc-056b-4a0b-9952-04107295a85d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmployeesRadioButtonCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("0d3459c9-e871-4413-9ba5-489133ff0a0b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _rolesRadioButtonCheckStartMessage;
		public ProcessFlowElement RolesRadioButtonCheckStartMessage {
			get {
				return _rolesRadioButtonCheckStartMessage ?? (_rolesRadioButtonCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RolesRadioButtonCheckStartMessage",
					SchemaElementUId = new Guid("f9a27859-8249-4317-9683-68974dee3743"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _rolesRadioButtonCheckScriptTask;
		public ProcessScriptTask RolesRadioButtonCheckScriptTask {
			get {
				return _rolesRadioButtonCheckScriptTask ?? (_rolesRadioButtonCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RolesRadioButtonCheckScriptTask",
					SchemaElementUId = new Guid("3ffe92d2-8137-4541-aff0-73a054afba98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RolesRadioButtonCheckScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _isValidDataConditionalFlow;
		public ProcessConditionalFlow IsValidDataConditionalFlow {
			get {
				return _isValidDataConditionalFlow ?? (_isValidDataConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsValidDataConditionalFlow",
					SchemaElementUId = new Guid("790b15f8-8148-4611-b255-28a6d21fa93a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _employeesSatisfyingFilteringCaption;
		public LocalizableString EmployeesSatisfyingFilteringCaption {
			get {
				return _employeesSatisfyingFilteringCaption ?? (_employeesSatisfyingFilteringCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EmployeesSatisfyingFilteringCaption.Value"));
			}
		}

		private LocalizableString _allRolesAndUsersCaption;
		public LocalizableString AllRolesAndUsersCaption {
			get {
				return _allRolesAndUsersCaption ?? (_allRolesAndUsersCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AllRolesAndUsersCaption.Value"));
			}
		}

		private LocalizableString _shouldSelectOneOrMoreOperationMessage;
		public LocalizableString ShouldSelectOneOrMoreOperationMessage {
			get {
				return _shouldSelectOneOrMoreOperationMessage ?? (_shouldSelectOneOrMoreOperationMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ShouldSelectOneOrMoreOperationMessage.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _isNotSetFiltrationOptionsMessage;
		public LocalizableString IsNotSetFiltrationOptionsMessage {
			get {
				return _isNotSetFiltrationOptionsMessage ?? (_isNotSetFiltrationOptionsMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IsNotSetFiltrationOptionsMessage.Value"));
			}
		}

		private LocalizableString _sysSettingLocalizableString;
		public LocalizableString SysSettingLocalizableString {
			get {
				return _sysSettingLocalizableString ?? (_sysSettingLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysSettingLocalizableString.Value"));
			}
		}

		private LocalizableString _sysValueLocalizableString;
		public LocalizableString SysValueLocalizableString {
			get {
				return _sysValueLocalizableString ?? (_sysValueLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysValueLocalizableString.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[CancelButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickEventSubProcess };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[OkButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickEventSubProcess };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[GetIsValidInputDataScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetIsValidInputDataScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ShowMassageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMassageScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[AllRolesAndUsersRadioButtonCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AllRolesAndUsersRadioButtonCheckStartMessage };
			FlowElements[AllRolesAndUsersRadioButtonCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AllRolesAndUsersRadioButtonCheckScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[EmployeeRadioButtonCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeRadioButtonCheckStartMessage };
			FlowElements[EmployeeRadioButtonCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeeRadioButtonCheckScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[EmployeesRadioButtonCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeesRadioButtonCheckStartMessage };
			FlowElements[EmployeesRadioButtonCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmployeesRadioButtonCheckScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[RolesRadioButtonCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RolesRadioButtonCheckStartMessage };
			FlowElements[RolesRadioButtonCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RolesRadioButtonCheckScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "CancelButtonClickEventSubProcess":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "OkButtonClickEventSubProcess":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("GetIsValidInputDataScriptTask");
						break;
					case "OkButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "GetIsValidInputDataScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (IsValidDataConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ShowMassageScriptTask");
						break;
					case "ShowMassageScriptTask":
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "InitEventSubProcess":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess1":
						break;
					case "AllRolesAndUsersRadioButtonCheckStartMessage":
						e.Context.QueueTasks.Enqueue("AllRolesAndUsersRadioButtonCheckScriptTask");
						break;
					case "AllRolesAndUsersRadioButtonCheckScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "EmployeeRadioButtonCheckStartMessage":
						e.Context.QueueTasks.Enqueue("EmployeeRadioButtonCheckScriptTask");
						break;
					case "EmployeeRadioButtonCheckScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "EmployeesRadioButtonCheckStartMessage":
						e.Context.QueueTasks.Enqueue("EmployeesRadioButtonCheckScriptTask");
						break;
					case "EmployeesRadioButtonCheckScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "RolesRadioButtonCheckStartMessage":
						e.Context.QueueTasks.Enqueue("RolesRadioButtonCheckScriptTask");
						break;
					case "RolesRadioButtonCheckScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool IsValidDataConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(IsValidData);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("AllRolesAndUsersRadioButtonCheckStartMessage");
			ActivatedEventElements.Add("EmployeeRadioButtonCheckStartMessage");
			ActivatedEventElements.Add("EmployeesRadioButtonCheckStartMessage");
			ActivatedEventElements.Add("RolesRadioButtonCheckStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "CancelButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickStartMessage";
					result = CancelButtonClickStartMessage.Execute(context);
					break;
				case "CancelButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScriptTask";
					result = CancelButtonClickScriptTask.Execute(context, CancelButtonClickScriptTaskExecute);
					break;
				case "OkButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "OkButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScriptTask";
					result = OkButtonClickScriptTask.Execute(context, OkButtonClickScriptTaskExecute);
					break;
				case "GetIsValidInputDataScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetIsValidInputDataScriptTask";
					result = GetIsValidInputDataScriptTask.Execute(context, GetIsValidInputDataScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ShowMassageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMassageScriptTask";
					result = ShowMassageScriptTask.Execute(context, ShowMassageScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
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
				case "PageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "AllRolesAndUsersRadioButtonCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllRolesAndUsersRadioButtonCheckStartMessage";
					result = AllRolesAndUsersRadioButtonCheckStartMessage.Execute(context);
					break;
				case "AllRolesAndUsersRadioButtonCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AllRolesAndUsersRadioButtonCheckScriptTask";
					result = AllRolesAndUsersRadioButtonCheckScriptTask.Execute(context, AllRolesAndUsersRadioButtonCheckScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeeRadioButtonCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeRadioButtonCheckStartMessage";
					result = EmployeeRadioButtonCheckStartMessage.Execute(context);
					break;
				case "EmployeeRadioButtonCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeeRadioButtonCheckScriptTask";
					result = EmployeeRadioButtonCheckScriptTask.Execute(context, EmployeeRadioButtonCheckScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "EmployeesRadioButtonCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeesRadioButtonCheckStartMessage";
					result = EmployeesRadioButtonCheckStartMessage.Execute(context);
					break;
				case "EmployeesRadioButtonCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmployeesRadioButtonCheckScriptTask";
					result = EmployeesRadioButtonCheckScriptTask.Execute(context, EmployeesRadioButtonCheckScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "RolesRadioButtonCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RolesRadioButtonCheckStartMessage";
					result = RolesRadioButtonCheckStartMessage.Execute(context);
					break;
				case "RolesRadioButtonCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RolesRadioButtonCheckScriptTask";
					result = RolesRadioButtonCheckScriptTask.Execute(context, RolesRadioButtonCheckScriptTaskExecute);
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
				case "EditSchemaManagerName":
					EditSchemaManagerName = reader.GetValue<System.String>();
				break;
				case "IncludedDataValueTypesMap":
					IncludedDataValueTypesMap = reader.GetSerializableObjectValue();
				break;
				case "Messages":
					Messages = reader.GetSerializableObjectValue();
				break;
				case "IsInitializedParameterValueEdit":
					IsInitializedParameterValueEdit = reader.GetValue<System.Boolean>();
				break;
				case "ContactSchemaUId":
					ContactSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "SysAdminUnitSchemaUId":
					SysAdminUnitSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "IsValidData":
					IsValidData = reader.GetValue<System.Boolean>();
				break;
				case "GuidTypeUId":
					GuidTypeUId = reader.GetValue<System.Guid>();
				break;
				case "LookupTypeUId":
					LookupTypeUId = reader.GetValue<System.Guid>();
				break;
				case "EditElementUId":
					EditElementUId = reader.GetValue<System.Guid>();
				break;
				case "ProcessSchemaExplorer":
					ProcessSchemaExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsProcessSchemaExplorerRegistered":
					IsProcessSchemaExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "IsProcessSchemaExplorerCreated":
					IsProcessSchemaExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "EditSchemaUId":
					EditSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ItemId":
					ItemId = reader.GetValue<System.String>();
				break;
				case "ContextKey":
					ContextKey = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			List<Dictionary<string, object>> items = GetEditedItems();
			Dictionary<string, object> item = null;
			bool isNewItem = string.IsNullOrEmpty(ItemId);
			if (isNewItem) {
				item = new Dictionary<string, object>();
				item.Add("Id", Guid.NewGuid().ToString());
				items.Add(item);
			} else {
				item = FindEditedItem(items);
				item.Clear();
				item.Add("Id", ItemId);
			}
			AssignEditedItem(item);
			UserConnection.SessionData[ContextKey] = items;
			return true;
		}

		public virtual bool GetIsValidInputDataScriptTaskExecute(ProcessExecutingContext context) {
			IsValidData = Page.RightToReadCheckBox.Checked || Page.RightToChangeCheckBox.Checked || Page.RightToRemoveCheckBox.Checked;
			var messages = new List<string>(2);
			if (!IsValidData) {
				messages.Add(ShouldSelectOneOrMoreOperationMessage.Value);
			}
			if (Page.EmployeesRadioButton.Checked) {
				var filters = Page.ContactFilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
				if (filters.Count == 0 || filters.IsAnyLeftExpressionNullOrEmpty()){
					IsValidData = false;
					messages.Add(IsNotSetFiltrationOptionsMessage.Value);
				}
			}
			Messages = messages;
			return true;
		}

		public virtual bool ShowMassageScriptTaskExecute(ProcessExecutingContext context) {
			Page.BaseMessagePanel.Clear();
			var messages = (List<string>)Messages;
			foreach(string message in messages) {
				Page.BaseMessagePanel.AddMessage(ValidationMessageTitle, message, MessageType.Warning);
			}
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			InitializePage();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			HandleOnPageLoaded();
			return true;
		}

		public virtual bool AllRolesAndUsersRadioButtonCheckScriptTaskExecute(ProcessExecutingContext context) {
			if (!Page.AllRolesAndUsersRadioButton.Checked) {
				return true;
			}
			SetEnabledControlsProperty(false);
			Page.EmployeeParameterValueEdit.SetRequired(false);
			Page.RolesParameterValueEdit.SetRequired(false);
			return true;
		}

		public virtual bool EmployeeRadioButtonCheckScriptTaskExecute(ProcessExecutingContext context) {
			if (!Page.EmployeeRadioButton.Checked) {
				return true;
			}
			SetEnabledControlsProperty(false);
			Page.EmployeeParameterValueEdit.Enabled = true;
			Page.EmployeeParameterValueEdit.SetRequired(true);
			Page.RolesParameterValueEdit.SetRequired(false);
			//AssignIncludedDataValueTypesMap(ContactSchemaUId);
			return true;
		}

		public virtual bool EmployeesRadioButtonCheckScriptTaskExecute(ProcessExecutingContext context) {
			if (!Page.EmployeesRadioButton.Checked) {
				return true;
			}
			SetEnabledControlsProperty(false);
			Page.ContactFilterEdit.Enabled = true;
			Page.EmployeeParameterValueEdit.SetRequired(false);
			Page.RolesParameterValueEdit.SetRequired(false);
			return true;
		}

		public virtual bool RolesRadioButtonCheckScriptTaskExecute(ProcessExecutingContext context) {
			if (!Page.RolesRadioButton.Checked) {
				return true;
			}
			SetEnabledControlsProperty(false);
			Page.RolesParameterValueEdit.Enabled = true;
			Page.RolesParameterValueEdit.SetRequired(true);
			Page.EmployeeParameterValueEdit.SetRequired(false);
			//AssignIncludedDataValueTypesMap(SysAdminUnitSchemaUId);
			return true;
		}

		public virtual List<Dictionary<string, object>> GetEditedItems() {
			var items = UserConnection.SessionData[ContextKey] as List<Dictionary<string, object>>;
			if (items == null) {
				items = new List<Dictionary<string, object>>();
			}
			return items;
		}

		public virtual Dictionary<string, object> FindEditedItem(List<Dictionary<string, object>> items) {
			foreach(Dictionary<string, object> item in items) {
				if ((string)item["Id"] == ItemId) {
					return item;
				}
			}
			return null;
		}

		public virtual ProcessSchema GetDesignedProcessSchema() {
			return UserConnection.ProcessSchemaManager.GetDesignInstance(UserConnection, EditSchemaUId);
		}

		public virtual void ShowProcessSchemaExplorer(string value, SchemaStructureExplorer processSchemaExplorer) {
			if (processSchemaExplorer == null) {
				return;
			}
			processSchemaExplorer.ShowEditWindow(EditSchemaUId, value, EditElementUId);
		}

		public virtual SchemaStructureExplorer ForceGetProcessSchemaExplorer(Dictionary<Guid, Guid> includedDataValueTypesMap) {
			SchemaStructureExplorer schemaStructureExplorer = null;
			if (IsProcessSchemaExplorerCreated) {
				schemaStructureExplorer = (SchemaStructureExplorer)ProcessSchemaExplorer;
				if (includedDataValueTypesMap != null) {
					schemaStructureExplorer.IncludedDataValueTypes.Clear();
					foreach(KeyValuePair<Guid, Guid> keyValuePair in includedDataValueTypesMap) {
						schemaStructureExplorer.IncludedDataValueTypes.Add(keyValuePair.Key, keyValuePair.Value);
					}
					ProcessSchemaExplorer = schemaStructureExplorer;
				}
			} else {
				schemaStructureExplorer = CreateProcessSchemaExplorer(includedDataValueTypesMap);
				ProcessSchemaExplorer = schemaStructureExplorer;
			}
			return schemaStructureExplorer;
		}

		public virtual void ClearFilterEdit() {
			var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(Page.ContactFilterEdit.FilterEditGroupName);
			filterEditGroup.Clear();
		}

		public virtual SchemaStructureExplorer CreateProcessSchemaExplorer(Dictionary<Guid, Guid> includedDataValueTypesMap) {
			var processSchemaExplorer = new SchemaStructureExplorer(Page.MainControlLayout, "ProcessSchemaStructureExplorer", false, false);
			processSchemaExplorer.ManagerName = "ProcessSchemaManager";
			processSchemaExplorer.IncludedDataValueTypes.Clear();
			if (includedDataValueTypesMap != null) {
				foreach(KeyValuePair<Guid, Guid> keyValuePair in includedDataValueTypesMap) {
					processSchemaExplorer.IncludedDataValueTypes.Add(keyValuePair.Key, keyValuePair.Value);
				}
			} else {
				processSchemaExplorer.IncludedDataValueTypes.Add(GuidTypeUId, Guid.Empty);
			}
			if (!IsProcessSchemaExplorerCreated) {
				processSchemaExplorer.Register();
			}
			IsProcessSchemaExplorerCreated = true;
			return processSchemaExplorer;
		}

		public virtual void RolesParameterValueEdit_ShowMappingWindow(object sender, AjaxEventArgs e) {
			var parameter = (ProcessSchemaParameterValueEdit)sender;
			var parameterValue = (ProcessSchemaParameterValue)parameter.Value;
			if (parameterValue.ReferenceSchemaUId == Guid.Empty) {
				parameterValue.ReferenceSchemaUId = SysAdminUnitSchemaUId;
			}
			AssignShowMappingWindowEvent(Page.RolesParameterValueEdit.ClientID, parameterValue);
		}

		public virtual void SetFilterDataValueTypeIdParameterEdit(Dictionary<string, string> parameterEditControls) {
			if (parameterEditControls == null || parameterEditControls.Count == 0) {
				return;
			}
			var sb = new StringBuilder(128 * parameterEditControls.Count);
			sb.Append("(function(){");
			foreach (KeyValuePair<string, string> parameterEditControl in parameterEditControls) {
				sb.Append(parameterEditControl.Key);
				sb.Append(".setFilterDataValueTypeId = function(dataValueTypeUId){");
				sb.Append("var dataProvider=this.dataProvider;var filters=dataProvider.filters;");
				sb.Append("for(var i=0;i<filters.length;i++){var filter=filters[i];");
				sb.Append("if(filter[0]=='dataValueTypeId'){");
				sb.Append("filter[1]=dataValueTypeUId;break;}}};");
				sb.Append(parameterEditControl.Key);
				sb.Append(".setFilterDataValueTypeId(\"");
				sb.Append(parameterEditControl.Value.ToLower());
				sb.Append("\");");
			}
			sb.Append("})();");
			Page.AddScript(sb.ToString());
		}

		public virtual void ClearParameterValueEditControl(string clientId) {
			Page.AddScript(
				string.Format("{0}.setValue({1})", clientId,
					"{\"source\":\"None\",\"value\":\"\",\"displayValue\":\"\",\"constValueEditor\":{\"xtype\":\"lookupedit\",\"referenceSchemaUId\":\"00000000000000000000000000000000\"}}"));
		}

		public virtual void InitRolesParameterValueEdit() {
			var sysAdminUnitType = (int)Terrasoft.Core.DB.SysAdminUnitType.User;
			Page.RolesParameterValueEdit.LookupFilters.Add(new Dictionary<string, object> { 
				 {"comparisonType", FilterComparisonType.NotEqual},
				 {"leftExpressionColumnPath", "SysAdminUnitTypeValue"},
				 {"useDisplayValue", false }, 
				 {"rightExpressionParameterValues", new object[] { sysAdminUnitType }}
			});
			//Page.RolesParameterValueEdit.AjaxEvents.ShowMappingWindow.Event += RolesParameterValueEdit_ShowMappingWindow;
			if (IsInitializedParameterValueEdit) {
				return;
			}
			SysAdminUnitSchemaUId = UserConnection.EntitySchemaManager.GetItemByName("SysAdminUnit").UId;
			var parameterValue = new ProcessSchemaParameterValue {
				ReferenceSchemaUId = SysAdminUnitSchemaUId,
				DataValueTypeUId = LookupTypeUId,
				SchemaUId = EditSchemaUId,
				SchemaManagerName = EditSchemaManagerName
			};
			Page.RolesParameterValueEdit.Value = parameterValue;
			Page.RolesParameterValueEdit.DataProvider.DataValueTypeUId = LookupTypeUId;
			Page.RolesParameterValueEdit.CustomConfig.Add(new ConfigItem("showLookupEditToolButton", "true"));
			//Page.AddScript(String.Format("{0}.setReferenceSchemaUId('{1}')", Page.RolesParameterValueEdit.ClientID, SysAdminUnitSchemaUId));
		}

		public virtual void InitEmployeeParameterValueEdit() {
			//Page.EmployeeParameterValueEdit.AjaxEvents.ShowMappingWindow.Event += EmployeeParameterValueEdit_ShowMappingWindow;
			Page.EmployeeParameterValueEdit.LookupFilters.Add(new Dictionary<string, object> { 
				{"comparisonType", FilterComparisonType.IsNotNull}, 
				{"leftExpressionColumnPath", "[SysAdminUnit:Contact].Id"},
				{"useDisplayValue", false}, 
				{"rightExpressionParameterValues", new object[] {0}}
			});
			if (IsInitializedParameterValueEdit) {
				return;
			}
			ContactSchemaUId = UserConnection.EntitySchemaManager.GetItemByName("Contact").UId;
			var parameterValue = new ProcessSchemaParameterValue {
				ReferenceSchemaUId = ContactSchemaUId,
				DataValueTypeUId = LookupTypeUId,
				SchemaUId = EditSchemaUId,
				SchemaManagerName = EditSchemaManagerName
			};
			Page.EmployeeParameterValueEdit.Value = parameterValue;
			Page.EmployeeParameterValueEdit.DataProvider.DataValueTypeUId = LookupTypeUId;
			Page.EmployeeParameterValueEdit.CustomConfig.Add(new ConfigItem("showLookupEditToolButton", "true"));
			//Page.AddScript(String.Format("{0}.setReferenceSchemaUId('{1}')", Page.EmployeeParameterValueEdit.ClientID, ContactSchemaUId));
		}

		public virtual void SetEnabledControlsProperty(bool isEnabled) {
			Page.RolesParameterValueEdit.Enabled = isEnabled;
			Page.EmployeeParameterValueEdit.Enabled = isEnabled;
			Page.ContactFilterEdit.Enabled = isEnabled;
		}

		public virtual void AssignEditedItem(Dictionary<string, object> item) {
			ProcessSchema processSchema = UserConnection.ProcessSchemaManager.GetDesignInstance(UserConnection, EditSchemaUId);
			var generator = new ProcessSchemaGeneratorNew(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			item.Add("CanRead", Page.RightToReadCheckBox.Checked);
			item.Add("CanEdit", Page.RightToChangeCheckBox.Checked);
			item.Add("CanDelete", Page.RightToRemoveCheckBox.Checked);
			item.Add("Source", ((int)ProcessSchemaParameterValueSource.ConstValue).ToString());
			if (Page.AllRolesAndUsersRadioButton.Checked) {
				item.Add("Grantee", "AllRolesAndUsers");
				item.Add("Name", AllRolesAndUsersCaption.Value);
				return;
			}
			string runtimeValue = string.Empty;
			if (Page.EmployeesRadioButton.Checked) {
				item.Add("Grantee", "DataSourceFilter");
				item.Add("Name", EmployeesSatisfyingFilteringCaption.Value);
				var filterCollection = Page.ContactFilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
				var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.ContactFilterEdit.DataSource);
				var value = filterCollection.Count > 0 ? Json.Serialize(filterCollection, jsonConverter) : string.Empty;
				item.Add("Value", value);
				return;
			}
			ProcessSchemaParameterValue parameterValue = null;
			if (Page.RolesRadioButton.Checked) {
				parameterValue = (ProcessSchemaParameterValue)Page.RolesParameterValueEdit.Value;
				item.Add("Grantee", "Role");
			} else if (Page.EmployeeRadioButton.Checked) {
				parameterValue = (ProcessSchemaParameterValue)Page.EmployeeParameterValueEdit.Value;
				item.Add("Grantee", "Employee");
			}
			if (parameterValue == null) {
				return;
			}
			item.Add("Name", parameterValue.DisplayValue);
			item.Add("Value", parameterValue.Value);
			if (parameterValue.Source == ProcessSchemaParameterValueSource.Mapping) {
				runtimeValue = generator.GetMetaPath(processSchema, parameterValue.Value);
				item.Add("RuntimeValue", runtimeValue);
			}
			if (parameterValue.Source != ProcessSchemaParameterValueSource.ConstValue) {
				item["Source"] = ((int)parameterValue.Source).ToString();
			}
		}

		public virtual void AssignControlValues(Dictionary<string, object> item) {
			Page.ContactFilterEdit.Enabled = false;
			if (item == null) {
				Page.AllRolesAndUsersRadioButton.Checked = true;
				return;
			}
			Page.RightToReadCheckBox.Checked = Convert.ToBoolean(item["CanRead"]);
			Page.RightToChangeCheckBox.Checked = Convert.ToBoolean(item["CanEdit"]);
			Page.RightToRemoveCheckBox.Checked = Convert.ToBoolean(item["CanDelete"]);
			var grantee = (string)item["Grantee"];
			if (grantee == "AllRolesAndUsers") {
				Page.AllRolesAndUsersRadioButton.Checked = true;
				return;
			}
			if (grantee == "DataSourceFilter") {
				var filters = item["Value"] as string;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(
						UserConnection, Page.ContactFilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
					if (filterCollection != null) {
						var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(filterCollection.Name);
						if (filterEditGroup != null) {
							Page.EntityDataSource.CurrentStructure.Filters.Remove(filterEditGroup);
						}
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				Page.ContactFilterEdit.SetDataSource(Page.EntityDataSource);
				Page.EmployeesRadioButton.Checked = true;
				Page.ContactFilterEdit.Enabled = true;
				return;
			}
			//string clientID = null;
			var value = (string)item["Value"];
			var displayValue = (string)item["Name"];
			var source = (ProcessSchemaParameterValueSource)Enum.Parse(typeof(ProcessSchemaParameterValueSource), (string)item["Source"]);
			ProcessSchemaParameterValueEdit parameterValueEdit = null;
			if (grantee == "Role") {
				Page.RolesRadioButton.Checked = true;
				Page.RolesParameterValueEdit.Enabled = true;
				Page.RolesParameterValueEdit.SetRequired(true);
				parameterValueEdit = Page.RolesParameterValueEdit;
				//clientID = Page.RolesParameterValueEdit.ClientID;
				//AssignIncludedDataValueTypesMap(SysAdminUnitSchemaUId);
				/*
				parameterValue.ReferenceSchemaUId = SysAdminUnitSchemaUId;
				Page.RolesParameterValueEdit.SetValue(parameterValue);
				*/
			} else if (grantee == "Employee") {
				Page.EmployeeRadioButton.Checked = true;
				Page.EmployeeParameterValueEdit.Enabled = true;
				Page.EmployeeParameterValueEdit.SetRequired(true);
				parameterValueEdit = Page.EmployeeParameterValueEdit;
				//clientID = Page.EmployeeParameterValueEdit.ClientID;
				//AssignIncludedDataValueTypesMap(ContactSchemaUId);
				/*
				parameterValue.ReferenceSchemaUId = ContactSchemaUId;
				Page.EmployeeParameterValueEdit.SetValue(parameterValue);
				*/
			}
			if (parameterValueEdit == null) {
				return;
			}
			var parameterValue = parameterValueEdit.ParameterValue;
			parameterValue.Source = source;
			parameterValue.Value = value;
			parameterValue.DisplayValue = displayValue;
			parameterValueEdit.Value = parameterValue;
			/*
			var source = Enum.Parse(typeof(ProcessSchemaParameterValueSource), (string)item["Source"]).ToString();
			var script = string.Concat(clientID, ".setValue(\"{'source':'", source,"','value':'", value,
				"','displayValue':'", displayValue,"'}\")");
			Page.AddScript(script);
			*/
		}

		public virtual void AssignShowMappingWindowEvent(string parameterValueEditClientId, ProcessSchemaParameterValue parameterValue) {
			var includedDataValueTypesMap = new Dictionary<Guid, Guid> {
				{ GuidTypeUId, Guid.Empty },
				{ LookupTypeUId, parameterValue.ReferenceSchemaUId }
			};
			var processSchemaExplorer = ForceGetProcessSchemaExplorer(includedDataValueTypesMap);
			Page.ScriptManager.AddScript(String.Format("{0}.un('editcomplete', {1}.onStructureExplorerWindowEditComplete, {1});",
				processSchemaExplorer.ClientID, parameterValueEditClientId));
			Page.ScriptManager.AddScript(String.Format("{0}.on('editcomplete', {1}.onStructureExplorerWindowEditComplete, {1});",
				processSchemaExplorer.ClientID, parameterValueEditClientId));
			ShowProcessSchemaExplorer(parameterValue.Value, processSchemaExplorer);
		}

		public virtual void EmployeeParameterValueEdit_ShowMappingWindow(object sender, AjaxEventArgs e) {
			var parameter = (ProcessSchemaParameterValueEdit)sender;
			var parameterValue = (ProcessSchemaParameterValue)parameter.Value;
			if (parameterValue.ReferenceSchemaUId == Guid.Empty) {
				parameterValue.ReferenceSchemaUId = ContactSchemaUId;
			}
			AssignShowMappingWindowEvent(Page.EmployeeParameterValueEdit.ClientID, parameterValue);
		}

		public virtual void HandleOnPageLoaded() {
			Page.OkButton.AjaxEvents.Click.CausesValidation = true;
			/*
			var parameterEditControls = new Dictionary<string, string>(2);
			string lookupDvt = LookupTypeUId.ToString();
			parameterEditControls.Add(Page.RolesParameterValueEdit.ClientID, lookupDvt);
			parameterEditControls.Add(Page.EmployeeParameterValueEdit.ClientID, lookupDvt);
			SetFilterDataValueTypeIdParameterEdit(parameterEditControls);
			*/
			object value = Page.GetParameterValue("itemId");
			if (value != null) {
				ItemId = value.ToString();
			}
			ProcessSchema schema = GetDesignedProcessSchema();
			Page.ContactFilterEdit.SetProcessSchema(schema);
			Dictionary<string, object> item = null;
			if (!string.IsNullOrEmpty(ItemId)) {
				List<Dictionary<string, object>> items = GetEditedItems();
				item = FindEditedItem(items);
			}
			AssignControlValues(item);
			Page.EntityDataSource.LoadStructure();
		}

		public virtual void InitializePage() {
			if (!IsInitializedParameterValueEdit) {
				GuidTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Guid").UId;
				LookupTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId;
				ContextKey = Page.GetParameterValue("sessionKey").ToString();
				EditSchemaUId = new Guid(Page.GetParameterValue("processSchemaId").ToString());
				EditElementUId = new Guid(Page.GetParameterValue("editElementId").ToString());
				EditSchemaManagerName = Page.GetParameterValue("managerName").ToString();
			}
			InitRolesParameterValueEdit();
			InitEmployeeParameterValueEdit();
			IsInitializedParameterValueEdit = true;
			if (IsProcessSchemaExplorerCreated) {
				Dictionary<Guid, Guid> includedDataValueTypesMap = IncludedDataValueTypesMap == null
					? null : (Dictionary<Guid, Guid>)IncludedDataValueTypesMap;
				ProcessSchemaExplorer = CreateProcessSchemaExplorer(includedDataValueTypesMap);
			}
		}

		public virtual void AssignIncludedDataValueTypesMap(Guid referenceSchemaUId) {
			Dictionary<Guid, Guid> includedDataValueTypesMap;
			if (referenceSchemaUId != Guid.Empty) {
				includedDataValueTypesMap = new Dictionary<Guid, Guid> {
					{ GuidTypeUId, Guid.Empty },
					{ LookupTypeUId, referenceSchemaUId }
				};
			} else {
				includedDataValueTypesMap = null;
			}
			IncludedDataValueTypesMap = includedDataValueTypesMap;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "AllRolesAndUsersRadioButtonCheck":
							if (ActivatedEventElements.Contains("AllRolesAndUsersRadioButtonCheckStartMessage")) {
							context.QueueTasks.Enqueue("AllRolesAndUsersRadioButtonCheckStartMessage");
						}
						break;
					case "EmployeeRadioButtonCheck":
							if (ActivatedEventElements.Contains("EmployeeRadioButtonCheckStartMessage")) {
							context.QueueTasks.Enqueue("EmployeeRadioButtonCheckStartMessage");
						}
						break;
					case "EmployeesRadioButtonCheck":
							if (ActivatedEventElements.Contains("EmployeesRadioButtonCheckStartMessage")) {
							context.QueueTasks.Enqueue("EmployeesRadioButtonCheckStartMessage");
						}
						break;
					case "RolesRadioButtonCheck":
							if (ActivatedEventElements.Contains("RolesRadioButtonCheckStartMessage")) {
							context.QueueTasks.Enqueue("RolesRadioButtonCheckStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("EditSchemaManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaManagerName", EditSchemaManagerName, null);
			}
			if (IncludedDataValueTypesMap != null) {
				if (IncludedDataValueTypesMap.GetType().IsSerializable ||
					IncludedDataValueTypesMap.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("IncludedDataValueTypesMap", IncludedDataValueTypesMap, null);
				}
			}
			if (Messages != null) {
				if (Messages.GetType().IsSerializable ||
					Messages.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Messages", Messages, null);
				}
			}
			if (!HasMapping("IsInitializedParameterValueEdit") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsInitializedParameterValueEdit", IsInitializedParameterValueEdit, false);
			}
			if (!HasMapping("ContactSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ContactSchemaUId", ContactSchemaUId, Guid.Empty);
			}
			if (!HasMapping("SysAdminUnitSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysAdminUnitSchemaUId", SysAdminUnitSchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsValidData") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsValidData", IsValidData, false);
			}
			if (!HasMapping("GuidTypeUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("GuidTypeUId", GuidTypeUId, Guid.Empty);
			}
			if (!HasMapping("LookupTypeUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupTypeUId", LookupTypeUId, Guid.Empty);
			}
			if (!HasMapping("EditElementUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditElementUId", EditElementUId, Guid.Empty);
			}
			if (ProcessSchemaExplorer != null) {
				if (ProcessSchemaExplorer.GetType().IsSerializable ||
					ProcessSchemaExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ProcessSchemaExplorer", ProcessSchemaExplorer, null);
				}
			}
			if (!HasMapping("IsProcessSchemaExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsProcessSchemaExplorerRegistered", IsProcessSchemaExplorerRegistered, false);
			}
			if (!HasMapping("IsProcessSchemaExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsProcessSchemaExplorerCreated", IsProcessSchemaExplorerCreated, false);
			}
			if (!HasMapping("EditSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaUId", EditSchemaUId, Guid.Empty);
			}
			if (!HasMapping("ItemId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ItemId", ItemId, null);
			}
			if (!HasMapping("ContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ContextKey", ContextKey, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: DeleteRightsRecordEditPageEventsProcess

	/// <exclude/>
	public class DeleteRightsRecordEditPageEventsProcess : DeleteRightsRecordEditPageEventsProcess<Terrasoft.WebApp.DeleteRightsRecordEditPageSchemaUserControl>
	{

		public DeleteRightsRecordEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeleteRightsRecordEditPageSchemaUserControl

	/// <exclude/>
	public partial class DeleteRightsRecordEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout OperationsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("OperationsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox RightToReadCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("RightToReadCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox RightToChangeCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("RightToChangeCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox RightToRemoveCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("RightToRemoveCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout RemoveRightsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("RemoveRightsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AllRolesAndUsersRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AllRolesAndUsersRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton RolesRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("RolesRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit RolesParameterValueEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("RolesParameterValueEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton EmployeeRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("EmployeeRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout7", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit EmployeeParameterValueEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ProcessSchemaParameterValueEdit)PageContainer.FindPageControl("EmployeeParameterValueEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton EmployeesRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("EmployeesRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout9", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit ContactFilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("ContactFilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OkButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
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
			AllRolesAndUsersRadioButton.AjaxEvents.Check.Event += AllRolesAndUsersRadioButtonCheck;
			RolesRadioButton.AjaxEvents.Check.Event += RolesRadioButtonCheck;
			EmployeeRadioButton.AjaxEvents.Check.Event += EmployeeRadioButtonCheck;
			EmployeesRadioButton.AjaxEvents.Check.Event += EmployeesRadioButtonCheck;
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AllRolesAndUsersRadioButton.AjaxEvents.Check.Event -= AllRolesAndUsersRadioButtonCheck;
			RolesRadioButton.AjaxEvents.Check.Event -= RolesRadioButtonCheck;
			EmployeeRadioButton.AjaxEvents.Check.Event -= EmployeeRadioButtonCheck;
			EmployeesRadioButton.AjaxEvents.Check.Event -= EmployeesRadioButtonCheck;
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (DeleteRightsRecordEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new DeleteRightsRecordEditPageEventsProcess(UserConnection);
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

		public virtual void AllRolesAndUsersRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("AllRolesAndUsersRadioButtonCheck");
		}

		public virtual void RolesRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("RolesRadioButtonCheck");
		}

		public virtual void EmployeeRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("EmployeeRadioButtonCheck");
		}

		public virtual void EmployeesRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("EmployeesRadioButtonCheck");
		}

		public virtual void OkButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OkButtonClick");
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
			SchemaName = "DeleteRightsRecordEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: DeleteRightsRecordEditPageEventsProcessSchema

	/// <exclude/>
	public class DeleteRightsRecordEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public DeleteRightsRecordEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DeleteRightsRecordEditPageEventsProcessSchema(DeleteRightsRecordEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeleteRightsRecordEditPageEventsProcess";
			UId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22");
			CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1");
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

		protected virtual ProcessSchemaParameter CreateContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2d7e6988-d892-45cc-82a4-c3fa849bb98e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateItemIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("19bcb1fc-39e5-4512-b9b2-8a2165c15c3e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ItemId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c2ac2c31-4ba2-444c-81ab-c47310ebdca2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EditSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsProcessSchemaExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("45031b78-90ae-4f22-9c00-32154ee94333"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"IsProcessSchemaExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsProcessSchemaExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("72a79de2-167c-439e-9908-05f470fbcd6a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"IsProcessSchemaExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessSchemaExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c2cc337a-804d-4f94-a268-20de70967628"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ProcessSchemaExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditElementUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("070365da-fec9-4c3a-8bb9-163b1ec7bd87"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EditElementUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupTypeUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("74b850c9-09d1-43f8-989b-6fe66986f2f1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"LookupTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateGuidTypeUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e9160d67-106c-4bfc-8c66-33669a83f204"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"GuidTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsValidDataParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c5ea55ce-68b7-440c-9168-2284f45d11fc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"IsValidData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysAdminUnitSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fa87bf4d-5af2-4900-b896-fc45fcb2f421"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"SysAdminUnitSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("55836b8b-1e59-41e8-9d2e-8803bb8f5195"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ContactSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsInitializedParameterValueEditParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5d2e5043-ba58-4490-8533-3cf37f2113d6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"IsInitializedParameterValueEdit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("851fb8ea-6517-4e7e-a1e3-04ff209fac4b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"Messages",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIncludedDataValueTypesMapParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("abef0e2c-e832-43fc-ade3-7fbb37b6c74f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"IncludedDataValueTypesMap",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e95f4376-7eba-424e-8dfb-3eaebb0d4c4e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EditSchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateContextKeyParameter());
			Parameters.Add(CreateItemIdParameter());
			Parameters.Add(CreateEditSchemaUIdParameter());
			Parameters.Add(CreateIsProcessSchemaExplorerCreatedParameter());
			Parameters.Add(CreateIsProcessSchemaExplorerRegisteredParameter());
			Parameters.Add(CreateProcessSchemaExplorerParameter());
			Parameters.Add(CreateEditElementUIdParameter());
			Parameters.Add(CreateLookupTypeUIdParameter());
			Parameters.Add(CreateGuidTypeUIdParameter());
			Parameters.Add(CreateIsValidDataParameter());
			Parameters.Add(CreateSysAdminUnitSchemaUIdParameter());
			Parameters.Add(CreateContactSchemaUIdParameter());
			Parameters.Add(CreateIsInitializedParameterValueEditParameter());
			Parameters.Add(CreateMessagesParameter());
			Parameters.Add(CreateIncludedDataValueTypesMapParameter());
			Parameters.Add(CreateEditSchemaManagerNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaLane schemaButtonsLane = CreateButtonsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaButtonsLane);
			ProcessSchemaLane schemaRadioButtonsLane = CreateRadioButtonsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaRadioButtonsLane);
			ProcessSchemaEventSubProcess cancelbuttonclickeventsubprocess = CreateCancelButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(cancelbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess okbuttonclickeventsubprocess = CreateOkButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			cancelbuttonclickeventsubprocess.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			cancelbuttonclickeventsubprocess.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaScriptTask getisvalidinputdatascripttask = CreateGetIsValidInputDataScriptTaskScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(getisvalidinputdatascripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			okbuttonclickeventsubprocess.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask showmassagescripttask = CreateShowMassageScriptTaskScriptTask();
			okbuttonclickeventsubprocess.FlowElements.Add(showmassagescripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			okbuttonclickeventsubprocess.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent allrolesandusersradiobuttoncheckstartmessage = CreateAllRolesAndUsersRadioButtonCheckStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(allrolesandusersradiobuttoncheckstartmessage);
			ProcessSchemaScriptTask allrolesandusersradiobuttoncheckscripttask = CreateAllRolesAndUsersRadioButtonCheckScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(allrolesandusersradiobuttoncheckscripttask);
			ProcessSchemaStartMessageEvent employeeradiobuttoncheckstartmessage = CreateEmployeeRadioButtonCheckStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(employeeradiobuttoncheckstartmessage);
			ProcessSchemaScriptTask employeeradiobuttoncheckscripttask = CreateEmployeeRadioButtonCheckScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(employeeradiobuttoncheckscripttask);
			ProcessSchemaStartMessageEvent employeesradiobuttoncheckstartmessage = CreateEmployeesRadioButtonCheckStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(employeesradiobuttoncheckstartmessage);
			ProcessSchemaScriptTask employeesradiobuttoncheckscripttask = CreateEmployeesRadioButtonCheckScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(employeesradiobuttoncheckscripttask);
			ProcessSchemaStartMessageEvent rolesradiobuttoncheckstartmessage = CreateRolesRadioButtonCheckStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(rolesradiobuttoncheckstartmessage);
			ProcessSchemaScriptTask rolesradiobuttoncheckscripttask = CreateRolesRadioButtonCheckScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(rolesradiobuttoncheckscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateIsValidDataConditionalFlowConditionalFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmployeesSatisfyingFilteringCaptionLocalizableString());
			LocalizableStrings.Add(CreateAllRolesAndUsersCaptionLocalizableString());
			LocalizableStrings.Add(CreateShouldSelectOneOrMoreOperationMessageLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateIsNotSetFiltrationOptionsMessageLocalizableString());
			LocalizableStrings.Add(CreateSysSettingLocalizableStringLocalizableString());
			LocalizableStrings.Add(CreateSysValueLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmployeesSatisfyingFilteringCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0f98b7d1-7226-4b1a-82cc-019738c3e7a5"),
				Name = "EmployeesSatisfyingFilteringCaption",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAllRolesAndUsersCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("85c59080-3ef7-41d6-880e-1288073bfb53"),
				Name = "AllRolesAndUsersCaption",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateShouldSelectOneOrMoreOperationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("576cb1e6-de94-4277-a31c-09c5a23d726c"),
				Name = "ShouldSelectOneOrMoreOperationMessage",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab1a2b67-1eb0-4690-ae37-a296f0084b36"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIsNotSetFiltrationOptionsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1379265d-478f-4ea1-95cb-01e8d4cfbb59"),
				Name = "IsNotSetFiltrationOptionsMessage",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSysSettingLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("13bad3d0-11b9-4583-9159-99496b2d78cc"),
				Name = "SysSettingLocalizableString",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSysValueLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("946cd53f-7456-4cca-813a-cdc83dc49bba"),
				Name = "SysValueLocalizableString",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("92a666f9-0e64-40ef-994b-24f4ce91ad82"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1cf94e34-2bef-435e-a2d8-ccbf166f8b86"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c9ebf89-7041-4580-8275-9a2614fd9aa8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("aac4072d-8465-4ae2-bf80-19c15f81a3f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5a24ef5f-54d6-4495-acf1-2fbbdd608e9b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("033531b8-ea88-4c09-9168-2a46cf9f4bf3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("3d6cfadc-1c20-4cab-8a21-504c23cc664f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(167, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54119caa-e8c2-44e0-bd71-c8d088774367"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8883bdaf-2867-46a5-9f79-3fa58a6de071"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("4e1ff30b-dc48-4f6a-a853-e0c586a366bb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(383, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df5349ef-7600-4922-99bd-b033eb4d6f63"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("02643dba-1045-4e7f-b283-8cd3af8c4c2f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("16586386-172b-4f7d-9c4c-35f22a440e2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(228, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd4067a8-f715-45e1-a80f-337c807fa288"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8e88eed-bfb2-412d-806c-f2e77bde2f99"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("76972859-e20f-4c54-ba02-ef048a291929"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ebc4924a-fc65-4861-9eb7-a6e8caa676cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0745fd0f-df72-499b-b91d-7b18a9bb081e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("ecf1156a-d883-489b-913e-12ddcfd1daaa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9a27859-8249-4317-9683-68974dee3743"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ffe92d2-8137-4541-aff0-73a054afba98"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("ac71f05d-c29b-441e-9a8d-ccfeeeceb5d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5da92d9c-e6ee-4c5d-a529-4ae51dbee0ad"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e87fc7d-82a7-448b-ae7f-7a86d42f176a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("682d860a-71d4-4c04-80f0-7270c1511a8b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f73ae22-759e-462a-8c09-e84bcb75ceb7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7a82ffc-056b-4a0b-9952-04107295a85d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("c7b332a4-f14b-4817-bcae-41153555f763"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c9ebf89-7041-4580-8275-9a2614fd9aa8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e36cd70b-83ab-4a3b-8b8a-4204692cf933"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("8bef552b-f986-423d-8a06-6c3d6b9b63d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(490, 114),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e36cd70b-83ab-4a3b-8b8a-4204692cf933"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33b62ae0-13a6-427e-b463-e28897a12915"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsValidDataConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsValidDataConditionalFlow",
				UId = new Guid("790b15f8-8148-4611-b255-28a6d21fa93a"),
				ConditionExpression = @"IsValidData",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CurveCenterPosition = new Point(486, 167),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e36cd70b-83ab-4a3b-8b8a-4204692cf933"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd4067a8-f715-45e1-a80f-337c807fa288"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("144cfc86-08a7-4c09-8550-4f9f61cf77eb"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(958, 929),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("2322931a-d1f7-4e0e-928b-ef4cdaea3ce7"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("144cfc86-08a7-4c09-8550-4f9f61cf77eb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"PageEventsLane",
				Position = new Point(29, 394),
				Size = new Size(929, 189),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaLane CreateButtonsLaneLane() {
			ProcessSchemaLane schemaButtonsLane = new ProcessSchemaLane(this) {
				UId = new Guid("58051f74-b076-4daf-8dc6-4aef548cd62c"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("144cfc86-08a7-4c09-8550-4f9f61cf77eb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ButtonsLane",
				Position = new Point(29, 0),
				Size = new Size(929, 389),
				UseBackgroundMode = false
			};
			return schemaButtonsLane;
		}

		protected virtual ProcessSchemaLane CreateRadioButtonsLaneLane() {
			ProcessSchemaLane schemaRadioButtonsLane = new ProcessSchemaLane(this) {
				UId = new Guid("000d9075-910a-4eb9-a61c-8ba68e0ecf29"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("144cfc86-08a7-4c09-8550-4f9f61cf77eb"),
				CreatedInOwnerSchemaUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"RadioButtonsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 588),
				Size = new Size(929, 341),
				UseBackgroundMode = false
			};
			return schemaRadioButtonsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("92e38030-7540-44bb-8310-873060a2b92a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58051f74-b076-4daf-8dc6-4aef548cd62c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"CancelButtonClickEventSubProcess",
				Position = new Point(35, 252),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(208, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5a24ef5f-54d6-4495-acf1-2fbbdd608e9b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92e38030-7540-44bb-8310-873060a2b92a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("033531b8-ea88-4c09-9168-2a46cf9f4bf3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92e38030-7540-44bb-8310-873060a2b92a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,160,144,205,48,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58051f74-b076-4daf-8dc6-4aef548cd62c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"OkButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(692, 228),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1cf94e34-2bef-435e-a2d8-ccbf166f8b86"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(29, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dd4067a8-f715-45e1-a80f-337c807fa288"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(477, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,65,107,2,49,16,133,207,93,216,255,48,120,202,130,228,15,104,5,81,43,161,197,30,108,79,165,135,213,76,101,100,77,36,51,139,93,138,255,189,73,164,110,41,245,148,228,229,123,239,205,60,17,203,120,78,91,33,239,234,208,141,89,2,185,221,16,252,102,143,91,153,76,128,4,15,12,247,176,68,89,216,248,176,38,9,170,26,149,197,109,91,118,69,147,107,155,38,130,27,239,27,32,94,225,201,92,244,11,174,13,175,34,240,28,22,135,163,116,42,253,25,155,130,233,3,212,21,175,224,171,44,238,126,2,241,4,183,107,243,84,25,213,83,107,213,192,216,193,16,150,45,89,29,179,210,169,42,253,226,215,217,164,170,43,204,153,78,183,36,157,1,27,198,223,165,15,228,108,191,123,6,185,111,154,53,88,135,127,155,251,133,206,101,49,101,166,157,251,19,147,254,94,25,195,204,59,135,121,43,189,198,8,122,55,175,165,126,139,178,224,167,60,98,247,30,199,200,189,209,16,80,218,224,64,66,139,163,111,144,107,225,214,191,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateGetIsValidInputDataScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1c9ebf89-7041-4580-8275-9a2614fd9aa8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"GetIsValidInputDataScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,107,194,48,20,198,207,21,252,31,50,79,237,165,140,93,157,3,117,58,10,106,71,59,118,15,205,107,27,150,38,37,121,113,150,233,255,190,164,93,17,241,176,75,8,239,125,249,222,239,125,73,204,39,21,156,189,82,164,100,65,222,105,5,113,198,171,26,63,84,6,148,173,107,40,190,86,234,20,247,23,96,228,124,190,209,172,107,42,43,248,79,149,65,163,142,119,170,249,116,114,164,154,52,96,140,211,26,55,93,194,55,217,113,131,207,6,53,151,213,75,248,20,57,17,47,73,248,144,92,49,35,242,51,157,4,227,179,120,201,88,152,215,202,10,150,131,128,2,83,9,169,222,43,13,105,11,154,34,87,114,63,72,99,231,96,193,59,94,6,211,30,113,211,180,66,117,0,38,163,140,171,149,69,84,114,36,28,38,121,200,146,11,4,109,198,132,214,74,34,45,112,219,87,55,140,99,236,193,114,101,117,1,241,150,75,54,116,204,155,86,182,93,117,7,218,64,56,187,170,103,30,34,240,8,127,190,206,208,74,36,139,5,121,244,217,141,213,196,44,101,183,131,18,55,167,86,187,37,220,46,7,43,68,170,29,52,118,97,20,121,188,32,185,249,193,146,10,3,222,254,54,161,196,28,20,230,208,35,15,169,164,173,63,205,93,56,193,165,15,104,127,253,150,209,200,53,53,160,213,146,160,182,48,255,5,61,170,222,211,58,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("e36cd70b-83ab-4a3b-8b8a-4204692cf933"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateShowMassageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("33b62ae0-13a6-427e-b463-e28897a12915"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"ShowMassageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(477, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,65,11,194,48,12,133,207,22,250,31,114,108,97,236,15,76,5,245,58,97,7,209,115,112,113,22,106,39,73,39,136,248,223,173,172,245,228,45,121,47,95,222,235,112,160,122,139,66,123,18,73,115,135,129,124,189,243,132,108,108,163,213,3,25,110,179,37,176,2,211,58,137,75,137,236,194,176,182,153,145,116,119,25,153,240,124,53,179,85,16,112,225,71,91,120,105,181,232,254,230,109,250,62,239,230,136,222,245,24,221,24,178,114,112,209,83,85,222,84,80,228,231,157,234,19,114,72,113,223,162,111,173,152,226,196,1,34,79,212,124,0,112,28,171,0,216,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d8e88eed-bfb2-412d-806c-f2e77bde2f99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8f17f60d-2cfd-4174-81c3-d19e103b6fb4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("456be734-98b3-4bf5-b071-1b32916f1035"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(624, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3c9cfbfc-8431-45c7-bae6-e512afc62d03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2322931a-d1f7-4e0e-928b-ef4cdaea3ce7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 168),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("54119caa-e8c2-44e0-bd71-c8d088774367"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c9cfbfc-8431-45c7-bae6-e512afc62d03"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8883bdaf-2867-46a5-9f79-3fa58a6de071"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c9cfbfc-8431-45c7-bae6-e512afc62d03"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,201,76,204,201,172,74,13,72,76,79,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,212,175,194,53,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e2c0638-cdd0-418b-bdf8-3bebe6b713a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2322931a-d1f7-4e0e-928b-ef4cdaea3ce7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("df5349ef-7600-4922-99bd-b033eb4d6f63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e2c0638-cdd0-418b-bdf8-3bebe6b713a3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("02643dba-1045-4e7f-b283-8cd3af8c4c2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e2c0638-cdd0-418b-bdf8-3bebe6b713a3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,72,204,75,201,73,245,207,11,72,76,79,245,201,79,76,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,128,109,245,165,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("15ec5ef5-d493-496c-bd21-da8dd89162a7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("000d9075-910a-4eb9-a61c-8ba68e0ecf29"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(256, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAllRolesAndUsersRadioButtonCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ebc4924a-fc65-4861-9eb7-a6e8caa676cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15ec5ef5-d493-496c-bd21-da8dd89162a7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AllRolesAndUsersRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"AllRolesAndUsersRadioButtonCheckStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAllRolesAndUsersRadioButtonCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0745fd0f-df72-499b-b91d-7b18a9bb081e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("15ec5ef5-d493-496c-bd21-da8dd89162a7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"AllRolesAndUsersRadioButtonCheckScriptTask",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,49,14,130,64,16,69,107,73,184,3,118,208,112,1,43,36,244,4,163,253,232,126,116,227,184,131,179,179,5,49,222,93,66,101,172,236,255,251,239,249,177,40,183,61,93,81,55,204,131,48,98,19,220,49,66,227,64,206,203,62,153,73,168,219,27,46,119,184,170,120,229,217,70,97,73,67,97,154,176,203,179,119,158,29,96,93,160,51,195,181,18,76,133,99,175,50,65,109,46,71,226,136,106,153,173,138,238,49,177,204,64,79,74,15,24,244,68,156,208,57,111,245,242,49,224,153,188,194,253,64,107,212,191,196,119,219,7,49,200,30,18,219,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("78c83aad-44ef-46ec-9498-8843997d3388"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("000d9075-910a-4eb9-a61c-8ba68e0ecf29"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EventSubProcess3",
				Position = new Point(36, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmployeeRadioButtonCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5da92d9c-e6ee-4c5d-a529-4ae51dbee0ad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78c83aad-44ef-46ec-9498-8843997d3388"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EmployeeRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EmployeeRadioButtonCheckStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeeRadioButtonCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6e87fc7d-82a7-448b-ae7f-7a86d42f176a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78c83aad-44ef-46ec-9498-8843997d3388"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EmployeeRadioButtonCheckScriptTask",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,59,14,194,48,16,68,107,34,229,14,161,11,77,56,0,162,224,147,130,2,41,10,159,126,137,7,98,225,216,97,189,46,34,196,221,33,8,16,84,244,251,222,204,172,62,38,233,176,160,19,178,188,105,141,235,128,146,148,118,243,32,226,108,182,168,81,157,161,70,201,53,142,6,12,9,108,19,225,128,73,28,221,226,104,3,201,45,29,12,212,194,89,97,103,124,193,174,5,75,151,30,201,120,140,30,103,63,234,130,152,26,8,120,79,38,32,87,90,178,151,32,153,190,189,255,128,71,104,137,75,208,12,149,246,200,39,164,116,6,254,15,240,169,53,30,207,188,215,39,187,178,149,9,10,106,73,66,79,100,219,181,240,107,106,211,126,18,85,178,169,106,52,180,91,169,158,250,254,192,29,227,28,203,231,57,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8938bc27-2909-4fde-aa25-28db37553dcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("000d9075-910a-4eb9-a61c-8ba68e0ecf29"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EventSubProcess4",
				Position = new Point(316, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEmployeesRadioButtonCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f73ae22-759e-462a-8c09-e84bcb75ceb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8938bc27-2909-4fde-aa25-28db37553dcf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EmployeesRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EmployeesRadioButtonCheckStartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmployeesRadioButtonCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c7a82ffc-056b-4a0b-9952-04107295a85d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8938bc27-2909-4fde-aa25-28db37553dcf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EmployeesRadioButtonCheckScriptTask",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,177,14,130,64,16,68,107,73,248,135,179,131,134,31,48,54,18,172,9,38,246,43,55,232,197,227,14,246,246,10,98,252,119,145,104,162,86,214,59,239,205,172,233,84,182,174,233,140,162,234,7,235,39,32,52,164,141,223,69,17,239,138,242,130,246,10,157,171,91,154,172,24,18,217,41,225,136,77,154,220,211,228,0,169,28,157,44,116,233,157,176,183,161,102,63,128,101,202,58,178,1,249,28,91,220,207,51,181,178,55,86,192,149,54,82,188,56,181,125,235,190,54,212,196,212,99,206,30,201,70,44,192,220,213,96,140,134,161,127,228,141,183,8,255,18,159,63,60,0,176,146,145,19,252,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0d3459c9-e871-4413-9ba5-489133ff0a0b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("000d9075-910a-4eb9-a61c-8ba68e0ecf29"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"EventSubProcess2",
				Position = new Point(322, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRolesRadioButtonCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f9a27859-8249-4317-9683-68974dee3743"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0d3459c9-e871-4413-9ba5-489133ff0a0b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RolesRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"RolesRadioButtonCheckStartMessage",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRolesRadioButtonCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3ffe92d2-8137-4541-aff0-73a054afba98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0d3459c9-e871-4413-9ba5-489133ff0a0b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Name = @"RolesRadioButtonCheckScriptTask",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,187,110,194,64,16,69,107,44,249,31,156,206,52,230,3,80,10,30,46,40,144,44,59,208,15,158,11,172,88,239,154,217,217,194,138,242,239,1,148,0,21,244,231,156,59,26,179,207,242,143,138,14,40,106,111,17,106,98,227,231,81,213,187,98,113,68,123,2,143,179,239,52,25,9,52,138,203,84,34,166,105,242,147,38,13,180,116,180,179,224,133,119,42,222,134,74,124,15,209,33,223,147,13,24,95,176,71,183,34,161,14,10,217,146,141,40,217,104,241,103,103,159,255,209,151,244,101,174,198,57,26,1,231,87,254,158,47,187,222,250,1,120,227,220,111,154,76,102,33,152,131,91,185,214,70,6,47,73,233,166,124,13,61,194,154,250,188,25,194,140,59,227,54,206,104,211,30,209,209,102,197,87,245,249,7,191,73,194,184,47,56,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetEditedItemsMethod());
			Methods.Add(CreateFindEditedItemMethod());
			Methods.Add(CreateGetDesignedProcessSchemaMethod());
			Methods.Add(CreateShowProcessSchemaExplorerMethod());
			Methods.Add(CreateForceGetProcessSchemaExplorerMethod());
			Methods.Add(CreateClearFilterEditMethod());
			Methods.Add(CreateCreateProcessSchemaExplorerMethod());
			Methods.Add(CreateRolesParameterValueEdit_ShowMappingWindowMethod());
			Methods.Add(CreateSetFilterDataValueTypeIdParameterEditMethod());
			Methods.Add(CreateClearParameterValueEditControlMethod());
			Methods.Add(CreateInitRolesParameterValueEditMethod());
			Methods.Add(CreateInitEmployeeParameterValueEditMethod());
			Methods.Add(CreateSetEnabledControlsPropertyMethod());
			Methods.Add(CreateAssignEditedItemMethod());
			Methods.Add(CreateAssignControlValuesMethod());
			Methods.Add(CreateAssignShowMappingWindowEventMethod());
			Methods.Add(CreateEmployeeParameterValueEdit_ShowMappingWindowMethod());
			Methods.Add(CreateHandleOnPageLoadedMethod());
			Methods.Add(CreateInitializePageMethod());
			Methods.Add(CreateAssignIncludedDataValueTypesMapMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bbade363-be8c-4c87-8b52-f1efacd7aed4"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ecb18468-0b11-44f0-b175-94ba323f9853"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("14b62c8a-1e84-40df-8dd4-8fc7c0ca4094"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec439e80-3be7-4fa6-87dc-2510c7bf0362"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
		}

		protected virtual SchemaMethod CreateGetEditedItemsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dd7bb7a7-3fce-418a-8145-c9b37beb01cb"),
				Name = "GetEditedItems",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,44,73,205,45,86,176,85,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,78,45,46,6,210,46,137,37,137,209,64,225,146,212,138,18,239,212,202,88,133,196,98,5,159,204,226,18,27,151,76,176,186,196,162,74,155,226,146,162,204,188,116,29,133,252,164,44,160,102,59,59,107,174,204,52,5,13,168,185,182,10,121,165,57,57,154,10,213,92,156,48,155,242,82,203,9,154,161,161,105,205,85,203,85,148,90,82,90,148,7,113,162,53,0,165,106,219,202,173,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindEditedItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8746e10f-2adf-4d6d-96de-bcc832bcfca2"),
				Name = "FindEditedItem",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "Dictionary<string, object>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("057867f7-2d53-4c3c-9fb0-1f40478bf272"),
				Name = "items",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Dictionary<string, object>>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,203,47,74,77,76,206,208,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,200,79,202,74,77,46,177,83,200,44,73,205,85,200,204,3,211,197,154,10,213,92,156,153,105,10,26,26,16,101,154,32,209,104,37,207,20,165,88,5,91,91,5,79,32,207,51,5,172,136,179,40,181,164,180,8,162,205,154,139,179,150,171,150,11,42,146,87,154,147,99,13,0,182,220,113,59,121,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDesignedProcessSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("306f8782-3c4f-4ce8-9b02-26325f51190c"),
				Name = "GetDesignedProcessSchema",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "ProcessSchema"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,40,202,79,78,45,46,14,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,113,73,45,206,76,207,243,204,43,46,73,204,75,78,213,64,213,165,163,224,154,146,89,2,209,19,234,153,162,105,13,0,27,32,176,57,92,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowProcessSchemaExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bb1a78c5-acf5-4d70-afd7-172c4c099426"),
				Name = "ShowProcessSchemaExplorer",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1f1fea5b-06e4-408a-ac2e-bf14b2e73f19"),
				Name = "value",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cc84e077-3277-489b-904f-c20d96cd05b1"),
				Name = "processSchemaExplorer",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "SchemaStructureExplorer",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,40,40,202,79,78,45,46,14,78,206,72,205,77,116,173,40,200,201,47,74,45,82,176,181,85,200,43,205,201,209,84,168,230,229,226,44,74,45,41,45,202,179,230,229,170,229,229,194,170,92,47,56,35,191,220,53,37,179,36,60,51,47,37,191,92,3,196,132,168,8,245,76,209,81,40,75,204,41,77,213,81,0,137,186,230,164,230,166,230,149,0,133,53,173,1,230,143,205,11,126,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateForceGetProcessSchemaExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ad366bca-d64c-4922-a450-a3fa4d1c3ce7"),
				Name = "ForceGetProcessSchemaExplorer",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "SchemaStructureExplorer"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a26091c2-c90c-4662-b19b-2508a4aa9f87"),
				Name = "includedDataValueTypesMap",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<Guid, Guid>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,193,106,195,48,12,134,207,41,244,29,212,155,3,37,47,208,109,48,178,81,74,41,4,82,118,23,182,74,204,188,52,200,49,52,148,190,251,236,120,131,14,108,70,47,194,216,191,244,125,88,173,236,232,11,219,145,157,28,29,211,251,101,48,103,38,6,155,185,127,134,222,25,179,89,46,244,9,196,206,54,124,150,100,109,59,167,127,67,53,19,142,164,74,184,46,23,69,126,144,104,211,79,101,114,168,71,22,129,169,123,105,156,34,245,134,35,126,160,113,116,156,6,178,7,28,96,21,221,34,54,199,173,118,201,254,170,54,132,44,202,64,41,78,62,136,178,19,123,154,230,68,131,154,159,182,78,171,53,132,250,2,159,119,15,160,123,200,58,253,184,60,42,243,170,148,184,103,84,222,100,253,135,90,205,167,168,123,11,37,249,103,254,147,51,228,208,232,251,110,64,198,210,63,123,138,235,76,2,242,219,152,213,30,151,242,78,76,254,174,207,102,190,1,49,244,24,67,177,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("59a890cf-a2bb-4ef0-86af-1e1c2df05b87"),
				Name = "ClearFilterEdit",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,203,204,41,73,45,114,77,201,44,113,47,202,47,45,80,176,85,8,72,76,79,213,115,205,43,201,44,169,116,73,44,73,12,206,47,45,74,78,213,115,203,204,75,113,3,171,45,6,43,116,170,244,75,204,77,213,0,43,118,206,207,43,73,76,46,113,131,27,165,231,134,106,42,72,169,166,53,47,23,154,101,122,206,57,169,137,69,26,154,214,0,11,68,9,95,137,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateProcessSchemaExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9a6015d5-63e4-4b69-a25a-a6dfbddcdd69"),
				Name = "CreateProcessSchemaExplorer",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "SchemaStructureExplorer"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1bd8ce54-ab75-4917-9a75-3e8698df5d28"),
				Name = "includedDataValueTypesMap",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<Guid, Guid>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,205,106,195,48,12,199,207,45,244,29,212,158,18,8,121,129,110,131,145,149,81,182,142,176,110,187,139,88,105,205,28,39,56,246,182,48,242,238,147,155,12,82,154,22,122,241,151,164,223,95,146,245,133,6,42,83,102,84,215,219,108,79,5,174,126,42,85,26,50,112,11,154,190,161,123,220,90,227,50,235,12,253,91,131,20,119,20,111,80,234,164,212,214,148,234,25,155,210,217,8,22,233,16,118,18,183,136,32,71,85,83,191,133,203,217,116,84,157,209,154,21,204,11,22,196,153,28,83,123,219,226,108,240,90,103,202,9,18,15,104,241,3,149,163,183,166,162,58,78,20,161,9,188,166,204,33,144,163,78,27,172,96,206,165,59,165,66,248,157,77,39,57,19,49,219,7,79,212,28,188,82,148,230,230,209,73,17,129,95,239,224,115,96,0,169,225,44,183,227,77,174,74,249,94,136,96,40,16,115,26,209,145,100,124,56,249,162,38,237,108,218,2,113,91,15,66,87,235,248,114,252,237,125,221,215,22,175,138,202,54,30,221,118,45,155,175,235,116,140,154,112,139,44,137,240,130,238,43,237,100,109,169,107,63,227,46,147,248,203,121,114,136,93,13,241,248,232,241,17,93,254,1,55,10,45,37,189,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRolesParameterValueEdit_ShowMappingWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("519b33d8-f597-4da8-b8d5-d40597d3e0df"),
				Name = "RolesParameterValueEdit_ShowMappingWindow",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f56054a6-d19e-49f6-8d4c-3193c5e861df"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("309971e7-8a30-4095-a667-803c0509c34f"),
				Name = "e",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,203,10,130,64,20,134,215,9,190,195,44,21,98,94,64,92,72,73,184,8,36,177,214,131,115,212,3,206,81,102,70,69,162,119,79,140,164,203,162,150,231,191,124,135,127,16,154,117,66,11,5,22,52,11,153,151,234,182,0,99,178,162,6,37,210,167,115,22,77,15,177,68,235,27,32,9,58,112,157,225,181,185,248,63,234,254,154,230,203,61,51,176,100,222,59,131,159,160,4,13,84,192,3,145,39,146,133,33,59,244,40,121,172,58,59,249,236,234,58,155,63,74,44,155,76,36,21,82,78,104,87,125,126,122,115,157,200,24,172,40,171,219,241,40,186,14,169,186,32,201,118,140,7,32,235,165,162,154,137,109,3,230,123,62,223,53,56,103,146,253,246,99,187,31,220,1,142,135,142,218,74,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetFilterDataValueTypeIdParameterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0f9266c9-8b0b-444f-aaca-c8b3192101f5"),
				Name = "SetFilterDataValueTypeIdParameterEdit",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a7e73b82-8caf-4aa2-8fde-5e0ffbf38121"),
				Name = "parameterEditControls",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,193,107,194,48,20,198,207,19,252,31,66,47,166,115,4,221,105,80,51,112,110,3,217,14,130,186,139,122,136,38,213,199,186,164,164,169,34,218,255,125,73,91,102,213,50,6,59,5,222,251,242,251,242,189,60,8,17,142,153,102,95,194,8,253,194,193,12,148,52,90,69,9,162,20,201,52,138,208,241,136,106,5,100,160,82,105,156,172,227,163,67,179,113,163,133,73,181,12,154,141,172,217,216,50,141,146,37,178,8,177,67,99,163,65,174,159,82,136,184,208,184,123,255,128,110,127,67,250,22,145,44,73,63,142,133,228,216,195,97,42,87,6,148,196,254,193,115,189,80,105,193,86,27,132,223,196,254,131,69,169,24,49,208,189,36,55,185,67,197,249,88,107,128,64,214,27,23,1,78,166,117,34,98,237,156,125,69,230,145,68,152,87,136,172,240,153,25,150,63,102,178,143,197,144,219,228,63,207,230,213,214,116,200,203,24,85,142,27,151,147,141,180,218,130,29,18,53,27,72,72,181,18,56,73,152,91,37,180,218,32,101,49,184,130,218,57,97,119,11,104,39,128,94,41,35,145,144,107,179,9,160,221,246,15,39,38,45,219,51,88,92,131,32,196,69,123,214,89,80,218,226,231,81,91,53,121,74,121,119,65,47,195,7,75,251,121,159,65,150,101,87,62,255,30,58,158,123,127,98,230,87,200,68,189,171,157,221,71,255,146,63,183,144,156,147,157,237,97,230,227,178,62,98,107,65,250,156,143,87,26,98,131,173,102,162,138,29,119,176,111,254,119,63,185,82,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearParameterValueEditControlMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1eb1d304-b9cb-443c-9de4-9eab68593842"),
				Name = "ClearParameterValueEditControl",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("729350d4-3460-42e5-b2cb-4a7140a23788"),
				Name = "clientId",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,140,49,11,194,48,20,132,231,10,254,7,121,83,11,165,212,85,39,7,133,46,34,20,59,101,9,201,179,134,166,73,72,82,177,148,252,119,99,58,57,121,211,187,187,239,221,141,246,88,157,56,111,153,21,198,231,219,77,230,188,21,170,175,46,218,142,212,231,176,212,161,114,232,59,42,39,204,151,125,40,160,220,49,41,80,249,134,151,17,207,96,33,224,244,100,25,18,56,16,184,106,21,143,146,192,235,251,145,162,100,185,112,70,210,185,251,77,153,86,110,221,62,115,225,181,141,77,156,123,251,217,172,144,212,122,152,12,198,46,225,22,31,104,81,49,108,217,19,71,122,111,120,162,234,63,34,16,2,20,197,241,3,193,194,133,88,237,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitRolesParameterValueEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8b332324-da62-433e-9e60-429c95c1c34b"),
				Name = "InitRolesParameterValueEdit",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,203,110,219,48,16,60,215,128,255,129,208,37,18,42,48,237,185,77,1,191,82,24,104,2,35,182,219,67,80,20,172,180,178,153,82,164,74,174,236,40,134,254,189,75,41,9,164,56,141,143,90,237,12,103,102,119,119,194,50,87,185,81,154,75,189,214,18,87,85,1,236,130,133,82,99,180,2,107,133,51,25,242,137,177,192,167,99,190,124,209,201,215,14,236,167,225,96,33,54,192,111,140,2,183,16,86,228,128,96,191,11,85,194,44,149,200,191,25,243,167,44,46,165,162,170,227,163,52,13,53,236,217,84,38,40,141,22,182,250,236,208,74,189,137,153,249,125,7,9,126,97,7,54,28,188,99,135,32,49,121,33,172,116,70,251,183,130,152,181,28,147,94,153,95,27,156,253,45,133,170,227,22,165,32,195,217,125,97,193,57,226,159,24,85,230,122,33,112,75,248,224,165,254,70,100,240,132,44,29,76,165,43,148,168,218,122,204,50,161,28,176,58,126,20,100,229,102,219,225,238,123,117,212,239,141,181,46,110,127,146,141,163,96,235,122,56,168,35,10,236,252,252,205,200,70,119,226,126,182,3,141,142,47,183,102,127,37,138,130,18,250,33,117,106,246,188,249,193,222,95,176,255,160,127,29,65,232,65,153,177,112,238,230,36,68,10,37,31,32,61,198,69,236,64,54,45,96,105,53,33,72,106,55,174,101,178,133,92,172,231,41,109,135,159,250,196,104,13,205,8,249,76,163,196,170,109,184,18,154,140,89,254,21,112,142,144,143,171,107,122,37,236,5,31,68,156,104,232,133,29,237,94,209,147,65,220,62,194,133,53,9,69,220,50,246,133,54,26,111,32,3,11,58,129,174,168,87,197,250,201,78,5,138,6,235,71,208,246,182,43,249,248,237,123,186,68,62,139,30,65,207,153,247,211,107,234,212,41,180,83,199,240,100,179,239,251,20,202,91,160,80,118,50,165,104,79,249,57,69,54,41,29,154,156,230,151,201,205,243,57,182,159,126,100,97,224,104,127,90,70,223,191,50,70,141,75,68,163,253,5,161,165,195,136,58,43,76,4,203,196,202,2,195,101,115,198,252,210,216,92,96,24,28,62,212,220,1,30,207,42,60,59,124,172,207,34,98,123,91,166,146,180,231,243,105,252,250,100,73,195,63,176,33,99,240,188,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitEmployeeParameterValueEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("51975207-688e-4211-8650-bc891ab21019"),
				Name = "InitEmployeeParameterValueEdit",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,148,81,111,218,48,16,199,159,135,196,119,176,242,210,160,33,179,189,110,235,36,10,233,20,105,69,104,41,219,67,85,77,94,114,1,119,142,29,217,23,104,138,242,221,119,78,232,68,134,38,120,180,115,247,187,255,255,238,156,201,100,41,214,192,163,162,84,166,6,88,10,43,10,64,176,223,133,170,32,202,36,242,233,147,120,142,182,160,209,241,100,99,118,119,162,44,165,94,255,144,58,51,59,222,126,96,111,175,217,255,1,63,79,178,62,14,7,231,138,126,53,230,119,85,222,74,69,183,142,79,179,44,212,176,99,115,153,162,52,90,216,250,147,67,75,188,49,51,191,158,32,197,207,108,207,134,131,55,251,32,53,69,41,172,116,70,223,215,37,4,99,214,33,102,189,107,30,187,133,193,69,165,84,51,238,210,20,228,24,61,151,22,156,35,254,204,168,170,208,75,129,27,2,4,15,73,237,166,89,33,245,74,75,252,48,51,26,69,138,143,60,206,130,102,220,38,87,14,230,210,149,74,212,173,126,202,201,133,114,240,202,182,114,189,57,130,247,205,58,138,246,206,58,27,15,143,108,255,174,105,134,131,102,68,61,146,57,11,99,23,83,85,41,148,124,129,236,180,79,35,182,167,26,22,176,178,154,50,40,243,160,47,73,55,80,136,85,156,177,107,182,114,190,1,90,67,219,60,30,105,148,88,119,1,119,66,211,32,44,255,2,24,35,20,55,245,130,10,132,193,1,18,140,56,17,136,187,21,150,149,189,226,132,245,178,151,214,164,100,171,131,245,229,181,202,190,65,14,22,116,10,199,122,254,149,232,187,56,23,40,218,52,63,159,46,172,91,129,195,217,199,28,51,188,249,30,160,231,199,187,232,5,29,221,83,151,46,216,191,87,147,125,215,23,36,122,35,212,149,173,204,168,173,231,92,93,192,155,85,14,77,65,45,203,229,250,239,59,232,142,126,98,97,224,232,117,117,80,31,127,111,140,186,169,16,141,246,171,139,150,214,113,228,119,105,210,61,115,2,36,169,149,37,134,73,251,126,248,173,177,133,192,48,160,181,227,14,240,116,94,225,213,254,125,115,53,34,218,89,165,74,210,191,32,158,143,79,6,76,10,254,0,148,222,217,246,103,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledControlsPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e77dc499-4f03-4ee8-a926-781a0d8057e2"),
				Name = "SetEnabledControlsProperty",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a55a8392-311b-4b68-bc88-e2199ab7597b"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,202,207,73,45,14,72,44,74,204,77,45,73,45,10,75,204,41,77,117,77,201,44,209,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,121,185,2,64,90,92,115,11,114,242,43,83,83,73,211,229,156,159,87,146,152,92,226,150,153,3,212,129,83,49,0,64,236,122,61,148,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignEditedItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46e2c4f6-dfaa-47a0-815d-e540302bf278"),
				Name = "AssignEditedItem",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ab08127c-9171-4b94-bcc1-8776408d7847"),
				Name = "item",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,203,110,219,48,16,60,215,64,254,129,213,73,2,12,162,231,6,109,97,203,137,145,2,14,12,59,201,165,232,129,144,214,50,91,138,20,72,202,169,91,228,223,203,135,37,83,146,29,55,64,111,148,184,179,59,59,59,36,151,82,100,160,212,58,219,66,73,80,213,249,250,132,30,21,200,84,112,14,153,166,130,227,101,184,189,32,156,20,32,241,28,244,12,20,45,248,29,87,154,240,12,226,46,106,140,110,114,170,61,230,241,46,79,174,175,70,59,34,81,1,28,36,209,66,154,50,28,158,81,39,247,188,217,188,135,231,65,186,14,201,211,156,238,73,9,170,34,25,216,106,84,67,137,39,121,30,71,41,225,43,32,121,52,70,75,19,134,87,180,216,234,7,97,127,165,91,200,126,78,197,47,236,22,144,15,112,182,135,30,46,221,18,94,192,69,228,12,24,104,24,212,44,197,238,2,118,45,106,153,89,96,28,83,174,147,78,163,75,34,77,139,26,228,19,97,53,248,72,108,68,82,218,253,72,240,131,88,107,73,121,17,39,46,233,6,197,174,252,132,177,149,96,160,38,60,183,178,170,21,201,169,152,214,90,155,233,54,36,208,159,171,209,187,35,141,185,36,92,131,229,17,245,209,145,205,29,132,90,217,77,92,63,44,37,149,179,143,167,102,33,18,116,45,185,89,189,92,141,148,227,137,100,205,53,45,193,197,24,75,248,191,248,166,172,244,62,108,192,252,96,98,15,240,70,230,51,162,137,87,233,150,50,35,219,25,230,109,246,53,209,84,109,246,134,130,143,55,139,97,23,214,198,27,183,157,10,198,188,61,13,117,199,211,204,66,147,76,123,180,53,15,62,82,192,183,148,231,126,71,205,165,168,171,233,222,214,143,163,99,116,212,22,248,161,4,55,201,118,32,205,214,225,172,244,187,81,95,195,160,193,129,185,72,168,45,182,59,168,223,239,202,160,205,120,208,103,244,1,125,65,182,24,94,27,77,8,163,191,33,238,199,142,187,148,19,244,177,63,204,64,119,39,166,17,126,119,210,26,175,88,30,85,221,79,35,76,205,88,232,20,103,193,179,46,25,192,227,87,138,37,199,132,221,13,167,163,91,93,159,115,158,69,185,105,190,32,96,10,208,192,201,255,147,98,147,243,205,44,27,160,103,234,85,236,215,247,18,123,110,225,148,6,167,168,11,196,51,170,42,70,246,237,185,25,78,191,7,56,70,14,88,96,111,88,75,230,242,125,184,32,85,101,124,119,96,220,189,95,218,231,199,190,95,11,208,38,131,222,198,157,167,229,60,175,64,195,85,144,214,116,18,86,57,43,101,211,196,251,127,105,34,184,212,219,235,237,91,243,54,124,183,174,112,175,195,201,10,225,51,96,201,252,5,200,130,75,199,237,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4c5332cc-6437-4aa0-ab75-f6811b152336"),
				Name = "AssignControlValues",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8801fb46-0d3b-46ef-906f-3f68e30bef96"),
				Name = "item",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,93,111,218,48,20,125,166,82,255,131,151,23,66,21,133,247,109,76,162,192,170,78,91,135,160,237,203,182,7,47,185,80,111,198,102,182,195,198,42,254,251,174,237,4,66,146,82,152,250,130,192,62,247,220,115,63,241,152,206,33,30,72,97,104,98,222,51,110,64,141,82,102,226,145,160,223,57,164,164,71,102,148,107,120,115,126,198,102,36,100,6,22,164,215,35,34,227,188,67,30,207,207,90,99,107,222,231,124,34,57,232,190,72,239,52,40,61,161,41,147,151,153,49,82,196,131,7,72,126,58,34,163,50,203,211,82,96,50,37,240,219,230,252,204,153,79,216,252,193,220,202,9,208,212,161,47,229,159,146,25,106,91,129,50,241,173,188,148,232,132,10,167,226,75,48,160,194,90,4,223,58,111,246,121,6,15,84,204,225,52,38,27,115,157,105,2,11,185,58,145,105,8,28,12,120,174,21,85,100,174,168,48,0,104,20,106,163,152,152,119,60,244,202,159,7,223,242,212,110,113,61,18,84,243,25,188,72,174,171,94,134,212,208,169,204,84,2,190,238,185,23,43,122,230,14,52,18,121,177,247,148,103,40,149,80,77,124,16,150,219,242,189,242,63,227,107,125,131,45,241,89,141,22,75,179,14,115,243,142,39,116,140,63,180,20,121,214,64,33,175,128,223,164,42,64,127,40,131,66,107,218,178,49,226,145,128,196,48,41,34,50,110,110,215,29,149,205,123,171,20,196,64,114,238,141,209,171,117,16,15,1,57,25,229,236,47,20,74,35,98,214,75,144,179,176,42,105,103,221,137,136,19,100,133,127,100,218,188,221,19,251,142,60,86,66,220,116,108,182,158,230,115,50,109,10,107,50,95,149,231,171,28,138,141,244,74,201,108,137,145,184,60,140,132,97,102,189,243,17,191,103,34,205,115,233,128,151,235,27,186,128,154,139,216,158,250,68,149,36,236,232,43,10,90,205,206,6,153,82,32,204,20,123,45,193,46,179,222,157,231,216,143,77,149,53,247,183,113,159,39,50,246,211,180,22,132,231,179,116,155,98,54,234,125,49,5,179,227,15,27,189,58,30,127,179,88,114,185,6,120,102,166,158,112,181,219,152,77,195,215,237,250,73,33,9,103,24,226,245,144,248,28,231,91,98,101,7,172,182,35,242,177,203,49,41,211,75,78,215,247,141,80,91,209,45,82,187,192,44,102,172,100,2,90,79,147,7,88,208,49,85,136,66,189,142,34,143,126,36,178,69,140,55,26,194,124,6,158,183,137,42,206,253,113,190,63,159,182,182,105,34,203,250,209,54,19,213,13,101,23,93,121,247,185,197,119,68,113,28,174,238,187,161,68,7,225,216,60,19,248,149,49,5,105,104,13,92,167,52,234,63,68,99,141,186,221,82,217,15,250,28,228,56,111,213,215,154,205,197,181,72,120,150,66,106,123,214,33,111,177,80,250,19,93,134,211,181,238,167,11,38,238,4,51,62,227,119,215,169,147,217,189,168,105,197,185,156,1,206,87,2,91,40,170,105,164,56,38,53,238,71,184,239,194,185,190,232,98,199,19,192,87,3,169,22,180,152,176,114,81,139,179,35,234,90,64,143,47,237,1,139,19,171,251,52,83,115,129,15,120,62,173,198,249,166,249,207,242,86,173,143,204,204,225,226,250,73,109,202,85,249,143,163,188,254,236,86,218,199,163,182,58,65,188,175,6,109,43,49,78,139,205,230,87,92,29,80,112,175,154,237,135,251,59,180,188,82,107,96,39,168,89,43,98,109,5,246,118,237,139,46,82,124,89,78,221,69,88,188,35,117,162,216,210,118,99,254,226,194,194,38,212,132,69,219,69,36,136,117,81,183,175,193,99,219,235,106,191,110,7,81,174,49,10,218,81,219,229,197,159,186,175,17,22,202,158,151,51,225,175,203,39,104,186,249,26,116,130,237,3,25,255,144,167,78,80,232,117,217,139,139,238,63,106,189,129,62,76,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignShowMappingWindowEventMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("571e3323-15bb-4731-831c-2a5bb8dea33e"),
				Name = "AssignShowMappingWindowEvent",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("32f8311f-67ac-4c9d-aa70-112ac9819199"),
				Name = "parameterValueEditClientId",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3404a83e-4848-43ac-92d3-69bc90af50fd"),
				Name = "parameterValue",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaParameterValue",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,146,193,74,196,48,16,134,207,22,250,14,97,47,219,66,9,122,174,10,178,173,203,130,11,139,85,247,28,146,113,55,216,38,97,154,108,45,165,239,110,218,174,30,150,122,241,228,101,72,242,127,204,252,51,147,19,67,34,21,47,157,0,145,49,203,222,88,233,224,165,53,80,111,153,33,119,68,65,67,50,201,173,212,138,97,123,187,118,82,36,100,136,247,164,11,131,171,110,60,15,252,235,230,44,208,188,50,182,37,125,50,202,79,90,127,56,243,3,24,134,172,2,11,56,214,161,207,240,14,8,138,67,193,143,80,49,143,144,62,12,250,52,12,78,222,151,65,205,161,174,39,45,255,52,165,70,64,239,233,81,35,135,53,216,221,156,30,253,218,77,236,211,238,216,1,104,193,81,26,187,101,202,95,144,62,8,49,61,68,133,69,169,14,212,167,175,152,141,22,221,117,79,157,138,150,32,164,229,186,50,165,247,189,76,72,119,211,83,173,60,235,184,117,8,223,117,247,82,9,221,228,158,93,157,217,17,141,211,197,48,136,217,86,232,170,148,160,236,38,187,156,203,152,101,210,68,252,23,219,250,127,216,46,142,186,153,95,210,197,63,24,99,50,191,240,56,253,2,194,69,83,156,164,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEmployeeParameterValueEdit_ShowMappingWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("21ee41b0-f438-40c9-94ed-19dea1aa1e3f"),
				Name = "EmployeeParameterValueEdit_ShowMappingWindow",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5730e6b2-da21-4b99-b20c-e5383ec4ff9f"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("840a516d-b4ae-4014-b4c2-0326f8756b36"),
				Name = "e",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,205,10,131,48,16,132,207,21,124,135,28,13,148,188,128,120,40,86,138,135,130,84,218,158,23,179,106,64,147,144,68,69,74,223,189,214,82,233,207,161,61,238,206,204,55,76,15,134,104,48,208,162,67,67,34,18,100,70,21,104,109,94,212,216,66,246,84,78,208,116,152,112,225,168,69,201,209,132,190,215,191,38,103,253,71,156,46,110,54,223,19,67,148,36,120,103,176,3,150,104,80,22,248,64,28,83,78,162,136,236,58,193,89,210,106,55,82,114,241,189,213,31,33,18,43,233,160,112,203,107,234,187,250,222,198,90,81,201,188,86,195,30,180,22,178,58,11,201,213,144,244,40,93,144,65,133,247,154,70,141,136,223,227,89,220,136,201,150,110,215,31,203,105,120,3,31,111,32,139,72,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHandleOnPageLoadedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea9e3549-e333-4900-8091-76400152b851"),
				Name = "HandleOnPageLoaded",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,219,74,195,48,24,190,94,161,239,144,237,170,27,82,193,91,167,48,215,41,133,225,138,155,222,199,230,119,198,101,73,73,254,76,139,248,238,230,80,15,133,9,94,245,144,239,156,138,110,33,95,237,174,44,162,146,249,236,133,190,45,14,32,209,228,115,193,235,93,62,167,214,128,121,160,130,51,138,92,73,114,65,80,91,56,79,147,211,73,154,28,168,38,13,213,116,15,8,122,193,56,206,149,68,173,132,113,48,9,175,164,224,181,39,81,221,78,13,106,46,183,39,36,62,47,179,179,177,211,136,31,68,40,181,179,77,113,64,71,91,134,247,77,219,192,125,201,242,141,90,7,72,230,209,71,157,242,25,99,89,229,75,220,41,1,166,250,194,184,200,22,60,208,23,113,133,202,226,228,199,231,31,106,139,125,35,84,11,240,127,193,53,224,53,23,14,89,80,164,1,237,91,148,172,250,109,148,29,181,245,244,201,105,154,168,199,23,168,145,28,60,217,109,17,130,220,0,246,51,100,35,142,176,47,217,200,179,248,19,201,34,124,232,38,183,66,140,201,123,154,12,202,128,112,18,225,172,63,227,71,154,84,90,213,96,204,186,126,134,61,37,38,62,46,136,179,42,192,240,173,4,214,67,4,90,8,227,3,211,186,235,25,198,112,173,251,216,168,230,25,71,110,63,22,188,36,190,1,137,129,187,18,195,8,201,75,115,235,126,174,180,219,31,219,44,246,24,199,82,75,110,112,250,183,104,84,53,177,135,207,6,204,211,77,72,63,232,28,175,185,100,63,103,89,96,116,163,204,140,175,222,93,73,88,218,132,243,239,242,11,137,28,91,127,187,107,101,117,13,249,82,81,230,134,181,53,90,13,206,230,19,50,94,102,231,76,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializePageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d639f5a9-c98f-439b-a3ec-85493833199c"),
				Name = "InitializePage",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,111,75,195,48,16,198,95,111,176,239,16,251,42,5,217,7,240,47,232,202,8,58,25,110,243,125,104,206,25,76,147,146,92,113,85,252,238,94,90,113,86,219,33,248,46,144,231,249,221,221,115,167,31,25,63,18,65,88,141,90,26,253,10,106,41,189,44,0,193,63,72,83,65,166,52,166,236,109,50,30,205,43,173,214,117,9,27,161,216,57,219,4,240,215,206,90,200,81,59,59,157,73,148,141,62,42,22,210,202,45,248,233,28,80,32,20,87,245,29,1,121,18,1,73,58,37,255,41,225,110,157,123,174,202,127,1,91,196,30,73,118,132,29,222,64,77,188,37,57,162,161,59,14,79,2,132,64,5,72,68,198,181,91,161,215,118,203,211,232,143,179,174,242,39,40,100,219,146,133,23,22,155,230,67,172,210,187,156,112,173,71,168,14,240,139,152,25,40,192,226,31,145,176,119,12,1,219,114,159,153,196,36,14,76,91,236,85,63,199,125,159,140,227,214,239,157,129,240,123,231,141,36,254,103,69,105,92,13,48,36,57,124,58,212,26,250,10,72,168,233,208,68,88,126,79,44,219,17,218,211,218,61,72,4,213,158,217,76,55,7,32,125,125,22,131,58,110,226,186,96,218,230,166,82,160,58,119,17,22,178,164,10,98,248,143,18,175,140,33,236,232,178,121,177,19,198,251,43,164,131,148,152,123,111,223,84,186,109,189,247,151,15,182,220,164,255,1,110,228,21,206,121,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAssignIncludedDataValueTypesMapMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4c65d74f-8506-4f7a-a2e3-4fef22e624af"),
				Name = "AssignIncludedDataValueTypesMap",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("86785092-6b50-414a-8152-bdc218748827"),
				Name = "referenceSchemaUId",
				CreatedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				ModifiedInSchemaUId = new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,0,145,118,10,153,121,201,57,165,41,169,41,46,137,37,137,97,137,57,165,169,33,149,5,169,197,190,137,5,214,188,92,153,105,10,26,69,169,105,169,69,169,121,201,169,193,201,25,169,185,137,161,158,41,10,138,182,96,189,122,174,185,5,37,149,154,10,213,188,92,156,56,77,81,176,85,200,75,45,87,112,193,110,57,72,43,103,53,152,3,210,0,52,92,7,201,104,133,90,29,136,188,79,126,126,118,105,1,92,5,22,39,213,2,21,214,2,93,92,171,144,154,83,156,74,216,73,165,57,57,32,213,188,92,158,120,84,225,14,26,0,204,6,50,70,76,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeleteRightsRecordEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22cc0063-9f83-4380-9952-f68dc7b96c22"));
		}

		#endregion

	}

	#endregion

}

