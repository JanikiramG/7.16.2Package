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
	using System.Linq;
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
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
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ReadDataUserTaskParametersPageSchema

	/// <exclude/>
	public class ReadDataUserTaskParametersPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _userTaskTitleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return _userTaskTitleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _objectEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return _objectEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _radioButtonCount;
		public Terrasoft.UI.WebControls.Controls.RadioButton RadioButtonCount {
			get {
				return _radioButtonCount;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _radioButtonFunction;
		public Terrasoft.UI.WebControls.Controls.RadioButton RadioButtonFunction {
			get {
				return _radioButtonFunction;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _functionTypeEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FunctionTypeEdit {
			get {
				return _functionTypeEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _functionColumnEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FunctionColumnEdit {
			get {
				return _functionColumnEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _radioButtonEntity;
		public Terrasoft.UI.WebControls.Controls.RadioButton RadioButtonEntity {
			get {
				return _radioButtonEntity;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayoutEntity;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutEntity {
			get {
				return _controlLayoutEntity;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _numberOfRecordsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout NumberOfRecordsControlLayout {
			get {
				return _numberOfRecordsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _readSomeTopRecordsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ReadSomeTopRecordsEdit {
			get {
				return _readSomeTopRecordsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _numberOfRecordsEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit NumberOfRecordsEdit {
			get {
				return _numberOfRecordsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _labelNumberOfRecords;
		public Terrasoft.UI.WebControls.Controls.Label LabelNumberOfRecords {
			get {
				return _labelNumberOfRecords;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayoutTreeGrid;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutTreeGrid {
			get {
				return _controlLayoutTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _treeGridRecordSorting;
		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGridRecordSorting {
			get {
				return _treeGridRecordSorting;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _setColumnsMenuButton;
		public Terrasoft.UI.WebControls.Controls.Button SetColumnsMenuButton {
			get {
				return _setColumnsMenuButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayoutSpecifyColumns;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutSpecifyColumns {
			get {
				return _controlLayoutSpecifyColumns;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _specifyEntityColumnsCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox SpecifyEntityColumnsCheckBox {
			get {
				return _specifyEntityColumnsCheckBox;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _specifyEntityColumnsButton;
		public Terrasoft.UI.WebControls.Controls.Button SpecifyEntityColumnsButton {
			get {
				return _specifyEntityColumnsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return _filterControlLayout;
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

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _entityDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return _entityDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public ReadDataUserTaskParametersPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ReadDataUserTaskParametersPageSchema(ReadDataUserTaskParametersPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			RealUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			Name = "ReadDataUserTaskParametersPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 500;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReadDataUserTaskParametersPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateUserTaskTitleEdit());
			ControlLayout1.InsertItem(1, CreateObjectEdit());
			TopControlLayout.InsertItem(1, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateRadioButtonCount());
			ControlLayout3.InsertItem(1, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateRadioButtonFunction());
			ControlLayout4.InsertItem(1, CreateFunctionTypeEdit());
			ControlLayout4.InsertItem(2, CreateFunctionColumnEdit());
			ControlLayout3.InsertItem(2, CreateRadioButtonEntity());
			ControlLayout3.InsertItem(3, CreateControlLayoutEntity());
			ControlLayoutEntity.InsertItem(0, CreateNumberOfRecordsControlLayout());
			NumberOfRecordsControlLayout.InsertItem(0, CreateReadSomeTopRecordsEdit());
			NumberOfRecordsControlLayout.InsertItem(1, CreateNumberOfRecordsEdit());
			NumberOfRecordsControlLayout.InsertItem(2, CreateLabelNumberOfRecords());
			ControlLayoutEntity.InsertItem(1, CreateControlLayoutTreeGrid());
			ControlLayoutTreeGrid.InsertItem(0, CreateTreeGridRecordSorting());
			ControlLayoutTreeGrid.InsertItem(1, CreateSetColumnsMenuButton());
			ControlLayoutEntity.InsertItem(2, CreateControlLayoutSpecifyColumns());
			ControlLayoutSpecifyColumns.InsertItem(0, CreateSpecifyEntityColumnsCheckBox());
			ControlLayoutSpecifyColumns.InsertItem(1, CreateSpecifyEntityColumnsButton());
			TopControlLayout.InsertItem(2, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateLabel1());
			FilterControlLayout.InsertItem(1, CreateFilterEdit());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			Controls.AddAt(3, CreateEntityDataSource());
			UpdateEntityDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateReadDataUserTaskParametersPageEventsProcessSchema() {
			var schema = new ReadDataUserTaskParametersPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("8b46f07a-d351-4054-83c1-f0d3aca168f5");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectEdit() {
			_objectEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectEdit.UId = new Guid("f142e18c-e863-4686-b544-585ee7d50e0c");
			_objectEdit.Name = "ObjectEdit";
			_objectEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_objectEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_objectEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectEdit.Tag = "";
			_objectEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectEdit.Image = new ControlImage {};
			_objectEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectEdit.Required = true;
			_objectEdit.LookupSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15");
			_objectEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _objectEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("9a46f13b-7ed4-409e-b3a8-11c167d73add");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayout1.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateRadioButtonCount() {
			_radioButtonCount = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_radioButtonCount.UId = new Guid("b6d66cf1-e0a8-4788-96ab-6f86605556bf");
			_radioButtonCount.Name = "RadioButtonCount";
			_radioButtonCount.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_radioButtonCount.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_radioButtonCount.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_radioButtonCount.AjaxEvents.Check.IsProcessEventHandler = true;
			_radioButtonCount.Tag = "";
			_radioButtonCount.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_radioButtonCount.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_radioButtonCount.AlignedByCaption = false;
			_radioButtonCount.GroupName = "ResultType";
			return _radioButtonCount;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateRadioButtonFunction() {
			_radioButtonFunction = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_radioButtonFunction.UId = new Guid("e8303e60-3e1c-4560-ac26-d4f2571453dd");
			_radioButtonFunction.Name = "RadioButtonFunction";
			_radioButtonFunction.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_radioButtonFunction.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_radioButtonFunction.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_radioButtonFunction.AjaxEvents.Check.IsProcessEventHandler = true;
			_radioButtonFunction.Tag = "";
			_radioButtonFunction.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_radioButtonFunction.Width = System.Web.UI.WebControls.Unit.Percentage(25);
			_radioButtonFunction.AlignedByCaption = false;
			_radioButtonFunction.GroupName = "ResultType";
			return _radioButtonFunction;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateFunctionTypeEdit() {
			_functionTypeEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_functionTypeEdit.UId = new Guid("1ed3e98c-1af8-4f05-b111-45dbd30b9570");
			_functionTypeEdit.Name = "FunctionTypeEdit";
			_functionTypeEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_functionTypeEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_functionTypeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_functionTypeEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_functionTypeEdit.Tag = "";
			_functionTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_functionTypeEdit.Image = new ControlImage {};
			_functionTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			_functionTypeEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_functionTypeEdit.AlignedByCaption = false;
			_functionTypeEdit.Margins = "0 -10";
			_functionTypeEdit.Enabled = false;
			return _functionTypeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateFunctionColumnEdit() {
			_functionColumnEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_functionColumnEdit.UId = new Guid("51c2e317-4791-462d-926d-a547ccbdeb29");
			_functionColumnEdit.Name = "FunctionColumnEdit";
			_functionColumnEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_functionColumnEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_functionColumnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_functionColumnEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_functionColumnEdit.Tag = "";
			_functionColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_functionColumnEdit.Image = new ControlImage {};
			_functionColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_functionColumnEdit.AlignedByCaption = false;
			_functionColumnEdit.Margins = "0 0 0 15";
			_functionColumnEdit.Enabled = false;
			return _functionColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("6265dff7-7fbc-4b93-af6a-7804776c27ef");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayout4.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateRadioButtonEntity() {
			_radioButtonEntity = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_radioButtonEntity.UId = new Guid("397c4f4e-f348-486e-98e1-6f02cbb0a07b");
			_radioButtonEntity.Name = "RadioButtonEntity";
			_radioButtonEntity.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_radioButtonEntity.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_radioButtonEntity.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_radioButtonEntity.AjaxEvents.Check.IsProcessEventHandler = true;
			_radioButtonEntity.Tag = "";
			_radioButtonEntity.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_radioButtonEntity.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_radioButtonEntity.AlignedByCaption = false;
			_radioButtonEntity.GroupName = "ResultType";
			return _radioButtonEntity;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateReadSomeTopRecordsEdit() {
			_readSomeTopRecordsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_readSomeTopRecordsEdit.UId = new Guid("ec3723f8-552f-425d-8022-209841f91717");
			_readSomeTopRecordsEdit.Name = "ReadSomeTopRecordsEdit";
			_readSomeTopRecordsEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_readSomeTopRecordsEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_readSomeTopRecordsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_readSomeTopRecordsEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_readSomeTopRecordsEdit.Tag = "";
			_readSomeTopRecordsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_readSomeTopRecordsEdit.Width = System.Web.UI.WebControls.Unit.Pixel(100);
			_readSomeTopRecordsEdit.AlignedByCaption = false;
			_readSomeTopRecordsEdit.Enabled = false;
			return _readSomeTopRecordsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateNumberOfRecordsEdit() {
			_numberOfRecordsEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_numberOfRecordsEdit.UId = new Guid("382dcfeb-8f26-47b6-94a9-0978e750f114");
			_numberOfRecordsEdit.Name = "NumberOfRecordsEdit";
			_numberOfRecordsEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_numberOfRecordsEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_numberOfRecordsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_numberOfRecordsEdit.Tag = "";
			_numberOfRecordsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_numberOfRecordsEdit.Image = new ControlImage {};
			_numberOfRecordsEdit.Width = System.Web.UI.WebControls.Unit.Pixel(100);
			_numberOfRecordsEdit.Margins = "0 0 0 -10";
			_numberOfRecordsEdit.Enabled = false;
			return _numberOfRecordsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabelNumberOfRecords() {
			_labelNumberOfRecords = new Terrasoft.UI.WebControls.Controls.Label();
			_labelNumberOfRecords.UId = new Guid("cf6e800d-f854-4d11-8761-5714358d36ab");
			_labelNumberOfRecords.Name = "LabelNumberOfRecords";
			_labelNumberOfRecords.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_labelNumberOfRecords.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_labelNumberOfRecords.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_labelNumberOfRecords.Tag = "";
			_labelNumberOfRecords.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_labelNumberOfRecords.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_labelNumberOfRecords.Margins = "3 0 0 7";
			return _labelNumberOfRecords;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNumberOfRecordsControlLayout() {
			_numberOfRecordsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_numberOfRecordsControlLayout.UId = new Guid("4597bfd9-251e-4b1b-bd81-aedb04e66d54");
			_numberOfRecordsControlLayout.Name = "NumberOfRecordsControlLayout";
			_numberOfRecordsControlLayout.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_numberOfRecordsControlLayout.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_numberOfRecordsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_numberOfRecordsControlLayout.Tag = "";
			_numberOfRecordsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_numberOfRecordsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_numberOfRecordsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_numberOfRecordsControlLayout.FitHeightByContent = true;
			_numberOfRecordsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberOfRecordsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_numberOfRecordsControlLayout.Padding = "0 0 5 0";
			_numberOfRecordsControlLayout.StartNewAlignGroup = false;
			_numberOfRecordsControlLayout.Image = new ControlImage {};
			_numberOfRecordsControlLayout.Edges = "";
			return _numberOfRecordsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateTreeGridRecordSorting() {
			_treeGridRecordSorting = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_treeGridRecordSorting.UId = new Guid("ae9ebfa8-657f-4ed7-ba5a-cfa2a82a7425");
			_treeGridRecordSorting.Name = "TreeGridRecordSorting";
			_treeGridRecordSorting.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_treeGridRecordSorting.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_treeGridRecordSorting.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_treeGridRecordSorting.Tag = "";
			_treeGridRecordSorting.DataSourceId = "EntityDataSource";
			_treeGridRecordSorting.Edges = "1 1 1 1";
			_treeGridRecordSorting.IsColumnAutowidth = true;
			_treeGridRecordSorting.FooterVisible = false;
			_treeGridRecordSorting.IsMultilineMode = false;
			_treeGridRecordSorting.Height = System.Web.UI.WebControls.Unit.Pixel(27);
			_treeGridRecordSorting.IsSummaryVisible = false;
			_treeGridRecordSorting.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_treeGridRecordSorting.ToolbarVisible = false;
			_treeGridRecordSorting.QuickFilterVisible = false;
			_treeGridRecordSorting.HideHeaders = false;
			return _treeGridRecordSorting;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSetColumnsMenuButton() {
			_setColumnsMenuButton = new Terrasoft.UI.WebControls.Controls.Button();
			_setColumnsMenuButton.UId = new Guid("f9de7ab5-9ccc-4f74-b457-1eb85f32bd3e");
			_setColumnsMenuButton.Name = "SetColumnsMenuButton";
			_setColumnsMenuButton.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_setColumnsMenuButton.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_setColumnsMenuButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setColumnsMenuButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setColumnsMenuButton.Tag = "";
			_setColumnsMenuButton.Image = new ControlImage {};
			_setColumnsMenuButton.Margins = "3 0";
			return _setColumnsMenuButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutTreeGrid() {
			_controlLayoutTreeGrid = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutTreeGrid.UId = new Guid("cdf32a3b-7d12-4880-b200-53be030696d1");
			_controlLayoutTreeGrid.Name = "ControlLayoutTreeGrid";
			_controlLayoutTreeGrid.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayoutTreeGrid.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayoutTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayoutTreeGrid.Tag = "";
			_controlLayoutTreeGrid.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayoutTreeGrid.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayoutTreeGrid.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayoutTreeGrid.FitHeightByContent = true;
			_controlLayoutTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutTreeGrid.Padding = "0 0 5 0";
			_controlLayoutTreeGrid.StartNewAlignGroup = false;
			_controlLayoutTreeGrid.Image = new ControlImage {};
			_controlLayoutTreeGrid.Edges = "";
			return _controlLayoutTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateSpecifyEntityColumnsCheckBox() {
			_specifyEntityColumnsCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_specifyEntityColumnsCheckBox.UId = new Guid("3b037d61-e666-42b8-acc0-d39792312704");
			_specifyEntityColumnsCheckBox.Name = "SpecifyEntityColumnsCheckBox";
			_specifyEntityColumnsCheckBox.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_specifyEntityColumnsCheckBox.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_specifyEntityColumnsCheckBox.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_specifyEntityColumnsCheckBox.AjaxEvents.Check.IsProcessEventHandler = true;
			_specifyEntityColumnsCheckBox.Tag = "";
			_specifyEntityColumnsCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_specifyEntityColumnsCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(80);
			_specifyEntityColumnsCheckBox.AlignedByCaption = false;
			_specifyEntityColumnsCheckBox.Enabled = false;
			return _specifyEntityColumnsCheckBox;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSpecifyEntityColumnsButton() {
			_specifyEntityColumnsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_specifyEntityColumnsButton.UId = new Guid("dd2ffde1-2bc6-4058-bce9-8ef1ccafa0b9");
			_specifyEntityColumnsButton.Name = "SpecifyEntityColumnsButton";
			_specifyEntityColumnsButton.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_specifyEntityColumnsButton.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_specifyEntityColumnsButton.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_specifyEntityColumnsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_specifyEntityColumnsButton.Tag = "";
			_specifyEntityColumnsButton.Image = new ControlImage {};
			_specifyEntityColumnsButton.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _specifyEntityColumnsButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutSpecifyColumns() {
			_controlLayoutSpecifyColumns = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutSpecifyColumns.UId = new Guid("1770c9ca-7e5f-445a-960a-2b0e0dde20f7");
			_controlLayoutSpecifyColumns.Name = "ControlLayoutSpecifyColumns";
			_controlLayoutSpecifyColumns.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayoutSpecifyColumns.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayoutSpecifyColumns.CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251");
			_controlLayoutSpecifyColumns.Tag = "";
			_controlLayoutSpecifyColumns.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayoutSpecifyColumns.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayoutSpecifyColumns.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayoutSpecifyColumns.FitHeightByContent = true;
			_controlLayoutSpecifyColumns.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutSpecifyColumns.StartNewAlignGroup = false;
			_controlLayoutSpecifyColumns.Image = new ControlImage {};
			_controlLayoutSpecifyColumns.Edges = "";
			return _controlLayoutSpecifyColumns;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutEntity() {
			_controlLayoutEntity = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutEntity.UId = new Guid("ec22278d-7c4b-4040-98c9-948cc98a81a6");
			_controlLayoutEntity.Name = "ControlLayoutEntity";
			_controlLayoutEntity.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayoutEntity.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayoutEntity.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayoutEntity.Tag = "";
			_controlLayoutEntity.Height = System.Web.UI.WebControls.Unit.Pixel(150);
			_controlLayoutEntity.FitHeightByContent = true;
			_controlLayoutEntity.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutEntity.Padding = "0 0 0 15";
			_controlLayoutEntity.StartNewAlignGroup = false;
			_controlLayoutEntity.Image = new ControlImage {};
			_controlLayoutEntity.Edges = "";
			return _controlLayoutEntity;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("bfe7ce0f-d109-42a2-acdb-031bf0a0d972");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayout3.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(150);
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLabel1() {
			_label1 = new Terrasoft.UI.WebControls.Controls.Label();
			_label1.UId = new Guid("c0752970-23c6-415b-909e-5cda981d644a");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_label1.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("60cb99ab-da32-4b51-ad90-de80e24c90df");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_filterEdit.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.HasSplitter = true;
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterControlLayout() {
			_filterControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterControlLayout.UId = new Guid("874bdb1f-2fda-4a55-aa3a-2b1feb80130c");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("2b9ff127-adc6-462d-9622-714982d34184");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_entityDataSource.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("65dc3ebd-cd5e-45c9-a56c-de64a6708cd7");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
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
			return new ReadDataUserTaskParametersPageSchemaUserControl();
		}

		public override object Clone() {
			return new ReadDataUserTaskParametersPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ba077d3-6338-40e7-91f6-72bd49208660"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ReadDataUserTaskParametersPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataUserTaskParametersPageEventsProcess

	/// <exclude/>
	public class ReadDataUserTaskParametersPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ReadDataUserTaskParametersPageSchemaUserControl
	{

		#region Class: ChangeSchemaEntityUserMessageFlowElement

		/// <exclude/>
		public class ChangeSchemaEntityUserMessageFlowElement : QuestionUserTask
		{

			public ChangeSchemaEntityUserMessageFlowElement(UserConnection userConnection, ReadDataUserTaskParametersPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeSchemaEntityUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ReadDataUserTaskParametersPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReadDataUserTaskParametersPageEventsProcess";
			SchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8ba077d3-6338-40e7-91f6-72bd49208660");
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

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual bool IsFilterParamsValuesCorrect {
			get;
			set;
		}

		public virtual bool IsColumnStructureExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnStructureExplorer {
			get;
			set;
		}

		public virtual Object SelectedEntityColumns {
			get;
			set;
		}

		private bool _isSelectedAnyEntityColumns = true;
		public bool IsSelectedAnyEntityColumns {
			get {
				return _isSelectedAnyEntityColumns;
			}
			set {
				_isSelectedAnyEntityColumns = value;
			}
		}

		public virtual bool IsColumnStructureExplorerRegistered {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessOnInit;
		public ProcessFlowElement EventSubProcessOnInit {
			get {
				return _eventSubProcessOnInit ?? (_eventSubProcessOnInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessOnInit",
					SchemaElementUId = new Guid("fce45a8b-feff-462e-979e-71b9ee6390d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInit;
		public ProcessFlowElement StartMessageInit {
			get {
				return _startMessageInit ?? (_startMessageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInit",
					SchemaElementUId = new Guid("bb868588-b72c-4de2-974b-89e067f76301"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventInit;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventInit {
			get {
				return _intermediateThrowMessageEventInit ?? (_intermediateThrowMessageEventInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventInit",
					SchemaElementUId = new Guid("83edd0f3-e63c-4668-9fc0-bdb47bf56bb2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("32e5f3a4-6bfe-4610-88e2-4b52fa46f982"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
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
					SchemaElementUId = new Guid("526ec1cf-521c-475a-97b5-c632418ed617"),
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
					SchemaElementUId = new Guid("81336f9a-b9ec-4e36-865f-eed2b061e359"),
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
					SchemaElementUId = new Guid("2db048fb-62fc-4dc6-9110-46b3fbb6b6a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteChildScript;
		public ProcessScriptTask PageLoadCompleteChildScript {
			get {
				return _pageLoadCompleteChildScript ?? (_pageLoadCompleteChildScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteChildScript",
					SchemaElementUId = new Guid("db28b24b-a162-4a02-8672-91b94102c9e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptExecute,
				});
			}
		}

		private ProcessFlowElement _okButtonClickChildSubProcess;
		public ProcessFlowElement OkButtonClickChildSubProcess {
			get {
				return _okButtonClickChildSubProcess ?? (_okButtonClickChildSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OkButtonClickChildSubProcess",
					SchemaElementUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
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
					SchemaElementUId = new Guid("0575c6f7-4062-4dbb-ae9f-f5ac5099f08a"),
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
					SchemaElementUId = new Guid("b9497386-a058-4d1b-ad47-d96d78b3ec1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildOkButtonClick;
		public ProcessScriptTask ScriptChildOkButtonClick {
			get {
				return _scriptChildOkButtonClick ?? (_scriptChildOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildOkButtonClick",
					SchemaElementUId = new Guid("f83c7c63-e93d-40b1-8ec2-8b5c9122a7bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildOkButtonClickExecute,
				});
			}
		}

		private ProcessScriptTask _checkData_ScriptTask;
		public ProcessScriptTask CheckData_ScriptTask {
			get {
				return _checkData_ScriptTask ?? (_checkData_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckData_ScriptTask",
					SchemaElementUId = new Guid("e48c0bb1-1a35-451e-b273-fe73ed22aa07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckData_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("21913e8d-d6bf-4789-b93a-a4f7e9fbd908"),
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

		private ProcessScriptTask _errorMessage_ScriptTask;
		public ProcessScriptTask ErrorMessage_ScriptTask {
			get {
				return _errorMessage_ScriptTask ?? (_errorMessage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ErrorMessage_ScriptTask",
					SchemaElementUId = new Guid("315606ef-b9a9-4129-8c15-06acb6352fae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ErrorMessage_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySchemaEditChangeStartMessage;
		public ProcessFlowElement EntitySchemaEditChangeStartMessage {
			get {
				return _entitySchemaEditChangeStartMessage ?? (_entitySchemaEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySchemaEditChangeStartMessage",
					SchemaElementUId = new Guid("0565db16-6f2f-404d-8af3-bd93505423d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPrepareChangeSchemaEntityQuestion;
		public ProcessScriptTask ScriptTaskPrepareChangeSchemaEntityQuestion {
			get {
				return _scriptTaskPrepareChangeSchemaEntityQuestion ?? (_scriptTaskPrepareChangeSchemaEntityQuestion = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepareChangeSchemaEntityQuestion",
					SchemaElementUId = new Guid("d588e308-1f40-4322-9d9d-c1456464970b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepareChangeSchemaEntityQuestionExecute,
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
					SchemaElementUId = new Guid("6f6821c7-ec9e-43b4-9563-91876d004430"),
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

		private ChangeSchemaEntityUserMessageFlowElement _changeSchemaEntityUserMessage;
		public ChangeSchemaEntityUserMessageFlowElement ChangeSchemaEntityUserMessage {
			get {
				return _changeSchemaEntityUserMessage ?? (_changeSchemaEntityUserMessage = new ChangeSchemaEntityUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("871877ed-acc0-4394-99a5-f301d40747c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeSchemaEntityYesMessage;
		public ProcessFlowElement EventSubProcessChangeSchemaEntityYesMessage {
			get {
				return _eventSubProcessChangeSchemaEntityYesMessage ?? (_eventSubProcessChangeSchemaEntityYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeSchemaEntityYesMessage",
					SchemaElementUId = new Guid("3b58efef-3eee-4f2c-9fb5-27e930d8209e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityYesMessageBase;
		public ProcessFlowElement ChangeSchemaEntityYesMessageBase {
			get {
				return _changeSchemaEntityYesMessageBase ?? (_changeSchemaEntityYesMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityYesMessageBase",
					SchemaElementUId = new Guid("42a48851-809f-4d84-9c2d-5032f054a41b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptEntitySchemaEditChange;
		public ProcessScriptTask ScriptEntitySchemaEditChange {
			get {
				return _scriptEntitySchemaEditChange ?? (_scriptEntitySchemaEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEntitySchemaEditChange",
					SchemaElementUId = new Guid("94302525-8dd8-4732-a9ea-54f74c074171"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEntitySchemaEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeSchemaEntityNoMessage;
		public ProcessFlowElement EventSubProcessChangeSchemaEntityNoMessage {
			get {
				return _eventSubProcessChangeSchemaEntityNoMessage ?? (_eventSubProcessChangeSchemaEntityNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeSchemaEntityNoMessage",
					SchemaElementUId = new Guid("d4585bc0-3134-475a-b808-347912426115"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityNoMessageBase;
		public ProcessFlowElement ChangeSchemaEntityNoMessageBase {
			get {
				return _changeSchemaEntityNoMessageBase ?? (_changeSchemaEntityNoMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityNoMessageBase",
					SchemaElementUId = new Guid("7991a852-b003-42fd-a9bc-a68f740c4f56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptEntitySchemaEditNotChange;
		public ProcessScriptTask ScriptEntitySchemaEditNotChange {
			get {
				return _scriptEntitySchemaEditNotChange ?? (_scriptEntitySchemaEditNotChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEntitySchemaEditNotChange",
					SchemaElementUId = new Guid("5e553897-8444-4a15-9b52-57e8594e1629"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEntitySchemaEditNotChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessCount;
		public ProcessFlowElement EventSubProcessCount {
			get {
				return _eventSubProcessCount ?? (_eventSubProcessCount = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessCount",
					SchemaElementUId = new Guid("cb09a195-8dfc-4094-85a3-d15f19efa321"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageRadioButtonCountCheck;
		public ProcessFlowElement StartMessageRadioButtonCountCheck {
			get {
				return _startMessageRadioButtonCountCheck ?? (_startMessageRadioButtonCountCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRadioButtonCountCheck",
					SchemaElementUId = new Guid("14e4e359-66fd-4be4-a081-b51c7fc6d3d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskCountCheck;
		public ProcessScriptTask ScriptTaskCountCheck {
			get {
				return _scriptTaskCountCheck ?? (_scriptTaskCountCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCountCheck",
					SchemaElementUId = new Guid("5b15cac2-ff4e-4a1a-9b36-c7b9dd8208ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCountCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessEntity;
		public ProcessFlowElement EventSubProcessEntity {
			get {
				return _eventSubProcessEntity ?? (_eventSubProcessEntity = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessEntity",
					SchemaElementUId = new Guid("ae0e901c-3ebd-48a8-9147-8eed48e91583"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageRadioButtonEntityCheck;
		public ProcessFlowElement StartMessageRadioButtonEntityCheck {
			get {
				return _startMessageRadioButtonEntityCheck ?? (_startMessageRadioButtonEntityCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRadioButtonEntityCheck",
					SchemaElementUId = new Guid("5e09c491-06fb-499e-ae1f-fd3a2410fce2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskEntityCheck;
		public ProcessScriptTask ScriptTaskEntityCheck {
			get {
				return _scriptTaskEntityCheck ?? (_scriptTaskEntityCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskEntityCheck",
					SchemaElementUId = new Guid("998382e8-40c6-4062-836b-7c1822687d97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskEntityCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessFunction;
		public ProcessFlowElement EventSubProcessFunction {
			get {
				return _eventSubProcessFunction ?? (_eventSubProcessFunction = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessFunction",
					SchemaElementUId = new Guid("afd6728a-cd4f-48de-a4d3-b05c5847d6ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageFunctionCheck;
		public ProcessFlowElement StartMessageFunctionCheck {
			get {
				return _startMessageFunctionCheck ?? (_startMessageFunctionCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageFunctionCheck",
					SchemaElementUId = new Guid("2d7b1eee-5031-4edb-901a-0468dd8891c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskFunctionCheck;
		public ProcessScriptTask ScriptTaskFunctionCheck {
			get {
				return _scriptTaskFunctionCheck ?? (_scriptTaskFunctionCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskFunctionCheck",
					SchemaElementUId = new Guid("0f578e2e-4192-4b8d-86c9-cfa70f6630b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskFunctionCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessFunctionType;
		public ProcessFlowElement EventSubProcessFunctionType {
			get {
				return _eventSubProcessFunctionType ?? (_eventSubProcessFunctionType = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessFunctionType",
					SchemaElementUId = new Guid("330e0830-d008-4d09-882d-1a621ff12ae1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageFunctionTypeEditChange;
		public ProcessFlowElement StartMessageFunctionTypeEditChange {
			get {
				return _startMessageFunctionTypeEditChange ?? (_startMessageFunctionTypeEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageFunctionTypeEditChange",
					SchemaElementUId = new Guid("3d43fbc4-ccaf-4091-b0fb-e07ed074317f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskFunctionTypeEditChange;
		public ProcessScriptTask ScriptTaskFunctionTypeEditChange {
			get {
				return _scriptTaskFunctionTypeEditChange ?? (_scriptTaskFunctionTypeEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskFunctionTypeEditChange",
					SchemaElementUId = new Guid("db6e7a94-333c-4e5e-bd28-9f5142b0c8e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskFunctionTypeEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessFunctionColumnEditChange;
		public ProcessFlowElement EventSubProcessFunctionColumnEditChange {
			get {
				return _eventSubProcessFunctionColumnEditChange ?? (_eventSubProcessFunctionColumnEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessFunctionColumnEditChange",
					SchemaElementUId = new Guid("7327e493-7ed2-48f7-83d9-c29137ebdaf6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageFunctionColumnEditChange;
		public ProcessFlowElement StartMessageFunctionColumnEditChange {
			get {
				return _startMessageFunctionColumnEditChange ?? (_startMessageFunctionColumnEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageFunctionColumnEditChange",
					SchemaElementUId = new Guid("f6328f40-824c-4a16-b4fb-4b44fdb3869b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskFunctionColumnEditChange;
		public ProcessScriptTask ScriptTaskFunctionColumnEditChange {
			get {
				return _scriptTaskFunctionColumnEditChange ?? (_scriptTaskFunctionColumnEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskFunctionColumnEditChange",
					SchemaElementUId = new Guid("4871b103-1a1e-4d45-9f11-13b70ddf4e8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskFunctionColumnEditChangeExecute,
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
					SchemaElementUId = new Guid("5db1a1ec-eefa-4a7d-8cfe-6fec20b08e31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _specifyEntityColumnsCheckBoxCheckStartMessage;
		public ProcessFlowElement SpecifyEntityColumnsCheckBoxCheckStartMessage {
			get {
				return _specifyEntityColumnsCheckBoxCheckStartMessage ?? (_specifyEntityColumnsCheckBoxCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SpecifyEntityColumnsCheckBoxCheckStartMessage",
					SchemaElementUId = new Guid("de965e78-bf7c-4bbe-ae10-752eb2482ab7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _specifyEntityColumnsCheckBoxCheckScriptTask;
		public ProcessScriptTask SpecifyEntityColumnsCheckBoxCheckScriptTask {
			get {
				return _specifyEntityColumnsCheckBoxCheckScriptTask ?? (_specifyEntityColumnsCheckBoxCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SpecifyEntityColumnsCheckBoxCheckScriptTask",
					SchemaElementUId = new Guid("07b7b7d8-a42b-431b-bc8b-0b986a0e3f61"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SpecifyEntityColumnsCheckBoxCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("849be45f-0c77-489a-9c03-1259c8b00523"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _specifyEntityColumnsButtonClickStartMessage;
		public ProcessFlowElement SpecifyEntityColumnsButtonClickStartMessage {
			get {
				return _specifyEntityColumnsButtonClickStartMessage ?? (_specifyEntityColumnsButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SpecifyEntityColumnsButtonClickStartMessage",
					SchemaElementUId = new Guid("d02fe798-8ed3-43ca-9052-a045d515b224"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _specifyEntityColumnsScriptTask;
		public ProcessScriptTask SpecifyEntityColumnsScriptTask {
			get {
				return _specifyEntityColumnsScriptTask ?? (_specifyEntityColumnsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SpecifyEntityColumnsScriptTask",
					SchemaElementUId = new Guid("171427ba-8d81-429b-89aa-e5c0ac14c3b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SpecifyEntityColumnsScriptTaskExecute,
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
					SchemaElementUId = new Guid("f1894962-3ad0-4e7c-adac-4e2f6998fea2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageSetColumnsMenuButtonClick;
		public ProcessFlowElement StartMessageSetColumnsMenuButtonClick {
			get {
				return _startMessageSetColumnsMenuButtonClick ?? (_startMessageSetColumnsMenuButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageSetColumnsMenuButtonClick",
					SchemaElementUId = new Guid("21360584-d516-4823-8d92-adac38be592e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskSetColumnsMenuButtonClick;
		public ProcessScriptTask ScriptTaskSetColumnsMenuButtonClick {
			get {
				return _scriptTaskSetColumnsMenuButtonClick ?? (_scriptTaskSetColumnsMenuButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskSetColumnsMenuButtonClick",
					SchemaElementUId = new Guid("038bf8c8-b630-43b3-ac73-9140854077cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSetColumnsMenuButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7;
		public ProcessFlowElement EventSubProcess7 {
			get {
				return _eventSubProcess7 ?? (_eventSubProcess7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7",
					SchemaElementUId = new Guid("06e3b395-fc07-412f-9dce-21338111c62c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _readSomeTopRecordsEditCheckStartMessage;
		public ProcessFlowElement ReadSomeTopRecordsEditCheckStartMessage {
			get {
				return _readSomeTopRecordsEditCheckStartMessage ?? (_readSomeTopRecordsEditCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReadSomeTopRecordsEditCheckStartMessage",
					SchemaElementUId = new Guid("d4eeb3a5-b9ec-4b36-90df-c7745f0c14da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _readSomeTopRecordsEditCheckScriptTask;
		public ProcessScriptTask ReadSomeTopRecordsEditCheckScriptTask {
			get {
				return _readSomeTopRecordsEditCheckScriptTask ?? (_readSomeTopRecordsEditCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ReadSomeTopRecordsEditCheckScriptTask",
					SchemaElementUId = new Guid("208f2e2b-8ada-4c5a-a659-f7719579caa8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ReadSomeTopRecordsEditCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("7cefff1b-2b85-4a01-bc08-1d0c8d5f997a"),
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
					SchemaElementUId = new Guid("a0051c7d-bf15-494e-86a5-46a51dfd9797"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _changeSchemaEntityMessage;
		public LocalizableString ChangeSchemaEntityMessage {
			get {
				return _changeSchemaEntityMessage ?? (_changeSchemaEntityMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeSchemaEntityMessage.Value"));
			}
		}

		private LocalizableString _captionColumnCaption;
		public LocalizableString CaptionColumnCaption {
			get {
				return _captionColumnCaption ?? (_captionColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CaptionColumnCaption.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _validationMessage;
		public LocalizableString ValidationMessage {
			get {
				return _validationMessage ?? (_validationMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessage.Value"));
			}
		}

		private LocalizableString _isNotSelectedAnyEntityColumnsMessage;
		public LocalizableString IsNotSelectedAnyEntityColumnsMessage {
			get {
				return _isNotSelectedAnyEntityColumnsMessage ?? (_isNotSelectedAnyEntityColumnsMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.IsNotSelectedAnyEntityColumnsMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessOnInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOnInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[OkButtonClickChildSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildSubProcess };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptChildOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildOkButtonClick };
			FlowElements[CheckData_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckData_ScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ErrorMessage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorMessage_ScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[EntitySchemaEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChangeStartMessage };
			FlowElements[ScriptTaskPrepareChangeSchemaEntityQuestion.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareChangeSchemaEntityQuestion };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ChangeSchemaEntityUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityUserMessage };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[EventSubProcessChangeSchemaEntityYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeSchemaEntityYesMessage };
			FlowElements[ChangeSchemaEntityYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageBase };
			FlowElements[ScriptEntitySchemaEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEntitySchemaEditChange };
			FlowElements[EventSubProcessChangeSchemaEntityNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeSchemaEntityNoMessage };
			FlowElements[ChangeSchemaEntityNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageBase };
			FlowElements[ScriptEntitySchemaEditNotChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEntitySchemaEditNotChange };
			FlowElements[EventSubProcessCount.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessCount };
			FlowElements[StartMessageRadioButtonCountCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRadioButtonCountCheck };
			FlowElements[ScriptTaskCountCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCountCheck };
			FlowElements[EventSubProcessEntity.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessEntity };
			FlowElements[StartMessageRadioButtonEntityCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRadioButtonEntityCheck };
			FlowElements[ScriptTaskEntityCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskEntityCheck };
			FlowElements[EventSubProcessFunction.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessFunction };
			FlowElements[StartMessageFunctionCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageFunctionCheck };
			FlowElements[ScriptTaskFunctionCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskFunctionCheck };
			FlowElements[EventSubProcessFunctionType.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessFunctionType };
			FlowElements[StartMessageFunctionTypeEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageFunctionTypeEditChange };
			FlowElements[ScriptTaskFunctionTypeEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskFunctionTypeEditChange };
			FlowElements[EventSubProcessFunctionColumnEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessFunctionColumnEditChange };
			FlowElements[StartMessageFunctionColumnEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageFunctionColumnEditChange };
			FlowElements[ScriptTaskFunctionColumnEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskFunctionColumnEditChange };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[SpecifyEntityColumnsCheckBoxCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SpecifyEntityColumnsCheckBoxCheckStartMessage };
			FlowElements[SpecifyEntityColumnsCheckBoxCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SpecifyEntityColumnsCheckBoxCheckScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[SpecifyEntityColumnsButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SpecifyEntityColumnsButtonClickStartMessage };
			FlowElements[SpecifyEntityColumnsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SpecifyEntityColumnsScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessageSetColumnsMenuButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSetColumnsMenuButtonClick };
			FlowElements[ScriptTaskSetColumnsMenuButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSetColumnsMenuButtonClick };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ReadSomeTopRecordsEditCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadSomeTopRecordsEditCheckStartMessage };
			FlowElements[ReadSomeTopRecordsEditCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadSomeTopRecordsEditCheckScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessOnInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScript":
						break;
					case "OkButtonClickChildSubProcess":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("CheckData_ScriptTask");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "ScriptChildOkButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "CheckData_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptChildOkButtonClick");
							break;
						}
						e.Context.QueueTasks.Enqueue("ErrorMessage_ScriptTask");
						break;
					case "ErrorMessage_ScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "EntitySchemaEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ScriptTaskPrepareChangeSchemaEntityQuestion":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityUserMessage");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTaskPrepareChangeSchemaEntityQuestion");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "ChangeSchemaEntityUserMessage":
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "EventSubProcessChangeSchemaEntityYesMessage":
						break;
					case "ChangeSchemaEntityYesMessageBase":
						e.Context.QueueTasks.Enqueue("ScriptEntitySchemaEditChange");
						break;
					case "ScriptEntitySchemaEditChange":
						break;
					case "EventSubProcessChangeSchemaEntityNoMessage":
						break;
					case "ChangeSchemaEntityNoMessageBase":
						e.Context.QueueTasks.Enqueue("ScriptEntitySchemaEditNotChange");
						break;
					case "ScriptEntitySchemaEditNotChange":
						break;
					case "EventSubProcessCount":
						break;
					case "StartMessageRadioButtonCountCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskCountCheck");
						break;
					case "ScriptTaskCountCheck":
						break;
					case "EventSubProcessEntity":
						break;
					case "StartMessageRadioButtonEntityCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskEntityCheck");
						break;
					case "ScriptTaskEntityCheck":
						break;
					case "EventSubProcessFunction":
						break;
					case "StartMessageFunctionCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskFunctionCheck");
						break;
					case "ScriptTaskFunctionCheck":
						break;
					case "EventSubProcessFunctionType":
						break;
					case "StartMessageFunctionTypeEditChange":
						e.Context.QueueTasks.Enqueue("ScriptTaskFunctionTypeEditChange");
						break;
					case "ScriptTaskFunctionTypeEditChange":
						break;
					case "EventSubProcessFunctionColumnEditChange":
						break;
					case "StartMessageFunctionColumnEditChange":
						e.Context.QueueTasks.Enqueue("ScriptTaskFunctionColumnEditChange");
						break;
					case "ScriptTaskFunctionColumnEditChange":
						break;
					case "EventSubProcess5":
						break;
					case "SpecifyEntityColumnsCheckBoxCheckStartMessage":
						e.Context.QueueTasks.Enqueue("SpecifyEntityColumnsCheckBoxCheckScriptTask");
						break;
					case "SpecifyEntityColumnsCheckBoxCheckScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "SpecifyEntityColumnsButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("SpecifyEntityColumnsScriptTask");
						break;
					case "SpecifyEntityColumnsScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "StartMessageSetColumnsMenuButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskSetColumnsMenuButtonClick");
						break;
					case "ScriptTaskSetColumnsMenuButtonClick":
						break;
					case "EventSubProcess7":
						break;
					case "ReadSomeTopRecordsEditCheckStartMessage":
						e.Context.QueueTasks.Enqueue("ReadSomeTopRecordsEditCheckScriptTask");
						break;
					case "ReadSomeTopRecordsEditCheckScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(EntitySchemaUId != Guid.Empty && (Guid)Page.ObjectEdit.Value != EntitySchemaUId);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(IsFilterParamsValuesCorrect && IsSelectedAnyEntityColumns);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("EntitySchemaEditChangeStartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityYesMessageBase");
			ActivatedEventElements.Add("ChangeSchemaEntityNoMessageBase");
			ActivatedEventElements.Add("StartMessageRadioButtonCountCheck");
			ActivatedEventElements.Add("StartMessageRadioButtonEntityCheck");
			ActivatedEventElements.Add("StartMessageFunctionCheck");
			ActivatedEventElements.Add("StartMessageFunctionTypeEditChange");
			ActivatedEventElements.Add("StartMessageFunctionColumnEditChange");
			ActivatedEventElements.Add("SpecifyEntityColumnsCheckBoxCheckStartMessage");
			ActivatedEventElements.Add("SpecifyEntityColumnsButtonClickStartMessage");
			ActivatedEventElements.Add("StartMessageSetColumnsMenuButtonClick");
			ActivatedEventElements.Add("ReadSomeTopRecordsEditCheckStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessOnInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
					break;
				case "IntermediateThrowMessageEventInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventInit.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScript";
					result = PageLoadCompleteChildScript.Execute(context, PageLoadCompleteChildScriptExecute);
					break;
				case "OkButtonClickChildSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptChildOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildOkButtonClick";
					result = ScriptChildOkButtonClick.Execute(context, ScriptChildOkButtonClickExecute);
					break;
				case "CheckData_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckData_ScriptTask";
					result = CheckData_ScriptTask.Execute(context, CheckData_ScriptTaskExecute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ErrorMessage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ErrorMessage_ScriptTask";
					result = ErrorMessage_ScriptTask.Execute(context, ErrorMessage_ScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "EntitySchemaEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaEditChangeStartMessage";
					result = EntitySchemaEditChangeStartMessage.Execute(context);
					break;
				case "ScriptTaskPrepareChangeSchemaEntityQuestion":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepareChangeSchemaEntityQuestion";
					result = ScriptTaskPrepareChangeSchemaEntityQuestion.Execute(context, ScriptTaskPrepareChangeSchemaEntityQuestionExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ChangeSchemaEntityUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityUserMessage";
					result = ChangeSchemaEntityUserMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "EventSubProcessChangeSchemaEntityYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageBase";
					result = ChangeSchemaEntityYesMessageBase.Execute(context);
					break;
				case "ScriptEntitySchemaEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEntitySchemaEditChange";
					result = ScriptEntitySchemaEditChange.Execute(context, ScriptEntitySchemaEditChangeExecute);
					break;
				case "EventSubProcessChangeSchemaEntityNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageBase";
					result = ChangeSchemaEntityNoMessageBase.Execute(context);
					break;
				case "ScriptEntitySchemaEditNotChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEntitySchemaEditNotChange";
					result = ScriptEntitySchemaEditNotChange.Execute(context, ScriptEntitySchemaEditNotChangeExecute);
					break;
				case "EventSubProcessCount":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageRadioButtonCountCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRadioButtonCountCheck";
					result = StartMessageRadioButtonCountCheck.Execute(context);
					break;
				case "ScriptTaskCountCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCountCheck";
					result = ScriptTaskCountCheck.Execute(context, ScriptTaskCountCheckExecute);
					break;
				case "EventSubProcessEntity":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageRadioButtonEntityCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRadioButtonEntityCheck";
					result = StartMessageRadioButtonEntityCheck.Execute(context);
					break;
				case "ScriptTaskEntityCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskEntityCheck";
					result = ScriptTaskEntityCheck.Execute(context, ScriptTaskEntityCheckExecute);
					break;
				case "EventSubProcessFunction":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageFunctionCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageFunctionCheck";
					result = StartMessageFunctionCheck.Execute(context);
					break;
				case "ScriptTaskFunctionCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskFunctionCheck";
					result = ScriptTaskFunctionCheck.Execute(context, ScriptTaskFunctionCheckExecute);
					break;
				case "EventSubProcessFunctionType":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageFunctionTypeEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageFunctionTypeEditChange";
					result = StartMessageFunctionTypeEditChange.Execute(context);
					break;
				case "ScriptTaskFunctionTypeEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskFunctionTypeEditChange";
					result = ScriptTaskFunctionTypeEditChange.Execute(context, ScriptTaskFunctionTypeEditChangeExecute);
					break;
				case "EventSubProcessFunctionColumnEditChange":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageFunctionColumnEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageFunctionColumnEditChange";
					result = StartMessageFunctionColumnEditChange.Execute(context);
					break;
				case "ScriptTaskFunctionColumnEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskFunctionColumnEditChange";
					result = ScriptTaskFunctionColumnEditChange.Execute(context, ScriptTaskFunctionColumnEditChangeExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "SpecifyEntityColumnsCheckBoxCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SpecifyEntityColumnsCheckBoxCheckStartMessage";
					result = SpecifyEntityColumnsCheckBoxCheckStartMessage.Execute(context);
					break;
				case "SpecifyEntityColumnsCheckBoxCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SpecifyEntityColumnsCheckBoxCheckScriptTask";
					result = SpecifyEntityColumnsCheckBoxCheckScriptTask.Execute(context, SpecifyEntityColumnsCheckBoxCheckScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "SpecifyEntityColumnsButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SpecifyEntityColumnsButtonClickStartMessage";
					result = SpecifyEntityColumnsButtonClickStartMessage.Execute(context);
					break;
				case "SpecifyEntityColumnsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SpecifyEntityColumnsScriptTask";
					result = SpecifyEntityColumnsScriptTask.Execute(context, SpecifyEntityColumnsScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageSetColumnsMenuButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageSetColumnsMenuButtonClick";
					result = StartMessageSetColumnsMenuButtonClick.Execute(context);
					break;
				case "ScriptTaskSetColumnsMenuButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskSetColumnsMenuButtonClick";
					result = ScriptTaskSetColumnsMenuButtonClick.Execute(context, ScriptTaskSetColumnsMenuButtonClickExecute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "ReadSomeTopRecordsEditCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReadSomeTopRecordsEditCheckStartMessage";
					result = ReadSomeTopRecordsEditCheckStartMessage.Execute(context);
					break;
				case "ReadSomeTopRecordsEditCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReadSomeTopRecordsEditCheckScriptTask";
					result = ReadSomeTopRecordsEditCheckScriptTask.Execute(context, ReadSomeTopRecordsEditCheckScriptTaskExecute);
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
				case "IsColumnStructureExplorerRegistered":
					IsColumnStructureExplorerRegistered = reader.GetValue<System.Boolean>();
				break;
				case "IsSelectedAnyEntityColumns":
					IsSelectedAnyEntityColumns = reader.GetValue<System.Boolean>();
				break;
				case "SelectedEntityColumns":
					SelectedEntityColumns = reader.GetSerializableObjectValue();
				break;
				case "ColumnStructureExplorer":
					ColumnStructureExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsColumnStructureExplorerCreated":
					IsColumnStructureExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "IsFilterParamsValuesCorrect":
					IsFilterParamsValuesCorrect = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			if (IsColumnStructureExplorerCreated){
				CreateColumnStructureExplorer();
			}
			Page.NumberOfRecordsEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, FindDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageIdFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "SysPackage"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", objectPackageIds}};
			var managerNameFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}};
			var extendParentFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ExtendParent"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {false}}};
			Page.ObjectEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageIdFilter);
				filters.Add(managerNameFilter);
				filters.Add(extendParentFilter);
			};
			if (!Ext.IsAjaxRequest) {
				Page.UserTaskTitleEdit.Text = ElementNewCaption;
				var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
				SetDefaultValue(defValues["ResultType"], ((int)ProcessReadDataResultType.Entity).ToString(), ProcessReadDataResultType.Entity.ToLocalizedString(), "ResultType");
				SetDefaultValue(defValues["FunctionType"], ((int)AggregationTypeStrict.Sum).ToString(), AggregationTypeStrict.Sum.ToLocalizedString(), "FunctionType");
				SetDefaultValue(defValues["ReadSomeTopRecords"], "False", string.Empty, "ReadSomeTopRecords");
				SetDefaultValue(defValues["NumberOfRecords"], "1", "1", "NumberOfRecords");
				DefaultValues = defValues;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = (VirtualDataSource)PropertyDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
				InitFunctionList();
				/*
				var selectedEntityColumns = SelectedEntityColumns as List<string>;
				Page.SpecifyEntityColumnsCheckBox.Checked = selectedEntityColumns != null && selectedEntityColumns.Count > 0;
				switch ((ProcessReadDataResultType)Enum.Parse(typeof(ProcessReadDataResultType), defValues["ResultType"].Value)) {
					case ProcessReadDataResultType.Entity:
						Page.RadioButtonEntity.Checked = true;
						SetEnabledFunctionControlsProperty(false);
						SetEnabledNumberOfRecordsControlsProperty(true);
						SetEnabledSpecifyEntityColumnsControlsProperty(true);
						break;
					case ProcessReadDataResultType.Function:
						if (defValues["FunctionType"].Value == ((int)AggregationTypeStrict.Count).ToString()) {
							Page.RadioButtonCount.Checked = true;
							SetEnabledFunctionControlsProperty(false);
							SetEnabledNumberOfRecordsControlsProperty(false);
							SetEnabledSpecifyEntityColumnsControlsProperty(false);
						} else {
							Page.RadioButtonFunction.Checked = true;
							SetEnabledFunctionControlsProperty(true);
							SetEnabledNumberOfRecordsControlsProperty(false);
							SetEnabledSpecifyEntityColumnsControlsProperty(false);
						}
						break;
				}
				*/
			}
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			ConfigureFilterEdit();
			Page.TreeGridRecordSorting.ShowAutoWidthMenu = false;
			Page.TreeGridRecordSorting.ShowMultiLineMenu = false;
			Page.TreeGridRecordSorting.ShowSummariesMenu = false;
			Page.TreeGridRecordSorting.IsShowOppositeReference = false;
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters == null) {
				return true;
			}
			if (!parameters["ResultEntity"].ReferenceSchemaUId.Equals(Guid.Empty)) {
				EntitySchemaUId = parameters["ResultEntity"].ReferenceSchemaUId;
				Page.EntityDataSource.SchemaUId = EntitySchemaUId;
				Page.ObjectEdit.SetValueAndText(EntitySchemaUId,
					Page.EntityDataSource.Schema.Caption.ToString());
				string entityColumnMetaPathes = parameters["EntityColumnMetaPathes"].Value;
				if (!string.IsNullOrEmpty(entityColumnMetaPathes)) {
					string[] entityColumnPathes = entityColumnMetaPathes.Split(';');
					var selectedEntityColumnMetaPathes = new List<string>();
					foreach (string entityColumnPath in entityColumnPathes) {
						selectedEntityColumnMetaPathes.Add(entityColumnPath);
					}
					SelectedEntityColumns = selectedEntityColumnMetaPathes;
					Page.SpecifyEntityColumnsCheckBox.Checked = selectedEntityColumnMetaPathes.Count > 0;
				}
				string filters = parameters["DataSourceFilters"].Value;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(
						UserConnection, Page.FilterEdit.DataSource);
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
				Page.EntityDataSource.LoadStructure();
				Page.FilterEdit.SetDataSource(Page.EntityDataSource);
				InitTreeGridRecordSorting();
			}
			bool isEnabled = EntitySchemaUId != Guid.Empty;
			SetEnabledControls(isEnabled);
			switch ((ProcessReadDataResultType)Enum.Parse(typeof(ProcessReadDataResultType), parameters["ResultType"].Value)) {
				case ProcessReadDataResultType.Entity:
					Page.RadioButtonEntity.Checked = isEnabled;
					SetEnabledFunctionControlsProperty(false);
					SetEnabledNumberOfRecordsControlsProperty(isEnabled);
					SetEnabledSpecifyEntityColumnsControlsProperty(isEnabled);
					break;
				case ProcessReadDataResultType.Function:
					if (parameters["FunctionType"].Value == ((int)AggregationTypeStrict.Count).ToString()) {
						Page.RadioButtonCount.Checked = isEnabled;
						SetEnabledFunctionControlsProperty(false);
						SetEnabledNumberOfRecordsControlsProperty(false);
						SetEnabledSpecifyEntityColumnsControlsProperty(false);
					} else {
						Page.RadioButtonFunction.Checked = isEnabled;
						SetEnabledFunctionControlsProperty(isEnabled);
						SetEnabledNumberOfRecordsControlsProperty(false);
						SetEnabledSpecifyEntityColumnsControlsProperty(false);
					}
					InitAggregationColumnNamesList();
					break;
			}
			return true;
		}

		public virtual bool ScriptChildOkButtonClickExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = filterCollection.Count > 0 ? constVS : noneVS,
				Value = filterCollection.Count > 0 ? 
					Json.Serialize(filterCollection, jsonConverter) : string.Empty
			};
			parametersValue["ResultEntity"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = EntitySchemaUId.Equals(Guid.Empty) ? noneVS : constVS,
				Value = "",
				ReferenceSchemaUId = EntitySchemaUId
			};
			parametersValue["ResultEntityCollection"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				ReferenceSchemaUId = EntitySchemaUId
			};
			parametersValue["ReadSomeTopRecords"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value =  Page.ReadSomeTopRecordsEdit.Checked.ToString()
			};
			parametersValue["NumberOfRecords"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value =  Page.NumberOfRecordsEdit.Text
			};
			var sb = new StringBuilder();
			foreach (var column in Page.TreeGridRecordSorting.DataSource.DefStructure.Columns) {
				if (sb.Length > 0) {
					sb.Append(",");
				}
				sb.AppendFormat("{0}:{1}:{2}", column.Name, (int)column.OrderDirection, column.OrderPosition);
			}
			parametersValue["OrderInfo"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = sb.Length == 0 ? noneVS : constVS,
				Value = sb.ToString(),
			};
			bool isSpecifiedEntityColumns = Page.RadioButtonEntity.Checked && Page.SpecifyEntityColumnsCheckBox.Checked;
			if (isSpecifiedEntityColumns) {
				sb.Length = 0;
				bool isFirst = true;
				foreach(string selectedEntityColumnPath in (List<string>)SelectedEntityColumns) {
					if (isFirst) {
						isFirst = false;
					} else {
						sb.Append(";");
					}
					sb.Append(selectedEntityColumnPath);
				}
			} else {
				SelectedEntityColumns = null;
			}
			parametersValue["EntityColumnMetaPathes"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isSpecifiedEntityColumns ? constVS : noneVS,
				Value = isSpecifiedEntityColumns ? sb.ToString() : string.Empty
			};
			return true;
		}

		public virtual bool CheckData_ScriptTaskExecute(ProcessExecutingContext context) {
			IsFilterParamsValuesCorrect = true;
			var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			IsFilterParamsValuesCorrect = !filters.IsAnyLeftExpressionNullOrEmpty();
			if (Page.RadioButtonEntity.Checked && Page.SpecifyEntityColumnsCheckBox.Checked) {
				var selectedEntityColumns = SelectedEntityColumns as List<string>;
				IsSelectedAnyEntityColumns = selectedEntityColumns != null && selectedEntityColumns.Count > 0;
			}
			return true;
		}

		public virtual bool ErrorMessage_ScriptTaskExecute(ProcessExecutingContext context) {
			Page.MainMessagePanel.Clear();
			if (!IsFilterParamsValuesCorrect) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessage, MessageType.Warning);
			}
			if (!IsSelectedAnyEntityColumns) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, IsNotSelectedAnyEntityColumnsMessage, MessageType.Warning);
			}
			return true;
		}

		public virtual bool ScriptTaskPrepareChangeSchemaEntityQuestionExecute(ProcessExecutingContext context) {
			ChangeSchemaEntityUserMessage.Page = Page;
			ChangeSchemaEntityUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeSchemaEntityUserMessage.Icon = "QUESTION";
			ChangeSchemaEntityUserMessage.Buttons = "YESNO";
			ChangeSchemaEntityUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeSchemaEntityYesMessage"},
				{"no", "ChangeSchemaEntityNoMessage"},
			};
			return true;
		}

		public virtual bool ScriptEntitySchemaEditChangeExecute(ProcessExecutingContext context) {
			EntitySchemaUId = (new Select(UserConnection)
				.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter((Guid)Page.ObjectEdit.Value)) as Select)
				.ExecuteScalar<Guid>();
			var structure = Page.EntityDataSource.CurrentStructure;
			structure.Columns.Clear();
			SelectedEntityColumns = null;
			Page.EntityDataSource.SchemaUId = EntitySchemaUId;
			ResetControlValues();
			if (EntitySchemaUId.Equals(Guid.Empty)) {
				SetEnabledControls(false);
				SetEnabledFunctionControlsProperty(false);
				SetEnabledNumberOfRecordsControlsProperty(false);
				SetEnabledSpecifyEntityColumnsControlsProperty(false);
				Page.FunctionTypeEdit.Clear();
				Page.FunctionColumnEdit.Clear();
				return true;
			}
			EntitySchema schema = Page.EntityDataSource.Schema;
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
			var hierarchyColumn = schema.HierarchyColumn;
			if (hierarchyColumn != null && structure.Columns.FindByName(hierarchyColumn.Name) == null) {
				var column = structure.CreateColumn(schema, hierarchyColumn.UId.ToString());
				column.IsVisible = false;
				structure.AddColumn(column);
			}
			Page.FilterEdit.SetDataSource(Page.EntityDataSource);
			Page.EntityDataSource.LoadRows();
			Page.TreeGridRecordSorting.RefreshData();
			InitAggregationColumnNamesList();
			Page.RadioButtonEntity.Checked = true;
			SetEnabledControls(true);
			SetEnabledFunctionControlsProperty(false);
			SetEnabledNumberOfRecordsControlsProperty(true);
			SetEnabledSpecifyEntityColumnsControlsProperty(true);
			return true;
		}

		public virtual bool ScriptEntitySchemaEditNotChangeExecute(ProcessExecutingContext context) {
			Page.ObjectEdit.SuspendAjaxEvents();
			Page.ObjectEdit.SetValueAndText(EntitySchemaUId, Page.EntityDataSource.Schema.Caption.ToString());
			Page.ObjectEdit.ResumeAjaxEvents();
			return true;
		}

		public virtual bool ScriptTaskCountCheckExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonCount.Checked) {
				string value = ((int)ProcessReadDataResultType.Function).ToString();
				SetUserTaskParameterConstValue("ResultType", value, value);
				value = ((int)AggregationTypeStrict.Count).ToString();
				SetUserTaskParameterConstValue("FunctionType", value, value);
				SetEnabledFunctionControlsProperty(false);
				SetEnabledNumberOfRecordsControlsProperty(false);
				SetEnabledSpecifyEntityColumnsControlsProperty(false);
				EntitySchema schema = Page.EntityDataSource.Schema;
				if (schema != null) {
					SetUserTaskParameterConstValue("AggregationColumnName", schema.PrimaryColumn.Name, schema.PrimaryColumn.Caption);
				}
			}
			return true;
		}

		public virtual bool ScriptTaskEntityCheckExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonEntity.Checked) {
				string value = ((int)ProcessReadDataResultType.Entity).ToString();
				SetUserTaskParameterConstValue("ResultType", value, value);
				SetUserTaskParameterConstValue("FunctionType", "0", "0");
				SetEnabledFunctionControlsProperty(false);
				SetEnabledNumberOfRecordsControlsProperty(true);
				SetEnabledSpecifyEntityColumnsControlsProperty(true);
				InitTreeGridRecordSorting();
			}
			return true;
		}

		public virtual bool ScriptTaskFunctionCheckExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonFunction.Checked) {
				string value = ((int)ProcessReadDataResultType.Function).ToString();
				SetUserTaskParameterConstValue("ResultType", value, value);
				value = Page.FunctionTypeEdit.SelectedItem.Value;
				if (string.IsNullOrEmpty(value) || value == "0") {
					value = ((int)AggregationTypeStrict.Sum).ToString();
				}
				SetUserTaskParameterConstValue("FunctionType", value, value);
				SetEnabledFunctionControlsProperty(true);
				SetEnabledNumberOfRecordsControlsProperty(false);
				SetEnabledSpecifyEntityColumnsControlsProperty(false);
				InitAggregationColumnNamesList();
			}
			return true;
		}

		public virtual bool ScriptTaskFunctionTypeEditChangeExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonFunction.Checked) {
				string value = Page.FunctionTypeEdit.SelectedItem.Value;
				SetUserTaskParameterConstValue("FunctionType", value, value);
				InitAggregationColumnNamesList();
			}
			return true;
		}

		public virtual bool ScriptTaskFunctionColumnEditChangeExecute(ProcessExecutingContext context) {
			SetUserTaskParameterConstValue("AggregationColumnName",
				Page.FunctionColumnEdit.SelectedItem.Value, Page.FunctionColumnEdit.SelectedItem.Text);
			return true;
		}

		public virtual bool SpecifyEntityColumnsCheckBoxCheckScriptTaskExecute(ProcessExecutingContext context) {
			Page.SpecifyEntityColumnsButton.Enabled = Page.SpecifyEntityColumnsCheckBox.Checked;
			return true;
		}

		public virtual bool SpecifyEntityColumnsScriptTaskExecute(ProcessExecutingContext context) {
			ShowColumnStructureExplorerEditWindow();
			return true;
		}

		public virtual bool ScriptTaskSetColumnsMenuButtonClickExecute(ProcessExecutingContext context) {
			Page.AddScript(string.Format(
				"{0}.fireEvent('setcolumns', this, null);", Page.TreeGridRecordSorting.ClientID));
			return true;
		}

		public virtual bool ReadSomeTopRecordsEditCheckScriptTaskExecute(ProcessExecutingContext context) {
			bool isEnabled = Page.ReadSomeTopRecordsEdit.Checked;
			Page.NumberOfRecordsEdit.Enabled = isEnabled;
			Page.LabelNumberOfRecords.Enabled = isEnabled;
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
			{"ReadSomeTopRecords", Page.ReadSomeTopRecordsEdit},
			{"NumberOfRecords", Page.NumberOfRecordsEdit}
			};
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				string.Format("{0} ({1})", WindowCaption, NewRecord) : Page.UserTaskTitleEdit.Text;
		}

		public virtual void ResetControlValues() {
			var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(Page.FilterEdit.FilterEditGroupName);
			if (filterEditGroup != null) {
				filterEditGroup.Clear();
			}
			Page.RadioButtonEntity.Checked = false;
			Page.RadioButtonCount.Checked = false;
			Page.RadioButtonFunction.Checked = false;
		}

		public virtual void ConfigureFilterEdit() {
			ISchemaManager sm = UserConnection.GetSchemaManager(ManagerName);
			ProcessSchema processSchema = null;
			if (sm is ProcessSchemaManager){
				processSchema = ((ProcessSchemaManager)sm).GetDesignInstance(UserConnection, EditSchemaUId) as ProcessSchema;
			} else if (sm is PageSchemaManager) {
				var ps = ((PageSchemaManager)sm).GetDesignInstance(UserConnection, EditSchemaUId) as PageSchema;
				processSchema = ps.EventsProcessSchema;
			}
			if (processSchema == null) {
				var di = UserConnection.ProcessSchemaManager.FindDesignItem(UserConnection, EditSchemaUId);
				processSchema = di == null ? null : di.Instance as ProcessSchema;
			}
			Page.FilterEdit.SetProcessSchema(processSchema);
			Page.FilterEdit.AutoInitializeFilterEditGroup = true;
		}

		public virtual void InitFunctionList() {
			if (Ext.IsAjaxRequest) {
				return;
			}
			foreach (AggregationTypeStrict item in Enum.GetValues(typeof(AggregationTypeStrict))) {
				if (item == AggregationTypeStrict.Count) {
					continue;
				}
				Page.FunctionTypeEdit.AddItem(((int)item).ToString(), item.ToLocalizedString());
			}
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			Page.FunctionTypeEdit.SelectItem(propertyDataSource.Rows[0].GetColumnValue("FunctionType"));
		}

		public virtual void SetUserTaskParameterConstValue(string parameterName, string value, string displayValue) {
			if (ParametersValue == null) {
				ParametersValue = new Dictionary<string, ProcessSchemaParameterValue>();
			}
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			ProcessSchemaParameterValue parameterValue = new ProcessSchemaParameterValue();
			parameterValue.ModifiedInSchemaUId = EditSchemaUId;
			parameterValue.Source = ProcessSchemaParameterValueSource.ConstValue;
			parameterValue.Value = value;
			parameterValue.DisplayValue = string.IsNullOrEmpty(displayValue) ? value : displayValue;
			if (parametersValue.ContainsKey(parameterName)) {
				parametersValue[parameterName] = parameterValue;
			} else {
				parametersValue.Add(parameterName, parameterValue);
			}
		}

		public virtual void InitAggregationColumnNamesList() {
			Page.FunctionColumnEdit.ClearItems();
			Page.FunctionColumnEdit.ClearValue();
			EntitySchema schema = Page.EntityDataSource.Schema;
			if (schema == null) {
				return;
			}
			if (!Page.RadioButtonFunction.Checked) {
				return;
			}
			string value = "1";
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			if (string.IsNullOrEmpty(Page.FunctionTypeEdit.SelectedItem.Value)) {
				if (propertyDataSource.Rows.Count > 0) {
					value = (string)propertyDataSource.Rows[0].GetColumnValue("FunctionType");
					if (string.IsNullOrEmpty(value) || value == "0") {
						value = "1";
					}
				}
				Page.FunctionTypeEdit.SelectItem(value);
			} else {
				value = Page.FunctionTypeEdit.SelectedItem.Value;
			}
			AggregationTypeStrict functionType = (AggregationTypeStrict)Enum.Parse(typeof(AggregationTypeStrict), value);
			int itemsCount = 0;
			foreach (var column in schema.Columns) {
				var dataValueType = column.DataValueType;
				if (!(dataValueType is NumericDataValueType) && !(dataValueType is DateTimeDataValueType)) {
					continue;
				}
				if ((functionType == AggregationTypeStrict.Avg || functionType == AggregationTypeStrict.Sum)
						&& !(dataValueType is NumericDataValueType)) {
					continue;
				}
				Page.FunctionColumnEdit.AddItem(column.Name, column.Caption);
				itemsCount++;
			}
			if (itemsCount > 0) {
				var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				if (defValues != null) {
					Page.FunctionColumnEdit.SelectedItem.Value = defValues["AggregationColumnName"].Value;
				}
			}
		}

		public virtual void InitTreeGridRecordSorting() {
			EntitySchema schema = Page.EntityDataSource.Schema;
			if (schema == null) {
				return;
			}
			var structure = Page.EntityDataSource.CurrentStructure;
			structure.Columns.Clear();
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters != null && parameters["OrderInfo"] != null && parameters["OrderInfo"].Value != null) {
				string[] orders = parameters["OrderInfo"].Value.Split(new char[] {','});
				for (int i=0; i < orders.Length; i++) {
					string[] order = orders[i].Split(new char[] {':'});
					if (order.Length != 3) {
						continue;
					}
					var displayColumn = schema.Columns.FindByName(order[0]);
					if (displayColumn == null) {
						continue;
					}
					var column = structure.CreateColumn(schema, displayColumn.UId.ToString());
					column.OrderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection), order[1]);
					column.OrderPosition = int.Parse(order[2]);
					structure.AddColumn(column);
				}
			} else {
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
			}
			var primaryColumn = structure.Columns.FindByName(schema.PrimaryColumn.Name);
			if (primaryColumn == null) {
				primaryColumn = structure.CreateColumn(schema, schema.PrimaryColumn.UId.ToString());
				structure.AddColumn(primaryColumn);
			}
			primaryColumn.IsVisible = false;
			var hierarchyColumn = schema.HierarchyColumn;
			if (hierarchyColumn != null && structure.Columns.FindByName(hierarchyColumn.Name) == null) {
				var column = structure.CreateColumn(schema, hierarchyColumn.UId.ToString());
				column.IsVisible = false;
				structure.AddColumn(column);
			}
			Page.FilterEdit.SetDataSource(Page.EntityDataSource);
			Page.EntityDataSource.LoadStructure(force: true);
			Page.TreeGridRecordSorting.RefreshData();
		}

		public virtual void SetEnabledControls(bool isEnabled) {
			Page.RadioButtonCount.Enabled = isEnabled;
			Page.RadioButtonFunction.Enabled = isEnabled;
			Page.RadioButtonEntity.Enabled = isEnabled;
			Page.FilterEdit.Enabled = isEnabled;
		}

		public virtual void SetCheckedRadioButtonEntity() {
			string value = ((int)ProcessReadDataResultType.Entity).ToString();
			SetUserTaskParameterConstValue("ResultType", value, value);
			SetUserTaskParameterConstValue("FunctionType", "0", "0");
			Page.FunctionColumnEdit.Enabled = false;
			Page.FunctionColumnEdit.SetRequired(false);
			Page.FunctionTypeEdit.Enabled = false;
			Page.FunctionTypeEdit.SetRequired(false);
		}

		public virtual void ShowColumnStructureExplorerEditWindow() {
			if (EntitySchemaUId == Guid.Empty) {
				return;
			}
			StructureExplorer columnStructureExplorer;
			if (!IsColumnStructureExplorerCreated) {
				columnStructureExplorer = CreateColumnStructureExplorer();
			} else {
				columnStructureExplorer = (StructureExplorer)ColumnStructureExplorer;	
			}
			var selectedEntityColumns = SelectedEntityColumns as List<string>;
			if (selectedEntityColumns != null && selectedEntityColumns.Count != 0) {
				var dataSourceStructureColumnCollection = new DataSourceStructureColumnCollection();
				EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
				foreach(string selectedEntityColumnMetaPath in selectedEntityColumns) {
					var dataSourceStructureColumn = new DataSourceStructureColumn();
					EntitySchemaColumn entitySchemaColumn =
						entitySchema.GetSchemaColumnByMetaPath(selectedEntityColumnMetaPath);
					dataSourceStructureColumn.UId = entitySchemaColumn.UId;
					dataSourceStructureColumn.MetaPath = selectedEntityColumnMetaPath;
					dataSourceStructureColumn.Name = entitySchemaColumn.Name;
					dataSourceStructureColumn.Caption = entitySchemaColumn.Caption;
					dataSourceStructureColumn.DataValueType = entitySchemaColumn.DataValueType;
					dataSourceStructureColumnCollection.Add(dataSourceStructureColumn);
				}
				columnStructureExplorer.Columns = dataSourceStructureColumnCollection;
			}
			columnStructureExplorer.ShowEditWindow(EntitySchemaUId, null);
		}

		public virtual StructureExplorer CreateColumnStructureExplorer() {
			// public StructureExplorer(WebControl parentControl, string key, bool isMultiSelect, bool isRootMode,
			//	string helpContextId, bool isShowStructureItemsProperties = true)
			var param = new Terrasoft.UI.WebControls.Controls.Parameter("itemsInfo", "itemsInfo", ParameterMode.Raw);
			var columnStructureExplorer = new StructureExplorer(Page.TopControlLayout, "columnExplorer", true, false, string.Empty);
			columnStructureExplorer.ExcludeDataValueTypes = new string[] { "Binary", "File", "Image", "Color" };
			columnStructureExplorer.IsShowSystemColumns = true;
			columnStructureExplorer.IsShowOppositeReference = false;
			ComponentAjaxEvent editComplete = columnStructureExplorer.AjaxEvents.EditComplete;
			editComplete.Event += ColumnStructureExplorer_EditComplete;
			editComplete.ExtraParameters.Add(param);
			columnStructureExplorer.Columns = new DataSourceStructureColumnCollection();
			IsColumnStructureExplorerCreated = true;
			if (!IsColumnStructureExplorerRegistered) {
				columnStructureExplorer.Register();
				IsColumnStructureExplorerRegistered = true;
			}
			ColumnStructureExplorer = columnStructureExplorer;
			return columnStructureExplorer;
		}

		public virtual void ColumnStructureExplorer_EditComplete(object sender, AjaxEventArgs e) {
			var structureExplorerColumns = (JArray)Json.Deserialize(e.ExtraParameters["itemsInfo"]);
			var selectedEntityColumnPathes = SelectedEntityColumns as List<string>;
			if (selectedEntityColumnPathes == null){
				selectedEntityColumnPathes = new List<string>();
			} else {
				selectedEntityColumnPathes.Clear();
			}
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			foreach(var structureExplorerColumn in structureExplorerColumns) {
				var newColumnMetaPath = structureExplorerColumn["metaPath"].ToString();
				selectedEntityColumnPathes.Add(newColumnMetaPath);
			}
			SelectedEntityColumns = selectedEntityColumnPathes;
		}

		public virtual void SetEnabledSpecifyEntityColumnsControlsProperty(bool isEnabled) {
			Page.SpecifyEntityColumnsCheckBox.Enabled = isEnabled;
			Page.SpecifyEntityColumnsButton.Enabled = isEnabled && Page.SpecifyEntityColumnsCheckBox.Checked;
		}

		public virtual void SetEnabledNumberOfRecordsControlsProperty(bool isEnabled) {
			Page.TreeGridRecordSorting.Enabled = isEnabled;
			Page.SetColumnsMenuButton.Enabled = isEnabled;
			Page.ReadSomeTopRecordsEdit.Enabled = isEnabled;
			if (isEnabled) {
				isEnabled = Page.ReadSomeTopRecordsEdit.Checked;
			}
			Page.NumberOfRecordsEdit.Enabled = isEnabled;
			Page.LabelNumberOfRecords.Enabled = isEnabled;
		}

		public virtual void SetEnabledFunctionControlsProperty(bool isEnabled) {
			Page.FunctionColumnEdit.Enabled = isEnabled;
			Page.FunctionColumnEdit.SetRequired(isEnabled);
			Page.FunctionTypeEdit.Enabled = isEnabled;
			Page.FunctionTypeEdit.SetRequired(isEnabled);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "ObjectEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EntitySchemaEditChangeStartMessage");
						}
						break;
					case "ChangeSchemaEntityYesMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageBase");
						}
						break;
					case "ChangeSchemaEntityNoMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageBase");
						}
						break;
					case "RadioButtonCountCheck":
							if (ActivatedEventElements.Contains("StartMessageRadioButtonCountCheck")) {
							context.QueueTasks.Enqueue("StartMessageRadioButtonCountCheck");
						}
						break;
					case "RadioButtonEntityCheck":
							if (ActivatedEventElements.Contains("StartMessageRadioButtonEntityCheck")) {
							context.QueueTasks.Enqueue("StartMessageRadioButtonEntityCheck");
						}
						break;
					case "RadioButtonFunctionCheck":
							if (ActivatedEventElements.Contains("StartMessageFunctionCheck")) {
							context.QueueTasks.Enqueue("StartMessageFunctionCheck");
						}
						break;
					case "FunctionTypeEditChange":
							if (ActivatedEventElements.Contains("StartMessageFunctionTypeEditChange")) {
							context.QueueTasks.Enqueue("StartMessageFunctionTypeEditChange");
						}
						break;
					case "FunctionColumnEditChange":
							if (ActivatedEventElements.Contains("StartMessageFunctionColumnEditChange")) {
							context.QueueTasks.Enqueue("StartMessageFunctionColumnEditChange");
						}
						break;
					case "SpecifyEntityColumnsCheckBoxCheck":
							if (ActivatedEventElements.Contains("SpecifyEntityColumnsCheckBoxCheckStartMessage")) {
							context.QueueTasks.Enqueue("SpecifyEntityColumnsCheckBoxCheckStartMessage");
						}
						break;
					case "SpecifyEntityColumnsButtonClick":
							if (ActivatedEventElements.Contains("SpecifyEntityColumnsButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("SpecifyEntityColumnsButtonClickStartMessage");
						}
						break;
					case "SetColumnsMenuButtonClick":
							if (ActivatedEventElements.Contains("StartMessageSetColumnsMenuButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageSetColumnsMenuButtonClick");
						}
						break;
					case "ReadSomeTopRecordsEditCheck":
							if (ActivatedEventElements.Contains("ReadSomeTopRecordsEditCheckStartMessage")) {
							context.QueueTasks.Enqueue("ReadSomeTopRecordsEditCheckStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsColumnStructureExplorerRegistered") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnStructureExplorerRegistered", IsColumnStructureExplorerRegistered, false);
			}
			if (!HasMapping("IsSelectedAnyEntityColumns") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSelectedAnyEntityColumns", IsSelectedAnyEntityColumns, false);
			}
			if (SelectedEntityColumns != null) {
				if (SelectedEntityColumns.GetType().IsSerializable ||
					SelectedEntityColumns.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SelectedEntityColumns", SelectedEntityColumns, null);
				}
			}
			if (ColumnStructureExplorer != null) {
				if (ColumnStructureExplorer.GetType().IsSerializable ||
					ColumnStructureExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnStructureExplorer", ColumnStructureExplorer, null);
				}
			}
			if (!HasMapping("IsColumnStructureExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnStructureExplorerCreated", IsColumnStructureExplorerCreated, false);
			}
			if (!HasMapping("IsFilterParamsValuesCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFilterParamsValuesCorrect", IsFilterParamsValuesCorrect, false);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataUserTaskParametersPageEventsProcess

	/// <exclude/>
	public class ReadDataUserTaskParametersPageEventsProcess : ReadDataUserTaskParametersPageEventsProcess<Terrasoft.WebApp.ReadDataUserTaskParametersPageSchemaUserControl>
	{

		public ReadDataUserTaskParametersPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReadDataUserTaskParametersPageSchemaUserControl

	/// <exclude/>
	public partial class ReadDataUserTaskParametersPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("UserTaskTitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit ObjectEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ObjectEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton RadioButtonCount {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("RadioButtonCount", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton RadioButtonFunction {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("RadioButtonFunction", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FunctionTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("FunctionTypeEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit FunctionColumnEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("FunctionColumnEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton RadioButtonEntity {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("RadioButtonEntity", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutEntity {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayoutEntity", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout NumberOfRecordsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("NumberOfRecordsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ReadSomeTopRecordsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ReadSomeTopRecordsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit NumberOfRecordsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("NumberOfRecordsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label LabelNumberOfRecords {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("LabelNumberOfRecords", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayoutTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid TreeGridRecordSorting {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("TreeGridRecordSorting", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SetColumnsMenuButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SetColumnsMenuButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutSpecifyColumns {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayoutSpecifyColumns", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox SpecifyEntityColumnsCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("SpecifyEntityColumnsCheckBox", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SpecifyEntityColumnsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SpecifyEntityColumnsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterControlLayout", true);
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

		public Terrasoft.UI.WebControls.Controls.EntityDataSource EntityDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("EntityDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event += ObjectEditChange;
			RadioButtonCount.AjaxEvents.Check.Event += RadioButtonCountCheck;
			RadioButtonFunction.AjaxEvents.Check.Event += RadioButtonFunctionCheck;
			FunctionTypeEdit.AjaxEvents.Change.Event += FunctionTypeEditChange;
			FunctionColumnEdit.AjaxEvents.Change.Event += FunctionColumnEditChange;
			RadioButtonEntity.AjaxEvents.Check.Event += RadioButtonEntityCheck;
			ReadSomeTopRecordsEdit.AjaxEvents.Check.Event += ReadSomeTopRecordsEditCheck;
			SetColumnsMenuButton.AjaxEvents.Click.Event += SetColumnsMenuButtonClick;
			SpecifyEntityColumnsCheckBox.AjaxEvents.Check.Event += SpecifyEntityColumnsCheckBoxCheck;
			SpecifyEntityColumnsButton.AjaxEvents.Click.Event += SpecifyEntityColumnsButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event -= ObjectEditChange;
			RadioButtonCount.AjaxEvents.Check.Event -= RadioButtonCountCheck;
			RadioButtonFunction.AjaxEvents.Check.Event -= RadioButtonFunctionCheck;
			FunctionTypeEdit.AjaxEvents.Change.Event -= FunctionTypeEditChange;
			FunctionColumnEdit.AjaxEvents.Change.Event -= FunctionColumnEditChange;
			RadioButtonEntity.AjaxEvents.Check.Event -= RadioButtonEntityCheck;
			ReadSomeTopRecordsEdit.AjaxEvents.Check.Event -= ReadSomeTopRecordsEditCheck;
			SetColumnsMenuButton.AjaxEvents.Click.Event -= SetColumnsMenuButtonClick;
			SpecifyEntityColumnsCheckBox.AjaxEvents.Check.Event -= SpecifyEntityColumnsCheckBoxCheck;
			SpecifyEntityColumnsButton.AjaxEvents.Click.Event -= SpecifyEntityColumnsButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ReadDataUserTaskParametersPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ReadDataUserTaskParametersPageEventsProcess(UserConnection);
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

		public virtual void RadioButtonCountCheck(object sender, EventArgs e) {
			object result = ThrowEvent("RadioButtonCountCheck");
		}

		public virtual void RadioButtonFunctionCheck(object sender, EventArgs e) {
			object result = ThrowEvent("RadioButtonFunctionCheck");
		}

		public virtual void FunctionTypeEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FunctionTypeEditChange");
		}

		public virtual void FunctionColumnEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FunctionColumnEditChange");
		}

		public virtual void RadioButtonEntityCheck(object sender, EventArgs e) {
			object result = ThrowEvent("RadioButtonEntityCheck");
		}

		public virtual void ReadSomeTopRecordsEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("ReadSomeTopRecordsEditCheck");
		}

		public virtual void SetColumnsMenuButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SetColumnsMenuButtonClick");
		}

		public virtual void SpecifyEntityColumnsCheckBoxCheck(object sender, EventArgs e) {
			object result = ThrowEvent("SpecifyEntityColumnsCheckBoxCheck");
		}

		public virtual void SpecifyEntityColumnsButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SpecifyEntityColumnsButtonClick");
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
			SchemaName = "ReadDataUserTaskParametersPage";
		}

		#endregion

	}

	#endregion

	#region Class: ReadDataUserTaskParametersPageEventsProcessSchema

	/// <exclude/>
	public class ReadDataUserTaskParametersPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ReadDataUserTaskParametersPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReadDataUserTaskParametersPageEventsProcessSchema(ReadDataUserTaskParametersPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReadDataUserTaskParametersPageEventsProcess";
			UId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreatePropertyDataSourceParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e7fe8054-e33d-4fa1-add5-d1b1957d18b7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				Name = @"PropertyDataSource",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f4be25e0-3a48-4a72-ace6-eb379815e764"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterParamsValuesCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("28f0c25f-bb1e-47a3-b171-b804ab6e6846"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IsFilterParamsValuesCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnStructureExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f01838ce-03b7-4518-962b-561b79468459"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IsColumnStructureExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnStructureExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("321b4bb3-2ef6-45cb-aa35-8143175766e3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ColumnStructureExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedEntityColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("772ae386-6e7a-46a7-85be-8225234d5708"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"SelectedEntityColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSelectedAnyEntityColumnsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0d98ea03-d8fc-42dc-bca0-0531b60a91a9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IsSelectedAnyEntityColumns",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnStructureExplorerRegisteredParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b6022797-5200-4812-8c72-8cd75e4530a7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IsColumnStructureExplorerRegistered",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateIsFilterParamsValuesCorrectParameter());
			Parameters.Add(CreateIsColumnStructureExplorerCreatedParameter());
			Parameters.Add(CreateColumnStructureExplorerParameter());
			Parameters.Add(CreateSelectedEntityColumnsParameter());
			Parameters.Add(CreateIsSelectedAnyEntityColumnsParameter());
			Parameters.Add(CreateIsColumnStructureExplorerRegisteredParameter());
		}

		protected virtual void InitializeChangeSchemaEntityUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fbafe2c0-3b7a-454f-9d84-8eeedd01cbf5"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("00a89c9e-2b6a-4978-89dc-0797070df637"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("6f73ed57-ec70-4441-bed1-b03f9a03fcfe"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("ef4f9b35-8603-44f7-a4c6-6242e694699b"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("7bb1752c-5bb6-4861-af11-1cd11def354d"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("dab4e938-db78-4c1b-ab8f-b68f8b33922b"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("df223d0c-6b9a-4949-9498-b54904484532"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
				UId = new Guid("1bf3afe0-774c-4d44-97ad-4055dcb034f5"),
				ContainerUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
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
			ProcessSchemaLane schemaLaneInitEvents = CreateLaneInitEventsLane();
			schemaLaneSet1.Lanes.Add(schemaLaneInitEvents);
			ProcessSchemaLane schemaButtonsLane = CreateButtonsLaneLane();
			schemaLaneSet1.Lanes.Add(schemaButtonsLane);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocessoninit = CreateEventSubProcessOnInitEventSubProcess();
			FlowElements.Add(eventsubprocessoninit);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess okbuttonclickchildsubprocess = CreateOkButtonClickChildSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickchildsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocesschangeschemaentityyesmessage = CreateEventSubProcessChangeSchemaEntityYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeschemaentityyesmessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeschemaentitynomessage = CreateEventSubProcessChangeSchemaEntityNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeschemaentitynomessage);
			ProcessSchemaEventSubProcess eventsubprocesscount = CreateEventSubProcessCountEventSubProcess();
			FlowElements.Add(eventsubprocesscount);
			ProcessSchemaEventSubProcess eventsubprocessentity = CreateEventSubProcessEntityEventSubProcess();
			FlowElements.Add(eventsubprocessentity);
			ProcessSchemaEventSubProcess eventsubprocessfunction = CreateEventSubProcessFunctionEventSubProcess();
			FlowElements.Add(eventsubprocessfunction);
			ProcessSchemaEventSubProcess eventsubprocessfunctiontype = CreateEventSubProcessFunctionTypeEventSubProcess();
			FlowElements.Add(eventsubprocessfunctiontype);
			ProcessSchemaEventSubProcess eventsubprocessfunctioncolumneditchange = CreateEventSubProcessFunctionColumnEditChangeEventSubProcess();
			FlowElements.Add(eventsubprocessfunctioncolumneditchange);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocessoninit.FlowElements.Add(startmessageinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessoninit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocessoninit.FlowElements.Add(scriptchildinit);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			eventsubprocess2.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scriptchildokbuttonclick = CreateScriptChildOkButtonClickScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(scriptchildokbuttonclick);
			ProcessSchemaScriptTask checkdata_scripttask = CreateCheckData_ScriptTaskScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(checkdata_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			okbuttonclickchildsubprocess.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask errormessage_scripttask = CreateErrorMessage_ScriptTaskScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(errormessage_scripttask);
			ProcessSchemaStartMessageEvent entityschemaeditchangestartmessage = CreateEntitySchemaEditChangeStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(entityschemaeditchangestartmessage);
			ProcessSchemaScriptTask scripttaskpreparechangeschemaentityquestion = CreateScriptTaskPrepareChangeSchemaEntityQuestionScriptTask();
			eventsubprocess3.FlowElements.Add(scripttaskpreparechangeschemaentityquestion);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess3.FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask changeschemaentityusermessage = CreateChangeSchemaEntityUserMessageUserTask();
			eventsubprocess3.FlowElements.Add(changeschemaentityusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaStartMessageEvent changeschemaentityyesmessagebase = CreateChangeSchemaEntityYesMessageBaseStartMessageEvent();
			eventsubprocesschangeschemaentityyesmessage.FlowElements.Add(changeschemaentityyesmessagebase);
			ProcessSchemaScriptTask scriptentityschemaeditchange = CreateScriptEntitySchemaEditChangeScriptTask();
			eventsubprocesschangeschemaentityyesmessage.FlowElements.Add(scriptentityschemaeditchange);
			ProcessSchemaStartMessageEvent changeschemaentitynomessagebase = CreateChangeSchemaEntityNoMessageBaseStartMessageEvent();
			eventsubprocesschangeschemaentitynomessage.FlowElements.Add(changeschemaentitynomessagebase);
			ProcessSchemaScriptTask scriptentityschemaeditnotchange = CreateScriptEntitySchemaEditNotChangeScriptTask();
			eventsubprocesschangeschemaentitynomessage.FlowElements.Add(scriptentityschemaeditnotchange);
			ProcessSchemaStartMessageEvent startmessageradiobuttoncountcheck = CreateStartMessageRadioButtonCountCheckStartMessageEvent();
			eventsubprocesscount.FlowElements.Add(startmessageradiobuttoncountcheck);
			ProcessSchemaScriptTask scripttaskcountcheck = CreateScriptTaskCountCheckScriptTask();
			eventsubprocesscount.FlowElements.Add(scripttaskcountcheck);
			ProcessSchemaStartMessageEvent startmessageradiobuttonentitycheck = CreateStartMessageRadioButtonEntityCheckStartMessageEvent();
			eventsubprocessentity.FlowElements.Add(startmessageradiobuttonentitycheck);
			ProcessSchemaScriptTask scripttaskentitycheck = CreateScriptTaskEntityCheckScriptTask();
			eventsubprocessentity.FlowElements.Add(scripttaskentitycheck);
			ProcessSchemaStartMessageEvent startmessagefunctioncheck = CreateStartMessageFunctionCheckStartMessageEvent();
			eventsubprocessfunction.FlowElements.Add(startmessagefunctioncheck);
			ProcessSchemaScriptTask scripttaskfunctioncheck = CreateScriptTaskFunctionCheckScriptTask();
			eventsubprocessfunction.FlowElements.Add(scripttaskfunctioncheck);
			ProcessSchemaStartMessageEvent startmessagefunctiontypeeditchange = CreateStartMessageFunctionTypeEditChangeStartMessageEvent();
			eventsubprocessfunctiontype.FlowElements.Add(startmessagefunctiontypeeditchange);
			ProcessSchemaScriptTask scripttaskfunctiontypeeditchange = CreateScriptTaskFunctionTypeEditChangeScriptTask();
			eventsubprocessfunctiontype.FlowElements.Add(scripttaskfunctiontypeeditchange);
			ProcessSchemaStartMessageEvent startmessagefunctioncolumneditchange = CreateStartMessageFunctionColumnEditChangeStartMessageEvent();
			eventsubprocessfunctioncolumneditchange.FlowElements.Add(startmessagefunctioncolumneditchange);
			ProcessSchemaScriptTask scripttaskfunctioncolumneditchange = CreateScriptTaskFunctionColumnEditChangeScriptTask();
			eventsubprocessfunctioncolumneditchange.FlowElements.Add(scripttaskfunctioncolumneditchange);
			ProcessSchemaStartMessageEvent specifyentitycolumnscheckboxcheckstartmessage = CreateSpecifyEntityColumnsCheckBoxCheckStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(specifyentitycolumnscheckboxcheckstartmessage);
			ProcessSchemaScriptTask specifyentitycolumnscheckboxcheckscripttask = CreateSpecifyEntityColumnsCheckBoxCheckScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(specifyentitycolumnscheckboxcheckscripttask);
			ProcessSchemaStartMessageEvent specifyentitycolumnsbuttonclickstartmessage = CreateSpecifyEntityColumnsButtonClickStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(specifyentitycolumnsbuttonclickstartmessage);
			ProcessSchemaScriptTask specifyentitycolumnsscripttask = CreateSpecifyEntityColumnsScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(specifyentitycolumnsscripttask);
			ProcessSchemaStartMessageEvent startmessagesetcolumnsmenubuttonclick = CreateStartMessageSetColumnsMenuButtonClickStartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessagesetcolumnsmenubuttonclick);
			ProcessSchemaScriptTask scripttasksetcolumnsmenubuttonclick = CreateScriptTaskSetColumnsMenuButtonClickScriptTask();
			eventsubprocess4.FlowElements.Add(scripttasksetcolumnsmenubuttonclick);
			ProcessSchemaStartMessageEvent readsometoprecordseditcheckstartmessage = CreateReadSomeTopRecordsEditCheckStartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(readsometoprecordseditcheckstartmessage);
			ProcessSchemaScriptTask readsometoprecordseditcheckscripttask = CreateReadSomeTopRecordsEditCheckScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(readsometoprecordseditcheckscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
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
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateCaptionColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageLocalizableString());
			LocalizableStrings.Add(CreateIsNotSelectedAnyEntityColumnsMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a76a7571-7209-4254-a035-8f5c1bd23bbd"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7985ba75-acb3-48e5-ad72-5642bd83a3a4"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("84527396-d2e0-4d22-a4e0-e048240ad568"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("59144159-beaf-4a8d-bb84-54a49c492883"),
				Name = "ValidationMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIsNotSelectedAnyEntityColumnsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("28845a17-3e82-426a-b5d5-3daf939decf9"),
				Name = "IsNotSelectedAnyEntityColumnsMessage",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ab88cf24-952d-4dc2-814a-382862b3b554"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(150, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bb868588-b72c-4de2-974b-89e067f76301"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83edd0f3-e63c-4668-9fc0-bdb47bf56bb2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2d13e9cc-8bf3-45ae-af88-1506d50648b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(250, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("83edd0f3-e63c-4668-9fc0-bdb47bf56bb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("32e5f3a4-6bfe-4610-88e2-4b52fa46f982"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("292ef6e4-e038-46ea-92e5-51a9daaac081"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(240, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2db048fb-62fc-4dc6-9110-46b3fbb6b6a2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db28b24b-a162-4a02-8672-91b94102c9e5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("9a98f4b9-f7c3-48bd-ad6c-7b98867fb263"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(152, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("81336f9a-b9ec-4e36-865f-eed2b061e359"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2db048fb-62fc-4dc6-9110-46b3fbb6b6a2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("697ca56c-ba78-4362-a30f-5f344aa64908"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f83c7c63-e93d-40b1-8ec2-8b5c9122a7bb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9497386-a058-4d1b-ad47-d96d78b3ec1c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("5f9a65e9-da06-47c8-8cad-0513da3a5305"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0575c6f7-4062-4dbb-ae9f-f5ac5099f08a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e48c0bb1-1a35-451e-b273-fe73ed22aa07"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("07e77915-1ecc-400a-a158-7bbf35df9da1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0565db16-6f2f-404d-8af3-bd93505423d2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6f6821c7-ec9e-43b4-9563-91876d004430"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("7cefff1b-2b85-4a01-bc08-1d0c8d5f997a"),
				ConditionExpression = @"EntitySchemaUId != Guid.Empty && (Guid)Page.ObjectEdit.Value != EntitySchemaUId",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(324, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f6821c7-ec9e-43b4-9563-91876d004430"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d588e308-1f40-4322-9d9d-c1456464970b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("8f235056-862d-4bdf-a4ed-35e3ed48eb65"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(446, 62),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d588e308-1f40-4322-9d9d-c1456464970b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("2bf8075a-85e7-419a-bd71-7de9fca8bd25"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(316, 178),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6f6821c7-ec9e-43b4-9563-91876d004430"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("871877ed-acc0-4394-99a5-f301d40747c0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("53e9d8e2-4835-44a6-a7fe-e225da7c137c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(194, 339),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42a48851-809f-4d84-9c2d-5032f054a41b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94302525-8dd8-4732-a9ea-54f74c074171"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("d2ee95c0-26a6-4ad4-92ef-bf2c49f37e05"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(478, 340),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7991a852-b003-42fd-a9bc-a68f740c4f56"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5e553897-8444-4a15-9b52-57e8594e1629"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("1c855f8f-cf58-4731-9da3-9c43e1c4c844"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e48c0bb1-1a35-451e-b273-fe73ed22aa07"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("21913e8d-d6bf-4789-b93a-a4f7e9fbd908"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("a0051c7d-bf15-494e-86a5-46a51dfd9797"),
				ConditionExpression = @"IsFilterParamsValuesCorrect && IsSelectedAnyEntityColumns",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(406, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21913e8d-d6bf-4789-b93a-a4f7e9fbd908"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f83c7c63-e93d-40b1-8ec2-8b5c9122a7bb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow16",
				UId = new Guid("8cc2a676-e613-4525-b27c-c9aceb915191"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(406, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21913e8d-d6bf-4789-b93a-a4f7e9fbd908"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("315606ef-b9a9-4129-8c15-06acb6352fae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("bd25f734-182f-4ad3-88d9-4f2d32eb7761"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14e4e359-66fd-4be4-a081-b51c7fc6d3d5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b15cac2-ff4e-4a1a-9b36-c7b9dd8208ec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("43b7aded-f690-47a0-907b-7994f506ca6d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e09c491-06fb-499e-ae1f-fd3a2410fce2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("998382e8-40c6-4062-836b-7c1822687d97"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("f33db936-9194-492d-89a3-7d417d2b1130"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2d7b1eee-5031-4edb-901a-0468dd8891c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0f578e2e-4192-4b8d-86c9-cfa70f6630b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("3c6b3baa-f666-4793-9180-528123803c25"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d43fbc4-ccaf-4091-b0fb-e07ed074317f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db6e7a94-333c-4e5e-bd28-9f5142b0c8e2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("8220ccc4-4202-424a-acf4-18846660e2bf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6328f40-824c-4a16-b4fb-4b44fdb3869b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4871b103-1a1e-4d45-9f11-13b70ddf4e8d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("4606cec8-d0ad-407f-8dc1-336ac2341e23"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21360584-d516-4823-8d92-adac38be592e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("038bf8c8-b630-43b3-ac73-9140854077cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("a211fd1c-780a-4f3c-b88b-bf45aefb904a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de965e78-bf7c-4bbe-ae10-752eb2482ab7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("07b7b7d8-a42b-431b-bc8b-0b986a0e3f61"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("dbb76b2c-215c-43e0-a8af-8bd2cc20a7d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d02fe798-8ed3-43ca-9052-a045d515b224"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("171427ba-8d81-429b-89aa-e5c0ac14c3b5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("1a7ca50b-dbae-4ad4-b46b-42edc7dfddb0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4eeb3a5-b9ec-4b36-90df-c7745f0c14da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("208f2e2b-8ada-4c5a-a659-f7719579caa8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e4f191cf-a8d7-4a7c-83fd-53ad3f23d040"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1182, 1824),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLaneInitEventsLane() {
			ProcessSchemaLane schemaLaneInitEvents = new ProcessSchemaLane(this) {
				UId = new Guid("a4df6f68-4c7c-45ce-8217-b48165143b85"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("e4f191cf-a8d7-4a7c-83fd-53ad3f23d040"),
				CreatedInOwnerSchemaUId = new Guid("8ba077d3-6338-40e7-91f6-72bd49208660"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"LaneInitEvents",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1535),
				Size = new Size(1153, 289),
				UseBackgroundMode = false
			};
			return schemaLaneInitEvents;
		}

		protected virtual ProcessSchemaLane CreateButtonsLaneLane() {
			ProcessSchemaLane schemaButtonsLane = new ProcessSchemaLane(this) {
				UId = new Guid("156e511a-1a24-4a7b-bb7b-be96aba65774"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("e4f191cf-a8d7-4a7c-83fd-53ad3f23d040"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ButtonsLane",
				Position = new Point(29, 1051),
				Size = new Size(1153, 479),
				UseBackgroundMode = false
			};
			return schemaButtonsLane;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("92eaa999-9e69-4571-9826-e1d44f1fe0d0"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("e4f191cf-a8d7-4a7c-83fd-53ad3f23d040"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"Lane3",
				Position = new Point(29, 623),
				Size = new Size(1153, 423),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e4f191cf-a8d7-4a7c-83fd-53ad3f23d040"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"Lane2",
				Position = new Point(29, 0),
				Size = new Size(1153, 618),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOnInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOnInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fce45a8b-feff-462e-979e-71b9ee6390d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a4df6f68-4c7c-45ce-8217-b48165143b85"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessOnInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(305, 125),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOnInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bb868588-b72c-4de2-974b-89e067f76301"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce45a8b-feff-462e-979e-71b9ee6390d3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("83edd0f3-e63c-4668-9fc0-bdb47bf56bb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce45a8b-feff-462e-979e-71b9ee6390d3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("32e5f3a4-6bfe-4610-88e2-4b52fa46f982"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fce45a8b-feff-462e-979e-71b9ee6390d3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,81,115,218,56,16,126,78,102,242,31,84,63,116,236,30,227,94,95,47,129,25,66,72,143,153,52,101,128,244,30,58,125,80,236,53,168,200,146,43,201,73,184,12,255,253,86,146,29,48,134,164,189,185,155,60,0,246,106,247,219,221,111,87,43,193,50,18,142,244,64,242,50,23,83,163,202,196,148,10,134,15,5,151,10,212,64,1,53,144,70,143,39,199,71,254,249,128,98,24,157,158,28,175,79,142,199,116,14,241,117,153,223,130,250,156,77,32,145,42,213,195,148,153,120,80,106,35,243,129,20,25,155,199,253,52,13,5,220,19,255,58,50,144,135,193,130,165,48,86,44,167,106,53,147,146,159,151,198,72,17,116,72,128,174,32,136,44,254,104,40,202,28,20,189,229,112,246,177,100,105,143,20,52,89,162,199,81,170,73,151,204,64,41,170,101,134,206,48,164,120,236,215,116,252,151,84,75,141,154,112,99,24,103,134,161,232,35,152,106,249,79,134,128,42,89,172,16,35,188,209,152,178,20,2,18,195,164,232,144,75,38,210,11,208,108,46,32,29,43,153,128,214,211,100,1,57,13,163,26,254,102,148,118,144,156,166,229,198,101,60,74,109,228,242,246,59,174,124,253,70,252,195,120,59,236,77,14,241,128,106,115,230,85,122,232,98,38,251,152,209,202,113,123,71,213,70,243,146,113,3,10,109,45,137,23,204,249,68,222,206,180,81,76,204,59,149,151,30,177,101,59,122,12,18,153,23,84,49,45,197,108,85,64,96,243,178,246,131,134,56,30,254,40,41,95,119,188,9,135,204,96,109,21,102,140,216,190,232,99,106,22,182,32,211,149,174,18,8,106,245,82,195,5,211,5,167,171,47,148,151,214,69,70,185,134,122,89,177,249,98,11,110,76,21,205,1,35,112,202,58,232,180,104,89,175,171,148,115,42,80,162,174,81,255,117,147,254,180,9,228,63,203,218,38,242,212,25,143,193,80,24,102,86,190,193,42,119,193,250,137,9,120,48,32,82,4,1,97,94,151,138,225,86,36,255,19,23,222,214,229,238,38,202,103,183,226,6,201,88,1,70,13,87,82,46,203,162,34,226,183,46,73,129,195,28,231,19,9,61,10,209,24,35,168,14,241,138,214,116,120,135,1,247,213,92,19,136,28,53,150,214,204,33,216,125,8,177,71,211,232,244,168,18,187,73,181,179,237,162,221,245,86,143,182,52,218,181,115,227,18,63,12,167,239,27,36,52,30,233,254,119,250,48,129,31,72,135,241,225,185,204,237,96,153,81,189,156,49,195,193,17,48,67,52,12,119,200,33,71,184,107,184,31,208,194,54,192,105,149,81,10,153,103,21,149,194,61,205,209,24,100,205,66,244,162,11,200,104,201,141,7,176,136,83,48,219,178,240,9,253,107,48,1,141,98,215,82,223,58,36,12,153,48,81,5,62,1,154,94,80,67,55,42,177,239,110,59,212,166,46,144,48,122,10,229,160,54,42,95,201,132,114,246,55,164,27,171,109,199,209,11,49,94,150,194,17,208,140,178,63,159,43,219,45,213,130,133,78,76,60,45,243,102,120,7,213,14,196,213,112,246,82,100,54,233,169,204,97,38,139,234,156,180,241,5,151,182,243,113,63,248,106,197,195,188,48,43,151,114,75,251,37,7,59,167,176,67,255,16,212,95,187,171,14,173,81,125,210,221,180,146,95,180,7,225,39,153,194,128,83,173,241,53,81,172,48,210,118,220,211,99,151,108,201,169,38,7,141,44,34,110,5,142,45,80,128,50,43,91,255,169,44,85,2,161,255,233,108,193,70,117,111,23,45,109,219,228,95,152,50,56,187,54,194,168,141,106,17,218,214,49,242,55,224,204,206,5,172,220,29,76,228,189,59,109,143,206,241,228,183,187,77,42,29,226,101,161,122,180,210,170,216,109,172,206,134,46,7,49,18,204,212,29,113,197,180,241,192,239,223,85,169,104,28,88,9,222,173,124,167,251,9,107,57,159,238,149,35,149,22,163,218,196,189,211,122,60,76,11,72,88,182,106,40,15,22,144,44,207,229,67,236,30,32,69,208,253,206,222,224,1,82,114,78,222,190,221,175,128,247,168,82,24,210,35,191,91,127,250,158,153,100,129,59,232,224,174,141,236,253,12,47,70,74,67,104,240,93,102,207,232,110,209,213,28,37,177,19,70,126,6,30,37,84,195,139,115,226,15,171,233,9,153,208,148,73,127,121,172,102,200,134,5,123,147,60,117,170,88,246,161,176,247,200,180,174,16,94,222,140,146,92,215,157,19,186,35,40,218,85,223,217,54,45,43,235,162,101,180,183,72,207,88,222,226,77,123,121,250,19,217,215,193,251,252,237,89,114,112,244,121,86,73,183,251,236,8,116,5,223,30,130,85,21,218,228,58,205,189,220,254,42,185,191,192,238,1,179,159,226,119,219,118,77,0,95,14,165,86,71,253,175,179,219,42,229,107,36,215,236,33,251,250,238,189,251,115,166,0,255,178,9,159,204,63,19,130,17,187,247,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("526ec1cf-521c-475a-97b5-c632418ed617"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a4df6f68-4c7c-45ce-8217-b48165143b85"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 147),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(314, 128),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("81336f9a-b9ec-4e36-865f-eed2b061e359"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("526ec1cf-521c-475a-97b5-c632418ed617"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2db048fb-62fc-4dc6-9110-46b3fbb6b6a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("526ec1cf-521c-475a-97b5-c632418ed617"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("db28b24b-a162-4a02-8672-91b94102c9e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("526ec1cf-521c-475a-97b5-c632418ed617"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,77,111,211,64,16,61,167,18,255,97,225,130,45,69,22,103,2,149,218,52,173,138,250,165,184,192,1,245,176,177,199,201,130,189,107,246,163,37,160,252,119,102,119,253,21,215,105,27,33,113,137,172,120,222,155,153,183,179,111,60,21,60,99,75,35,225,148,229,26,228,44,101,58,8,39,175,14,110,232,18,162,91,9,112,38,89,58,135,68,200,52,22,82,51,190,140,226,149,120,56,50,90,124,101,169,94,93,2,55,228,35,201,104,174,224,121,216,165,201,53,187,96,28,246,131,197,166,40,168,100,160,94,14,59,87,22,120,93,150,66,49,13,115,200,64,2,79,160,3,190,167,146,148,84,210,2,176,111,133,47,78,32,163,88,223,23,154,27,80,132,42,114,194,18,205,4,167,114,253,65,105,137,172,99,114,35,69,2,74,197,201,10,10,122,83,163,29,228,16,57,89,70,130,46,231,71,194,77,158,135,228,207,171,131,145,4,109,36,39,90,26,155,125,227,131,95,183,209,223,222,204,65,97,254,25,215,76,175,223,220,69,77,209,62,219,231,243,52,154,253,52,88,125,112,102,24,62,23,165,94,135,158,219,99,154,56,108,102,47,94,172,103,228,180,244,49,39,84,211,88,24,153,64,212,165,236,37,105,64,215,139,239,144,104,59,57,81,12,94,190,35,158,222,194,47,29,244,32,99,132,60,153,40,154,210,210,74,30,221,138,216,41,30,132,118,24,71,94,126,2,14,53,21,185,41,248,37,104,60,0,189,2,213,235,118,54,24,132,125,187,202,44,155,19,222,83,226,156,92,225,9,93,75,167,102,48,156,160,18,185,170,226,219,221,86,29,77,13,195,216,40,46,115,188,82,111,39,111,93,35,35,59,117,10,114,20,12,210,225,74,145,138,195,3,185,96,74,87,99,119,24,120,108,38,36,208,100,69,130,1,57,44,150,48,62,80,90,85,252,232,233,172,209,81,154,6,125,176,79,187,177,63,241,0,218,150,250,52,235,164,57,240,184,132,132,101,235,45,248,116,5,201,143,99,241,43,114,15,144,62,75,23,77,133,225,154,28,146,119,150,120,211,14,70,230,204,171,63,9,237,120,121,115,123,225,16,84,100,245,169,219,19,251,174,4,159,10,126,15,18,223,84,7,244,136,253,83,55,40,112,154,127,86,32,241,47,14,206,72,208,62,172,20,173,211,70,45,71,59,29,62,61,182,158,123,20,166,179,204,209,9,32,25,163,57,251,13,117,137,99,162,215,37,136,44,232,215,210,162,195,49,113,149,52,35,181,85,229,33,249,211,235,109,19,58,231,219,201,231,202,180,218,61,42,243,117,215,236,186,173,216,78,207,164,48,37,118,50,124,249,79,25,79,43,17,93,224,241,250,10,15,241,81,138,200,254,235,133,234,148,208,210,247,42,216,225,52,83,35,209,253,52,250,139,73,208,145,235,243,80,232,139,133,184,135,62,107,149,207,93,130,125,25,237,157,234,55,209,222,169,205,78,215,189,16,52,109,216,252,229,239,79,14,58,109,11,8,6,105,28,238,156,51,61,184,33,29,45,150,176,16,34,39,76,205,56,93,228,48,96,243,86,213,118,223,32,6,51,87,193,56,53,90,10,220,71,13,220,114,170,7,166,173,73,5,213,174,156,3,77,109,81,126,11,221,226,192,134,51,110,138,8,183,167,130,160,26,224,221,177,227,129,85,102,95,212,119,185,186,166,9,85,64,118,178,84,218,188,111,236,104,78,83,38,142,141,214,130,251,87,29,15,106,186,153,120,227,171,219,61,53,220,157,96,221,54,102,43,241,210,160,97,216,47,138,176,23,125,101,138,5,200,235,204,139,174,30,129,182,52,235,2,7,157,242,25,244,2,23,195,143,201,243,50,212,45,188,175,111,113,87,219,250,101,87,93,251,9,19,4,140,235,240,104,185,148,176,164,117,128,93,207,137,246,134,28,118,215,117,117,249,250,42,187,192,157,34,239,169,242,30,50,15,163,94,164,113,7,186,33,128,207,59,90,171,43,254,167,238,122,7,250,255,59,180,63,214,44,58,231,236,97,214,116,149,93,29,193,246,172,33,162,251,73,251,23,95,198,78,59,73,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickChildSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickChildSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("156e511a-1a24-4a7b-bb7b-be96aba65774"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"OkButtonClickChildSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(523, 298),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickChildSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0575c6f7-4062-4dbb-ae9f-f5ac5099f08a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessage2",
				Position = new Point(22, 139),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b9497386-a058-4d1b-ad47-d96d78b3ec1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IntermediateThrowMessageEvent2",
				Position = new Point(477, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f83c7c63-e93d-40b1-8ec2-8b5c9122a7bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptChildOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(358, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,91,79,219,48,20,126,14,18,255,193,202,3,74,164,40,234,246,8,131,105,189,33,38,40,85,83,120,153,246,224,38,39,212,35,177,51,219,1,186,170,255,125,118,236,180,233,117,76,83,181,7,36,114,252,157,219,119,62,31,183,151,65,14,84,14,224,181,131,11,73,24,69,151,104,136,159,32,124,16,192,199,88,60,143,137,204,160,151,16,25,142,225,77,94,156,158,188,96,142,40,163,240,24,105,40,103,49,8,17,197,83,200,241,16,115,156,131,4,254,136,179,18,34,86,242,24,194,129,130,90,175,152,81,33,223,233,214,169,176,218,96,157,139,26,37,42,107,85,230,186,5,11,212,37,177,238,1,243,217,39,33,57,161,79,193,161,84,87,42,52,73,145,183,21,250,18,209,50,203,124,52,63,61,113,54,179,92,238,192,35,10,175,127,155,219,243,125,149,126,97,154,75,73,166,14,58,44,203,32,110,14,161,95,217,43,246,187,88,98,203,77,159,208,196,156,136,107,206,202,162,61,27,168,200,158,187,66,187,190,101,237,135,96,84,81,249,2,92,157,212,133,46,35,217,32,95,155,32,79,15,94,125,81,83,73,112,160,16,157,100,131,139,111,238,86,116,247,187,205,123,128,13,207,112,125,199,18,146,18,72,110,168,1,61,220,36,202,87,103,93,126,7,10,102,194,171,147,77,218,148,106,74,42,209,21,106,161,207,75,181,157,91,181,106,207,122,94,7,29,21,206,209,148,132,17,112,130,51,242,11,188,77,124,176,78,172,175,146,152,153,135,189,188,144,51,53,215,93,212,140,64,148,153,236,81,73,228,236,136,172,152,4,203,179,176,247,179,196,153,240,174,75,146,152,242,124,213,164,189,193,231,53,77,77,118,92,87,127,141,32,5,14,52,134,181,172,235,177,223,209,232,138,180,35,182,220,104,226,159,202,198,73,196,114,24,179,98,4,49,227,201,49,181,187,131,119,115,213,182,171,168,174,93,103,10,241,51,36,225,152,69,149,210,60,127,79,23,131,50,159,0,191,79,255,99,11,27,37,44,95,15,83,177,222,75,98,98,171,50,205,180,75,146,37,106,247,232,141,146,50,14,56,158,34,207,60,25,89,153,83,68,168,9,60,230,0,215,156,36,38,112,196,184,212,119,174,177,26,187,144,170,136,101,44,75,174,223,16,237,44,76,115,122,209,139,73,120,11,244,73,78,245,77,55,102,71,217,190,20,5,208,196,115,131,106,109,58,106,39,175,172,125,198,115,44,61,119,222,90,156,207,63,168,191,143,11,55,176,101,133,122,237,6,200,35,84,250,214,114,207,85,27,93,194,235,53,209,52,15,153,32,218,106,247,254,214,224,42,208,13,77,217,17,71,182,98,64,61,114,173,63,236,1,5,94,169,45,48,195,155,48,150,33,34,162,2,226,42,241,242,146,107,166,235,103,107,132,19,194,218,165,148,140,154,243,90,189,232,236,204,32,140,255,108,205,187,194,180,217,91,13,182,175,243,190,100,134,128,70,67,168,165,167,103,11,236,19,46,164,178,41,49,232,95,16,142,85,149,103,214,52,18,160,151,210,122,196,33,86,81,148,210,188,91,34,164,125,195,175,252,104,7,210,230,118,76,121,85,42,107,113,86,153,83,181,116,171,212,206,2,129,250,215,2,26,122,187,48,122,171,4,215,176,239,171,173,22,103,35,220,206,226,144,249,249,178,71,101,77,232,29,72,172,35,195,49,183,196,94,177,28,126,162,15,184,173,233,114,231,211,203,65,45,0,106,134,255,27,78,140,240,218,226,10,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckData_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e48c0bb1-1a35-451e-b273-fe73ed22aa07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"CheckData_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 125),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,77,75,195,64,16,134,207,13,228,63,108,123,40,233,37,120,215,22,76,140,18,40,181,24,240,190,100,39,117,113,179,27,102,102,165,65,252,239,110,18,139,40,161,215,119,158,125,63,216,146,30,181,97,192,163,68,217,210,171,52,30,40,119,136,80,179,216,10,70,15,183,113,244,33,81,52,35,70,65,60,202,19,164,211,171,66,105,78,31,36,203,202,121,172,7,213,170,233,66,79,232,124,151,245,7,217,66,178,250,165,87,155,224,87,94,13,93,254,68,165,37,221,219,126,15,13,23,231,14,129,72,59,123,240,198,60,99,209,118,220,39,131,147,110,68,50,246,121,145,74,187,204,51,59,91,88,214,220,167,249,27,212,239,160,196,122,61,53,174,58,168,117,211,79,215,220,25,223,90,26,153,204,157,47,240,70,124,198,209,98,152,75,96,66,27,80,127,240,80,174,154,213,37,137,189,38,190,35,70,109,79,187,80,108,81,210,5,13,35,254,187,204,187,47,183,194,134,125,67,227,89,32,205,157,183,44,118,226,38,4,124,197,17,2,123,180,211,39,125,3,241,212,117,24,200,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("21913e8d-d6bf-4789-b93a-a4f7e9fbd908"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 125),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateErrorMessage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("315606ef-b9a9-4129-8c15-06acb6352fae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4dd6b33-9177-4f48-aa7f-144a09e6375c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ErrorMessage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(358, 209),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,142,191,10,194,64,12,198,103,11,190,195,185,181,80,250,2,157,74,81,232,80,57,80,116,14,54,150,192,53,39,185,220,80,196,119,183,130,117,81,65,112,203,23,190,63,63,11,61,22,45,16,183,24,194,116,91,96,116,69,237,16,36,205,202,101,66,103,147,174,154,176,33,167,40,22,4,134,112,0,23,49,212,94,4,79,154,153,235,50,89,216,143,45,85,215,61,117,58,101,168,3,37,63,59,246,164,14,115,243,246,207,205,108,24,47,88,28,65,152,184,127,128,220,94,44,59,116,211,48,118,21,143,107,86,210,177,246,46,14,28,254,68,105,194,214,235,183,238,31,232,4,53,10,27,149,136,229,29,159,8,194,254,86,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92eaa999-9e69-4571-9826-e1d44f1fe0d0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcess3",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(496, 240),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0565db16-6f2f-404d-8af3-bd93505423d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectEditChange",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EntitySchemaEditChangeStartMessage",
				Position = new Point(43, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepareChangeSchemaEntityQuestionScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d588e308-1f40-4322-9d9d-c1456464970b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskPrepareChangeSchemaEntityQuestion",
				Position = new Point(266, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,140,49,14,130,64,16,69,107,57,197,102,107,226,5,80,11,145,130,66,80,129,130,114,67,38,64,225,172,217,25,162,132,112,119,119,227,22,38,24,105,230,103,242,223,251,113,167,176,133,162,233,224,174,18,228,158,199,138,192,156,129,72,181,176,189,216,35,246,194,69,20,196,127,81,159,37,188,216,26,75,214,247,107,51,105,163,209,250,242,90,37,69,153,230,153,92,19,142,3,179,70,114,78,157,20,89,190,42,220,128,30,86,0,255,59,19,225,41,78,125,195,189,70,101,198,29,177,233,177,13,197,39,15,98,10,54,147,28,129,100,40,228,114,187,6,242,83,114,14,29,137,250,55,152,233,47,110,142,2,3,60,24,20,108,6,136,222,35,22,238,217,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("6f6821c7-ec9e-43b4-9563-91876d004430"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeSchemaEntityUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a3cecbe1-24ca-47ad-b21d-2e30ef30c9b5"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ChangeSchemaEntityUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(406, 21),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeSchemaEntityUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("871877ed-acc0-4394-99a5-f301d40747c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("312bfabd-fd68-4453-ae43-88fee0181b27"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(280, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeSchemaEntityYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeSchemaEntityYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3b58efef-3eee-4f2c-9fb5-27e930d8209e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92eaa999-9e69-4571-9826-e1d44f1fe0d0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessChangeSchemaEntityYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 252),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeSchemaEntityYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("42a48851-809f-4d84-9c2d-5032f054a41b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b58efef-3eee-4f2c-9fb5-27e930d8209e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ChangeSchemaEntityYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEntitySchemaEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("94302525-8dd8-4732-a9ea-54f74c074171"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b58efef-3eee-4f2c-9fb5-27e930d8209e"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptEntitySchemaEditChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,77,79,27,49,16,61,7,137,255,176,229,80,237,74,149,165,158,251,33,65,88,40,18,130,40,11,244,236,216,147,196,101,99,167,99,111,105,84,241,223,59,254,88,178,187,44,133,30,162,68,158,121,111,198,239,141,39,165,118,202,237,42,177,134,13,191,189,144,217,151,44,215,240,144,85,80,131,112,249,173,5,156,26,173,233,183,50,186,56,60,152,176,169,169,155,141,206,143,40,249,40,28,156,161,217,228,71,213,206,70,146,120,248,125,13,8,249,81,155,115,97,203,159,13,175,243,8,102,51,142,124,3,14,48,207,207,27,37,139,25,95,1,187,94,252,160,50,165,84,142,221,241,186,129,162,200,184,77,141,4,146,242,55,136,198,65,37,120,205,241,179,7,126,205,139,79,135,7,191,56,102,214,97,35,92,131,64,23,8,108,101,184,215,41,119,188,50,13,10,96,211,6,17,180,171,218,68,2,62,129,210,165,44,155,214,192,49,144,198,186,32,35,79,138,19,185,110,234,154,194,227,53,186,50,150,125,97,9,51,7,11,142,212,116,104,234,112,67,27,42,169,101,150,15,146,89,80,203,6,113,88,185,217,186,29,137,241,135,52,168,192,149,154,47,106,144,137,199,230,75,74,4,207,211,9,158,53,58,24,214,38,205,208,108,1,221,110,52,249,170,217,44,0,175,151,115,16,6,165,125,19,166,218,130,80,203,93,79,156,127,0,131,90,109,83,55,187,45,4,151,247,98,247,19,34,223,48,5,129,156,210,25,89,230,173,123,60,60,232,106,150,217,248,245,146,249,49,43,205,202,22,213,134,99,106,155,32,157,49,64,224,14,210,132,71,202,15,137,154,205,186,40,230,77,186,49,52,76,74,175,242,194,55,216,99,165,129,191,83,86,145,84,196,31,116,232,141,219,177,148,169,72,15,213,14,179,84,118,91,243,78,131,189,14,78,187,209,52,63,3,68,28,211,56,50,75,67,151,18,235,44,247,204,34,38,40,221,114,38,239,98,234,196,83,137,116,65,75,66,122,171,60,91,87,234,136,120,10,179,115,208,128,60,21,155,76,134,189,139,182,77,138,45,168,147,251,240,147,236,243,159,199,177,238,223,117,187,239,52,253,170,81,61,154,17,135,38,233,106,215,40,1,79,21,198,165,70,188,253,3,118,108,5,104,73,176,33,102,102,172,74,144,143,62,54,102,168,120,114,242,49,154,185,86,36,15,138,245,51,59,191,245,3,201,201,97,122,82,35,123,255,62,123,190,174,206,148,150,39,187,43,218,165,67,28,243,135,69,127,18,254,71,203,33,221,203,106,142,77,250,235,202,196,7,175,106,250,15,8,15,157,86,203,254,185,230,163,143,184,120,113,237,94,26,46,231,230,33,174,211,144,114,131,0,231,168,100,220,105,149,65,71,125,179,57,44,17,236,218,35,67,234,133,86,238,120,181,66,88,241,253,222,241,194,217,75,101,221,158,109,206,165,50,39,141,115,70,199,218,108,186,6,113,15,126,205,167,125,52,178,152,125,164,232,133,94,95,203,111,223,202,207,217,223,180,147,91,88,119,155,254,5,194,79,113,225,3,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeSchemaEntityNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeSchemaEntityNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d4585bc0-3134-475a-b808-347912426115"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92eaa999-9e69-4571-9826-e1d44f1fe0d0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessChangeSchemaEntityNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(322, 252),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(261, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeSchemaEntityNoMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7991a852-b003-42fd-a9bc-a68f740c4f56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4585bc0-3134-475a-b808-347912426115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityNoMessage",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ChangeSchemaEntityNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEntitySchemaEditNotChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5e553897-8444-4a15-9b52-57e8594e1629"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d4585bc0-3134-475a-b808-347912426115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptEntitySchemaEditNotChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,10,194,48,20,69,119,191,162,99,10,146,31,232,84,52,131,147,197,180,238,207,228,82,83,236,75,73,94,164,254,189,96,39,197,245,112,14,247,118,52,66,159,111,19,156,24,31,68,219,146,23,176,111,39,90,205,19,44,89,213,205,174,251,149,32,87,122,20,180,236,123,172,162,12,75,144,151,117,119,204,52,156,252,190,250,4,27,61,146,144,141,37,57,232,77,208,7,90,36,68,214,125,180,146,2,143,170,254,51,113,65,46,51,190,111,36,72,73,92,73,42,104,222,0,15,248,68,184,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessCountEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessCount = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cb09a195-8dfc-4094-85a3-d15f19efa321"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessCount",
				Position = new Point(29, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(265, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessCount;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRadioButtonCountCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("14e4e359-66fd-4be4-a081-b51c7fc6d3d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb09a195-8dfc-4094-85a3-d15f19efa321"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RadioButtonCountCheck",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageRadioButtonCountCheck",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCountCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b15cac2-ff4e-4a1a-9b36-c7b9dd8208ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cb09a195-8dfc-4094-85a3-d15f19efa321"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskCountCheck",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,203,106,195,48,16,60,55,144,127,80,115,178,161,248,7,66,14,173,155,30,83,99,167,189,111,228,181,35,34,75,102,181,42,152,210,127,175,20,37,244,1,233,3,4,123,216,153,157,97,70,170,19,89,5,61,22,53,180,202,222,121,102,107,74,235,13,23,229,30,229,1,219,92,188,206,103,87,142,73,153,94,188,128,246,40,86,34,203,148,225,188,34,43,209,185,26,161,189,7,134,26,157,215,188,157,70,44,30,188,145,172,172,201,139,173,109,142,212,44,95,134,51,13,242,147,67,218,130,59,84,64,48,32,35,149,214,56,126,142,135,179,197,199,137,197,77,18,59,141,35,251,171,250,109,223,19,246,16,101,34,33,202,200,224,58,122,255,175,236,217,238,37,225,192,95,27,216,105,108,207,200,192,102,178,218,133,8,70,36,158,178,14,180,251,14,222,248,97,135,244,216,213,40,45,181,238,79,156,102,68,169,186,105,109,88,241,84,90,237,7,243,19,49,225,26,185,199,1,132,75,99,37,142,133,166,85,44,166,177,158,36,22,9,21,89,42,148,126,2,95,175,132,241,90,167,150,127,13,234,83,230,201,219,38,96,66,98,233,88,81,145,26,128,78,182,139,184,187,176,42,97,60,126,143,104,230,109,62,11,143,144,61,25,193,228,113,249,14,230,26,212,181,148,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessEntityEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessEntity = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ae0e901c-3ebd-48a8-9147-8eed48e91583"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessEntity",
				Position = new Point(308, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessEntity;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRadioButtonEntityCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5e09c491-06fb-499e-ae1f-fd3a2410fce2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae0e901c-3ebd-48a8-9147-8eed48e91583"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RadioButtonEntityCheck",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageRadioButtonEntityCheck",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskEntityCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("998382e8-40c6-4062-836b-7c1822687d97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ae0e901c-3ebd-48a8-9147-8eed48e91583"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskEntityCheck",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,208,193,74,196,64,12,6,224,179,11,251,14,67,79,83,144,226,125,241,98,93,197,139,150,182,122,207,118,210,221,97,167,153,146,201,8,69,124,119,187,206,22,97,5,241,146,92,242,253,33,177,189,210,21,236,177,168,193,88,127,23,69,60,109,73,172,76,69,121,192,238,136,38,87,31,235,213,85,16,182,180,87,239,224,34,170,91,165,181,37,201,43,246,29,134,80,35,152,123,16,168,49,68,39,237,52,98,145,34,242,162,245,205,55,212,249,102,14,105,80,94,3,114,11,225,88,1,195,128,130,92,122,10,242,118,138,213,217,79,64,118,157,86,157,219,191,244,67,164,78,172,167,179,207,110,82,89,236,150,96,231,208,44,83,179,20,246,46,204,55,140,200,50,233,30,92,192,139,225,231,56,236,144,95,250,26,59,207,38,252,50,194,241,146,52,35,118,182,159,210,3,74,239,226,64,127,184,39,178,210,50,226,35,91,147,150,52,158,101,121,216,231,122,197,40,145,73,157,192,230,11,134,248,141,62,172,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessFunctionEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessFunction = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("afd6728a-cd4f-48de-a4d3-b05c5847d6ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessFunction",
				Position = new Point(28, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(265, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessFunction;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageFunctionCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2d7b1eee-5031-4edb-901a-0468dd8891c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afd6728a-cd4f-48de-a4d3-b05c5847d6ca"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RadioButtonFunctionCheck",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageFunctionCheck",
				Position = new Point(43, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskFunctionCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0f578e2e-4192-4b8d-86c9-cfa70f6630b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afd6728a-cd4f-48de-a4d3-b05c5847d6ca"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskFunctionCheck",
				Position = new Point(155, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,81,75,195,48,20,133,159,39,248,31,66,159,90,144,224,251,216,131,206,10,3,217,70,59,125,207,146,219,26,150,38,229,230,70,40,206,255,110,218,90,156,155,136,79,121,201,119,206,249,174,174,88,186,21,53,240,66,40,237,238,3,145,179,143,193,74,210,206,242,229,43,200,3,168,140,189,95,95,205,60,161,182,53,123,19,38,0,91,176,52,213,150,178,45,58,9,222,23,32,212,131,32,81,128,15,134,118,93,11,124,10,201,248,206,149,3,154,102,243,24,83,2,61,123,192,157,240,135,173,64,209,0,1,46,157,245,244,210,7,167,201,119,68,114,51,150,125,61,3,61,181,15,147,167,138,254,115,174,52,241,18,12,72,2,181,34,104,248,144,215,51,58,42,142,227,249,202,175,131,49,27,204,155,150,186,116,140,101,199,227,36,181,96,201,109,50,218,206,126,122,222,213,53,66,45,166,182,94,72,198,190,208,156,235,125,252,67,241,116,247,111,146,145,207,173,216,27,80,211,207,72,19,58,227,227,185,91,192,56,157,240,226,239,58,52,123,192,77,85,128,116,168,252,5,82,9,227,207,153,178,5,169,171,46,183,164,169,91,58,19,26,251,23,184,178,154,78,46,49,2,235,40,232,159,180,167,225,0,209,31,129,2,90,214,79,156,127,2,208,15,21,242,95,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessFunctionTypeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessFunctionType = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("330e0830-d008-4d09-882d-1a621ff12ae1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessFunctionType",
				Position = new Point(308, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(269, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessFunctionType;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageFunctionTypeEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3d43fbc4-ccaf-4091-b0fb-e07ed074317f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("330e0830-d008-4d09-882d-1a621ff12ae1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FunctionTypeEditChange",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageFunctionTypeEditChange",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskFunctionTypeEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("db6e7a94-333c-4e5e-bd28-9f5142b0c8e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("330e0830-d008-4d09-882d-1a621ff12ae1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskFunctionTypeEditChange",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,65,10,194,48,16,69,215,22,188,67,232,170,5,201,5,196,133,22,133,130,72,177,213,125,104,198,24,218,78,100,50,17,68,188,187,77,85,112,245,55,239,189,111,47,34,171,148,1,121,84,218,186,77,96,118,184,11,216,178,117,40,139,43,180,29,232,92,60,231,201,204,51,89,52,226,174,250,0,98,37,38,233,71,54,143,27,108,181,101,89,67,15,45,131,46,25,6,121,142,232,114,84,107,224,147,7,106,148,239,42,69,106,0,6,42,28,122,158,136,44,253,207,164,139,207,197,119,242,232,151,104,121,109,12,129,81,17,43,92,31,6,60,140,29,191,183,158,179,200,188,230,9,1,7,66,193,52,158,190,1,10,40,74,74,215,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessFunctionColumnEditChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessFunctionColumnEditChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7327e493-7ed2-48f7-83d9-c29137ebdaf6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcessFunctionColumnEditChange",
				Position = new Point(28, 315),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(262, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessFunctionColumnEditChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageFunctionColumnEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f6328f40-824c-4a16-b4fb-4b44fdb3869b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7327e493-7ed2-48f7-83d9-c29137ebdaf6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FunctionColumnEditChange",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageFunctionColumnEditChange",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskFunctionColumnEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4871b103-1a1e-4d45-9f11-13b70ddf4e8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7327e493-7ed2-48f7-83d9-c29137ebdaf6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskFunctionColumnEditChange",
				Position = new Point(155, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,204,61,10,194,64,20,69,225,218,64,246,16,82,41,132,217,64,42,9,10,54,33,144,104,255,72,46,67,112,126,224,205,125,224,242,21,27,91,235,243,113,102,240,94,160,139,148,231,36,42,17,132,14,57,21,62,36,24,142,237,217,123,133,23,238,57,13,57,88,76,227,199,180,93,93,29,38,241,112,87,75,235,175,93,182,157,110,70,192,74,108,55,34,186,239,165,107,254,178,11,94,60,245,117,165,160,105,106,168,134,254,13,110,151,146,69,159,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5db1a1ec-eefa-4a7d-8cfe-6fec20b08e31"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcess5",
				Position = new Point(309, 324),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(220, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSpecifyEntityColumnsCheckBoxCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("de965e78-bf7c-4bbe-ae10-752eb2482ab7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5db1a1ec-eefa-4a7d-8cfe-6fec20b08e31"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SpecifyEntityColumnsCheckBoxCheck",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"SpecifyEntityColumnsCheckBoxCheckStartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSpecifyEntityColumnsCheckBoxCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("07b7b7d8-a42b-431b-bc8b-0b986a0e3f61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5db1a1ec-eefa-4a7d-8cfe-6fec20b08e31"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"SpecifyEntityColumnsCheckBoxCheckScriptTask",
				Position = new Point(119, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,46,72,77,206,76,171,116,205,43,201,44,169,116,206,207,41,205,205,43,118,42,45,41,201,207,211,115,205,75,76,202,73,77,81,176,85,8,192,165,210,57,35,53,57,219,41,191,66,15,204,72,77,177,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,10,9,235,216,98,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("849be45f-0c77-489a-9c03-1259c8b00523"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("156e511a-1a24-4a7b-bb7b-be96aba65774"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcess6",
				Position = new Point(36, 317),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(237, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSpecifyEntityColumnsButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d02fe798-8ed3-43ca-9052-a045d515b224"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("849be45f-0c77-489a-9c03-1259c8b00523"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SpecifyEntityColumnsButtonClick",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"SpecifyEntityColumnsButtonClickStartMessage",
				Position = new Point(35, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSpecifyEntityColumnsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("171427ba-8d81-429b-89aa-e5c0ac14c3b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("849be45f-0c77-489a-9c03-1259c8b00523"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"SpecifyEntityColumnsScriptTask",
				Position = new Point(133, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,206,200,47,119,206,207,41,205,205,11,46,41,42,77,46,41,45,74,117,173,40,200,201,47,74,45,114,77,201,44,9,207,204,75,201,47,215,208,180,230,229,42,74,5,74,230,41,0,85,165,90,3,0,87,169,108,8,54,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f1894962-3ad0-4e7c-adac-4e2f6998fea2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("156e511a-1a24-4a7b-bb7b-be96aba65774"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcess4",
				Position = new Point(288, 315),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(270, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSetColumnsMenuButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("21360584-d516-4823-8d92-adac38be592e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1894962-3ad0-4e7c-adac-4e2f6998fea2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetColumnsMenuButtonClick",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"StartMessageSetColumnsMenuButtonClick",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSetColumnsMenuButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("038bf8c8-b630-43b3-ac73-9140854077cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1894962-3ad0-4e7c-adac-4e2f6998fea2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ScriptTaskSetColumnsMenuButtonClick",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,204,65,10,194,48,16,0,192,179,133,254,33,244,210,4,66,240,158,147,104,21,111,197,250,129,146,172,117,33,221,200,102,227,69,252,187,246,1,51,227,188,128,59,196,56,5,198,151,232,34,140,180,184,115,230,117,22,221,54,187,238,179,255,186,7,50,12,111,32,209,125,1,9,57,213,149,74,111,149,60,177,88,69,53,37,227,59,171,198,237,186,51,192,133,49,222,32,100,142,83,102,217,194,99,194,63,191,158,140,241,109,195,32,149,73,9,87,240,63,215,36,233,17,128,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("06e3b395-fc07-412f-9dce-21338111c62c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5adfa319-fe64-44e6-833a-6d9279d598a0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"EventSubProcess7",
				Position = new Point(28, 469),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(262, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReadSomeTopRecordsEditCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d4eeb3a5-b9ec-4b36-90df-c7745f0c14da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("06e3b395-fc07-412f-9dce-21338111c62c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ReadSomeTopRecordsEditCheck",
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ReadSomeTopRecordsEditCheckStartMessage",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateReadSomeTopRecordsEditCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("208f2e2b-8ada-4c5a-a659-f7719579caa8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("06e3b395-fc07-412f-9dce-21338111c62c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Name = @"ReadSomeTopRecordsEditCheckScriptTask",
				Position = new Point(155, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,202,207,207,81,200,44,118,205,75,76,202,73,77,81,176,85,8,72,76,79,213,11,74,77,76,9,206,207,77,13,201,47,8,74,77,206,47,74,41,118,77,201,44,209,115,206,72,77,206,78,77,177,230,229,2,171,242,43,205,77,74,45,242,79,67,86,130,48,8,110,40,76,185,79,98,82,106,14,154,30,28,234,139,82,75,74,139,242,20,74,138,74,83,173,1,205,44,206,251,162,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateResetControlValuesMethod());
			Methods.Add(CreateConfigureFilterEditMethod());
			Methods.Add(CreateInitFunctionListMethod());
			Methods.Add(CreateSetUserTaskParameterConstValueMethod());
			Methods.Add(CreateInitAggregationColumnNamesListMethod());
			Methods.Add(CreateInitTreeGridRecordSortingMethod());
			Methods.Add(CreateSetEnabledControlsMethod());
			Methods.Add(CreateSetCheckedRadioButtonEntityMethod());
			Methods.Add(CreateShowColumnStructureExplorerEditWindowMethod());
			Methods.Add(CreateCreateColumnStructureExplorerMethod());
			Methods.Add(CreateColumnStructureExplorer_EditCompleteMethod());
			Methods.Add(CreateSetEnabledSpecifyEntityColumnsControlsPropertyMethod());
			Methods.Add(CreateSetEnabledNumberOfRecordsControlsPropertyMethod());
			Methods.Add(CreateSetEnabledFunctionControlsPropertyMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1ae533c2-bc91-4adb-b3fd-6c47cc51ecc1"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("20c69b44-9bec-4517-98fc-5f2c345f1bb6"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7228643d-f4a9-4950-b041-d039ccd641a7"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("568a5dd3-ca8b-4c5e-baa6-5708bd17ad12")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,41,84,243,114,85,43,5,165,38,166,4,231,231,166,134,228,23,4,165,38,231,23,165,20,43,233,40,4,36,166,167,234,97,202,184,166,100,150,212,234,128,116,249,149,230,38,165,22,249,167,161,105,65,19,6,171,231,229,170,181,6,0,96,205,152,213,173,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,141,193,10,130,64,20,69,215,5,253,195,195,213,8,50,212,182,136,8,49,112,99,17,35,174,167,124,201,208,56,35,111,94,88,136,255,30,134,235,86,119,115,206,185,226,162,27,148,199,208,77,11,58,128,66,34,29,252,131,101,153,203,10,111,169,119,76,222,6,57,1,177,76,117,199,198,59,216,67,96,50,174,145,121,40,94,214,158,41,107,59,254,136,95,173,12,72,74,135,167,50,108,49,171,13,75,133,111,142,225,176,90,46,102,235,228,169,213,44,162,97,61,130,24,54,99,28,37,80,25,87,251,126,62,72,160,192,254,138,119,79,117,12,91,248,211,221,125,1,32,100,170,189,195,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("40e6b3ba-d2cc-4a95-9b2a-5e6201af991e"),
				Name = "ResetControlValues",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,206,193,10,194,48,12,6,224,179,131,189,67,189,109,151,190,192,216,101,115,245,38,162,79,16,218,76,139,53,149,46,21,134,248,238,186,10,34,219,197,91,32,95,242,255,119,8,162,183,142,49,116,198,242,54,248,120,19,181,216,195,9,101,71,108,121,220,0,195,209,199,160,81,42,75,70,37,59,36,216,140,59,184,98,145,176,250,254,248,25,147,154,76,89,229,153,237,69,49,79,90,215,130,162,115,165,120,228,217,106,182,148,173,67,8,197,116,250,204,179,20,114,0,99,125,19,153,61,125,202,201,246,140,250,130,230,93,185,7,55,96,181,132,173,143,196,127,56,21,73,179,245,180,160,47,81,80,45,185,34,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateConfigureFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("71f362e4-a56a-45c9-a7c1-9a078c79ec64"),
				Name = "ConfigureFilterEdit",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,209,74,196,48,16,69,159,205,87,204,99,11,146,15,176,44,34,186,187,244,65,17,150,253,128,208,142,235,64,50,45,153,116,31,20,255,221,212,214,213,164,5,193,167,208,228,230,222,51,183,169,15,205,43,58,243,104,216,156,208,131,56,216,192,81,208,223,119,204,216,4,234,88,239,49,36,162,98,94,159,140,195,178,82,207,190,107,80,100,146,64,159,124,109,128,7,107,43,69,47,80,68,107,18,72,212,179,81,249,174,174,242,123,69,177,170,20,87,142,60,15,40,116,226,154,37,24,110,176,72,129,175,97,219,210,140,124,172,219,18,76,22,91,169,15,64,43,8,191,176,162,123,154,4,17,234,108,60,244,50,209,44,4,255,70,185,56,85,203,177,123,209,219,51,114,144,28,248,171,194,76,61,181,123,33,109,105,249,239,214,74,212,59,226,118,198,14,232,254,64,94,129,28,131,166,108,184,157,150,155,184,167,191,59,88,235,91,141,83,199,96,27,208,143,254,250,128,33,209,164,179,141,207,42,187,112,55,132,174,102,10,100,44,189,225,207,193,222,119,67,31,161,130,31,176,250,4,87,224,197,239,206,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitFunctionListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fc7eac40-a30d-477c-9dbb-bc8a51df481f"),
				Name = "InitFunctionList",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,177,106,195,48,16,134,103,27,252,14,71,38,9,138,232,94,60,152,212,45,129,14,33,14,89,74,7,33,159,157,43,182,228,202,167,54,105,233,187,87,113,26,90,136,215,95,247,127,250,238,168,1,81,30,88,173,198,226,85,31,54,248,22,112,100,9,95,89,154,120,228,224,237,93,150,126,103,105,227,60,106,179,7,81,180,173,199,86,51,57,187,61,14,88,177,39,195,64,140,61,144,133,210,134,94,61,34,239,116,23,57,130,227,132,107,230,59,82,158,127,161,40,48,213,243,28,102,7,213,210,5,251,171,148,24,103,153,108,192,104,149,68,173,100,173,91,84,15,193,154,75,167,172,137,85,81,215,171,136,20,66,80,108,158,232,82,109,221,9,103,91,33,111,38,221,24,60,57,163,59,250,196,250,242,34,207,203,190,107,15,131,119,3,122,62,222,107,214,149,11,222,32,228,176,190,14,245,8,59,242,28,116,247,23,70,202,188,87,133,29,26,158,212,174,249,106,227,62,198,231,219,151,211,253,150,174,11,189,157,174,40,22,255,49,139,232,248,3,38,156,236,124,179,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetUserTaskParameterConstValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ecc445cf-7cc5-499b-80d6-e3c5205bcb75"),
				Name = "SetUserTaskParameterConstValue",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("590fdd06-0dbd-42eb-81f7-b2b716c98dbc"),
				Name = "parameterName",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e4c0ea19-ea27-4d47-be1f-56f3fa921407"),
				Name = "value",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("82a9c5fd-21f6-41fd-ac0c-6be551c2adbe"),
				Name = "displayValue",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,106,195,48,12,62,207,79,161,99,2,37,15,208,172,27,99,237,33,148,117,133,178,93,198,14,38,86,55,129,99,7,203,233,8,99,239,62,39,161,109,126,186,194,78,198,210,247,103,75,180,135,104,43,157,44,208,163,227,87,169,43,132,197,2,76,165,117,12,223,226,102,210,3,131,95,176,164,220,147,53,210,213,183,236,29,153,143,25,108,157,205,145,121,151,127,98,33,79,172,150,116,23,197,169,248,17,7,233,160,156,200,141,13,36,255,87,61,21,87,186,103,199,126,254,43,132,38,235,144,147,60,89,69,123,66,149,153,142,240,146,169,160,179,82,228,79,247,9,103,103,43,151,183,239,251,219,170,195,36,143,214,176,111,11,19,149,99,230,195,197,238,146,184,212,178,62,130,186,191,74,50,222,132,225,61,187,85,81,250,58,82,61,76,12,247,157,18,204,161,95,79,5,133,45,24,141,166,137,229,37,25,94,99,125,238,109,194,17,183,139,49,130,191,13,32,239,33,206,48,108,88,0,64,205,120,129,154,60,40,53,116,152,141,200,205,250,252,2,42,17,143,189,169,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitAggregationColumnNamesListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e2dcf9bd-3c8e-4b3f-a060-5f165040d893"),
				Name = "InitAggregationColumnNamesList",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,111,226,64,12,61,167,82,255,131,201,161,74,84,52,98,207,93,42,177,64,87,189,176,168,84,189,84,61,140,18,39,140,154,204,160,249,96,133,182,253,239,59,31,9,36,130,84,61,32,132,121,246,60,191,103,123,77,75,36,15,134,103,154,9,62,23,149,169,249,50,103,154,204,43,164,242,81,99,173,146,244,238,250,106,253,21,236,133,86,6,61,108,201,53,211,135,77,182,197,154,130,10,95,83,240,201,225,175,5,213,116,35,140,204,144,4,148,77,98,5,36,45,118,10,220,84,85,10,255,174,175,34,137,218,72,110,1,159,1,51,242,117,158,104,206,196,47,163,181,224,45,31,50,223,98,246,142,249,121,154,210,146,241,18,246,142,160,37,18,255,136,109,124,79,37,236,164,216,161,236,242,113,60,207,131,84,193,11,147,218,208,234,20,108,41,251,218,228,81,173,44,227,63,114,89,239,244,33,233,233,244,124,216,161,87,105,131,21,102,26,115,167,39,241,106,165,129,171,171,115,78,133,60,137,191,138,204,133,225,26,238,97,18,160,81,219,68,243,112,58,144,247,58,121,35,191,81,7,143,130,51,113,151,80,236,124,138,162,193,14,252,51,41,124,124,180,170,89,217,38,113,195,33,234,43,25,69,86,99,255,249,170,111,215,117,83,214,185,2,88,41,244,229,218,98,223,21,45,120,58,43,75,137,37,109,177,27,219,68,166,161,232,164,59,145,46,162,210,37,55,53,89,83,169,48,209,54,42,138,1,220,24,142,124,153,53,129,185,61,8,126,76,97,98,131,133,144,72,179,45,36,110,150,50,47,53,48,222,76,60,9,218,171,180,105,82,66,110,45,242,29,52,236,66,6,89,116,195,119,205,56,140,146,62,154,41,88,153,26,45,173,30,60,133,155,27,184,128,181,32,124,102,53,246,193,141,125,153,176,75,200,189,144,222,53,247,94,210,87,110,10,23,21,33,179,125,233,102,226,123,224,141,169,83,63,46,151,57,94,236,103,128,226,208,225,153,229,126,48,146,70,202,21,173,113,220,234,58,167,59,135,246,131,126,178,238,246,246,116,74,58,134,30,23,204,27,133,133,103,164,172,73,11,44,168,169,116,243,219,30,130,5,243,36,168,60,252,12,155,51,118,23,35,67,165,194,41,179,115,101,89,104,12,247,240,190,53,244,84,115,212,189,110,131,157,157,207,189,37,115,44,242,26,119,36,15,89,174,247,248,237,184,34,78,182,207,255,97,62,231,105,215,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitTreeGridRecordSortingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0229e104-23c7-4a4c-bfef-de335d0f3428"),
				Name = "InitTreeGridRecordSorting",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,81,79,219,48,16,126,110,37,254,131,199,3,164,162,178,96,123,3,58,137,181,133,33,161,173,34,192,75,213,7,227,92,26,107,169,83,217,206,166,10,245,191,239,28,59,105,18,66,97,47,235,67,155,218,119,223,221,247,221,229,110,42,141,48,155,144,39,176,98,68,187,159,17,153,177,37,208,105,113,53,97,134,133,89,174,56,80,103,117,113,208,23,49,9,74,219,17,145,121,154,14,200,203,65,191,167,192,228,74,162,193,246,160,255,155,41,162,141,202,57,30,193,155,144,227,92,41,144,38,44,13,209,183,114,162,227,44,205,87,82,211,113,10,76,5,131,11,7,186,102,138,173,192,128,210,136,58,129,152,229,169,121,98,105,14,154,48,77,38,130,27,145,73,166,54,151,8,36,228,114,72,102,42,227,160,181,203,126,86,122,23,46,95,61,153,26,230,39,71,136,28,29,213,34,205,15,127,170,8,212,173,140,179,195,197,7,76,104,129,94,26,58,113,92,58,243,5,201,172,157,77,126,175,51,13,215,169,48,129,132,63,132,39,76,161,223,203,241,240,120,107,85,232,197,153,34,129,144,134,136,209,233,5,17,228,210,99,210,59,144,75,147,224,209,201,137,11,218,138,138,65,157,229,92,44,186,2,156,251,0,61,43,74,97,233,33,45,149,47,30,178,199,51,44,163,204,161,176,220,218,47,91,151,72,232,117,202,54,174,104,24,200,53,72,85,196,107,33,163,111,155,31,72,216,1,207,79,23,187,80,45,223,186,108,111,133,227,85,156,93,191,40,96,6,28,136,239,207,97,51,45,250,120,27,209,135,44,44,68,9,6,46,1,135,68,139,10,76,132,130,162,129,16,56,104,158,12,166,50,95,81,236,31,13,129,217,172,33,139,219,6,67,39,238,252,108,241,26,120,150,105,225,113,177,112,30,198,153,127,246,230,59,34,87,81,228,89,56,136,226,30,153,111,9,164,26,10,89,246,40,62,83,98,133,253,63,169,223,90,128,247,132,198,174,2,198,19,18,212,228,21,178,85,199,178,40,22,204,243,123,212,248,106,63,160,34,22,111,90,155,39,206,165,186,166,55,32,65,177,170,174,189,118,254,188,74,21,63,207,152,204,47,247,188,45,11,191,237,100,209,120,203,254,83,111,52,15,232,149,230,32,35,244,219,87,247,179,143,86,217,207,57,87,198,113,7,151,215,175,84,179,244,158,144,189,25,148,19,174,137,86,151,108,79,160,46,209,58,67,117,104,215,69,180,17,106,224,22,69,227,140,222,234,39,161,197,115,106,87,70,204,176,219,253,212,79,4,182,142,226,201,171,110,255,222,188,240,116,219,230,181,145,189,87,199,150,159,147,176,41,215,191,52,88,27,174,67,38,254,54,239,119,122,5,181,43,150,234,181,72,113,135,76,35,97,104,8,102,183,92,131,206,149,107,61,187,119,241,93,198,162,106,17,7,56,13,56,156,19,252,191,115,121,80,0,55,74,68,247,192,113,116,133,153,194,185,188,164,247,16,43,208,137,69,194,37,253,23,99,90,167,76,81,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("41719a2c-83dc-415a-83ef-fade10cad020"),
				Name = "SetEnabledControls",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2b176ff9-89fd-491b-ab2a-ce46138ffe7d"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,74,76,201,204,119,42,45,41,201,207,115,206,47,205,43,209,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,185,2,208,148,186,149,230,37,151,100,230,231,17,167,218,53,175,36,179,164,18,143,90,183,204,156,146,212,34,215,148,76,236,214,3,0,191,92,248,102,169,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCheckedRadioButtonEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("84534130-8051-492b-9cdc-9597dbcc6cfa"),
				Name = "SetCheckedRadioButtonEntity",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,61,15,130,48,16,134,119,127,5,97,42,137,33,238,198,9,113,38,128,238,39,61,73,99,105,181,119,53,225,223,91,62,212,196,104,194,114,29,238,125,158,247,74,236,148,105,163,7,104,143,209,46,18,66,25,78,10,103,27,36,42,17,228,30,24,74,36,175,185,238,111,152,230,134,21,247,73,90,219,106,4,69,178,93,85,200,71,66,87,3,93,11,112,208,33,163,203,172,33,62,13,82,17,127,240,120,61,21,205,207,2,246,224,77,195,202,154,153,142,55,211,8,100,1,45,166,175,117,102,181,239,76,46,21,135,11,225,172,81,134,191,92,64,19,254,15,134,234,18,239,94,57,148,98,140,126,75,135,206,5,202,119,236,135,240,9,178,103,245,208,94,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowColumnStructureExplorerEditWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("72b93a0e-1f8e-434a-a65f-caa93149f54c"),
				Name = "ShowColumnStructureExplorerEditWindow",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,81,107,131,48,16,126,110,161,255,33,125,41,10,67,246,222,57,88,157,148,194,58,6,174,219,115,48,215,26,208,68,146,184,78,70,255,251,18,99,59,219,198,186,23,193,187,239,190,251,238,187,36,116,139,188,152,41,170,234,36,205,160,192,155,21,65,97,136,150,21,37,65,92,148,170,246,209,207,100,60,18,160,42,193,230,147,241,97,50,78,148,168,82,253,11,241,119,153,115,1,2,165,60,175,10,118,21,215,112,170,233,167,43,25,185,1,145,0,172,128,216,22,61,36,40,68,22,214,195,225,249,70,21,130,92,194,0,141,119,21,244,123,56,231,163,102,208,47,44,144,132,28,82,173,209,122,100,241,82,147,37,206,56,150,232,133,74,245,32,149,160,108,247,216,26,224,230,152,134,136,85,121,142,102,51,119,147,32,226,21,83,6,118,111,13,50,114,8,86,56,225,149,72,225,36,218,194,245,215,112,80,206,180,56,6,123,244,60,140,108,172,27,117,183,143,160,251,19,162,141,212,75,226,140,89,124,208,133,174,49,195,59,16,193,18,212,138,73,133,89,10,139,90,159,158,203,211,212,244,216,106,87,113,154,121,214,23,231,188,107,80,248,13,171,12,81,230,246,195,154,112,219,133,161,217,237,196,103,35,183,133,112,29,10,13,116,212,77,152,97,187,144,69,125,84,237,220,241,49,105,155,246,138,14,154,59,231,80,96,18,3,165,39,215,194,155,166,14,176,188,226,2,220,10,76,102,160,56,194,101,123,236,28,245,109,114,128,194,236,235,3,231,21,188,215,101,143,144,51,200,109,186,191,3,30,60,17,226,245,226,154,181,28,250,159,140,224,239,182,255,163,151,125,27,251,168,146,140,239,99,66,213,39,101,132,239,47,239,200,93,243,18,248,243,95,34,5,61,19,141,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnStructureExplorerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c8f76999-176e-4d57-83a7-4155b91780ab"),
				Name = "CreateColumnStructureExplorer",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "StructureExplorer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,203,110,219,48,16,60,219,128,255,129,209,201,70,5,250,3,138,28,82,85,5,4,36,168,97,187,237,33,40,10,90,90,57,76,40,46,65,82,177,132,32,255,222,165,100,203,41,82,185,189,72,124,204,206,12,103,201,229,146,153,122,167,100,206,54,222,214,185,175,45,164,141,81,104,193,206,127,192,46,65,237,45,42,102,132,5,237,143,179,152,57,111,165,222,179,39,104,99,182,67,218,151,238,174,86,94,110,64,65,238,135,181,53,162,191,195,2,226,217,116,185,156,28,139,30,64,153,64,4,141,207,138,1,186,121,192,195,224,32,243,80,185,149,69,3,214,75,112,236,154,209,14,44,102,211,103,97,131,21,81,209,146,134,3,219,130,181,194,97,233,249,183,140,159,237,58,62,12,86,1,13,158,78,19,201,192,154,233,18,163,152,253,49,25,48,193,43,95,139,195,226,99,47,149,163,170,43,253,46,152,163,248,251,192,86,98,15,124,139,230,168,126,43,90,172,41,141,168,231,57,193,72,49,28,39,102,165,80,14,78,97,242,180,50,190,13,202,35,170,60,109,114,85,23,240,89,120,241,93,168,26,182,173,233,178,9,94,122,142,251,159,236,133,69,159,164,22,182,13,135,252,34,21,132,127,86,145,177,48,72,144,168,34,246,122,65,37,235,91,209,58,10,40,233,48,167,252,255,89,244,213,24,116,20,236,26,74,160,235,146,3,21,118,103,164,202,4,43,131,154,238,208,205,163,104,210,103,26,48,40,164,15,203,138,162,39,228,24,247,80,224,120,250,166,130,56,223,18,240,158,243,195,53,75,254,206,243,235,98,113,227,173,24,174,129,227,55,69,49,239,238,217,165,126,156,211,9,29,8,109,217,96,109,115,24,144,61,128,190,225,81,72,212,243,192,150,185,17,131,137,5,225,161,56,135,45,75,54,191,26,133,175,97,47,169,71,22,138,5,123,153,77,39,99,46,79,184,78,124,242,31,116,103,3,175,161,109,99,47,96,68,143,202,44,208,130,30,5,252,6,23,188,17,105,114,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateColumnStructureExplorer_EditCompleteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("60b3aa79-18de-4edf-a39d-ba1c17f01261"),
				Name = "ColumnStructureExplorer_EditComplete",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("de56cf69-deca-4c91-ab70-0b2a837adee2"),
				Name = "sender",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("47d54e20-aa86-4eee-a7db-1b0342a5b8af"),
				Name = "e",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "AjaxEventArgs",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,193,110,194,48,12,61,175,95,17,245,148,94,250,3,172,147,24,67,168,104,72,72,29,39,196,193,106,13,68,74,221,201,113,59,216,180,127,95,82,118,232,52,218,163,227,231,231,247,158,211,1,43,39,220,150,210,50,46,47,239,182,97,228,69,99,219,154,156,202,148,94,207,153,225,154,172,93,67,233,11,58,100,3,214,124,162,198,116,121,17,134,45,48,212,40,200,110,31,27,193,218,229,116,108,226,67,50,139,186,64,140,22,75,193,106,73,98,228,122,99,221,130,156,49,80,23,119,154,78,129,83,175,198,201,163,215,100,232,244,52,139,204,81,233,41,158,76,81,107,109,242,21,61,76,110,35,252,248,67,172,189,196,111,133,214,161,154,28,77,23,22,129,123,116,116,235,22,229,25,107,80,56,44,50,181,115,33,54,34,79,99,124,84,67,232,6,8,78,200,233,10,37,39,39,64,37,62,95,119,121,165,135,32,95,251,29,71,159,62,148,103,221,141,95,69,25,26,61,88,18,188,132,89,239,246,246,180,65,129,96,196,43,28,25,218,199,245,47,38,62,164,111,77,209,199,19,252,78,133,50,175,42,253,111,71,159,209,253,171,102,19,95,97,246,3,174,80,37,205,131,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledSpecifyEntityColumnsControlsPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("98b5c2b1-54b6-4593-8ff4-5a41e3a97a02"),
				Name = "SetEnabledSpecifyEntityColumnsControlsProperty",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("48923add-f2e5-49bb-a8b4-bbb8cdedbc7e"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,46,72,77,206,76,171,116,205,43,201,44,169,116,206,207,41,205,205,43,118,206,72,77,206,118,202,175,208,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,185,2,112,105,115,42,45,41,201,207,195,166,73,65,77,77,1,167,54,184,109,96,6,208,6,0,77,41,205,75,152,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledNumberOfRecordsControlsPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2deb4072-73c1-4997-8cec-0001a111e61d"),
				Name = "SetEnabledNumberOfRecordsControlsProperty",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c2eb79c4-fa67-4e6f-8278-5963ab5b2c18"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,41,74,77,117,47,202,76,9,74,77,206,47,74,9,206,47,42,201,204,75,215,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,121,185,2,64,26,130,83,75,156,243,115,74,115,243,138,125,83,243,74,157,74,75,74,242,243,240,169,15,74,77,4,26,155,155,26,146,95,0,177,163,216,53,37,179,4,135,142,204,52,5,13,56,95,83,161,154,151,139,19,206,5,42,197,103,160,115,70,106,114,54,216,144,90,168,205,126,165,185,73,169,69,254,105,132,173,5,43,247,73,76,74,205,65,211,131,85,61,0,70,16,82,49,56,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledFunctionControlsPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b298019b-1214-42df-acea-41bf4c404b5c"),
				Name = "SetEnabledFunctionControlsProperty",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9d206905-fd8c-42f9-bac8-0e822c73ab3a"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				ModifiedInSchemaUId = new Guid("c33cd795-145c-425f-83b0-4f16100efa57"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,43,205,75,46,201,204,207,115,206,207,41,205,205,115,77,201,44,209,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,185,2,112,40,14,78,45,9,74,45,44,205,44,74,77,209,128,43,215,68,83,31,82,89,144,74,164,209,112,165,56,12,6,0,42,141,15,39,181,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReadDataUserTaskParametersPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c33cd795-145c-425f-83b0-4f16100efa57"));
		}

		#endregion

	}

	#endregion

}

