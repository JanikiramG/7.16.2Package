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

	#region Class: ChangeDataUserTaskParametersEditPageSchema

	/// <exclude/>
	public class ChangeDataUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout3;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return _controlLayout3;
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

		private Terrasoft.UI.WebControls.Controls.CheckBox _isMatchConditionsEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsMatchConditionsEdit {
			get {
				return _isMatchConditionsEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _filterControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return _filterControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.FilterEdit _filterEdit;
		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return _filterEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _columnsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ColumnsControlLayout {
			get {
				return _columnsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayoutColumns;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutColumns {
			get {
				return _controlLayoutColumns;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return _buttonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addButton;
		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return _addButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _editButton;
		public Terrasoft.UI.WebControls.Controls.Button EditButton {
			get {
				return _editButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return _deleteButton;
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

		public ChangeDataUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ChangeDataUserTaskParametersEditPageSchema(ChangeDataUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			RealUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			Name = "ChangeDataUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 500;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChangeDataUserTaskParametersEditPageEventsProcessSchema();
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
			TopControlLayout.InsertItem(0, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateUserTaskTitleEdit());
			ControlLayout3.InsertItem(1, CreateObjectEdit());
			ControlLayout3.InsertItem(2, CreateIsMatchConditionsEdit());
			TopControlLayout.InsertItem(1, CreateFilterControlLayout());
			FilterControlLayout.InsertItem(0, CreateFilterEdit());
			TopControlLayout.InsertItem(2, CreateColumnsControlLayout());
			ColumnsControlLayout.InsertItem(0, CreateControlLayoutColumns());
			ControlLayoutColumns.InsertItem(0, CreateButtonsControlLayout());
			ButtonsControlLayout.InsertItem(0, CreateAddButton());
			ButtonsControlLayout.InsertItem(1, CreateEditButton());
			ButtonsControlLayout.InsertItem(2, CreateDeleteButton());
			ControlLayoutColumns.InsertItem(1, CreateColumnValuesTreeGrid());
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

		protected virtual EmbeddedProcessSchema CreateChangeDataUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new ChangeDataUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("7b574b70-3204-4765-bb6a-75a82da8e7e6");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateObjectEdit() {
			_objectEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_objectEdit.UId = new Guid("65a0a0ee-4e41-4577-8aaa-9c1c6f4a48f5");
			_objectEdit.Name = "ObjectEdit";
			_objectEdit.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_objectEdit.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
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

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsMatchConditionsEdit() {
			_isMatchConditionsEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isMatchConditionsEdit.UId = new Guid("8072c5f6-03f5-468d-9c60-4cba8b3323ad");
			_isMatchConditionsEdit.Name = "IsMatchConditionsEdit";
			_isMatchConditionsEdit.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_isMatchConditionsEdit.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_isMatchConditionsEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_isMatchConditionsEdit.AjaxEvents.Check.IsProcessEventHandler = true;
			_isMatchConditionsEdit.Tag = "";
			_isMatchConditionsEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isMatchConditionsEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isMatchConditionsEdit.AlignedByCaption = false;
			_isMatchConditionsEdit.Hidden = true;
			return _isMatchConditionsEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("ac4f1a55-10de-4b8e-8427-05eb93a14178");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_controlLayout3.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_controlLayout3.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.FitHeightByContent = true;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("5cb963b3-1a65-4575-ae16-809146ac997c");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_filterEdit.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
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
			_filterControlLayout.UId = new Guid("5f8a7fad-84d7-4d9c-9236-cb8cbdf137e8");
			_filterControlLayout.Name = "FilterControlLayout";
			_filterControlLayout.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_filterControlLayout.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_filterControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_filterControlLayout.Tag = "";
			_filterControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(130);
			_filterControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterControlLayout.Padding = "0 0 0 15";
			_filterControlLayout.StartNewAlignGroup = false;
			_filterControlLayout.Image = new ControlImage {};
			_filterControlLayout.Edges = "";
			_filterControlLayout.Enabled = false;
			return _filterControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("5b8f708a-433b-4e60-bd87-4ecb6bc6a28d");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_addButton.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_addButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditButton() {
			_editButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editButton.UId = new Guid("ec9023ea-a5ae-4b06-a5dd-d37dd10d795f");
			_editButton.Name = "EditButton";
			_editButton.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_editButton.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_editButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_editButton.Tag = "";
			_editButton.Image = new ControlImage {};
			return _editButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("ce7a67b1-22a5-4c09-87d8-6d4a8fc06a03");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_deleteButton.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_deleteButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_deleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonsControlLayout() {
			_buttonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonsControlLayout.UId = new Guid("53f39806-d876-44c9-b042-5e5101ef46de");
			_buttonsControlLayout.Name = "ButtonsControlLayout";
			_buttonsControlLayout.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_buttonsControlLayout.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_buttonsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonsControlLayout.Tag = "";
			_buttonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_buttonsControlLayout.FitHeightByContent = true;
			_buttonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonsControlLayout.StartNewAlignGroup = false;
			_buttonsControlLayout.Image = new ControlImage {};
			_buttonsControlLayout.Edges = "";
			return _buttonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateColumnValuesTreeGrid() {
			_columnValuesTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_columnValuesTreeGrid.UId = new Guid("fb939237-91e3-498d-a42c-a0d365595c28");
			_columnValuesTreeGrid.Name = "ColumnValuesTreeGrid";
			_columnValuesTreeGrid.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_columnValuesTreeGrid.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_columnValuesTreeGrid.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnValuesTreeGrid.Tag = "";
			_columnValuesTreeGrid.Edges = "0 1 1 1";
			_columnValuesTreeGrid.IsColumnAutowidth = true;
			_columnValuesTreeGrid.FooterVisible = false;
			_columnValuesTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnValuesTreeGrid.IsSummaryVisible = false;
			_columnValuesTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnValuesTreeGrid.HideHeaders = false;
			return _columnValuesTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutColumns() {
			_controlLayoutColumns = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutColumns.UId = new Guid("7d11c990-b23e-4f55-9aa4-46c3b155a6ff");
			_controlLayoutColumns.Name = "ControlLayoutColumns";
			_controlLayoutColumns.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_controlLayoutColumns.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_controlLayoutColumns.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayoutColumns.Tag = "";
			_controlLayoutColumns.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutColumns.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutColumns.StartNewAlignGroup = false;
			_controlLayoutColumns.Image = new ControlImage {};
			_controlLayoutColumns.Edges = "";
			return _controlLayoutColumns;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateColumnsControlLayout() {
			_columnsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_columnsControlLayout.UId = new Guid("17770a0e-78d9-48a6-b620-cfaca6c64cc7");
			_columnsControlLayout.Name = "ColumnsControlLayout";
			_columnsControlLayout.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_columnsControlLayout.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_columnsControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnsControlLayout.Tag = "";
			_columnsControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_columnsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnsControlLayout.Padding = "0 0 0 15";
			_columnsControlLayout.StartNewAlignGroup = false;
			_columnsControlLayout.Image = new ControlImage {};
			_columnsControlLayout.Edges = "";
			return _columnsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("fe36046d-6196-4a09-b9c2-454cc04d400a");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_entityDataSource.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_entityDataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("1ee16746-0366-42ee-b5e5-d956109d5ce8");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
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
			return new ChangeDataUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ChangeDataUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ChangeDataUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeDataUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ChangeDataUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ChangeDataUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: ChangeSchemaEntityUserMessageFlowElement

		/// <exclude/>
		public class ChangeSchemaEntityUserMessageFlowElement : QuestionUserTask
		{

			public ChangeSchemaEntityUserMessageFlowElement(UserConnection userConnection, ChangeDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeSchemaEntityUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenColumnPageOnAddFlowElement

		/// <exclude/>
		public class OpenColumnPageOnAddFlowElement : OpenPageUserTask
		{

			public OpenColumnPageOnAddFlowElement(UserConnection userConnection, ChangeDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenColumnPageOnAdd";
				IsLogging = false;
				SchemaElementUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenColumnPageOnEditFlowElement

		/// <exclude/>
		public class OpenColumnPageOnEditFlowElement : OpenPageUserTask
		{

			public OpenColumnPageOnEditFlowElement(UserConnection userConnection, ChangeDataUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenColumnPageOnEdit";
				IsLogging = false;
				SchemaElementUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ChangeDataUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeDataUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
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
				return _virtualDataSourceID ?? (_virtualDataSourceID = new LocalizableString(Storage, "7110cdfde1334075aeea1112c8b841bd",
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

		public virtual string ColumnValuesContextKey {
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

		private ProcessFlowElement _eventSubProcessIsMatchConditionsEditCheck;
		public ProcessFlowElement EventSubProcessIsMatchConditionsEditCheck {
			get {
				return _eventSubProcessIsMatchConditionsEditCheck ?? (_eventSubProcessIsMatchConditionsEditCheck = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessIsMatchConditionsEditCheck",
					SchemaElementUId = new Guid("fef0770e-54f7-4b9c-bad4-ded16d81be23"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _isMatchConditionsEditCheckStartMessage;
		public ProcessFlowElement IsMatchConditionsEditCheckStartMessage {
			get {
				return _isMatchConditionsEditCheckStartMessage ?? (_isMatchConditionsEditCheckStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IsMatchConditionsEditCheckStartMessage",
					SchemaElementUId = new Guid("387757dd-1b4e-4d58-8be3-edbb95d5d09f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isMatchConditionsEditCheckScript;
		public ProcessScriptTask IsMatchConditionsEditCheckScript {
			get {
				return _isMatchConditionsEditCheckScript ?? (_isMatchConditionsEditCheckScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsMatchConditionsEditCheckScript",
					SchemaElementUId = new Guid("737f571b-5137-4ea3-9ec7-b56f4af6ce34"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsMatchConditionsEditCheckScriptExecute,
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
					SchemaElementUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
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
					SchemaElementUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
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

		private ProcessScriptTask _scriptTaskPrepareChangeSchemaEntityQuestion;
		public ProcessScriptTask ScriptTaskPrepareChangeSchemaEntityQuestion {
			get {
				return _scriptTaskPrepareChangeSchemaEntityQuestion ?? (_scriptTaskPrepareChangeSchemaEntityQuestion = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPrepareChangeSchemaEntityQuestion",
					SchemaElementUId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPrepareChangeSchemaEntityQuestionExecute,
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
					SchemaElementUId = new Guid("8574bc6f-d9d4-40c9-af8e-e74c0e88e3ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
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
					SchemaElementUId = new Guid("89dbe425-7207-4802-ab4f-24e87aba772e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("f47a446b-bb12-4fda-94a4-ce01729700c4"),
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
					SchemaElementUId = new Guid("4d884aac-887d-41da-b6e0-7232b8ae062d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEntitySchemaEditNotChangeExecute,
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
					SchemaElementUId = new Guid("6e13d9b4-f5c5-4e0c-8ebb-e2bdf6759d01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("6c557ccf-583c-4f11-b2ea-1c97b6067400"),
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
					SchemaElementUId = new Guid("0feee0b1-e83b-4faf-8350-54801f9b72cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEntitySchemaEditChangeExecute,
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
					SchemaElementUId = new Guid("e9f91717-c48b-4ac1-808b-b7b9e753fcee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessAddButtonClick;
		public ProcessFlowElement EventSubProcessAddButtonClick {
			get {
				return _eventSubProcessAddButtonClick ?? (_eventSubProcessAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessAddButtonClick",
					SchemaElementUId = new Guid("3a0d8cea-9efb-4e57-a299-dc34bffc4649"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAddButtonClick;
		public ProcessFlowElement StartMessageAddButtonClick {
			get {
				return _startMessageAddButtonClick ?? (_startMessageAddButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAddButtonClick",
					SchemaElementUId = new Guid("def9bf49-e2a7-4587-b99d-c54ed837ad5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAddButtonClick;
		public ProcessScriptTask ScriptAddButtonClick {
			get {
				return _scriptAddButtonClick ?? (_scriptAddButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAddButtonClick",
					SchemaElementUId = new Guid("9f84ea93-2403-4903-adc2-23a962fefc48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAddButtonClickExecute,
				});
			}
		}

		private OpenColumnPageOnAddFlowElement _openColumnPageOnAdd;
		public OpenColumnPageOnAddFlowElement OpenColumnPageOnAdd {
			get {
				return _openColumnPageOnAdd ?? (_openColumnPageOnAdd = new OpenColumnPageOnAddFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcessDeleteButtonClick;
		public ProcessFlowElement EventSubProcessDeleteButtonClick {
			get {
				return _eventSubProcessDeleteButtonClick ?? (_eventSubProcessDeleteButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessDeleteButtonClick",
					SchemaElementUId = new Guid("5dc6bd6b-ef42-4bd5-ae09-300676d70e8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageDeleteButtonClick;
		public ProcessFlowElement StartMessageDeleteButtonClick {
			get {
				return _startMessageDeleteButtonClick ?? (_startMessageDeleteButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageDeleteButtonClick",
					SchemaElementUId = new Guid("2c2506a1-d719-4971-b1f6-83fe9cb7e5a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptDeleteButtonClick;
		public ProcessScriptTask ScriptDeleteButtonClick {
			get {
				return _scriptDeleteButtonClick ?? (_scriptDeleteButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptDeleteButtonClick",
					SchemaElementUId = new Guid("984c9da9-bf25-4318-ad66-95016ac895e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptDeleteButtonClickExecute,
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
					SchemaElementUId = new Guid("6fe72715-e811-44e7-a6d6-fd1acf5088e6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _editButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent EditButtonClickIntermediateThrowMessageEvent {
			get {
				return _editButtonClickIntermediateThrowMessageEvent ?? (_editButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "EditButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("556035f6-caa4-46e0-b0e9-34dd547856e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditButtonClick",
				});
			}
		}

		private ProcessFlowElement _columnValuesTreeGridDblClickStartMessage;
		public ProcessFlowElement ColumnValuesTreeGridDblClickStartMessage {
			get {
				return _columnValuesTreeGridDblClickStartMessage ?? (_columnValuesTreeGridDblClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValuesTreeGridDblClickStartMessage",
					SchemaElementUId = new Guid("8a2ba162-5aeb-485f-9fb7-d84b2ba4f453"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("c84f1a39-a569-4995-8e89-c5e4e74bd157"),
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
					SchemaElementUId = new Guid("90786533-b6d1-4e73-aede-512610dd85e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _editButtonClickScriptTask;
		public ProcessScriptTask EditButtonClickScriptTask {
			get {
				return _editButtonClickScriptTask ?? (_editButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EditButtonClickScriptTask",
					SchemaElementUId = new Guid("4cc9dea1-a415-4289-90ec-3b254f12bed9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EditButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenColumnPageOnEditFlowElement _openColumnPageOnEdit;
		public OpenColumnPageOnEditFlowElement OpenColumnPageOnEdit {
			get {
				return _openColumnPageOnEdit ?? (_openColumnPageOnEdit = new OpenColumnPageOnEditFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("d51b0478-d6b6-4503-8e09-5cdf4b5c07f8"),
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
					SchemaElementUId = new Guid("18e0966e-b381-4917-82a7-d4477261ecbb"),
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
					SchemaElementUId = new Guid("1094876f-3a0d-4388-821a-4c9da5469f54"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnValueEditPageClosedScriptTaskExecute,
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
					SchemaElementUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent4;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent4 {
			get {
				return _intermediateThrowMessageEvent4 ?? (_intermediateThrowMessageEvent4 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent4",
					SchemaElementUId = new Guid("48917043-bf45-4abc-aad0-547d6cdf6fd4"),
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
					SchemaElementUId = new Guid("58baff93-00a9-424d-a289-47e8c2547238"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildOkButtonClickExecute,
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
					SchemaElementUId = new Guid("7d258006-43fb-45c3-98a2-789fb80b68e2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("627fd35a-02a4-4607-aa50-904e2a79929a"),
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
					SchemaElementUId = new Guid("f9ad24c7-c53e-4c20-a156-f8c11ee7a075"),
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
					SchemaElementUId = new Guid("491d0ce8-a016-42e9-b8a4-67e59897da93"),
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
					SchemaElementUId = new Guid("4a0dc41f-4c3f-45ee-ac9f-d9ea8fa161cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInitStartMessage;
		public ProcessFlowElement ChildInitStartMessage {
			get {
				return _childInitStartMessage ?? (_childInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInitStartMessage",
					SchemaElementUId = new Guid("eceb9e93-95ac-4c4b-ad38-be8c6f356c7f"),
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
					SchemaElementUId = new Guid("9e3b34ac-45b6-40ba-9c98-c8f1d849a10a"),
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
					SchemaElementUId = new Guid("b15aa5a6-4cf9-432c-a357-5be0baba8feb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
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
					SchemaElementUId = new Guid("139b99c2-dce1-45c4-a009-f96c23ebda28"),
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
					SchemaElementUId = new Guid("c5d620f7-5a4f-49c2-aee5-ed865cd83205"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("5fc49db8-3a33-484c-9f23-45ea5715ad01"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteChildScriptExecute,
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
					SchemaElementUId = new Guid("fb772206-b438-4c4f-9171-260b9bdaed47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow177;
		public ProcessConditionalFlow ConditionalFlow177 {
			get {
				return _conditionalFlow177 ?? (_conditionalFlow177 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow177",
					SchemaElementUId = new Guid("214f8d7c-10f2-4e02-917e-a7247935b9a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
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
					SchemaElementUId = new Guid("4028b0db-6bd5-4f17-b0d1-d11823646103"),
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessIsMatchConditionsEditCheck.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessIsMatchConditionsEditCheck };
			FlowElements[IsMatchConditionsEditCheckStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IsMatchConditionsEditCheckStartMessage };
			FlowElements[IsMatchConditionsEditCheckScript.SchemaElementUId] = new Collection<ProcessFlowElement> { IsMatchConditionsEditCheckScript };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ScriptTaskPrepareChangeSchemaEntityQuestion.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPrepareChangeSchemaEntityQuestion };
			FlowElements[ChangeSchemaEntityUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityUserMessage };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[EntitySchemaEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChangeStartMessage };
			FlowElements[EventSubProcessChangeSchemaEntityNoMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeSchemaEntityNoMessage };
			FlowElements[ScriptEntitySchemaEditNotChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEntitySchemaEditNotChange };
			FlowElements[ChangeSchemaEntityNoMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageBase };
			FlowElements[EventSubProcessChangeSchemaEntityYesMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChangeSchemaEntityYesMessage };
			FlowElements[ScriptEntitySchemaEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEntitySchemaEditChange };
			FlowElements[ChangeSchemaEntityYesMessageBase.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageBase };
			FlowElements[EventSubProcessAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessAddButtonClick };
			FlowElements[StartMessageAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAddButtonClick };
			FlowElements[ScriptAddButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAddButtonClick };
			FlowElements[OpenColumnPageOnAdd.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnPageOnAdd };
			FlowElements[EventSubProcessDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessDeleteButtonClick };
			FlowElements[StartMessageDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageDeleteButtonClick };
			FlowElements[ScriptDeleteButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptDeleteButtonClick };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[EditButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickIntermediateThrowMessageEvent };
			FlowElements[ColumnValuesTreeGridDblClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClickStartMessage };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[EditButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickScriptTask };
			FlowElements[OpenColumnPageOnEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnPageOnEdit };
			FlowElements[ColumnValueEditPageClosedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedEventSubProcess };
			FlowElements[ColumnValueEditPageClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedStartMessage };
			FlowElements[ColumnValueEditPageClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedScriptTask };
			FlowElements[OkButtonClickChildSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickChildSubProcess };
			FlowElements[IntermediateThrowMessageEvent4.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent4 };
			FlowElements[ScriptChildOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildOkButtonClick };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[CheckData_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckData_ScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ErrorMessage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorMessage_ScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[ChildInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitStartMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteChildScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChildScript };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessIsMatchConditionsEditCheck":
						break;
					case "IsMatchConditionsEditCheckStartMessage":
						e.Context.QueueTasks.Enqueue("IsMatchConditionsEditCheckScript");
						break;
					case "IsMatchConditionsEditCheckScript":
						break;
					case "EventSubProcess4":
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow177ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTaskPrepareChangeSchemaEntityQuestion");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "ScriptTaskPrepareChangeSchemaEntityQuestion":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityUserMessage");
						break;
					case "ChangeSchemaEntityUserMessage":
						break;
					case "IntermediateThrowMessageEvent3":
						break;
					case "EntitySchemaEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "EventSubProcessChangeSchemaEntityNoMessage":
						break;
					case "ScriptEntitySchemaEditNotChange":
						break;
					case "ChangeSchemaEntityNoMessageBase":
						e.Context.QueueTasks.Enqueue("ScriptEntitySchemaEditNotChange");
						break;
					case "EventSubProcessChangeSchemaEntityYesMessage":
						break;
					case "ScriptEntitySchemaEditChange":
						break;
					case "ChangeSchemaEntityYesMessageBase":
						e.Context.QueueTasks.Enqueue("ScriptEntitySchemaEditChange");
						break;
					case "EventSubProcessAddButtonClick":
						break;
					case "StartMessageAddButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptAddButtonClick");
						break;
					case "ScriptAddButtonClick":
						e.Context.QueueTasks.Enqueue("OpenColumnPageOnAdd");
						break;
					case "OpenColumnPageOnAdd":
						break;
					case "EventSubProcessDeleteButtonClick":
						break;
					case "StartMessageDeleteButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptDeleteButtonClick");
						break;
					case "ScriptDeleteButtonClick":
						break;
					case "EventSubProcess2":
						break;
					case "EditButtonClickIntermediateThrowMessageEvent":
						break;
					case "ColumnValuesTreeGridDblClickStartMessage":
						e.Context.QueueTasks.Enqueue("EditButtonClickIntermediateThrowMessageEvent");
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("EditButtonClickScriptTask");
						break;
					case "EditButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenColumnPageOnEdit");
						break;
					case "OpenColumnPageOnEdit":
						break;
					case "ColumnValueEditPageClosedEventSubProcess":
						break;
					case "ColumnValueEditPageClosedStartMessage":
						e.Context.QueueTasks.Enqueue("ColumnValueEditPageClosedScriptTask");
						break;
					case "ColumnValueEditPageClosedScriptTask":
						break;
					case "OkButtonClickChildSubProcess":
						break;
					case "IntermediateThrowMessageEvent4":
						break;
					case "ScriptChildOkButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent4");
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("CheckData_ScriptTask");
						break;
					case "CheckData_ScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptChildOkButtonClick");
							break;
						}
						e.Context.QueueTasks.Enqueue("ErrorMessage_ScriptTask");
						break;
					case "ErrorMessage_ScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "ChildInitStartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						break;
					case "EventSubProcess5":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "PageLoadCompleteChildScript":
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteChildScript");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow177ExpressionExecute() {
			return Convert.ToBoolean(EntitySchemaUId != Guid.Empty && (Guid)Page.ObjectEdit.Value != EntitySchemaUId);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsFilterParamsValuesCorrect);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("IsMatchConditionsEditCheckStartMessage");
			ActivatedEventElements.Add("EntitySchemaEditChangeStartMessage");
			ActivatedEventElements.Add("ChangeSchemaEntityNoMessageBase");
			ActivatedEventElements.Add("ChangeSchemaEntityYesMessageBase");
			ActivatedEventElements.Add("StartMessageAddButtonClick");
			ActivatedEventElements.Add("StartMessageDeleteButtonClick");
			ActivatedEventElements.Add("ColumnValuesTreeGridDblClickStartMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("ColumnValueEditPageClosedStartMessage");
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("ChildInitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessIsMatchConditionsEditCheck":
					context.QueueTasks.Dequeue();
					break;
				case "IsMatchConditionsEditCheckStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsMatchConditionsEditCheckStartMessage";
					result = IsMatchConditionsEditCheckStartMessage.Execute(context);
					break;
				case "IsMatchConditionsEditCheckScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsMatchConditionsEditCheckScript";
					result = IsMatchConditionsEditCheckScript.Execute(context, IsMatchConditionsEditCheckScriptExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ScriptTaskPrepareChangeSchemaEntityQuestion":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPrepareChangeSchemaEntityQuestion";
					result = ScriptTaskPrepareChangeSchemaEntityQuestion.Execute(context, ScriptTaskPrepareChangeSchemaEntityQuestionExecute);
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
				case "EntitySchemaEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaEditChangeStartMessage";
					result = EntitySchemaEditChangeStartMessage.Execute(context);
					break;
				case "EventSubProcessChangeSchemaEntityNoMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptEntitySchemaEditNotChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEntitySchemaEditNotChange";
					result = ScriptEntitySchemaEditNotChange.Execute(context, ScriptEntitySchemaEditNotChangeExecute);
					break;
				case "ChangeSchemaEntityNoMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageBase";
					result = ChangeSchemaEntityNoMessageBase.Execute(context);
					break;
				case "EventSubProcessChangeSchemaEntityYesMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptEntitySchemaEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEntitySchemaEditChange";
					result = ScriptEntitySchemaEditChange.Execute(context, ScriptEntitySchemaEditChangeExecute);
					break;
				case "ChangeSchemaEntityYesMessageBase":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageBase";
					result = ChangeSchemaEntityYesMessageBase.Execute(context);
					break;
				case "EventSubProcessAddButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAddButtonClick";
					result = StartMessageAddButtonClick.Execute(context);
					break;
				case "ScriptAddButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAddButtonClick";
					result = ScriptAddButtonClick.Execute(context, ScriptAddButtonClickExecute);
					break;
				case "OpenColumnPageOnAdd":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnPageOnAdd";
					result = OpenColumnPageOnAdd.Execute(context);
					break;
				case "EventSubProcessDeleteButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageDeleteButtonClick";
					result = StartMessageDeleteButtonClick.Execute(context);
					break;
				case "ScriptDeleteButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptDeleteButtonClick";
					result = ScriptDeleteButtonClick.Execute(context, ScriptDeleteButtonClickExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "EditButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = EditButtonClickIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ColumnValuesTreeGridDblClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValuesTreeGridDblClickStartMessage";
					result = ColumnValuesTreeGridDblClickStartMessage.Execute(context);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "EditButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClickScriptTask";
					result = EditButtonClickScriptTask.Execute(context, EditButtonClickScriptTaskExecute);
					break;
				case "OpenColumnPageOnEdit":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnPageOnEdit";
					result = OpenColumnPageOnEdit.Execute(context);
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
				case "OkButtonClickChildSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "IntermediateThrowMessageEvent4":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEvent4.Execute(context);
					break;
				case "ScriptChildOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildOkButtonClick";
					result = ScriptChildOkButtonClick.Execute(context, ScriptChildOkButtonClickExecute);
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
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
				case "ChildInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitStartMessage";
					result = ChildInitStartMessage.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteChildScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChildScript";
					result = PageLoadCompleteChildScript.Execute(context, PageLoadCompleteChildScriptExecute);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent2.Execute(context);
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
				case "ColumnValuesContextKey":
					ColumnValuesContextKey = reader.GetValue<System.String>();
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

		public virtual bool IsMatchConditionsEditCheckScriptExecute(ProcessExecutingContext context) {
			EnableFilterEdit();
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

		public virtual bool ScriptEntitySchemaEditNotChangeExecute(ProcessExecutingContext context) {
			Page.ObjectEdit.SuspendAjaxEvents();
			Page.ObjectEdit.SetValueAndText(EntitySchemaUId, Page.EntityDataSource.Schema.Caption.ToString());
			Page.ObjectEdit.ResumeAjaxEvents();
			return true;
		}

		public virtual bool ScriptEntitySchemaEditChangeExecute(ProcessExecutingContext context) {
			EntitySchemaUId = (new Select(UserConnection)
				.Column("UId")
				.From("SysSchema")
				.Where("Id")
				.IsEqual(Column.Parameter((Guid)Page.ObjectEdit.Value)) as Select)
				.ExecuteScalar<Guid>();
			Page.EntityDataSource.SchemaUId = EntitySchemaUId;
			Page.IsMatchConditionsEdit.Checked = Guid.Empty != EntitySchemaUId;
			ResetControlValues();
			Page.FilterEdit.SetDataSource(Page.EntityDataSource);
			Page.EntityDataSource.LoadStructure();
			return true;
		}

		public virtual bool ScriptAddButtonClickExecute(ProcessExecutingContext context) {
			OpenColumnPageOnAdd.OpenerInstanceId = InstanceUId;
			OpenColumnPageOnAdd.UseCurrentActivePage = true;
			OpenColumnPageOnAdd.PageUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			OpenColumnPageOnAdd.CloseMessage = "ColumnValueEditPageClosed";
			InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			OpenColumnPageOnAdd.PageParameters =
				new Dictionary<string, string>() {
						{ "schemaId", EntitySchemaUId.ToString() },
						{ "processSchemaId", EditSchemaUId.ToString() },
						{ "managerName", EditSchemaManagerName },
						{ "contextKey", ColumnValuesContextKey },
						{ "treeGridId", Page.ColumnValuesTreeGrid.ClientID },
						{ "canChangeColumn", true.ToString().ToLower() },
						{ "insertedRowKey", InsertedColumnValueKey },
						{ "editElementId", EditElementUId.ToString() }
					};
			return true;
		}

		public virtual bool ScriptDeleteButtonClickExecute(ProcessExecutingContext context) {
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

		public virtual bool EditButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			TreeGridNode node = null;
			if (Page.ColumnValuesTreeGrid.SelectedNodes.Count != 0) {
				node = Page.ColumnValuesTreeGrid.SelectedNodes[0];
			} else {
				return false;
			}
			OpenColumnPageOnEdit.OpenerInstanceId = InstanceUId;
			OpenColumnPageOnEdit.UseCurrentActivePage = true;
			OpenColumnPageOnEdit.PageUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			OpenColumnPageOnEdit.CloseMessage = "ColumnValueEditPageClosed";
			InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			OpenColumnPageOnEdit.PageParameters =
				new Dictionary<string, string>() {
						{ "schemaId", EntitySchemaUId.ToString() },
						{ "processSchemaId", EditSchemaUId.ToString() },
						{ "managerName", EditSchemaManagerName },
						{ "contextKey", ColumnValuesContextKey },
						{ "treeGridId", Page.ColumnValuesTreeGrid.ClientID },
						{ "rowId", node.Values["Id"].ToString() },
						{ "metaPath", node.Values["MetaPath"].ToString() },
						{ "canChangeColumn", true.ToString().ToLower() },
						{ "insertedRowKey", InsertedColumnValueKey },
						{ "editElementId", EditElementUId.ToString() }
					};
			
			return true;
		}

		public virtual bool ColumnValueEditPageClosedScriptTaskExecute(ProcessExecutingContext context) {
			var insertRowColumnValue = (string)UserConnection.SessionData[InsertedColumnValueKey];
			UserConnection.SessionData.Remove(InsertedColumnValueKey);
			Page.AddScript(insertRowColumnValue);
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
			// Serealize datasource filter instead of ESQ one because we need to rebuild
			// it when reopen page for this element.
			// Obtain ESQ filter from serealized datasource filter for this element on runtime
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = Page.IsMatchConditionsEdit.Checked ? constVS : noneVS,
				Value = Page.IsMatchConditionsEdit.Checked ? 
					Json.Serialize(filterCollection, jsonConverter) : String.Empty
			};
			// Set object schema value
			string objectSchemaId = EntitySchemaUId == Guid.Empty ? String.Empty : EntitySchemaUId.ToString();
			parametersValue["EntitySchemaUId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = String.IsNullOrEmpty(objectSchemaId) ? noneVS : constVS,
				Value = objectSchemaId
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
			parametersValue["RecordColumnValues"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = mappingCollection.Count == 0 ? noneVS : constVS,
				LocalizableCollectionValue = mappingLocalizableList
			};
			return true;
		}

		public virtual bool CheckData_ScriptTaskExecute(ProcessExecutingContext context) {
			var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			if (filters.Count == 0){
				IsFilterParamsValuesCorrect = false;
			} else {
				IsFilterParamsValuesCorrect = !filters.IsAnyLeftExpressionNullOrEmpty();
			}
			return true;
		}

		public virtual bool ErrorMessage_ScriptTaskExecute(ProcessExecutingContext context) {
			Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessage, MessageType.Warning);
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
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
			CreateColumnValuesVds();
			if (!Ext.IsAjaxRequest) {
				var defValues = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
				Page.UserTaskTitleEdit.Text = ElementNewCaption;
				SetDefaultValue(defValues["IsMatchConditions"], false.ToString(), string.Empty, "IsMatchConditions");
				DefaultValues = defValues;
				var descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			}
			return true;
		}

		public virtual bool PageLoadCompleteChildScriptExecute(ProcessExecutingContext context) {
			var schema = FindDesignedProcessSchema();
			Page.FilterEdit.SetProcessSchema(schema);
			
			var parameters = DefaultValues as Dictionary<string, ProcessSchemaParameterValue>;
			if (parameters == null) {
				return true;
			}
			// Deserialize filters
			string entitySchemaId = parameters["EntitySchemaUId"].Value;
			if (!String.IsNullOrEmpty(entitySchemaId)) {
				EntitySchemaUId = new Guid(entitySchemaId);
				Page.EntityDataSource.SchemaUId = EntitySchemaUId;
				Page.ObjectEdit.SetValueAndText(EntitySchemaUId, Page.EntityDataSource.Schema.Caption);
				
				string filters = parameters["DataSourceFilters"].Value;
				if (!String.IsNullOrEmpty(filters)) {
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
			}
			EnableControls();
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Checked;
			
			// Deserialize column values
			ColumnValuesContextKey = Guid.NewGuid().ToString();
			var columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			ProcessSchemaParameterValue serealizedCVs = parameters["RecordColumnValues"];
			if (serealizedCVs != null) {
				var cvColection = EntityColumnMappingCollection.DeserializeValue(serealizedCVs);
				foreach (var cv in cvColection) {
					columnValues[cv.ColumnMetaPath] = cv.Value;
				}
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
			return true;
		}

		public override Dictionary<string, Terrasoft.UI.WebControls.WebControl> GetEditorsBinding() {
			return new Dictionary<string, Terrasoft.UI.WebControls.WebControl> {
			{"IsMatchConditions", Page.IsMatchConditionsEdit}
			};
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				string.Format("{0} ({1})", WindowCaption, NewRecord) : Page.UserTaskTitleEdit.Text;
		}

		public virtual bool IsEntitySchemaUIdEmpty() {
			bool result = Page.EntityDataSource.SchemaUId == Guid.Empty;
			Page.FilterControlLayout.Enabled = !result;
			Page.IsMatchConditionsEdit.Checked = !result;
			return result;
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

		public virtual Dictionary<string, ProcessSchemaParameterValue> GetColumnValues() {
			//var userContext = UserConnection.UserContext;
			object sessiobDataValue = UserConnection.SessionData[ColumnValuesContextKey];
			if (sessiobDataValue == null) {
				return null;
			}
			return sessiobDataValue as Dictionary<string, ProcessSchemaParameterValue>;
		}

		public virtual void DisplayColumnValues() {
			var vds = Page.PageContainer.FindControl("ColumnValuesVds") as VirtualDataSource;
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

		public virtual void ResetControlValues() {
			//Page.IsMatchConditionsEdit.SuspendAjaxEvents();
			//Page.IsMatchConditionsEdit.Checked = false;
			EnableFilterEdit();
			var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(Page.FilterEdit.FilterEditGroupName);
			filterEditGroup.Clear();
			//Page.IsMatchConditionsEdit.ResumeAjaxEvents();
			(Page.PageContainer.FindControl("ColumnValuesVds") as VirtualDataSource).Clear();
			GetColumnValues().Clear();
			EnableControls();
		}

		public virtual void EnableFilterEdit() {
			Page.FilterControlLayout.Enabled = Page.IsMatchConditionsEdit.Checked;
			Page.FilterEdit.Enabled = Page.IsMatchConditionsEdit.Checked;
		}

		public virtual void EnableControls() {
			if (EntitySchemaUId.Equals(Guid.Empty)) {
				Page.IsMatchConditionsEdit.Checked = false;
				Page.IsMatchConditionsEdit.Enabled = 
					Page.AddButton.Enabled = 
					Page.EditButton.Enabled = 
					Page.DeleteButton.Enabled = false;
			} else {
				Page.IsMatchConditionsEdit.Enabled = 
					Page.AddButton.Enabled = 
					Page.EditButton.Enabled = 
					Page.DeleteButton.Enabled = true;
			}
			EnableFilterEdit();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "IsMatchConditionsEditCheck":
							if (ActivatedEventElements.Contains("IsMatchConditionsEditCheckStartMessage")) {
							context.QueueTasks.Enqueue("IsMatchConditionsEditCheckStartMessage");
						}
						break;
					case "ObjectEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("EntitySchemaEditChangeStartMessage");
						}
						break;
					case "ChangeSchemaEntityNoMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityNoMessageBase")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageBase");
						}
						break;
					case "ChangeSchemaEntityYesMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityYesMessageBase")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageBase");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("StartMessageAddButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageAddButtonClick");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("StartMessageDeleteButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageDeleteButtonClick");
						}
						break;
					case "ColumnValuesTreeGridDblClick":
							if (ActivatedEventElements.Contains("ColumnValuesTreeGridDblClickStartMessage")) {
							context.QueueTasks.Enqueue("ColumnValuesTreeGridDblClickStartMessage");
						}
						break;
					case "EditButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "ColumnValueEditPageClosed":
							if (ActivatedEventElements.Contains("ColumnValueEditPageClosedStartMessage")) {
							context.QueueTasks.Enqueue("ColumnValueEditPageClosedStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInitStartMessage")) {
							context.QueueTasks.Enqueue("ChildInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
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
			if (!HasMapping("ColumnValuesContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnValuesContextKey", ColumnValuesContextKey, null);
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

	#region Class: ChangeDataUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ChangeDataUserTaskParametersEditPageEventsProcess : ChangeDataUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.ChangeDataUserTaskParametersEditPageSchemaUserControl>
	{

		public ChangeDataUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeDataUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class ChangeDataUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout3 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout3", true);
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

		public Terrasoft.UI.WebControls.Controls.CheckBox IsMatchConditionsEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsMatchConditionsEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout FilterControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("FilterControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.FilterEdit FilterEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.FilterEdit)PageContainer.FindPageControl("FilterEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ColumnsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ColumnsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutColumns {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayoutColumns", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button EditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("EditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteButton", true);
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
			ObjectEdit.AjaxEvents.Change.Event += ObjectEditChange;
			IsMatchConditionsEdit.AjaxEvents.Check.Event += IsMatchConditionsEditCheck;
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			EditButton.AjaxEvents.Click.Event += EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ObjectEdit.AjaxEvents.Change.Event -= ObjectEditChange;
			IsMatchConditionsEdit.AjaxEvents.Check.Event -= IsMatchConditionsEditCheck;
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			EditButton.AjaxEvents.Click.Event -= EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ChangeDataUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ChangeDataUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void IsMatchConditionsEditCheck(object sender, EventArgs e) {
			object result = ThrowEvent("IsMatchConditionsEditCheck");
		}

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void EditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditButtonClick");
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
			SchemaName = "ChangeDataUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ChangeDataUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class ChangeDataUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ChangeDataUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChangeDataUserTaskParametersEditPageEventsProcessSchema(ChangeDataUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeDataUserTaskParametersEditPageEventsProcess";
			UId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c");
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
			UId = new Guid("df9e1588-f7c3-4095-9347-314e128ca56d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"VirtualDataSourceID",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c33c50ab-f5e9-4aec-ab7d-fdf0ce2652d6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnValuesContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("73db9fe6-92ce-426c-a87e-de70b12839b8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ColumnValuesContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsFilterParamsValuesCorrectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("46d65128-c351-4306-8a29-5dffe39cd687"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IsFilterParamsValuesCorrect",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedColumnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3ff1dab2-80ce-482a-a822-ed6d40d7e3dc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
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
			Parameters.Add(CreateColumnValuesContextKeyParameter());
			Parameters.Add(CreateIsFilterParamsValuesCorrectParameter());
			Parameters.Add(CreateInsertedColumnValueKeyParameter());
		}

		protected virtual void InitializeChangeSchemaEntityUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("15e0066b-8e20-4a1c-87c7-bc687d8cf920"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("a4cd1e0c-dcd8-4514-b3a7-1376ca2f672a"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("39cc251c-3181-42af-85ce-526de0892bd8"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("217786e6-0f99-4f9a-b121-b5b43b827138"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("609efa94-971f-4e32-982e-b8d1ab686c74"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("a8663bc7-86c1-4cf1-b94a-1e5da4653d00"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("978e0450-58f0-4330-be1f-29a52d4d63f5"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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
				UId = new Guid("128ccc38-6fcd-4e5e-8d38-4134e2a10c0e"),
				ContainerUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
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

		protected virtual void InitializeOpenColumnPageOnAddParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a40899ba-546b-40d7-9005-5059571c1d58"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("ed769b87-875d-4946-8180-ea4b3b820d57"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("504a2ed1-74e8-4fe6-b35e-af3101d94a56"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("eefa6f71-0a39-49f2-80ad-bcd68464e107"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("30bd0daf-4ddc-4a8d-b795-05ebe64ea728"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("f79ef12b-89df-472a-a06e-a15457a108d8"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("275c63f9-ca17-4634-a55c-624ae78cb10d"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("181c5ab8-5189-4cfb-86d5-41aa09b9a718"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("dd588229-a25b-47a9-a231-c2dcfe8054c4"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("470715d2-b483-43cb-a404-2bb208b54638"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("557474b4-9440-45a2-9ee6-05caa204ada8"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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
				UId = new Guid("c986b917-858f-4485-a982-8804bc86129c"),
				ContainerUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
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

		protected virtual void InitializeOpenColumnPageOnEditParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1bb45e39-c2ba-4f39-bb2c-f1c201b28dcc"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("57fe1221-2543-4e94-a009-0f4a0b23d467"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("f8e65362-8a85-4899-a044-b01d8c2bbda6"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("33eec405-e8e7-426b-b246-74f51852b1b2"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("53c933ef-1c3e-42f4-9713-ee075faad77a"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("beeaa922-b649-4dbb-8c48-b12dc1cc032c"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("fc39d5db-48ab-467b-ba6f-84727c10da27"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("4c2c8cb2-a4f7-4bcf-be5e-7a281c03d979"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("292dcc3b-c0b2-498a-be77-3debbcae6c53"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("19a60801-74ee-41e8-83d2-7ac5a06af2ba"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("88d68e4d-1480-4d24-bcf0-11801e69d19b"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
				UId = new Guid("be774c1d-d74b-4787-a1a0-a9910accda6b"),
				ContainerUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
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
			ProcessSchemaLaneSet schemaLaneSet334 = CreateLaneSet334LaneSet();
			LaneSets.Add(schemaLaneSet334);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet334.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocessismatchconditionseditcheck = CreateEventSubProcessIsMatchConditionsEditCheckEventSubProcess();
			FlowElements.Add(eventsubprocessismatchconditionseditcheck);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocesschangeschemaentitynomessage = CreateEventSubProcessChangeSchemaEntityNoMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeschemaentitynomessage);
			ProcessSchemaEventSubProcess eventsubprocesschangeschemaentityyesmessage = CreateEventSubProcessChangeSchemaEntityYesMessageEventSubProcess();
			FlowElements.Add(eventsubprocesschangeschemaentityyesmessage);
			ProcessSchemaEventSubProcess eventsubprocessaddbuttonclick = CreateEventSubProcessAddButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocessaddbuttonclick);
			ProcessSchemaEventSubProcess eventsubprocessdeletebuttonclick = CreateEventSubProcessDeleteButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocessdeletebuttonclick);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess columnvalueeditpageclosedeventsubprocess = CreateColumnValueEditPageClosedEventSubProcessEventSubProcess();
			FlowElements.Add(columnvalueeditpageclosedeventsubprocess);
			ProcessSchemaEventSubProcess okbuttonclickchildsubprocess = CreateOkButtonClickChildSubProcessEventSubProcess();
			FlowElements.Add(okbuttonclickchildsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaStartMessageEvent ismatchconditionseditcheckstartmessage = CreateIsMatchConditionsEditCheckStartMessageStartMessageEvent();
			eventsubprocessismatchconditionseditcheck.FlowElements.Add(ismatchconditionseditcheckstartmessage);
			ProcessSchemaScriptTask ismatchconditionseditcheckscript = CreateIsMatchConditionsEditCheckScriptScriptTask();
			eventsubprocessismatchconditionseditcheck.FlowElements.Add(ismatchconditionseditcheckscript);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess4.FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask scripttaskpreparechangeschemaentityquestion = CreateScriptTaskPrepareChangeSchemaEntityQuestionScriptTask();
			eventsubprocess4.FlowElements.Add(scripttaskpreparechangeschemaentityquestion);
			ProcessSchemaUserTask changeschemaentityusermessage = CreateChangeSchemaEntityUserMessageUserTask();
			eventsubprocess4.FlowElements.Add(changeschemaentityusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaStartMessageEvent entityschemaeditchangestartmessage = CreateEntitySchemaEditChangeStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(entityschemaeditchangestartmessage);
			ProcessSchemaScriptTask scriptentityschemaeditnotchange = CreateScriptEntitySchemaEditNotChangeScriptTask();
			eventsubprocesschangeschemaentitynomessage.FlowElements.Add(scriptentityschemaeditnotchange);
			ProcessSchemaStartMessageEvent changeschemaentitynomessagebase = CreateChangeSchemaEntityNoMessageBaseStartMessageEvent();
			eventsubprocesschangeschemaentitynomessage.FlowElements.Add(changeschemaentitynomessagebase);
			ProcessSchemaScriptTask scriptentityschemaeditchange = CreateScriptEntitySchemaEditChangeScriptTask();
			eventsubprocesschangeschemaentityyesmessage.FlowElements.Add(scriptentityschemaeditchange);
			ProcessSchemaStartMessageEvent changeschemaentityyesmessagebase = CreateChangeSchemaEntityYesMessageBaseStartMessageEvent();
			eventsubprocesschangeschemaentityyesmessage.FlowElements.Add(changeschemaentityyesmessagebase);
			ProcessSchemaStartMessageEvent startmessageaddbuttonclick = CreateStartMessageAddButtonClickStartMessageEvent();
			eventsubprocessaddbuttonclick.FlowElements.Add(startmessageaddbuttonclick);
			ProcessSchemaScriptTask scriptaddbuttonclick = CreateScriptAddButtonClickScriptTask();
			eventsubprocessaddbuttonclick.FlowElements.Add(scriptaddbuttonclick);
			ProcessSchemaUserTask opencolumnpageonadd = CreateOpenColumnPageOnAddUserTask();
			eventsubprocessaddbuttonclick.FlowElements.Add(opencolumnpageonadd);
			ProcessSchemaStartMessageEvent startmessagedeletebuttonclick = CreateStartMessageDeleteButtonClickStartMessageEvent();
			eventsubprocessdeletebuttonclick.FlowElements.Add(startmessagedeletebuttonclick);
			ProcessSchemaScriptTask scriptdeletebuttonclick = CreateScriptDeleteButtonClickScriptTask();
			eventsubprocessdeletebuttonclick.FlowElements.Add(scriptdeletebuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent editbuttonclickintermediatethrowmessageevent = CreateEditButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(editbuttonclickintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent columnvaluestreegriddblclickstartmessage = CreateColumnValuesTreeGridDblClickStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(columnvaluestreegriddblclickstartmessage);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage2);
			ProcessSchemaScriptTask editbuttonclickscripttask = CreateEditButtonClickScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(editbuttonclickscripttask);
			ProcessSchemaUserTask opencolumnpageonedit = CreateOpenColumnPageOnEditUserTask();
			eventsubprocess6.FlowElements.Add(opencolumnpageonedit);
			ProcessSchemaStartMessageEvent columnvalueeditpageclosedstartmessage = CreateColumnValueEditPageClosedStartMessageStartMessageEvent();
			columnvalueeditpageclosedeventsubprocess.FlowElements.Add(columnvalueeditpageclosedstartmessage);
			ProcessSchemaScriptTask columnvalueeditpageclosedscripttask = CreateColumnValueEditPageClosedScriptTaskScriptTask();
			columnvalueeditpageclosedeventsubprocess.FlowElements.Add(columnvalueeditpageclosedscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent4 = CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(intermediatethrowmessageevent4);
			ProcessSchemaScriptTask scriptchildokbuttonclick = CreateScriptChildOkButtonClickScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(scriptchildokbuttonclick);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			okbuttonclickchildsubprocess.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask checkdata_scripttask = CreateCheckData_ScriptTaskScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(checkdata_scripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			okbuttonclickchildsubprocess.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask errormessage_scripttask = CreateErrorMessage_ScriptTaskScriptTask();
			okbuttonclickchildsubprocess.FlowElements.Add(errormessage_scripttask);
			ProcessSchemaStartMessageEvent childinitstartmessage = CreateChildInitStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(childinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocess3.FlowElements.Add(scriptchildinit);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletechildscript = CreatePageLoadCompleteChildScriptScriptTask();
			eventsubprocess5.FlowElements.Add(pageloadcompletechildscript);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(intermediatethrowmessageevent2);
			FlowElements.Add(CreateSequenceFlow6558SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6559SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6560SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6561SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6562SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6563SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6565SequenceFlow());
			FlowElements.Add(CreateConditionalFlow177ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6567SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6568SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6569SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6570SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6571SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6572SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateCaptionColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateValueColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ffef5ca2-6af1-4f42-aa70-0b3bb14bf1fe"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("77f3b7b2-240a-45ca-8960-e291b22886af"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValueColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bc33ea7c-3ff5-45db-bd92-b94e2e8dc66c"),
				Name = "ValueColumnCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a3c9570c-da5d-495b-bd38-925810e932fd"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1d79b77a-4005-40ad-8f41-09cf46cee253"),
				Name = "ValidationMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6558SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6558",
				UId = new Guid("b3d4780f-635e-4f9f-a53b-b4c76800b933"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("387757dd-1b4e-4d58-8be3-edbb95d5d09f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("737f571b-5137-4ea3-9ec7-b56f4af6ce34"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6559SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6559",
				UId = new Guid("82c35e50-bae6-4f2b-817b-04f6fc18bc73"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(164, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eceb9e93-95ac-4c4b-ad38-be8c6f356c7f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e3b34ac-45b6-40ba-9c98-c8f1d849a10a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6560SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6560",
				UId = new Guid("29239b4a-8b89-4221-8a84-bb87244c51d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(256, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e3b34ac-45b6-40ba-9c98-c8f1d849a10a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b15aa5a6-4cf9-432c-a357-5be0baba8feb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6561SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6561",
				UId = new Guid("203dc513-2d83-4cb0-b83a-a52a865ab5d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(254, 556),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb772206-b438-4c4f-9171-260b9bdaed47"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5fc49db8-3a33-484c-9f23-45ea5715ad01"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6562SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6562",
				UId = new Guid("72a27306-3454-4f76-beca-a3d802f79ce5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(163, 552),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c5d620f7-5a4f-49c2-aee5-ed865cd83205"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb772206-b438-4c4f-9171-260b9bdaed47"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6563SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6563",
				UId = new Guid("de1d49b9-9b85-47c3-8544-a31fab4e9732"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(318, 74),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6565SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow6565",
				UId = new Guid("57165467-ef3e-435c-9fa1-f17a357265b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(210, 158),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8574bc6f-d9d4-40c9-af8e-e74c0e88e3ec"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow177ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow177",
				UId = new Guid("214f8d7c-10f2-4e02-917e-a7247935b9a4"),
				ConditionExpression = @"EntitySchemaUId != Guid.Empty && (Guid)Page.ObjectEdit.Value != EntitySchemaUId",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(264, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6567SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6567",
				UId = new Guid("e31bec34-5f3f-4fb5-ac3a-07fb20827844"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(164, 194),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e9f91717-c48b-4ac1-808b-b7b9e753fcee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0feee0b1-e83b-4faf-8350-54801f9b72cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6568SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6568",
				UId = new Guid("2c0f6b05-1ab2-4e87-90ac-b2e802512098"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(394, 194),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e13d9b4-f5c5-4e0c-8ebb-e2bdf6759d01"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d884aac-887d-41da-b6e0-7232b8ae062d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6569SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6569",
				UId = new Guid("296fd3d3-8d98-4c69-9c19-fb5c65187c1d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58baff93-00a9-424d-a289-47e8c2547238"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48917043-bf45-4abc-aad0-547d6cdf6fd4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6570SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6570",
				UId = new Guid("2ea855c1-6048-4421-821c-ad7f94bca15e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7d258006-43fb-45c3-98a2-789fb80b68e2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("627fd35a-02a4-4607-aa50-904e2a79929a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6571SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6571",
				UId = new Guid("ab61fd34-b15b-4846-9abb-ac182b98177e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("def9bf49-e2a7-4587-b99d-c54ed837ad5e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9f84ea93-2403-4903-adc2-23a962fefc48"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6572SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6572",
				UId = new Guid("34bcf1f7-2aef-4d4b-8f75-28285cbd5319"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c2506a1-d719-4971-b1f6-83fe9cb7e5a9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("984c9da9-bf25-4318-ad66-95016ac895e9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4065e002-344c-4519-b5bd-c2778dfc99b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(488, 770),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8a2ba162-5aeb-485f-9fb7-d84b2ba4f453"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("556035f6-caa4-46e0-b0e9-34dd547856e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c8e63167-fe9c-489a-a5ff-0acd5a1ee262"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("90786533-b6d1-4e73-aede-512610dd85e3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4cc9dea1-a415-4289-90ec-3b254f12bed9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("7ff70899-b441-49d7-8bcb-1e0e3da044cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(302, 616),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f84ea93-2403-4903-adc2-23a962fefc48"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("02c9c680-682d-4253-876f-5ce30ff6df51"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(300, 764),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4cc9dea1-a415-4289-90ec-3b254f12bed9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("8e306890-63e7-488e-86b8-abe033c4d9d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(166, 144),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("89dbe425-7207-4802-ab4f-24e87aba772e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("17408bae-216b-407f-9049-78aa724b6aa4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("627fd35a-02a4-4607-aa50-904e2a79929a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9ad24c7-c53e-4c20-a156-f8c11ee7a075"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("4028b0db-6bd5-4f17-b0d1-d11823646103"),
				ConditionExpression = @"IsFilterParamsValuesCorrect",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(392, 194),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9ad24c7-c53e-4c20-a156-f8c11ee7a075"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58baff93-00a9-424d-a289-47e8c2547238"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7",
				UId = new Guid("20b4e232-9dee-4091-bdb5-7d9371ecc2fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(386, 312),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9ad24c7-c53e-4c20-a156-f8c11ee7a075"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("491d0ce8-a016-42e9-b8a4-67e59897da93"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("11cb7fc8-aa5f-4838-946b-a6777e48f409"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CurveCenterPosition = new Point(769, 296),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18e0966e-b381-4917-82a7-d4477261ecbb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1094876f-3a0d-4388-821a-4c9da5469f54"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet334LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet334 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ab019746-e5b1-40da-b298-22e4d43e4a7c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"LaneSet334",
				Position = new Point(5, 5),
				Size = new Size(891, 1522),
				UseBackgroundMode = false
			};
			return schemaLaneSet334;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ab019746-e5b1-40da-b298-22e4d43e4a7c"),
				CreatedInOwnerSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(862, 153),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessIsMatchConditionsEditCheckEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessIsMatchConditionsEditCheck = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fef0770e-54f7-4b9c-bad4-ded16d81be23"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcessIsMatchConditionsEditCheck",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessIsMatchConditionsEditCheck;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIsMatchConditionsEditCheckStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("387757dd-1b4e-4d58-8be3-edbb95d5d09f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fef0770e-54f7-4b9c-bad4-ded16d81be23"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"IsMatchConditionsEditCheck",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IsMatchConditionsEditCheckStartMessage",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIsMatchConditionsEditCheckScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("737f571b-5137-4ea3-9ec7-b56f4af6ce34"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fef0770e-54f7-4b9c-bad4-ded16d81be23"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IsMatchConditionsEditCheckScript",
				Position = new Point(147, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,76,202,73,117,203,204,41,73,45,114,77,201,44,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,60,118,41,246,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcess4",
				Position = new Point(35, 165),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(510, 219),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7048f505-208d-4500-9ee2-a56785c7607e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPrepareChangeSchemaEntityQuestionScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5b3ff4a1-f642-4c88-a3da-1cb1d8f83d39"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptTaskPrepareChangeSchemaEntityQuestion",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,140,49,14,130,64,16,69,107,57,197,102,107,226,5,80,11,145,130,66,80,129,130,114,67,38,64,225,172,217,25,162,132,112,119,119,227,22,38,24,105,230,103,242,223,251,113,167,176,133,162,233,224,174,18,228,158,199,138,192,156,129,72,181,176,189,216,35,246,194,69,20,196,127,81,159,37,188,216,26,75,214,247,107,51,105,163,209,250,242,90,37,69,153,230,153,92,19,142,3,179,70,114,78,157,20,89,190,42,220,128,30,86,0,255,59,19,225,41,78,125,195,189,70,101,198,29,177,233,177,13,197,39,15,98,10,54,147,28,129,100,40,228,114,187,6,242,83,114,14,29,137,250,55,152,233,47,110,142,2,3,60,24,20,108,6,136,222,35,22,238,217,135,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeSchemaEntityUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3c40e234-0601-49e2-abed-ea6b8847dc30"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ChangeSchemaEntityUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(399, 21),
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
				UId = new Guid("8574bc6f-d9d4-40c9-af8e-e74c0e88e3ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(280, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("89dbe425-7207-4802-ab4f-24e87aba772e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7d95ba0-61a8-4319-aa32-8882bfcae6e5"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ObjectEditChange",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EntitySchemaEditChangeStartMessage",
				Position = new Point(36, 89),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeSchemaEntityNoMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeSchemaEntityNoMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f47a446b-bb12-4fda-94a4-ce01729700c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcessChangeSchemaEntityNoMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 397),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(233, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeSchemaEntityNoMessage;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEntitySchemaEditNotChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4d884aac-887d-41da-b6e0-7232b8ae062d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f47a446b-bb12-4fda-94a4-ce01729700c4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptEntitySchemaEditNotChange",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,177,10,194,48,20,69,119,191,162,99,10,146,31,232,84,52,131,147,197,180,238,207,228,82,83,236,75,73,94,164,254,189,96,39,197,245,112,14,247,118,52,66,159,111,19,156,24,31,68,219,146,23,176,111,39,90,205,19,44,89,213,205,174,251,149,32,87,122,20,180,236,123,172,162,12,75,144,151,117,119,204,52,156,252,190,250,4,27,61,146,144,141,37,57,232,77,208,7,90,36,68,214,125,180,146,2,143,170,254,51,113,65,46,51,190,111,36,72,73,92,73,42,104,222,0,15,248,68,184,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityNoMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6e13d9b4-f5c5-4e0c-8ebb-e2bdf6759d01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f47a446b-bb12-4fda-94a4-ce01729700c4"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityNoMessage",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ChangeSchemaEntityNoMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChangeSchemaEntityYesMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChangeSchemaEntityYesMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6c557ccf-583c-4f11-b2ea-1c97b6067400"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcessChangeSchemaEntityYesMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 397),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 123),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChangeSchemaEntityYesMessage;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEntitySchemaEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0feee0b1-e83b-4faf-8350-54801f9b72cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c557ccf-583c-4f11-b2ea-1c97b6067400"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptEntitySchemaEditChange",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,205,78,195,48,12,199,207,76,218,59,132,158,210,75,94,96,192,165,100,168,18,136,137,104,112,54,169,69,11,105,2,137,35,232,219,227,166,76,3,105,220,44,203,255,143,159,181,167,129,38,99,123,28,97,223,118,226,82,72,143,159,194,160,67,75,114,159,48,54,193,123,158,135,224,235,245,234,76,53,193,229,209,203,138,143,171,178,216,198,48,202,202,76,105,49,89,150,79,61,70,148,213,225,166,77,250,35,131,147,139,88,237,32,194,136,132,81,202,155,60,116,245,14,94,80,221,63,191,114,140,238,6,82,143,224,50,214,181,128,244,83,164,152,232,47,180,153,208,88,112,16,47,102,225,149,172,55,235,85,81,235,194,113,13,4,38,228,104,81,253,70,210,127,33,15,154,54,221,1,217,158,1,57,148,249,82,9,111,122,180,111,56,203,230,8,165,199,119,154,196,249,41,147,7,76,72,172,166,24,92,169,156,142,125,182,131,99,190,98,104,144,142,189,228,201,182,255,99,220,6,232,12,197,108,41,243,67,231,187,136,60,122,193,59,220,124,3,174,99,77,166,190,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityYesMessageBaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e9f91717-c48b-4ac1-808b-b7b9e753fcee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c557ccf-583c-4f11-b2ea-1c97b6067400"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ChangeSchemaEntityYesMessageBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessAddButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessAddButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3a0d8cea-9efb-4e57-a299-dc34bffc4649"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcessAddButtonClick",
				Position = new Point(28, 546),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(388, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessAddButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAddButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("def9bf49-e2a7-4587-b99d-c54ed837ad5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3a0d8cea-9efb-4e57-a299-dc34bffc4649"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"StartMessageAddButtonClick",
				Position = new Point(29, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAddButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9f84ea93-2403-4903-adc2-23a962fefc48"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3a0d8cea-9efb-4e57-a299-dc34bffc4649"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptAddButtonClick",
				Position = new Point(127, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,81,107,194,48,16,126,86,216,127,8,125,82,166,178,7,117,202,230,64,170,72,217,180,50,117,175,35,77,110,26,176,169,36,233,58,17,255,251,46,173,206,56,86,246,210,38,119,223,119,119,223,119,9,119,32,253,100,155,198,114,78,215,16,202,33,231,173,16,99,160,2,169,13,149,12,2,78,6,228,124,89,5,252,225,166,26,254,65,90,105,240,83,165,64,154,33,51,226,19,108,6,137,70,165,80,194,176,167,85,94,93,66,70,38,169,224,53,143,71,253,54,237,244,121,147,49,214,109,182,35,218,105,246,32,186,107,66,116,207,63,34,218,237,181,123,61,175,94,82,208,223,38,26,166,160,117,209,218,43,242,111,116,155,194,152,11,99,129,57,132,123,88,0,21,129,50,192,29,208,51,236,145,54,163,49,144,91,226,189,123,248,181,83,181,102,144,229,211,213,91,203,100,97,148,144,235,90,217,8,246,52,167,10,75,24,80,154,12,110,170,21,43,110,36,208,147,68,82,181,127,212,121,129,6,41,254,79,181,58,57,32,168,82,57,16,79,179,13,196,52,224,94,131,140,165,17,102,191,200,3,232,145,211,152,28,27,103,252,78,37,12,213,46,28,26,202,252,135,20,83,137,51,42,171,242,138,48,189,196,29,52,75,164,129,47,131,206,32,216,177,74,251,63,9,7,109,20,192,68,9,158,207,98,173,104,185,148,229,41,139,123,18,248,76,130,145,219,135,74,127,67,37,46,40,39,32,221,62,28,71,1,30,95,146,12,212,149,22,113,218,225,107,146,21,19,150,44,245,194,0,212,59,222,66,108,251,159,13,59,221,127,59,102,41,71,92,179,2,147,42,89,60,228,111,208,77,215,61,46,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenColumnPageOnAddUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6515a496-9ac0-4b8f-a6f2-844d40fd3610"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3a0d8cea-9efb-4e57-a299-dc34bffc4649"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"OpenColumnPageOnAdd",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 38),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenColumnPageOnAddParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessDeleteButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessDeleteButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5dc6bd6b-ef42-4bd5-ae09-300676d70e8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcessDeleteButtonClick",
				Position = new Point(435, 546),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(246, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessDeleteButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageDeleteButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2c2506a1-d719-4971-b1f6-83fe9cb7e5a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5dc6bd6b-ef42-4bd5-ae09-300676d70e8d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"StartMessageDeleteButtonClick",
				Position = new Point(29, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptDeleteButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("984c9da9-bf25-4318-ad66-95016ac895e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5dc6bd6b-ef42-4bd5-ae09-300676d70e8d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptDeleteButtonClick",
				Position = new Point(141, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,193,106,195,48,16,68,207,49,248,31,150,156,108,40,250,129,214,189,196,144,67,105,49,117,218,75,200,97,145,55,177,64,150,202,74,54,53,165,255,222,141,221,130,114,237,73,32,102,102,223,204,132,12,218,219,113,112,239,104,71,10,80,193,91,32,222,121,231,72,71,227,157,106,41,4,121,107,140,120,220,37,74,145,68,250,140,79,52,159,0,3,212,102,145,35,207,15,33,178,113,151,59,104,216,107,49,183,186,167,1,27,100,28,40,18,47,238,199,251,60,51,103,40,110,79,87,224,70,107,75,248,202,179,13,83,28,217,65,228,145,68,251,157,103,103,207,132,186,135,98,18,100,231,59,2,227,160,193,11,169,148,234,192,68,123,54,157,96,91,41,64,221,139,40,195,26,121,53,10,130,160,196,94,122,94,51,212,234,58,110,159,127,255,183,39,117,240,237,82,160,40,229,240,38,37,84,175,52,248,137,138,191,144,114,37,251,199,96,213,205,232,18,83,155,240,97,113,78,245,203,253,116,134,31,86,244,62,73,172,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6fe72715-e811-44e7-a6d6-fd1acf5088e6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(421, 698),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(208, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateEditButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("556035f6-caa4-46e0-b0e9-34dd547856e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fe72715-e811-44e7-a6d6-fd1acf5088e6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EditButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(140, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValuesTreeGridDblClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8a2ba162-5aeb-485f-9fb7-d84b2ba4f453"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fe72715-e811-44e7-a6d6-fd1acf5088e6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValuesTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ColumnValuesTreeGridDblClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c84f1a39-a569-4995-8e89-c5e4e74bd157"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcess6",
				Position = new Point(29, 698),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(370, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("90786533-b6d1-4e73-aede-512610dd85e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c84f1a39-a569-4995-8e89-c5e4e74bd157"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"StartMessage2",
				Position = new Point(29, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEditButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4cc9dea1-a415-4289-90ec-3b254f12bed9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c84f1a39-a569-4995-8e89-c5e4e74bd157"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EditButtonClickScriptTask",
				Position = new Point(127, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,81,107,219,48,16,199,159,19,200,119,80,253,148,176,196,228,33,237,82,186,12,138,27,138,217,146,134,37,217,75,41,69,150,46,141,192,150,138,36,207,13,37,223,125,39,217,89,213,130,89,95,108,249,244,255,157,238,78,127,111,52,192,173,22,124,169,56,16,233,30,51,34,203,60,191,234,117,197,142,244,87,244,9,226,68,229,101,33,127,211,188,4,179,105,244,241,26,114,96,22,60,104,80,82,74,75,206,102,100,60,32,175,189,110,167,201,244,73,252,126,252,128,231,29,9,228,6,60,174,193,150,90,146,29,197,128,219,233,117,239,158,65,214,137,92,206,59,57,231,194,198,46,8,58,149,198,82,201,32,229,120,226,233,99,155,242,171,22,106,107,32,41,181,6,105,175,153,21,127,192,109,33,105,117,9,109,136,91,110,125,126,9,21,185,45,5,239,71,60,187,156,208,243,75,62,98,140,93,140,38,25,61,31,77,33,27,143,32,251,202,119,25,189,152,78,166,211,104,208,150,49,201,149,129,5,24,83,31,30,5,67,114,251,78,233,37,60,194,12,216,20,104,28,86,32,250,1,7,196,150,180,0,242,133,68,143,17,62,93,89,241,18,42,95,222,32,222,168,181,213,66,62,245,91,107,112,203,21,213,152,195,130,54,100,230,238,13,219,187,17,56,22,37,169,62,124,51,62,195,144,212,239,239,253,250,114,59,157,87,18,25,182,135,130,166,60,26,146,185,180,194,30,214,62,128,83,10,78,38,199,225,73,255,172,21,195,118,215,1,134,53,252,7,42,168,196,26,181,107,243,29,176,120,139,7,106,166,164,133,23,139,163,65,113,232,186,228,223,70,160,182,141,21,125,45,237,70,77,114,129,78,73,111,2,82,171,202,67,206,228,113,45,191,143,48,242,208,210,4,88,186,162,118,255,145,88,156,226,45,28,163,50,217,83,137,70,240,117,33,238,44,26,104,113,249,83,85,160,223,81,162,241,202,47,85,213,131,104,49,207,27,1,56,214,121,14,133,107,243,116,47,205,247,199,139,113,200,17,237,212,235,54,127,168,255,105,254,2,130,195,26,4,68,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenColumnPageOnEditUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0a819252-5eb9-4748-8f4e-2101b290f135"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c84f1a39-a569-4995-8e89-c5e4e74bd157"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"OpenColumnPageOnEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(274, 38),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenColumnPageOnEditParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateColumnValueEditPageClosedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaColumnValueEditPageClosedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d51b0478-d6b6-4503-8e09-5cdf4b5c07f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ColumnValueEditPageClosedEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(652, 693),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(196, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaColumnValueEditPageClosedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValueEditPageClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("18e0966e-b381-4917-82a7-d4477261ecbb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d51b0478-d6b6-4503-8e09-5cdf4b5c07f8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValueEditPageClosed",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ColumnValueEditPageClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnValueEditPageClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1094876f-3a0d-4388-821a-4c9da5469f54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d51b0478-d6b6-4503-8e09-5cdf4b5c07f8"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ColumnValueEditPageClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,204,43,78,45,42,9,202,47,119,206,207,41,205,205,11,75,204,41,77,85,176,85,208,40,46,41,202,204,75,215,12,5,202,58,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,151,196,146,196,104,79,176,206,212,20,36,141,222,169,149,177,214,188,92,184,53,233,5,165,230,230,151,165,106,96,215,171,9,212,27,144,152,158,170,231,152,146,18,156,92,148,89,80,162,129,205,121,32,101,69,169,37,165,69,121,10,37,69,165,169,214,0,208,185,248,233,199,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateOkButtonClickChildSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaOkButtonClickChildSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"OkButtonClickChildSubProcess",
				Position = new Point(29, 886),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(533, 324),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaOkButtonClickChildSubProcess;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("48917043-bf45-4abc-aad0-547d6cdf6fd4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IntermediateThrowMessageEvent4",
				Position = new Point(483, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("58baff93-00a9-424d-a289-47e8c2547238"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptChildOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(371, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,193,110,219,48,12,61,71,95,193,229,228,0,129,187,115,179,172,192,210,180,200,208,164,221,146,246,50,236,160,216,76,163,214,150,12,73,110,150,13,253,247,81,146,211,58,142,17,180,135,158,12,211,79,228,227,227,19,61,206,48,71,105,103,184,25,241,194,10,37,97,8,55,252,30,227,91,131,122,193,205,227,66,216,12,199,169,176,241,2,255,216,1,99,79,92,131,84,18,239,230,14,170,85,130,198,204,147,53,230,252,134,107,158,163,69,125,199,179,18,231,170,212,9,198,51,130,14,252,161,68,73,99,223,120,106,228,177,46,80,85,44,118,40,227,163,158,229,126,132,27,56,23,137,107,129,235,237,23,99,181,144,247,253,99,165,190,14,152,88,65,116,144,121,8,178,204,178,30,252,99,157,102,141,97,11,28,36,110,222,91,57,234,245,6,236,153,157,156,192,28,53,242,76,252,69,72,185,229,198,119,15,43,145,17,20,4,105,128,60,5,181,130,241,252,7,144,144,176,196,132,151,6,97,131,84,22,83,176,10,52,46,75,145,165,46,153,176,176,89,163,164,144,42,232,81,208,28,97,165,52,216,181,48,128,97,210,177,3,94,47,45,23,210,103,173,106,173,180,202,193,236,200,164,45,108,154,137,136,15,232,82,90,145,163,159,80,128,141,84,150,97,82,55,210,133,143,123,7,157,83,210,106,192,23,66,166,225,139,185,212,170,44,190,109,103,36,80,212,125,69,119,123,193,54,15,70,73,178,195,19,106,199,162,146,251,37,81,149,227,123,29,20,57,239,210,155,12,68,250,71,120,80,141,198,64,127,117,15,146,119,127,87,101,143,140,52,242,126,153,170,84,172,4,166,19,25,48,183,147,148,142,186,154,47,239,125,214,9,201,119,250,76,204,148,219,100,77,124,9,70,116,141,167,56,90,99,242,72,115,56,123,185,54,167,213,173,163,4,175,87,224,13,231,89,167,227,212,137,201,105,194,15,55,106,78,170,191,175,113,143,74,205,189,137,227,113,94,216,45,123,30,4,167,210,200,151,15,116,4,140,111,6,158,28,13,22,252,94,125,10,109,134,174,201,26,118,91,211,97,8,151,165,72,67,78,226,85,47,65,21,27,240,120,161,2,32,106,27,81,3,252,97,3,170,56,78,204,140,54,194,181,246,92,163,253,78,123,212,74,181,14,79,119,179,170,141,104,31,92,147,50,81,89,153,203,160,161,97,44,116,52,242,193,41,47,10,42,91,187,74,249,65,36,44,169,1,123,231,226,1,83,96,226,21,8,165,124,212,80,182,75,180,245,136,83,221,45,199,118,248,167,218,138,108,165,70,163,56,218,80,123,222,126,211,4,126,73,94,169,196,217,150,47,51,220,111,198,92,9,99,119,210,212,80,62,60,108,211,44,208,166,27,113,230,41,30,207,28,245,88,231,244,48,11,25,179,81,171,177,110,252,118,241,105,22,219,2,167,92,210,37,213,109,38,254,137,137,210,123,2,124,152,143,15,187,24,41,90,221,78,145,207,237,254,173,245,248,122,106,103,234,118,205,157,185,53,218,82,75,176,154,126,220,255,1,136,255,162,1,91,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7d258006-43fb-45c3-98a2-789fb80b68e2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"StartMessage1",
				Position = new Point(35, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckData_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("627fd35a-02a4-4607-aa50-904e2a79929a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"CheckData_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,65,11,130,64,16,133,207,9,254,135,201,147,93,164,187,120,40,179,8,194,132,160,251,160,99,8,235,174,204,236,70,18,254,247,52,139,142,221,102,222,251,230,189,185,35,67,221,40,75,44,144,64,129,55,138,246,239,53,171,26,27,237,208,226,197,56,46,39,85,87,179,35,7,54,174,219,246,57,182,20,6,63,58,88,197,190,215,212,16,126,242,162,212,56,109,33,73,96,189,122,250,222,226,40,51,91,32,99,43,87,84,142,36,53,204,84,142,16,212,168,132,198,128,1,104,28,224,255,193,242,91,115,148,141,238,79,84,219,236,209,49,137,52,70,231,78,169,51,103,109,103,251,112,250,106,240,61,38,235,88,131,101,71,241,11,79,186,38,1,245,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f9ad24c7-c53e-4c20-a156-f8c11ee7a075"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(266, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateErrorMessage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("491d0ce8-a016-42e9-b8a4-67e59897da93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bde019a8-cc54-452c-8c1b-1a2a0de3046f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ErrorMessage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(357, 224),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,77,204,204,243,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,176,196,156,204,148,196,146,204,124,152,138,144,204,146,156,84,29,5,12,113,29,5,152,130,202,130,84,189,240,196,162,188,204,188,116,77,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,128,150,131,124,111,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4a0dc41f-4c3f-45ee-ac9f-d9ea8fa161cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1236),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(309, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eceb9e93-95ac-4c4b-ad38-be8c6f356c7f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a0dc41f-4c3f-45ee-ac9f-d9ea8fa161cc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ChildInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9e3b34ac-45b6-40ba-9c98-c8f1d849a10a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a0dc41f-4c3f-45ee-ac9f-d9ea8fa161cc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b15aa5a6-4cf9-432c-a357-5be0baba8feb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4a0dc41f-4c3f-45ee-ac9f-d9ea8fa161cc"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,193,110,163,48,16,61,167,82,255,193,203,137,104,17,63,208,54,82,150,208,110,164,109,23,109,210,238,161,234,193,133,33,113,99,108,58,54,109,81,149,127,223,49,144,144,148,61,238,170,39,192,51,243,230,189,231,177,153,199,170,42,0,249,163,132,243,171,74,100,19,86,242,116,195,87,48,207,12,187,96,75,64,228,70,231,54,140,52,66,152,180,49,19,254,214,184,49,148,9,183,86,72,97,5,45,93,129,237,194,223,5,1,98,186,174,9,195,191,53,128,145,86,10,82,43,180,10,216,165,80,217,12,140,88,41,200,18,212,41,24,179,72,215,80,112,127,188,131,191,157,103,193,233,201,232,184,178,111,25,206,179,241,217,233,137,126,124,162,200,253,3,107,95,146,67,218,189,134,48,226,198,158,183,41,19,106,177,212,83,82,84,251,14,225,133,99,159,121,41,164,5,164,90,5,175,108,38,154,158,28,235,115,99,81,168,85,208,117,153,176,119,98,54,122,247,82,93,148,28,133,209,106,89,151,224,57,93,174,62,58,90,14,227,231,138,203,109,208,150,72,200,109,252,86,34,41,38,236,72,203,170,80,9,183,107,42,246,22,181,233,4,120,187,244,202,192,76,152,82,242,250,142,203,202,181,200,185,52,176,11,163,88,173,15,224,18,142,188,0,98,208,36,27,47,24,216,178,221,118,146,11,174,104,5,111,40,255,115,69,95,247,68,254,153,106,39,100,63,25,239,94,172,172,176,117,59,96,93,59,111,187,119,2,222,44,168,140,64,64,217,207,181,34,62,96,242,159,188,104,107,27,237,9,249,16,254,108,34,113,38,108,152,32,16,107,248,161,245,166,42,59,35,190,94,176,12,36,172,184,5,230,183,40,204,16,71,192,128,181,137,174,52,126,33,194,83,92,25,6,227,198,26,103,107,222,32,184,115,8,97,139,102,168,233,168,91,14,167,89,230,127,56,118,227,143,241,193,140,14,50,134,123,231,82,156,186,8,129,72,183,254,182,94,220,209,61,228,162,34,103,254,23,178,58,156,155,233,19,127,251,5,207,20,180,61,241,12,242,182,128,168,207,32,231,149,180,221,55,55,127,155,137,163,251,235,216,255,137,227,219,248,236,174,177,37,55,155,165,176,18,26,187,151,196,157,58,196,18,10,34,127,3,175,17,47,29,180,43,89,128,61,236,236,239,41,221,123,115,115,205,109,186,166,43,145,64,40,221,120,15,221,68,208,173,182,104,40,249,227,128,181,228,194,184,40,109,77,147,53,172,106,172,60,150,119,209,75,63,219,123,97,82,20,165,213,216,152,177,255,112,78,52,215,247,181,206,32,146,220,152,62,232,106,105,47,36,249,82,2,218,122,198,45,95,232,10,83,240,219,71,112,0,59,222,117,42,7,217,212,113,8,225,58,223,9,180,116,162,250,69,135,49,172,15,201,197,72,10,55,154,180,103,47,240,75,191,54,251,63,250,70,63,31,183,5,26,141,79,255,171,238,213,173,118,230,13,177,130,222,154,102,192,78,79,16,108,133,138,89,172,224,236,15,125,131,183,246,63,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("139b99c2-dce1-45c4-a009-f96c23ebda28"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("952b699e-7de0-4383-bd6c-cdea1bf85420"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1376),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(317, 132),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c5d620f7-5a4f-49c2-aee5-ed865cd83205"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("139b99c2-dce1-45c4-a009-f96c23ebda28"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteChildScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5fc49db8-3a33-484c-9f23-45ea5715ad01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("139b99c2-dce1-45c4-a009-f96c23ebda28"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"PageLoadCompleteChildScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(204, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,219,78,227,48,16,125,110,165,254,131,225,41,145,80,248,128,5,36,54,45,168,187,220,68,129,23,196,131,73,166,212,108,106,71,182,83,182,139,250,239,140,199,105,227,164,237,74,72,21,21,246,156,51,103,102,142,167,11,174,153,201,102,48,231,236,148,93,8,153,15,193,136,55,9,249,157,86,25,24,51,161,187,40,254,49,232,223,241,55,72,46,68,97,65,143,114,97,147,9,216,118,144,231,113,161,131,254,2,121,75,174,249,28,48,220,32,247,16,166,188,42,236,19,47,42,48,140,27,54,20,153,21,74,114,189,60,49,86,11,249,118,196,90,116,119,107,52,65,206,144,85,76,89,20,114,158,50,89,21,69,204,62,7,253,158,6,91,105,201,172,174,0,35,87,131,254,241,49,166,52,160,5,47,196,63,96,83,210,109,6,125,159,139,129,180,194,46,125,166,113,142,250,26,226,231,195,81,112,249,56,206,15,95,18,210,80,75,56,152,16,69,50,54,55,152,254,86,143,230,165,93,70,109,194,216,171,234,16,97,26,9,31,236,178,18,121,55,30,185,123,212,96,15,25,114,203,39,170,210,25,36,33,186,195,183,1,221,190,190,67,102,215,83,33,177,231,50,127,128,191,54,234,64,176,201,255,201,146,164,188,116,67,33,57,248,169,155,85,55,175,211,165,6,237,77,97,130,62,245,246,55,170,38,171,59,212,115,70,121,55,74,166,74,46,64,227,77,221,164,45,246,95,97,80,228,160,189,71,156,47,30,73,32,39,213,165,5,14,109,56,168,32,202,229,211,167,170,40,60,10,211,57,230,36,48,203,90,226,17,179,203,18,212,52,234,106,105,208,241,17,35,37,78,241,149,48,246,164,165,242,140,125,118,106,91,197,100,253,189,124,36,211,245,110,75,230,65,232,246,176,20,87,233,165,86,85,137,149,236,158,173,123,214,117,19,41,240,231,242,6,135,184,149,34,113,167,190,81,129,132,134,190,163,96,143,93,211,74,107,244,54,142,190,202,240,73,174,231,97,146,123,152,171,5,116,89,235,124,43,250,251,77,198,243,60,223,42,194,243,57,186,213,222,23,117,165,120,190,97,139,154,167,215,222,109,13,32,218,73,19,251,61,51,146,252,181,0,156,176,213,170,48,59,23,165,15,201,215,243,25,155,107,110,179,25,66,240,18,37,27,10,74,103,144,253,129,156,150,103,103,119,101,170,168,230,146,45,104,117,14,250,41,253,235,23,169,203,139,175,252,55,44,145,221,237,149,228,6,62,104,191,196,201,131,242,239,143,52,57,191,100,1,112,253,202,190,183,132,125,121,251,3,24,138,6,18,157,167,79,221,125,113,15,153,210,121,168,254,240,165,94,169,109,88,203,104,36,124,129,168,205,115,245,131,240,60,215,188,44,81,117,96,226,160,113,148,164,205,77,195,158,42,60,201,102,44,242,220,76,200,48,67,237,239,176,89,207,217,34,169,243,129,197,146,237,236,5,117,224,225,102,221,173,200,11,237,125,132,38,50,6,191,157,101,158,119,15,141,104,130,27,164,26,10,83,22,124,25,198,83,215,195,31,184,47,75,76,184,40,181,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("fb772206-b438-4c4f-9171-260b9bdaed47"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("139b99c2-dce1-45c4-a009-f96c23ebda28"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				Name = @"IntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 40),
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
			Methods.Add(CreateIsEntitySchemaUIdEmptyMethod());
			Methods.Add(CreateCreateColumnValuesVdsMethod());
			Methods.Add(CreateGetColumnValuesMethod());
			Methods.Add(CreateDisplayColumnValuesMethod());
			Methods.Add(CreateResetControlValuesMethod());
			Methods.Add(CreateEnableFilterEditMethod());
			Methods.Add(CreateEnableControlsMethod());
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
				UId = new Guid("f447e342-cf83-40e2-896b-965672ba47c1"),
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
				UId = new Guid("6b6e0882-a958-4574-a9e8-0b1cdd80f76e"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("94063248-2238-47b9-8987-82552b075c5d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("568a5dd3-ca8b-4c5e-baa6-5708bd17ad12")
			});
		}

		protected override SchemaMethod CreateGetEditorsBindingMethod() {
			SchemaMethod method = base.CreateGetEditorsBindingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,41,46,41,202,204,75,215,81,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,70,98,219,41,84,115,85,43,121,22,251,38,150,36,103,0,197,82,50,65,134,20,43,233,40,4,36,166,167,234,97,72,184,2,233,90,174,90,107,0,176,165,86,105,121,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,204,177,10,194,48,20,133,225,89,159,226,210,41,129,18,116,85,68,164,84,232,82,69,82,58,71,123,45,193,52,41,185,87,170,148,190,187,84,156,157,206,242,159,79,156,77,139,234,64,253,188,96,8,52,198,104,40,220,89,85,133,170,241,154,5,207,49,56,82,115,32,85,102,122,182,193,195,14,136,163,245,173,42,168,124,58,119,138,121,215,243,91,124,181,138,48,106,67,15,109,217,97,222,88,86,26,95,44,97,191,92,252,78,199,16,59,195,34,25,87,19,136,113,61,201,36,133,218,250,38,12,63,63,133,18,135,11,222,66,108,36,108,224,15,187,253,0,212,67,124,110,194,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntitySchemaUIdEmptyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e8c5e4d1-d68b-480b-af21-17497950cc0f"),
				Name = "IsEntitySchemaUIdEmpty",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,206,65,10,194,48,16,133,225,189,167,24,47,144,11,148,172,106,148,130,130,80,60,192,52,29,76,48,205,200,100,178,200,237,13,218,141,171,183,249,248,121,11,115,2,161,82,147,130,133,59,62,201,184,172,81,219,9,21,103,174,226,201,204,62,208,134,143,105,5,107,225,82,227,106,220,246,214,54,28,190,252,28,147,146,140,156,85,56,93,177,113,213,158,192,37,81,247,112,252,181,119,59,149,27,170,15,29,175,81,35,231,226,250,154,49,144,127,253,107,33,173,146,247,99,195,7,5,93,14,202,165,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b74a8e4c-d50f-431d-951c-c98254cddeda"),
				Name = "CreateColumnValuesVds",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,77,111,194,48,12,61,175,191,34,234,169,72,83,249,1,136,195,70,37,214,3,19,82,89,239,94,99,88,164,52,69,73,202,96,19,255,125,78,90,209,143,113,3,113,105,147,103,251,61,63,199,7,208,236,192,13,155,51,133,223,44,23,218,214,32,19,176,144,85,181,46,48,154,176,223,224,41,77,40,30,46,42,89,151,42,7,89,163,201,185,9,131,243,44,88,195,14,99,247,89,84,202,130,80,168,99,119,210,149,52,241,11,231,17,81,79,102,65,48,157,178,12,173,23,74,57,219,86,154,21,32,81,113,18,183,26,145,237,180,224,13,87,95,100,67,161,37,69,226,174,31,170,158,59,154,56,77,136,182,195,51,171,235,194,214,26,93,176,187,52,185,9,110,47,16,85,245,51,226,181,22,37,232,83,35,251,14,165,171,9,83,30,206,174,166,37,194,236,37,140,178,221,63,116,188,228,102,87,11,158,28,44,193,31,6,53,141,66,97,97,69,165,188,5,239,106,115,218,227,10,20,121,213,241,18,109,170,140,5,85,224,235,201,209,68,225,146,8,66,26,153,35,43,225,152,137,31,220,224,209,222,196,185,234,120,28,245,208,25,189,82,99,39,114,11,112,101,162,109,212,47,66,111,64,207,180,22,38,23,70,124,74,7,109,65,26,244,216,155,224,8,99,48,171,180,29,129,131,238,9,111,71,23,156,239,211,226,10,45,172,193,126,221,191,209,225,179,220,171,95,191,69,164,182,128,189,123,92,130,218,83,147,220,94,70,102,136,240,159,151,11,214,179,210,98,143,113,226,21,134,86,60,244,80,35,127,10,86,92,39,216,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8311eb1b-6952-4a87-945a-28329aff3822"),
				Name = "GetColumnValues",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,141,49,10,194,64,16,69,107,3,185,195,148,10,98,14,16,99,147,116,105,2,33,54,98,49,9,163,174,108,102,97,118,87,12,226,221,93,215,128,69,202,121,255,253,63,89,246,64,1,111,73,74,195,142,158,14,10,232,126,23,211,224,148,225,93,247,15,243,52,49,253,61,112,176,100,173,50,125,133,14,143,168,61,45,107,109,52,248,107,156,74,163,253,200,81,180,243,84,77,211,57,204,169,11,172,151,91,5,176,215,122,3,175,52,89,9,57,47,28,65,240,223,105,50,131,69,11,45,84,42,254,70,153,246,214,137,226,235,22,26,49,67,48,219,225,70,35,54,40,56,146,35,137,141,67,254,1,62,204,172,26,254,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bac5442f-c53c-480d-9e28-d02bd7790b85"),
				Name = "DisplayColumnValues",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,93,79,163,64,20,125,214,196,255,48,233,19,77,28,2,148,150,18,173,9,159,166,113,117,155,245,227,125,132,171,146,165,67,51,12,54,141,250,223,247,50,212,21,20,63,95,104,152,222,123,206,185,103,230,48,247,76,144,251,180,36,51,178,96,183,160,215,143,160,224,146,101,28,132,30,103,60,173,223,68,145,107,131,160,200,171,37,191,98,121,5,229,85,90,14,134,132,149,228,42,19,178,98,121,200,36,59,47,42,145,192,193,222,46,194,233,65,14,76,104,67,124,11,179,68,102,5,103,98,115,88,74,145,241,219,125,178,16,69,2,101,121,158,220,193,146,45,152,96,75,144,32,20,242,17,73,90,52,168,234,24,100,155,88,65,102,55,68,235,150,205,8,175,242,124,72,30,246,118,119,4,200,74,112,44,123,122,91,169,7,69,197,101,93,111,144,199,71,18,113,153,201,77,163,227,114,158,214,235,199,85,150,234,209,114,37,55,13,90,61,204,175,130,165,127,138,117,67,222,193,111,3,16,104,191,204,200,101,9,2,205,227,160,230,215,219,165,167,140,163,207,66,199,225,230,188,148,140,39,224,111,80,128,246,74,144,242,15,173,85,226,47,54,43,216,54,146,180,111,241,13,101,95,43,34,206,35,94,45,65,176,235,28,14,251,74,230,18,150,71,93,138,122,169,222,141,62,94,53,69,253,191,178,231,30,207,83,94,20,127,171,85,7,90,185,75,56,172,149,193,218,224,193,183,220,177,225,152,49,117,34,207,165,54,76,44,58,13,77,143,186,166,235,199,35,103,100,197,177,245,52,120,70,68,94,184,200,150,240,49,102,104,153,145,27,197,54,13,140,137,77,109,195,180,168,111,77,39,52,246,76,111,106,58,102,232,217,118,23,243,99,188,137,49,10,109,119,98,80,236,183,168,61,6,23,241,70,22,181,140,137,55,182,109,203,244,13,243,5,79,126,170,207,176,131,192,25,59,62,157,198,198,132,218,83,43,161,83,132,166,70,96,68,181,60,203,54,141,23,60,60,183,133,248,100,96,47,246,209,67,151,70,145,27,163,137,198,53,245,236,208,161,35,199,243,204,177,59,117,204,241,184,1,188,41,4,176,228,142,104,39,176,81,120,11,150,137,111,7,146,100,188,147,207,38,34,205,161,37,162,88,163,58,21,126,228,146,128,137,217,6,166,88,235,231,157,24,107,131,121,58,216,111,178,118,6,107,53,205,240,221,218,83,144,40,74,222,97,71,139,92,199,73,84,75,59,51,77,223,182,12,213,180,35,89,159,211,118,149,191,121,6,214,250,96,251,148,156,161,49,255,85,232,1,91,213,49,83,213,141,147,36,205,202,85,206,26,135,145,190,141,219,60,195,86,65,221,247,242,129,210,223,110,245,236,157,36,53,182,239,124,155,236,137,64,94,226,38,126,204,249,94,214,106,202,29,252,104,126,210,250,131,182,190,228,124,161,173,55,32,63,246,102,187,25,205,70,234,243,242,12,47,148,223,66,221,4,90,27,109,248,85,134,14,116,223,105,82,63,120,156,58,232,7,219,59,199,75,83,13,155,134,205,61,243,234,22,250,7,87,32,218,131,181,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0478c31b-ad88-45df-879c-6ca37ce4a5cc"),
				Name = "ResetControlValues",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,193,110,194,48,12,134,239,60,69,196,169,189,180,15,128,118,128,174,160,29,54,77,32,245,110,26,3,97,169,131,98,7,141,183,95,147,34,218,237,48,46,73,156,124,255,255,219,41,203,79,56,98,241,198,239,32,237,169,114,164,141,24,71,92,247,123,177,11,124,65,210,203,51,124,215,87,36,225,44,95,204,202,255,20,213,9,219,47,212,234,69,29,192,50,46,102,53,193,222,226,218,88,65,31,137,232,112,5,175,14,143,155,141,119,225,210,11,146,107,77,98,228,246,10,2,59,23,124,139,197,218,144,30,212,156,192,213,237,3,58,204,18,60,186,78,142,137,138,76,31,244,39,164,168,44,130,127,58,195,22,57,116,248,123,232,33,48,46,61,44,96,8,125,106,45,86,222,217,108,94,57,27,58,106,192,6,228,70,243,60,87,192,170,49,94,2,216,113,156,124,108,97,131,50,213,100,147,167,225,207,238,214,49,254,7,114,47,196,175,165,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnableFilterEditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("154501c0-4122-4f15-9073-975b9a36cd54"),
				Name = "EnableFilterEdit",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,203,204,41,73,45,114,206,207,43,41,202,207,241,73,172,204,47,45,209,115,205,75,76,202,73,77,81,176,85,8,0,41,241,44,246,77,44,73,206,0,170,73,201,44,201,204,207,43,118,5,210,122,206,25,169,201,217,169,41,214,188,92,1,8,115,192,50,36,105,7,0,5,169,108,124,133,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnableControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7498501e-a69d-477c-8d63-85c76226514f"),
				Name = "EnableControls",
				CreatedInSchemaUId = new Guid("76598e82-6add-4234-a0db-072a60cbb96c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,205,43,201,44,169,12,78,206,72,205,77,12,245,76,209,115,45,44,77,204,41,214,112,47,205,4,178,115,11,74,42,53,53,21,170,121,185,56,3,18,211,83,245,60,139,125,19,75,146,51,156,243,243,82,50,75,50,243,243,138,93,129,180,158,115,70,106,114,118,106,138,130,173,66,26,80,107,170,53,126,213,174,121,137,73,57,96,213,64,117,16,133,142,41,41,78,165,37,37,249,121,216,36,65,154,112,203,186,164,230,164,150,164,98,200,195,28,82,171,144,10,100,16,242,0,93,156,84,82,84,10,118,17,47,23,68,204,45,51,167,36,181,8,100,148,134,166,53,0,94,56,124,120,138,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeDataUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76598e82-6add-4234-a0db-072a60cbb96c"));
		}

		#endregion

	}

	#endregion

}

