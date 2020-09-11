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

	#region Class: AddDataToEntityCollectionUserTaskParametersEditPageSchema

	/// <exclude/>
	public class AddDataToEntityCollectionUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
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

		private Terrasoft.UI.WebControls.Controls.RadioButton _addOneRecordRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton AddOneRecordRadioButton {
			get {
				return _addOneRecordRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _addSamplingRecordsRadioButton;
		public Terrasoft.UI.WebControls.Controls.RadioButton AddSamplingRecordsRadioButton {
			get {
				return _addSamplingRecordsRadioButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _samplingEntityCollectionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit SamplingEntityCollectionTextEdit {
			get {
				return _samplingEntityCollectionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _samplingEntityCollectionEditToolButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton SamplingEntityCollectionEditToolButton {
			get {
				return _samplingEntityCollectionEditToolButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _filterLabel;
		public Terrasoft.UI.WebControls.Controls.Label FilterLabel {
			get {
				return _filterLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addButton;
		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return _addButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _editValueButton;
		public Terrasoft.UI.WebControls.Controls.Button EditValueButton {
			get {
				return _editValueButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return _deleteButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _columnValuesTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid ColumnValuesTreeGrid {
			get {
				return _columnValuesTreeGrid;
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

		public AddDataToEntityCollectionUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AddDataToEntityCollectionUserTaskParametersEditPageSchema(AddDataToEntityCollectionUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			RealUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			Name = "AddDataToEntityCollectionUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 550;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema();
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
			ControlLayout1.InsertItem(2, CreateAddOneRecordRadioButton());
			ControlLayout1.InsertItem(3, CreateAddSamplingRecordsRadioButton());
			TopControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateSamplingEntityCollectionTextEdit());
			SamplingEntityCollectionTextEdit.InsertItem(0, CreateSamplingEntityCollectionEditToolButton());
			ControlLayout2.InsertItem(1, CreateFilterLabel());
			ControlLayout2.InsertItem(2, CreateFilterEdit());
			TopControlLayout.InsertItem(2, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateAddButton());
			ControlLayout3.InsertItem(1, CreateEditValueButton());
			ControlLayout3.InsertItem(2, CreateDeleteButton());
			TopControlLayout.InsertItem(3, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateColumnValuesTreeGrid());
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

		protected virtual EmbeddedProcessSchema CreateAddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleEdit() {
			_titleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleEdit.UId = new Guid("87d03716-ef51-4946-a8ba-fbbd4b7b9aa7");
			_titleEdit.Name = "TitleEdit";
			_titleEdit.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_titleEdit.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_titleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_titleEdit.Tag = "";
			_titleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_titleEdit.Image = new ControlImage {};
			_titleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_titleEdit.Required = true;
			return _titleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateEntityCollectionEditToolButton() {
			_entityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_entityCollectionEditToolButton.UId = new Guid("726dac9a-f930-4b12-92b2-e3e9a24823b6");
			_entityCollectionEditToolButton.Name = "EntityCollectionEditToolButton";
			_entityCollectionEditToolButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_entityCollectionEditToolButton.Tag = "";
			_entityCollectionEditToolButton.Image = new ControlImage {};
			return _entityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateEntityCollectionTextEdit() {
			_entityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_entityCollectionTextEdit.UId = new Guid("5ff8cbae-7f00-4307-9aa3-5e552e7c1d38");
			_entityCollectionTextEdit.Name = "EntityCollectionTextEdit";
			_entityCollectionTextEdit.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityCollectionTextEdit.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityCollectionTextEdit.Tag = "";
			_entityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entityCollectionTextEdit.Image = new ControlImage {};
			_entityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entityCollectionTextEdit.Required = true;
			return _entityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAddOneRecordRadioButton() {
			_addOneRecordRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_addOneRecordRadioButton.UId = new Guid("379176d9-ae04-40d1-adb9-0ff795662925");
			_addOneRecordRadioButton.Name = "AddOneRecordRadioButton";
			_addOneRecordRadioButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_addOneRecordRadioButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_addOneRecordRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addOneRecordRadioButton.Tag = "";
			_addOneRecordRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addOneRecordRadioButton.AlignedByCaption = false;
			_addOneRecordRadioButton.GroupName = "AddDataMode";
			return _addOneRecordRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAddSamplingRecordsRadioButton() {
			_addSamplingRecordsRadioButton = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_addSamplingRecordsRadioButton.UId = new Guid("62f52e52-d13c-4848-9b9b-3e0cdc4ddfb7");
			_addSamplingRecordsRadioButton.Name = "AddSamplingRecordsRadioButton";
			_addSamplingRecordsRadioButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_addSamplingRecordsRadioButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_addSamplingRecordsRadioButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addSamplingRecordsRadioButton.AjaxEvents.Check.IsProcessEventHandler = true;
			_addSamplingRecordsRadioButton.Tag = "";
			_addSamplingRecordsRadioButton.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addSamplingRecordsRadioButton.AlignedByCaption = false;
			_addSamplingRecordsRadioButton.GroupName = "AddDataMode";
			return _addSamplingRecordsRadioButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("80c7e3cc-431d-4a08-a238-266639ff508a");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout1.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
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

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateSamplingEntityCollectionEditToolButton() {
			_samplingEntityCollectionEditToolButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_samplingEntityCollectionEditToolButton.UId = new Guid("82c607a7-13e2-4e1f-81f0-87f4bd9b7f46");
			_samplingEntityCollectionEditToolButton.Name = "SamplingEntityCollectionEditToolButton";
			_samplingEntityCollectionEditToolButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_samplingEntityCollectionEditToolButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_samplingEntityCollectionEditToolButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingEntityCollectionEditToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_samplingEntityCollectionEditToolButton.Tag = "";
			_samplingEntityCollectionEditToolButton.Image = new ControlImage {};
			return _samplingEntityCollectionEditToolButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateSamplingEntityCollectionTextEdit() {
			_samplingEntityCollectionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_samplingEntityCollectionTextEdit.UId = new Guid("3f66a653-cf03-4aea-9bda-b18b4ee0219f");
			_samplingEntityCollectionTextEdit.Name = "SamplingEntityCollectionTextEdit";
			_samplingEntityCollectionTextEdit.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_samplingEntityCollectionTextEdit.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_samplingEntityCollectionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_samplingEntityCollectionTextEdit.Tag = "";
			_samplingEntityCollectionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_samplingEntityCollectionTextEdit.Image = new ControlImage {};
			_samplingEntityCollectionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _samplingEntityCollectionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateFilterLabel() {
			_filterLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_filterLabel.UId = new Guid("864fb485-9a23-47ae-bab6-140dbb1df43e");
			_filterLabel.Name = "FilterLabel";
			_filterLabel.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_filterLabel.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_filterLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterLabel.Tag = "";
			_filterLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_filterLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("cec8e72a-9a17-48e7-a2b4-297c4656dacd");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_filterEdit.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("c594a243-7b4f-4763-9c7f-d1c1327d8cde");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout2.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.Padding = "0 0 0 18";
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("892dca30-8fa2-4795-a3b8-f23deb6310f5");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_addButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditValueButton() {
			_editValueButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editValueButton.UId = new Guid("7982aac2-960b-4a02-9bad-bba795d9ca8a");
			_editValueButton.Name = "EditValueButton";
			_editValueButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_editValueButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_editValueButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editValueButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_editValueButton.Tag = "";
			_editValueButton.Image = new ControlImage {};
			return _editValueButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("9b8c600c-60f1-48d4-bbc3-1ac1a63aece8");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_deleteButton.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_deleteButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_deleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("3f0a3498-9fb1-44d3-8271-f392f52a1aea");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout3.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.Padding = "0 0 0 18";
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateColumnValuesTreeGrid() {
			_columnValuesTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_columnValuesTreeGrid.UId = new Guid("ba559a1d-8f95-4fed-a26d-5e4cc5745857");
			_columnValuesTreeGrid.Name = "ColumnValuesTreeGrid";
			_columnValuesTreeGrid.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_columnValuesTreeGrid.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_columnValuesTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnValuesTreeGrid.Tag = "";
			_columnValuesTreeGrid.Edges = "1 1 1 1";
			_columnValuesTreeGrid.IsColumnAutowidth = true;
			_columnValuesTreeGrid.FooterVisible = false;
			_columnValuesTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnValuesTreeGrid.IsSummaryVisible = false;
			_columnValuesTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnValuesTreeGrid.ToolbarVisible = false;
			_columnValuesTreeGrid.QuickFilterVisible = false;
			_columnValuesTreeGrid.HideHeaders = false;
			_columnValuesTreeGrid.HasSplitter = true;
			return _columnValuesTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("7bcbd914-8d83-44dc-8e4d-7a473e81b55c");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout4.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.Padding = "0 0 0 18";
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("dec30c4d-d241-4e45-bc42-ebaa0b19f910");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityDataSource.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("13ced04f-86b6-4338-a8e9-448cda695ff6");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
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
			return new AddDataToEntityCollectionUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AddDataToEntityCollectionUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AddDataToEntityCollectionUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeEntityCollectionUserMessageFlowElement

		/// <exclude/>
		public class ChangeEntityCollectionUserMessageFlowElement : QuestionUserTask
		{

			public ChangeEntityCollectionUserMessageFlowElement(UserConnection userConnection, AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeEntityCollectionUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ChangeAddModeUserTaskFlowElement

		/// <exclude/>
		public class ChangeAddModeUserTaskFlowElement : QuestionUserTask
		{

			public ChangeAddModeUserTaskFlowElement(UserConnection userConnection, AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAddModeUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: DeleteColumnQuestion_UserTaskFlowElement

		/// <exclude/>
		public class DeleteColumnQuestion_UserTaskFlowElement : QuestionUserTask
		{

			public DeleteColumnQuestion_UserTaskFlowElement(UserConnection userConnection, AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DeleteColumnQuestion_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenEditColumnValuePage_UserTaskFlowElement

		/// <exclude/>
		public class OpenEditColumnValuePage_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenEditColumnValuePage_UserTaskFlowElement(UserConnection userConnection, AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditColumnValuePage_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenColumnValuePage_UserTaskFlowElement

		/// <exclude/>
		public class OpenColumnValuePage_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenColumnValuePage_UserTaskFlowElement(UserConnection userConnection, AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenColumnValuePage_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
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

		public virtual string EntityCollectionDisplayValue {
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

		public virtual string NewUserDefinedEntityCollectionParameterValue {
			get;
			set;
		}

		public virtual bool IsNewSamplingEntityCollection {
			get;
			set;
		}

		public virtual Guid SamplingEntityCollectionSchemaUId {
			get;
			set;
		}

		public virtual string SamplingEntityCollectionMetaPath {
			get;
			set;
		}

		public virtual string SamplingEntityCollectionDisplayValue {
			get;
			set;
		}

		public virtual bool IsEditingSamplingEntityCollection {
			get;
			set;
		}

		public virtual string NewEntityCollectionParameterValue {
			get;
			set;
		}

		public virtual string ColumnValuesContextKey {
			get;
			set;
		}

		public virtual string InsertedColumnValueKey {
			get;
			set;
		}

		public virtual bool IsSelectedSamplingAddMode {
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
					SchemaElementUId = new Guid("7ea0ac05-e134-4fce-99d2-ab529cf99cbb"),
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
					SchemaElementUId = new Guid("a6f1bd64-41df-409b-8744-d602546f5eb0"),
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
					SchemaElementUId = new Guid("beb7ac45-c97a-4fd1-b230-a49e66ef36bc"),
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
					SchemaElementUId = new Guid("9dfe73a0-3012-4cca-8f8f-42e10defbe12"),
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
					SchemaElementUId = new Guid("eabde8b3-98d9-48f6-bec6-1f07256af1f3"),
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
					SchemaElementUId = new Guid("d538ec58-680b-4d47-8f08-9bf063455a71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("66903d77-49c7-4476-880e-699300365782"),
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
					SchemaElementUId = new Guid("812a8c25-1e13-4f25-9d5d-dcf59b93b499"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptExecute,
				});
			}
		}

		private ProcessScriptTask _addNotNullColumns_ScriptTask;
		public ProcessScriptTask AddNotNullColumns_ScriptTask {
			get {
				return _addNotNullColumns_ScriptTask ?? (_addNotNullColumns_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddNotNullColumns_ScriptTask",
					SchemaElementUId = new Guid("125aa3bc-94fd-46bb-98b1-2fb510b0d36e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddNotNullColumns_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("3229c544-47f9-43c1-aee0-ea95b9e282c7"),
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
					SchemaElementUId = new Guid("c2a0b340-01f2-48c5-b686-5f7c605e04ca"),
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
					SchemaElementUId = new Guid("3078fa48-528b-4de1-b0bd-affc166895c8"),
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
					SchemaElementUId = new Guid("32f449e1-1d24-440b-b590-9d9ef1ad3229"),
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
					SchemaElementUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
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
					SchemaElementUId = new Guid("cbb7a67d-7f49-4f4c-b835-66a4eb36d4c8"),
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
					SchemaElementUId = new Guid("add336fe-4405-4dd4-b844-4e2a47b3726c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NewEntityCollectionParameterValueScriptTaskExecute,
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
					SchemaElementUId = new Guid("ead69206-954b-488e-8043-70bc1f41a8fa"),
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

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("a34bd0ab-e228-4664-8b53-e90b124fdc9d"),
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

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("b8a4a5e2-a52f-4dc7-9fee-e40b7065f4b8"),
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
					SchemaElementUId = new Guid("fbe9ecf9-94e5-48fb-89c9-9fa341fc5202"),
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
					SchemaElementUId = new Guid("c112a537-8043-4dda-806e-db5115f32dc5"),
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
					SchemaElementUId = new Guid("2eb442c0-dbff-417a-ac72-3264ed60beef"),
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
					SchemaElementUId = new Guid("a4cf6e68-db03-4cba-89d7-b09254fa5abe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("4945cbf7-719e-47e2-b001-f8db768ce20d"),
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
					SchemaElementUId = new Guid("24b3eb9b-edf2-4808-ad8e-2ec7e1a5ed0f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeEntityCollectionNoMessageScriptExecute,
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
					SchemaElementUId = new Guid("3f2033cf-80c4-4ed1-bfc5-fdfadeae37b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entityCollectionEditToolButtonClickMessage;
		public ProcessFlowElement EntityCollectionEditToolButtonClickMessage {
			get {
				return _entityCollectionEditToolButtonClickMessage ?? (_entityCollectionEditToolButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntityCollectionEditToolButtonClickMessage",
					SchemaElementUId = new Guid("dbb75089-e32b-4793-ace6-61425cbe3160"),
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
					SchemaElementUId = new Guid("63630b3a-781f-4567-adb5-64528bc940de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EntityCollectionEditToolButtonClickScriptExecute,
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
					SchemaElementUId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addSamplingRecordsRadioButtonCheckMessage;
		public ProcessFlowElement AddSamplingRecordsRadioButtonCheckMessage {
			get {
				return _addSamplingRecordsRadioButtonCheckMessage ?? (_addSamplingRecordsRadioButtonCheckMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddSamplingRecordsRadioButtonCheckMessage",
					SchemaElementUId = new Guid("664cccca-bfee-499f-aae6-d24181a00195"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addSamplingRecordsRadioButtonCheckScript;
		public ProcessScriptTask AddSamplingRecordsRadioButtonCheckScript {
			get {
				return _addSamplingRecordsRadioButtonCheckScript ?? (_addSamplingRecordsRadioButtonCheckScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddSamplingRecordsRadioButtonCheckScript",
					SchemaElementUId = new Guid("658db6c9-757b-4b36-92f0-4865c5acc544"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddSamplingRecordsRadioButtonCheckScriptExecute,
				});
			}
		}

		private ChangeAddModeUserTaskFlowElement _changeAddModeUserTask;
		public ChangeAddModeUserTaskFlowElement ChangeAddModeUserTask {
			get {
				return _changeAddModeUserTask ?? (_changeAddModeUserTask = new ChangeAddModeUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("193ab86d-c35f-4554-8619-ace47d42c7a8"),
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

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("7cbde5ef-d099-45ee-afec-08bf056b367a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeAddModeYesMessage",
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
					SchemaElementUId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClickMessage;
		public ProcessFlowElement DeleteButtonClickMessage {
			get {
				return _deleteButtonClickMessage ?? (_deleteButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClickMessage",
					SchemaElementUId = new Guid("f0fd6322-7fcb-45af-845d-6fcbc3a828c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteButtonClickScriptTask;
		public ProcessScriptTask DeleteButtonClickScriptTask {
			get {
				return _deleteButtonClickScriptTask ?? (_deleteButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteButtonClickScriptTask",
					SchemaElementUId = new Guid("bd92dae0-a3aa-4f58-8843-842fae7d8a19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteButtonClickScriptTaskExecute,
				});
			}
		}

		private DeleteColumnQuestion_UserTaskFlowElement _deleteColumnQuestion_UserTask;
		public DeleteColumnQuestion_UserTaskFlowElement DeleteColumnQuestion_UserTask {
			get {
				return _deleteColumnQuestion_UserTask ?? (_deleteColumnQuestion_UserTask = new DeleteColumnQuestion_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("58653b18-7e26-4e68-9cd3-643748fad3a9"),
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

		private ProcessScriptTask _breakDelete_ScriptTask;
		public ProcessScriptTask BreakDelete_ScriptTask {
			get {
				return _breakDelete_ScriptTask ?? (_breakDelete_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BreakDelete_ScriptTask",
					SchemaElementUId = new Guid("d521d6ea-acc8-4a87-935d-c76007771f57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BreakDelete_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("c0ce10c7-ec89-4570-bf65-9be0f02a5d92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editValueButtonClickMessage;
		public ProcessFlowElement EditValueButtonClickMessage {
			get {
				return _editValueButtonClickMessage ?? (_editValueButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditValueButtonClickMessage",
					SchemaElementUId = new Guid("56a02fb8-13f2-4d9b-8601-82f7db8cab05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _editValueButtonClickScriptTask;
		public ProcessScriptTask EditValueButtonClickScriptTask {
			get {
				return _editValueButtonClickScriptTask ?? (_editValueButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EditValueButtonClickScriptTask",
					SchemaElementUId = new Guid("befa76ec-02b8-4516-a55d-0a5cc71ed348"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EditValueButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenEditColumnValuePage_UserTaskFlowElement _openEditColumnValuePage_UserTask;
		public OpenEditColumnValuePage_UserTaskFlowElement OpenEditColumnValuePage_UserTask {
			get {
				return _openEditColumnValuePage_UserTask ?? (_openEditColumnValuePage_UserTask = new OpenEditColumnValuePage_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("82309a82-ac22-4a3f-a10b-2c5c76c7d875"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickMessage;
		public ProcessFlowElement AddButtonClickMessage {
			get {
				return _addButtonClickMessage ?? (_addButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickMessage",
					SchemaElementUId = new Guid("b76156a7-072e-4796-8ee5-ed1f3c515210"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addButtonClickScriptTask;
		public ProcessScriptTask AddButtonClickScriptTask {
			get {
				return _addButtonClickScriptTask ?? (_addButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddButtonClickScriptTask",
					SchemaElementUId = new Guid("a0e3897a-18f1-47c0-9be5-0c287c204360"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenColumnValuePage_UserTaskFlowElement _openColumnValuePage_UserTask;
		public OpenColumnValuePage_UserTaskFlowElement OpenColumnValuePage_UserTask {
			get {
				return _openColumnValuePage_UserTask ?? (_openColumnValuePage_UserTask = new OpenColumnValuePage_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("6cfbee65-14c3-4759-ac3b-1298cb73eaa9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _samplingEntityCollectionEditToolButtonClickMessage;
		public ProcessFlowElement SamplingEntityCollectionEditToolButtonClickMessage {
			get {
				return _samplingEntityCollectionEditToolButtonClickMessage ?? (_samplingEntityCollectionEditToolButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SamplingEntityCollectionEditToolButtonClickMessage",
					SchemaElementUId = new Guid("233d2354-0acf-4420-a592-80a1b302c7c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _samplingEntityCollectionEditToolButtonClickScript;
		public ProcessScriptTask SamplingEntityCollectionEditToolButtonClickScript {
			get {
				return _samplingEntityCollectionEditToolButtonClickScript ?? (_samplingEntityCollectionEditToolButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SamplingEntityCollectionEditToolButtonClickScript",
					SchemaElementUId = new Guid("943b1cfe-1767-4270-9d82-fd70ce238bdf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SamplingEntityCollectionEditToolButtonClickScriptExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("f7b751e6-1286-4eb7-ab66-e03560c68ef0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValueEditPageClosedMessage;
		public ProcessFlowElement ColumnValueEditPageClosedMessage {
			get {
				return _columnValueEditPageClosedMessage ?? (_columnValueEditPageClosedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValueEditPageClosedMessage",
					SchemaElementUId = new Guid("d9ee863f-c591-4d9c-8559-c50694b46f98"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _columnValueEditPageClosedScript;
		public ProcessScriptTask ColumnValueEditPageClosedScript {
			get {
				return _columnValueEditPageClosedScript ?? (_columnValueEditPageClosedScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ColumnValueEditPageClosedScript",
					SchemaElementUId = new Guid("4b31c581-d91b-49dd-b5d9-0baf9c9cc23b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnValueEditPageClosedScriptExecute,
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
					SchemaElementUId = new Guid("924edebf-db4d-4552-a4d5-9281d9042f99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValuesTreeGridDblClick_StartMessage;
		public ProcessFlowElement ColumnValuesTreeGridDblClick_StartMessage {
			get {
				return _columnValuesTreeGridDblClick_StartMessage ?? (_columnValuesTreeGridDblClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValuesTreeGridDblClick_StartMessage",
					SchemaElementUId = new Guid("e5ec48ff-5bed-476c-ab2d-2253976515a6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _columnValuesTreeGridDblClick;
		public ProcessThrowMessageEvent ColumnValuesTreeGridDblClick {
			get {
				return _columnValuesTreeGridDblClick ?? (_columnValuesTreeGridDblClick = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ColumnValuesTreeGridDblClick",
					SchemaElementUId = new Guid("e1615ef6-12dc-4caf-89cc-703a30d98877"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditValueButtonClick",
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
					SchemaElementUId = new Guid("13b05f60-c5f5-4a46-8d8e-4f15a514f2d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteColumnYesMessage_StartMessage;
		public ProcessFlowElement DeleteColumnYesMessage_StartMessage {
			get {
				return _deleteColumnYesMessage_StartMessage ?? (_deleteColumnYesMessage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteColumnYesMessage_StartMessage",
					SchemaElementUId = new Guid("eda23f51-74b6-446f-afdb-bfda8c7970f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteColumn_ScriptTask;
		public ProcessScriptTask DeleteColumn_ScriptTask {
			get {
				return _deleteColumn_ScriptTask ?? (_deleteColumn_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteColumn_ScriptTask",
					SchemaElementUId = new Guid("925e9682-6397-47a0-8d06-d80cbc6b309c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteColumn_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess12;
		public ProcessFlowElement EventSubProcess12 {
			get {
				return _eventSubProcess12 ?? (_eventSubProcess12 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess12",
					SchemaElementUId = new Guid("ba8c8335-379a-4528-8a17-e011dae4ec5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeAddModeYesStartMessage;
		public ProcessFlowElement ChangeAddModeYesStartMessage {
			get {
				return _changeAddModeYesStartMessage ?? (_changeAddModeYesStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeAddModeYesStartMessage",
					SchemaElementUId = new Guid("654d0935-beb0-483d-bde1-b6cee71af318"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeAddModeYesMessageScript;
		public ProcessScriptTask ChangeAddModeYesMessageScript {
			get {
				return _changeAddModeYesMessageScript ?? (_changeAddModeYesMessageScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeAddModeYesMessageScript",
					SchemaElementUId = new Guid("a7f7ab66-1070-4f1b-916e-aaaca1d095ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeAddModeYesMessageScriptExecute,
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
					SchemaElementUId = new Guid("5cc2d685-74e4-4cf7-ad1d-f4467f524ff0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeAddModeNoStartMessage;
		public ProcessFlowElement ChangeAddModeNoStartMessage {
			get {
				return _changeAddModeNoStartMessage ?? (_changeAddModeNoStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeAddModeNoStartMessage",
					SchemaElementUId = new Guid("18e7ece9-a5bc-4c95-b0ff-191fdb963d47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("61edf8c7-b36f-4f68-8df8-9b9aa49f1be3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("609fa422-2d3a-48ad-8cef-663b014b027e"),
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
					SchemaElementUId = new Guid("8dfda6f2-1c22-4c01-910a-7c9cbff51d55"),
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
					SchemaElementUId = new Guid("c8b73978-656b-4288-8f3f-ade95849c44b"),
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

		private LocalizableString _valueColumnCaption;
		public LocalizableString ValueColumnCaption {
			get {
				return _valueColumnCaption ?? (_valueColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValueColumnCaption.Value"));
			}
		}

		private LocalizableString _deleteColumnMessage;
		public LocalizableString DeleteColumnMessage {
			get {
				return _deleteColumnMessage ?? (_deleteColumnMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteColumnMessage.Value"));
			}
		}

		private LocalizableString _validationMessageTitle;
		public LocalizableString ValidationMessageTitle {
			get {
				return _validationMessageTitle ?? (_validationMessageTitle = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTitle.Value"));
			}
		}

		private LocalizableString _validationMessageTextNewRow;
		public LocalizableString ValidationMessageTextNewRow {
			get {
				return _validationMessageTextNewRow ?? (_validationMessageTextNewRow = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTextNewRow.Value"));
			}
		}

		private LocalizableString _validationMessageTextFilterParamsEmpty;
		public LocalizableString ValidationMessageTextFilterParamsEmpty {
			get {
				return _validationMessageTextFilterParamsEmpty ?? (_validationMessageTextFilterParamsEmpty = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValidationMessageTextFilterParamsEmpty.Value"));
			}
		}

		private LocalizableString _selectAddModeMessage;
		public LocalizableString SelectAddModeMessage {
			get {
				return _selectAddModeMessage ?? (_selectAddModeMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SelectAddModeMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessOnInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessOnInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[IntermediateThrowMessageEventInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventInit };
			FlowElements[ChildInitScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitScript };
			FlowElements[OnPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPageLoadComplete };
			FlowElements[StartMessagePageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoadComplete };
			FlowElements[IntermediateThrowMessageEventPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventPageLoadComplete };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[AddNotNullColumns_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddNotNullColumns_ScriptTask };
			FlowElements[OkButtonClickChildSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildSubProcess };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[OkButtonClickChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildScript };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[NewEntityCollectionParameterValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NewEntityCollectionParameterValueScriptTask };
			FlowElements[PrepareChangeEntityCollectionQuestionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeEntityCollectionQuestionScript };
			FlowElements[ChangeEntityCollectionUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionUserMessage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcessChangeEntityCollectionYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionYesMessage };
			FlowElements[ChangeEntityCollectionYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageBase };
			FlowElements[ChangeEntityCollectionYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionYesMessageScript };
			FlowElements[EventSubProcessChangeEntityCollectionNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeEntityCollectionNoMessage };
			FlowElements[ChangeEntityCollectionNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageBase };
			FlowElements[ChangeEntityCollectionNoMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeEntityCollectionNoMessageScript };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[EntityCollectionEditToolButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickMessage };
			FlowElements[EntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { EntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[AddSamplingRecordsRadioButtonCheckMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSamplingRecordsRadioButtonCheckMessage };
			FlowElements[AddSamplingRecordsRadioButtonCheckScript.SchemaElementUId] = new Collection<ProcessFlowElement> { AddSamplingRecordsRadioButtonCheckScript };
			FlowElements[ChangeAddModeUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAddModeUserTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[DeleteButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickMessage };
			FlowElements[DeleteButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickScriptTask };
			FlowElements[DeleteColumnQuestion_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteColumnQuestion_UserTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[BreakDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BreakDelete_ScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[EditValueButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EditValueButtonClickMessage };
			FlowElements[EditValueButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EditValueButtonClickScriptTask };
			FlowElements[OpenEditColumnValuePage_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditColumnValuePage_UserTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[AddButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickMessage };
			FlowElements[AddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickScriptTask };
			FlowElements[OpenColumnValuePage_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnValuePage_UserTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[SamplingEntityCollectionEditToolButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SamplingEntityCollectionEditToolButtonClickMessage };
			FlowElements[SamplingEntityCollectionEditToolButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SamplingEntityCollectionEditToolButtonClickScript };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[ColumnValueEditPageClosedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedMessage };
			FlowElements[ColumnValueEditPageClosedScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedScript };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ColumnValuesTreeGridDblClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClick_StartMessage };
			FlowElements[ColumnValuesTreeGridDblClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClick };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DeleteColumnYesMessage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteColumnYesMessage_StartMessage };
			FlowElements[DeleteColumn_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteColumn_ScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[ChangeAddModeYesStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAddModeYesStartMessage };
			FlowElements[ChangeAddModeYesMessageScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAddModeYesMessageScript };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[ChangeAddModeNoStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAddModeNoStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
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
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventPageLoadComplete");
						break;
					case "IntermediateThrowMessageEventPageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
					case "PageLoadCompleteChildScript":
						e.Context.QueueTasks.Enqueue("AddNotNullColumns_ScriptTask");
						break;
					case "AddNotNullColumns_ScriptTask":
						break;
					case "OkButtonClickChildSubProcess":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("OkButtonClickChildScript");
						break;
					case "OkButtonClickChildScript":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess3":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("NewEntityCollectionParameterValueScriptTask");
						break;
					case "NewEntityCollectionParameterValueScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "PrepareChangeEntityCollectionQuestionScript":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionUserMessage");
						break;
					case "ChangeEntityCollectionUserMessage":
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeEntityCollectionQuestionScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
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
					case "ChangeEntityCollectionNoMessageBase":
						e.Context.QueueTasks.Enqueue("ChangeEntityCollectionNoMessageScript");
						break;
					case "ChangeEntityCollectionNoMessageScript":
						break;
					case "EventSubProcess2":
						break;
					case "EntityCollectionEditToolButtonClickMessage":
						e.Context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickScript");
						break;
					case "EntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcess4":
						break;
					case "AddSamplingRecordsRadioButtonCheckMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "AddSamplingRecordsRadioButtonCheckScript":
						e.Context.QueueTasks.Enqueue("ChangeAddModeUserTask");
						break;
					case "ChangeAddModeUserTask":
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("AddSamplingRecordsRadioButtonCheckScript");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "EventSubProcess7":
						break;
					case "DeleteButtonClickMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "DeleteButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("DeleteColumnQuestion_UserTask");
						break;
					case "DeleteColumnQuestion_UserTask":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("DeleteButtonClickScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("BreakDelete_ScriptTask");
						break;
					case "BreakDelete_ScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "EditValueButtonClickMessage":
						e.Context.QueueTasks.Enqueue("EditValueButtonClickScriptTask");
						break;
					case "EditValueButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenEditColumnValuePage_UserTask");
						break;
					case "OpenEditColumnValuePage_UserTask":
						break;
					case "EventSubProcess5":
						break;
					case "AddButtonClickMessage":
						e.Context.QueueTasks.Enqueue("AddButtonClickScriptTask");
						break;
					case "AddButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenColumnValuePage_UserTask");
						break;
					case "OpenColumnValuePage_UserTask":
						break;
					case "EventSubProcess8":
						break;
					case "SamplingEntityCollectionEditToolButtonClickMessage":
						e.Context.QueueTasks.Enqueue("SamplingEntityCollectionEditToolButtonClickScript");
						break;
					case "SamplingEntityCollectionEditToolButtonClickScript":
						break;
					case "EventSubProcess9":
						break;
					case "ColumnValueEditPageClosedMessage":
						e.Context.QueueTasks.Enqueue("ColumnValueEditPageClosedScript");
						break;
					case "ColumnValueEditPageClosedScript":
						break;
					case "EventSubProcess10":
						break;
					case "ColumnValuesTreeGridDblClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ColumnValuesTreeGridDblClick");
						break;
					case "ColumnValuesTreeGridDblClick":
						break;
					case "EventSubProcess11":
						break;
					case "DeleteColumnYesMessage_StartMessage":
						e.Context.QueueTasks.Enqueue("DeleteColumn_ScriptTask");
						break;
					case "DeleteColumn_ScriptTask":
						break;
					case "EventSubProcess12":
						break;
					case "ChangeAddModeYesStartMessage":
						e.Context.QueueTasks.Enqueue("ChangeAddModeYesMessageScript");
						break;
					case "ChangeAddModeYesMessageScript":
						break;
					case "EventSubProcess13":
						break;
					case "ChangeAddModeNoStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsEditingSamplingEntityCollection ? !IsNewSamplingEntityCollection : !IsNew);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(Page.ColumnValuesTreeGrid.SelectedNodes.Count > 0);
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(IsSelectedSamplingAddMode && !Page.AddSamplingRecordsRadioButton.Checked && !IsNewSamplingEntityCollection);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("StartMessagePageLoadComplete");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("ChangeEntityCollectionYesMessageBase");
			ActivatedEventElements.Add("ChangeEntityCollectionNoMessageBase");
			ActivatedEventElements.Add("EntityCollectionEditToolButtonClickMessage");
			ActivatedEventElements.Add("AddSamplingRecordsRadioButtonCheckMessage");
			ActivatedEventElements.Add("DeleteButtonClickMessage");
			ActivatedEventElements.Add("EditValueButtonClickMessage");
			ActivatedEventElements.Add("AddButtonClickMessage");
			ActivatedEventElements.Add("SamplingEntityCollectionEditToolButtonClickMessage");
			ActivatedEventElements.Add("ColumnValueEditPageClosedMessage");
			ActivatedEventElements.Add("ColumnValuesTreeGridDblClick_StartMessage");
			ActivatedEventElements.Add("DeleteColumnYesMessage_StartMessage");
			ActivatedEventElements.Add("ChangeAddModeYesStartMessage");
			ActivatedEventElements.Add("ChangeAddModeNoStartMessage");
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
				case "IntermediateThrowMessageEventPageLoadComplete":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEventPageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScript";
					result = PageLoadCompleteChildScript.Execute(context, PageLoadCompleteChildScriptExecute);
					break;
				case "AddNotNullColumns_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddNotNullColumns_ScriptTask";
					result = AddNotNullColumns_ScriptTask.Execute(context, AddNotNullColumns_ScriptTaskExecute);
					break;
				case "OkButtonClickChildSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
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
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "NewEntityCollectionParameterValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewEntityCollectionParameterValueScriptTask";
					result = NewEntityCollectionParameterValueScriptTask.Execute(context, NewEntityCollectionParameterValueScriptTaskExecute);
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
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
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
				case "ChangeEntityCollectionNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageBase";
					result = ChangeEntityCollectionNoMessageBase.Execute(context);
					break;
				case "ChangeEntityCollectionNoMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeEntityCollectionNoMessageScript";
					result = ChangeEntityCollectionNoMessageScript.Execute(context, ChangeEntityCollectionNoMessageScriptExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "EntityCollectionEditToolButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickMessage";
					result = EntityCollectionEditToolButtonClickMessage.Execute(context);
					break;
				case "EntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntityCollectionEditToolButtonClickScript";
					result = EntityCollectionEditToolButtonClickScript.Execute(context, EntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "AddSamplingRecordsRadioButtonCheckMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSamplingRecordsRadioButtonCheckMessage";
					result = AddSamplingRecordsRadioButtonCheckMessage.Execute(context);
					break;
				case "AddSamplingRecordsRadioButtonCheckScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddSamplingRecordsRadioButtonCheckScript";
					result = AddSamplingRecordsRadioButtonCheckScript.Execute(context, AddSamplingRecordsRadioButtonCheckScriptExecute);
					break;
				case "ChangeAddModeUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeAddModeUserTask";
					result = ChangeAddModeUserTask.Execute(context);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickMessage";
					result = DeleteButtonClickMessage.Execute(context);
					break;
				case "DeleteButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickScriptTask";
					result = DeleteButtonClickScriptTask.Execute(context, DeleteButtonClickScriptTaskExecute);
					break;
				case "DeleteColumnQuestion_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteColumnQuestion_UserTask";
					result = DeleteColumnQuestion_UserTask.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "BreakDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BreakDelete_ScriptTask";
					result = BreakDelete_ScriptTask.Execute(context, BreakDelete_ScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "EditValueButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditValueButtonClickMessage";
					result = EditValueButtonClickMessage.Execute(context);
					break;
				case "EditValueButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditValueButtonClickScriptTask";
					result = EditValueButtonClickScriptTask.Execute(context, EditValueButtonClickScriptTaskExecute);
					break;
				case "OpenEditColumnValuePage_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEditColumnValuePage_UserTask";
					result = OpenEditColumnValuePage_UserTask.Execute(context);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickMessage";
					result = AddButtonClickMessage.Execute(context);
					break;
				case "AddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickScriptTask";
					result = AddButtonClickScriptTask.Execute(context, AddButtonClickScriptTaskExecute);
					break;
				case "OpenColumnValuePage_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnValuePage_UserTask";
					result = OpenColumnValuePage_UserTask.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "SamplingEntityCollectionEditToolButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SamplingEntityCollectionEditToolButtonClickMessage";
					result = SamplingEntityCollectionEditToolButtonClickMessage.Execute(context);
					break;
				case "SamplingEntityCollectionEditToolButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SamplingEntityCollectionEditToolButtonClickScript";
					result = SamplingEntityCollectionEditToolButtonClickScript.Execute(context, SamplingEntityCollectionEditToolButtonClickScriptExecute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValueEditPageClosedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditPageClosedMessage";
					result = ColumnValueEditPageClosedMessage.Execute(context);
					break;
				case "ColumnValueEditPageClosedScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditPageClosedScript";
					result = ColumnValueEditPageClosedScript.Execute(context, ColumnValueEditPageClosedScriptExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValuesTreeGridDblClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValuesTreeGridDblClick_StartMessage";
					result = ColumnValuesTreeGridDblClick_StartMessage.Execute(context);
					break;
				case "ColumnValuesTreeGridDblClick":
					context.QueueTasks.Dequeue();
					result = ColumnValuesTreeGridDblClick.Execute(context);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteColumnYesMessage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteColumnYesMessage_StartMessage";
					result = DeleteColumnYesMessage_StartMessage.Execute(context);
					break;
				case "DeleteColumn_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteColumn_ScriptTask";
					result = DeleteColumn_ScriptTask.Execute(context, DeleteColumn_ScriptTaskExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeAddModeYesStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeAddModeYesStartMessage";
					result = ChangeAddModeYesStartMessage.Execute(context);
					break;
				case "ChangeAddModeYesMessageScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeAddModeYesMessageScript";
					result = ChangeAddModeYesMessageScript.Execute(context, ChangeAddModeYesMessageScriptExecute);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeAddModeNoStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeAddModeNoStartMessage";
					result = ChangeAddModeNoStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
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
				case "IsSelectedSamplingAddMode":
					IsSelectedSamplingAddMode = reader.GetValue<System.Boolean>();
				break;
				case "InsertedColumnValueKey":
					InsertedColumnValueKey = reader.GetValue<System.String>();
				break;
				case "ColumnValuesContextKey":
					ColumnValuesContextKey = reader.GetValue<System.String>();
				break;
				case "NewEntityCollectionParameterValue":
					NewEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "IsEditingSamplingEntityCollection":
					IsEditingSamplingEntityCollection = reader.GetValue<System.Boolean>();
				break;
				case "SamplingEntityCollectionDisplayValue":
					SamplingEntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "SamplingEntityCollectionMetaPath":
					SamplingEntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
				case "SamplingEntityCollectionSchemaUId":
					SamplingEntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "IsNewSamplingEntityCollection":
					IsNewSamplingEntityCollection = reader.GetValue<System.Boolean>();
				break;
				case "NewUserDefinedEntityCollectionParameterValue":
					NewUserDefinedEntityCollectionParameterValue = reader.GetValue<System.String>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "EntityCollectionSchemaUId":
					EntityCollectionSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "EntityCollectionDisplayValue":
					EntityCollectionDisplayValue = reader.GetValue<System.String>();
				break;
				case "EntityCollectionMetaPath":
					EntityCollectionMetaPath = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ChildInitScriptExecute(ProcessExecutingContext context) {
			CreateColumnValuesVds();
			if (!Ext.IsAjaxRequest) {
				ParameterDataValueTypeUId = UserConnection.DataValueTypeManager.GetItemByName("EntityCollectionDataValueType").UId;
				Page.TitleEdit.Text = ElementNewCaption;
				var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
				Page.AddOneRecordRadioButton.Checked = true;
			}
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			EntityCollectionMetaPath = string.Empty;
			EntityCollectionDisplayValue = string.Empty;
			SamplingEntityCollectionMetaPath = string.Empty;
			SamplingEntityCollectionDisplayValue = string.Empty;
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			Page.FilterEdit.AggregationEnable = false;
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
				EntityCollectionDisplayValue = GetEntityCollectionDisplayValue(EntityCollectionDisplayValue, EntityCollectionMetaPath);
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
				//Page.EntityCollectionTextEdit.Enabled = string.IsNullOrEmpty(EntityCollectionDisplayValue) ? true : false;;
			} else {
				IsNew = true;
			}
			var samplingEntityCollection = df["SamplingEntityCollection"];
			if (samplingEntityCollection == null) {
				return true;
			}
			((Terrasoft.UI.WebControls.Page)Page.AspPage).CustomData["SamplingEntityCollectionCustomDataKey"] = Json.Serialize(samplingEntityCollection);
			if (samplingEntityCollection.Source != ProcessSchemaParameterValueSource.None &&
					samplingEntityCollection.ReferenceSchemaUId != Guid.Empty) {
				SamplingEntityCollectionSchemaUId = samplingEntityCollection.ReferenceSchemaUId;
				SamplingEntityCollectionMetaPath = samplingEntityCollection.Value;
				SamplingEntityCollectionDisplayValue = GetPropertyDisplayPathByServerMetaPath(
					GetPropertyServerMetaPathByClientMetaPath(samplingEntityCollection.Value));
				Page.EntityDataSource.SchemaUId = SamplingEntityCollectionSchemaUId;
				SamplingEntityCollectionDisplayValue = GetEntityCollectionDisplayValue(SamplingEntityCollectionDisplayValue, SamplingEntityCollectionMetaPath);
				Page.SamplingEntityCollectionTextEdit.Text = SamplingEntityCollectionDisplayValue;
				//Page.SamplingEntityCollectionTextEdit.Enabled = string.IsNullOrEmpty(SamplingEntityCollectionDisplayValue) ? true : false;
				string filters = df["DataSourceFilters"].Value;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;	
					if (filterCollection != null) {
						Page.EntityDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				InitializeFilterEdit();
				Page.EntityDataSource.LoadStructure();
			} else {
				IsNewSamplingEntityCollection = true;
			}
			var isSelectedSamplingAddModeParameter = df["IsSelectedSamplingAddMode"];
			IsSelectedSamplingAddMode = (isSelectedSamplingAddModeParameter == null || string.IsNullOrEmpty(isSelectedSamplingAddModeParameter.Value))
				? false
				: Convert.ToBoolean(isSelectedSamplingAddModeParameter.Value);
			Page.AddOneRecordRadioButton.Checked = !IsSelectedSamplingAddMode;
			Page.AddSamplingRecordsRadioButton.Checked = IsSelectedSamplingAddMode;
			Page.SamplingEntityCollectionEditToolButton.Enabled = IsSelectedSamplingAddMode;
			SetControlsPropertyEnabled(IsSelectedSamplingAddMode);
			ColumnValuesContextKey = Guid.NewGuid().ToString();
			var columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			var serealizedCVs = df["RecordDefValues"].Value;
			if (!String.IsNullOrEmpty(serealizedCVs)) {
				var cvColection = EntityColumnMappingCollection.DeserializeValue(serealizedCVs);
				foreach (var cv in cvColection) {
					columnValues[cv.ColumnMetaPath] = cv.Value;
				}
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
			return true;
		}

		public virtual bool AddNotNullColumns_ScriptTaskExecute(ProcessExecutingContext context) {
			InitGridWithNotNullColumns();
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
			SaveEntityCollectionParameterValue(parametersValue, "EntityCollection", EntityCollectionMetaPath, EntityCollectionSchemaUId);
			DataSourceFilterCollection filterCollection;
			string serializedFilterCollection;
			if(Page.AddSamplingRecordsRadioButton.Checked) {
				filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
				var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
				serializedFilterCollection = Json.Serialize(filterCollection, jsonConverter);
			} else {
				SamplingEntityCollectionMetaPath = string.Empty;
				SamplingEntityCollectionSchemaUId = Guid.Empty;
				SamplingEntityCollectionDisplayValue = string.Empty;
				filterCollection = null;
				serializedFilterCollection = null;
			}
			SaveEntityCollectionParameterValue(parametersValue, "SamplingEntityCollection", SamplingEntityCollectionMetaPath,
				SamplingEntityCollectionSchemaUId);
			bool isNoneVS = filterCollection == null || filterCollection.Count == 0;
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = isNoneVS ? noneVS : constVS,
				Value = isNoneVS ? string.Empty : serializedFilterCollection
			};
			// Set column values
			var columnValues = new EntityColumnMappingCollection();
			foreach (KeyValuePair<string, ProcessSchemaParameterValue> cv in GetColumnValues()) {
				columnValues.Add(new EntityColumnMappingItem() {
					SchemaUId = EntityCollectionSchemaUId,
					ColumnMetaPath = cv.Key,
					Value = cv.Value
				});
			}
			parametersValue["RecordDefValues"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = columnValues.Count == 0 ? noneVS : constVS,
				Value = columnValues.SerializeValue()
			};
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
			ChangeEntityCollection();
			return true;
		}

		public virtual bool ChangeEntityCollectionNoMessageScriptExecute(ProcessExecutingContext context) {
			if(IsEditingSamplingEntityCollection) {
				Page.SamplingEntityCollectionTextEdit.Text = SamplingEntityCollectionDisplayValue;
			} else {
				Page.EntityCollectionTextEdit.Text = EntityCollectionDisplayValue;
			}
			return true;
		}

		public virtual bool EntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			IsEditingSamplingEntityCollection = false;
			ShowSchemaStructureExplorerEditWindow(EntityCollectionMetaPath,  Page.EntityCollectionTextEdit.ClientID, "EntityCollectionEditChange");
			return true;
		}

		public virtual bool AddSamplingRecordsRadioButtonCheckScriptExecute(ProcessExecutingContext context) {
			ChangeAddModeUserTask.Page = Page;
			ChangeAddModeUserTask.MessageText = SelectAddModeMessage;
			ChangeAddModeUserTask.Icon = "QUESTION";
			ChangeAddModeUserTask.Buttons = "YESNO";
			ChangeAddModeUserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeAddModeYesMessage"},
				{"no", "ChangeAddModeNoMessage"}
			};
			return true;
		}

		public virtual bool DeleteButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			DeleteColumnQuestion_UserTask.Page = Page;
			DeleteColumnQuestion_UserTask.MessageText = DeleteColumnMessage;
			DeleteColumnQuestion_UserTask.Icon = "QUESTION";
			DeleteColumnQuestion_UserTask.Buttons = "YESNO";
			DeleteColumnQuestion_UserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "DeleteColumnYesMessage"},
				{"no", "DeleteColumnNoMessage"},
			};
			return true;
		}

		public virtual bool BreakDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool EditValueButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			TreeGridNode node = null;
			if (Page.ColumnValuesTreeGrid.SelectedNodes.Count > 0) {
				node = Page.ColumnValuesTreeGrid.SelectedNodes[0];
			} 
			else {
				return false;
			}
			OpenEditColumnValuePage_UserTask.OpenerInstanceId = InstanceUId;
			OpenEditColumnValuePage_UserTask.UseCurrentActivePage = true;
			OpenEditColumnValuePage_UserTask.PageUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");//ColumnValueEditPageId;
			OpenEditColumnValuePage_UserTask.CloseMessage = "ColumnValueEditPageClosed";
			OpenEditColumnValuePage_UserTask.PageParameters = GetPageParams(node);
			return true;
		}

		public virtual bool AddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenColumnValuePage_UserTask.OpenerInstanceId = InstanceUId;
			OpenColumnValuePage_UserTask.UseCurrentActivePage = true;
			OpenColumnValuePage_UserTask.PageUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488"); //ColumnValueEditPageId;
			OpenColumnValuePage_UserTask.CloseMessage = "ColumnValueEditPageClosed";
			OpenColumnValuePage_UserTask.PageParameters = GetPageParams(null);
			return true;
		}

		public virtual bool SamplingEntityCollectionEditToolButtonClickScriptExecute(ProcessExecutingContext context) {
			IsEditingSamplingEntityCollection = true;
			ShowSchemaStructureExplorerEditWindow(SamplingEntityCollectionMetaPath,  Page.SamplingEntityCollectionTextEdit.ClientID, "EntityCollectionEditChange");
			return true;
		}

		public virtual bool ColumnValueEditPageClosedScriptExecute(ProcessExecutingContext context) {
			var insertRowColumnValue = (string)UserConnection.SessionData[InsertedColumnValueKey];
			UserConnection.SessionData.Remove(InsertedColumnValueKey);
			Page.AddScript(insertRowColumnValue);
			return true;
		}

		public virtual bool DeleteColumn_ScriptTaskExecute(ProcessExecutingContext context) {
			var columnValues = UserConnection.SessionData[ColumnValuesContextKey] as Dictionary<string, ProcessSchemaParameterValue>;
			if (columnValues == null) {
				return true;
			}
			foreach (var node in Page.ColumnValuesTreeGrid.SelectedNodes) {
				var metaPath = node.Values["MetaPath"].ToString();
				columnValues.Remove(metaPath);
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
			return true;
		}

		public virtual bool ChangeAddModeYesMessageScriptExecute(ProcessExecutingContext context) {
			bool isSelectedSamplingAddMode = Page.AddSamplingRecordsRadioButton.Checked;
			SetControlsPropertyEnabled(isSelectedSamplingAddMode);
			SetUserTaskParameterConstValue("IsSelectedSamplingAddMode",
					isSelectedSamplingAddMode.ToString(), string.Empty);
			if (IsSelectedSamplingAddMode && !isSelectedSamplingAddMode && !IsNewSamplingEntityCollection) {
				IsNewSamplingEntityCollection = true;
				SamplingEntityCollectionMetaPath = string.Empty;
				SamplingEntityCollectionDisplayValue = string.Empty;
				SamplingEntityCollectionSchemaUId = Guid.Empty;
				Page.SamplingEntityCollectionTextEdit.Text = SamplingEntityCollectionDisplayValue;
				ClearDataSourceFilters();
				ClearColumnValues();
				InitGridWithNotNullColumns();
			}
			IsSelectedSamplingAddMode = isSelectedSamplingAddMode;
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Page.AddSamplingRecordsRadioButton.Checked = true;
			Page.AddOneRecordRadioButton.Checked = false;
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

		public virtual void ShowSchemaStructureExplorerEditWindow(string entityCollectionMetaPath, string textEditClientID, string textEditEventName) {
			InitializeSchemaExplorerWindow();
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			//Show parameters only where ReferenceSchemaUId not empty
			schemaExplorer.IncludedDataValueTypes[ParameterDataValueTypeUId] = Guid.NewGuid();
			var processSchema = FindDesignedProcessSchema();
			string handler = string.Empty;
			string handlerReferenceName = string.Format("window.{0}_EditCompleteParameter", schemaExplorer.ClientID);
			var propertyDataSource = PropertyDataSource as VirtualDataSource;
			var sb = new StringBuilder();
			sb.Append("function(columnInfo) {\n");
			sb.Append("var info = Ext.util.JSON.decode(columnInfo);");
			sb.AppendFormat("{0}.setValue(info.caption);", textEditClientID);
			sb.AppendFormat("window.Terrasoft.AjaxMethods.ThrowClientEventWithParameters('{0}', '{1}', columnInfo);", InstanceUId, textEditEventName);
			sb.Append("}");
			handler = sb.ToString();
			handler = string.Format(@"{0} = {1}", handlerReferenceName, handler);
			Page.ScriptManager.AddScript(string.Format("if ({2}) {{ {0}.un(\"{1}\",{2}); }}", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			Page.ScriptManager.AddScript(handler);
			Page.ScriptManager.AddScript(string.Format("{0}.on(\"{1}\",{2});", schemaExplorer.ClientID, "editcomplete", handlerReferenceName));
			schemaExplorer.ManagerName = processSchema.Manager.Name;
			schemaExplorer.ShowEditWindow(processSchema.UId, entityCollectionMetaPath);
		}

		public virtual void InitializeFilterEdit() {
			EntityDataSource dataSource = Page.EntityDataSource;
			var filterEditGroup = dataSource.FindFiltersGroupByName("FilterEdit");
			if (filterEditGroup == null) {
				filterEditGroup = dataSource.CreateFiltersGroup("FilterEdit");
				dataSource.CurrentStructure.Filters.Add(filterEditGroup);
			}
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

		public virtual void ChangeEntityCollection() {
			var entityCollectionSelectedParameterValues = Json.Deserialize<Dictionary<string, object>>(NewEntityCollectionParameterValue);
			Guid entityCollectionSchemaUId = new Guid(entityCollectionSelectedParameterValues["referenceSchemaUId"].ToString());
			string entityCollectionMetaPath = entityCollectionSelectedParameterValues["metaPath"].ToString();
			string entityCollectionDisplayValue = entityCollectionSelectedParameterValues["caption"].ToString();
			entityCollectionDisplayValue = GetEntityCollectionDisplayValue(entityCollectionDisplayValue, entityCollectionMetaPath);
			if(IsEditingSamplingEntityCollection) {
				if (!IsNewSamplingEntityCollection) {
					ClearDataSourceFilters();
					ClearColumnValues();
					InitGridWithNotNullColumns();
				}
				IsNewSamplingEntityCollection = false;
				SamplingEntityCollectionSchemaUId = entityCollectionSchemaUId;
				SamplingEntityCollectionMetaPath = entityCollectionMetaPath;
				SamplingEntityCollectionDisplayValue = entityCollectionDisplayValue;
				Page.SamplingEntityCollectionTextEdit.Text = entityCollectionDisplayValue;
				//Page.SamplingEntityCollectionTextEdit.Enabled = string.IsNullOrEmpty(entityCollectionDisplayValue) ? true : false;
				Page.EntityDataSource.SchemaUId = SamplingEntityCollectionSchemaUId;
				InitializeFilterEdit();
				Page.EntityDataSource.LoadStructure();
				Page.FilterEdit.Enabled = SamplingEntityCollectionSchemaUId != Guid.Empty;
			} else {
				if (!IsNew) {
					ClearColumnValues();
					InitGridWithNotNullColumns();
				}
				IsNew = false;
				EntityCollectionSchemaUId = entityCollectionSchemaUId;
				EntityCollectionMetaPath = entityCollectionMetaPath;
				EntityCollectionDisplayValue = entityCollectionDisplayValue;
				Page.EntityCollectionTextEdit.Text = entityCollectionDisplayValue;
				//Page.EntityCollectionTextEdit.Enabled = string.IsNullOrEmpty(entityCollectionDisplayValue) ? true : false;
			}
		}

		public virtual void CreateColumnValuesVds() {
			var vds = new VirtualDataSource() {
				ID = "ColumnValuesVds"
			};
			Page.PageContainer.Controls.Add(vds);
			Page.ColumnValuesTreeGrid.DataSourceId = vds.ID;
			DataSourceStructure vdsStructure = vds.DefStructure;
			vdsStructure.PrimaryColumnName = "Id";
			vdsStructure.PrimaryDisplayColumnName = "Name";
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "MetaPath",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = CaptionColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Value",
				Caption = ValueColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
		}

		public virtual void SetControlsPropertyEnabled(bool isEnabled) {
			Page.SamplingEntityCollectionTextEdit.Enabled = isEnabled;
			Page.SamplingEntityCollectionTextEdit.SetRequired(isEnabled);
			Page.SamplingEntityCollectionEditToolButton.Enabled = isEnabled;
			Page.FilterEdit.Enabled = isEnabled && SamplingEntityCollectionSchemaUId != Guid.Empty;
		}

		public virtual Dictionary<string, string> GetPageParams(TreeGridNode node) {
			InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			var result = new Dictionary<string, string>() {
				{ "schemaId", EntityCollectionSchemaUId.ToString() },			
				{ "processSchemaId", EditSchemaUId.ToString() },
				{ "managerName", EditSchemaManagerName },
				{ "contextKey", ColumnValuesContextKey },
				{ "treeGridId", Page.ColumnValuesTreeGrid.ClientID },
				{ "insertedRowKey", InsertedColumnValueKey },
				{ "editElementId", EditElementUId.ToString() }
			};
			if (SamplingEntityCollectionSchemaUId != Guid.Empty) {
				result.Add("filterSchemaId", SamplingEntityCollectionSchemaUId.ToString());
			}
			bool isColumnRequired = false;
			if (node != null) {
				result.Add("rowId", node.Values["Id"].ToString());
				result.Add("metaPath", node.Values["MetaPath"].ToString());
				var requiredColumnIds = GetNotNullColumnIdList();
				var metaPath = node.Values["MetaPath"].ToString();
				Guid columnId;
				isColumnRequired = Guid.TryParse(metaPath, out columnId) && requiredColumnIds.Contains(columnId);
			}
			result.Add("canChangeColumn", (!isColumnRequired).ToString().ToLower());
			return result;
		}

		public virtual void DisplayColumnValues() {
			var vds = GetColumnValuesVds();
			vds.Clear();
			
			var columnValues = GetColumnValues();
			if (columnValues == null) {
				return;
			}
			
			foreach (var columnValue in columnValues) {
				Entity row = vds.CreateRow();
				row.SetColumnValue("Id", Guid.NewGuid());
				row.SetColumnValue("MetaPath", columnValue.Key);
				
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
				var column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				row.SetColumnValue("Name", column.Caption.ToString());
				
				string displayValue = String.IsNullOrEmpty(columnValue.Value.DisplayValue) ?
					columnValue.Value.Value : columnValue.Value.DisplayValue;
					
				row.SetColumnValue("Value", displayValue);
				vds.Add(row);
			}
			
			vds.LoadRows();
			
			/*
			var vds = GetColumnValuesVds();
			vds.Clear();
			
			var columnValues = GetColumnValues();
			if (columnValues == null) {
				return;
			}
			
			foreach (var columnValue in columnValues) {
				Entity row = vds.CreateRow();
				row.SetColumnValue("Id", Guid.NewGuid());
				row.SetColumnValue("MetaPath", columnValue.Key);
				
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
				var column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				row.SetColumnValue("Name", column.Caption.ToString());
				
				row.SetColumnValue("Value", columnValue.Value.DisplayValue);
				vds.Add(row);
			}
			
			vds.LoadRows();
			*/
		}

		public virtual Dictionary<string, ProcessSchemaParameterValue> GetColumnValues() {
			var columnValues = UserConnection.SessionData[ColumnValuesContextKey];
			return columnValues != null ? columnValues as Dictionary<string, ProcessSchemaParameterValue> : null;
		}

		public virtual VirtualDataSource GetColumnValuesVds() {
			return Page.PageContainer.FindControl("ColumnValuesVds") as VirtualDataSource;
		}

		public virtual void InitGridWithNotNullColumns() {
			var columnValues = GetColumnValues();
			if ((columnValues != null && columnValues.Count > 0)
					|| EntityCollectionSchemaUId == Guid.Empty) {
				return;
			}
			columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			foreach(var columnId in GetNotNullColumnIdList()) {
				var cv = new EntityColumnMappingItem() {
					SchemaUId = EntityCollectionSchemaUId,
					ColumnMetaPath = columnId.ToString(),
					Value = new ProcessSchemaParameterValue()
				};
				columnValues[cv.ColumnMetaPath] = cv.Value;
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
		}

		public virtual List<Guid> GetNotNullColumnIdList() {
			var result = new List<Guid>();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntityCollectionSchemaUId);
			foreach(var column in entitySchema.Columns) {
				if (!entitySchema.PrimaryColumn.UId.Equals(column.UId) 
						&& column.IsDBRequirement
						&& !column.HasDefValue) {
					result.Add(column.UId);
				}
			}
			return result;
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

		public virtual void ClearDataSourceFilters() {
			EntityDataSource dataSource = Page.EntityDataSource;
			var oldFilters = dataSource.CurrentStructure.Filters.FindByName("FilterEdit") as DataSourceFilterCollection;
			if (oldFilters != null) {
				oldFilters.Clear();
			}
			Page.FilterEdit.IsColumnsExplorerRootMode = true;
			//Page.FilterEdit.Reinitialize(dataSource);
		}

		public virtual void ClearColumnValues() {
			var columnValuesContextKeySessionData = UserConnection.SessionData[ColumnValuesContextKey];
			if (columnValuesContextKeySessionData != null) {
				/*
				var values = columnValuesContextKeySessionData as Dictionary<string, ProcessSchemaParameterValue>;
				var clearValues = new Dictionary<string, ProcessSchemaParameterValue>();
				foreach(KeyValuePair<string, ProcessSchemaParameterValue> pair in values) {
					if (!pair.Value.Source.Equals(ProcessSchemaParameterValueSource.EntityMapping)) {
						clearValues.Add(pair.Key, pair.Value);
					}	
				}
				*/
				UserConnection.SessionData[ColumnValuesContextKey] = null;
				DisplayColumnValues();
			}
		}

		public virtual void SaveEntityCollectionParameterValue(Dictionary<string, ProcessSchemaParameterValue> parametersValue, string parameterName, string parameterMetaPath, Guid entitySchemaUId) {
			var entityCollection = Json.Deserialize<ProcessSchemaParameterValue>(((Terrasoft.UI.WebControls.Page)Page.AspPage)
				.CustomData[parameterName + "CustomDataKey"].ToString());
			entityCollection.MetaPath = parameterMetaPath;
			entityCollection.Value = parameterMetaPath;
			entityCollection.ModifiedInSchemaUId = EditSchemaUId;
			entityCollection.Source = string.IsNullOrEmpty(parameterMetaPath) ?
				ProcessSchemaParameterValueSource.None : ProcessSchemaParameterValueSource.Mapping;
			entityCollection.ReferenceSchemaUId = entitySchemaUId;
			parametersValue[parameterName] = entityCollection;
		}

		public virtual string GetEntityCollectionDisplayValue(string displayValue, string metaPath) {
			if (string.IsNullOrEmpty(displayValue)) {
				ProcessSchema processSchema = FindDesignedProcessSchema();
				displayValue = processSchema.GetBaseElementByUId(new Guid(metaPath)).Name;
			}
			return displayValue;
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
							if (ActivatedEventElements.Contains("StartMessagePageLoadComplete")) {
							context.QueueTasks.Enqueue("StartMessagePageLoadComplete");
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
					case "EntityCollectionEditChange":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
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
					case "EntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("EntityCollectionEditToolButtonClickMessage")) {
							context.QueueTasks.Enqueue("EntityCollectionEditToolButtonClickMessage");
						}
						break;
					case "AddSamplingRecordsRadioButtonCheck":
							if (ActivatedEventElements.Contains("AddSamplingRecordsRadioButtonCheckMessage")) {
							context.QueueTasks.Enqueue("AddSamplingRecordsRadioButtonCheckMessage");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClickMessage")) {
							context.QueueTasks.Enqueue("DeleteButtonClickMessage");
						}
						break;
					case "EditValueButtonClick":
							if (ActivatedEventElements.Contains("EditValueButtonClickMessage")) {
							context.QueueTasks.Enqueue("EditValueButtonClickMessage");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickMessage")) {
							context.QueueTasks.Enqueue("AddButtonClickMessage");
						}
						break;
					case "SamplingEntityCollectionEditToolButtonClick":
							if (ActivatedEventElements.Contains("SamplingEntityCollectionEditToolButtonClickMessage")) {
							context.QueueTasks.Enqueue("SamplingEntityCollectionEditToolButtonClickMessage");
						}
						break;
					case "ColumnValueEditPageClosed":
							if (ActivatedEventElements.Contains("ColumnValueEditPageClosedMessage")) {
							context.QueueTasks.Enqueue("ColumnValueEditPageClosedMessage");
						}
						break;
					case "ColumnValuesTreeGridDblClick":
							if (ActivatedEventElements.Contains("ColumnValuesTreeGridDblClick_StartMessage")) {
							context.QueueTasks.Enqueue("ColumnValuesTreeGridDblClick_StartMessage");
						}
						break;
					case "DeleteColumnYesMessage":
							if (ActivatedEventElements.Contains("DeleteColumnYesMessage_StartMessage")) {
							context.QueueTasks.Enqueue("DeleteColumnYesMessage_StartMessage");
						}
						break;
					case "ChangeAddModeYesMessage":
							if (ActivatedEventElements.Contains("ChangeAddModeYesStartMessage")) {
							context.QueueTasks.Enqueue("ChangeAddModeYesStartMessage");
						}
						break;
					case "ChangeAddModeNoMessage":
							if (ActivatedEventElements.Contains("ChangeAddModeNoStartMessage")) {
							context.QueueTasks.Enqueue("ChangeAddModeNoStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsSelectedSamplingAddMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsSelectedSamplingAddMode", IsSelectedSamplingAddMode, false);
			}
			if (!HasMapping("InsertedColumnValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InsertedColumnValueKey", InsertedColumnValueKey, null);
			}
			if (!HasMapping("ColumnValuesContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnValuesContextKey", ColumnValuesContextKey, null);
			}
			if (!HasMapping("NewEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewEntityCollectionParameterValue", NewEntityCollectionParameterValue, null);
			}
			if (!HasMapping("IsEditingSamplingEntityCollection") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsEditingSamplingEntityCollection", IsEditingSamplingEntityCollection, false);
			}
			if (!HasMapping("SamplingEntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingEntityCollectionDisplayValue", SamplingEntityCollectionDisplayValue, null);
			}
			if (!HasMapping("SamplingEntityCollectionMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingEntityCollectionMetaPath", SamplingEntityCollectionMetaPath, null);
			}
			if (!HasMapping("SamplingEntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SamplingEntityCollectionSchemaUId", SamplingEntityCollectionSchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsNewSamplingEntityCollection") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNewSamplingEntityCollection", IsNewSamplingEntityCollection, false);
			}
			if (!HasMapping("NewUserDefinedEntityCollectionParameterValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewUserDefinedEntityCollectionParameterValue", NewUserDefinedEntityCollectionParameterValue, null);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("EntityCollectionSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionSchemaUId", EntityCollectionSchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntityCollectionDisplayValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityCollectionDisplayValue", EntityCollectionDisplayValue, null);
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

	#region Class: AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess : AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.AddDataToEntityCollectionUserTaskParametersEditPageSchemaUserControl>
	{

		public AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddDataToEntityCollectionUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class AddDataToEntityCollectionUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.RadioButton AddOneRecordRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AddOneRecordRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AddSamplingRecordsRadioButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AddSamplingRecordsRadioButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit SamplingEntityCollectionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("SamplingEntityCollectionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton SamplingEntityCollectionEditToolButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("SamplingEntityCollectionEditToolButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label FilterLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("FilterLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button EditValueButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("EditValueButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid ColumnValuesTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("ColumnValuesTreeGrid", true);
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
			AddSamplingRecordsRadioButton.AjaxEvents.Check.Event += AddSamplingRecordsRadioButtonCheck;
			SamplingEntityCollectionEditToolButton.AjaxEvents.Click.Event += SamplingEntityCollectionEditToolButtonClick;
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			EditValueButton.AjaxEvents.Click.Event += EditValueButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntityCollectionEditToolButton.AjaxEvents.Click.Event -= EntityCollectionEditToolButtonClick;
			AddSamplingRecordsRadioButton.AjaxEvents.Check.Event -= AddSamplingRecordsRadioButtonCheck;
			SamplingEntityCollectionEditToolButton.AjaxEvents.Click.Event -= SamplingEntityCollectionEditToolButtonClick;
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			EditValueButton.AjaxEvents.Click.Event -= EditValueButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void AddSamplingRecordsRadioButtonCheck(object sender, EventArgs e) {
			object result = ThrowEvent("AddSamplingRecordsRadioButtonCheck");
		}

		public virtual void SamplingEntityCollectionEditToolButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SamplingEntityCollectionEditToolButtonClick");
		}

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void EditValueButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditValueButtonClick");
		}

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
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
			SchemaName = "AddDataToEntityCollectionUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema(AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AddDataToEntityCollectionUserTaskParametersEditPageEventsProcess";
			UId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7");
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
			UId = new Guid("60aca60c-9ef2-4562-9bd0-68d7d5b254b9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1185f262-405e-4d26-8020-4ef69ef9b389"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("462eb9ad-6e70-456f-bd62-faa9c905b69a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("28a020cc-ca3a-4835-907c-9f8a85fca9ce"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewUserDefinedEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("caa14c1b-1bb2-497f-82b9-e9ba15bed8c4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"NewUserDefinedEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewSamplingEntityCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8eec0ffc-9ea1-416c-875a-c890fd05af80"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IsNewSamplingEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d42ab2df-c1ac-4758-9ce4-3c2765b04201"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"SamplingEntityCollectionSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("00749411-9a7d-4c28-8154-222998422b35"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"SamplingEntityCollectionMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionDisplayValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9358ab1d-57c9-4f53-aee9-df283fe64c50"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"SamplingEntityCollectionDisplayValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsEditingSamplingEntityCollectionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("066061dd-a135-415b-92a8-97895a8c371e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IsEditingSamplingEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewEntityCollectionParameterValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4944787d-7043-4759-a957-cf95755f82a2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"NewEntityCollectionParameterValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnValuesContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b0990adb-1af3-49f0-af02-7598107ed67e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ColumnValuesContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedColumnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0c6ccfe3-cf39-430c-a61e-5ff290a1984a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"InsertedColumnValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSelectedSamplingAddModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("402b8e26-796e-48fd-b689-d2a8a3860f95"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IsSelectedSamplingAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntityCollectionMetaPathParameter());
			Parameters.Add(CreateEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateNewUserDefinedEntityCollectionParameterValueParameter());
			Parameters.Add(CreateIsNewSamplingEntityCollectionParameter());
			Parameters.Add(CreateSamplingEntityCollectionSchemaUIdParameter());
			Parameters.Add(CreateSamplingEntityCollectionMetaPathParameter());
			Parameters.Add(CreateSamplingEntityCollectionDisplayValueParameter());
			Parameters.Add(CreateIsEditingSamplingEntityCollectionParameter());
			Parameters.Add(CreateNewEntityCollectionParameterValueParameter());
			Parameters.Add(CreateColumnValuesContextKeyParameter());
			Parameters.Add(CreateInsertedColumnValueKeyParameter());
			Parameters.Add(CreateIsSelectedSamplingAddModeParameter());
		}

		protected virtual void InitializeChangeEntityCollectionUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0757179a-797a-41b4-9cdc-6ab381f1f80d"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("e95632d4-5e59-4e49-8efb-7d4a4efaaf45"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("6ce52976-afc2-457b-83fb-57cf33f3fc95"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("b1c14727-9e2f-4378-84f8-8397f810ed3c"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("f32c3daa-3a1f-478c-8fc0-be381a68946d"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("9644db40-e0af-4460-a477-7758506af005"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("5ee7cc29-4f79-4f41-b9cf-50584738ee86"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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
				UId = new Guid("90f03550-128d-41a2-89e4-8bf5dc6bb588"),
				ContainerUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
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

		protected virtual void InitializeChangeAddModeUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("baff996e-7594-4738-a32d-5998148813ca"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("4eece547-59e8-4276-af4b-40685d32535a"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("b1f65113-2ba8-447e-a392-169456af2f13"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("95375eae-f004-49a3-917e-23f746165481"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("a40c0e71-7fa2-438e-9617-f25ad99038d0"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("ec27b8da-e04f-4f76-9f93-8f95eb5d0fcb"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("8200d171-0c92-4f48-8cfd-3412417fc379"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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
				UId = new Guid("6bcc9e28-e7ad-487a-97db-73ec3ba32ded"),
				ContainerUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
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

		protected virtual void InitializeDeleteColumnQuestion_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5e411846-3efb-4a8a-8f02-daf1ba1d5414"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("15d0ee99-3a70-43a3-889b-0bc3b125905e"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("04dc5eee-455d-43df-9ad2-67e1dfa0e956"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("f41550ef-1d51-4ed3-82fb-13afb5461e85"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("f713edc7-0175-4ac3-9f77-8e1a7e2b2f04"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("697e2a11-4c59-4d65-997c-656bba1ee309"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("d71ba325-7f04-4e91-91db-899ca03cf4d5"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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
				UId = new Guid("6851ab98-f3c1-4b94-ad7f-33d0ed785525"),
				ContainerUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
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

		protected virtual void InitializeOpenEditColumnValuePage_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("86230a1f-3797-4a93-8d84-2a34e014ff51"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("9fd61131-b38d-4714-81dc-b6e754c81756"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("43f475a1-ca26-45e3-907d-e4e828769d40"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("b8106337-4ea3-4e5f-8d12-78580e71e8d3"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("701ed778-68dd-498e-9b93-d996d7c74aa9"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("d86c0f75-6331-481c-b5a7-dd328b474423"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("8721d6f7-654f-4fe8-a0d3-e32a26766bf1"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("5640c3d4-72a6-48f9-b5c1-37b49a32999a"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("65a495df-f15d-4e9a-82c3-5a392c892b43"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("a39f9e43-bc08-46a3-8adc-a82909ffa6d5"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("b0cfb1c4-1ba2-43ed-a898-1b8b71d22926"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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
				UId = new Guid("75eca2ac-2e16-4ce9-b1db-a5028b686aed"),
				ContainerUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
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

		protected virtual void InitializeOpenColumnValuePage_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ab40b1eb-536f-4b2a-b43b-f428a6ad7e66"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("0585fdd2-74b5-48c5-aca1-cad0e0f0c0e8"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("bcf5c388-d757-4a43-8933-52d7d3cb7f39"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("ddaf84b7-b940-4516-9fcd-2d19518e99ea"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("8d4ab86e-d054-4aa2-a936-ececae92c3de"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("aac73bb4-aae6-4676-8b39-765495b863a4"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("4e7829e0-d16a-48c3-a17e-4ed9c62c3d21"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("81e5854f-f1c7-4d34-9e74-d8b6cd1790a5"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("cdc88fc6-daf0-4640-9f12-0537ccf9b752"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("f8c1b0ef-bb48-452f-b4e7-85e3ee067ac3"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("0c8142fd-5ad8-492d-996b-1f9c0b8811bc"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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
				UId = new Guid("72c67243-2d97-483d-9abe-a547b7ac3e30"),
				ContainerUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess eventsubprocessoninit = CreateEventSubProcessOnInitEventSubProcess();
			FlowElements.Add(eventsubprocessoninit);
			ProcessSchemaEventSubProcess onpageloadcomplete = CreateOnPageLoadCompleteEventSubProcess();
			FlowElements.Add(onpageloadcomplete);
			ProcessSchemaEventSubProcess okbuttonclickchildsubprocess = CreateOkButtonClickChildSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickchildsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionyesmessage = CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionyesmessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeentitycollectionnomessage = CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeentitycollectionnomessage);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			eventsubprocessoninit.FlowElements.Add(startmessageinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventinit = CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent();
			eventsubprocessoninit.FlowElements.Add(intermediatethrowmessageeventinit);
			ProcessSchemaScriptTask childinitscript = CreateChildInitScriptScriptTask();
			eventsubprocessoninit.FlowElements.Add(childinitscript);
			ProcessSchemaStartMessageEvent startmessagepageloadcomplete = CreateStartMessagePageLoadCompleteStartMessageEvent();
			onpageloadcomplete.FlowElements.Add(startmessagepageloadcomplete);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventpageloadcomplete = CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent();
			onpageloadcomplete.FlowElements.Add(intermediatethrowmessageeventpageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			onpageloadcomplete.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaScriptTask addnotnullcolumns_scripttask = CreateAddNotNullColumns_ScriptTaskScriptTask();
			onpageloadcomplete.FlowElements.Add(addnotnullcolumns_scripttask);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask okbuttonclickchildscript = CreateOkButtonClickChildScriptScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(okbuttonclickchildscript);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess3.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask newentitycollectionparametervaluescripttask = CreateNewEntityCollectionParameterValueScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(newentitycollectionparametervaluescripttask);
			ProcessSchemaScriptTask preparechangeentitycollectionquestionscript = CreatePrepareChangeEntityCollectionQuestionScriptScriptTask();
			eventsubprocess3.FlowElements.Add(preparechangeentitycollectionquestionscript);
			ProcessSchemaUserTask changeentitycollectionusermessage = CreateChangeEntityCollectionUserMessageUserTask();
			eventsubprocess3.FlowElements.Add(changeentitycollectionusermessage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess3.FlowElements.Add(exclusivegateway1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent changeentitycollectionyesmessagebase = CreateChangeEntityCollectionYesMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagebase);
			ProcessSchemaScriptTask changeentitycollectionyesmessagescript = CreateChangeEntityCollectionYesMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionyesmessage.FlowElements.Add(changeentitycollectionyesmessagescript);
			ProcessSchemaStartMessageEvent changeentitycollectionnomessagebase = CreateChangeEntityCollectionNoMessageBaseStartMessageEvent();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagebase);
			ProcessSchemaScriptTask changeentitycollectionnomessagescript = CreateChangeEntityCollectionNoMessageScriptScriptTask();
			eventsubprocesschangeentitycollectionnomessage.FlowElements.Add(changeentitycollectionnomessagescript);
			ProcessSchemaStartMessageEvent entitycollectionedittoolbuttonclickmessage = CreateEntityCollectionEditToolButtonClickMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(entitycollectionedittoolbuttonclickmessage);
			ProcessSchemaScriptTask entitycollectionedittoolbuttonclickscript = CreateEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess2.FlowElements.Add(entitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent addsamplingrecordsradiobuttoncheckmessage = CreateAddSamplingRecordsRadioButtonCheckMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(addsamplingrecordsradiobuttoncheckmessage);
			ProcessSchemaScriptTask addsamplingrecordsradiobuttoncheckscript = CreateAddSamplingRecordsRadioButtonCheckScriptScriptTask();
			eventsubprocess4.FlowElements.Add(addsamplingrecordsradiobuttoncheckscript);
			ProcessSchemaUserTask changeaddmodeusertask = CreateChangeAddModeUserTaskUserTask();
			eventsubprocess4.FlowElements.Add(changeaddmodeusertask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess4.FlowElements.Add(exclusivegateway3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaStartMessageEvent deletebuttonclickmessage = CreateDeleteButtonClickMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(deletebuttonclickmessage);
			ProcessSchemaScriptTask deletebuttonclickscripttask = CreateDeleteButtonClickScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(deletebuttonclickscripttask);
			ProcessSchemaUserTask deletecolumnquestion_usertask = CreateDeleteColumnQuestion_UserTaskUserTask();
			eventsubprocess7.FlowElements.Add(deletecolumnquestion_usertask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess7.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask breakdelete_scripttask = CreateBreakDelete_ScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(breakdelete_scripttask);
			ProcessSchemaStartMessageEvent editvaluebuttonclickmessage = CreateEditValueButtonClickMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(editvaluebuttonclickmessage);
			ProcessSchemaScriptTask editvaluebuttonclickscripttask = CreateEditValueButtonClickScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(editvaluebuttonclickscripttask);
			ProcessSchemaUserTask openeditcolumnvaluepage_usertask = CreateOpenEditColumnValuePage_UserTaskUserTask();
			eventsubprocess6.FlowElements.Add(openeditcolumnvaluepage_usertask);
			ProcessSchemaStartMessageEvent addbuttonclickmessage = CreateAddButtonClickMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(addbuttonclickmessage);
			ProcessSchemaScriptTask addbuttonclickscripttask = CreateAddButtonClickScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(addbuttonclickscripttask);
			ProcessSchemaUserTask opencolumnvaluepage_usertask = CreateOpenColumnValuePage_UserTaskUserTask();
			eventsubprocess5.FlowElements.Add(opencolumnvaluepage_usertask);
			ProcessSchemaStartMessageEvent samplingentitycollectionedittoolbuttonclickmessage = CreateSamplingEntityCollectionEditToolButtonClickMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(samplingentitycollectionedittoolbuttonclickmessage);
			ProcessSchemaScriptTask samplingentitycollectionedittoolbuttonclickscript = CreateSamplingEntityCollectionEditToolButtonClickScriptScriptTask();
			eventsubprocess8.FlowElements.Add(samplingentitycollectionedittoolbuttonclickscript);
			ProcessSchemaStartMessageEvent columnvalueeditpageclosedmessage = CreateColumnValueEditPageClosedMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(columnvalueeditpageclosedmessage);
			ProcessSchemaScriptTask columnvalueeditpageclosedscript = CreateColumnValueEditPageClosedScriptScriptTask();
			eventsubprocess9.FlowElements.Add(columnvalueeditpageclosedscript);
			ProcessSchemaStartMessageEvent columnvaluestreegriddblclick_startmessage = CreateColumnValuesTreeGridDblClick_StartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(columnvaluestreegriddblclick_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent columnvaluestreegriddblclick = CreateColumnValuesTreeGridDblClickIntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(columnvaluestreegriddblclick);
			ProcessSchemaStartMessageEvent deletecolumnyesmessage_startmessage = CreateDeleteColumnYesMessage_StartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(deletecolumnyesmessage_startmessage);
			ProcessSchemaScriptTask deletecolumn_scripttask = CreateDeleteColumn_ScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(deletecolumn_scripttask);
			ProcessSchemaStartMessageEvent changeaddmodeyesstartmessage = CreateChangeAddModeYesStartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(changeaddmodeyesstartmessage);
			ProcessSchemaScriptTask changeaddmodeyesmessagescript = CreateChangeAddModeYesMessageScriptScriptTask();
			eventsubprocess12.FlowElements.Add(changeaddmodeyesmessagescript);
			ProcessSchemaStartMessageEvent changeaddmodenostartmessage = CreateChangeAddModeNoStartMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(changeaddmodenostartmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess13.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateCaptionColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateValueColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteColumnMessageLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTextNewRowLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTextFilterParamsEmptyLocalizableString());
			LocalizableStrings.Add(CreateSelectAddModeMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("98cae5c7-4a8a-4d55-9c14-7f6bb76e86b3"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("58aa7bbd-bcba-4b30-9973-a01cddc8bb34"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValueColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e9677bbb-c12e-4a59-9a81-985b1e2ca38e"),
				Name = "ValueColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteColumnMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bb23dabc-9ab3-45ab-8d9b-f32d2404fe29"),
				Name = "DeleteColumnMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b2e34524-24f0-4782-a566-1ee48c8a255e"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextNewRowLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("998beff3-c94c-4b5f-b886-eed0684c280f"),
				Name = "ValidationMessageTextNewRow",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextFilterParamsEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("87779770-237f-429f-ac2f-d54d436185f0"),
				Name = "ValidationMessageTextFilterParamsEmpty",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSelectAddModeMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("08ca66bc-6a0c-489c-be19-95b42f71b5d1"),
				Name = "SelectAddModeMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c37f3b75-db8c-4511-a4e3-44c6be222e0e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dbb75089-e32b-4793-ace6-61425cbe3160"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63630b3a-781f-4567-adb5-64528bc940de"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4eb7b004-eb4c-4495-9dd6-23bdd7599527"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(159, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a6f1bd64-41df-409b-8744-d602546f5eb0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("beb7ac45-c97a-4fd1-b230-a49e66ef36bc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d668ae56-dd07-4645-b1d3-c1fd34f403fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(276, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("beb7ac45-c97a-4fd1-b230-a49e66ef36bc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9dfe73a0-3012-4cca-8f8f-42e10defbe12"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("f7c83af2-62ec-471d-aac1-b8d02dce3dd3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(558, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d538ec58-680b-4d47-8f08-9bf063455a71"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("66903d77-49c7-4476-880e-699300365782"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("342f74b2-47ac-4637-a883-cf51ec51939c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(668, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("66903d77-49c7-4476-880e-699300365782"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("812a8c25-1e13-4f25-9d5d-dcf59b93b499"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("834eb206-3721-419d-908f-4cb1473819b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(141, 273),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2a0b340-01f2-48c5-b686-5f7c605e04ca"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3078fa48-528b-4de1-b0bd-affc166895c8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("b37026c7-ff55-471d-9d27-a3aa806cfae2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(262, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3078fa48-528b-4de1-b0bd-affc166895c8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("32f449e1-1d24-440b-b590-9d9ef1ad3229"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("11b4cbb1-a1df-480b-9596-2e05022bd106"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(153, 330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cbb7a67d-7f49-4f4c-b835-66a4eb36d4c8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("add336fe-4405-4dd4-b844-4e2a47b3726c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("430f921f-26d2-496e-93ff-c5517829411e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(553, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ead69206-954b-488e-8043-70bc1f41a8fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("ad5556e5-9bec-41c2-ad8d-4548de7d526d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(162, 588),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c112a537-8043-4dda-806e-db5115f32dc5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2eb442c0-dbff-417a-ac72-3264ed60beef"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("01bb1a6f-d71f-4eaf-8174-00c4e56ad80c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(461, 588),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4945cbf7-719e-47e2-b001-f8db768ce20d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("24b3eb9b-edf2-4808-ad8e-2ec7e1a5ed0f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("3b09504d-2707-40e4-9883-f7d32f1d87cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b76156a7-072e-4796-8ee5-ed1f3c515210"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a0e3897a-18f1-47c0-9be5-0c287c204360"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("41a37e89-082f-419b-9100-3ab6effeb227"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56a02fb8-13f2-4d9b-8601-82f7db8cab05"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("befa76ec-02b8-4516-a55d-0a5cc71ed348"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("1ea944a4-ee78-496a-8b4f-f9b7a2bb03cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f0fd6322-7fcb-45af-845d-6fcbc3a828c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58653b18-7e26-4e68-9cd3-643748fad3a9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("4d581c65-9d68-4ad7-936e-a6dddafd3668"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(174, 947),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("233d2354-0acf-4420-a592-80a1b302c7c9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("943b1cfe-1767-4270-9d82-fd70ce238bdf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("7d354293-e31d-4bf6-be77-a7ca0a591ff6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(310, 444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("add336fe-4405-4dd4-b844-4e2a47b3726c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a34bd0ab-e228-4664-8b53-e90b124fdc9d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("609fa422-2d3a-48ad-8cef-663b014b027e"),
				ConditionExpression = @"IsEditingSamplingEntityCollection ? !IsNewSamplingEntityCollection : !IsNew",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(434, 444),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a34bd0ab-e228-4664-8b53-e90b124fdc9d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ead69206-954b-488e-8043-70bc1f41a8fa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("2347310d-330f-4fb2-8c2c-a1d8c840936e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(417, 515),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a34bd0ab-e228-4664-8b53-e90b124fdc9d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b8a4a5e2-a52f-4dc7-9fee-e40b7065f4b8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("ab5d0813-8926-44e6-94b8-d26e2b1cda0f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(314, 259),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a0e3897a-18f1-47c0-9be5-0c287c204360"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("b15b28b6-2710-4d52-a0ca-43ca3fd17627"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(560, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d9ee863f-c591-4d9c-8559-c50694b46f98"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b31c581-d91b-49dd-b5d9-0baf9c9cc23b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("35db7c7e-f3e3-4499-a469-74375e260fac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(316, 432),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("befa76ec-02b8-4516-a55d-0a5cc71ed348"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("1fb400b0-84db-4db4-aff5-f9baee6bdbd4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(546, 440),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e5ec48ff-5bed-476c-ab2d-2253976515a6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e1615ef6-12dc-4caf-89cc-703a30d98877"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("990af13c-3a55-459d-b845-1f4b0ac3bb65"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(900, 606),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bd92dae0-a3aa-4f58-8843-842fae7d8a19"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow25",
				UId = new Guid("442e1be4-d027-48f6-9505-9b107bf4baba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(652, 658),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58653b18-7e26-4e68-9cd3-643748fad3a9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d521d6ea-acc8-4a87-935d-c76007771f57"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("8dfda6f2-1c22-4c01-910a-7c9cbff51d55"),
				ConditionExpression = @"Page.ColumnValuesTreeGrid.SelectedNodes.Count > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(730, 604),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58653b18-7e26-4e68-9cd3-643748fad3a9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bd92dae0-a3aa-4f58-8843-842fae7d8a19"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("57c6e2b6-616b-4afa-a6c2-e1f5cec1b5ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(753, 614),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eda23f51-74b6-446f-afdb-bfda8c7970f9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("925e9682-6397-47a0-8d06-d80cbc6b309c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("6e5bd1a8-768b-429a-969b-c4fa0aeee10a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(689, 1782),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("812a8c25-1e13-4f25-9d5d-dcf59b93b499"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("125aa3bc-94fd-46bb-98b1-2fb510b0d36e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow28",
				UId = new Guid("3c6d179f-c1fe-49fd-a9e4-f5cb992cf1d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(385, 152),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("193ab86d-c35f-4554-8619-ace47d42c7a8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7cbde5ef-d099-45ee-afec-08bf056b367a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("4d912e89-02c1-4a6f-a419-ee846232cc3b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(681, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("654d0935-beb0-483d-bde1-b6cee71af318"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a7f7ab66-1070-4f1b-916e-aaaca1d095ec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("18adc748-5a27-4616-881c-18663d43dace"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(679, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18e7ece9-a5bc-4c95-b0ff-191fdb963d47"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("61edf8c7-b36f-4f68-8df8-9b9aa49f1be3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d193cd4a-ce86-4d0b-8821-acbc8a3c66e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(170, 87),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("664cccca-bfee-499f-aae6-d24181a00195"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("193ab86d-c35f-4554-8619-ace47d42c7a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("c8b73978-656b-4288-8f3f-ade95849c44b"),
				ConditionExpression = @"IsSelectedSamplingAddMode && !Page.AddSamplingRecordsRadioButton.Checked && !IsNewSamplingEntityCollection",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(280, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("193ab86d-c35f-4554-8619-ace47d42c7a8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("658db6c9-757b-4b36-92f0-4865c5acc544"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("fa71740a-aa26-4594-9685-ccdaa80f4d98"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CurveCenterPosition = new Point(424, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("658db6c9-757b-4b36-92f0-4865c5acc544"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4dd5b8b8-e660-4ca7-94e5-753d59fe3bb9"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1246, 2043),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("4dd5b8b8-e660-4ca7-94e5-753d59fe3bb9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"Lane1",
				Position = new Point(29, 338),
				Size = new Size(1217, 611),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("719c1ecf-a0c3-4d64-a323-54098da4e815"),
				ContainerItemIndex = 5,
				ContainerUId = new Guid("4dd5b8b8-e660-4ca7-94e5-753d59fe3bb9"),
				CreatedInOwnerSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1866),
				Size = new Size(1217, 177),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("6bd8d6d8-5409-4573-9b56-a4def716ba88"),
				ContainerItemIndex = 4,
				ContainerUId = new Guid("4dd5b8b8-e660-4ca7-94e5-753d59fe3bb9"),
				CreatedInOwnerSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 1658),
				Size = new Size(1217, 203),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("b867e0f9-d2b2-42a9-85be-f73294a65751"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("4dd5b8b8-e660-4ca7-94e5-753d59fe3bb9"),
				CreatedInOwnerSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 954),
				Size = new Size(1217, 699),
				UseBackgroundMode = false
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("a32a77a7-46cf-4c1f-a7a2-8ea99c0a0ae4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4dd5b8b8-e660-4ca7-94e5-753d59fe3bb9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"Lane5",
				Position = new Point(29, 0),
				Size = new Size(1217, 333),
				UseBackgroundMode = false
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessOnInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessOnInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7ea0ac05-e134-4fce-99d2-ab529cf99cbb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("719c1ecf-a0c3-4d64-a323-54098da4e815"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcessOnInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessOnInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a6f1bd64-41df-409b-8744-d602546f5eb0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ea0ac05-e134-4fce-99d2-ab529cf99cbb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("beb7ac45-c97a-4fd1-b230-a49e66ef36bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ea0ac05-e134-4fce-99d2-ab529cf99cbb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IntermediateThrowMessageEventInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChildInitScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9dfe73a0-3012-4cca-8f8f-42e10defbe12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7ea0ac05-e134-4fce-99d2-ab529cf99cbb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChildInitScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,193,78,195,48,12,61,51,105,255,80,56,181,210,212,31,24,32,109,221,64,59,48,208,54,118,183,154,183,17,72,147,226,184,176,10,241,239,36,29,12,208,224,148,216,241,123,207,126,78,193,32,65,225,76,83,217,53,153,6,126,173,124,154,13,251,61,189,73,210,211,233,78,242,153,31,61,210,110,129,231,240,40,89,242,214,239,157,220,17,83,5,1,79,72,168,131,173,218,26,247,51,149,92,36,247,30,92,56,107,81,138,118,54,255,85,113,67,150,182,224,252,26,50,19,84,227,118,30,104,210,179,169,21,45,109,104,194,236,65,191,48,103,89,30,136,135,157,234,22,249,74,139,193,84,105,201,87,216,73,208,155,26,84,176,50,199,107,65,117,68,199,210,23,226,68,97,179,159,40,20,77,176,161,198,200,103,76,62,153,232,78,137,184,61,247,194,218,110,7,201,29,187,18,222,47,203,7,84,116,152,176,131,92,70,206,9,188,222,218,27,167,80,24,242,62,132,37,235,90,92,84,58,92,163,212,33,136,58,255,129,34,227,149,54,38,168,214,96,105,227,204,75,215,112,137,116,127,12,126,208,102,95,51,213,71,213,65,241,152,34,42,175,53,75,67,230,59,25,57,142,241,249,18,82,24,29,28,28,5,71,94,176,112,175,221,250,79,198,218,170,232,179,99,159,134,125,125,94,99,54,184,149,102,131,63,122,25,124,123,158,29,22,54,82,234,214,98,129,210,177,90,144,210,110,220,136,132,143,81,60,160,124,66,252,49,194,77,108,238,189,223,99,72,195,118,159,248,0,73,128,153,181,154,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOnPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOnPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eabde8b3-98d9-48f6-bec6-1f07256af1f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("719c1ecf-a0c3-4d64-a323-54098da4e815"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"OnPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(315, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(444, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOnPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d538ec58-680b-4d47-8f08-9bf063455a71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eabde8b3-98d9-48f6-bec6-1f07256af1f3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"StartMessagePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventPageLoadCompleteIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("66903d77-49c7-4476-880e-699300365782"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eabde8b3-98d9-48f6-bec6-1f07256af1f3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IntermediateThrowMessageEventPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("812a8c25-1e13-4f25-9d5d-dcf59b93b499"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eabde8b3-98d9-48f6-bec6-1f07256af1f3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(224, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,77,111,219,56,16,61,187,64,255,3,147,67,33,1,134,122,111,154,22,137,237,22,238,54,109,16,39,221,67,145,3,43,141,28,238,202,162,65,82,217,122,219,252,247,29,126,72,166,37,81,86,14,123,8,34,139,195,55,143,195,153,55,163,69,169,152,218,205,120,81,64,170,24,47,175,64,209,107,170,30,200,57,145,74,176,114,157,44,54,91,181,59,123,249,98,209,178,156,51,185,45,232,238,27,45,42,232,90,175,232,102,91,224,139,246,174,48,126,104,199,176,159,71,42,136,76,31,96,67,113,237,3,43,179,57,72,182,46,33,187,22,60,5,41,87,102,45,138,209,244,154,174,33,249,192,10,5,98,145,49,149,172,64,29,26,89,156,62,211,139,245,90,192,154,106,58,139,146,254,40,52,145,156,22,18,28,131,44,199,23,115,200,105,85,40,67,84,18,42,201,156,153,3,80,177,123,107,89,79,201,129,195,107,42,232,6,208,135,217,242,14,177,88,78,34,141,117,78,202,170,40,98,242,235,229,139,137,0,85,137,146,40,81,105,111,79,214,33,180,130,132,238,179,252,251,105,59,118,167,247,14,180,107,63,232,34,138,110,65,8,42,121,174,146,187,101,242,39,252,152,241,82,9,94,200,68,135,38,54,241,185,144,91,243,35,153,85,82,241,205,156,42,218,101,176,95,251,3,118,167,247,200,243,147,228,37,198,94,48,90,176,127,161,195,44,14,48,78,110,32,7,1,101,10,54,120,119,203,140,156,156,147,143,21,203,108,50,216,163,180,253,239,141,207,59,65,235,129,60,235,129,240,82,182,131,96,110,174,111,83,43,107,63,154,92,219,130,80,59,183,162,17,47,119,24,135,71,16,181,135,200,51,59,92,185,220,205,10,134,222,27,203,126,38,113,60,142,203,144,69,52,180,56,37,161,232,24,207,38,47,218,22,183,240,83,153,42,210,15,232,127,8,95,131,188,126,61,12,99,43,48,219,107,193,82,126,193,84,254,42,76,26,12,210,143,201,123,147,229,228,141,43,95,157,238,4,240,201,36,15,2,193,63,136,123,88,107,50,32,76,174,230,66,186,213,212,94,120,255,255,84,131,33,70,71,107,49,196,52,62,114,146,100,197,43,145,130,174,199,1,129,179,70,201,23,94,2,121,245,10,143,60,9,226,141,171,245,208,57,253,154,127,134,139,179,1,72,191,109,133,16,155,4,30,217,201,70,106,130,14,212,120,93,24,102,23,183,171,84,39,131,187,23,63,106,71,35,251,188,99,14,202,205,24,152,105,144,81,87,126,66,150,109,25,26,227,215,147,163,163,176,71,100,105,140,187,142,60,161,123,11,70,114,51,140,72,167,57,251,107,179,67,138,60,189,223,167,159,174,212,147,94,14,14,36,182,229,51,209,226,246,23,42,0,234,10,166,20,174,32,122,137,2,216,65,255,228,27,69,119,18,4,254,42,45,127,156,105,90,195,210,126,187,185,20,227,198,122,62,208,78,163,61,56,173,53,234,227,216,77,137,218,109,129,231,81,155,134,167,71,83,162,129,39,154,236,103,38,213,219,3,130,239,200,175,214,177,158,98,51,142,5,241,206,38,26,78,199,173,195,243,196,215,232,73,160,116,102,149,64,41,81,43,188,187,20,85,188,142,134,76,46,178,172,3,105,131,130,2,111,254,150,37,83,246,252,251,8,70,3,85,250,153,211,172,241,99,12,219,253,43,148,104,157,190,198,228,10,244,26,100,245,22,164,123,197,51,104,100,219,101,219,50,100,104,90,92,112,21,119,71,99,124,216,8,147,223,191,251,11,231,56,68,173,109,24,129,247,182,112,240,233,13,113,247,159,220,242,75,206,11,160,229,120,168,250,19,0,151,191,150,112,3,41,23,217,13,205,24,191,172,148,194,180,157,61,64,250,183,169,245,147,224,241,61,140,122,197,2,201,126,164,163,64,161,139,213,41,115,139,39,116,136,123,29,26,66,196,143,159,122,156,168,59,139,219,24,5,183,233,176,160,219,106,83,218,111,28,13,128,234,135,195,4,113,205,25,211,79,255,143,98,12,250,202,92,166,73,81,157,109,169,183,177,214,153,231,125,31,53,80,40,25,96,74,38,155,125,171,21,209,134,22,63,193,172,7,79,15,141,28,174,250,50,235,0,199,137,162,161,250,136,167,108,138,166,9,55,210,191,162,219,45,226,120,109,213,19,48,219,206,14,65,117,33,231,28,223,164,15,36,178,216,132,149,190,7,167,44,126,120,190,167,143,137,243,231,186,155,158,213,240,101,35,241,79,166,136,15,133,24,231,56,41,117,67,209,51,96,255,53,25,24,111,5,161,92,251,241,237,77,156,253,113,244,63,198,50,110,131,36,16,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateAddNotNullColumns_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("125aa3bc-94fd-46bb-98b1-2fb510b0d36e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eabde8b3-98d9-48f6-bec6-1f07256af1f3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"AddNotNullColumns_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(350, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,113,47,202,76,9,207,44,201,240,203,47,241,43,205,201,113,206,207,41,205,205,43,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,228,99,150,137,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickChildSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickChildSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3229c544-47f9-43c1-aee0-ea95b9e282c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6bd8d6d8-5409-4573-9b56-a4def716ba88"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"OkButtonClickChildSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 175),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickChildSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c2a0b340-01f2-48c5-b686-5f7c605e04ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3229c544-47f9-43c1-aee0-ea95b9e282c7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3078fa48-528b-4de1-b0bd-affc166895c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3229c544-47f9-43c1-aee0-ea95b9e282c7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"OkButtonClickChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,77,111,219,48,12,61,39,64,254,131,224,147,11,4,238,206,235,178,97,77,178,32,27,18,4,117,219,203,176,131,102,51,141,54,89,50,36,217,93,182,246,191,151,146,236,36,118,154,143,13,216,173,165,30,249,200,199,103,102,204,33,3,97,230,240,56,164,185,97,82,144,1,89,208,7,136,110,153,225,48,78,153,137,110,225,151,185,234,117,75,170,136,144,2,238,99,11,81,50,1,173,227,100,5,25,93,80,69,51,48,160,238,41,47,32,150,133,74,32,154,35,180,202,74,164,208,230,204,180,161,195,218,64,149,156,209,60,103,226,225,204,244,153,71,87,185,121,13,209,14,227,70,107,70,168,38,35,150,216,185,169,90,191,211,70,97,114,255,24,207,123,44,205,150,36,220,43,61,32,162,224,252,130,252,233,117,59,109,150,193,43,120,34,224,241,111,185,195,139,11,164,127,238,117,99,90,194,88,24,102,214,67,201,57,184,34,77,108,155,176,79,130,118,66,208,39,237,208,12,12,114,154,213,254,139,239,231,110,154,218,14,70,212,80,47,248,39,198,145,98,11,35,203,86,0,209,126,50,162,65,49,202,217,111,72,219,73,78,210,208,185,238,99,154,198,52,203,57,38,220,64,34,85,170,111,104,202,228,117,97,140,20,209,112,5,201,79,72,189,200,109,166,218,184,190,186,115,238,182,79,140,138,138,87,79,148,44,242,235,245,28,229,9,131,45,58,176,147,117,172,109,126,104,41,208,135,37,40,124,170,55,213,26,89,127,222,5,133,119,218,182,34,132,111,165,127,164,19,199,114,88,11,164,179,149,163,184,70,132,237,57,251,205,254,156,35,8,112,13,78,149,90,189,67,155,197,250,126,31,209,56,203,205,250,234,72,202,102,229,152,51,41,88,122,58,99,196,116,206,233,186,118,120,155,232,149,141,217,111,230,164,32,21,232,95,125,127,168,91,244,255,41,181,250,231,200,99,55,240,93,74,78,152,158,215,247,113,127,84,63,6,121,122,218,123,195,155,87,8,99,17,111,176,82,171,255,175,193,158,243,130,111,149,39,143,156,138,208,127,35,51,153,178,37,131,116,218,88,166,117,228,230,127,55,162,43,143,47,155,9,62,212,167,254,109,125,189,45,174,94,236,14,108,119,199,8,62,188,71,220,31,78,119,121,73,98,48,88,147,23,153,32,165,173,167,235,31,9,27,114,12,186,154,111,163,56,62,84,135,125,91,47,180,178,47,165,2,154,172,72,248,5,188,235,22,148,169,179,78,41,73,74,194,4,153,128,25,238,16,227,129,117,186,237,54,99,111,82,120,160,157,169,129,172,146,186,211,80,248,144,87,172,138,157,170,196,246,139,76,202,8,7,112,111,181,196,24,114,127,98,236,185,58,250,123,206,240,23,114,4,75,223,232,127,244,69,67,143,173,93,79,216,164,145,181,57,104,85,31,222,15,10,76,161,4,49,10,127,239,95,0,64,197,110,89,139,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("32f449e1-1d24-440b-b590-9d9ef1ad3229"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3229c544-47f9-43c1-aee0-ea95b9e282c7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b867e0f9-d2b2-42a9-85be-f73294a65751"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(632, 267),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cbb7a67d-7f49-4f4c-b835-66a4eb36d4c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EntityCollectionEditChange",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNewEntityCollectionParameterValueScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("add336fe-4405-4dd4-b844-4e2a47b3726c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"NewEntityCollectionParameterValueScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,45,119,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,72,44,74,204,77,45,73,45,10,75,204,41,77,85,176,85,240,42,206,207,211,11,78,45,202,76,204,201,172,74,213,72,206,207,43,73,173,40,209,11,201,40,202,47,119,45,75,205,43,113,44,74,47,214,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,207,202,118,138,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeEntityCollectionQuestionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ead69206-954b-488e-8043-70bc1f41a8fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"PrepareChangeEntityCollectionQuestionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(393, 48),
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
				UId = new Guid("f424597d-f4c8-4606-a572-56e0451a2b6c"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeEntityCollectionUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(526, 48),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeEntityCollectionUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a34bd0ab-e228-4664-8b53-e90b124fdc9d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b8a4a5e2-a52f-4dc7-9fee-e40b7065f4b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bf10bffb-86f6-48e7-883c-a7b37e4a3e82"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(393, 174),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fbe9ecf9-94e5-48fb-89c9-9fa341fc5202"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b867e0f9-d2b2-42a9-85be-f73294a65751"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcessChangeEntityCollectionYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 336),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionYesMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c112a537-8043-4dda-806e-db5115f32dc5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fbe9ecf9-94e5-48fb-89c9-9fa341fc5202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionYesMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeEntityCollectionYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2eb442c0-dbff-417a-ac72-3264ed60beef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fbe9ecf9-94e5-48fb-89c9-9fa341fc5202"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeEntityCollectionYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,204,75,79,117,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,182,115,214,243,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeEntityCollectionNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeEntityCollectionNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a4cf6e68-db03-4cba-89d7-b09254fa5abe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b867e0f9-d2b2-42a9-85be-f73294a65751"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcessChangeEntityCollectionNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 335),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeEntityCollectionNoMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeEntityCollectionNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4945cbf7-719e-47e2-b001-f8db768ce20d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a4cf6e68-db03-4cba-89d7-b09254fa5abe"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeEntityCollectionNoMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeEntityCollectionNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeEntityCollectionNoMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("24b3eb9b-edf2-4808-ad8e-2ec7e1a5ed0f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a4cf6e68-db03-4cba-89d7-b09254fa5abe"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeEntityCollectionNoMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,240,44,118,77,201,44,201,204,75,15,78,204,45,200,1,210,174,121,37,153,37,149,206,249,57,57,169,201,37,153,249,121,154,10,213,188,92,156,1,137,233,169,122,184,148,132,164,86,148,128,76,209,3,49,20,108,21,112,169,115,201,44,46,200,73,172,12,75,204,41,77,181,230,229,170,85,72,205,41,78,69,24,79,200,88,66,198,241,114,21,165,150,148,22,229,41,148,20,1,5,0,98,218,111,5,220,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3f2033cf-80c4-4ed1-bfc5-fdfadeae37b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b867e0f9-d2b2-42a9-85be-f73294a65751"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess2",
				Position = new Point(302, 504),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(297, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntityCollectionEditToolButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dbb75089-e32b-4793-ace6-61425cbe3160"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f2033cf-80c4-4ed1-bfc5-fdfadeae37b8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EntityCollectionEditToolButtonClickMessage",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("63630b3a-781f-4567-adb5-64528bc940de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f2033cf-80c4-4ed1-bfc5-fdfadeae37b8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EntityCollectionEditToolButtonClickScript",
				Position = new Point(154, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,191,10,131,48,16,198,247,66,223,33,56,181,32,190,128,116,74,29,28,10,66,10,157,143,120,77,2,231,69,226,137,246,237,155,172,153,190,225,247,253,27,183,97,14,18,216,25,88,86,202,58,176,4,249,233,72,132,86,66,100,245,80,95,160,13,251,235,197,248,120,24,235,113,1,35,105,183,178,39,28,206,149,98,194,84,74,62,129,231,120,220,234,130,23,10,76,32,190,85,106,2,135,93,205,223,120,74,137,119,154,2,178,140,207,86,53,181,167,112,237,129,29,54,247,124,36,97,222,102,149,79,96,255,7,31,246,188,195,193,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a32a77a7-46cf-4c1f-a7a2-8ea99c0a0ae4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess4",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(479, 253),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddSamplingRecordsRadioButtonCheckMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("664cccca-bfee-499f-aae6-d24181a00195"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddSamplingRecordsRadioButtonCheck",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"AddSamplingRecordsRadioButtonCheckMessage",
				Position = new Point(35, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddSamplingRecordsRadioButtonCheckScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("658db6c9-757b-4b36-92f0-4865c5acc544"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"AddSamplingRecordsRadioButtonCheckScript",
				Position = new Point(245, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,206,207,10,130,64,16,6,240,115,130,239,176,236,89,122,1,43,232,143,7,15,106,165,30,60,138,14,38,197,108,236,140,148,136,239,222,90,22,68,121,154,195,252,190,111,102,123,202,177,130,117,89,6,170,132,148,64,39,57,157,231,251,188,2,177,20,195,112,109,107,251,215,4,64,100,246,9,220,217,208,24,46,80,240,104,198,213,100,212,47,20,154,140,60,164,94,156,248,81,40,39,229,166,97,86,72,3,206,188,56,140,166,229,17,232,106,228,251,246,16,65,184,137,93,93,112,173,48,215,237,130,88,215,88,57,226,53,87,162,179,173,89,39,91,32,233,8,249,85,154,1,141,53,178,119,158,10,213,15,10,213,199,216,86,111,254,210,192,141,70,193,186,1,247,1,42,121,181,154,87,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAddModeUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5bffa94f-63d9-48b8-b9b5-c89a90cb9acc"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeAddModeUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(392, 41),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeAddModeUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("193ab86d-c35f-4554-8619-ace47d42c7a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(119, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7cbde5ef-d099-45ee-afec-08bf056b367a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6f4c61bf-a94d-4bf2-8a5f-72d109771507"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeAddModeYesMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(343, 160),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 364),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(564, 233),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f0fd6322-7fcb-45af-845d-6fcbc3a828c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"DeleteButtonClickMessage",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bd92dae0-a3aa-4f58-8843-842fae7d8a19"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"DeleteButtonClickScriptTask",
				Position = new Point(316, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,177,14,130,64,16,68,107,73,248,135,203,213,196,31,64,45,20,11,10,65,4,10,42,67,200,134,16,113,207,220,238,69,9,225,223,61,148,130,88,72,53,197,188,55,153,0,90,96,56,168,214,220,49,49,64,220,40,188,230,4,58,43,233,182,62,151,53,136,173,24,195,119,157,224,47,123,2,34,203,101,240,98,171,204,217,169,89,92,8,43,133,86,149,73,126,76,179,48,142,228,162,177,55,204,10,105,148,138,99,26,197,203,198,5,232,97,13,152,62,141,42,194,83,4,77,53,114,165,238,54,196,186,193,218,19,223,220,137,222,117,86,189,236,128,164,39,228,124,188,0,154,86,228,224,125,32,84,191,76,164,230,200,96,239,105,96,163,81,176,54,224,191,1,125,164,18,38,125,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateDeleteColumnQuestion_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4a981df9-fa47-48b4-ad12-8d5f0f5c05ca"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"DeleteColumnQuestion_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(448, 35),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeDeleteColumnQuestion_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("58653b18-7e26-4e68-9cd3-643748fad3a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateBreakDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d521d6ea-acc8-4a87-935d-c76007771f57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ebe62e92-2822-4965-a763-0455196cf85b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"BreakDelete_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(154, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c0ce10c7-ec89-4570-bf65-9be0f02a5d92"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess6",
				Position = new Point(35, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(377, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditValueButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("56a02fb8-13f2-4d9b-8601-82f7db8cab05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0ce10c7-ec89-4570-bf65-9be0f02a5d92"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditValueButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EditValueButtonClickMessage",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEditValueButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("befa76ec-02b8-4516-a55d-0a5cc71ed348"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0ce10c7-ec89-4570-bf65-9be0f02a5d92"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EditValueButtonClickScriptTask",
				Position = new Point(133, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,79,79,132,48,16,197,207,146,240,29,26,78,112,128,229,192,174,108,136,38,134,24,194,65,221,68,240,98,140,41,244,97,136,221,98,250,71,15,198,239,110,139,104,246,224,129,75,211,153,121,243,123,211,78,35,129,74,142,236,118,98,32,194,29,23,68,24,206,11,223,27,7,18,30,232,11,146,114,226,230,40,30,40,55,80,205,162,79,238,193,209,107,204,141,202,74,140,208,228,146,164,17,249,244,189,179,5,180,178,251,49,125,178,118,95,196,247,192,21,102,128,132,54,82,144,129,218,132,171,249,222,221,27,196,53,27,245,9,206,225,159,91,5,217,80,245,154,56,1,100,45,148,166,162,71,205,172,255,111,208,214,172,88,65,176,151,210,72,9,161,175,122,61,190,207,85,75,209,210,96,77,187,139,218,217,87,224,131,84,102,100,97,192,186,125,70,183,123,22,247,125,191,139,179,142,110,227,28,93,26,163,59,103,67,71,119,121,150,231,65,84,108,54,39,84,103,226,88,235,134,46,249,164,112,3,165,126,134,13,254,1,205,18,22,172,125,195,129,74,122,132,134,84,150,87,65,255,229,84,232,246,26,89,206,178,158,249,103,190,1,7,155,7,87,66,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditColumnValuePage_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("745c1eec-fb83-47c0-811c-6483b3162c43"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0ce10c7-ec89-4570-bf65-9be0f02a5d92"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"OpenEditColumnValuePage_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(273, 42),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenEditColumnValuePage_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("82309a82-ac22-4a3f-a10b-2c5c76c7d875"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess5",
				Position = new Point(35, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b76156a7-072e-4796-8ee5-ed1f3c515210"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82309a82-ac22-4a3f-a10b-2c5c76c7d875"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"AddButtonClickMessage",
				Position = new Point(36, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a0e3897a-18f1-47c0-9be5-0c287c204360"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82309a82-ac22-4a3f-a10b-2c5c76c7d875"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"AddButtonClickScriptTask",
				Position = new Point(134, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,49,111,194,48,16,133,247,74,252,135,40,83,50,4,58,36,33,17,98,168,162,10,101,64,97,104,88,209,217,126,160,8,99,170,179,13,127,191,38,168,85,135,10,186,221,221,187,247,221,211,117,159,48,205,89,251,147,217,146,246,216,208,1,187,222,130,63,200,30,167,93,16,193,173,177,142,140,68,171,162,101,244,221,244,173,90,76,94,186,71,238,80,52,158,25,198,189,73,55,92,70,53,16,28,123,60,179,222,186,126,188,103,112,141,86,126,80,73,172,68,157,83,81,171,76,74,89,102,185,160,34,171,32,94,51,136,185,218,11,42,171,188,170,226,116,17,205,102,191,176,239,106,112,55,216,243,180,141,62,91,172,97,237,61,101,252,7,100,92,81,241,127,194,111,136,233,4,7,182,129,181,130,251,153,217,196,120,173,211,192,96,56,207,230,254,142,47,180,220,154,173,134,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenColumnValuePage_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5464ac1b-c1b8-47a9-a8b6-93adb3005241"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("82309a82-ac22-4a3f-a10b-2c5c76c7d875"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"OpenColumnValuePage_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 35),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenColumnValuePage_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6cfbee65-14c3-4759-ac3b-1298cb73eaa9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b867e0f9-d2b2-42a9-85be-f73294a65751"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess8",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 504),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSamplingEntityCollectionEditToolButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("233d2354-0acf-4420-a592-80a1b302c7c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cfbee65-14c3-4759-ac3b-1298cb73eaa9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SamplingEntityCollectionEditToolButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"SamplingEntityCollectionEditToolButtonClickMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSamplingEntityCollectionEditToolButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("943b1cfe-1767-4270-9d82-fd70ce238bdf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6cfbee65-14c3-4759-ac3b-1298cb73eaa9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"SamplingEntityCollectionEditToolButtonClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,10,194,48,16,68,239,130,255,16,122,82,40,253,1,241,20,115,232,65,40,68,240,188,164,75,178,144,110,74,186,165,245,239,77,240,38,244,52,48,51,60,94,191,152,145,132,216,91,152,230,88,210,176,144,124,116,138,17,157,80,98,117,87,146,87,188,157,79,54,164,205,186,128,19,216,210,56,89,51,154,125,142,41,99,174,140,55,241,152,182,203,17,231,137,2,3,72,104,149,26,192,99,119,244,123,225,46,21,215,233,72,200,210,63,90,213,252,127,234,174,3,176,199,230,90,196,50,22,23,254,105,126,1,87,150,47,219,208,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f7b751e6-1286-4eb7-ab66-e03560c68ef0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 28),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(253, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValueEditPageClosedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d9ee863f-c591-4d9c-8559-c50694b46f98"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7b751e6-1286-4eb7-ab66-e03560c68ef0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValueEditPageClosed",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ColumnValueEditPageClosedMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnValueEditPageClosedScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4b31c581-d91b-49dd-b5d9-0baf9c9cc23b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7b751e6-1286-4eb7-ab66-e03560c68ef0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ColumnValueEditPageClosedScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,204,43,78,45,42,9,202,47,119,206,207,41,205,205,11,75,204,41,77,85,176,85,208,40,46,41,202,204,75,215,12,5,202,58,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,151,196,146,196,104,79,176,206,212,20,36,141,222,169,149,177,214,188,92,184,53,233,5,165,230,230,151,165,106,96,215,171,9,212,27,144,152,158,170,231,152,146,18,156,92,148,89,80,162,129,205,121,32,101,69,169,37,165,69,121,10,37,69,165,169,214,0,208,185,248,233,199,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("924edebf-db4d-4552-a4d5-9281d9042f99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(427, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(225, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValuesTreeGridDblClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e5ec48ff-5bed-476c-ab2d-2253976515a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("924edebf-db4d-4552-a4d5-9281d9042f99"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValuesTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ColumnValuesTreeGridDblClick_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateColumnValuesTreeGridDblClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e1615ef6-12dc-4caf-89cc-703a30d98877"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("924edebf-db4d-4552-a4d5-9281d9042f99"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditValueButtonClick",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ColumnValuesTreeGridDblClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("13b05f60-c5f5-4a46-8d8e-4f15a514f2d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("afafe6a5-6c40-4281-8ee5-8a6a98b1b6f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(623, 364),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteColumnYesMessage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eda23f51-74b6-446f-afdb-bfda8c7970f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13b05f60-c5f5-4a46-8d8e-4f15a514f2d9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteColumnYesMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"DeleteColumnYesMessage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteColumn_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("925e9682-6397-47a0-8d06-d80cbc6b309c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13b05f60-c5f5-4a46-8d8e-4f15a514f2d9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"DeleteColumn_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,106,195,48,16,68,207,49,248,31,150,156,108,40,250,129,214,189,196,144,67,105,49,117,218,75,200,97,145,55,177,64,150,202,74,54,53,165,255,222,141,221,130,114,237,73,32,102,102,223,204,132,12,218,219,113,112,239,104,71,10,80,193,91,32,222,121,231,72,71,227,157,106,41,4,121,107,140,120,220,37,74,145,68,250,140,79,52,159,0,3,212,102,145,35,207,15,33,178,113,151,59,104,216,107,49,183,186,167,1,27,100,28,40,18,47,238,199,251,60,51,103,40,110,79,87,224,70,107,75,248,202,179,13,83,28,217,65,228,145,68,251,157,103,103,207,132,186,135,98,18,100,231,59,2,227,160,193,11,169,148,234,192,68,123,54,157,96,91,41,64,221,139,40,195,26,121,53,10,130,160,196,94,122,94,51,212,234,58,110,159,127,255,183,39,117,240,237,82,160,40,229,240,38,37,84,175,52,248,137,138,191,144,114,37,251,199,96,213,205,232,18,83,155,240,97,113,78,245,203,253,116,134,31,86,244,62,73,172,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ba8c8335-379a-4528-8a17-e011dae4ec5c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a32a77a7-46cf-4c1f-a7a2-8ea99c0a0ae4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess12",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(532, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(265, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeAddModeYesStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("654d0935-beb0-483d-bde1-b6cee71af318"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8c8335-379a-4528-8a17-e011dae4ec5c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeAddModeYesMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeAddModeYesStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeAddModeYesMessageScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a7f7ab66-1070-4f1b-916e-aaaca1d095ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ba8c8335-379a-4528-8a17-e011dae4ec5c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeAddModeYesMessageScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,78,195,48,12,134,207,155,180,119,8,59,160,86,154,250,2,104,7,232,202,212,195,166,106,221,224,236,53,102,141,150,38,85,226,8,42,196,187,147,182,12,184,100,130,91,156,255,255,108,203,246,81,107,201,132,45,81,98,69,200,75,104,90,41,212,233,158,243,141,230,200,150,172,128,19,38,62,188,40,59,172,180,225,118,7,92,232,7,71,164,85,146,214,88,157,145,223,205,166,37,82,170,21,25,45,109,97,116,139,134,186,76,193,81,34,143,130,53,226,145,59,88,52,123,176,231,2,12,52,72,104,124,34,75,79,32,29,70,243,60,4,207,23,179,233,100,18,204,157,236,117,73,198,199,81,188,96,118,120,37,89,211,82,215,23,21,47,44,10,38,102,183,183,236,38,60,151,94,205,237,22,95,47,66,166,72,80,151,106,217,251,133,86,49,123,247,157,93,181,248,225,146,113,232,59,153,132,44,27,36,40,128,106,111,253,221,253,53,100,37,108,43,161,27,6,247,15,172,172,106,108,224,144,115,207,172,157,224,63,196,112,0,33,108,143,111,148,113,65,73,255,240,232,95,186,234,147,166,18,193,172,128,160,212,206,84,248,40,164,223,184,141,226,111,205,163,174,81,131,255,235,59,87,130,214,70,240,103,65,245,86,211,214,73,57,154,70,253,99,54,13,47,115,25,62,113,143,26,36,103,212,184,140,79,121,124,145,148,16,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5cc2d685-74e4-4cf7-ad1d-f4467f524ff0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a32a77a7-46cf-4c1f-a7a2-8ea99c0a0ae4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"EventSubProcess13",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(532, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeAddModeNoStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18e7ece9-a5bc-4c95-b0ff-191fdb963d47"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cc2d685-74e4-4cf7-ad1d-f4467f524ff0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeAddModeNoMessage",
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ChangeAddModeNoStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("61edf8c7-b36f-4f68-8df8-9b9aa49f1be3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5cc2d685-74e4-4cf7-ad1d-f4467f524ff0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,73,9,78,204,45,200,201,204,75,15,74,77,206,47,74,41,14,74,76,201,204,119,42,45,41,201,207,211,115,206,72,77,206,78,77,81,176,85,40,41,42,77,181,230,229,10,128,234,241,207,75,133,40,199,174,58,45,49,167,24,164,188,40,181,164,180,40,15,162,25,0,190,4,10,121,111,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateShowSchemaStructureExplorerEditWindowMethod());
			Methods.Add(CreateInitializeFilterEditMethod());
			Methods.Add(CreateGetPropertyDisplayPathByServerMetaPathMethod());
			Methods.Add(CreateGetPropertyServerMetaPathByClientMetaPathMethod());
			Methods.Add(CreateChangeEntityCollectionMethod());
			Methods.Add(CreateCreateColumnValuesVdsMethod());
			Methods.Add(CreateSetControlsPropertyEnabledMethod());
			Methods.Add(CreateGetPageParamsMethod());
			Methods.Add(CreateDisplayColumnValuesMethod());
			Methods.Add(CreateGetColumnValuesMethod());
			Methods.Add(CreateGetColumnValuesVdsMethod());
			Methods.Add(CreateInitGridWithNotNullColumnsMethod());
			Methods.Add(CreateGetNotNullColumnIdListMethod());
			Methods.Add(CreateSetUserTaskParameterConstValueMethod());
			Methods.Add(CreateClearDataSourceFiltersMethod());
			Methods.Add(CreateClearColumnValuesMethod());
			Methods.Add(CreateSaveEntityCollectionParameterValueMethod());
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
				UId = new Guid("d6a69048-7888-47be-be62-1e84f707b842"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,223,78,194,48,20,198,175,217,83,212,93,109,9,233,11,16,46,20,9,89,130,196,8,120,95,215,195,92,236,218,165,127,196,197,240,238,158,178,129,14,10,70,111,40,105,207,249,206,239,251,118,94,148,18,164,52,11,216,46,243,87,168,216,244,163,22,74,131,38,99,114,122,49,38,210,9,49,138,202,13,73,2,29,41,249,140,6,103,34,18,182,157,208,210,106,151,91,167,225,240,154,60,178,2,232,74,213,19,37,173,86,98,206,26,229,236,144,196,166,95,31,15,201,134,9,3,221,145,142,162,93,244,206,52,49,191,0,51,115,105,242,117,15,125,93,250,192,36,114,234,5,171,0,103,76,121,105,219,158,31,247,72,68,0,209,2,221,153,204,133,227,192,239,153,101,207,76,56,88,53,53,24,58,17,192,116,178,183,114,218,80,72,60,121,199,37,160,2,105,215,25,239,70,127,95,140,206,26,195,147,110,57,199,160,53,82,90,208,189,55,20,25,146,153,43,57,197,28,252,153,164,8,228,255,144,2,127,78,107,145,96,109,64,227,199,146,144,219,82,73,218,171,232,226,160,51,176,153,133,234,174,241,193,36,177,151,139,83,186,7,246,161,103,230,8,51,87,234,205,213,161,200,175,88,9,145,117,46,166,85,109,155,125,164,126,208,69,207,126,145,67,42,127,4,249,71,22,173,225,54,141,51,230,254,34,78,52,48,11,62,115,220,93,104,163,187,233,151,60,65,81,26,244,7,65,242,195,171,223,177,193,165,198,163,252,238,11,38,98,252,216,7,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShowSchemaStructureExplorerEditWindowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7b32bc55-19c0-4a37-b8a4-0b99a06d5fb5"),
				Name = "ShowSchemaStructureExplorerEditWindow",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bae35a61-18ee-4dd0-b837-8400e5cbfc8b"),
				Name = "entityCollectionMetaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4d2ca6bf-5553-4250-954c-39d8c3e07913"),
				Name = "textEditClientID",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f655e48c-b706-4a70-8cc9-1e9c5537f9ec"),
				Name = "textEditEventName",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,143,218,48,16,189,243,43,172,92,8,18,242,182,189,162,74,165,192,86,84,90,138,26,186,123,40,85,101,226,129,184,50,118,100,79,54,80,196,127,223,113,8,31,129,174,42,85,189,96,49,227,153,121,239,205,139,199,70,161,18,90,253,134,36,205,96,45,70,155,92,91,7,238,73,25,105,203,184,211,107,61,11,199,124,35,199,222,179,230,101,38,124,29,73,208,21,41,22,14,142,169,94,235,238,46,201,108,201,114,225,196,26,16,156,103,214,232,45,43,51,112,192,190,194,146,14,147,214,211,191,141,37,51,22,25,172,115,220,182,154,83,249,216,164,186,144,32,135,2,197,163,208,5,204,182,57,248,239,211,99,227,70,156,58,253,32,156,159,10,37,249,4,202,112,30,201,228,206,166,224,253,97,34,221,185,39,170,67,240,106,101,64,78,47,115,161,192,163,83,102,197,50,97,164,174,152,31,2,124,20,16,94,167,79,108,38,132,232,124,247,222,186,181,192,56,42,43,77,249,238,205,254,231,72,42,28,216,117,174,9,248,137,64,212,189,18,154,15,180,2,131,227,225,25,121,14,14,183,129,105,98,11,151,134,33,211,219,32,173,227,81,57,44,132,62,7,235,69,46,168,194,64,201,146,10,218,199,66,105,9,174,34,186,224,253,60,7,35,227,104,89,152,20,149,53,113,106,117,177,54,99,179,180,29,182,155,155,168,121,45,244,83,148,163,142,163,13,242,2,149,230,159,147,47,19,46,33,181,18,46,171,123,141,210,163,30,36,4,247,128,213,206,226,208,137,167,34,15,131,233,126,151,33,108,176,146,233,172,193,77,135,90,209,25,56,39,188,93,34,239,255,18,155,7,192,204,74,207,103,153,179,229,161,122,244,76,63,79,10,179,147,214,62,110,211,248,118,151,181,119,111,195,209,0,219,101,99,227,81,208,34,201,70,103,36,85,151,176,218,166,14,251,64,238,194,32,11,62,179,7,121,227,102,162,225,134,15,129,62,69,105,60,205,251,147,129,78,81,234,50,21,43,224,73,234,84,142,15,194,208,31,199,251,82,30,2,241,149,205,212,146,197,187,119,123,90,217,142,5,137,11,19,207,35,26,51,143,186,33,220,99,251,253,235,78,235,178,8,136,106,90,123,243,21,104,157,191,65,250,55,228,1,173,189,66,251,63,160,94,53,168,113,212,31,105,227,57,56,230,120,72,222,20,134,135,44,24,161,126,28,155,149,149,85,8,152,194,237,192,106,13,213,39,68,94,20,83,129,89,167,247,2,232,8,2,233,105,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("51834aca-7b97-431e-89c8-ecfb3d470fe8"),
				Name = "InitializeFilterEdit",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,77,10,194,48,16,133,215,22,122,135,208,85,187,169,7,16,23,254,180,226,66,145,122,130,208,140,50,144,38,101,58,17,127,240,238,54,93,24,105,193,221,192,188,239,189,55,83,24,70,126,108,37,203,179,117,84,131,80,97,92,138,147,188,66,94,140,36,139,56,186,73,18,23,212,12,84,40,228,29,89,215,246,234,128,230,37,26,85,14,130,110,216,174,31,71,217,64,154,148,95,40,201,122,31,188,136,116,226,179,20,198,105,157,137,87,28,205,254,134,108,8,36,195,111,204,36,96,246,43,119,68,96,248,204,228,106,118,228,75,14,100,190,82,106,220,194,179,239,56,26,238,15,150,249,190,219,88,237,26,211,21,247,86,91,2,170,172,229,131,85,254,87,189,173,127,205,124,62,134,42,64,131,140,82,227,19,210,208,39,91,124,0,93,212,174,170,124,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyDisplayPathByServerMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aebd15a8-8eaf-428c-84ae-f6a0d7cf5be8"),
				Name = "GetPropertyDisplayPathByServerMetaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9b56564-0a79-499a-be58-a0bcd0017eef"),
				Name = "serverMetaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,10,194,48,16,68,239,126,69,142,41,132,254,128,120,81,177,167,74,64,252,128,37,29,218,30,186,41,155,109,165,127,111,60,20,13,222,118,152,153,125,227,37,6,164,244,8,3,38,50,115,161,78,230,54,114,119,69,26,123,70,231,127,61,91,29,15,43,137,233,193,16,210,40,57,204,120,153,34,212,236,166,125,38,200,37,50,35,232,24,217,149,156,186,40,181,196,212,67,234,59,77,72,51,5,100,146,64,23,225,47,172,110,160,185,52,67,116,243,164,195,121,107,161,244,185,236,223,8,79,146,63,41,196,22,208,202,153,188,105,133,236,77,103,84,150,12,123,3,108,176,144,21,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPropertyServerMetaPathByClientMetaPathMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("825c3265-7c0a-4b1f-a715-6eae3b0fb669"),
				Name = "GetPropertyServerMetaPathByClientMetaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a17ae70-6dd2-4e8c-bfbe-949572d5e860"),
				Name = "clientMetaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,59,10,195,48,16,68,251,156,66,165,12,70,23,48,174,18,226,202,65,16,114,128,69,30,100,65,188,50,171,117,114,125,187,201,71,229,240,102,230,121,201,1,165,220,195,140,133,204,90,165,222,92,19,79,23,148,20,25,147,255,103,182,233,78,47,18,19,193,16,210,44,71,153,241,54,85,105,248,64,251,40,144,115,102,70,208,148,185,173,61,174,26,141,196,20,33,238,70,11,202,74,1,135,73,160,155,240,79,230,6,232,8,37,79,58,219,234,171,53,225,153,192,95,218,116,59,151,52,170,164,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateChangeEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("97788e7b-5c3b-433e-a1f5-6084dcb62c16"),
				Name = "ChangeEntityCollection",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,148,77,79,194,64,16,134,207,240,43,86,79,37,49,245,238,231,65,144,96,20,73,240,227,96,60,140,237,32,107,182,91,178,59,85,209,240,223,157,237,170,20,176,45,18,227,137,134,153,121,223,249,120,218,103,48,2,53,73,154,158,164,74,97,68,50,213,67,116,15,24,15,192,64,130,132,230,6,84,134,86,28,138,51,155,234,176,141,22,141,4,37,223,240,160,45,243,10,48,211,3,75,70,234,199,29,145,62,60,113,245,209,81,208,199,151,206,146,242,162,98,107,191,217,205,100,188,234,31,141,49,129,235,94,204,142,26,95,132,75,10,214,108,242,110,219,224,8,13,234,8,191,101,182,239,195,171,116,152,183,23,180,216,212,119,186,98,123,129,4,3,160,49,187,174,109,150,124,214,44,88,148,58,180,165,157,40,152,230,197,191,113,137,96,226,226,75,38,53,234,93,164,229,245,23,51,86,22,90,12,238,148,46,135,125,229,40,232,217,78,44,137,251,24,66,50,81,252,187,236,212,18,239,205,134,28,137,96,171,103,153,131,202,180,198,137,66,48,109,32,24,166,153,137,240,84,42,158,221,186,17,63,99,92,144,37,218,111,195,255,221,211,146,186,70,198,183,146,198,253,148,250,153,82,62,201,199,103,205,70,165,47,175,103,4,202,34,167,150,165,20,33,44,5,180,162,190,130,166,175,80,69,117,13,41,197,48,171,12,224,17,195,50,169,43,124,37,119,173,208,61,212,107,237,238,174,167,214,209,240,160,208,109,199,195,30,242,194,249,10,151,166,147,76,104,90,73,87,75,28,11,50,60,216,222,247,21,114,79,239,53,7,33,44,222,160,246,78,172,226,168,240,31,38,207,144,107,52,231,225,103,249,243,20,98,126,157,178,136,50,131,243,188,121,109,97,200,122,76,182,14,243,15,85,152,207,191,223,156,9,228,209,22,95,131,2,238,27,35,93,64,119,83,100,55,67,245,15,16,253,27,52,255,7,201,217,7,239,4,86,45,26,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4133e12b-b0d9-426d-80c9-f5ee4e9b90f8"),
				Name = "CreateColumnValuesVds",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,203,110,194,48,16,60,55,95,17,229,20,164,202,63,128,122,104,137,68,115,72,133,20,154,251,54,94,168,37,199,65,126,80,104,197,191,119,237,68,36,164,220,138,184,248,49,59,158,221,217,245,30,116,188,231,38,126,138,21,126,197,149,208,214,129,204,192,66,217,58,93,99,58,139,127,162,135,60,163,120,178,104,165,107,84,5,210,161,169,184,73,162,211,60,90,193,22,153,95,22,173,178,32,20,106,230,79,186,149,134,61,115,158,146,244,172,103,141,159,175,53,226,82,11,206,134,76,57,167,28,68,103,121,54,143,6,184,180,218,213,214,105,244,177,225,210,81,51,220,156,161,121,52,38,176,149,22,13,232,99,151,244,13,26,255,36,201,121,114,157,150,9,179,147,48,97,251,221,243,169,67,91,39,120,182,183,132,190,27,212,228,80,97,109,69,171,66,253,193,210,250,184,195,2,20,25,213,108,137,54,87,198,130,170,241,229,232,85,210,100,73,2,201,172,19,107,224,80,138,111,92,227,193,254,75,179,24,116,130,244,216,23,245,190,51,147,250,177,94,105,103,31,13,227,29,181,231,145,134,109,42,97,196,135,244,208,6,164,193,128,189,10,142,48,5,203,86,219,9,120,81,60,225,125,231,162,211,77,42,44,208,194,10,236,231,237,235,188,28,202,141,202,13,63,136,146,45,96,231,39,75,80,127,234,200,253,101,226,133,4,255,88,57,99,35,39,61,118,23,35,33,193,165,147,0,221,213,199,47,30,32,135,39,171,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetControlsPropertyEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("75c12d4b-0bcb-404f-a14f-247c9ae00679"),
				Name = "SetControlsPropertyEnabled",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("acf65355-8a0a-4041-99ed-62e9edacf6b8"),
				Name = "isEnabled",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,11,78,204,45,200,201,204,75,119,205,43,201,44,169,116,206,207,201,73,77,46,201,204,207,11,73,173,40,113,77,201,44,209,115,205,75,76,202,73,77,81,176,85,200,44,134,178,173,185,2,136,210,26,156,90,18,148,90,88,154,89,148,154,162,1,215,172,73,64,55,72,103,72,126,126,142,83,105,73,73,126,30,30,235,221,50,115,74,82,139,112,185,81,65,77,77,1,151,21,193,201,25,169,185,137,161,158,41,10,138,182,10,238,165,153,41,122,174,185,5,37,149,214,0,252,71,221,166,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPageParamsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("45df4849-ca32-4200-9f47-92aa0875fd27"),
				Name = "GetPageParams",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("180e40d3-76d6-4d94-ac36-037e9dfc2a18"),
				Name = "node",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TreeGridNode",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,203,110,219,48,16,60,91,95,193,232,16,208,168,161,31,112,82,160,112,12,67,104,98,24,177,211,75,81,20,172,184,182,9,80,164,75,174,170,8,129,255,61,124,136,174,236,36,200,69,20,151,51,187,179,195,101,169,44,24,4,62,211,178,169,213,15,38,27,248,14,29,185,37,75,86,3,249,66,242,223,185,251,46,26,193,139,37,180,126,165,227,98,163,215,104,132,218,209,241,52,251,199,12,49,96,27,137,142,164,160,37,119,162,66,161,21,51,221,141,13,168,9,137,235,87,58,38,47,217,232,133,228,182,218,67,205,74,158,79,200,92,161,192,206,85,151,16,104,235,112,244,84,242,65,17,114,156,140,70,163,192,60,24,93,129,181,235,65,2,46,240,3,82,96,212,76,177,29,24,223,206,25,250,225,127,60,65,43,173,16,158,209,245,239,144,3,67,236,236,116,144,160,104,0,22,70,240,32,97,229,18,21,67,252,166,63,45,102,82,128,194,242,46,209,68,239,246,163,110,99,149,242,125,251,123,56,56,181,115,9,181,207,145,122,237,247,151,205,102,199,105,38,182,132,174,89,125,144,46,246,161,175,228,234,54,94,231,188,62,96,23,110,36,94,95,241,141,115,154,111,133,68,48,3,127,63,77,56,144,225,198,225,152,253,209,90,18,97,99,71,143,240,183,17,6,184,155,141,45,147,22,162,72,165,57,120,29,170,145,242,141,2,163,219,80,216,131,138,232,231,207,220,69,126,157,23,58,227,212,128,108,197,112,127,73,123,72,241,75,114,156,218,168,45,42,45,185,117,34,23,128,75,141,75,167,43,69,239,133,69,154,40,169,142,31,245,79,235,56,142,55,154,84,125,38,183,127,199,150,112,23,27,211,173,152,177,64,83,129,9,209,13,158,152,99,114,125,253,86,110,225,199,146,185,145,162,39,156,247,127,232,75,197,212,108,207,212,14,34,201,217,67,175,46,53,12,159,179,251,189,215,45,152,96,146,1,108,140,234,31,247,244,21,237,177,222,227,41,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7ac9b866-7898-42ef-be01-d39b8102e61e"),
				Name = "DisplayColumnValues",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,82,209,78,194,48,20,125,94,191,162,225,169,35,102,188,75,136,145,73,200,162,160,17,225,189,89,47,176,100,107,73,219,65,22,227,191,123,219,70,221,4,209,39,227,131,47,235,218,158,115,207,185,183,103,207,53,221,11,67,71,116,10,54,85,101,93,201,21,47,107,48,43,97,88,60,36,120,151,164,37,112,237,54,100,143,232,188,5,58,166,57,88,177,166,172,139,26,81,89,151,101,76,159,73,164,193,214,90,14,201,11,33,107,165,129,231,91,202,62,149,165,133,236,168,120,222,68,218,194,54,84,171,3,138,122,87,72,182,240,168,14,78,50,194,243,100,209,177,194,122,153,232,93,208,105,93,136,100,14,7,183,178,248,43,232,12,44,127,224,118,139,132,150,114,114,11,141,99,144,200,57,4,239,96,145,111,161,226,232,97,105,64,167,74,74,200,109,161,100,50,105,221,206,184,228,27,208,9,206,38,147,198,114,153,195,184,89,102,130,5,16,42,151,129,21,224,120,227,84,62,166,128,213,219,98,174,78,248,11,158,199,205,155,93,118,194,236,169,246,230,188,130,247,214,146,148,239,188,229,39,181,176,186,144,155,48,22,18,25,191,163,162,48,187,146,55,225,41,70,52,96,146,204,204,241,9,239,245,164,218,217,166,163,27,190,55,45,86,76,175,72,20,29,99,66,201,75,122,158,141,94,162,211,109,248,5,251,104,59,244,147,195,56,92,11,193,144,19,251,100,185,131,59,197,5,166,195,39,146,12,250,62,187,255,73,255,221,164,255,173,124,159,139,212,55,129,254,73,200,250,131,87,141,65,120,62,77,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8a62e059-ca9e-4607-9c55-8eeb139527f6"),
				Name = "GetColumnValues",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,177,10,195,48,12,68,247,126,133,186,151,124,64,147,180,67,178,117,9,132,116,41,29,132,17,169,193,150,65,146,67,243,247,53,158,154,233,224,120,247,110,67,1,151,66,142,252,196,144,73,161,135,69,73,134,196,76,206,124,226,102,38,213,146,35,26,190,134,63,178,32,70,95,123,208,254,110,79,66,150,133,143,166,115,15,156,67,128,251,177,70,133,209,87,53,202,222,169,137,231,245,2,147,36,87,142,102,247,161,136,19,10,70,50,146,58,185,193,181,138,218,31,54,177,85,186,172,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4741c441-5aa4-4e27-aaea-3dc637ae6e40"),
				Name = "GetColumnValuesVds",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,199,49,10,128,48,12,5,208,171,148,78,186,244,2,142,21,103,65,232,254,209,32,133,152,64,154,220,95,186,60,120,70,30,38,233,196,75,101,82,85,28,93,200,202,209,229,153,51,229,37,87,229,248,164,129,131,70,123,70,94,19,70,106,221,60,192,59,28,151,134,221,180,253,42,16,51,176,78,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitGridWithNotNullColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fdeb764d-eee4-4143-a0d2-e65f9d8ce844"),
				Name = "InitGridWithNotNullColumns",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,65,107,195,48,12,133,207,241,175,208,46,197,129,18,118,207,218,75,90,70,217,86,10,93,119,41,59,152,84,93,13,137,29,108,37,91,88,251,223,167,184,89,73,11,219,201,32,63,233,125,79,118,163,28,228,182,168,75,243,166,138,26,61,76,224,17,41,27,84,100,156,10,189,7,41,175,100,119,19,48,117,81,192,104,116,213,158,100,182,54,4,83,184,143,69,20,29,143,48,55,164,169,229,121,5,230,164,173,89,231,7,44,213,102,177,131,9,59,213,122,151,204,203,138,218,24,190,69,228,144,106,103,82,113,18,55,68,6,63,97,166,67,191,114,237,131,39,167,205,199,24,86,206,230,232,253,121,228,74,57,85,34,161,11,93,211,142,122,111,29,170,252,32,155,75,70,182,213,166,11,184,180,180,100,252,172,175,62,107,79,50,14,16,65,220,244,166,23,122,86,189,168,170,98,219,5,97,41,131,50,26,100,249,59,231,152,133,253,0,36,166,164,3,171,127,105,146,87,187,14,97,100,220,233,2,122,111,253,79,56,201,187,61,165,34,26,110,105,155,55,201,181,205,123,231,211,36,225,186,219,233,198,163,203,172,49,103,190,100,205,195,249,156,41,82,219,225,115,179,132,240,139,158,176,125,191,128,158,111,82,49,211,190,42,84,123,251,59,126,0,47,190,180,73,68,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotNullColumnIdListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c500ec7e-5626-4a5a-957f-db8e15d66a9a"),
				Name = "GetNotNullColumnIdList",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,65,106,195,48,16,69,215,210,41,148,77,176,55,186,128,211,66,227,132,212,208,64,105,73,247,131,60,78,4,242,136,140,164,20,83,114,247,170,145,41,201,246,191,63,255,193,92,128,21,99,72,46,170,39,69,248,173,222,108,136,171,93,178,253,115,85,55,242,146,49,82,180,113,250,52,39,28,33,151,14,1,185,245,68,104,162,245,164,183,119,116,15,4,71,100,189,195,216,81,136,64,6,215,211,161,235,171,82,106,189,115,229,170,212,51,201,138,193,51,130,57,85,127,42,227,93,26,73,89,122,144,234,246,22,135,90,253,72,97,7,85,45,30,232,59,219,17,120,42,37,157,71,245,246,156,192,133,202,252,39,181,146,66,136,229,114,22,232,46,108,214,31,120,78,150,113,204,91,51,92,204,244,21,194,6,135,47,112,9,111,74,81,30,164,95,250,254,126,179,145,226,42,175,146,49,38,166,249,137,205,47,112,175,145,155,80,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetUserTaskParameterConstValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("16ff1fa0-3f46-4b9e-8665-662ad9ba845f"),
				Name = "SetUserTaskParameterConstValue",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("369626aa-853a-4613-b807-48022ee9455f"),
				Name = "parameterName",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("93a0fc9d-f57a-4c9c-9805-eec655ce57f2"),
				Name = "value",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("10840e36-c5ef-43a6-9980-455deadcf6ed"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,106,195,48,12,62,207,79,161,99,2,37,15,208,172,27,99,237,33,148,117,133,178,93,198,14,38,86,55,129,99,7,203,233,8,99,239,62,39,161,109,126,186,194,78,198,210,247,103,75,180,135,104,43,157,44,208,163,227,87,169,43,132,197,2,76,165,117,12,223,226,102,210,3,131,95,176,164,220,147,53,210,213,183,236,29,153,143,25,108,157,205,145,121,151,127,98,33,79,172,150,116,23,197,169,248,17,7,233,160,156,200,141,13,36,255,87,61,21,87,186,103,199,126,254,43,132,38,235,144,147,60,89,69,123,66,149,153,142,240,146,169,160,179,82,228,79,247,9,103,103,43,151,183,239,251,219,170,195,36,143,214,176,111,11,19,149,99,230,195,197,238,146,184,212,178,62,130,186,191,74,50,222,132,225,61,187,85,81,250,58,82,61,76,12,247,157,18,204,161,95,79,5,133,45,24,141,166,137,229,37,25,94,99,125,238,109,194,17,183,139,49,130,191,13,32,239,33,206,48,108,88,0,64,205,120,129,154,60,40,53,116,152,141,200,205,250,252,2,42,17,143,189,169,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearDataSourceFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("493f098c-2ae6-4ea7-94df-f0d0a9510292"),
				Name = "ClearDataSourceFilters",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,79,205,10,194,48,12,62,59,216,59,212,157,182,75,125,128,177,139,115,130,7,69,220,19,148,53,74,32,182,146,165,226,15,190,187,245,7,42,158,18,146,239,183,115,130,114,93,24,49,189,15,60,128,178,105,109,212,214,28,64,119,127,144,58,207,206,134,149,39,187,68,18,224,49,2,19,75,183,129,25,156,244,194,97,144,192,160,191,168,56,157,157,95,55,230,8,101,241,185,117,22,165,168,148,25,85,82,255,124,90,79,4,131,160,119,209,13,247,170,252,113,155,54,202,5,162,74,221,243,108,146,238,186,37,48,92,86,145,240,200,179,119,242,228,162,87,99,148,12,71,55,118,151,19,121,6,222,121,47,107,111,95,45,99,210,87,169,217,236,159,180,3,116,40,104,8,111,80,166,138,85,253,4,61,5,91,246,54,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb0f8d87-8e38-451c-b2a0-c7c70ca21130"),
				Name = "ClearColumnValues",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,193,78,195,48,12,134,207,201,83,120,183,110,154,186,7,24,67,66,43,39,132,84,169,130,11,226,96,101,30,139,148,38,37,73,11,21,234,187,227,166,32,122,64,140,93,237,223,223,239,223,238,208,131,114,166,173,237,35,154,150,194,222,217,72,239,241,142,250,138,66,208,206,22,24,17,118,240,16,200,115,207,146,138,92,204,103,205,167,253,175,227,207,91,169,143,144,157,103,47,118,96,91,99,150,240,33,197,102,37,69,199,27,117,73,207,182,231,199,49,64,161,211,82,232,251,171,16,189,182,47,107,40,189,83,44,170,212,137,106,44,209,99,77,145,124,226,92,111,39,15,101,8,167,202,104,100,233,237,82,78,182,100,210,209,121,66,117,202,120,171,84,45,81,251,127,77,67,195,74,208,246,43,107,138,47,198,139,45,198,70,158,68,121,229,90,175,40,191,125,109,209,132,236,15,220,183,208,70,29,251,123,108,26,246,95,78,76,49,11,154,223,28,14,89,226,243,190,107,248,113,26,163,136,65,72,49,72,177,218,72,113,249,187,97,122,35,115,10,29,26,131,253,92,55,158,106,248,4,82,167,144,21,107,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveEntityCollectionParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ec281a59-1902-4bb7-aee2-63bf79006047"),
				Name = "SaveEntityCollectionParameterValue",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c2336900-8b18-496d-8909-e82ce63c2dbb"),
				Name = "parametersValue",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4a6baf41-d9d9-4f7a-9f21-7f72eb9d4f47"),
				Name = "parameterName",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8bbda79c-c7e3-48c5-b92d-fef446a0e7b9"),
				Name = "parameterMetaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ef9c474f-2dcd-4a0d-9c0c-6344a4fd4c3d"),
				Name = "entitySchemaUId",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,207,78,195,48,12,198,207,76,218,59,68,59,181,66,202,3,48,254,8,117,59,20,212,82,209,141,29,208,14,161,117,183,72,105,92,57,46,82,121,122,186,86,235,6,84,192,37,145,157,207,159,127,118,222,21,9,176,172,185,9,208,24,200,88,163,21,55,226,193,161,149,11,112,64,90,25,253,1,215,9,97,6,206,165,217,30,74,149,40,82,37,48,208,139,50,53,220,122,158,183,2,34,229,176,96,185,14,229,6,222,2,180,76,104,156,76,212,14,252,195,33,239,93,213,5,211,201,133,12,106,199,88,46,20,171,215,234,232,21,183,151,184,20,179,211,219,35,52,179,173,92,97,202,164,237,206,243,253,249,116,242,157,85,70,192,45,15,239,91,232,193,234,152,27,211,119,200,255,21,71,152,235,66,67,30,218,126,240,117,152,183,165,203,92,243,16,143,149,165,88,83,118,104,226,58,114,25,186,184,54,230,137,150,101,197,141,247,163,179,47,238,218,165,252,178,225,222,79,198,104,65,92,137,191,133,145,170,170,182,239,24,218,51,20,64,96,51,56,31,168,87,157,143,52,48,186,206,247,235,47,109,135,146,147,241,252,19,189,205,149,87,73,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityCollectionDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("765b5648-7dea-4a69-bb27-20b9fd1c782a"),
				Name = "GetEntityCollectionDisplayValue",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff38cbaf-3ff9-435b-bcb4-019be0d7a552"),
				Name = "displayValue",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("269f2772-416c-4b02-b8e8-ef8984e20ed4"),
				Name = "metaPath",
				CreatedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				ModifiedInSchemaUId = new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,140,177,10,195,32,20,0,231,248,21,142,186,228,7,164,75,104,26,178,164,129,210,238,143,248,154,8,106,197,247,164,72,233,191,183,99,50,30,220,157,123,74,69,156,93,92,219,145,166,226,253,53,247,33,113,85,214,81,242,80,31,224,11,106,45,63,162,153,243,107,65,162,219,178,97,0,153,14,116,146,23,23,237,25,201,173,17,237,193,84,218,136,102,127,251,203,135,184,29,144,59,32,236,61,6,140,220,213,251,104,85,196,183,28,138,179,42,32,195,12,188,105,221,78,16,208,136,175,200,200,37,71,185,127,154,31,50,114,192,190,200,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddDataToEntityCollectionUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4691bc9-e5f6-4c39-9c78-c116ac8f95f7"));
		}

		#endregion

	}

	#endregion

}

