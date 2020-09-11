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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeAdminRightsUserTaskParametersEditPageSchema

	/// <exclude/>
	public class ChangeAdminRightsUserTaskParametersEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
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

		private Terrasoft.UI.WebControls.Controls.LookupEdit _entitySchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaEdit {
			get {
				return _entitySchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
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

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout5;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return _controlLayout5;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout6;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return _controlLayout6;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteRightAddButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteRightAddButton {
			get {
				return _deleteRightAddButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteRightEditButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteRightEditButton {
			get {
				return _deleteRightEditButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteRightDeleteButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteRightDeleteButton {
			get {
				return _deleteRightDeleteButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _deleteRightsTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid DeleteRightsTreeGrid {
			get {
				return _deleteRightsTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout4;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return _controlLayout4;
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

		private Terrasoft.UI.WebControls.Controls.Button _addRightAddButton;
		public Terrasoft.UI.WebControls.Controls.Button AddRightAddButton {
			get {
				return _addRightAddButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addRightEditButton;
		public Terrasoft.UI.WebControls.Controls.Button AddRightEditButton {
			get {
				return _addRightEditButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addRighDeletetButton;
		public Terrasoft.UI.WebControls.Controls.Button AddRighDeletetButton {
			get {
				return _addRighDeletetButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer2;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return _spacer2;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _upRighDeletetButton;
		public Terrasoft.UI.WebControls.Controls.Button UpRighDeletetButton {
			get {
				return _upRighDeletetButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _downRighDeletetButton;
		public Terrasoft.UI.WebControls.Controls.Button DownRighDeletetButton {
			get {
				return _downRighDeletetButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _addRightsTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid AddRightsTreeGrid {
			get {
				return _addRightsTreeGrid;
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

		public ChangeAdminRightsUserTaskParametersEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ChangeAdminRightsUserTaskParametersEditPageSchema(ChangeAdminRightsUserTaskParametersEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			RealUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			Name = "ChangeAdminRightsUserTaskParametersEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			Height = 600;
			HelpContextId = "793";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema();
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
			ControlLayout1.InsertItem(1, CreateEntitySchemaEdit());
			TopControlLayout.InsertItem(1, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateFilterEdit());
			TopControlLayout.InsertItem(2, CreateControlLayout3());
			ControlLayout3.InsertItem(0, CreateControlLayout5());
			ControlLayout5.InsertItem(0, CreateControlLayout6());
			ControlLayout6.InsertItem(0, CreateDeleteRightAddButton());
			ControlLayout6.InsertItem(1, CreateDeleteRightEditButton());
			ControlLayout6.InsertItem(2, CreateDeleteRightDeleteButton());
			ControlLayout5.InsertItem(1, CreateDeleteRightsTreeGrid());
			TopControlLayout.InsertItem(3, CreateControlLayout4());
			ControlLayout4.InsertItem(0, CreateControlLayout7());
			ControlLayout7.InsertItem(0, CreateControlLayout10());
			ControlLayout10.InsertItem(0, CreateAddRightAddButton());
			ControlLayout10.InsertItem(1, CreateAddRightEditButton());
			ControlLayout10.InsertItem(2, CreateAddRighDeletetButton());
			ControlLayout10.InsertItem(3, CreateSpacer2());
			ControlLayout10.InsertItem(4, CreateUpRighDeletetButton());
			ControlLayout10.InsertItem(5, CreateDownRighDeletetButton());
			ControlLayout7.InsertItem(1, CreateAddRightsTreeGrid());
			TopControlLayout.InsertItem(4, CreateEntityDataSource());
			UpdateEntityDataSource();
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema() {
			var schema = new ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateUserTaskTitleEdit() {
			_userTaskTitleEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_userTaskTitleEdit.UId = new Guid("cd9a5fef-6874-47d0-a974-4d495420e716");
			_userTaskTitleEdit.Name = "UserTaskTitleEdit";
			_userTaskTitleEdit.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_userTaskTitleEdit.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_userTaskTitleEdit.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_userTaskTitleEdit.Tag = "";
			_userTaskTitleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_userTaskTitleEdit.Image = new ControlImage {};
			_userTaskTitleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _userTaskTitleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateEntitySchemaEdit() {
			_entitySchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_entitySchemaEdit.UId = new Guid("d4a43837-52ec-4f91-a1eb-6e2609a35dd9");
			_entitySchemaEdit.Name = "EntitySchemaEdit";
			_entitySchemaEdit.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_entitySchemaEdit.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_entitySchemaEdit.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_entitySchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_entitySchemaEdit.Tag = "";
			_entitySchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_entitySchemaEdit.Image = new ControlImage {};
			_entitySchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_entitySchemaEdit.Required = true;
			_entitySchemaEdit.LookupSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			return _entitySchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("3d4b47d6-06d7-44d1-8f42-df032d9b8792");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout1.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout1.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.FilterEdit CreateFilterEdit() {
			_filterEdit = new Terrasoft.UI.WebControls.Controls.FilterEdit();
			_filterEdit.UId = new Guid("f0c48411-da30-4a55-9089-1d3fb03b6eda");
			_filterEdit.Name = "FilterEdit";
			_filterEdit.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_filterEdit.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_filterEdit.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_filterEdit.Tag = "";
			_filterEdit.DataSourceId = "EntityDataSource";
			_filterEdit.Edges = "1 1 1 1";
			_filterEdit.HasSplitter = true;
			_filterEdit.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_filterEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _filterEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("1acbc7c1-6361-4ecb-b9eb-a9b02ffcb2a4");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout2.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout2.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(130);
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.Padding = "0 0 0 15";
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "0 0 0 0";
			return _controlLayout2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteRightAddButton() {
			_deleteRightAddButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteRightAddButton.UId = new Guid("2b7e7034-7e49-4c7b-9521-f2ad76726415");
			_deleteRightAddButton.Name = "DeleteRightAddButton";
			_deleteRightAddButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightAddButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightAddButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_deleteRightAddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteRightAddButton.Tag = "";
			_deleteRightAddButton.Image = new ControlImage {};
			return _deleteRightAddButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteRightEditButton() {
			_deleteRightEditButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteRightEditButton.UId = new Guid("adc29e1e-01d7-4243-b785-864c81d5767a");
			_deleteRightEditButton.Name = "DeleteRightEditButton";
			_deleteRightEditButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightEditButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightEditButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_deleteRightEditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteRightEditButton.Tag = "";
			_deleteRightEditButton.Image = new ControlImage {};
			_deleteRightEditButton.Enabled = false;
			return _deleteRightEditButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteRightDeleteButton() {
			_deleteRightDeleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteRightDeleteButton.UId = new Guid("0084de8f-b3d9-4310-bf55-fea7582fa61c");
			_deleteRightDeleteButton.Name = "DeleteRightDeleteButton";
			_deleteRightDeleteButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightDeleteButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightDeleteButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_deleteRightDeleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteRightDeleteButton.Tag = "";
			_deleteRightDeleteButton.Image = new ControlImage {};
			_deleteRightDeleteButton.Enabled = false;
			return _deleteRightDeleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout6() {
			_controlLayout6 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout6.UId = new Guid("4aa00872-f299-4dae-b9a7-4c73bb69f3c9");
			_controlLayout6.Name = "ControlLayout6";
			_controlLayout6.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout6.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout6.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout6.Tag = "";
			_controlLayout6.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout6.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_controlLayout6.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout6.StartNewAlignGroup = false;
			_controlLayout6.Image = new ControlImage {};
			_controlLayout6.Edges = "";
			return _controlLayout6;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateDeleteRightsTreeGrid() {
			_deleteRightsTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_deleteRightsTreeGrid.UId = new Guid("e6ea0d8b-6552-4f84-b75f-d63f21eb7418");
			_deleteRightsTreeGrid.Name = "DeleteRightsTreeGrid";
			_deleteRightsTreeGrid.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightsTreeGrid.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_deleteRightsTreeGrid.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_deleteRightsTreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			_deleteRightsTreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
			_deleteRightsTreeGrid.Tag = "";
			_deleteRightsTreeGrid.Edges = "0 1 1 1";
			_deleteRightsTreeGrid.IsColumnAutowidth = true;
			_deleteRightsTreeGrid.FooterVisible = false;
			_deleteRightsTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_deleteRightsTreeGrid.IsSummaryVisible = false;
			_deleteRightsTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_deleteRightsTreeGrid.HideHeaders = false;
			return _deleteRightsTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout5() {
			_controlLayout5 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout5.UId = new Guid("581b6b1c-a507-4273-b36b-fac254b5f94a");
			_controlLayout5.Name = "ControlLayout5";
			_controlLayout5.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout5.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout5.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout5.Tag = "";
			_controlLayout5.Height = System.Web.UI.WebControls.Unit.Percentage(35);
			_controlLayout5.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout5.StartNewAlignGroup = false;
			_controlLayout5.Image = new ControlImage {};
			_controlLayout5.Edges = "";
			return _controlLayout5;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout3() {
			_controlLayout3 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout3.UId = new Guid("eafbdcf2-4a15-428f-8293-77471d2cc9f6");
			_controlLayout3.Name = "ControlLayout3";
			_controlLayout3.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout3.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout3.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout3.Tag = "";
			_controlLayout3.Height = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout3.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlLayout3.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout3.Padding = "0 0 0 15";
			_controlLayout3.StartNewAlignGroup = false;
			_controlLayout3.Image = new ControlImage {};
			_controlLayout3.Edges = "";
			return _controlLayout3;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddRightAddButton() {
			_addRightAddButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addRightAddButton.UId = new Guid("fa41d77e-a11f-41cc-85c5-6a6baa08ac06");
			_addRightAddButton.Name = "AddRightAddButton";
			_addRightAddButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRightAddButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRightAddButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_addRightAddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addRightAddButton.Tag = "";
			_addRightAddButton.Image = new ControlImage {};
			return _addRightAddButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddRightEditButton() {
			_addRightEditButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addRightEditButton.UId = new Guid("66f68581-6176-473b-901b-c99f035adfc4");
			_addRightEditButton.Name = "AddRightEditButton";
			_addRightEditButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRightEditButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRightEditButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_addRightEditButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addRightEditButton.Tag = "";
			_addRightEditButton.Image = new ControlImage {};
			_addRightEditButton.Enabled = false;
			return _addRightEditButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddRighDeletetButton() {
			_addRighDeletetButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addRighDeletetButton.UId = new Guid("d49307eb-c151-44e7-bc20-f25eda667d26");
			_addRighDeletetButton.Name = "AddRighDeletetButton";
			_addRighDeletetButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRighDeletetButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRighDeletetButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_addRighDeletetButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addRighDeletetButton.Tag = "";
			_addRighDeletetButton.Image = new ControlImage {};
			_addRighDeletetButton.Enabled = false;
			return _addRighDeletetButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer2() {
			_spacer2 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer2.UId = new Guid("bd1088c2-d733-4f0a-a8c7-f42e341bdd07");
			_spacer2.Name = "Spacer2";
			_spacer2.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_spacer2.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_spacer2.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_spacer2.Tag = "";
			_spacer2.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer2;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateUpRighDeletetButton() {
			_upRighDeletetButton = new Terrasoft.UI.WebControls.Controls.Button();
			_upRighDeletetButton.UId = new Guid("9c48f142-af7a-49a3-85b2-e199a2ef5ff3");
			_upRighDeletetButton.Name = "UpRighDeletetButton";
			_upRighDeletetButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_upRighDeletetButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_upRighDeletetButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_upRighDeletetButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_upRighDeletetButton.Tag = "";
			_upRighDeletetButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26"),
				ImageHash = @"d4d31ed5022c4f2895a9e06f3c42cfe5"
			};
			_upRighDeletetButton.Enabled = false;
			return _upRighDeletetButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDownRighDeletetButton() {
			_downRighDeletetButton = new Terrasoft.UI.WebControls.Controls.Button();
			_downRighDeletetButton.UId = new Guid("22bed003-c9df-44c9-9d00-cf636fc55710");
			_downRighDeletetButton.Name = "DownRighDeletetButton";
			_downRighDeletetButton.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_downRighDeletetButton.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_downRighDeletetButton.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_downRighDeletetButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_downRighDeletetButton.Tag = "";
			_downRighDeletetButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26"),
				ImageHash = @"fadb6ef880023738c3c59b2fe60b5216"
			};
			_downRighDeletetButton.Enabled = false;
			return _downRighDeletetButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout10() {
			_controlLayout10 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout10.UId = new Guid("11340e4b-a82d-4fda-adba-2a2ca614ce11");
			_controlLayout10.Name = "ControlLayout10";
			_controlLayout10.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout10.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout10.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout10.Tag = "";
			_controlLayout10.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout10.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_controlLayout10.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout10.StartNewAlignGroup = false;
			_controlLayout10.Image = new ControlImage {};
			_controlLayout10.Edges = "";
			return _controlLayout10;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateAddRightsTreeGrid() {
			_addRightsTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_addRightsTreeGrid.UId = new Guid("d9f112ab-e523-4a93-8843-58ec68a369b7");
			_addRightsTreeGrid.Name = "AddRightsTreeGrid";
			_addRightsTreeGrid.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRightsTreeGrid.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_addRightsTreeGrid.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_addRightsTreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
			_addRightsTreeGrid.AjaxEvents.SelectionChange.IsProcessEventHandler = true;
			_addRightsTreeGrid.Tag = "";
			_addRightsTreeGrid.Edges = "0 1 1 1";
			_addRightsTreeGrid.IsColumnAutowidth = true;
			_addRightsTreeGrid.FooterVisible = false;
			_addRightsTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_addRightsTreeGrid.IsSummaryVisible = false;
			_addRightsTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_addRightsTreeGrid.ToolbarVisible = false;
			_addRightsTreeGrid.HideHeaders = false;
			return _addRightsTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout7() {
			_controlLayout7 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout7.UId = new Guid("81b6c10a-2ffd-40ea-b70b-2a97967f64a4");
			_controlLayout7.Name = "ControlLayout7";
			_controlLayout7.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout7.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout7.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout7.Tag = "";
			_controlLayout7.Height = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout7.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout7.StartNewAlignGroup = false;
			_controlLayout7.Image = new ControlImage {};
			_controlLayout7.Edges = "";
			return _controlLayout7;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout4() {
			_controlLayout4 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout4.UId = new Guid("b01dcbff-5fec-42c4-92ed-503527b80f6f");
			_controlLayout4.Name = "ControlLayout4";
			_controlLayout4.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout4.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_controlLayout4.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_controlLayout4.Tag = "";
			_controlLayout4.Height = System.Web.UI.WebControls.Unit.Percentage(50);
			_controlLayout4.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout4.Padding = "0 0 0 15";
			_controlLayout4.StartNewAlignGroup = false;
			_controlLayout4.Image = new ControlImage {};
			_controlLayout4.Edges = "";
			return _controlLayout4;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateEntityDataSource() {
			_entityDataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_entityDataSource.UId = new Guid("3632010d-ca57-437a-b5eb-767392e1cf61");
			_entityDataSource.Name = "EntityDataSource";
			_entityDataSource.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_entityDataSource.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_entityDataSource.CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
			_entityDataSource.Tag = "";
			_entityDataSource.EnableServerActiveRow = false;
			_entityDataSource.SchemaUId = Guid.Empty;
			_entityDataSource.HierarchicalDepth = 1;
			_entityDataSource.DefStructure.ID = "c" + _entityDataSource.DefStructure.UId.ToString("N");
			_entityDataSource.DefStructure.UId = new Guid("aaaa50a0-69af-4a7e-a7b2-c244f26af9d6");
			_entityDataSource.DefStructure.Name = "DefStructure";
			_entityDataSource.DefStructure.CreatedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			_entityDataSource.DefStructure.ModifiedInSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
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
			return new ChangeAdminRightsUserTaskParametersEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ChangeAdminRightsUserTaskParametersEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f56a492-8454-4672-9df3-6ce613708c26"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ChangeAdminRightsUserTaskParametersEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeAdminRightsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ChangeAdminRightsUserTaskParametersEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ChangeAdminRightsUserTaskParametersEditPageSchemaUserControl
	{

		#region Class: OpenAddRightsRecordEditPageOnAddFlowElement

		/// <exclude/>
		public class OpenAddRightsRecordEditPageOnAddFlowElement : OpenPageUserTask
		{

			public OpenAddRightsRecordEditPageOnAddFlowElement(UserConnection userConnection, ChangeAdminRightsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenAddRightsRecordEditPageOnAdd";
				IsLogging = false;
				SchemaElementUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenAddRightsRecordEditPageOnEditFlowElement

		/// <exclude/>
		public class OpenAddRightsRecordEditPageOnEditFlowElement : OpenPageUserTask
		{

			public OpenAddRightsRecordEditPageOnEditFlowElement(UserConnection userConnection, ChangeAdminRightsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenAddRightsRecordEditPageOnEdit";
				IsLogging = false;
				SchemaElementUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenDeleteRightsRecordEditPageOnAddFlowElement

		/// <exclude/>
		public class OpenDeleteRightsRecordEditPageOnAddFlowElement : OpenPageUserTask
		{

			public OpenDeleteRightsRecordEditPageOnAddFlowElement(UserConnection userConnection, ChangeAdminRightsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenDeleteRightsRecordEditPageOnAdd";
				IsLogging = false;
				SchemaElementUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: DeleteRightEditButtonClickOnEditFlowElement

		/// <exclude/>
		public class DeleteRightEditButtonClickOnEditFlowElement : OpenPageUserTask
		{

			public DeleteRightEditButtonClickOnEditFlowElement(UserConnection userConnection, ChangeAdminRightsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DeleteRightEditButtonClickOnEdit";
				IsLogging = false;
				SchemaElementUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: ChangeSchemaEntityUserMessageFlowElement

		/// <exclude/>
		public class ChangeSchemaEntityUserMessageFlowElement : QuestionUserTask
		{

			public ChangeSchemaEntityUserMessageFlowElement(UserConnection userConnection, ChangeAdminRightsUserTaskParametersEditPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeSchemaEntityUserMessage";
				IsLogging = false;
				SchemaElementUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ChangeAdminRightsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeAdminRightsUserTaskParametersEditPageEventsProcess";
			SchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6f56a492-8454-4672-9df3-6ce613708c26");
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

		public virtual string DeleteRightsSessionKey {
			get;
			set;
		}

		public virtual string AddRightsSessionKey {
			get;
			set;
		}

		public virtual bool IsValidDataSourceFilter {
			get;
			set;
		}

		public virtual string InsertedDeleteRightColumnValueKey {
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

		public virtual Guid LookupTypeUId {
			get;
			set;
		}

		public virtual Object UserTaskParameterNames {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess15;
		public ProcessFlowElement EventSubProcess15 {
			get {
				return _eventSubProcess15 ?? (_eventSubProcess15 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess15",
					SchemaElementUId = new Guid("eceb638f-9f2f-4f85-aada-2f9dc3c91115"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRightAddButtonClickStartMessage1;
		public ProcessFlowElement AddRightAddButtonClickStartMessage1 {
			get {
				return _addRightAddButtonClickStartMessage1 ?? (_addRightAddButtonClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRightAddButtonClickStartMessage1",
					SchemaElementUId = new Guid("52be3440-d422-464b-934d-9105a4234bde"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addRightAddButtonClickScriptTask1;
		public ProcessScriptTask AddRightAddButtonClickScriptTask1 {
			get {
				return _addRightAddButtonClickScriptTask1 ?? (_addRightAddButtonClickScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddRightAddButtonClickScriptTask1",
					SchemaElementUId = new Guid("75a35d2f-6959-44f0-91f2-738a425a7e48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddRightAddButtonClickScriptTask1Execute,
				});
			}
		}

		private OpenAddRightsRecordEditPageOnAddFlowElement _openAddRightsRecordEditPageOnAdd;
		public OpenAddRightsRecordEditPageOnAddFlowElement OpenAddRightsRecordEditPageOnAdd {
			get {
				return _openAddRightsRecordEditPageOnAdd ?? (_openAddRightsRecordEditPageOnAdd = new OpenAddRightsRecordEditPageOnAddFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess16;
		public ProcessFlowElement EventSubProcess16 {
			get {
				return _eventSubProcess16 ?? (_eventSubProcess16 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess16",
					SchemaElementUId = new Guid("4ec017bd-3329-49c1-9912-511a04829f35"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRightsRecordEditPageClosedStartMessage1;
		public ProcessFlowElement AddRightsRecordEditPageClosedStartMessage1 {
			get {
				return _addRightsRecordEditPageClosedStartMessage1 ?? (_addRightsRecordEditPageClosedStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRightsRecordEditPageClosedStartMessage1",
					SchemaElementUId = new Guid("ac0f8a9c-5906-47e9-957f-cfd0f15a21a4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addRightsRecordEditPageClosedScriptTask1;
		public ProcessScriptTask AddRightsRecordEditPageClosedScriptTask1 {
			get {
				return _addRightsRecordEditPageClosedScriptTask1 ?? (_addRightsRecordEditPageClosedScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddRightsRecordEditPageClosedScriptTask1",
					SchemaElementUId = new Guid("5c7ac767-04b2-49a0-a82f-f32a5e6f3725"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddRightsRecordEditPageClosedScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess17;
		public ProcessFlowElement EventSubProcess17 {
			get {
				return _eventSubProcess17 ?? (_eventSubProcess17 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess17",
					SchemaElementUId = new Guid("09eeceb8-4d5f-412b-b647-c0a75807ff8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRightEditButtonClickStartMessage1;
		public ProcessFlowElement AddRightEditButtonClickStartMessage1 {
			get {
				return _addRightEditButtonClickStartMessage1 ?? (_addRightEditButtonClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRightEditButtonClickStartMessage1",
					SchemaElementUId = new Guid("4212ed84-0906-406f-a47d-532180d69c02"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addRightEditButtonClickScriptTask1;
		public ProcessScriptTask AddRightEditButtonClickScriptTask1 {
			get {
				return _addRightEditButtonClickScriptTask1 ?? (_addRightEditButtonClickScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddRightEditButtonClickScriptTask1",
					SchemaElementUId = new Guid("ef1d3ff8-8993-44e4-a6c3-ea888cf8c641"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddRightEditButtonClickScriptTask1Execute,
				});
			}
		}

		private OpenAddRightsRecordEditPageOnEditFlowElement _openAddRightsRecordEditPageOnEdit;
		public OpenAddRightsRecordEditPageOnEditFlowElement OpenAddRightsRecordEditPageOnEdit {
			get {
				return _openAddRightsRecordEditPageOnEdit ?? (_openAddRightsRecordEditPageOnEdit = new OpenAddRightsRecordEditPageOnEditFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess21;
		public ProcessFlowElement EventSubProcess21 {
			get {
				return _eventSubProcess21 ?? (_eventSubProcess21 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess21",
					SchemaElementUId = new Guid("78807e49-fd43-48d0-a14e-b484aaf3d286"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRightsTreeGridDblClickStartMessage1;
		public ProcessFlowElement AddRightsTreeGridDblClickStartMessage1 {
			get {
				return _addRightsTreeGridDblClickStartMessage1 ?? (_addRightsTreeGridDblClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRightsTreeGridDblClickStartMessage1",
					SchemaElementUId = new Guid("8ee24dfa-0f1f-4cef-8404-a6bf87a96e8e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _addRightEditButtonClickIntermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent AddRightEditButtonClickIntermediateThrowMessageEvent2 {
			get {
				return _addRightEditButtonClickIntermediateThrowMessageEvent2 ?? (_addRightEditButtonClickIntermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "AddRightEditButtonClickIntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("497e6229-f61b-442e-b1ea-f8ee2fef08f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "AddRightEditButtonClick",
				});
			}
		}

		private ProcessFlowElement _eventSubProcess18;
		public ProcessFlowElement EventSubProcess18 {
			get {
				return _eventSubProcess18 ?? (_eventSubProcess18 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess18",
					SchemaElementUId = new Guid("0c9f70f6-617f-4e08-8065-5b5bde303fec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRighDeletetButtonClickStartMessage2;
		public ProcessFlowElement AddRighDeletetButtonClickStartMessage2 {
			get {
				return _addRighDeletetButtonClickStartMessage2 ?? (_addRighDeletetButtonClickStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRighDeletetButtonClickStartMessage2",
					SchemaElementUId = new Guid("a6410d62-f9eb-4e73-9889-cebe6720e6c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addRighDeletetButtonClickScriptTask2;
		public ProcessScriptTask AddRighDeletetButtonClickScriptTask2 {
			get {
				return _addRighDeletetButtonClickScriptTask2 ?? (_addRighDeletetButtonClickScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddRighDeletetButtonClickScriptTask2",
					SchemaElementUId = new Guid("9868acf7-57e8-4dbd-9d5f-20dd64f278af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddRighDeletetButtonClickScriptTask2Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess20;
		public ProcessFlowElement EventSubProcess20 {
			get {
				return _eventSubProcess20 ?? (_eventSubProcess20 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess20",
					SchemaElementUId = new Guid("fe609841-4724-4afe-8bad-12521a9c90df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _downRighDeletetButtonClickStartMessage4;
		public ProcessFlowElement DownRighDeletetButtonClickStartMessage4 {
			get {
				return _downRighDeletetButtonClickStartMessage4 ?? (_downRighDeletetButtonClickStartMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DownRighDeletetButtonClickStartMessage4",
					SchemaElementUId = new Guid("f99caa27-0e70-461a-b2bf-ab93178d0378"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _downRighDeletetButtonClickScriptTask4;
		public ProcessScriptTask DownRighDeletetButtonClickScriptTask4 {
			get {
				return _downRighDeletetButtonClickScriptTask4 ?? (_downRighDeletetButtonClickScriptTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DownRighDeletetButtonClickScriptTask4",
					SchemaElementUId = new Guid("0c732236-e66a-451e-bb94-95cbe498d8ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DownRighDeletetButtonClickScriptTask4Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess19;
		public ProcessFlowElement EventSubProcess19 {
			get {
				return _eventSubProcess19 ?? (_eventSubProcess19 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess19",
					SchemaElementUId = new Guid("666edfef-7c5f-48ca-b630-58dd3d6bdff2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _upRighDeletetButtonClickStartMessage3;
		public ProcessFlowElement UpRighDeletetButtonClickStartMessage3 {
			get {
				return _upRighDeletetButtonClickStartMessage3 ?? (_upRighDeletetButtonClickStartMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UpRighDeletetButtonClickStartMessage3",
					SchemaElementUId = new Guid("b3d9235b-a90c-4358-9e68-c3fe95f78314"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _upRighDeletetButtonClickScriptTask3;
		public ProcessScriptTask UpRighDeletetButtonClickScriptTask3 {
			get {
				return _upRighDeletetButtonClickScriptTask3 ?? (_upRighDeletetButtonClickScriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpRighDeletetButtonClickScriptTask3",
					SchemaElementUId = new Guid("6827e9bb-4750-4279-97a9-b742d56a6e64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpRighDeletetButtonClickScriptTask3Execute,
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
					SchemaElementUId = new Guid("a816f075-ae13-4bda-8852-6fd59880f5f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteRightAddButtonClickStartMessage1;
		public ProcessFlowElement DeleteRightAddButtonClickStartMessage1 {
			get {
				return _deleteRightAddButtonClickStartMessage1 ?? (_deleteRightAddButtonClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteRightAddButtonClickStartMessage1",
					SchemaElementUId = new Guid("e2515858-06b9-45f8-a214-deada5805aae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteRightAddButtonClickScriptTask1;
		public ProcessScriptTask DeleteRightAddButtonClickScriptTask1 {
			get {
				return _deleteRightAddButtonClickScriptTask1 ?? (_deleteRightAddButtonClickScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteRightAddButtonClickScriptTask1",
					SchemaElementUId = new Guid("eb0b9d63-e5c4-4c9f-a7c6-ce5d5acb8c0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRightAddButtonClickScriptTask1Execute,
				});
			}
		}

		private OpenDeleteRightsRecordEditPageOnAddFlowElement _openDeleteRightsRecordEditPageOnAdd;
		public OpenDeleteRightsRecordEditPageOnAddFlowElement OpenDeleteRightsRecordEditPageOnAdd {
			get {
				return _openDeleteRightsRecordEditPageOnAdd ?? (_openDeleteRightsRecordEditPageOnAdd = new OpenDeleteRightsRecordEditPageOnAddFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("8a30c053-45c4-4676-bbbb-25027ba9fc3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteRightDeleteButtonClickStartMessage3;
		public ProcessFlowElement DeleteRightDeleteButtonClickStartMessage3 {
			get {
				return _deleteRightDeleteButtonClickStartMessage3 ?? (_deleteRightDeleteButtonClickStartMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteRightDeleteButtonClickStartMessage3",
					SchemaElementUId = new Guid("7f6013c3-1aac-41d8-80ce-f10e031806ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteRightDeleteButtonClickScriptTask3;
		public ProcessScriptTask DeleteRightDeleteButtonClickScriptTask3 {
			get {
				return _deleteRightDeleteButtonClickScriptTask3 ?? (_deleteRightDeleteButtonClickScriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteRightDeleteButtonClickScriptTask3",
					SchemaElementUId = new Guid("491dad71-cd8c-4a16-8429-e8e996503786"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRightDeleteButtonClickScriptTask3Execute,
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
					SchemaElementUId = new Guid("dd5784af-443e-4cf6-886a-c5ff812c97a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteRightEditButtonClickStartMessage2;
		public ProcessFlowElement DeleteRightEditButtonClickStartMessage2 {
			get {
				return _deleteRightEditButtonClickStartMessage2 ?? (_deleteRightEditButtonClickStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteRightEditButtonClickStartMessage2",
					SchemaElementUId = new Guid("970525f9-340f-4fab-81ea-ec8d0f395bc0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteRightEditButtonClickScriptTask2;
		public ProcessScriptTask DeleteRightEditButtonClickScriptTask2 {
			get {
				return _deleteRightEditButtonClickScriptTask2 ?? (_deleteRightEditButtonClickScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteRightEditButtonClickScriptTask2",
					SchemaElementUId = new Guid("6e2bb5e3-6617-402d-80d5-06230184bad3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRightEditButtonClickScriptTask2Execute,
				});
			}
		}

		private DeleteRightEditButtonClickOnEditFlowElement _deleteRightEditButtonClickOnEdit;
		public DeleteRightEditButtonClickOnEditFlowElement DeleteRightEditButtonClickOnEdit {
			get {
				return _deleteRightEditButtonClickOnEdit ?? (_deleteRightEditButtonClickOnEdit = new DeleteRightEditButtonClickOnEditFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("c0c60bb7-6915-473f-8fda-421c2fbc918f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteRightsTreeGridDblClickStartMessage1;
		public ProcessFlowElement DeleteRightsTreeGridDblClickStartMessage1 {
			get {
				return _deleteRightsTreeGridDblClickStartMessage1 ?? (_deleteRightsTreeGridDblClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteRightsTreeGridDblClickStartMessage1",
					SchemaElementUId = new Guid("5fcb32d2-99d4-4ab3-a8aa-d218a4526c63"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _deleteRightEditButtonClickIntermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent DeleteRightEditButtonClickIntermediateThrowMessageEvent2 {
			get {
				return _deleteRightEditButtonClickIntermediateThrowMessageEvent2 ?? (_deleteRightEditButtonClickIntermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "DeleteRightEditButtonClickIntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("06e1dda5-4878-4f3f-8aa1-d387b030be12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DeleteRightEditButtonClick",
				});
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
					SchemaElementUId = new Guid("0e5de09a-7c22-4e7b-a1b1-683dbb99eb86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteRightsRecordEditPageClosedStartMessage1;
		public ProcessFlowElement DeleteRightsRecordEditPageClosedStartMessage1 {
			get {
				return _deleteRightsRecordEditPageClosedStartMessage1 ?? (_deleteRightsRecordEditPageClosedStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteRightsRecordEditPageClosedStartMessage1",
					SchemaElementUId = new Guid("fb93f579-a8fa-4137-a260-716bb3f5a914"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteRightsRecordEditPageClosedScriptTask1;
		public ProcessScriptTask DeleteRightsRecordEditPageClosedScriptTask1 {
			get {
				return _deleteRightsRecordEditPageClosedScriptTask1 ?? (_deleteRightsRecordEditPageClosedScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteRightsRecordEditPageClosedScriptTask1",
					SchemaElementUId = new Guid("ff79d4ed-1941-4571-a11f-0e4ddbc92721"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRightsRecordEditPageClosedScriptTask1Execute,
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
					SchemaElementUId = new Guid("d6c4d4ec-2307-4a25-9259-37c714466b0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addRightsTreeGridSelectionChangeStartMessage2;
		public ProcessFlowElement AddRightsTreeGridSelectionChangeStartMessage2 {
			get {
				return _addRightsTreeGridSelectionChangeStartMessage2 ?? (_addRightsTreeGridSelectionChangeStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddRightsTreeGridSelectionChangeStartMessage2",
					SchemaElementUId = new Guid("3c4cb0e7-e65d-4bf6-898c-d1c9a31f27c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addRightsTreeGridSelectionChangeScriptTask2;
		public ProcessScriptTask AddRightsTreeGridSelectionChangeScriptTask2 {
			get {
				return _addRightsTreeGridSelectionChangeScriptTask2 ?? (_addRightsTreeGridSelectionChangeScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddRightsTreeGridSelectionChangeScriptTask2",
					SchemaElementUId = new Guid("9773719b-91cb-4bb0-8ad9-980567e8f2ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddRightsTreeGridSelectionChangeScriptTask2Execute,
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
					SchemaElementUId = new Guid("a3e3999f-ed78-4072-9806-02d60e1f61df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteRightsTreeGridSelectionChangeStartMessage1;
		public ProcessFlowElement DeleteRightsTreeGridSelectionChangeStartMessage1 {
			get {
				return _deleteRightsTreeGridSelectionChangeStartMessage1 ?? (_deleteRightsTreeGridSelectionChangeStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteRightsTreeGridSelectionChangeStartMessage1",
					SchemaElementUId = new Guid("c705debe-a8b4-411b-9a6d-d3c636aa9ab0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteRightsTreeGridSelectionChangeScriptTask1;
		public ProcessScriptTask DeleteRightsTreeGridSelectionChangeScriptTask1 {
			get {
				return _deleteRightsTreeGridSelectionChangeScriptTask1 ?? (_deleteRightsTreeGridSelectionChangeScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteRightsTreeGridSelectionChangeScriptTask1",
					SchemaElementUId = new Guid("279df4de-07ac-48e9-a0a5-4beb9c7f2e5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteRightsTreeGridSelectionChangeScriptTask1Execute,
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
					SchemaElementUId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _entitySchemaEditChangeStartMessage1;
		public ProcessFlowElement EntitySchemaEditChangeStartMessage1 {
			get {
				return _entitySchemaEditChangeStartMessage1 ?? (_entitySchemaEditChangeStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EntitySchemaEditChangeStartMessage1",
					SchemaElementUId = new Guid("6539cdb8-53df-421c-8bb4-8777863e51b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _objectEditChangeScriptTask1;
		public ProcessScriptTask ObjectEditChangeScriptTask1 {
			get {
				return _objectEditChangeScriptTask1 ?? (_objectEditChangeScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ObjectEditChangeScriptTask1",
					SchemaElementUId = new Guid("df0226e5-9391-427c-8478-9cc501182d24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ObjectEditChangeScriptTask1Execute,
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
					SchemaElementUId = new Guid("07d8e729-844f-44cb-8639-ea00cfaf872d"),
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

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("06c2438e-1751-4207-8139-ea05c8cc282b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChangeSchemaEntityYesMessage",
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
					SchemaElementUId = new Guid("8ba61907-4a11-4659-b908-bc5721ab60ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityYesMessageStartMessage1;
		public ProcessFlowElement ChangeSchemaEntityYesMessageStartMessage1 {
			get {
				return _changeSchemaEntityYesMessageStartMessage1 ?? (_changeSchemaEntityYesMessageStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityYesMessageStartMessage1",
					SchemaElementUId = new Guid("3de779d6-7534-4e05-aaf2-dd15db8ac124"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeSchemaEntityYesMessageScriptTask1;
		public ProcessScriptTask ChangeSchemaEntityYesMessageScriptTask1 {
			get {
				return _changeSchemaEntityYesMessageScriptTask1 ?? (_changeSchemaEntityYesMessageScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeSchemaEntityYesMessageScriptTask1",
					SchemaElementUId = new Guid("f446def4-6f7a-4514-8ec9-fab02a6e0006"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeSchemaEntityYesMessageScriptTask1Execute,
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
					SchemaElementUId = new Guid("a6e966bb-deea-4f3f-86ce-0d9ba4b3c752"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _changeSchemaEntityNoMessageStartMessage2;
		public ProcessFlowElement ChangeSchemaEntityNoMessageStartMessage2 {
			get {
				return _changeSchemaEntityNoMessageStartMessage2 ?? (_changeSchemaEntityNoMessageStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChangeSchemaEntityNoMessageStartMessage2",
					SchemaElementUId = new Guid("56c142a4-3a74-4249-9a92-f54d885de59b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _changeSchemaEntityNoMessageScriptTask2;
		public ProcessScriptTask ChangeSchemaEntityNoMessageScriptTask2 {
			get {
				return _changeSchemaEntityNoMessageScriptTask2 ?? (_changeSchemaEntityNoMessageScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChangeSchemaEntityNoMessageScriptTask2",
					SchemaElementUId = new Guid("7118b60b-3292-4ca3-87da-baa6637c8e27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChangeSchemaEntityNoMessageScriptTask2Execute,
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
					SchemaElementUId = new Guid("e6808c31-b242-4bcf-89c7-b8eb131ba397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage1;
		public ProcessFlowElement PageLoadCompleteStartMessage1 {
			get {
				return _pageLoadCompleteStartMessage1 ?? (_pageLoadCompleteStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage1",
					SchemaElementUId = new Guid("52e99ed4-2d9e-4987-b967-62390f2c4140"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteIntermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent PageLoadCompleteIntermediateThrowMessageEvent2 {
			get {
				return _pageLoadCompleteIntermediateThrowMessageEvent2 ?? (_pageLoadCompleteIntermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteIntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("79d32c88-8d27-4e80-8fd1-00b0ea13985b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask1;
		public ProcessScriptTask PageLoadCompleteScriptTask1 {
			get {
				return _pageLoadCompleteScriptTask1 ?? (_pageLoadCompleteScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask1",
					SchemaElementUId = new Guid("ecbdfcdd-5543-4356-8dd6-fd88d7d111cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTask1Execute,
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
					SchemaElementUId = new Guid("81668806-1c67-472f-9b82-51844cbad8f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage2;
		public ProcessFlowElement InitStartMessage2 {
			get {
				return _initStartMessage2 ?? (_initStartMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage2",
					SchemaElementUId = new Guid("2275b122-6887-4b74-b002-90f556dd0f97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent3 {
			get {
				return _initIntermediateThrowMessageEvent3 ?? (_initIntermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("9a10726a-7eec-46a3-92c8-b32dd2170c6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _initScriptTask2;
		public ProcessScriptTask InitScriptTask2 {
			get {
				return _initScriptTask2 ?? (_initScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask2",
					SchemaElementUId = new Guid("cc017de6-bd15-41d0-9ae7-a94021ffadba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTask2Execute,
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
					SchemaElementUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
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
					SchemaElementUId = new Guid("10cf12ab-bc97-487d-a2f8-e64c98bf7434"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkDataScriptTask1;
		public ProcessScriptTask CheckDataScriptTask1 {
			get {
				return _checkDataScriptTask1 ?? (_checkDataScriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckDataScriptTask1",
					SchemaElementUId = new Guid("f1f73d7f-c177-4349-89cb-62cde629edeb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckDataScriptTask1Execute,
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
					SchemaElementUId = new Guid("6d6c03ca-81ec-4eb2-aece-da4c1a41394a"),
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

		private ProcessScriptTask _scriptChildOkButtonClick;
		public ProcessScriptTask ScriptChildOkButtonClick {
			get {
				return _scriptChildOkButtonClick ?? (_scriptChildOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildOkButtonClick",
					SchemaElementUId = new Guid("d98e88fb-d6f1-4072-a888-6a7e139f2636"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildOkButtonClickExecute,
				});
			}
		}

		private ProcessScriptTask _errorMessageScriptTask;
		public ProcessScriptTask ErrorMessageScriptTask {
			get {
				return _errorMessageScriptTask ?? (_errorMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ErrorMessageScriptTask",
					SchemaElementUId = new Guid("865aab4e-e3d6-4bef-810f-f2d6ef410dee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ErrorMessageScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _baseOkButtonClickIntermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent BaseOkButtonClickIntermediateThrowMessageEvent2 {
			get {
				return _baseOkButtonClickIntermediateThrowMessageEvent2 ?? (_baseOkButtonClickIntermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseOkButtonClickIntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("10b62e9c-b8fd-4505-968c-ea15b93a6f4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("3dc08df0-e2ff-4384-865a-f696b85a0176"),
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
					SchemaElementUId = new Guid("f6b49213-70d2-4111-b013-9260b9954373"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _sysAdminUnitNameColumnCaption;
		public LocalizableString SysAdminUnitNameColumnCaption {
			get {
				return _sysAdminUnitNameColumnCaption ?? (_sysAdminUnitNameColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SysAdminUnitNameColumnCaption.Value"));
			}
		}

		private LocalizableString _canReadColumnCaption;
		public LocalizableString CanReadColumnCaption {
			get {
				return _canReadColumnCaption ?? (_canReadColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CanReadColumnCaption.Value"));
			}
		}

		private LocalizableString _canEditColumnCaption;
		public LocalizableString CanEditColumnCaption {
			get {
				return _canEditColumnCaption ?? (_canEditColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CanEditColumnCaption.Value"));
			}
		}

		private LocalizableString _canDeleteColumnCaption;
		public LocalizableString CanDeleteColumnCaption {
			get {
				return _canDeleteColumnCaption ?? (_canDeleteColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CanDeleteColumnCaption.Value"));
			}
		}

		private LocalizableString _recordOperationRightLevelColumnCaption;
		public LocalizableString RecordOperationRightLevelColumnCaption {
			get {
				return _recordOperationRightLevelColumnCaption ?? (_recordOperationRightLevelColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.RecordOperationRightLevelColumnCaption.Value"));
			}
		}

		private LocalizableString _changeSchemaEntityMessage;
		public LocalizableString ChangeSchemaEntityMessage {
			get {
				return _changeSchemaEntityMessage ?? (_changeSchemaEntityMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeSchemaEntityMessage.Value"));
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

		private LocalizableString _allowOperationRightLevel;
		public LocalizableString AllowOperationRightLevel {
			get {
				return _allowOperationRightLevel ?? (_allowOperationRightLevel = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AllowOperationRightLevel.Value"));
			}
		}

		private LocalizableString _denayOperationRightLevel;
		public LocalizableString DenayOperationRightLevel {
			get {
				return _denayOperationRightLevel ?? (_denayOperationRightLevel = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DenayOperationRightLevel.Value"));
			}
		}

		private LocalizableString _allowAndGrantOperationRightLevel;
		public LocalizableString AllowAndGrantOperationRightLevel {
			get {
				return _allowAndGrantOperationRightLevel ?? (_allowAndGrantOperationRightLevel = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AllowAndGrantOperationRightLevel.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess15.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess15 };
			FlowElements[AddRightAddButtonClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightAddButtonClickStartMessage1 };
			FlowElements[AddRightAddButtonClickScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightAddButtonClickScriptTask1 };
			FlowElements[OpenAddRightsRecordEditPageOnAdd.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenAddRightsRecordEditPageOnAdd };
			FlowElements[EventSubProcess16.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess16 };
			FlowElements[AddRightsRecordEditPageClosedStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightsRecordEditPageClosedStartMessage1 };
			FlowElements[AddRightsRecordEditPageClosedScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightsRecordEditPageClosedScriptTask1 };
			FlowElements[EventSubProcess17.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess17 };
			FlowElements[AddRightEditButtonClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightEditButtonClickStartMessage1 };
			FlowElements[AddRightEditButtonClickScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightEditButtonClickScriptTask1 };
			FlowElements[OpenAddRightsRecordEditPageOnEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenAddRightsRecordEditPageOnEdit };
			FlowElements[EventSubProcess21.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess21 };
			FlowElements[AddRightsTreeGridDblClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightsTreeGridDblClickStartMessage1 };
			FlowElements[AddRightEditButtonClickIntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightEditButtonClickIntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess18.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess18 };
			FlowElements[AddRighDeletetButtonClickStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRighDeletetButtonClickStartMessage2 };
			FlowElements[AddRighDeletetButtonClickScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRighDeletetButtonClickScriptTask2 };
			FlowElements[EventSubProcess20.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess20 };
			FlowElements[DownRighDeletetButtonClickStartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { DownRighDeletetButtonClickStartMessage4 };
			FlowElements[DownRighDeletetButtonClickScriptTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { DownRighDeletetButtonClickScriptTask4 };
			FlowElements[EventSubProcess19.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess19 };
			FlowElements[UpRighDeletetButtonClickStartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { UpRighDeletetButtonClickStartMessage3 };
			FlowElements[UpRighDeletetButtonClickScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { UpRighDeletetButtonClickScriptTask3 };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[DeleteRightAddButtonClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightAddButtonClickStartMessage1 };
			FlowElements[DeleteRightAddButtonClickScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightAddButtonClickScriptTask1 };
			FlowElements[OpenDeleteRightsRecordEditPageOnAdd.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenDeleteRightsRecordEditPageOnAdd };
			FlowElements[EventSubProcess12.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess12 };
			FlowElements[DeleteRightDeleteButtonClickStartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightDeleteButtonClickStartMessage3 };
			FlowElements[DeleteRightDeleteButtonClickScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightDeleteButtonClickScriptTask3 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[DeleteRightEditButtonClickStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightEditButtonClickStartMessage2 };
			FlowElements[DeleteRightEditButtonClickScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightEditButtonClickScriptTask2 };
			FlowElements[DeleteRightEditButtonClickOnEdit.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightEditButtonClickOnEdit };
			FlowElements[EventSubProcess13.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess13 };
			FlowElements[DeleteRightsTreeGridDblClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightsTreeGridDblClickStartMessage1 };
			FlowElements[DeleteRightEditButtonClickIntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightEditButtonClickIntermediateThrowMessageEvent2 };
			FlowElements[EventSubProcess14.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess14 };
			FlowElements[DeleteRightsRecordEditPageClosedStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightsRecordEditPageClosedStartMessage1 };
			FlowElements[DeleteRightsRecordEditPageClosedScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightsRecordEditPageClosedScriptTask1 };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[AddRightsTreeGridSelectionChangeStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightsTreeGridSelectionChangeStartMessage2 };
			FlowElements[AddRightsTreeGridSelectionChangeScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { AddRightsTreeGridSelectionChangeScriptTask2 };
			FlowElements[EventSubProcess7.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7 };
			FlowElements[DeleteRightsTreeGridSelectionChangeStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightsTreeGridSelectionChangeStartMessage1 };
			FlowElements[DeleteRightsTreeGridSelectionChangeScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteRightsTreeGridSelectionChangeScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[EntitySchemaEditChangeStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { EntitySchemaEditChangeStartMessage1 };
			FlowElements[ObjectEditChangeScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ObjectEditChangeScriptTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ChangeSchemaEntityUserMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityUserMessage };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[ChangeSchemaEntityYesMessageStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageStartMessage1 };
			FlowElements[ChangeSchemaEntityYesMessageScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityYesMessageScriptTask1 };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[ChangeSchemaEntityNoMessageStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageStartMessage2 };
			FlowElements[ChangeSchemaEntityNoMessageScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeSchemaEntityNoMessageScriptTask2 };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[PageLoadCompleteStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage1 };
			FlowElements[PageLoadCompleteIntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteIntermediateThrowMessageEvent2 };
			FlowElements[PageLoadCompleteScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask1 };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[InitStartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage2 };
			FlowElements[InitIntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent3 };
			FlowElements[InitScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask2 };
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[OkButtonClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage1 };
			FlowElements[CheckDataScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckDataScriptTask1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ScriptChildOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildOkButtonClick };
			FlowElements[ErrorMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorMessageScriptTask };
			FlowElements[BaseOkButtonClickIntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseOkButtonClickIntermediateThrowMessageEvent2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess15":
						break;
					case "AddRightAddButtonClickStartMessage1":
						e.Context.QueueTasks.Enqueue("AddRightAddButtonClickScriptTask1");
						break;
					case "AddRightAddButtonClickScriptTask1":
						e.Context.QueueTasks.Enqueue("OpenAddRightsRecordEditPageOnAdd");
						break;
					case "OpenAddRightsRecordEditPageOnAdd":
						break;
					case "EventSubProcess16":
						break;
					case "AddRightsRecordEditPageClosedStartMessage1":
						e.Context.QueueTasks.Enqueue("AddRightsRecordEditPageClosedScriptTask1");
						break;
					case "AddRightsRecordEditPageClosedScriptTask1":
						break;
					case "EventSubProcess17":
						break;
					case "AddRightEditButtonClickStartMessage1":
						e.Context.QueueTasks.Enqueue("AddRightEditButtonClickScriptTask1");
						break;
					case "AddRightEditButtonClickScriptTask1":
						e.Context.QueueTasks.Enqueue("OpenAddRightsRecordEditPageOnEdit");
						break;
					case "OpenAddRightsRecordEditPageOnEdit":
						break;
					case "EventSubProcess21":
						break;
					case "AddRightsTreeGridDblClickStartMessage1":
						e.Context.QueueTasks.Enqueue("AddRightEditButtonClickIntermediateThrowMessageEvent2");
						break;
					case "AddRightEditButtonClickIntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess18":
						break;
					case "AddRighDeletetButtonClickStartMessage2":
						e.Context.QueueTasks.Enqueue("AddRighDeletetButtonClickScriptTask2");
						break;
					case "AddRighDeletetButtonClickScriptTask2":
						break;
					case "EventSubProcess20":
						break;
					case "DownRighDeletetButtonClickStartMessage4":
						e.Context.QueueTasks.Enqueue("DownRighDeletetButtonClickScriptTask4");
						break;
					case "DownRighDeletetButtonClickScriptTask4":
						break;
					case "EventSubProcess19":
						break;
					case "UpRighDeletetButtonClickStartMessage3":
						e.Context.QueueTasks.Enqueue("UpRighDeletetButtonClickScriptTask3");
						break;
					case "UpRighDeletetButtonClickScriptTask3":
						break;
					case "EventSubProcess10":
						break;
					case "DeleteRightAddButtonClickStartMessage1":
						e.Context.QueueTasks.Enqueue("DeleteRightAddButtonClickScriptTask1");
						break;
					case "DeleteRightAddButtonClickScriptTask1":
						e.Context.QueueTasks.Enqueue("OpenDeleteRightsRecordEditPageOnAdd");
						break;
					case "OpenDeleteRightsRecordEditPageOnAdd":
						break;
					case "EventSubProcess12":
						break;
					case "DeleteRightDeleteButtonClickStartMessage3":
						e.Context.QueueTasks.Enqueue("DeleteRightDeleteButtonClickScriptTask3");
						break;
					case "DeleteRightDeleteButtonClickScriptTask3":
						break;
					case "EventSubProcess11":
						break;
					case "DeleteRightEditButtonClickStartMessage2":
						e.Context.QueueTasks.Enqueue("DeleteRightEditButtonClickScriptTask2");
						break;
					case "DeleteRightEditButtonClickScriptTask2":
						e.Context.QueueTasks.Enqueue("DeleteRightEditButtonClickOnEdit");
						break;
					case "DeleteRightEditButtonClickOnEdit":
						break;
					case "EventSubProcess13":
						break;
					case "DeleteRightsTreeGridDblClickStartMessage1":
						e.Context.QueueTasks.Enqueue("DeleteRightEditButtonClickIntermediateThrowMessageEvent2");
						break;
					case "DeleteRightEditButtonClickIntermediateThrowMessageEvent2":
						break;
					case "EventSubProcess14":
						break;
					case "DeleteRightsRecordEditPageClosedStartMessage1":
						e.Context.QueueTasks.Enqueue("DeleteRightsRecordEditPageClosedScriptTask1");
						break;
					case "DeleteRightsRecordEditPageClosedScriptTask1":
						break;
					case "EventSubProcess8":
						break;
					case "AddRightsTreeGridSelectionChangeStartMessage2":
						e.Context.QueueTasks.Enqueue("AddRightsTreeGridSelectionChangeScriptTask2");
						break;
					case "AddRightsTreeGridSelectionChangeScriptTask2":
						break;
					case "EventSubProcess7":
						break;
					case "DeleteRightsTreeGridSelectionChangeStartMessage1":
						e.Context.QueueTasks.Enqueue("DeleteRightsTreeGridSelectionChangeScriptTask1");
						break;
					case "DeleteRightsTreeGridSelectionChangeScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "EntitySchemaEditChangeStartMessage1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ObjectEditChangeScriptTask1":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityUserMessage");
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ObjectEditChangeScriptTask1");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "ChangeSchemaEntityUserMessage":
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess3":
						break;
					case "ChangeSchemaEntityYesMessageStartMessage1":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageScriptTask1");
						break;
					case "ChangeSchemaEntityYesMessageScriptTask1":
						break;
					case "EventSubProcess4":
						break;
					case "ChangeSchemaEntityNoMessageStartMessage2":
						e.Context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageScriptTask2");
						break;
					case "ChangeSchemaEntityNoMessageScriptTask2":
						break;
					case "EventSubProcess5":
						break;
					case "PageLoadCompleteStartMessage1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteIntermediateThrowMessageEvent2");
						break;
					case "PageLoadCompleteIntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask1");
						break;
					case "PageLoadCompleteScriptTask1":
						break;
					case "EventSubProcess6":
						break;
					case "InitStartMessage2":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent3");
						break;
					case "InitIntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("InitScriptTask2");
						break;
					case "InitScriptTask2":
						break;
					case "EventSubProcess9":
						break;
					case "OkButtonClickStartMessage1":
						e.Context.QueueTasks.Enqueue("CheckDataScriptTask1");
						break;
					case "CheckDataScriptTask1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptChildOkButtonClick");
							break;
						}
						e.Context.QueueTasks.Enqueue("ErrorMessageScriptTask");
						break;
					case "ScriptChildOkButtonClick":
						e.Context.QueueTasks.Enqueue("BaseOkButtonClickIntermediateThrowMessageEvent2");
						break;
					case "ErrorMessageScriptTask":
						break;
					case "BaseOkButtonClickIntermediateThrowMessageEvent2":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsEntitySchemaChanged());
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(IsValidDataSourceFilter);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AddRightAddButtonClickStartMessage1");
			ActivatedEventElements.Add("AddRightsRecordEditPageClosedStartMessage1");
			ActivatedEventElements.Add("AddRightEditButtonClickStartMessage1");
			ActivatedEventElements.Add("AddRightsTreeGridDblClickStartMessage1");
			ActivatedEventElements.Add("AddRighDeletetButtonClickStartMessage2");
			ActivatedEventElements.Add("DownRighDeletetButtonClickStartMessage4");
			ActivatedEventElements.Add("UpRighDeletetButtonClickStartMessage3");
			ActivatedEventElements.Add("DeleteRightAddButtonClickStartMessage1");
			ActivatedEventElements.Add("DeleteRightDeleteButtonClickStartMessage3");
			ActivatedEventElements.Add("DeleteRightEditButtonClickStartMessage2");
			ActivatedEventElements.Add("DeleteRightsTreeGridDblClickStartMessage1");
			ActivatedEventElements.Add("DeleteRightsRecordEditPageClosedStartMessage1");
			ActivatedEventElements.Add("AddRightsTreeGridSelectionChangeStartMessage2");
			ActivatedEventElements.Add("DeleteRightsTreeGridSelectionChangeStartMessage1");
			ActivatedEventElements.Add("EntitySchemaEditChangeStartMessage1");
			ActivatedEventElements.Add("ChangeSchemaEntityYesMessageStartMessage1");
			ActivatedEventElements.Add("ChangeSchemaEntityNoMessageStartMessage2");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage1");
			ActivatedEventElements.Add("InitStartMessage2");
			ActivatedEventElements.Add("OkButtonClickStartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess15":
					context.QueueTasks.Dequeue();
					break;
				case "AddRightAddButtonClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightAddButtonClickStartMessage1";
					result = AddRightAddButtonClickStartMessage1.Execute(context);
					break;
				case "AddRightAddButtonClickScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightAddButtonClickScriptTask1";
					result = AddRightAddButtonClickScriptTask1.Execute(context, AddRightAddButtonClickScriptTask1Execute);
					break;
				case "OpenAddRightsRecordEditPageOnAdd":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenAddRightsRecordEditPageOnAdd";
					result = OpenAddRightsRecordEditPageOnAdd.Execute(context);
					break;
				case "EventSubProcess16":
					context.QueueTasks.Dequeue();
					break;
				case "AddRightsRecordEditPageClosedStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightsRecordEditPageClosedStartMessage1";
					result = AddRightsRecordEditPageClosedStartMessage1.Execute(context);
					break;
				case "AddRightsRecordEditPageClosedScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightsRecordEditPageClosedScriptTask1";
					result = AddRightsRecordEditPageClosedScriptTask1.Execute(context, AddRightsRecordEditPageClosedScriptTask1Execute);
					break;
				case "EventSubProcess17":
					context.QueueTasks.Dequeue();
					break;
				case "AddRightEditButtonClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightEditButtonClickStartMessage1";
					result = AddRightEditButtonClickStartMessage1.Execute(context);
					break;
				case "AddRightEditButtonClickScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightEditButtonClickScriptTask1";
					result = AddRightEditButtonClickScriptTask1.Execute(context, AddRightEditButtonClickScriptTask1Execute);
					break;
				case "OpenAddRightsRecordEditPageOnEdit":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenAddRightsRecordEditPageOnEdit";
					result = OpenAddRightsRecordEditPageOnEdit.Execute(context);
					break;
				case "EventSubProcess21":
					context.QueueTasks.Dequeue();
					break;
				case "AddRightsTreeGridDblClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightsTreeGridDblClickStartMessage1";
					result = AddRightsTreeGridDblClickStartMessage1.Execute(context);
					break;
				case "AddRightEditButtonClickIntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					result = AddRightEditButtonClickIntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess18":
					context.QueueTasks.Dequeue();
					break;
				case "AddRighDeletetButtonClickStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRighDeletetButtonClickStartMessage2";
					result = AddRighDeletetButtonClickStartMessage2.Execute(context);
					break;
				case "AddRighDeletetButtonClickScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRighDeletetButtonClickScriptTask2";
					result = AddRighDeletetButtonClickScriptTask2.Execute(context, AddRighDeletetButtonClickScriptTask2Execute);
					break;
				case "EventSubProcess20":
					context.QueueTasks.Dequeue();
					break;
				case "DownRighDeletetButtonClickStartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownRighDeletetButtonClickStartMessage4";
					result = DownRighDeletetButtonClickStartMessage4.Execute(context);
					break;
				case "DownRighDeletetButtonClickScriptTask4":
					context.QueueTasks.Dequeue();
					context.SenderName = "DownRighDeletetButtonClickScriptTask4";
					result = DownRighDeletetButtonClickScriptTask4.Execute(context, DownRighDeletetButtonClickScriptTask4Execute);
					break;
				case "EventSubProcess19":
					context.QueueTasks.Dequeue();
					break;
				case "UpRighDeletetButtonClickStartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpRighDeletetButtonClickStartMessage3";
					result = UpRighDeletetButtonClickStartMessage3.Execute(context);
					break;
				case "UpRighDeletetButtonClickScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpRighDeletetButtonClickScriptTask3";
					result = UpRighDeletetButtonClickScriptTask3.Execute(context, UpRighDeletetButtonClickScriptTask3Execute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteRightAddButtonClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightAddButtonClickStartMessage1";
					result = DeleteRightAddButtonClickStartMessage1.Execute(context);
					break;
				case "DeleteRightAddButtonClickScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightAddButtonClickScriptTask1";
					result = DeleteRightAddButtonClickScriptTask1.Execute(context, DeleteRightAddButtonClickScriptTask1Execute);
					break;
				case "OpenDeleteRightsRecordEditPageOnAdd":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenDeleteRightsRecordEditPageOnAdd";
					result = OpenDeleteRightsRecordEditPageOnAdd.Execute(context);
					break;
				case "EventSubProcess12":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteRightDeleteButtonClickStartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightDeleteButtonClickStartMessage3";
					result = DeleteRightDeleteButtonClickStartMessage3.Execute(context);
					break;
				case "DeleteRightDeleteButtonClickScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightDeleteButtonClickScriptTask3";
					result = DeleteRightDeleteButtonClickScriptTask3.Execute(context, DeleteRightDeleteButtonClickScriptTask3Execute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteRightEditButtonClickStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightEditButtonClickStartMessage2";
					result = DeleteRightEditButtonClickStartMessage2.Execute(context);
					break;
				case "DeleteRightEditButtonClickScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightEditButtonClickScriptTask2";
					result = DeleteRightEditButtonClickScriptTask2.Execute(context, DeleteRightEditButtonClickScriptTask2Execute);
					break;
				case "DeleteRightEditButtonClickOnEdit":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightEditButtonClickOnEdit";
					result = DeleteRightEditButtonClickOnEdit.Execute(context);
					break;
				case "EventSubProcess13":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteRightsTreeGridDblClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightsTreeGridDblClickStartMessage1";
					result = DeleteRightsTreeGridDblClickStartMessage1.Execute(context);
					break;
				case "DeleteRightEditButtonClickIntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					result = DeleteRightEditButtonClickIntermediateThrowMessageEvent2.Execute(context);
					break;
				case "EventSubProcess14":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteRightsRecordEditPageClosedStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightsRecordEditPageClosedStartMessage1";
					result = DeleteRightsRecordEditPageClosedStartMessage1.Execute(context);
					break;
				case "DeleteRightsRecordEditPageClosedScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightsRecordEditPageClosedScriptTask1";
					result = DeleteRightsRecordEditPageClosedScriptTask1.Execute(context, DeleteRightsRecordEditPageClosedScriptTask1Execute);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "AddRightsTreeGridSelectionChangeStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightsTreeGridSelectionChangeStartMessage2";
					result = AddRightsTreeGridSelectionChangeStartMessage2.Execute(context);
					break;
				case "AddRightsTreeGridSelectionChangeScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddRightsTreeGridSelectionChangeScriptTask2";
					result = AddRightsTreeGridSelectionChangeScriptTask2.Execute(context, AddRightsTreeGridSelectionChangeScriptTask2Execute);
					break;
				case "EventSubProcess7":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteRightsTreeGridSelectionChangeStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightsTreeGridSelectionChangeStartMessage1";
					result = DeleteRightsTreeGridSelectionChangeStartMessage1.Execute(context);
					break;
				case "DeleteRightsTreeGridSelectionChangeScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteRightsTreeGridSelectionChangeScriptTask1";
					result = DeleteRightsTreeGridSelectionChangeScriptTask1.Execute(context, DeleteRightsTreeGridSelectionChangeScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "EntitySchemaEditChangeStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "EntitySchemaEditChangeStartMessage1";
					result = EntitySchemaEditChangeStartMessage1.Execute(context);
					break;
				case "ObjectEditChangeScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ObjectEditChangeScriptTask1";
					result = ObjectEditChangeScriptTask1.Execute(context, ObjectEditChangeScriptTask1Execute);
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
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityYesMessageStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageStartMessage1";
					result = ChangeSchemaEntityYesMessageStartMessage1.Execute(context);
					break;
				case "ChangeSchemaEntityYesMessageScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityYesMessageScriptTask1";
					result = ChangeSchemaEntityYesMessageScriptTask1.Execute(context, ChangeSchemaEntityYesMessageScriptTask1Execute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "ChangeSchemaEntityNoMessageStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageStartMessage2";
					result = ChangeSchemaEntityNoMessageStartMessage2.Execute(context);
					break;
				case "ChangeSchemaEntityNoMessageScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChangeSchemaEntityNoMessageScriptTask2";
					result = ChangeSchemaEntityNoMessageScriptTask2.Execute(context, ChangeSchemaEntityNoMessageScriptTask2Execute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage1";
					result = PageLoadCompleteStartMessage1.Execute(context);
					break;
				case "PageLoadCompleteIntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteIntermediateThrowMessageEvent2.Execute(context);
					break;
				case "PageLoadCompleteScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask1";
					result = PageLoadCompleteScriptTask1.Execute(context, PageLoadCompleteScriptTask1Execute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "InitStartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage2";
					result = InitStartMessage2.Execute(context);
					break;
				case "InitIntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent3.Execute(context);
					break;
				case "InitScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask2";
					result = InitScriptTask2.Execute(context, InitScriptTask2Execute);
					break;
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage1";
					result = OkButtonClickStartMessage1.Execute(context);
					break;
				case "CheckDataScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckDataScriptTask1";
					result = CheckDataScriptTask1.Execute(context, CheckDataScriptTask1Execute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "ScriptChildOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildOkButtonClick";
					result = ScriptChildOkButtonClick.Execute(context, ScriptChildOkButtonClickExecute);
					break;
				case "ErrorMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ErrorMessageScriptTask";
					result = ErrorMessageScriptTask.Execute(context, ErrorMessageScriptTaskExecute);
					break;
				case "BaseOkButtonClickIntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = BaseOkButtonClickIntermediateThrowMessageEvent2.Execute(context);
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
				case "UserTaskParameterNames":
					UserTaskParameterNames = reader.GetSerializableObjectValue();
				break;
				case "LookupTypeUId":
					LookupTypeUId = reader.GetValue<System.Guid>();
				break;
				case "ContactSchemaUId":
					ContactSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "SysAdminUnitSchemaUId":
					SysAdminUnitSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "InsertedDeleteRightColumnValueKey":
					InsertedDeleteRightColumnValueKey = reader.GetValue<System.String>();
				break;
				case "IsValidDataSourceFilter":
					IsValidDataSourceFilter = reader.GetValue<System.Boolean>();
				break;
				case "AddRightsSessionKey":
					AddRightsSessionKey = reader.GetValue<System.String>();
				break;
				case "DeleteRightsSessionKey":
					DeleteRightsSessionKey = reader.GetValue<System.String>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool AddRightAddButtonClickScriptTask1Execute(ProcessExecutingContext context) {
			OpenAddRightsRecordEditPageOnAdd.OpenerInstanceId = InstanceUId;
			OpenAddRightsRecordEditPageOnAdd.UseCurrentActivePage = true;
			OpenAddRightsRecordEditPageOnAdd.PageUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			OpenAddRightsRecordEditPageOnAdd.CloseMessage = "AddRightsRecordEditPageClosed";
			OpenAddRightsRecordEditPageOnAdd.PageParameters =
				new Dictionary<string, string>() {
					{ "entitySchemaUId", EntitySchemaUId.ToString() },
					{ "processSchemaId", EditSchemaUId.ToString() },
					{ "managerName", EditSchemaManagerName },
					{ "sessionKey", AddRightsSessionKey },
					{ "editElementId", EditElementUId.ToString() }
				};
			return true;
		}

		public virtual bool AddRightsRecordEditPageClosedScriptTask1Execute(ProcessExecutingContext context) {
			DisplayAddRights();
			return true;
		}

		public virtual bool AddRightEditButtonClickScriptTask1Execute(ProcessExecutingContext context) {
			TreeGridNode node = null;
			if (Page.AddRightsTreeGrid.SelectedNodes.Count != 0) {
				node = Page.AddRightsTreeGrid.SelectedNodes[0];
			} else {
				return false;
			}
			OpenAddRightsRecordEditPageOnEdit.OpenerInstanceId = InstanceUId;
			OpenAddRightsRecordEditPageOnEdit.UseCurrentActivePage = true;
			OpenAddRightsRecordEditPageOnEdit.PageUId = new Guid("4ab08430-f774-4a7c-8764-ba3d37a0cbaa");
			OpenAddRightsRecordEditPageOnEdit.CloseMessage = "AddRightsRecordEditPageClosed";
			OpenAddRightsRecordEditPageOnEdit.PageParameters =
				new Dictionary<string, string>() {
						{ "entitySchemaUId", EntitySchemaUId.ToString() },
						{ "processSchemaId", EditSchemaUId.ToString() },
						{ "managerName", EditSchemaManagerName },
						{ "sessionKey", AddRightsSessionKey },
						{ "itemId", node.Values["Id"].ToString() },
						{ "editElementId", EditElementUId.ToString() }
					};
			
			return true;
		}

		public virtual bool AddRighDeletetButtonClickScriptTask2Execute(ProcessExecutingContext context) {
			var addRights = UserConnection.SessionData[AddRightsSessionKey] as List<Dictionary<string, object>>;
			if (addRights == null) {
				return true;
			}
			foreach (var node in Page.AddRightsTreeGrid.SelectedNodes) {
				addRights.Remove(addRights.Find((addRight) => addRight["Id"].ToString() == node.Values["Id"].ToString()));
			}
			UserConnection.SessionData[AddRightsSessionKey] = addRights;
			if (addRights.Count == 0) {
				Page.AddRightEditButton.Enabled =
				Page.AddRighDeletetButton.Enabled =
				Page.UpRighDeletetButton.Enabled =
				Page.DownRighDeletetButton.Enabled = false;
			}
			DisplayAddRights();
			return true;
		}

		public virtual bool DownRighDeletetButtonClickScriptTask4Execute(ProcessExecutingContext context) {
			if (Page.AddRightsTreeGrid.SelectedNodes.Count == 1) {
				TreeGridNode node = Page.AddRightsTreeGrid.SelectedNodes[0];
				var addRights = GetAddRightsValues();
				var right = addRights.Find((addRight) => addRight["Id"].ToString() == node.Values["Id"].ToString());
				int position = addRights.IndexOf(right) + 1;
				if (position < addRights.Count) {
					addRights.Remove(right);
					addRights.Insert(position, right);
					UserConnection.SessionData[AddRightsSessionKey] = addRights;
					DisplayAddRights();
				}
			}
			return true;
		}

		public virtual bool UpRighDeletetButtonClickScriptTask3Execute(ProcessExecutingContext context) {
			if (Page.AddRightsTreeGrid.SelectedNodes.Count == 1) {
				TreeGridNode node = Page.AddRightsTreeGrid.SelectedNodes[0];
				var addRights = GetAddRightsValues();
				var right = addRights.Find((addRight) => addRight["Id"].ToString() == node.Values["Id"].ToString());
				int position = addRights.IndexOf(right) - 1;
				if (position >= 0) {
					addRights.Remove(right);
					addRights.Insert(position, right);
					UserConnection.SessionData[AddRightsSessionKey] = addRights;
					DisplayAddRights();
				}
			}
			return true;
		}

		public virtual bool DeleteRightAddButtonClickScriptTask1Execute(ProcessExecutingContext context) {
			OpenDeleteRightsRecordEditPageOnAdd.OpenerInstanceId = InstanceUId;
			OpenDeleteRightsRecordEditPageOnAdd.UseCurrentActivePage = true;
			OpenDeleteRightsRecordEditPageOnAdd.PageUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			OpenDeleteRightsRecordEditPageOnAdd.CloseMessage = "DeleteRightsRecordEditPageClosed";
			OpenDeleteRightsRecordEditPageOnAdd.PageParameters =
				new Dictionary<string, string>() {
					{ "entitySchemaId", EntitySchemaUId.ToString() },
					{ "processSchemaId", EditSchemaUId.ToString() },
					{ "managerName", EditSchemaManagerName },
					{ "sessionKey", DeleteRightsSessionKey },
					{ "editElementId", EditElementUId.ToString() }
				};
			return true;
		}

		public virtual bool DeleteRightDeleteButtonClickScriptTask3Execute(ProcessExecutingContext context) {
			var deleteRights = UserConnection.SessionData[DeleteRightsSessionKey] as List<Dictionary<string, object>>;
			if (deleteRights == null) {
				return true;
			}
			foreach (var node in Page.DeleteRightsTreeGrid.SelectedNodes) {
				deleteRights.Remove(deleteRights.Find((deleteRight) => deleteRight["Id"].ToString() == node.Values["Id"].ToString()));
			}
			UserConnection.SessionData[DeleteRightsSessionKey] = deleteRights;
			if (deleteRights.Count == 0){
				Page.DeleteRightEditButton.Enabled =
				Page.DeleteRightDeleteButton.Enabled = false;
			}
			DisplayDeleteRights();
			return true;
		}

		public virtual bool DeleteRightEditButtonClickScriptTask2Execute(ProcessExecutingContext context) {
			TreeGridNode node = null;
			if (Page.DeleteRightsTreeGrid.SelectedNodes.Count != 0) {
				node = Page.DeleteRightsTreeGrid.SelectedNodes[0];
			} else {
				return false;
			}
			DeleteRightEditButtonClickOnEdit.OpenerInstanceId = InstanceUId;
			DeleteRightEditButtonClickOnEdit.UseCurrentActivePage = true;
			DeleteRightEditButtonClickOnEdit.PageUId = new Guid("f781e755-5d72-4a58-bfda-0470e12dc76e");
			DeleteRightEditButtonClickOnEdit.CloseMessage = "DeleteRightsRecordEditPageClosed";
			DeleteRightEditButtonClickOnEdit.PageParameters =
				new Dictionary<string, string>() {
						{ "entitySchemaUId", EntitySchemaUId.ToString() },
						{ "processSchemaId", EditSchemaUId.ToString() },
						{ "managerName", EditSchemaManagerName },
						{ "sessionKey", DeleteRightsSessionKey },
						{ "itemId", node.Values["Id"].ToString() },
						{ "editElementId", EditElementUId.ToString() }
					};
			
			return true;
		}

		public virtual bool DeleteRightsRecordEditPageClosedScriptTask1Execute(ProcessExecutingContext context) {
			DisplayDeleteRights();
			return true;
		}

		public virtual bool AddRightsTreeGridSelectionChangeScriptTask2Execute(ProcessExecutingContext context) {
			Page.AddRightEditButton.Enabled =
			Page.AddRighDeletetButton.Enabled =
			Page.UpRighDeletetButton.Enabled =
			Page.DownRighDeletetButton.Enabled = true;
			return true;
		}

		public virtual bool DeleteRightsTreeGridSelectionChangeScriptTask1Execute(ProcessExecutingContext context) {
			Page.DeleteRightEditButton.Enabled = true;
			Page.DeleteRightDeleteButton.Enabled = true;
			return true;
		}

		public virtual bool ObjectEditChangeScriptTask1Execute(ProcessExecutingContext context) {
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

		public virtual bool ChangeSchemaEntityYesMessageScriptTask1Execute(ProcessExecutingContext context) {
			EntitySchemaUId = new Guid(Page.EntitySchemaEdit.Value.ToString());
			Page.EntityDataSource.SchemaUId = EntitySchemaUId;
			ResetControlValues();
			Page.FilterEdit.SetDataSource(Page.EntityDataSource);
			Page.EntityDataSource.LoadStructure();
			return true;
		}

		public virtual bool ChangeSchemaEntityNoMessageScriptTask2Execute(ProcessExecutingContext context) {
			Page.EntitySchemaEdit.SuspendAjaxEvents();
			Page.EntitySchemaEdit.SetValueAndText(EntitySchemaUId, Page.EntityDataSource.Schema.Caption.ToString());
			Page.EntitySchemaEdit.ResumeAjaxEvents();
			return true;
		}

		public virtual bool PageLoadCompleteScriptTask1Execute(ProcessExecutingContext context) {
			ProcessSchema schema = FindDesignedProcessSchema();
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
				Page.EntitySchemaEdit.SetValueAndText(EntitySchemaUId, Page.EntityDataSource.Schema.Caption);
				
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
				Page.FilterEdit.Enabled = true;
			} else {
				Page.FilterEdit.Enabled = false;
			}
			EnableControls();
			
			var userTask = (ProcessSchemaUserTask)schema.GetBaseElementByUId(EditElementUId);
			// Deserialize column values
			DeleteRightsSessionKey = Guid.NewGuid().ToString();
			var serealizedDeleteRights = parameters["DeleteRights"].Value;
			List<Dictionary<string, object>> deleteRights;
			if (string.IsNullOrEmpty(serealizedDeleteRights)) {
				deleteRights = new List<Dictionary<string, object>>();
			} else {
				deleteRights = Json.Deserialize<List<Dictionary<string, object>>>(serealizedDeleteRights);
				UpdateDisplayValues(deleteRights);
				ActualizeParameterValues(deleteRights, userTask, schema);
			}
			
			UserConnection.SessionData[DeleteRightsSessionKey] = deleteRights;
			
			AddRightsSessionKey = Guid.NewGuid().ToString();
			var serealizedAddRights = parameters["AddRights"].Value;
			List<Dictionary<string, object>> addRights;
			if (string.IsNullOrEmpty(serealizedAddRights)) {
				addRights = new List<Dictionary<string, object>>();
			} else {
				addRights = Json.Deserialize<List<Dictionary<string, object>>>(serealizedAddRights);
				UpdateDisplayValues(addRights);
				ActualizeParameterValues(addRights, userTask, schema);
			}
			UserConnection.SessionData[AddRightsSessionKey] = addRights;
			
			DisplayDeleteRights();
			DisplayAddRights();
			
			return true;
		}

		public virtual bool InitScriptTask2Execute(ProcessExecutingContext context) {
			var workspaceUIdFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "SysWorkspace"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {UserConnection.Workspace.Id}}};
			var administratedByRecordsFilter = new Dictionary<string, object> {
					{"comparisonType", FilterComparisonType.Equal},
					{"leftExpressionColumnPath", "AdministratedByRecords"},
					{"useDisplayValue", false},
					{"rightExpressionParameterValues", new object[] {true}}};
			Page.EntitySchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				var filters = e.Filters;
				filters.Add(workspaceUIdFilter);
				filters.Add(administratedByRecordsFilter);
			};
			CreateDeleteRightsVds();
			CreateAddRightsVds();
			if (!Ext.IsAjaxRequest) {
				Page.UserTaskTitleEdit.Text = ElementNewCaption;
				DesignModeClassDescriptor descriptor = Descriptor as DesignModeClassDescriptor;
				FillPropertyDataSource(Source, descriptor);
				var propertyDataSource = PropertyDataSource as VirtualDataSource;
				propertyDataSource.SetClientActiveRow();
				var defValues = (Dictionary<string, ProcessSchemaParameterValue>)DefaultValues;
				BindEditors(GetEditorsBinding(), propertyDataSource, defValues);
			}
			return true;
		}

		public virtual bool CheckDataScriptTask1Execute(ProcessExecutingContext context) {
			var filters = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			if (filters.Count == 0){
				IsValidDataSourceFilter = false;
			} else {
				IsValidDataSourceFilter = !filters.IsAnyLeftExpressionNullOrEmpty();
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
			// Serealize datasource filter instead of ESQ one because we need to rebuild
			// it when reopen page for this element.
			// Obtain ESQ filter from serealized datasource filter for this element on runtime
			var filterCollection = Page.FilterEdit.DataSource.FindFiltersGroupByName("FilterEdit");
			var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, Page.FilterEdit.DataSource);
			parametersValue["DataSourceFilters"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = constVS,
				Value = Json.Serialize(filterCollection, jsonConverter)
			};
			// Set EntitySchema value
			string objectSchemaId = EntitySchemaUId == Guid.Empty ? String.Empty : EntitySchemaUId.ToString();
			parametersValue["EntitySchemaUId"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = String.IsNullOrEmpty(objectSchemaId) ? noneVS : constVS,
				Value = objectSchemaId
			};
			
			// Set DeleteRights column values
			/*var columnValues = new EntityColumnMappingCollection();
			foreach (var cv in GetDeleteRightsValues()) {
				columnValues.Add(new EntityColumnMappingItem() {
					SchemaUId = EntitySchemaUId,
					ColumnMetaPath = cv.Key,
					Value = cv.Value
				});
			}*/
			SysAdminUnitSchemaUId = UserConnection.EntitySchemaManager.GetItemByName("SysAdminUnit").UId;
			ContactSchemaUId = UserConnection.EntitySchemaManager.GetItemByName("Contact").UId;
			LookupTypeUId = UserConnection.DataValueTypeManager.GetItemByName("Lookup").UId;
			ProcessSchema schema = FindDesignedProcessSchema();
			var userTask = (ProcessSchemaUserTask)schema.GetBaseElementByUId(EditElementUId);
			var userTaskParameterNames = new List<string>(userTask.Parameters.Count);
			foreach (ProcessSchemaParameter parameter in userTask.Parameters) {
				userTaskParameterNames.Add(parameter.Name);
			}
			UserTaskParameterNames = userTaskParameterNames;
			List<Dictionary<string, object>> deleteRights = GetDeleteRightsValues();
			parametersValue["DeleteRights"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = deleteRights.Count == 0 ? noneVS : constVS,
				Value = Json.Serialize(deleteRights, jsonConverter)
			};
			List<ProcessSchemaParameter> modifiedParameters = GenerateUserTaskCustomParameters(schema, userTask.UId, deleteRights);
			// Set AddRights column values
			/*foreach (var cv in GetAddRightsValues()) {
				columnValues.Add(new EntityColumnMappingItem() {
					SchemaUId = EntitySchemaUId,
					ColumnMetaPath = cv.Key,
					Value = cv.Value
				});
			}*/
			List<Dictionary<string, object>> addRights = GetAddRightsValues();
			parametersValue["AddRights"] = new ProcessSchemaParameterValue() {
				ModifiedInSchemaUId = EditSchemaUId,
				Source = addRights.Count == 0 ? noneVS : constVS,
				Value = Json.Serialize(addRights, jsonConverter)
			};
			modifiedParameters.AddRange(GenerateUserTaskCustomParameters(schema, userTask.UId, addRights));
			UpdateProcessSchemaUserTaskCustomParameters(schema, userTask, modifiedParameters);
			return true;
		}

		public virtual bool ErrorMessageScriptTaskExecute(ProcessExecutingContext context) {
			Page.MainMessagePanel.AddMessage(ValidationMessageTitle, ValidationMessage, MessageType.Warning);
			return true;
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.UserTaskTitleEdit.Text) ?
				string.Format("{0} ({1})", WindowCaption, NewRecord) : Page.UserTaskTitleEdit.Text;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void UpdateProcessSchemaCustomParameter(ProcessSchemaParameter currentParameter, ProcessSchemaParameter modifiedParameter) {
			//currentParameter.Name = modifiedParameter.Name;
			//currentParameter.Caption = modifiedParameter.Caption;
			currentParameter.DataValueTypeUId = modifiedParameter.DataValueTypeUId;
			currentParameter.ReferenceSchemaUId = modifiedParameter.ReferenceSchemaUId;
			currentParameter.SourceValue.Value = modifiedParameter.SourceValue.Value;
			currentParameter.SourceValue.DisplayValue = modifiedParameter.SourceValue.DisplayValue;
			currentParameter.SourceValue.DataValueTypeUId = modifiedParameter.SourceValue.DataValueTypeUId;
			currentParameter.SourceValue.ReferenceSchemaUId = modifiedParameter.SourceValue.ReferenceSchemaUId;
		}

		public virtual bool IsEntitySchemaChanged() {
			return !EntitySchemaUId.Equals(Guid.Empty) && !EntitySchemaUId.Equals((Guid)Page.EntitySchemaEdit.Value);
		}

		public virtual void CreateDeleteRightsVds() {
			var vds = new VirtualDataSource() {
				ID = "DeleteRightsVds"
			};
			Page.PageContainer.Controls.Add(vds);
			
			// Set vds Id for calendar tree grid
			Page.DeleteRightsTreeGrid.DataSourceId = vds.ID;
			
			DataSourceStructure vdsStructure = vds.DefStructure;
			
			vdsStructure.PrimaryColumnName = "Id";
			vdsStructure.PrimaryDisplayColumnName = "Name";
			
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			var booleanDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Boolean");
			var intDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Integer");
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = SysAdminUnitNameColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "CanRead",
				Caption = CanReadColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = booleanDvt 
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "CanEdit",
				Caption = CanEditColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = booleanDvt 
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "CanDelete",
				Caption = CanDeleteColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = booleanDvt 
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Grantee", // ”Role”, “Employee”, “DataSourceFilter”
				IsVisible = false,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Value",
				IsVisible = false,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Source", // Enum ProcessSchemaParameterValueSource 
				IsVisible = false,
				IsHideable = true,
				IsSortable = true,
				DataValueType = intDvt
			});
		}

		public virtual void CreateAddRightsVds() {
			var vds = new VirtualDataSource() {
				ID = "AddRightsVds"
			};
			Page.PageContainer.Controls.Add(vds);
			
			// Set vds Id for calendar tree grid
			Page.AddRightsTreeGrid.DataSourceId = vds.ID;
			
			DataSourceStructure vdsStructure = vds.DefStructure;
			
			vdsStructure.PrimaryColumnName = "Id";
			vdsStructure.PrimaryDisplayColumnName = "Name";
			
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			var booleanDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Boolean");
			var intDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Integer");
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = SysAdminUnitNameColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "CanRead",
				Caption = CanReadColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = false,
				DataValueType = booleanDvt 
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "CanEdit",
				Caption = CanEditColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = false,
				DataValueType = booleanDvt 
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "CanDelete",
				Caption = CanDeleteColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = false,
				DataValueType = booleanDvt 
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Grantee", // ”Role”, “Employee”, “DataSourceFilter”
				IsVisible = false,
				IsHideable = true,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Value",
				IsVisible = false,
				IsHideable = true,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Source", // Enum ProcessSchemaParameterValueSource 
				IsVisible = false,
				IsHideable = true,
				IsSortable = false,
				DataValueType = intDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "OperationRightLevel",
				Caption = RecordOperationRightLevelColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = false,
				DataValueType = maxSizeTextDvt 
			});
		}

		public virtual void EnableControls() {
			if (EntitySchemaUId.Equals(Guid.Empty)) {
					Page.ControlLayout2.Enabled =
					Page.FilterEdit.Enabled =
			
					Page.DeleteRightAddButton.Enabled =
					Page.DeleteRightEditButton.Enabled =
					Page.DeleteRightDeleteButton.Enabled =
			
					Page.AddRightAddButton.Enabled =
					Page.AddRightEditButton.Enabled =
					Page.AddRighDeletetButton.Enabled =
			
					Page.UpRighDeletetButton.Enabled =
					Page.DownRighDeletetButton.Enabled = false;
			} else {
					Page.ControlLayout2.Enabled =
					Page.FilterEdit.Enabled =
			
					Page.DeleteRightAddButton.Enabled =
			
					Page.AddRightAddButton.Enabled = true;
			}
		}

		public virtual void ResetControlValues() {
			var filterEditGroup = Page.EntityDataSource.FindFiltersGroupByName(Page.FilterEdit.FilterEditGroupName);
			filterEditGroup.Clear();
			(Page.PageContainer.FindControl("DeleteRightsVds") as VirtualDataSource).Clear();
			(Page.PageContainer.FindControl("AddRightsVds") as VirtualDataSource).Clear();
			GetDeleteRightsValues().Clear();
			GetAddRightsValues().Clear();
			UserConnection.SessionData[DeleteRightsSessionKey] =  new List<Dictionary<string, object>>();
			UserConnection.SessionData[AddRightsSessionKey] = new List<Dictionary<string, object>>();
			EnableControls();
		}

		public virtual List<Dictionary<string, object>> GetDeleteRightsValues() {
			object sessionDataValue = UserConnection.SessionData[DeleteRightsSessionKey];
			if (sessionDataValue  == null) {
				return null;
			}
			return sessionDataValue as List<Dictionary<string, object>>;
		}

		public virtual List<Dictionary<string, object>> GetAddRightsValues() {
			object sessionDataValue = UserConnection.SessionData[AddRightsSessionKey];
			if (sessionDataValue  == null) {
				return null;
			}
			return sessionDataValue as List<Dictionary<string, object>>;
		}

		public virtual void DisplayDeleteRights() {
			var vds = Page.PageContainer.FindControl("DeleteRightsVds") as VirtualDataSource;
			vds.Clear();
			List<Dictionary<string, object>> deleteRights = GetDeleteRightsValues();
			if (deleteRights == null) {
				return;
			}
			if (deleteRights.Count == 0 || EntitySchemaUId == Guid.Empty) {
				vds.LoadRows();
				return;
			}
			foreach (var columnValues in deleteRights) {
				Entity row = vds.CreateRow();
				row.SetColumnValue("Id", columnValues["Id"]);
				row.SetColumnValue("CanRead", columnValues["CanRead"]);
				row.SetColumnValue("CanEdit", columnValues["CanEdit"]);
				row.SetColumnValue("CanDelete", columnValues["CanDelete"]);
				row.SetColumnValue("Grantee", columnValues["Grantee"]);
				row.SetColumnValue("Source", columnValues["Source"]);
				row.SetColumnValue("Name", columnValues["Name"]);
				if (columnValues.ContainsKey("Value")) {
					row.SetColumnValue("Value", columnValues["Value"]);
				}
				vds.Add(row);
			}
			vds.LoadRows();
		}

		public virtual void DisplayAddRights() {
			var vds = Page.PageContainer.FindControl("AddRightsVds") as VirtualDataSource;
			vds.Clear();
			List<Dictionary<string, object>> addRights = GetAddRightsValues();
			if (addRights == null) {
				return;
			}
			if (addRights .Count == 0 || EntitySchemaUId == Guid.Empty) {
				vds.LoadRows();
				return;
			}
			foreach (var columnValues in addRights ) {
				Entity row = vds.CreateRow();
				row.SetColumnValue("Id", columnValues["Id"]);
				row.SetColumnValue("CanRead", columnValues["CanRead"]);
				row.SetColumnValue("CanEdit", columnValues["CanEdit"]);
				row.SetColumnValue("CanDelete", columnValues["CanDelete"]);
				row.SetColumnValue("Grantee", columnValues["Grantee"]);
				row.SetColumnValue("Source", columnValues["Source"]);
				row.SetColumnValue("Name", columnValues["Name"]);
				string operationRightLevelCaption = AllowOperationRightLevel;
				switch((EntitySchemaRecordOperationRightLevel)Convert.ToInt32(columnValues["OperationRightLevel"])) {
					case EntitySchemaRecordOperationRightLevel.Deny:
						operationRightLevelCaption = DenayOperationRightLevel;
						break;
					case EntitySchemaRecordOperationRightLevel.Allow:
						operationRightLevelCaption = AllowOperationRightLevel;
						break;
					case EntitySchemaRecordOperationRightLevel.AllowAndGrant:
						operationRightLevelCaption = AllowAndGrantOperationRightLevel;
						break;
				}
				row.SetColumnValue("OperationRightLevel", operationRightLevelCaption);
				if (columnValues.ContainsKey("Value")) {
					row.SetColumnValue("Value", columnValues["Value"]);
				}
				vds.Add(row);
			}
			vds.LoadRows();
		}

		public virtual void UpdateDisplayValues(List<Dictionary<string, object>> rights) {
			var displayRights = new Dictionary<int, string>();
			for (int i = 0; i < rights.Count; i++) {
				var right = rights[i];
				int source = Convert.ToInt32(right["Source"]);
				if (!Enum.IsDefined(typeof(ProcessSchemaParameterValueSource), source)) {
					continue;
				}
				var parameterSource = (ProcessSchemaParameterValueSource)source;
				if (parameterSource == ProcessSchemaParameterValueSource.Script) {
					continue;
				}
				if (parameterSource == ProcessSchemaParameterValueSource.ConstValue) {
					//"AllRolesAndUsers" ,”Role”, “Employee”, “DataSourceFilter”
					if (right["Grantee"].ToString() == "Employee") {
						var contact = new Terrasoft.Configuration.Contact(UserConnection);
						if (contact.FetchPrimaryInfoFromDB("Id", new Guid(right["Value"].ToString()))) {
							displayRights.Add(i, contact.PrimaryDisplayColumnValue);
						}
					} else if (right["Grantee"].ToString() == "Role") {
						var sysAdminUnit = new Terrasoft.Configuration.SysAdminUnit(UserConnection);
						if (sysAdminUnit.FetchPrimaryInfoFromDB("Id", new Guid(right["Value"].ToString()))) {
							displayRights.Add(i, sysAdminUnit.PrimaryDisplayColumnValue);
						}
					}
				} else if (parameterSource != ProcessSchemaParameterValueSource.SystemSetting
						&& parameterSource != ProcessSchemaParameterValueSource.SystemValue) {
					ProcessSchema processSchema = FindDesignedProcessSchema();
					var generator = new ProcessSchemaGeneratorNew(UserConnection, processSchema.ProcessSchemaManager.Namespace);
					displayRights.Add(i, generator.GetPropertyPathByMetaPath(new ProcessSchemaParameter(processSchema),
						generator.GetMetaPath(processSchema, right["Value"].ToString()), true));
				}
			}
			foreach (var displayName in displayRights) {
				rights[displayName.Key]["Name"] = displayName.Value;
			}
		}

		public virtual List<ProcessSchemaParameter> GenerateUserTaskCustomParameters(ProcessSchema schema, Guid userTaskUId, List<Dictionary<string, object>> items) {
			if (items == null || items.Count == 0) {
				return new List<ProcessSchemaParameter>(0);
			}
			var modifiedParameters = new List<ProcessSchemaParameter>(items.Count * 2);
			string scriptSource = ((int)ProcessSchemaParameterValueSource.Script).ToString();
			foreach(Dictionary<string, object> item in items) {
				if ((string)item["Source"] != scriptSource) {
					continue;
				}
				modifiedParameters.Add(CreateCustomParameter(schema, userTaskUId, item));
			}
			return modifiedParameters;
		}

		public virtual ProcessSchemaParameter CreateCustomParameter(ProcessSchema schema, Guid userTaskUId, Dictionary<string, object> item) {
			Guid referenceSchemaUId;
			var grantee = (string)item["Grantee"];
			if (grantee == "Role") {
				referenceSchemaUId = SysAdminUnitSchemaUId;
			} else {
				//(grantee == "Employee")
				referenceSchemaUId = ContactSchemaUId;
			}
			var name = GenerateParameterName(grantee);
			return new ProcessSchemaParameter(schema) {
				UId = new Guid((string)item["Id"]),
				Name = name,
				Caption = name,
				ContainerUId = userTaskUId,
				DataValueTypeUId = LookupTypeUId,
				ReferenceSchemaUId = referenceSchemaUId,
				SourceValue = {
					ModifiedInSchemaUId = schema.UId,
					Value = (string)item["Value"],
					DisplayValue = (string)item["Name"],
					Source = ProcessSchemaParameterValueSource.Script
				}
			};
		}

		public virtual string GenerateParameterName(string prefix) {
			var userTaskParameterNames = UserTaskParameterNames == null
				? new List<string>(16) : (List<string>)UserTaskParameterNames;
			int idx = 1;
			var inc = "1";
			string name = prefix + inc;
			if (userTaskParameterNames != null && userTaskParameterNames.Count != 0) {
				while (userTaskParameterNames.Contains(name)) {
					idx++;
					inc = idx.ToString();
					name = prefix + inc;
				}
			}
			userTaskParameterNames.Add(name);
			UserTaskParameterNames = userTaskParameterNames;
			return name;
		}

		public virtual void ActualizeParameterValues(List<Dictionary<string, object>> items, ProcessSchemaUserTask userTask, ProcessSchema schema) {
			if (items == null || items.Count == 0) {
				return;
			}
			var source = ((int)ProcessSchemaParameterValueSource.Script).ToString();
			foreach (ProcessSchemaParameter parameter in userTask.Parameters) {
				if (parameter.CreatedInSchemaUId != schema.UId
						|| parameter.SourceValue.Source != ProcessSchemaParameterValueSource.Script) {
					continue;
				}
				var parameterUId = parameter.UId.ToString();
				foreach (Dictionary<string, object> item in items) {
					if ((string)item["Id"] == parameterUId) {
						item["Source"] = source;
						item["Name"] = parameter.SourceValue.DisplayValue;
						item["Value"] = parameter.SourceValue.Value;
						break;
					}
				}
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddRightAddButtonClick":
							if (ActivatedEventElements.Contains("AddRightAddButtonClickStartMessage1")) {
							context.QueueTasks.Enqueue("AddRightAddButtonClickStartMessage1");
						}
						break;
					case "AddRightsRecordEditPageClosed":
							if (ActivatedEventElements.Contains("AddRightsRecordEditPageClosedStartMessage1")) {
							context.QueueTasks.Enqueue("AddRightsRecordEditPageClosedStartMessage1");
						}
						break;
					case "AddRightEditButtonClick":
							if (ActivatedEventElements.Contains("AddRightEditButtonClickStartMessage1")) {
							context.QueueTasks.Enqueue("AddRightEditButtonClickStartMessage1");
						}
						break;
					case "AddRightsTreeGridDblClick":
							if (ActivatedEventElements.Contains("AddRightsTreeGridDblClickStartMessage1")) {
							context.QueueTasks.Enqueue("AddRightsTreeGridDblClickStartMessage1");
						}
						break;
					case "AddRighDeletetButtonClick":
							if (ActivatedEventElements.Contains("AddRighDeletetButtonClickStartMessage2")) {
							context.QueueTasks.Enqueue("AddRighDeletetButtonClickStartMessage2");
						}
						break;
					case "DownRighDeletetButtonClick":
							if (ActivatedEventElements.Contains("DownRighDeletetButtonClickStartMessage4")) {
							context.QueueTasks.Enqueue("DownRighDeletetButtonClickStartMessage4");
						}
						break;
					case "UpRighDeletetButtonClick":
							if (ActivatedEventElements.Contains("UpRighDeletetButtonClickStartMessage3")) {
							context.QueueTasks.Enqueue("UpRighDeletetButtonClickStartMessage3");
						}
						break;
					case "DeleteRightAddButtonClick":
							if (ActivatedEventElements.Contains("DeleteRightAddButtonClickStartMessage1")) {
							context.QueueTasks.Enqueue("DeleteRightAddButtonClickStartMessage1");
						}
						break;
					case "DeleteRightDeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteRightDeleteButtonClickStartMessage3")) {
							context.QueueTasks.Enqueue("DeleteRightDeleteButtonClickStartMessage3");
						}
						break;
					case "DeleteRightEditButtonClick":
							if (ActivatedEventElements.Contains("DeleteRightEditButtonClickStartMessage2")) {
							context.QueueTasks.Enqueue("DeleteRightEditButtonClickStartMessage2");
						}
						break;
					case "DeleteRightsTreeGridDblClick":
							if (ActivatedEventElements.Contains("DeleteRightsTreeGridDblClickStartMessage1")) {
							context.QueueTasks.Enqueue("DeleteRightsTreeGridDblClickStartMessage1");
						}
						break;
					case "DeleteRightsRecordEditPageClosed":
							if (ActivatedEventElements.Contains("DeleteRightsRecordEditPageClosedStartMessage1")) {
							context.QueueTasks.Enqueue("DeleteRightsRecordEditPageClosedStartMessage1");
						}
						break;
					case "AddRightsTreeGridSelectionChange":
							if (ActivatedEventElements.Contains("AddRightsTreeGridSelectionChangeStartMessage2")) {
							context.QueueTasks.Enqueue("AddRightsTreeGridSelectionChangeStartMessage2");
						}
						break;
					case "DeleteRightsTreeGridSelectionChange":
							if (ActivatedEventElements.Contains("DeleteRightsTreeGridSelectionChangeStartMessage1")) {
							context.QueueTasks.Enqueue("DeleteRightsTreeGridSelectionChangeStartMessage1");
						}
						break;
					case "EntitySchemaEditChange":
							if (ActivatedEventElements.Contains("EntitySchemaEditChangeStartMessage1")) {
							context.QueueTasks.Enqueue("EntitySchemaEditChangeStartMessage1");
						}
						break;
					case "ChangeSchemaEntityYesMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityYesMessageStartMessage1")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityYesMessageStartMessage1");
						}
						break;
					case "ChangeSchemaEntityNoMessage":
							if (ActivatedEventElements.Contains("ChangeSchemaEntityNoMessageStartMessage2")) {
							context.QueueTasks.Enqueue("ChangeSchemaEntityNoMessageStartMessage2");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage1")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage2")) {
							context.QueueTasks.Enqueue("InitStartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage1")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage1");
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
			if (UserTaskParameterNames != null) {
				if (UserTaskParameterNames.GetType().IsSerializable ||
					UserTaskParameterNames.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("UserTaskParameterNames", UserTaskParameterNames, null);
				}
			}
			if (!HasMapping("LookupTypeUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LookupTypeUId", LookupTypeUId, Guid.Empty);
			}
			if (!HasMapping("ContactSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ContactSchemaUId", ContactSchemaUId, Guid.Empty);
			}
			if (!HasMapping("SysAdminUnitSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysAdminUnitSchemaUId", SysAdminUnitSchemaUId, Guid.Empty);
			}
			if (!HasMapping("InsertedDeleteRightColumnValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InsertedDeleteRightColumnValueKey", InsertedDeleteRightColumnValueKey, null);
			}
			if (!HasMapping("IsValidDataSourceFilter") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsValidDataSourceFilter", IsValidDataSourceFilter, false);
			}
			if (!HasMapping("AddRightsSessionKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AddRightsSessionKey", AddRightsSessionKey, null);
			}
			if (!HasMapping("DeleteRightsSessionKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DeleteRightsSessionKey", DeleteRightsSessionKey, null);
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

	#region Class: ChangeAdminRightsUserTaskParametersEditPageEventsProcess

	/// <exclude/>
	public class ChangeAdminRightsUserTaskParametersEditPageEventsProcess : ChangeAdminRightsUserTaskParametersEditPageEventsProcess<Terrasoft.WebApp.ChangeAdminRightsUserTaskParametersEditPageSchemaUserControl>
	{

		public ChangeAdminRightsUserTaskParametersEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeAdminRightsUserTaskParametersEditPageSchemaUserControl

	/// <exclude/>
	public partial class ChangeAdminRightsUserTaskParametersEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
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

		public Terrasoft.UI.WebControls.Controls.LookupEdit EntitySchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("EntitySchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
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

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout5 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout5", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout6 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout6", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteRightAddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteRightAddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteRightEditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteRightEditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteRightDeleteButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteRightDeleteButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid DeleteRightsTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("DeleteRightsTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout4 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout4", true);
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

		public Terrasoft.UI.WebControls.Controls.Button AddRightAddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddRightAddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddRightEditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddRightEditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddRighDeletetButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddRighDeletetButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer2", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button UpRighDeletetButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("UpRighDeletetButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DownRighDeletetButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DownRighDeletetButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid AddRightsTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("AddRightsTreeGrid", true);
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
			EntitySchemaEdit.AjaxEvents.Change.Event += EntitySchemaEditChange;
			DeleteRightAddButton.AjaxEvents.Click.Event += DeleteRightAddButtonClick;
			DeleteRightEditButton.AjaxEvents.Click.Event += DeleteRightEditButtonClick;
			DeleteRightDeleteButton.AjaxEvents.Click.Event += DeleteRightDeleteButtonClick;
			DeleteRightsTreeGrid.AjaxEvents.DblClick.Event += DeleteRightsTreeGridDblClick;
			DeleteRightsTreeGrid.AjaxEvents.SelectionChange.Event += DeleteRightsTreeGridSelectionChange;
			AddRightAddButton.AjaxEvents.Click.Event += AddRightAddButtonClick;
			AddRightEditButton.AjaxEvents.Click.Event += AddRightEditButtonClick;
			AddRighDeletetButton.AjaxEvents.Click.Event += AddRighDeletetButtonClick;
			UpRighDeletetButton.AjaxEvents.Click.Event += UpRighDeletetButtonClick;
			DownRighDeletetButton.AjaxEvents.Click.Event += DownRighDeletetButtonClick;
			AddRightsTreeGrid.AjaxEvents.DblClick.Event += AddRightsTreeGridDblClick;
			AddRightsTreeGrid.AjaxEvents.SelectionChange.Event += AddRightsTreeGridSelectionChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			EntitySchemaEdit.AjaxEvents.Change.Event -= EntitySchemaEditChange;
			DeleteRightAddButton.AjaxEvents.Click.Event -= DeleteRightAddButtonClick;
			DeleteRightEditButton.AjaxEvents.Click.Event -= DeleteRightEditButtonClick;
			DeleteRightDeleteButton.AjaxEvents.Click.Event -= DeleteRightDeleteButtonClick;
			DeleteRightsTreeGrid.AjaxEvents.DblClick.Event -= DeleteRightsTreeGridDblClick;
			DeleteRightsTreeGrid.AjaxEvents.SelectionChange.Event -= DeleteRightsTreeGridSelectionChange;
			AddRightAddButton.AjaxEvents.Click.Event -= AddRightAddButtonClick;
			AddRightEditButton.AjaxEvents.Click.Event -= AddRightEditButtonClick;
			AddRighDeletetButton.AjaxEvents.Click.Event -= AddRighDeletetButtonClick;
			UpRighDeletetButton.AjaxEvents.Click.Event -= UpRighDeletetButtonClick;
			DownRighDeletetButton.AjaxEvents.Click.Event -= DownRighDeletetButtonClick;
			AddRightsTreeGrid.AjaxEvents.DblClick.Event -= AddRightsTreeGridDblClick;
			AddRightsTreeGrid.AjaxEvents.SelectionChange.Event -= AddRightsTreeGridSelectionChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ChangeAdminRightsUserTaskParametersEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ChangeAdminRightsUserTaskParametersEditPageEventsProcess(UserConnection);
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

		public virtual void DeleteRightAddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteRightAddButtonClick");
		}

		public virtual void DeleteRightEditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteRightEditButtonClick");
		}

		public virtual void DeleteRightDeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteRightDeleteButtonClick");
		}

		public virtual void DeleteRightsTreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteRightsTreeGridDblClick");
		}

		public virtual void DeleteRightsTreeGridSelectionChange(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteRightsTreeGridSelectionChange");
		}

		public virtual void AddRightAddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddRightAddButtonClick");
		}

		public virtual void AddRightEditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddRightEditButtonClick");
		}

		public virtual void AddRighDeletetButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddRighDeletetButtonClick");
		}

		public virtual void UpRighDeletetButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("UpRighDeletetButtonClick");
		}

		public virtual void DownRighDeletetButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DownRighDeletetButtonClick");
		}

		public virtual void AddRightsTreeGridDblClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddRightsTreeGridDblClick");
		}

		public virtual void AddRightsTreeGridSelectionChange(object sender, EventArgs e) {
			object result = ThrowEvent("AddRightsTreeGridSelectionChange");
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
			SchemaName = "ChangeAdminRightsUserTaskParametersEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema

	/// <exclude/>
	public class ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema(ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ChangeAdminRightsUserTaskParametersEditPageEventsProcess";
			UId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642");
			CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cd2c9e19-9ce6-41ee-bdd9-c68044d0000e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDeleteRightsSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("82e53d1b-958f-4344-835a-0ca9d29ce397"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightsSessionKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddRightsSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c53454eb-b8aa-450d-be8a-31c4862b4792"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightsSessionKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsValidDataSourceFilterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f985e367-3bbc-4e22-b041-ff41295966a2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"IsValidDataSourceFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedDeleteRightColumnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ec56ca9-9290-4cd6-a7f6-eb4dc4c6e363"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"InsertedDeleteRightColumnValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSysAdminUnitSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fa90f866-28a5-4d20-abd0-32a27e6f4954"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"SysAdminUnitSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("28f1da7c-df35-46ce-ae79-84282d095445"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ContactSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLookupTypeUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d3da1beb-c00c-4305-a102-bbb79b4eaf08"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"LookupTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateUserTaskParameterNamesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c04bb21d-c4a1-40a4-8ad0-b6b4dfe43e82"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"UserTaskParameterNames",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateDeleteRightsSessionKeyParameter());
			Parameters.Add(CreateAddRightsSessionKeyParameter());
			Parameters.Add(CreateIsValidDataSourceFilterParameter());
			Parameters.Add(CreateInsertedDeleteRightColumnValueKeyParameter());
			Parameters.Add(CreateSysAdminUnitSchemaUIdParameter());
			Parameters.Add(CreateContactSchemaUIdParameter());
			Parameters.Add(CreateLookupTypeUIdParameter());
			Parameters.Add(CreateUserTaskParameterNamesParameter());
		}

		protected virtual void InitializeOpenAddRightsRecordEditPageOnAddParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5edc68dd-7316-43d8-b80f-4101d170ba37"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("e67852f0-96be-43d7-bd81-4cc44b6981c2"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("f2cc734a-c439-424b-8fff-346d2a90569b"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("eb69113f-da6e-4f84-a1a7-06d12619bb9a"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("46ce67db-a39f-4e17-9f50-8d6dbc6cf5c7"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("ef5099f7-96fd-4e50-8ada-c75fc9647440"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("229390c2-1c39-41dd-84ad-12a85bbb0a29"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("0d489603-518a-464c-a7fc-10074f0103d8"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("ae15c85b-2cb0-4e41-bc4e-b7a003800a61"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("39bee79c-0259-4a13-b40e-071372b9c908"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("93082e77-1eb0-4a73-97ad-af418293b60f"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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
				UId = new Guid("810b5717-52d0-4c96-9613-f78ae9f6264a"),
				ContainerUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
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

		protected virtual void InitializeOpenAddRightsRecordEditPageOnEditParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("6f20c343-fbd1-4777-b0e3-64fa00ba70ad"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("dd04c9f9-51e5-4972-a615-fc47968fd8c7"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("ae69f2a8-e509-475b-9924-c2426b8f7b55"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("1e41913a-2390-43cb-9dd4-9926143af22e"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("99e6cbe6-c47c-48fc-9667-ca7e647a1300"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("1d05fa38-ea02-4c7f-b5c7-e4f55682a9d3"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("012c6eb8-0df6-4702-b811-23c4959bb3ad"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("62e4c215-5af8-4dfc-a42a-fb39747588ad"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("03974a4a-9da5-42ad-b110-a90120ad531e"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("092c6a6d-361d-4ebb-a893-1025bd9ada58"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("8a1ec6ae-525d-4be3-8048-dad95d7db72f"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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
				UId = new Guid("de9eff6a-3ec8-43cb-9a16-9f960a12a3c1"),
				ContainerUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
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

		protected virtual void InitializeOpenDeleteRightsRecordEditPageOnAddParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("73d713b8-91e4-4b7f-8434-5e74846a0d2f"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("33b4c7b5-8c23-4e41-a7a0-3fbfc3b9ed3e"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("bc3c8481-8f84-411a-87a6-9faa60aa0ef9"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("4ac111bc-d498-4a6e-8472-7b0540fc5b9b"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("fe3d03b1-df10-4d94-b32c-bd35a37cef8a"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("aae78aae-801a-4c9e-9bd4-9a4d0bb96239"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("3beb7ad5-fdcb-4ad1-8b0e-433e1ee88b32"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("65846c5a-4a03-4c70-a654-273cf7c3a4b0"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("8af32c90-3e31-446a-8a4f-032c01a1ea66"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("fd819ff1-4549-473b-a905-103fb11e8c57"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("1d0d7bc8-2bd2-4be9-b71d-8962f2a6b234"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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
				UId = new Guid("810422ff-a393-4aae-b804-75065d9a762c"),
				ContainerUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
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

		protected virtual void InitializeDeleteRightEditButtonClickOnEditParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c764d300-e573-4646-b1c4-10055b01fbf9"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("dcefdc72-93f6-4a1c-8253-ac8eda5e596c"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("56f911cc-5a70-482c-9f53-58717d488ce4"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("5774437c-fefe-445f-bb25-acbc989711ec"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("8f9cb438-d53d-424e-8c84-fd977630612d"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("1b4d4415-cc61-4b90-93c8-0feaa5b6818e"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("d9a358fc-45f7-48a9-b75d-6cb4be9152aa"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("e5422d43-4afa-40c4-a539-2082725f039a"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("9afd0e6b-15e9-4c46-9c18-4a942ab5522f"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("0361718e-c286-4805-b822-8ac3012b5bad"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("7711346d-d822-4a7c-bd90-e2cbd582bb0b"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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
				UId = new Guid("9640932c-1c73-4ca4-8c0c-9ef0d723b391"),
				ContainerUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
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

		protected virtual void InitializeChangeSchemaEntityUserMessageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("bb025f94-c7c1-4e65-8a00-c9e16c660c13"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("47e0cbf6-58d3-4f57-a87f-73b0c7b0dce8"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("febbc0db-5b56-466f-bce3-990b034c78b3"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("4680c39f-f5bd-46b5-8f1f-7a28a83e677d"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("c7f5fce3-f288-4fb3-94f4-bc359e45178c"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("9073c4aa-49ae-4f20-9e87-e84b79b84d84"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("fd0c3daf-de9d-45ef-a4eb-bb809b9bce17"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
				UId = new Guid("2456c487-d4ec-4c79-9d09-03bb69fa5420"),
				ContainerUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
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
			ProcessSchemaLane schemaLane7 = CreateLane7Lane();
			schemaLaneSet1.Lanes.Add(schemaLane7);
			ProcessSchemaEventSubProcess eventsubprocess15 = CreateEventSubProcess15EventSubProcess();
			FlowElements.Add(eventsubprocess15);
			ProcessSchemaEventSubProcess eventsubprocess16 = CreateEventSubProcess16EventSubProcess();
			FlowElements.Add(eventsubprocess16);
			ProcessSchemaEventSubProcess eventsubprocess17 = CreateEventSubProcess17EventSubProcess();
			FlowElements.Add(eventsubprocess17);
			ProcessSchemaEventSubProcess eventsubprocess21 = CreateEventSubProcess21EventSubProcess();
			FlowElements.Add(eventsubprocess21);
			ProcessSchemaEventSubProcess eventsubprocess18 = CreateEventSubProcess18EventSubProcess();
			FlowElements.Add(eventsubprocess18);
			ProcessSchemaEventSubProcess eventsubprocess20 = CreateEventSubProcess20EventSubProcess();
			FlowElements.Add(eventsubprocess20);
			ProcessSchemaEventSubProcess eventsubprocess19 = CreateEventSubProcess19EventSubProcess();
			FlowElements.Add(eventsubprocess19);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess12 = CreateEventSubProcess12EventSubProcess();
			FlowElements.Add(eventsubprocess12);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaEventSubProcess eventsubprocess13 = CreateEventSubProcess13EventSubProcess();
			FlowElements.Add(eventsubprocess13);
			ProcessSchemaEventSubProcess eventsubprocess14 = CreateEventSubProcess14EventSubProcess();
			FlowElements.Add(eventsubprocess14);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess7 = CreateEventSubProcess7EventSubProcess();
			FlowElements.Add(eventsubprocess7);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaStartMessageEvent addrightaddbuttonclickstartmessage1 = CreateAddRightAddButtonClickStartMessage1StartMessageEvent();
			eventsubprocess15.FlowElements.Add(addrightaddbuttonclickstartmessage1);
			ProcessSchemaScriptTask addrightaddbuttonclickscripttask1 = CreateAddRightAddButtonClickScriptTask1ScriptTask();
			eventsubprocess15.FlowElements.Add(addrightaddbuttonclickscripttask1);
			ProcessSchemaUserTask openaddrightsrecordeditpageonadd = CreateOpenAddRightsRecordEditPageOnAddUserTask();
			eventsubprocess15.FlowElements.Add(openaddrightsrecordeditpageonadd);
			ProcessSchemaStartMessageEvent addrightsrecordeditpageclosedstartmessage1 = CreateAddRightsRecordEditPageClosedStartMessage1StartMessageEvent();
			eventsubprocess16.FlowElements.Add(addrightsrecordeditpageclosedstartmessage1);
			ProcessSchemaScriptTask addrightsrecordeditpageclosedscripttask1 = CreateAddRightsRecordEditPageClosedScriptTask1ScriptTask();
			eventsubprocess16.FlowElements.Add(addrightsrecordeditpageclosedscripttask1);
			ProcessSchemaStartMessageEvent addrighteditbuttonclickstartmessage1 = CreateAddRightEditButtonClickStartMessage1StartMessageEvent();
			eventsubprocess17.FlowElements.Add(addrighteditbuttonclickstartmessage1);
			ProcessSchemaScriptTask addrighteditbuttonclickscripttask1 = CreateAddRightEditButtonClickScriptTask1ScriptTask();
			eventsubprocess17.FlowElements.Add(addrighteditbuttonclickscripttask1);
			ProcessSchemaUserTask openaddrightsrecordeditpageonedit = CreateOpenAddRightsRecordEditPageOnEditUserTask();
			eventsubprocess17.FlowElements.Add(openaddrightsrecordeditpageonedit);
			ProcessSchemaStartMessageEvent addrightstreegriddblclickstartmessage1 = CreateAddRightsTreeGridDblClickStartMessage1StartMessageEvent();
			eventsubprocess21.FlowElements.Add(addrightstreegriddblclickstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent addrighteditbuttonclickintermediatethrowmessageevent2 = CreateAddRightEditButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess21.FlowElements.Add(addrighteditbuttonclickintermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent addrighdeletetbuttonclickstartmessage2 = CreateAddRighDeletetButtonClickStartMessage2StartMessageEvent();
			eventsubprocess18.FlowElements.Add(addrighdeletetbuttonclickstartmessage2);
			ProcessSchemaScriptTask addrighdeletetbuttonclickscripttask2 = CreateAddRighDeletetButtonClickScriptTask2ScriptTask();
			eventsubprocess18.FlowElements.Add(addrighdeletetbuttonclickscripttask2);
			ProcessSchemaStartMessageEvent downrighdeletetbuttonclickstartmessage4 = CreateDownRighDeletetButtonClickStartMessage4StartMessageEvent();
			eventsubprocess20.FlowElements.Add(downrighdeletetbuttonclickstartmessage4);
			ProcessSchemaScriptTask downrighdeletetbuttonclickscripttask4 = CreateDownRighDeletetButtonClickScriptTask4ScriptTask();
			eventsubprocess20.FlowElements.Add(downrighdeletetbuttonclickscripttask4);
			ProcessSchemaStartMessageEvent uprighdeletetbuttonclickstartmessage3 = CreateUpRighDeletetButtonClickStartMessage3StartMessageEvent();
			eventsubprocess19.FlowElements.Add(uprighdeletetbuttonclickstartmessage3);
			ProcessSchemaScriptTask uprighdeletetbuttonclickscripttask3 = CreateUpRighDeletetButtonClickScriptTask3ScriptTask();
			eventsubprocess19.FlowElements.Add(uprighdeletetbuttonclickscripttask3);
			ProcessSchemaStartMessageEvent deleterightaddbuttonclickstartmessage1 = CreateDeleteRightAddButtonClickStartMessage1StartMessageEvent();
			eventsubprocess10.FlowElements.Add(deleterightaddbuttonclickstartmessage1);
			ProcessSchemaScriptTask deleterightaddbuttonclickscripttask1 = CreateDeleteRightAddButtonClickScriptTask1ScriptTask();
			eventsubprocess10.FlowElements.Add(deleterightaddbuttonclickscripttask1);
			ProcessSchemaUserTask opendeleterightsrecordeditpageonadd = CreateOpenDeleteRightsRecordEditPageOnAddUserTask();
			eventsubprocess10.FlowElements.Add(opendeleterightsrecordeditpageonadd);
			ProcessSchemaStartMessageEvent deleterightdeletebuttonclickstartmessage3 = CreateDeleteRightDeleteButtonClickStartMessage3StartMessageEvent();
			eventsubprocess12.FlowElements.Add(deleterightdeletebuttonclickstartmessage3);
			ProcessSchemaScriptTask deleterightdeletebuttonclickscripttask3 = CreateDeleteRightDeleteButtonClickScriptTask3ScriptTask();
			eventsubprocess12.FlowElements.Add(deleterightdeletebuttonclickscripttask3);
			ProcessSchemaStartMessageEvent deleterighteditbuttonclickstartmessage2 = CreateDeleteRightEditButtonClickStartMessage2StartMessageEvent();
			eventsubprocess11.FlowElements.Add(deleterighteditbuttonclickstartmessage2);
			ProcessSchemaScriptTask deleterighteditbuttonclickscripttask2 = CreateDeleteRightEditButtonClickScriptTask2ScriptTask();
			eventsubprocess11.FlowElements.Add(deleterighteditbuttonclickscripttask2);
			ProcessSchemaUserTask deleterighteditbuttonclickonedit = CreateDeleteRightEditButtonClickOnEditUserTask();
			eventsubprocess11.FlowElements.Add(deleterighteditbuttonclickonedit);
			ProcessSchemaStartMessageEvent deleterightstreegriddblclickstartmessage1 = CreateDeleteRightsTreeGridDblClickStartMessage1StartMessageEvent();
			eventsubprocess13.FlowElements.Add(deleterightstreegriddblclickstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent deleterighteditbuttonclickintermediatethrowmessageevent2 = CreateDeleteRightEditButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess13.FlowElements.Add(deleterighteditbuttonclickintermediatethrowmessageevent2);
			ProcessSchemaStartMessageEvent deleterightsrecordeditpageclosedstartmessage1 = CreateDeleteRightsRecordEditPageClosedStartMessage1StartMessageEvent();
			eventsubprocess14.FlowElements.Add(deleterightsrecordeditpageclosedstartmessage1);
			ProcessSchemaScriptTask deleterightsrecordeditpageclosedscripttask1 = CreateDeleteRightsRecordEditPageClosedScriptTask1ScriptTask();
			eventsubprocess14.FlowElements.Add(deleterightsrecordeditpageclosedscripttask1);
			ProcessSchemaStartMessageEvent addrightstreegridselectionchangestartmessage2 = CreateAddRightsTreeGridSelectionChangeStartMessage2StartMessageEvent();
			eventsubprocess8.FlowElements.Add(addrightstreegridselectionchangestartmessage2);
			ProcessSchemaScriptTask addrightstreegridselectionchangescripttask2 = CreateAddRightsTreeGridSelectionChangeScriptTask2ScriptTask();
			eventsubprocess8.FlowElements.Add(addrightstreegridselectionchangescripttask2);
			ProcessSchemaStartMessageEvent deleterightstreegridselectionchangestartmessage1 = CreateDeleteRightsTreeGridSelectionChangeStartMessage1StartMessageEvent();
			eventsubprocess7.FlowElements.Add(deleterightstreegridselectionchangestartmessage1);
			ProcessSchemaScriptTask deleterightstreegridselectionchangescripttask1 = CreateDeleteRightsTreeGridSelectionChangeScriptTask1ScriptTask();
			eventsubprocess7.FlowElements.Add(deleterightstreegridselectionchangescripttask1);
			ProcessSchemaStartMessageEvent entityschemaeditchangestartmessage1 = CreateEntitySchemaEditChangeStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(entityschemaeditchangestartmessage1);
			ProcessSchemaScriptTask objecteditchangescripttask1 = CreateObjectEditChangeScriptTask1ScriptTask();
			eventsubprocess2.FlowElements.Add(objecteditchangescripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess2.FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask changeschemaentityusermessage = CreateChangeSchemaEntityUserMessageUserTask();
			eventsubprocess2.FlowElements.Add(changeschemaentityusermessage);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent changeschemaentityyesmessagestartmessage1 = CreateChangeSchemaEntityYesMessageStartMessage1StartMessageEvent();
			eventsubprocess3.FlowElements.Add(changeschemaentityyesmessagestartmessage1);
			ProcessSchemaScriptTask changeschemaentityyesmessagescripttask1 = CreateChangeSchemaEntityYesMessageScriptTask1ScriptTask();
			eventsubprocess3.FlowElements.Add(changeschemaentityyesmessagescripttask1);
			ProcessSchemaStartMessageEvent changeschemaentitynomessagestartmessage2 = CreateChangeSchemaEntityNoMessageStartMessage2StartMessageEvent();
			eventsubprocess4.FlowElements.Add(changeschemaentitynomessagestartmessage2);
			ProcessSchemaScriptTask changeschemaentitynomessagescripttask2 = CreateChangeSchemaEntityNoMessageScriptTask2ScriptTask();
			eventsubprocess4.FlowElements.Add(changeschemaentitynomessagescripttask2);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage1 = CreatePageLoadCompleteStartMessage1StartMessageEvent();
			eventsubprocess5.FlowElements.Add(pageloadcompletestartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteintermediatethrowmessageevent2 = CreatePageLoadCompleteIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(pageloadcompleteintermediatethrowmessageevent2);
			ProcessSchemaScriptTask pageloadcompletescripttask1 = CreatePageLoadCompleteScriptTask1ScriptTask();
			eventsubprocess5.FlowElements.Add(pageloadcompletescripttask1);
			ProcessSchemaStartMessageEvent initstartmessage2 = CreateInitStartMessage2StartMessageEvent();
			eventsubprocess6.FlowElements.Add(initstartmessage2);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent3 = CreateInitIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(initintermediatethrowmessageevent3);
			ProcessSchemaScriptTask initscripttask2 = CreateInitScriptTask2ScriptTask();
			eventsubprocess6.FlowElements.Add(initscripttask2);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage1 = CreateOkButtonClickStartMessage1StartMessageEvent();
			eventsubprocess9.FlowElements.Add(okbuttonclickstartmessage1);
			ProcessSchemaScriptTask checkdatascripttask1 = CreateCheckDataScriptTask1ScriptTask();
			eventsubprocess9.FlowElements.Add(checkdatascripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess9.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask scriptchildokbuttonclick = CreateScriptChildOkButtonClickScriptTask();
			eventsubprocess9.FlowElements.Add(scriptchildokbuttonclick);
			ProcessSchemaScriptTask errormessagescripttask = CreateErrorMessageScriptTaskScriptTask();
			eventsubprocess9.FlowElements.Add(errormessagescripttask);
			ProcessSchemaIntermediateThrowMessageEvent baseokbuttonclickintermediatethrowmessageevent2 = CreateBaseOkButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess9.FlowElements.Add(baseokbuttonclickintermediatethrowmessageevent2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
			FlowElements.Add(CreateSequenceFlow30SequenceFlow());
			FlowElements.Add(CreateSequenceFlow31SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSysAdminUnitNameColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateCanReadColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateCanEditColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateCanDeleteColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateRecordOperationRightLevelColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateChangeSchemaEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageTitleLocalizableString());
			LocalizableStrings.Add(CreateValidationMessageLocalizableString());
			LocalizableStrings.Add(CreateAllowOperationRightLevelLocalizableString());
			LocalizableStrings.Add(CreateDenayOperationRightLevelLocalizableString());
			LocalizableStrings.Add(CreateAllowAndGrantOperationRightLevelLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSysAdminUnitNameColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("71674a74-4686-4374-8fc5-36a4175bf892"),
				Name = "SysAdminUnitNameColumnCaption",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanReadColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("108a0723-bb86-49a1-9b33-de1a4208f118"),
				Name = "CanReadColumnCaption",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanEditColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e1febcbd-3670-42c4-b4d6-78c8790fb274"),
				Name = "CanEditColumnCaption",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanDeleteColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c73eb61-5e36-486d-b366-f82dab504ee0"),
				Name = "CanDeleteColumnCaption",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRecordOperationRightLevelColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d08d79c2-6c25-4c28-a846-4af6095b3d16"),
				Name = "RecordOperationRightLevelColumnCaption",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChangeSchemaEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7f523e17-c5bf-4711-828c-cf66b55a64a9"),
				Name = "ChangeSchemaEntityMessage",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0ad0b8b5-bb19-4dda-9471-5ecd3dbab424"),
				Name = "ValidationMessageTitle",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5d85b523-faa2-425a-9ff1-2897a7024300"),
				Name = "ValidationMessage",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAllowOperationRightLevelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2a93e20c-a5ef-4e5e-995d-0e8834018cf3"),
				Name = "AllowOperationRightLevel",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDenayOperationRightLevelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ba8b53e6-9088-4752-8f50-bad086619b50"),
				Name = "DenayOperationRightLevel",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAllowAndGrantOperationRightLevelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5f0a65ab-dc0d-49d8-b0c6-c2f5eb66723c"),
				Name = "AllowAndGrantOperationRightLevel",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f4feb8fc-63f2-41ec-8a24-7d779f4ae17e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6539cdb8-53df-421c-8bb4-8777863e51b5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("07d8e729-844f-44cb-8639-ea00cfaf872d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("3dc08df0-e2ff-4384-865a-f696b85a0176"),
				ConditionExpression = @"IsEntitySchemaChanged()",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(362, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07d8e729-844f-44cb-8639-ea00cfaf872d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("df0226e5-9391-427c-8478-9cc501182d24"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b7a91f49-eb11-40f6-b541-f9f5880ba1cf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(477, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("df0226e5-9391-427c-8478-9cc501182d24"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("2524ecbe-6cca-4bda-9df1-3c84804505f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(187, 132),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07d8e729-844f-44cb-8639-ea00cfaf872d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06c2438e-1751-4207-8139-ea05c8cc282b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c7f76e70-7f2a-4dfc-86c6-3a576462d0e9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(180, 353),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3de779d6-7534-4e05-aaf2-dd15db8ac124"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f446def4-6f7a-4514-8ec9-fab02a6e0006"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("086b0e25-6493-43f5-9e0c-51eeb83b9a90"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(448, 352),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("56c142a4-3a74-4249-9a92-f54d885de59b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7118b60b-3292-4ca3-87da-baa6637c8e27"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("63384a3d-57c9-4f49-858c-dedea35defb3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(182, 726),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2275b122-6887-4b74-b002-90f556dd0f97"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9a10726a-7eec-46a3-92c8-b32dd2170c6b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("16fb2f93-000a-4123-ae1b-80c4343af9e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(176, 561),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52e99ed4-2d9e-4987-b967-62390f2c4140"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79d32c88-8d27-4e80-8fd1-00b0ea13985b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("e3df2fc3-6a20-4d69-9dc5-8a8a403e25e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(272, 722),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9a10726a-7eec-46a3-92c8-b32dd2170c6b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cc017de6-bd15-41d0-9ae7-a94021ffadba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("d8b452ac-718a-4033-838a-c9a2be4b11eb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(277, 563),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79d32c88-8d27-4e80-8fd1-00b0ea13985b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ecbdfcdd-5543-4356-8dd6-fd88d7d111cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("1ed15cf0-5856-44c4-8d57-1c2f58dc95a3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c705debe-a8b4-411b-9a6d-d3c636aa9ab0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("279df4de-07ac-48e9-a0a5-4beb9c7f2e5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("95a56c55-20e6-4e39-ae93-65cf5b2fb437"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c4cb0e7-e65d-4bf6-898c-d1c9a31f27c6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9773719b-91cb-4bb0-8ad9-980567e8f2ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("acb9961a-63e8-4003-8e8b-6aa7d2991494"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(171, 543),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("10cf12ab-bc97-487d-a2f8-e64c98bf7434"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f1f73d7f-c177-4349-89cb-62cde629edeb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("2b8d218a-f56e-48c6-89f4-8c1e7caada59"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(292, 540),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f1f73d7f-c177-4349-89cb-62cde629edeb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d6c03ca-81ec-4eb2-aece-da4c1a41394a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f6b49213-70d2-4111-b013-9260b9954373"),
				ConditionExpression = @"IsValidDataSourceFilter",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(424, 540),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d6c03ca-81ec-4eb2-aece-da4c1a41394a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d98e88fb-d6f1-4072-a888-6a7e139f2636"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("76b8d530-8ec7-4419-bd79-0f2fbbb328e1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(535, 540),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d98e88fb-d6f1-4072-a888-6a7e139f2636"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("10b62e9c-b8fd-4505-968c-ea15b93a6f4c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow15",
				UId = new Guid("3def289b-4164-48d8-9b0b-ae4cf9cb4027"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(388, 612),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d6c03ca-81ec-4eb2-aece-da4c1a41394a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("865aab4e-e3d6-4bef-810f-f2d6ef410dee"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("fa31559a-9c02-408f-94c2-0e419ff2f5fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e2515858-06b9-45f8-a214-deada5805aae"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eb0b9d63-e5c4-4c9f-a7c6-ce5d5acb8c0c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("3b7a552b-d1ab-4c29-b6d9-a2a0a40330a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("970525f9-340f-4fab-81ea-ec8d0f395bc0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e2bb5e3-6617-402d-80d5-06230184bad3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("f94353cb-7687-4701-9a4a-963966679425"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f6013c3-1aac-41d8-80ce-f10e031806ee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("491dad71-cd8c-4a16-8429-e8e996503786"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("bb16b588-466d-4d4d-98e5-c64cfe287f57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(256, 403),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb0b9d63-e5c4-4c9f-a7c6-ce5d5acb8c0c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("a21a6844-fd75-49db-a3ca-d16c975ac564"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(966, 420),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6e2bb5e3-6617-402d-80d5-06230184bad3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("a6b4591a-70af-4ab6-9031-6113711a832a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(468, 574),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5fcb32d2-99d4-4ab3-a8aa-d218a4526c63"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("06e1dda5-4878-4f3f-8aa1-d387b030be12"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("81bdb2d4-3a6a-4a71-84a2-0b0ee87c7852"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(596, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb93f579-a8fa-4137-a260-716bb3f5a914"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff79d4ed-1941-4571-a11f-0e4ddbc92721"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("77a2a046-57fc-4233-8e8e-e78cec5c6406"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52be3440-d422-464b-934d-9105a4234bde"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75a35d2f-6959-44f0-91f2-738a425a7e48"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("bed13244-206b-4570-8a82-1c2caa6a61c1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(259, 71),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("75a35d2f-6959-44f0-91f2-738a425a7e48"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("da03867c-d05e-421b-9823-51b9114ff801"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(497, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac0f8a9c-5906-47e9-957f-cfd0f15a21a4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c7ac767-04b2-49a0-a82f-f32a5e6f3725"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("3567d056-d21b-4be7-a4a8-5b58aafc00f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4212ed84-0906-406f-a47d-532180d69c02"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef1d3ff8-8993-44e4-a6c3-ea888cf8c641"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("477a8c78-91e7-41f3-bf4b-f22c9b0cdf2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a6410d62-f9eb-4e73-9889-cebe6720e6c8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9868acf7-57e8-4dbd-9d5f-20dd64f278af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow28",
				UId = new Guid("3d17d435-752a-48f7-9eac-6473c2dc962c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3d9235b-a90c-4358-9e68-c3fe95f78314"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6827e9bb-4750-4279-97a9-b742d56a6e64"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("4845bdf4-598c-451d-acfe-8969db0a96f4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f99caa27-0e70-461a-b2bf-ab93178d0378"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c732236-e66a-451e-bb94-95cbe498d8ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow30SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow30",
				UId = new Guid("a2403102-d1c9-4244-aa8e-d0837ad24ba9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(252, 886),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ef1d3ff8-8993-44e4-a6c3-ea888cf8c641"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow31SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow31",
				UId = new Guid("8ef502cc-2af7-4e2a-9890-95e3ac647c23"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CurveCenterPosition = new Point(151, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8ee24dfa-0f1f-4cef-8404-a6bf87a96e8e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("497e6229-f61b-442e-b1ea-f8ee2fef08f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("48be40dc-0cc8-412d-8bb9-cb0daa6f1426"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1162, 2286),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane7Lane() {
			ProcessSchemaLane schemaLane7 = new ProcessSchemaLane(this) {
				UId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("48be40dc-0cc8-412d-8bb9-cb0daa6f1426"),
				CreatedInOwnerSchemaUId = new Guid("6f56a492-8454-4672-9df3-6ce613708c26"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"Lane7",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1133, 323),
				UseBackgroundMode = false
			};
			return schemaLane7;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess15EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess15 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eceb638f-9f2f-4f85-aada-2f9dc3c91115"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess15",
				Position = new Point(36, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(316, 150),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess15;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRightAddButtonClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("52be3440-d422-464b-934d-9105a4234bde"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eceb638f-9f2f-4f85-aada-2f9dc3c91115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddRightAddButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightAddButtonClickStartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddRightAddButtonClickScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("75a35d2f-6959-44f0-91f2-738a425a7e48"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eceb638f-9f2f-4f85-aada-2f9dc3c91115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightAddButtonClickScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,81,107,194,48,20,133,159,21,252,15,161,79,10,86,132,150,85,216,28,136,147,81,134,171,216,245,7,92,147,59,13,216,84,110,210,141,34,254,247,221,90,167,56,216,230,83,154,155,115,78,191,19,146,236,208,76,148,90,234,245,198,217,37,202,130,212,76,105,183,128,53,38,245,193,32,97,1,82,108,172,3,35,49,86,98,44,190,55,89,172,238,59,237,228,191,132,204,226,180,36,66,227,38,210,233,15,172,79,56,197,81,137,183,216,235,175,236,248,95,131,159,226,185,212,170,235,133,176,26,142,194,96,232,191,71,81,232,135,16,73,127,20,221,133,254,10,2,21,68,48,148,43,0,175,119,75,250,116,91,88,156,163,181,13,148,247,139,248,40,83,222,173,188,11,32,200,209,33,89,49,238,180,91,53,248,147,230,242,133,1,170,30,172,35,109,214,125,209,172,143,221,158,216,179,168,181,23,30,223,145,118,85,42,55,152,3,119,246,250,98,118,61,25,188,21,233,209,197,166,67,255,228,218,81,33,185,65,35,106,92,76,244,183,39,7,195,156,244,202,152,87,250,249,101,126,17,91,78,103,246,23,172,88,123,46,159,158,167,23,37,114,208,108,139,57,23,57,131,156,246,63,73,216,113,224,251,36,116,37,153,230,53,124,1,194,29,190,157,141,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenAddRightsRecordEditPageOnAddUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8c357a11-2ca4-4bdd-96eb-1efce7375524"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eceb638f-9f2f-4f85-aada-2f9dc3c91115"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"OpenAddRightsRecordEditPageOnAdd",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 35),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenAddRightsRecordEditPageOnAddParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess16EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess16 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4ec017bd-3329-49c1-9912-511a04829f35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess16",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 2),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(206, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess16;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRightsRecordEditPageClosedStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ac0f8a9c-5906-47e9-957f-cfd0f15a21a4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ec017bd-3329-49c1-9912-511a04829f35"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AddRightsRecordEditPageClosed",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightsRecordEditPageClosedStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(21, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddRightsRecordEditPageClosedScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5c7ac767-04b2-49a0-a82f-f32a5e6f3725"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ec017bd-3329-49c1-9912-511a04829f35"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightsRecordEditPageClosedScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,44,46,200,73,172,116,76,73,9,202,76,207,40,41,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,78,150,162,230,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess17EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess17 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("09eeceb8-4d5f-412b-b647-c0a75807ff8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess17",
				Position = new Point(35, 161),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess17;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRightEditButtonClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4212ed84-0906-406f-a47d-532180d69c02"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09eeceb8-4d5f-412b-b647-c0a75807ff8b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddRightEditButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightEditButtonClickStartMessage1",
				Position = new Point(15, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddRightEditButtonClickScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ef1d3ff8-8993-44e4-a6c3-ea888cf8c641"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09eeceb8-4d5f-412b-b647-c0a75807ff8b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightEditButtonClickScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,194,64,16,61,27,240,63,108,115,82,48,33,96,104,4,107,65,172,136,20,63,48,218,75,241,176,102,71,93,72,54,178,187,105,17,241,191,119,54,137,86,75,75,115,217,143,217,247,222,188,217,153,165,4,24,73,206,166,41,3,34,204,210,35,34,139,227,110,221,226,91,210,152,211,29,184,125,198,22,124,183,215,106,89,130,221,16,98,136,52,228,44,229,14,210,76,104,242,208,35,94,147,156,234,86,173,148,169,194,125,247,214,152,233,76,32,86,144,115,37,232,76,10,178,165,24,48,47,117,107,118,0,113,85,89,64,148,74,54,100,92,27,245,153,48,39,215,32,64,142,133,210,84,68,48,102,152,251,114,89,141,89,183,138,196,74,193,32,147,18,132,238,71,154,127,128,121,66,25,45,51,168,196,55,199,85,158,89,192,39,25,101,156,53,108,159,110,188,142,223,246,156,109,16,248,142,79,131,200,233,4,143,190,179,161,109,214,14,168,23,109,40,181,155,149,228,7,113,170,96,2,74,21,182,236,63,208,57,140,217,149,29,207,169,164,9,104,144,138,244,76,223,208,250,11,199,250,83,65,229,241,73,105,201,197,174,69,138,253,185,81,52,183,86,59,17,27,255,137,235,99,24,237,33,161,88,182,221,34,195,251,136,187,76,195,156,134,172,115,235,66,59,200,52,194,34,10,84,65,67,43,255,144,18,42,208,170,156,162,211,59,194,228,59,126,131,86,168,143,254,95,225,136,224,235,15,132,215,232,13,148,107,72,114,19,102,94,221,55,26,103,56,143,54,70,214,191,27,1,76,61,140,33,193,226,175,222,203,251,79,243,134,114,198,54,212,173,114,158,243,65,250,2,206,152,66,54,108,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenAddRightsRecordEditPageOnEditUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("00b7e44c-3b54-4100-a6c3-bae8247412c6"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09eeceb8-4d5f-412b-b647-c0a75807ff8b"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"OpenAddRightsRecordEditPageOnEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 32),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenAddRightsRecordEditPageOnEditParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess21EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess21 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("78807e49-fd43-48d0-a14e-b484aaf3d286"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess21",
				Position = new Point(610, 8),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(195, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess21;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRightsTreeGridDblClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8ee24dfa-0f1f-4cef-8404-a6bf87a96e8e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78807e49-fd43-48d0-a14e-b484aaf3d286"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddRightsTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightsTreeGridDblClickStartMessage1",
				Position = new Point(35, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateAddRightEditButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("497e6229-f61b-442e-b1ea-f8ee2fef08f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("78807e49-fd43-48d0-a14e-b484aaf3d286"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"AddRightEditButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightEditButtonClickIntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 50),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess18EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess18 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0c9f70f6-617f-4e08-8065-5b5bde303fec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess18",
				Position = new Point(372, 173),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess18;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRighDeletetButtonClickStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a6410d62-f9eb-4e73-9889-cebe6720e6c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c9f70f6-617f-4e08-8065-5b5bde303fec"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddRighDeletetButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRighDeletetButtonClickStartMessage2",
				Position = new Point(14, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddRighDeletetButtonClickScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9868acf7-57e8-4dbd-9d5f-20dd64f278af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0c9f70f6-617f-4e08-8065-5b5bde303fec"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRighDeletetButtonClickScriptTask2",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,91,75,195,48,20,199,159,45,236,59,28,246,212,130,4,223,93,11,186,78,17,69,100,23,95,198,30,206,150,211,46,18,147,145,75,165,136,223,221,172,221,186,57,81,244,41,36,249,229,252,47,169,208,0,114,62,22,229,218,89,72,97,102,201,12,181,82,180,114,66,43,54,33,107,195,154,163,195,249,213,30,219,29,222,83,189,0,180,240,32,172,27,228,162,121,128,166,30,88,103,132,42,207,65,47,95,194,148,44,187,236,69,162,128,248,72,37,5,229,165,76,224,189,23,157,25,114,222,40,112,198,83,0,63,122,81,161,13,225,106,13,113,21,172,41,205,9,132,130,39,44,137,117,6,166,134,232,214,8,30,236,201,32,65,252,49,96,182,157,215,201,176,49,189,234,138,14,186,236,70,40,30,119,251,4,210,172,139,62,239,223,241,254,130,77,245,164,49,31,39,141,201,48,149,61,163,244,100,191,221,39,73,235,246,191,125,165,135,182,79,123,97,67,237,149,219,10,95,180,81,190,132,30,113,225,174,189,115,65,100,164,112,41,137,67,122,194,228,161,13,71,63,82,179,205,31,160,92,191,169,95,48,40,80,218,221,71,229,194,110,36,214,93,204,120,91,201,241,119,126,2,144,11,231,66,92,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess20EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess20 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fe609841-4724-4afe-8bad-12521a9c90df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess20",
				Position = new Point(610, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(189, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess20;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDownRighDeletetButtonClickStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f99caa27-0e70-461a-b2bf-ab93178d0378"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe609841-4724-4afe-8bad-12521a9c90df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DownRighDeletetButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DownRighDeletetButtonClickStartMessage4",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDownRighDeletetButtonClickScriptTask4ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c732236-e66a-451e-bb94-95cbe498d8ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe609841-4724-4afe-8bad-12521a9c90df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DownRighDeletetButtonClickScriptTask4",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,209,75,195,48,16,198,159,55,216,255,112,236,41,101,18,220,115,173,48,54,28,69,80,217,166,47,165,15,193,220,106,160,38,35,73,135,67,252,223,189,180,107,214,225,139,80,82,114,223,239,187,187,124,106,15,236,69,84,200,23,82,110,84,245,225,221,206,34,174,173,146,124,139,53,190,123,148,79,70,162,227,75,211,104,15,89,6,243,4,190,39,227,81,143,5,21,116,56,50,248,79,163,226,182,76,201,126,20,22,68,79,146,117,141,62,26,223,68,221,160,99,73,207,217,80,37,38,242,252,65,105,201,88,127,79,32,187,143,98,49,205,229,180,228,59,179,245,86,233,138,37,97,231,176,31,239,218,254,209,219,49,138,222,118,48,78,121,101,244,213,164,92,75,252,122,222,51,219,13,154,193,188,197,41,181,136,223,13,240,54,165,46,160,209,165,186,193,79,115,196,115,143,244,90,203,181,67,235,99,183,27,24,80,175,36,45,141,214,148,30,73,148,163,115,244,95,9,47,138,24,214,185,248,136,167,114,184,120,235,95,41,119,168,197,41,178,93,164,63,147,49,125,22,125,99,53,120,219,96,250,11,197,141,36,106,5,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess19EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess19 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("666edfef-7c5f-48ca-b630-58dd3d6bdff2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess19",
				Position = new Point(820, 3),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess19;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUpRighDeletetButtonClickStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3d9235b-a90c-4358-9e68-c3fe95f78314"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("666edfef-7c5f-48ca-b630-58dd3d6bdff2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UpRighDeletetButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"UpRighDeletetButtonClickStartMessage3",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpRighDeletetButtonClickScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6827e9bb-4750-4279-97a9-b742d56a6e64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("666edfef-7c5f-48ca-b630-58dd3d6bdff2"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"UpRighDeletetButtonClickScriptTask3",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,65,75,3,49,16,133,207,45,244,63,12,61,101,65,67,123,94,82,144,22,203,34,168,180,213,203,178,135,96,166,107,96,77,74,146,45,22,241,191,59,217,237,198,22,47,66,72,72,222,247,102,38,79,239,129,61,203,26,249,157,82,27,93,191,7,191,115,136,107,167,21,223,98,131,111,1,213,163,85,232,249,210,182,38,128,16,48,207,224,107,50,30,13,88,84,193,196,77,192,127,10,149,179,42,39,251,81,58,144,3,73,214,53,134,100,124,149,77,139,158,101,3,231,226,43,49,137,231,247,218,40,198,134,123,6,98,145,196,114,90,168,105,197,119,118,27,156,54,53,203,226,204,113,62,222,151,253,163,119,109,52,253,237,96,189,14,218,154,171,78,133,81,248,249,180,103,174,111,116,11,243,14,167,212,18,190,16,48,235,51,25,253,250,54,248,97,143,120,182,229,215,90,97,60,186,144,10,220,192,5,245,66,210,210,26,67,129,145,68,209,121,79,231,74,6,89,166,124,206,143,15,120,170,46,103,237,252,43,237,15,141,60,37,182,79,241,123,50,166,229,48,180,206,64,112,45,230,63,177,131,189,169,248,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a816f075-ae13-4bda-8852-6fd59880f5f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 335),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(291, 148),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteRightAddButtonClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e2515858-06b9-45f8-a214-deada5805aae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a816f075-ae13-4bda-8852-6fd59880f5f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteRightAddButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightAddButtonClickStartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRightAddButtonClickScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eb0b9d63-e5c4-4c9f-a7c6-ce5d5acb8c0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a816f075-ae13-4bda-8852-6fd59880f5f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightAddButtonClickScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,221,106,194,64,16,133,175,21,124,135,37,87,10,70,84,76,35,180,22,68,165,132,98,35,166,121,128,109,118,140,11,201,70,102,55,45,34,190,123,39,137,53,105,161,197,94,237,223,119,206,156,25,214,63,128,90,66,2,6,182,50,222,27,189,133,40,67,177,18,210,108,120,12,190,154,11,49,240,137,1,244,148,54,92,69,224,9,54,99,95,135,208,19,247,157,182,127,131,73,168,97,145,35,130,50,243,200,200,119,40,94,200,200,96,14,55,58,20,187,176,172,174,224,131,61,229,82,116,173,157,59,29,129,235,56,182,35,220,177,61,225,206,212,126,219,9,110,15,39,238,16,70,99,17,185,119,96,245,110,44,176,72,50,13,107,208,186,138,102,253,206,151,164,176,254,17,124,195,145,167,68,161,102,179,78,187,85,116,176,148,52,136,76,113,60,62,104,131,82,197,125,86,173,143,221,30,59,17,212,58,49,139,230,37,205,49,136,246,144,114,79,88,125,182,106,92,208,52,6,175,89,80,138,72,115,238,95,68,7,204,34,106,163,169,162,64,127,107,82,174,40,38,190,80,202,111,252,186,190,175,97,77,238,20,253,25,142,196,54,219,15,174,15,53,12,228,181,74,32,165,86,174,89,46,231,159,97,72,113,166,161,34,152,28,85,245,55,62,1,162,6,99,159,161,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenDeleteRightsRecordEditPageOnAddUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a5702203-5ccf-4297-bba6-20ab88c37a94"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a816f075-ae13-4bda-8852-6fd59880f5f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"OpenDeleteRightsRecordEditPageOnAdd",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(190, 32),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenDeleteRightsRecordEditPageOnAddParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess12EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess12 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8a30c053-45c4-4676-bbbb-25027ba9fc3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess12",
				Position = new Point(35, 664),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(192, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess12;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteRightDeleteButtonClickStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7f6013c3-1aac-41d8-80ce-f10e031806ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a30c053-45c4-4676-bbbb-25027ba9fc3d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteRightDeleteButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightDeleteButtonClickStartMessage3",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRightDeleteButtonClickScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("491dad71-cd8c-4a16-8429-e8e996503786"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a30c053-45c4-4676-bbbb-25027ba9fc3d"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightDeleteButtonClickScriptTask3",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,49,79,195,48,16,133,103,34,229,63,156,58,37,18,178,216,105,50,208,20,132,64,8,181,133,165,234,224,214,151,212,200,216,200,62,71,138,16,255,29,39,233,224,148,78,76,182,206,207,247,190,123,215,114,11,2,21,18,174,100,115,36,7,5,188,57,180,11,163,53,30,72,26,205,214,232,92,56,43,78,124,91,69,202,83,253,9,187,29,112,7,207,210,209,188,146,195,31,110,187,185,35,43,117,115,13,102,255,17,26,149,229,109,154,200,26,178,169,87,1,218,43,149,195,119,154,92,89,36,111,53,144,245,24,180,63,105,82,27,139,252,112,132,172,13,140,218,8,4,169,225,149,55,200,98,140,141,69,124,176,82,4,78,21,140,80,188,4,165,27,91,198,102,108,133,159,166,197,9,0,187,151,90,100,113,41,135,162,140,243,216,206,30,197,108,199,54,102,61,140,147,229,3,115,112,96,239,92,121,116,127,222,243,124,132,255,71,136,197,100,17,23,242,98,11,227,53,245,4,55,121,63,222,121,22,75,33,233,206,19,5,191,165,230,123,133,2,138,11,178,241,122,46,132,154,43,119,74,190,146,238,75,241,46,6,205,250,185,226,21,253,2,198,53,131,8,57,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dd5784af-443e-4cf6-886a-c5ff812c97a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess11",
				Position = new Point(36, 499),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(388, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteRightEditButtonClickStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("970525f9-340f-4fab-81ea-ec8d0f395bc0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd5784af-443e-4cf6-886a-c5ff812c97a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteRightEditButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightEditButtonClickStartMessage2",
				Position = new Point(22, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRightEditButtonClickScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6e2bb5e3-6617-402d-80d5-06230184bad3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd5784af-443e-4cf6-886a-c5ff812c97a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightEditButtonClickScriptTask2",
				Position = new Point(120, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,223,107,194,48,16,199,159,21,250,63,100,125,82,208,162,98,87,193,57,216,84,68,134,63,176,186,151,225,67,214,156,26,214,166,146,164,27,34,254,239,187,180,234,234,24,172,47,45,185,124,191,119,159,187,220,82,2,140,36,103,211,152,1,17,230,211,35,34,9,195,174,85,230,27,82,153,211,45,56,3,8,65,195,130,111,119,90,45,207,122,199,199,96,160,33,53,42,167,31,39,66,147,187,30,105,84,201,209,42,151,206,153,10,218,223,26,107,172,119,34,16,42,72,237,18,116,34,5,217,80,12,152,27,171,156,75,50,100,92,63,39,90,199,162,31,242,224,99,38,76,192,153,237,65,128,28,11,165,169,8,96,204,176,250,229,176,26,179,110,129,12,43,5,253,68,74,16,250,41,208,252,19,12,60,102,209,50,129,34,118,35,95,165,117,5,124,145,81,194,89,197,222,120,157,38,120,174,91,119,153,215,170,183,169,219,169,191,111,24,173,55,218,94,3,154,45,22,120,247,96,87,139,100,239,135,177,130,9,40,149,65,217,249,161,46,32,136,37,51,50,195,144,42,153,93,20,121,78,37,141,80,38,21,233,153,135,67,246,1,199,254,99,65,229,225,65,105,201,197,182,70,178,255,99,37,123,221,82,233,72,108,156,19,215,7,63,216,65,68,177,111,187,70,134,183,17,103,25,251,169,13,93,167,218,197,182,151,113,128,109,100,170,204,134,40,255,152,34,42,16,85,78,145,244,198,48,249,137,231,212,10,243,35,255,11,28,80,156,31,148,127,189,200,169,185,134,40,229,48,59,235,188,210,48,193,133,180,49,178,254,155,5,176,250,48,132,8,251,191,226,159,207,191,249,141,229,132,15,97,149,207,11,157,238,210,55,175,138,222,190,115,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateDeleteRightEditButtonClickOnEditUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("16f3fa0c-5cc7-4e0c-a26e-69fae03df436"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd5784af-443e-4cf6-886a-c5ff812c97a9"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightEditButtonClickOnEdit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 31),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeDeleteRightEditButtonClickOnEditParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess13EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess13 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c0c60bb7-6915-473f-8fda-421c2fbc918f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess13",
				Position = new Point(351, 342),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(181, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess13;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteRightsTreeGridDblClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5fcb32d2-99d4-4ab3-a8aa-d218a4526c63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0c60bb7-6915-473f-8fda-421c2fbc918f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteRightsTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightsTreeGridDblClickStartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateDeleteRightEditButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("06e1dda5-4878-4f3f-8aa1-d387b030be12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c0c60bb7-6915-473f-8fda-421c2fbc918f"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DeleteRightEditButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightEditButtonClickIntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess14EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess14 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0e5de09a-7c22-4e7b-a1b1-683dbb99eb86"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess14",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 660),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess14;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteRightsRecordEditPageClosedStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fb93f579-a8fa-4137-a260-716bb3f5a914"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e5de09a-7c22-4e7b-a1b1-683dbb99eb86"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteRightsRecordEditPageClosed",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightsRecordEditPageClosedStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRightsRecordEditPageClosedScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ff79d4ed-1941-4571-a11f-0e4ddbc92721"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0e5de09a-7c22-4e7b-a1b1-683dbb99eb86"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightsRecordEditPageClosedScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,44,46,200,73,172,116,73,205,73,45,73,13,202,76,207,40,41,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,252,56,220,88,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d6c4d4ec-2307-4a25-9259-37c714466b0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 846),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(187, 146),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddRightsTreeGridSelectionChangeStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3c4cb0e7-e65d-4bf6-898c-d1c9a31f27c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6c4d4ec-2307-4a25-9259-37c714466b0c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddRightsTreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightsTreeGridSelectionChangeStartMessage2",
				Position = new Point(14, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddRightsTreeGridSelectionChangeScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9773719b-91cb-4bb0-8ad9-980567e8f2ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d6c4d4ec-2307-4a25-9259-37c714466b0c"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"AddRightsTreeGridSelectionChangeScriptTask2",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,73,9,202,76,207,40,113,77,201,44,113,42,45,41,201,207,211,115,205,75,76,202,73,77,81,176,229,229,10,64,82,226,146,154,147,90,146,138,75,81,104,1,97,53,46,249,229,121,120,84,41,148,20,149,166,90,243,114,21,165,150,148,22,229,65,120,0,109,194,246,9,164,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a3e3999f-ed78-4072-9806-02d60e1f61df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess7",
				Position = new Point(36, 1021),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteRightsTreeGridSelectionChangeStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c705debe-a8b4-411b-9a6d-d3c636aa9ab0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3e3999f-ed78-4072-9806-02d60e1f61df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteRightsTreeGridSelectionChange",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightsTreeGridSelectionChangeStartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteRightsTreeGridSelectionChangeScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("279df4de-07ac-48e9-a0a5-4beb9c7f2e5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a3e3999f-ed78-4072-9806-02d60e1f61df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"DeleteRightsTreeGridSelectionChangeScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,205,73,45,73,13,202,76,207,40,113,77,201,44,113,42,45,41,201,207,211,115,205,75,76,202,73,77,81,176,85,40,41,42,77,181,230,229,10,64,83,11,97,226,82,93,148,90,82,90,148,7,225,1,0,171,58,153,98,102,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess2",
				Position = new Point(36, 1185),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(857, 220),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEntitySchemaEditChangeStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6539cdb8-53df-421c-8bb4-8777863e51b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EntitySchemaEditChange",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EntitySchemaEditChangeStartMessage1",
				Position = new Point(15, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateObjectEditChangeScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("df0226e5-9391-427c-8478-9cc501182d24"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ObjectEditChangeScriptTask1",
				Position = new Point(281, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,177,14,130,64,12,134,103,73,120,135,203,205,196,23,64,29,68,6,6,65,5,6,70,66,26,188,193,158,185,150,40,33,188,187,135,222,96,130,145,165,127,154,126,223,159,70,215,26,91,200,155,43,220,234,24,89,113,95,18,152,35,16,213,45,172,79,118,136,173,152,34,244,189,232,47,235,178,128,39,91,101,206,186,251,98,79,210,104,180,5,242,92,198,121,145,100,169,92,52,246,29,179,70,154,164,42,206,211,108,217,184,0,221,173,1,110,159,84,132,135,56,168,134,149,198,218,244,27,98,163,176,13,196,39,119,98,240,189,213,32,123,32,25,8,57,47,175,128,92,151,28,131,55,138,250,55,153,234,111,112,180,175,26,224,206,160,96,211,65,248,2,64,16,55,128,143,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("07d8e729-844f-44cb-8639-ea00cfaf872d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateChangeSchemaEntityUserMessageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("aa8b7b25-2d77-48ac-8b36-016727145847"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ChangeSchemaEntityUserMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(455, 35),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeChangeSchemaEntityUserMessageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("06c2438e-1751-4207-8139-ea05c8cc282b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("061cefe5-3199-46b8-b976-0b0be0575e60"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8ba61907-4a11-4659-b908-bc5721ab60ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 1435),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityYesMessageStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3de779d6-7534-4e05-aaf2-dd15db8ac124"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8ba61907-4a11-4659-b908-bc5721ab60ca"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityYesMessage",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ChangeSchemaEntityYesMessageStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeSchemaEntityYesMessageScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f446def4-6f7a-4514-8ec9-fab02a6e0006"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8ba61907-4a11-4659-b908-bc5721ab60ca"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ChangeSchemaEntityYesMessageScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,193,10,66,33,16,69,247,65,255,224,210,183,241,7,30,173,202,34,104,17,89,237,69,47,47,193,20,230,141,68,127,159,184,40,131,218,13,51,119,206,185,58,113,224,167,113,55,220,237,101,239,197,74,36,60,196,174,4,47,143,118,130,210,221,93,251,192,234,106,99,129,58,103,195,20,210,36,135,97,92,46,186,228,198,178,53,185,144,131,234,161,250,91,83,127,78,152,193,235,156,152,114,108,204,89,190,81,219,16,25,212,116,6,252,65,202,159,162,255,13,14,217,250,218,179,56,46,132,134,39,212,49,137,186,195,248,2,30,82,167,30,251,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("a6e966bb-deea-4f3f-86ce-0d9ba4b3c752"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(302, 1437),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChangeSchemaEntityNoMessageStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("56c142a4-3a74-4249-9a92-f54d885de59b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6e966bb-deea-4f3f-86ce-0d9ba4b3c752"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChangeSchemaEntityNoMessage",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ChangeSchemaEntityNoMessageStartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateChangeSchemaEntityNoMessageScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7118b60b-3292-4ca3-87da-baa6637c8e27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a6e966bb-deea-4f3f-86ce-0d9ba4b3c752"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ChangeSchemaEntityNoMessageScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,206,177,10,194,48,20,133,225,93,240,29,58,166,32,121,129,78,69,51,184,21,83,221,47,205,161,70,236,77,73,238,45,245,237,29,92,138,232,254,253,156,211,209,8,235,88,162,188,252,112,199,68,46,68,177,94,203,12,14,237,131,86,183,128,165,152,186,217,239,186,223,22,114,163,167,162,229,208,99,21,179,5,215,115,56,84,155,236,68,66,62,105,30,96,63,192,30,105,150,152,216,246,201,75,142,60,154,250,255,210,5,69,39,124,157,202,16,205,92,73,86,52,111,124,124,121,166,205,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e6808c31-b242-4bcf-89c7-b8eb131ba397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 1648),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(539, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("52e99ed4-2d9e-4987-b967-62390f2c4140"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6808c31-b242-4bcf-89c7-b8eb131ba397"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"PageLoadCompleteStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("79d32c88-8d27-4e80-8fd1-00b0ea13985b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6808c31-b242-4bcf-89c7-b8eb131ba397"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"PageLoadCompleteIntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ecbdfcdd-5543-4356-8dd6-fd88d7d111cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6808c31-b242-4bcf-89c7-b8eb131ba397"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"PageLoadCompleteScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,219,110,218,64,16,125,6,137,127,216,228,201,72,200,249,128,38,72,9,144,40,109,148,162,16,250,18,229,97,195,14,196,233,98,163,221,53,169,27,241,239,157,189,96,175,23,59,109,26,9,129,180,158,57,115,118,230,204,49,83,145,45,64,202,217,226,25,214,148,72,251,115,70,46,147,148,141,65,38,171,20,216,212,15,137,250,95,122,221,41,93,65,124,153,112,5,98,194,18,21,207,64,213,131,44,142,14,237,117,183,84,144,13,21,116,13,24,46,17,123,12,75,154,115,245,131,242,28,36,161,146,140,147,133,74,178,148,138,226,84,42,145,164,171,1,169,193,77,247,217,38,101,136,168,201,146,68,62,230,25,73,115,206,251,228,173,215,237,8,80,185,72,137,18,57,96,228,174,215,61,57,193,146,18,68,66,121,242,27,200,210,240,150,189,174,173,69,32,85,137,42,108,165,107,134,252,42,224,135,227,137,247,112,126,205,142,31,99,195,193,81,56,154,25,136,248,90,222,98,249,239,98,178,222,168,34,170,3,246,45,171,0,8,203,164,240,74,174,242,132,133,241,136,221,49,13,182,41,99,170,232,44,203,197,2,98,63,59,192,11,146,236,249,126,54,134,242,121,202,238,225,151,138,130,68,108,245,59,181,226,17,221,232,209,24,82,248,113,45,115,45,12,122,85,101,91,105,72,175,91,157,246,118,57,48,215,167,142,150,203,139,204,210,81,150,110,65,224,19,215,170,3,244,175,126,80,164,83,59,115,156,50,30,165,96,244,228,174,230,233,180,194,48,23,50,181,108,249,81,198,185,205,194,114,26,57,246,36,179,167,56,32,170,216,64,182,140,66,46,85,118,127,64,12,19,205,248,38,145,234,180,198,114,72,222,130,187,237,250,102,1,90,241,12,77,221,187,3,154,71,190,230,253,171,232,155,94,137,44,223,224,77,154,103,171,151,219,53,209,4,94,20,183,56,196,131,18,177,62,181,141,242,40,84,240,1,131,22,209,142,114,33,80,225,56,250,124,129,139,185,159,135,140,239,96,157,109,33,68,117,245,118,230,251,131,136,231,140,29,92,194,226,105,184,93,235,94,221,100,148,149,104,81,181,128,117,135,171,18,162,70,152,198,188,73,74,159,56,232,133,221,251,17,1,46,193,180,172,61,118,73,49,198,154,151,61,68,193,40,145,113,25,85,150,154,163,60,239,169,252,137,225,81,205,45,231,238,65,223,154,112,124,5,234,130,74,152,112,88,99,215,46,10,92,250,72,215,115,7,115,107,57,129,73,46,50,158,175,83,178,53,30,221,235,142,129,227,146,223,37,171,103,37,103,88,9,27,251,13,10,44,173,13,44,190,133,87,99,100,253,248,62,179,43,110,120,106,150,136,8,6,145,249,16,161,113,120,143,60,207,48,251,211,240,110,200,158,94,112,182,195,33,97,94,158,115,100,217,228,48,205,36,156,225,176,58,175,114,113,223,41,108,110,231,13,50,128,8,237,227,244,111,120,195,54,134,90,81,243,13,163,10,198,137,220,112,90,216,119,102,196,194,160,115,148,174,201,175,191,42,235,145,131,82,51,3,82,189,160,119,90,80,117,227,140,221,136,181,182,31,154,71,255,136,247,12,218,223,235,226,254,125,74,34,101,126,160,143,242,252,35,226,160,251,164,127,83,70,89,195,201,130,122,92,254,71,19,126,254,167,4,81,17,107,83,3,173,69,180,74,161,12,107,213,193,59,42,104,24,173,150,128,223,100,116,9,75,203,87,140,105,139,59,47,49,156,139,249,127,212,254,0,254,162,210,85,135,10,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("81668806-1c67-472f-9b82-51844cbad8f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 1816),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(539, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2275b122-6887-4b74-b002-90f556dd0f97"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("81668806-1c67-472f-9b82-51844cbad8f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"InitStartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9a10726a-7eec-46a3-92c8-b32dd2170c6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("81668806-1c67-472f-9b82-51844cbad8f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"InitIntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 62),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cc017de6-bd15-41d0-9ae7-a94021ffadba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("81668806-1c67-472f-9b82-51844cbad8f0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"InitScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(211, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,83,193,142,218,48,16,61,131,196,63,184,156,130,26,229,7,182,172,196,18,90,33,181,21,2,150,30,170,30,220,120,0,47,198,206,122,38,64,132,248,247,142,19,96,161,208,222,170,158,226,140,103,222,188,247,242,178,145,94,108,157,95,97,46,51,120,30,170,143,218,16,120,209,21,22,182,34,213,25,105,103,165,47,63,32,121,109,23,177,112,63,95,32,163,71,177,111,53,27,141,125,59,115,235,92,122,141,206,78,203,28,218,177,168,231,251,87,229,100,240,90,72,115,136,235,17,3,115,26,236,114,15,136,140,221,119,166,88,219,145,164,37,15,183,39,37,126,59,145,105,159,6,10,132,84,99,110,100,57,147,166,8,75,230,210,32,156,174,189,94,44,47,0,71,210,203,53,48,135,170,25,185,59,40,169,105,127,255,33,246,207,24,232,89,11,149,180,228,188,46,25,170,195,225,240,208,106,110,216,17,169,214,218,106,214,44,9,212,83,57,134,204,121,133,255,215,155,222,93,78,255,200,37,242,5,212,118,140,228,130,73,90,210,84,78,178,37,172,229,64,105,74,70,30,88,4,124,118,110,85,228,71,95,222,119,133,2,3,11,230,39,162,26,74,32,88,5,62,22,117,99,24,29,108,192,82,207,47,80,64,167,114,42,248,61,175,16,144,173,133,164,70,67,94,221,56,150,147,158,82,209,109,72,59,191,183,252,237,171,133,230,32,167,239,129,111,83,230,73,48,14,158,224,76,97,212,57,223,48,206,117,89,207,69,244,110,176,163,100,136,189,23,185,27,195,43,251,69,53,245,202,155,16,168,169,196,213,84,147,129,202,156,41,236,136,165,12,12,172,89,235,87,216,246,101,30,178,18,248,166,128,122,97,191,56,5,125,35,17,249,53,243,58,39,231,217,187,243,177,43,46,234,18,197,31,135,2,34,235,51,35,239,114,240,84,166,146,228,196,21,62,131,168,126,196,23,176,149,95,193,237,252,166,155,55,222,66,132,205,51,237,137,243,249,86,12,24,183,243,201,4,168,111,116,248,178,252,87,108,96,236,182,209,121,157,130,121,157,50,222,18,221,249,109,120,115,198,169,172,211,117,29,204,199,78,10,115,89,24,170,1,2,226,147,182,42,184,236,60,70,159,128,142,199,80,101,176,168,19,223,81,23,191,81,168,98,208,106,122,160,194,91,17,82,254,240,11,212,2,116,173,2,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9e75f8a-e293-4b6d-b557-6abbd5953370"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(49, 1996),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(552, 276),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("10cf12ab-bc97-487d-a2f8-e64c98bf7434"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"OkButtonClickStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckDataScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f1f73d7f-c177-4349-89cb-62cde629edeb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"CheckDataScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,79,11,130,64,16,197,207,9,126,135,201,147,94,164,187,120,232,143,133,16,22,4,221,151,156,141,133,117,87,102,103,35,9,191,123,154,133,183,110,51,111,222,251,189,121,8,2,169,52,35,57,200,225,44,238,152,238,63,107,81,43,78,119,130,197,197,122,186,141,170,169,167,139,59,144,245,237,166,171,68,131,113,52,187,163,36,11,3,37,33,254,242,210,173,245,134,33,207,97,149,188,194,96,81,186,171,208,170,158,153,83,116,168,149,66,59,28,194,61,224,48,192,127,243,242,135,47,221,218,116,71,148,92,60,91,66,231,148,53,149,215,250,68,69,211,114,23,143,223,244,97,64,200,158,12,48,121,204,222,199,212,249,239,237,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("6d6c03ca-81ec-4eb2-aece-da4c1a41394a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(232, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d98e88fb-d6f1-4072-a888-6a7e139f2636"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ScriptChildOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,77,111,219,70,16,61,91,128,254,195,64,39,42,16,232,158,227,74,69,44,43,134,219,216,73,35,201,151,162,135,181,56,146,54,33,119,137,221,165,92,181,200,127,239,236,7,41,82,94,217,109,10,3,61,9,92,190,125,243,245,102,134,154,229,88,160,48,119,248,56,101,165,225,82,192,24,62,177,13,166,75,141,106,193,244,215,5,55,57,206,50,110,210,5,254,97,46,250,189,126,111,199,20,8,41,240,126,110,193,74,174,80,235,249,106,139,5,251,196,20,43,208,160,186,103,121,133,115,89,169,21,166,119,4,189,240,183,86,82,104,243,15,175,77,29,214,30,52,70,203,26,167,221,185,115,181,123,194,52,92,241,149,141,131,169,253,143,218,40,46,54,163,231,140,77,136,156,175,33,121,66,61,6,81,229,249,16,254,234,247,206,142,173,140,35,120,16,248,248,111,109,39,195,33,153,255,214,239,157,159,195,28,21,178,156,255,137,144,49,195,180,203,1,172,121,78,96,224,148,9,100,25,200,53,204,230,191,2,229,19,30,112,197,42,141,240,136,100,24,51,48,18,20,62,84,60,207,28,27,55,240,184,69,65,103,178,164,159,146,42,10,107,169,192,108,185,6,244,53,79,29,242,227,131,97,92,56,222,96,109,173,100,1,186,118,39,139,248,115,204,68,30,129,170,132,225,5,250,66,121,220,84,230,57,174,218,162,122,239,206,157,154,174,136,53,84,250,61,23,153,127,163,175,149,172,202,203,253,29,101,41,25,28,208,131,97,16,208,23,45,5,9,99,135,202,250,17,146,222,48,5,146,159,219,160,196,10,153,158,132,247,100,244,140,35,214,200,81,93,127,27,60,97,31,252,30,236,62,83,217,196,235,230,86,102,124,205,49,187,17,30,180,188,201,232,174,181,218,60,143,8,230,233,233,77,104,15,123,86,171,202,198,146,146,54,184,43,70,114,156,216,81,55,35,67,82,211,69,144,147,129,25,85,196,236,189,41,216,89,194,126,207,203,18,228,195,23,34,240,175,188,83,45,172,115,115,12,215,21,207,210,89,81,154,61,252,4,115,119,47,60,190,61,134,167,11,233,1,73,52,135,71,232,87,204,96,112,243,70,223,81,243,126,84,206,221,164,27,236,144,162,9,211,235,109,44,227,93,180,79,104,147,210,43,82,188,193,207,124,179,53,154,46,231,85,33,124,102,53,65,222,248,17,103,15,29,153,14,97,250,240,167,238,197,45,43,75,242,240,80,65,151,49,106,40,100,171,45,36,142,97,71,13,15,215,104,218,198,60,33,13,12,151,150,182,145,244,93,150,37,39,204,220,24,44,66,38,207,58,9,236,22,196,134,127,22,46,162,161,74,152,173,85,227,46,253,5,247,238,93,157,27,58,186,247,58,58,251,230,70,215,155,243,126,111,190,215,239,178,130,139,165,104,85,133,192,221,198,75,219,54,111,153,160,46,84,41,5,105,93,172,27,190,205,52,24,166,68,67,54,136,194,176,213,127,100,14,36,13,233,7,41,191,86,229,98,95,98,148,209,54,189,11,212,34,78,80,122,138,134,177,163,101,208,254,103,12,118,182,93,161,230,27,129,89,7,146,212,35,173,10,139,214,110,149,14,162,222,192,67,79,102,237,95,50,141,51,63,115,47,247,100,55,177,157,16,14,232,241,152,178,105,41,235,113,173,198,15,92,155,176,157,38,73,141,76,15,43,142,22,47,141,242,142,42,227,125,122,88,199,86,175,17,38,47,188,184,51,78,181,13,65,106,207,194,46,92,158,114,62,78,100,139,105,35,138,172,94,223,201,147,9,100,237,174,29,159,106,173,232,244,111,225,94,113,108,181,29,244,249,183,3,248,135,23,38,213,209,110,104,147,196,247,130,75,84,220,251,9,20,193,231,67,253,92,170,4,42,102,176,46,202,180,210,70,22,7,72,226,181,57,58,148,223,134,214,137,103,120,88,72,84,243,83,163,51,62,1,155,11,255,227,241,247,162,250,88,19,245,56,26,83,76,119,13,232,21,69,215,248,245,221,138,107,24,226,114,123,170,40,91,172,207,76,108,48,249,78,97,53,22,221,151,243,178,164,111,83,140,14,205,23,249,70,17,193,91,78,133,166,82,2,140,162,255,29,127,3,116,123,158,92,29,13,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateErrorMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("865aab4e-e3d6-4bef-810f-f2d6ef410dee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"ErrorMessageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 176),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,243,77,204,204,243,77,45,46,6,178,3,18,243,82,115,244,28,83,82,160,124,141,176,196,156,204,148,196,146,204,124,152,138,144,204,146,156,84,29,5,12,113,29,5,152,130,202,130,84,189,240,196,162,188,204,188,116,77,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,128,150,131,124,111,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseOkButtonClickIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("10b62e9c-b8fd-4505-968c-ea15b93a6f4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1adc5654-f282-4212-9bf8-c5be44658df3"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Name = @"BaseOkButtonClickIntermediateThrowMessageEvent2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(484, 71),
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
			Methods.Add(CreateIsEntitySchemaChangedMethod());
			Methods.Add(CreateCreateDeleteRightsVdsMethod());
			Methods.Add(CreateCreateAddRightsVdsMethod());
			Methods.Add(CreateEnableControlsMethod());
			Methods.Add(CreateResetControlValuesMethod());
			Methods.Add(CreateGetDeleteRightsValuesMethod());
			Methods.Add(CreateGetAddRightsValuesMethod());
			Methods.Add(CreateDisplayDeleteRightsMethod());
			Methods.Add(CreateDisplayAddRightsMethod());
			Methods.Add(CreateUpdateDisplayValuesMethod());
			Methods.Add(CreateGenerateUserTaskCustomParametersMethod());
			Methods.Add(CreateCreateCustomParameterMethod());
			Methods.Add(CreateGenerateParameterNameMethod());
			Methods.Add(CreateActualizeParameterValuesMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80548273-33cb-44ee-9ce9-71eb58f1bcb2"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f2663354-b875-4ec0-a426-a93c1f50d9dd"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,204,177,10,194,48,20,133,225,89,159,226,210,41,129,18,116,85,68,164,84,232,82,69,82,58,71,123,45,193,52,41,185,87,170,148,190,187,84,156,157,206,242,159,79,156,77,139,234,64,253,188,96,8,52,198,104,40,220,89,85,133,170,241,154,5,207,49,56,82,115,32,85,102,122,182,193,195,14,136,163,245,173,42,168,124,58,119,138,121,215,243,91,124,181,138,48,106,67,15,109,217,97,222,88,86,26,95,44,97,191,92,252,78,199,16,59,195,34,25,87,19,136,113,61,201,36,133,218,250,38,12,63,63,133,18,135,11,222,66,108,36,108,224,15,187,253,0,212,67,124,110,194,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateUpdateProcessSchemaCustomParameterMethod() {
			SchemaMethod method = base.CreateUpdateProcessSchemaCustomParameterMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,215,79,46,45,42,74,205,43,9,72,44,74,204,77,45,73,45,210,243,3,210,10,182,10,185,249,41,153,105,153,169,41,168,18,214,188,92,250,152,90,156,19,11,74,50,243,243,176,234,130,202,1,53,98,104,115,73,44,73,12,75,204,41,77,13,169,44,72,13,245,76,193,170,31,93,17,54,131,130,82,211,82,129,34,201,169,193,201,25,169,185,137,184,140,194,84,134,205,176,224,252,210,162,228,84,176,149,122,96,18,171,89,24,170,8,25,229,146,89,92,144,147,88,73,156,137,200,138,9,26,76,76,40,226,211,64,200,2,34,67,23,191,22,107,0,126,129,41,129,106,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntitySchemaChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("78a8a190-81c9-4cb4-a3ea-c51eed1050f5"),
				Name = "IsEntitySchemaChanged",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,116,205,43,201,44,169,12,78,206,72,205,77,12,245,76,209,115,45,44,77,204,41,214,112,47,205,4,178,115,11,74,42,53,21,212,212,112,42,3,171,211,12,72,76,79,213,67,86,225,154,146,89,162,23,150,152,83,154,170,105,13,0,78,20,20,102,105,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateDeleteRightsVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3c951161-0910-49f3-8015-39946a1032c2"),
				Name = "CreateDeleteRightsVds",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,75,110,219,48,16,93,215,128,239,64,104,101,3,129,114,128,32,139,196,114,93,45,82,24,150,227,253,68,28,59,4,40,210,32,41,55,106,81,160,7,105,47,215,147,116,40,42,150,34,101,17,192,46,144,108,244,121,111,248,102,30,103,68,29,192,176,3,183,236,154,41,252,198,54,194,184,18,100,2,14,50,93,154,28,39,83,246,99,60,250,148,38,20,16,37,40,209,225,74,236,30,157,221,112,27,141,71,63,175,198,163,37,236,48,246,151,153,86,14,132,66,19,251,39,163,165,141,111,56,159,144,250,148,194,198,163,203,75,150,161,171,179,165,156,109,181,97,57,72,84,156,42,112,6,145,237,140,224,141,92,55,211,154,184,5,81,113,91,21,45,191,246,58,113,154,212,202,45,147,57,83,230,174,52,232,233,246,37,68,39,184,61,66,245,186,110,76,188,52,162,0,83,205,180,44,11,245,21,10,191,42,74,121,116,245,122,92,34,236,94,66,47,220,223,163,32,77,174,118,165,224,201,193,17,113,111,209,208,166,40,204,157,208,170,118,178,1,89,226,186,218,227,29,40,178,108,226,5,186,84,89,7,42,199,219,202,11,77,162,5,9,68,126,243,188,90,1,79,153,248,142,107,124,114,39,137,222,181,58,71,237,7,173,37,130,58,73,247,54,104,28,53,133,58,173,206,84,57,36,42,154,14,91,69,99,21,246,125,226,135,246,149,238,55,108,24,222,78,47,47,252,44,219,141,176,226,65,122,108,11,210,98,0,191,8,142,48,64,51,109,92,31,125,97,128,136,166,205,244,53,156,173,212,122,142,124,174,25,236,253,166,17,150,85,246,134,23,66,221,43,225,60,29,214,53,124,223,23,137,15,109,181,96,199,213,51,216,55,245,114,218,206,233,109,6,106,133,192,123,246,26,244,63,187,234,204,249,153,45,205,185,112,67,75,30,253,176,150,194,33,60,52,21,240,143,105,107,97,128,142,21,50,197,232,111,244,247,215,159,21,101,161,219,5,61,255,158,23,123,169,43,60,190,183,154,159,133,116,104,8,127,211,241,241,78,190,179,58,203,27,79,188,119,82,114,136,9,205,153,171,178,96,75,163,115,180,54,203,31,177,128,37,24,138,163,70,212,197,132,88,118,126,123,225,191,85,219,250,7,170,157,235,146,29,9,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAddRightsVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3b0e40bd-3b08-4bca-82c5-cf3ff18791c6"),
				Name = "CreateAddRightsVds",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,75,110,219,48,16,93,215,128,239,64,104,101,3,129,114,128,32,139,196,114,29,1,73,107,88,142,247,19,113,236,16,160,72,131,164,220,184,69,129,30,164,189,92,79,210,161,40,72,142,236,133,1,59,69,178,209,231,205,227,27,62,206,144,210,6,12,219,112,203,174,153,194,111,108,33,140,43,65,38,224,32,211,165,201,113,48,100,63,250,189,79,105,66,132,232,134,243,153,88,61,59,187,224,54,234,247,126,94,245,123,83,88,97,236,47,35,173,28,8,133,38,246,79,70,75,27,19,125,64,210,67,162,245,123,151,151,44,67,87,165,74,57,91,106,195,114,144,168,56,165,119,6,145,173,140,224,181,92,147,102,78,129,9,225,113,59,31,26,123,237,69,226,52,169,100,219,72,230,76,153,187,210,160,15,183,47,129,157,224,178,129,170,113,187,156,120,106,68,1,102,59,210,178,44,212,23,40,252,168,40,229,209,213,97,94,34,236,90,66,135,238,239,81,144,38,75,171,82,240,100,227,40,240,104,209,208,138,40,204,157,208,170,114,178,0,89,226,124,187,198,7,80,228,215,196,19,116,169,178,14,84,142,183,91,47,52,136,38,36,16,249,149,243,106,5,188,100,226,59,206,241,197,157,36,250,208,234,52,218,79,90,75,4,117,146,238,109,208,104,52,133,58,109,158,169,114,72,161,104,184,95,42,234,141,176,238,3,223,174,7,170,95,71,67,219,238,212,242,194,119,177,93,8,43,158,164,199,150,32,45,6,240,78,112,132,61,52,211,198,117,209,87,6,40,80,151,153,182,194,217,166,90,245,145,207,53,130,181,95,52,194,178,173,189,225,133,80,143,74,56,31,14,227,234,120,215,23,137,239,219,106,193,99,92,189,110,183,115,154,27,129,154,33,240,142,191,26,125,107,91,59,157,126,102,79,99,46,220,190,39,143,126,92,79,9,74,116,221,78,108,240,15,234,107,98,128,142,22,114,197,232,115,244,247,215,159,25,101,161,219,5,61,255,30,23,107,169,183,216,188,183,154,159,133,116,104,8,63,234,8,121,47,123,173,202,114,228,177,247,94,230,28,56,161,60,99,85,22,108,106,116,142,214,102,249,51,22,48,5,67,60,42,69,53,153,192,101,111,224,47,124,190,206,233,235,235,26,13,248,173,82,253,215,220,227,6,101,103,103,205,48,215,134,31,224,253,223,195,62,236,182,127,99,51,54,32,20,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnableControlsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("61361981-775e-479f-97a6-fe584e9ac0cd"),
				Name = "EnableControls",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,209,189,10,194,48,16,7,240,185,125,138,140,237,210,193,85,28,252,136,69,112,16,165,15,16,205,181,13,164,73,141,23,36,136,239,110,74,13,20,10,181,147,83,14,238,199,253,143,139,40,73,66,21,10,116,151,91,13,13,43,14,60,163,119,203,228,35,201,173,240,117,211,162,75,83,242,138,163,232,196,42,200,182,90,161,209,242,200,156,182,184,200,168,98,87,9,156,172,66,127,47,36,130,161,92,224,160,23,154,59,144,128,112,22,85,141,107,206,55,22,81,171,241,136,129,234,230,204,96,125,57,130,65,250,172,95,153,129,76,5,126,77,31,54,86,129,21,237,148,10,203,235,167,154,96,164,244,63,0,203,248,77,192,191,255,185,254,140,107,17,52,182,219,234,3,156,230,195,60,54,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateResetControlValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ec722b3d-225f-449e-9487-98638c45d562"),
				Name = "ResetControlValues",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,77,78,195,48,16,133,247,156,194,234,42,145,80,46,208,82,9,154,164,11,16,170,90,209,13,98,49,173,135,116,42,99,163,153,9,40,183,199,49,85,219,192,2,186,241,223,188,249,222,179,253,1,108,94,201,41,114,101,73,231,28,218,119,115,99,22,208,96,81,121,37,237,74,80,88,133,150,183,88,212,228,109,157,180,146,132,119,221,35,188,97,150,196,245,145,113,182,76,170,94,147,143,175,126,152,20,51,135,192,89,44,124,247,247,195,44,120,5,242,200,201,169,223,113,112,217,168,68,135,138,75,106,118,42,107,43,163,220,128,152,53,177,182,224,78,233,242,11,136,183,214,94,128,155,163,14,34,128,107,81,178,161,224,68,252,85,125,18,228,232,236,113,171,20,124,177,66,145,56,247,78,207,231,216,195,249,61,118,47,241,3,140,199,79,243,64,162,147,146,82,31,112,55,17,101,242,205,181,9,155,125,132,77,167,127,208,143,153,134,232,255,146,43,15,27,135,135,55,139,55,26,127,1,195,128,68,31,43,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDeleteRightsValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ed8a5f41-95f0-4f7f-b021-63c3c3b0e4a3"),
				Name = "GetDeleteRightsValues",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,78,189,10,194,48,16,158,205,83,220,168,32,190,64,154,46,102,211,169,98,23,113,136,114,214,147,112,129,220,101,40,197,119,183,132,130,67,199,239,255,75,143,15,62,21,4,69,40,177,15,26,250,16,11,130,131,171,96,62,38,230,89,158,149,195,229,239,184,121,140,168,216,209,240,86,89,248,19,142,119,107,232,5,219,85,21,56,7,92,98,220,193,100,54,25,181,100,174,216,154,175,89,224,42,19,4,206,36,218,120,170,235,33,143,141,104,38,30,246,144,234,227,182,181,63,135,153,216,113,187,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAddRightsValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6ede837a-dc9d-49d6-9a6e-9029f2614869"),
				Name = "GetAddRightsValues",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "List<Dictionary<string, object>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,78,189,10,194,48,16,158,205,83,220,88,65,124,129,52,5,177,155,78,74,93,196,33,218,179,158,132,11,228,46,67,17,223,221,18,10,14,29,191,255,47,222,223,248,80,16,20,161,200,173,87,127,241,33,35,56,232,4,211,62,50,79,242,164,108,207,127,199,117,215,247,39,26,94,42,51,121,192,241,102,13,61,161,90,244,128,115,192,57,132,53,124,204,42,161,230,196,5,91,243,53,51,92,100,188,192,145,68,235,150,202,180,79,99,45,154,136,135,13,196,114,183,105,236,15,92,23,123,17,184,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayDeleteRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ee6537ff-959c-4c4b-8510-0eca41bd0723"),
				Name = "DisplayDeleteRights",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,81,107,194,48,20,133,159,39,248,31,66,159,90,144,178,247,169,48,170,19,153,140,161,204,151,177,135,187,230,170,25,105,50,146,91,75,153,254,247,165,77,199,172,85,95,10,57,57,223,185,185,201,237,30,12,219,115,203,70,236,21,182,24,87,159,68,43,2,161,208,196,79,66,241,106,101,180,12,131,9,74,36,92,138,237,142,236,154,219,32,98,96,217,90,24,202,65,78,128,96,165,115,147,226,67,191,231,226,226,68,34,152,48,114,171,133,176,52,156,136,148,132,86,96,202,161,37,35,212,118,192,244,231,23,166,52,30,51,126,146,235,142,49,67,106,85,2,153,163,173,147,196,134,133,109,243,136,169,92,202,136,253,244,123,119,6,41,55,202,217,142,93,103,156,232,92,81,229,191,103,135,3,155,42,18,84,174,210,29,102,240,54,231,149,62,203,5,143,167,217,55,149,62,173,234,97,161,129,47,117,225,139,183,242,55,218,32,164,59,22,238,221,237,165,90,230,153,242,231,100,66,181,250,241,97,190,30,51,186,112,253,213,183,227,112,103,209,69,19,173,139,120,133,148,252,7,133,193,156,7,131,86,244,123,37,125,92,245,39,160,150,8,93,232,79,191,73,78,185,160,75,100,173,223,36,253,83,93,98,155,157,235,244,204,128,34,236,178,127,250,117,210,79,90,7,108,228,235,220,11,100,93,170,22,61,83,141,205,233,102,220,252,9,246,25,203,48,168,181,32,242,79,122,49,223,59,206,11,120,213,87,56,54,163,245,200,121,232,18,34,63,78,103,195,246,11,189,9,81,62,147,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayAddRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("692c47a2-5712-4a83-a924-44b63d58fc48"),
				Name = "DisplayAddRights",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,77,139,219,48,16,61,123,97,255,131,240,201,129,96,74,123,235,126,64,112,210,16,26,218,146,180,123,41,61,204,90,179,137,90,69,10,242,216,198,116,243,223,43,91,54,155,196,31,155,165,23,131,159,223,123,51,210,60,79,6,134,101,60,97,119,236,27,108,48,44,31,145,86,4,66,161,9,63,9,197,203,55,163,101,224,79,56,95,137,205,150,146,7,158,248,35,6,9,123,16,134,82,144,83,32,88,235,212,196,120,115,125,101,189,194,72,34,152,96,100,223,150,34,161,219,169,136,73,104,5,166,184,77,200,8,181,25,51,253,248,27,99,186,191,103,208,152,218,6,230,72,47,53,64,166,152,84,30,226,137,5,71,180,59,166,82,41,71,236,239,245,149,103,144,82,163,44,231,112,78,11,35,157,42,42,217,239,216,243,51,155,41,18,84,172,227,45,238,224,199,130,151,248,60,21,60,156,237,246,84,56,175,178,241,165,6,190,210,185,171,123,226,254,164,13,66,188,101,65,102,239,43,214,50,221,41,215,34,19,234,232,16,206,202,85,99,70,231,246,84,213,133,88,49,161,117,174,141,117,30,174,145,162,23,155,192,95,112,127,124,98,252,179,132,126,245,242,35,80,43,132,182,168,193,7,149,51,46,168,75,89,225,131,202,41,74,36,236,210,214,95,250,213,115,3,138,176,173,109,240,126,165,11,87,75,88,195,253,186,47,176,107,171,42,208,105,92,26,153,222,163,129,50,161,213,16,151,152,161,140,96,95,2,118,124,19,41,117,254,181,205,168,244,185,160,120,27,4,199,233,90,97,172,13,239,16,140,236,143,148,161,161,240,187,94,40,250,240,62,56,109,171,67,97,187,116,121,242,98,72,144,93,84,37,156,162,42,62,150,26,111,240,88,150,6,69,207,177,60,239,209,230,245,207,205,27,43,87,55,117,65,233,161,27,253,159,210,19,197,171,40,93,218,66,195,127,189,149,67,79,190,186,102,54,30,136,83,21,186,114,79,29,143,62,172,215,109,242,25,139,192,175,48,191,153,123,87,81,199,56,79,181,67,93,172,15,245,54,179,203,52,176,14,35,183,193,206,246,219,63,87,178,116,158,248,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateDisplayValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0bc21fb8-22bf-4bc4-9237-5062a159d918"),
				Name = "UpdateDisplayValues",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e3521ccd-db5e-4bdb-bcc8-9edf6a5b24c8"),
				Name = "rights",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Dictionary<string, object>>",
				CreatedInPackageId = new Guid("e1248995-a648-4538-bd20-4700170015a3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,93,107,219,48,20,125,78,126,133,234,135,34,83,227,142,237,49,237,32,77,154,16,70,75,168,219,189,148,60,8,251,218,17,216,146,145,228,20,51,2,253,33,219,159,235,47,217,149,236,100,118,211,210,108,176,39,125,29,157,123,116,238,149,180,97,138,36,92,151,57,171,239,120,182,54,154,92,18,1,79,100,202,99,195,165,96,170,190,224,194,4,68,27,197,69,246,149,250,163,97,42,21,161,56,73,56,98,63,141,176,185,32,202,237,13,39,178,18,6,103,206,206,124,242,99,56,216,32,185,91,65,96,131,120,228,171,209,112,96,55,107,89,169,24,112,97,34,197,6,148,9,239,229,66,152,47,159,169,3,62,122,145,91,247,86,190,197,167,132,158,92,139,170,8,23,122,10,41,23,144,80,83,151,32,83,186,84,50,6,173,163,120,13,5,91,50,197,10,48,160,190,179,188,130,134,193,15,218,80,190,147,52,136,165,48,92,84,128,180,219,70,97,185,219,21,237,36,29,193,218,112,182,218,14,24,46,201,135,12,97,20,43,94,154,183,68,253,51,37,90,169,141,155,104,104,207,207,189,113,158,223,201,28,244,88,36,15,26,148,246,72,240,242,252,203,78,97,19,144,151,231,159,215,69,153,203,26,246,227,41,51,172,225,155,241,28,3,224,60,82,89,77,109,102,230,138,9,3,152,26,76,89,228,202,130,250,86,159,183,99,242,154,232,206,92,123,50,22,155,182,170,238,65,41,166,101,106,172,212,148,103,149,98,182,202,236,200,162,168,149,136,125,1,174,248,108,234,155,200,45,75,56,3,19,175,151,138,23,88,151,11,145,202,153,146,197,244,138,122,139,196,11,92,128,121,197,147,157,78,103,68,79,165,223,214,192,96,208,43,249,112,156,36,148,7,59,173,97,27,96,218,96,38,50,175,10,209,184,234,4,97,134,6,91,2,185,6,114,140,43,214,235,174,35,186,214,227,164,224,226,65,240,143,108,137,58,208,119,189,233,242,253,103,131,122,161,142,113,105,216,53,234,117,73,159,28,117,75,106,109,160,136,192,224,253,200,44,239,233,233,193,133,253,11,162,206,229,232,109,33,101,111,116,73,102,92,36,83,208,60,195,183,166,135,164,238,120,54,145,25,8,192,68,225,107,216,100,177,7,155,239,22,111,225,233,85,234,130,126,176,176,183,239,134,9,150,129,10,111,241,4,186,100,113,227,230,155,217,216,199,15,231,96,144,164,196,87,180,94,50,179,190,170,111,192,48,219,163,7,186,246,222,208,158,8,63,176,222,246,24,247,28,61,96,64,222,47,158,128,24,133,238,250,238,21,219,218,127,2,88,188,38,116,243,231,143,177,199,34,92,244,191,28,151,143,246,127,232,224,194,111,80,175,30,61,219,245,86,232,113,119,201,69,31,13,183,191,1,110,180,132,177,191,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGenerateUserTaskCustomParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3abe5357-5da6-4715-a932-890f9b62a7f8"),
				Name = "GenerateUserTaskCustomParameters",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f"),
				ResultValueTypeName = "List<ProcessSchemaParameter>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("06125dd2-310c-4f1d-b262-a6f3fd832b91"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8908bf1f-05b3-4ff7-911c-aef8b7e2bb2d"),
				Name = "userTaskUId",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("19e773ad-6218-46cb-a03b-b67cac6fbdaf"),
				Name = "items",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Dictionary<string, object>>",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,78,195,48,12,134,207,173,180,119,48,59,165,168,170,38,174,91,39,161,114,65,226,48,169,131,11,226,16,82,151,25,218,4,37,14,8,49,222,157,52,153,38,208,144,184,218,206,247,219,95,168,7,65,140,163,131,186,6,237,135,1,246,123,136,133,170,49,94,243,84,94,20,240,57,203,51,139,236,173,6,141,239,112,67,142,87,27,107,20,58,215,170,29,142,114,35,173,28,145,209,174,197,162,88,206,242,175,89,254,38,45,140,166,163,158,176,59,182,67,206,255,132,159,249,231,112,49,241,28,91,210,79,224,148,165,87,110,141,183,10,3,73,8,210,92,252,141,185,147,131,199,52,89,181,241,89,81,109,77,27,57,98,66,246,198,162,84,59,113,69,138,201,104,105,63,86,41,165,4,243,248,140,138,215,81,4,144,78,66,146,5,10,194,68,154,43,166,242,253,60,101,204,31,224,172,254,181,95,154,207,148,209,76,218,99,72,204,130,149,236,84,73,117,217,117,162,9,203,48,54,222,177,25,143,45,225,226,77,37,120,135,118,43,221,203,237,117,87,198,109,138,131,228,195,167,156,66,151,223,66,246,198,160,218,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateCustomParameterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b3a271ee-4c83-4401-bcf7-0110a24b0e67"),
				Name = "CreateCustomParameter",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f"),
				ResultValueTypeName = "ProcessSchemaParameter"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("30c9d1bb-0b59-45ae-b205-e036a3b62681"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("12bacc80-231f-45e3-9ad7-dff953356db3"),
				Name = "userTaskUId",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa32a8b9-3f13-4fe3-ac02-cac351a580da"),
				Name = "item",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, object>",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,193,106,194,64,16,134,207,10,190,195,146,83,2,69,31,64,60,20,45,33,208,138,24,237,165,120,24,146,137,93,76,118,195,236,166,37,20,223,189,179,89,149,4,245,20,102,246,251,255,153,249,19,55,50,23,132,5,18,170,12,211,236,27,43,216,39,249,124,50,254,1,18,71,2,101,17,197,66,132,198,146,84,199,72,90,172,190,130,216,247,131,3,115,178,16,225,141,91,136,96,171,75,12,34,241,55,25,143,238,125,217,41,109,205,107,94,73,181,87,210,246,231,157,5,150,6,59,221,108,54,112,124,171,234,82,183,60,46,122,230,185,212,202,66,54,180,243,23,40,168,220,250,49,42,36,176,184,1,226,134,69,90,243,231,58,36,98,156,208,54,164,132,194,95,177,33,157,161,49,222,236,38,8,77,87,251,195,252,84,7,199,156,95,56,12,39,201,131,67,244,194,212,218,207,118,43,184,114,9,181,149,90,245,59,110,109,201,155,121,191,198,32,237,192,156,184,114,175,43,176,240,9,101,131,187,182,70,79,188,107,125,106,234,75,237,152,237,163,52,238,35,114,104,170,27,202,176,51,100,198,93,49,250,208,185,44,36,230,137,234,203,253,161,211,139,108,116,85,12,143,236,186,193,161,35,86,210,212,37,180,143,65,23,194,133,243,27,48,241,56,225,78,239,153,105,154,145,172,45,139,248,55,158,231,255,151,122,16,243,165,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGenerateParameterNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0ad31a6f-5b69-4538-be41-cebfdedd15ea"),
				Name = "GenerateParameterName",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("12bbff7a-1886-44a2-b49b-e8486fecbaed"),
				Name = "prefix",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("fd6f8350-6389-44b2-a647-0ba86600bb6f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,205,202,194,48,16,60,183,208,119,88,61,72,66,65,236,197,131,245,7,241,42,34,168,15,16,108,252,190,96,93,37,73,85,16,223,221,105,122,241,96,32,144,204,238,204,206,108,238,202,82,227,180,221,43,119,222,42,171,46,218,107,187,193,229,104,70,135,72,99,70,220,212,117,150,38,11,98,253,160,181,113,126,234,188,53,252,55,23,197,88,210,132,196,119,77,254,158,83,102,169,97,79,166,122,194,170,0,186,35,139,225,35,80,191,232,3,119,114,98,144,81,187,89,125,50,79,202,91,74,43,61,145,136,4,239,117,249,104,48,136,172,54,92,93,27,56,131,55,146,244,194,30,143,127,83,235,216,60,176,217,43,195,78,180,73,100,167,72,16,59,207,203,240,10,145,129,135,251,235,46,68,22,50,52,126,7,79,222,89,138,19,241,90,86,85,103,3,102,236,251,35,91,65,97,181,111,44,135,31,43,63,185,59,250,49,218,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizeParameterValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("22407779-1e6c-4981-8aa8-7dcb0e96a0af"),
				Name = "ActualizeParameterValues",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("62f4d1fb-3b49-4d4c-9358-0c0c50e4ba93"),
				Name = "items",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Dictionary<string, object>>",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("71f99ccb-c153-430b-81e2-4cb17063557d"),
				Name = "userTask",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("24b439dc-4cde-40d6-bbfd-36bcbad9b88b"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				ModifiedInSchemaUId = new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("6da427d3-b6ac-4046-8f8c-ef5b40544ff1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,203,106,195,48,16,60,203,144,127,216,230,100,67,17,189,167,238,37,185,248,82,2,78,123,41,61,40,242,166,81,99,75,70,143,66,104,252,239,213,195,184,46,132,146,219,62,102,118,119,102,197,1,114,97,177,51,80,150,32,93,219,194,229,2,177,64,215,202,73,27,202,15,5,124,47,50,162,209,58,45,87,139,108,88,100,95,76,131,81,78,115,132,18,242,92,72,91,108,181,226,104,76,205,143,216,177,45,211,172,67,139,250,149,181,14,235,136,164,53,215,162,183,5,221,169,218,106,33,63,242,194,15,59,40,141,140,31,33,191,206,135,126,138,132,4,103,80,239,152,57,209,169,111,210,109,194,203,152,144,116,237,71,90,108,42,153,134,189,84,13,220,149,96,98,66,125,230,9,132,120,157,191,140,116,97,60,118,140,3,227,102,73,241,6,194,149,180,66,58,244,170,136,247,136,4,147,166,21,225,136,114,182,209,231,127,141,32,147,19,27,193,173,80,146,233,243,163,137,253,123,80,251,79,228,246,41,126,38,24,17,63,52,174,13,218,243,4,44,66,253,109,89,53,203,247,240,184,249,242,17,76,18,34,157,31,80,227,27,87,179,230,179,39,197,214,117,127,54,194,244,45,59,199,100,78,139,133,127,120,51,194,222,43,61,197,112,72,94,13,63,226,97,150,88,136,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeAdminRightsUserTaskParametersEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba7e27a8-03e4-416f-b1f6-e36db93d7642"));
		}

		#endregion

	}

	#endregion

}

