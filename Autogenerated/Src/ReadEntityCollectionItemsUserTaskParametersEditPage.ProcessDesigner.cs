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
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ReadEntityCollectionItemsUserTaskParametersEditPageSchema

	/// <exclude/>
	public class ReadEntityCollectionItemsUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _titleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit TitleEdit {
			get {
				return _titleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _entityCollectionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit EntityCollectionTextEdit {
			get {
				return _entityCollectionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _entityCollectionEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton EntityCollectionEditToolButton {
			get {
				return _entityCollectionEditToolButton;
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

		private Terrasoft.UI.WebControls.Controls.Label _sortRecordsByFieldsLabel;
		public Terrasoft.UI.WebControls.Controls.Label SortRecordsByFieldsLabel {
			get {
				return _sortRecordsByFieldsLabel;
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

		public ReadEntityCollectionItemsUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ReadEntityCollectionItemsUserTaskParametersEditPageSchema(ReadEntityCollectionItemsUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			RealUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			Name = "ReadEntityCollectionItemsUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 500;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema();
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
			ControlLayout1.InsertItem(0, CreateTitleEdit());
			ControlLayout1.InsertItem(1, CreateEntityCollectionTextEdit());
			EntityCollectionTextEdit.InsertItem(0, CreateEntityCollectionEditToolButton());
			TopControlLayout.InsertItem(1, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateRadioButtonCount());
			ControlLayout3.InsertItem(1, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateRadioButtonFunction());
			ControlLayout4.InsertItem(1, CreateFunctionTypeEdit());
			ControlLayout4.InsertItem(2, CreateFunctionColumnEdit());
			ControlLayout3.InsertItem(2, CreateRadioButtonEntity());
			ControlLayout3.InsertItem(3, CreateNumberOfRecordsControlLayout());
			NumberOfRecordsControlLayout.InsertItem(0, CreateReadSomeTopRecordsEdit());
			NumberOfRecordsControlLayout.InsertItem(1, CreateNumberOfRecordsEdit());
			NumberOfRecordsControlLayout.InsertItem(2, CreateSortRecordsByFieldsLabel());
			ControlLayout3.InsertItem(4, CreateControlLayoutTreeGrid());
			ControlLayoutTreeGrid.InsertItem(0, CreateTreeGridRecordSorting());
			ControlLayoutTreeGrid.InsertItem(1, CreateSetColumnsMenuButton());
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

		protected virtual EmbeddedProcessSchema CreateReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleEdit() {
			_titleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleEdit.UId = new Guid("ac414596-8b91-4451-895f-f0bf28d29d6b");
			_titleEdit.Name = "TitleEdit";
			_titleEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_titleEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_titleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_titleEdit.Tag = "";
			_titleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_titleEdit.Image = new ControlImage {};
			_titleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _titleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateEntityCollectionEditToolButton() {
			_entityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_entityCollectionEditToolButton.UId = new Guid("94fed920-cfa8-413b-92eb-3547b16ef4a8");
			_entityCollectionEditToolButton.Name = "EntityCollectionEditToolButton";
			_entityCollectionEditToolButton.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_entityCollectionEditToolButton.Tag = "";
			_entityCollectionEditToolButton.Image = new ControlImage {};
			return _entityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateEntityCollectionTextEdit() {
			_entityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_entityCollectionTextEdit.UId = new Guid("19d71570-4876-42ec-a5b9-a5d98b3c664e");
			_entityCollectionTextEdit.Name = "EntityCollectionTextEdit";
			_entityCollectionTextEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityCollectionTextEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionTextEdit.Tag = "";
			_entityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityCollectionTextEdit.Image = new ControlImage {};
			_entityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityCollectionTextEdit.Required = true;
			return _entityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("de97d279-ffd0-443e-a434-13094cbeb09e");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_controlLayout1.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_radioButtonCount.UId = new Guid("acd7b4f0-f380-47aa-b56f-be963c395a78");
			_radioButtonCount.Name = "RadioButtonCount";
			_radioButtonCount.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_radioButtonCount.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_radioButtonFunction.UId = new Guid("959bd58e-04be-471f-84a2-0f6cc6f80463");
			_radioButtonFunction.Name = "RadioButtonFunction";
			_radioButtonFunction.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_radioButtonFunction.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_functionTypeEdit.UId = new Guid("8f063c65-f1b5-4c69-8875-788c891808ff");
			_functionTypeEdit.Name = "FunctionTypeEdit";
			_functionTypeEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_functionTypeEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_functionTypeEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_functionTypeEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_functionTypeEdit.Tag = "";
			_functionTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_functionTypeEdit.Image = new ControlImage {};
			_functionTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(40);
			_functionTypeEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_functionTypeEdit.Enabled = false;
			return _functionTypeEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateFunctionColumnEdit() {
			_functionColumnEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_functionColumnEdit.UId = new Guid("ff14cae2-f597-42dc-94e6-85c1bfde5eb9");
			_functionColumnEdit.Name = "FunctionColumnEdit";
			_functionColumnEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_functionColumnEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_functionColumnEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_functionColumnEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_functionColumnEdit.Tag = "";
			_functionColumnEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_functionColumnEdit.Image = new ControlImage {};
			_functionColumnEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_functionColumnEdit.Enabled = false;
			return _functionColumnEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("77edcd38-86f5-4033-8dd6-b561c69df309");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_controlLayout4.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout4.FitHeightByContent = true;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateRadioButtonEntity() {
			_radioButtonEntity = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_radioButtonEntity.UId = new Guid("51248841-fc39-4aa4-b467-8ed741c21055");
			_radioButtonEntity.Name = "RadioButtonEntity";
			_radioButtonEntity.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_radioButtonEntity.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_readSomeTopRecordsEdit.UId = new Guid("4ee00409-7b4e-43bd-8b61-9da76a49d825");
			_readSomeTopRecordsEdit.Name = "ReadSomeTopRecordsEdit";
			_readSomeTopRecordsEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_readSomeTopRecordsEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_readSomeTopRecordsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_readSomeTopRecordsEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_readSomeTopRecordsEdit.Tag = "";
			_readSomeTopRecordsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_readSomeTopRecordsEdit.AlignedByCaption = false;
			_readSomeTopRecordsEdit.Enabled = false;
			return _readSomeTopRecordsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateNumberOfRecordsEdit() {
			_numberOfRecordsEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_numberOfRecordsEdit.UId = new Guid("be172c70-f23d-4636-9123-8fa58d063d84");
			_numberOfRecordsEdit.Name = "NumberOfRecordsEdit";
			_numberOfRecordsEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_numberOfRecordsEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_numberOfRecordsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_numberOfRecordsEdit.Tag = "";
			_numberOfRecordsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_numberOfRecordsEdit.Image = new ControlImage {};
			_numberOfRecordsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberOfRecordsEdit.AlignedByCaption = false;
			_numberOfRecordsEdit.Margins = "0 5 0 0";
			_numberOfRecordsEdit.Enabled = false;
			return _numberOfRecordsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateSortRecordsByFieldsLabel() {
			_sortRecordsByFieldsLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_sortRecordsByFieldsLabel.UId = new Guid("d0d05302-55aa-452c-9693-efeb86533e83");
			_sortRecordsByFieldsLabel.Name = "SortRecordsByFieldsLabel";
			_sortRecordsByFieldsLabel.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_sortRecordsByFieldsLabel.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_sortRecordsByFieldsLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sortRecordsByFieldsLabel.Tag = "";
			_sortRecordsByFieldsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sortRecordsByFieldsLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _sortRecordsByFieldsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateNumberOfRecordsControlLayout() {
			_numberOfRecordsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_numberOfRecordsControlLayout.UId = new Guid("f383bf17-d884-4201-a70a-59530768cda8");
			_numberOfRecordsControlLayout.Name = "NumberOfRecordsControlLayout";
			_numberOfRecordsControlLayout.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_numberOfRecordsControlLayout.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_numberOfRecordsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_numberOfRecordsControlLayout.Tag = "";
			_numberOfRecordsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_numberOfRecordsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_numberOfRecordsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_numberOfRecordsControlLayout.FitHeightByContent = true;
			_numberOfRecordsControlLayout.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_numberOfRecordsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_numberOfRecordsControlLayout.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Right;
			_numberOfRecordsControlLayout.Padding = "0 0 0 15";
			_numberOfRecordsControlLayout.StartNewAlignGroup = false;
			_numberOfRecordsControlLayout.Image = new ControlImage {};
			_numberOfRecordsControlLayout.Edges = "";
			_numberOfRecordsControlLayout.Enabled = false;
			return _numberOfRecordsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateTreeGridRecordSorting() {
			_treeGridRecordSorting = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_treeGridRecordSorting.UId = new Guid("19fb94dd-aa59-46b3-87c9-ef0d484d3270");
			_treeGridRecordSorting.Name = "TreeGridRecordSorting";
			_treeGridRecordSorting.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_treeGridRecordSorting.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_setColumnsMenuButton.UId = new Guid("dc48a316-9a1d-4aca-9e68-7dfd13379dd4");
			_setColumnsMenuButton.Name = "SetColumnsMenuButton";
			_setColumnsMenuButton.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_setColumnsMenuButton.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_setColumnsMenuButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_setColumnsMenuButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_setColumnsMenuButton.Tag = "";
			_setColumnsMenuButton.Image = new ControlImage {};
			_setColumnsMenuButton.Enabled = false;
			return _setColumnsMenuButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutTreeGrid() {
			_controlLayoutTreeGrid = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutTreeGrid.UId = new Guid("12d131d6-4043-46b2-b5c6-e29eb5a499e2");
			_controlLayoutTreeGrid.Name = "ControlLayoutTreeGrid";
			_controlLayoutTreeGrid.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_controlLayoutTreeGrid.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_controlLayoutTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayoutTreeGrid.Tag = "";
			_controlLayoutTreeGrid.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayoutTreeGrid.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayoutTreeGrid.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayoutTreeGrid.FitHeightByContent = true;
			_controlLayoutTreeGrid.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayoutTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutTreeGrid.Padding = "5 0 5 15";
			_controlLayoutTreeGrid.StartNewAlignGroup = false;
			_controlLayoutTreeGrid.Image = new ControlImage {};
			_controlLayoutTreeGrid.Edges = "";
			return _controlLayoutTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("de01ee35-3905-4c1d-a76e-aa349753a109");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_controlLayout3.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_label1.UId = new Guid("a5a0354c-2e36-4023-9a29-117d65b6fb59");
			_label1.Name = "Label1";
			_label1.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_label1.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_label1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_label1.Tag = "";
			_label1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_label1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _label1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("6fffea74-4c95-46bd-a17f-61a98f0bd820");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_filterEdit.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_filterControlLayout.UId = new Guid("39b93a10-e260-4913-bcd5-a16cda1cad9c");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			_entityDataSource.UId = new Guid("26f6454e-3fca-41f6-86a7-575bd105a360");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityDataSource.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("898ff292-e7bc-458c-8723-a67b97ff543c");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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
			return new ReadEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ReadEntityCollectionItemsUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d48e6f5b-9107-4513-8158-6d8588391f12"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ReadEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeEntityCollectionUserMessageFlowElement

		/// <exclude/>
		public class ChangeEntityCollectionUserMessageFlowElement : QuestionUserTask
		{

			public ChangeEntityCollectionUserMessageFlowElement(UserConnection userConnection, ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeEntityCollectionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
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

		public virtual string EntityCollectionMetaPath {
			get;
			set;
		}

		public virtual Guid EntityCollectionSchemaUId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual string EntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual string NewEntityCollectionParameterValue {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessCount;
		public ProcessFlowElement EventSubProcessCount {
			get {
				return _eventSubProcessCount ?? (_eventSubProcessCount = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessCount",
					SchemaElementUId = new Guid("9ab56133-38dd-444a-8469-320b8c4018bd"),
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
					SchemaElementUId = new Guid("19c780e2-da93-4d5f-a858-b38ae76b1681"),
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
					SchemaElementUId = new Guid("48f4346d-f8dc-49d5-9d88-ac339446c216"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCountCheckExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessOnInit;
		public ProcessFlowElement EventSubProcessOnInit {
			get {
				return _eventSubProcessOnInit ?? (_eventSubProcessOnInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessOnInit",
					SchemaElementUId = new Guid("9d83c3b4-d63d-47ef-a417-5cca150ccdbe"),
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
					SchemaElementUId = new Guid("2b5c1b48-d2c0-4dc2-8dad-521f4c485940"),
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
					SchemaElementUId = new Guid("740f4839-4121-4f78-92f1-77cf5f3525bd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childInitScript;
		public ProcessScriptTask ChildInitScript {
			get {
				return _childInitScript ?? (_childInitScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildInitScript",
					SchemaElementUId = new Guid("099d8b36-b98d-4eea-bca9-c03b2cb3a241"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildInitScriptExecute,
				});
			}
		}

		private ProcessFlowElement _onPageLoadComplete;
		public ProcessFlowElement OnPageLoadComplete {
			get {
				return _onPageLoadComplete ?? (_onPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "OnPageLoadComplete",
					SchemaElementUId = new Guid("09d76d38-b0cc-48ca-84c6-66a003ffac1f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePageLoadComplete;
		public ProcessFlowElement StartMessagePageLoadComplete {
			get {
				return _startMessagePageLoadComplete ?? (_startMessagePageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePageLoadComplete",
					SchemaElementUId = new Guid("69d168d0-89f4-4420-811f-cff3247a1595"),
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
					SchemaElementUId = new Guid("ac33ee99-d16b-48d9-8623-7dbcdc469e35"),
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
					SchemaElementUId = new Guid("6034803b-b1e0-43d4-9d6b-575e74bfd9ed"),
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
					SchemaElementUId = new Guid("5af48d2b-6a08-4759-b8da-0d51430a5669"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("963e15de-62df-46bd-ab6d-07574c55e9b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickChildScript;
		public ProcessScriptTask OkButtonClickChildScript {
			get {
				return _okButtonClickChildScript ?? (_okButtonClickChildScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickChildScript",
					SchemaElementUId = new Guid("a309c370-8339-4ea9-9fb8-b928056caa95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickChildScriptExecute,
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
					SchemaElementUId = new Guid("54c7fc1e-7923-4bb1-beb9-539573a57ed4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("4ac3bbdf-cdef-44db-a91b-1de18c871342"),
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
					SchemaElementUId = new Guid("f3e2ea56-0775-4c50-a4b9-508f9da11e4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _radioButtonFunctionCheckScriptTask;
		public ProcessScriptTask RadioButtonFunctionCheckScriptTask {
			get {
				return _radioButtonFunctionCheckScriptTask ?? (_radioButtonFunctionCheckScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RadioButtonFunctionCheckScriptTask",
					SchemaElementUId = new Guid("5e29fd3f-f00c-445a-8d74-93cf44324e40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RadioButtonFunctionCheckScriptTaskExecute,
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
					SchemaElementUId = new Guid("28436f51-cb8c-47f9-94ea-6fcf8c678029"),
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
					SchemaElementUId = new Guid("7af5e0db-0b96-402e-9afa-447c695170d1"),
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
					SchemaElementUId = new Guid("f782dd80-46cc-4709-b4e6-84ce9df9921e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskSetColumnsMenuButtonClickExecute,
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
					SchemaElementUId = new Guid("842839c1-5ded-4cb8-b05d-c1a43fda94bc"),
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
					SchemaElementUId = new Guid("6dbaf112-2938-4262-9d35-087d77d1b447"),
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
					SchemaElementUId = new Guid("6541bb33-9637-40be-a62e-987c1c5db151"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskEntityCheckExecute,
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
					SchemaElementUId = new Guid("5bc454e3-da8e-44c9-b15a-e29f826a8555"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage7;
		public ProcessFlowElement StartMessage7 {
			get {
				return _startMessage7 ?? (_startMessage7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage7",
					SchemaElementUId = new Guid("05d8e732-3225-47a2-b3fe-18acef611208"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _entityCollectionEditToolButtonClickScript;
		public ProcessScriptTask EntityCollectionEditToolButtonClickScript {
			get {
				return _entityCollectionEditToolButtonClickScript ?? (_entityCollectionEditToolButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EntityCollectionEditToolButtonClickScript",
					SchemaElementUId = new Guid("091eb633-ceba-48a4-b9a5-807b6a481567"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntityCollectionEditToolButtonClickScriptExecute,
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
					SchemaElementUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6;
		public ProcessFlowElement StartMessage6 {
			get {
				return _startMessage6 ?? (_startMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6",
					SchemaElementUId = new Guid("e666bc7a-e245-4fbd-882c-1665b575c3cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _newEntityCollectionParameterValueScriptTask;
		public ProcessScriptTask NewEntityCollectionParameterValueScriptTask {
			get {
				return _newEntityCollectionParameterValueScriptTask ?? (_newEntityCollectionParameterValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NewEntityCollectionParameterValueScriptTask",
					SchemaElementUId = new Guid("60b8ee9d-3d6e-4d53-84ea-56f4d2dfc7d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NewEntityCollectionParameterValueScriptTaskExecute,
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
					SchemaElementUId = new Guid("cce3a706-e59d-426e-84b4-642383e38974"),
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

		private ProcessScriptTask _prepareChangeEntityCollectionQuestionScript;
		public ProcessScriptTask PrepareChangeEntityCollectionQuestionScript {
			get {
				return _prepareChangeEntityCollectionQuestionScript ?? (_prepareChangeEntityCollectionQuestionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareChangeEntityCollectionQuestionScript",
					SchemaElementUId = new Guid("cb5c6396-7de0-4c0e-8b05-7be79024300a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareChangeEntityCollectionQuestionScriptExecute,
				});
			}
		}

		private ChangeEntityCollectionUserMessageFlowElement _changeEntityCollectionUserMessage;
		public ChangeEntityCollectionUserMessageFlowElement ChangeEntityCollectionUserMessage {
			get {
				return _changeEntityCollectionUserMessage ?? (_changeEntityCollectionUserMessage = new ChangeEntityCollectionUserMessageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("a2a68826-1d6d-4a36-83b5-ad408c3b2f68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeEntityCollectionYesMessage",
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionYesMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionYesMessage {
			get {
				return _eventSubProcessChangeEntityCollectionYesMessage ?? (_eventSubProcessChangeEntityCollectionYesMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionYesMessage",
					SchemaElementUId = new Guid("e886f55a-fdf4-4436-8c44-1205d9b076d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeEntityCollectionYesMessageBase;
		public ProcessFlowElement ChangeEntityCollectionYesMessageBase {
			get {
				return _changeEntityCollectionYesMessageBase ?? (_changeEntityCollectionYesMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeEntityCollectionYesMessageBase",
					SchemaElementUId = new Guid("8eef7f54-306a-4ed5-8795-3f94223ba7c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeEntityCollectionYesMessageScript;
		public ProcessScriptTask ChangeEntityCollectionYesMessageScript {
			get {
				return _changeEntityCollectionYesMessageScript ?? (_changeEntityCollectionYesMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEntityCollectionYesMessageScript",
					SchemaElementUId = new Guid("025afd8b-f268-4870-ad58-e5d80e0f89b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionYesMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChangeEntityCollectionNoMessage;
		public ProcessFlowElement EventSubProcessChangeEntityCollectionNoMessage {
			get {
				return _eventSubProcessChangeEntityCollectionNoMessage ?? (_eventSubProcessChangeEntityCollectionNoMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChangeEntityCollectionNoMessage",
					SchemaElementUId = new Guid("bdcc7e54-aef4-44ac-9d4f-4cbfb6fbad88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeEntityCollectionNoMessageScript;
		public ProcessScriptTask ChangeEntityCollectionNoMessageScript {
			get {
				return _changeEntityCollectionNoMessageScript ?? (_changeEntityCollectionNoMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeEntityCollectionNoMessageScript",
					SchemaElementUId = new Guid("8931acdc-e6fa-4dc2-960a-3cffea872c3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionNoMessageScriptExecute,
				});
			}
		}

		private ProcessFlowElement _changeEntityCollectionNoMessageBase;
		public ProcessFlowElement ChangeEntityCollectionNoMessageBase {
			get {
				return _changeEntityCollectionNoMessageBase ?? (_changeEntityCollectionNoMessageBase = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeEntityCollectionNoMessageBase",
					SchemaElementUId = new Guid("a156d9ae-d8fc-4aa8-a746-b307c6dae58b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("6350ee39-d89b-4045-bdce-3ea6e978dbb8"),
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
					SchemaElementUId = new Guid("1355c758-4f98-4401-8caa-26cc1ea75da3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sScriptTaskFunctionColumnEditChange;
		public ProcessScriptTask SScriptTaskFunctionColumnEditChange {
			get {
				return _sScriptTaskFunctionColumnEditChange ?? (_sScriptTaskFunctionColumnEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SScriptTaskFunctionColumnEditChange",
					SchemaElementUId = new Guid("e9e26f9c-ff18-4f72-92d6-b2e9b4cf71f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SScriptTaskFunctionColumnEditChangeExecute,
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
					SchemaElementUId = new Guid("9f69897b-5c6c-4f9d-aea1-740114edbcd9"),
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
					SchemaElementUId = new Guid("7ece54fa-6e68-48d4-afe8-a763b2ed5687"),
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
					SchemaElementUId = new Guid("540b42c7-3794-4a47-ba17-199d36a07a30"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskFunctionTypeEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessReadSomeTopRecordsEditCheck;
		public ProcessFlowElement EventSubProcessReadSomeTopRecordsEditCheck {
			get {
				return _eventSubProcessReadSomeTopRecordsEditCheck ?? (_eventSubProcessReadSomeTopRecordsEditCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessReadSomeTopRecordsEditCheck",
					SchemaElementUId = new Guid("f5e4b58f-53ba-40b7-a707-98ada4072846"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageReadSomeTopRecordsEditCheck;
		public ProcessFlowElement StartMessageReadSomeTopRecordsEditCheck {
			get {
				return _startMessageReadSomeTopRecordsEditCheck ?? (_startMessageReadSomeTopRecordsEditCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageReadSomeTopRecordsEditCheck",
					SchemaElementUId = new Guid("e4724dd6-7c7f-4d76-9cf1-adbbed93c8d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskReadSomeTopRecordsEditCheck;
		public ProcessScriptTask ScriptTaskReadSomeTopRecordsEditCheck {
			get {
				return _scriptTaskReadSomeTopRecordsEditCheck ?? (_scriptTaskReadSomeTopRecordsEditCheck = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskReadSomeTopRecordsEditCheck",
					SchemaElementUId = new Guid("327f2b83-3e4b-4f3e-88ec-b29507e1145d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskReadSomeTopRecordsEditCheckExecute,
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
					SchemaElementUId = new Guid("8c5b9b70-3283-4da1-b97e-c619311df47d"),
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessCount.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessCount };
			FlowElements[StartMessageRadioButtonCountCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRadioButtonCountCheck };
			FlowElements[ScriptTaskCountCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCountCheck };
			FlowElements[EventSubProcessOnInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOnInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[OnPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPageLoadComplete };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[OkButtonClickChildSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildSubProcess };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[OkButtonClickChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildScript };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[RadioButtonFunctionCheckScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RadioButtonFunctionCheckScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[StartMessageSetColumnsMenuButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSetColumnsMenuButtonClick };
			FlowElements[ScriptTaskSetColumnsMenuButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskSetColumnsMenuButtonClick };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessageRadioButtonEntityCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRadioButtonEntityCheck };
			FlowElements[ScriptTaskEntityCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskEntityCheck };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[StartMessage7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7 };
			FlowElements[EntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[NewEntityCollectionParameterValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NewEntityCollectionParameterValueScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[PrepareChangeEntityCollectionQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeEntityCollectionQuestionScript };
			FlowElements[ChangeEntityCollectionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionUserMessage };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[EventSubProcessChangeEntityCollectionYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionYesMessage };
			FlowElements[ChangeEntityCollectionYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageBase };
			FlowElements[ChangeEntityCollectionYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageScript };
			FlowElements[EventSubProcessChangeEntityCollectionNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionNoMessage };
			FlowElements[ChangeEntityCollectionNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageScript };
			FlowElements[ChangeEntityCollectionNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageBase };
			FlowElements[EventSubProcessFunctionColumnEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessFunctionColumnEditChange };
			FlowElements[StartMessageFunctionColumnEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageFunctionColumnEditChange };
			FlowElements[SScriptTaskFunctionColumnEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SScriptTaskFunctionColumnEditChange };
			FlowElements[EventSubProcessFunctionType.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessFunctionType };
			FlowElements[StartMessageFunctionTypeEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageFunctionTypeEditChange };
			FlowElements[ScriptTaskFunctionTypeEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskFunctionTypeEditChange };
			FlowElements[EventSubProcessReadSomeTopRecordsEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessReadSomeTopRecordsEditCheck };
			FlowElements[StartMessageReadSomeTopRecordsEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageReadSomeTopRecordsEditCheck };
			FlowElements[ScriptTaskReadSomeTopRecordsEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskReadSomeTopRecordsEditCheck };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessCount":
						break;
					case "StartMessageRadioButtonCountCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskCountCheck");
						break;
					case "ScriptTaskCountCheck":
						break;
					case "EventSubProcessOnInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventInit");
						break;
					case "IntermediateThrowMessageEventInit":
						e.Context.QueueTasks.Enqueue("ChildInitScript");
						break;
					case "ChildInitScript":
						break;
					case "OnPageLoadComplete":
						break;
					case "StartMessagePageLoadComplete":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScript":
						break;
					case "OkButtonClickChildSubProcess":
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("OkButtonClickChildScript");
						break;
					case "OkButtonClickChildScript":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("RadioButtonFunctionCheckScriptTask");
						break;
					case "RadioButtonFunctionCheckScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "StartMessageSetColumnsMenuButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskSetColumnsMenuButtonClick");
						break;
					case "ScriptTaskSetColumnsMenuButtonClick":
						break;
					case "EventSubProcess4":
						break;
					case "StartMessageRadioButtonEntityCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskEntityCheck");
						break;
					case "ScriptTaskEntityCheck":
						break;
					case "EventSubProcess7":
						break;
					case "StartMessage7":
						e.Context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickScript");
						break;
					case "EntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("NewEntityCollectionParameterValueScriptTask");
						break;
					case "NewEntityCollectionParameterValueScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeEntityCollectionQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "PrepareChangeEntityCollectionQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionUserMessage");
						break;
					case "ChangeEntityCollectionUserMessage":
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "EventSubProcessChangeEntityCollectionYesMessage":
						break;
					case "ChangeEntityCollectionYesMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageScript");
						break;
					case "ChangeEntityCollectionYesMessageScript":
						break;
					case "EventSubProcessChangeEntityCollectionNoMessage":
						break;
					case "ChangeEntityCollectionNoMessageScript":
						break;
					case "ChangeEntityCollectionNoMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageScript");
						break;
					case "EventSubProcessFunctionColumnEditChange":
						break;
					case "StartMessageFunctionColumnEditChange":
						e.Context.QueueTasks.Enqueue("SScriptTaskFunctionColumnEditChange");
						break;
					case "SScriptTaskFunctionColumnEditChange":
						break;
					case "EventSubProcessFunctionType":
						break;
					case "StartMessageFunctionTypeEditChange":
						e.Context.QueueTasks.Enqueue("ScriptTaskFunctionTypeEditChange");
						break;
					case "ScriptTaskFunctionTypeEditChange":
						break;
					case "EventSubProcessReadSomeTopRecordsEditCheck":
						break;
					case "StartMessageReadSomeTopRecordsEditCheck":
						e.Context.QueueTasks.Enqueue("ScriptTaskReadSomeTopRecordsEditCheck");
						break;
					case "ScriptTaskReadSomeTopRecordsEditCheck":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(!IsNew);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageRadioButtonCountCheck");
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessageSetColumnsMenuButtonClick");
			ActivatedEventElements.Add("StartMessageRadioButtonEntityCheck");
			ActivatedEventElements.Add("StartMessage7");
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("ChangeEntityCollectionYesMessageBase");
			ActivatedEventElements.Add("ChangeEntityCollectionNoMessageBase");
			ActivatedEventElements.Add("StartMessageFunctionColumnEditChange");
			ActivatedEventElements.Add("StartMessageFunctionTypeEditChange");
			ActivatedEventElements.Add("StartMessageReadSomeTopRecordsEditCheck");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
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
				case "ChildInitScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitScript";
					result = ChildInitScript.Execute(context, ChildInitScriptExecute);
					break;
				case "OnPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoadComplete";
					result = StartMessagePageLoadComplete.Execute(context);
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
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "OkButtonClickChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickChildScript";
					result = OkButtonClickChildScript.Execute(context, OkButtonClickChildScriptExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "RadioButtonFunctionCheckScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RadioButtonFunctionCheckScriptTask";
					result = RadioButtonFunctionCheckScriptTask.Execute(context, RadioButtonFunctionCheckScriptTaskExecute);
					break;
				case "EventSubProcess5":
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
				case "EventSubProcess4":
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
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7";
					result = StartMessage7.Execute(context);
					break;
				case "EntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickScript";
					result = EntityCollectionEditToolButtonClickScript.Execute(context, EntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "NewEntityCollectionParameterValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewEntityCollectionParameterValueScriptTask";
					result = NewEntityCollectionParameterValueScriptTask.Execute(context, NewEntityCollectionParameterValueScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "PrepareChangeEntityCollectionQuestionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareChangeEntityCollectionQuestionScript";
					result = PrepareChangeEntityCollectionQuestionScript.Execute(context, PrepareChangeEntityCollectionQuestionScriptExecute);
					break;
				case "ChangeEntityCollectionUserMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionUserMessage";
					result = ChangeEntityCollectionUserMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "EventSubProcessChangeEntityCollectionYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeEntityCollectionYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionYesMessageBase";
					result = ChangeEntityCollectionYesMessageBase.Execute(context);
					break;
				case "ChangeEntityCollectionYesMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionYesMessageScript";
					result = ChangeEntityCollectionYesMessageScript.Execute(context, ChangeEntityCollectionYesMessageScriptExecute);
					break;
				case "EventSubProcessChangeEntityCollectionNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeEntityCollectionNoMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageScript";
					result = ChangeEntityCollectionNoMessageScript.Execute(context, ChangeEntityCollectionNoMessageScriptExecute);
					break;
				case "ChangeEntityCollectionNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageBase";
					result = ChangeEntityCollectionNoMessageBase.Execute(context);
					break;
				case "EventSubProcessFunctionColumnEditChange":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageFunctionColumnEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageFunctionColumnEditChange";
					result = StartMessageFunctionColumnEditChange.Execute(context);
					break;
				case "SScriptTaskFunctionColumnEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "SScriptTaskFunctionColumnEditChange";
					result = SScriptTaskFunctionColumnEditChange.Execute(context, SScriptTaskFunctionColumnEditChangeExecute);
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
				case "EventSubProcessReadSomeTopRecordsEditCheck":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageReadSomeTopRecordsEditCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageReadSomeTopRecordsEditCheck";
					result = StartMessageReadSomeTopRecordsEditCheck.Execute(context);
					break;
				case "ScriptTaskReadSomeTopRecordsEditCheck":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskReadSomeTopRecordsEditCheck";
					result = ScriptTaskReadSomeTopRecordsEditCheck.Execute(context, ScriptTaskReadSomeTopRecordsEditCheckExecute);
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
				case "NewEntityCollectionParameterValue":
					NewEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "EntityCollectionDisplayValue":
					EntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "EntityCollectionSchemaUId":
					EntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EntityCollectionMetaPath":
					EntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskCountCheckExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonCount.Checked) {
				string value = ((int)ProcessReadDataResultType.Function).ToString();
				SetUserTaskParameterConstValue("ResultType", value, value);
				value = ((int)AggregationTypeStrict.Count).ToString();
				SetUserTaskParameterConstValue("FunctionType", value, value);
				Page.FunctionColumnEdit.Enabled = false;
				Page.FunctionColumnEdit.SetRequired(false);
				Page.FunctionTypeEdit.Enabled = false;
				SetEnabledNumberOfRecordsControlLayout(false);
				Page.FunctionTypeEdit.SetRequired(false);
				EntitySchema schema = Page.EntityDataSource.Schema;
				if (schema != null) {
					SetUserTaskParameterConstValue("AggregationColumnName", schema.PrimaryColumn.Name, schema.PrimaryColumn.Caption);
				}
			}
			return true;
		}

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			Page.NumberOfRecordsEdit.CustomConfig.Add(new ConfigItem("hidePrimaryToolButton", "true"));
			if (!Ext.IsAjaxRequest) {
				ParameterDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("EntityCollectionDataValueType").UId;
				Page.TitleEdit.Text = ElementNewCaption;
				var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
				SetDefaultValue(defValues["ResultType"], ((int)ProcessReadDataResultType.Entity).ToString(), ProcessReadDataResultType.Entity.ToLocalizedString(), "ResultType");
				SetDefaultValue(defValues["FunctionType"], ((int)AggregationTypeStrict.Sum).ToString(), AggregationTypeStrict.Sum.ToLocalizedString(), "FunctionType");
				SetDefaultValue(defValues["ReadSomeTopRecords"], false.ToString(), string.Empty, "ReadSomeTopRecords");
				SetDefaultValue(defValues["NumberOfRecords"], "1", "1", "NumberOfRecords");
				DefaultValues = defValues;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = (VirtualDataSource)PropertyDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
				InitFunctionList();
				switch ((ProcessReadDataResultType)Enum.Parse(typeof(ProcessReadDataResultType), defValues["ResultType"].Value)) {
					case ProcessReadDataResultType.Entity:
						Page.RadioButtonEntity.Checked = true;
						SetEnabledNumberOfRecordsControlLayout(true);
						Page.ControlLayoutTreeGrid.SetEnabled(true, true);
						break;
					case ProcessReadDataResultType.Function:
						Page.ControlLayoutTreeGrid.SetEnabled(false, true);
						if (defValues["FunctionType"].Value == ((int)AggregationTypeStrict.Count).ToString()) {
							Page.RadioButtonCount.Checked = true;
						} else {
							Page.RadioButtonFunction.Checked = true;
							Page.FunctionColumnEdit.SetEnabled(true);
							Page.FunctionColumnEdit.SetRequired(true);
							Page.FunctionTypeEdit.SetEnabled(true);
							Page.FunctionTypeEdit.SetRequired(true);
						}
						break;
				}
			}
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			EntityCollectionMetaPath = string.Empty;
			EntityCollectionDisplayValue = string.Empty;
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			Page.FilterEdit.AggregationEnable = false;
			Page.TreeGridRecordSorting.ShowAutoWidthMenu = false;
			Page.TreeGridRecordSorting.ShowMultiLineMenu = false;
			Page.TreeGridRecordSorting.ShowSummariesMenu = false;
			Page.TreeGridRecordSorting.IsShowOppositeReference = false;
			Page.TreeGridRecordSorting.IsColumnsExplorerRootMode = true;
			var df = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (df == null) {
				return true;
			}
			var entityCollection = df["EntityCollection"];
			if (entityCollection == null) {
				return true;
			}
			((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"] = Json.Serialize(entityCollection);
			if (entityCollection.ReferenceSchemaUId != Guid.Empty) {
				EntityCollectionSchemaUId = entityCollection.ReferenceSchemaUId;
				EntityCollectionMetaPath = entityCollection.Value;
				EntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(GetPropertyServerMetaPathByClientMetaPath(entityCollection.Value));
				Page.EntityDataSource.SchemaUId = EntityCollectionSchemaUId;
				EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
				string filters = df["DataSourceFilters"].Value;
				if (!String.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
					if (filterCollection != null) {
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				InitializeFilterEdit();
				Page.EntityDataSource.LoadStructure();
				InitTreeGridRecordSorting();
				InitAggregationColumnNamesList();
			} else {
				IsNew = true;
			}
			Page.FilterEdit.Enabled = EntityCollectionSchemaUId != Guid.Empty;
			return true;
		}

		public virtual bool OkButtonClickChildScriptExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.TitleEdit.Text;
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			var mappingVS = ProcessSchemaParameterValueSource.Mapping;
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			
			var entityCollection =
				Json.Deserialize<ProcessSchemaParameterValue>(((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["EntityCollectionCustomDataKey"].ToString());
			entityCollection.Value = EntityCollectionMetaPath;
			entityCollection.ModifiedInSchemaUId = EditSchemaUId;
			entityCollection.Source = string.IsNullOrEmpty(EntityCollectionMetaPath)? noneVS : mappingVS;
			entityCollection.ReferenceSchemaUId = EntityCollectionSchemaUId;
			parametersValue["EntityCollection"] = entityCollection;
			parametersValue["ResultEntityCollection"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				ReferenceSchemaUId = EntityCollectionSchemaUId
			};
			parametersValue["ResultEntity"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = EntityCollectionSchemaUId == Guid.Empty ? noneVS : constVS,
				Value = "",
				ReferenceSchemaUId = EntityCollectionSchemaUId
			};
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			var serializedFilterCollection = Json.Serialize(filterCollection, jsonConverter);
			bool isNoneVS = filterCollection == null || filterCollection.Count == 0;
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isNoneVS ? noneVS : constVS,
				Value = isNoneVS ? string.Empty : serializedFilterCollection
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
				if (column.OrderDirection == OrderDirection.None) {
					continue;
				}
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
			return true;
		}

		public virtual bool RadioButtonFunctionCheckScriptTaskExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonFunction.Checked) {
				string value = ((int)ProcessReadDataResultType.Function).ToString();
				SetUserTaskParameterConstValue("ResultType", value, value);
				value = Page.FunctionTypeEdit.SelectedItem.Value;
				if (string.IsNullOrEmpty(value) || value == "0") {
					value = ((int)AggregationTypeStrict.Sum).ToString();
				}
				SetUserTaskParameterConstValue("FunctionType", value, value);
				Page.FunctionColumnEdit.Enabled = true;
				Page.FunctionColumnEdit.SetRequired(true);
				Page.FunctionTypeEdit.Enabled = true;
				Page.FunctionTypeEdit.SetRequired(true);
				SetEnabledNumberOfRecordsControlLayout(false);
				InitAggregationColumnNamesList();
			}
			return true;
		}

		public virtual bool ScriptTaskSetColumnsMenuButtonClickExecute(ProcessExecutingContext context) {
			Page.AddScript(string.Format(
				"{0}.fireEvent('setcolumns', this, null);", Page.TreeGridRecordSorting.ClientID));
			return true;
		}

		public virtual bool ScriptTaskEntityCheckExecute(ProcessExecutingContext context) {
			if (Page.RadioButtonEntity.Checked) {
				string value = ((int)ProcessReadDataResultType.Entity).ToString();
				SetUserTaskParameterConstValue("ResultType", value, value);
				SetUserTaskParameterConstValue("FunctionType", "0", "0");
				Page.ControlLayoutTreeGrid.SetEnabled(true, true);
				Page.FunctionColumnEdit.Enabled = false;
				Page.FunctionColumnEdit.SetRequired(false);
				Page.FunctionTypeEdit.Enabled = false;
				Page.FunctionTypeEdit.SetRequired(false);
				SetEnabledNumberOfRecordsControlLayout(true);
				InitTreeGridRecordSorting();
			} else {
				Page.ControlLayoutTreeGrid.SetEnabled(false, true);
			}
			return true;
		}

		public virtual bool EntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			var processSchema = FindDesignedProcessSchema();
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter", schemaExplorer.ClientID);
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			var sb = new StringBuilder();
			sb.Append("function(columnInfo) {\n");
			sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
			sb.AppendFormat("{0}.setValue(info.caption);", Page.EntityCollectionTextEdit.ClientID);
			sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEventWithParameters('{0}', '{1}', columnInfo);", InstanceUId, "EntityCollectionEditChange");
			sb.Append("}");
			handler = sb.ToString();
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = processSchema.Manager.Name;
			schemaExplorer.ShowEditWindow(processSchema.UId, EntityCollectionMetaPath);
			return true;
		}

		public virtual bool NewEntityCollectionParameterValueScriptTaskExecute(ProcessExecutingContext context) {
			NewEntityCollectionParameterValue = Json.Serialize(context.ThrowEventArgs);
			return true;
		}

		public virtual bool PrepareChangeEntityCollectionQuestionScriptExecute(ProcessExecutingContext context) {
			ChangeEntityCollectionUserMessage.Page = Page;
			ChangeEntityCollectionUserMessage.MessageText = ChangeSchemaEntityMessage;
			ChangeEntityCollectionUserMessage.Icon = "QUESTION";
			ChangeEntityCollectionUserMessage.Buttons = "YESNO";
			ChangeEntityCollectionUserMessage.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeEntityCollectionYesMessage"},
				{"no", "ChangeEntityCollectionNoMessage"},
			};
			return true;
		}

		public virtual bool ChangeEntityCollectionYesMessageScriptExecute(ProcessExecutingContext context) {
			var entityCollectionSelectedParameterValues = Json.Deserialize<Dictionary<string, object>>(NewEntityCollectionParameterValue);
			EntityCollectionSchemaUId = new Guid(entityCollectionSelectedParameterValues["referenceSchemaUId"].ToString());
			EntityCollectionMetaPath = entityCollectionSelectedParameterValues["metaPath"].ToString();
			EntityCollectionDisplayValue = entityCollectionSelectedParameterValues["caption"].ToString();
			EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
			Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			if (!IsNew) {
				ClearDataSourceFilters();
				Page.EntityDataSource.CurrentStructure.Clear();
			}
			IsNew = false;
			Page.EntityDataSource.SchemaUId = EntityCollectionSchemaUId;
			EntitySchema schema = Page.EntityDataSource.Schema;
			var structure = Page.EntityDataSource.CurrentStructure;
			structure.Columns.Clear();
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
			InitializeFilterEdit();
			Page.EntityDataSource.LoadStructure();
			Page.FilterEdit.Enabled = EntityCollectionSchemaUId != Guid.Empty;
			//Page.TreeGridRecordSorting.RefreshData();
			InitAggregationColumnNamesList();
			return true;
		}

		public virtual bool ChangeEntityCollectionNoMessageScriptExecute(ProcessExecutingContext context) {
			Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			return true;
		}

		public virtual bool SScriptTaskFunctionColumnEditChangeExecute(ProcessExecutingContext context) {
			SetUserTaskParameterConstValue("AggregationColumnName",
				Page.FunctionColumnEdit.SelectedItem.Value, Page.FunctionColumnEdit.SelectedItem.Text);
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

		public virtual bool ScriptTaskReadSomeTopRecordsEditCheckExecute(ProcessExecutingContext context) {
			Page.NumberOfRecordsEdit.SetEnabled(Page.ReadSomeTopRecordsEdit.Checked);
			return true;
		}

		public override void InitializeSchemaExplorerWindow() {
			bool isNewSchemaExplorer = SchemaExplorer == null;
			if (isNewSchemaExplorer) {
				SchemaExplorer = new SchemaStructureExplorer(Page.TopControlLayout, "schemaStructure", false, false);
			}
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			if (isNewSchemaExplorer) {
				schemaExplorer.ManagerName = EditSchemaManagerName;
			} else {
				schemaExplorer.IncludedDataValueTypes.Clear();
			}
			schemaExplorer.IgnoredSchemaElementUId = EditElementUId;
			schemaExplorer.IncludedDataValueTypes.Add(ParameterDataValueTypeUId, Guid.NewGuid());
			Guid guidDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Guid").UId;
			if (IsParameterLookup) {
				schemaExplorer.IncludedDataValueTypes.Add(guidDataValueTypeUId, Guid.Empty);
			}
			if (ParameterDataValueTypeUId == guidDataValueTypeUId) {
				schemaExplorer.IncludedDataValueTypes.Add(UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId, Guid.Empty);
			}
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
			{"ReadSomeTopRecords", Page.ReadSomeTopRecordsEdit},
			{"NumberOfRecords", Page.NumberOfRecordsEdit}
			};
		}

		public override void MakeCaption() {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Caption = string.IsNullOrEmpty(Page.TitleEdit.Text)
				? string.Format("{0} ({1})", WindowCaption, NewRecord)
				: Page.TitleEdit.Text;
		}

		public virtual void InitializeFilterEdit() {
			EntityDataSource dataSource = Page.EntityDataSource;
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup == null) {
				filterEditGroup = dataSource.CreateFiltersGroup("FilterEdit");
				dataSource.CurrentStructure.Filters.Add(filterEditGroup);
			}
			Page.FilterEdit.AggregationEnable = false;
			Page.FilterEdit.IsRightExpressionSchemaStructureExplorerRootMode = false;
			Page.FilterEdit.IsColumnsExplorerRootMode = true;
			//Page.FilterEdit.Reinitialize(dataSource);
		}

		public virtual string GetPropertyDisplayPathByServerMetaPath(string serverMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGenerator(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetPropertyPathByMetaPath(new ProcessSchemaParameter(processSchema), serverMetaPath, true);
		}

		public virtual string GetPropertyServerMetaPathByClientMetaPath(string clientMetaPath) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var generator = new ProcessSchemaGenerator(UserConnection, processSchema.ProcessSchemaManager.Namespace);
			return generator.GetMetaPath(processSchema, clientMetaPath);
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
			InitializeFilterEdit();
			Page.EntityDataSource.LoadStructure(force: true);
			//Page.TreeGridRecordSorting.RefreshData();
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

		public virtual void SetEnabledNumberOfRecordsControlLayout(bool enabled) {
			Page.NumberOfRecordsControlLayout.SetEnabled(enabled, true);
			if (enabled) {
				Page.NumberOfRecordsEdit.SetEnabled(Page.ReadSomeTopRecordsEdit.Checked);
			}
		}

		public virtual void ClearDataSourceFilters() {
			EntityDataSource dataSource = Page.EntityDataSource;
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup != null) {
				filterEditGroup.Clear();
			}
		}

		public virtual string GetEntityCollectionDisplayValue(string displayValue, string metaPath) {
			if (string.IsNullOrEmpty(displayValue)) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				return processSchema.GetBaseElementByUId(new Guid(metaPath)).Name;
			}
			return displayValue;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "RadioButtonCountCheck":
							if (ActivatedEventElements.Contains("StartMessageRadioButtonCountCheck")) {
							context.QueueTasks.Enqueue("StartMessageRadioButtonCountCheck");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
							ProcessQueue(context);
							return;
						}
						break;
					case "RadioButtonFunctionCheck":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "SetColumnsMenuButtonClick":
							if (ActivatedEventElements.Contains("StartMessageSetColumnsMenuButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageSetColumnsMenuButtonClick");
						}
						break;
					case "RadioButtonEntityCheck":
							if (ActivatedEventElements.Contains("StartMessageRadioButtonEntityCheck")) {
							context.QueueTasks.Enqueue("StartMessageRadioButtonEntityCheck");
						}
						break;
					case "EntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("StartMessage7")) {
							context.QueueTasks.Enqueue("StartMessage7");
						}
						break;
					case "EntityCollectionEditChange":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
						}
						break;
					case "ChangeEntityCollectionYesMessage":
							if (ActivatedEventElements.Contains("ChangeEntityCollectionYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeEntityCollectionYesMessageBase");
						}
						break;
					case "ChangeEntityCollectionNoMessage":
							if (ActivatedEventElements.Contains("ChangeEntityCollectionNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageBase");
						}
						break;
					case "FunctionColumnEditChange":
							if (ActivatedEventElements.Contains("StartMessageFunctionColumnEditChange")) {
							context.QueueTasks.Enqueue("StartMessageFunctionColumnEditChange");
						}
						break;
					case "FunctionTypeEditChange":
							if (ActivatedEventElements.Contains("StartMessageFunctionTypeEditChange")) {
							context.QueueTasks.Enqueue("StartMessageFunctionTypeEditChange");
						}
						break;
					case "ReadSomeTopRecordsEditCheck":
							if (ActivatedEventElements.Contains("StartMessageReadSomeTopRecordsEditCheck")) {
							context.QueueTasks.Enqueue("StartMessageReadSomeTopRecordsEditCheck");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("NewEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewEntityCollectionParameterValue", NewEntityCollectionParameterValue, null);
			}
			if (!HasMapping("EntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionDisplayValue", EntityCollectionDisplayValue, null);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("EntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionSchemaUId", EntityCollectionSchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntityCollectionMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionMetaPath", EntityCollectionMetaPath, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess : ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.ReadEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl>
	{

		public ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReadEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class ReadEntityCollectionItemsUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit TitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("TitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit EntityCollectionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("EntityCollectionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton EntityCollectionEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("EntityCollectionEditToolButton", true);
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

		public Terrasoft.UI.WebControls.Controls.Label SortRecordsByFieldsLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("SortRecordsByFieldsLabel", true);
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
			EntityCollectionEditToolButton.AjaxEvents.Click.Event += EntityCollectionEditToolButtonClick;
			RadioButtonCount.AjaxEvents.Check.Event += RadioButtonCountCheck;
			RadioButtonFunction.AjaxEvents.Check.Event += RadioButtonFunctionCheck;
			FunctionTypeEdit.AjaxEvents.Change.Event += FunctionTypeEditChange;
			FunctionColumnEdit.AjaxEvents.Change.Event += FunctionColumnEditChange;
			RadioButtonEntity.AjaxEvents.Check.Event += RadioButtonEntityCheck;
			ReadSomeTopRecordsEdit.AjaxEvents.Check.Event += ReadSomeTopRecordsEditCheck;
			SetColumnsMenuButton.AjaxEvents.Click.Event += SetColumnsMenuButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event -= EntityCollectionEditToolButtonClick;
			RadioButtonCount.AjaxEvents.Check.Event -= RadioButtonCountCheck;
			RadioButtonFunction.AjaxEvents.Check.Event -= RadioButtonFunctionCheck;
			FunctionTypeEdit.AjaxEvents.Change.Event -= FunctionTypeEditChange;
			FunctionColumnEdit.AjaxEvents.Change.Event -= FunctionColumnEditChange;
			RadioButtonEntity.AjaxEvents.Check.Event -= RadioButtonEntityCheck;
			ReadSomeTopRecordsEdit.AjaxEvents.Check.Event -= ReadSomeTopRecordsEditCheck;
			SetColumnsMenuButton.AjaxEvents.Click.Event -= SetColumnsMenuButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void EntityCollectionEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EntityCollectionEditToolButtonClick");
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
			SchemaName = "ReadEntityCollectionItemsUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcess";
			UId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b");
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

		protected virtual ProcessSchemaParameter CreateEntityCollectionMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("01e47f46-82a8-4e92-b7a4-60c050adb899"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("456a029b-aac1-4fa4-b4d2-08cd97d73c2e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d20446ee-6ef0-4774-9e70-c72d93488182"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4425380b-698b-41eb-b2b8-f5ff8c27b46d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("55a6294c-e3b1-40c5-ba06-566df7db41c3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"NewEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntityCollectionMetaPathParameter());
			Parameters.Add(CreateEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateNewEntityCollectionParameterValueParameter());
		}

		protected virtual void InitializeChangeEntityCollectionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4f5bc9ec-adf6-4ded-b8f4-d40bcb753331"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("cddbc06a-eeef-48f2-b1df-1d77d187fecd"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("48bd0f82-34de-4176-abc7-d02b3002577c"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("e846352a-294e-4197-9d8b-cf22aac64a25"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("c021915c-3e0d-4392-9201-9cd5229d6122"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("c355d6ac-0821-4097-8c52-18392d6b77a0"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("bde1a904-8722-484f-852e-f33a42750b80"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
				UId = new Guid("bd4803fd-f55a-4da0-88f0-3670da1c04e8"),
				ContainerUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
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
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLaneInitEvents = CreateLaneInitEventsLane();
			schemaLaneSet1.Lanes.Add(schemaLaneInitEvents);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess eventsubprocesscount = CreateEventSubProcessCountEventSubProcess();
			FlowElements.Add(eventsubprocesscount);
			ProcessSchemaEventSubProcess eventsubprocessoninit = CreateEventSubProcessOnInitEventSubProcess();
			FlowElements.Add(eventsubprocessoninit);
			ProcessSchemaEventSubProcess onpageloadcomplete = CreateOnPageLoadCompleteEventSubProcess();
			FlowElements.Add(onpageloadcomplete);
			ProcessSchemaEventSubProcess okbuttonclickchildsubprocess = CreateOkButtonClickChildSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickchildsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionyesmessage = CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionyesmessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionnomessage = CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionnomessage);
			ProcessSchemaEventSubProcess eventsubprocessfunctioncolumneditchange = CreateEventSubProcessFunctionColumnEditChangeEventSubProcess();
			FlowElements.Add(eventsubprocessfunctioncolumneditchange);
			ProcessSchemaEventSubProcess eventsubprocessfunctiontype = CreateEventSubProcessFunctionTypeEventSubProcess();
			FlowElements.Add(eventsubprocessfunctiontype);
			ProcessSchemaEventSubProcess eventsubprocessreadsometoprecordseditcheck = CreateEventSubProcessReadSomeTopRecordsEditCheckEventSubProcess();
			FlowElements.Add(eventsubprocessreadsometoprecordseditcheck);
			ProcessSchemaStartMessageEvent startmessageradiobuttoncountcheck = CreateStartMessageRadioButtonCountCheckStartMessageEvent();
			eventsubprocesscount.FlowElements.Add(startmessageradiobuttoncountcheck);
			ProcessSchemaScriptTask scripttaskcountcheck = CreateScriptTaskCountCheckScriptTask();
			eventsubprocesscount.FlowElements.Add(scripttaskcountcheck);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocessoninit.FlowElements.Add(startmessageinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessoninit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocessoninit.FlowElements.Add(childinitscript);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			onpageloadcomplete.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			onpageloadcomplete.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			onpageloadcomplete.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask okbuttonclickchildscript = CreateOkButtonClickChildScriptScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(okbuttonclickchildscript);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask radiobuttonfunctioncheckscripttask = CreateRadioButtonFunctionCheckScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(radiobuttonfunctioncheckscripttask);
			ProcessSchemaStartMessageEvent startmessagesetcolumnsmenubuttonclick = CreateStartMessageSetColumnsMenuButtonClickStartMessageEvent();
			eventsubprocess5.FlowElements.Add(startmessagesetcolumnsmenubuttonclick);
			ProcessSchemaScriptTask scripttasksetcolumnsmenubuttonclick = CreateScriptTaskSetColumnsMenuButtonClickScriptTask();
			eventsubprocess5.FlowElements.Add(scripttasksetcolumnsmenubuttonclick);
			ProcessSchemaStartMessageEvent startmessageradiobuttonentitycheck = CreateStartMessageRadioButtonEntityCheckStartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessageradiobuttonentitycheck);
			ProcessSchemaScriptTask scripttaskentitycheck = CreateScriptTaskEntityCheckScriptTask();
			eventsubprocess4.FlowElements.Add(scripttaskentitycheck);
			ProcessSchemaStartMessageEvent startmessage7 = CreateStartMessage7StartMessageEvent();
			eventsubprocess7.FlowElements.Add(startmessage7);
			ProcessSchemaScriptTask entitycollectionedittoolbuttonclickscript = CreateEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess7.FlowElements.Add(entitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage6);
			ProcessSchemaScriptTask newentitycollectionparametervaluescripttask = CreateNewEntityCollectionParameterValueScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(newentitycollectionparametervaluescripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess2.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask preparechangeentitycollectionquestionscript = CreatePrepareChangeEntityCollectionQuestionScriptScriptTask();
			eventsubprocess2.FlowElements.Add(preparechangeentitycollectionquestionscript);
			ProcessSchemaUserTask changeentitycollectionusermessage = CreateChangeEntityCollectionUserMessageUserTask();
			eventsubprocess2.FlowElements.Add(changeentitycollectionusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaStartMessageEvent changeentitycollectionyesmessagebase = CreateChangeEntityCollectionYesMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagebase);
			ProcessSchemaScriptTask changeentitycollectionyesmessagescript = CreateChangeEntityCollectionYesMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagescript);
			ProcessSchemaScriptTask changeentitycollectionnomessagescript = CreateChangeEntityCollectionNoMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagescript);
			ProcessSchemaStartMessageEvent changeentitycollectionnomessagebase = CreateChangeEntityCollectionNoMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagebase);
			ProcessSchemaStartMessageEvent startmessagefunctioncolumneditchange = CreateStartMessageFunctionColumnEditChangeStartMessageEvent();
			eventsubprocessfunctioncolumneditchange.FlowElements.Add(startmessagefunctioncolumneditchange);
			ProcessSchemaScriptTask sscripttaskfunctioncolumneditchange = CreateSScriptTaskFunctionColumnEditChangeScriptTask();
			eventsubprocessfunctioncolumneditchange.FlowElements.Add(sscripttaskfunctioncolumneditchange);
			ProcessSchemaStartMessageEvent startmessagefunctiontypeeditchange = CreateStartMessageFunctionTypeEditChangeStartMessageEvent();
			eventsubprocessfunctiontype.FlowElements.Add(startmessagefunctiontypeeditchange);
			ProcessSchemaScriptTask scripttaskfunctiontypeeditchange = CreateScriptTaskFunctionTypeEditChangeScriptTask();
			eventsubprocessfunctiontype.FlowElements.Add(scripttaskfunctiontypeeditchange);
			ProcessSchemaStartMessageEvent startmessagereadsometoprecordseditcheck = CreateStartMessageReadSomeTopRecordsEditCheckStartMessageEvent();
			eventsubprocessreadsometoprecordseditcheck.FlowElements.Add(startmessagereadsometoprecordseditcheck);
			ProcessSchemaScriptTask scripttaskreadsometoprecordseditcheck = CreateScriptTaskReadSomeTopRecordsEditCheckScriptTask();
			eventsubprocessreadsometoprecordseditcheck.FlowElements.Add(scripttaskreadsometoprecordseditcheck);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f702b975-f882-4abb-a473-8b18285dce3d"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2a028c93-a9fc-47f5-8f75-9ffe1f92fdf0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("19c780e2-da93-4d5f-a858-b38ae76b1681"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48f4346d-f8dc-49d5-9d88-ac339446c216"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e3a93d5c-dd7d-4fa9-97c6-02eeb3ec9af2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f3e2ea56-0775-4c50-a4b9-508f9da11e4a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5e29fd3f-f00c-445a-8d74-93cf44324e40"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("83ee5b57-dd47-4fdd-b518-76e620511e1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6dbaf112-2938-4262-9d35-087d77d1b447"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6541bb33-9637-40be-a62e-987c1c5db151"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("7b5518a1-43c6-4d57-985b-d3ec9fdf6bb1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7af5e0db-0b96-402e-9afa-447c695170d1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f782dd80-46cc-4709-b4e6-84ce9df9921e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b5f848a5-d024-416c-9a3a-f24b8d004b14"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(142, 766),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b5c1b48-d2c0-4dc2-8dad-521f4c485940"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("740f4839-4121-4f78-92f1-77cf5f3525bd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("5385ea66-c6ce-40f1-8182-82242692c998"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(232, 766),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("740f4839-4121-4f78-92f1-77cf5f3525bd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("099d8b36-b98d-4eea-bca9-c03b2cb3a241"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("7673a9c1-32bc-4e91-865d-c88b6eab8197"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(580, 763),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69d168d0-89f4-4420-811f-cff3247a1595"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac33ee99-d16b-48d9-8623-7dbcdc469e35"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("283e6297-8858-4d70-bca0-e7895f4c1a85"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(685, 762),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac33ee99-d16b-48d9-8623-7dbcdc469e35"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6034803b-b1e0-43d4-9d6b-575e74bfd9ed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("ae380bc4-7130-4333-ba51-cbcd6671e005"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(662, 720),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a309c370-8339-4ea9-9fb8-b928056caa95"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54c7fc1e-7923-4bb1-beb9-539573a57ed4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("2f044784-b816-446a-9058-aaba9656ab15"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e666bc7a-e245-4fbd-882c-1665b575c3cf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60b8ee9d-3d6e-4d53-84ea-56f4d2dfc7d5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("407d6b15-4883-4071-8092-09a479683f3d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(170, 564),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05d8e732-3225-47a2-b3fe-18acef611208"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("091eb633-ceba-48a4-b9a5-807b6a481567"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("2504ed1c-3495-4537-8515-3248331e6143"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(174, 749),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("963e15de-62df-46bd-ab6d-07574c55e9b7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a309c370-8339-4ea9-9fb8-b928056caa95"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("7776da85-8828-4a3b-84b3-b3859bbf98db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(455, 404),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cce3a706-e59d-426e-84b4-642383e38974"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a2a68826-1d6d-4a36-83b5-ad408c3b2f68"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("b2a91bb8-2587-4dd2-b4e6-f4ea33842d46"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(336, 350),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60b8ee9d-3d6e-4d53-84ea-56f4d2dfc7d5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cce3a706-e59d-426e-84b4-642383e38974"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("30d6427b-fd4e-40b9-92cb-607cb5408b14"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(619, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb5c6396-7de0-4c0e-8b05-7be79024300a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("8c5b9b70-3283-4da1-b97e-c619311df47d"),
				ConditionExpression = @"!IsNew",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(458, 289),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cce3a706-e59d-426e-84b4-642383e38974"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb5c6396-7de0-4c0e-8b05-7be79024300a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("acbd4a0a-9bfe-492f-8208-368c6cadf243"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(884, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8eef7f54-306a-4ed5-8795-3f94223ba7c6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("025afd8b-f268-4870-ad58-e5d80e0f89b5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("9d868aa6-5128-429f-ac7e-3abd5584067c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(889, 450),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a156d9ae-d8fc-4aa8-a746-b307c6dae58b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8931acdc-e6fa-4dc2-960a-3cffea872c3e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("ec20a50d-68b1-4795-af0f-67547c219c0f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1355c758-4f98-4401-8caa-26cc1ea75da3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9e26f9c-ff18-4f72-92d6-b2e9b4cf71f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("3fa9db87-d588-4cf3-9071-e7359a0f784c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ece54fa-6e68-48d4-afe8-a763b2ed5687"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("540b42c7-3794-4a47-ba17-199d36a07a30"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("ed803d9e-2fb7-4e8c-be9b-78f597b24688"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4724dd6-7c7f-4d76-9cf1-adbbed93c8d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("327f2b83-3e4b-4f3e-88ec-b29507e1145d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1efb6539-251b-4958-9c8e-4df5f5e8bc5b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1254, 1153),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1efb6539-251b-4958-9c8e-4df5f5e8bc5b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1225, 710),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLaneInitEventsLane() {
			ProcessSchemaLane schemaLaneInitEvents = new ProcessSchemaLane(this) {
				UId = new Guid("cbd56b93-7a31-458c-8957-5a0a40409a0c"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("1efb6539-251b-4958-9c8e-4df5f5e8bc5b"),
				CreatedInOwnerSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"LaneInitEvents",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 933),
				Size = new Size(1225, 220),
				UseBackgroundMode = false
			};
			return schemaLaneInitEvents;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("f8f9360c-b401-480b-adea-b7d7389a4411"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("1efb6539-251b-4958-9c8e-4df5f5e8bc5b"),
				CreatedInOwnerSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"Lane5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 715),
				Size = new Size(1225, 213),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessCountEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessCount = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9ab56133-38dd-444a-8469-320b8c4018bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessCount",
				Position = new Point(323, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(272, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessCount;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRadioButtonCountCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("19c780e2-da93-4d5f-a858-b38ae76b1681"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ab56133-38dd-444a-8469-320b8c4018bd"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RadioButtonCountCheck",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageRadioButtonCountCheck",
				Position = new Point(56, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCountCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("48f4346d-f8dc-49d5-9d88-ac339446c216"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9ab56133-38dd-444a-8469-320b8c4018bd"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ScriptTaskCountCheck",
				Position = new Point(161, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,95,75,195,48,16,127,118,224,119,136,123,106,65,242,5,198,30,180,206,39,153,165,157,190,223,218,91,23,150,38,243,114,17,138,248,221,77,154,13,21,157,67,8,28,228,126,255,114,57,181,17,89,9,29,202,10,90,101,111,61,179,53,133,245,134,101,177,197,102,135,109,46,222,46,39,23,142,73,153,78,188,130,246,40,230,34,203,148,225,188,36,219,160,115,21,66,123,7,12,21,58,175,121,53,236,81,222,123,211,176,178,38,151,43,91,143,212,44,159,5,153,26,249,201,33,173,192,237,74,32,232,145,145,10,107,28,63,71,225,108,250,41,49,189,78,102,135,50,178,191,187,223,116,29,97,7,209,38,18,162,77,19,82,199,236,255,181,61,198,61,101,60,14,232,8,42,172,246,189,89,180,138,229,194,192,90,99,27,34,109,64,59,252,11,26,34,84,248,226,21,97,155,141,224,159,194,209,253,148,108,160,31,110,151,190,95,35,61,110,42,108,44,181,46,60,131,201,234,7,24,172,231,179,202,191,167,88,24,86,60,212,205,22,123,16,46,149,185,24,21,82,43,254,110,109,61,53,40,19,42,178,84,216,156,3,248,106,46,140,215,58,173,202,217,105,127,249,184,52,160,101,192,132,177,39,49,89,146,234,129,134,212,146,177,119,162,85,192,126,220,177,24,230,253,114,18,14,33,123,50,130,201,227,236,3,53,38,206,33,217,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOnInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOnInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9d83c3b4-d63d-47ef-a417-5cca150ccdbe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbd56b93-7a31-458c-8957-5a0a40409a0c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessOnInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 167),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOnInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2b5c1b48-d2c0-4dc2-8dad-521f4c485940"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d83c3b4-d63d-47ef-a417-5cca150ccdbe"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("740f4839-4121-4f78-92f1-77cf5f3525bd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d83c3b4-d63d-47ef-a417-5cca150ccdbe"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("099d8b36-b98d-4eea-bca9-c03b2cb3a241"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d83c3b4-d63d-47ef-a417-5cca150ccdbe"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,81,111,218,48,16,126,110,165,254,135,44,79,177,132,34,237,181,140,73,52,165,21,82,219,33,160,125,153,246,224,38,151,224,213,177,153,125,46,101,83,255,123,109,135,64,2,77,233,36,4,216,254,238,187,239,206,119,231,9,45,32,190,51,229,35,168,31,249,20,82,169,50,61,202,24,198,137,209,40,203,68,138,156,21,241,48,203,34,1,171,160,90,142,17,202,40,92,176,12,38,138,149,84,173,231,82,242,11,131,40,69,216,11,66,84,6,66,66,250,103,167,44,15,162,47,163,23,140,199,122,248,155,190,76,225,143,1,141,36,248,119,118,122,50,161,138,150,128,160,46,41,210,7,202,13,204,215,75,184,31,103,193,32,184,215,160,172,43,1,41,50,41,226,22,226,150,10,43,89,197,215,128,78,199,197,250,206,210,68,225,72,32,195,117,34,57,175,140,90,54,33,137,45,113,223,123,181,225,206,25,114,240,65,206,225,5,173,191,17,135,18,4,222,193,42,161,75,103,237,160,207,84,5,25,228,158,68,91,80,116,201,60,179,141,247,155,70,197,68,209,11,38,74,166,160,245,44,93,64,73,183,17,121,147,239,228,18,114,106,56,86,4,142,113,6,216,220,139,182,236,63,195,41,104,187,237,181,254,234,5,81,196,4,146,13,249,20,104,230,162,217,65,226,42,88,18,207,229,204,11,137,200,86,74,39,218,130,111,100,74,57,251,11,217,206,170,233,152,28,209,120,101,132,79,64,91,229,176,40,20,20,180,62,112,212,41,198,51,83,182,229,117,194,58,116,181,156,29,83,230,130,158,201,18,230,114,185,41,97,167,47,167,92,67,75,68,117,109,241,168,92,226,218,199,126,96,118,204,211,94,167,56,55,225,215,176,254,218,63,245,108,173,50,176,117,180,101,171,14,53,43,196,173,204,32,225,84,107,187,76,21,91,162,116,165,183,253,59,8,26,251,84,7,157,70,142,241,138,113,110,107,97,9,10,215,174,16,102,210,168,20,162,234,167,215,160,37,117,145,47,15,208,174,218,31,152,66,67,249,110,147,28,178,58,134,67,235,216,230,47,225,204,54,212,208,94,225,51,76,229,42,242,206,46,152,200,92,219,73,165,35,219,190,155,191,110,119,115,63,135,92,189,93,186,60,197,88,48,172,75,227,134,105,172,136,245,138,97,186,176,5,217,217,4,100,36,108,169,217,14,213,16,161,93,203,252,3,108,195,105,187,51,99,191,73,170,1,118,146,82,13,71,219,238,220,33,171,177,51,165,25,147,213,152,220,180,100,178,128,244,9,220,196,115,51,179,239,161,54,121,35,65,31,57,100,123,213,100,7,34,42,201,111,232,90,26,140,156,1,233,239,200,91,167,115,5,112,173,88,22,239,200,188,65,47,104,152,61,42,160,79,253,79,4,82,231,251,252,63,188,249,222,107,185,115,111,65,231,48,169,18,27,12,6,31,14,149,68,26,123,214,232,232,205,69,28,230,215,35,223,77,239,107,0,86,89,151,93,173,234,93,211,10,93,67,236,83,99,74,225,95,145,189,44,147,227,112,247,18,50,245,17,222,133,253,105,242,38,248,61,234,215,246,133,219,165,253,40,64,163,68,21,223,27,127,189,52,250,6,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("09d76d38-b0cc-48ca-84c6-66a003ffac1f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cbd56b93-7a31-458c-8957-5a0a40409a0c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"OnPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(455, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 168),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69d168d0-89f4-4420-811f-cff3247a1595"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09d76d38-b0cc-48ca-84c6-66a003ffac1f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ac33ee99-d16b-48d9-8623-7dbcdc469e35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09d76d38-b0cc-48ca-84c6-66a003ffac1f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6034803b-b1e0-43d4-9d6b-575e74bfd9ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09d76d38-b0cc-48ca-84c6-66a003ffac1f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,193,78,227,48,16,61,23,137,127,48,61,37,82,149,31,128,34,149,182,160,178,20,42,2,203,97,197,193,36,147,214,171,196,142,108,7,200,34,254,157,177,221,54,105,146,86,221,67,165,70,51,126,243,252,102,230,121,202,53,211,229,88,164,41,68,154,9,62,7,77,23,84,175,200,144,40,45,25,95,6,211,44,215,229,249,233,201,180,145,57,97,42,79,105,249,155,166,5,180,179,223,169,36,42,90,65,70,49,118,205,120,60,1,197,150,28,226,133,20,17,40,21,218,152,231,99,234,130,46,33,184,102,169,6,57,141,153,14,66,208,187,73,14,167,43,117,180,92,74,88,82,67,103,202,233,91,106,136,36,52,85,176,201,125,146,0,55,146,197,143,16,9,25,135,66,106,67,50,92,137,143,81,161,197,11,139,245,106,14,188,56,254,216,188,72,53,187,99,28,254,239,88,88,100,25,149,12,212,241,199,102,202,28,124,200,115,161,152,134,71,72,64,2,143,142,188,225,76,97,163,138,140,171,233,103,158,10,9,242,81,8,61,23,177,57,174,101,1,235,14,197,9,126,79,32,161,120,43,219,72,69,168,34,19,102,27,76,101,121,225,186,58,32,59,13,89,80,73,51,192,30,216,35,151,136,197,18,226,25,172,33,225,69,154,250,228,235,244,164,39,65,23,146,111,170,125,187,130,208,24,34,44,31,39,127,250,205,217,234,191,174,65,219,249,7,75,120,222,19,72,73,149,72,116,240,60,11,94,224,109,44,184,150,34,85,129,17,203,183,138,141,84,110,63,130,113,161,180,200,38,84,211,54,131,42,246,11,202,254,43,242,188,85,130,227,108,74,70,83,246,15,90,204,252,61,140,131,109,231,156,120,207,179,152,156,13,201,77,193,98,183,44,238,42,205,250,85,242,176,37,90,7,228,121,7,68,109,149,91,8,182,115,93,135,26,91,125,99,119,49,7,169,203,117,196,32,94,149,168,195,59,200,77,5,175,150,182,27,185,42,199,41,195,234,219,204,110,38,190,81,175,103,187,227,8,25,225,67,81,200,8,130,186,18,123,85,58,238,42,135,50,188,67,193,65,171,242,230,66,77,226,85,198,19,124,106,107,82,230,79,7,247,58,190,1,113,171,70,18,235,110,106,189,24,149,14,206,245,84,255,181,234,157,25,183,179,208,249,238,76,221,227,90,60,72,59,82,222,26,196,119,179,213,51,155,247,23,199,23,151,1,123,131,17,68,231,240,65,90,232,183,245,36,239,89,129,196,47,238,248,162,9,52,220,183,58,110,85,176,101,92,229,157,5,183,139,131,246,191,93,157,53,187,1,209,101,14,34,241,154,52,106,75,53,32,6,184,103,200,222,49,165,47,118,8,94,146,175,198,181,190,125,235,95,123,241,44,77,35,91,139,230,89,221,87,122,123,70,113,92,72,92,59,141,146,23,17,58,207,70,12,21,140,226,184,5,233,52,65,83,178,191,25,103,218,93,191,18,208,59,48,245,119,130,198,219,58,46,209,64,116,186,125,21,174,189,135,206,255,239,209,168,149,81,206,230,124,19,192,151,195,94,17,231,5,53,29,214,188,179,217,93,247,160,30,220,186,93,35,67,152,186,33,255,0,190,173,13,19,90,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickChildSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickChildSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5af48d2b-6a08-4759-b8da-0d51430a5669"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8f9360c-b401-480b-adea-b7d7389a4411"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"OkButtonClickChildSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 178),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickChildSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("963e15de-62df-46bd-ab6d-07574c55e9b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5af48d2b-6a08-4759-b8da-0d51430a5669"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessage5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 78),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a309c370-8339-4ea9-9fb8-b928056caa95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5af48d2b-6a08-4759-b8da-0d51430a5669"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"OkButtonClickChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,77,79,219,64,16,61,131,196,127,88,249,228,72,214,138,246,8,133,10,18,64,161,37,32,18,232,161,226,176,177,199,100,91,123,215,218,93,67,83,200,127,239,126,217,73,28,39,64,85,212,3,7,214,111,102,222,219,121,51,217,147,12,114,96,106,0,143,93,82,40,202,25,58,64,87,228,30,240,136,170,12,78,18,170,240,8,126,169,253,157,237,7,34,16,227,12,110,135,6,34,120,12,82,14,227,9,228,228,138,8,146,131,2,113,75,178,18,134,188,20,49,224,129,134,250,168,152,51,169,94,25,214,181,88,115,224,131,115,82,20,148,221,191,50,252,194,161,125,108,81,65,164,197,88,105,203,39,68,162,30,141,141,110,34,166,159,164,18,58,56,218,84,231,80,167,166,41,10,87,82,31,32,86,102,89,7,61,237,108,111,53,171,28,180,224,17,131,199,183,214,14,59,29,93,126,182,179,237,228,233,190,81,53,237,242,44,131,216,181,78,215,62,151,156,225,30,72,16,148,100,244,55,124,218,152,48,12,71,32,4,145,60,85,248,166,143,191,193,88,55,64,9,158,73,108,92,208,177,86,56,146,133,253,7,119,75,169,120,222,35,138,124,15,78,26,197,231,223,190,192,52,184,195,35,62,180,138,28,231,38,85,92,221,66,51,205,5,40,77,82,77,218,98,46,120,66,83,10,73,159,57,49,55,253,196,100,208,30,173,255,111,11,115,214,208,72,119,197,184,47,7,186,83,151,226,36,47,212,52,92,71,160,243,185,114,251,222,220,131,109,233,175,33,5,1,44,134,37,82,13,212,34,193,134,21,86,175,50,184,211,25,154,117,218,2,175,65,150,153,106,13,55,238,218,208,249,208,25,245,21,55,26,105,216,219,36,106,135,190,68,246,223,83,172,155,188,150,150,25,209,179,146,38,216,246,29,45,180,215,239,39,147,166,178,101,16,252,173,110,51,152,41,205,180,138,197,193,116,59,245,212,158,219,165,106,6,197,239,172,83,202,18,247,69,158,9,94,22,199,211,129,190,134,48,152,163,131,142,79,252,67,15,183,30,208,7,16,250,75,181,67,234,76,62,201,249,34,40,188,145,134,9,99,142,73,180,129,72,85,164,94,29,158,213,146,14,187,94,134,21,34,108,42,141,150,41,154,148,99,206,51,68,229,160,250,233,88,189,28,183,58,209,243,243,202,55,253,115,80,50,101,16,187,109,150,90,145,254,142,190,170,21,108,54,206,2,204,175,27,103,183,189,13,215,186,118,96,72,50,228,57,140,120,113,13,49,23,201,123,202,107,145,226,172,178,202,194,218,166,59,129,248,39,36,11,107,126,141,138,65,153,143,65,92,166,255,81,66,131,66,253,168,153,15,172,28,123,86,78,204,113,73,179,68,207,142,177,111,202,5,144,120,130,66,247,146,201,202,156,33,202,252,27,73,0,156,9,154,184,196,67,46,148,105,248,194,104,247,32,213,25,203,88,149,194,60,109,76,176,116,226,204,27,194,101,195,151,66,215,234,81,49,31,135,229,19,251,148,114,81,91,90,163,174,97,31,71,91,51,159,70,142,241,87,96,247,106,130,14,209,174,199,233,179,163,162,0,150,132,65,100,183,135,69,215,167,167,92,228,68,133,193,211,238,108,239,233,131,254,251,56,11,34,175,14,155,237,19,161,144,50,213,105,101,88,3,237,241,21,151,212,156,250,151,201,74,255,45,168,207,82,254,142,157,159,223,128,217,20,47,76,168,6,207,77,27,57,15,8,208,29,98,72,183,10,246,255,0,107,78,198,10,18,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("54c7fc1e-7923-4bb1-beb9-539573a57ed4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5af48d2b-6a08-4759-b8da-0d51430a5669"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 78),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4ac3bbdf-cdef-44db-a91b-1de18c871342"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcess3",
				Position = new Point(1023, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f3e2ea56-0775-4c50-a4b9-508f9da11e4a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ac3bbdf-cdef-44db-a91b-1de18c871342"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RadioButtonFunctionCheck",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessage2",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRadioButtonFunctionCheckScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5e29fd3f-f00c-445a-8d74-93cf44324e40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ac3bbdf-cdef-44db-a91b-1de18c871342"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"RadioButtonFunctionCheckScriptTask",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,74,3,49,20,133,215,21,124,135,48,171,12,72,112,47,93,104,29,161,80,218,50,173,238,211,201,237,24,154,73,234,205,141,80,172,239,110,102,210,209,86,43,186,10,132,123,126,190,163,215,140,207,101,13,162,148,74,187,187,64,228,236,67,176,21,105,103,197,232,25,170,13,168,156,189,93,94,12,60,161,182,53,123,149,38,0,27,50,206,181,165,124,142,174,2,239,75,144,234,94,146,44,193,7,67,203,221,22,68,111,146,139,165,91,116,82,158,223,68,155,5,208,163,7,92,74,191,153,75,148,13,16,224,200,89,79,79,173,49,207,190,44,178,171,20,118,120,58,117,159,222,85,238,35,218,227,66,105,18,11,48,80,17,168,49,65,35,58,191,86,163,35,98,42,47,198,126,26,140,153,97,209,108,105,199,147,45,219,239,123,168,33,203,174,179,68,59,56,229,188,173,107,132,90,246,105,45,80,21,243,66,243,29,239,253,31,136,199,189,207,65,158,192,141,156,9,141,237,240,10,43,87,6,84,44,69,152,208,126,187,140,13,74,120,9,26,65,241,246,246,167,237,231,102,127,152,30,109,123,198,50,126,30,244,211,208,172,0,103,235,18,42,135,202,71,92,66,103,38,114,231,2,241,181,52,62,9,198,86,211,209,150,169,242,52,78,228,39,218,83,55,97,92,16,129,2,218,84,232,3,135,252,75,223,161,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("28436f51-cb8c-47f9-94ea-6fcf8c678029"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcess5",
				Position = new Point(820, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(184, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSetColumnsMenuButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7af5e0db-0b96-402e-9afa-447c695170d1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28436f51-cb8c-47f9-94ea-6fcf8c678029"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SetColumnsMenuButtonClick",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageSetColumnsMenuButtonClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskSetColumnsMenuButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f782dd80-46cc-4709-b4e6-84ce9df9921e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28436f51-cb8c-47f9-94ea-6fcf8c678029"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ScriptTaskSetColumnsMenuButtonClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,204,65,10,194,48,16,0,192,179,133,254,33,244,210,4,66,240,158,147,104,21,111,197,250,129,146,172,117,33,221,200,102,227,69,252,187,246,1,51,227,188,128,59,196,56,5,198,151,232,34,140,180,184,115,230,117,22,221,54,187,238,179,255,186,7,50,12,111,32,209,125,1,9,57,213,149,74,111,149,60,177,88,69,53,37,227,59,171,198,237,186,51,192,133,49,222,32,100,142,83,102,217,194,99,194,63,191,158,140,241,109,195,32,149,73,9,87,240,63,215,36,233,17,128,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("842839c1-5ded-4cb8-b05d-c1a43fda94bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcess4",
				Position = new Point(617, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(184, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRadioButtonEntityCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6dbaf112-2938-4262-9d35-087d77d1b447"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("842839c1-5ded-4cb8-b05d-c1a43fda94bc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RadioButtonEntityCheck",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageRadioButtonEntityCheck",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskEntityCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6541bb33-9637-40be-a62e-987c1c5db151"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("842839c1-5ded-4cb8-b05d-c1a43fda94bc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ScriptTaskEntityCheck",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,75,196,48,16,133,207,46,236,127,8,61,165,32,197,251,226,197,90,69,16,45,109,245,158,109,166,107,216,54,209,201,68,40,178,255,221,52,237,182,136,34,189,76,32,188,247,205,188,25,213,48,158,139,3,36,133,144,202,220,56,34,163,51,77,138,250,36,125,131,250,8,50,102,95,219,205,133,37,84,250,192,62,69,235,128,93,51,206,149,166,56,71,83,131,181,5,8,121,43,72,20,96,93,75,85,255,14,201,136,136,147,202,148,193,200,227,157,135,148,64,47,22,176,18,246,152,11,20,29,16,96,106,180,165,215,1,203,163,5,16,93,142,173,166,103,149,251,206,233,154,148,209,147,63,186,26,75,240,134,136,94,76,104,218,71,209,27,71,21,2,220,163,146,137,199,102,90,236,91,144,156,112,232,56,212,197,116,166,166,166,117,157,206,164,162,100,146,251,53,52,162,181,240,159,212,195,11,248,112,10,61,61,136,127,131,135,113,87,97,103,225,223,208,37,199,147,235,246,128,207,77,1,181,65,105,127,196,230,115,186,7,173,230,37,140,202,210,32,157,111,117,98,224,193,225,244,235,118,23,6,89,150,119,218,110,16,200,161,14,63,187,111,163,51,232,203,103,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5bc454e3-da8e-44c9-b15a-e29f826a8555"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 13),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(262, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage7StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("05d8e732-3225-47a2-b3fe-18acef611208"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5bc454e3-da8e-44c9-b15a-e29f826a8555"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessage7",
				Position = new Point(29, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("091eb633-ceba-48a4-b9a5-807b6a481567"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5bc454e3-da8e-44c9-b15a-e29f826a8555"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EntityCollectionEditToolButtonClickScript",
				Position = new Point(140, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,93,139,218,64,20,125,47,244,63,12,121,49,66,24,218,190,74,161,86,179,96,97,183,210,216,221,23,161,140,153,27,51,101,50,19,38,55,171,86,252,239,189,147,196,213,196,46,133,210,23,197,115,191,206,61,247,56,11,163,80,9,173,126,65,146,230,80,136,120,95,106,235,192,61,41,35,237,46,28,79,222,190,121,22,142,85,189,32,251,200,250,217,76,84,29,146,160,171,83,172,29,156,67,93,131,210,217,20,170,170,77,162,250,59,234,63,135,74,109,13,200,229,117,172,25,89,161,83,102,203,114,97,164,110,198,181,0,143,139,18,15,55,241,111,144,129,3,147,194,131,40,224,146,124,103,93,33,48,12,118,205,42,252,248,238,244,35,150,10,103,182,40,53,32,44,133,163,116,4,23,68,131,245,248,76,43,48,184,152,143,47,228,75,112,120,152,11,20,137,173,93,234,167,44,111,65,82,225,81,57,172,133,190,128,103,1,55,84,98,96,199,146,134,220,231,90,105,9,174,93,118,195,167,101,9,70,134,65,86,155,20,149,53,97,106,117,93,152,133,201,236,152,29,215,38,24,228,249,142,138,130,212,51,222,35,175,81,105,254,37,249,250,192,37,164,86,194,117,249,164,95,123,22,133,212,224,21,224,163,208,53,132,190,21,79,69,233,71,83,65,196,150,98,11,60,54,168,240,48,179,90,67,67,106,5,123,244,2,246,228,185,105,220,169,189,2,231,68,101,51,228,211,159,98,127,15,152,91,89,241,85,238,236,174,45,143,159,233,227,73,97,254,114,135,42,28,17,171,81,196,70,199,247,254,171,183,68,196,22,166,66,65,71,254,190,144,17,11,134,228,154,203,146,31,182,48,212,234,212,0,87,86,218,240,149,109,175,16,14,34,61,223,124,242,26,17,74,100,104,250,159,172,246,130,250,54,141,100,73,234,84,137,247,194,208,15,199,167,82,182,64,56,112,164,202,88,120,252,112,162,211,30,153,63,68,109,194,117,64,115,214,65,228,225,9,59,157,94,55,37,45,15,180,108,218,217,248,21,110,227,191,114,250,71,238,158,175,29,240,253,47,100,7,29,58,34,221,95,186,247,124,156,99,220,7,111,43,147,220,238,188,29,186,39,172,95,218,184,103,104,30,178,167,88,10,204,61,13,7,244,122,25,70,207,24,76,126,3,91,83,105,131,29,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcess2",
				Position = new Point(36, 191),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(688, 338),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e666bc7a-e245-4fbd-882c-1665b575c3cf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityCollectionEditChange",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessage6",
				Position = new Point(36, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNewEntityCollectionParameterValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60b8ee9d-3d6e-4d53-84ea-56f4d2dfc7d5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"NewEntityCollectionParameterValueScriptTask",
				Position = new Point(155, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,45,119,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,72,44,74,204,77,45,73,45,10,75,204,41,77,85,176,85,240,42,206,207,211,11,78,45,202,76,204,201,172,74,213,72,206,207,43,73,173,40,209,11,201,40,202,47,119,45,75,205,43,113,44,74,47,214,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,207,202,118,138,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("cce3a706-e59d-426e-84b4-642383e38974"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeEntityCollectionQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cb5c6396-7de0-4c0e-8b05-7be79024300a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"PrepareChangeEntityCollectionQuestionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,14,130,48,16,134,103,73,120,135,166,51,241,5,80,7,145,129,65,80,129,129,145,144,11,52,193,171,105,143,40,33,188,187,5,58,56,104,100,185,63,151,126,223,127,13,154,18,107,8,145,4,245,129,108,91,168,72,72,204,53,168,51,104,93,214,176,189,152,193,246,108,10,223,117,130,191,188,205,12,94,100,180,133,79,171,6,238,229,98,217,247,85,93,81,37,209,148,240,107,30,166,89,148,196,124,149,117,236,136,36,234,73,44,194,52,78,214,89,55,208,15,99,129,221,39,29,225,201,78,98,38,75,213,239,52,41,129,181,199,150,60,176,193,117,54,3,239,65,115,143,241,239,7,10,208,182,143,143,222,140,163,252,77,199,242,19,30,205,183,21,80,167,144,145,234,192,127,3,172,124,101,110,171,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeEntityCollectionUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("faf59503-983d-42df-9efb-5ec1149964cf"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ChangeEntityCollectionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(582, 44),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeEntityCollectionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a2a68826-1d6d-4a36-83b5-ad408c3b2f68"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43a6e6c5-5627-44bf-bb1c-cde3ab699113"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(435, 233),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e886f55a-fdf4-4436-8c44-1205d9b076d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessChangeEntityCollectionYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(749, 175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8eef7f54-306a-4ed5-8795-3f94223ba7c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e886f55a-fdf4-4436-8c44-1205d9b076d7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ChangeEntityCollectionYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("025afd8b-f268-4870-ad58-e5d80e0f89b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e886f55a-fdf4-4436-8c44-1205d9b076d7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ChangeEntityCollectionYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,75,111,26,49,16,62,131,196,127,112,114,90,36,228,168,231,60,36,196,82,68,149,166,40,208,92,170,30,140,119,0,183,94,47,26,123,147,210,42,255,61,227,245,194,62,4,52,57,172,214,242,204,247,205,55,47,63,11,100,96,156,114,187,81,166,53,72,167,50,51,7,127,128,100,38,80,164,224,0,159,132,206,193,178,91,246,197,102,134,199,96,1,149,208,234,47,220,196,170,64,8,220,221,88,135,202,172,7,44,91,254,34,244,221,93,244,0,47,227,22,115,147,177,127,221,235,182,61,230,114,3,169,248,62,77,40,154,129,23,54,201,85,18,189,83,224,143,75,132,21,32,24,9,7,154,203,159,124,145,205,11,105,81,255,88,192,175,224,196,76,184,13,197,123,119,152,180,196,52,200,143,112,199,202,110,181,216,21,176,143,240,75,177,245,246,15,210,79,192,157,243,136,206,25,7,236,84,93,124,224,153,88,3,111,59,44,224,143,27,39,202,113,127,160,240,231,232,137,67,173,88,116,49,181,52,20,125,246,175,215,237,140,52,8,140,133,19,243,44,71,9,159,149,166,2,216,34,207,78,45,94,229,193,71,57,82,111,29,21,36,151,46,71,186,240,20,5,226,181,215,45,168,73,198,74,104,11,77,205,53,142,250,120,157,28,189,67,169,195,13,179,225,119,203,206,113,18,232,153,118,201,238,213,157,116,111,167,65,64,91,165,148,233,60,53,182,150,154,39,221,162,74,105,197,130,145,136,107,254,8,194,65,48,68,65,231,160,212,203,103,117,20,167,188,90,155,208,96,229,83,251,164,172,90,106,168,213,176,138,51,76,146,50,72,3,181,23,152,132,94,87,2,27,10,226,186,181,28,133,22,130,150,61,215,58,76,198,42,163,164,228,134,69,158,89,6,7,101,246,156,101,133,130,107,199,83,201,50,65,75,229,94,236,182,224,217,234,253,11,136,131,153,79,192,0,138,50,88,167,211,214,46,247,50,201,182,36,37,191,139,35,77,152,255,94,143,169,191,168,171,175,137,254,111,163,26,52,71,58,212,41,83,251,134,9,96,172,48,204,41,241,54,47,248,208,74,48,9,193,218,152,89,102,85,9,249,228,109,199,26,42,15,157,244,91,100,200,191,120,218,195,66,250,5,143,250,39,215,233,62,19,201,97,144,43,191,10,75,16,65,51,117,118,221,124,253,252,51,207,199,233,214,237,136,227,234,170,96,89,32,192,4,85,242,8,50,195,100,158,161,163,12,249,35,172,16,236,198,139,40,2,122,197,195,245,26,97,45,60,107,72,234,129,222,83,123,175,108,208,142,64,242,12,35,157,112,253,6,83,73,229,95,240,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bdcc7e54-aef4-44ac-9d4f-4cbfb6fbad88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessChangeEntityCollectionNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(749, 350),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(244, 165),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionNoMessage;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8931acdc-e6fa-4dc2-960a-3cffea872c3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdcc7e54-aef4-44ac-9d4f-4cbfb6fbad88"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ChangeEntityCollectionNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,73,173,40,113,77,201,44,209,3,49,20,108,21,208,229,93,50,139,11,114,18,43,195,18,115,74,83,173,121,185,138,82,75,74,139,242,20,74,138,128,60,0,226,252,1,62,80,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a156d9ae-d8fc-4aa8-a746-b307c6dae58b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bdcc7e54-aef4-44ac-9d4f-4cbfb6fbad88"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionNoMessage",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ChangeEntityCollectionNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessFunctionColumnEditChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessFunctionColumnEditChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6350ee39-d89b-4045-bdce-3ea6e978dbb8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessFunctionColumnEditChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(1009, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(199, 159),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessFunctionColumnEditChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageFunctionColumnEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1355c758-4f98-4401-8caa-26cc1ea75da3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6350ee39-d89b-4045-bdce-3ea6e978dbb8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FunctionColumnEditChange",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageFunctionColumnEditChange",
				Position = new Point(21, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSScriptTaskFunctionColumnEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e9e26f9c-ff18-4f72-92d6-b2e9b4cf71f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6350ee39-d89b-4045-bdce-3ea6e978dbb8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"SScriptTaskFunctionColumnEditChange",
				Position = new Point(98, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,204,61,10,194,64,20,69,225,218,64,246,16,82,41,132,217,64,42,9,10,54,33,144,104,255,72,46,67,112,126,224,205,125,224,242,21,27,91,235,243,113,102,240,94,160,139,148,231,36,42,17,132,14,57,21,62,36,24,142,237,217,123,133,23,238,57,13,57,88,76,227,199,180,93,93,29,38,241,112,87,75,235,175,93,182,157,110,70,192,74,108,55,34,186,239,165,107,254,178,11,94,60,245,117,165,160,105,106,168,134,254,13,110,151,146,69,159,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessFunctionTypeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessFunctionType = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9f69897b-5c6c-4f9d-aea1-740114edbcd9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessFunctionType",
				Position = new Point(1016, 363),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessFunctionType;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageFunctionTypeEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7ece54fa-6e68-48d4-afe8-a763b2ed5687"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f69897b-5c6c-4f9d-aea1-740114edbcd9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FunctionTypeEditChange",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageFunctionTypeEditChange",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskFunctionTypeEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("540b42c7-3794-4a47-ba17-199d36a07a30"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f69897b-5c6c-4f9d-aea1-740114edbcd9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ScriptTaskFunctionTypeEditChange",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,65,10,194,48,16,69,215,22,188,67,232,170,5,201,5,196,133,22,133,130,72,177,213,125,104,198,24,218,78,100,50,17,68,188,187,77,85,112,245,55,239,189,111,47,34,171,148,1,121,84,218,186,77,96,118,184,11,216,178,117,40,139,43,180,29,232,92,60,231,201,204,51,89,52,226,174,250,0,98,37,38,233,71,54,143,27,108,181,101,89,67,15,45,131,46,25,6,121,142,232,114,84,107,224,147,7,106,148,239,42,69,106,0,6,42,28,122,158,136,44,253,207,164,139,207,197,119,242,232,151,104,121,109,12,129,81,17,43,92,31,6,60,140,29,191,183,158,179,200,188,230,9,1,7,66,193,52,158,190,1,10,40,74,74,215,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessReadSomeTopRecordsEditCheckEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessReadSomeTopRecordsEditCheck = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f5e4b58f-53ba-40b7-a707-98ada4072846"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("850e48d7-8835-428f-ba83-662a5d15d8b7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"EventSubProcessReadSomeTopRecordsEditCheck",
				Position = new Point(35, 539),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessReadSomeTopRecordsEditCheck;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageReadSomeTopRecordsEditCheckStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e4724dd6-7c7f-4d76-9cf1-adbbed93c8d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e4b58f-53ba-40b7-a707-98ada4072846"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ReadSomeTopRecordsEditCheck",
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"StartMessageReadSomeTopRecordsEditCheck",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskReadSomeTopRecordsEditCheckScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("327f2b83-3e4b-4f3e-88ec-b29507e1145d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f5e4b58f-53ba-40b7-a707-98ada4072846"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Name = @"ScriptTaskReadSomeTopRecordsEditCheck",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,43,205,77,74,45,242,79,11,74,77,206,47,74,41,118,77,201,44,209,11,78,45,113,205,75,76,202,73,77,209,8,0,169,9,74,77,76,9,206,207,77,13,201,47,64,86,230,156,145,154,156,157,154,162,105,205,203,85,148,90,82,90,148,167,80,82,84,154,106,13,0,70,117,131,0,87,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeFilterEditMethod());
			Methods.Add(CreateGetPropertyDisplayPathByServerMetaPathMethod());
			Methods.Add(CreateGetPropertyServerMetaPathByClientMetaPathMethod());
			Methods.Add(CreateInitFunctionListMethod());
			Methods.Add(CreateInitTreeGridRecordSortingMethod());
			Methods.Add(CreateInitAggregationColumnNamesListMethod());
			Methods.Add(CreateSetUserTaskParameterConstValueMethod());
			Methods.Add(CreateSetEnabledNumberOfRecordsControlLayoutMethod());
			Methods.Add(CreateClearDataSourceFiltersMethod());
			Methods.Add(CreateGetEntityCollectionDisplayValueMethod());
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
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60992d4c-e5a6-4891-8a0b-55a87c8c2e1a"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("39b69501-96cb-4ccf-8031-bb503aac3707"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b4b348d1-4d02-48ca-914b-e3352b13132f"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("88cf0cfd-c8b8-4a9c-9d22-db769829d23b"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,93,79,194,48,20,134,175,33,225,63,212,93,109,9,217,31,32,92,40,16,178,4,137,17,240,190,174,135,185,216,181,75,63,196,197,240,223,61,117,69,28,20,137,222,172,203,233,249,120,222,183,231,89,74,78,74,189,132,221,42,127,129,138,206,222,107,46,21,40,50,38,167,129,49,17,150,243,209,160,95,110,73,28,40,73,200,199,160,223,59,107,35,96,231,91,173,140,178,185,177,10,14,183,241,3,45,32,93,203,122,34,133,81,146,47,104,35,173,25,146,72,119,243,163,33,217,82,174,193,31,9,50,236,7,253,55,170,136,190,2,77,245,165,217,215,116,116,59,167,247,84,32,171,90,210,10,112,202,140,149,166,45,250,17,119,84,4,144,47,84,159,137,156,91,6,108,74,13,125,162,220,194,186,169,65,167,19,14,84,197,94,208,105,73,33,240,100,30,142,67,5,194,108,50,230,199,31,3,163,243,202,240,176,91,198,208,113,133,168,6,84,231,14,187,12,201,220,150,44,69,55,220,25,39,142,201,253,145,2,63,167,201,200,176,209,160,240,217,4,228,166,148,34,237,100,120,83,210,57,152,204,64,117,215,56,123,226,200,181,139,146,180,69,118,230,103,250,27,103,33,229,171,173,131,214,255,162,38,196,230,133,204,170,218,52,222,88,55,235,162,112,183,216,161,62,127,101,249,135,33,173,232,214,146,0,118,119,45,39,10,168,1,103,61,174,50,120,7,111,186,57,143,80,148,26,53,66,152,254,112,253,181,112,189,75,165,199,9,251,79,61,108,203,29,30,4,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,41,84,115,85,43,5,165,38,166,4,231,231,166,134,228,23,4,165,38,231,23,165,20,43,233,40,4,36,166,167,234,97,202,184,166,100,150,212,234,0,53,249,149,230,38,165,22,249,167,161,233,64,19,6,43,231,170,181,6,0,49,133,206,254,170,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,140,65,11,130,64,16,70,207,5,253,135,197,211,10,50,212,181,136,8,49,240,98,17,70,231,45,39,89,88,119,100,118,194,66,252,239,161,212,173,203,7,31,188,247,180,46,145,217,4,122,8,92,114,184,226,45,37,47,76,46,192,201,212,24,143,3,251,208,78,7,82,211,138,37,175,182,42,8,91,95,67,30,138,167,115,71,206,154,86,222,122,130,75,43,14,179,202,10,148,248,146,120,49,159,237,126,244,129,184,49,162,163,126,57,40,221,175,134,56,74,212,213,250,138,186,111,56,81,5,118,103,188,19,87,163,184,86,127,138,155,15,206,159,102,151,179,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d45b0fd-ec7e-4bc9-9179-d214e53b6bd0"),
				Name = "InitializeFilterEdit",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,110,131,64,12,69,215,65,226,14,163,172,96,67,14,16,101,145,166,67,212,69,171,10,78,224,50,134,88,26,102,34,143,167,106,90,245,238,5,22,33,34,85,118,150,252,223,255,246,215,78,72,46,207,32,80,251,200,13,42,51,143,59,245,14,29,22,122,33,217,166,201,39,176,106,201,10,178,54,36,71,246,241,60,168,103,180,40,201,153,114,18,132,105,251,116,121,131,30,179,117,121,133,214,249,224,67,173,202,238,124,118,202,69,107,115,245,147,38,171,135,33,7,70,16,188,141,185,11,88,221,202,35,51,58,169,133,99,35,145,199,35,39,178,216,27,179,188,98,100,127,211,100,250,127,182,44,246,93,199,216,129,144,119,218,193,135,29,59,106,193,134,177,147,165,246,37,84,212,157,68,127,157,25,67,24,136,186,57,97,15,215,248,97,97,61,35,87,222,203,171,55,143,173,14,222,198,222,133,127,152,193,110,68,54,155,37,84,33,57,18,2,75,223,152,205,53,228,219,63,216,30,4,188,243,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyDisplayPathByServerMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("68e7af8d-423a-42e5-ba94-28bf2a52ebd4"),
				Name = "GetPropertyDisplayPathByServerMetaPath",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("75aca7e7-4ad4-409c-9cf6-e4e4cce73d72"),
				Name = "serverMetaPath",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,239,126,69,142,41,132,254,128,120,81,177,167,74,64,252,128,37,29,218,30,186,41,155,109,165,127,111,60,20,13,222,118,152,153,125,227,37,6,164,244,8,3,38,50,115,161,78,230,54,114,119,69,26,123,70,231,127,61,91,29,15,43,137,233,193,16,210,40,57,204,120,153,34,212,236,166,125,38,200,37,50,35,232,24,217,149,156,186,40,181,196,212,67,234,59,77,72,51,5,100,146,64,23,225,47,172,110,160,185,52,67,116,243,164,195,121,107,161,244,185,236,223,8,79,146,63,41,196,22,208,202,153,188,105,133,236,77,103,84,150,12,123,3,108,176,144,21,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyServerMetaPathByClientMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d690038a-12c3-42fe-a615-30f466b1f4bb"),
				Name = "GetPropertyServerMetaPathByClientMetaPath",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("52c4af31-0777-41cf-9df8-8c9bbd31c501"),
				Name = "clientMetaPath",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,10,195,48,16,68,251,156,66,165,12,70,23,48,174,18,226,202,65,16,114,128,69,30,100,65,188,50,171,117,114,125,187,201,71,229,240,102,230,121,201,1,165,220,195,140,133,204,90,165,222,92,19,79,23,148,20,25,147,255,103,182,233,78,47,18,19,193,16,210,44,71,153,241,54,85,105,248,64,251,40,144,115,102,70,208,148,185,173,61,174,26,141,196,20,33,238,70,11,202,74,1,135,73,160,155,240,79,230,6,232,8,37,79,58,219,234,171,53,225,153,192,95,218,116,59,151,52,170,164,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitFunctionListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6debffd1-ea7b-43bf-9825-1101238f51ea"),
				Name = "InitFunctionList",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,177,106,195,48,16,134,103,235,41,142,76,18,20,209,221,120,48,169,91,2,29,66,28,178,148,14,66,62,43,42,182,228,202,167,54,105,201,187,87,118,9,45,196,235,175,251,191,251,116,182,5,94,157,72,110,198,242,77,157,118,248,30,113,36,1,223,44,11,72,49,184,156,93,88,235,3,42,125,4,94,26,19,208,40,178,222,237,207,3,214,20,172,38,176,132,61,88,7,149,139,189,124,66,58,168,46,65,56,165,9,223,46,119,132,152,87,216,180,124,110,23,5,44,206,201,181,143,238,87,39,211,222,145,117,17,115,150,93,88,182,85,6,229,99,116,250,90,168,26,75,178,108,154,77,226,113,206,109,170,77,104,33,247,126,98,57,195,197,221,172,154,130,103,175,85,103,191,176,185,190,136,233,155,31,42,192,16,252,128,129,206,15,138,84,237,99,208,8,5,108,111,67,53,194,193,6,138,170,251,11,115,182,44,85,99,135,154,102,175,91,188,220,249,207,241,229,254,117,58,220,218,119,177,119,243,249,248,234,63,102,149,4,127,0,80,127,166,83,169,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitTreeGridRecordSortingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f941e711-33e5-4673-a7f4-825a2096709a"),
				Name = "InitTreeGridRecordSorting",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,81,111,218,48,16,126,38,191,194,235,67,27,84,228,182,219,91,41,147,58,160,21,82,181,161,66,251,130,120,112,157,11,88,11,54,178,157,77,180,202,127,223,217,14,52,129,140,245,105,145,80,130,125,247,221,221,247,157,207,67,105,133,221,76,248,18,86,140,152,240,234,145,49,91,0,29,250,173,1,179,108,162,114,205,129,6,171,110,36,82,18,111,77,123,68,230,89,214,38,111,81,75,131,205,181,236,70,69,244,139,105,98,172,206,57,46,192,95,225,250,185,214,32,237,100,107,216,141,118,62,180,175,178,124,37,13,237,103,192,116,220,238,122,200,53,211,108,5,22,180,65,204,1,164,44,207,236,51,203,114,48,132,25,50,16,220,10,37,153,222,220,32,142,144,139,14,25,107,197,193,152,144,247,120,235,237,93,190,134,50,42,144,159,66,41,228,244,180,18,104,118,242,67,39,160,71,50,85,39,243,15,152,80,15,190,53,244,180,132,100,102,115,162,156,153,75,253,168,47,157,172,51,97,99,9,191,9,95,50,141,126,111,103,157,179,2,41,104,165,74,147,88,72,75,68,239,178,75,4,185,41,33,233,3,200,133,93,226,210,249,185,15,185,23,19,67,6,195,153,152,55,193,95,7,248,150,35,196,27,150,128,174,140,47,1,176,197,21,202,39,115,112,118,5,254,156,30,137,48,235,140,109,130,86,24,36,244,196,78,187,59,33,147,111,155,239,88,106,64,157,93,206,119,97,246,92,43,116,53,135,226,187,24,239,45,162,129,89,8,8,101,59,118,234,41,209,167,81,66,167,106,226,201,136,219,62,120,0,162,158,246,129,208,224,123,6,113,227,250,74,123,40,243,21,197,150,49,16,219,205,26,84,186,111,208,9,156,206,174,230,7,184,99,101,68,9,139,106,149,40,193,250,115,176,126,175,226,54,73,202,18,2,130,219,46,162,130,64,102,192,209,113,132,231,177,22,43,236,246,65,117,23,189,255,65,47,54,17,48,190,36,113,133,86,33,247,180,43,149,112,80,101,97,79,6,207,240,20,153,112,104,195,202,208,8,30,187,109,122,15,18,52,219,106,217,218,207,157,111,211,196,231,5,51,249,233,63,139,32,117,209,148,125,245,44,253,159,94,168,47,208,91,195,65,38,232,118,68,231,171,15,169,26,166,88,144,173,223,80,197,225,193,169,75,93,150,226,118,218,229,252,170,131,85,168,58,18,166,137,172,198,64,135,156,53,149,88,139,212,118,243,191,182,66,71,230,89,24,241,146,185,155,32,101,216,215,221,104,36,145,56,150,137,87,184,19,25,14,194,97,130,51,9,93,155,47,138,7,197,146,221,45,17,99,3,115,184,38,248,223,145,112,113,225,125,166,26,224,94,139,228,17,56,30,180,137,210,56,65,22,244,17,82,13,102,233,160,16,253,15,195,1,51,216,235,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitAggregationColumnNamesListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5c5a269b-8db5-4801-ad62-8c1dac441e95"),
				Name = "InitAggregationColumnNamesList",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,148,93,111,218,48,20,134,175,147,95,97,114,81,37,42,178,216,117,70,37,6,108,234,13,67,165,234,77,213,11,43,57,9,214,18,27,249,131,9,173,252,247,249,35,30,201,8,85,37,36,132,121,125,252,156,247,61,246,150,212,128,191,107,86,40,202,217,146,55,186,101,235,146,42,188,108,128,136,71,5,173,76,179,60,222,126,164,122,33,141,6,171,90,51,69,213,105,87,236,161,37,72,250,175,57,114,123,253,95,43,162,200,142,107,81,0,246,170,60,166,21,74,131,116,142,152,110,154,12,253,137,35,1,74,11,150,199,103,39,152,184,26,79,164,164,252,155,86,138,179,128,130,151,123,40,126,65,249,223,30,169,4,101,53,58,90,48,67,144,124,73,242,248,72,4,58,8,126,0,209,231,176,124,215,139,68,162,23,42,148,38,205,101,177,67,117,149,241,163,220,24,210,159,98,221,30,212,41,29,184,243,124,58,128,243,102,7,13,20,10,74,107,34,118,30,101,14,211,150,185,6,193,79,252,183,196,75,174,153,66,15,104,230,148,81,104,160,59,54,187,177,237,117,246,134,127,128,242,185,248,52,146,62,78,98,178,137,162,155,248,238,148,12,189,191,7,195,140,99,179,196,19,68,3,15,163,232,28,219,207,71,13,219,118,187,146,38,10,4,141,4,91,41,212,249,172,87,54,198,69,93,11,168,73,80,238,12,124,161,80,213,219,108,189,25,85,101,107,166,91,188,37,66,66,170,204,42,175,110,232,166,40,176,82,227,60,181,3,239,67,152,163,89,30,87,92,0,41,246,40,181,211,83,56,127,17,101,221,108,99,111,184,204,124,127,2,149,38,22,7,223,161,249,13,120,213,95,206,253,0,76,210,161,152,74,180,209,45,24,164,129,58,67,119,119,104,68,107,68,240,76,91,24,138,125,100,5,55,119,141,89,7,109,84,246,176,116,104,217,28,141,90,129,23,199,218,14,193,231,196,59,221,102,118,62,198,249,70,123,25,195,187,245,176,44,74,55,11,105,103,225,134,180,48,13,126,46,201,193,170,237,80,95,242,186,191,15,143,69,47,195,112,145,92,56,80,57,20,105,130,89,65,69,116,163,186,223,230,182,175,168,3,32,226,244,213,95,145,169,125,22,10,144,210,191,83,102,144,12,129,2,255,214,61,116,33,94,74,78,122,79,215,205,158,174,135,220,160,252,171,241,154,244,140,246,187,108,215,201,91,184,15,198,174,243,95,48,65,133,108,174,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetUserTaskParameterConstValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3b5aff2f-2c00-471c-8209-4ab49dc454af"),
				Name = "SetUserTaskParameterConstValue",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0cf2678e-1d3d-48f3-93de-b266db3b9d8d"),
				Name = "parameterName",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36cf584c-4452-4ac4-b634-ea3abb417564"),
				Name = "value",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b97cf5f4-5995-40c5-8451-77f65ecdedf0"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,106,195,48,12,62,207,79,161,99,2,37,15,208,172,27,99,237,33,148,117,133,178,93,198,14,38,86,55,129,99,7,203,233,8,99,239,62,39,161,109,126,186,194,78,198,210,247,103,75,180,135,104,43,157,44,208,163,227,87,169,43,132,197,2,76,165,117,12,223,226,102,210,3,131,95,176,164,220,147,53,210,213,183,236,29,153,143,25,108,157,205,145,121,151,127,98,33,79,172,150,116,23,197,169,248,17,7,233,160,156,200,141,13,36,255,87,61,21,87,186,103,199,126,254,43,132,38,235,144,147,60,89,69,123,66,149,153,142,240,146,169,160,179,82,228,79,247,9,103,103,43,151,183,239,251,219,170,195,36,143,214,176,111,11,19,149,99,230,195,197,238,146,184,212,178,62,130,186,191,74,50,222,132,225,61,187,85,81,250,58,82,61,76,12,247,157,18,204,161,95,79,5,133,45,24,141,166,137,229,37,25,94,99,125,238,109,194,17,183,139,49,130,191,13,32,239,33,206,48,108,88,0,64,205,120,129,154,60,40,53,116,152,141,200,205,250,252,2,42,17,143,189,169,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEnabledNumberOfRecordsControlLayoutMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb013aef-264e-4772-b1d9-c15389f4d752"),
				Name = "SetEnabledNumberOfRecordsControlLayout",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("11455e29-80f8-4392-85f2-421390ae9327"),
				Name = "enabled",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,43,205,77,74,45,242,79,11,74,77,206,47,74,41,118,206,207,43,41,202,207,241,73,172,204,47,45,209,11,78,45,113,205,75,76,202,73,77,209,72,133,208,58,10,37,69,165,169,154,214,188,92,153,105,10,48,65,77,133,106,94,46,206,0,44,198,185,166,100,162,152,2,86,19,148,154,152,18,156,159,155,26,146,95,128,172,204,57,35,53,57,27,104,24,208,236,90,0,144,125,206,255,155,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearDataSourceFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cbc1af9e-9fe1-4460-8617-415b0c005e74"),
				Name = "ClearDataSourceFilters",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,116,73,44,73,12,206,47,45,74,78,85,72,65,48,109,21,2,18,211,83,245,92,209,148,88,115,149,37,22,41,164,101,230,148,164,22,185,166,100,150,184,23,229,151,22,0,21,35,116,234,185,101,230,165,184,129,21,20,131,101,157,42,253,18,115,83,53,148,220,224,154,148,52,173,185,50,211,20,52,208,141,81,180,85,200,43,205,201,209,84,168,230,226,68,147,211,115,206,73,77,44,210,0,106,172,5,0,141,20,76,106,182,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityCollectionDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2d8b890c-bc80-4ec9-b060-20d33d6b59de"),
				Name = "GetEntityCollectionDisplayValue",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dcdd69ee-b3ff-45de-881e-a67a6523d6df"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24974cfc-ed81-4924-a9c1-655dadaf55dc"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				ModifiedInSchemaUId = new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,177,10,194,48,20,69,231,230,43,50,38,75,127,160,184,20,107,233,162,5,209,253,209,92,219,64,18,75,222,11,82,196,127,119,113,176,227,133,115,14,215,63,180,97,201,62,205,245,192,231,18,194,37,119,113,149,205,56,207,107,160,237,78,161,192,90,253,86,213,152,159,19,152,175,211,130,72,122,221,173,131,62,249,228,142,96,63,39,184,29,105,108,163,170,12,41,57,237,165,186,135,180,196,232,2,34,146,180,219,109,112,38,225,165,251,226,157,137,16,26,73,22,107,235,51,69,52,234,163,126,145,255,103,205,23,41,136,78,101,192,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReadEntityCollectionItemsUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc17b6cb-94ae-4a6f-b226-3bc38abb3a9b"));
		}

		#endregion

	}

	#endregion

}

