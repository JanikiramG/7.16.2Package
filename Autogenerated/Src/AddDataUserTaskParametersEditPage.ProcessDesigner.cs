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
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;
	using VwSysEntitySchemaInWorkspace = Terrasoft.Configuration.VwSysEntitySchemaInWorkspace;
	using VwSysPageSchemaInWorkspace = Terrasoft.Configuration.VwSysPageSchemaInWorkspace;

	#region Class: AddDataUserTaskParametersEditPageSchema

	/// <exclude/>
	public class AddDataUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _userTaskTitleEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return _userTaskTitleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _entitySchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaEdit {
			get {
				return _entitySchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _addOneRowEdit;
		public Terrasoft.UI.WebControls.Controls.RadioButton AddOneRowEdit {
			get {
				return _addOneRowEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.RadioButton _addFilterResultEdit;
		public Terrasoft.UI.WebControls.Controls.RadioButton AddFilterResultEdit {
			get {
				return _addFilterResultEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return _filterControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _filterEntitySchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit FilterEntitySchemaEdit {
			get {
				return _filterEntitySchemaEdit;
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _columnValuesTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid ColumnValuesTreeGrid {
			get {
				return _columnValuesTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _filterDataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource FilterDataSource {
			get {
				return _filterDataSource;
			}
		}

		#endregion

		#region Constructors: Public

		public AddDataUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AddDataUserTaskParametersEditPageSchema(AddDataUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			RealUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			Name = "AddDataUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 550;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAddDataUserTaskParametersEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateContextHelpButton();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateUserTaskTitleEdit());
			ControlLayout2.InsertItem(1, CreateEntitySchemaEdit());
			ControlLayout2.InsertItem(2, CreateAddOneRowEdit());
			ControlLayout2.InsertItem(3, CreateAddFilterResultEdit());
			TopControlLayout.InsertItem(1, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateFilterEntitySchemaEdit());
			FilterControlLayout.InsertItem(1, CreateFilterLabel());
			FilterControlLayout.InsertItem(2, CreateFilterEdit());
			TopControlLayout.InsertItem(2, CreateControlLayout5());
			ControlLayout5.InsertItem(0, CreateAddButton());
			ControlLayout5.InsertItem(1, CreateEditValueButton());
			ControlLayout5.InsertItem(2, CreateDeleteButton());
			TopControlLayout.InsertItem(3, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateColumnValuesTreeGrid());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, Spacer1);
			BottomControlLayout.MoveItem(1, OkButton);
			BottomControlLayout.MoveItem(2, CancelButton);
			BottomControlLayout.MoveItem(3, ContextHelpButton);
			Controls.AddAt(3, CreateFilterDataSource());
			UpdateFilterDataSource();
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAddDataUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new AddDataUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("55a11eb0-72c2-44fd-af1b-0a2e1057ae58");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEntitySchemaEdit() {
			_entitySchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_entitySchemaEdit.UId = new Guid("fcc4c6e2-d2ff-4122-90f0-1afc04a548a6");
			_entitySchemaEdit.Name = "EntitySchemaEdit";
			_entitySchemaEdit.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_entitySchemaEdit.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_entitySchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entitySchemaEdit.Tag = "";
			_entitySchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entitySchemaEdit.Image = new ControlImage {};
			_entitySchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entitySchemaEdit.Required = true;
			_entitySchemaEdit.LookupSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111");
			_entitySchemaEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _entitySchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAddOneRowEdit() {
			_addOneRowEdit = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_addOneRowEdit.UId = new Guid("45528175-ce8f-41ce-b3f5-5b3d1de23a4f");
			_addOneRowEdit.Name = "AddOneRowEdit";
			_addOneRowEdit.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_addOneRowEdit.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_addOneRowEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addOneRowEdit.Tag = "";
			_addOneRowEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addOneRowEdit.AlignedByCaption = false;
			_addOneRowEdit.Margins = "0 0 0 0";
			_addOneRowEdit.GroupName = "RecordAddMode";
			return _addOneRowEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.RadioButton CreateAddFilterResultEdit() {
			_addFilterResultEdit = new Terrasoft.UI.WebControls.Controls.RadioButton();
			_addFilterResultEdit.UId = new Guid("1e373f08-84e7-42ea-954b-ecbb489e06cd");
			_addFilterResultEdit.Name = "AddFilterResultEdit";
			_addFilterResultEdit.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_addFilterResultEdit.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_addFilterResultEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addFilterResultEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_addFilterResultEdit.Tag = "";
			_addFilterResultEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addFilterResultEdit.AlignedByCaption = false;
			_addFilterResultEdit.Margins = "0 0 0 0";
			_addFilterResultEdit.GroupName = "RecordAddMode";
			return _addFilterResultEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("8a104ff1-4837-4f9a-aba3-658d3269ad27");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_controlLayout2.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_controlLayout2.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout2.FitHeightByContent = true;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateFilterEntitySchemaEdit() {
			_filterEntitySchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_filterEntitySchemaEdit.UId = new Guid("8a709a09-4ab5-4f8c-bc2a-4ba5e5703ddd");
			_filterEntitySchemaEdit.Name = "FilterEntitySchemaEdit";
			_filterEntitySchemaEdit.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterEntitySchemaEdit.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterEntitySchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEntitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_filterEntitySchemaEdit.Tag = "";
			_filterEntitySchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_filterEntitySchemaEdit.Image = new ControlImage {};
			_filterEntitySchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEntitySchemaEdit.LookupSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111");
			_filterEntitySchemaEdit.LookupPageSchemaUId = new Guid("33cc4a3a-babb-464d-82a0-1b904d198d31");
			return _filterEntitySchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Label CreateFilterLabel() {
			_filterLabel = new Terrasoft.UI.WebControls.Controls.Label();
			_filterLabel.UId = new Guid("37119f3a-6cbb-47d0-8783-8f7fb8280c5e");
			_filterLabel.Name = "FilterLabel";
			_filterLabel.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterLabel.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterLabel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterLabel.Tag = "";
			_filterLabel.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_filterLabel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterLabel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("f72b43c2-29b3-477d-a141-a72501936b1c");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterEdit.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "FilterDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateFilterControlLayout() {
			_filterControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_filterControlLayout.UId = new Guid("42eb4ba2-e093-4a32-971e-bb7a0e5bebc7");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_filterControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_filterControlLayout.FitHeightByContent = true;
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.Padding = "0 0 0 20";
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("04cc4ca0-853e-4e3e-b044-4bfeaf77f0f9");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_addButton.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditValueButton() {
			_editValueButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editValueButton.UId = new Guid("9b1548b3-80f7-48eb-9c4e-cd56f8853fd6");
			_editValueButton.Name = "EditValueButton";
			_editValueButton.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_editValueButton.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_editValueButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editValueButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_editValueButton.Tag = "";
			_editValueButton.Image = new ControlImage {};
			return _editValueButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("cf09e8d8-d9ad-4b38-bbff-88160a5c38d0");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_deleteButton.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_deleteButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_deleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("b593c7f5-b60e-46bd-88f4-0a0ac9acb475");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_controlLayout5.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_controlLayout5.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout5.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout5.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout5.FitHeightByContent = true;
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.Padding = "0 0 0 20";
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateColumnValuesTreeGrid() {
			_columnValuesTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_columnValuesTreeGrid.UId = new Guid("156149f4-662b-448c-b0ba-ad42571ac8a8");
			_columnValuesTreeGrid.Name = "ColumnValuesTreeGrid";
			_columnValuesTreeGrid.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_columnValuesTreeGrid.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_columnValuesTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnValuesTreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			_columnValuesTreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
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

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("c9535b2b-2111-466e-9584-567039993da9");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_controlLayout6.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_controlLayout6.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.Padding = "0 0 0 20";
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateFilterDataSource() {
			_filterDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_filterDataSource.UId = new Guid("06857866-6b34-4532-a77c-934bbb115df0");
			_filterDataSource.Name = "FilterDataSource";
			_filterDataSource.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterDataSource.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterDataSource.Tag = "";
			_filterDataSource.EnableServerActiveRow = false;
			_filterDataSource.SchemaUId = Guid.Empty;
			_filterDataSource.HierarchicalDepth = 1;
			_filterDataSource.DefStructure.ID = "c" + _filterDataSource.DefStructure.UId.ToString("N");
			_filterDataSource.DefStructure.UId = new Guid("ecc639d7-bd43-438b-a9c1-3d170d1c7235");
			_filterDataSource.DefStructure.Name = "DefStructure";
			_filterDataSource.DefStructure.CreatedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			_filterDataSource.DefStructure.ModifiedInSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			return _filterDataSource;
		}

		protected virtual void UpdateFilterDataSource() {
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AddDataUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new AddDataUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AddDataUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AddDataUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class AddDataUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.AddDataUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeSchemaEntityQuestion_UserTaskFlowElement

		/// <exclude/>
		public class ChangeSchemaEntityQuestion_UserTaskFlowElement : QuestionUserTask
		{

			public ChangeSchemaEntityQuestion_UserTaskFlowElement(UserConnection userConnection, AddDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeSchemaEntityQuestion_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenColumnValuePage_UserTaskFlowElement

		/// <exclude/>
		public class OpenColumnValuePage_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenColumnValuePage_UserTaskFlowElement(UserConnection userConnection, AddDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenColumnValuePage_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: DeleteColumnQuestion_UserTaskFlowElement

		/// <exclude/>
		public class DeleteColumnQuestion_UserTaskFlowElement : QuestionUserTask
		{

			public DeleteColumnQuestion_UserTaskFlowElement(UserConnection userConnection, AddDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DeleteColumnQuestion_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenEditColumnValuePage_UserTaskFlowElement

		/// <exclude/>
		public class OpenEditColumnValuePage_UserTaskFlowElement : OpenPageUserTask
		{

			public OpenEditColumnValuePage_UserTaskFlowElement(UserConnection userConnection, AddDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditColumnValuePage_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public AddDataUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddDataUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
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

		private string _virtualDataSourceID;
		public virtual string VirtualDataSourceID {
			get {
				return _virtualDataSourceID ?? (_virtualDataSourceID = new LocalizableString(Storage, "d84286d03e644e9f9d717e80c73b191d",
						 "EventsProcessSchema.Parameters.VirtualDataSourceID.Value"));
			}
			set {
				_virtualDataSourceID = value;
			}
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private string _filtersGroupName;
		public virtual string FiltersGroupName {
			get {
				return _filtersGroupName ?? (_filtersGroupName = new LocalizableString(Storage, "d84286d03e644e9f9d717e80c73b191d",
						 "EventsProcessSchema.Parameters.FiltersGroupName.Value"));
			}
			set {
				_filtersGroupName = value;
			}
		}

		public virtual Guid FilterEntitySchemaUId {
			get;
			set;
		}

		public virtual string ColumnValuesContextKey {
			get;
			set;
		}

		private Guid _columnValueEditPageId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
		public Guid ColumnValueEditPageId {
			get {
				return _columnValueEditPageId;
			}
			set {
				_columnValueEditPageId = value;
			}
		}

		public virtual string EntitySchemaCaption {
			get;
			set;
		}

		public virtual bool IsDataValid_NewRow {
			get;
			set;
		}

		public virtual bool IsFilterParamsValuesCorrect {
			get;
			set;
		}

		public virtual string InsertedColumnValueKey {
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
					SchemaElementUId = new Guid("913c00ea-83d2-4e4f-9c46-cdc96e4c1235"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValuesTreeGridSelectionChange_StartMessage;
		public ProcessFlowElement ColumnValuesTreeGridSelectionChange_StartMessage {
			get {
				return _columnValuesTreeGridSelectionChange_StartMessage ?? (_columnValuesTreeGridSelectionChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValuesTreeGridSelectionChange_StartMessage",
					SchemaElementUId = new Guid("7d6b29c6-0165-4be6-9dda-44c6bfb06f42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processSelectedRow_ScriptTask;
		public ProcessScriptTask ProcessSelectedRow_ScriptTask {
			get {
				return _processSelectedRow_ScriptTask ?? (_processSelectedRow_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessSelectedRow_ScriptTask",
					SchemaElementUId = new Guid("53fce431-a33a-45f9-9796-8229de4e60c3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessSelectedRow_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySchemaEditChange_StartMessage;
		public ProcessFlowElement EntitySchemaEditChange_StartMessage {
			get {
				return _entitySchemaEditChange_StartMessage ?? (_entitySchemaEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySchemaEditChange_StartMessage",
					SchemaElementUId = new Guid("da783a9a-38f2-431d-a1cc-66f7be2d1080"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("1c7eb845-6666-4ff3-8fce-aae84e60bcda"),
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

		private ProcessScriptTask _prepareChangeSchemaEntityQuestion_ScriptTask;
		public ProcessScriptTask PrepareChangeSchemaEntityQuestion_ScriptTask {
			get {
				return _prepareChangeSchemaEntityQuestion_ScriptTask ?? (_prepareChangeSchemaEntityQuestion_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareChangeSchemaEntityQuestion_ScriptTask",
					SchemaElementUId = new Guid("1cb9b047-da0a-4d66-8e09-c355af6ae411"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareChangeSchemaEntityQuestion_ScriptTaskExecute,
				});
			}
		}

		private ChangeSchemaEntityQuestion_UserTaskFlowElement _changeSchemaEntityQuestion_UserTask;
		public ChangeSchemaEntityQuestion_UserTaskFlowElement ChangeSchemaEntityQuestion_UserTask {
			get {
				return _changeSchemaEntityQuestion_UserTask ?? (_changeSchemaEntityQuestion_UserTask = new ChangeSchemaEntityQuestion_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessThrowMessageEvent _entitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent {
			get {
				return _entitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent ?? (_entitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("027da987-b17d-49e7-aab4-d8bea5ae93af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
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
					SchemaElementUId = new Guid("56814492-0936-4a57-8d06-99613a7552df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityYesMessage_StartMessage;
		public ProcessFlowElement ChangeSchemaEntityYesMessage_StartMessage {
			get {
				return _changeSchemaEntityYesMessage_StartMessage ?? (_changeSchemaEntityYesMessage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityYesMessage_StartMessage",
					SchemaElementUId = new Guid("602509d8-0306-479b-8b54-1c5dc77a8739"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _doChangeSelectedEntitySchema_ScriptTask;
		public ProcessScriptTask DoChangeSelectedEntitySchema_ScriptTask {
			get {
				return _doChangeSelectedEntitySchema_ScriptTask ?? (_doChangeSelectedEntitySchema_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DoChangeSelectedEntitySchema_ScriptTask",
					SchemaElementUId = new Guid("8e7b2508-ce48-4030-914c-84b53e213b6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DoChangeSelectedEntitySchema_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("3d3f4104-853c-477a-be51-6fec932725db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityNoMessage_StartMessage;
		public ProcessFlowElement ChangeSchemaEntityNoMessage_StartMessage {
			get {
				return _changeSchemaEntityNoMessage_StartMessage ?? (_changeSchemaEntityNoMessage_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityNoMessage_StartMessage",
					SchemaElementUId = new Guid("b6e30d1f-8663-467a-af31-7ee327b5b361"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _doNotChangeSelectedEntitySchema_ScriptTask;
		public ProcessScriptTask DoNotChangeSelectedEntitySchema_ScriptTask {
			get {
				return _doNotChangeSelectedEntitySchema_ScriptTask ?? (_doNotChangeSelectedEntitySchema_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DoNotChangeSelectedEntitySchema_ScriptTask",
					SchemaElementUId = new Guid("c4917ad8-5d2e-43b4-9e7e-0e0977ee4ed6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DoNotChangeSelectedEntitySchema_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("f46940bc-d34a-4b4b-bdba-07c1baeabac5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addFilterResultEditCheck_StartMessage;
		public ProcessFlowElement AddFilterResultEditCheck_StartMessage {
			get {
				return _addFilterResultEditCheck_StartMessage ?? (_addFilterResultEditCheck_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddFilterResultEditCheck_StartMessage",
					SchemaElementUId = new Guid("147951e0-5582-4dba-b9bb-5513b229b261"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addManyRowsRBEditCheckChanged_ScriptTask;
		public ProcessScriptTask AddManyRowsRBEditCheckChanged_ScriptTask {
			get {
				return _addManyRowsRBEditCheckChanged_ScriptTask ?? (_addManyRowsRBEditCheckChanged_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddManyRowsRBEditCheckChanged_ScriptTask",
					SchemaElementUId = new Guid("77f34950-42f6-4ef3-9290-2a1aee89b48a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddManyRowsRBEditCheckChanged_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("1ab1857b-5043-4164-95ef-ab13e650a310"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _filterEntitySchemaEditChange_StartMessage;
		public ProcessFlowElement FilterEntitySchemaEditChange_StartMessage {
			get {
				return _filterEntitySchemaEditChange_StartMessage ?? (_filterEntitySchemaEditChange_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FilterEntitySchemaEditChange_StartMessage",
					SchemaElementUId = new Guid("7c5d9304-98d7-4051-a379-4a1e1564a019"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processFilterEdit_ScriptTask;
		public ProcessScriptTask ProcessFilterEdit_ScriptTask {
			get {
				return _processFilterEdit_ScriptTask ?? (_processFilterEdit_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessFilterEdit_ScriptTask",
					SchemaElementUId = new Guid("70ce59de-2c24-4f06-b45e-6edfc90f442a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessFilterEdit_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("00441ee9-e8fb-46b4-abc5-67901fd82604"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClick_StartMessage;
		public ProcessFlowElement AddButtonClick_StartMessage {
			get {
				return _addButtonClick_StartMessage ?? (_addButtonClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClick_StartMessage",
					SchemaElementUId = new Guid("709502c2-eeb2-4297-bcf1-1e1ae8bb0c0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processAddButtonClick_PrepareOpenColumnValuePage_ScriptTask;
		public ProcessScriptTask ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask {
			get {
				return _processAddButtonClick_PrepareOpenColumnValuePage_ScriptTask ?? (_processAddButtonClick_PrepareOpenColumnValuePage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask",
					SchemaElementUId = new Guid("5fe449be-135e-40af-a548-7dde521fa3b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTaskExecute,
				});
			}
		}

		private OpenColumnValuePage_UserTaskFlowElement _openColumnValuePage_UserTask;
		public OpenColumnValuePage_UserTaskFlowElement OpenColumnValuePage_UserTask {
			get {
				return _openColumnValuePage_UserTask ?? (_openColumnValuePage_UserTask = new OpenColumnValuePage_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClick_StartMessage;
		public ProcessFlowElement DeleteButtonClick_StartMessage {
			get {
				return _deleteButtonClick_StartMessage ?? (_deleteButtonClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClick_StartMessage",
					SchemaElementUId = new Guid("49c15664-1e76-4774-811e-3ae5ef01e7b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareDeleteColumnQuestion_ScriptTask;
		public ProcessScriptTask PrepareDeleteColumnQuestion_ScriptTask {
			get {
				return _prepareDeleteColumnQuestion_ScriptTask ?? (_prepareDeleteColumnQuestion_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareDeleteColumnQuestion_ScriptTask",
					SchemaElementUId = new Guid("a3d5a3c3-e8a4-4b3e-add7-fabb991ad1fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareDeleteColumnQuestion_ScriptTaskExecute,
				});
			}
		}

		private DeleteColumnQuestion_UserTaskFlowElement _deleteColumnQuestion_UserTask;
		public DeleteColumnQuestion_UserTaskFlowElement DeleteColumnQuestion_UserTask {
			get {
				return _deleteColumnQuestion_UserTask ?? (_deleteColumnQuestion_UserTask = new DeleteColumnQuestion_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("4e466bc2-e302-4c6c-abe5-abadb9714416"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BreakDelete_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("03d557e7-0950-46fa-8440-643c2ceff653"),
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

		private ProcessFlowElement _eventSubProcess13;
		public ProcessFlowElement EventSubProcess13 {
			get {
				return _eventSubProcess13 ?? (_eventSubProcess13 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess13",
					SchemaElementUId = new Guid("32917b1a-a752-4d11-a207-687c7faaa188"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editValueButtonClick_StartMessage;
		public ProcessFlowElement EditValueButtonClick_StartMessage {
			get {
				return _editValueButtonClick_StartMessage ?? (_editValueButtonClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditValueButtonClick_StartMessage",
					SchemaElementUId = new Guid("3761e734-99ce-4506-9956-262ffdeaf750"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processEditButtonClick_ScriptTask;
		public ProcessScriptTask ProcessEditButtonClick_ScriptTask {
			get {
				return _processEditButtonClick_ScriptTask ?? (_processEditButtonClick_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessEditButtonClick_ScriptTask",
					SchemaElementUId = new Guid("458a101b-3e49-47a0-987f-c76e7ae9939e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ProcessEditButtonClick_ScriptTaskExecute,
				});
			}
		}

		private OpenEditColumnValuePage_UserTaskFlowElement _openEditColumnValuePage_UserTask;
		public OpenEditColumnValuePage_UserTaskFlowElement OpenEditColumnValuePage_UserTask {
			get {
				return _openEditColumnValuePage_UserTask ?? (_openEditColumnValuePage_UserTask = new OpenEditColumnValuePage_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess14;
		public ProcessFlowElement EventSubProcess14 {
			get {
				return _eventSubProcess14 ?? (_eventSubProcess14 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess14",
					SchemaElementUId = new Guid("d6d4be0e-1d29-44cd-83cc-feb27ca277e8"),
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
					SchemaElementUId = new Guid("2189b114-663b-4279-b781-90461ebc6b17"),
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
					SchemaElementUId = new Guid("3afc4a9c-a6e9-4bcc-8191-12ec0c58c218"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteColumn_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess15;
		public ProcessFlowElement EventSubProcess15 {
			get {
				return _eventSubProcess15 ?? (_eventSubProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess15",
					SchemaElementUId = new Guid("3e2fab41-cb18-4b89-8427-1482dc6c57eb"),
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
					SchemaElementUId = new Guid("844450b7-a2bf-4f8f-90fc-7eb15b6130af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _columnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent {
			get {
				return _columnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent ?? (_columnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("ba187f53-116d-4347-898c-1e8a5347a8f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditValueButtonClick",
				});
			}
		}

		private ProcessFlowElement _columnValueEditPageClosedEventSubProcess;
		public ProcessFlowElement ColumnValueEditPageClosedEventSubProcess {
			get {
				return _columnValueEditPageClosedEventSubProcess ?? (_columnValueEditPageClosedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ColumnValueEditPageClosedEventSubProcess",
					SchemaElementUId = new Guid("58a7c3b1-eb58-464f-b00d-e6801d41cf54"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValueEditPageClosedStartMessage;
		public ProcessFlowElement ColumnValueEditPageClosedStartMessage {
			get {
				return _columnValueEditPageClosedStartMessage ?? (_columnValueEditPageClosedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValueEditPageClosedStartMessage",
					SchemaElementUId = new Guid("2edc2e5c-791f-4d6b-8a1a-49e3d3d15345"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _columnValueEditPageClosedScriptTask;
		public ProcessScriptTask ColumnValueEditPageClosedScriptTask {
			get {
				return _columnValueEditPageClosedScriptTask ?? (_columnValueEditPageClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ColumnValueEditPageClosedScriptTask",
					SchemaElementUId = new Guid("4d571fc2-ce5c-414b-b1b8-bb3d9f22885d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnValueEditPageClosedScriptTaskExecute,
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
					SchemaElementUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClick_StartMessage;
		public ProcessFlowElement OkButtonClick_StartMessage {
			get {
				return _okButtonClick_StartMessage ?? (_okButtonClick_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClick_StartMessage",
					SchemaElementUId = new Guid("30acb4e5-62ab-456b-9b1f-e5b1e02fddbb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setProcessParams_ScriptTask;
		public ProcessScriptTask SetProcessParams_ScriptTask {
			get {
				return _setProcessParams_ScriptTask ?? (_setProcessParams_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetProcessParams_ScriptTask",
					SchemaElementUId = new Guid("d70308a4-86b8-4788-b305-4350528e7570"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetProcessParams_ScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _okButtonClick_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent OkButtonClick_IntermediateThrowMessageEvent {
			get {
				return _okButtonClick_IntermediateThrowMessageEvent ?? (_okButtonClick_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "OkButtonClick_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("a6c43bc3-9760-497a-8a63-55bf034caf3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("80b61b45-b018-470d-b296-fc1c4ab474e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckData_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("ec0375d0-6f55-4812-8405-3c14f1d97cce"),
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

		private ProcessScriptTask _errorMessage_ScriptTask;
		public ProcessScriptTask ErrorMessage_ScriptTask {
			get {
				return _errorMessage_ScriptTask ?? (_errorMessage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ErrorMessage_ScriptTask",
					SchemaElementUId = new Guid("450b9fa1-be74-480d-90c9-97129333203f"),
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
					SchemaElementUId = new Guid("9299ca48-de54-4a9d-90bb-85cd2ef8b375"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _init_StartMessage;
		public ProcessFlowElement Init_StartMessage {
			get {
				return _init_StartMessage ?? (_init_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "Init_StartMessage",
					SchemaElementUId = new Guid("a9ca98f7-e04e-45d0-94ce-f641c449ddf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _init_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent Init_IntermediateThrowMessageEvent {
			get {
				return _init_IntermediateThrowMessageEvent ?? (_init_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "Init_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("1c6374ef-003c-46da-a052-d8622b16b90b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _init_ScriptTask;
		public ProcessScriptTask Init_ScriptTask {
			get {
				return _init_ScriptTask ?? (_init_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Init_ScriptTask",
					SchemaElementUId = new Guid("cec8505a-1aef-4bbd-9e46-48ac55b90354"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Init_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("2b0677f3-b22c-4ce4-9e26-4627378027a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete_StartMessage;
		public ProcessFlowElement PageLoadComplete_StartMessage {
			get {
				return _pageLoadComplete_StartMessage ?? (_pageLoadComplete_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadComplete_StartMessage",
					SchemaElementUId = new Guid("2834a381-a6ec-49d5-ae19-5099a0a0c768"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadComplete_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent PageLoadComplete_IntermediateThrowMessageEvent {
			get {
				return _pageLoadComplete_IntermediateThrowMessageEvent ?? (_pageLoadComplete_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadComplete_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("cb0efeb1-52ee-478e-9621-8d1b5fcdd327"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _setDefValues_ScriptTask;
		public ProcessScriptTask SetDefValues_ScriptTask {
			get {
				return _setDefValues_ScriptTask ?? (_setDefValues_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetDefValues_ScriptTask",
					SchemaElementUId = new Guid("0625fbfa-cd59-4b71-9347-77d1dfed062e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetDefValues_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("2e6e7a88-bf5e-404e-ac5c-e85a1a56fbb0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddNotNullColumns_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("152269e0-8c27-4f63-9b3e-440ae9657f57"),
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
					SchemaElementUId = new Guid("322322c1-da83-4fef-84a8-40eb2027cbcb"),
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
					SchemaElementUId = new Guid("7915a519-5730-4012-b82c-ca3c120dbc34"),
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[ColumnValuesTreeGridSelectionChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridSelectionChange_StartMessage };
			FlowElements[ProcessSelectedRow_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessSelectedRow_ScriptTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[EntitySchemaEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChange_StartMessage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[PrepareChangeSchemaEntityQuestion_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareChangeSchemaEntityQuestion_ScriptTask };
			FlowElements[ChangeSchemaEntityQuestion_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityQuestion_UserTask };
			FlowElements[EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[ChangeSchemaEntityYesMessage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessage_StartMessage };
			FlowElements[DoChangeSelectedEntitySchema_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DoChangeSelectedEntitySchema_ScriptTask };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[ChangeSchemaEntityNoMessage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessage_StartMessage };
			FlowElements[DoNotChangeSelectedEntitySchema_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DoNotChangeSelectedEntitySchema_ScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[AddFilterResultEditCheck_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddFilterResultEditCheck_StartMessage };
			FlowElements[AddManyRowsRBEditCheckChanged_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddManyRowsRBEditCheckChanged_ScriptTask };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[FilterEntitySchemaEditChange_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterEntitySchemaEditChange_StartMessage };
			FlowElements[ProcessFilterEdit_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessFilterEdit_ScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[AddButtonClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClick_StartMessage };
			FlowElements[ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask };
			FlowElements[OpenColumnValuePage_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnValuePage_UserTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[DeleteButtonClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClick_StartMessage };
			FlowElements[PrepareDeleteColumnQuestion_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareDeleteColumnQuestion_ScriptTask };
			FlowElements[DeleteColumnQuestion_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteColumnQuestion_UserTask };
			FlowElements[BreakDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BreakDelete_ScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[EditValueButtonClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EditValueButtonClick_StartMessage };
			FlowElements[ProcessEditButtonClick_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessEditButtonClick_ScriptTask };
			FlowElements[OpenEditColumnValuePage_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditColumnValuePage_UserTask };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[DeleteColumnYesMessage_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteColumnYesMessage_StartMessage };
			FlowElements[DeleteColumn_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteColumn_ScriptTask };
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[ColumnValuesTreeGridDblClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClick_StartMessage };
			FlowElements[ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent };
			FlowElements[ColumnValueEditPageClosedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedEventSubProcess };
			FlowElements[ColumnValueEditPageClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedStartMessage };
			FlowElements[ColumnValueEditPageClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedScriptTask };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[OkButtonClick_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClick_StartMessage };
			FlowElements[SetProcessParams_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetProcessParams_ScriptTask };
			FlowElements[OkButtonClick_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClick_IntermediateThrowMessageEvent };
			FlowElements[CheckData_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckData_ScriptTask };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ErrorMessage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorMessage_ScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[Init_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { Init_StartMessage };
			FlowElements[Init_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { Init_IntermediateThrowMessageEvent };
			FlowElements[Init_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Init_ScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[PageLoadComplete_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete_StartMessage };
			FlowElements[PageLoadComplete_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete_IntermediateThrowMessageEvent };
			FlowElements[SetDefValues_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetDefValues_ScriptTask };
			FlowElements[AddNotNullColumns_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddNotNullColumns_ScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess7":
						break;
					case "ColumnValuesTreeGridSelectionChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessSelectedRow_ScriptTask");
						break;
					case "ProcessSelectedRow_ScriptTask":
						break;
					case "EventSubProcess8":
						break;
					case "EntitySchemaEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareChangeSchemaEntityQuestion_ScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent");
						break;
					case "PrepareChangeSchemaEntityQuestion_ScriptTask":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityQuestion_UserTask");
						break;
					case "ChangeSchemaEntityQuestion_UserTask":
						break;
					case "EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent":
						break;
					case "EventSubProcess9":
						break;
					case "ChangeSchemaEntityYesMessage_StartMessage":
						e.Context.QueueTasks.Enqueue("DoChangeSelectedEntitySchema_ScriptTask");
						break;
					case "DoChangeSelectedEntitySchema_ScriptTask":
						break;
					case "EventSubProcess10":
						break;
					case "ChangeSchemaEntityNoMessage_StartMessage":
						e.Context.QueueTasks.Enqueue("DoNotChangeSelectedEntitySchema_ScriptTask");
						break;
					case "DoNotChangeSelectedEntitySchema_ScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "AddFilterResultEditCheck_StartMessage":
						e.Context.QueueTasks.Enqueue("AddManyRowsRBEditCheckChanged_ScriptTask");
						break;
					case "AddManyRowsRBEditCheckChanged_ScriptTask":
						break;
					case "EventSubProcess11":
						break;
					case "FilterEntitySchemaEditChange_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessFilterEdit_ScriptTask");
						break;
					case "ProcessFilterEdit_ScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "AddButtonClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask");
						break;
					case "ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask":
						e.Context.QueueTasks.Enqueue("OpenColumnValuePage_UserTask");
						break;
					case "OpenColumnValuePage_UserTask":
						break;
					case "EventSubProcess5":
						break;
					case "DeleteButtonClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "PrepareDeleteColumnQuestion_ScriptTask":
						e.Context.QueueTasks.Enqueue("DeleteColumnQuestion_UserTask");
						break;
					case "DeleteColumnQuestion_UserTask":
						break;
					case "BreakDelete_ScriptTask":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrepareDeleteColumnQuestion_ScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("BreakDelete_ScriptTask");
						break;
					case "EventSubProcess13":
						break;
					case "EditValueButtonClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ProcessEditButtonClick_ScriptTask");
						break;
					case "ProcessEditButtonClick_ScriptTask":
						e.Context.QueueTasks.Enqueue("OpenEditColumnValuePage_UserTask");
						break;
					case "OpenEditColumnValuePage_UserTask":
						break;
					case "EventSubProcess14":
						break;
					case "DeleteColumnYesMessage_StartMessage":
						e.Context.QueueTasks.Enqueue("DeleteColumn_ScriptTask");
						break;
					case "DeleteColumn_ScriptTask":
						break;
					case "EventSubProcess15":
						break;
					case "ColumnValuesTreeGridDblClick_StartMessage":
						e.Context.QueueTasks.Enqueue("ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent");
						break;
					case "ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent":
						break;
					case "ColumnValueEditPageClosedEventSubProcess":
						break;
					case "ColumnValueEditPageClosedStartMessage":
						e.Context.QueueTasks.Enqueue("ColumnValueEditPageClosedScriptTask");
						break;
					case "ColumnValueEditPageClosedScriptTask":
						break;
					case "EventSubProcess12":
						break;
					case "OkButtonClick_StartMessage":
						e.Context.QueueTasks.Enqueue("CheckData_ScriptTask");
						break;
					case "SetProcessParams_ScriptTask":
						e.Context.QueueTasks.Enqueue("OkButtonClick_IntermediateThrowMessageEvent");
						break;
					case "OkButtonClick_IntermediateThrowMessageEvent":
						break;
					case "CheckData_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3");
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("SetProcessParams_ScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ErrorMessage_ScriptTask");
						break;
					case "ErrorMessage_ScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "Init_StartMessage":
						e.Context.QueueTasks.Enqueue("Init_IntermediateThrowMessageEvent");
						break;
					case "Init_IntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("Init_ScriptTask");
						break;
					case "Init_ScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "PageLoadComplete_StartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadComplete_IntermediateThrowMessageEvent");
						break;
					case "PageLoadComplete_IntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("SetDefValues_ScriptTask");
						break;
					case "SetDefValues_ScriptTask":
						e.Context.QueueTasks.Enqueue("AddNotNullColumns_ScriptTask");
						break;
					case "AddNotNullColumns_ScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsEntitySchemaChanged());
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(Page.ColumnValuesTreeGrid.SelectedNodes.Count > 0);
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(IsDataValid_NewRow && IsFilterParamsValuesCorrect);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ColumnValuesTreeGridSelectionChange_StartMessage");
			ActivatedEventElements.Add("EntitySchemaEditChange_StartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityYesMessage_StartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityNoMessage_StartMessage");
			ActivatedEventElements.Add("AddFilterResultEditCheck_StartMessage");
			ActivatedEventElements.Add("FilterEntitySchemaEditChange_StartMessage");
			ActivatedEventElements.Add("AddButtonClick_StartMessage");
			ActivatedEventElements.Add("DeleteButtonClick_StartMessage");
			ActivatedEventElements.Add("EditValueButtonClick_StartMessage");
			ActivatedEventElements.Add("DeleteColumnYesMessage_StartMessage");
			ActivatedEventElements.Add("ColumnValuesTreeGridDblClick_StartMessage");
			ActivatedEventElements.Add("ColumnValueEditPageClosedStartMessage");
			ActivatedEventElements.Add("OkButtonClick_StartMessage");
			ActivatedEventElements.Add("Init_StartMessage");
			ActivatedEventElements.Add("PageLoadComplete_StartMessage");
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
				case "ColumnValuesTreeGridSelectionChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValuesTreeGridSelectionChange_StartMessage";
					result = ColumnValuesTreeGridSelectionChange_StartMessage.Execute(context);
					break;
				case "ProcessSelectedRow_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessSelectedRow_ScriptTask";
					result = ProcessSelectedRow_ScriptTask.Execute(context, ProcessSelectedRow_ScriptTaskExecute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "EntitySchemaEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaEditChange_StartMessage";
					result = EntitySchemaEditChange_StartMessage.Execute(context);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "PrepareChangeSchemaEntityQuestion_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareChangeSchemaEntityQuestion_ScriptTask";
					result = PrepareChangeSchemaEntityQuestion_ScriptTask.Execute(context, PrepareChangeSchemaEntityQuestion_ScriptTaskExecute);
					break;
				case "ChangeSchemaEntityQuestion_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityQuestion_UserTask";
					result = ChangeSchemaEntityQuestion_UserTask.Execute(context);
					break;
				case "EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityYesMessage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessage_StartMessage";
					result = ChangeSchemaEntityYesMessage_StartMessage.Execute(context);
					break;
				case "DoChangeSelectedEntitySchema_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DoChangeSelectedEntitySchema_ScriptTask";
					result = DoChangeSelectedEntitySchema_ScriptTask.Execute(context, DoChangeSelectedEntitySchema_ScriptTaskExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityNoMessage_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessage_StartMessage";
					result = ChangeSchemaEntityNoMessage_StartMessage.Execute(context);
					break;
				case "DoNotChangeSelectedEntitySchema_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DoNotChangeSelectedEntitySchema_ScriptTask";
					result = DoNotChangeSelectedEntitySchema_ScriptTask.Execute(context, DoNotChangeSelectedEntitySchema_ScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "AddFilterResultEditCheck_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddFilterResultEditCheck_StartMessage";
					result = AddFilterResultEditCheck_StartMessage.Execute(context);
					break;
				case "AddManyRowsRBEditCheckChanged_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddManyRowsRBEditCheckChanged_ScriptTask";
					result = AddManyRowsRBEditCheckChanged_ScriptTask.Execute(context, AddManyRowsRBEditCheckChanged_ScriptTaskExecute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "FilterEntitySchemaEditChange_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterEntitySchemaEditChange_StartMessage";
					result = FilterEntitySchemaEditChange_StartMessage.Execute(context);
					break;
				case "ProcessFilterEdit_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessFilterEdit_ScriptTask";
					result = ProcessFilterEdit_ScriptTask.Execute(context, ProcessFilterEdit_ScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClick_StartMessage";
					result = AddButtonClick_StartMessage.Execute(context);
					break;
				case "ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask";
					result = ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask.Execute(context, ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTaskExecute);
					break;
				case "OpenColumnValuePage_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnValuePage_UserTask";
					result = OpenColumnValuePage_UserTask.Execute(context);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClick_StartMessage";
					result = DeleteButtonClick_StartMessage.Execute(context);
					break;
				case "PrepareDeleteColumnQuestion_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareDeleteColumnQuestion_ScriptTask";
					result = PrepareDeleteColumnQuestion_ScriptTask.Execute(context, PrepareDeleteColumnQuestion_ScriptTaskExecute);
					break;
				case "DeleteColumnQuestion_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteColumnQuestion_UserTask";
					result = DeleteColumnQuestion_UserTask.Execute(context);
					break;
				case "BreakDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BreakDelete_ScriptTask";
					result = BreakDelete_ScriptTask.Execute(context, BreakDelete_ScriptTaskExecute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "EditValueButtonClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditValueButtonClick_StartMessage";
					result = EditValueButtonClick_StartMessage.Execute(context);
					break;
				case "ProcessEditButtonClick_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProcessEditButtonClick_ScriptTask";
					result = ProcessEditButtonClick_ScriptTask.Execute(context, ProcessEditButtonClick_ScriptTaskExecute);
					break;
				case "OpenEditColumnValuePage_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenEditColumnValuePage_UserTask";
					result = OpenEditColumnValuePage_UserTask.Execute(context);
					break;
				case "EventSubProcess14":
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
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValuesTreeGridDblClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValuesTreeGridDblClick_StartMessage";
					result = ColumnValuesTreeGridDblClick_StartMessage.Execute(context);
					break;
				case "ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "ColumnValueEditPageClosedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValueEditPageClosedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditPageClosedStartMessage";
					result = ColumnValueEditPageClosedStartMessage.Execute(context);
					break;
				case "ColumnValueEditPageClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditPageClosedScriptTask";
					result = ColumnValueEditPageClosedScriptTask.Execute(context, ColumnValueEditPageClosedScriptTaskExecute);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClick_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClick_StartMessage";
					result = OkButtonClick_StartMessage.Execute(context);
					break;
				case "SetProcessParams_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetProcessParams_ScriptTask";
					result = SetProcessParams_ScriptTask.Execute(context, SetProcessParams_ScriptTaskExecute);
					break;
				case "OkButtonClick_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = OkButtonClick_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "CheckData_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckData_ScriptTask";
					result = CheckData_ScriptTask.Execute(context, CheckData_ScriptTaskExecute);
					break;
				case "ExclusiveGateway3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3";
					result = ExclusiveGateway3.Execute(context);
					break;
				case "ErrorMessage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ErrorMessage_ScriptTask";
					result = ErrorMessage_ScriptTask.Execute(context, ErrorMessage_ScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "Init_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init_StartMessage";
					result = Init_StartMessage.Execute(context);
					break;
				case "Init_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = Init_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "Init_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Init_ScriptTask";
					result = Init_ScriptTask.Execute(context, Init_ScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete_StartMessage";
					result = PageLoadComplete_StartMessage.Execute(context);
					break;
				case "PageLoadComplete_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadComplete_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "SetDefValues_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetDefValues_ScriptTask";
					result = SetDefValues_ScriptTask.Execute(context, SetDefValues_ScriptTaskExecute);
					break;
				case "AddNotNullColumns_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddNotNullColumns_ScriptTask";
					result = AddNotNullColumns_ScriptTask.Execute(context, AddNotNullColumns_ScriptTaskExecute);
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
				case "InsertedColumnValueKey":
					InsertedColumnValueKey = reader.GetValue<System.String>();
				break;
				case "IsFilterParamsValuesCorrect":
					IsFilterParamsValuesCorrect = reader.GetValue<System.Boolean>();
				break;
				case "IsDataValid_NewRow":
					IsDataValid_NewRow = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaCaption":
					EntitySchemaCaption = reader.GetValue<System.String>();
				break;
				case "ColumnValueEditPageId":
					ColumnValueEditPageId = reader.GetValue<System.Guid>();
				break;
				case "ColumnValuesContextKey":
					ColumnValuesContextKey = reader.GetValue<System.String>();
				break;
				case "FilterEntitySchemaUId":
					FilterEntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "FiltersGroupName":
					FiltersGroupName = reader.GetValue<System.String>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "VirtualDataSourceID":
					VirtualDataSourceID = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ProcessSelectedRow_ScriptTaskExecute(ProcessExecutingContext context) {
			Page.DeleteButton.Enabled = true;
			foreach (var node in Page.ColumnValuesTreeGrid.SelectedNodes) {
				var metaPath = node.Values["MetaPath"].ToString();
				var idList = GetNotNullColumnIdList();
				var i = 0;
				while(i < idList.Count) {
					if(String.Compare(metaPath, idList[i].ToString(), true) == 0) {
						Page.DeleteButton.Enabled = false;
						return true;
					}
					i++;
				}	
			}
			
			return true;
		}

		public virtual bool PrepareChangeSchemaEntityQuestion_ScriptTaskExecute(ProcessExecutingContext context) {
			ChangeSchemaEntityQuestion_UserTask.Page = Page;
			ChangeSchemaEntityQuestion_UserTask.MessageText = ChangeSchemaEntityMessage;
			ChangeSchemaEntityQuestion_UserTask.Icon = "QUESTION";
			ChangeSchemaEntityQuestion_UserTask.Buttons = "YESNO";
			ChangeSchemaEntityQuestion_UserTask.ResponseMessages = new Dictionary<string, string> {
				{"yes", "ChangeSchemaEntityYesMessage"},
				{"no", "ChangeSchemaEntityNoMessage"},
			};
			
			return true;
		}

		public virtual bool DoChangeSelectedEntitySchema_ScriptTaskExecute(ProcessExecutingContext context) {
			ClearControlValues();
			// TODO ##170733 Конфигурация: Проверить функционал, который использует вид VwSysEntitySchemaInWorkspace, в странице AddDataUserTaskParametersEditPage
			EntitySchemaUId = (new Select(UserConnection)
				.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter((Guid)Page.EntitySchemaEdit.Value)) as Select)
				.ExecuteScalar<Guid>();
			EntitySchemaCaption = Page.EntitySchemaEdit.Text;
			InitGridWithNotNullColumns();
			return true;
		}

		public virtual bool DoNotChangeSelectedEntitySchema_ScriptTaskExecute(ProcessExecutingContext context) {
			if (!EntitySchemaUId.Equals(Guid.Empty) && string.IsNullOrEmpty(EntitySchemaCaption)) {
				return true;
			}
			
			Page.EntitySchemaEdit.SuspendAjaxEvents();
			Page.EntitySchemaEdit.SetValueAndText(EntitySchemaUId, EntitySchemaCaption);
			Page.EntitySchemaEdit.ResumeAjaxEvents();
			return true;
		}

		public virtual bool AddManyRowsRBEditCheckChanged_ScriptTaskExecute(ProcessExecutingContext context) {
			RecordAddModeChanged();
			return true;
		}

		public virtual bool ProcessFilterEdit_ScriptTaskExecute(ProcessExecutingContext context) {
			ClearControlFilterValues();
			
			FilterEntitySchemaUId = (new Select(UserConnection)
				.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter((Guid)Page.FilterEntitySchemaEdit.Value)) as Select)
				.ExecuteScalar<Guid>();
			
			if (FilterEntitySchemaUId.Equals(Guid.Empty)) {
				return true;
			}
			Page.FilterEdit.Enabled = true;
			Page.FilterDataSource.SchemaUId = FilterEntitySchemaUId;
			Page.FilterEdit.SetDataSource(Page.FilterDataSource);
			Page.FilterDataSource.LoadStructure();
			return true;
		}

		public virtual bool ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTaskExecute(ProcessExecutingContext context) {
			OpenColumnValuePage_UserTask.OpenerInstanceId = InstanceUId;
			OpenColumnValuePage_UserTask.UseCurrentActivePage = true;
			OpenColumnValuePage_UserTask.PageUId = ColumnValueEditPageId;
			OpenColumnValuePage_UserTask.CloseMessage = "ColumnValueEditPageClosed";
			OpenColumnValuePage_UserTask.PageParameters = GetPageParams(null);
			return true;
		}

		public virtual bool PrepareDeleteColumnQuestion_ScriptTaskExecute(ProcessExecutingContext context) {
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

		public virtual bool ProcessEditButtonClick_ScriptTaskExecute(ProcessExecutingContext context) {
			TreeGridNode node = null;
			if (Page.ColumnValuesTreeGrid.SelectedNodes.Count > 0) {
				node = Page.ColumnValuesTreeGrid.SelectedNodes[0];
			} 
			else {
				return false;
			}
			OpenEditColumnValuePage_UserTask.OpenerInstanceId = InstanceUId;
			OpenEditColumnValuePage_UserTask.UseCurrentActivePage = true;
			OpenEditColumnValuePage_UserTask.PageUId = ColumnValueEditPageId;
			OpenEditColumnValuePage_UserTask.CloseMessage = "ColumnValueEditPageClosed";
			OpenEditColumnValuePage_UserTask.PageParameters = GetPageParams(node);
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

		public virtual bool ColumnValueEditPageClosedScriptTaskExecute(ProcessExecutingContext context) {
			var insertRowColumnValue = (string)UserConnection.SessionData[InsertedColumnValueKey];
			UserConnection.SessionData.Remove(InsertedColumnValueKey);
			Page.AddScript(insertRowColumnValue);
			return true;
		}

		public virtual bool SetProcessParams_ScriptTaskExecute(ProcessExecutingContext context) {
			ElementNewCaption = Page.UserTaskTitleEdit.Text;
			
			var noneVS = ProcessSchemaParameterValueSource.None;
			var constVS = ProcessSchemaParameterValueSource.ConstValue;
			
			var parametersValue = ParametersValue as Dictionary<string, ProcessSchemaParameterValue>;
			if (parametersValue == null) {
				ParametersValue = (parametersValue = new Dictionary<string, ProcessSchemaParameterValue>());
			}
			
			string entitySchemaId = EntitySchemaUId.Equals(Guid.Empty) ? String.Empty : EntitySchemaUId.ToString();
			parametersValue["EntitySchemaId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = String.IsNullOrEmpty(entitySchemaId) ? noneVS : constVS,
				Value = entitySchemaId
			};
			
			string filterEntitySchemaUId = FilterEntitySchemaUId.Equals(Guid.Empty) ? String.Empty : FilterEntitySchemaUId.ToString();
			parametersValue["FilterEntitySchemaId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = String.IsNullOrEmpty(filterEntitySchemaUId) ? noneVS : constVS,
				Value = filterEntitySchemaUId
			};
			
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName(FiltersGroupName);
			var jsonConverter = new DataSourceFiltersJsonConverter(
				UserConnection, Page.FilterEdit.DataSource);
			
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = !FilterEntitySchemaUId.Equals(Guid.Empty) ? constVS : noneVS,
				Value = !FilterEntitySchemaUId.Equals(Guid.Empty) ? 
					Json.Serialize(filterCollection, jsonConverter) : String.Empty
			};
			
			// Set column values
			EntityColumnMappingCollection mappingCollection = null;
			Dictionary<string, ProcessSchemaParameterValue> specifiedColumnValues = GetColumnValues();
			if (specifiedColumnValues != null) {
				mappingCollection = new EntityColumnMappingCollection(specifiedColumnValues, EntitySchemaUId);
			}
			LocalizableParameterValuesList mappingLocalizableList = mappingCollection == null 
				? new LocalizableParameterValuesList()
				: mappingCollection.ToLocalizableList(UserConnection.DataValueTypeManager);
			parametersValue["RecordDefValues"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = mappingCollection.Count == 0 ? noneVS : constVS,
				LocalizableCollectionValue = mappingLocalizableList
			};
			return true;
		}

		public virtual bool CheckData_ScriptTaskExecute(ProcessExecutingContext context) {
			IsDataValid_NewRow = true;
			foreach (var pair in GetColumnValues()) {
				if (string.IsNullOrEmpty(pair.Value.Value)) {
					IsDataValid_NewRow = false;
					break;
				}
			}
			
			IsFilterParamsValuesCorrect = true;
			if (Page.AddFilterResultEdit.Checked) {
				var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
				IsFilterParamsValuesCorrect = !filters.IsAnyLeftExpressionNullOrEmpty();
			}
			
			return true;
		}

		public virtual bool ErrorMessage_ScriptTaskExecute(ProcessExecutingContext context) {
			if (!IsDataValid_NewRow) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessageTextNewRow, MessageType.Warning);
			}
			if (!IsFilterParamsValuesCorrect) {
				Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessageTextFilterParamsEmpty, MessageType.Warning);
			}
			
			return true;
		}

		public virtual bool Init_ScriptTaskExecute(ProcessExecutingContext context) {
			IEnumerable<Guid> packageIds = Terrasoft.Core.Packages.WorkspaceUtilities.GetPackageHierarchyIds(UserConnection, FindDesignedProcessSchema().PackageUId,
				UserConnection.Workspace.Id);
			object[] objectPackageIds = packageIds.Cast<object>().ToArray();
			var packageIdFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "SysPackage"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", objectPackageIds}};
			var extendParentFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "ExtendParent"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {false}}};
			Page.EntitySchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageIdFilter);
				filters.Add(extendParentFilter);
			};
			Page.FilterEntitySchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(packageIdFilter);
				filters.Add(extendParentFilter);
			};
			CreateColumnValuesVds();
			if (!Ext.IsAjaxRequest) {
				Page.UserTaskTitleEdit.Text = ElementNewCaption;
				DesignModeClassDescriptor descriptor = (DesignModeClassDescriptor)Descriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = (VirtualDataSource)PropertyDataSource;
				propertyDataSource.SetClientActiveRow();
				var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			}
			return true;
		}

		public virtual bool SetDefValues_ScriptTaskExecute(ProcessExecutingContext context) {
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			
			if (parameters == null) {
				return true;
			}
			
			string entitySchemaId = parameters["EntitySchemaId"].Value;
			if (!string.IsNullOrEmpty(entitySchemaId)) {
				EntitySchemaUId = new Guid(entitySchemaId);
				var entitySchema = new Terrasoft.Configuration.VwSysEntitySchemaInWorkspace(UserConnection);
				var entityConditions = new Dictionary<string, object>() {
					{ "UId", EntitySchemaUId },
					{ "SysWorkspace", UserConnection.Workspace.Id},
				};
				if (entitySchema.FetchFromDB(entityConditions)) {
					EntitySchemaCaption = entitySchema.Caption;
					Page.EntitySchemaEdit.SetValueAndText(EntitySchemaUId, EntitySchemaCaption);
				}
			}
			
			string filterEntitySchemaId = parameters["FilterEntitySchemaId"].Value;
			if (!string.IsNullOrEmpty(filterEntitySchemaId)) {
				FilterEntitySchemaUId = new Guid(filterEntitySchemaId);
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var entitySchemaItem = entitySchemaManager.GetItemByUId(FilterEntitySchemaUId);
				Page.FilterEntitySchemaEdit.SetValueAndText(entitySchemaItem.UId, entitySchemaItem.Caption);
				Page.FilterDataSource.SchemaUId = FilterEntitySchemaUId;
							
				string filters = parameters["DataSourceFilters"].Value;
				if (!string.IsNullOrEmpty(filters)) {
					var jsonConverter = new DataSourceFiltersJsonConverter(
						UserConnection, Page.FilterEdit.DataSource);
					var filterCollection = Json.Deserialize(filters, typeof(DataSourceFilterCollection), 
						new List<JsonConverter> { jsonConverter }) as DataSourceFilterCollection;
					if (filterCollection != null) {
						var filterEditGroup = Page.FilterDataSource.FindFiltersGroupByName(filterCollection.Name);
						if (filterEditGroup != null) {
							Page.FilterDataSource.CurrentStructure.Filters.Remove(filterEditGroup);
						}
						Page.FilterDataSource.CurrentStructure.Filters.Add(filterCollection);
					}
				}
				Page.FilterDataSource.LoadStructure();
				Page.FilterEdit.SetDataSource(Page.FilterDataSource);
			}
			
			Page.AddOneRowEdit.Checked = string.IsNullOrEmpty(filterEntitySchemaId);
			Page.AddFilterResultEdit.Checked = !string.IsNullOrEmpty(filterEntitySchemaId);
			RecordAddModeChanged();
			
			// Deserialize column values
			ColumnValuesContextKey = Guid.NewGuid().ToString();
			var columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			ProcessSchemaParameterValue serealizedCVs = parameters["RecordDefValues"];
			if (serealizedCVs != null) {
				EntityColumnMappingCollection cvColection = EntityColumnMappingCollection.DeserializeValue(serealizedCVs);
				foreach (EntityColumnMappingItem cv in cvColection) {
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

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
				{"EntitySchemaId", Page.EntitySchemaEdit},
				{"FilterEntitySchemaId", Page.FilterEntitySchemaEdit}
			};
		}

		public override void BindEditors(Dictionary<string, Terrasoft.UI.WebControls.WebControl> bindingMap, VirtualDataSource propertyDataSource, Dictionary<string, ProcessSchemaParameterValue> defValues) {
			foreach (var item in bindingMap) {
				string name = item.Key;
				var column = propertyDataSource.DefStructure.Columns.FindByName(name);
				if (item.Value is ProcessSchemaParameterValueEdit) {
					var parameterValueEditor = item.Value as ProcessSchemaParameterValueEdit;
					parameterValueEditor.DataSource = propertyDataSource.Name;
					parameterValueEditor.ColumnUId = column.UId;
					Page.AddScript(string.Format("{0}.showMappingWindowSignalName = 'ShowMappingWindow';", parameterValueEditor.ClientID));
				} else {
					(item.Value as UIControls.Field).DataSource = propertyDataSource.Name;
					(item.Value as UIControls.Field).ColumnUId = column.UId;
					var value = defValues[name].Value;
					if (item.Value is LookupEdit) {
						var id = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
						var text = defValues[name].DisplayValue;
						(item.Value as LookupEdit).SetValueAndText(id, text);
						//(item.Value as LookupEdit).Value = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
					} else if (item.Value is CheckBoxBase) {
						(item.Value as CheckBoxBase).Value = value;
					} else if (item.Value is NumberEdit) {
						(item.Value as NumberEdit).Value = string.IsNullOrEmpty(value) ? 0 : Decimal.Parse(value);
					} else if (item.Value is BaseEdit) {
						(item.Value as BaseEdit).Value = value;
					}
				}
			}
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				ElementNewCaption : Page.UserTaskTitleEdit.Text;	
		}

		public virtual bool IsEntitySchemaChanged() {
			return !EntitySchemaUId.Equals(Guid.Empty) && !EntitySchemaUId.Equals((Guid)Page.EntitySchemaEdit.Value);
		}

		public virtual string GetSerializedFilters() {
			var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName(FiltersGroupName);
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			var result = string.Empty;
			if (Page.FilterEntitySchemaEdit.Value.Equals(Guid.Empty)) {
				result = Json.Serialize(filters, jsonConverter);
			}
			return result;
			/*
			var result = string.Empty;
			if (Page.FilterDataSource.SchemaUId.Equals(Guid.Empty)) {
				return result;
			}
			//Page.FilterDataSource.LoadRows();	
			if (Page.FilterDataSource.CurrentStructure.Filters.Count > 0) {
				var filters = Page.FilterDataSource.CurrentStructure.Filters.FindByName(FiltersGroupName);
				var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterDataSource);
				result = Json.Serialize(filters, jsonConverter);
			}
			return result;	
			*/
		}

		public virtual void ClearControlValues() {
			Page.AddOneRowEdit.Checked = true;
			Page.AddFilterResultEdit.Checked = false;
			RecordAddModeChanged();
			var columnValuesContextKeySessionData =
				UserConnection.SessionData.Pop<Dictionary<string, ProcessSchemaParameterValue>>(ColumnValuesContextKey);
			if (columnValuesContextKeySessionData != null) {
				DisplayColumnValues();
			}
			ClearControlFilterValues();
		}

		public virtual void ClearControlFilterValues() {
			Page.FilterEdit.Enabled = false;
			
			var oldFilters = Page.FilterDataSource.CurrentStructure.Filters.FindByName(FiltersGroupName) as DataSourceFilterCollection;
			if (oldFilters != null) {
				oldFilters.Clear();
			}
			
			if (UserConnection.SessionData[ColumnValuesContextKey] != null) {
				var values = UserConnection.SessionData[ColumnValuesContextKey] as Dictionary<string, ProcessSchemaParameterValue>;
				var clearValues = new Dictionary<string, ProcessSchemaParameterValue>();
				foreach(var pair in values) {
					if (!pair.Value.Source.Equals(ProcessSchemaParameterValueSource.EntityMapping)) {
						clearValues.Add(pair.Key, pair.Value);
					}	
				}	
				UserConnection.SessionData[ColumnValuesContextKey] = clearValues;
				DisplayColumnValues();
			}
		}

		public virtual string GetSchemaCaption(Guid id) {
			return string.Empty;
		}

		public virtual void CreateColumnValuesVds() {
			var vds = new VirtualDataSource() {
				ID = "ColumnValuesVds"
			};
			Page.PageContainer.Controls.Add(vds);
			
			// Set vds Id for calendar tree grid
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

		public virtual VirtualDataSource GetColumnValuesVds() {
			return Page.PageContainer.FindControl("ColumnValuesVds") as VirtualDataSource;
		}

		public virtual Dictionary<string, ProcessSchemaParameterValue> GetColumnValues() {
			if (UserConnection.SessionData[ColumnValuesContextKey] == null) {
				return null;
			}
			
			return UserConnection.SessionData[ColumnValuesContextKey] as Dictionary<string, ProcessSchemaParameterValue>;
		}

		public virtual void RecordAddModeChanged() {
			Page.FilterEntitySchemaEdit.Enabled = Page.AddFilterResultEdit.Checked;
			Page.FilterEntitySchemaEdit.Required = Page.AddFilterResultEdit.Checked;
			// change filterEntity - logic
			if (!Page.AddFilterResultEdit.Checked) {	
				Page.FilterEntitySchemaEdit.SetValueAndText(Guid.Empty, "");
				Page.FilterEdit.Enabled = false;
				Page.FilterDataSource.CurrentStructure.Filters.Clear();
			}
		}

		public virtual void DisplayColumnValues() {
			var vds = GetColumnValuesVds();
			vds.Clear();
			Dictionary<string, ProcessSchemaParameterValue> columnValues = GetColumnValues();
			if (columnValues == null) {
				return;
			}
			if (columnValues.Count == 0 || EntitySchemaUId == Guid.Empty) {
				vds.LoadRows();
				return;
			}
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
			IEnumerable<DataValueTypeManagerItem> dataValueTypeItems = dataValueTypeManager.GetItems();
			var lookupDataValueTypeUId = new Guid("{B295071F-7EA9-4e62-8D1A-919BF3732FF2}");
			var dateTimeDataValueTypeUId = new Guid("{D21E9EF4-C064-4012-B286-FA1A8171DA44}");
			var dateDataValueTypeUId = new Guid("{603D4960-A1A2-45e9-B232-206A54421B01}");
			var timeDataValueTypeUId = new Guid("{04CC757B-8F06-482c-8A1A-0C0E171D2410}");
			var colorDataValueTypeUId = new Guid("{DAFB71F9-EE9F-4e0b-A4D7-37AA15987155}");
			foreach (KeyValuePair<string, ProcessSchemaParameterValue> columnValue in columnValues) {
				Entity row = vds.CreateRow();
				row.SetColumnValue("Id", Guid.NewGuid());
				row.SetColumnValue("MetaPath", columnValue.Key);
				EntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				row.SetColumnValue("Name", column.Caption);
				string displayValue = columnValue.Value.DisplayValue;
				if (column.DataValueTypeUId == lookupDataValueTypeUId) {
					displayValue = columnValue.Value.DisplayValue;
				} else if (column.DataValueTypeUId == dateTimeDataValueTypeUId
						|| column.DataValueTypeUId == dateDataValueTypeUId
						|| column.DataValueTypeUId == timeDataValueTypeUId
						|| column.DataValueTypeUId == colorDataValueTypeUId) {
					displayValue = columnValue.Value.DisplayValue;
				}
				if (string.IsNullOrEmpty(displayValue)) {
					displayValue = columnValue.Value.Value;
				}
				row.SetColumnValue("Value", displayValue);
				vds.Add(row);
			}
			vds.LoadRows();
		}

		public virtual Dictionary<string, string> GetPageParams(TreeGridNode node) {
			InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			var result = new Dictionary<string, string>() {
				{ "schemaId", EntitySchemaUId.ToString() },			
				{ "processSchemaId", EditSchemaUId.ToString() },
				{ "managerName", EditSchemaManagerName },
				{ "contextKey", ColumnValuesContextKey },
				{ "treeGridId", Page.ColumnValuesTreeGrid.ClientID },
				{ "insertedRowKey", InsertedColumnValueKey },
				{ "editElementId", EditElementUId.ToString() }
			};
			if (!FilterEntitySchemaUId.Equals(Guid.Empty) ) {
				result.Add("filterSchemaId", FilterEntitySchemaUId.ToString());
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

		public virtual List<Guid> GetNotNullColumnIdList() {
			var result = new List<Guid>();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			foreach(var column in entitySchema.Columns) {
				if (!entitySchema.PrimaryColumn.UId.Equals(column.UId) 
						&& column.IsDBRequirement
						&& !column.HasDefValue) {
					result.Add(column.UId);
				}
			}
			
			return result;
		}

		public virtual void InitGridWithNotNullColumns() {
			var columnValues = GetColumnValues();
			
			if ((columnValues != null && columnValues.Count > 0)
					|| EntitySchemaUId.Equals(Guid.Empty)) {
				return;
			}
			
			columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			foreach(var columnId in GetNotNullColumnIdList()) {
				var cv = new EntityColumnMappingItem() {
					SchemaUId = EntitySchemaUId,
					ColumnMetaPath = columnId.ToString(),
					Value = new ProcessSchemaParameterValue()
				};
				columnValues[cv.ColumnMetaPath] = cv.Value;
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
		}

		public virtual Guid GetEntityIdBySysSchemaInWorkspace(Guid sysSchamaInWorkspaceId) {
			var result = Guid.Empty;
			 //TODO: 175393
			var sysSchemaInWorkspace = new Terrasoft.Core.Configuration.VwSysSchemaInWorkspace(Page.UserConnection)	;
			if (!sysSchamaInWorkspaceId.Equals(Guid.Empty) && sysSchemaInWorkspace.FetchFromDB(sysSchamaInWorkspaceId)) {
				result = sysSchemaInWorkspace.GetTypedColumnValue<Guid>("UId");
			}
			return result;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ColumnValuesTreeGridSelectionChange":
							if (ActivatedEventElements.Contains("ColumnValuesTreeGridSelectionChange_StartMessage")) {
							context.QueueTasks.Enqueue("ColumnValuesTreeGridSelectionChange_StartMessage");
						}
						break;
					case "EntitySchemaEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("EntitySchemaEditChange_StartMessage");
						}
						break;
					case "ChangeSchemaEntityYesMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityYesMessage_StartMessage")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessage_StartMessage");
						}
						break;
					case "ChangeSchemaEntityNoMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityNoMessage_StartMessage")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessage_StartMessage");
						}
						break;
					case "AddFilterResultEditCheck":
							if (ActivatedEventElements.Contains("AddFilterResultEditCheck_StartMessage")) {
							context.QueueTasks.Enqueue("AddFilterResultEditCheck_StartMessage");
						}
						break;
					case "FilterEntitySchemaEditChange":
							if (ActivatedEventElements.Contains("FilterEntitySchemaEditChange_StartMessage")) {
							context.QueueTasks.Enqueue("FilterEntitySchemaEditChange_StartMessage");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClick_StartMessage")) {
							context.QueueTasks.Enqueue("AddButtonClick_StartMessage");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClick_StartMessage")) {
							context.QueueTasks.Enqueue("DeleteButtonClick_StartMessage");
						}
						break;
					case "EditValueButtonClick":
							if (ActivatedEventElements.Contains("EditValueButtonClick_StartMessage")) {
							context.QueueTasks.Enqueue("EditValueButtonClick_StartMessage");
						}
						break;
					case "DeleteColumnYesMessage":
							if (ActivatedEventElements.Contains("DeleteColumnYesMessage_StartMessage")) {
							context.QueueTasks.Enqueue("DeleteColumnYesMessage_StartMessage");
						}
						break;
					case "ColumnValuesTreeGridDblClick":
							if (ActivatedEventElements.Contains("ColumnValuesTreeGridDblClick_StartMessage")) {
							context.QueueTasks.Enqueue("ColumnValuesTreeGridDblClick_StartMessage");
						}
						break;
					case "ColumnValueEditPageClosed":
							if (ActivatedEventElements.Contains("ColumnValueEditPageClosedStartMessage")) {
							context.QueueTasks.Enqueue("ColumnValueEditPageClosedStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClick_StartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClick_StartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("Init_StartMessage")) {
							context.QueueTasks.Enqueue("Init_StartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete_StartMessage")) {
							context.QueueTasks.Enqueue("PageLoadComplete_StartMessage");
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
			if (!HasMapping("InsertedColumnValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InsertedColumnValueKey", InsertedColumnValueKey, null);
			}
			if (!HasMapping("IsFilterParamsValuesCorrect") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsFilterParamsValuesCorrect", IsFilterParamsValuesCorrect, false);
			}
			if (!HasMapping("IsDataValid_NewRow") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDataValid_NewRow", IsDataValid_NewRow, false);
			}
			if (!HasMapping("EntitySchemaCaption") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaCaption", EntitySchemaCaption, null);
			}
			if (!HasMapping("ColumnValueEditPageId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnValueEditPageId", ColumnValueEditPageId, Guid.Empty);
			}
			if (!HasMapping("ColumnValuesContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnValuesContextKey", ColumnValuesContextKey, null);
			}
			if (!HasMapping("FilterEntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FilterEntitySchemaUId", FilterEntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("FiltersGroupName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FiltersGroupName", FiltersGroupName, null);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("VirtualDataSourceID") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("VirtualDataSourceID", VirtualDataSourceID, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AddDataUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class AddDataUserTaskParametersEditPageEventsProcess : AddDataUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.AddDataUserTaskParametersEditPageSchemaUserControl>
	{

		public AddDataUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddDataUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class AddDataUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit UserTaskTitleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("UserTaskTitleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EntitySchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AddOneRowEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AddOneRowEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.RadioButton AddFilterResultEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.RadioButton)PageContainer.FindPageControl("AddFilterResultEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit FilterEntitySchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("FilterEntitySchemaEdit", true);
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid ColumnValuesTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("ColumnValuesTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource FilterDataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("FilterDataSource", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			EntitySchemaEdit.AjaxEvents.Change.Event += EntitySchemaEditChange;
			AddFilterResultEdit.AjaxEvents.Check.Event += AddFilterResultEditCheck;
			FilterEntitySchemaEdit.AjaxEvents.Change.Event += FilterEntitySchemaEditChange;
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			EditValueButton.AjaxEvents.Click.Event += EditValueButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
			ColumnValuesTreeGrid.AjaxEvents.DblClick.Event += ColumnValuesTreeGridDblClick;
			ColumnValuesTreeGrid.AjaxEvents.SelectionChange.Event += ColumnValuesTreeGridSelectionChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntitySchemaEdit.AjaxEvents.Change.Event -= EntitySchemaEditChange;
			AddFilterResultEdit.AjaxEvents.Check.Event -= AddFilterResultEditCheck;
			FilterEntitySchemaEdit.AjaxEvents.Change.Event -= FilterEntitySchemaEditChange;
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			EditValueButton.AjaxEvents.Click.Event -= EditValueButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
			ColumnValuesTreeGrid.AjaxEvents.DblClick.Event -= ColumnValuesTreeGridDblClick;
			ColumnValuesTreeGrid.AjaxEvents.SelectionChange.Event -= ColumnValuesTreeGridSelectionChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AddDataUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AddDataUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void EntitySchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("EntitySchemaEditChange");
		}

		public virtual void AddFilterResultEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("AddFilterResultEditCheck");
		}

		public virtual void FilterEntitySchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("FilterEntitySchemaEditChange");
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

		public virtual void ColumnValuesTreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("ColumnValuesTreeGridDblClick");
		}

		public virtual void ColumnValuesTreeGridSelectionChange(object sender, EventArgs e) {
			object result = ThrowEvent("ColumnValuesTreeGridSelectionChange");
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
			SchemaName = "AddDataUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: AddDataUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class AddDataUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public AddDataUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AddDataUserTaskParametersEditPageEventsProcessSchema(AddDataUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AddDataUserTaskParametersEditPageEventsProcess";
			UId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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

		protected virtual ProcessSchemaParameter CreateVirtualDataSourceIDParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6266385a-0293-4352-abfd-7bc746dc60b1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"VirtualDataSourceID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("012bec90-5255-4fb9-a555-8f575ce593bc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFiltersGroupNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("08b4a718-d836-4efb-b774-6e55a80a8f21"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"FiltersGroupName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7d2936c9-2720-4a9c-8849-14570cd95f9b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"FilterEntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnValuesContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a258c514-aa67-4322-a891-b766db9ea3a2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValuesContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnValueEditPageIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb63d071-0eb3-403f-acba-aab2f9634968"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValueEditPageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"db94a59d-ccc6-4ba5-8eb0-eb7dfba68488",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("527e861b-8314-412e-8f13-9231ba5aac6e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EntitySchemaCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDataValid_NewRowParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("98bdfe0a-29bc-4fa8-9777-20c4cb348ef3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"IsDataValid_NewRow",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterParamsValuesCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56cbd2ef-34cc-4c76-863b-e849a899af49"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"IsFilterParamsValuesCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedColumnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("16844e7b-fad5-416a-bd7d-6ccfd9568b08"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"InsertedColumnValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateVirtualDataSourceIDParameter());
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateFiltersGroupNameParameter());
			Parameters.Add(CreateFilterEntitySchemaUIdParameter());
			Parameters.Add(CreateColumnValuesContextKeyParameter());
			Parameters.Add(CreateColumnValueEditPageIdParameter());
			Parameters.Add(CreateEntitySchemaCaptionParameter());
			Parameters.Add(CreateIsDataValid_NewRowParameter());
			Parameters.Add(CreateIsFilterParamsValuesCorrectParameter());
			Parameters.Add(CreateInsertedColumnValueKeyParameter());
		}

		protected virtual void InitializeChangeSchemaEntityQuestion_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a4a47556-111f-435b-b530-28c88c877e45"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("dbac814e-c5ec-4c05-80db-c0b8b4f5f401"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("d220718d-2721-4a79-a3a2-c7a53818de12"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("7738d8c7-9bac-4879-98f4-8da6889a387c"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("7dfcb9fa-b5b7-46be-b2be-c05814228a6d"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("f9fe68fe-28d8-4d6d-aa37-c4a6e765c076"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("8ac00b15-a024-46a5-a29b-7f4c9b057bbf"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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
				UId = new Guid("9aeb359a-703f-435e-9c9d-b32166304de9"),
				ContainerUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
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

		protected virtual void InitializeOpenColumnValuePage_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("191f629a-b633-498e-9615-d8bd07e754b0"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("7dd6de31-3b5d-475f-8b4d-f0bfc17ee8b3"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("2b566fd7-1e5b-433d-8d23-276f0d2a45c6"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("24f60609-aebb-4bfe-92d8-f9d8cc0d6e49"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("73605534-647f-4657-8f21-6b1b05849897"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("eb888cbb-0e0a-42aa-952c-727edff9b268"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("1760af14-c263-4233-b01e-9151446f6320"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("7bf67d44-b9f8-430e-a156-52c24f3dde52"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("640f4a85-5cb2-4bf3-a1be-225c718ea0bb"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("ecd92b69-972a-4f38-b0c7-c034776bfc87"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("a08dec75-38b0-409a-8daa-8367a535864f"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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
				UId = new Guid("cd179957-b0c5-4be0-b875-dc45c000d74f"),
				ContainerUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
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

		protected virtual void InitializeDeleteColumnQuestion_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4dc08063-ca57-41cc-9c55-2093a1482ef0"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("a80ba473-6409-4098-a0d8-8afba06a9acb"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("0c29bc42-36e6-450b-b09a-fb604560df25"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("d36938a2-b70b-4b94-bd4c-779a245704f7"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("a3dfd6b7-040e-490b-98bd-5361a154ae5b"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("532199bc-7508-4ddf-bdd2-3780560de1f6"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("aa1e5f0e-66f7-4af6-b7ea-d30bb619a7c3"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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
				UId = new Guid("793935c1-33b8-48b9-b4bf-7888c066039c"),
				ContainerUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
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

		protected virtual void InitializeOpenEditColumnValuePage_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("32c6f28b-3df8-405c-a9ee-365520ca72ca"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("1f7e8bf0-7706-48e8-a3ac-7fbb3819166c"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("8dd0d9bc-e62a-4881-a493-d9149002a50e"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("32fe49c9-0427-4242-a52c-710f0871e5a4"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("2b698e7e-8a69-4ea8-8df8-71b6ffbc59a5"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("d6b20aaa-c747-4858-a92f-5d939008274a"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("5ba7b3bc-a3b6-4c00-874b-40057165be87"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("748e6aa5-bf06-4622-9e7d-a4f4be1dcd41"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("80e21578-6ff0-4341-8c56-2526583d5038"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("c2a0e1fb-8e67-4db1-80cf-a12208831c13"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("cce6d412-a4a2-496f-8956-6f1c8aab03c6"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
				UId = new Guid("d4df1daa-1d5e-49aa-bef2-4c8cbaaf8331"),
				ContainerUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane7 = CreateLane7Lane();
			schemaLaneSet1.Lanes.Add(schemaLane7);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess columnvalueeditpageclosedeventsubprocess = CreateColumnValueEditPageClosedEventSubProcessEventSubProcess();
			FlowElements.Add(columnvalueeditpageclosedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaStartMessageEvent columnvaluestreegridselectionchange_startmessage = CreateColumnValuesTreeGridSelectionChange_StartMessageStartMessageEvent();
			eventsubprocess7.FlowElements.Add(columnvaluestreegridselectionchange_startmessage);
			ProcessSchemaScriptTask processselectedrow_scripttask = CreateProcessSelectedRow_ScriptTaskScriptTask();
			eventsubprocess7.FlowElements.Add(processselectedrow_scripttask);
			ProcessSchemaStartMessageEvent entityschemaeditchange_startmessage = CreateEntitySchemaEditChange_StartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(entityschemaeditchange_startmessage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess8.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask preparechangeschemaentityquestion_scripttask = CreatePrepareChangeSchemaEntityQuestion_ScriptTaskScriptTask();
			eventsubprocess8.FlowElements.Add(preparechangeschemaentityquestion_scripttask);
			ProcessSchemaUserTask changeschemaentityquestion_usertask = CreateChangeSchemaEntityQuestion_UserTaskUserTask();
			eventsubprocess8.FlowElements.Add(changeschemaentityquestion_usertask);
			ProcessSchemaIntermediateThrowMessageEvent entityschemaeditchange_changeschemaentityyesmessage_intermediatethrowmessageevent = CreateEntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess8.FlowElements.Add(entityschemaeditchange_changeschemaentityyesmessage_intermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent changeschemaentityyesmessage_startmessage = CreateChangeSchemaEntityYesMessage_StartMessageStartMessageEvent();
			eventsubprocess9.FlowElements.Add(changeschemaentityyesmessage_startmessage);
			ProcessSchemaScriptTask dochangeselectedentityschema_scripttask = CreateDoChangeSelectedEntitySchema_ScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(dochangeselectedentityschema_scripttask);
			ProcessSchemaStartMessageEvent changeschemaentitynomessage_startmessage = CreateChangeSchemaEntityNoMessage_StartMessageStartMessageEvent();
			eventsubprocess10.FlowElements.Add(changeschemaentitynomessage_startmessage);
			ProcessSchemaScriptTask donotchangeselectedentityschema_scripttask = CreateDoNotChangeSelectedEntitySchema_ScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(donotchangeselectedentityschema_scripttask);
			ProcessSchemaStartMessageEvent addfilterresulteditcheck_startmessage = CreateAddFilterResultEditCheck_StartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(addfilterresulteditcheck_startmessage);
			ProcessSchemaScriptTask addmanyrowsrbeditcheckchanged_scripttask = CreateAddManyRowsRBEditCheckChanged_ScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(addmanyrowsrbeditcheckchanged_scripttask);
			ProcessSchemaStartMessageEvent filterentityschemaeditchange_startmessage = CreateFilterEntitySchemaEditChange_StartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(filterentityschemaeditchange_startmessage);
			ProcessSchemaScriptTask processfilteredit_scripttask = CreateProcessFilterEdit_ScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(processfilteredit_scripttask);
			ProcessSchemaStartMessageEvent addbuttonclick_startmessage = CreateAddButtonClick_StartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(addbuttonclick_startmessage);
			ProcessSchemaScriptTask processaddbuttonclick_prepareopencolumnvaluepage_scripttask = CreateProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(processaddbuttonclick_prepareopencolumnvaluepage_scripttask);
			ProcessSchemaUserTask opencolumnvaluepage_usertask = CreateOpenColumnValuePage_UserTaskUserTask();
			eventsubprocess4.FlowElements.Add(opencolumnvaluepage_usertask);
			ProcessSchemaStartMessageEvent deletebuttonclick_startmessage = CreateDeleteButtonClick_StartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(deletebuttonclick_startmessage);
			ProcessSchemaScriptTask preparedeletecolumnquestion_scripttask = CreatePrepareDeleteColumnQuestion_ScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(preparedeletecolumnquestion_scripttask);
			ProcessSchemaUserTask deletecolumnquestion_usertask = CreateDeleteColumnQuestion_UserTaskUserTask();
			eventsubprocess5.FlowElements.Add(deletecolumnquestion_usertask);
			ProcessSchemaScriptTask breakdelete_scripttask = CreateBreakDelete_ScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(breakdelete_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess5.FlowElements.Add(exclusivegateway2);
			ProcessSchemaStartMessageEvent editvaluebuttonclick_startmessage = CreateEditValueButtonClick_StartMessageStartMessageEvent();
			eventsubprocess13.FlowElements.Add(editvaluebuttonclick_startmessage);
			ProcessSchemaScriptTask processeditbuttonclick_scripttask = CreateProcessEditButtonClick_ScriptTaskScriptTask();
			eventsubprocess13.FlowElements.Add(processeditbuttonclick_scripttask);
			ProcessSchemaUserTask openeditcolumnvaluepage_usertask = CreateOpenEditColumnValuePage_UserTaskUserTask();
			eventsubprocess13.FlowElements.Add(openeditcolumnvaluepage_usertask);
			ProcessSchemaStartMessageEvent deletecolumnyesmessage_startmessage = CreateDeleteColumnYesMessage_StartMessageStartMessageEvent();
			eventsubprocess14.FlowElements.Add(deletecolumnyesmessage_startmessage);
			ProcessSchemaScriptTask deletecolumn_scripttask = CreateDeleteColumn_ScriptTaskScriptTask();
			eventsubprocess14.FlowElements.Add(deletecolumn_scripttask);
			ProcessSchemaStartMessageEvent columnvaluestreegriddblclick_startmessage = CreateColumnValuesTreeGridDblClick_StartMessageStartMessageEvent();
			eventsubprocess15.FlowElements.Add(columnvaluestreegriddblclick_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent columnvaluestreegriddblclick_editvaluebuttonclick_intermediatethrowmessageevent = CreateColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess15.FlowElements.Add(columnvaluestreegriddblclick_editvaluebuttonclick_intermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent columnvalueeditpageclosedstartmessage = CreateColumnValueEditPageClosedStartMessageStartMessageEvent();
			columnvalueeditpageclosedeventsubprocess.FlowElements.Add(columnvalueeditpageclosedstartmessage);
			ProcessSchemaScriptTask columnvalueeditpageclosedscripttask = CreateColumnValueEditPageClosedScriptTaskScriptTask();
			columnvalueeditpageclosedeventsubprocess.FlowElements.Add(columnvalueeditpageclosedscripttask);
			ProcessSchemaStartMessageEvent okbuttonclick_startmessage = CreateOkButtonClick_StartMessageStartMessageEvent();
			eventsubprocess12.FlowElements.Add(okbuttonclick_startmessage);
			ProcessSchemaScriptTask setprocessparams_scripttask = CreateSetProcessParams_ScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(setprocessparams_scripttask);
			ProcessSchemaIntermediateThrowMessageEvent okbuttonclick_intermediatethrowmessageevent = CreateOkButtonClick_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess12.FlowElements.Add(okbuttonclick_intermediatethrowmessageevent);
			ProcessSchemaScriptTask checkdata_scripttask = CreateCheckData_ScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(checkdata_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			eventsubprocess12.FlowElements.Add(exclusivegateway3);
			ProcessSchemaScriptTask errormessage_scripttask = CreateErrorMessage_ScriptTaskScriptTask();
			eventsubprocess12.FlowElements.Add(errormessage_scripttask);
			ProcessSchemaStartMessageEvent init_startmessage = CreateInit_StartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(init_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent init_intermediatethrowmessageevent = CreateInit_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(init_intermediatethrowmessageevent);
			ProcessSchemaScriptTask init_scripttask = CreateInit_ScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(init_scripttask);
			ProcessSchemaStartMessageEvent pageloadcomplete_startmessage = CreatePageLoadComplete_StartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(pageloadcomplete_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcomplete_intermediatethrowmessageevent = CreatePageLoadComplete_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(pageloadcomplete_intermediatethrowmessageevent);
			ProcessSchemaScriptTask setdefvalues_scripttask = CreateSetDefValues_ScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(setdefvalues_scripttask);
			ProcessSchemaScriptTask addnotnullcolumns_scripttask = CreateAddNotNullColumns_ScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(addnotnullcolumns_scripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
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
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("136237bc-4de7-41b3-889a-e66f531b1af8"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("daabf9e3-a03d-48c1-aaed-a25eb8f19fa1"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValueColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6620d2d7-7777-423d-85f8-cf6de75b4ca6"),
				Name = "ValueColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteColumnMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7bbcef56-e5f6-4ed1-ab16-eacabdd6cca3"),
				Name = "DeleteColumnMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7da9714d-d397-4086-abdb-ad6d910389e0"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextNewRowLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a9e66a47-e545-4acc-876b-662bbab56836"),
				Name = "ValidationMessageTextNewRow",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTextFilterParamsEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9bd27b9b-b87c-4a27-b141-6afe0f5ef143"),
				Name = "ValidationMessageTextFilterParamsEmpty",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("fa499a34-66e9-4fe7-be32-c5f1dfd6186e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("147951e0-5582-4dba-b9bb-5513b229b261"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77f34950-42f6-4ef3-9290-2a1aee89b48a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f79578be-28fc-4dec-85d6-832ceda14cb6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(170, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9ca98f7-e04e-45d0-94ce-f641c449ddf9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c6374ef-003c-46da-a052-d8622b16b90b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("6b3fee2a-e73f-40ca-99ff-9c22687ff31c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(268, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c6374ef-003c-46da-a052-d8622b16b90b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cec8505a-1aef-4bbd-9e46-48ac55b90354"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("50084326-5238-4bee-8f77-4f5b4b4df2be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(162, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da783a9a-38f2-431d-a1cc-66f7be2d1080"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c7eb845-6666-4ff3-8fce-aae84e60bcda"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("b080730f-550b-45ab-be8a-c400621ee210"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(426, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1cb9b047-da0a-4d66-8e09-c355af6ae411"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("152269e0-8c27-4f63-9b3e-440ae9657f57"),
				ConditionExpression = @"IsEntitySchemaChanged()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(281, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c7eb845-6666-4ff3-8fce-aae84e60bcda"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1cb9b047-da0a-4d66-8e09-c355af6ae411"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("8bcd9dfb-18f4-4298-a634-93b0f16d7adf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(217, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c7eb845-6666-4ff3-8fce-aae84e60bcda"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("027da987-b17d-49e7-aab4-d8bea5ae93af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("58e96edc-a4c3-46d1-bbfd-5ea722c9e3e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(164, 329),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("602509d8-0306-479b-8b54-1c5dc77a8739"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8e7b2508-ce48-4030-914c-84b53e213b6c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("5f725398-c9cd-4451-8561-a4b1f99d4f78"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(430, 329),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b6e30d1f-8663-467a-af31-7ee327b5b361"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c4917ad8-5d2e-43b4-9e7e-0e0977ee4ed6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("9a006bf7-4db5-453a-83e7-a506ff7e5f8e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("30acb4e5-62ab-456b-9b1f-e5b1e02fddbb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("80b61b45-b018-470d-b296-fc1c4ab474e7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("bf1c7eb7-2dde-4f10-ae52-a4500fdd7422"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(294, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d70308a4-86b8-4788-b305-4350528e7570"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a6c43bc3-9760-497a-8a63-55bf034caf3d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("d38c6829-f156-4180-a308-b9b8208e0d92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c5d9304-98d7-4051-a379-4a1e1564a019"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("70ce59de-2c24-4f06-b45e-6edfc90f442a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("c0593257-46b0-48f4-95a2-a5ac2d475800"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3761e734-99ce-4506-9956-262ffdeaf750"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("458a101b-3e49-47a0-987f-c76e7ae9939e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("d6d7396f-a683-4271-9077-8633306df54d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(172, 1330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2834a381-a6ec-49d5-ae19-5099a0a0c768"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb0efeb1-52ee-478e-9621-8d1b5fcdd327"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("5b6f3c15-2888-4579-b70d-c6fa43003191"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(274, 1330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb0efeb1-52ee-478e-9621-8d1b5fcdd327"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0625fbfa-cd59-4b71-9347-77d1dfed062e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("292bfeb2-106d-4db0-b035-e4fe7d4445c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(300, 826),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5fe449be-135e-40af-a548-7dde521fa3b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("89bf6ff7-4b71-42ff-bf55-6533e2a5d63f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(296, 966),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3d5a3c3-e8a4-4b3e-add7-fabb991ad1fc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("be0d3200-d762-4f2e-80a7-ef59d1b6a5ce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(166, 1134),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2189b114-663b-4279-b781-90461ebc6b17"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3afc4a9c-a6e9-4bcc-8191-12ec0c58c218"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("382ea666-b3c6-4fc7-bce4-b4ad5325e26e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(230, 826),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("709502c2-eeb2-4297-bcf1-1e1ae8bb0c0c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5fe449be-135e-40af-a548-7dde521fa3b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("c0b0a897-1c2c-4892-ab69-d135333c4ba7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(164, 966),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("49c15664-1e76-4774-811e-3ae5ef01e7b8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03d557e7-0950-46fa-8440-643c2ceff653"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("322322c1-da83-4fef-84a8-40eb2027cbcb"),
				ConditionExpression = @"Page.ColumnValuesTreeGrid.SelectedNodes.Count > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(294, 987),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03d557e7-0950-46fa-8440-643c2ceff653"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a3d5a3c3-e8a4-4b3e-add7-fabb991ad1fc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("5fe00bff-16a7-454d-9f3f-e3e88bab04ee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(224, 1055),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03d557e7-0950-46fa-8440-643c2ceff653"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e466bc2-e302-4c6c-abe5-abadb9714416"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("fc719062-0c9c-431b-9e83-0c0a6dcced66"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(300, 1408),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("458a101b-3e49-47a0-987f-c76e7ae9939e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("5a2c761a-42dc-4ac4-b2d6-be87092d7884"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(424, 1642),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0625fbfa-cd59-4b71-9347-77d1dfed062e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e6e7a88-bf5e-404e-ac5c-e85a1a56fbb0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("d93102aa-52a7-4964-a148-c3cdb9be82e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7d6b29c6-0165-4be6-9dda-44c6bfb06f42"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("53fce431-a33a-45f9-9796-8229de4e60c3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("89d561ef-df9a-4776-bc0d-7f78700b60a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(448, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("844450b7-a2bf-4f8f-90fc-7eb15b6130af"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba187f53-116d-4347-898c-1e8a5347a8f4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("cdc8d030-8808-4657-a737-eab90a1118d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80b61b45-b018-470d-b296-fc1c4ab474e7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ec0375d0-6f55-4812-8405-3c14f1d97cce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow27",
				UId = new Guid("45f501b0-ef78-4008-83e1-94922abd2f3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(375, 372),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec0375d0-6f55-4812-8405-3c14f1d97cce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("450b9fa1-be74-480d-90c9-97129333203f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("7915a519-5730-4012-b82c-ca3c120dbc34"),
				ConditionExpression = @"IsDataValid_NewRow && IsFilterParamsValuesCorrect",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(385, 248),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec0375d0-6f55-4812-8405-3c14f1d97cce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d70308a4-86b8-4788-b305-4350528e7570"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(308, 1760));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("8126ae90-9c8e-4387-807d-73c15b57c176"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CurveCenterPosition = new Point(524, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2edc2e5c-791f-4d6b-8a1a-49e3d3d15345"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d571fc2-ce5c-414b-b1b8-bb3d9f22885d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3ce2f8e2-18e6-46a1-a788-088291cb9542"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(717, 2384),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane7Lane() {
			ProcessSchemaLane schemaLane7 = new ProcessSchemaLane(this) {
				UId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3ce2f8e2-18e6-46a1-a788-088291cb9542"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"Lane7",
				Position = new Point(29, 0),
				Size = new Size(688, 165),
				UseBackgroundMode = false
			};
			return schemaLane7;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("913c00ea-83d2-4e4f-9c46-cdc96e4c1235"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess7",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(251, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValuesTreeGridSelectionChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7d6b29c6-0165-4be6-9dda-44c6bfb06f42"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("913c00ea-83d2-4e4f-9c46-cdc96e4c1235"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ColumnValuesTreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValuesTreeGridSelectionChange_StartMessage",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessSelectedRow_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("53fce431-a33a-45f9-9796-8229de4e60c3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("913c00ea-83d2-4e4f-9c46-cdc96e4c1235"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ProcessSelectedRow_ScriptTask",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,79,107,195,48,12,197,207,246,167,16,61,57,180,152,221,187,94,246,135,50,216,66,160,101,151,178,131,87,43,141,193,177,135,35,111,135,145,239,62,37,206,88,79,187,9,233,189,159,158,212,152,11,234,7,244,72,120,151,137,98,208,143,193,188,123,180,176,3,74,25,183,178,141,9,205,185,3,245,105,18,132,104,17,92,128,102,178,221,71,159,251,240,106,124,198,225,152,16,247,201,89,125,96,214,153,208,214,172,28,42,248,150,98,242,245,72,166,49,212,49,117,66,232,98,58,173,94,150,254,234,77,31,227,129,146,11,23,85,109,139,199,217,103,55,16,59,246,72,117,164,58,123,95,54,62,205,131,63,29,75,110,184,254,234,156,71,229,224,118,113,114,190,28,104,142,32,92,171,10,157,155,253,135,73,168,126,19,109,22,245,201,93,71,216,204,199,87,176,99,116,33,136,230,159,79,181,198,15,252,42,86,37,164,156,194,242,58,33,198,105,247,122,205,229,40,228,40,229,245,248,7,234,69,135,63,123,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess8",
				Position = new Point(35, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(501, 242),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da783a9a-38f2-431d-a1cc-66f7be2d1080"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EntitySchemaEditChange_StartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("1c7eb845-6666-4ff3-8fce-aae84e60bcda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareChangeSchemaEntityQuestion_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1cb9b047-da0a-4d66-8e09-c355af6ae411"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"PrepareChangeSchemaEntityQuestion_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,49,14,130,64,16,69,107,73,184,195,102,107,226,5,80,11,145,130,66,16,129,130,202,108,200,4,136,113,214,236,12,81,66,184,187,139,82,152,104,65,245,139,121,239,207,15,26,133,53,100,85,3,55,21,34,183,220,167,29,16,183,26,47,5,129,201,21,93,215,39,85,131,216,138,41,124,215,9,22,24,71,32,178,116,14,79,182,226,175,49,223,23,182,69,149,70,91,35,211,34,204,242,40,137,229,66,111,223,49,107,164,73,45,195,44,78,150,122,103,160,187,245,96,94,57,21,32,60,196,161,173,38,78,153,126,67,108,90,172,61,241,201,157,24,92,103,53,200,30,72,122,66,254,190,40,129,230,46,57,122,111,20,245,127,50,214,223,224,104,7,187,142,1,238,12,10,54,29,248,47,78,163,183,188,175,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeSchemaEntityQuestion_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("93a8cfe8-24a1-4001-9b4c-f4ba963203f4"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ChangeSchemaEntityQuestion_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 37),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeSchemaEntityQuestion_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateEntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("027da987-b17d-49e7-aab4-d8bea5ae93af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34b60250-f809-40a1-9841-e0d9495ed039"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EntitySchemaEditChange_ChangeSchemaEntityYesMessage_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("56814492-0936-4a57-8d06-99613a7552df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 424),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityYesMessage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("602509d8-0306-479b-8b54-1c5dc77a8739"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56814492-0936-4a57-8d06-99613a7552df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ChangeSchemaEntityYesMessage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDoChangeSelectedEntitySchema_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8e7b2508-ce48-4030-914c-84b53e213b6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("56814492-0936-4a57-8d06-99613a7552df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"DoChangeSelectedEntitySchema_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,205,74,3,49,16,199,207,22,250,14,97,189,100,65,86,165,7,193,47,144,90,165,23,91,104,107,207,97,119,176,139,105,86,179,89,90,111,246,3,47,22,188,123,241,21,68,45,174,138,245,21,38,111,228,236,174,74,15,30,66,146,201,252,255,243,203,76,85,130,208,213,72,25,29,201,83,33,19,136,185,187,83,46,173,175,179,118,227,176,193,86,87,55,183,54,182,42,21,134,247,184,192,79,59,197,20,159,237,196,94,227,163,189,193,212,222,109,51,124,160,219,2,159,112,78,123,106,199,118,198,236,212,78,240,19,223,179,148,76,134,143,248,177,198,240,29,23,118,76,235,218,222,226,27,163,220,17,126,209,243,135,157,225,43,9,230,118,204,200,38,197,23,118,58,104,93,197,53,101,66,115,213,242,123,208,23,117,213,141,244,121,124,33,124,32,163,39,102,71,84,136,32,200,59,165,42,115,118,16,4,135,194,136,78,12,186,45,226,243,166,208,162,15,6,116,92,11,66,211,20,103,80,46,45,251,117,234,1,219,99,92,193,128,181,64,130,111,120,166,164,62,40,58,135,145,114,203,165,21,175,26,201,164,175,184,67,201,78,30,56,210,81,159,59,132,86,152,20,193,110,15,52,112,231,55,167,30,215,46,19,33,121,33,246,254,64,56,63,78,194,192,205,80,188,101,146,140,207,203,59,239,186,76,196,63,56,185,85,109,8,126,98,160,229,11,41,244,110,38,223,207,135,179,44,175,138,139,140,151,62,243,191,115,27,134,134,36,117,21,154,99,29,6,221,208,244,78,34,115,146,72,89,0,22,227,214,96,18,173,152,209,9,236,124,3,57,193,112,103,18,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3d3f4104-853c-477a-be51-6fec932725db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(288, 424),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(259, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityNoMessage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b6e30d1f-8663-467a-af31-7ee327b5b361"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d3f4104-853c-477a-be51-6fec932725db"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityNoMessage",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ChangeSchemaEntityNoMessage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDoNotChangeSelectedEntitySchema_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c4917ad8-5d2e-43b4-9e7e-0e0977ee4ed6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3d3f4104-853c-477a-be51-6fec932725db"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"DoNotChangeSelectedEntitySchema_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,189,10,194,48,20,133,103,243,20,113,41,9,72,94,160,83,145,32,93,84,172,186,7,115,173,145,52,214,228,94,105,17,223,93,113,106,197,110,7,206,223,231,206,92,204,117,64,135,125,117,186,64,99,14,165,85,250,78,198,39,177,34,247,209,77,139,189,228,89,198,19,70,23,106,85,166,53,121,191,137,95,67,12,171,75,211,162,187,5,41,249,147,205,34,32,197,192,49,18,228,236,197,216,214,212,160,134,105,109,29,170,138,82,11,193,22,87,211,233,7,4,76,66,230,83,81,192,163,241,4,69,176,123,232,80,252,64,47,248,63,148,169,177,29,36,106,96,124,59,34,126,3,15,238,82,41,24,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f46940bc-d34a-4b4b-bdba-07c1baeabac5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess2",
				Position = new Point(35, 604),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(242, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddFilterResultEditCheck_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("147951e0-5582-4dba-b9bb-5513b229b261"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f46940bc-d34a-4b4b-bdba-07c1baeabac5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddFilterResultEditCheck",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"AddFilterResultEditCheck_StartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddManyRowsRBEditCheckChanged_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77f34950-42f6-4ef3-9290-2a1aee89b48a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f46940bc-d34a-4b4b-bdba-07c1baeabac5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"AddManyRowsRBEditCheckChanged_ScriptTask",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,74,77,206,47,74,113,76,73,241,205,79,73,117,206,72,204,75,79,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,103,247,129,162,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1ab1857b-5043-4164-95ef-ab13e650a310"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess11",
				Position = new Point(35, 780),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFilterEntitySchemaEditChange_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7c5d9304-98d7-4051-a379-4a1e1564a019"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ab1857b-5043-4164-95ef-ab13e650a310"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"FilterEntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"FilterEntitySchemaEditChange_StartMessage",
				Position = new Point(36, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessFilterEdit_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("70ce59de-2c24-4f06-b45e-6edfc90f442a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1ab1857b-5043-4164-95ef-ab13e650a310"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ProcessFilterEdit_ScriptTask",
				Position = new Point(134, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,193,74,196,48,16,134,207,22,250,14,161,167,228,146,23,88,245,82,187,178,224,97,33,172,158,199,116,116,3,105,162,201,4,45,226,187,155,166,21,11,91,111,97,248,243,205,247,79,107,17,66,235,29,5,111,247,198,18,134,71,176,9,35,23,187,186,170,171,121,212,57,50,52,42,125,198,1,78,135,158,221,48,238,240,131,41,180,168,137,159,34,78,4,151,223,198,59,81,87,87,178,245,54,13,142,55,57,220,148,193,62,248,129,55,106,140,51,100,30,62,157,49,32,111,126,51,135,216,189,39,176,124,254,44,143,16,96,192,188,157,243,251,100,122,113,132,87,148,151,62,93,111,72,22,103,33,24,196,69,170,0,187,79,212,137,80,105,176,16,174,39,200,237,82,203,188,48,190,89,77,22,133,88,54,202,110,120,163,49,83,191,50,44,32,165,224,24,133,132,153,240,93,87,107,157,73,161,115,240,108,113,186,205,146,89,5,238,128,64,249,20,52,202,245,17,55,13,118,151,104,133,244,71,224,155,92,241,239,194,7,15,189,202,74,58,251,99,169,191,174,242,3,190,168,195,132,255,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("00441ee9-e8fb-46b4-abc5-67901fd82604"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess4",
				Position = new Point(35, 948),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 159),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("709502c2-eeb2-4297-bcf1-1e1ae8bb0c0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00441ee9-e8fb-46b4-abc5-67901fd82604"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"AddButtonClick_StartMessage",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5fe449be-135e-40af-a548-7dde521fa3b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00441ee9-e8fb-46b4-abc5-67901fd82604"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ProcessAddButtonClick_PrepareOpenColumnValuePage_ScriptTask",
				Position = new Point(120, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,79,189,10,194,64,12,222,5,223,161,116,210,197,23,16,7,57,68,110,144,118,176,174,114,244,62,164,120,77,75,146,243,249,189,182,40,14,98,221,242,229,251,75,138,30,100,186,16,91,186,184,16,81,186,27,174,149,128,207,78,238,155,34,145,96,75,162,142,106,88,159,237,178,23,168,172,223,46,23,197,47,119,26,76,100,6,233,190,214,230,49,178,41,65,57,98,206,58,160,106,236,251,144,28,124,163,3,49,223,108,66,39,56,65,100,106,204,191,132,140,18,159,255,115,72,233,216,181,80,176,164,172,35,244,189,147,21,197,16,214,41,131,161,145,105,122,237,9,102,114,125,217,82,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenColumnValuePage_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1f5bf5f8-2c9d-4b96-9b73-6e585bd382d8"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("00441ee9-e8fb-46b4-abc5-67901fd82604"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"OpenColumnValuePage_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 42),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenColumnValuePage_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess5",
				Position = new Point(35, 1109),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(508, 250),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("49c15664-1e76-4774-811e-3ae5ef01e7b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"DeleteButtonClick_StartMessage",
				Position = new Point(36, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareDeleteColumnQuestion_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a3d5a3c3-e8a4-4b3e-add7-fabb991ad1fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"PrepareDeleteColumnQuestion_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,49,14,130,64,16,69,107,247,20,155,173,137,23,64,45,20,10,10,65,4,10,42,67,200,132,16,113,214,236,204,70,9,225,238,178,145,130,88,72,245,139,121,239,101,2,232,128,225,164,59,251,192,212,2,113,171,241,86,16,152,188,162,251,246,82,53,32,247,210,141,47,130,191,232,25,136,38,44,135,55,79,198,146,157,47,107,129,168,214,56,153,42,45,194,44,143,146,88,173,9,71,203,172,145,156,83,134,89,156,172,10,87,160,231,36,192,252,144,51,17,94,50,104,107,199,85,166,223,17,155,22,27,79,126,247,32,7,177,25,84,15,164,60,169,150,237,18,104,142,168,209,115,12,234,95,36,214,11,98,244,133,48,192,214,160,100,99,193,255,0,238,81,166,209,118,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateDeleteColumnQuestion_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f9730e79-67a1-40dd-9570-25b410596f79"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"DeleteColumnQuestion_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 38),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeDeleteColumnQuestion_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateBreakDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4e466bc2-e302-4c6c-abe5-abadb9714416"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"BreakDelete_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 164),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("03d557e7-0950-46fa-8440-643c2ceff653"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("760dc067-efab-4038-a283-8170724113e0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("32917b1a-a752-4d11-a207-687c7faaa188"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess13",
				Position = new Point(36, 1532),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(377, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditValueButtonClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3761e734-99ce-4506-9956-262ffdeaf750"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32917b1a-a752-4d11-a207-687c7faaa188"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditValueButtonClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EditValueButtonClick_StartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessEditButtonClick_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("458a101b-3e49-47a0-987f-c76e7ae9939e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32917b1a-a752-4d11-a207-687c7faaa188"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ProcessEditButtonClick_ScriptTask",
				Position = new Point(133, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,75,196,48,16,133,207,22,250,31,194,158,118,47,101,239,139,130,20,89,122,80,23,108,189,136,72,104,222,74,49,59,149,153,137,23,241,191,155,196,42,123,240,144,75,72,102,222,251,222,36,233,25,216,243,228,238,102,7,67,105,185,52,20,188,223,213,213,116,52,235,131,125,69,211,206,62,156,232,209,250,0,233,23,125,243,0,143,81,145,141,18,37,129,212,92,153,237,198,124,214,213,197,2,42,116,63,109,159,99,220,151,169,43,120,65,6,48,52,48,153,163,141,133,212,171,171,251,119,208,141,155,244,12,151,240,47,131,128,123,43,111,77,18,128,59,18,181,52,162,115,49,255,247,48,116,110,87,64,136,155,54,48,131,244,122,212,233,35,119,35,69,57,160,196,158,78,67,206,61,147,36,71,106,148,77,208,250,89,112,11,145,159,228,213,63,160,44,113,171,210,129,14,150,237,9,10,150,200,219,67,255,106,178,78,159,180,137,156,229,173,243,53,191,1,52,7,145,0,15,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditColumnValuePage_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7d95a9f8-0338-4a22-aec8-a5b6c31a0339"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("32917b1a-a752-4d11-a207-687c7faaa188"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"OpenEditColumnValuePage_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(266, 35),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenEditColumnValuePage_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d6d4be0e-1d29-44cd-83cc-feb27ca277e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1361),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(231, 139),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteColumnYesMessage_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2189b114-663b-4279-b781-90461ebc6b17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6d4be0e-1d29-44cd-83cc-feb27ca277e8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteColumnYesMessage",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"DeleteColumnYesMessage_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteColumn_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3afc4a9c-a6e9-4bcc-8191-12ec0c58c218"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6d4be0e-1d29-44cd-83cc-feb27ca277e8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"DeleteColumn_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,106,195,48,16,68,207,49,248,31,150,156,108,40,250,129,214,189,196,144,67,105,49,117,218,75,200,97,145,55,177,64,150,202,74,54,53,165,255,222,141,221,130,114,237,73,32,102,102,223,204,132,12,218,219,113,112,239,104,71,10,80,193,91,32,222,121,231,72,71,227,157,106,41,4,121,107,140,120,220,37,74,145,68,250,140,79,52,159,0,3,212,102,145,35,207,15,33,178,113,151,59,104,216,107,49,183,186,167,1,27,100,28,40,18,47,238,199,251,60,51,103,40,110,79,87,224,70,107,75,248,202,179,13,83,28,217,65,228,145,68,251,157,103,103,207,132,186,135,98,18,100,231,59,2,227,160,193,11,169,148,234,192,68,123,54,157,96,91,41,64,221,139,40,195,26,121,53,10,130,160,196,94,122,94,51,212,234,58,110,159,127,255,183,39,117,240,237,82,160,40,229,240,38,37,84,175,52,248,137,138,191,144,114,37,251,199,96,213,205,232,18,83,155,240,97,113,78,245,203,253,116,134,31,86,244,62,73,172,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3e2fab41-cb18-4b89-8427-1482dc6c57eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess15",
				Position = new Point(421, 1534),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValuesTreeGridDblClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("844450b7-a2bf-4f8f-90fc-7eb15b6130af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3e2fab41-cb18-4b89-8427-1482dc6c57eb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ColumnValuesTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValuesTreeGridDblClick_StartMessage",
				Position = new Point(35, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ba187f53-116d-4347-898c-1e8a5347a8f4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3e2fab41-cb18-4b89-8427-1482dc6c57eb"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditValueButtonClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValuesTreeGridDblClick_EditValueButtonClick_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(168, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateColumnValueEditPageClosedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaColumnValueEditPageClosedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("58a7c3b1-eb58-464f-b00d-e6801d41cf54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValueEditPageClosedEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 948),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(224, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaColumnValueEditPageClosedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValueEditPageClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2edc2e5c-791f-4d6b-8a1a-49e3d3d15345"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58a7c3b1-eb58-464f-b00d-e6801d41cf54"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValueEditPageClosed",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValueEditPageClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnValueEditPageClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4d571fc2-ce5c-414b-b1b8-bb3d9f22885d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58a7c3b1-eb58-464f-b00d-e6801d41cf54"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ColumnValueEditPageClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,204,43,78,45,42,9,202,47,119,206,207,41,205,205,11,75,204,41,77,85,176,85,208,40,46,41,202,204,75,215,12,5,202,58,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,151,196,146,196,104,79,176,206,212,20,36,141,222,169,149,177,214,188,92,184,53,233,5,165,230,230,151,165,106,96,215,171,9,212,27,144,152,158,170,231,152,146,18,156,92,148,89,80,162,129,205,121,32,101,69,169,37,165,69,121,10,37,69,165,169,214,0,208,185,248,233,199,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess12",
				Position = new Point(35, 1708),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(544, 314),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClick_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("30acb4e5-62ab-456b-9b1f-e5b1e02fddbb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"OkButtonClick_StartMessage",
				Position = new Point(29, 144),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetProcessParams_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d70308a4-86b8-4788-b305-4350528e7570"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"SetProcessParams_ScriptTask",
				Position = new Point(351, 25),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,77,115,218,48,16,61,163,95,161,228,100,207,48,164,103,92,154,153,2,97,232,4,154,169,73,46,157,30,84,123,73,213,218,146,43,201,73,105,38,255,189,43,201,166,54,246,208,112,72,111,120,181,31,111,223,238,190,97,158,65,14,194,172,225,113,202,10,195,165,160,19,122,195,238,97,116,171,65,109,152,254,177,225,38,131,121,202,205,104,3,191,76,68,200,3,83,84,72,1,119,177,117,85,50,1,173,227,228,27,228,236,134,41,150,131,1,117,199,178,18,98,89,170,4,70,107,116,141,92,80,34,133,54,47,140,154,58,95,107,168,42,22,181,151,118,86,135,178,109,97,154,206,120,98,91,96,106,247,86,27,197,197,253,240,88,169,119,17,225,91,26,116,50,79,168,40,179,44,164,79,100,112,88,99,210,227,78,5,60,158,90,57,8,195,136,60,19,226,125,41,14,128,155,157,247,92,166,152,114,222,48,220,46,211,209,252,103,201,50,29,44,74,142,191,243,194,236,66,122,73,99,23,236,191,233,184,19,179,145,222,33,192,82,7,160,63,159,207,91,21,207,191,84,109,28,193,28,56,66,86,50,229,91,14,233,82,236,11,89,184,184,30,251,239,33,25,248,33,226,67,5,113,169,215,200,232,71,229,160,6,237,110,109,39,213,58,141,235,21,193,20,53,185,109,103,242,28,237,73,219,242,12,177,29,116,141,17,87,125,246,23,49,216,31,121,148,199,110,200,255,102,179,151,134,127,144,218,27,227,184,181,167,230,95,167,50,203,32,105,42,66,213,171,149,130,25,51,172,186,212,43,46,82,255,162,23,74,150,197,251,221,26,251,12,154,38,107,8,189,6,124,215,82,224,109,63,128,194,215,250,118,246,201,170,160,15,77,167,128,12,172,20,225,183,240,112,134,71,208,96,149,238,140,58,249,95,109,64,103,39,236,94,173,134,227,106,80,141,241,156,146,134,12,6,150,174,81,12,138,179,140,255,134,224,112,124,195,54,233,33,86,108,238,189,27,251,197,5,141,193,32,166,172,204,5,125,176,56,52,241,245,167,206,182,98,69,129,33,141,165,200,59,22,175,155,17,57,81,11,169,46,32,113,44,251,82,206,170,49,219,2,76,211,98,239,207,234,117,191,251,89,67,181,123,161,225,184,143,54,212,159,119,120,40,171,78,183,175,101,98,185,102,95,51,104,55,163,175,185,54,53,53,13,47,103,158,244,113,230,97,227,24,47,29,196,227,153,131,144,12,198,221,44,40,81,7,181,130,246,201,184,11,113,105,54,187,2,86,76,224,1,169,62,57,251,4,137,84,233,12,182,190,230,171,29,74,183,133,169,44,133,177,116,188,233,151,174,70,131,127,163,234,131,233,39,220,110,182,2,83,42,65,141,194,63,18,127,0,222,161,60,234,235,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateOkButtonClick_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a6c43bc3-9760-497a-8a63-55bf034caf3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"OkButtonClick_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(477, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckData_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("80b61b45-b018-470d-b296-fc1c4ab474e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"CheckData_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 130),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,75,196,48,16,133,207,45,244,63,196,61,181,151,254,1,241,176,214,186,20,164,46,43,120,149,177,157,236,134,77,147,50,147,184,22,241,191,219,52,133,245,32,66,8,33,188,55,223,123,211,240,3,56,120,5,173,250,183,22,47,7,123,17,119,194,145,199,219,44,149,150,16,186,147,200,63,128,196,8,138,132,50,98,135,174,178,218,15,102,246,120,228,188,40,196,87,150,38,74,138,156,29,41,115,44,27,110,189,214,207,84,15,163,155,242,224,43,23,109,188,87,125,210,252,5,150,160,57,144,147,228,125,70,159,195,235,59,75,231,147,165,13,63,42,237,144,246,64,48,112,132,87,150,8,59,119,77,28,82,236,225,136,229,182,239,163,252,128,236,181,171,123,229,202,234,132,221,25,251,200,15,149,228,162,224,217,190,120,162,97,145,134,104,47,214,83,23,126,205,58,138,119,100,253,120,63,181,48,96,190,185,170,55,69,200,249,127,190,155,149,53,47,103,107,166,39,148,174,254,28,9,153,149,53,191,183,21,70,45,117,9,157,39,19,123,253,0,119,168,242,72,164,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ec0375d0-6f55-4812-8405-3c14f1d97cce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 130),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateErrorMessage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("450b9fa1-be74-480d-90c9-97129333203f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("732a47f0-13c7-4ae0-b206-f1b6e91b3a05"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"ErrorMessage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 214),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,142,189,10,194,64,16,132,107,15,238,29,206,46,129,144,23,72,37,254,128,69,36,136,104,41,139,89,195,194,229,46,236,109,136,65,124,119,131,49,32,8,118,118,59,195,204,236,71,87,19,205,183,97,5,2,71,176,84,158,119,216,237,125,23,155,187,86,179,2,42,76,115,32,151,99,8,195,93,128,67,155,46,202,242,173,163,87,5,132,252,148,56,144,88,76,204,183,143,55,25,151,19,51,89,125,131,233,9,216,145,171,226,76,171,135,86,52,194,108,200,10,114,1,12,117,24,150,90,12,75,207,140,23,249,7,213,231,179,117,221,72,255,11,80,43,70,105,217,25,225,22,179,39,35,104,35,73,60,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9299ca48-de54-4a9d-90bb-85cd2ef8b375"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 2216),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(348, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInit_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a9ca98f7-e04e-45d0-94ce-f641c449ddf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9299ca48-de54-4a9d-90bb-85cd2ef8b375"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"Init_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInit_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1c6374ef-003c-46da-a052-d8622b16b90b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9299ca48-de54-4a9d-90bb-85cd2ef8b375"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"Init_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInit_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cec8505a-1aef-4bbd-9e46-48ac55b90354"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9299ca48-de54-4a9d-90bb-85cd2ef8b375"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"Init_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,110,219,48,16,60,219,64,254,129,245,73,66,5,253,64,18,3,174,172,164,6,218,66,136,237,244,80,244,192,136,43,155,49,77,42,75,42,137,16,228,223,187,20,21,63,226,246,86,160,232,73,212,62,102,103,150,203,157,229,186,217,2,242,59,5,23,215,141,20,99,86,243,114,195,87,48,19,150,93,178,5,32,114,107,42,151,102,6,33,45,130,207,166,223,13,110,44,69,194,210,73,37,157,36,211,53,184,222,253,89,18,32,150,235,150,48,162,165,5,204,140,214,80,58,105,116,194,174,164,22,83,176,114,165,65,20,104,74,176,118,94,174,97,203,163,248,13,126,57,19,201,217,112,112,156,185,47,153,206,68,124,126,54,52,119,247,228,249,241,147,133,67,113,72,123,175,33,205,184,117,23,33,100,76,37,22,102,66,138,218,200,35,60,114,220,71,94,73,229,0,41,87,195,19,155,202,174,38,199,246,194,58,148,122,149,244,85,198,236,133,152,13,94,70,165,217,214,28,165,53,122,209,214,48,242,186,124,126,118,100,78,243,135,134,171,215,36,164,40,168,92,254,92,35,41,38,236,204,168,102,171,11,238,214,148,60,154,183,182,23,48,122,11,111,44,76,165,173,21,111,111,185,106,124,137,138,43,11,111,110,148,171,245,1,92,193,145,111,129,24,116,193,118,148,156,180,229,245,181,151,12,207,14,180,160,4,208,238,223,170,206,15,152,252,53,221,94,201,110,54,94,66,110,167,189,160,62,164,185,118,210,181,97,226,114,33,93,90,32,16,119,248,98,204,166,169,251,118,124,188,100,2,20,172,184,3,22,5,44,102,137,41,96,194,66,160,79,205,31,137,246,4,87,150,65,220,53,200,55,183,234,16,252,12,66,26,208,44,149,30,244,230,116,34,68,244,110,228,226,247,254,211,251,241,33,59,5,193,244,95,235,200,16,136,82,152,133,112,111,183,180,41,188,87,86,44,250,64,99,145,206,236,228,158,63,223,192,3,57,93,160,213,169,247,75,97,193,237,102,33,157,130,78,248,130,234,16,205,92,193,150,10,125,131,167,140,215,126,140,61,157,176,104,190,26,1,153,226,214,210,111,137,178,118,6,169,47,187,227,37,139,254,24,23,239,143,30,143,100,40,90,90,53,160,107,167,220,241,185,105,176,132,40,124,146,3,208,174,25,221,126,57,137,246,245,110,37,58,122,35,123,99,124,138,234,17,78,179,211,57,184,76,73,127,99,244,88,31,225,198,60,69,187,98,2,170,208,206,78,211,233,107,62,218,183,199,47,103,76,74,43,222,40,23,0,60,226,39,218,212,190,195,6,109,68,203,189,63,122,43,129,69,113,242,27,109,201,158,66,119,215,103,67,4,215,160,102,14,27,56,255,5,183,114,249,175,108,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2b0677f3-b22c-4ce4-9e26-4627378027a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b3dd3b8-41bb-4885-b9e9-3707334405d1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 2043),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(494, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadComplete_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2834a381-a6ec-49d5-ae19-5099a0a0c768"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b0677f3-b22c-4ce4-9e26-4627378027a1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"PageLoadComplete_StartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadComplete_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("cb0efeb1-52ee-478e-9621-8d1b5fcdd327"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b0677f3-b22c-4ce4-9e26-4627378027a1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"PageLoadComplete_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetDefValues_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0625fbfa-cd59-4b71-9347-77d1dfed062e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b0677f3-b22c-4ce4-9e26-4627378027a1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"SetDefValues_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,77,111,219,48,12,61,167,64,255,131,150,147,3,4,218,15,232,86,96,205,71,209,109,237,138,166,235,14,69,15,154,205,36,222,28,201,144,228,116,94,145,255,62,138,114,18,89,113,186,237,226,32,18,249,248,248,72,81,90,11,205,76,186,132,149,96,239,217,52,151,217,24,76,190,144,144,221,106,149,130,49,51,218,75,6,103,167,39,183,98,1,124,154,23,22,244,36,203,45,159,129,109,27,121,28,103,122,122,178,70,220,82,104,177,2,52,55,136,61,134,185,168,10,251,32,138,10,12,19,134,141,243,212,230,74,10,93,191,51,86,231,114,49,100,45,184,219,173,55,185,156,19,106,62,103,73,136,250,158,201,170,40,6,236,229,244,164,167,193,86,90,50,171,43,64,219,141,51,247,184,12,164,205,109,237,81,175,50,228,178,135,120,236,79,90,155,253,39,78,225,206,124,172,55,30,129,95,153,27,140,243,69,79,86,165,173,147,54,222,192,135,15,113,190,82,20,9,207,236,178,202,179,216,30,177,123,78,158,112,185,49,191,7,173,133,81,115,203,71,74,206,243,69,165,133,211,136,63,60,207,106,211,98,42,191,41,253,211,148,34,133,228,171,1,141,230,18,72,207,8,30,55,176,86,184,110,154,16,29,178,171,239,63,208,247,60,241,137,244,94,88,31,19,232,15,89,156,210,102,216,108,35,153,93,120,180,107,19,224,187,45,126,149,145,203,198,81,114,114,134,25,243,41,216,116,57,213,106,53,190,72,98,174,141,166,45,81,71,162,116,123,152,70,11,166,89,118,33,122,212,161,161,207,182,79,169,166,31,100,118,15,191,108,18,165,213,206,179,129,35,21,55,237,54,154,251,214,127,173,153,166,29,38,255,212,82,93,216,141,8,135,152,81,123,117,250,118,53,217,181,144,40,144,70,223,168,98,147,67,163,46,255,43,11,171,72,254,198,154,95,130,117,187,23,53,114,75,58,25,19,163,112,132,252,173,76,113,100,78,181,58,88,13,11,22,192,143,133,21,51,85,105,236,194,80,180,78,106,212,59,189,30,126,91,149,54,81,113,247,144,30,197,4,149,237,253,173,180,187,150,118,162,254,48,74,162,252,107,208,150,202,65,231,50,70,255,24,26,37,68,177,93,54,156,151,209,68,222,99,144,28,20,203,135,31,169,162,240,94,24,206,33,115,156,243,160,115,81,228,191,97,75,113,200,108,93,130,154,39,49,151,189,247,96,200,136,137,99,252,57,55,246,93,139,229,57,123,137,114,219,12,104,212,31,197,35,154,78,187,3,154,111,194,217,30,166,226,50,189,212,170,42,49,147,238,130,187,107,172,17,145,12,47,234,27,44,226,65,8,238,86,189,80,1,133,61,124,196,224,72,119,141,42,173,177,41,103,120,239,164,120,1,109,45,12,191,131,149,90,67,140,218,196,219,208,247,63,17,63,100,217,65,18,30,111,227,167,213,17,192,207,74,100,59,180,228,224,32,54,135,111,239,144,116,194,12,182,183,42,237,34,151,47,18,238,212,51,185,143,150,144,254,4,119,192,254,125,186,157,237,145,124,168,59,48,248,64,136,240,254,99,92,34,224,29,164,74,103,136,120,173,50,24,45,133,92,64,150,248,7,201,219,183,44,104,121,150,170,162,90,73,182,166,231,200,233,201,136,254,250,199,9,118,175,197,1,244,9,106,140,239,38,44,191,129,103,154,180,3,126,175,102,196,135,64,93,79,166,129,227,241,27,246,181,135,141,127,91,29,55,96,72,26,136,116,54,122,136,103,146,79,24,223,86,158,65,255,169,185,101,218,62,173,78,158,52,119,173,227,125,45,202,18,9,6,199,46,93,227,159,221,164,120,213,54,28,33,20,190,29,149,250,108,174,112,37,93,178,164,3,137,174,147,116,205,242,86,212,230,184,133,186,62,166,107,222,120,130,69,117,236,242,9,185,225,226,110,250,250,155,58,186,213,102,40,40,254,186,14,126,236,174,47,193,4,59,8,53,206,77,89,136,58,180,167,2,133,175,203,63,230,0,234,98,52,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateAddNotNullColumns_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2e6e7a88-bf5e-404e-ac5c-e85a1a56fbb0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b0677f3-b22c-4ce4-9e26-4627378027a1"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Name = @"AddNotNullColumns_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(386, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,204,203,44,113,47,202,76,9,207,44,201,240,203,47,241,43,205,201,113,206,207,41,205,205,43,214,208,180,230,226,42,74,45,41,45,202,83,40,41,42,77,181,6,0,36,201,91,236,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIsEntitySchemaChangedMethod());
			Methods.Add(CreateGetSerializedFiltersMethod());
			Methods.Add(CreateClearControlValuesMethod());
			Methods.Add(CreateClearControlFilterValuesMethod());
			Methods.Add(CreateGetSchemaCaptionMethod());
			Methods.Add(CreateCreateColumnValuesVdsMethod());
			Methods.Add(CreateGetColumnValuesVdsMethod());
			Methods.Add(CreateGetColumnValuesMethod());
			Methods.Add(CreateRecordAddModeChangedMethod());
			Methods.Add(CreateDisplayColumnValuesMethod());
			Methods.Add(CreateGetPageParamsMethod());
			Methods.Add(CreateGetNotNullColumnIdListMethod());
			Methods.Add(CreateInitGridWithNotNullColumnsMethod());
			Methods.Add(CreateGetEntityIdBySysSchemaInWorkspaceMethod());
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
				UId = new Guid("fde88d12-4e3b-4ec7-b0da-657ef90bcf81"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ff51e0ba-f656-4962-97fd-432bbead6707"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dd4632d2-d984-47c7-ae03-ab24a8c2a352"),
				Name = "Terrasoft.Configuration.VwSysEntitySchemaInWorkspace",
				Alias = "VwSysEntitySchemaInWorkspace",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("728c89e1-8ea8-423e-b8e6-bf9a63fb5a2c"),
				Name = "Terrasoft.Configuration.VwSysPageSchemaInWorkspace",
				Alias = "VwSysPageSchemaInWorkspace",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fc68a00f-d1d1-4be6-b31e-368e70f75b1f"),
				Name = "Terrasoft.Core.Process",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("76ae6123-c67d-4336-acd2-71993a720ca1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7776095a-2607-4417-a154-15086dbbc033"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa9e14dd-9184-44fc-a692-58bb720193fb"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("568a5dd3-ca8b-4c5e-baa6-5708bd17ad12")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,41,84,115,113,86,43,185,230,149,100,150,84,6,39,103,164,230,38,122,166,40,233,40,4,36,166,167,234,33,139,186,166,100,150,212,234,128,212,186,101,230,148,164,22,97,215,129,41,7,214,199,85,107,13,0,205,128,36,179,170,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateBindEditorsMethod() {
			SchemaMethod method = base.CreateBindEditorsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,93,111,218,48,24,133,175,225,87,88,189,105,34,85,110,175,135,170,169,144,182,66,219,24,82,214,238,98,218,133,107,191,128,85,199,182,252,1,141,42,254,251,108,39,80,10,97,69,234,101,222,143,199,231,28,59,51,101,128,208,5,202,150,196,32,238,160,66,92,162,39,46,25,151,243,31,68,231,232,181,223,179,206,132,47,36,73,5,232,58,13,225,111,80,15,250,189,184,67,149,240,149,12,117,109,148,6,227,234,130,56,82,42,111,40,224,2,102,165,51,158,58,111,0,143,210,160,197,119,1,62,172,39,1,150,69,98,30,56,124,134,178,132,125,36,194,3,226,22,77,141,162,96,109,73,23,80,145,41,49,97,208,129,73,237,91,198,93,146,149,142,215,7,61,101,54,34,27,26,249,144,22,20,244,186,56,248,205,74,183,191,104,226,232,114,227,247,97,204,194,110,19,18,14,31,113,124,74,230,128,111,24,43,169,225,218,101,77,188,248,78,153,138,184,236,236,245,106,141,237,66,173,66,250,58,212,127,135,184,212,170,228,115,73,196,164,185,129,243,114,191,125,62,56,187,232,140,2,143,4,7,233,198,69,30,115,94,35,16,22,82,118,217,251,132,30,198,35,37,157,81,34,222,15,8,150,159,236,253,67,208,241,28,226,253,45,211,226,53,98,48,75,12,251,39,62,138,191,13,48,14,29,190,141,239,74,61,123,253,246,12,18,135,71,124,155,228,216,78,188,16,63,205,109,165,93,157,165,19,114,244,21,221,123,206,112,170,161,47,72,194,42,21,218,246,96,195,113,240,226,58,228,20,220,106,65,234,173,170,125,219,59,154,112,9,46,213,111,36,251,21,104,25,103,23,9,219,28,114,121,249,159,213,199,54,141,207,25,105,175,249,48,185,209,2,232,243,80,189,12,137,133,54,187,61,49,239,38,182,114,150,27,219,71,201,19,95,61,129,217,185,147,61,238,78,255,68,147,87,193,91,1,148,87,68,224,240,203,90,56,197,96,148,125,92,196,182,219,97,44,252,28,253,245,63,160,176,239,6,13,5,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,140,49,10,194,64,16,0,235,8,254,97,203,164,217,7,24,68,36,92,145,38,90,92,176,94,113,13,135,151,187,99,119,37,250,123,137,96,107,53,205,204,212,103,154,24,143,90,86,2,41,120,22,33,205,119,195,177,199,11,95,187,156,76,114,84,92,133,6,59,42,22,114,130,61,168,73,72,19,246,58,60,99,60,137,155,139,189,235,239,109,84,22,79,250,240,193,34,187,91,48,244,252,178,6,14,219,77,229,34,207,156,108,224,229,119,218,193,159,168,173,62,118,75,78,144,161,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntitySchemaChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e5ff5e5f-d1ff-4076-993f-df3d0e278b9a"),
				Name = "IsEntitySchemaChanged",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,116,205,43,201,44,169,12,78,206,72,205,77,12,245,76,209,115,45,44,77,204,41,214,112,47,205,4,178,115,11,74,42,53,21,212,212,112,42,3,171,211,12,72,76,79,213,67,86,225,154,146,89,162,23,150,152,83,154,170,105,13,0,78,20,20,102,105,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSerializedFiltersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e737f921-9a56-424f-94fe-ef1cd697bdaf"),
				Name = "GetSerializedFilters",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,77,79,132,48,16,134,207,244,87,244,8,155,13,120,39,122,16,113,163,49,198,72,214,123,3,179,107,13,180,235,116,202,6,205,254,119,203,135,10,201,178,209,232,113,190,158,121,59,125,107,129,124,35,75,2,52,252,156,63,136,45,132,215,93,152,22,146,194,43,65,34,211,22,243,54,171,138,190,98,86,168,237,238,178,185,23,21,248,227,84,155,8,98,86,59,228,139,209,42,209,170,6,116,85,7,86,176,231,223,176,97,232,118,220,228,175,13,160,139,20,228,36,181,90,158,208,50,236,64,48,182,36,7,55,132,82,109,195,180,218,81,19,51,185,225,254,120,86,145,164,38,203,159,161,18,29,231,73,148,22,194,244,213,138,210,248,43,43,139,126,48,8,248,59,243,190,152,173,182,48,3,148,162,148,111,224,15,39,90,78,31,230,132,28,24,2,89,84,131,154,152,69,139,95,136,27,221,183,87,184,190,41,230,165,77,246,28,88,20,29,39,221,105,81,60,234,189,241,131,216,59,177,48,177,136,160,40,35,180,185,35,127,118,152,48,209,86,17,191,224,103,221,218,122,206,32,63,65,181,166,153,55,138,247,255,78,153,152,228,239,191,233,177,69,244,1,195,208,69,181,34,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("badb76ee-08ac-43b4-92fb-87b542999dda"),
				Name = "ClearControlValues",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,193,74,3,49,16,134,207,205,83,164,183,45,200,190,64,187,5,217,173,23,145,134,45,122,31,146,233,110,112,54,41,147,137,186,136,239,110,90,69,138,8,94,231,255,152,255,155,49,48,96,125,235,220,62,96,31,95,119,206,75,221,142,104,159,209,233,70,11,103,92,43,243,141,220,121,18,228,30,83,38,249,5,30,129,82,33,123,180,145,93,65,31,162,195,118,132,48,160,171,86,107,245,2,172,109,164,60,133,39,160,140,169,141,65,240,77,238,113,62,96,74,62,134,14,4,116,163,22,143,9,185,132,1,173,148,105,125,149,214,38,158,54,157,191,204,129,231,77,18,246,97,184,209,134,163,45,212,193,142,56,129,1,134,9,139,228,165,102,187,173,218,63,75,139,145,63,234,234,127,163,101,163,67,38,90,233,119,181,232,124,58,17,204,215,27,207,167,125,168,150,16,206,210,194,145,190,94,244,147,126,2,88,136,25,246,93,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearControlFilterValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("039f34d4-8cc0-4a37-8250-5d0859c28f52"),
				Name = "ClearControlFilterValues",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,193,78,195,48,12,134,207,237,83,100,183,86,66,121,129,50,36,216,6,7,4,170,84,177,11,226,96,82,111,139,148,37,197,73,6,21,218,187,147,164,155,90,46,72,236,16,69,178,127,127,246,239,164,134,45,242,123,169,28,210,170,149,142,175,52,188,43,108,217,156,109,64,89,172,242,252,0,196,140,106,7,141,13,137,122,44,89,130,131,198,120,18,200,23,158,8,181,107,28,121,225,60,157,21,54,220,186,189,235,159,97,143,197,41,244,64,198,119,49,80,50,176,108,100,12,233,133,81,10,133,147,70,87,185,220,176,98,210,123,54,103,218,43,85,178,239,60,27,195,124,161,16,168,40,171,252,152,167,138,23,27,41,90,15,20,222,160,181,225,142,125,94,3,220,239,245,26,148,71,27,36,14,191,220,35,246,111,191,200,209,240,33,41,130,217,11,88,209,147,76,114,160,254,218,58,146,122,123,197,106,50,34,20,55,98,135,123,168,129,130,253,48,124,170,190,169,134,166,34,250,88,159,59,107,252,252,47,39,238,32,219,24,66,16,187,34,18,59,144,196,164,62,217,73,238,178,184,161,89,76,240,84,196,79,239,183,250,240,225,193,139,63,240,103,161,118,210,245,79,208,117,97,158,114,96,102,147,209,249,109,219,22,137,31,182,113,197,198,78,113,184,236,152,229,233,92,176,215,249,116,65,129,181,148,182,83,208,79,229,233,19,252,0,120,248,70,70,211,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3e812ace-9b1f-472c-b353-2f69667abd24"),
				Name = "GetSchemaCaption",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("006ac5fb-c663-4d88-8e1f-9ff09032bf74"),
				Name = "id",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ebacca1d-2f96-4ad5-8a89-860c54415f28"),
				Name = "CreateColumnValuesVds",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,77,111,194,48,12,61,175,191,34,234,169,72,83,249,1,136,195,70,37,214,3,19,82,89,239,94,99,88,164,52,69,73,202,96,19,255,125,78,90,209,143,113,3,113,105,147,103,251,61,63,199,7,208,236,192,13,155,51,133,223,44,23,218,214,32,19,176,144,85,181,46,48,154,176,223,224,41,77,40,30,46,42,89,151,42,7,89,163,201,185,9,131,243,44,88,195,14,99,247,89,84,202,130,80,168,99,119,210,149,52,241,11,231,17,81,79,102,65,48,157,178,12,173,23,74,57,219,86,154,21,32,81,113,18,183,26,145,237,180,224,13,87,95,100,67,161,37,69,226,174,31,170,158,59,154,56,77,136,182,195,51,171,235,194,214,26,93,176,187,52,185,9,110,47,16,85,245,51,226,181,22,37,232,83,35,251,14,165,171,9,83,30,206,174,166,37,194,236,37,140,178,221,63,116,188,228,102,87,11,158,28,44,193,31,6,53,141,66,97,97,69,165,188,5,239,106,115,218,227,10,20,121,213,241,18,109,170,140,5,85,224,235,201,209,68,225,146,8,66,26,153,35,43,225,152,137,31,220,224,209,222,196,185,234,120,28,245,208,25,189,82,99,39,114,11,112,101,162,109,212,47,66,111,64,207,180,22,38,23,70,124,74,7,109,65,26,244,216,155,224,8,99,48,171,180,29,129,131,238,9,111,71,23,156,239,211,226,10,45,172,193,126,221,191,209,225,179,220,171,95,191,69,164,182,128,189,123,92,130,218,83,147,220,94,70,102,136,240,159,151,11,214,179,210,98,143,113,226,21,134,86,60,244,80,35,127,10,86,92,39,216,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7c0cec2f-2776-43f1-96b2-2a8c8f8b8de0"),
				Name = "GetColumnValuesVds",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,199,49,10,128,48,12,5,208,171,148,78,186,244,2,142,21,103,65,232,254,209,32,133,152,64,154,220,95,186,60,120,70,30,38,233,196,75,101,82,85,28,93,200,202,209,229,153,51,229,37,87,229,248,164,129,131,70,123,70,94,19,70,106,221,60,192,59,28,151,134,221,180,253,42,16,51,176,78,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c99083be-2496-4369-b4b1-e7d6d7bab33d"),
				Name = "GetColumnValues",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,140,49,10,2,49,16,69,107,115,138,41,21,196,11,172,107,179,219,217,44,44,107,35,22,67,24,53,144,76,96,102,2,46,226,221,13,193,19,88,125,30,188,247,195,29,182,139,146,12,153,153,188,133,204,135,153,84,235,142,104,120,29,114,44,137,47,24,11,105,85,140,94,118,166,245,6,125,15,92,98,220,193,219,109,132,172,8,55,238,220,199,185,31,255,241,138,10,99,104,58,202,122,84,147,192,143,61,76,146,125,141,103,255,164,132,19,10,38,50,146,86,159,58,247,5,19,29,251,86,193,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRecordAddModeChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3ca3aca9-b4c2-4a29-97a0-71ff08029133"),
				Name = "RecordAddModeChanged",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,208,207,10,130,64,16,199,241,115,62,197,228,201,160,214,7,144,14,97,214,85,52,186,79,187,163,46,109,91,173,179,144,68,239,222,63,130,188,88,247,207,124,249,49,57,214,36,86,218,48,185,204,178,230,174,148,13,29,48,83,154,69,102,113,103,72,193,28,242,167,90,40,245,134,5,181,222,240,139,164,13,201,61,169,36,200,7,58,5,157,189,118,127,134,226,24,100,131,182,38,168,190,106,48,3,115,172,181,12,116,5,209,248,87,101,2,215,81,48,26,154,84,18,111,209,120,90,88,181,161,11,71,107,175,149,200,14,39,238,166,16,134,147,164,127,221,127,70,133,166,165,190,88,34,99,121,244,78,146,72,189,115,100,185,100,231,37,123,247,17,173,72,13,161,139,30,233,219,29,209,106,69,130,116,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5351ccde-1393-4639-8efc-793843df80d3"),
				Name = "DisplayColumnValues",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,149,219,78,227,48,16,134,175,65,226,29,172,94,165,18,142,146,212,57,9,138,148,35,170,88,88,180,28,238,77,98,32,218,196,169,28,135,170,2,222,125,29,187,44,9,13,199,155,86,113,102,190,127,102,236,63,126,192,12,60,228,13,152,131,99,194,163,186,108,43,122,141,203,150,52,215,121,163,77,15,246,118,197,75,61,42,9,102,242,41,46,50,94,212,20,179,245,97,195,89,65,239,246,193,57,171,51,210,52,23,217,61,169,240,57,102,184,34,156,48,9,57,2,89,143,184,173,33,145,197,45,208,134,97,115,64,219,178,156,130,199,189,221,29,70,120,203,168,8,123,222,142,212,163,186,165,188,139,55,192,211,19,72,40,47,248,90,213,113,181,200,187,245,227,182,200,245,164,90,242,181,162,117,205,252,170,113,254,167,94,41,241,1,191,15,0,164,255,48,7,87,13,97,81,77,41,145,253,235,253,208,83,76,241,29,97,186,104,110,65,27,142,105,70,194,181,40,64,123,83,144,156,31,230,88,22,127,185,94,146,77,34,200,199,22,183,36,199,82,5,113,145,208,182,34,12,223,148,228,112,44,100,193,73,117,52,148,232,150,186,221,24,211,149,93,116,239,213,230,139,211,81,214,245,223,118,57,64,203,233,2,74,86,114,192,218,228,49,180,124,219,112,205,20,186,73,224,67,68,28,11,122,177,25,64,223,244,195,116,230,206,172,52,181,158,39,47,68,161,75,46,139,138,124,204,140,45,51,241,147,20,193,200,112,16,68,134,105,193,208,242,28,152,6,102,224,153,174,25,7,8,13,153,31,243,28,99,22,35,223,49,160,200,183,32,178,137,47,120,51,11,90,134,19,216,8,89,102,104,152,175,60,254,105,125,6,138,34,215,118,67,232,165,134,3,145,103,101,208,19,104,104,68,70,210,149,103,33,211,120,229,137,115,91,179,79,26,14,210,80,204,208,135,73,226,167,98,136,198,13,12,80,236,194,153,27,4,166,237,123,174,105,219,10,120,91,51,130,179,123,160,157,144,181,228,157,227,130,125,219,144,160,160,3,127,42,139,168,67,11,88,189,18,213,73,243,11,45,78,132,99,54,134,169,87,250,197,192,198,218,100,145,79,246,149,215,206,200,74,118,51,125,55,246,148,112,81,20,191,23,25,61,113,93,116,34,83,250,158,81,121,155,48,81,77,223,146,221,57,237,71,133,235,23,176,54,134,29,171,228,76,12,230,127,21,122,132,151,157,205,100,180,154,36,200,139,102,89,98,53,97,33,223,231,170,223,184,23,208,229,189,126,160,244,237,173,158,191,227,36,53,246,157,111,139,61,3,82,54,98,19,63,214,124,207,107,157,228,142,248,104,126,146,250,131,180,49,231,124,33,109,212,32,63,158,205,102,51,212,70,234,139,230,76,92,40,191,153,188,9,180,62,109,250,85,133,1,122,236,52,201,63,113,156,6,244,131,205,157,19,228,185,38,146,166,234,158,121,115,11,253,3,126,60,133,79,131,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPageParamsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("79132acd-5fe1-4609-9577-2c0d7f9e782c"),
				Name = "GetPageParams",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0d362250-1885-43c3-87bd-9477989ceb17"),
				Name = "node",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "TreeGridNode",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,109,107,219,48,16,254,156,64,254,131,226,15,69,102,193,127,160,219,96,164,89,48,107,67,104,178,125,25,163,104,214,37,17,200,82,43,157,230,153,210,255,62,201,178,93,215,73,25,24,191,156,239,185,231,185,231,78,185,178,96,16,248,82,75,87,170,31,76,58,248,6,53,249,68,54,172,4,242,129,36,15,137,191,175,157,224,217,6,170,240,164,105,182,215,59,52,66,29,105,122,61,155,254,97,134,24,176,78,162,71,41,168,200,141,40,80,104,197,76,253,209,54,105,11,18,159,159,105,74,158,103,211,201,51,73,108,113,130,146,229,60,89,144,149,66,129,245,174,9,124,207,249,160,56,121,89,76,38,147,8,120,52,186,0,107,119,3,28,23,248,14,42,66,74,166,216,17,76,104,228,77,250,221,107,188,207,45,180,66,248,139,190,117,159,58,240,194,46,251,31,125,46,26,128,181,17,188,81,177,245,165,178,33,96,223,254,205,150,82,128,194,252,166,199,137,214,234,123,93,69,158,252,178,247,93,62,120,197,43,9,101,168,210,53,220,126,143,59,158,77,95,252,36,196,129,208,249,87,33,17,204,216,212,213,147,99,210,210,102,142,171,242,17,235,148,196,89,196,201,101,95,56,167,201,161,129,14,44,190,92,235,149,56,140,223,115,207,166,191,181,150,68,216,216,200,61,60,57,97,128,251,117,56,120,82,104,149,41,205,129,204,253,138,56,41,207,185,141,174,26,202,144,149,69,39,127,38,62,242,107,68,247,6,84,2,178,45,195,211,24,119,215,197,207,208,254,138,251,26,37,70,193,57,183,94,235,26,112,163,113,227,213,117,209,91,97,177,89,241,6,211,145,133,45,255,47,89,203,21,252,38,69,91,46,196,46,120,212,204,100,111,234,45,51,22,104,199,178,32,218,97,15,77,201,213,213,185,232,44,44,39,243,107,69,251,188,110,32,67,151,10,166,150,39,166,142,16,129,222,44,58,31,235,24,158,105,255,122,171,43,48,209,50,3,232,140,106,79,248,245,63,166,16,213,227,47,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotNullColumnIdListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("888505f3-d2f8-49b6-9a30-7da216735601"),
				Name = "GetNotNullColumnIdList",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,205,170,194,48,16,133,215,201,83,196,141,164,155,188,64,175,130,127,104,193,11,23,69,247,67,58,213,64,59,197,73,226,165,136,239,110,212,34,117,57,231,59,124,7,230,10,172,24,125,172,131,154,40,194,127,181,117,62,252,172,163,43,167,58,203,229,53,97,164,224,66,183,183,103,108,32,149,14,30,121,209,18,161,13,174,37,179,26,208,95,32,56,33,155,53,134,130,124,0,178,56,239,14,69,169,135,165,116,39,113,213,50,130,61,235,231,128,109,235,216,144,114,244,53,101,22,175,216,103,234,38,133,171,148,30,125,209,63,118,13,112,247,46,153,36,53,171,75,132,218,107,251,73,50,37,133,16,227,113,63,96,10,191,156,239,240,18,29,99,147,92,61,28,245,116,3,126,137,213,17,234,136,175,73,241,126,139,153,149,229,208,153,75,113,151,119,41,25,67,100,234,127,151,63,0,201,24,6,46,71,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitGridWithNotNullColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c23be994-ac33-4894-a947-1f01d0630310"),
				Name = "InitGridWithNotNullColumns",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,65,107,2,49,16,133,207,43,248,31,166,23,201,130,44,189,183,122,89,69,164,173,8,214,94,196,67,88,199,26,216,77,182,201,100,219,165,250,223,59,155,221,138,90,232,41,33,243,101,222,123,147,84,210,66,102,114,95,232,55,153,123,116,48,130,25,82,122,113,34,226,135,126,175,223,83,123,16,226,138,188,27,129,246,121,14,131,193,85,135,36,53,94,19,140,225,62,238,247,162,232,120,132,169,38,69,245,42,59,96,33,215,243,93,50,253,240,50,119,98,230,21,239,139,146,234,56,134,111,102,45,146,183,154,213,78,141,224,141,43,141,159,48,81,25,41,163,165,173,31,29,89,165,223,135,176,180,38,67,231,218,230,75,105,101,129,132,54,220,26,7,231,123,99,81,102,7,81,157,131,206,119,160,116,147,114,97,104,193,1,210,238,244,89,57,18,157,149,64,87,157,108,235,191,197,94,100,89,178,240,156,176,16,45,26,157,131,49,126,19,117,216,212,187,139,72,236,143,14,12,253,218,72,94,205,42,196,16,113,0,131,235,78,243,159,92,162,153,235,137,163,69,151,35,218,100,85,114,173,180,109,164,170,36,148,219,161,174,29,218,212,104,141,97,140,201,138,5,120,157,72,146,155,203,23,103,132,240,139,158,176,222,158,221,182,21,110,51,81,174,204,101,253,231,135,252,0,16,9,251,190,73,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntityIdBySysSchemaInWorkspaceMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5910185e-48f6-4dfd-b079-a2e16d5e4ef8"),
				Name = "GetEntityIdBySysSchemaInWorkspace",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8bd13cec-ebd6-41e1-a0a5-288c0834da51"),
				Name = "sysSchamaInWorkspaceId",
				CreatedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				ModifiedInSchemaUId = new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,75,107,194,64,20,133,215,6,242,31,110,93,200,204,102,164,72,145,250,232,162,90,37,43,11,70,93,95,146,27,13,77,102,210,59,51,74,40,253,239,29,177,88,10,217,156,213,121,124,156,51,50,48,89,95,57,152,195,218,151,185,122,171,27,215,78,227,8,134,195,116,179,220,76,224,113,252,52,122,30,197,209,57,88,109,107,183,217,137,106,76,244,193,240,135,109,48,163,16,212,116,129,148,152,209,154,194,169,133,97,10,162,139,242,232,25,93,105,180,218,95,182,29,73,241,142,71,82,59,75,28,220,154,178,171,85,246,194,118,89,128,120,184,109,225,191,68,18,248,62,61,86,86,252,177,74,24,12,58,193,212,138,92,118,90,177,169,151,175,162,187,77,74,248,138,163,222,253,129,206,154,53,185,180,109,40,95,152,202,215,122,143,149,167,217,117,254,69,244,119,73,222,151,1,248,59,142,152,156,103,253,123,230,244,7,3,148,123,117,88,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddDataUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f8ee8ec-7014-41b7-8c31-fa49c19bd2ec"));
		}

		#endregion

	}

	#endregion

}

