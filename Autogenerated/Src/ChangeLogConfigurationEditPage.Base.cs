namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.CodeDom.Compiler;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.ConfigurationBuild;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: ChangeLogConfigurationEditPageSchema

	/// <exclude/>
	public class ChangeLogConfigurationEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _objectComboBoxEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ObjectComboBoxEdit {
			get {
				return _objectComboBoxEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout9;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return _controlLayout9;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout7;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return _controlLayout7;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout10;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout10 {
			get {
				return _controlLayout10;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _allColumnsLabel;
		public Terrasoft.UI.WebControls.Controls.Label AllColumnsLabel {
			get {
				return _allColumnsLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _allColumnsTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid AllColumnsTreeGrid {
			get {
				return _allColumnsTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout12;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout12 {
			get {
				return _controlLayout12;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addButton;
		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return _addButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _removeButton;
		public Terrasoft.UI.WebControls.Controls.Button RemoveButton {
			get {
				return _removeButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout8;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return _controlLayout8;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout11;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout11 {
			get {
				return _controlLayout11;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Label _logColumnsLabel;
		public Terrasoft.UI.WebControls.Controls.Label LogColumnsLabel {
			get {
				return _logColumnsLabel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _logColumnsTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid LogColumnsTreeGrid {
			get {
				return _logColumnsTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
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

		#endregion

		#region Constructors: Public

		public ChangeLogConfigurationEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ChangeLogConfigurationEditPageSchema(ChangeLogConfigurationEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			RealUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			Name = "ChangeLogConfigurationEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChangeLogConfigurationEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateObjectComboBoxEdit());
			Controls.AddAt(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateControlLayout9());
			ControlLayout2.InsertItem(1, CreateControlLayout7());
			ControlLayout7.InsertItem(0, CreateControlLayout10());
			ControlLayout10.InsertItem(0, CreateAllColumnsLabel());
			ControlLayout7.InsertItem(1, CreateAllColumnsTreeGrid());
			ControlLayout2.InsertItem(2, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateControlLayout12());
			ControlLayout12.InsertItem(0, CreateAddButton());
			ControlLayout12.InsertItem(1, CreateRemoveButton());
			ControlLayout2.InsertItem(3, CreateControlLayout8());
			ControlLayout8.InsertItem(0, CreateControlLayout11());
			ControlLayout11.InsertItem(0, CreateLogColumnsLabel());
			ControlLayout8.InsertItem(1, CreateLogColumnsTreeGrid());
			ControlLayout2.InsertItem(4, CreateControlLayout5());
			Controls.AddAt(3, CreateControlLayout3());
			Controls.AddAt(4, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateSpacer1());
			ControlLayout4.InsertItem(1, CreateOkButton());
			ControlLayout4.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateChangeLogConfigurationEditPageEventsProcessSchema() {
			var schema = new ChangeLogConfigurationEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("4c6a95a8-8ad3-453a-a09b-4e0b5bbb8508");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_baseMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateObjectComboBoxEdit() {
			_objectComboBoxEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_objectComboBoxEdit.UId = new Guid("269ee35f-be5c-42c5-b9cd-0b71dca0e47d");
			_objectComboBoxEdit.Name = "ObjectComboBoxEdit";
			_objectComboBoxEdit.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_objectComboBoxEdit.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_objectComboBoxEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_objectComboBoxEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_objectComboBoxEdit.Tag = "";
			_objectComboBoxEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_objectComboBoxEdit.Image = new ControlImage {};
			_objectComboBoxEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_objectComboBoxEdit.Margins = "7 10 7 10";
			_objectComboBoxEdit.Required = true;
			return _objectComboBoxEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("6d9fcf25-a246-445f-a49c-70be41066327");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout1.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(35);
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout9() {
			_controlLayout9 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout9.UId = new Guid("126bbcd9-bc09-4609-8868-031008b3de6d");
			_controlLayout9.Name = "ControlLayout9";
			_controlLayout9.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout9.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout9.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout9.Tag = "";
			_controlLayout9.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout9.Width = System.Web.UI.WebControls.Unit.Pixel(1);
			_controlLayout9.StartNewAlignGroup = false;
			_controlLayout9.Image = new ControlImage {};
			_controlLayout9.Edges = "";
			return _controlLayout9;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateAllColumnsLabel() {
			_allColumnsLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_allColumnsLabel.UId = new Guid("96d98a43-cfdb-4ba4-a185-5f47b053a071");
			_allColumnsLabel.Name = "AllColumnsLabel";
			_allColumnsLabel.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_allColumnsLabel.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_allColumnsLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_allColumnsLabel.Tag = "";
			_allColumnsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_allColumnsLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _allColumnsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout10() {
			_controlLayout10 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout10.UId = new Guid("794d7928-dfcd-4645-887d-26f207143ce6");
			_controlLayout10.Name = "ControlLayout10";
			_controlLayout10.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout10.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout10.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout10.Tag = "";
			_controlLayout10.Height = System.Web.UI.WebControls.Unit.Pixel(30);
			_controlLayout10.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout10.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout10.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout10.StartNewAlignGroup = false;
			_controlLayout10.Image = new ControlImage {};
			_controlLayout10.Edges = "";
			return _controlLayout10;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateAllColumnsTreeGrid() {
			_allColumnsTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_allColumnsTreeGrid.UId = new Guid("e8def52d-1b0e-4e82-9604-e1563683e6a6");
			_allColumnsTreeGrid.Name = "AllColumnsTreeGrid";
			_allColumnsTreeGrid.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_allColumnsTreeGrid.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_allColumnsTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_allColumnsTreeGrid.Tag = "";
			_allColumnsTreeGrid.Edges = "1 1 1 1";
			_allColumnsTreeGrid.IsColumnAutowidth = true;
			_allColumnsTreeGrid.FooterVisible = false;
			_allColumnsTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_allColumnsTreeGrid.IsSummaryVisible = false;
			_allColumnsTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_allColumnsTreeGrid.ToolbarVisible = false;
			_allColumnsTreeGrid.QuickFilterVisible = false;
			_allColumnsTreeGrid.HideHeaders = false;
			return _allColumnsTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout7() {
			_controlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout7.UId = new Guid("98969eb2-95f8-49dd-a72d-5864f7aae513");
			_controlLayout7.Name = "ControlLayout7";
			_controlLayout7.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout7.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout7.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout7.Tag = "";
			_controlLayout7.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.StartNewAlignGroup = false;
			_controlLayout7.Image = new ControlImage {};
			_controlLayout7.Edges = "";
			return _controlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("aa1ab736-65b5-48af-9a06-11429d104e78");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_addButton.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			_addButton.Width = System.Web.UI.WebControls.Unit.Pixel(50);
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateRemoveButton() {
			_removeButton = new Terrasoft.UI.WebControls.Controls.Button();
			_removeButton.UId = new Guid("63703872-5483-459e-9b73-c125fdcfb476");
			_removeButton.Name = "RemoveButton";
			_removeButton.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_removeButton.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_removeButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_removeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_removeButton.Tag = "";
			_removeButton.Image = new ControlImage {};
			_removeButton.Width = System.Web.UI.WebControls.Unit.Pixel(50);
			_removeButton.Margins = "5 0 0 0";
			return _removeButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout12() {
			_controlLayout12 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout12.UId = new Guid("53486744-f267-4ec1-9472-82eb97cdd08d");
			_controlLayout12.Name = "ControlLayout12";
			_controlLayout12.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout12.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout12.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout12.Tag = "";
			_controlLayout12.Height = System.Web.UI.WebControls.Unit.Pixel(55);
			_controlLayout12.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout12.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout12.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Center;
			_controlLayout12.StartNewAlignGroup = false;
			_controlLayout12.Image = new ControlImage {};
			_controlLayout12.Edges = "";
			return _controlLayout12;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("2f46b281-9bb0-4b7c-9437-034d82a6b988");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout6.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout6.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout6.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Pixel(80);
			_controlLayout6.HorizontalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutHorizontalAlign.Center;
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateLogColumnsLabel() {
			_logColumnsLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_logColumnsLabel.UId = new Guid("153fcec2-866f-4bd4-b533-6ffd5a2ab7fb");
			_logColumnsLabel.Name = "LogColumnsLabel";
			_logColumnsLabel.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_logColumnsLabel.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_logColumnsLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_logColumnsLabel.Tag = "";
			_logColumnsLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			return _logColumnsLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout11() {
			_controlLayout11 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout11.UId = new Guid("b60b1f2b-8813-4bb6-b4fe-30f3bce03abb");
			_controlLayout11.Name = "ControlLayout11";
			_controlLayout11.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout11.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout11.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout11.Tag = "";
			_controlLayout11.Height = System.Web.UI.WebControls.Unit.Pixel(30);
			_controlLayout11.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout11.VerticalAlign = Terrasoft.UI.WebControls.Controls.ControlLayoutVerticalAlign.Middle;
			_controlLayout11.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout11.StartNewAlignGroup = false;
			_controlLayout11.Image = new ControlImage {};
			_controlLayout11.Edges = "";
			return _controlLayout11;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateLogColumnsTreeGrid() {
			_logColumnsTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_logColumnsTreeGrid.UId = new Guid("8cb28714-d0f8-423c-a491-7eeddef8a5e8");
			_logColumnsTreeGrid.Name = "LogColumnsTreeGrid";
			_logColumnsTreeGrid.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_logColumnsTreeGrid.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_logColumnsTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_logColumnsTreeGrid.Tag = "";
			_logColumnsTreeGrid.Edges = "1 1 1 1";
			_logColumnsTreeGrid.IsColumnAutowidth = true;
			_logColumnsTreeGrid.FooterVisible = false;
			_logColumnsTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_logColumnsTreeGrid.IsSummaryVisible = false;
			_logColumnsTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_logColumnsTreeGrid.ToolbarVisible = false;
			_logColumnsTreeGrid.QuickFilterVisible = false;
			_logColumnsTreeGrid.HideHeaders = false;
			return _logColumnsTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout8() {
			_controlLayout8 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout8.UId = new Guid("773992e0-0f27-4bc5-82e9-3d857a9b0d02");
			_controlLayout8.Name = "ControlLayout8";
			_controlLayout8.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout8.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout8.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout8.Tag = "";
			_controlLayout8.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout8.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout8.StartNewAlignGroup = false;
			_controlLayout8.Image = new ControlImage {};
			_controlLayout8.Edges = "";
			return _controlLayout8;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("68085920-b622-450b-ab25-2ee4214dc0c5");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout5.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Pixel(1);
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("31a7d88b-852b-488c-83a0-475f6c0003f1");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout2.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Percentage(70);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("9a80098d-5c9e-437d-aa27-8fa067834fe4");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout3.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(10);
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("781c81c2-c47c-42a9-ba58-e701ef1c4bc5");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_spacer1.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("8e774459-c4a6-45da-8c18-babfb11a1370");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_okButton.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("3a90805c-5f10-4956-857a-f3098ccb6e96");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_cancelButton.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("9eb0738f-624e-485c-a830-25d01f3628e5");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout4.ModifiedInSchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			_controlLayout4.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout4.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout4.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ChangeLogConfigurationEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ChangeLogConfigurationEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ChangeLogConfigurationEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogConfigurationEditPageEventsProcess

	/// <exclude/>
	public class ChangeLogConfigurationEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ChangeLogConfigurationEditPageSchemaUserControl
	{

		#region Class: ShowMessageUserTaskFlowElement

		/// <exclude/>
		public class ShowMessageUserTaskFlowElement : QuestionUserTask
		{

			public ShowMessageUserTaskFlowElement(UserConnection userConnection, ChangeLogConfigurationEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83");
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

		public ChangeLogConfigurationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeLogConfigurationEditPageEventsProcess";
			SchemaUId = new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d037e0e3-16ed-4fa4-86bb-5fe0dac46ad7");
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

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual string SerializedList {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual string InitialSerealizedList {
			get;
			set;
		}

		public virtual bool IsViewOrVirtualSchemaSelected {
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
					SchemaElementUId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _objectComboBoxEditChangeStartMessage;
		public ProcessFlowElement ObjectComboBoxEditChangeStartMessage {
			get {
				return _objectComboBoxEditChangeStartMessage ?? (_objectComboBoxEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ObjectComboBoxEditChangeStartMessage",
					SchemaElementUId = new Guid("0a442ead-772a-4140-87d0-df3ae9d9bb4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectComboBoxEditChangeScriptTask;
		public ProcessScriptTask ObjectComboBoxEditChangeScriptTask {
			get {
				return _objectComboBoxEditChangeScriptTask ?? (_objectComboBoxEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectComboBoxEditChangeScriptTask",
					SchemaElementUId = new Guid("ab9a81fb-89f0-4367-acee-422c7036eea1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectComboBoxEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("3770ea1a-260b-4181-af89-26356f3029c2"),
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

		private ShowMessageUserTaskFlowElement _showMessageUserTask;
		public ShowMessageUserTaskFlowElement ShowMessageUserTask {
			get {
				return _showMessageUserTask ?? (_showMessageUserTask = new ShowMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("6e294e1e-df13-4976-9a5b-8b0fd0c6e459"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("f8335dfc-4d8d-4e69-9630-9d8c40f09ce9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickStartMessage;
		public ProcessFlowElement AddButtonClickStartMessage {
			get {
				return _addButtonClickStartMessage ?? (_addButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickStartMessage",
					SchemaElementUId = new Guid("61e20acf-e9e5-410c-9098-051d5e646e3d"),
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
					SchemaElementUId = new Guid("5b2a83e9-a312-4cc0-b900-5cd8fdf47679"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("e4a199aa-c6d4-45f6-8231-b8ded0c9f69f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _removeButtonClickStartMessage;
		public ProcessFlowElement RemoveButtonClickStartMessage {
			get {
				return _removeButtonClickStartMessage ?? (_removeButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "RemoveButtonClickStartMessage",
					SchemaElementUId = new Guid("8f156aeb-5865-43b2-b81f-096111606048"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _removeButtonClickScriptTask;
		public ProcessScriptTask RemoveButtonClickScriptTask {
			get {
				return _removeButtonClickScriptTask ?? (_removeButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RemoveButtonClickScriptTask",
					SchemaElementUId = new Guid("20872aaa-7764-4906-bc4c-0bd817a5403a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RemoveButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("13939597-42d0-4634-91fa-34819e797108"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessage1;
		public ProcessFlowElement OkButtonClickStartMessage1 {
			get {
				return _okButtonClickStartMessage1 ?? (_okButtonClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessage1",
					SchemaElementUId = new Guid("05e5fda9-3f89-4444-ae00-d71e0db2496f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startDBMetaActionMessage;
		public ProcessFlowElement StartDBMetaActionMessage {
			get {
				return _startDBMetaActionMessage ?? (_startDBMetaActionMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartDBMetaActionMessage",
					SchemaElementUId = new Guid("9220775c-cdc9-4c23-a903-dee08554073e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _startDBMetaActionScript;
		public ProcessScriptTask StartDBMetaActionScript {
			get {
				return _startDBMetaActionScript ?? (_startDBMetaActionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartDBMetaActionScript",
					SchemaElementUId = new Guid("545ce653-0ab4-49c5-8600-c652ee6ce198"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = StartDBMetaActionScriptExecute,
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
					SchemaElementUId = new Guid("9fa675c3-f016-45af-aadf-608cd27f25f5"),
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
					SchemaElementUId = new Guid("c9357b60-e20b-4fe6-b7d2-261c32f7e1f5"),
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
					SchemaElementUId = new Guid("23bcceee-2318-4b74-b53e-ff52f89855c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
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
					SchemaElementUId = new Guid("74b10479-00e9-49d5-b269-21b301a81ff8"),
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
					SchemaElementUId = new Guid("125bc4d1-e803-4485-aa0f-65ab8a642a28"),
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
					SchemaElementUId = new Guid("6cf246ae-f915-4bad-909a-13f0e31cffd4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("57a38ce1-26e6-4767-ae05-81cd03306f10"),
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
					SchemaElementUId = new Guid("cfee8440-8261-4a48-bc6f-5f259e19ef9d"),
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
					SchemaElementUId = new Guid("32aaa3ca-b263-42e2-ac2c-006e4e2072b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _okButtonClickStartMessage;
		public ProcessScriptTask OkButtonClickStartMessage {
			get {
				return _okButtonClickStartMessage ?? (_okButtonClickStartMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickStartMessage",
					SchemaElementUId = new Guid("075f2678-9a71-461a-b877-2d38224587d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickStartMessageExecute,
				});
			}
		}

		private ProcessConditionalFlow _isViewOrVirtualSchemaSelectedConditionalFlow;
		public ProcessConditionalFlow IsViewOrVirtualSchemaSelectedConditionalFlow {
			get {
				return _isViewOrVirtualSchemaSelectedConditionalFlow ?? (_isViewOrVirtualSchemaSelectedConditionalFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsViewOrVirtualSchemaSelectedConditionalFlow",
					SchemaElementUId = new Guid("ceff4159-b9fb-4397-8502-4c007f86ef84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _columnCaption;
		public LocalizableString ColumnCaption {
			get {
				return _columnCaption ?? (_columnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ColumnCaption.Value"));
			}
		}

		private LocalizableString _viewObjectMessage;
		public LocalizableString ViewObjectMessage {
			get {
				return _viewObjectMessage ?? (_viewObjectMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ViewObjectMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ObjectComboBoxEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectComboBoxEditChangeStartMessage };
			FlowElements[ObjectComboBoxEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectComboBoxEditChangeScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ShowMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowMessageUserTask };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[AddButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickStartMessage };
			FlowElements[AddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[RemoveButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveButtonClickStartMessage };
			FlowElements[RemoveButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { RemoveButtonClickScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[OkButtonClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage1 };
			FlowElements[StartDBMetaActionMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDBMetaActionMessage };
			FlowElements[StartDBMetaActionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { StartDBMetaActionScript };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess7":
						break;
					case "ObjectComboBoxEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ObjectComboBoxEditChangeScriptTask");
						break;
					case "ObjectComboBoxEditChangeScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (IsViewOrVirtualSchemaSelectedConditionalFlowExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ShowMessageUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("End1");
						break;
					case "ShowMessageUserTask":
						break;
					case "End1":
						break;
					case "EventSubProcess3":
						break;
					case "AddButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("AddButtonClickScriptTask");
						break;
					case "AddButtonClickScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "RemoveButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("RemoveButtonClickScriptTask");
						break;
					case "RemoveButtonClickScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "OkButtonClickStartMessage1":
						e.Context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						break;
					case "StartDBMetaActionMessage":
						e.Context.QueueTasks.Enqueue("StartDBMetaActionScript");
						break;
					case "StartDBMetaActionScript":
						break;
					case "EventSubProcess6":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "OkButtonClickStartMessage":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool IsViewOrVirtualSchemaSelectedConditionalFlowExpressionExecute() {
			return Convert.ToBoolean(IsViewOrVirtualSchemaSelected);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ObjectComboBoxEditChangeStartMessage");
			ActivatedEventElements.Add("AddButtonClickStartMessage");
			ActivatedEventElements.Add("RemoveButtonClickStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessage1");
			ActivatedEventElements.Add("StartDBMetaActionMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("InitStartMessage");
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
				case "ObjectComboBoxEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectComboBoxEditChangeStartMessage";
					result = ObjectComboBoxEditChangeStartMessage.Execute(context);
					break;
				case "ObjectComboBoxEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectComboBoxEditChangeScriptTask";
					result = ObjectComboBoxEditChangeScriptTask.Execute(context, ObjectComboBoxEditChangeScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ShowMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ShowMessageUserTask";
					result = ShowMessageUserTask.Execute(context);
					break;
				case "End1":
					context.QueueTasks.Dequeue();
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickStartMessage";
					result = AddButtonClickStartMessage.Execute(context);
					break;
				case "AddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickScriptTask";
					result = AddButtonClickScriptTask.Execute(context, AddButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "RemoveButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveButtonClickStartMessage";
					result = RemoveButtonClickStartMessage.Execute(context);
					break;
				case "RemoveButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "RemoveButtonClickScriptTask";
					result = RemoveButtonClickScriptTask.Execute(context, RemoveButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage1";
					result = OkButtonClickStartMessage1.Execute(context);
					break;
				case "StartDBMetaActionMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDBMetaActionMessage";
					result = StartDBMetaActionMessage.Execute(context);
					break;
				case "StartDBMetaActionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartDBMetaActionScript";
					result = StartDBMetaActionScript.Execute(context, StartDBMetaActionScriptExecute);
					break;
				case "EventSubProcess6":
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
				case "EventSubProcess1":
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
				case "EventSubProcess2":
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
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context, OkButtonClickStartMessageExecute);
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
				case "IsViewOrVirtualSchemaSelected":
					IsViewOrVirtualSchemaSelected = reader.GetValue<System.Boolean>();
				break;
				case "InitialSerealizedList":
					InitialSerealizedList = reader.GetValue<System.String>();
				break;
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "SerializedList":
					SerializedList = reader.GetValue<System.String>();
				break;
				case "RecordId":
					RecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ObjectComboBoxEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			RecordId = (Guid)Page.ObjectComboBoxEdit.Value;
			SerializedList = string.Empty;
			IsViewOrVirtualSchemaSelected = false;
			if (!RecordId.Equals(Guid.Empty)) {
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(RecordId);
				if (entitySchema != null && (entitySchema.IsVirtual || entitySchema.IsDBView)) {
					Page.ObjectComboBoxEdit.SuspendAjaxEvents();
					Page.ObjectComboBoxEdit.Clear();
					RecordId = Guid.Empty;
					Page.ObjectComboBoxEdit.ResumeAjaxEvents();
					ShowMessageUserTask.MessageText = ViewObjectMessage;
					ShowMessageUserTask.Icon = "INFO";
					ShowMessageUserTask.Buttons = "OK";
					ShowMessageUserTask.ProcessInstanceId = InstanceUId;
					IsViewOrVirtualSchemaSelected = true;
				}
				try {
					entitySchema.IsTrackChangesInDB = true;
					entitySchema.ExtendParent = true;
					entitySchema.ValidateNames(false);
				} catch (Exception ex) {
					Page.ObjectComboBoxEdit.SuspendAjaxEvents();
					Page.ObjectComboBoxEdit.Clear();
					RecordId = Guid.Empty;
					Page.ObjectComboBoxEdit.ResumeAjaxEvents();
					ShowMessageUserTask.MessageText = ex.Message;
					ShowMessageUserTask.Icon = "INFO";
					ShowMessageUserTask.Buttons = "OK";
					ShowMessageUserTask.ProcessInstanceId = InstanceUId;
					IsViewOrVirtualSchemaSelected = true;
				} finally {
					entitySchema.IsTrackChangesInDB = false;
					entitySchema.ExtendParent = false;
				}
			}
			InitDataSources();
			return true;
		}

		public virtual bool AddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			MoveItemsToTheRight();
			return true;
		}

		public virtual bool RemoveButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			MoveItemsToTheLeft();
			return true;
		}

		public virtual bool StartDBMetaActionScriptExecute(ProcessExecutingContext context) {
			var schema = GetCurrentEntitySchema();
			var dBMetaActionManager = Page.UserConnection.UserManagerProvider.GetManager("DBMetaActionManager") as DBMetaActionManager;
			DBMetaScript dbMetaScript = Page.UserConnection.DBMetaScript;
			DBMetaActionCollection actions = dBMetaActionManager.GetEntitySchemaActions(schema.UId) ?? new DBMetaActionCollection(UserConnection);
			dbMetaScript.AddEntitySchemaSavingActions(actions, schema);
			dbMetaScript.ExecuteActions(actions);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			if (!UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanViewConfiguration")) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageChangeLog");
			}
			Page.OkButton.AjaxEvents.Click.Timeout = 600000;
			Page.OkButton.AjaxEvents.Click.ShowLoadMask = true;
			Page.AllColumnsLabel.Bold = true;
			Page.LogColumnsLabel.Bold = true;
			SerializedList = string.Empty;
			InitialSerealizedList = string.Empty;
			object rId = Page.GetParameterValue("recordId");
			if (rId != null) {
				RecordId = new Guid(rId.ToString());
			} else {
				RecordId = Guid.Empty;	
			}
			if (RecordId != Guid.Empty) {
				IsNew = false;
				var schema = GetCurrentEntitySchema();
				Page.ObjectComboBoxEdit.AddItem(schema.UId.ToString(), schema.Caption);
				Page.ObjectComboBoxEdit.SelectItem(schema.UId.ToString());
				Page.ObjectComboBoxEdit.Disable();
				InitDataSources();
				if (!string.IsNullOrEmpty(SerializedList)) {
					InitialSerealizedList = string.Copy(SerializedList);
				}
			} else {			
				IsNew = true;
				Select select = GetEntitySchemaWithLoggingDisabled();
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
						while (dr.Read()) {
							string value = (string)dr.GetValue(0);			
							Guid key = UserConnection.DBTypeConverter.DBValueToGuid(dr.GetValue(1));
							Page.ObjectComboBoxEdit.AddItem(key.ToString(), value);			
						}
					}
				}
			}
			return true;
		}

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			CreateDataSources();
			Page.OkButton.AjaxEvents.Click.CausesValidation = true;
			return true;
		}

		public virtual bool OkButtonClickStartMessageExecute(ProcessExecutingContext context) {
			JArray array = new JArray();
			if (!string.IsNullOrEmpty(SerializedList)) {
				array = Json.Deserialize(SerializedList) as JArray;
			}
			List<Guid> loggedColumnUIds = new List<Guid>();
			foreach (var item in array) {
				loggedColumnUIds.Add(new Guid(Json.Deserialize(item.ToString()).ToString()));
			}
			if (IsNew && loggedColumnUIds.Count > 0) {
				CompileEntitySchema(loggedColumnUIds);
			} else if (!IsNew) {
				if (string.Compare(SerializedList, InitialSerealizedList, false) != 0) {
					CompileEntitySchema(loggedColumnUIds);
				}
			}
			UpdateParentGrid();
			if (IsNew) {
				string script = string.Format("Terrasoft.AjaxMethods.ThrowClientEventWithMask(\'{0}\', \'{1}\', {{timeout:999999}});", InstanceUId, "StartDBMetaAction");
				Page.AddScript(script);
			} else {
				(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			}
			return true;
		}

		public virtual void CreateDataSources() {
			var virtualDataSourceLeft = CreateVirtualDataSource("virtualDataSourceLeft");
			Page.AllColumnsTreeGrid.DataSourceId = virtualDataSourceLeft.ID;
			var virtualDataSourceRight = CreateVirtualDataSource("virtualDataSourceRight");
			Page.LogColumnsTreeGrid.DataSourceId = virtualDataSourceRight.ID;
		}

		public virtual VirtualDataSource CreateVirtualDataSource(string virtualDataSourceId) {
			var virtualDataSource = new VirtualDataSource() {ID = virtualDataSourceId};
			virtualDataSource.CreatedByAjax = (Page.PageContainer as Terrasoft.UI.WebControls.WebControl).CreatedByAjax;
			Page.PageContainer.Controls.Add(virtualDataSource);
			DataSourceStructure defStructure = virtualDataSource.DefStructure;
			if (defStructure.Columns.Count == 0) {
				defStructure.Columns.Clear();
				defStructure.PrimaryColumnName = "Id";
				var dataValueTypeManager = (DataValueTypeManager)Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
				CreateVirtualDataSourceStructure(dataValueTypeManager, defStructure);
			}
			return virtualDataSource;
		}

		public virtual void CreateVirtualDataSourceStructure(DataValueTypeManager dataValueTypeManager, DataSourceStructure defStructure) {
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
					DataValueType = dataValueTypeManager.GetInstanceByName("MediumText"),
					Caption = ColumnCaption.Value,		
					IsVisible = true,
					IsSortable = false
			};
			defStructure.AddColumn(column);
		}

		public virtual VirtualDataSource GetDataSource(bool left) {
			if (left) {
				return Terrasoft.UI.WebControls.Utilities.ControlUtilities.FindControl(Page.AspPage.Controls[0], "virtualDataSourceLeft", true) as VirtualDataSource;
			}
			
			return Terrasoft.UI.WebControls.Utilities.ControlUtilities.FindControl(Page.AspPage.Controls[0], "virtualDataSourceRight", true) as VirtualDataSource;
		}

		public virtual VirtualDataSource GetLeftDataSource() {
			return GetDataSource(true);
		}

		public virtual VirtualDataSource GetRightDataSource() {
			return GetDataSource(false);
		}

		public virtual void InitDataSources() {
			var leftDataSource = GetLeftDataSource();
			var rightDataSource = GetRightDataSource();
			rightDataSource.Clear();
			leftDataSource.Clear();
			Page.AllColumnsTreeGrid.Clear();
			Page.LogColumnsTreeGrid.Clear();
			EntitySchema schema = GetCurrentEntitySchema();
			if (schema == null) {
				return;
			}
			JArray array = new JArray();
			foreach (var column in schema.Columns) {
				if (column.UsageType != EntitySchemaColumnUsageType.None) {
					AddRow(leftDataSource, column.UId, column.Caption);
					if (column.IsTrackChangesInDB) {
						AddRow(rightDataSource, column.UId, column.Caption);
						array.Add(Json.Serialize(column.UId));
					}
				}
			}
			leftDataSource.LoadRows();
			rightDataSource.LoadRows();
			SerializedList = Json.Serialize(array);
		}

		public virtual void AddRow(VirtualDataSource dataSource, Guid id, string name) {
			var row = dataSource.CreateRow();	
			row.SetColumnValue("Id", id);
			row.SetColumnValue("Name", name);
			dataSource.Add(row);
		}

		public virtual void MoveItemsToTheRight() {
			var leftDataSource = Page.AllColumnsTreeGrid.DataSource;
			var rightDataSource = Page.LogColumnsTreeGrid.DataSource;
			ObservableCollection<System.Guid> logColumnIds = leftDataSource.SelectedItemPrimaryColumnValues;
			if (logColumnIds.Count == 0) {
				return;
			}
			JArray array = null;
			if (!string.IsNullOrEmpty(SerializedList)) {
				array = Json.Deserialize(SerializedList) as JArray;
			} else {
				array = new JArray();
			}
			
			foreach(var logColumnId in  logColumnIds) {
				bool existing = false;
				var column = GetSchemaColumnById(logColumnId);
				// column.UId, column.Caption
				Guid id = column.UId;
				string name = column.Caption;
				var newRow = rightDataSource.CreateRow();	
				newRow.SetColumnValue("Id", id);
				newRow.SetColumnValue("Name", name);
				rightDataSource.Rows.Add(newRow);	
				foreach(var item in array) {
					if (item.Value<string>() == Json.Serialize(id)) {
						existing = true;
						break;
					}
				}
				if (!existing) {
					array.Add(Json.Serialize(id));
				}
			}
			SerializedList = Json.Serialize(array); 
			rightDataSource.LoadRows();
		}

		public virtual void MoveItemsToTheLeft() {
			var dataSource = Page.LogColumnsTreeGrid.DataSource;
			var logColumnIds = dataSource.SelectedItemPrimaryColumnValues.ToList();
			if (logColumnIds.Count == 0) {
				return;
			}
			JArray array = null;
			if (!string.IsNullOrEmpty(SerializedList)) {
				array = Json.Deserialize(SerializedList) as JArray;
			}
			foreach(var logColumnId in  logColumnIds) {
				dataSource.Remove(logColumnId);
				if (array != null) {
					foreach(var item in array) {
						if (item.Value<string>() == Json.Serialize(logColumnId)) {
							array.Remove(item);
							break;
						}
					}
				}
			}
			SerializedList = Json.Serialize(array); 
		}

		public virtual EntitySchema GetCurrentEntitySchema() {
			if (RecordId == Guid.Empty) {
				return null;
			}
			var entitySchema = UserConnection.EntitySchemaManager.FindInstanceByUId(RecordId);
			if (entitySchema != null) {
				return entitySchema;
			}
			var entitySchemaUId = 
				Terrasoft.Core.Packages.WorkspaceUtilities.GetSchemaUIdById(RecordId, UserConnection);
			return UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaUId);
		}

		public virtual EntitySchemaColumn GetSchemaColumnById(Guid id) {
			var schema = GetCurrentEntitySchema();
			return schema.FindSchemaColumnByMetaPath(id.ToString());
		}

		public virtual Select GetEntitySchemaWithLoggingDisabled() {
			bool useLocalizationTable = true;
			string localizationTableName = "SysVwWorkspaceObjectsLcz";
			if (GlobalAppSettings.UseEntitySchemaLczNaming) {
				EntitySchema entitySchema = UserConnection.EntitySchemaManager.FindInstanceByName("VwWorkspaceObjects");
				useLocalizationTable = entitySchema.IsLocalizable;
				localizationTableName = entitySchema.LocalizationSchemaName;
			}
			var select = new Select(UserConnection);
			if (useLocalizationTable) {
				Guid currentUserCultureId = UserConnection.CurrentUser.SysCultureId;
				select.Column(Func.IsNull(Column.SourceColumn(localizationTableName, "Caption"),
						Column.SourceColumn("VwWorkspaceObjects", "Caption"))).As("SchemaCaption")
					.Join(JoinType.LeftOuter, localizationTableName)
						.On("VwWorkspaceObjects", "Id").IsEqual(localizationTableName, "RecordId")
						.And(localizationTableName, "SysCultureId").IsEqual(Column.Parameter(currentUserCultureId));
			} else {
				select.Column("VwWorkspaceObjects", "Caption").As("SchemaCaption");
			}
			select.Column("VwWorkspaceObjects", "UId")
				.From("VwWorkspaceObjects")
				.Where("SysWorkspaceId").IsEqual(Column.Parameter(UserConnection.Workspace.Id))
				.And("UId").Not().In(
					new Select(UserConnection)
						.Column("UId")
					.From("VwLogObjects"))
				.OrderBy(OrderDirectionStrict.Ascending, "SchemaCaption");
			return select;
		}

		public virtual void UpdateParentGrid() {
			object treeGridParameter = Page.GetParameterValue("treeGridId"); 
			string treeGridClientId = treeGridParameter == null ? string.Empty : treeGridParameter.ToString();
			if (!string.IsNullOrEmpty(treeGridClientId)) {
				var pageScript = 
					@"var treeGrid = null;
					if (window.opener) {
						treeGrid = window.opener.window.Ext.getCmp('" + treeGridClientId + @"');
					}
					if (treeGrid) {
						treeGrid.refreshData();
					}";
				Page.ScriptManager.AddScript(pageScript);
			}
		}

		public virtual void CompileEntitySchema(List<Guid> loggedColumnUIds) {
			var currentSchema = GetCurrentEntitySchema();
			var entitySchemaManager = Page.UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var desSchema = entitySchemaManager.FindItemByUId(currentSchema.UId) as ISchemaManagerItem;
			ISchemaManagerItem desSchemaItem = entitySchemaManager.DesignItemInCustomPackage(UserConnection, currentSchema.UId);
			var schema = desSchemaItem.Instance as EntitySchema;
			bool isSchemaTrackChangesInDB = false;
			foreach (var column in schema.Columns) {
				column.IsTrackChangesInDB = loggedColumnUIds.Contains(column.UId);
				if (column.IsTrackChangesInDB) {
					isSchemaTrackChangesInDB = true;
				}
			}
			schema.IsTrackChangesInDB = isSchemaTrackChangesInDB;
			entitySchemaManager.SaveDesignedItemInSessionData(UserConnection, schema as MetaSchema, schema.UId);
			entitySchemaManager.SaveSchema(schema.UId, Page.UserConnection);
			if (!GlobalAppSettings.FeatureUseRuntimeEntitySchemaMetadata) {
				var workspaceBuilder = WorkspaceBuilderUtility.CreateWorkspaceBuilder(Page.UserConnection.AppConnection);
				CompilerErrorCollection compilerErrors = workspaceBuilder.Build(Page.UserConnection.AppConnection.Workspace);
			}
			var configurationBuilder = ClassFactory.Get<IAppConfigurationBuilder>();
			configurationBuilder.BuildChanged();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ObjectComboBoxEditChange":
							if (ActivatedEventElements.Contains("ObjectComboBoxEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("ObjectComboBoxEditChangeStartMessage");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("AddButtonClickStartMessage");
						}
						break;
					case "RemoveButtonClick":
							if (ActivatedEventElements.Contains("RemoveButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("RemoveButtonClickStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage1")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage1");
						}
						break;
					case "StartDBMetaAction":
							if (ActivatedEventElements.Contains("StartDBMetaActionMessage")) {
							context.QueueTasks.Enqueue("StartDBMetaActionMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsViewOrVirtualSchemaSelected") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsViewOrVirtualSchemaSelected", IsViewOrVirtualSchemaSelected, false);
			}
			if (!HasMapping("InitialSerealizedList") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InitialSerealizedList", InitialSerealizedList, null);
			}
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (!HasMapping("SerializedList") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SerializedList", SerializedList, null);
			}
			if (!HasMapping("RecordId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogConfigurationEditPageEventsProcess

	/// <exclude/>
	public class ChangeLogConfigurationEditPageEventsProcess : ChangeLogConfigurationEditPageEventsProcess<Terrasoft.WebApp.ChangeLogConfigurationEditPageSchemaUserControl>
	{

		public ChangeLogConfigurationEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeLogConfigurationEditPageSchemaUserControl

	/// <exclude/>
	public partial class ChangeLogConfigurationEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ObjectComboBoxEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ObjectComboBoxEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout9 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout9", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout7 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout7", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout10 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout10", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label AllColumnsLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("AllColumnsLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid AllColumnsTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("AllColumnsTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout12 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout12", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button RemoveButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("RemoveButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout8 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout8", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout11 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout11", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Label LogColumnsLabel {
			get {
				return (Terrasoft.UI.WebControls.Controls.Label)PageContainer.FindPageControl("LogColumnsLabel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid LogColumnsTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("LogColumnsTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
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
			ObjectComboBoxEdit.AjaxEvents.Change.Event += ObjectComboBoxEditChange;
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			RemoveButton.AjaxEvents.Click.Event += RemoveButtonClick;
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectComboBoxEdit.AjaxEvents.Change.Event -= ObjectComboBoxEditChange;
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			RemoveButton.AjaxEvents.Click.Event -= RemoveButtonClick;
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ChangeLogConfigurationEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ChangeLogConfigurationEditPageEventsProcess(UserConnection);
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

		public virtual void ObjectComboBoxEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ObjectComboBoxEditChange");
		}

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void RemoveButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("RemoveButtonClick");
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
			SchemaName = "ChangeLogConfigurationEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogConfigurationEditPageEventsProcessSchema

	/// <exclude/>
	public class ChangeLogConfigurationEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ChangeLogConfigurationEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChangeLogConfigurationEditPageEventsProcessSchema(ChangeLogConfigurationEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeLogConfigurationEditPageEventsProcess";
			UId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("29b3e582-22d2-466c-bc88-ec2897e82981"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSerializedListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c6d3030c-9f08-4795-bf8f-db62626ab09a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"SerializedList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b41bda74-be39-4fe3-ad38-cf1024298d77"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("58e8e4c6-5381-4c9a-b9c5-82ee6fe35093"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInitialSerealizedListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("261153ef-5a43-4030-b6a3-c4979eb9e1ec"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"InitialSerealizedList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsViewOrVirtualSchemaSelectedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02c8c20e-a9f5-4982-99e6-8a67ee2ad603"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"IsViewOrVirtualSchemaSelected",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateSerializedListParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateIsNewParameter());
			Parameters.Add(CreateInitialSerealizedListParameter());
			Parameters.Add(CreateIsViewOrVirtualSchemaSelectedParameter());
		}

		protected virtual void InitializeShowMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c9ca402e-4b43-459b-a7f6-06f05e816202"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("df74980b-985e-4652-a594-59c34efaba23"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("bc756279-beb3-4bd1-ba70-0843a9998b27"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("0fd3361d-8df3-4941-81d4-af45192080fb"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("19fe8772-b81f-4062-9cb8-02d7efa6becb"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("45f07be1-de51-4b24-affb-3842e1c43eb4"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("7ebb609d-289b-4ea0-8151-4aecae92ba27"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
				UId = new Guid("6fde8354-db55-415a-9b47-9605116fc228"),
				ContainerUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
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
			ProcessSchemaLaneSet schemaLaneSet30 = CreateLaneSet30LaneSet();
			LaneSets.Add(schemaLaneSet30);
			ProcessSchemaLane schemaLane93 = CreateLane93Lane();
			schemaLaneSet30.Lanes.Add(schemaLane93);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent objectcomboboxeditchangestartmessage = CreateObjectComboBoxEditChangeStartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(objectcomboboxeditchangestartmessage);
			ProcessSchemaScriptTask objectcomboboxeditchangescripttask = CreateObjectComboBoxEditChangeScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(objectcomboboxeditchangescripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess7.FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask showmessageusertask = CreateShowMessageUserTaskUserTask();
			eventsubprocess7.FlowElements.Add(showmessageusertask);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			eventsubprocess7.FlowElements.Add(end1);
			ProcessSchemaStartMessageEvent addbuttonclickstartmessage = CreateAddButtonClickStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(addbuttonclickstartmessage);
			ProcessSchemaScriptTask addbuttonclickscripttask = CreateAddButtonClickScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(addbuttonclickscripttask);
			ProcessSchemaStartMessageEvent removebuttonclickstartmessage = CreateRemoveButtonClickStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(removebuttonclickstartmessage);
			ProcessSchemaScriptTask removebuttonclickscripttask = CreateRemoveButtonClickScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(removebuttonclickscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage1 = CreateOkButtonClickStartMessage1StartMessageEvent();
			eventsubprocess5.FlowElements.Add(okbuttonclickstartmessage1);
			ProcessSchemaStartMessageEvent startdbmetaactionmessage = CreateStartDBMetaActionMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(startdbmetaactionmessage);
			ProcessSchemaScriptTask startdbmetaactionscript = CreateStartDBMetaActionScriptScriptTask();
			eventsubprocess5.FlowElements.Add(startdbmetaactionscript);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(initscripttask);
			ProcessSchemaScriptTask okbuttonclickstartmessage = CreateOkButtonClickStartMessageScriptTask();
			FlowElements.Add(okbuttonclickstartmessage);
			FlowElements.Add(CreateSequenceFlow319SequenceFlow());
			FlowElements.Add(CreateSequenceFlow320SequenceFlow());
			FlowElements.Add(CreateSequenceFlow321SequenceFlow());
			FlowElements.Add(CreateSequenceFlow322SequenceFlow());
			FlowElements.Add(CreateSequenceFlow323SequenceFlow());
			FlowElements.Add(CreateSequenceFlow324SequenceFlow());
			FlowElements.Add(CreateSequenceFlow325SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateIsViewOrVirtualSchemaSelectedConditionalFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateViewObjectMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a36ea733-7046-45b2-8a9d-d1c6da33578a"),
				Name = "ColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateViewObjectMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a3de234b-e78a-4625-9ca7-cca1da59991f"),
				Name = "ViewObjectMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow319SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow319",
				UId = new Guid("4baec707-9b95-4a51-8979-dda88396620f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(248, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("125bc4d1-e803-4485-aa0f-65ab8a642a28"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6cf246ae-f915-4bad-909a-13f0e31cffd4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow320SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow320",
				UId = new Guid("e25cf457-19b3-445f-8d2d-3f422d06aee7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(250, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cfee8440-8261-4a48-bc6f-5f259e19ef9d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("32aaa3ca-b263-42e2-ac2c-006e4e2072b7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow321SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow321",
				UId = new Guid("3788c99b-1b84-4715-903f-3f649a6afca0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("61e20acf-e9e5-410c-9098-051d5e646e3d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b2a83e9-a312-4cc0-b900-5cd8fdf47679"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow322SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow322",
				UId = new Guid("b0aa33dd-1e0d-4d82-9384-377a50b3f4ba"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f156aeb-5865-43b2-b81f-096111606048"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("20872aaa-7764-4906-bc4c-0bd817a5403a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow323SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow323",
				UId = new Guid("8847e9b3-7775-4ff5-8eb1-10224fcc9a9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05e5fda9-3f89-4444-ae00-d71e0db2496f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("075f2678-9a71-461a-b877-2d38224587d2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(461, 681));
			schemaFlow.PolylinePointPositions.Add(new Point(461, 471));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow324SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow324",
				UId = new Guid("718bec4b-e508-4c45-8190-bbfc444fec4c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c9357b60-e20b-4fe6-b7d2-261c32f7e1f5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("23bcceee-2318-4b74-b53e-ff52f89855c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow325SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow325",
				UId = new Guid("62cce608-ffde-441f-92dc-1154e174977f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0a442ead-772a-4140-87d0-df3ae9d9bb4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab9a81fb-89f0-4367-acee-422c7036eea1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c3554455-9503-4fac-b2c6-83c297804592"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(449, 456),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9220775c-cdc9-4c23-a903-dee08554073e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("545ce653-0ab4-49c5-8600-c652ee6ce198"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d807359d-6f30-4b9f-aed1-a9fe7a4a13a4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(332, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab9a81fb-89f0-4367-acee-422c7036eea1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3770ea1a-260b-4181-af89-26356f3029c2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsViewOrVirtualSchemaSelectedConditionalFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsViewOrVirtualSchemaSelectedConditionalFlow",
				UId = new Guid("ceff4159-b9fb-4397-8502-4c007f86ef84"),
				ConditionExpression = @"IsViewOrVirtualSchemaSelected",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(432, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3770ea1a-260b-4181-af89-26356f3029c2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("9601b65a-c9e6-469b-a67a-bd8c2bee32f1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CurveCenterPosition = new Point(366, 130),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3770ea1a-260b-4181-af89-26356f3029c2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e294e1e-df13-4976-9a5b-8b0fd0c6e459"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet30LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet30 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("28741696-b986-4cc8-ba8c-e3b65e4a6da9"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"LaneSet30",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(936, 235),
				UseBackgroundMode = false
			};
			return schemaLaneSet30;
		}

		protected virtual ProcessSchemaLane CreateLane93Lane() {
			ProcessSchemaLane schemaLane93 = new ProcessSchemaLane(this) {
				UId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("28741696-b986-4cc8-ba8c-e3b65e4a6da9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"Lane93",
				Position = new Point(29, 0),
				Size = new Size(907, 235),
				UseBackgroundMode = false
			};
			return schemaLane93;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess7",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(661, 217),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateObjectComboBoxEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0a442ead-772a-4140-87d0-df3ae9d9bb4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectComboBoxEditChange",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"ObjectComboBoxEditChangeStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectComboBoxEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ab9a81fb-89f0-4367-acee-422c7036eea1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"ObjectComboBoxEditChangeScriptTask",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,84,77,83,219,48,16,61,135,25,254,131,224,192,56,23,255,129,14,135,58,113,25,79,11,201,196,33,247,69,222,36,2,89,74,165,53,56,45,252,247,174,20,7,8,29,3,215,118,198,62,72,251,246,237,199,123,246,12,165,117,85,81,137,115,145,92,52,170,26,78,97,133,233,228,230,22,37,141,108,125,99,51,219,230,149,162,116,1,186,193,47,199,71,37,58,5,90,253,194,234,135,242,196,105,158,156,50,171,52,175,55,180,229,120,225,23,10,31,38,110,161,28,53,160,75,185,198,26,74,212,204,135,161,202,18,180,15,60,106,41,146,147,89,87,61,205,127,50,214,199,14,118,76,195,161,248,125,124,52,184,7,39,208,144,162,237,142,136,9,174,61,186,145,53,134,9,149,53,105,254,42,122,9,134,187,119,233,5,82,97,60,129,145,152,109,175,139,42,217,215,25,114,225,65,168,124,192,121,114,46,76,163,181,56,59,59,12,164,97,150,56,133,120,124,20,111,34,227,44,204,217,181,57,232,219,90,217,248,13,154,234,235,45,180,249,61,51,248,36,182,208,139,31,105,4,215,97,102,47,210,188,236,229,221,236,25,250,166,198,191,138,149,107,251,112,137,222,115,86,88,222,28,252,93,218,157,231,216,6,13,163,100,145,175,187,239,205,43,164,53,156,112,90,92,125,155,156,246,162,178,134,200,26,31,128,147,239,253,176,169,179,146,175,246,90,197,81,247,7,150,45,230,125,228,39,114,209,150,131,39,126,201,109,119,114,188,209,106,238,64,222,141,214,96,86,200,197,198,217,171,180,67,104,222,18,171,53,5,199,183,189,32,254,18,84,5,132,87,80,163,79,162,159,227,158,159,132,4,146,107,145,228,173,196,77,48,167,192,246,255,240,7,182,233,191,107,12,177,84,6,180,254,180,53,246,127,168,247,189,241,140,98,227,241,83,24,69,99,32,40,109,227,184,245,184,89,135,212,56,179,107,228,15,93,207,217,62,104,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3770ea1a-260b-4181-af89-26356f3029c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(267, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateShowMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b0f06ee9-03fe-432d-bcdf-b7a00fdcce83"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"ShowMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 37),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeShowMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("6e294e1e-df13-4976-9a5b-8b0fd0c6e459"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f573833-8b19-429c-bd74-7aa57bfa8d36"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"End1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f8335dfc-4d8d-4e69-9630-9d8c40f09ce9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess3",
				Position = new Point(39, 250),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(304, 149),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("61e20acf-e9e5-410c-9098-051d5e646e3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8335dfc-4d8d-4e69-9630-9d8c40f09ce9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"AddButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b2a83e9-a312-4cc0-b900-5cd8fdf47679"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f8335dfc-4d8d-4e69-9630-9d8c40f09ce9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"AddButtonClickScriptTask",
				Position = new Point(158, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,245,44,73,205,45,14,201,15,201,72,13,202,76,207,40,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,108,79,114,173,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e4a199aa-c6d4-45f6-8231-b8ded0c9f69f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess4",
				Position = new Point(364, 254),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(304, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateRemoveButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8f156aeb-5865-43b2-b81f-096111606048"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4a199aa-c6d4-45f6-8231-b8ded0c9f69f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"RemoveButtonClick",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"RemoveButtonClickStartMessage",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRemoveButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("20872aaa-7764-4906-bc4c-0bd817a5403a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e4a199aa-c6d4-45f6-8231-b8ded0c9f69f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"RemoveButtonClickScriptTask",
				Position = new Point(155, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,205,47,75,245,44,73,205,45,14,201,15,201,72,245,73,77,43,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,223,252,63,201,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("13939597-42d0-4634-91fa-34819e797108"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess5",
				Position = new Point(718, 620),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(541, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("05e5fda9-3f89-4444-ae00-d71e0db2496f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13939597-42d0-4634-91fa-34819e797108"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"OkButtonClickStartMessage1",
				Position = new Point(36, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartDBMetaActionMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9220775c-cdc9-4c23-a903-dee08554073e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13939597-42d0-4634-91fa-34819e797108"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"StartDBMetaAction",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"StartDBMetaActionMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartDBMetaActionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("545ce653-0ab4-49c5-8600-c652ee6ce198"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13939597-42d0-4634-91fa-34819e797108"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"StartDBMetaActionScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(428, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,203,106,195,48,16,188,23,250,15,75,78,50,20,253,64,40,193,117,67,233,33,16,112,66,206,138,181,77,4,174,20,86,107,183,249,251,234,225,20,181,241,105,89,205,236,236,104,118,84,4,190,59,227,167,130,103,120,67,110,6,34,180,188,182,108,248,218,38,64,84,203,199,135,49,240,244,203,6,89,213,29,27,103,55,202,170,19,82,24,218,134,42,247,30,169,113,214,98,2,83,59,49,182,228,70,163,145,100,16,159,158,196,226,245,94,105,81,129,242,48,3,132,229,249,181,237,200,92,24,244,177,104,230,215,151,252,223,241,44,218,184,190,207,44,80,169,248,160,49,243,177,104,183,12,33,131,94,228,172,228,254,93,87,176,90,129,197,47,152,151,23,127,61,197,12,75,231,178,214,186,212,111,213,104,236,233,182,101,178,246,52,157,230,110,120,253,141,221,192,248,143,30,105,34,229,81,251,75,172,49,209,29,18,41,239,62,56,120,150,7,60,6,75,76,174,247,50,18,42,217,244,206,99,186,48,33,15,100,129,105,192,229,15,209,133,155,132,22,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9fa675c3-f016-45af-aadf-608cd27f25f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess6",
				Position = new Point(589, 400),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(304, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c9357b60-e20b-4fe6-b7d2-261c32f7e1f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fa675c3-f016-45af-aadf-608cd27f25f5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("23bcceee-2318-4b74-b53e-ff52f89855c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fa675c3-f016-45af-aadf-608cd27f25f5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(155, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("74b10479-00e9-49d5-b269-21b301a81ff8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 583),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("125bc4d1-e803-4485-aa0f-65ab8a642a28"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74b10479-00e9-49d5-b269-21b301a81ff8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6cf246ae-f915-4bad-909a-13f0e31cffd4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("74b10479-00e9-49d5-b269-21b301a81ff8"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,111,226,48,16,61,7,137,255,96,56,5,105,101,117,47,123,65,61,64,136,42,36,186,173,26,218,61,155,120,26,92,28,27,249,131,143,93,241,223,119,28,135,66,91,21,124,0,101,252,230,205,248,189,25,241,74,210,222,179,5,147,105,165,160,116,66,43,58,25,23,80,122,35,220,62,87,149,80,64,239,192,101,76,229,59,140,58,120,88,131,97,1,151,246,49,248,34,96,139,169,175,162,242,49,218,31,12,200,191,110,39,185,198,153,45,161,92,125,199,122,207,20,171,32,91,50,85,193,76,87,253,193,176,219,57,116,59,143,24,164,15,171,177,119,14,41,71,111,108,151,111,64,57,75,51,41,202,21,157,139,26,180,119,228,150,252,186,9,103,120,53,163,88,234,237,76,51,126,207,236,10,211,156,241,112,76,26,73,153,105,233,107,101,103,108,1,146,142,181,228,159,32,216,217,5,72,1,70,48,41,254,2,159,9,27,154,178,206,8,85,209,188,94,187,61,222,79,149,112,8,64,24,92,130,233,197,27,74,72,204,52,80,55,101,209,141,71,102,88,13,14,204,11,147,30,210,190,129,82,27,62,229,141,80,2,45,13,240,222,45,81,94,202,104,199,83,139,64,18,5,91,114,231,5,15,32,58,215,69,83,47,29,52,26,19,144,22,62,39,4,112,219,79,210,248,16,42,188,223,247,206,1,177,216,212,254,198,26,183,228,149,33,27,210,38,27,102,136,45,151,80,179,64,135,211,228,141,65,27,114,229,112,32,138,230,34,13,245,147,232,87,243,228,76,215,11,61,214,187,156,11,71,71,156,79,29,212,105,36,161,207,31,58,255,209,114,211,140,173,195,8,93,100,42,64,98,232,123,178,139,201,19,97,217,66,66,236,53,24,56,97,142,21,218,155,18,108,12,6,105,122,173,133,40,3,234,255,96,26,101,210,143,243,208,110,73,114,101,10,50,189,254,146,25,202,28,78,94,37,73,114,38,121,59,124,73,124,38,177,241,175,17,253,92,237,63,194,45,113,124,113,19,171,246,77,60,246,239,45,134,72,26,12,227,139,184,155,218,96,254,167,117,206,149,245,6,38,227,83,40,61,190,168,101,152,6,105,158,128,113,64,166,192,16,91,161,237,190,199,155,244,84,227,152,158,108,151,66,2,73,185,161,1,243,78,155,36,81,18,178,9,35,143,124,105,252,30,32,16,31,23,23,225,102,48,140,114,224,9,67,73,86,176,255,218,252,100,60,223,175,1,3,27,48,184,67,248,221,100,207,117,179,21,231,124,63,227,56,224,185,54,152,88,232,195,68,54,93,158,186,57,132,223,67,107,92,183,99,192,121,163,162,89,255,1,20,162,158,208,130,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("57a38ce1-26e6-4767-ae05-81cd03306f10"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 582),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cfee8440-8261-4a48-bc6f-5f259e19ef9d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a38ce1-26e6-4767-ae05-81cd03306f10"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("32aaa3ca-b263-42e2-ac2c-006e4e2072b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57a38ce1-26e6-4767-ae05-81cd03306f10"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,37,199,49,10,128,48,12,0,192,189,175,232,168,75,62,80,28,180,58,43,8,238,161,6,169,45,45,164,137,248,124,7,111,59,207,132,66,51,10,238,85,57,80,235,122,103,54,188,8,214,52,169,72,45,48,222,248,46,15,21,105,224,115,12,9,60,106,163,118,96,142,39,74,172,197,14,86,88,201,25,38,81,46,127,62,235,19,109,171,89,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickStartMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("075f2678-9a71-461a-b877-2d38224587d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0b3a189b-818b-4d0d-abac-c9b59bf89da0"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(100, 444),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,193,78,227,48,16,134,207,84,234,59,12,61,128,45,85,17,28,119,187,32,149,208,69,173,96,23,41,173,184,112,49,201,180,49,235,216,145,61,129,237,86,121,247,181,157,84,84,229,66,14,206,120,52,254,231,155,223,94,76,173,21,91,16,113,189,2,141,239,176,136,41,198,39,195,129,92,3,59,117,100,165,222,36,115,247,171,81,234,183,157,85,53,109,89,134,86,10,37,255,97,113,47,29,113,14,187,225,224,100,175,178,112,70,39,183,232,246,53,199,213,32,92,223,197,247,104,135,131,144,252,113,215,200,226,26,148,217,108,176,72,141,106,42,189,154,23,174,103,250,168,136,92,107,99,81,228,37,176,55,97,65,18,86,32,117,55,67,7,114,172,146,76,139,130,5,157,32,193,62,225,5,133,100,105,178,56,40,227,252,48,230,29,98,112,194,59,224,37,206,206,62,65,38,169,105,52,193,53,92,116,237,83,83,213,82,225,76,147,164,109,150,151,88,9,118,124,38,234,2,42,135,16,93,142,226,221,241,176,239,77,15,74,194,30,27,56,134,185,150,228,19,62,141,135,233,181,240,122,28,78,175,246,36,95,70,57,105,227,152,171,186,16,132,143,190,165,166,59,235,189,218,191,130,3,188,14,13,92,110,101,77,254,126,122,212,159,198,86,130,216,104,137,254,30,156,89,83,50,125,21,127,31,144,74,227,29,90,150,214,188,167,74,122,221,217,155,95,158,36,149,15,194,253,97,207,231,187,139,246,249,124,12,62,184,140,193,110,71,178,66,211,208,247,111,241,107,91,62,25,133,145,29,9,157,163,39,30,195,40,35,97,233,246,198,203,139,105,78,210,232,81,156,226,81,108,48,92,118,22,225,88,199,120,96,117,224,103,93,145,171,195,63,60,197,15,226,213,60,121,194,151,212,104,178,70,185,36,20,240,36,85,198,33,235,223,129,69,106,172,6,178,13,78,254,3,149,63,65,255,60,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateDataSourcesMethod());
			Methods.Add(CreateCreateVirtualDataSourceMethod());
			Methods.Add(CreateCreateVirtualDataSourceStructureMethod());
			Methods.Add(CreateGetDataSourceMethod());
			Methods.Add(CreateGetLeftDataSourceMethod());
			Methods.Add(CreateGetRightDataSourceMethod());
			Methods.Add(CreateInitDataSourcesMethod());
			Methods.Add(CreateAddRowMethod());
			Methods.Add(CreateMoveItemsToTheRightMethod());
			Methods.Add(CreateMoveItemsToTheLeftMethod());
			Methods.Add(CreateGetCurrentEntitySchemaMethod());
			Methods.Add(CreateGetSchemaColumnByIdMethod());
			Methods.Add(CreateGetEntitySchemaWithLoggingDisabledMethod());
			Methods.Add(CreateUpdateParentGridMethod());
			Methods.Add(CreateCompileEntitySchemaMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("03d681e3-0268-4b5c-8426-332e1994e631"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fd30bfcd-7a4e-43f0-b0f7-5261ef298167"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("91fee092-7164-44b0-a8b8-8ad99ef73211"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9fe59177-5b6b-4bff-acd5-ef0623623949"),
				Name = "System.Collections.ObjectModel",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9eca7f82-ad52-48e5-a3ad-84f916b65ddf"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("af575fce-ae2a-4428-b018-89b6248756f6"),
				Name = "System.CodeDom.Compiler",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb27932e-e292-42b1-9162-b9c51908d8c5"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3122a687-e63f-4d35-9c38-6b644078c914"),
				Name = "Terrasoft.Core.ConfigurationBuild",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c084bf1c-f0a6-40e5-9674-5097a0016358"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateCreateDataSourcesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("491e214e-f21f-448f-934b-d9502038c628"),
				Name = "CreateDataSources",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,203,44,42,41,77,204,113,73,44,73,12,206,47,45,74,78,245,73,77,43,81,176,85,112,46,74,77,44,73,13,67,151,213,80,194,170,65,73,211,154,43,32,49,61,85,207,49,39,199,57,63,167,52,55,175,56,164,40,53,213,189,40,51,69,15,161,210,51,5,104,48,86,253,122,158,46,214,92,101,216,156,19,148,153,158,65,154,123,192,58,224,14,242,201,79,39,213,65,96,3,64,46,2,0,8,220,29,228,32,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateVirtualDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6bbd17f8-047e-4172-ba92-133fa350a29b"),
				Name = "CreateVirtualDataSource",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e7698c53-da91-4d39-b828-b015ffac301a"),
				Name = "virtualDataSourceId",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,77,111,131,48,12,61,143,95,17,113,10,210,20,237,142,56,176,34,77,28,54,33,245,99,103,143,184,85,38,8,200,36,108,104,234,127,159,89,171,22,6,151,36,126,126,118,158,95,210,3,137,222,144,243,80,101,224,96,219,120,42,81,36,194,226,151,56,252,199,101,36,126,242,140,179,139,138,92,159,227,96,129,170,13,33,56,212,207,67,250,9,223,92,39,11,56,161,26,151,77,99,29,24,139,36,160,19,59,36,130,174,57,58,181,207,213,59,126,140,73,106,170,110,114,142,230,189,226,96,217,73,221,202,82,173,229,66,76,20,7,247,96,235,200,151,206,19,10,141,199,123,176,50,153,202,38,132,56,48,71,33,167,37,124,105,229,107,219,241,238,173,19,73,34,158,216,164,224,97,157,83,33,144,100,33,243,116,65,166,6,26,46,172,55,168,71,29,97,174,67,230,245,252,60,154,181,28,160,242,184,27,90,124,5,203,51,211,232,101,182,130,71,127,182,236,59,36,54,195,98,233,76,99,85,218,182,215,116,65,77,111,52,91,245,130,238,10,201,112,173,79,56,138,188,56,190,248,5,55,225,114,77,217,227,204,81,110,115,14,8,249,104,151,214,198,191,197,89,184,180,125,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateVirtualDataSourceStructureMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b8da91ab-a7ec-44a6-afac-16213908e6aa"),
				Name = "CreateVirtualDataSourceStructure",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f5d7afbb-7d18-40c2-9b19-ca90bc81ccbe"),
				Name = "dataValueTypeManager",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataValueTypeManager",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2b4cc824-4360-45fd-b69f-34e0ca257eee"),
				Name = "defStructure",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceStructure",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,143,177,10,131,48,24,132,103,243,20,193,73,65,124,1,233,208,90,40,14,118,81,220,255,154,223,18,208,68,98,210,86,74,223,189,198,72,17,71,59,133,187,251,185,220,247,0,69,107,217,154,78,208,3,21,248,164,103,208,80,72,163,106,44,180,50,181,54,10,83,151,191,137,231,93,161,195,233,208,207,152,31,77,178,130,214,44,241,38,177,53,115,90,142,189,245,217,90,231,32,224,142,42,190,160,206,196,160,65,212,120,26,109,65,224,95,12,103,126,104,27,82,232,53,151,98,213,153,13,21,31,248,173,181,125,13,180,3,58,179,144,74,195,202,37,159,132,48,108,126,243,227,35,99,110,99,224,72,195,132,236,64,182,239,95,104,57,50,110,186,18,95,122,11,232,126,91,116,60,119,69,158,183,33,158,166,237,7,254,2,242,172,90,184,231,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4ef9c12d-3dc4-4311-9bd3-7f4e3ac9abed"),
				Name = "GetDataSource",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1c78db3-0cf7-4762-95e7-8543a649af53"),
				Name = "left",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,200,73,77,43,209,84,168,230,226,44,74,45,41,45,202,83,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,45,201,204,201,44,201,76,45,214,131,10,33,4,220,50,243,82,160,130,26,1,137,233,169,122,142,197,5,96,26,166,57,218,32,86,71,65,169,44,179,168,164,52,49,199,37,177,36,49,56,191,180,40,57,213,7,104,183,146,142,66,73,81,105,170,166,66,98,177,66,24,186,2,107,174,90,46,174,1,112,88,80,102,122,6,1,151,1,0,40,103,96,37,60,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLeftDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9807d352-e0dd-474b-a04b-706fc2b417e5"),
				Name = "GetLeftDataSource",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,79,45,113,73,44,73,12,206,47,45,74,78,213,40,41,42,77,213,180,6,0,222,44,87,18,27,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRightDataSourceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("088c64fa-6ce5-4faa-97d1-8bdb243f67f7"),
				Name = "GetRightDataSource",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,79,45,113,73,44,73,12,206,47,45,74,78,213,72,75,204,41,78,213,180,6,0,67,170,133,110,28,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitDataSourcesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1a4e623c-277f-4a24-8af8-6ffb87e9628a"),
				Name = "InitDataSources",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,65,110,194,48,16,69,215,65,226,14,211,93,34,85,190,0,98,65,211,10,129,162,170,2,122,128,81,50,36,86,141,141,38,14,136,86,220,189,142,13,52,9,173,186,72,98,121,222,252,255,51,246,1,25,20,109,237,51,90,92,155,134,115,130,41,204,201,102,189,189,56,153,140,71,7,135,178,44,171,59,118,213,223,244,240,0,20,169,34,100,95,233,187,117,10,111,88,146,152,41,149,26,213,236,116,189,97,162,57,203,98,72,100,166,252,155,120,209,86,218,211,58,175,104,135,80,135,143,207,152,54,204,164,109,183,238,27,228,22,226,43,55,5,221,40,149,192,215,120,20,49,217,134,181,3,206,227,209,114,198,140,39,64,255,118,16,29,33,108,121,133,173,97,194,188,130,184,157,79,238,147,129,212,23,115,113,137,26,68,91,179,64,136,247,218,253,203,230,180,39,120,152,66,55,85,104,184,149,197,171,209,20,186,163,89,81,172,204,49,238,15,240,17,174,138,139,226,182,78,113,111,165,209,109,188,168,235,186,112,51,195,252,35,173,80,151,84,47,244,243,211,69,250,170,61,56,182,255,197,35,63,21,225,218,227,101,109,180,88,19,75,84,242,147,226,159,206,36,160,110,146,237,115,190,187,2,153,193,214,188,254,245,226,244,138,55,245,34,147,181,117,103,49,240,244,97,146,201,55,47,245,228,220,213,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddRowMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2457af91-8d45-4a74-811e-94dce7113210"),
				Name = "AddRow",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("17a418af-18df-4628-9522-5cc76dd74774"),
				Name = "dataSource",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "VirtualDataSource",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7deebede-f562-4d1b-ad34-6919128d9aa0"),
				Name = "id",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("77423907-71e6-4104-86ba-4d2f59c14c8b"),
				Name = "name",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,202,47,87,176,85,72,73,44,73,12,206,47,45,74,78,213,115,46,74,77,44,73,13,202,47,215,208,180,230,228,2,74,235,5,167,150,56,231,231,148,230,230,133,37,230,148,166,106,40,121,166,40,233,40,100,166,104,90,99,149,245,75,204,77,5,202,231,1,41,160,10,36,131,29,83,82,52,128,26,52,173,1,62,116,65,179,119,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMoveItemsToTheRightMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0ccab5d5-e4d5-475d-b3ee-3a4b3a51cf6d"),
				Name = "MoveItemsToTheRight",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,97,107,219,48,16,253,108,67,254,195,173,159,28,40,234,190,167,46,100,233,8,46,161,45,243,182,239,138,117,73,196,100,169,72,114,58,111,236,191,239,36,217,171,147,181,5,219,24,233,189,123,119,239,221,145,91,80,184,243,183,220,243,218,116,182,65,40,225,145,239,145,45,149,90,25,213,181,218,125,181,136,107,43,5,123,1,45,102,249,145,152,86,238,15,175,80,55,102,255,46,245,97,235,208,30,249,86,33,193,20,54,94,26,125,93,247,206,99,203,214,157,20,55,160,198,10,149,112,84,245,180,67,86,99,32,161,168,136,240,104,101,203,109,159,208,223,185,234,208,145,130,220,65,49,173,193,86,166,211,30,202,18,62,206,225,247,44,207,44,250,206,106,66,254,153,229,119,75,107,121,15,60,126,75,208,157,82,67,137,15,206,91,169,247,172,114,247,116,248,96,63,183,79,190,47,106,180,146,43,249,11,197,70,58,63,79,5,71,246,157,51,154,221,162,27,49,231,104,224,14,146,96,16,7,84,14,79,248,26,159,135,251,98,158,218,155,229,59,99,145,55,135,34,88,62,153,10,164,134,19,167,82,39,91,99,20,224,79,18,163,214,169,226,142,147,6,149,202,2,189,137,88,58,93,163,175,155,3,182,60,177,63,245,149,152,58,22,180,179,171,171,1,207,190,85,226,114,252,95,241,167,16,24,221,135,172,128,158,114,2,11,188,228,26,104,222,226,203,221,64,27,27,161,57,191,152,103,186,62,219,33,182,162,89,61,210,29,205,159,17,56,1,41,115,63,201,184,184,168,196,197,37,105,199,62,223,128,220,147,62,129,66,27,17,118,174,68,28,199,150,66,20,137,159,228,166,94,75,218,175,96,114,204,38,153,155,133,181,8,231,44,138,92,167,81,111,138,121,216,173,152,253,191,188,11,234,110,32,101,147,56,188,237,98,26,89,182,37,165,31,241,151,82,142,111,220,185,17,59,112,163,120,108,243,149,242,139,68,164,231,116,205,224,191,102,210,12,11,152,229,231,54,108,12,23,193,10,242,251,47,57,25,221,78,14,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMoveItemsToTheLeftMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6eef82a2-bfcb-4c0a-a7dc-6043cbebc128"),
				Name = "MoveItemsToTheLeft",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,80,203,106,195,48,16,60,199,224,127,216,220,236,139,232,61,117,161,36,165,56,132,54,52,161,119,53,222,184,162,178,84,86,178,193,45,249,247,234,17,167,118,162,195,34,164,121,236,76,199,9,42,110,249,78,183,116,64,40,96,203,107,100,27,93,47,181,108,27,101,246,132,248,76,162,98,171,11,104,145,38,157,99,201,1,83,86,198,241,254,69,216,14,37,30,44,86,165,197,102,75,162,225,212,71,228,59,151,45,26,182,215,27,97,108,150,59,33,113,132,108,44,196,150,186,85,22,138,2,238,114,248,77,147,25,161,109,73,57,228,41,77,214,143,68,188,7,30,102,1,170,149,242,44,49,55,150,132,170,89,105,94,220,227,43,61,53,223,182,207,118,72,130,75,241,131,149,247,203,163,224,192,94,27,173,216,10,205,128,185,70,3,55,16,13,163,249,81,19,242,195,103,118,21,29,132,130,73,21,209,101,212,198,27,54,186,195,113,74,31,124,230,215,142,187,204,99,148,72,156,141,125,132,43,208,27,4,220,249,63,16,253,7,11,109,222,199,228,15,89,238,75,11,161,46,65,38,158,3,61,22,48,108,229,133,194,58,238,124,56,227,175,120,63,249,233,199,41,100,159,86,3,55,62,113,191,5,252,1,230,202,130,72,77,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCurrentEntitySchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2caf9b5f-6ae5-4a4b-ba64-a4d9c75790c9"),
				Name = "GetCurrentEntitySchema",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchema"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,207,193,138,194,64,12,6,224,179,243,20,241,102,65,230,5,74,47,138,43,61,8,203,106,241,60,204,196,53,180,102,36,147,10,69,124,119,199,101,145,42,123,216,107,66,242,127,63,29,96,246,133,62,74,168,3,84,21,172,123,10,118,117,58,235,80,192,213,76,4,181,23,6,238,187,174,52,55,115,113,2,200,74,58,108,253,17,79,14,42,104,18,202,50,50,163,87,138,108,87,163,237,198,177,251,70,177,31,196,161,230,164,142,61,46,134,166,14,207,196,162,52,148,1,47,47,167,213,79,220,56,126,188,255,139,209,60,236,96,38,59,20,113,41,30,212,46,163,160,253,116,190,205,128,100,247,81,218,116,118,30,27,165,142,148,242,104,141,250,188,93,12,35,210,252,173,81,38,254,42,254,209,52,127,125,45,250,166,44,202,59,191,107,209,53,112,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaColumnByIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7331b087-ad83-4936-8222-0c72b6a97d64"),
				Name = "GetSchemaColumnById",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchemaColumn"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("838662e6-080d-4d82-a859-53b20618d0e7"),
				Name = "id",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,78,206,72,205,77,84,176,85,112,79,45,113,46,45,42,74,205,43,113,205,43,201,44,169,12,6,75,104,104,90,115,21,165,150,148,22,229,65,85,234,185,101,230,165,64,228,156,243,115,74,115,243,156,42,125,83,75,18,3,18,75,50,52,50,83,244,66,242,131,75,138,50,243,210,53,52,53,173,1,90,94,209,196,95,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntitySchemaWithLoggingDisabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("64bf8be5-717e-499b-a61e-c9db9e755112"),
				Name = "GetEntitySchemaWithLoggingDisabled",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Select"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,203,110,219,48,16,60,75,95,65,232,68,1,6,127,64,200,193,113,227,192,133,99,23,85,210,156,105,106,227,168,161,73,149,143,6,74,145,127,239,82,116,20,217,145,210,94,36,136,59,59,156,153,37,181,211,90,18,111,97,173,5,151,245,11,119,181,86,183,124,39,129,92,16,103,60,20,169,117,166,86,123,34,207,1,27,126,8,160,172,108,237,143,231,123,109,158,108,195,5,108,119,63,65,56,187,22,47,89,145,214,15,132,94,75,189,227,114,222,52,37,56,135,68,150,221,89,184,82,174,118,109,41,30,225,192,17,138,84,88,201,201,159,52,25,86,8,12,63,46,8,54,154,133,86,10,55,64,17,108,8,189,225,138,239,193,176,101,173,170,149,178,142,43,1,151,109,144,72,179,143,234,178,188,72,147,9,211,195,61,217,202,190,65,176,136,61,83,33,156,52,13,89,227,82,64,21,233,107,250,155,27,98,65,162,4,236,81,240,76,202,238,131,158,26,203,99,112,99,250,186,136,174,125,93,17,225,141,193,93,187,78,47,157,55,176,170,62,70,180,120,71,49,156,83,143,68,43,81,7,91,104,233,15,138,46,189,18,232,118,227,165,164,113,137,149,218,27,1,199,250,168,241,25,201,22,188,9,75,89,62,75,147,36,25,235,28,139,127,216,152,231,108,110,105,22,131,234,87,145,141,125,213,181,162,225,113,219,54,192,214,240,224,182,222,129,153,141,31,197,208,146,176,237,228,134,171,42,203,209,225,213,47,207,229,164,157,239,32,180,169,2,180,99,155,171,106,18,58,140,115,192,124,140,224,27,55,8,67,181,116,108,80,57,142,248,149,128,180,16,230,121,58,137,127,229,53,150,86,56,91,255,197,114,23,173,177,165,209,135,241,139,129,197,251,71,48,120,109,208,96,95,254,220,226,217,161,235,187,88,112,154,198,24,227,214,108,163,29,69,38,69,49,223,233,11,208,133,255,230,228,168,249,93,244,90,239,123,185,129,126,107,42,48,151,45,237,222,95,106,19,73,74,252,109,97,30,115,43,64,85,248,119,9,35,59,79,205,0,206,67,29,175,100,241,23,208,173,101,136,11,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateParentGridMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6df5607e-f0d6-46a8-bde1-7c28eee142bc"),
				Name = "UpdateParentGrid",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,205,78,195,48,12,62,183,79,97,114,89,162,73,121,0,170,137,161,49,77,61,0,147,134,184,135,197,43,65,109,26,185,30,3,161,189,59,233,223,128,141,139,37,219,223,159,93,191,188,225,150,129,9,113,69,206,174,13,153,10,25,9,102,176,54,5,234,21,242,105,246,108,202,61,74,49,98,115,43,84,6,105,195,228,124,113,82,88,148,14,61,231,54,10,252,35,58,3,191,47,75,184,129,158,165,151,85,224,79,184,190,132,234,167,122,211,65,164,202,82,183,3,121,53,48,242,230,33,42,60,82,199,148,231,174,74,193,87,154,188,27,130,16,211,111,182,228,2,199,36,105,146,204,69,59,29,241,208,7,201,226,162,21,63,56,111,235,131,174,3,122,164,78,34,73,126,65,255,172,245,208,45,63,88,23,200,139,42,200,137,128,233,229,3,166,48,23,19,213,90,28,7,155,17,114,230,160,9,119,132,205,235,157,97,35,123,130,136,181,251,127,127,194,189,241,177,33,125,107,109,63,144,63,231,69,194,241,27,131,42,34,185,198,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompileEntitySchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c7a43bd3-ba13-43fa-ac70-d61a20045293"),
				Name = "CompileEntitySchema",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("638c0d3f-c0e9-4cfd-9a13-41f99017a436"),
				Name = "loggedColumnUIds",
				CreatedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				ModifiedInSchemaUId = new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Guid>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,110,163,48,16,61,195,87,184,61,17,169,242,15,208,173,180,33,73,197,161,82,181,105,180,231,41,76,136,85,99,71,30,147,42,90,229,223,119,192,180,41,129,180,39,139,153,55,239,189,241,140,57,128,19,69,227,28,26,191,46,118,88,131,248,37,30,209,103,33,180,52,94,249,99,72,36,179,52,62,48,26,191,196,158,192,64,133,142,107,158,249,148,27,66,151,89,99,176,240,202,26,201,60,3,88,114,187,28,215,222,206,4,144,152,72,4,181,18,233,211,215,132,178,92,41,83,230,30,235,249,113,147,151,201,160,19,201,145,142,60,31,148,180,232,52,30,199,206,82,221,215,180,220,2,73,85,166,5,228,38,107,200,219,250,25,138,55,78,37,195,222,239,196,216,74,104,136,62,186,25,200,201,220,144,7,83,224,229,101,164,241,171,181,90,168,30,251,226,88,46,219,129,169,144,114,179,152,51,207,22,52,97,26,111,173,67,40,118,34,105,69,10,171,155,218,8,101,122,57,153,117,1,154,137,127,113,20,146,50,167,9,50,109,171,10,203,128,102,207,196,133,198,131,50,148,244,85,161,145,72,109,69,114,149,167,83,137,190,177,236,93,195,142,163,83,124,138,123,127,147,102,174,49,164,241,212,104,214,112,192,48,30,44,195,128,214,72,196,179,88,128,135,209,120,250,49,240,109,63,161,135,192,244,17,237,155,188,38,210,63,135,51,246,110,106,251,153,160,189,164,155,71,109,95,65,255,222,239,215,232,189,50,21,201,21,130,111,28,50,252,79,195,18,53,14,150,159,221,148,108,184,187,195,118,148,239,214,189,209,30,10,156,55,74,151,221,91,251,123,17,218,120,165,153,64,102,188,1,30,47,179,201,212,211,100,63,3,171,81,102,235,189,210,232,150,206,89,6,106,29,82,188,73,95,226,196,226,151,126,100,119,254,44,34,63,125,177,220,41,14,91,106,182,170,106,28,180,249,115,123,153,6,162,21,20,222,186,99,251,15,185,207,3,209,8,251,208,254,146,166,72,130,167,176,49,37,131,254,3,188,143,207,100,229,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeLogConfigurationEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c3b52ff-60ab-4ed8-8a6e-6a5e63f8bc0f"));
		}

		#endregion

	}

	#endregion

}

